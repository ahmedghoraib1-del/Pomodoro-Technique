namespace Pomodoro_Tech
{
    partial class frmPomodoroTechnique
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPomodoroTechnique));
            tcT = new TabControl();
            tpWorkT = new TabPage();
            txtNumofT = new TextBox();
            txtNumofM = new TextBox();
            pbImage = new PictureBox();
            gbworktimer = new GroupBox();
            btnReset = new Button();
            lblRemainingRounds = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            btnStop = new Button();
            btnStart = new Button();
            lblWTimer = new Label();
            label1 = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            tpBreakT = new TabPage();
            btnreturntowork = new Button();
            lblTimeLonge = new Label();
            pictureBox1 = new PictureBox();
            lblBTimer = new Label();
            notifyIcon1 = new NotifyIcon(components);
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            tcT.SuspendLayout();
            tpWorkT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            gbworktimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tpBreakT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tcT
            // 
            tcT.Controls.Add(tpWorkT);
            tcT.Controls.Add(tpBreakT);
            tcT.Location = new Point(2, 2);
            tcT.Name = "tcT";
            tcT.SelectedIndex = 0;
            tcT.Size = new Size(1702, 712);
            tcT.TabIndex = 25;
            // 
            // tpWorkT
            // 
            tpWorkT.BackColor = Color.IndianRed;
            tpWorkT.Controls.Add(txtNumofT);
            tpWorkT.Controls.Add(txtNumofM);
            tpWorkT.Controls.Add(pbImage);
            tpWorkT.Controls.Add(gbworktimer);
            tpWorkT.Controls.Add(label3);
            tpWorkT.Controls.Add(linkLabel1);
            tpWorkT.Controls.Add(label2);
            tpWorkT.ForeColor = Color.Black;
            tpWorkT.Location = new Point(4, 29);
            tpWorkT.Name = "tpWorkT";
            tpWorkT.Padding = new Padding(3);
            tpWorkT.Size = new Size(1694, 679);
            tpWorkT.TabIndex = 0;
            tpWorkT.Text = "Working Time";// 
            // txtNumofT
            // 
            txtNumofT.BackColor = Color.FromArgb(255, 128, 128);
            txtNumofT.Location = new Point(253, 367);
            txtNumofT.Name = "txtNumofT";
            txtNumofT.Size = new Size(201, 27);
            txtNumofT.TabIndex = 0;
            txtNumofT.KeyPress += txtNumofT_KeyPress;
            // 
            // txtNumofM
            // 
            txtNumofM.BackColor = Color.FromArgb(255, 128, 128);
            txtNumofM.Location = new Point(253, 461);
            txtNumofM.Name = "txtNumofM";
            txtNumofM.Size = new Size(201, 27);
            txtNumofM.TabIndex = 1;
            txtNumofM.KeyPress += txtNumofM_KeyPress;
            // 
            // pbImage
            // 
            pbImage.Image = Properties.Resources.sEl4g;
            pbImage.Location = new Point(0, -6);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(1705, 327);
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImage.TabIndex = 25;
            pbImage.TabStop = false;
            // 
            // gbworktimer
            // 
            gbworktimer.Controls.Add(btnReset);
            gbworktimer.Controls.Add(lblRemainingRounds);
            gbworktimer.Controls.Add(label4);
            gbworktimer.Controls.Add(pictureBox2);
            gbworktimer.Controls.Add(btnStop);
            gbworktimer.Controls.Add(btnStart);
            gbworktimer.Controls.Add(lblWTimer);
            gbworktimer.Controls.Add(label1);
            gbworktimer.Location = new Point(525, 327);
            gbworktimer.Name = "gbworktimer";
            gbworktimer.Size = new Size(1106, 353);
            gbworktimer.TabIndex = 24;
            gbworktimer.TabStop = false;
            gbworktimer.Text = "Work Timer";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Crimson;
            btnReset.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(915, 115);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(162, 61);
            btnReset.TabIndex = 15;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // lblRemainingRounds
            // 
            lblRemainingRounds.AutoSize = true;
            lblRemainingRounds.BackColor = Color.DeepPink;
            lblRemainingRounds.BorderStyle = BorderStyle.FixedSingle;
            lblRemainingRounds.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRemainingRounds.Location = new Point(1032, 55);
            lblRemainingRounds.Name = "lblRemainingRounds";
            lblRemainingRounds.Size = new Size(35, 38);
            lblRemainingRounds.TabIndex = 14;
            lblRemainingRounds.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DeepPink;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(713, 55);
            label4.Name = "label4";
            label4.Size = new Size(297, 38);
            label4.TabIndex = 13;
            label4.Text = "Remaining Rounds:";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.HotPink;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(238, 55);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(118, 106);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.Crimson;
            btnStop.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStop.Location = new Point(618, 230);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(222, 86);
            btnStop.TabIndex = 4;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Crimson;
            btnStart.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(312, 230);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(222, 86);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // lblWTimer
            // 
            lblWTimer.AutoSize = true;
            lblWTimer.BackColor = Color.Crimson;
            lblWTimer.BorderStyle = BorderStyle.FixedSingle;
            lblWTimer.Font = new Font("Microsoft Sans Serif", 60F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWTimer.Location = new Point(380, 47);
            lblWTimer.Name = "lblWTimer";
            lblWTimer.Size = new Size(307, 115);
            lblWTimer.TabIndex = 2;
            lblWTimer.Text = "00:00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Crimson;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 77);
            label1.Name = "label1";
            label1.Size = new Size(140, 48);
            label1.TabIndex = 1;
            label1.Text = "Timer:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(-1, 457);
            label3.Name = "label3";
            label3.Size = new Size(231, 31);
            label3.TabIndex = 23;
            label3.Text = "Number of Minutes:";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.HotPink;
            linkLabel1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(6, 629);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(375, 41);
            linkLabel1.TabIndex = 21;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Why Pomodoro Techniqe ?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 361);
            label2.Name = "label2";
            label2.Size = new Size(201, 31);
            label2.TabIndex = 22;
            label2.Text = "Number of Tours:";
            // 
            // tpBreakT
            // 
            tpBreakT.BackColor = Color.LightSeaGreen;
            tpBreakT.Controls.Add(btnreturntowork);
            tpBreakT.Controls.Add(lblTimeLonge);
            tpBreakT.Controls.Add(pictureBox1);
            tpBreakT.Controls.Add(lblBTimer);
            tpBreakT.Location = new Point(4, 29);
            tpBreakT.Name = "tpBreakT";
            tpBreakT.Padding = new Padding(3);
            tpBreakT.Size = new Size(1694, 679);
            tpBreakT.TabIndex = 1;
            tpBreakT.Text = "Break Timer";
            // 
            // btnreturntowork
            // 
            btnreturntowork.BackColor = Color.Crimson;
            btnreturntowork.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnreturntowork.Location = new Point(1072, 439);
            btnreturntowork.Name = "btnreturntowork";
            btnreturntowork.Size = new Size(191, 67);
            btnreturntowork.TabIndex = 16;
            btnreturntowork.Text = "Return to Work =>";
            btnreturntowork.UseVisualStyleBackColor = false;
            btnreturntowork.Click += btnreturntowork_Click;
            // 
            // lblTimeLonge
            // 
            lblTimeLonge.AutoSize = true;
            lblTimeLonge.BackColor = Color.Crimson;
            lblTimeLonge.BorderStyle = BorderStyle.FixedSingle;
            lblTimeLonge.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTimeLonge.Location = new Point(509, 84);
            lblTimeLonge.Name = "lblTimeLonge";
            lblTimeLonge.Size = new Size(617, 93);
            lblTimeLonge.TabIndex = 15;
            lblTimeLonge.Text = "Short Break^_^:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.HotPink;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(432, 267);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // lblBTimer
            // 
            lblBTimer.AutoSize = true;
            lblBTimer.BackColor = Color.Crimson;
            lblBTimer.BorderStyle = BorderStyle.FixedSingle;
            lblBTimer.Font = new Font("Microsoft Sans Serif", 70.2000046F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBTimer.Location = new Point(667, 284);
            lblBTimer.Name = "lblBTimer";
            lblBTimer.Size = new Size(361, 136);
            lblBTimer.TabIndex = 13;
            lblBTimer.Text = "00:00";
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipClicked += notifyIcon1_BalloonTipClicked;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // frmPomodoroTechnique
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.IndianRed;
            ClientSize = new Size(1716, 726);
            Controls.Add(tcT);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmPomodoroTechnique";
            Text = "Pomodore Techniqe";
            Load += frmPomodoroTechnique_Load;
            tcT.ResumeLayout(false);
            tpWorkT.ResumeLayout(false);
            tpWorkT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            gbworktimer.ResumeLayout(false);
            gbworktimer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tpBreakT.ResumeLayout(false);
            tpBreakT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcT;
        private TabPage tpWorkT;
        private TabPage tpBreakT;
        private PictureBox pbImage;
        private GroupBox gbworktimer;
        private Button btnReset;
        private Label lblRemainingRounds;
        private Label label4;
        private PictureBox pictureBox2;
        private Button btnStop;
        private Button btnStart;
        private Label lblWTimer;
        private Label label1;
        private Label label3;
        private LinkLabel linkLabel1;
        private Label label2;
        private NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer1;
        private Button btnreturntowork;
        private Label lblTimeLonge;
        private PictureBox pictureBox1;
        private Label lblBTimer;
        public TextBox txtNumofT;
        public TextBox txtNumofM;
        private System.Windows.Forms.Timer timer2;
    }
}
