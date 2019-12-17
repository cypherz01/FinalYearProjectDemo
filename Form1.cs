﻿using System;
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
        private int highlightNum;
        private Boolean canClick;
        public Form1()
        {
            InitializeComponent();

            Timer timer = new Timer();
            timer.Interval = (1 * 750); // 0.75 seconds
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();


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
            highlightNum = 1;
            canClick = true;
            panel1.Visible = true;
            panel1.Top = button2.Top + 10;
            panel1.Left = button2.Left + 10;
            panel1.Height = button2.Height;
            panel1.SendToBack();
           

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if ((layoutNum == 6) || (layoutNum == 8) || (layoutNum == 9) || (layoutNum == 10)
                || (layoutNum == 11) || (layoutNum == 12))
            {
                switch (highlightNum)
                {
                    case 1:
                        canClick = true;
                        panel1.BackColor = Color.Red;
                        highlightNum = (highlightNum + 1) % 9;
                        panel1.Height = button1.Height;
                        panel1.Top = button1.Top + 10;
                        panel1.Left = button1.Left + 10;
                        break;
                    case 2:
                        canClick = true;
                        panel1.BackColor = Color.Red;
                        highlightNum = (highlightNum + 1) % 9;
                        panel1.Height = button2.Height;
                        panel1.Top = button2.Top + 10;
                        panel1.Left = button2.Left + 10;
                        break;
                    case 3:
                        canClick = true;
                        panel1.BackColor = Color.Red;
                        highlightNum = (highlightNum + 1) % 9;
                        panel1.Height = button3.Height;
                        panel1.Top = button3.Top + 10;
                        panel1.Left = button3.Left + 10;
                        break;
                    case 4:
                        canClick = true;
                        panel1.BackColor = Color.Red;
                        highlightNum = 1;
                        panel1.Height = button9.Height;
                        panel1.Top = button9.Top + 10;
                        panel1.Left = button9.Left + 10;
                        break;

                }
            }
            else
            {
                switch (highlightNum)
                {
                    case 1:
                        canClick = true;
                        panel1.BackColor = Color.Red;
                        highlightNum = (highlightNum + 1) % 9;
                        panel1.Height = button1.Height;
                        panel1.Top = button1.Top + 10;
                        panel1.Left = button1.Left + 10;
                        break;
                    case 2:
                        canClick = true;
                        panel1.BackColor = Color.Red;
                        highlightNum = (highlightNum + 1) % 9;
                        panel1.Height = button2.Height;
                        panel1.Top = button2.Top + 10;
                        panel1.Left = button2.Left + 10;
                        break;
                    case 3:
                        canClick = true;
                        panel1.BackColor = Color.Red;
                        highlightNum = (highlightNum + 1) % 9;
                        panel1.Height = button3.Height;
                        panel1.Top = button3.Top + 10;
                        panel1.Left = button3.Left + 10;
                        break;
                    case 4:
                        canClick = true;
                        panel1.BackColor = Color.Red;
                        highlightNum = (highlightNum + 1) % 9;
                        panel1.Height = button4.Height;
                        panel1.Top = button4.Top + 10;
                        panel1.Left = button4.Left + 10;
                        break;
                    case 5:
                        canClick = true;
                        panel1.BackColor = Color.Red;
                        highlightNum = (highlightNum + 1) % 9;
                        panel1.Height = button5.Height;
                        panel1.Top = button5.Top + 10;
                        panel1.Left = button5.Left + 10;
                        break;
                    case 6:
                        canClick = true;
                        panel1.BackColor = Color.Red;
                        highlightNum = (highlightNum + 1) % 9;
                        panel1.Height = button6.Height;
                        panel1.Top = button6.Top + 10;
                        panel1.Left = button6.Left + 10;
                        break;
                    case 7:
                        canClick = true;
                        panel1.BackColor = Color.Red;
                        highlightNum = (highlightNum + 1) % 9;
                        panel1.Height = button7.Height;
                        panel1.Top = button7.Top + 10;
                        panel1.Left = button7.Left + 10;
                        break;
                    case 8:
                        canClick = true;
                        panel1.BackColor = Color.Red;
                        highlightNum = (highlightNum + 1) % 9;
                        panel1.Height = button8.Height;
                        panel1.Top = button8.Top + 10;
                        panel1.Left = button8.Left + 10;
                        break;
                    case 0:
                        canClick = true;
                        panel1.BackColor = Color.Red;
                        highlightNum = (highlightNum + 1) % 9;
                        panel1.Height = button9.Height;
                        panel1.Top = button9.Top + 10;
                        panel1.Left = button9.Left + 10;
                        break;




                }
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
            button2.Text = "A";
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
            button2.Text = "G";
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
            button2.Text = "M";
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
            button2.Text = "S";
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
            button2.Text = "Y";
            button3.Text = "Z";
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
        }

        private void Layout7()
        {
            button1.Text = "Return";
            button2.Text = "0 1";
            button3.Text = "2 3";
            button4.Text = "4 5";
            button5.Text = "6 7";
            button6.Text = "8 9";
            button7.Text = "! ? . * ...";
            button8.Text = "space";
        }

        private void Layout8()
        {
            button1.Text = "Return";
            button2.Text = "0";
            button3.Text = "1";
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
        }

        private void Layout9()
        {
            button1.Text = "Return";
            button2.Text = "2";
            button3.Text = "3";
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
        }

        private void Layout10()
        {
            button1.Text = "Return";
            button2.Text = "4";
            button3.Text = "5";
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
        }

        private void Layout11()
        {
            button1.Text = "Return";
            button2.Text = "6";
            button3.Text = "7";
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
        }

        private void Layout12()
        {
            button1.Text = "Return";
            button2.Text = "8";
            button3.Text = "9";
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
        }

        private void Layout13()
        {
            button1.Text = "Return";
            button2.Text = "!";
            button3.Text = "?";
            button4.Text = ".";
            button5.Text = "*";
            button6.Text = "/";
            button7.Text = "\\";
            button8.Text = "space";
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

        private void Button2_Click(object sender, EventArgs e)
        {

            switch (layoutNum)
            {
                case 1:
                    layoutNum = 2;
                    Layout2();
                    break;
                case 2:
                    textBox1.Text += "A";
                    break;
                case 3:
                    textBox1.Text += "G";
                    break;
                case 4:
                    textBox1.Text += "M";
                    break;
                case 5:
                    textBox1.Text += "S";
                    break;
                case 6:
                    textBox1.Text += "Y";
                    break;
                case 7:
                    layoutNum = 8;
                    Layout8();
                    break;
                case 8:
                    textBox1.Text += "0";
                    break;
                case 9:
                    textBox1.Text += "2";
                    break;
                case 10:
                    textBox1.Text += "4";
                    break;
                case 11:
                    textBox1.Text += "6";
                    break;
                case 12:
                    textBox1.Text += "8";
                    break;
                case 13:
                    textBox1.Text += "!";
                    break;


            }


        }

        private void Button3_Click(object sender, EventArgs e)
        {

            switch (layoutNum)
            {
                case 1:
                    layoutNum = 3;
                    Layout3();
                    break;
                case 2:
                    textBox1.Text += "B";
                    break;
                case 3:
                    textBox1.Text += "H";
                    break;
                case 4:
                    textBox1.Text += "N";
                    break;
                case 5:
                    textBox1.Text += "T";
                    break;
                case 6:
                    textBox1.Text += "Z";
                    break;
                case 7:
                    layoutNum = 9;
                    Layout9();
                    break;
                case 8:
                    textBox1.Text += "1";
                    break;
                case 9:
                    textBox1.Text += "3";
                    break;
                case 10:
                    textBox1.Text += "5";
                    break;
                case 11:
                    textBox1.Text += "7";
                    break;
                case 12:
                    textBox1.Text += "9";
                    break;
                case 13:
                    textBox1.Text += "?";
                    break;


            }


        }

        private void Button4_Click(object sender, EventArgs e)
        {
            switch (layoutNum)
            {
                case 1:
                    layoutNum = 4;
                    Layout4();
                    break;
                case 2:
                    textBox1.Text += "C";
                    break;
                case 3:
                    textBox1.Text += "I";
                    break;
                case 4:
                    textBox1.Text += "O";
                    break;
                case 5:
                    textBox1.Text += "U";
                    break;
                case 7:
                    layoutNum = 10;
                    Layout10();
                    break;
                case 13:
                    textBox1.Text += ".";
                    break;

            }

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            switch (layoutNum)
            {
                case 1:
                    layoutNum = 5;
                    Layout5();
                    break;
                case 2:
                    textBox1.Text += "D";
                    break;
                case 3:
                    textBox1.Text += "J";
                    break;
                case 4:
                    textBox1.Text += "P";
                    break;
                case 5:
                    textBox1.Text += "V";
                    break;
                case 7:
                    layoutNum = 11;
                    Layout11();
                    break;
                case 13:
                    textBox1.Text += "*";
                    break;
            }



        }

        private void Button6_Click(object sender, EventArgs e)
        {
            switch (layoutNum)
            {
                case 1:
                    layoutNum = 6;
                    Layout6();
                    break;
                case 2:
                    textBox1.Text += "E";
                    break;
                case 3:
                    textBox1.Text += "K";
                    break;
                case 4:
                    textBox1.Text += "Q";
                    break;
                case 5:
                    textBox1.Text += "W";
                    break;
                case 7:
                    layoutNum = 12;
                    Layout12();
                    break;
                case 13:
                    textBox1.Text += "/";
                    break;

            }
        }


        private void Button7_Click(object sender, EventArgs e)
        {
            switch (layoutNum)
            {
                case 1:
                    layoutNum = 7;
                    Layout7();
                    break;
                case 2:
                    textBox1.Text += "F";
                    break;
                case 3:
                    textBox1.Text += "L";
                    break;
                case 4:
                    textBox1.Text += "R";
                    break;
                case 5:
                    textBox1.Text += "X";
                    break;
                case 7:
                    layoutNum = 13;
                    Layout13();
                    break;
                case 13:
                    textBox1.Text += "\\";
                    break;

            }


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.M)&&(canClick))
            {
                switch (highlightNum)
            {
                case 2:
                        panel1.BackColor = Color.Yellow;
                        Button1_Click(sender, e);
                        highlightNum = 1;
                        canClick = false;
                        break;
                case 3:
                        panel1.BackColor = Color.Yellow;
                        Button2_Click(sender, e);
                        highlightNum = 1;
                        canClick = false;
                        break;
                case 4:
                        panel1.BackColor = Color.Yellow;
                        Button3_Click(sender, e);
                        highlightNum = 1;
                        canClick = false;
                        break;
                case 5:
                        panel1.BackColor = Color.Yellow;
                        Button4_Click(sender, e);
                        highlightNum = 1;
                        canClick = false;
                        break;
                case 6:
                        panel1.BackColor = Color.Yellow;
                        Button5_Click(sender, e);
                        highlightNum = 1;
                        canClick = false;
                        break;
                case 7:
                        panel1.BackColor = Color.Yellow;
                        Button6_Click(sender, e);
                        highlightNum = 1;
                        canClick = false;
                        break;
                case 8:
                        panel1.BackColor = Color.Yellow;
                        Button7_Click(sender, e);
                        highlightNum = 1;
                        canClick = false;
                        break;
                case 0:
                        panel1.BackColor = Color.Yellow;
                        Button8_Click(sender, e);
                        highlightNum = 1;
                        canClick = false;
                        break;
                case 1:
                        panel1.BackColor = Color.Yellow;
                        Button9_Click(sender, e);
                        highlightNum = 1;
                        canClick = false;
                        break;


            }
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += " ";

        }

        private void Button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                panel1.Visible = true;
                KeyPreview = true;

            }
            else
            {
                panel1.Visible = false;
                KeyPreview = false;
            }
        }
    }
}
