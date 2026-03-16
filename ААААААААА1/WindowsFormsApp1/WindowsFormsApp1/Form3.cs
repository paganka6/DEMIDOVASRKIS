using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            cart frmCart = new cart();
            frmCart.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            akaunt frmAkaunt = new akaunt();
            frmAkaunt.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            akaunt frmAkaunt = new akaunt();
            frmAkaunt.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cart frmСart = new cart();
            frmСart.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            catalog frmСatalog = new catalog();
            frmСatalog.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            catalog frmСatalog = new catalog();
            frmСatalog.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            inf frmInf = new inf();
            frmInf.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inf frmInf = new inf();
            frmInf.Show();
            this.Hide();
        }
    }
}
