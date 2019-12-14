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
            button7.Location = new System.Drawing.Point((w / 2) - 400, (screen.Height / 2) - 200);
            button8.Location = new System.Drawing.Point((w / 2) - 400, (screen.Height / 2) + 100);
            button9.Location = new System.Drawing.Point((w/2)-75, (screen.Height/2)-50);



        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
