using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace H_L_7
{
    public partial class FindACoupleForm : Form
    {
        FindACoupleGame.FindACouple find;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public FindACoupleForm()
        {
            InitializeComponent();
            find = new FindACoupleGame.FindACouple();
            timer.Tick += TimerTick;
            timer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            if (find.DataArray[0] == 0) button1.Visible = false;
            if (find.DataArray[1] == 0) button2.Visible = false;
            if (find.DataArray[2] == 0) button3.Visible = false;
            if (find.DataArray[3] == 0) button4.Visible = false;
            if (find.DataArray[4] == 0) button5.Visible = false;
            if (find.DataArray[5] == 0) button6.Visible = false;
            if (find.DataArray[6] == 0) button7.Visible = false;
            if (find.DataArray[7] == 0) button8.Visible = false;
            if ((!button1.Visible) && (!button1.Visible) && (!button1.Visible) && (!button1.Visible) && (!button1.Visible) && (!button1.Visible) && (!button1.Visible) && (!button1.Visible))
            {
                lblWin.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            find.CheckCouple(0);
            button1.Enabled = false;
            button1.Text = Convert.ToString(find.DataArray[0]);
            if ((!button2.Enabled) | (!button3.Enabled) | (!button4.Enabled) | (!button5.Enabled) | (!button6.Enabled) | (!button7.Enabled) | (!button8.Enabled))
            {
                button1.Text = "-";
                button2.Text = "-";
                button3.Text = "-";
                button4.Text = "-";
                button5.Text = "-";
                button6.Text = "-";
                button7.Text = "-";
                button8.Text = "-";
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            find.CheckCouple(1);
            button2.Enabled = false;
            button2.Text = Convert.ToString(find.DataArray[1]);
            if ((!button1.Enabled) | (!button3.Enabled) | (!button4.Enabled) | (!button5.Enabled) | (!button6.Enabled) | (!button7.Enabled) | (!button8.Enabled))
            {
                button1.Text = "-";
                button2.Text = "-";
                button3.Text = "-";
                button4.Text = "-";
                button5.Text = "-";
                button6.Text = "-";
                button7.Text = "-";
                button8.Text = "-";
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            find.CheckCouple(2);
            button3.Enabled = false;
            button3.Text = Convert.ToString(find.DataArray[2]);
            if ((!button1.Enabled) | (!button2.Enabled) | (!button4.Enabled) | (!button5.Enabled) | (!button6.Enabled) | (!button7.Enabled) | (!button8.Enabled))
            {
                button1.Text = "-";
                button2.Text = "-";
                button3.Text = "-";
                button4.Text = "-";
                button5.Text = "-";
                button6.Text = "-";
                button7.Text = "-";
                button8.Text = "-";
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            find.CheckCouple(3);
            button4.Enabled = false;
            button4.Text = Convert.ToString(find.DataArray[3]);
            if ((!button1.Enabled) | (!button2.Enabled) | (!button3.Enabled) | (!button5.Enabled) | (!button6.Enabled) | (!button7.Enabled) | (!button8.Enabled))
            {
                button1.Text = "-";
                button2.Text = "-";
                button3.Text = "-";
                button4.Text = "-";
                button5.Text = "-";
                button6.Text = "-";
                button7.Text = "-";
                button8.Text = "-";
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            find.CheckCouple(4);
            button5.Enabled = false;
            button5.Text = Convert.ToString(find.DataArray[4]);
            if ((!button1.Enabled) | (!button2.Enabled) | (!button3.Enabled) | (!button4.Enabled) | (!button6.Enabled) | (!button7.Enabled) | (!button8.Enabled))
            {
                button1.Text = "-";
                button2.Text = "-";
                button3.Text = "-";
                button4.Text = "-";
                button5.Text = "-";
                button6.Text = "-";
                button7.Text = "-";
                button8.Text = "-";
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            find.CheckCouple(5);
            button6.Enabled = false;
            button6.Text = Convert.ToString(find.DataArray[5]);
            if ((!button1.Enabled) | (!button2.Enabled) | (!button3.Enabled) | (!button4.Enabled) | (!button5.Enabled) | (!button7.Enabled) | (!button8.Enabled))
            {
                button1.Text = "-";
                button2.Text = "-";
                button3.Text = "-";
                button4.Text = "-";
                button5.Text = "-";
                button6.Text = "-";
                button7.Text = "-";
                button8.Text = "-";
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            find.CheckCouple(6);
            button7.Enabled = false;
            button7.Text = Convert.ToString(find.DataArray[6]);
            if ((!button1.Enabled) | (!button2.Enabled) | (!button3.Enabled) | (!button4.Enabled) | (!button5.Enabled) | (!button6.Enabled) | (!button8.Enabled))
            {
                button1.Text = "-";
                button2.Text = "-";
                button3.Text = "-";
                button4.Text = "-";
                button5.Text = "-";
                button6.Text = "-";
                button7.Text = "-";
                button8.Text = "-";
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            find.CheckCouple(7);
            button8.Enabled = false;
            button8.Text = Convert.ToString(find.DataArray[7]);
            if ((!button1.Enabled) | (!button2.Enabled) | (!button3.Enabled) | (!button4.Enabled) | (!button5.Enabled) | (!button6.Enabled) | (!button7.Enabled))
            {
                button1.Text = "-";
                button2.Text = "-";
                button3.Text = "-";
                button4.Text = "-";
                button5.Text = "-";
                button6.Text = "-";
                button7.Text = "-";
                button8.Text = "-";
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
            }
        }
    }
}
