namespace WindowsFormsApp1
{
    partial class WeatherPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherPanel));
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblSunlight = new System.Windows.Forms.Label();
            this.lblWind = new System.Windows.Forms.Label();
            this.lblCondition = new System.Windows.Forms.Label();
            this.picCondition = new System.Windows.Forms.PictureBox();
            this.picSun = new System.Windows.Forms.PictureBox();
            this.picWind = new System.Windows.Forms.PictureBox();
            this.picTemp = new System.Windows.Forms.PictureBox();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.picHumidity = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnlCondition = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pnlStormWarning = new System.Windows.Forms.Panel();
            this.lblFindShelter = new System.Windows.Forms.Label();
            this.btnGoToShelter = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCondition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHumidity)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnlCondition.SuspendLayout();
            this.panel9.SuspendLayout();
            this.pnlStormWarning.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.pnlStormWarning);
            this.panel2.Controls.Add(this.pnlCondition);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblTemp.Location = new System.Drawing.Point(12, 18);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(177, 19);
            this.lblTemp.TabIndex = 0;
            this.lblTemp.Text = "Current Temperature: ";
            // 
            // lblSunlight
            // 
            this.lblSunlight.AutoSize = true;
            this.lblSunlight.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblSunlight.Location = new System.Drawing.Point(12, 15);
            this.lblSunlight.Name = "lblSunlight";
            this.lblSunlight.Size = new System.Drawing.Size(145, 19);
            this.lblSunlight.TabIndex = 1;
            this.lblSunlight.Text = "Current Sunlight: ";
            // 
            // lblWind
            // 
            this.lblWind.AutoSize = true;
            this.lblWind.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblWind.Location = new System.Drawing.Point(12, 15);
            this.lblWind.Name = "lblWind";
            this.lblWind.Size = new System.Drawing.Size(116, 19);
            this.lblWind.TabIndex = 2;
            this.lblWind.Text = "Current Wind:";
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblCondition.Location = new System.Drawing.Point(14, 23);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(152, 19);
            this.lblCondition.TabIndex = 3;
            this.lblCondition.Text = "Current Condition:";
            this.lblCondition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picCondition
            // 
            this.picCondition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCondition.Location = new System.Drawing.Point(78, 101);
            this.picCondition.Name = "picCondition";
            this.picCondition.Size = new System.Drawing.Size(43, 42);
            this.picCondition.TabIndex = 4;
            this.picCondition.TabStop = false;
            // 
            // picSun
            // 
            this.picSun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picSun.BackgroundImage")));
            this.picSun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSun.Location = new System.Drawing.Point(41, 229);
            this.picSun.Name = "picSun";
            this.picSun.Size = new System.Drawing.Size(43, 42);
            this.picSun.TabIndex = 5;
            this.picSun.TabStop = false;
            // 
            // picWind
            // 
            this.picWind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picWind.BackgroundImage")));
            this.picWind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWind.Location = new System.Drawing.Point(41, 165);
            this.picWind.Name = "picWind";
            this.picWind.Size = new System.Drawing.Size(43, 42);
            this.picWind.TabIndex = 6;
            this.picWind.TabStop = false;
            // 
            // picTemp
            // 
            this.picTemp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picTemp.BackgroundImage")));
            this.picTemp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTemp.Location = new System.Drawing.Point(41, 29);
            this.picTemp.Name = "picTemp";
            this.picTemp.Size = new System.Drawing.Size(43, 42);
            this.picTemp.TabIndex = 7;
            this.picTemp.TabStop = false;
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblHumidity.Location = new System.Drawing.Point(12, 17);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(145, 19);
            this.lblHumidity.TabIndex = 8;
            this.lblHumidity.Text = "Current Humidity:";
            // 
            // picHumidity
            // 
            this.picHumidity.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picHumidity.BackgroundImage")));
            this.picHumidity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picHumidity.Location = new System.Drawing.Point(41, 98);
            this.picHumidity.Name = "picHumidity";
            this.picHumidity.Size = new System.Drawing.Size(43, 42);
            this.picHumidity.TabIndex = 9;
            this.picHumidity.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.picSun);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.picWind);
            this.panel4.Controls.Add(this.picTemp);
            this.panel4.Controls.Add(this.picHumidity);
            this.panel4.Location = new System.Drawing.Point(80, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(392, 313);
            this.panel4.TabIndex = 11;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.Control;
            this.panel8.Controls.Add(this.lblSunlight);
            this.panel8.Location = new System.Drawing.Point(90, 226);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(255, 51);
            this.panel8.TabIndex = 11;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Control;
            this.panel7.Controls.Add(this.lblWind);
            this.panel7.Location = new System.Drawing.Point(90, 159);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(255, 51);
            this.panel7.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.Controls.Add(this.lblHumidity);
            this.panel6.Location = new System.Drawing.Point(90, 92);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(255, 51);
            this.panel6.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.lblTemp);
            this.panel5.Location = new System.Drawing.Point(90, 23);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(255, 51);
            this.panel5.TabIndex = 0;
            // 
            // pnlCondition
            // 
            this.pnlCondition.Controls.Add(this.panel9);
            this.pnlCondition.Controls.Add(this.picCondition);
            this.pnlCondition.Location = new System.Drawing.Point(541, 31);
            this.pnlCondition.Name = "pnlCondition";
            this.pnlCondition.Size = new System.Drawing.Size(206, 169);
            this.pnlCondition.TabIndex = 12;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.Control;
            this.panel9.Controls.Add(this.lblCondition);
            this.panel9.Location = new System.Drawing.Point(15, 9);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(178, 78);
            this.panel9.TabIndex = 9;
            // 
            // pnlStormWarning
            // 
            this.pnlStormWarning.Controls.Add(this.lblFindShelter);
            this.pnlStormWarning.Controls.Add(this.btnGoToShelter);
            this.pnlStormWarning.Location = new System.Drawing.Point(541, 231);
            this.pnlStormWarning.Name = "pnlStormWarning";
            this.pnlStormWarning.Size = new System.Drawing.Size(206, 113);
            this.pnlStormWarning.TabIndex = 13;
            // 
            // lblFindShelter
            // 
            this.lblFindShelter.AutoSize = true;
            this.lblFindShelter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblFindShelter.ForeColor = System.Drawing.Color.Red;
            this.lblFindShelter.Location = new System.Drawing.Point(40, 9);
            this.lblFindShelter.Name = "lblFindShelter";
            this.lblFindShelter.Size = new System.Drawing.Size(0, 19);
            this.lblFindShelter.TabIndex = 1;
            this.lblFindShelter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGoToShelter
            // 
            this.btnGoToShelter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnGoToShelter.Location = new System.Drawing.Point(51, 54);
            this.btnGoToShelter.Name = "btnGoToShelter";
            this.btnGoToShelter.Size = new System.Drawing.Size(107, 47);
            this.btnGoToShelter.TabIndex = 0;
            this.btnGoToShelter.Text = "Find Shelter!";
            this.btnGoToShelter.UseVisualStyleBackColor = true;
            this.btnGoToShelter.Click += new System.EventHandler(this.btnGoToShelter_Click);
            // 
            // WeatherPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "WeatherPanel";
            this.Text = "Weather";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCondition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHumidity)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pnlCondition.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.pnlStormWarning.ResumeLayout(false);
            this.pnlStormWarning.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblWind;
        private System.Windows.Forms.Label lblSunlight;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.PictureBox picTemp;
        private System.Windows.Forms.PictureBox picWind;
        private System.Windows.Forms.PictureBox picSun;
        private System.Windows.Forms.PictureBox picCondition;
        private System.Windows.Forms.PictureBox picHumidity;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlCondition;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel pnlStormWarning;
        private System.Windows.Forms.Label lblFindShelter;
        private System.Windows.Forms.Button btnGoToShelter;
    }
}