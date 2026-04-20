using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class StakePlacement : Form
    {
        public int forceReq;
        public int forceApplied;
        public int direction; // 0 = -40, 1 = -30, 2 = -20, 3 = -10, 4 = 0, 5 = 10, 6 = 20, 7 = 30, 8 = 40
        public int numofStakes = 0;
        public int obstacle;
        public int obstacle_size; // How difficult it is to place the stake
        string[,] stakeImages = { { "-40_1.png", "-40_2.png", "-40_3.png", "-40_4.png" },
            { "-30_1.png", "-30_2.png", "-30_3.png", "-30_4.png" },
            { "-20_1.png", "-20_2.png", "-20_3.png", "-20_4.png" },
            { "-10_1.png", "-10_2.png", "-10_3.png", "-10_4.png" },
            { "0_1.png", "0_2.png", "0_3.png", "0_4.png" },
            { "10_1.png", "10_2.png", "10_3.png", "10_4.png" },
            { "20_1.png", "20_2.png", "20_3.png", "20_4.png" },
            { "30_1.png", "30_2.png", "30_3.png", "30_4.png" },
            { "40_1.png", "40_2.png", "40_3.png", "40_4.png" } };
        public int soil_hardness; // lowest force required to drive stake
        public int stake_toughness; // how much force stake can take before breaking

        public void newStake()
        {
            forceReq = Cache.Rnd.Next(150, 300);
            forceApplied = 0;
            direction = 4;

            obstacle = Cache.Rnd.Next(-4, 5);
            obstacle_size = Cache.Rnd.Next(0, 4);

            soil_hardness = Cache.Rnd.Next(50, 101);
            stake_toughness = Cache.Rnd.Next(110, 250);

            button1.Enabled = true;
            button2.Visible = true;
            button3.Visible = false;
            hScrollBar1.Enabled = true;
            hScrollBar1.Value = 0;
            vScrollBar1.Value = 190;
            textBox1.Text = 10 + "N";
            textBox2.Text = 0 + "°";
            pictureBox1.ImageLocation = "images\\symbols\\stakes\\" + stakeImages[4, 0];
            label4.Visible = false;

            //Troubleshooting values
            textBox3.Text = forceReq.ToString();
            textBox4.Text = obstacle.ToString();
            textBox5.Text = obstacle_size.ToString();
            textBox6.Text = soil_hardness.ToString();
            textBox6.Text = stake_toughness.ToString();
        }

        public StakePlacement()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void StakePlacement_Load(object sender, EventArgs e)
        {
            newStake();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            richTextBox1.Clear();
            int invertedValue = vScrollBar1.Maximum - vScrollBar1.Value;
            textBox1.Text = invertedValue.ToString() + "N";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( Convert.ToInt32( textBox1.Text.Replace("N","") ) > stake_toughness )
            {
                richTextBox1.AppendText("The stake has broken under the applied force!\nTry again with less force.\n");
                //pictureBox1.ImageLocation = "images\\symbols\\stakes\\broken.png";
                button1.Enabled = false;
                hScrollBar1.Enabled = false;
                button2.Visible = true;
            }
            else if ( Convert.ToInt32( textBox1.Text.Replace("N","") ) < soil_hardness )
            {
                richTextBox1.AppendText("The applied force is insufficient to drive the stake into the ground!\nTry applying more force.\n");
            }
            else
            {
                if ((direction - 4) >= (obstacle - obstacle_size) && (direction - 4) <= (obstacle + obstacle_size))
                {
                    richTextBox1.AppendText("Something prevents the stake from securing in place!\nTry different direction or change positions!\n");
                }
                else
                {
                    label4.Visible = false;
                    hScrollBar1.Enabled = false;

                    forceApplied += Convert.ToInt32(textBox1.Text.Replace("N", ""));

                    if (forceApplied < (forceReq / 3))
                    {
                        pictureBox1.ImageLocation = "images\\symbols\\stakes\\" + stakeImages[direction, 1];
                    }
                    else if (forceApplied < (2 * forceReq / 3))
                    {
                        pictureBox1.ImageLocation = "images\\symbols\\stakes\\" + stakeImages[direction, 2];
                    }
                    else
                    {
                        pictureBox1.ImageLocation = "images\\symbols\\stakes\\" + stakeImages[direction, 3];
                        button1.Enabled = false;
                        button2.Visible = false;
                        button3.Visible = true;
                        label1.Text = "Stake is secure!";
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            newStake();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numofStakes += 1;
            if (numofStakes >= 4)
            {
                Cache.tentExist = true;
                MessageBox.Show("You have placed enough stakes to set up a tent!");
                TentSetup form = new TentSetup();
                form.Show();
                Hide();
            }
            else
            {
                newStake();
                label1.Text = "Place stake " + (numofStakes + 1).ToString() + " of 4";
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            richTextBox1.Clear();
            int value = hScrollBar1.Value;

            if (value > -400 && value <= -300)
            {
                direction = 0;
            }
            else if (value > -300 && value <= -200)
            {
                direction = 1;
            }
            else if (value > -200 && value <= -100)
            {
                direction = 2;
            }
            else if (value > -100 && value <= -25)
            {
                direction = 3;
            }
            else if (value > -25 && value <= 25)
            {
                direction = 4;
            }
            else if (value > 25 && value <= 100)
            {
                direction = 5;
            }
            else if (value > 100 && value <= 200)
            {
                direction = 6;
            }
            else if (value > 200 && value <= 300)
            {
                direction = 7;
            }
            else if (value > 300 && value <= 400)
            {
                direction = 8;
            }
            pictureBox1.ImageLocation = "images\\symbols\\stakes\\" + stakeImages[direction, 0];
            textBox2.Text = ( hScrollBar1.Value / 10 ) + "°";
            //textBox2.Text = hScrollBar1.Value.ToString();
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
