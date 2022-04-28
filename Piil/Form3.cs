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
    public partial class Form3 : Form
    {
        Button[] NumbM = new Button[12];
        Button[] TeheM = new Button[5];
        byte TeheNumber = 5;
        byte EelmineTeheNumber = 5;
        double Tulemus = 0;
        Boolean uus = true;

        public Form3()
        {
            InitializeComponent();
            Numb_Create();
            Tehe_Create();
        }

        public void Numb_Create()
        {
            int x = Frame2.Width/4;
            int dx = x / 4;
            int y = Frame2.Height/5;
            int dy = y / 5;

            for(int i = 0; i < 12; i++)
            {
                NumbM[i] = new Button();
                NumbM[i].Click += new EventHandler(Numb_Click);
                Frame2.Controls.Add(NumbM[i]);
                NumbM[i].Text = i.ToString();
                NumbM[i].BackColor = Color.LightSkyBlue;
                NumbM[i].ForeColor = Color.Black;
                NumbM[i].Width = x;
                NumbM[i].Height = y;

                int vn = (i - 1) % 3;
                int rn = 2 - ((i - 1) / 3);

                if (i==0 || i>9)
                {
                    if (i == 0) vn = 1;
                    else if (i == 10) vn = 0;
                    else vn = 2;
                    rn = 3;
                }
                
                NumbM[i].Left = vn * x + (vn + 1) * dx;
                NumbM[i].Top = rn * y + (rn + 1) * dy;
            }
            NumbM[10].Text = "+-";
            NumbM[10].BackColor = Color.LightYellow;
            NumbM[11].Text = ",";
            NumbM[11].BackColor = Color.LightYellow;
        }

        public void Tehe_Create()
        {
            int x = Frame3.Width*2 / 3;
            int dx = x / 4;
            int y = Frame3.Height / 6;
            int dy = y / 6;

            for (int i = 0; i < 5; i++)
            {
                TeheM[i] = new Button();
                TeheM[i].Click += new EventHandler(Tehe_Click);
                Frame3.Controls.Add(TeheM[i]);
                TeheM[i].Text = i.ToString();
                TeheM[i].BackColor = Color.LightSkyBlue;
                TeheM[i].ForeColor = Color.Black;
                TeheM[i].Width = x;
                TeheM[i].Height = y;
                TeheM[i].Left = dx;
                TeheM[i].Top = i * y + (i + 1) * dy;
            }
            TeheM[0].Text = ":";
            TeheM[1].Text = "x";
            TeheM[2].Text = "-";
            TeheM[3].Text = "+";
            TeheM[4].Text = "=";
        }
        public void Numb_Click(object sender, EventArgs e)
        {
            if (uus)
            {
                display.Text = "0";
                uus = false;
            }
            int n=Array.IndexOf(NumbM, (Button)sender);
            if (n<10)
            {
                string t = display.Text;
                if (t == "0") t = "";
                t = t + NumbM[n].Text;
                display.Text = t;
            }
            else if (n==10)
            {
                double arv = Convert.ToDouble(display.Text);
                arv = -arv;
                display.Text = arv.ToString();
            }
            else
            {
                string t = display.Text;
                for (int i = 0; i < t.Length; i++)
                    if (t[i] == ',') return;
                t = t + ",";
                display.Text = t;
            }
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            display.Text = "0";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            string t = display.Text;
            t = t.Substring(0, t.Length - 1);
            if (t.Length==0 || t=="-" || t=="-0") t = "0";
            display.Text = t;
        }

        public void Tehe_Click(object sender, EventArgs e)
        {
            double arv = Convert.ToDouble(display.Text);
            if (TeheNumber == 0) Tulemus /= arv;
            else if (TeheNumber == 1) Tulemus *= arv;
            else if (TeheNumber == 2) Tulemus -= arv;
            else if (TeheNumber == 3) Tulemus += arv;
            else Tulemus = arv;

            display.Text = Tulemus.ToString();
            uus = true;
            
            EelmineTeheNumber = TeheNumber;
            TeheNumber = (byte)Array.IndexOf(TeheM, (Button)sender);
        }
    }
}
