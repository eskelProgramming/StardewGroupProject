namespace StardewGroupProject
{
	partial class BoilerRoomForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoilerRoomForm));
            lblAdventurers = new Label();
            lblGeologists = new Label();
            lblBlacksmiths = new Label();
            cklAdventurers = new CheckedListBox();
            cklGeologists = new CheckedListBox();
            cklBlacksmiths = new CheckedListBox();
            SuspendLayout();
            // 
            // lblAdventurers
            // 
            lblAdventurers.AutoSize = true;
            lblAdventurers.BackColor = Color.FromArgb(255, 192, 255);
            lblAdventurers.Font = new Font("Reem Kufi", 12F);
            lblAdventurers.Location = new Point(463, 199);
            lblAdventurers.Name = "lblAdventurers";
            lblAdventurers.Size = new Size(104, 30);
            lblAdventurers.TabIndex = 22;
            lblAdventurers.Text = "Adventurer's";
            lblAdventurers.Paint += lblAdventurers_Paint;
            // 
            // lblGeologists
            // 
            lblGeologists.AutoSize = true;
            lblGeologists.BackColor = Color.FromArgb(255, 192, 255);
            lblGeologists.Font = new Font("Reem Kufi", 12F);
            lblGeologists.Location = new Point(179, 199);
            lblGeologists.Name = "lblGeologists";
            lblGeologists.Size = new Size(92, 30);
            lblGeologists.TabIndex = 20;
            lblGeologists.Text = "Geologist's";
            lblGeologists.Paint += lblGeologists_Paint;
            // 
            // lblBlacksmiths
            // 
            lblBlacksmiths.AutoSize = true;
            lblBlacksmiths.BackColor = Color.FromArgb(255, 224, 192);
            lblBlacksmiths.Font = new Font("Reem Kufi", 12F);
            lblBlacksmiths.Location = new Point(322, 37);
            lblBlacksmiths.Name = "lblBlacksmiths";
            lblBlacksmiths.Size = new Size(100, 30);
            lblBlacksmiths.TabIndex = 18;
            lblBlacksmiths.Text = "Blacksmith's";
            lblBlacksmiths.Paint += lblBlacksmiths_Paint;
            // 
            // cklAdventurers
            // 
            cklAdventurers.BackColor = Color.FromArgb(255, 192, 255);
            cklAdventurers.BorderStyle = BorderStyle.FixedSingle;
            cklAdventurers.CheckOnClick = true;
            cklAdventurers.Font = new Font("Sitka Banner", 12F);
            cklAdventurers.FormattingEnabled = true;
            cklAdventurers.Location = new Point(456, 231);
            cklAdventurers.Name = "cklAdventurers";
            cklAdventurers.Size = new Size(120, 94);
            cklAdventurers.TabIndex = 16;
            cklAdventurers.ItemCheck += cklAdventurers_ItemCheck;
            // 
            // cklGeologists
            // 
            cklGeologists.BackColor = Color.FromArgb(255, 192, 255);
            cklGeologists.BorderStyle = BorderStyle.FixedSingle;
            cklGeologists.CheckOnClick = true;
            cklGeologists.Font = new Font("Sitka Banner", 12F);
            cklGeologists.FormattingEnabled = true;
            cklGeologists.Location = new Point(165, 232);
            cklGeologists.Name = "cklGeologists";
            cklGeologists.Size = new Size(120, 94);
            cklGeologists.TabIndex = 14;
            cklGeologists.ItemCheck += cklGeologists_ItemCheck;
            // 
            // cklBlacksmiths
            // 
            cklBlacksmiths.BackColor = Color.FromArgb(255, 224, 192);
            cklBlacksmiths.BorderStyle = BorderStyle.FixedSingle;
            cklBlacksmiths.CheckOnClick = true;
            cklBlacksmiths.Font = new Font("Sitka Banner", 12F);
            cklBlacksmiths.FormattingEnabled = true;
            cklBlacksmiths.Location = new Point(312, 70);
            cklBlacksmiths.Name = "cklBlacksmiths";
            cklBlacksmiths.Size = new Size(120, 94);
            cklBlacksmiths.TabIndex = 12;
            cklBlacksmiths.ItemCheck += cklBlacksmiths_ItemCheck;
            // 
            // BoilerRoomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(763, 383);
            Controls.Add(lblAdventurers);
            Controls.Add(lblGeologists);
            Controls.Add(lblBlacksmiths);
            Controls.Add(cklAdventurers);
            Controls.Add(cklGeologists);
            Controls.Add(cklBlacksmiths);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BoilerRoomForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Boiler Room Bundles";
            Load += BoilerRoomForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdventurers;
		private Label lblGeologists;
		private Label lblBlacksmiths;
		private CheckedListBox cklAdventurers;
		private CheckedListBox cklGeologists;
		private CheckedListBox cklBlacksmiths;
	}
}