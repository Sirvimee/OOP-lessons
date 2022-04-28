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
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
        }

        private void num0_Click(object sender, EventArgs e)
        {
            string t = display.Text;
            if (t == "0")
            {
                t = "";
            }
            t = t + "0";
            display.Text = t;
        }
        private void num1_Click(object sender, EventArgs e)
        {
            string t = display.Text;
            if (t == "0")
            {
                t = "";
            }
            t = t + 1;
            display.Text = t;
        }

        private void num2_Click(object sender, EventArgs e)
        {
            string t = display.Text;
            if (t == "0")
            {
                t = "";
            }
            t = t + 2;
            display.Text = t;
        }

        private void num3_Click(object sender, EventArgs e)
        {
            string t = display.Text;
            if (t == "0")
            {
                t = "";
            }
            t = t + 3;
            display.Text = t;
        }

        private void num4_Click(object sender, EventArgs e)
        {
            string t = display.Text;
            if (t == "0")
            {
                t = "";
            }
            t = t + 4;
            display.Text = t;
        }

        private void num5_Click(object sender, EventArgs e)
        {
            string t = display.Text;
            if (t == "0")
            {
                t = "";
            }
            t = t + 5;
            display.Text = t;
        }

        private void num6_Click(object sender, EventArgs e)
        {
            string t = display.Text;
            if (t == "0")
            {
                t = "";
            }
            t = t + 6;
            display.Text = t;
        }

        private void num7_Click(object sender, EventArgs e)
        {
            string t = display.Text;
            if (t == "0")
            {
                t = "";
            }
            t = t + 7;
            display.Text = t;
        }

        private void num8_Click(object sender, EventArgs e)
        {
            string t = display.Text;
            if (t == "0")
            {
                t = "";
            }
            t = t + 8;
            display.Text = t;
        }

        private void num9_Click(object sender, EventArgs e)
        {
            string t = display.Text;
            if (t == "0")
            {
                t = "";
            }
            t = t + 9;
            display.Text = t;
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            string t = display.Text;
            for (int i = 0; i < t.Length; i++){
                if (t[i] == ',')
                {
                    return;
                }
            }
            t = t + ",";
            display.Text = t;
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            /*string t = display.Text;
            if (t[0] == '-')
            {
                t = t.Substring(1, t.Length-1);
            }
            else if(t!="0")
            {
                t = "-" + t;
            }
            display.Text = t;
            */

            double n = Convert.ToDouble(display.Text);
            n = -n;
            display.Text = n.ToString();
        }
    }
}
