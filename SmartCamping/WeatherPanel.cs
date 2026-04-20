using SmartCamping;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class WeatherPanel : BaseForm
    {
        public WeatherPanel()
        {
            InitializeComponent();
            this.Text = "Weather Panel";
            lblFindShelter.Text = "Warning!\nStorm Detected!";

            // Subscribe method UpdateUI to event WeatherChanged of AppState.Weather
            // so when the timer updates the weather conditions, it will also update the weather panel form
            AppState.Weather.WeatherChanged += UpdateWeatherDisplay;

            // Initial setup of values
            UpdateWeatherDisplay();
        }

        private void UpdateWeatherDisplay()
        {
            lblTemp.Text = $"Current Temperature: {AppState.Weather.CurrentTemperature} °C";
            lblHumidity.Text = $"Current Humidity: {AppState.Weather.CurrentHumidity} %";
            lblWind.Text = $"Current Wind Speed: {AppState.Weather.CurrentWindSpeed} km/h";
            lblSunlight.Text = $"Current Sunlight: {AppState.Weather.CurrentSunlight}%";

            string condition = AppState.Weather.WeatherType;
            lblCondition.Text = $"Current Condition:\n{AppState.Weather.WeatherType}";

            pnlStormWarning.Visible = false;

            if (condition == "Stormy")
            {
                picCondition.BackgroundImage = Image.FromFile("images/symbols/storm.png");

                pnlStormWarning.Visible = true;
            }
            else if (condition == "Sunny")
            {
                picCondition.BackgroundImage = Image.FromFile("images/symbols/weather.png");
            }
            else if (condition == "Partly Sunny")
            {
                picCondition.BackgroundImage = Image.FromFile("images/symbols/partly_sunny.png");
            }
            else
            {
                picCondition.BackgroundImage = Image.FromFile("images/symbols/cloudy.png");
            }

        }

        // Help button
        protected override void ShowHelpTopic()
        {
            MessageBox.Show("Overview:" +
                "This panel displays real-time weather conditions around your campsite." +
                "\nYou can monitor temperature, wind speed, humidity, and sunlight intensity." +
                "\nThe system updates automatically at regular intervals." +
                "\nWhen 'Stormy' weather is detected, a Shelter Warning icon will appear." +
                "\nYou can then press the Shelter button to quickly access nearby shelters."
                    , "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        // Unsubscribe from the event when the form closes
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            AppState.Weather.WeatherChanged -= UpdateWeatherDisplay;
            base.OnFormClosed(e);
        }

        private void btnGoToShelter_Click(object sender, EventArgs e)
        {
            ShelterPanel shelterForm = new ShelterPanel();
            shelterForm.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
