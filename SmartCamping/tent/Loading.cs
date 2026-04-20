using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Future_Camping
{
    public partial class Loading : Form
    {
        int counter = 0;
        int counter2 = 0;
        int delay = Cache.Rnd.Next(1, 5);
        public Loading()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            timer1.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {}

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter == 1)
            {
                richTextBox1.ForeColor = Color.Gainsboro;
                pictureBox2.Hide();
            } 
            else if (counter == 2){
                richTextBox1.ForeColor = Color.Silver;
            }
            else if (counter == 3)
            {
                richTextBox1.ForeColor = Color.Gray;
            }
            else if (counter == 4)
            {
                richTextBox1.ForeColor = Color.Black;
            }
            else if (counter == 6)
            {
                richTextBox1.ForeColor = Color.Gray;
                pictureBox2.Show();
            }
            else if (counter == 7)
            {
                richTextBox1.ForeColor = Color.Silver;
            }
            else if (counter == 8)
            {
                richTextBox1.ForeColor = Color.Gainsboro;
                counter = 0;
                counter2++;
            }
            counter++;
            if (counter2 == delay)
            {
                Location form = new Location();
                form.Show();
                Hide();
                timer1.Stop();
            }
        }

        private void Loading_Load(object sender, EventArgs e)
        {
        }
    }
}
