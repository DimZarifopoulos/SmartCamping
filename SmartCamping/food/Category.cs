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
    public partial class Category : BaseForm
    {
        public Category()
        {
            InitializeComponent();
            this.Text = "Food";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Cache.food_category = "Breakfast";
            FoodList form = new FoodList();
            form.Show();
            Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Cache.food_category = "Lunch";
            FoodList form = new FoodList();
            form.Show();
            Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Cache.food_category = "Supper";
            FoodList form = new FoodList();
            form.Show();            
            Close();
        }
        protected override void ShowHelpTopic()
        {
            MessageBox.Show("Overview:" +
                "\nThis panel allows you to order food delivery from the camping's cafeteria" +
                "\nRegardless of your appetite you will find a variety of foods to suit your needs and prefrences." +
                "\nAll you have to do is pick the time of day, the items, their amount and wait for the notification to go off once it has arrived",
                    "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
