using SmartCamping;
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
    public partial class Conditions : Form
    {
        int temperature = Cache.Rnd.Next(35, 41);
        int humidity = Cache.Rnd.Next(55, 100);
        int wind = Cache.Rnd.Next(0, 50);
        int chanceOfRain = Cache.Rnd.Next(20, 61);
        int incline = Cache.Rnd.Next(0, 61);
        string tempmsg;
        string hummsg;
        string windmsg;
        string rainmsg;
        string inclinemsg;

        public Conditions()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            // Random wind direction for future use in the Canopy form
            //string[] options = { "North", "North-East", "East", "South-East", "South", "South-West", "West", "Nort-West" };
            //Random random = new Random();
            //int index = random.Next(options.Length);
            //WeatherConditions weatherConditions = new WeatherConditions();
            //Cache.windDirect = options[index];

            //Cache.windSpeed = wind;
        }

        private void Conditions_Load(object sender, EventArgs e)
        {
            textBox1.Text = AppState.Weather.CurrentTemperature.ToString() + " °C";
            textBox2.Text = AppState.Weather.CurrentHumidity.ToString() + " %";
            textBox3.Text = AppState.Weather.CurrentWindSpeed.ToString() + " km/h";
            textBox4.Text = chanceOfRain.ToString() + " %";
            textBox5.Text = incline.ToString() + " °";
            //Warnimg messages
            // Temperature
            if (temperature < 10)
            {
                button3.Visible = true;
                tempmsg = "The temperature of this area is below the average comfort range";
            }
            else if (temperature > 30)
            {
                button3.Visible = true;
                tempmsg = "The temperature of this area is above the average comfort range";
            }

            // Humidity
            if (humidity < 30)
            {
                button4.Visible = true;
                hummsg = "The humidity of this area is too dry";
            }
            else if (humidity > 70)
            {
                button4.Visible = true;
                hummsg = "The humidity of this area is too high";
            }

            // Wind
            if (wind > 30)
            {
                button5.Visible = true;
                windmsg = "The wind speed of this area is high";
            }

            // Chance of Rain
            if (chanceOfRain > 50)
            {
                button6.Visible = true;
                rainmsg = "The chance of rain in this area is high";
            }

            // Incline
            if (incline > 20)
            {
                button7.Visible = true;
                inclinemsg = "The incline of this area is steep";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tempmsg);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(hummsg);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(windmsg);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rainmsg);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(inclinemsg);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Location form = new Location();
            form.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StakePlacement form = new StakePlacement();
            form.Show();
            Hide();
        }
    }
}
