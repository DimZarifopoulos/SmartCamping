using SmartCamping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CanopyPanel : BaseForm
    {
        private string windDirection = AppState.Weather.CurrentWindDirection;
        private void diagCanopy()
        {
            if (Cache.n_canopy && Cache.e_canopy)
                pictureBox4.Visible = true;
            else
                pictureBox4.Visible = false;

            if (Cache.e_canopy && Cache.s_canopy)
                pictureBox7.Visible = true;
            else
                pictureBox7.Visible = false;

            if (Cache.s_canopy && Cache.w_canopy)
                pictureBox6.Visible = true;
            else
                pictureBox6.Visible = false;

            if (Cache.w_canopy && Cache.n_canopy)
                pictureBox5.Visible = true;
            else
                pictureBox5.Visible = false;
        }

        public void WarningMsg()
        {
            richTextBox1.Clear();
            if (windDirection == "North" && !Cache.n_canopy)
            {
                richTextBox1.Text = "It is advised to deploy the northen canopy";
            }
            else if (windDirection == "North-East" && (!Cache.n_canopy && !Cache.e_canopy))
            {
                richTextBox1.Text = "It is advised to deploy both the northen and eastern canopy";
            }
            else if (windDirection == "East" && !Cache.e_canopy)
            {
                richTextBox1.Text = "It is advised to deploy the eastern canopy";
            }
            else if (windDirection == "South-East" && (!Cache.s_canopy && !Cache.e_canopy))
            {
                richTextBox1.Text = "It is advised to deploy both the southern and eastern canopy";
            }
            else if (windDirection == "South" && !Cache.s_canopy)
            {
                richTextBox1.Text = "It is advised to deploy the southern canopy";
            }
            else if (windDirection == "South-West" && (!Cache.s_canopy && !Cache.w_canopy))
            {
                richTextBox1.Text = "It is advised to deploy both the southern and western canopy";
            }
            else if (windDirection == "West" && !Cache.w_canopy)
            {
                richTextBox1.Text = "It is advised to deploy the western canopy";
            }
            else if (windDirection == "Nort-West" && (!Cache.n_canopy && !Cache.w_canopy))
            {
                richTextBox1.Text = "It is advised to deploy both the northen and western canopy";
            }

            if (AppState.Weather.CurrentWindSpeed >= 40)
            {
                richTextBox1.Clear();
                richTextBox1.ForeColor = Color.Red;
                richTextBox1.Text = "Warning: High winds detected. It is not advised to deploy any canopies at present.";
            }

            if (richTextBox1.Text == "")
            {
                richTextBox1.ForeColor = Color.Black;
                CanopyWarningClear();
            }
        }

        private void mouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.Red;   // Change background color
            this.ForeColor = Color.DarkRed;    // Change text color
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;  // Reset to default
            this.ForeColor = SystemColors.ControlText;
        }

        public CanopyPanel()
        {
            InitializeComponent();
            Text = "Canopy Panel";
            load_canopy(this, EventArgs.Empty);

            textBox1.Text = AppState.Weather.CurrentWindSpeed.ToString() + " km/h";
            textBox2.Text = AppState.Weather.CurrentWindDirection;

            WarningMsg();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.Visible = false;
            button13.Visible = true;
            Cache.n_canopy = true;
            diagCanopy();
            WarningMsg();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button20.Visible = false;
            button16.Visible = true;
            Cache.e_canopy = true;
            diagCanopy();
            WarningMsg();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19.Visible = false;
            button14.Visible = true;
            Cache.s_canopy = true;
            diagCanopy();
            WarningMsg();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.Visible = false;
            button15.Visible = true;
            Cache.w_canopy = true;
            diagCanopy();
            WarningMsg();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Visible = false;
            button17.Visible = true;
            Cache.n_canopy = false;
            diagCanopy();
            WarningMsg();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.Visible = false;
            button20.Visible = true;
            Cache.e_canopy = false;
            diagCanopy();
            WarningMsg();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Visible = false;
            button19.Visible = true;
            Cache.s_canopy = false;
            diagCanopy();
            WarningMsg();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Visible = false;
            button18.Visible = true;
            Cache.w_canopy = false;
            diagCanopy();
            WarningMsg();
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            button16.Visible = false;
            button20.Visible = true;
            Cache.e_canopy = false;
            diagCanopy();
            WarningMsg();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            button13.Visible = false;
            button17.Visible = true;
            Cache.n_canopy = false;
            diagCanopy();
            WarningMsg();
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            button15.Visible = false;
            button18.Visible = true;
            Cache.w_canopy = false;
            diagCanopy();
            WarningMsg();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            button14.Visible = false;
            button19.Visible = true;
            Cache.s_canopy = false;
            diagCanopy();
            WarningMsg();
        }

        private void button14_Click_2(object sender, EventArgs e)
        {
            button14.Visible = false;
            button19.Visible = true;
            Cache.s_canopy = false;
            diagCanopy();
            WarningMsg();
        }

        private void button15_Click_2(object sender, EventArgs e)
        {
            button15.Visible = false;
            button18.Visible = true;
            Cache.w_canopy = false;
            diagCanopy();
            WarningMsg();
        }

        private void button13_Click_2(object sender, EventArgs e)
        {
            button13.Visible = false;
            button17.Visible = true;
            Cache.n_canopy = false;
            diagCanopy();
            WarningMsg();
        }
        
        public void load_canopy(object sender, EventArgs e)
        {
            if (Cache.n_canopy)
            {
                button17_Click(sender, e);
            }
            if (Cache.e_canopy)
            {
                button20_Click(sender, e);
            }
            if (Cache.s_canopy)
            {
                button19_Click(sender, e);
            }
            if (Cache.w_canopy)
            {
                button18_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AppState.Weather.OptCanopyState(AppState.Weather.CurrentWindDirection, AppState.Weather.CurrentWindSpeed).ToString());
        }
        protected override void ShowHelpTopic()
        {
            MessageBox.Show("Overview:" +
                "\nThis panel allows you to deploy the tent's canopy depending on your personal needs." +
                "\nThe programm will also prompt you in case there is a change in weather whilst also providing you with the nessecary information so you can act accordingly",
                    "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
