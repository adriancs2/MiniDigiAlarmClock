using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DigiClock
{
    public partial class ShowAlarmMessage : Form
    {
        public ShowAlarmMessage()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            textBox1.Select(0, 0);
        }
    }
}
