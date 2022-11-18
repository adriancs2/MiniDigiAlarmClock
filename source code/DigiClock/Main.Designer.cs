namespace DigiClock
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelMain = new System.Windows.Forms.Panel();
            this.lbAM = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbAlarmTime = new System.Windows.Forms.Label();
            this.lbAlarmAMPM = new System.Windows.Forms.Label();
            this.btTurnOff = new System.Windows.Forms.PictureBox();
            this.lbOn = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.timerUpdateMainTime = new System.Windows.Forms.Timer(this.components);
            this.timerCloseForm = new System.Windows.Forms.Timer(this.components);
            this.timerLoadForm = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.makeClockOnTopOfOtherWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.miniDesktopDigitalAlarmClockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.httpdigialarmclockcodeplexcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freewareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btTurnOff)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackgroundImage = global::DigiClock.Properties.Resources._1;
            this.panelMain.Controls.Add(this.lbAM);
            this.panelMain.Controls.Add(this.flowLayoutPanel1);
            this.panelMain.Controls.Add(this.btTurnOff);
            this.panelMain.Controls.Add(this.lbOn);
            this.panelMain.Controls.Add(this.lbDate);
            this.panelMain.Controls.Add(this.lbTime);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(200, 100);
            this.panelMain.TabIndex = 0;
            this.panelMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainInterface_MouseClick);
            this.panelMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainInterface_MouseDown);
            this.panelMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainInterface_MouseMove);
            this.panelMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainInterface_MouseUp);
            // 
            // lbAM
            // 
            this.lbAM.AutoSize = true;
            this.lbAM.BackColor = System.Drawing.Color.Transparent;
            this.lbAM.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAM.ForeColor = System.Drawing.Color.LawnGreen;
            this.lbAM.Location = new System.Drawing.Point(143, 22);
            this.lbAM.Name = "lbAM";
            this.lbAM.Size = new System.Drawing.Size(38, 25);
            this.lbAM.TabIndex = 8;
            this.lbAM.Text = "AM";
            this.lbAM.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainInterface_MouseClick);
            this.lbAM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainInterface_MouseDown);
            this.lbAM.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainInterface_MouseMove);
            this.lbAM.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainInterface_MouseUp);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.lbAlarmTime);
            this.flowLayoutPanel1.Controls.Add(this.lbAlarmAMPM);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(35, 71);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(160, 22);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // lbAlarmTime
            // 
            this.lbAlarmTime.AutoSize = true;
            this.lbAlarmTime.BackColor = System.Drawing.Color.Transparent;
            this.lbAlarmTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbAlarmTime.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlarmTime.ForeColor = System.Drawing.Color.White;
            this.lbAlarmTime.Location = new System.Drawing.Point(0, 0);
            this.lbAlarmTime.Margin = new System.Windows.Forms.Padding(0);
            this.lbAlarmTime.Name = "lbAlarmTime";
            this.lbAlarmTime.Size = new System.Drawing.Size(99, 20);
            this.lbAlarmTime.TabIndex = 3;
            this.lbAlarmTime.Text = "Set Alarm: 09:00";
            this.lbAlarmTime.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbAlarmTime_MouseClick);
            // 
            // lbAlarmAMPM
            // 
            this.lbAlarmAMPM.AutoSize = true;
            this.lbAlarmAMPM.BackColor = System.Drawing.Color.Transparent;
            this.lbAlarmAMPM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbAlarmAMPM.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlarmAMPM.ForeColor = System.Drawing.Color.LightBlue;
            this.lbAlarmAMPM.Location = new System.Drawing.Point(99, 0);
            this.lbAlarmAMPM.Margin = new System.Windows.Forms.Padding(0);
            this.lbAlarmAMPM.Name = "lbAlarmAMPM";
            this.lbAlarmAMPM.Size = new System.Drawing.Size(27, 20);
            this.lbAlarmAMPM.TabIndex = 4;
            this.lbAlarmAMPM.Text = "AM";
            this.lbAlarmAMPM.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbAlarmTime_MouseClick);
            // 
            // btTurnOff
            // 
            this.btTurnOff.BackColor = System.Drawing.Color.Transparent;
            this.btTurnOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTurnOff.Image = global::DigiClock.Properties.Resources.onoff;
            this.btTurnOff.Location = new System.Drawing.Point(179, 56);
            this.btTurnOff.Margin = new System.Windows.Forms.Padding(0);
            this.btTurnOff.Name = "btTurnOff";
            this.btTurnOff.Size = new System.Drawing.Size(16, 16);
            this.btTurnOff.TabIndex = 11;
            this.btTurnOff.TabStop = false;
            this.btTurnOff.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btTurnOff_MouseClick);
            // 
            // lbOn
            // 
            this.lbOn.AutoSize = true;
            this.lbOn.BackColor = System.Drawing.Color.Transparent;
            this.lbOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbOn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOn.ForeColor = System.Drawing.Color.Red;
            this.lbOn.Location = new System.Drawing.Point(7, 74);
            this.lbOn.Name = "lbOn";
            this.lbOn.Size = new System.Drawing.Size(26, 16);
            this.lbOn.TabIndex = 10;
            this.lbOn.Text = "On";
            this.lbOn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbOn_MouseClick);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.BackColor = System.Drawing.Color.Transparent;
            this.lbDate.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.LawnGreen;
            this.lbDate.Location = new System.Drawing.Point(14, 50);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(57, 20);
            this.lbDate.TabIndex = 9;
            this.lbDate.Text = "00:00:00";
            this.lbDate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainInterface_MouseClick);
            this.lbDate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainInterface_MouseDown);
            this.lbDate.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainInterface_MouseMove);
            this.lbDate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainInterface_MouseUp);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.Transparent;
            this.lbTime.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.LawnGreen;
            this.lbTime.Location = new System.Drawing.Point(10, 8);
            this.lbTime.Margin = new System.Windows.Forms.Padding(0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(137, 43);
            this.lbTime.TabIndex = 7;
            this.lbTime.Text = "00:00:00";
            this.lbTime.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainInterface_MouseClick);
            this.lbTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainInterface_MouseDown);
            this.lbTime.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainInterface_MouseMove);
            this.lbTime.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainInterface_MouseUp);
            // 
            // timerUpdateMainTime
            // 
            this.timerUpdateMainTime.Tick += new System.EventHandler(this.timerUpdateMainTime_Tick);
            // 
            // timerCloseForm
            // 
            this.timerCloseForm.Interval = 15;
            this.timerCloseForm.Tick += new System.EventHandler(this.timerCloseForm_Tick);
            // 
            // timerLoadForm
            // 
            this.timerLoadForm.Interval = 25;
            this.timerLoadForm.Tick += new System.EventHandler(this.timerLoadForm_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeClockOnTopOfOtherWindowToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem,
            this.toolStripSeparator2,
            this.miniDesktopDigitalAlarmClockToolStripMenuItem,
            this.httpdigialarmclockcodeplexcomToolStripMenuItem,
            this.freewareToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(274, 148);
            this.contextMenuStrip1.Text = "Option";
            // 
            // makeClockOnTopOfOtherWindowToolStripMenuItem
            // 
            this.makeClockOnTopOfOtherWindowToolStripMenuItem.Name = "makeClockOnTopOfOtherWindowToolStripMenuItem";
            this.makeClockOnTopOfOtherWindowToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.makeClockOnTopOfOtherWindowToolStripMenuItem.Text = "Make clock on top of other window.";
            this.makeClockOnTopOfOtherWindowToolStripMenuItem.Click += new System.EventHandler(this.makeClockOnTopOfOtherWindowToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(270, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Enabled = false;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(270, 6);
            // 
            // miniDesktopDigitalAlarmClockToolStripMenuItem
            // 
            this.miniDesktopDigitalAlarmClockToolStripMenuItem.Enabled = false;
            this.miniDesktopDigitalAlarmClockToolStripMenuItem.Name = "miniDesktopDigitalAlarmClockToolStripMenuItem";
            this.miniDesktopDigitalAlarmClockToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.miniDesktopDigitalAlarmClockToolStripMenuItem.Text = "Mini Desktop Digital Alarm Clock v1.2";
            // 
            // httpdigialarmclockcodeplexcomToolStripMenuItem
            // 
            this.httpdigialarmclockcodeplexcomToolStripMenuItem.Enabled = false;
            this.httpdigialarmclockcodeplexcomToolStripMenuItem.Name = "httpdigialarmclockcodeplexcomToolStripMenuItem";
            this.httpdigialarmclockcodeplexcomToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.httpdigialarmclockcodeplexcomToolStripMenuItem.Text = "http://digialarmclock.codeplex.com";
            // 
            // freewareToolStripMenuItem
            // 
            this.freewareToolStripMenuItem.Enabled = false;
            this.freewareToolStripMenuItem.Name = "freewareToolStripMenuItem";
            this.freewareToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.freewareToolStripMenuItem.Text = "Freeware";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(221, 125);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini Desktop Digital Alarm Clock";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btTurnOff)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbAlarmTime;
        private System.Windows.Forms.Label lbAlarmAMPM;
        private System.Windows.Forms.PictureBox btTurnOff;
        private System.Windows.Forms.Label lbOn;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbAM;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer timerUpdateMainTime;
        private System.Windows.Forms.Timer timerCloseForm;
        private System.Windows.Forms.Timer timerLoadForm;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem makeClockOnTopOfOtherWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem miniDesktopDigitalAlarmClockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem httpdigialarmclockcodeplexcomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freewareToolStripMenuItem;
    }
}