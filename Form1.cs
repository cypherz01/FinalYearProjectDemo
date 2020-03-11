
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace FinalYearProjectDemo
{

    class WordObj
    {
        public String word { get; set; }
        public int frequency { get; set; }

        public static WordObj FromCsv(string csvline)
        {
            string[] values = csvline.Split(',');
            WordObj wordObj = new WordObj();

            wordObj.word = values[0];
            wordObj.frequency = Convert.ToInt32(values[1]);
            return wordObj;

    }

    }

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
            public int Id { get; set; }
            public String Button1 { get; set; }
            public String Button2 { get; set; }
            public String Button3 { get; set; }
            public String Button4 { get; set; }
            public String Button5 { get; set; }
            public String Button6 { get; set; }
            public String Button7 { get; set; }
            public String Button8 { get; set; }

        }

        private int layoutNum;
        private int highlightNum;
        private Boolean canClick;
       
        private List<WordObj> words = new List<WordObj>();
        private String currentWord;
        private String layoutFile;

        // populating auto complete buttons
        public void populatePredictingWords(String currentWord)
        {
            List<WordObj> resultList = new List<WordObj>();

            try
            {
                foreach (var item in words)
                {
                    
                    if (item.word.StartsWith(currentWord))
                    {
                        resultList.Add(item);
                        

                    }
                }

                resultList.OrderBy(words => words.frequency);
                
                button10.Text = resultList.ElementAt(0).word;
                button11.Text = resultList.ElementAt(1).word;
                button12.Text = resultList.ElementAt(2).word;
                
            }
            catch (Exception e) { };

        }

        public void loadFiles()
        {
            layoutFile = "layout.JSON";

                words = File.ReadAllLines("words.csv")
                .Select(v => WordObj.FromCsv(v))
                .ToList();

            
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

            
            updateLayout(1);

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
            loadFiles();
            InitializeComponent();
            initializeScreenFormat();

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
                    if (item.Id == id)
                    {
                        button1.Text = item.Button1;
                        button2.Text = item.Button2;
                        button3.Text = item.Button3;
                        button4.Text = item.Button4;
                        button5.Text = item.Button5;
                        button6.Text = item.Button6;
                        button7.Text = item.Button7;
                        button8.Text = item.Button8;
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
            Button b = (Button)sender;
           
            switch (layoutNum)
            {
                case 1:
                    layoutNum = 2;
                    updateLayout(2);
                    break;
                case 7:
                    layoutNum = 8;
                    updateLayout(8);
                    break;
                default:
                    if (!CaplockActive())
                    {
                        SendKeys.Send(b.Text.ToLower());
                        currentWord += b.Text;
                        populatePredictingWords(currentWord);
                        break;
                    }
                    else
                    {
                        SendKeys.Send(b.Text);
                        currentWord += b.Text;
                        populatePredictingWords(currentWord);
                        break;
                    }

            }


        }

        private void Button3_Click(object sender, EventArgs e)
        {

            Button b = (Button)sender;

            switch (layoutNum)
            {
                case 1:
                    layoutNum = 3;
                    updateLayout(3);
                    break;
                case 7:
                    layoutNum = 9;
                    updateLayout(9);
                    break;
                default:
                    if (!CaplockActive())
                    {
                        SendKeys.Send(b.Text.ToLower());
                        currentWord += b.Text;
                        populatePredictingWords(currentWord);
                        break;
                    }
                    else
                    {
                        SendKeys.Send(b.Text);
                        currentWord += b.Text;
                        populatePredictingWords(currentWord);
                        break;
                    }

            }


        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            switch (layoutNum)
            {
                case 1:
                    layoutNum = 4;
                    updateLayout(4);
                    break;
                case 7:
                    layoutNum = 10;
                    updateLayout(10);
                    break;
                default:
                    if (!CaplockActive())
                    {
                        SendKeys.Send(b.Text.ToLower());
                        currentWord += b.Text;
                        populatePredictingWords(currentWord);
                        break;
                    }
                    else
                    {
                        SendKeys.Send(b.Text);
                        currentWord += b.Text;
                        populatePredictingWords(currentWord);
                        break;
                    }

            }

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            switch (layoutNum)
            {
                case 1:
                    layoutNum = 5;
                    updateLayout(5);
                    break;
                case 7:
                    layoutNum = 11;
                    updateLayout(11);
                    break;
                default:
                    if (!CaplockActive())
                    {
                        SendKeys.Send(b.Text.ToLower());
                        currentWord += b.Text;
                        populatePredictingWords(currentWord);
                        break;
                    }
                    else
                    {
                        SendKeys.Send(b.Text);
                        currentWord += b.Text;
                        populatePredictingWords(currentWord);
                        break;
                    }

            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            switch (layoutNum)
            {
                case 1:
                    layoutNum = 6;
                    updateLayout(6);
                    break;
                case 7:
                    layoutNum = 12;
                    updateLayout(12);
                    break;
                default:
                    if (!CaplockActive())
                    {
                        SendKeys.Send(b.Text.ToLower());
                        currentWord += b.Text;
                        populatePredictingWords(currentWord);
                        break;
                    }
                    else
                    {
                        SendKeys.Send(b.Text);
                        currentWord += b.Text;
                        populatePredictingWords(currentWord);
                        break;
                    }

            }
        }


        private void Button7_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            switch (layoutNum)
            {
                case 1:
                    layoutNum = 7;
                    updateLayout(7);
                    break;
                case 7:
                    layoutNum = 13;
                    updateLayout(13);
                    break;
                default:

                    if (!CaplockActive())
                    {
                        SendKeys.Send(b.Text.ToLower());
                        currentWord += b.Text;
                        populatePredictingWords(currentWord);
                        break;
                    }
                    else
                    {
                        SendKeys.Send(b.Text);
                        currentWord += b.Text;
                        populatePredictingWords(currentWord);
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

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            b.Font = new Font(b.Font.Name, 32, FontStyle.Regular);
            int width = b.Size.Width;
            int height = b.Height;
            int change = 20;
            b.Size = new Size(width + change, height + change);
            b.Location = new Point(b.Location.X - (change / 2), b.Location.Y - (change / 2));
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            b.Font = new Font(b.Font.Name, 16, FontStyle.Regular);
            int width = b.Size.Width;
            int height = b.Height;
            int change = 20;
            b.Size = new Size(width - change, height - change);
            b.Location = new Point(b.Location.X + (change / 2), b.Location.Y + (change / 2));
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

        private void autoFillButton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            for (int i = 0; i < currentWord.Length; i++)
            {
                SendKeys.Send("{BACKSPACE}");
            }
            SendKeys.Send(b.Text);
        }

        public static bool CaplockActive()
        {
            return Control.IsKeyLocked(Keys.CapsLock);
        }
    }
}
