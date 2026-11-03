using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangMan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int x;
        string s;
        string c;
        int ok = 0;
        int ok1 = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            x = rnd.Next(1,6);
            if (x == 1)
            {
                s = "BROWSER";
            }
            else if (x == 2)
            {
                s = "CRIPTARE";
            }
            else if(x==3)
            {
                s = "MATRICE";
            }
            else if (x == 4)
            {
                s = "HARDWARE";
            }
            else
            {
                s = "PROCESARE";
            }

        }
        

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           
            Graphics g = e.Graphics;
            int a = 280;
            int b = 200;
            Pen pen = new Pen(Color.Black);
            pen.Width = 2;
            for (int i = 0; i < s.Length; i++)
            {
                g.DrawLine(pen, a, b, a + 40, b);
                a += 55;
            }
            pen.Width = 15;
            g.DrawLine(pen, 200, 50, 200, 200);
            pen.Width = 12;
            g.DrawLine(pen, 135, 50, 208, 50);
            pen.Width = 10;
            g.DrawLine(pen, 140, 50, 140, 80);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            c = btn.Text;
            btn.Visible = false;
            int a = 285;
            int b = 160;
            bool rasp = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c[0])
                {
                   
                    Brush br = new SolidBrush(Color.Black);
                    Font font = new Font("Arial", 20);
                    string d = c[0].ToString();
                    Graphics g = this.CreateGraphics();
                    g.DrawString(d,font , br, a, b);
                    ok++; 
                    rasp = true;
                }
                if (ok == s.Length)
                {
                    MessageBox.Show("Ati castigat!");
                    System.Environment.Exit(0);
                }
                a += 55;
            }
            if (!rasp)
            {
                Pen pen = new Pen(Color.Black);
                pen.Width = 5;
                
                ok1++;
                if (ok1 == 1)
                {
                    Graphics g = this.CreateGraphics();
                    g.DrawEllipse(pen, 130, 80, 20, 20);
                }
                else if (ok1 == 2)
                {
                    Graphics g = this.CreateGraphics();
                    g.DrawLine(pen, 140, 100, 140, 160);
                }
                else if (ok1 == 3)
                {
                    Graphics g = this.CreateGraphics();
                    g.DrawLine(pen, 140, 110, 100, 140);
                }
                else if (ok1 == 4)
                {
                    Graphics g = this.CreateGraphics();
                    g.DrawLine(pen, 140, 110, 180, 140);
                }
                else if (ok1 == 5)
                {
                    Graphics g = this.CreateGraphics();
                    g.DrawLine(pen, 140, 160, 100, 210);
                }
                else if (ok1 == 6)
                {
                    Graphics g = this.CreateGraphics();
                    g.DrawLine(pen, 140, 160, 180, 210);
                    MessageBox.Show("Ati pierdut!");
                    System.Environment.Exit(0);
                }
            }
        }
    }
}
