using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace SmartCamping
{
    public partial class ClimateControlPanel : BaseForm
    {
        public ClimateControlPanel()
        {
            InitializeComponent();
            this.Text = "Climate Control Panel";
        }

        private void ClimateControlPanel_Load_1(object sender, EventArgs e)
        {
            // Subscribe method UpdateUI to event WeatherChanged of AppState.Weather
            // so when the timer updates the weather conditions, it will also update the Climate control panel UI
            AppState.Weather.WeatherChanged += UpdateUI;
            UpdateUI();

            panel2.BackgroundImage = Image.FromFile("images/backgrounds/climate_panel.png");
        }
        private void UpdateUI()
        {
            AppState.Climate.ApplySmartMode(AppState.Weather.CurrentTemperature);

            UpdateBaseUI();

            if (AppState.Consumption.AirConditionOn)
            {
                UpdateACUI();
            }
            else if (AppState.Consumption.HeaterOn)
            {
                UpdateHeaterUI();
            }
            else
            {
                UpdateIdleUI();
            }

            UpdateSmartModeUI();
            UpdateTemperatureButtons();

            // Weather info
            lblCurrentWeatherTemperature.Text = $"Weather\nTemperature\n{AppState.Weather.CurrentTemperature}°C";
        }

        // Default appearance
        private void UpdateBaseUI()
        {
            panelAC.BackColor = Color.DimGray;
            panelHeater.BackColor = Color.DimGray;

            btnACTemp.Text = $"{AppState.Climate.AcTemp}°C";
            btnHeaterTemp.Text = $"{AppState.Climate.HeaterTemp}°C";
        }

        // AC ON
        private void UpdateACUI()
        {
            panelAC.BackColor = Color.LimeGreen;
            lblCurrentMode.Text = $"❄️ A/C Mode - {AppState.Climate.AcTemp}°C";
            lblCurrentMode.ForeColor = Color.SpringGreen;

            btnOnAC.Enabled = false;
            btnOffAC.Enabled = true;
            panelAC.Enabled = true;
            panelHeater.Enabled = false;

            btnACSmart.Enabled = true;
            btnHeaterSmart.Enabled = false;

            toolTip1.SetToolTip(panelAC, "Air Conditioning is ON");
            toolTip1.SetToolTip(panelHeater, "Heater is disabled while A/C is on");
        }

        // Heater ON
        private void UpdateHeaterUI()
        {
            panelHeater.BackColor = Color.FromArgb(180, 50, 0);
            lblCurrentMode.Text = $"🔥 Heater Mode - {AppState.Climate.HeaterTemp}°C";
            lblCurrentMode.ForeColor = Color.OrangeRed;

            btnOnHeater.Enabled = false;
            btnOffHeater.Enabled = true;
            panelAC.Enabled = false;
            panelHeater.Enabled = true;

            btnHeaterSmart.Enabled = true;
            btnACSmart.Enabled = false;

            toolTip1.SetToolTip(panelHeater, "Heater is ON");
            toolTip1.SetToolTip(panelAC, "A/C is disabled while Heater is on");
        }

        // AC + Heater off
        private void UpdateIdleUI()
        {
            lblCurrentMode.Text = "🕹️ Climate Control Off";
            lblCurrentMode.ForeColor = Color.Black;

            panelAC.Enabled = true;
            panelHeater.Enabled = true;

            btnOnAC.Enabled = true;
            btnOffAC.Enabled = false;
            btnOnHeater.Enabled = true;
            btnOffHeater.Enabled = false;

            btnACSmart.Enabled = false;
            btnHeaterSmart.Enabled = false;
        }

        // Smart Mode UI
        private void UpdateSmartModeUI()
        {
            bool smartAC = AppState.Consumption.SmartACMode;
            bool smartHeater = AppState.Consumption.SmartHeaterMode;
            double temp = AppState.Weather.CurrentTemperature;

            // UI Changes
            // Default label position (normal mode)
            lblCurrentMode.Location = new Point(290, 56);

            if (smartAC && AppState.Consumption.AirConditionOn)
            {
                if (temp > 28)
                {
                    lblCurrentMode.Text = $"Smart A/C Active - {AppState.Climate.AcTemp}°C";
                    lblCurrentMode.ForeColor = Color.MediumSpringGreen;
                }
                else
                {
                    lblCurrentMode.Text = $"Smart A/C Standby (Temp < 28°C)";
                    lblCurrentMode.ForeColor = Color.Gray;

                    // Move label slightly left
                    lblCurrentMode.Location = new Point(245, 56);
                }
            }
            else if (smartHeater && AppState.Consumption.HeaterOn)
            {
                if (temp < 10)
                {
                    lblCurrentMode.Text = $"Smart Heater Active - {AppState.Climate.HeaterTemp}°C";
                    lblCurrentMode.ForeColor = Color.OrangeRed;
                }
                else
                {
                    lblCurrentMode.Text = $"Smart Heater Standby (Temp > 10°C)";
                    lblCurrentMode.ForeColor = Color.Gray;

                    // Move label slightly left
                    lblCurrentMode.Location = new Point(245, 56);
                }
            }
        }

        // Temp button UI
        private void UpdateTemperatureButtons()
        {
            bool smartAC = AppState.Consumption.SmartACMode;
            bool smartHeater = AppState.Consumption.SmartHeaterMode;

            btnIncreaseACTemp.Enabled = !smartAC && AppState.Consumption.AirConditionOn;
            btnDecreaseACTemp.Enabled = !smartAC && AppState.Consumption.AirConditionOn;
            btnIncreaseHeaterTemp.Enabled = !smartHeater && AppState.Consumption.HeaterOn;
            btnDecreaseHeaterTemp.Enabled = !smartHeater && AppState.Consumption.HeaterOn;
        }

        // Set up buttons
        // AC
        private void btnOnAC_Click(object sender, EventArgs e)
        {
            if (AppState.Consumption.IsLowPowerMode)
            {
                MessageBox.Show("Low power mode is preventing the AC from starting.\nPlease turn off low power mode to continue.", "Energy Saving",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            // If not low power mode -> turn on AC
            AppState.Climate.TurnOnAC();
            UpdateUI();
        }

        private void btnOffAC_Click(object sender, EventArgs e)
        {
            AppState.Climate.TurnOffAll();
            AppState.Consumption.SmartACMode = false;
            UpdateUI();
        }

        private void btnDecreaseACTemp_Click(object sender, EventArgs e)
        {
            AppState.Climate.DecreaseACTemperature();
            UpdateUI();
        }

        private void btnIncreaseACTemp_Click(object sender, EventArgs e)
        {
            AppState.Climate.IncreaseACTemperature();
            UpdateUI();
        }

        // Heater
        private void btnOnHeater_Click(object sender, EventArgs e)
        {
            if (AppState.Consumption.IsLowPowerMode)
            {
                MessageBox.Show("Low power mode is preventing the heater from starting.\nPlease turn off low power mode to continue.", "Energy Saving",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            AppState.Climate.TurnOnHeater();
            UpdateUI();
        }
        private void btnOffHeater_Click(object sender, EventArgs e)
        {
            AppState.Climate.TurnOffAll();
            AppState.Consumption.SmartHeaterMode = false;
            UpdateUI();
        }

        private void btnDecreaseHeaterTemp_Click(object sender, EventArgs e)
        {
            AppState.Climate.DecreaseHeaterTemperature();
            UpdateUI();
        }

        private void btnIncreaseHeaterTemp_Click(object sender, EventArgs e)
        {
            AppState.Climate.IncreaseHeaterTemperature();
            UpdateUI();
        }

        // AC Smart Button
        private void btnACSmart_Click(object sender, EventArgs e)
        {
            // Toggle button
            AppState.Consumption.SmartACMode = !AppState.Consumption.SmartACMode;

            if (AppState.Consumption.SmartACMode)
            {
                MessageBox.Show("Smart A/C enabled.\nTemperature set to 26°C and power reduced by 15% on hot days (>28°C).",
                    "Smart Mode", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Smart A/C disabled.",
                    "Smart Mode", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            UpdateUI();
        }

        // Heater Smart Button
        private void btnHeaterSmart_Click(object sender, EventArgs e)
        {
            AppState.Consumption.SmartHeaterMode = !AppState.Consumption.SmartHeaterMode;

            if (AppState.Consumption.SmartHeaterMode)
            {
                MessageBox.Show("Smart Heater enabled.\nTemperature set to minimum and power reduced by 20% on cold days (<10°C).",
                    "Smart Mode", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Smart Heater disabled.",
                    "Smart Mode", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            UpdateUI();
        }

        // Help button
        protected override void ShowHelpTopic()
        {
            MessageBox.Show("Overview:" +
                "\nThis panel manages the temperature and comfort inside your tent or main area." +
                "\nIt includes Air Conditioning (A/C), Heater, and Smart Mode controls." +
                "\nIt also displays current mode and current temperature." +
                "\n\nFunctions:" +
                "\n- AC controls: Turn on/off, increase/decrease temperature." +
                "\n- Heater controls: Turn on/off, increase/decrease temperature." +
                "\n- AC Smart Mode: sets temperature to 26°C and power reduced by 15% on hot days (>28°C)." +
                "\n- Heater Smart Mode: sets temperature to minimum and power reduced by 20% on cold days (<10°C)" +
                "\n- System disables both features during Low Power Mode.",
                    "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        // Unsubscribe from the event when the form closes
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            AppState.Weather.WeatherChanged -= UpdateUI;
            base.OnFormClosed(e);
        }
    }
}
