namespace SmartCamping
{
    partial class AttractionInfo
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
            this.infoBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // infoBox
            // 
            this.infoBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.infoBox.Enabled = false;
            this.infoBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.infoBox.Location = new System.Drawing.Point(0, 328);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(800, 122);
            this.infoBox.TabIndex = 0;
            this.infoBox.Text = "";
            // 
            // AttractionInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.infoBox);
            this.Name = "AttractionInfo";
            this.Text = "AttractionInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox infoBox;
    }
}