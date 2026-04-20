using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Future_Camping
{
    public partial class Welcome : Form
    {
        int counter = 0;

        public Welcome()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            label1.ForeColor = Color.Transparent;
            label2.ForeColor = Color.Transparent;
            timer1.Start();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Focus(); // or any other control
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter == 4)
            {
                label1.ForeColor = Color.White;
            }
            else if(counter == 5) 
            {
                label1.ForeColor = Color.Gainsboro;
            }
            else if (counter == 6)
            {
                label1.ForeColor = Color.Silver;
            }
            else if (counter == 7)
            {
                label1.ForeColor = Color.Gray;
            }
            else if (counter == 8)
            {
                label1.ForeColor = Color.Black;
            }
            if (counter == 11)
            {
                label2.ForeColor = Color.White;
            }
            else if (counter == 12)
            {
                label2.ForeColor = Color.Gainsboro;
            }
            else if (counter == 13)
            {
                label2.ForeColor = Color.Silver;
            }
            else if (counter == 14)
            {
                label2.ForeColor = Color.Gray;
            }
            else if (counter == 15)
            {
                label2.ForeColor = Color.Black;
            }
            counter++;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TentSetup form = new TentSetup();
            form.Show();
            Hide();
        }
    }
}
