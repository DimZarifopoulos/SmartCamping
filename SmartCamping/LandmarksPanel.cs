using SmartCamping;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LandmarksPanel : BaseForm
    {
        private Panel infoPanel;
        private Label infoLabel;
        List<Point> BikeCoordinates = new List<Point>();
        List<Point> ForestCoordinates = new List<Point>();
        List<Point> MountainCoordinates = new List<Point>();
        List<Point> BeachCoordinates = new List<Point>();
        List<Point> CaveCoordinates = new List<Point>();

        private List<Point> carCoordinates; // Current route
        private int selectedRoute = 0;

        int currentStep = 0;
        Timer moveTimer = new Timer();

        private AttractionInfo currentInfoForm;

        public LandmarksPanel()
        {
            InitializeComponent();
            this.Text = "Nearby Landmarks";
        }

        private void LandmarksPanel_Load(object sender, EventArgs e)
        {
            SetupAttractions();
            SetupInfoPanel();
            SetupComboAttractions();
            SetupCar();
            SetupTimer();
            SetupCoordinates();
        }
        private void SetupAttractions()
        {
            PictureBoxMap.BackgroundImage = Image.FromFile("images/backgrounds/map.png");

            pictureBoxTent.Parent = PictureBoxMap;
            pictureBoxCave.Parent = PictureBoxMap;
            pictureBoxForest.Parent = PictureBoxMap;
            pictureBoxBeach.Parent = PictureBoxMap;
            pictureBoxBike.Parent = PictureBoxMap;
            pictureBoxClimbing.Parent = PictureBoxMap;
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

        // Combo box setup
        private void SetupComboAttractions()
        {
            comboAttractions.Items.Add("Select attraction...");
            comboAttractions.Items.Add("Bike Track");
            comboAttractions.Items.Add("Strofylia Forest");
            comboAttractions.Items.Add("Mountain Climbing");
            comboAttractions.Items.Add("Elafonisi Beach");
            comboAttractions.Items.Add("Diros Cave");

            comboAttractions.SelectedIndex = 0;
        }

        // Combo box 
        private void comboAttractions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboAttractions.SelectedIndex == 1) // Bike Track
            {
                PictureBoxMap.BackgroundImage = Image.FromFile("images/backgrounds/map_bike.png");
                selectedRoute = 1;
            }
            else if (comboAttractions.SelectedIndex == 2) // Forest
            {
                PictureBoxMap.BackgroundImage = Image.FromFile("images/backgrounds/map_forest.png");
                selectedRoute = 2;
            }
            else if (comboAttractions.SelectedIndex == 3) // Mountain
            {
                PictureBoxMap.BackgroundImage = Image.FromFile("images/backgrounds/map_mountain.png");
                selectedRoute = 3;
            }
            else if (comboAttractions.SelectedIndex == 4) // Beach
            {
                PictureBoxMap.BackgroundImage = Image.FromFile("images/backgrounds/map_beach.png");
                selectedRoute = 4;
            }
            else if (comboAttractions.SelectedIndex == 5) // Cave
            {
                PictureBoxMap.BackgroundImage = Image.FromFile("images/backgrounds/map_cave.png");
                selectedRoute = 5;
            }
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

        // Coordinates(x,y) for moving car
        private void SetupCoordinates()
        {
            BikeCoordinates = new List<Point>
            {
                new Point(200, 143),
                new Point(213, 153),
                new Point(220, 162),
                new Point(229, 172),
                new Point(240, 186),
                new Point(246, 200),
                new Point(269, 213),
                new Point(281, 226),
                new Point(288, 241),
                new Point(309, 239),
                new Point(322, 232),
                new Point(349, 229),
                new Point(372, 216),
                new Point(387, 199),
                new Point(388, 183),
                new Point(393, 171),
                new Point(401, 152),
                new Point(410, 136)
            };

            ForestCoordinates = new List<Point>
            {
                new Point(200, 143),
                new Point(213, 153),
                new Point(220, 162),
                new Point(229, 172),
                new Point(236, 171),
                new Point(243, 178),
                new Point(265, 178),
                new Point(284, 182),
                new Point(304, 184),
            };

            MountainCoordinates = new List<Point>
            {
                new Point(200, 143),
                new Point(213, 153),
                new Point(220, 162),
                new Point(229, 172),
                new Point(238, 186),
                new Point(246, 200),
                new Point(260, 213),
                new Point(276, 235),
                new Point(276, 249),
                new Point(276, 265),
                new Point(276, 281),
                new Point(259, 295),
            };

            BeachCoordinates = new List<Point>
            {
                new Point(200, 143),
                new Point(181, 124),
                new Point(168, 115),
                new Point(150, 107),
                new Point(139, 95),
                new Point(130, 87),
                new Point(117, 71),
                new Point(125, 63),
                new Point(139, 48),
                new Point(152, 34),
                new Point(168, 32),
                new Point(192, 36),
                new Point(214, 36),
                new Point(238, 35),
                new Point(265, 36),
                new Point(280, 42),
                new Point(297, 51),
                new Point(318, 63),
                new Point(337, 78),
                new Point(358, 78)
            };

            CaveCoordinates = new List<Point>
            {
                new Point(200, 143),
                new Point(181, 124),
                new Point(168, 115),
                new Point(150, 107),
                new Point(139, 95),
                new Point(130, 87),
                new Point(117, 71),
                new Point(102, 64),
                new Point(77, 60)
            };
        }

        private void btnStartRoute_Click(object sender, EventArgs e)
        {
            if (selectedRoute == 0)
            {
                MessageBox.Show("Please select a route first!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedRoute == 1)
            {
                carCoordinates = BikeCoordinates;
            }
            else if (selectedRoute == 2)
            {
                carCoordinates = ForestCoordinates;
            }
            else if (selectedRoute == 3)
            {
                carCoordinates = MountainCoordinates;
            }
            else if (selectedRoute == 4)
            {
                carCoordinates = BeachCoordinates;
            }
            else if (selectedRoute == 5)
            {
                carCoordinates = CaveCoordinates;
            }

            // Disable buttons while route is active
            SetAttractionsEnabled(false);

            pictureBoxCar.Visible = true;

            pictureBoxCar.Location = carCoordinates[0];
            currentStep = 0;
            moveTimer.Start();
        }

        private void MoveCar(object sender, EventArgs e)
        {
            if (currentStep < carCoordinates.Count)
            {
                pictureBoxCar.Location = carCoordinates[currentStep];
                currentStep++;
            }
            else
            {
                moveTimer.Stop();
                MessageBox.Show("You reached your destination!", "Arrived",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                currentStep = 0;

                selectedRoute = 0;
                pictureBoxCar.Visible = false;
                PictureBoxMap.BackgroundImage = Image.FromFile("images/backgrounds/map.png");

                // Re enable buttons 
                SetAttractionsEnabled(true);
            }
        }

        private void SetAttractionsEnabled(bool enabled)
        {
            pictureBoxBike.Enabled = enabled;
            pictureBoxForest.Enabled = enabled;
            pictureBoxClimbing.Enabled = enabled;
            pictureBoxBeach.Enabled = enabled;
            pictureBoxCave.Enabled = enabled;

            comboAttractions.Enabled = enabled;
            btnStartRoute.Enabled = enabled;
        }

        // Attractions click
        private void pictureBoxBike_Click(object sender, EventArgs e)
        {
            PictureBoxMap.BackgroundImage = Image.FromFile("images/backgrounds/map_bike.png");
            selectedRoute = 1;

            // Close AttractionInfo form if already open
            if (currentInfoForm != null)
            {
                currentInfoForm.Close();
            }

            currentInfoForm = new AttractionInfo("images/attractions/bike_track.png",
                "Green Trail Bike Track\n\n" +
                "A circular route through hills and open meadows, perfect for mountain biking or a relaxed ride. " +
                "There are rest stops along the way and scenic lake views.\n\n" +
                "Distance from camp: 2.0 km\n" +
                "Entrance: Free\n\n" +
                "Tips: Check your brakes before starting, bring water and a helmet. The sunset at the end of the trail is spectacular!");

            currentInfoForm.Location = new Point(this.Right + 10, this.Top);
            currentInfoForm.Show();
        }

        private void pictureBoxForest_Click(object sender, EventArgs e)
        {
            PictureBoxMap.BackgroundImage = Image.FromFile("images/backgrounds/map_forest.png");
            selectedRoute = 2;

            // Close AttractionInfo form if already open
            if (currentInfoForm != null)
            {
                currentInfoForm.Close();
            }

            currentInfoForm = new AttractionInfo("images/attractions/forest_trail.png",
                "Strofylia Forest\n\n" +
                "The largest pine forest in Greece, extending over a large area that includes wetlands and ends right at the sea coast. " +
                "You’ll encounter birds, small streams, and clearings perfect for picnics.\n\n" +
                "Distance from camp: 1 km\n" +
                "Entrance: Free\n\n" +
                "Tips: Bring mosquito repellent and water. Visit in the morning or late afternoon for cooler weather and beautiful light.");

            currentInfoForm.Location = new Point(this.Right + 10, this.Top);
            currentInfoForm.Show();
        }

        private void pictureBoxClimbing_Click(object sender, EventArgs e)
        {
            PictureBoxMap.BackgroundImage = Image.FromFile("images/backgrounds/map_mountain.png");
            selectedRoute = 3;

            // Close AttractionInfo form if already open
            if (currentInfoForm != null)
            {
                currentInfoForm.Close();
            }

            currentInfoForm = new AttractionInfo("images/attractions/mountain.png",
                "Eagle’s Peak Climbing Site\n\n" +
                "A steep rocky area suitable for both beginners and experienced climbers, offering a breathtaking view from the top. " +
                "Equipment and instructors are available on site.\n\n" +
                "Distance from camp: 3 km\n" +
                "Entrance: €10 (includes basic gear)\n\n" +
                "Tips: Book in advance, wear gloves and sturdy shoes. Don’t forget your camera, the view is amazing!");

            currentInfoForm.Location = new Point(this.Right + 10, this.Top);
            currentInfoForm.Show();
        }

        private void pictureBoxBeach_Click(object sender, EventArgs e)
        {
            PictureBoxMap.BackgroundImage = Image.FromFile("images/backgrounds/map_beach.png");
            selectedRoute = 4;

            // Close AttractionInfo form if already open
            if (currentInfoForm != null)
            {
                currentInfoForm.Close();
            }

            currentInfoForm = new AttractionInfo("images/attractions/elafonisi.png",
                "Elafonisi Beach\n\n" +
                "A clean, sandy beach with shallow waters and a calm atmosphere. " +
                "You can swim, sunbathe, or enjoy water sports such as canoeing and paddle boarding.\n\n" +
                "Distance from camp: 2.5 km\n" +
                "Entrance: Free\n\n" +
                "Tips: Go early to find shade, bring sunscreen and a hat. There’s a small beach bar with cold drinks.");

            currentInfoForm.Location = new Point(this.Right + 10, this.Top);
            currentInfoForm.Show();
        }

        private void pictureBoxCave_Click(object sender, EventArgs e)
        {
            PictureBoxMap.BackgroundImage = Image.FromFile("images/backgrounds/map_cave.png");
            selectedRoute = 5;

            // Close AttractionInfo form if already open
            if (currentInfoForm != null)
            {
                currentInfoForm.Close();
            }

            currentInfoForm = new AttractionInfo("images/attractions/cave.png",
                "Diros Cave\n\n" +
                "A stunning natural cave filled with stalactites and stalagmites, softly lit for safe exploration. " +
                "You can take a guided tour and learn about the area’s geology.\n\n" +
                "Distance from camp: 1.5 km\n" +
                "Entrance: €5 (free for children under 12)\n\n" +
                "Tips: Wear comfortable shoes and bring a light jacket. A flashlight makes the experience even better.");

            currentInfoForm.Location = new Point(this.Right + 10, this.Top);
            currentInfoForm.Show();
        }

        // Help button
        protected override void ShowHelpTopic()
        {
            MessageBox.Show("Overview:" +
                "\nDiscover and explore attractions and points of interest around the camping area." +
                "\nEach landmark shows detailed information, an image, and tips." +
                "\n\nFunctions:" +
                "\n- View all available attractions on the map, or use the dropdown list to quickly select them." +
                "\n- Click on a landmark to open an info window with image and description." +
                "\n- Press 'Start Route' to travel to the selected attraction." +
                "\n- A new info form opens side-by-side without closing the existing one, displaying the attractin's info.",
                    "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
