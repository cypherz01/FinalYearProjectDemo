
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

        class KeyboardLayout
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
        private List<Panel> panels = new List<Panel>();
        private String currentWord;
        private String layoutFile;
        private int layout;
        private bool CaplockOveride;

        // populating auto complete buttons
        public void populatePredictingWords(String currentWord)
        {
            List<WordObj> resultList = new List<WordObj>();
            try
            {
                foreach (var item in words)
                {
                    if ((item.word.StartsWith(currentWord)) || (item.word.StartsWith(currentWord.ToLowerInvariant())))
                    {
                        resultList.Add(item);
                    }
                }
                resultList.OrderBy(words => words.frequency);
                button10.Text = resultList.ElementAt(0).word;
                button11.Text = resultList.ElementAt(1).word;
                button12.Text = resultList.ElementAt(2).word;
                if (groupBox1.Visible == false)
                {
                    groupBox1.Visible = true;
                }
                layout = 2;
                LoadPanels();
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

        public void LoadPanels()
        {
            panels.Clear();
            highlightNum = -1;
            if (layout == 1)
            {
                panel1.Visible = true;
                panel1.SendToBack();
                panel13.Visible = false;


                panels.Add(panel2);
                panels.Add(panel3);
                panels.Add(panel4);
                panels.Add(panel5);
                panels.Add(panel6);
                panels.Add(panel7);
                panels.Add(panel8);
                panels.Add(panel9);
            }
            else if (layout == 2)
            {
                panel13.Visible = true;
                panel13.SendToBack();
                panel1.Visible = false;
                panels.Add(panel10);
                panels.Add(panel11);
                panels.Add(panel12);
                panels.Add(panel14);
            }
            else if (layout == 3)
            {
                panel1.Visible = true;
                panel1.SendToBack();
                panel13.Visible = false;

                panels.Add(panel2);
                panels.Add(panel3);
                panels.Add(panel4);
                panels.Add(panel5);
            }
            else
            {
                panel1.Visible = true;
                panel1.SendToBack();
                panel13.Visible = false;

                panels.Add(panel2);
                panels.Add(panel3);
                panels.Add(panel4);
                panels.Add(panel5);
                panels.Add(panel6);
                panels.Add(panel7);
            }



        }

        public void initializeScreenFormat()
        {
            CaplockOveride = false;
            layout = 1;
            LoadPanels();

            Timer timer = new Timer { Interval = (1 * 750) };
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();

            // StartPosition was set to FormStartPosition.Manual in the properties window.
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            int w = Width >= screen.Width ? screen.Width : (screen.Width) / 2;
            this.Size = new Size(w, screen.Height);

            updateLayout(1);
            groupBox1.Visible = false;

            layoutNum = 1;
            highlightNum = 0;
            canClick = true;
        }
        public Form1()
        {
            loadFiles();
            InitializeComponent();
            initializeScreenFormat();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (CaplockActive(CaplockOveride))
            {
                label2.Text = "ON";
            }
            else
            {
                label2.Text = "OFF";
            }

            canClick = true;

            if (layout == 2)
            {
                panel13.BackColor = Color.Red;
                highlightNum = (highlightNum + 1) % panels.Count;

                string name = panels.ElementAt(highlightNum).Name;
                panel13.Height = panels.ElementAt(highlightNum).Height;
                panel13.Width = panels.ElementAt(highlightNum).Width;
                panel13.Top = panels.ElementAt(highlightNum).Top + 10;
                panel13.Left = panels.ElementAt(highlightNum).Left + 10;
            }
            else
            {

                panel1.BackColor = Color.Red;
                highlightNum = (highlightNum + 1) % panels.Count;

                string name = panels.ElementAt(highlightNum).Name;
                panel1.Height = panels.ElementAt(highlightNum).Height;
                panel1.Width = panels.ElementAt(highlightNum).Width;
                panel1.Top = panels.ElementAt(highlightNum).Top + 10;
                panel1.Left = panels.ElementAt(highlightNum).Left + 10;

            }
        }

        

        private void updateLayout(int id)
        {
            using (StreamReader r = new StreamReader(layoutFile))
            {
                string json = r.ReadToEnd();
                List<KeyboardLayout> layouts = JsonConvert.DeserializeObject<List<KeyboardLayout>>(json);

                foreach (var item in layouts)
                {
                    if (item.Id == id)
                    {
                        layout = 1;
                        button1.Text = item.Button1;
                        button2.Text = item.Button2;
                        button3.Text = item.Button3;
                        button4.Text = item.Button4;

                        if (item.Button5 != "")
                        {
                            panel6.Visible = true;
                            button5.Text = item.Button5;
                            

                        }
                        else
                        {
                            panel6.Visible = false;
                            layout = 3;
                        }

                        if (item.Button6 != "")
                        {
                            panel7.Visible = true;
                            button6.Text = item.Button6;
                        }
                        else
                        {
                            panel7.Visible = false;
                            
                            
                        }

                        if (item.Button7 != "")
                        {
                            panel8.Visible = true;
                            button7.Text = item.Button7;
                        }
                        else
                        {
                            panel8.Visible = false;
                            if (layout != 3)
                            {
                                layout = 4;
                            }
                            
                        }

                        if (item.Button8 != "")
                        {
                            panel9.Visible = true;
                            button8.Text = item.Button8;
                        }
                        else
                        {
                            panel9.Visible = false;
                            
                        }

                        LoadPanels();
                    }
                }
            }
        }


        private void Button1_Click(object sender, EventArgs e)
        {

            if (layoutNum == 1)
            {
                layoutNum = 14;
                updateLayout(14);
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
                case 14:
                    SendKeys.Send("{BACKSPACE}");
                    break;
                default:
                    if (!CaplockActive(CaplockOveride))
                    {
                        String output = b.Text.ToLower();
                        SendKeys.Send(output);
                        currentWord += b.Text;
                        populatePredictingWords(currentWord);
                        break;
                    }
                    else
                    {
                        String output = b.Text.ToLower();
                        SendKeys.Send(output.ToUpper());
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
                case 14:
                    CaplockOveride = !CaplockOveride;
                    break;
                default:
                    if (!CaplockActive(CaplockOveride))
                    {
                        String output = b.Text.ToLower();
                        SendKeys.Send(output);
                        currentWord += b.Text;
                        populatePredictingWords(currentWord);
                        break;
                    }
                    else
                    {
                        String output = b.Text.ToLower();
                        SendKeys.Send(output.ToUpper());
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
                case 14:
                    if (layoutFile.Equals("layout.JSON"))
                    {
                        layoutFile = "layout2.JSON";
                        layoutNum = 1;
                        updateLayout(1);
                    }
                    else
                    {
                        layoutFile = "layout.JSON";
                        layoutNum = 1;
                        updateLayout(1);
                    }
                    break;
                default:

                    if (layout != 4)
                    {
                        SendKeys.Send(" ");
                        currentWord = "";
                        break;
                    }

                    if (!CaplockActive(CaplockOveride))
                    {
                        String output = b.Text.ToLower();
                        SendKeys.Send(output);
                        currentWord += b.Text;
                        populatePredictingWords(currentWord);
                        break;
                    }
                    else
                    {
                        String output = b.Text.ToLower();
                        SendKeys.Send(output.ToUpper());
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
                    if (!CaplockActive(CaplockOveride))
                    {
                        String output = b.Text.ToLower();
                        SendKeys.Send(output);
                        currentWord += b.Text;
                        populatePredictingWords(currentWord);
                        break;
                    }
                    else
                    {
                        String output = b.Text.ToLower();
                        SendKeys.Send(output.ToUpper());
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
                case 14:
                    this.Close();
                    break;
                default:
                    if (!CaplockActive(CaplockOveride))
                    {
                        String output = b.Text.ToLower();
                        SendKeys.Send(output);
                        currentWord += b.Text;
                        populatePredictingWords(currentWord);
                        break;
                    }
                    else
                    {
                        String output = b.Text.ToLower();
                        SendKeys.Send(output.ToUpper());
                        currentWord += b.Text;
                        populatePredictingWords(currentWord);
                        break;
                    }
            }
        }


        private void Button7_Click(object sender, EventArgs e)
        {
            if (layoutNum == 1)
            {
                groupBox1.Visible = false;
            }

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

                    if (!CaplockActive(CaplockOveride))
                    {
                        String output = b.Text.ToLower();
                        SendKeys.Send(output);
                        currentWord += b.Text;
                        populatePredictingWords(currentWord);
                        break;
                    }
                    else
                    {
                        String output = b.Text.ToLower();
                        SendKeys.Send(output.ToUpper());
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
            if ((e.Button == MouseButtons.Right) && (canClick) && (layout != 2))
            {
                switch (highlightNum)
                {
                    case 0:
                        panel1.BackColor = Color.Yellow;
                        Button1_Click(button1, e);
                        highlightNum = 0;
                        canClick = false;
                        break;
                    case 1:
                        panel1.BackColor = Color.Yellow;
                        Button2_Click(button2, e);
                        highlightNum = -1;
                        canClick = false;
                        break;
                    case 2:
                        panel1.BackColor = Color.Yellow;
                        Button3_Click(button3, e);
                        highlightNum = -1;
                        canClick = false;
                        break;
                    case 3:
                        panel1.BackColor = Color.Yellow;
                        Button4_Click(button4, e);
                        highlightNum = -1;
                        canClick = false;
                        break;
                    case 4:
                        panel1.BackColor = Color.Yellow;
                        Button5_Click(button5, e);
                        highlightNum = -1;
                        canClick = false;
                        break;
                    case 5:
                        panel1.BackColor = Color.Yellow;
                        Button6_Click(button6, e);
                        highlightNum = -1;
                        canClick = false;
                        break;
                    case 6:
                        panel1.BackColor = Color.Yellow;
                        Button7_Click(button7, e);
                        highlightNum = -1;
                        canClick = false;
                        break;
                    case 7:
                        panel1.BackColor = Color.Yellow;
                        Button8_Click(button8, e);
                        highlightNum = -1;
                        canClick = false;
                        break;
                }

            }
            else if ((e.Button == MouseButtons.Right) && (canClick) && (layout == 2))
            {
                switch (highlightNum)
                {
                    case 0:
                        panel13.BackColor = Color.Yellow;
                        autoFillButton_Click(button10, e);
                        highlightNum = 0;
                        canClick = false;
                        layout = 1;
                        layoutNum = 1;
                        LoadPanels();
                        updateLayout(1);
                        break;
                    case 1:
                        panel13.BackColor = Color.Yellow;
                        autoFillButton_Click(button11, e);
                        highlightNum = 0;
                        canClick = false;
                        layout = 1;
                        layoutNum = 1;
                        LoadPanels();
                        updateLayout(1);
                        break;
                    case 2:
                        panel13.BackColor = Color.Yellow;
                        autoFillButton_Click(button12, e);
                        highlightNum = 7;
                        canClick = false;
                        layout = 1;
                        layoutNum = 1;
                        LoadPanels();
                        updateLayout(1);
                        break;
                    case 3:
                        panel13.BackColor = Color.Yellow;
                        canClick = false;
                        layout = 1;
                        layoutNum = 1;
                        LoadPanels();
                        updateLayout(1);
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
            SendKeys.Send(" ");
            currentWord = "";
            groupBox1.Visible = false;
        }

        public static bool CaplockActive(bool overide)
        {
            if (Control.IsKeyLocked(Keys.CapsLock) || (overide == true))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

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
    }

}
