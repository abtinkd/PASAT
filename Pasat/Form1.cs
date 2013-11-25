using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;

namespace Pasat
{
    public partial class Form1 : Form
    {
        Monitor PasatMonitorwindow;
        AboutBox aboutWindow;
        Options optionsWindow;
        int ResponseClock, UserVoiceClock, AudioDelayClock, QuestionNo;
        System.Media.SoundPlayer audioPlayer;
        DataRow QuizState;
        bool thresholdPassed;
        int[,] QSeri;

        //Excel
        Excel.Application objApp;
        Excel._Workbook objBook;

        //
        int WaitTimeToPlayAudioFiles,
            WaitTimeToGetUserVoice;

        public Form1()
        {
            InitializeComponent();

            // InInitialize
            audioPlayer = new System.Media.SoundPlayer();
            QuizState = dataTableQuizResults.NewRow();
            WaitTimeToPlayAudioFiles = 6;
            WaitTimeToGetUserVoice = 10;

            // Create Question Series -- 4 collection of 60 numbers & 2 collection of 120 numbers
            QSeri = new int[,]{
            {1,4,8,1,5,1,3,7,2,6,9,4,7,3,5,3,6,8,2,5,1,5,4,6,3,8,1,7,4,9,3,7,2,6,9,5,2,4,8,3,1,8,5,7,1,8,2,4,9,7,9,3,1,5,7,4,8,1,3,8,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            {4,3,7,2,5,1,8,6,9,1,7,9,4,6,3,5,8,1,6,2,7,5,9,4,5,2,6,4,8,3,5,9,7,4,2,8,5,2,1,6,4,7,3,5,9,6,4,5,3,9,4,1,8,3,1,6,8,5,4,2,6,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            {2,7,5,8,2,6,9,4,1,3,6,3,6,2,8,4,9,1,6,7,2,4,1,5,7,3,9,7,2,6,8,4,2,5,8,5,9,3,7,1,4,2,4,3,6,1,7,3,8,3,9,1,3,5,2,6,4,9,7,1,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            {7,8,6,3,7,5,9,1,2,6,8,3,6,2,5,9,7,1,8,3,6,7,4,2,5,3,8,6,2,3,7,3,5,2,8,5,3,7,4,1,5,2,4,1,6,3,9,7,1,8,4,6,2,5,8,1,9,7,2,8,3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            {1,4,1,5,9,2,6,5,3,5,8,9,7,9,3,2,3,8,4,6,2,6,4,3,3,8,3,2,7,9,5,2,8,8,4,1,9,7,1,6,9,3,9,9,3,7,5,1,5,8,2,9,7,4,9,4,4,5,9,2,3,7,8,1,6,4,6,2,8,6,2,8,9,9,8,6,2,8,3,4,8,2,5,3,4,2,1,1,7,6,7,9,8,2,1,4,8,8,6,5,1,3,2,8,2,3,6,6,4,7,9,3,8,4,4,6,9,5,5,5},
            {8,2,2,3,1,7,2,5,3,5,9,4,8,1,2,8,4,8,1,1,1,7,4,5,2,8,4,1,2,7,1,9,3,8,5,2,1,1,5,5,5,9,6,4,4,6,2,2,9,4,8,9,5,4,9,3,3,8,1,9,6,4,4,2,8,8,1,9,7,5,6,6,5,9,3,3,4,4,6,1,2,8,4,7,5,6,4,8,2,3,3,7,8,6,7,8,3,1,6,5,2,7,1,2,1,9,9,1,4,5,6,4,8,5,6,6,9,2,3,4}};
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBxSoundCard.DataSource = volumeMeter1.DeviceNames;
            comboBxQuestionGroup.SelectedIndex = 0;

            PasatMonitorwindow = new Monitor();
            PasatMonitorwindow.Show();
        }

        private void comboBxSoundCard_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                volumeMeter1.SelectedDeviceIndex = comboBxSoundCard.SelectedIndex;
            }
            catch
            {
                MessageBox.Show("Please connect a microphone.\n", "Audio Input Problem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void volumeMeter1_VolumeChanged(User.DirectX.DirectSound.VolumeChangedEventArgs vcea)
        {
            int midChannelVol = (vcea.NewRight + vcea.NewLeft) / 2;
            VuMeter.Level = midChannelVol;

            int maxVol = midChannelVol / 100;
            if (maxVol >= Int32.Parse(VuMeter.VuText))
                VuMeter.VuText = maxVol.ToString();

            if (midChannelVol >= numUpDnSensitivity.Value * 100)
                if (!thresholdPassed && btnStartStop.Text == "Stop")
                {
                    if (!ChkBxAutomatic.Checked)
                        timer1.Stop();

                    thresholdPassed = true;
                }
        }

        private void btnResetVolumeMeter_Click(object sender, EventArgs e)
        {
            VuMeter.VuText = "0";
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            switch (btnStartStop.Text)
            {
                case "Start":
                    
                    if (PasatMonitorwindow.IsDisposed )
                    {
                        PasatMonitorwindow = new Monitor();
                        PasatMonitorwindow.Show();
                    }
                    QuestionNo = -1;
                    groupBox1.Enabled = groupBox1.Enabled = groupBox2.Enabled = false;
                    btnStartStop.Text = "Stop";
                    tbxName.ReadOnly = tbxAge.ReadOnly = true;
                    tbxCurrentNo.Text = "0";
                    tbxCorrectAnswers.Text = "0";
                    thresholdPassed = false;
                    saveAsToolStripMenuItem.Enabled = false;
                    dataTableQuizResults.Clear();
                    btnTrue.Select();
                    playNextNo();
                    break;

                case "Stop":
                    timer1.Stop();
                    groupBox1.Enabled = groupBox1.Enabled = groupBox2.Enabled = true;
                    btnTrue.Enabled = btnFalse.Enabled = false;
                    tbxName.ReadOnly = tbxAge.ReadOnly = false;
                    btnStartStop.Text = "Start";
                    tbxLastNo.Text = tbxSumNo.Text = tbxCurrentNo.Text = null;
                    if ( !PasatMonitorwindow.IsDisposed )
                        PasatMonitorwindow.Controls["lblMonitorNo"].Text = "0";
                    TimeMeter.Level = 0;
                    saveAsToolStripMenuItem.Enabled = true;
                    reportQuiz();
                    break;
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AudioDelayClock++;

            if (AudioDelayClock == WaitTimeToPlayAudioFiles)
            {
                try
                {
                    volumeMeter1.Start();
                }
                catch
                {
                    timer1.Stop();
                    MessageBox.Show("Microphone is not connected.", "Audio Input Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                if (!ChkBxAutomatic.Checked)
                    btnTrue.Enabled = btnFalse.Enabled = true;
            }

            // !threasholdPassed is here for Automatic Query
            if (AudioDelayClock >= WaitTimeToPlayAudioFiles && !thresholdPassed)
                ResponseClock++;

            TimeMeter.Level = (int) (ResponseClock * 3 / numUpDnResponseTime.Value);
            if (ResponseClock == numUpDnResponseTime.Value * 10)
                btnFalse_Click(sender, e);

            // For Automatic Query
            if (thresholdPassed)
                UserVoiceClock++;
            if ( UserVoiceClock == WaitTimeToGetUserVoice )
                btnFalse_Click(sender, e);
        }

        private void btnTrue_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            QuizState[dataColQuesNo] = QuestionNo + 1;
            QuizState[dataColNum] = Int32.Parse(tbxCurrentNo.Text);
            QuizState[dataColResponseTime] = (decimal)ResponseClock / 10;
            QuizState[dataColAccepted] = true;
            dataTableQuizResults.Rows.Add(QuizState);
            QuizState = dataTableQuizResults.NewRow();
            playNextNo();
        }

        private void btnFalse_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            QuizState[dataColQuesNo] = QuestionNo + 1;
            QuizState[dataColNum] = Int32.Parse(tbxCurrentNo.Text);
            QuizState[dataColResponseTime] = (decimal)ResponseClock / 10;
            QuizState[dataColAccepted] = false;
            dataTableQuizResults.Rows.Add(QuizState);
            QuizState = dataTableQuizResults.NewRow();
            btnTrue.Select();
            playNextNo();
        }
        
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dataGridView1[3, dataGridView1.RowCount - 1].Value.ToString() == "True")
                dataGridView1[3, dataGridView1.RowCount - 1].Style.BackColor = Color.Green;
            else
                dataGridView1[3, dataGridView1.RowCount - 1].Style.BackColor = Color.Red;

            tbxCorrectAnswers.Text = dataTableQuizResults.Compute("Count(Accepted)", "Accepted = TRUE").ToString();
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
                if (dataGridView1.CurrentCell.Value.ToString() == "True")
                    dataGridView1.CurrentCell.Style.BackColor = Color.Green;
                else
                    dataGridView1.CurrentCell.Style.BackColor = Color.Red;

            tbxCorrectAnswers.Text = dataTableQuizResults.Compute("Count(Accepted)", "Accepted = TRUE").ToString();
        }
        
        private void playNextNo()
        {
            VuMeter.VuText = "0";
            QuestionNo++;
            if (QuestionNo>QSeri.GetUpperBound(1) || QSeri[comboBxQuestionGroup.SelectedIndex, QuestionNo]==0)
            {
                btnStartStop.PerformClick();
                return;
            }
            ResponseClock = AudioDelayClock = UserVoiceClock = 0;
            btnTrue.Enabled = btnFalse.Enabled = false;

            try
            {
                volumeMeter1.Stop();
            }
            catch { }
            
            thresholdPassed = false;
            timer1.Start();

            if (radioBtnPVSAT.Checked)
            {
                if (PasatMonitorwindow.IsDisposed)
                {
                    PasatMonitorwindow = new Monitor();
                    PasatMonitorwindow.Show();
                }
                PasatMonitorwindow.Controls["lblMonitorNo"].Text = QSeri[comboBxQuestionGroup.SelectedIndex, QuestionNo].ToString();
            }
            if (radioBtnBoth.Checked)
            {
                if (!PasatMonitorwindow.IsDisposed)
                    PasatMonitorwindow.Controls["lblMonitorNo"].Text = QSeri[comboBxQuestionGroup.SelectedIndex, QuestionNo].ToString();
            }
            if (!radioBtnPVSAT.Checked)
            {
                audioPlayer.SoundLocation = "Lan\\" + comboBxLanguage.Text + "\\" + QSeri[comboBxQuestionGroup.SelectedIndex, QuestionNo].ToString() + ".wav";
                audioPlayer.Play();
            }

            tbxQuestionNo.Text = (QuestionNo+1).ToString();            
            tbxLastNo.Text = tbxCurrentNo.Text;
            tbxCurrentNo.Text = QSeri[comboBxQuestionGroup.SelectedIndex, QuestionNo].ToString();
            tbxSumNo.Text = (Int32.Parse(tbxLastNo.Text) + QSeri[comboBxQuestionGroup.SelectedIndex, QuestionNo]).ToString();
        }

        private void reportQuiz()
        {
            Excel.Workbooks objBooks;
            Excel.Sheets objSheets;
            Excel._Worksheet objSheet;
            StreamWriter streamWritertxt;

            string MeanTime = MeanResponseTime().ToString();
            string MeanTrueTime = MeanTrueAnswersResponseTime().ToString();
            string MeanFalseTime = MeanFalseAnswersResponseTime().ToString();

            if (dataTableQuizResults.Rows.Count != 0)
            {
                dataTableQuizResults.Rows[0]["Time"] = DBNull.Value;
                dataTableQuizResults.Rows[0]["Accepted"] = DBNull.Value;
                dataGridView1[3, 0].Style.BackColor = Color.White;
            }
            dataGridView1.EndEdit();
            btnStartStop.Select(); // I did this to change control to s.th other than datagridview to have my changes accepted
            tbxCorrectAnswers.Text = dataTableQuizResults.Compute("Count(Accepted)", "Accepted = TRUE").ToString();

            // Set saveFileDialog1 Properties
            saveFileDialog1.Filter = "Both Excel and Text Files (*.xls;*.txt)|*.*|Excel Files (*.xls)|*.*|Text Files (*.txt)|*.*";
            saveFileDialog1.FilterIndex = 1;

            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (saveFileDialog1.FilterIndex != 3)
                    {
                        // Instantiate Excel and start a new workbook.
                        System.Globalization.CultureInfo oldCI = System.Threading.Thread.CurrentThread.CurrentCulture;
                        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                        objApp = new Excel.Application();
                        objBooks = objApp.Workbooks;
                        objBook = objBooks.Add(Missing.Value);
                        objSheets = objBook.Worksheets;
                        objSheet = (Excel._Worksheet)objSheets.get_Item(1);
                        
                        //Quiz Properties 
                        objSheet.Cells[1, 6] = "Quiz Type";
                        if (radioBtnBoth.Checked)
                            objSheet.Cells[1, 7] = "Both";
                        else if (radioBtnPASAT.Checked)
                            objSheet.Cells[1, 7] = "PASAT";
                        else
                            objSheet.Cells[1, 7] = "PVSAT";                         
                        objSheet.Cells[2, 6] = "Response Time Limit";
                        objSheet.Cells[2, 7] = numUpDnResponseTime.Value.ToString();
                        objSheet.Cells[3, 6] = "Automatic Query";
                        objSheet.Cells[3, 7] = ChkBxAutomatic.Checked.ToString();

                        // Patient's identification
                        objSheet.Cells[5, 6] = "Name";
                        objSheet.Cells[5, 7] = tbxName.Text;
                        objSheet.Cells[6, 6] = "Age";
                        objSheet.Cells[6, 7] = tbxAge.Text;

                        //Quiz Summary
                        objSheet.Cells[8, 6] = "Number of Correct Answers";
                        objSheet.Cells[8, 7] = tbxCorrectAnswers.Text;                        
                        objSheet.Cells[9, 6] = "Total Mean Time";
                        objSheet.Cells[9, 7] = MeanTime;
                        objSheet.Cells[10, 6] = "Correct Answers Mean Time";
                        objSheet.Cells[10, 7] = MeanTrueTime;
                        objSheet.Cells[11, 6] = "Incorrect Answers Mean Time";
                        objSheet.Cells[11, 7] = MeanFalseTime;                       
                        
                        // Fill Column Headers
                        objSheet.Cells[1, 1] = dataTableQuizResults.Columns[0].ColumnName;
                        objSheet.Cells[1, 2] = dataTableQuizResults.Columns[1].ColumnName;
                        objSheet.Cells[1, 3] = dataTableQuizResults.Columns[2].ColumnName;
                        objSheet.Cells[1, 4] = dataTableQuizResults.Columns[3].ColumnName;

                        // Fill other Fields 
                        for (int iRow = 0; iRow < dataTableQuizResults.Rows.Count; iRow++)
                            for (int iCol = 0; iCol < dataTableQuizResults.Columns.Count; iCol++)
                                objSheet.Cells[iRow + 2, iCol + 1] = dataTableQuizResults.Rows[iRow][iCol].ToString();
                        
                        objSheet.Columns.AutoFit();

                        // Save Excel WorkBook
                        objBook.SaveAs(@saveFileDialog1.FileName + ".xls" , Excel.XlFileFormat.xlWorkbookNormal, Missing.Value,
                        Missing.Value, false, false, Excel.XlSaveAsAccessMode.xlNoChange, Missing.Value,
                        Missing.Value, Missing.Value, Missing.Value, Missing.Value);
                        objApp.Quit();
                        System.Threading.Thread.CurrentThread.CurrentCulture = oldCI;
                    }

                    if (saveFileDialog1.FilterIndex != 2)
                    {
                        // Instantiate File Stream
                        streamWritertxt = File.CreateText(@saveFileDialog1.FileName + ".txt" );

                        // Write Quiz Properties
                        streamWritertxt.WriteLine("Quiz Properties:");
                        if (radioBtnBoth.Checked)
                            streamWritertxt.WriteLine("Quiz Type\t" + "Both");
                        else if (radioBtnPASAT.Checked)
                            streamWritertxt.WriteLine("Quiz Type\t" + "PASAT");
                        else
                            streamWritertxt.WriteLine("Quiz Type\t" + "PVSAT");
                        streamWritertxt.WriteLine("Response Time Limit\t" + numUpDnResponseTime.Value.ToString());
                        streamWritertxt.WriteLine("Automatic Query\t" + ChkBxAutomatic.Checked.ToString());
                        streamWritertxt.WriteLine("---------------------------------------------------------");
                        streamWritertxt.WriteLine();

                        // Patient's identification
                        streamWritertxt.WriteLine("Name\t" + tbxName.Text);
                        streamWritertxt.WriteLine("Age\t" + tbxAge.Text);
                        streamWritertxt.WriteLine();

                        // //Quiz Summary 
                        streamWritertxt.WriteLine("Number of Correct Answers\t" + tbxCorrectAnswers.Text);
                        streamWritertxt.WriteLine("Total Mean Time\t" + MeanTime);
                        streamWritertxt.WriteLine("Correct Answers Mean Time\t" + MeanTrueTime);
                        streamWritertxt.WriteLine("Incorrect Answers Mean Time\t" + MeanFalseTime);
                        streamWritertxt.WriteLine();

                        // Write Column Headers
                        streamWritertxt.WriteLine(dataTableQuizResults.Columns[0].ColumnName + "\t" +
                            dataTableQuizResults.Columns[1].ColumnName + "\t" + dataTableQuizResults.Columns[2].ColumnName +
                            "\t" + dataTableQuizResults.Columns[3].ColumnName);

                        // Fill other Fields 
                        for (int iRow = 0; iRow < dataTableQuizResults.Rows.Count; iRow++)
                        {
                            for (int iCol = 0; iCol < dataTableQuizResults.Columns.Count; iCol++)
                                streamWritertxt.Write(dataTableQuizResults.Rows[iRow][iCol].ToString() + "\t");
                            streamWritertxt.WriteLine();
                        }

                        // Save Text File
                        streamWritertxt.Close();
                    }
                }
            }

            catch (Exception theException)
            {
                String errorMessage;
                errorMessage = "Error: ";
                errorMessage = String.Concat(errorMessage, theException.Message);
                errorMessage = String.Concat(errorMessage, " Line: ");
                errorMessage = String.Concat(errorMessage, theException.Source);

                MessageBox.Show(errorMessage, "Error");
            }
        }

        float MeanResponseTime()
        {
            float sum = 0;
            for (int i = 1; i < dataTableQuizResults.Rows.Count; ++i)
            {
                sum += float.Parse(dataTableQuizResults.Rows[i]["Time"].ToString());
            }
            return sum / (dataTableQuizResults.Rows.Count -1 ); // -1 is for first question
        }

        float MeanTrueAnswersResponseTime()
        {
            float sum = 0;
            int trueCount = 0;
            for (int i = 1; i < dataTableQuizResults.Rows.Count; ++i)
                if (dataTableQuizResults.Rows[i]["Accepted"].ToString() == "True")
                {
                    trueCount++;
                    sum += float.Parse(dataTableQuizResults.Rows[i]["Time"].ToString());
                }
            return sum / trueCount;
        }

        float MeanFalseAnswersResponseTime()
        {
            float sum = 0;
            int falseCount = 0;
            for (int i = 1; i < dataTableQuizResults.Rows.Count; ++i)
                if (dataTableQuizResults.Rows[i]["Accepted"].ToString() == "False")
                {
                    falseCount++;
                    sum += float.Parse(dataTableQuizResults.Rows[i]["Time"].ToString());
                }
            return sum / falseCount;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (optionsWindow == null)
                optionsWindow = new Options();
            optionsWindow.Controls["numUpDnPlaySoundTime"].Text = (WaitTimeToPlayAudioFiles/10.0).ToString();
            optionsWindow.Controls["numUpDnUserVoiceTime"].Text = (WaitTimeToGetUserVoice/10.0).ToString();
            optionsWindow.ShowDialog();
            WaitTimeToPlayAudioFiles = optionsWindow.returnnumUpDnPlaySoundTime();
            WaitTimeToGetUserVoice = optionsWindow.returnnumUpDnUserVoiceTime();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutWindow = new AboutBox();
            aboutWindow.ShowDialog();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportQuiz();
        }

        private void tbxName_Enter(object sender, EventArgs e)
        {
            if (tbxName.Text == "Insert Name")
            {
                tbxName.Text = "";
                tbxName.ForeColor = Color.Black;
            }
        }

        private void tbxAge_Enter(object sender, EventArgs e)
        {
            if (tbxAge.Text == "?")
            {
                tbxAge.Text = "";
                tbxAge.ForeColor = Color.Black;
            }
        }
    }
}