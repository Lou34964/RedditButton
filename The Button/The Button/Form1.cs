using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Button
{
    public partial class Form1 : Form
    {
        //colors
        Color White = Color.White;
        Color red = Color.Red;
        Color orange = Color.Orange;
        Color yellow = Color.Yellow;
        Color Green = Color.Green;
        Color Blue = Color.Blue;
        Color Purple = Color.Purple;

        //interval
        int interal = 1;
        int statInt = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setDefault();
            timer.Start();
        }

        private void setDefault()
        {
            timer.Stop();
            timer.Enabled = false;
            progressBar1.Value = 100;
            this.BackColor = White;
            button1.BackColor = Purple;
            button1.ForeColor = White;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            iv();
            checkProgress(progressBar1.Value);
        }

        private void iv()
        {
            if (statInt > 0)
            {
                statInt -= 1;
            }
            else
            {
                progressBar1.Value -= 1;
                statInt = interal;
            }
        }

        private void checkProgress(int p)
        {
            if (p > 72)
            {
                button1.BackColor = Purple;
                button1.ForeColor = White;
            }
            else if(p > 50)
            {
                button1.BackColor = Blue;
                button1.ForeColor = White;
            }
            else if (p > 30)
            {
                button1.BackColor = Green;
                button1.ForeColor = Color.Black;
            }
            else if (p > 15)
            {
                button1.BackColor = yellow;
                button1.ForeColor = Color.Black;
            }
            else if (p > 5)
            {
                button1.BackColor = orange;
                button1.ForeColor = Color.Black;
            }
            else
            {
                button1.BackColor = red;
                button1.ForeColor = White;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackColor = button1.BackColor;
            Saved();
        }

        private void Saved()
        {
            timer.Stop();
            timer.Enabled = false;
            progressBar1.Value = 100;
            button1.BackColor = Purple;
            button1.ForeColor = White;
            interal = 1;
            statInt = 1;
            timer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to The Button. This is a simulation of the Redit button from 2015.\nThe progress bar will slowly move down and when it hit the next color the click button will change color.\nClicking the button will give you the status color of when you pressed it, then the progess bar will reset.\nHave fun!");
        }
    }
}
