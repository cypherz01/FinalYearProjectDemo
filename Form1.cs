using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalYearProjectDemo
{
    public partial class Form1 : Form
    {

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;
                return param;
            }
        }
        private int layoutNum;
        private int highlightNum;
        private Boolean canClick;
        private string[] Words;
        public Form1()
        {
            InitializeComponent();

           /* Words = File.ReadAllLines("C:\\words\\words.txt");
            for (int i = 0; i < Words.Length; i++)
            {
                textBox1.AutoCompleteCustomSource.Add(Words[i]);
            }
            */


            Timer timer = new Timer();
            timer.Interval = (1 * 750); // 0.75 seconds
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();


            // StartPosition was set to FormStartPosition.Manual in the properties window.
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            int w = Width >= screen.Width ? screen.Width : (screen.Width) / 2;
            this.Size = new Size(w, screen.Height);

            

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
                        panel1.Height = panel2.Height;
                        panel1.Width = panel2.Width;
                        panel1.Top = panel2.Top + 10;
                        panel1.Left = panel2.Left + 10;
                       
                        break;
                    case 2:
                        canClick = true;
                        panel1.BackColor = Color.Red;
                        highlightNum = (highlightNum + 1) % 9;
                        panel1.Height = panel3.Height;
                        panel1.Width = panel3.Width;
                        panel1.Top = panel3.Top + 10;
                        panel1.Left = panel3.Left + 10;
                        
                        
                        break;
                    case 3:
                        canClick = true;
                        panel1.BackColor = Color.Red;
                        highlightNum = (highlightNum + 1) % 9;
                        panel1.Height = panel4.Height;
                        panel1.Width = panel4.Width;
                        panel1.Top = panel4.Top + 10;
                        panel1.Left = panel4.Left + 10;
                        
                        break;
                    case 4:
                        canClick = true;
                        panel1.BackColor = Color.Red;
                        highlightNum = (highlightNum + 1) % 9;
                        panel1.Height = panel5.Height;
                        panel1.Width = panel5.Width;
                        panel1.Top = panel5.Top + 10;
                        panel1.Left = panel5.Left + 10;
                        
                        break;
                    case 5:
                        canClick = true;
                        panel1.BackColor = Color.Red;
                        highlightNum = (highlightNum + 1) % 9;
                        panel1.Height = panel6.Height;
                        panel1.Width = panel6.Width;
                        panel1.Top = panel6.Top + 10;
                        panel1.Left = panel6.Left + 10;
                       
                        break;
                    case 6:
                        canClick = true;
                        panel1.BackColor = Color.Red;
                        highlightNum = (highlightNum + 1) % 9;
                        panel1.Height = panel7.Height;
                        panel1.Width = panel7.Width;
                        panel1.Top = panel7.Top + 10;
                        panel1.Left = panel7.Left + 10;
                        break;
                    case 7:
                        canClick = true;
                        panel1.BackColor = Color.Red;
                        highlightNum = (highlightNum + 1) % 9;
                        panel1.Height = panel8.Height;
                        panel1.Width = panel8.Width;
                        panel1.Top = panel8.Top + 10;
                        panel1.Left = panel8.Left + 10;
                        break;
                    case 8:
                        canClick = true;
                        panel1.BackColor = Color.Red;
                        highlightNum = (highlightNum + 1) % 9;
                        panel1.Height = panel9.Height;
                        panel1.Width = panel9.Width;
                        panel1.Top = panel9.Top + 10;
                        panel1.Left = panel9.Left + 10;
                        break;
                    case 0:
                        canClick = true;
                        panel1.BackColor = Color.Red;
                        highlightNum = (highlightNum + 1) % 9;
                        panel1.Height = panel10.Height;
                        panel1.Width = panel10.Width;
                        panel1.Top = panel10.Top + 10;
                        panel1.Left = panel10.Left + 10;
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
                    SendKeys.Send("A");
                    textBox1.Text += ("A");
                    break;
                case 3:
                    SendKeys.Send("G");
                    break;
                case 4:
                    SendKeys.Send("M");
                    break;
                case 5:
                    SendKeys.Send("S");
                    break;
                case 6:
                    SendKeys.Send("Y");
                    break;
                case 7:
                    layoutNum = 8;
                    Layout8();
                    break;
                case 8:
                    SendKeys.Send("0");
                    break;
                case 9:
                    SendKeys.Send("2");
                    break;
                case 10:
                    SendKeys.Send("4");
                    break;
                case 11:
                    SendKeys.Send("6");
                    break;
                case 12:
                    SendKeys.Send("8");
                    break;
                case 13:
                    SendKeys.Send("!");
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
                    SendKeys.Send("B");
                    break;
                case 3:
                    SendKeys.Send("H");
                    break;
                case 4:
                    SendKeys.Send("N");
                    break;
                case 5:
                    SendKeys.Send("T");
                    break;
                case 6:
                    SendKeys.Send("Z");
                    break;
                case 7:
                    layoutNum = 9;
                    Layout9();
                    break;
                case 8:
                    SendKeys.Send("1");
                    break;
                case 9:
                    SendKeys.Send("3");
                    break;
                case 10:
                    SendKeys.Send("5");
                    break;
                case 11:
                    SendKeys.Send("7");
                    break;
                case 12:
                    SendKeys.Send("9");
                    break;
                case 13:
                    SendKeys.Send("?");
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
                    SendKeys.Send("C");
                    break;
                case 3:
                    SendKeys.Send("I");
                    break;
                case 4:
                    SendKeys.Send("O");
                    break;
                case 5:
                    SendKeys.Send("U");
                    break;
                case 7:
                    layoutNum = 10;
                    Layout10();
                    break;
                case 13:
                    SendKeys.Send(".");
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
                    SendKeys.Send("D");
                    break;
                case 3:
                    SendKeys.Send("J");
                    break;
                case 4:
                    SendKeys.Send("P");
                    break;
                case 5:
                    SendKeys.Send("V");
                    break;
                case 7:
                    layoutNum = 11;
                    Layout11();
                    break;
                case 13:
                    SendKeys.Send("*");
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
                    SendKeys.Send("E");
                    break;
                case 3:
                    SendKeys.Send("K");
                    break;
                case 4:
                    SendKeys.Send("Q");
                    break;
                case 5:
                    SendKeys.Send("W");
                    break;
                case 7:
                    layoutNum = 12;
                    Layout12();
                    break;
                case 13:
                    SendKeys.Send("/");
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
                    SendKeys.Send("F");
                    break;
                case 3:
                    SendKeys.Send("L");
                    break;
                case 4:
                    SendKeys.Send("R");
                    break;
                case 5:
                    SendKeys.Send("X");
                    break;
                case 7:
                    layoutNum = 13;
                    Layout13();
                    break;
                case 13:
                    SendKeys.Send("\\");
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
            SendKeys.Send(" ");

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

        private void Button3_MouseEnter(object sender, EventArgs e)
        {
            button3.Font = new Font(button3.Font.Name, 32, FontStyle.Regular);
            int width = button3.Size.Width;
            int height = button3.Height;
            int change = 20;
            button3.Size = new Size(width + change, height + change);
            button3.Location = new Point(button3.Location.X - (change/2), button3.Location.Y - (change / 2));
        }

        private void Button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Font = new Font(button3.Font.Name, 16, FontStyle.Regular);
            int width = button3.Size.Width;
            int height = button3.Height;
            int change = 20;
            button3.Size = new Size(width - change, height - change);
            button3.Location = new Point(button3.Location.X + (change / 2), button3.Location.Y + (change / 2));
        }

        private void Button4_MouseEnter(object sender, EventArgs e)
        {
            button4.Font = new Font(button4.Font.Name, 32, FontStyle.Regular);
            int width = button4.Size.Width;
            int height = button4.Height;
            int change = 20;
            button4.Size = new Size(width + change, height + change);
            button4.Location = new Point(button4.Location.X - (change / 2), button4.Location.Y - (change / 2));
        }

        private void Button4_MouseLeave(object sender, EventArgs e)
        {
            button4.Font = new Font(button4.Font.Name, 16, FontStyle.Regular);
            int width = button4.Size.Width;
            int height = button4.Height;
            int change = 20;
            button4.Size = new Size(width - change, height - change);
            button4.Location = new Point(button4.Location.X + (change / 2), button4.Location.Y + (change / 2));
        }

        private void Button5_MouseEnter(object sender, EventArgs e)
        {
            button5.Font = new Font(button5.Font.Name, 32, FontStyle.Regular);
            int width = button5.Size.Width;
            int height = button5.Height;
            int change = 20;
            button5.Size = new Size(width + change, height + change);
            button5.Location = new Point(button5.Location.X - (change / 2), button5.Location.Y - (change / 2));

        }

        private void Button5_MouseLeave(object sender, EventArgs e)
        {
            button5.Font = new Font(button5.Font.Name, 16, FontStyle.Regular);
            int width = button5.Size.Width;
            int height = button5.Height;
            int change = 20;
            button5.Size = new Size(width - change, height - change);
            button5.Location = new Point(button5.Location.X + (change / 2), button5.Location.Y + (change / 2));

        }

        private void Button6_MouseEnter(object sender, EventArgs e)
        {
            button6.Font = new Font(button6.Font.Name, 32, FontStyle.Regular);
            int width = button6.Size.Width;
            int height = button6.Height;
            int change = 20;
            button6.Size = new Size(width + change, height + change);
            button6.Location = new Point(button6.Location.X - (change / 2), button6.Location.Y - (change / 2));


        }

        private void Button6_MouseLeave(object sender, EventArgs e)
        {
            button6.Font = new Font(button6.Font.Name, 16, FontStyle.Regular);
            int width = button6.Size.Width;
            int height = button6.Height;
            int change = 20;
            button6.Size = new Size(width - change, height - change);
            button6.Location = new Point(button6.Location.X + (change / 2), button6.Location.Y + (change / 2));

        }

        private void Button7_MouseEnter(object sender, EventArgs e)
        {
            button7.Font = new Font(button7.Font.Name, 32, FontStyle.Regular);
            int width = button7.Size.Width;
            int height = button7.Height;
            int change = 20;
            button7.Size = new Size(width + change, height + change);
            button7.Location = new Point(button7.Location.X - (change / 2), button7.Location.Y - (change / 2));


        }

        private void Button7_MouseLeave(object sender, EventArgs e)
        {
            button7.Font = new Font(button7.Font.Name, 16, FontStyle.Regular);
            int width = button7.Size.Width;
            int height = button7.Height;
            int change = 20;
            button7.Size = new Size(width - change, height - change);
            button7.Location = new Point(button7.Location.X + (change / 2), button7.Location.Y + (change / 2));

        }

        private void Button8_MouseEnter(object sender, EventArgs e)
        {
            button8.Font = new Font(button8.Font.Name, 32, FontStyle.Regular);
            int width = button8.Size.Width;
            int height = button8.Height;
            int change = 20;
            button8.Size = new Size(width + change, height + change);
            button8.Location = new Point(button8.Location.X - (change / 2), button8.Location.Y - (change / 2));

        }

        private void Button8_MouseLeave(object sender, EventArgs e)
        {
            button8.Font = new Font(button8.Font.Name, 16, FontStyle.Regular);
            int width = button8.Size.Width;
            int height = button8.Height;
            int change = 20;
            button8.Size = new Size(width - change, height - change);
            button8.Location = new Point(button8.Location.X + (change / 2), button8.Location.Y + (change / 2));


        }

        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Font = new Font(button1.Font.Name, 32, FontStyle.Regular);
            int width = button1.Size.Width;
            int height = button1.Height;
            int change = 20;
            button1.Size = new Size(width + change, height + change);
            button1.Location = new Point(button1.Location.X - (change / 2), button1.Location.Y - (change / 2));

        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Font = new Font(button1.Font.Name, 16, FontStyle.Regular);
            int width = button1.Size.Width;
            int height = button1.Height;
            int change = 20;
            button1.Size = new Size(width - change, height - change);
            button1.Location = new Point(button1.Location.X + (change / 2), button1.Location.Y + (change / 2));

        }

        private void Button2_MouseEnter(object sender, EventArgs e)
        {
            button2.Font = new Font(button2.Font.Name, 32, FontStyle.Regular);
            int width = button2.Size.Width;
            int height = button2.Height;
            int change = 20;
            button2.Size = new Size(width + change, height + change);
            button2.Location = new Point(button2.Location.X - (change / 2), button2.Location.Y - (change / 2));

        }

        private void Button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Font = new Font(button2.Font.Name, 16, FontStyle.Regular);
            int width = button2.Size.Width;
            int height = button2.Height;
            int change = 20;
            button2.Size = new Size(width - change, height - change);
            button2.Location = new Point(button2.Location.X + (change / 2), button2.Location.Y + (change / 2));

        }

        private void Button9_MouseEnter(object sender, EventArgs e)
        {
            button9.Font = new Font(button9.Font.Name, 32, FontStyle.Regular);
            int width = button9.Size.Width;
            int height = button9.Height;
            int change = 20;
            button9.Size = new Size(width + change, height + change);
            button9.Location = new Point(button9.Location.X - (change / 2), button9.Location.Y - (change / 2));

        }

        private void Button9_MouseLeave(object sender, EventArgs e)
        {
            button9.Font = new Font(button9.Font.Name, 16, FontStyle.Regular);
            int width = button9.Size.Width;
            int height = button9.Height;
            int change = 20;
            button9.Size = new Size(width - change, height - change);
            button9.Location = new Point(button9.Location.X + (change / 2), button9.Location.Y + (change / 2));

        }
    }
}
