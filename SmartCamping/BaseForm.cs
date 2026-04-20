using SmartCamping;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            // Subscribe to weather updates
            AppState.Weather.WeatherChanged += UpdateWeatherWarning;
            UpdateWeatherWarning();

            DeliveryTimer.TimerFinished += DeliveryWarning;

            if (Cache.tentExist == false)
            {
                button3.Click -= button3_Click;
                button3.Cursor = Cursors.No;
                button4.Click -= button4_Click;
                button4.Cursor = Cursors.No;
                button5.Click -= button5_Click;
                button5.Cursor = Cursors.No;
                button6.Click -= button6_Click;
                button6.Cursor = Cursors.No;
                button7.Click -= button7_Click;
                button7.Cursor = Cursors.No;
                button8.Click -= button8_Click;
                button8.Cursor = Cursors.No;
                button9.Click -= button9_Click;
                button9.Cursor = Cursors.No;
                button10.Click -= button10_Click;
                button10.Cursor = Cursors.No;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TentSetup tent = new TentSetup();
            tent.Show();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            CanopyPanel canopy = new CanopyPanel();
            canopy.Show();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            LightningPanel lightning = new LightningPanel();
            lightning.Show();
            this.Hide();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            EnergyPanel energy = new EnergyPanel();
            energy.Show();
            this.Hide();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            ShelterPanel shelter = new ShelterPanel();
            shelter.Show();
            this.Hide();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            LandmarksPanel landmarks = new LandmarksPanel();
            landmarks.Show();
            this.Hide();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            WeatherPanel weather = new WeatherPanel();
            weather.Show();
            this.Hide();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                DeliveryTimer.Stop();
                pictureBox1.Visible = false;
                MessageBox.Show("Delivery has arrived\nEnjoy your meal!");
            }

            Category food = new Category();
            food.Show();
            this.Hide();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            EventsPanel events = new EventsPanel();
            events.Show();
            this.Hide();
        }
        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Help button
        private void button11_Click(object sender, EventArgs e)
        {
            ShowHelpTopic();
        }
        protected virtual void ShowHelpTopic()
        {
            // Default help αν δεν γίνει override
            //Help.ShowHelp(this, "SmartCampingHelp.chm");
        }

        // Show warning on Shelter + Weather pics in case of storm
        private void UpdateWeatherWarning()
        {
            if (AppState.Weather.WeatherType == "Stormy")
            {
                picShelterWarning.Visible = true;
                picWeatherWarning.Visible = true;
            }
            else
            {
                picShelterWarning.Visible = false;
                picWeatherWarning.Visible = false;
            }

            if (!AppState.Weather.OptCanopyState(AppState.Weather.CurrentWindDirection, AppState.Weather.CurrentWindSpeed))
            {
                pictureBox2.Visible = true;
            }
        }

        private void DeliveryWarning()
        {
            // UI callback — use Invoke
            if (InvokeRequired)
            {
                Invoke(new Action(DeliveryWarning));
                return;
            }

            pictureBox1.Visible = true;
        }

        public void CanopyWarningClear()
        {
            pictureBox2.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
