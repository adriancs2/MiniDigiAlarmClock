using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DigiClock
{
    public partial class SetAlarmTime : Form
    {
        public SetAlarmTime()
        {
            InitializeComponent();
            lbAM.Text = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.AMDesignator;
            txtHour.Tag = 12;
            txtMinute.Tag = 59;
            txtHour.LostFocus += txtHourMinuteLostFocus;
            txtMinute.LostFocus += txtHourMinuteLostFocus;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((TextBox)sender).Name == "txtAlarmMessage")
            {
                return;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, false);
                e.Handled = true;
            }
        }

        private void ChangeAMPM_MouseClick(object sender, MouseEventArgs e)
        {
            if (lbAM.Text == System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.AMDesignator)
                lbAM.Text = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.PMDesignator;
            else
                lbAM.Text = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.AMDesignator;
        }

        private void btOk_MouseClick(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        void txtHourMinuteLostFocus(object sender, EventArgs e)
        {
            int a = 99;
            string b = ((TextBox)sender).Text;
            if (int.TryParse(b, out a))
            {

                if (a > (int)((TextBox)sender).Tag)
                {
                    ((TextBox)sender).Text = ((TextBox)sender).Tag + "";
                }
                else if (a < 0)
                {
                    ((TextBox)sender).Text = "0";
                }
            }

            ((TextBox)sender).Text = ((TextBox)sender).Text.PadLeft(2, '0');
        }

    }
}
