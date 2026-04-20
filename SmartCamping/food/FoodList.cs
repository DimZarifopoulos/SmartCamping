using SmartCamping.food;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FoodList : Form
    {
        private int amount;
        private double price;
        private List<Food> Menu = new List<Food>();
        private Food current_item;
        public static List<Cart> cart = new List<Cart>();
        public FoodList()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            if (Cache.food_category == "Breakfast")
            {
                this.Text = "Breakfast Menu";
                Menu = Food_Options.Breakfast;
            }
            else if (Cache.food_category == "Lunch")
            {
                this.Text = "Lunch Menu";
                Menu = Food_Options.Lunch;
            }
            else if (Cache.food_category == "Supper")
            {
                this.Text = "Supper Menu";
                Menu = Food_Options.Supper;
            }

            StartPosition = FormStartPosition.CenterScreen;
            this.BackgroundImage = Image.FromFile("images/backgrounds/picnic.png");


            foreach (var food in Menu)
            {
                // Create the panel
                Panel itemPanel = new Panel
                {
                    Width = 300,
                    Height = 60,
                    Margin = new Padding(5),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.WhiteSmoke,
                    Cursor = Cursors.Hand
                };

                // Create name label
                Label lblName = new Label
                {
                    Text = food.Name,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Width = 200,
                    Height = 60,
                    Location = new Point(10, 0)
                };

                // Create price label
                Label lblPrice = new Label
                {
                    Text = $"${food.Price:F2}",
                    Font = new Font("Segoe UI", 10),
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleRight,
                    Width = 80,
                    Height = 60,
                    Location = new Point(220, 0)
                };

                // Define a single event handler
                EventHandler clickHandler = (s, e) =>
                {
                    amount = 1;
                    textBox1.Text = amount.ToString();
                    price = food.Price;
                    textBox2.Text = price.ToString() + "€";
                    current_item = food;
                    //pictureBox1.Dispose();
                    pictureBox1.Image = Image.FromFile(food.Picture);
                    richTextBox1.Text = food.Description;
                };

                // Attach the handler to all relevant controls
                itemPanel.Click += clickHandler;
                lblName.Click += clickHandler;
                lblPrice.Click += clickHandler;

                // Add labels to panel
                itemPanel.Controls.Add(lblName);
                itemPanel.Controls.Add(lblPrice);

                // Add panel to FlowLayoutPanel
                flowLayoutPanelMenu.Controls.Add(itemPanel);
            }

        }



        private void button5_Click(object sender, EventArgs e)
        {
            Category form = new Category();
            form.Show();
            Close();
        }

        private void FoodList_Load(object sender, EventArgs e)
        {
            textBox1.Text = amount.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Checkout form = new Checkout();
            form.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            amount++;
            textBox1.Text = amount.ToString();
            textBox2.Text = (price * amount).ToString() + "€";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (amount > 1)
            {
                amount--;
                textBox1.Text = amount.ToString();
                textBox2.Text = (price * amount).ToString() + "€";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cart.Add(new Cart
            {
                item = current_item,
                quantity = amount
            });
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}