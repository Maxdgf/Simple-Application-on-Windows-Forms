using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstC_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            return;
        }
        private void btnChangeText_clicked(object sender, EventArgs e)
        {
            string outputTxTValue = textBox1.Text;
            label2.Text = outputTxTValue;
        }
        private void btnChangeBGColor_clicked(object sender, EventArgs e)
        {
            Random rndMethod = new Random();
            int first = rndMethod.Next(0, 255);
            int second = rndMethod.Next(0, 255);
            int third = rndMethod.Next(0, 255);
            this.BackColor = Color.FromArgb(first, second, third);
            this.Refresh();
        }
        private void btnChangeTextColor_clicked(object sender, EventArgs e)
        {
            string outputColorTextValue = textBox2.Text;

            if (outputColorTextValue == "green")
            {
                label2.ForeColor = Color.Green;
            }
            else
            {
                label5.Text = "Color is not defined!";
            }

            if (outputColorTextValue == "red")
            {
                label2.ForeColor = Color.Red;
            }
            else
            {
                label5.Text = "Color is not defined!";
            }

            if (outputColorTextValue == "yellow")
            {
                label2.ForeColor = Color.Yellow;
            }
            else
            {
                label5.Text = "Color is not defined!";
            }

            if (outputColorTextValue == "orange")
            {
                label2.ForeColor = Color.Orange;
            }
            else
            {
                label5.Text = "Color is not defined!";
            }

            if (outputColorTextValue == "blue")
            {
                label2.ForeColor = Color.Blue;
            }
            else
            {
                label5.Text = "Color is not defined";
            }
        }
    }
}
