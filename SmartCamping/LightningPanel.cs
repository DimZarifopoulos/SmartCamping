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
    public partial class LightningPanel : BaseForm
    {
        private PictureBox lightCanvas;
        private Color color;
        private float fadeLevel = 1.0f; // starts fully bright
        private bool isFading = false;
        private float fade_step = -0.05f;

        List<Color> primaryColors = new List<Color>
        {
            Color.Red,       // Primary
            Color.LightGreen,     // Primary (additive)
            Color.Blue,      // Primary (additive)
            Color.Yellow,    // Secondary
            Color.Cyan,      // Secondary
            Color.Magenta,   // Secondary
            Color.Orange,
            Color.Purple,
            Color.White
        };
        private int currentPrimaryIndex = 0;

        public LightningPanel()
        {
            InitializeComponent();
            this.Text = "Lightning Panel";

            lightCanvas = new PictureBox();
            lightCanvas.Dock = DockStyle.Fill;
            lightCanvas.BackColor = Color.Transparent;
            panel2.Controls.Add(lightCanvas);
        }

        private void LightningPanel_Load(object sender, EventArgs e)
        {
            // Transparent background of color button
            changeColorBtn.ImageAlign = ContentAlignment.MiddleCenter;
            changeColorBtn.FlatStyle = FlatStyle.Flat;
            changeColorBtn.FlatAppearance.BorderSize = 0;
            changeColorBtn.BackColor = Color.Transparent;
        }
        // Μέθοδος για να δημιουργήσουμε 'λάμπες' με transparent background
        
        private Color BrightenColor(Color color, float factor = 1.5f)
        {
            int r = Math.Min(255, (int)(color.R * factor));
            int g = Math.Min(255, (int)(color.G * factor));
            int b = Math.Min(255, (int)(color.B * factor));
            return Color.FromArgb(color.A, r, g, b);
        }

        private Bitmap MakeLayeredGlow(Color color, float aspectRatio = 1.5f, float brightness = 1.0f)
        {
            int width = panel2.Width;
            int height = panel2.Height;
            Bitmap bmp = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);

                Point center = new Point(width / 2, height / 2);

                (int size, int alpha)[] layers = new (int, int)[]
                {
                    (200, 100),
                    (250, 80),
                    (300, 60),
                    (400, 40),
                    (500, 30),
                    (600, 20),
                    (800, 10),
                };

                foreach (var (size, alpha) in layers)
                {
                    int ovalWidth = (int)(size * aspectRatio);
                    int ovalHeight = size;
                    int fadedAlpha = (int)(alpha * brightness);

                    using (SolidBrush brush = new SolidBrush(Color.FromArgb(fadedAlpha, color)))
                    {
                        g.FillEllipse(
                            brush,
                            center.X - ovalWidth / 2,
                            center.Y - ovalHeight / 2,
                            ovalWidth,
                            ovalHeight
                        );
                    }
                }
            }
            return bmp;
        }


        //public static Color FromAhsb(int a, float h, float s, float b)
        //{
        //    if (s == 0)
        //    {
        //        int v = (int)(b * 255);
        //        return Color.FromArgb(a, v, v, v);
        //    }

        //    float fMax, fMid, fMin;
        //    int iSextant;
        //    if (b > 0.5)
        //        fMax = b - (b * s) + s;
        //    else
        //        fMax = b + (b * s);

        //    fMin = b + b - fMax;
        //    iSextant = (int)Math.Floor(h / 60f);
        //    if (h >= 300f)
        //        h -= 360f;
        //    h /= 60f;
        //    h -= 2f * (float)Math.Floor(((iSextant + 1f) % 6f) / 2f);
        //    if (iSextant % 2 == 0)
        //        fMid = h * (fMax - fMin) + fMin;
        //    else
        //        fMid = fMin - h * (fMax - fMin);

        //    int iMax = (int)(fMax * 255);
        //    int iMid = (int)(fMid * 255);
        //    int iMin = (int)(fMin * 255);

        //    switch (iSextant)
        //    {
        //        case 1: return Color.FromArgb(a, iMid, iMax, iMin);
        //        case 2: return Color.FromArgb(a, iMin, iMax, iMid);
        //        case 3: return Color.FromArgb(a, iMin, iMid, iMax);
        //        case 4: return Color.FromArgb(a, iMid, iMin, iMax);
        //        case 5: return Color.FromArgb(a, iMax, iMin, iMid);
        //        default: return Color.FromArgb(a, iMax, iMid, iMin);
        //    }
        //}

        private void changeColorBtn_Click_1(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    panel2.BackgroundImage = Image.FromFile("images\\symbols\\lamp_on.jpg");
                    Color bright = BrightenColor(cd.Color, 1.6f);
                    lightCanvas.Image = MakeLayeredGlow(bright);
                    color = bright;
                    fadeLevel = 0f;
                    timer1.Stop();
                    isFading = false;
                }
            }
        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            fade_step = -0.05f;
            fadeLevel = 1.0f;
            lightCanvas.Image = null;
            panel2.BackgroundImage = Image.FromFile("images\\symbols\\lamp_off.jpg");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Pulse")
            {
                //fadeLevel = 1.0f;
                //timer1.Interval = 100; // adjust fade speed
                simple_pulse();
            }
            else if (comboBox1.Text == "Primary")
            {
                primary_cycle();
            }
            else if (comboBox1.Text == "Primary pulse")
            {
                primary_pulse();
            }

            //fadeLevel += fade_step ; // decrease brightness gradually (adjust speed)
            //if (fadeLevel <= 0.25f)
            //{
            //    //fadeLevel = 0f;
            //    fade_step = -fade_step; // reverse direction to brighten
            //}
            //else if (fadeLevel >= 1.0f)
            //{
            //    fadeLevel = 1.0f;
            //    fade_step = -fade_step; // reverse direction to fade
            //}


            //lightCanvas.Image = MakeLayeredGlow(color, 1.5f, fadeLevel);
            //textBox1.Text = $"Fade Level: {fadeLevel:F2}";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            timer1.Start();
            //if (comboBox1.Text == "Pulse")
            //{
            fadeLevel = 1.0f;
            timer1.Interval = 100; // adjust fade speed
            panel2.BackgroundImage = Image.FromFile("images\\symbols\\lamp_on.jpg");
            //    timer1.Start();
            //}
        }

        private void button15_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void simple_pulse()
        {
            fadeLevel += fade_step; // decrease brightness gradually (adjust speed)
            if (fadeLevel <= 0.25f)
            {
                //fadeLevel = 0f;
                fade_step = -fade_step; // reverse direction to brighten
            }
            else if (fadeLevel >= 1.0f)
            {
                fadeLevel = 1.0f;
                fade_step = -fade_step; // reverse direction to fade
            }


            lightCanvas.Image = MakeLayeredGlow(color, 1.5f, fadeLevel);
            textBox1.Text = $"Fade Level: {fadeLevel:F2}";
        }

        private void primary_cycle()
        {
            if (currentPrimaryIndex >= 8)
                currentPrimaryIndex = 0;

            fadeLevel += fade_step; // decrease brightness gradually (adjust speed)
            if (fadeLevel <= 0.25f)
            {
                //fadeLevel = 0f;
                fade_step = -fade_step; // reverse direction to brighten
                currentPrimaryIndex++;
            }
            else if (fadeLevel >= 1.0f)
            {
                fadeLevel = 1.0f;
                fade_step = -fade_step; // reverse direction to fade
            }


            lightCanvas.Image = MakeLayeredGlow(primaryColors[currentPrimaryIndex], 1.5f);
            textBox1.Text = $"Fade Level: {fadeLevel:F2}";
        }

        private void primary_pulse()
        {
            if (currentPrimaryIndex >= 8)
                currentPrimaryIndex = 0;

            fadeLevel += fade_step; // decrease brightness gradually (adjust speed)
            if (fadeLevel <= 0.25f)
            {
                //fadeLevel = 0f;
                fade_step = -fade_step; // reverse direction to brighten
                currentPrimaryIndex++;
            }
            else if (fadeLevel >= 1.0f)
            {
                fadeLevel = 1.0f;
                fade_step = -fade_step; // reverse direction to fade
            }


            lightCanvas.Image = MakeLayeredGlow(primaryColors[currentPrimaryIndex], 1.5f, fadeLevel);
            textBox1.Text = $"Fade Level: {fadeLevel:F2}";
        }   

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        protected override void ShowHelpTopic()
        {
            MessageBox.Show("Overview:" +
                "\nThis panel gives you the ability to change the tent's lighting." +
                "\nThe app provides a variety of atmospheric modes depending on your needs" +
                "\nFrom simple manual color change, to automatic interchangable lighting modes" +
                "\nAll while providing realtime simulation of the light's appearence giving the ability to use even from a distance.",
                    "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
