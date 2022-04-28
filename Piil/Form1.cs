using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            string t = txtName.Text;
            string tt = "";
            for( int i = 0; i < t.Length; i++)
            {
                tt = t[i] +" "+tt;
            }
            myText.Text = tt;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            string t = txtName.Text;
            if (checkBox1.Checked) 
            {
                t = t.ToUpper();
            }
            else
            {
                t = t.ToLower();
            }
            lable2.Text = t;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Suured";
            }
            else
            {
                checkBox1.Text = "Väiksed";

            }
            txtName_TextChanged(null, null);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                timeLabel.Text = DateTime.Now.ToString();
            }
            else if (radioButton2.Checked)
            {
                timeLabel.Text = DateTime.Now.ToLongDateString().ToString();

            }
            else if (radioButton3.Checked)
            {
                timeLabel.Text = DateTime.Now.ToShortDateString().ToString();

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox2.Text = "Stop";
                timer1.Enabled = true;
            }
            else
            {
                checkBox2.Text = "Start";
                timer1.Enabled = false;
            }

        }
    }
}
