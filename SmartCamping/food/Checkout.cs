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

namespace SmartCamping.food
{
    public partial class Checkout : Form
    {
        private List<Cart> shopping_list = new List<Cart>();
        private int delIndex = -1;
        private double total_price = 0.0;
        private int count = 0;
        public Checkout()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            shopping_list = FoodList.cart;
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            string line;
            total_price = 0.0;

            count = shopping_list.Count;
            textBox2.Text = delIndex.ToString();

            if (count == 0)
            {
                richTextBox1.AppendText("Your cart is empty!" + Environment.NewLine);
                textBox1.Text = "0.00";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                return;
            }
            foreach (Cart item in shopping_list)
            {
                line = item.item.Name + " x " + item.quantity + "    " + (item.item.Price * item.quantity).ToString("C2");
                richTextBox1.AppendText(line + Environment.NewLine);
                total_price += item.item.Price * item.quantity;
                textBox1.Text = total_price.ToString("C2");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (delIndex < 1)
            {
                delIndex = count-1;
            }
            else
            {
                delIndex--;
            }

            richTextBox1.SelectAll();
            richTextBox1.SelectionColor = Color.Black;

            if (delIndex < richTextBox1.Lines.Length)
            {
                int start = richTextBox1.GetFirstCharIndexFromLine(delIndex);
                int length = richTextBox1.Lines[delIndex].Length;

                // Select the line and change its color
                richTextBox1.Select(start, length);
                richTextBox1.SelectionColor = Color.Red;

                // Deselect (optional)
                richTextBox1.Select(0, 0);
            }
            textBox2.Text = delIndex.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (delIndex > count - 2)
            {
                delIndex = 0;
            }
            else
            {
                delIndex++;
            }

            richTextBox1.SelectAll();
            richTextBox1.SelectionColor = Color.Black;

            if (delIndex < richTextBox1.Lines.Length)
            {
                int start = richTextBox1.GetFirstCharIndexFromLine(delIndex);
                int length = richTextBox1.Lines[delIndex].Length;

                // Select the line and change its color
                richTextBox1.Select(start, length);
                richTextBox1.SelectionColor = Color.Red;

                // Deselect (optional)
                richTextBox1.Select(0, 0);
            }
            textBox2.Text = delIndex.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (shopping_list[delIndex].quantity > 1)
            {
                shopping_list[delIndex].quantity--;
            }
            else
            {
                shopping_list.RemoveAt(delIndex);
            }
            richTextBox1.Clear();
            Checkout_Load(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FoodList form = new FoodList();
            form.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int prepTime = 0;
            FoodList.cart.Clear();
            prepTime += Cache.Rnd.Next(5, 10); // base prep time
            DeliveryTimer.Start(prepTime); 
            MessageBox.Show("Thank you for your purchase! Your food will be delivered in " + (prepTime / 60 ) + " minutes.");
            TentSetup form = new TentSetup();
            form.Show();
            Hide();
            //Application.Run(new MainForm());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FoodList form = new FoodList();
            form.Show();
            Hide();
        }
    }
}
