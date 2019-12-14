using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalYearProjectDemo
{
    public partial class Form1 : Form
    {
        private int layoutNum;
        public Form1()
        {
            InitializeComponent();

            // StartPosition was set to FormStartPosition.Manual in the properties window.
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            int w = Width >= screen.Width ? screen.Width : (screen.Width) / 2;
            this.Size = new Size(w, screen.Height);

            button1.Location = new System.Drawing.Point((w / 2)-250, (screen.Height / 2)-400);
            button2.Location = new System.Drawing.Point((w / 2)+100, (screen.Height / 2)-400);
            button3.Location = new System.Drawing.Point((w / 2) + 250, (screen.Height / 2)-200);
            button4.Location = new System.Drawing.Point((w / 2) + 250, (screen.Height / 2) + 100);
            button5.Location = new System.Drawing.Point((w / 2) + 100, (screen.Height / 2) +300);
            button6.Location = new System.Drawing.Point((w / 2) - 250, (screen.Height / 2) + 300);
            button7.Location = new System.Drawing.Point((w / 2) - 400, (screen.Height / 2) + 100);
            button8.Location = new System.Drawing.Point((w / 2) - 400, (screen.Height / 2) - 200);
            button9.Location = new System.Drawing.Point((w/2)-75, (screen.Height/2)-50);

            button1.Text = "controls";
            button2.Text = "A B C D E F";
            button3.Text = "G H I J K L";
            button4.Text = "M N O P Q R";
            button5.Text = "S T U V W X";
            button6.Text = "Y Z";
            button7.Text = "1 2 3 4...";
            button8.Text = "space";

            layoutNum = 1;

        }

        private void Button2_Click(object sender, EventArgs e)
        {

            if (layoutNum == 1)
            {
                layoutNum = 2;
                Layout2();
            }
            else if (layoutNum == 2)
                {
                textBox1.Text = "A";
            }
            else if (layoutNum == 3)
            {
                textBox1.Text = "G";
            }
            else if (layoutNum == 4)
            {
                textBox1.Text = "M";
            }
            else if (layoutNum == 5)
            {
                textBox1.Text = "S";
            }
            else if (layoutNum == 6)
            {
                textBox1.Text = "Y";
            }

        }

        private void Layout1()
        {
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;

            button1.Text = "controls";
            button2.Text = "A B C D E F";
            button3.Text = "G H I J K L";
            button4.Text = "M N O P Q R";
            button5.Text = "S T U V W X";
            button6.Text = "Y Z";
            button7.Text = "1 2 3 4...";
            button8.Text = "space";
        }

        private void Layout2()
        {
            button1.Text = "Return";
            button2.Text = "A ";
            button3.Text = "B";
            button4.Text = "C";
            button5.Text = "D";
            button6.Text = "E";
            button7.Text = "F";
            button8.Text = "space";
        }

        private void Layout3()
        {
            button1.Text = "Return";
            button2.Text = "G ";
            button3.Text = "H";
            button4.Text = "I";
            button5.Text = "J";
            button6.Text = "K";
            button7.Text = "L";
            button8.Text = "space";
        }

        private void Layout4()
        {
            button1.Text = "Return";
            button2.Text = "M ";
            button3.Text = "N";
            button4.Text = "O";
            button5.Text = "P";
            button6.Text = "Q";
            button7.Text = "R";
            button8.Text = "space";
        }

        private void Layout5()
        {
            button1.Text = "Return";
            button2.Text = "S ";
            button3.Text = "T";
            button4.Text = "U";
            button5.Text = "V";
            button6.Text = "W";
            button7.Text = "X";
            button8.Text = "space";
        }

        private void Layout6()
        {
            button1.Text = "Return";
            button2.Text = "Y ";
            button3.Text = "Z";
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (layoutNum == 1)
            {
                layoutNum = 3;
                Layout3();
            }
            else if (layoutNum == 2)
            {
                textBox1.Text = "B";
            }
            else if (layoutNum == 3)
            {
                textBox1.Text = "H";
            }
            else if (layoutNum == 4)
            {
                textBox1.Text = "N";
            }
            else if (layoutNum == 5)
            {
                textBox1.Text = "T";
            }
            else if (layoutNum == 6)
            {
                textBox1.Text = "Z";
            }

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (layoutNum == 1)
            {
                layoutNum = 4;
                Layout4();
            }
            else if (layoutNum == 2)
            {
                textBox1.Text = "C";
            }
            else if (layoutNum == 3)
            {
                textBox1.Text = "I";
            }
            else if (layoutNum == 4)
            {
                textBox1.Text = "O";
            }
            else if (layoutNum == 5)
            {
                textBox1.Text = "U";
            }

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (layoutNum == 1)
            {
                layoutNum = 5;
                Layout5();
            }
            else if (layoutNum == 2)
            {
                textBox1.Text = "D";
            }
            else if (layoutNum == 3)
            {
                textBox1.Text = "J";
            }
            else if (layoutNum == 4)
            {
                textBox1.Text = "P";
            }
            else if (layoutNum == 5)
            {
                textBox1.Text = "V";
            }

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (layoutNum == 1)
            {
                layoutNum = 6;
                Layout6();
            }
            else if (layoutNum == 2)
            {
                textBox1.Text = "E";
            }
            else if (layoutNum == 3)
            {
                textBox1.Text = "K";
            }
            else if (layoutNum == 4)
            {
                textBox1.Text = "Q";
            }
            else if (layoutNum == 5)
            {
                textBox1.Text = "W";
            }


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (layoutNum == 1)
            {
                layoutNum = 6;
                Layout6();
            }
            else
            {
                layoutNum = 1;
                Layout1();
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if(layoutNum == 1)
            {
                
            }
            else if (layoutNum == 2)
            {
                textBox1.Text = "F";
            }
            else if (layoutNum == 3)
            {
                textBox1.Text = "L";
            }
            else if (layoutNum == 4)
            {
                textBox1.Text = "R";
            }
            else if (layoutNum == 5)
            {
                textBox1.Text = "X";
            }

        }
    }
}
