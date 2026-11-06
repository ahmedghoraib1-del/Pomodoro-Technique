using System.Diagnostics.Metrics;
using System;
//using CommunityToolkit.WinUI.Notifications;

namespace Pomodoro_Tech
{
    public partial class frmPomodoroTechnique : Form
    {
        private int _Counter;
        private int _Minutes = 0;

        private int _Toures = 0;
        private int _RemainingSecond = 0;

        private string _BreakLength = "";
        public delegate void MyEvent();

        private event MyEvent WorkTimeFinished;

        public frmPomodoroTechnique()
        {
            InitializeComponent();
            WorkTimeFinished += StartBreak;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNumofM.Text) || string.IsNullOrEmpty(txtNumofT.Text) ||
                int.Parse(txtNumofT.Text) < 1 || int.Parse(txtNumofM.Text) < 1)
            {
                MessageBox.Show("Please enter the count of Minutes and Tours 😊", "Pomodoro Timer Warning", MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
            }
            else
            {
                //here fix how you wanna lblremainingrounds appear OK.

                _Toures = int.Parse(txtNumofT.Text);
                //lblRemainingRounds.Text = txtNumofT.Text.ToString();
                lblRemainingRounds.Text = _Toures.ToString();
                timer1.Start();
                txtNumofT.Enabled = false;
                txtNumofM.Enabled = false;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //if (int.TryParse(txtNumofM.Text, out int NOFM) && Minutes != NOFM && 
            //    int.TryParse(txtNumofT.Text, out int NOFT) &&  NOFT < 0)
            //{
            //    for (int Min = Minutes; Min != NOFM; Min++)
            //    {
            //        _Counter = 0;
            //        for (int Count = _Counter; Count != 60; _Counter++)
            //        {
            //            lblTimer.Text = Min + ":" + _Counter;
            //        }

            //        NOFT--;
            //    }



            //    //    _Counter++;
            //    //lblTimer.Text = _Counter.ToString();
            //}
            //else
            //{
            //    return;
            //}



            _Counter++;


            if (_Counter == 60)
            {
                _Counter = 0;

                _Minutes++;

                if (int.TryParse(txtNumofM.Text, out int NOFM) && _Minutes == NOFM)
                {
                    timer1.Stop();
                    WorkTimeFinished?.Invoke();

                    _Toures--;
                    if (_Toures == 0)
                    {
                        _BreakLength = "Long";
                        lblRemainingRounds.Text = _Toures.ToString();
                        _Reset();
                        return;
                    }
                    //lblRemainingRounds.Text = _Toures.ToString();
                    btnStart.Text = "Countinue";
                    _BreakLength = "Short";

                    _Minutes = 0;

                }

            }

            lblWTimer.Text = $"{_Minutes:D2}:{_Counter:D2}";

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmWhyPT frm = new frmWhyPT();
            frm.ShowDialog();
        }

        private void frmPomodoroTechnique_Load(object sender, EventArgs e)
        {
            tpBreakT.Enabled = false;
        }



        private void StartBreak()
        {
            ShowNotification("Breake Time 🎶", "It's Time to take rest for 5 Minutes (Click Here)");

        }

        private void ShowNotification(string Title, string Massege)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = Title;
            notifyIcon1.BalloonTipText = Massege;
            notifyIcon1.ShowBalloonTip(1000);

        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();


            tpBreakT.Enabled = true;
            tpWorkT.Enabled = false;

            tcT.SelectedTab = tpBreakT;
     
            timer2.Start();
            //tpBreakT.Focus();
            //tpBreakT.FindForm().Focus();
            // tpBreakT.Show();
            //frmShowBreakTimer frm = new frmShowBreakTimer(_BreakLength);
            //frm.ShowDialog();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _Reset();
        }

        private void _Reset()
        {
            txtNumofM.Enabled = true;
            txtNumofT.Enabled = true;

            txtNumofM.Text = null;
            txtNumofT.Text = null;

            timer1.Stop();
            _Counter = 0;
            _Minutes = 0;

            btnStart.Text = "Start";

            lblWTimer.Text = "00:00";

            lblRemainingRounds.Text = "0";
        }

        private void txtNumofT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || e.KeyChar == '0')
            {
                e.Handled = true;
            }
        }

        private void txtNumofM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || e.KeyChar == '0')
            {
                e.Handled = true;
            }
        }

        private void btnreturntowork_Click(object sender, EventArgs e)
        {
            tpWorkT.Focus();
            tpBreakT.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblTimeLonge.Text = _BreakLength == "Short" ? "Short Break^_^" : "Long Break^_~";

            //byte BreakTime = _BreakLength == "short" ? (byte)1 : (byte)2;
            int BreakTime = _BreakLength == "Short" ? 1 : 2;

            btnreturntowork.Visible = false;
            _Counter++;
            lblBTimer.Text = $"{_Minutes:D2}:{_Counter:D2}";

            if (_Counter == 60)
            {
                _Minutes++;
                _Counter = 0;
            }

            if (_Minutes == BreakTime)
            {
                lblBTimer.Text = $"{_Minutes}:00";
                timer2.Stop();
                btnreturntowork.Visible = true;

                if (MessageBox.Show("Break Finished return to work 💪") == DialogResult.OK)
                {
                    tpWorkT.Enabled = true;
                    tpBreakT.Enabled = false;
                    tcT.SelectedTab = tpWorkT;

                   _Minutes = 0;
                   _Counter = 0;
                }

            }
        }

  
    }
}
