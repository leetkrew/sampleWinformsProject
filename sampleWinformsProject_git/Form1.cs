using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sampleWinformsProject_git
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAlert_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Hello {0}", txtName.Text));
        }

        private void btnShowForm2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}
