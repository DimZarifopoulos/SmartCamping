namespace WindowsFormsApp1
{
    partial class LandmarksPanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandmarksPanel));
            this.PictureBoxMap = new System.Windows.Forms.PictureBox();
            this.panelControls = new System.Windows.Forms.Panel();
            this.comboAttractions = new System.Windows.Forms.ComboBox();
            this.btnStartRoute = new System.Windows.Forms.Button();
            this.pictureBoxTent = new System.Windows.Forms.PictureBox();
            this.pictureBoxCave = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBoxBeach = new System.Windows.Forms.PictureBox();
            this.pictureBoxForest = new System.Windows.Forms.PictureBox();
            this.pictureBoxClimbing = new System.Windows.Forms.PictureBox();
            this.pictureBoxBike = new System.Windows.Forms.PictureBox();
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMap)).BeginInit();
            this.panelControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBeach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClimbing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBoxCar);
            this.panel2.Controls.Add(this.pictureBoxBike);
            this.panel2.Controls.Add(this.pictureBoxClimbing);
            this.panel2.Controls.Add(this.pictureBoxForest);
            this.panel2.Controls.Add(this.pictureBoxBeach);
            this.panel2.Controls.Add(this.pictureBoxCave);
            this.panel2.Controls.Add(this.pictureBoxTent);
            this.panel2.Controls.Add(this.panelControls);
            this.panel2.Controls.Add(this.PictureBoxMap);
            // 
            // PictureBoxMap
            // 
            this.PictureBoxMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBoxMap.Location = new System.Drawing.Point(-9, 0);
            this.PictureBoxMap.Name = "PictureBoxMap";
            this.PictureBoxMap.Size = new System.Drawing.Size(756, 386);
            this.PictureBoxMap.TabIndex = 1;
            this.PictureBoxMap.TabStop = false;
            // 
            // panelControls
            // 
            this.panelControls.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panelControls.Controls.Add(this.comboAttractions);
            this.panelControls.Controls.Add(this.btnStartRoute);
            this.panelControls.Location = new System.Drawing.Point(664, 3);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(136, 383);
            this.panelControls.TabIndex = 2;
            // 
            // comboAttractions
            // 
            this.comboAttractions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAttractions.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.comboAttractions.FormattingEnabled = true;
            this.comboAttractions.Location = new System.Drawing.Point(3, 72);
            this.comboAttractions.Name = "comboAttractions";
            this.comboAttractions.Size = new System.Drawing.Size(130, 28);
            this.comboAttractions.TabIndex = 4;
            this.comboAttractions.SelectedIndexChanged += new System.EventHandler(this.comboAttractions_SelectedIndexChanged);
            // 
            // btnStartRoute
            // 
            this.btnStartRoute.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnStartRoute.Location = new System.Drawing.Point(26, 236);
            this.btnStartRoute.Name = "btnStartRoute";
            this.btnStartRoute.Size = new System.Drawing.Size(98, 24);
            this.btnStartRoute.TabIndex = 3;
            this.btnStartRoute.Text = "Start route";
            this.btnStartRoute.UseVisualStyleBackColor = true;
            this.btnStartRoute.Click += new System.EventHandler(this.btnStartRoute_Click);
            // 
            // pictureBoxTent
            // 
            this.pictureBoxTent.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxTent.BackgroundImage")));
            this.pictureBoxTent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxTent.Location = new System.Drawing.Point(210, 124);
            this.pictureBoxTent.Name = "pictureBoxTent";
            this.pictureBoxTent.Size = new System.Drawing.Size(33, 32);
            this.pictureBoxTent.TabIndex = 7;
            this.pictureBoxTent.TabStop = false;
            this.pictureBoxTent.MouseEnter += new System.EventHandler(this.pictureBoxTent_MouseEnter);
            this.pictureBoxTent.MouseLeave += new System.EventHandler(this.pictureBoxTent_MouseLeave);
            // 
            // pictureBoxCave
            // 
            this.pictureBoxCave.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCave.BackgroundImage")));
            this.pictureBoxCave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCave.Location = new System.Drawing.Point(64, 48);
            this.pictureBoxCave.Name = "pictureBoxCave";
            this.pictureBoxCave.Size = new System.Drawing.Size(33, 32);
            this.pictureBoxCave.TabIndex = 8;
            this.pictureBoxCave.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxCave, "Visit the cave");
            this.pictureBoxCave.Click += new System.EventHandler(this.pictureBoxCave_Click);
            // 
            // pictureBoxBeach
            // 
            this.pictureBoxBeach.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBeach.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBeach.BackgroundImage")));
            this.pictureBoxBeach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBeach.Location = new System.Drawing.Point(372, 71);
            this.pictureBoxBeach.Name = "pictureBoxBeach";
            this.pictureBoxBeach.Size = new System.Drawing.Size(33, 32);
            this.pictureBoxBeach.TabIndex = 9;
            this.pictureBoxBeach.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxBeach, "Visit the beach");
            this.pictureBoxBeach.Click += new System.EventHandler(this.pictureBoxBeach_Click);
            // 
            // pictureBoxForest
            // 
            this.pictureBoxForest.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxForest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxForest.BackgroundImage")));
            this.pictureBoxForest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxForest.Location = new System.Drawing.Point(318, 136);
            this.pictureBoxForest.Name = "pictureBoxForest";
            this.pictureBoxForest.Size = new System.Drawing.Size(33, 32);
            this.pictureBoxForest.TabIndex = 10;
            this.pictureBoxForest.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxForest, "Visit the forest");
            this.pictureBoxForest.Click += new System.EventHandler(this.pictureBoxForest_Click);
            // 
            // pictureBoxClimbing
            // 
            this.pictureBoxClimbing.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxClimbing.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxClimbing.BackgroundImage")));
            this.pictureBoxClimbing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxClimbing.Location = new System.Drawing.Point(192, 314);
            this.pictureBoxClimbing.Name = "pictureBoxClimbing";
            this.pictureBoxClimbing.Size = new System.Drawing.Size(33, 32);
            this.pictureBoxClimbing.TabIndex = 11;
            this.pictureBoxClimbing.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxClimbing, "Go mountain climbing");
            this.pictureBoxClimbing.Click += new System.EventHandler(this.pictureBoxClimbing_Click);
            // 
            // pictureBoxBike
            // 
            this.pictureBoxBike.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBike.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBike.BackgroundImage")));
            this.pictureBoxBike.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBike.Location = new System.Drawing.Point(403, 124);
            this.pictureBoxBike.Name = "pictureBoxBike";
            this.pictureBoxBike.Size = new System.Drawing.Size(33, 32);
            this.pictureBoxBike.TabIndex = 12;
            this.pictureBoxBike.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxBike, "Go biking");
            this.pictureBoxBike.Click += new System.EventHandler(this.pictureBoxBike_Click);
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCar.BackgroundImage")));
            this.pictureBoxCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCar.Location = new System.Drawing.Point(229, 172);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(29, 25);
            this.pictureBoxCar.TabIndex = 13;
            this.pictureBoxCar.TabStop = false;
            // 
            // LandmarksPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "LandmarksPanel";
            this.Text = "LandmarksPanel";
            this.Load += new System.EventHandler(this.LandmarksPanel_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMap)).EndInit();
            this.panelControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBeach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClimbing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxMap;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Button btnStartRoute;
        private System.Windows.Forms.PictureBox pictureBoxTent;
        private System.Windows.Forms.PictureBox pictureBoxCave;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBoxForest;
        private System.Windows.Forms.PictureBox pictureBoxBeach;
        private System.Windows.Forms.PictureBox pictureBoxClimbing;
        private System.Windows.Forms.PictureBox pictureBoxBike;
        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.ComboBox comboAttractions;
    }
}