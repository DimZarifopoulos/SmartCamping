using SmartCamping;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EnergyPanel : BaseForm
    {
        public EnergyPanel()
        {
            InitializeComponent();
            this.Text = "Energy Panel";
            panel2.BackgroundImage = Image.FromFile("images/backgrounds/leaves.png");

            AppState.Climate.ApplySmartMode(AppState.Weather.CurrentTemperature);

            // Subscribe method UpdateUI to event WeatherChanged of AppState.Weather
            // so when the timer updates the weather conditions, it will also update the energy panel
            AppState.Weather.WeatherChanged += UpdateUI;

            // Initial setup of values
            UpdateUI();
        }

        private void EnergyPanel_Load(object sender, EventArgs e)
        {
            // Call manually click events for normal power and low power mode
            if (AppState.Consumption.IsLowPowerMode)
            {
                btnLowPower_Click(null, null);
            }
            else
            {
                btnPowerMode_Click(null, null);
            }
        }

        private void UpdateUI()
        {
            // Panel performance update
            AppState.Panels.UpdatePerformance(AppState.Weather);

            double produced = AppState.Panels.CurrentProduction;
            double consumed = AppState.Consumption.GetTotalConsumption();

            // Battery update - convert kW to kWh -> energy * (tick / 3600.0) 
            if (produced > consumed)
            {
                AppState.Battery.Charge((produced - consumed) * 0.05);      // Κανονικά θα έβαζα (produced - consumed) * (6.0/ 3600.0) για να το μετατρέψω σε kWh αλλά θα είναι πολύ αργό για να φαίνεται αλλαγή στο UI
            }
            else
            {
                AppState.Battery.Discharge((consumed - produced) * 0.05);   // οπότε έβαλα έναν πιο ορατό συντελεστή όπως 0.05
            }

            ShowPanels();
            ShowBattery();
            ShowConsumption();
            ShowDevices();

            LowBattery();
        }

        // Panels info
        private void ShowPanels()
        {
            lblMaxProduction.Text = $"Max Production: {AppState.Panels.MaxProduction} kW";
            lblEfficiency.Text = $"Panel Efficiency: {AppState.Panels.Efficiency}%";
            lblProduction.Text = $"Current Production: {AppState.Panels.CurrentProduction:F2} kW";
            circularBarEfficiency.Value = (int)AppState.Panels.Efficiency;

            if (AppState.Panels.Efficiency < 20)
            {
                circularBarEfficiency.ProgressColor = Color.Red;
            }
            else if (AppState.Panels.Efficiency < 50)
            {
                circularBarEfficiency.ProgressColor = Color.Orange;
            }
            else
            {
                circularBarEfficiency.ProgressColor = Color.Lime;
            }
        }

        // Battery info
        private void ShowBattery()
        {
            lblBatteryCapacity.Text = $"Total Battery Capacity: {AppState.Battery.Capacity} kWh";
            lblBattery.Text = $"Current Battery Levels: {AppState.Battery.Level:F2} kWh ({AppState.Battery.GetChargePercent():F0}%)";
            circularBarBattery.Value = (int)AppState.Battery.GetChargePercent();

            if (AppState.Battery.GetChargePercent() < 20)
            {
                circularBarBattery.ProgressColor = Color.Red;
            }
            else if (AppState.Battery.GetChargePercent() < 50)
            {
                circularBarBattery.ProgressColor = Color.Orange;
            }
            else
            {
                circularBarBattery.ProgressColor = Color.Lime;
            }
        }

        // Consumption info
        private void ShowConsumption()
        {
            lblMaxConsumption.Text = $"Maximum Consumption: {AppState.Consumption.MaxConsumption} kW";
            lblConsumption.Text = $"Current Consumption: {AppState.Consumption.GetTotalConsumption():F2} kW";

            double currentSavings = AppState.Consumption.GetCurrentPowerSaving(AppState.Weather.CurrentTemperature);
            lblEnergySaved.Text = $"Current Energy Saved: {currentSavings:F2} kW";
            circularBarConsuption.Value = (int)AppState.Consumption.GetTotalConsumptionPercent();
        }

        // Show enabled devices
        private void ShowDevices()
        {
            lblBaseLoad.Text = $"{AppState.Consumption.BaseLoad}\nkW";
            toolTip1.SetToolTip(pictureBaseLoad, "Base load");

            // Default label position
            lblACLoad.Location = new Point(142, 72);
            lblHeaterLoad.Location = new Point(208, 72);

            // Change picture of each device depending if it is on or off + show current load

            // Lights
            if (AppState.Consumption.DimLights)
            {
                pictureLights.BackgroundImage = Image.FromFile("images/symbols/dim_lights.png");
                lblLightsLoad.Text = $"{AppState.Consumption.LightsLoad / 2}\nkW";
                toolTip1.SetToolTip(pictureLights, "Lights are dimmed");
            }
            else
            {
                pictureLights.BackgroundImage = Image.FromFile("images/symbols/lights.png");
                lblLightsLoad.Text = $"{AppState.Consumption.LightsLoad}\nkW";
                toolTip1.SetToolTip(pictureLights, "Lights are ON");
            }

            // AC
            if (AppState.Consumption.AirConditionOn)
            {
                // Normal Mode
                pictureAC.BackgroundImage = Image.FromFile("images/symbols/ac1.png");
                toolTip1.SetToolTip(pictureAC, "AC is ON");
                lblACLoad.Text = $"{AppState.Consumption.AirConditionLoad}\nkW";

                // Smart Mode
                if (AppState.Consumption.SmartACMode && AppState.Weather.CurrentTemperature > 28)
                {
                    lblACLoad.Text = $"{AppState.Consumption.AirConditionLoad * 0.85}\nkW";         // -15%

                    // Move label slightly left
                    lblACLoad.Location = new Point(135, 72);
                }
                // Stand by Mode
                else if (AppState.Consumption.SmartACMode && AppState.Weather.CurrentTemperature <= 28)
                {
                    pictureAC.BackgroundImage = Image.FromFile("images/symbols/ac_standby.png");
                    lblACLoad.Text = "0\nkw";
                    toolTip1.SetToolTip(pictureAC, "AC is on Stand by");
                }
            }
            //Off
            else
            {
                pictureAC.BackgroundImage = Image.FromFile("images/symbols/ac_off.png");
                lblACLoad.Text = "0\nkw";
                toolTip1.SetToolTip(pictureAC, "AC is Off");
            }

            // Heater
            if (AppState.Consumption.HeaterOn)
            {
                // Normal Mode
                pictureHeater.BackgroundImage = Image.FromFile("images/symbols/heater.png");
                toolTip1.SetToolTip(pictureHeater, "Heater is ON");
                lblHeaterLoad.Text = $"{AppState.Consumption.HeaterLoad}\nkW";

                // Smart Mode
                if (AppState.Consumption.SmartHeaterMode && AppState.Weather.CurrentTemperature < 10)
                {
                    lblHeaterLoad.Text = $"{AppState.Consumption.HeaterLoad * 0.8}\nkW";        // -20%

                    // Move label slightly left
                    lblHeaterLoad.Location = new Point(203, 72);
                }
                // Stand by Mode
                else if (AppState.Consumption.SmartHeaterMode && AppState.Weather.CurrentTemperature >= 10)
                {
                    pictureHeater.BackgroundImage = Image.FromFile("images/symbols/heater_standby.png");
                    lblHeaterLoad.Text = "0\nkw";
                    toolTip1.SetToolTip(pictureHeater, "Heater is on Stand by");
                }
            }
            // Off
            else
            {
                pictureHeater.BackgroundImage = Image.FromFile("images/symbols/heater_off.png");
                lblHeaterLoad.Text = "0\nkw";
                toolTip1.SetToolTip(pictureHeater, "Heater is Off");
            }
        }


        // Low battery message
        private void LowBattery()
        {
            if (AppState.Battery.GetChargePercent() < 20)
            {
                MessageBox.Show("Battery levels are low! Enable low power mode immediately!", "Low Battery Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Normal Power Mode
        private void btnPowerMode_Click(object sender, EventArgs e)
        {
            AppState.Consumption.DisableLowPowerMode();

            // Update UI
            btnPowerMode.BackColor = Color.SkyBlue;
            panelNormalMode.BackColor = Color.SkyBlue;
            btnPowerMode.Enabled = false;

            btnLowPower.BackColor = Color.DimGray;
            panelLowMode.BackColor = Color.DimGray;
            btnLowPower.Enabled = true;

            MessageBox.Show("Normal Mode Enabled!", "Current Mode",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            UpdateUI();
        }

        // Low Power Mode
        private void btnLowPower_Click(object sender, EventArgs e)
        {
            AppState.Consumption.EnableLowPowerMode();

            // Update UI
            btnLowPower.BackColor = Color.FromArgb(180, 50, 0);
            panelLowMode.BackColor = Color.FromArgb(180, 50, 0);
            btnLowPower.Enabled = false;

            btnPowerMode.BackColor = Color.DimGray;
            panelNormalMode.BackColor = Color.DimGray;
            btnPowerMode.Enabled = true;

            MessageBox.Show("Low Power Mode Enabled!\n\n- A/C Off\n- Heater Off\n- Lights Dimmed",
                "Power Mode", MessageBoxButtons.OK, MessageBoxIcon.Information);

            UpdateUI();
        }

        // Climate control panel
        private void btnCliamateControl_Click(object sender, EventArgs e)
        {
            this.Location = new Point(
                (Screen.PrimaryScreen.WorkingArea.Width / 2) - this.Width - 5,
                (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2
            );

            ClimateControlPanel form = new ClimateControlPanel();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(
                this.Location.X + this.Width + 10,
                this.Location.Y
            );
            form.Show();
        }

        // Help button
        protected override void ShowHelpTopic()
        {
            MessageBox.Show("Overview:" +
                "\nThis panel allows you to monitor and manage your campsite’s energy system." +
                "\nYou can view solar energy generation, battery storage, and power consumption in real time." +
                "\nIn the devices panel you can see which devices are turned on/ off and their current consumption" +
                "\n\nFunctions:" +
                "\n- 'Low Power Mode' reduces system consumption by turning off A/C, heater and lights get dimmed." +
                "\n- 'Normal Power Mode' reverts back devices." +
                "\n- 'Climate Control Panel' opens a panel where you can control the climate devices",
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
