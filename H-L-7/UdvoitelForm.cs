using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H_L_7
{
    public partial class UdvoitelForm : Form
    {
        int commands = 0;

        UdvoitelGame.Udvoitel udvoitel;
        HowToPlay howToPlay;
        Timer timer = new Timer();

        public UdvoitelForm()
        {
            InitializeComponent();
            timer.Tick += TimerTick;
            timer.Start();
            udvoitel = new UdvoitelGame.Udvoitel();
            commands++;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            UpdateLabels();
            WinLoseCheckUpdateLabel();
        }

        private void UpdateLabels()
        {
            lblPurposeNumber.Text = Convert.ToString(udvoitel.Purpose);
            lblCurrentNumber.Text = Convert.ToString(udvoitel.Current);
            lblStepsNumber.Text = Convert.ToString(udvoitel.Steps);
            lblMaxStepsNumber.Text = Convert.ToString(udvoitel.MaxSteps);
            tssilblCommandsNumber.Text = Convert.ToString(commands);
        }

        private void WinLoseCheckUpdateLabel()
        {
            if (udvoitel.WinCheck)
            {
                lblWinLose.Visible = true;
                lblWinLose.ForeColor = Color.Lime;
                lblWinLose.Text = "You Win!";
            }
            if (udvoitel.LoseCheck)
            {
                lblWinLose.Visible = true;
                lblWinLose.ForeColor = Color.Red;
                lblWinLose.Text = "You Lose!";
            }
            if ((!udvoitel.WinCheck) && (!udvoitel.LoseCheck))
            {
                lblWinLose.Visible = false;
            }
        }

        private void tsmiNew_Click(object sender, EventArgs e)
        {
            udvoitel = new UdvoitelGame.Udvoitel();
            commands++;
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            udvoitel.Plus();
            commands++;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            udvoitel.Multi();
            commands++;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            udvoitel.Reset();
            commands++;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            udvoitel.Back();
            commands++;
        }

        private void tsmiHowToPlay_Click(object sender, EventArgs e)
        {
            howToPlay = new HowToPlay();
            howToPlay.ShowDialog();
        }
    }
}
