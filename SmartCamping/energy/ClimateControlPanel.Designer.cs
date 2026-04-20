namespace SmartCamping
{
    partial class ClimateControlPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClimateControlPanel));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblAC = new System.Windows.Forms.Label();
            this.panelAC = new System.Windows.Forms.Panel();
            this.btnACSmart = new System.Windows.Forms.Button();
            this.btnIncreaseACTemp = new System.Windows.Forms.Button();
            this.btnACTemp = new System.Windows.Forms.Button();
            this.btnDecreaseACTemp = new System.Windows.Forms.Button();
            this.btnOffAC = new System.Windows.Forms.Button();
            this.btnOnAC = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelHeater = new System.Windows.Forms.Panel();
            this.btnHeaterSmart = new System.Windows.Forms.Button();
            this.btnIncreaseHeaterTemp = new System.Windows.Forms.Button();
            this.btnHeaterTemp = new System.Windows.Forms.Button();
            this.btnDecreaseHeaterTemp = new System.Windows.Forms.Button();
            this.btnOffHeater = new System.Windows.Forms.Button();
            this.btnOnHeater = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHeater = new System.Windows.Forms.Label();
            this.lblCurrentMode = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblCurrentWeatherTemperature = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panelAC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelHeater.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lblCurrentWeatherTemperature);
            this.panel2.Controls.Add(this.lblCurrentMode);
            this.panel2.Controls.Add(this.panelHeater);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panelAC);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(279, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Climate Control Panel";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(495, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(39, 41);
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // lblAC
            // 
            this.lblAC.AutoSize = true;
            this.lblAC.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblAC.Location = new System.Drawing.Point(57, 13);
            this.lblAC.Name = "lblAC";
            this.lblAC.Size = new System.Drawing.Size(142, 22);
            this.lblAC.TabIndex = 3;
            this.lblAC.Text = "Air - Condition";
            // 
            // panelAC
            // 
            this.panelAC.BackColor = System.Drawing.SystemColors.Control;
            this.panelAC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAC.Controls.Add(this.btnACSmart);
            this.panelAC.Controls.Add(this.btnIncreaseACTemp);
            this.panelAC.Controls.Add(this.btnACTemp);
            this.panelAC.Controls.Add(this.btnDecreaseACTemp);
            this.panelAC.Controls.Add(this.btnOffAC);
            this.panelAC.Controls.Add(this.btnOnAC);
            this.panelAC.Controls.Add(this.pictureBox2);
            this.panelAC.Controls.Add(this.lblAC);
            this.panelAC.Location = new System.Drawing.Point(78, 100);
            this.panelAC.Name = "panelAC";
            this.panelAC.Size = new System.Drawing.Size(284, 260);
            this.panelAC.TabIndex = 0;
            // 
            // btnACSmart
            // 
            this.btnACSmart.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnACSmart.Location = new System.Drawing.Point(61, 197);
            this.btnACSmart.Name = "btnACSmart";
            this.btnACSmart.Size = new System.Drawing.Size(155, 37);
            this.btnACSmart.TabIndex = 11;
            this.btnACSmart.Text = "Smart AC";
            this.toolTip1.SetToolTip(this.btnACSmart, "Set temperature to 26°C on hot days (>28°C)");
            this.btnACSmart.UseVisualStyleBackColor = true;
            this.btnACSmart.Click += new System.EventHandler(this.btnACSmart_Click);
            // 
            // btnIncreaseACTemp
            // 
            this.btnIncreaseACTemp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIncreaseACTemp.BackgroundImage")));
            this.btnIncreaseACTemp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIncreaseACTemp.Location = new System.Drawing.Point(197, 135);
            this.btnIncreaseACTemp.Name = "btnIncreaseACTemp";
            this.btnIncreaseACTemp.Size = new System.Drawing.Size(38, 40);
            this.btnIncreaseACTemp.TabIndex = 10;
            this.btnIncreaseACTemp.UseVisualStyleBackColor = true;
            this.btnIncreaseACTemp.Click += new System.EventHandler(this.btnIncreaseACTemp_Click);
            // 
            // btnACTemp
            // 
            this.btnACTemp.Enabled = false;
            this.btnACTemp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnACTemp.Location = new System.Drawing.Point(110, 135);
            this.btnACTemp.Name = "btnACTemp";
            this.btnACTemp.Size = new System.Drawing.Size(67, 40);
            this.btnACTemp.TabIndex = 9;
            this.btnACTemp.Text = "20,5°C";
            this.btnACTemp.UseVisualStyleBackColor = true;
            // 
            // btnDecreaseACTemp
            // 
            this.btnDecreaseACTemp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDecreaseACTemp.BackgroundImage")));
            this.btnDecreaseACTemp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDecreaseACTemp.Location = new System.Drawing.Point(49, 135);
            this.btnDecreaseACTemp.Name = "btnDecreaseACTemp";
            this.btnDecreaseACTemp.Size = new System.Drawing.Size(38, 40);
            this.btnDecreaseACTemp.TabIndex = 7;
            this.btnDecreaseACTemp.UseVisualStyleBackColor = true;
            this.btnDecreaseACTemp.Click += new System.EventHandler(this.btnDecreaseACTemp_Click);
            // 
            // btnOffAC
            // 
            this.btnOffAC.BackColor = System.Drawing.Color.Red;
            this.btnOffAC.Location = new System.Drawing.Point(176, 56);
            this.btnOffAC.Name = "btnOffAC";
            this.btnOffAC.Size = new System.Drawing.Size(59, 51);
            this.btnOffAC.TabIndex = 6;
            this.btnOffAC.Text = "OFF";
            this.btnOffAC.UseVisualStyleBackColor = false;
            this.btnOffAC.Click += new System.EventHandler(this.btnOffAC_Click);
            // 
            // btnOnAC
            // 
            this.btnOnAC.BackColor = System.Drawing.Color.Lime;
            this.btnOnAC.Location = new System.Drawing.Point(49, 56);
            this.btnOnAC.Name = "btnOnAC";
            this.btnOnAC.Size = new System.Drawing.Size(59, 51);
            this.btnOnAC.TabIndex = 5;
            this.btnOnAC.Text = "ON";
            this.btnOnAC.UseVisualStyleBackColor = false;
            this.btnOnAC.Click += new System.EventHandler(this.btnOnAC_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(196, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 41);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // panelHeater
            // 
            this.panelHeater.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeater.Controls.Add(this.btnHeaterSmart);
            this.panelHeater.Controls.Add(this.btnIncreaseHeaterTemp);
            this.panelHeater.Controls.Add(this.btnHeaterTemp);
            this.panelHeater.Controls.Add(this.btnDecreaseHeaterTemp);
            this.panelHeater.Controls.Add(this.btnOffHeater);
            this.panelHeater.Controls.Add(this.btnOnHeater);
            this.panelHeater.Controls.Add(this.pictureBox1);
            this.panelHeater.Controls.Add(this.lblHeater);
            this.panelHeater.Location = new System.Drawing.Point(437, 100);
            this.panelHeater.Name = "panelHeater";
            this.panelHeater.Size = new System.Drawing.Size(284, 260);
            this.panelHeater.TabIndex = 4;
            // 
            // btnHeaterSmart
            // 
            this.btnHeaterSmart.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnHeaterSmart.Location = new System.Drawing.Point(65, 197);
            this.btnHeaterSmart.Name = "btnHeaterSmart";
            this.btnHeaterSmart.Size = new System.Drawing.Size(155, 37);
            this.btnHeaterSmart.TabIndex = 14;
            this.btnHeaterSmart.Text = "Smart Heater";
            this.toolTip1.SetToolTip(this.btnHeaterSmart, "Set temperature to 20°C on cold days (>10°C)");
            this.btnHeaterSmart.UseVisualStyleBackColor = true;
            this.btnHeaterSmart.Click += new System.EventHandler(this.btnHeaterSmart_Click);
            // 
            // btnIncreaseHeaterTemp
            // 
            this.btnIncreaseHeaterTemp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIncreaseHeaterTemp.BackgroundImage")));
            this.btnIncreaseHeaterTemp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIncreaseHeaterTemp.Location = new System.Drawing.Point(197, 135);
            this.btnIncreaseHeaterTemp.Name = "btnIncreaseHeaterTemp";
            this.btnIncreaseHeaterTemp.Size = new System.Drawing.Size(38, 40);
            this.btnIncreaseHeaterTemp.TabIndex = 13;
            this.btnIncreaseHeaterTemp.UseVisualStyleBackColor = true;
            this.btnIncreaseHeaterTemp.Click += new System.EventHandler(this.btnIncreaseHeaterTemp_Click);
            // 
            // btnHeaterTemp
            // 
            this.btnHeaterTemp.Enabled = false;
            this.btnHeaterTemp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnHeaterTemp.Location = new System.Drawing.Point(110, 135);
            this.btnHeaterTemp.Name = "btnHeaterTemp";
            this.btnHeaterTemp.Size = new System.Drawing.Size(67, 40);
            this.btnHeaterTemp.TabIndex = 12;
            this.btnHeaterTemp.Text = "20°C";
            this.btnHeaterTemp.UseVisualStyleBackColor = true;
            // 
            // btnDecreaseHeaterTemp
            // 
            this.btnDecreaseHeaterTemp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDecreaseHeaterTemp.BackgroundImage")));
            this.btnDecreaseHeaterTemp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDecreaseHeaterTemp.Location = new System.Drawing.Point(49, 135);
            this.btnDecreaseHeaterTemp.Name = "btnDecreaseHeaterTemp";
            this.btnDecreaseHeaterTemp.Size = new System.Drawing.Size(38, 40);
            this.btnDecreaseHeaterTemp.TabIndex = 11;
            this.btnDecreaseHeaterTemp.UseVisualStyleBackColor = true;
            this.btnDecreaseHeaterTemp.Click += new System.EventHandler(this.btnDecreaseHeaterTemp_Click);
            // 
            // btnOffHeater
            // 
            this.btnOffHeater.BackColor = System.Drawing.Color.Red;
            this.btnOffHeater.Location = new System.Drawing.Point(176, 56);
            this.btnOffHeater.Name = "btnOffHeater";
            this.btnOffHeater.Size = new System.Drawing.Size(59, 51);
            this.btnOffHeater.TabIndex = 7;
            this.btnOffHeater.Text = "OFF";
            this.btnOffHeater.UseVisualStyleBackColor = false;
            this.btnOffHeater.Click += new System.EventHandler(this.btnOffHeater_Click);
            // 
            // btnOnHeater
            // 
            this.btnOnHeater.BackColor = System.Drawing.Color.Lime;
            this.btnOnHeater.Location = new System.Drawing.Point(49, 56);
            this.btnOnHeater.Name = "btnOnHeater";
            this.btnOnHeater.Size = new System.Drawing.Size(59, 51);
            this.btnOnHeater.TabIndex = 6;
            this.btnOnHeater.Text = "ON";
            this.btnOnHeater.UseVisualStyleBackColor = false;
            this.btnOnHeater.Click += new System.EventHandler(this.btnOnHeater_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(181, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 41);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblHeater
            // 
            this.lblHeater.AutoSize = true;
            this.lblHeater.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblHeater.Location = new System.Drawing.Point(105, 19);
            this.lblHeater.Name = "lblHeater";
            this.lblHeater.Size = new System.Drawing.Size(70, 22);
            this.lblHeater.TabIndex = 3;
            this.lblHeater.Text = "Heater";
            // 
            // lblCurrentMode
            // 
            this.lblCurrentMode.AutoSize = true;
            this.lblCurrentMode.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentMode.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblCurrentMode.ForeColor = System.Drawing.Color.Azure;
            this.lblCurrentMode.Location = new System.Drawing.Point(290, 56);
            this.lblCurrentMode.Name = "lblCurrentMode";
            this.lblCurrentMode.Size = new System.Drawing.Size(138, 22);
            this.lblCurrentMode.TabIndex = 5;
            this.lblCurrentMode.Text = "Current mode";
            // 
            // lblCurrentWeatherTemperature
            // 
            this.lblCurrentWeatherTemperature.AutoSize = true;
            this.lblCurrentWeatherTemperature.BackColor = System.Drawing.Color.SpringGreen;
            this.lblCurrentWeatherTemperature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrentWeatherTemperature.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblCurrentWeatherTemperature.Location = new System.Drawing.Point(656, 16);
            this.lblCurrentWeatherTemperature.Name = "lblCurrentWeatherTemperature";
            this.lblCurrentWeatherTemperature.Size = new System.Drawing.Size(2, 21);
            this.lblCurrentWeatherTemperature.TabIndex = 6;
            this.lblCurrentWeatherTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClimateControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "ClimateControlPanel";
            this.Text = "ClimateControl";
            this.Load += new System.EventHandler(this.ClimateControlPanel_Load_1);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panelAC.ResumeLayout(false);
            this.panelAC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelHeater.ResumeLayout(false);
            this.panelHeater.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panelHeater;
        private System.Windows.Forms.Label lblHeater;
        private System.Windows.Forms.Panel panelAC;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblAC;
        private System.Windows.Forms.Button btnOnAC;
        private System.Windows.Forms.Button btnOffHeater;
        private System.Windows.Forms.Button btnOnHeater;
        private System.Windows.Forms.Button btnOffAC;
        private System.Windows.Forms.Button btnDecreaseACTemp;
        private System.Windows.Forms.Button btnIncreaseACTemp;
        private System.Windows.Forms.Button btnACTemp;
        private System.Windows.Forms.Button btnIncreaseHeaterTemp;
        private System.Windows.Forms.Button btnHeaterTemp;
        private System.Windows.Forms.Button btnDecreaseHeaterTemp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCurrentMode;
        private System.Windows.Forms.Button btnHeaterSmart;
        private System.Windows.Forms.Button btnACSmart;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblCurrentWeatherTemperature;
    }
}