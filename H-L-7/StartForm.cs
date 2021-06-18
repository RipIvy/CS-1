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
    public partial class StartForm : Form
    {
        UdvoitelForm udvoitelForm;
        About about;
        FindACoupleForm findACoupleForm;

        public StartForm()
        {
            InitializeComponent();
        }

        private void btnUdvoitelStart_Click(object sender, EventArgs e)
        {
            udvoitelForm = new UdvoitelForm();
            udvoitelForm.ShowDialog();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            about = new About();
            about.ShowDialog();
        }

        private void btnFaCStart_Click(object sender, EventArgs e)
        {
            findACoupleForm = new FindACoupleForm();
            findACoupleForm.ShowDialog();
        }
    }
}
