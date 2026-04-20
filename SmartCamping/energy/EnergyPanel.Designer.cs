namespace WindowsFormsApp1
{
    partial class EnergyPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnergyPanel));
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblEfficiency = new System.Windows.Forms.Label();
            this.lblWind = new System.Windows.Forms.Label();
            this.circularBarEfficiency = new CircularProgressBar.CircularProgressBar();
            this.lblProduction = new System.Windows.Forms.Label();
            this.lblMaxProduction = new System.Windows.Forms.Label();
            this.circularBarBattery = new CircularProgressBar.CircularProgressBar();
            this.circularBarConsuption = new CircularProgressBar.CircularProgressBar();
            this.lblConsumption = new System.Windows.Forms.Label();
            this.lblBattery = new System.Windows.Forms.Label();
            this.lblBatteryCapacity = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblEnergySaved = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblMaxConsumption = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panelLowMode = new System.Windows.Forms.Panel();
            this.btnLowPower = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnCliamateControl = new System.Windows.Forms.PictureBox();
            this.lblClimateControl = new System.Windows.Forms.Label();
            this.panelNormalMode = new System.Windows.Forms.Panel();
            this.btnPowerMode = new System.Windows.Forms.PictureBox();
            this.lblPowerMode = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblBaseLoad = new System.Windows.Forms.Label();
            this.lblLightsLoad = new System.Windows.Forms.Label();
            this.lblACLoad = new System.Windows.Forms.Label();
            this.lblHeaterLoad = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pictureBaseLoad = new System.Windows.Forms.PictureBox();
            this.pictureAC = new System.Windows.Forms.PictureBox();
            this.pictureHeater = new System.Windows.Forms.PictureBox();
            this.pictureLights = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            this.panelLowMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLowPower)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCliamateControl)).BeginInit();
            this.panelNormalMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPowerMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBaseLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHeater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLights)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblWind);
            this.panel2.Controls.Add(this.lblTemp);
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Size = new System.Drawing.Size(800, 381);
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblTemp.Location = new System.Drawing.Point(173, 103);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(0, 20);
            this.lblTemp.TabIndex = 0;
            // 
            // lblEfficiency
            // 
            this.lblEfficiency.AutoSize = true;
            this.lblEfficiency.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblEfficiency.Location = new System.Drawing.Point(108, 41);
            this.lblEfficiency.Name = "lblEfficiency";
            this.lblEfficiency.Size = new System.Drawing.Size(104, 20);
            this.lblEfficiency.TabIndex = 1;
            this.lblEfficiency.Text = "Panel Efficiency";
            // 
            // lblWind
            // 
            this.lblWind.AutoSize = true;
            this.lblWind.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblWind.Location = new System.Drawing.Point(173, 159);
            this.lblWind.Name = "lblWind";
            this.lblWind.Size = new System.Drawing.Size(0, 20);
            this.lblWind.TabIndex = 2;
            // 
            // circularBarEfficiency
            // 
            this.circularBarEfficiency.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularBarEfficiency.AnimationSpeed = 500;
            this.circularBarEfficiency.BackColor = System.Drawing.Color.Transparent;
            this.circularBarEfficiency.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularBarEfficiency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularBarEfficiency.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularBarEfficiency.InnerMargin = 2;
            this.circularBarEfficiency.InnerWidth = -1;
            this.circularBarEfficiency.Location = new System.Drawing.Point(3, 19);
            this.circularBarEfficiency.MarqueeAnimationSpeed = 2000;
            this.circularBarEfficiency.Name = "circularBarEfficiency";
            this.circularBarEfficiency.OuterColor = System.Drawing.SystemColors.ControlLight;
            this.circularBarEfficiency.OuterMargin = -25;
            this.circularBarEfficiency.OuterWidth = 26;
            this.circularBarEfficiency.ProgressColor = System.Drawing.Color.Lime;
            this.circularBarEfficiency.ProgressWidth = 25;
            this.circularBarEfficiency.SecondaryFont = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.circularBarEfficiency.Size = new System.Drawing.Size(77, 79);
            this.circularBarEfficiency.StartAngle = 270;
            this.circularBarEfficiency.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularBarEfficiency.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularBarEfficiency.SubscriptText = ".23";
            this.circularBarEfficiency.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularBarEfficiency.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularBarEfficiency.SuperscriptText = "°C";
            this.circularBarEfficiency.TabIndex = 7;
            this.circularBarEfficiency.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.toolTip1.SetToolTip(this.circularBarEfficiency, "Panel Efficiency (%)");
            this.circularBarEfficiency.Value = 68;
            // 
            // lblProduction
            // 
            this.lblProduction.AutoSize = true;
            this.lblProduction.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblProduction.Location = new System.Drawing.Point(108, 68);
            this.lblProduction.Name = "lblProduction";
            this.lblProduction.Size = new System.Drawing.Size(119, 20);
            this.lblProduction.TabIndex = 8;
            this.lblProduction.Text = "Current Production";
            // 
            // lblMaxProduction
            // 
            this.lblMaxProduction.AutoSize = true;
            this.lblMaxProduction.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblMaxProduction.Location = new System.Drawing.Point(108, 14);
            this.lblMaxProduction.Name = "lblMaxProduction";
            this.lblMaxProduction.Size = new System.Drawing.Size(102, 20);
            this.lblMaxProduction.TabIndex = 9;
            this.lblMaxProduction.Text = "Max Production";
            // 
            // circularBarBattery
            // 
            this.circularBarBattery.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularBarBattery.AnimationSpeed = 500;
            this.circularBarBattery.BackColor = System.Drawing.Color.Transparent;
            this.circularBarBattery.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularBarBattery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularBarBattery.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularBarBattery.InnerMargin = 2;
            this.circularBarBattery.InnerWidth = -1;
            this.circularBarBattery.Location = new System.Drawing.Point(3, 19);
            this.circularBarBattery.MarqueeAnimationSpeed = 2000;
            this.circularBarBattery.Name = "circularBarBattery";
            this.circularBarBattery.OuterColor = System.Drawing.SystemColors.ControlLight;
            this.circularBarBattery.OuterMargin = -25;
            this.circularBarBattery.OuterWidth = 26;
            this.circularBarBattery.ProgressColor = System.Drawing.Color.Lime;
            this.circularBarBattery.ProgressWidth = 25;
            this.circularBarBattery.SecondaryFont = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.circularBarBattery.Size = new System.Drawing.Size(77, 79);
            this.circularBarBattery.StartAngle = 270;
            this.circularBarBattery.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularBarBattery.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularBarBattery.SubscriptText = ".23";
            this.circularBarBattery.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularBarBattery.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularBarBattery.SuperscriptText = "°C";
            this.circularBarBattery.TabIndex = 10;
            this.circularBarBattery.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.toolTip1.SetToolTip(this.circularBarBattery, "Battery Level (%)");
            this.circularBarBattery.Value = 68;
            // 
            // circularBarConsuption
            // 
            this.circularBarConsuption.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularBarConsuption.AnimationSpeed = 500;
            this.circularBarConsuption.BackColor = System.Drawing.Color.Transparent;
            this.circularBarConsuption.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularBarConsuption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularBarConsuption.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularBarConsuption.InnerMargin = 2;
            this.circularBarConsuption.InnerWidth = -1;
            this.circularBarConsuption.Location = new System.Drawing.Point(3, 17);
            this.circularBarConsuption.MarqueeAnimationSpeed = 2000;
            this.circularBarConsuption.Name = "circularBarConsuption";
            this.circularBarConsuption.OuterColor = System.Drawing.SystemColors.ControlLight;
            this.circularBarConsuption.OuterMargin = -25;
            this.circularBarConsuption.OuterWidth = 26;
            this.circularBarConsuption.ProgressColor = System.Drawing.Color.OrangeRed;
            this.circularBarConsuption.ProgressWidth = 25;
            this.circularBarConsuption.SecondaryFont = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.circularBarConsuption.Size = new System.Drawing.Size(77, 79);
            this.circularBarConsuption.StartAngle = 270;
            this.circularBarConsuption.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularBarConsuption.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularBarConsuption.SubscriptText = ".23";
            this.circularBarConsuption.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularBarConsuption.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularBarConsuption.SuperscriptText = "°C";
            this.circularBarConsuption.TabIndex = 11;
            this.circularBarConsuption.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.toolTip1.SetToolTip(this.circularBarConsuption, "Current Consumption (kW)");
            this.circularBarConsuption.Value = 64;
            // 
            // lblConsumption
            // 
            this.lblConsumption.AutoSize = true;
            this.lblConsumption.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblConsumption.Location = new System.Drawing.Point(108, 50);
            this.lblConsumption.Name = "lblConsumption";
            this.lblConsumption.Size = new System.Drawing.Size(133, 20);
            this.lblConsumption.TabIndex = 12;
            this.lblConsumption.Text = "Current Consumption";
            // 
            // lblBattery
            // 
            this.lblBattery.AutoSize = true;
            this.lblBattery.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblBattery.Location = new System.Drawing.Point(108, 61);
            this.lblBattery.Name = "lblBattery";
            this.lblBattery.Size = new System.Drawing.Size(140, 20);
            this.lblBattery.TabIndex = 13;
            this.lblBattery.Text = "Current Battery Levels";
            // 
            // lblBatteryCapacity
            // 
            this.lblBatteryCapacity.AutoSize = true;
            this.lblBatteryCapacity.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblBatteryCapacity.Location = new System.Drawing.Point(108, 30);
            this.lblBatteryCapacity.Name = "lblBatteryCapacity";
            this.lblBatteryCapacity.Size = new System.Drawing.Size(137, 20);
            this.lblBatteryCapacity.TabIndex = 15;
            this.lblBatteryCapacity.Text = "Total Battery Capacity";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(40, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(418, 337);
            this.panel3.TabIndex = 16;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lblEnergySaved);
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Controls.Add(this.lblMaxConsumption);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.circularBarConsuption);
            this.panel6.Controls.Add(this.lblConsumption);
            this.panel6.Location = new System.Drawing.Point(15, 225);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(387, 99);
            this.panel6.TabIndex = 14;
            // 
            // lblEnergySaved
            // 
            this.lblEnergySaved.AutoSize = true;
            this.lblEnergySaved.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblEnergySaved.Location = new System.Drawing.Point(108, 70);
            this.lblEnergySaved.Name = "lblEnergySaved";
            this.lblEnergySaved.Size = new System.Drawing.Size(141, 20);
            this.lblEnergySaved.TabIndex = 21;
            this.lblEnergySaved.Text = "Current Energy Saved";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(355, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 27);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // lblMaxConsumption
            // 
            this.lblMaxConsumption.AutoSize = true;
            this.lblMaxConsumption.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblMaxConsumption.Location = new System.Drawing.Point(108, 30);
            this.lblMaxConsumption.Name = "lblMaxConsumption";
            this.lblMaxConsumption.Size = new System.Drawing.Size(105, 20);
            this.lblMaxConsumption.TabIndex = 19;
            this.lblMaxConsumption.Text = "Max Consuption";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Consumption";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.circularBarEfficiency);
            this.panel5.Controls.Add(this.lblEfficiency);
            this.panel5.Controls.Add(this.lblProduction);
            this.panel5.Controls.Add(this.lblMaxProduction);
            this.panel5.Location = new System.Drawing.Point(15, 15);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(387, 99);
            this.panel5.TabIndex = 13;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(355, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 27);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Solar Panels";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.circularBarBattery);
            this.panel4.Controls.Add(this.lblBatteryCapacity);
            this.panel4.Controls.Add(this.lblBattery);
            this.panel4.Location = new System.Drawing.Point(15, 120);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(387, 99);
            this.panel4.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(355, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Battery";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel7.Controls.Add(this.panelLowMode);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.panelNormalMode);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(486, 33);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(261, 202);
            this.panel7.TabIndex = 17;
            // 
            // panelLowMode
            // 
            this.panelLowMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLowMode.Controls.Add(this.btnLowPower);
            this.panelLowMode.Controls.Add(this.label7);
            this.panelLowMode.Location = new System.Drawing.Point(10, 73);
            this.panelLowMode.Name = "panelLowMode";
            this.panelLowMode.Size = new System.Drawing.Size(241, 38);
            this.panelLowMode.TabIndex = 3;
            // 
            // btnLowPower
            // 
            this.btnLowPower.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLowPower.BackgroundImage")));
            this.btnLowPower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLowPower.Location = new System.Drawing.Point(185, -1);
            this.btnLowPower.Name = "btnLowPower";
            this.btnLowPower.Size = new System.Drawing.Size(51, 35);
            this.btnLowPower.TabIndex = 1;
            this.btnLowPower.TabStop = false;
            this.toolTip1.SetToolTip(this.btnLowPower, "Press for low power mode (A/C off - Heater off - Dim lights)");
            this.btnLowPower.Click += new System.EventHandler(this.btnLowPower_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label7.Location = new System.Drawing.Point(13, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Low Power Mode";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.btnCliamateControl);
            this.panel8.Controls.Add(this.lblClimateControl);
            this.panel8.Location = new System.Drawing.Point(10, 116);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(241, 38);
            this.panel8.TabIndex = 2;
            // 
            // btnCliamateControl
            // 
            this.btnCliamateControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCliamateControl.BackgroundImage")));
            this.btnCliamateControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCliamateControl.Location = new System.Drawing.Point(193, -1);
            this.btnCliamateControl.Name = "btnCliamateControl";
            this.btnCliamateControl.Size = new System.Drawing.Size(40, 34);
            this.btnCliamateControl.TabIndex = 1;
            this.btnCliamateControl.TabStop = false;
            this.btnCliamateControl.Click += new System.EventHandler(this.btnCliamateControl_Click);
            // 
            // lblClimateControl
            // 
            this.lblClimateControl.AutoSize = true;
            this.lblClimateControl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblClimateControl.Location = new System.Drawing.Point(13, 9);
            this.lblClimateControl.Name = "lblClimateControl";
            this.lblClimateControl.Size = new System.Drawing.Size(174, 19);
            this.lblClimateControl.TabIndex = 0;
            this.lblClimateControl.Text = "Climate Control Panel";
            // 
            // panelNormalMode
            // 
            this.panelNormalMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNormalMode.Controls.Add(this.btnPowerMode);
            this.panelNormalMode.Controls.Add(this.lblPowerMode);
            this.panelNormalMode.Location = new System.Drawing.Point(10, 30);
            this.panelNormalMode.Name = "panelNormalMode";
            this.panelNormalMode.Size = new System.Drawing.Size(241, 38);
            this.panelNormalMode.TabIndex = 1;
            // 
            // btnPowerMode
            // 
            this.btnPowerMode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPowerMode.BackgroundImage")));
            this.btnPowerMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPowerMode.Location = new System.Drawing.Point(185, -1);
            this.btnPowerMode.Name = "btnPowerMode";
            this.btnPowerMode.Size = new System.Drawing.Size(51, 35);
            this.btnPowerMode.TabIndex = 1;
            this.btnPowerMode.TabStop = false;
            this.toolTip1.SetToolTip(this.btnPowerMode, "Press for normal mode");
            this.btnPowerMode.Click += new System.EventHandler(this.btnPowerMode_Click);
            // 
            // lblPowerMode
            // 
            this.lblPowerMode.AutoSize = true;
            this.lblPowerMode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblPowerMode.Location = new System.Drawing.Point(13, 9);
            this.lblPowerMode.Name = "lblPowerMode";
            this.lblPowerMode.Size = new System.Drawing.Size(163, 19);
            this.lblPowerMode.TabIndex = 0;
            this.lblPowerMode.Text = "Normal Power Mode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(67, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Energy saving";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(496, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(33, 29);
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox5, "Disable ac, heater");
            // 
            // lblBaseLoad
            // 
            this.lblBaseLoad.AutoSize = true;
            this.lblBaseLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBaseLoad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblBaseLoad.Location = new System.Drawing.Point(13, 72);
            this.lblBaseLoad.Name = "lblBaseLoad";
            this.lblBaseLoad.Size = new System.Drawing.Size(2, 21);
            this.lblBaseLoad.TabIndex = 5;
            this.lblBaseLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblBaseLoad, "Base load");
            // 
            // lblLightsLoad
            // 
            this.lblLightsLoad.AutoSize = true;
            this.lblLightsLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLightsLoad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblLightsLoad.Location = new System.Drawing.Point(74, 72);
            this.lblLightsLoad.Name = "lblLightsLoad";
            this.lblLightsLoad.Size = new System.Drawing.Size(2, 21);
            this.lblLightsLoad.TabIndex = 6;
            this.lblLightsLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblLightsLoad, "Lights load");
            // 
            // lblACLoad
            // 
            this.lblACLoad.AutoSize = true;
            this.lblACLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblACLoad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblACLoad.Location = new System.Drawing.Point(142, 72);
            this.lblACLoad.Name = "lblACLoad";
            this.lblACLoad.Size = new System.Drawing.Size(2, 21);
            this.lblACLoad.TabIndex = 7;
            this.lblACLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblACLoad, "AC load");
            // 
            // lblHeaterLoad
            // 
            this.lblHeaterLoad.AutoSize = true;
            this.lblHeaterLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHeaterLoad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblHeaterLoad.Location = new System.Drawing.Point(203, 72);
            this.lblHeaterLoad.Name = "lblHeaterLoad";
            this.lblHeaterLoad.Size = new System.Drawing.Size(2, 21);
            this.lblHeaterLoad.TabIndex = 8;
            this.lblHeaterLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblHeaterLoad, "Heater load");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(310, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "Energy Dashboard";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.LimeGreen;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.lblHeaterLoad);
            this.panel9.Controls.Add(this.lblACLoad);
            this.panel9.Controls.Add(this.lblLightsLoad);
            this.panel9.Controls.Add(this.lblBaseLoad);
            this.panel9.Controls.Add(this.pictureBaseLoad);
            this.panel9.Controls.Add(this.pictureAC);
            this.panel9.Controls.Add(this.pictureHeater);
            this.panel9.Controls.Add(this.pictureLights);
            this.panel9.Controls.Add(this.label5);
            this.panel9.Location = new System.Drawing.Point(486, 251);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(261, 119);
            this.panel9.TabIndex = 19;
            // 
            // pictureBaseLoad
            // 
            this.pictureBaseLoad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBaseLoad.BackgroundImage")));
            this.pictureBaseLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBaseLoad.Location = new System.Drawing.Point(9, 24);
            this.pictureBaseLoad.Name = "pictureBaseLoad";
            this.pictureBaseLoad.Size = new System.Drawing.Size(42, 39);
            this.pictureBaseLoad.TabIndex = 4;
            this.pictureBaseLoad.TabStop = false;
            // 
            // pictureAC
            // 
            this.pictureAC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureAC.BackgroundImage")));
            this.pictureAC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureAC.Location = new System.Drawing.Point(138, 24);
            this.pictureAC.Name = "pictureAC";
            this.pictureAC.Size = new System.Drawing.Size(42, 39);
            this.pictureAC.TabIndex = 3;
            this.pictureAC.TabStop = false;
            // 
            // pictureHeater
            // 
            this.pictureHeater.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureHeater.BackgroundImage")));
            this.pictureHeater.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureHeater.Location = new System.Drawing.Point(203, 24);
            this.pictureHeater.Name = "pictureHeater";
            this.pictureHeater.Size = new System.Drawing.Size(42, 39);
            this.pictureHeater.TabIndex = 2;
            this.pictureHeater.TabStop = false;
            // 
            // pictureLights
            // 
            this.pictureLights.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureLights.BackgroundImage")));
            this.pictureLights.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureLights.Location = new System.Drawing.Point(70, 24);
            this.pictureLights.Name = "pictureLights";
            this.pictureLights.Size = new System.Drawing.Size(42, 39);
            this.pictureLights.TabIndex = 1;
            this.pictureLights.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(98, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Devices";
            // 
            // EnergyPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Location = new System.Drawing.Point(0, 67);
            this.Name = "EnergyPanel";
            this.Text = "EnergyPanel";
            this.Load += new System.EventHandler(this.EnergyPanel_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panelLowMode.ResumeLayout(false);
            this.panelLowMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLowPower)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCliamateControl)).EndInit();
            this.panelNormalMode.ResumeLayout(false);
            this.panelNormalMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPowerMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBaseLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHeater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLights)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblEfficiency;
        private System.Windows.Forms.Label lblWind;
        private CircularProgressBar.CircularProgressBar circularBarEfficiency;
        private System.Windows.Forms.Label lblProduction;
        private System.Windows.Forms.Label lblMaxProduction;
        private CircularProgressBar.CircularProgressBar circularBarBattery;
        private CircularProgressBar.CircularProgressBar circularBarConsuption;
        private System.Windows.Forms.Label lblConsumption;
        private System.Windows.Forms.Label lblBattery;
        private System.Windows.Forms.Label lblBatteryCapacity;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMaxConsumption;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panelNormalMode;
        private System.Windows.Forms.Label lblPowerMode;
        private System.Windows.Forms.PictureBox btnPowerMode;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox btnCliamateControl;
        private System.Windows.Forms.Label lblClimateControl;
        private System.Windows.Forms.Panel panelLowMode;
        private System.Windows.Forms.PictureBox btnLowPower;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureLights;
        private System.Windows.Forms.PictureBox pictureHeater;
        private System.Windows.Forms.PictureBox pictureBaseLoad;
        private System.Windows.Forms.PictureBox pictureAC;
        private System.Windows.Forms.Label lblBaseLoad;
        private System.Windows.Forms.Label lblHeaterLoad;
        private System.Windows.Forms.Label lblACLoad;
        private System.Windows.Forms.Label lblLightsLoad;
        private System.Windows.Forms.Label lblEnergySaved;
    }
}