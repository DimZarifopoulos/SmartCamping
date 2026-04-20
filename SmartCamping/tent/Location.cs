using Future_Camping;
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
    public partial class Location : Form
    {
        public Location()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conditions form = new Conditions();
            form.Show();
            Hide();
        }

        private void Location_Load(object sender, EventArgs e)
        {

        }
    }
}
