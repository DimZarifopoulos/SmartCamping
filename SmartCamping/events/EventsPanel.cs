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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class EventsPanel : BaseForm
    {
        System.Windows.Forms.ToolTip eventTip = new System.Windows.Forms.ToolTip();
        public EventsPanel()
        {
            InitializeComponent();
            this.Text = "Events";

            PopulateEvents();

            eventTip.AutoPopDelay = 5000;
            eventTip.InitialDelay = 200;
            eventTip.ReshowDelay = 100;
            eventTip.ShowAlways = true;

        }

        private void PopulateEvents()
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var ev in EventDatabase.Events)
            {
                Panel card = new Panel
                {
                    Width = 320,
                    Height = 70,
                    Margin = new Padding(9),
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    Tag = ev
                };

                Label lblTitle = new Label
                {
                    Text = ev.Name,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Location = new Point(10, 6),
                    AutoSize = false,
                    Width = 300,
                    Height = 22
                };

                Label lblDate = new Label
                {
                    Text = ev.Date.ToString("ddd, MMM d @ HH:mm"),
                    Font = new Font("Segoe UI", 9),
                    Location = new Point(10, 30),
                    AutoSize = false,
                    Width = 300,
                    Height = 18,
                    ForeColor = Color.DimGray
                };

                Label lblRegister = new Label
                {
                    Text = ev.Registered ? "Registered" : "Click to Register",
                    Font = new Font("Segoe UI", 8, FontStyle.Italic),
                    Location = new Point(10, 50),
                    AutoSize = false,
                    Width = 300,
                    Height = 15,
                    ForeColor = ev.Registered ? Color.Green : Color.Blue
                };

                card.Controls.Add(lblTitle);
                card.Controls.Add(lblDate);
                card.Controls.Add(lblRegister);
                flowLayoutPanel1.Controls.Add(card);

                // Tooltip method
                void ShowTip(Control ctrl)
                {
                    var info = (EventInfo)card.Tag;
                    eventTip.SetToolTip(ctrl, $"{info.Name}\nTime: {info.Date}\n\n{info.Description}");
                }

                // Panel hover
                card.MouseEnter += (s, e) => ShowTip(card);

                // Labels hover (enable tooltip when hovering labels too)
                lblTitle.MouseEnter += (s, e) => ShowTip(lblTitle);
                lblDate.MouseEnter += (s, e) => ShowTip(lblDate);


                // Click handler
                card.Click += (s, e) =>
                {
                    var info = (EventInfo)card.Tag;
                    var result = MessageBox.Show(
                        $"Do you want to register for '{info.Name}' on {info.Date:ddd, MMM d @ HH:mm}?",
                        "Register",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        // Here you can add registration logic
                        MessageBox.Show($"You are registered for '{info.Name}'!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ev.Registered = true;
                        PopulateEvents(); // Refresh the list to update registration status
                    }
                };
            }
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
        protected override void ShowHelpTopic()
        {
            MessageBox.Show("Overview:" +
                "\nThis panel allows you to view all the future events organised the the campings community." +
                "\nBy hovering over each event you can gather more information regarding it" +
                "\nAnd by clicking on it you can register to participate",
                    "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
