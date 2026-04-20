using System.Drawing;
using System.Windows.Forms;

namespace SmartCamping
{
    public partial class AttractionInfo : Form
    {
        public AttractionInfo(string imagePath, string infoText)
        {
            InitializeComponent();
            this.Text = "Attraction Info";

            this.Size = new Size(408, 489);
            this.StartPosition = FormStartPosition.Manual;

            this.BackgroundImage = Image.FromFile(imagePath);
            this.BackgroundImageLayout = ImageLayout.Stretch;

            infoBox.Text = infoText;
        }
    }
}
