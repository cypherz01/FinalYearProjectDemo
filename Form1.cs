using Newtonsoft.Json;
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

        //create parameters
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;
                return param;
            }
        }

        class keyboardLayout
        {
            public int id { get; set; }
            public String button1 { get; set; }
            public String button2 { get; set; }
            public String button3 { get; set; }
            public String button4 { get; set; }
            public String button5 { get; set; }
            public String button6 { get; set; }
            public String button7 { get; set; }
            public String button8 { get; set; }

        }

        private int layoutNum;
        private int highlightNum;
        private Boolean canClick;
        private List<string> words = new List<string>();
        private String currentWord;
        private String layoutFile;

        // populating auto complete buttons
        public void populatePredictingWords(String currentWord)
        {
            var resultList = from name in words
                             where name.StartsWith(currentWord)
                             select name;

            try
            {
                button10.Text = resultList.ElementAt(1);
                button11.Text = resultList.ElementAt(2);
                button12.Text = resultList.ElementAt(3);
                
            }
            catch (Exception e) { };

        }

        public void initializeScreenFormat()
        {
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
        public Form1()
        {
            InitializeComponent();
            initializeScreenFormat();

            var  WordsFile = File.ReadAllLines("C:\\Users\\csf16cut\\source\\repos\\cypherz01\\FinalYearProjectDemo\\words.txt");
            layoutFile = "C:\\Users\\csf16cut\\source\\repos\\cypherz01\\FinalYearProjectDemo\\Layout.JSON";
            words = new List<string>(WordsFile);

            


            
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
                    




                }
            }

        }

        private void updateLayout(int id)
        {
            using (StreamReader r = new StreamReader(layoutFile))
            {
                string json = r.ReadToEnd();
                List<keyboardLayout> layouts = JsonConvert.DeserializeObject<List<keyboardLayout>>(json);

                foreach (var item in layouts)
                {
                    if (item.id == id)
                    {
                        button1.Text = item.button1;
                        button2.Text = item.button2;
                        button3.Text = item.button3;
                        button4.Text = item.button4;
                        button5.Text = item.button5;
                        button6.Text = item.button6;
                        button7.Text = item.button7;
                        button8.Text = item.button8;
                    }
                }
            }
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            if (layoutNum == 1)
            {
                layoutNum = 6;
                updateLayout(6);
            }
            else
            {
                layoutNum = 1;
                updateLayout(1);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            switch (layoutNum)
            {
                case 1:
                    layoutNum = 2;
                    updateLayout(2);
                    break;
                case 2:
                    SendKeys.Send("a");
                    currentWord += "a";
                    populatePredictingWords(currentWord);
                    
                    break;
                case 3:
                    SendKeys.Send("g");
                    currentWord += "g";
                    populatePredictingWords(currentWord);
                    break;
                case 4:
                    SendKeys.Send("m");
                    currentWord += "m";
                    populatePredictingWords(currentWord);
                    break;
                case 5:
                    SendKeys.Send("s");
                    currentWord += "s";
                    populatePredictingWords(currentWord);
                    break;
                case 6:
                    SendKeys.Send("y");
                    currentWord += "y";
                    populatePredictingWords(currentWord);
                    break;
                case 7:
                    layoutNum = 8;
                    updateLayout(8);
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
                    updateLayout(3);
                    break;
                case 2:
                    SendKeys.Send("b");
                    currentWord += "b";
                    populatePredictingWords(currentWord);
                    break;
                case 3:
                    SendKeys.Send("h");
                    currentWord += "h";
                    populatePredictingWords(currentWord);
                    break;
                case 4:
                    SendKeys.Send("n");
                    currentWord += "n";
                    populatePredictingWords(currentWord);
                    break;
                case 5:
                    SendKeys.Send("t");
                    currentWord += "t";
                    populatePredictingWords(currentWord);
                    break;
                case 6:
                    SendKeys.Send("z");
                    currentWord += "z";
                    populatePredictingWords(currentWord);
                    break;
                case 7:
                    layoutNum = 9;
                    updateLayout(9);
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
                    updateLayout(4);
                    break;
                case 2:
                    SendKeys.Send("c");
                    currentWord += "c";
                    populatePredictingWords(currentWord);
                    break;
                case 3:
                    SendKeys.Send("i");
                    currentWord += "i";
                    populatePredictingWords(currentWord);
                    break;
                case 4:
                    SendKeys.Send("o");
                    currentWord += "o";
                    populatePredictingWords(currentWord);
                    break;
                case 5:
                    SendKeys.Send("u");
                    currentWord += "u";
                    populatePredictingWords(currentWord);
                    break;
                case 7:
                    layoutNum = 10;
                    updateLayout(10);
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
                    updateLayout(5);
                    break;
                case 2:
                    SendKeys.Send("d");
                    currentWord += "d";
                    populatePredictingWords(currentWord);

                    break;
                case 3:
                    SendKeys.Send("j");
                    currentWord += "j";
                    populatePredictingWords(currentWord);
                    break;
                case 4:
                    SendKeys.Send("p");
                    currentWord += "p";
                    populatePredictingWords(currentWord);
                    break;
                case 5:
                    SendKeys.Send("v");
                    currentWord += "v";
                    populatePredictingWords(currentWord);
                    break;
                case 7:
                    layoutNum = 11;
                    updateLayout(11);
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
                    updateLayout(6);
                    break;
                case 2:
                    SendKeys.Send("e");
                    currentWord += "e";
                    populatePredictingWords(currentWord);
                    break;
                case 3:
                    SendKeys.Send("k");
                    currentWord += "k";
                    populatePredictingWords(currentWord);
                    break;
                case 4:
                    SendKeys.Send("q");
                    currentWord += "q";
                    populatePredictingWords(currentWord);
                    break;
                case 5:
                    SendKeys.Send("w");
                    currentWord += "w";
                    populatePredictingWords(currentWord);
                    break;
                case 7:
                    layoutNum = 12;
                    updateLayout(12);
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
                    updateLayout(7);
                    break;
                case 2:
                    SendKeys.Send("f");
                    currentWord += "f";
                    populatePredictingWords(currentWord);
                    break;
                case 3:
                    SendKeys.Send("l");
                    currentWord += "l";
                    populatePredictingWords(currentWord);
                    break;
                case 4:
                    SendKeys.Send("r");
                    currentWord += "r";
                    populatePredictingWords(currentWord);
                    break;
                case 5:
                    SendKeys.Send("x");
                    currentWord += "x";
                    populatePredictingWords(currentWord);
                    break;
                case 7:
                    layoutNum = 13;
                    updateLayout(13);
                    break;
                case 13:
                    SendKeys.Send("\\");
                    break;

            }


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Tab)&&(canClick))
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
                


            }
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            SendKeys.Send(" ");
            currentWord = "";

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

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Left) && (canClick))
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
                  


                }
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < currentWord.Length; i++)
            {
                SendKeys.Send("{BACKSPACE}");
            }
            SendKeys.Send(button10.Text);
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < currentWord.Length; i++)
            {
                SendKeys.Send("{BACKSPACE}");
            }
            SendKeys.Send(button11.Text);

        }

        private void Button12_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < currentWord.Length; i++)
            {
                SendKeys.Send("{BACKSPACE}");
            }
            SendKeys.Send(button12.Text);
        }
    }
}
