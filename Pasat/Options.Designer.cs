namespace Pasat
{
    partial class Options
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numUpDnPlaySoundTime = new System.Windows.Forms.NumericUpDown();
            this.numUpDnUserVoiceTime = new System.Windows.Forms.NumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnPlaySoundTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnUserVoiceTime)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Audio Sound Time (s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "User Voice Time (s)";
            // 
            // numUpDnPlaySoundTime
            // 
            this.numUpDnPlaySoundTime.DecimalPlaces = 1;
            this.numUpDnPlaySoundTime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numUpDnPlaySoundTime.Location = new System.Drawing.Point(119, 13);
            this.numUpDnPlaySoundTime.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUpDnPlaySoundTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numUpDnPlaySoundTime.Name = "numUpDnPlaySoundTime";
            this.numUpDnPlaySoundTime.Size = new System.Drawing.Size(37, 20);
            this.numUpDnPlaySoundTime.TabIndex = 4;
            this.numUpDnPlaySoundTime.Value = new decimal(new int[] {
            6,
            0,
            0,
            65536});
            // 
            // numUpDnUserVoiceTime
            // 
            this.numUpDnUserVoiceTime.DecimalPlaces = 1;
            this.numUpDnUserVoiceTime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numUpDnUserVoiceTime.Location = new System.Drawing.Point(119, 39);
            this.numUpDnUserVoiceTime.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUpDnUserVoiceTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numUpDnUserVoiceTime.Name = "numUpDnUserVoiceTime";
            this.numUpDnUserVoiceTime.Size = new System.Drawing.Size(37, 20);
            this.numUpDnUserVoiceTime.TabIndex = 5;
            this.numUpDnUserVoiceTime.Tag = "";
            this.numUpDnUserVoiceTime.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(12, 89);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(93, 89);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(174, 89);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(75, 23);
            this.btnDefault.TabIndex = 8;
            this.btnDefault.Text = "&Default";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // Options
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(258, 124);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.numUpDnUserVoiceTime);
            this.Controls.Add(this.numUpDnPlaySoundTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Options";
            this.ShowIcon = false;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnPlaySoundTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnUserVoiceTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numUpDnPlaySoundTime;
        private System.Windows.Forms.NumericUpDown numUpDnUserVoiceTime;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDefault;
    }
}