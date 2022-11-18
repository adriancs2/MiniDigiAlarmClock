using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Reflection;

namespace DigiClock
{
    public partial class Main : Form
    {
        enum AMPM
        {
            am,
            pm
        }

        bool dragForm = false;
        Point oldFormLocation;
        Point oldCursorLocation;
        string alarmMessage = "";
        SoundPlayer player = new SoundPlayer();
        Stream sound;

        bool _onAlarm = false;
        bool _activateAlarm = false;

        string alarmHour = "00";
        string alarmMinute = "00";
        AMPM _alarmAMPM = AMPM.am;

        string alarmAMPM
        {
            get
            {
                if (_alarmAMPM == AMPM.am)
                    return System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.AMDesignator;
                else
                    return System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.PMDesignator;
            }
        }

        string FullAlarmTimeStr
        {
            get
            {
                return string.Format("{0}:{1} {2}", alarmHour.PadLeft(2, '0'), alarmMinute.PadLeft(2, '0'), alarmAMPM);
            }
        }

        bool OnAlarm
        {
            get
            {
                return _onAlarm;
            }
            set
            {
                _onAlarm = value;
                if (_onAlarm)
                {
                    lbOn.Text = "On";
                    lbOn.ForeColor = Color.Red;
                }
                else
                {
                    lbOn.Text = "Off";
                    lbOn.ForeColor = Color.Gray;
                    ActivateAlarm = false;
                }
            }
        }

        bool ActivateAlarm
        {
            get
            {
                return _activateAlarm;
            }
            set
            {
                _activateAlarm = value;

                if (_activateAlarm)
                {
                    if (!OnAlarm)
                    {
                        _activateAlarm = false;
                        return;
                    }
                    lbAM.Cursor = Cursors.Hand;
                    lbDate.Cursor = Cursors.Hand;
                    lbTime.Cursor = Cursors.Hand;
                    panelMain.Cursor = Cursors.Hand;
                    player.PlayLooping();
                    this.panelMain.BackgroundImage = global::DigiClock.Properties.Resources._2;
                    this.Activate();
                    if (alarmMessage.Trim().Length > 0)
                    {
                        ShowAlarmMessage f = new ShowAlarmMessage();
                        f.textBox1.Text = "Alarm! " + FullAlarmTimeStr + Environment.NewLine + Environment.NewLine + alarmMessage;
                        f.Show();
                    }
                }
                else
                {
                    lbAM.Cursor = Cursors.Default;
                    lbDate.Cursor = Cursors.Default;
                    lbTime.Cursor = Cursors.Default;
                    this.panelMain.Cursor = Cursors.Default;
                    player.Stop();
                    this.panelMain.BackgroundImage = global::DigiClock.Properties.Resources._1;

                }
            }
        }

        bool IsTopMost
        {
            get
            {
                return this.TopMost;
            }
            set
            {
                this.TopMost = value;
                makeClockOnTopOfOtherWindowToolStripMenuItem.Checked = this.TopMost;
            }
        }

        public Main()
        {
            InitializeComponent();
            timerUpdateMainTime_Tick(this, null);
            sound = Assembly.GetAssembly(typeof(Main)).GetManifestResourceStream("DigiClock.alarm.wav");
            player.Stream = sound;
            IsTopMost = false;
            OnAlarm = false;
            ActivateAlarm = false;
            DisplayNewAlarmTime();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            timerLoadForm.Start();
        }

        private void MainInterface_MouseDown(object sender, MouseEventArgs e)
        {
            dragForm = true;
            oldCursorLocation = Cursor.Position;
            oldFormLocation = this.Location;
        }

        private void MainInterface_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragForm)
            {
                int x = oldFormLocation.X + (Cursor.Position.X - oldCursorLocation.X);
                int y = oldFormLocation.Y + (Cursor.Position.Y - oldCursorLocation.Y);

                this.Location = new Point(x, y);
            }
        }

        private void MainInterface_MouseUp(object sender, MouseEventArgs e)
        {
            dragForm = false;
        }

        private void btTurnOff_MouseClick(object sender, MouseEventArgs e)
        {
            timerCloseForm.Start();
        }

        private void lbOn_MouseClick(object sender, MouseEventArgs e)
        {
            OnAlarm = !OnAlarm;
        }

        private void MainInterface_MouseClick(object sender, MouseEventArgs e)
        {
            if (ActivateAlarm)
            {
                OnAlarm = false;
            }

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void timerUpdateMainTime_Tick(object sender, EventArgs e)
        {
            lbAM.Text = DateTime.Now.ToString("tt");
            lbTime.Text = DateTime.Now.ToString("hh:mm:ss");

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(DateTime.Now.ToShortDateString());

            if (!System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern.Contains("ddd"))
            {
                sb.AppendFormat(" ");
                sb.AppendFormat(DateTime.Now.ToString("dddd"));
            }

            if (lbDate.Text != sb.ToString())
            {
                lbDate.Text = sb.ToString();
            }

            if (FullAlarmTimeStr == DateTime.Now.ToString("hh:mm tt"))
            {
                if (OnAlarm)
                {
                    if (!ActivateAlarm)
                    {
                        ActivateAlarm = true;
                    }
                }
            }
        }

        private void timerLoadForm_Tick(object sender, EventArgs e)
        {
            timerLoadForm.Stop();
            timerUpdateMainTime.Stop();

            this.SuspendLayout();
            Opacity = Opacity + 0.1D;
            this.ResumeLayout(true);

            if (Opacity >= 1D)
            {
                timerUpdateMainTime.Start();
            }
            else
            {
                timerLoadForm.Start();
            }
        }

        private void timerCloseForm_Tick(object sender, EventArgs e)
        {
            timerCloseForm.Stop();
            timerUpdateMainTime.Stop();

            this.SuspendLayout();
            Opacity = Opacity - 0.1D;
            this.ResumeLayout(true);

            if (Opacity <= 0D)
            {
                this.Close();
            }
            else
            {
                timerCloseForm.Start();
            }
        }

        private void makeClockOnTopOfOtherWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsTopMost = !IsTopMost;
        }

        private void lbAlarmTime_MouseClick(object sender, MouseEventArgs e)
        {
            SetAlarmTime f = new SetAlarmTime();
            f.txtAlarmMessage.Text = alarmMessage;
            f.txtHour.Text = alarmHour;
            f.txtMinute.Text = alarmMinute;
            f.lbAM.Text = alarmAMPM;
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                alarmHour = f.txtHour.Text;
                alarmMinute = f.txtMinute.Text;
                alarmMessage = f.txtAlarmMessage.Text;
                if (f.lbAM.Text == System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.AMDesignator)
                {
                    _alarmAMPM = AMPM.am;
                }
                else
                    _alarmAMPM = AMPM.pm;

                OnAlarm = true;
                DisplayNewAlarmTime();
            }
        }

        void DisplayNewAlarmTime()
        {
            lbAlarmTime.Text = string.Format("Set Alarm: {0}:{1}", alarmHour.PadLeft(2,'0'), alarmMinute.PadLeft(2,'0'));
            lbAlarmAMPM.Text = alarmAMPM;
        }

    }
}
