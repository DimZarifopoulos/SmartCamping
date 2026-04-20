namespace WindowsFormsApp1
{
    partial class ShelterPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShelterPanel));
            this.PictureBoxMap = new System.Windows.Forms.PictureBox();
            this.panelControls = new System.Windows.Forms.Panel();
            this.btnStartRoute = new System.Windows.Forms.Button();
            this.btnShowRoutes = new System.Windows.Forms.Button();
            this.pictureBoxShelter1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxShelter3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxShelter4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxShelter2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxTent = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBoxRoute2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxRoute3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxRoute1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMap)).BeginInit();
            this.panelControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShelter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShelter3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShelter4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShelter2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoute2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoute3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoute1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.pictureBoxCar);
            this.panel2.Controls.Add(this.pictureBoxRoute1);
            this.panel2.Controls.Add(this.pictureBoxRoute3);
            this.panel2.Controls.Add(this.pictureBoxRoute2);
            this.panel2.Controls.Add(this.pictureBoxTent);
            this.panel2.Controls.Add(this.pictureBoxShelter2);
            this.panel2.Controls.Add(this.pictureBoxShelter4);
            this.panel2.Controls.Add(this.pictureBoxShelter3);
            this.panel2.Controls.Add(this.pictureBoxShelter1);
            this.panel2.Controls.Add(this.panelControls);
            this.panel2.Controls.Add(this.PictureBoxMap);
            this.panel2.Dock = System.Windows.Forms.DockStyle.None;
            this.panel2.Size = new System.Drawing.Size(800, 392);
            // 
            // PictureBoxMap
            // 
            this.PictureBoxMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBoxMap.Location = new System.Drawing.Point(-9, 0);
            this.PictureBoxMap.Name = "PictureBoxMap";
            this.PictureBoxMap.Size = new System.Drawing.Size(756, 386);
            this.PictureBoxMap.TabIndex = 0;
            this.PictureBoxMap.TabStop = false;
            // 
            // panelControls
            // 
            this.panelControls.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panelControls.Controls.Add(this.btnStartRoute);
            this.panelControls.Controls.Add(this.btnShowRoutes);
            this.panelControls.Location = new System.Drawing.Point(664, 3);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(136, 383);
            this.panelControls.TabIndex = 1;
            // 
            // btnStartRoute
            // 
            this.btnStartRoute.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnStartRoute.Location = new System.Drawing.Point(26, 200);
            this.btnStartRoute.Name = "btnStartRoute";
            this.btnStartRoute.Size = new System.Drawing.Size(98, 47);
            this.btnStartRoute.TabIndex = 3;
            this.btnStartRoute.Text = "Start route";
            this.btnStartRoute.UseVisualStyleBackColor = true;
            this.btnStartRoute.Click += new System.EventHandler(this.btnStartRoute_Click);
            // 
            // btnShowRoutes
            // 
            this.btnShowRoutes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnShowRoutes.Location = new System.Drawing.Point(26, 106);
            this.btnShowRoutes.Name = "btnShowRoutes";
            this.btnShowRoutes.Size = new System.Drawing.Size(98, 47);
            this.btnShowRoutes.TabIndex = 2;
            this.btnShowRoutes.Text = "Show routes";
            this.btnShowRoutes.UseVisualStyleBackColor = true;
            this.btnShowRoutes.Click += new System.EventHandler(this.btnShowRoutes_Click_1);
            // 
            // pictureBoxShelter1
            // 
            this.pictureBoxShelter1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxShelter1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxShelter1.BackgroundImage")));
            this.pictureBoxShelter1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxShelter1.Location = new System.Drawing.Point(64, 48);
            this.pictureBoxShelter1.Name = "pictureBoxShelter1";
            this.pictureBoxShelter1.Size = new System.Drawing.Size(33, 32);
            this.pictureBoxShelter1.TabIndex = 2;
            this.pictureBoxShelter1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxShelter1, "Shelter 1");
            // 
            // pictureBoxShelter3
            // 
            this.pictureBoxShelter3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxShelter3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxShelter3.BackgroundImage")));
            this.pictureBoxShelter3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxShelter3.Location = new System.Drawing.Point(367, 225);
            this.pictureBoxShelter3.Name = "pictureBoxShelter3";
            this.pictureBoxShelter3.Size = new System.Drawing.Size(33, 32);
            this.pictureBoxShelter3.TabIndex = 3;
            this.pictureBoxShelter3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxShelter3, "Shelter 3");
            // 
            // pictureBoxShelter4
            // 
            this.pictureBoxShelter4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxShelter4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxShelter4.BackgroundImage")));
            this.pictureBoxShelter4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxShelter4.Location = new System.Drawing.Point(336, 48);
            this.pictureBoxShelter4.Name = "pictureBoxShelter4";
            this.pictureBoxShelter4.Size = new System.Drawing.Size(33, 32);
            this.pictureBoxShelter4.TabIndex = 4;
            this.pictureBoxShelter4.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxShelter4, "Shelter 4");
            // 
            // pictureBoxShelter2
            // 
            this.pictureBoxShelter2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxShelter2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxShelter2.BackgroundImage")));
            this.pictureBoxShelter2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxShelter2.Location = new System.Drawing.Point(345, 339);
            this.pictureBoxShelter2.Name = "pictureBoxShelter2";
            this.pictureBoxShelter2.Size = new System.Drawing.Size(33, 32);
            this.pictureBoxShelter2.TabIndex = 5;
            this.pictureBoxShelter2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxShelter2, "Shelter 2");
            // 
            // pictureBoxTent
            // 
            this.pictureBoxTent.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxTent.BackgroundImage")));
            this.pictureBoxTent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxTent.Location = new System.Drawing.Point(210, 124);
            this.pictureBoxTent.Name = "pictureBoxTent";
            this.pictureBoxTent.Size = new System.Drawing.Size(33, 32);
            this.pictureBoxTent.TabIndex = 6;
            this.pictureBoxTent.TabStop = false;
            this.pictureBoxTent.MouseEnter += new System.EventHandler(this.pictureBoxTent_MouseEnter);
            this.pictureBoxTent.MouseLeave += new System.EventHandler(this.pictureBoxTent_MouseLeave);
            // 
            // pictureBoxRoute2
            // 
            this.pictureBoxRoute2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRoute2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxRoute2.BackgroundImage")));
            this.pictureBoxRoute2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxRoute2.Location = new System.Drawing.Point(282, 185);
            this.pictureBoxRoute2.Name = "pictureBoxRoute2";
            this.pictureBoxRoute2.Size = new System.Drawing.Size(25, 23);
            this.pictureBoxRoute2.TabIndex = 8;
            this.pictureBoxRoute2.TabStop = false;
            this.pictureBoxRoute2.Click += new System.EventHandler(this.pictureBoxRoute2_Click);
            // 
            // pictureBoxRoute3
            // 
            this.pictureBoxRoute3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRoute3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxRoute3.BackgroundImage")));
            this.pictureBoxRoute3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxRoute3.Location = new System.Drawing.Point(156, 109);
            this.pictureBoxRoute3.Name = "pictureBoxRoute3";
            this.pictureBoxRoute3.Size = new System.Drawing.Size(25, 23);
            this.pictureBoxRoute3.TabIndex = 9;
            this.pictureBoxRoute3.TabStop = false;
            this.pictureBoxRoute3.Click += new System.EventHandler(this.pictureBoxRoute3_Click);
            // 
            // pictureBoxRoute1
            // 
            this.pictureBoxRoute1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRoute1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxRoute1.BackgroundImage")));
            this.pictureBoxRoute1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxRoute1.Location = new System.Drawing.Point(251, 203);
            this.pictureBoxRoute1.Name = "pictureBoxRoute1";
            this.pictureBoxRoute1.Size = new System.Drawing.Size(25, 23);
            this.pictureBoxRoute1.TabIndex = 10;
            this.pictureBoxRoute1.TabStop = false;
            this.pictureBoxRoute1.Click += new System.EventHandler(this.pictureBoxRoute1_Click);
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCar.BackgroundImage")));
            this.pictureBoxCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCar.Location = new System.Drawing.Point(220, 162);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(29, 25);
            this.pictureBoxCar.TabIndex = 11;
            this.pictureBoxCar.TabStop = false;
            // 
            // ShelterPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "ShelterPanel";
            this.Text = "ShelterPanel";
            this.Load += new System.EventHandler(this.ShelterPanel_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMap)).EndInit();
            this.panelControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShelter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShelter3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShelter4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShelter2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoute2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoute3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoute1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxMap;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.PictureBox pictureBoxShelter1;
        private System.Windows.Forms.PictureBox pictureBoxShelter2;
        private System.Windows.Forms.PictureBox pictureBoxShelter4;
        private System.Windows.Forms.PictureBox pictureBoxShelter3;
        private System.Windows.Forms.PictureBox pictureBoxTent;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnShowRoutes;
        private System.Windows.Forms.PictureBox pictureBoxRoute2;
        private System.Windows.Forms.PictureBox pictureBoxRoute3;
        private System.Windows.Forms.PictureBox pictureBoxRoute1;
        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.Button btnStartRoute;
    }
}