namespace StardewGroupProject.Forms
{
	partial class AbandonedJojamartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbandonedJojamartForm));
            lblMissingBundle = new Label();
            cklMissingBundle = new CheckedListBox();
            SuspendLayout();
            // 
            // lblMissingBundle
            // 
            lblMissingBundle.AutoSize = true;
            lblMissingBundle.BackColor = Color.FromArgb(192, 192, 255);
            lblMissingBundle.Font = new Font("Reem Kufi", 12F);
            lblMissingBundle.Location = new Point(145, 20);
            lblMissingBundle.Name = "lblMissingBundle";
            lblMissingBundle.Size = new Size(121, 30);
            lblMissingBundle.TabIndex = 20;
            lblMissingBundle.Text = "Missing Bundle";
            lblMissingBundle.Paint += lblMissingBundle_Paint;
            // 
            // cklMissingBundle
            // 
            cklMissingBundle.BackColor = Color.FromArgb(192, 192, 255);
            cklMissingBundle.BorderStyle = BorderStyle.FixedSingle;
            cklMissingBundle.CheckOnClick = true;
            cklMissingBundle.Font = new Font("Reem Kufi", 10F);
            cklMissingBundle.FormattingEnabled = true;
            cklMissingBundle.Location = new Point(145, 53);
            cklMissingBundle.Name = "cklMissingBundle";
            cklMissingBundle.Size = new Size(120, 114);
            cklMissingBundle.TabIndex = 19;
            // 
            // AbandonedJojamartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(416, 210);
            Controls.Add(lblMissingBundle);
            Controls.Add(cklMissingBundle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AbandonedJojamartForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Abandoned JojaMart";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMissingBundle;
		private CheckedListBox cklMissingBundle;
	}
}