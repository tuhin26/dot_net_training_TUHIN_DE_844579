using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace samplewindowsapp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {

            // MessageBox.Show("wellcome");

            if ((txtfirst.Text == "") || (txtsecond.Text == ""))
            {
                MessageBox.Show("enter number first");

            }
            else
            {

                double n1, n2;
                n1 = double.Parse(txtfirst.Text);
                n2 = double.Parse(txtsecond.Text);

                double result = 0;

                if (radioadd.Checked)
                {
                    result = (n1 + n2);
                    lblsol.Text = "sum " + result;
                }
                else if (radiosub.Checked)
                {
                    result = (n1 - n2);
                    lblsol.Text = "sub " + result;
                }
                else if (radiomulti.Checked)
                {
                    result = (n1 * n2);
                    lblsol.Text = "multi " + result;
                }
                else if (radiodiv.Checked)
                {
                    result = (n1 / n2);
                    lblsol.Text = "div " + result;
                }
                else
                {
                    MessageBox.Show("enter your choice first");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
