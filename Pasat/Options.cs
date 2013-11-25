using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pasat
{
    public partial class Options : Form
    {
        decimal defaultValue1,defaultValue2,
            oldvalue1, oldvalue2;

        public Options()
        {
            InitializeComponent();

            defaultValue1 = numUpDnPlaySoundTime.Value;
            defaultValue2 = numUpDnUserVoiceTime.Value;
        }

        private void Options_Load(object sender, EventArgs e)
        {
            oldvalue1 = numUpDnPlaySoundTime.Value;
            oldvalue2 = numUpDnUserVoiceTime.Value;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            numUpDnPlaySoundTime.Value = oldvalue1;
            numUpDnUserVoiceTime.Value = oldvalue2;
            this.Close();
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            numUpDnPlaySoundTime.Value = defaultValue1;
            numUpDnUserVoiceTime.Value = defaultValue2;
        }

        public int returnnumUpDnPlaySoundTime()
        {
            return decimal.ToInt32(numUpDnPlaySoundTime.Value * 10);
        }

        public int returnnumUpDnUserVoiceTime()
        {
            return decimal.ToInt32(numUpDnUserVoiceTime.Value * 10);
        }

    }
}