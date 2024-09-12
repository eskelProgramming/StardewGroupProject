﻿namespace StardewGroupProject
{
	partial class FishTankForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FishTankForm));
            lblOceanFish = new Label();
            lblSpecialtyFish = new Label();
            lblLakeFish = new Label();
            lblCrabPot = new Label();
            lblNightFishing = new Label();
            lblRiverFish = new Label();
            cklOceanFish = new CheckedListBox();
            cklSpecialtyFish = new CheckedListBox();
            cklLakeFish = new CheckedListBox();
            cklCrabPot = new CheckedListBox();
            cklNightFishing = new CheckedListBox();
            cklRiverFish = new CheckedListBox();
            SuspendLayout();
            // 
            // lblOceanFish
            // 
            lblOceanFish.AutoSize = true;
            lblOceanFish.BackColor = Color.FromArgb(192, 192, 255);
            lblOceanFish.Font = new Font("Reem Kufi", 12F);
            lblOceanFish.Location = new Point(487, 203);
            lblOceanFish.Name = "lblOceanFish";
            lblOceanFish.Size = new Size(91, 30);
            lblOceanFish.TabIndex = 23;
            lblOceanFish.Text = "Ocean Fish";
            lblOceanFish.Paint += lblOceanFish_Paint;
            // 
            // lblSpecialtyFish
            // 
            lblSpecialtyFish.AutoSize = true;
            lblSpecialtyFish.BackColor = Color.FromArgb(255, 192, 192);
            lblSpecialtyFish.Font = new Font("Reem Kufi", 12F);
            lblSpecialtyFish.Location = new Point(503, 53);
            lblSpecialtyFish.Name = "lblSpecialtyFish";
            lblSpecialtyFish.Size = new Size(109, 30);
            lblSpecialtyFish.TabIndex = 22;
            lblSpecialtyFish.Text = "Specialty Fish";
            lblSpecialtyFish.Paint += lblSpecialtyFish_Paint;
            // 
            // lblLakeFish
            // 
            lblLakeFish.AutoSize = true;
            lblLakeFish.BackColor = Color.FromArgb(192, 255, 192);
            lblLakeFish.Font = new Font("Reem Kufi", 12F);
            lblLakeFish.Location = new Point(155, 203);
            lblLakeFish.Name = "lblLakeFish";
            lblLakeFish.Size = new Size(79, 30);
            lblLakeFish.TabIndex = 21;
            lblLakeFish.Text = "Lake Fish";
            lblLakeFish.Paint += lblLakeFish_Paint;
            // 
            // lblCrabPot
            // 
            lblCrabPot.AutoSize = true;
            lblCrabPot.BackColor = Color.FromArgb(255, 192, 255);
            lblCrabPot.Font = new Font("Reem Kufi", 12F);
            lblCrabPot.Location = new Point(329, 173);
            lblCrabPot.Name = "lblCrabPot";
            lblCrabPot.Size = new Size(76, 30);
            lblCrabPot.TabIndex = 20;
            lblCrabPot.Text = "Crab Pot";
            lblCrabPot.Paint += lblCrabPot_Paint;
            // 
            // lblNightFishing
            // 
            lblNightFishing.AutoSize = true;
            lblNightFishing.BackColor = Color.FromArgb(255, 192, 255);
            lblNightFishing.Font = new Font("Reem Kufi", 12F);
            lblNightFishing.Location = new Point(118, 53);
            lblNightFishing.Name = "lblNightFishing";
            lblNightFishing.Size = new Size(109, 30);
            lblNightFishing.TabIndex = 19;
            lblNightFishing.Text = "Night Fishing";
            lblNightFishing.Paint += lblNightFishing_Paint;
            // 
            // lblRiverFish
            // 
            lblRiverFish.AutoSize = true;
            lblRiverFish.BackColor = Color.FromArgb(192, 255, 255);
            lblRiverFish.Font = new Font("Reem Kufi", 12F);
            lblRiverFish.Location = new Point(329, 20);
            lblRiverFish.Name = "lblRiverFish";
            lblRiverFish.Size = new Size(81, 30);
            lblRiverFish.TabIndex = 18;
            lblRiverFish.Text = "River Fish";
            lblRiverFish.Paint += lblRiverFish_Paint;
            // 
            // cklOceanFish
            // 
            cklOceanFish.BackColor = Color.FromArgb(192, 192, 255);
            cklOceanFish.CheckOnClick = true;
            cklOceanFish.Font = new Font("Sitka Banner", 12F);
            cklOceanFish.FormattingEnabled = true;
            cklOceanFish.Location = new Point(472, 236);
            cklOceanFish.Name = "cklOceanFish";
            cklOceanFish.Size = new Size(120, 96);
            cklOceanFish.TabIndex = 17;
            cklOceanFish.ItemCheck += cklOceanFish_ItemCheck;
            // 
            // cklSpecialtyFish
            // 
            cklSpecialtyFish.BackColor = Color.FromArgb(255, 192, 192);
            cklSpecialtyFish.CheckOnClick = true;
            cklSpecialtyFish.Font = new Font("Sitka Banner", 12F);
            cklSpecialtyFish.FormattingEnabled = true;
            cklSpecialtyFish.Location = new Point(498, 86);
            cklSpecialtyFish.Name = "cklSpecialtyFish";
            cklSpecialtyFish.Size = new Size(120, 96);
            cklSpecialtyFish.TabIndex = 16;
            cklSpecialtyFish.ItemCheck += cklSpecialtyFish_ItemCheck;
            // 
            // cklLakeFish
            // 
            cklLakeFish.BackColor = Color.FromArgb(192, 255, 192);
            cklLakeFish.CheckOnClick = true;
            cklLakeFish.Font = new Font("Sitka Banner", 12F);
            cklLakeFish.FormattingEnabled = true;
            cklLakeFish.Location = new Point(136, 236);
            cklLakeFish.Name = "cklLakeFish";
            cklLakeFish.Size = new Size(120, 96);
            cklLakeFish.TabIndex = 15;
            cklLakeFish.ItemCheck += cklLakeFish_ItemCheck;
            // 
            // cklCrabPot
            // 
            cklCrabPot.BackColor = Color.FromArgb(255, 192, 255);
            cklCrabPot.CheckOnClick = true;
            cklCrabPot.Font = new Font("Sitka Banner", 12F);
            cklCrabPot.FormattingEnabled = true;
            cklCrabPot.Location = new Point(309, 206);
            cklCrabPot.Name = "cklCrabPot";
            cklCrabPot.Size = new Size(120, 96);
            cklCrabPot.TabIndex = 14;
            cklCrabPot.ItemCheck += cklCrabPot_ItemCheck;
            // 
            // cklNightFishing
            // 
            cklNightFishing.BackColor = Color.FromArgb(255, 192, 255);
            cklNightFishing.CheckOnClick = true;
            cklNightFishing.Font = new Font("Sitka Banner", 12F);
            cklNightFishing.FormattingEnabled = true;
            cklNightFishing.Location = new Point(114, 86);
            cklNightFishing.Name = "cklNightFishing";
            cklNightFishing.Size = new Size(120, 96);
            cklNightFishing.TabIndex = 13;
            cklNightFishing.ItemCheck += cklNightFishing_ItemCheck;
            // 
            // cklRiverFish
            // 
            cklRiverFish.BackColor = Color.FromArgb(192, 255, 255);
            cklRiverFish.CheckOnClick = true;
            cklRiverFish.Font = new Font("Sitka Banner", 12F);
            cklRiverFish.FormattingEnabled = true;
            cklRiverFish.Location = new Point(309, 53);
            cklRiverFish.Name = "cklRiverFish";
            cklRiverFish.Size = new Size(120, 96);
            cklRiverFish.TabIndex = 12;
            cklRiverFish.ItemCheck += cklRiverFish_ItemCheck;
            // 
            // FishTankForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(763, 383);
            Controls.Add(lblOceanFish);
            Controls.Add(lblSpecialtyFish);
            Controls.Add(lblLakeFish);
            Controls.Add(lblCrabPot);
            Controls.Add(lblNightFishing);
            Controls.Add(lblRiverFish);
            Controls.Add(cklOceanFish);
            Controls.Add(cklSpecialtyFish);
            Controls.Add(cklLakeFish);
            Controls.Add(cklCrabPot);
            Controls.Add(cklNightFishing);
            Controls.Add(cklRiverFish);
            DoubleBuffered = true;
            ForeColor = SystemColors.WindowText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FishTankForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Fish Tank Bundles";
            Load += FishTankForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOceanFish;
		private Label lblSpecialtyFish;
		private Label lblLakeFish;
		private Label lblCrabPot;
		private Label lblNightFishing;
		private Label lblRiverFish;
		private CheckedListBox cklOceanFish;
		private CheckedListBox cklSpecialtyFish;
		private CheckedListBox cklLakeFish;
		private CheckedListBox cklCrabPot;
		private CheckedListBox cklNightFishing;
		private CheckedListBox cklRiverFish;
	}
}