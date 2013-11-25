namespace Pasat
{
    partial class Monitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Monitor));
            this.lblMonitorNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMonitorNo
            // 
            this.lblMonitorNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMonitorNo.AutoSize = true;
            this.lblMonitorNo.Font = new System.Drawing.Font("Arial", 400F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonitorNo.Location = new System.Drawing.Point(42, -33);
            this.lblMonitorNo.Name = "lblMonitorNo";
            this.lblMonitorNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMonitorNo.Size = new System.Drawing.Size(547, 596);
            this.lblMonitorNo.TabIndex = 0;
            this.lblMonitorNo.Text = "0";
            this.lblMonitorNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 514);
            this.Controls.Add(this.lblMonitorNo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Monitor";
            this.Text = "PASAT Monitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMonitorNo;
    }
}