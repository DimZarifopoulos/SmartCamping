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
    public partial class TentSetup : BaseForm
    {
        public TentSetup()
        {
            InitializeComponent();
            Text = "Tent Setup";
            if (Cache.tentExist)
            {
                button13.Visible = false;
                button17.Visible = true;
            }
            else
            {
                button13.Visible = true;
                button17.Visible = false;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button13_Click(object sender, EventArgs e)
        {
            Loading form = new Loading();
            form.Show();
            Hide();
        }
        private void button17_Click(object sender, EventArgs e)
        {
            TearDownTent form = new TearDownTent();
            form.Show();
            Hide();
        }

        protected override void ShowHelpTopic()
        {
            MessageBox.Show("Overview:" +
                "\nThis panel allows you to place a new tent" +
                "\nIf there are no available tents, you can place a new one, by following the steps as shown on screen." +
                "\nOtherwise you can tear down an existing one and place a new one in its place if neccessary",
                    "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        /* Help for tent setup chapter
protected override void ShowHelpTopic()
{
Help.ShowHelp(this, "SmartCampingHelp.chm", HelpNavigator.TopicID, 10");
} */
    }
}
