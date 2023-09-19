using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bolum1_uygulama3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;

        }

        private void btnblue_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;

        }

        private void btngri_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;

        }

        private void btnyesil_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;

        }
    }
}
