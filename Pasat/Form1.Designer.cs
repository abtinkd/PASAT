namespace Pasat
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBxLanguage = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.radioBtnBoth = new System.Windows.Forms.RadioButton();
            this.radioBtnPVSAT = new System.Windows.Forms.RadioButton();
            this.radioBtnPASAT = new System.Windows.Forms.RadioButton();
            this.numUpDnResponseTime = new System.Windows.Forms.NumericUpDown();
            this.comboBxQuestionGroup = new System.Windows.Forms.ComboBox();
            this.ChkBxAutomatic = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnResetVolumeMeter = new System.Windows.Forms.Button();
            this.numUpDnSensitivity = new System.Windows.Forms.NumericUpDown();
            this.comboBxSoundCard = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VuMeter = new KA.Audio.VuMeter();
            this.volumeMeter1 = new User.DirectX.DirectSound.VolumeMeter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbxCorrectAnswers = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxQuestionNo = new System.Windows.Forms.TextBox();
            this.tbxSumNo = new System.Windows.Forms.TextBox();
            this.tbxCurrentNo = new System.Windows.Forms.TextBox();
            this.tbxLastNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TimeMeter = new KA.Audio.VuMeter();
            this.btnFalse = new System.Windows.Forms.Button();
            this.btnTrue = new System.Windows.Forms.Button();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxAge = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acceptedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataSet1 = new System.Data.DataSet();
            this.dataTableQuizResults = new System.Data.DataTable();
            this.dataColQuesNo = new System.Data.DataColumn();
            this.dataColNum = new System.Data.DataColumn();
            this.dataColResponseTime = new System.Data.DataColumn();
            this.dataColAccepted = new System.Data.DataColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnResponseTime)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnSensitivity)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableQuizResults)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBxLanguage);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.radioBtnBoth);
            this.groupBox1.Controls.Add(this.radioBtnPVSAT);
            this.groupBox1.Controls.Add(this.radioBtnPASAT);
            this.groupBox1.Controls.Add(this.numUpDnResponseTime);
            this.groupBox1.Controls.Add(this.comboBxQuestionGroup);
            this.groupBox1.Controls.Add(this.ChkBxAutomatic);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 419);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quiz Options";
            // 
            // comboBxLanguage
            // 
            this.comboBxLanguage.FormattingEnabled = true;
            this.comboBxLanguage.Items.AddRange(new object[] {
            "Persian",
            "English",
            "Spanish",
            "French",
            "German",
            "Indian",
            "Italian"});
            this.comboBxLanguage.Location = new System.Drawing.Point(131, 38);
            this.comboBxLanguage.Name = "comboBxLanguage";
            this.comboBxLanguage.Size = new System.Drawing.Size(86, 21);
            this.comboBxLanguage.TabIndex = 14;
            this.comboBxLanguage.Text = "Persian";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Language";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Type:";
            // 
            // radioBtnBoth
            // 
            this.radioBtnBoth.AutoSize = true;
            this.radioBtnBoth.Checked = true;
            this.radioBtnBoth.Location = new System.Drawing.Point(176, 17);
            this.radioBtnBoth.Name = "radioBtnBoth";
            this.radioBtnBoth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioBtnBoth.Size = new System.Drawing.Size(47, 17);
            this.radioBtnBoth.TabIndex = 11;
            this.radioBtnBoth.TabStop = true;
            this.radioBtnBoth.Text = "Both";
            this.radioBtnBoth.UseVisualStyleBackColor = true;
            // 
            // radioBtnPVSAT
            // 
            this.radioBtnPVSAT.AutoSize = true;
            this.radioBtnPVSAT.Location = new System.Drawing.Point(110, 17);
            this.radioBtnPVSAT.Name = "radioBtnPVSAT";
            this.radioBtnPVSAT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioBtnPVSAT.Size = new System.Drawing.Size(60, 17);
            this.radioBtnPVSAT.TabIndex = 10;
            this.radioBtnPVSAT.Text = "PVSAT";
            this.radioBtnPVSAT.UseVisualStyleBackColor = true;
            // 
            // radioBtnPASAT
            // 
            this.radioBtnPASAT.AutoSize = true;
            this.radioBtnPASAT.Location = new System.Drawing.Point(44, 17);
            this.radioBtnPASAT.Name = "radioBtnPASAT";
            this.radioBtnPASAT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioBtnPASAT.Size = new System.Drawing.Size(60, 17);
            this.radioBtnPASAT.TabIndex = 9;
            this.radioBtnPASAT.Text = "PASAT";
            this.radioBtnPASAT.UseVisualStyleBackColor = true;
            // 
            // numUpDnResponseTime
            // 
            this.numUpDnResponseTime.DecimalPlaces = 1;
            this.numUpDnResponseTime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numUpDnResponseTime.Location = new System.Drawing.Point(131, 86);
            this.numUpDnResponseTime.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUpDnResponseTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numUpDnResponseTime.Name = "numUpDnResponseTime";
            this.numUpDnResponseTime.Size = new System.Drawing.Size(41, 20);
            this.numUpDnResponseTime.TabIndex = 7;
            this.numUpDnResponseTime.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // comboBxQuestionGroup
            // 
            this.comboBxQuestionGroup.FormattingEnabled = true;
            this.comboBxQuestionGroup.Items.AddRange(new object[] {
            "1 (61)",
            "2 (61)",
            "3 (61)",
            "4 (61)",
            "5 (120)",
            "6 (120)"});
            this.comboBxQuestionGroup.Location = new System.Drawing.Point(131, 62);
            this.comboBxQuestionGroup.Name = "comboBxQuestionGroup";
            this.comboBxQuestionGroup.Size = new System.Drawing.Size(64, 21);
            this.comboBxQuestionGroup.TabIndex = 6;
            // 
            // ChkBxAutomatic
            // 
            this.ChkBxAutomatic.AutoSize = true;
            this.ChkBxAutomatic.Location = new System.Drawing.Point(6, 114);
            this.ChkBxAutomatic.Name = "ChkBxAutomatic";
            this.ChkBxAutomatic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ChkBxAutomatic.Size = new System.Drawing.Size(104, 17);
            this.ChkBxAutomatic.TabIndex = 8;
            this.ChkBxAutomatic.Text = "Automatic Query";
            this.ChkBxAutomatic.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Response Time Limit (s)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(506, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.saveAsToolStripMenuItem.Text = "&Save As ...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnResetVolumeMeter);
            this.groupBox2.Controls.Add(this.numUpDnSensitivity);
            this.groupBox2.Controls.Add(this.comboBxSoundCard);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.VuMeter);
            this.groupBox2.Controls.Add(this.volumeMeter1);
            this.groupBox2.Location = new System.Drawing.Point(12, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 161);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Volume Options";
            // 
            // btnResetVolumeMeter
            // 
            this.btnResetVolumeMeter.Location = new System.Drawing.Point(79, 138);
            this.btnResetVolumeMeter.Name = "btnResetVolumeMeter";
            this.btnResetVolumeMeter.Size = new System.Drawing.Size(51, 21);
            this.btnResetVolumeMeter.TabIndex = 0;
            this.btnResetVolumeMeter.Text = "Reset";
            this.btnResetVolumeMeter.UseVisualStyleBackColor = true;
            this.btnResetVolumeMeter.Click += new System.EventHandler(this.btnResetVolumeMeter_Click);
            // 
            // numUpDnSensitivity
            // 
            this.numUpDnSensitivity.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpDnSensitivity.Location = new System.Drawing.Point(75, 40);
            this.numUpDnSensitivity.Maximum = new decimal(new int[] {
            320,
            0,
            0,
            0});
            this.numUpDnSensitivity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDnSensitivity.Name = "numUpDnSensitivity";
            this.numUpDnSensitivity.Size = new System.Drawing.Size(48, 20);
            this.numUpDnSensitivity.TabIndex = 5;
            this.numUpDnSensitivity.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // comboBxSoundCard
            // 
            this.comboBxSoundCard.FormattingEnabled = true;
            this.comboBxSoundCard.Location = new System.Drawing.Point(75, 15);
            this.comboBxSoundCard.Name = "comboBxSoundCard";
            this.comboBxSoundCard.Size = new System.Drawing.Size(148, 21);
            this.comboBxSoundCard.TabIndex = 4;
            this.comboBxSoundCard.SelectedIndexChanged += new System.EventHandler(this.comboBxSoundCard_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sensitivity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sound Card";
            // 
            // VuMeter
            // 
            this.VuMeter.AnalogMeter = true;
            this.VuMeter.BackColor = System.Drawing.Color.Transparent;
            this.VuMeter.DialBackground = System.Drawing.Color.Transparent;
            this.VuMeter.DialTextNegative = System.Drawing.Color.Red;
            this.VuMeter.DialTextPositive = System.Drawing.Color.Black;
            this.VuMeter.DialTextZero = System.Drawing.Color.DarkGreen;
            this.VuMeter.Led1ColorOff = System.Drawing.Color.DarkGreen;
            this.VuMeter.Led1ColorOn = System.Drawing.Color.LimeGreen;
            this.VuMeter.Led1Count = 9;
            this.VuMeter.Led2ColorOff = System.Drawing.Color.Olive;
            this.VuMeter.Led2ColorOn = System.Drawing.Color.Yellow;
            this.VuMeter.Led2Count = 7;
            this.VuMeter.Led3ColorOff = System.Drawing.Color.Maroon;
            this.VuMeter.Led3ColorOn = System.Drawing.Color.Red;
            this.VuMeter.Led3Count = 4;
            this.VuMeter.LedSize = new System.Drawing.Size(3, 30);
            this.VuMeter.LedSpace = 2;
            this.VuMeter.Level = 0;
            this.VuMeter.LevelMax = 32768;
            this.VuMeter.Location = new System.Drawing.Point(-11, 50);
            this.VuMeter.MeterScale = KA.Audio.MeterScale.Analog;
            this.VuMeter.Name = "VuMeter";
            this.VuMeter.NeedleColor = System.Drawing.Color.Black;
            this.VuMeter.PeakHold = true;
            this.VuMeter.Peakms = 200;
            this.VuMeter.PeakNeedleColor = System.Drawing.Color.Red;
            this.VuMeter.ShowDialOnly = false;
            this.VuMeter.ShowLedPeak = false;
            this.VuMeter.ShowTextInDial = false;
            this.VuMeter.Size = new System.Drawing.Size(228, 182);
            this.VuMeter.TabIndex = 7;
            this.VuMeter.TextInDial = new string[] {
        "-40",
        "-20",
        "-10",
        "-5",
        "0",
        "+6"};
            this.VuMeter.UseLedLight = true;
            this.VuMeter.VerticalBar = false;
            this.VuMeter.VuText = "0";
            // 
            // volumeMeter1
            // 
            this.volumeMeter1.AutoStart = true;
            this.volumeMeter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.volumeMeter1.FrameDelay = 10;
            this.volumeMeter1.Location = new System.Drawing.Point(6, 91);
            this.volumeMeter1.Name = "volumeMeter1";
            this.volumeMeter1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.volumeMeter1.Padding = new System.Windows.Forms.Padding(8);
            this.volumeMeter1.SampleDelay = 100;
            this.volumeMeter1.SelectedDeviceIndex = -1;
            this.volumeMeter1.SelectedDeviceName = "(none)";
            this.volumeMeter1.Size = new System.Drawing.Size(176, 64);
            this.volumeMeter1.TabIndex = 6;
            this.volumeMeter1.TabStop = false;
            this.volumeMeter1.VisualizerOn = false;
            this.volumeMeter1.VolumeChanged += new User.DirectX.DirectSound.VolumeMeter.VolumeChangedEventHandler(this.volumeMeter1_VolumeChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbxCorrectAnswers);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tbxQuestionNo);
            this.groupBox3.Controls.Add(this.tbxSumNo);
            this.groupBox3.Controls.Add(this.tbxCurrentNo);
            this.groupBox3.Controls.Add(this.tbxLastNo);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.TimeMeter);
            this.groupBox3.Controls.Add(this.btnFalse);
            this.groupBox3.Controls.Add(this.btnTrue);
            this.groupBox3.Controls.Add(this.btnStartStop);
            this.groupBox3.Location = new System.Drawing.Point(12, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 219);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quiz Status";
            // 
            // tbxCorrectAnswers
            // 
            this.tbxCorrectAnswers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbxCorrectAnswers.ForeColor = System.Drawing.Color.White;
            this.tbxCorrectAnswers.Location = new System.Drawing.Point(27, 100);
            this.tbxCorrectAnswers.Name = "tbxCorrectAnswers";
            this.tbxCorrectAnswers.ReadOnly = true;
            this.tbxCorrectAnswers.Size = new System.Drawing.Size(34, 20);
            this.tbxCorrectAnswers.TabIndex = 14;
            this.tbxCorrectAnswers.TabStop = false;
            this.tbxCorrectAnswers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Correct Answers";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Question Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(167, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Sum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Current";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Last";
            // 
            // tbxQuestionNo
            // 
            this.tbxQuestionNo.Location = new System.Drawing.Point(27, 66);
            this.tbxQuestionNo.Name = "tbxQuestionNo";
            this.tbxQuestionNo.ReadOnly = true;
            this.tbxQuestionNo.Size = new System.Drawing.Size(34, 20);
            this.tbxQuestionNo.TabIndex = 8;
            this.tbxQuestionNo.TabStop = false;
            this.tbxQuestionNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxSumNo
            // 
            this.tbxSumNo.BackColor = System.Drawing.Color.Yellow;
            this.tbxSumNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSumNo.Location = new System.Drawing.Point(139, 136);
            this.tbxSumNo.Name = "tbxSumNo";
            this.tbxSumNo.Size = new System.Drawing.Size(84, 53);
            this.tbxSumNo.TabIndex = 7;
            this.tbxSumNo.TabStop = false;
            this.tbxSumNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxCurrentNo
            // 
            this.tbxCurrentNo.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCurrentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCurrentNo.Location = new System.Drawing.Point(74, 136);
            this.tbxCurrentNo.Name = "tbxCurrentNo";
            this.tbxCurrentNo.Size = new System.Drawing.Size(56, 53);
            this.tbxCurrentNo.TabIndex = 6;
            this.tbxCurrentNo.TabStop = false;
            this.tbxCurrentNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxLastNo
            // 
            this.tbxLastNo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbxLastNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLastNo.Location = new System.Drawing.Point(9, 136);
            this.tbxLastNo.Name = "tbxLastNo";
            this.tbxLastNo.Size = new System.Drawing.Size(56, 53);
            this.tbxLastNo.TabIndex = 5;
            this.tbxLastNo.TabStop = false;
            this.tbxLastNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(6, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Time";
            // 
            // TimeMeter
            // 
            this.TimeMeter.AnalogMeter = false;
            this.TimeMeter.DialBackground = System.Drawing.Color.White;
            this.TimeMeter.DialTextNegative = System.Drawing.Color.Red;
            this.TimeMeter.DialTextPositive = System.Drawing.Color.Black;
            this.TimeMeter.DialTextZero = System.Drawing.Color.DarkGreen;
            this.TimeMeter.Led1ColorOff = System.Drawing.Color.DarkGreen;
            this.TimeMeter.Led1ColorOn = System.Drawing.Color.LimeGreen;
            this.TimeMeter.Led1Count = 10;
            this.TimeMeter.Led2ColorOff = System.Drawing.Color.Olive;
            this.TimeMeter.Led2ColorOn = System.Drawing.Color.Yellow;
            this.TimeMeter.Led2Count = 10;
            this.TimeMeter.Led3ColorOff = System.Drawing.Color.Maroon;
            this.TimeMeter.Led3ColorOn = System.Drawing.Color.Red;
            this.TimeMeter.Led3Count = 10;
            this.TimeMeter.LedSize = new System.Drawing.Size(4, 13);
            this.TimeMeter.LedSpace = 2;
            this.TimeMeter.Level = 0;
            this.TimeMeter.LevelMax = 30;
            this.TimeMeter.Location = new System.Drawing.Point(42, 196);
            this.TimeMeter.MeterScale = KA.Audio.MeterScale.Analog;
            this.TimeMeter.Name = "TimeMeter";
            this.TimeMeter.NeedleColor = System.Drawing.Color.Black;
            this.TimeMeter.PeakHold = false;
            this.TimeMeter.Peakms = 1000;
            this.TimeMeter.PeakNeedleColor = System.Drawing.Color.Red;
            this.TimeMeter.ShowDialOnly = false;
            this.TimeMeter.ShowLedPeak = false;
            this.TimeMeter.ShowTextInDial = false;
            this.TimeMeter.Size = new System.Drawing.Size(182, 17);
            this.TimeMeter.TabIndex = 3;
            this.TimeMeter.TextInDial = new string[] {
        "-40",
        "-20",
        "-10",
        "-5",
        "0",
        "+6"};
            this.TimeMeter.UseLedLight = false;
            this.TimeMeter.VerticalBar = false;
            this.TimeMeter.VuText = "VU";
            // 
            // btnFalse
            // 
            this.btnFalse.BackColor = System.Drawing.Color.Transparent;
            this.btnFalse.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFalse.Enabled = false;
            this.btnFalse.Image = global::Pasat.Properties.Resources.False;
            this.btnFalse.Location = new System.Drawing.Point(159, 58);
            this.btnFalse.Name = "btnFalse";
            this.btnFalse.Size = new System.Drawing.Size(64, 60);
            this.btnFalse.TabIndex = 2;
            this.btnFalse.UseVisualStyleBackColor = false;
            this.btnFalse.Click += new System.EventHandler(this.btnFalse_Click);
            // 
            // btnTrue
            // 
            this.btnTrue.BackColor = System.Drawing.Color.Transparent;
            this.btnTrue.Enabled = false;
            this.btnTrue.Image = global::Pasat.Properties.Resources.True;
            this.btnTrue.Location = new System.Drawing.Point(92, 58);
            this.btnTrue.Name = "btnTrue";
            this.btnTrue.Size = new System.Drawing.Size(64, 60);
            this.btnTrue.TabIndex = 1;
            this.btnTrue.UseVisualStyleBackColor = false;
            this.btnTrue.Click += new System.EventHandler(this.btnTrue_Click);
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(6, 19);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(217, 33);
            this.btnStartStop.TabIndex = 0;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.tbxAge);
            this.groupBox4.Controls.Add(this.tbxName);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(247, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(256, 536);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Results";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(197, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Age";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Name";
            // 
            // tbxAge
            // 
            this.tbxAge.ForeColor = System.Drawing.Color.Gray;
            this.tbxAge.Location = new System.Drawing.Point(223, 26);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.Size = new System.Drawing.Size(27, 20);
            this.tbxAge.TabIndex = 2;
            this.tbxAge.Text = "?";
            this.tbxAge.Enter += new System.EventHandler(this.tbxAge_Enter);
            // 
            // tbxName
            // 
            this.tbxName.ForeColor = System.Drawing.Color.Gray;
            this.tbxName.Location = new System.Drawing.Point(38, 26);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(153, 20);
            this.tbxName.TabIndex = 1;
            this.tbxName.Tag = "";
            this.tbxName.Text = "Insert Name";
            this.tbxName.Enter += new System.EventHandler(this.tbxName_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.numberDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.acceptedDataGridViewCheckBoxColumn});
            this.dataGridView1.DataMember = "Quiz Results";
            this.dataGridView1.DataSource = this.dataSet1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(250, 475);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "#";
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.numberDataGridViewTextBoxColumn.Width = 60;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.timeDataGridViewTextBoxColumn.Width = 70;
            // 
            // acceptedDataGridViewCheckBoxColumn
            // 
            this.acceptedDataGridViewCheckBoxColumn.DataPropertyName = "Accepted";
            this.acceptedDataGridViewCheckBoxColumn.HeaderText = "Accepted";
            this.acceptedDataGridViewCheckBoxColumn.Name = "acceptedDataGridViewCheckBoxColumn";
            this.acceptedDataGridViewCheckBoxColumn.Width = 70;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTableQuizResults});
            // 
            // dataTableQuizResults
            // 
            this.dataTableQuizResults.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColQuesNo,
            this.dataColNum,
            this.dataColResponseTime,
            this.dataColAccepted});
            this.dataTableQuizResults.TableName = "Quiz Results";
            // 
            // dataColQuesNo
            // 
            this.dataColQuesNo.ColumnName = "#";
            this.dataColQuesNo.DataType = typeof(int);
            // 
            // dataColNum
            // 
            this.dataColNum.ColumnName = "Number";
            this.dataColNum.DataType = typeof(int);
            // 
            // dataColResponseTime
            // 
            this.dataColResponseTime.ColumnName = "Time";
            this.dataColResponseTime.DataType = typeof(decimal);
            // 
            // dataColAccepted
            // 
            this.dataColAccepted.ColumnName = "Accepted";
            this.dataColAccepted.DataType = typeof(bool);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.AddExtension = false;
            this.saveFileDialog1.RestoreDirectory = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnTrue;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnFalse;
            this.ClientSize = new System.Drawing.Size(506, 575);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PASAT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnResponseTime)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnSensitivity)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableQuizResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown numUpDnResponseTime;
        private System.Windows.Forms.ComboBox comboBxQuestionGroup;
        private System.Windows.Forms.CheckBox ChkBxAutomatic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUpDnSensitivity;
        private System.Windows.Forms.ComboBox comboBxSoundCard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private User.DirectX.DirectSound.VolumeMeter volumeMeter1;
        private KA.Audio.VuMeter VuMeter;
        private KA.Audio.VuMeter TimeMeter;
        private System.Windows.Forms.Button btnFalse;
        private System.Windows.Forms.Button btnTrue;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxSumNo;
        private System.Windows.Forms.TextBox tbxCurrentNo;
        private System.Windows.Forms.TextBox tbxLastNo;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox tbxQuestionNo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnResetVolumeMeter;
        private System.Windows.Forms.Label label9;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dataTableQuizResults;
        private System.Data.DataColumn dataColQuesNo;
        private System.Data.DataColumn dataColNum;
        private System.Data.DataColumn dataColResponseTime;
        private System.Data.DataColumn dataColAccepted;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.TextBox tbxCorrectAnswers;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn acceptedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxAge;
        private System.Windows.Forms.RadioButton radioBtnPASAT;
        private System.Windows.Forms.RadioButton radioBtnBoth;
        private System.Windows.Forms.RadioButton radioBtnPVSAT;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBxLanguage;
        private System.Windows.Forms.Label label14;
    }
}

