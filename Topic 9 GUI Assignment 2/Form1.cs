using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_9_GUI_Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelect1_Click(object sender, EventArgs e)
        {
            label1.Text = "8+8=" + (8 + 8);
        }

        private void btnSelect2_Click(object sender, EventArgs e)
        {
            label2.Text = "8-8=" + (8 - 8);
        }

        private void btnSelect3_Click(object sender, EventArgs e)
        {
            label3.Text = "8*8=" + (8 * 8);
        }

        private void btnSelect4_Click(object sender, EventArgs e)
        {
            label4.Text = "8/8=" + (8 / 8);
        }
    }
}
