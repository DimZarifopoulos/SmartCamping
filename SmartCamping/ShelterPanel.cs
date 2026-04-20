using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ShelterPanel : BaseForm
    {
        private Panel infoPanel;
        private Label infoLabel;
        private int selectedRoute = 0;

        List<Point> carCoordinates = new List<Point>();
        int currentStep = 0;
        Timer moveTimer = new Timer();
        public ShelterPanel()
        {
            InitializeComponent();
            this.Text = "Find Shelter";
        }

        private void ShelterPanel_Load(object sender, EventArgs e)
        {
            SetupMap();
            SetupShelters();
            SetupInfoPanel();
            SetupRoutes();
            SetupCar();
            SetupTimer();
        }

        // Map setup
        private void SetupMap()
        {
            PictureBoxMap.BackgroundImage = Image.FromFile("images/backgrounds/map.png");
            PictureBoxMap.BackgroundImageLayout = ImageLayout.Center;
        }

        // Shelter setup - make background transparent
        private void SetupShelters()
        {
            pictureBoxTent.Parent = PictureBoxMap;
            pictureBoxShelter1.Parent = PictureBoxMap;
            pictureBoxShelter2.Parent = PictureBoxMap;
            pictureBoxShelter3.Parent = PictureBoxMap;
            pictureBoxShelter4.Parent = PictureBoxMap;
        }

        // Info Panel setup
        private void SetupInfoPanel()
        {
            infoLabel = new Label
            {
                Text = "You are here",
                Font = new Font("Arial", 10, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            infoPanel = new Panel
            {
                Visible = false,
                BackColor = Color.DarkOliveGreen,
                Size = new Size(80, 50),
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(240, 82)
            };

            infoPanel.Controls.Add(infoLabel);
            PictureBoxMap.Controls.Add(infoPanel);
            infoPanel.BringToFront();
        }

        // Show info panel on hover
        private void pictureBoxTent_MouseEnter(object sender, EventArgs e)
        {
            infoPanel.Visible = true;
        }

        // Hide info panel when not hover
        private void pictureBoxTent_MouseLeave(object sender, EventArgs e)
        {
            infoPanel.Visible = false;
        }

        // Routes setup
        private void SetupRoutes()
        {
            pictureBoxRoute1.Parent = PictureBoxMap;
            pictureBoxRoute2.Parent = PictureBoxMap;
            pictureBoxRoute3.Parent = PictureBoxMap;

            pictureBoxRoute1.Visible = false;
            pictureBoxRoute2.Visible = false;
            pictureBoxRoute3.Visible = false;

            pictureBoxRoute1.Location = new Point(197, 144);

            toolTip1.SetToolTip(pictureBoxRoute1, "Route 1\nClosest shelter");
            toolTip1.SetToolTip(pictureBoxRoute2, "Route 2\n+6 minutes slower");
            toolTip1.SetToolTip(pictureBoxRoute3, "Route 3\nSecond closest shelter");
        }

        // Car setup
        private void SetupCar()
        {
            pictureBoxCar.Parent = PictureBoxMap;
            pictureBoxCar.Visible = false;
        }

        // Timer for moving car setup
        private void SetupTimer()
        {
            moveTimer.Interval = 600;
            moveTimer.Tick -= MoveCar;
            moveTimer.Tick += MoveCar;
        }

        // Show all routes button
        private void btnShowRoutes_Click_1(object sender, EventArgs e)
        {
            PictureBoxMap.BackgroundImage = Image.FromFile("images/backgrounds/map_all_routes.png");

            MessageBox.Show("Please select a route", "Route Selection",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            pictureBoxRoute1.Location = new Point(251, 203);
            pictureBoxRoute1.Visible = true;
            pictureBoxRoute2.Visible = true;
            pictureBoxRoute3.Visible = true;

            selectedRoute = 0;
        }

        // Route 1 button
        private void pictureBoxRoute1_Click(object sender, EventArgs e)
        {
            selectedRoute = 1;

            PictureBoxMap.BackgroundImage = Image.FromFile("images/backgrounds/map_route1.png");

            MessageBox.Show("Route 1 selected.\nFastest route to shelter 1.", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            HideRoutes();
        }

        // Route 2 button
        private void pictureBoxRoute2_Click(object sender, EventArgs e)
        {
            selectedRoute = 2;

            MessageBox.Show("Route 2 selected", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            PictureBoxMap.BackgroundImage = Image.FromFile("images/backgrounds/map_route2.png");

            HideRoutes();
        }

        // Route 3 button - closed
        private void pictureBoxRoute3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Road Closed!\nThere has been a landslide.", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Hide routes
        private void HideRoutes()
        {
            pictureBoxRoute1.Visible = false;
            pictureBoxRoute2.Visible = false;
            pictureBoxRoute3.Visible = false;
        }

        // Start route button
        private void btnStartRoute_Click(object sender, EventArgs e)
        {
            if (selectedRoute == 0)
            {
                MessageBox.Show("Please select a route first!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Disable buttons while route is active
            btnShowRoutes.Enabled = false;
            btnStartRoute.Enabled = false;

            pictureBoxCar.Visible = true;
            SetupCoordinates();

            pictureBoxCar.Location = carCoordinates[0];
            currentStep = 0;
            moveTimer.Start();
        }

        // Coordinates(x,y) for moving car
        private void SetupCoordinates()
        {
            carCoordinates = new List<Point>
            {
                new Point(200, 143),
                new Point(205, 149),
                new Point(213, 153),
                new Point(220, 162),
                new Point(229, 172),
                new Point(236, 171),        // Step 5 -> Weather warning -> Change route
                new Point(240, 173),
                new Point(252, 179),
                new Point(265, 179),
                new Point(279, 180),
                new Point(293, 182),
                new Point(310, 189),
                new Point(308, 196),
                new Point(304, 200),
                new Point(289, 206),
                new Point(279, 211),
                new Point(270, 220),
                new Point(285, 232),
                new Point(298, 239),
                new Point(315, 236),
                new Point(332, 230),
                new Point(349, 232)
            };
        }

        private void MoveCar(object sender, EventArgs e)
        {
            if (currentStep < carCoordinates.Count)
            {
                pictureBoxCar.Location = carCoordinates[currentStep];
                currentStep++;

                if (currentStep == 5 && moveTimer.Enabled) // Weather event
                {
                    moveTimer.Stop();

                    PictureBoxMap.BackgroundImage = Image.FromFile("images/backgrounds/map_route_closed.png");

                    // Different message box depending on route
                    if (selectedRoute == 1)
                    {
                        MessageBox.Show(
                            "Extreme weather conditions have been reported on Route 1!\n" +
                            "Switching to Route 2 for a safer path.",
                            "Weather Alert",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        selectedRoute = 2;
                    }
                    else if (selectedRoute == 2)
                    {
                        MessageBox.Show(
                            "Extreme weather conditions have been reported on Route 1\n" +
                            "You will continue safely via Route 2.",
                            "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    moveTimer.Start();
                }
            }
            else
            {
                moveTimer.Stop();
                MessageBox.Show("You reached the shelter!", "Arrived",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                currentStep = 0;

                selectedRoute = 0;
                pictureBoxCar.Visible = false;
                PictureBoxMap.BackgroundImage = Image.FromFile("images/backgrounds/map.png");

                btnShowRoutes.Enabled = true;
                btnStartRoute.Enabled = true;
            }
        }


        // Help button
        protected override void ShowHelpTopic()
        {
            MessageBox.Show("Overview:" +
                "\nThis panel helps you find the safest and nearest shelters during bad weather." +
                "\n\nFunctions:" +
                "\n- Press 'Show Routes' to view all the available routes." +
                "\n- Select the route you wish to follow." +
                "\n- Press 'Start Route' to begin the trip."
                    , "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
