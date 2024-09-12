namespace StardewGroupProject
{
	partial class BulletinBoardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BulletinBoardForm));
            lblEnchanters = new Label();
            lblFodder = new Label();
            lblFieldResearch = new Label();
            lblDye = new Label();
            lblChefs = new Label();
            cklEnchanters = new CheckedListBox();
            cklFodder = new CheckedListBox();
            cklFieldResearch = new CheckedListBox();
            cklDye = new CheckedListBox();
            cklChefs = new CheckedListBox();
            SuspendLayout();
            // 
            // lblEnchanters
            // 
            lblEnchanters.AutoSize = true;
            lblEnchanters.BackColor = Color.FromArgb(255, 192, 255);
            lblEnchanters.Font = new Font("Reem Kufi", 12F);
            lblEnchanters.Location = new Point(460, 206);
            lblEnchanters.Name = "lblEnchanters";
            lblEnchanters.Size = new Size(96, 30);
            lblEnchanters.TabIndex = 23;
            lblEnchanters.Text = "Enchanter's";
            lblEnchanters.Paint += lblEnchanters_Paint;
            // 
            // lblFodder
            // 
            lblFodder.AutoSize = true;
            lblFodder.BackColor = Color.FromArgb(255, 255, 192);
            lblFodder.Font = new Font("Reem Kufi", 12F);
            lblFodder.Location = new Point(568, 62);
            lblFodder.Name = "lblFodder";
            lblFodder.Size = new Size(64, 30);
            lblFodder.TabIndex = 22;
            lblFodder.Text = "Fodder";
            lblFodder.Paint += lblFodder_Paint;
            // 
            // lblFieldResearch
            // 
            lblFieldResearch.AutoSize = true;
            lblFieldResearch.BackColor = Color.FromArgb(192, 192, 255);
            lblFieldResearch.Font = new Font("Reem Kufi", 12F);
            lblFieldResearch.Location = new Point(159, 206);
            lblFieldResearch.Name = "lblFieldResearch";
            lblFieldResearch.Size = new Size(115, 30);
            lblFieldResearch.TabIndex = 21;
            lblFieldResearch.Text = "Field Research";
            lblFieldResearch.Paint += lblFieldResearch_Paint;
            // 
            // lblDye
            // 
            lblDye.AutoSize = true;
            lblDye.BackColor = Color.FromArgb(192, 255, 255);
            lblDye.Font = new Font("Reem Kufi", 12F);
            lblDye.Location = new Point(126, 62);
            lblDye.Name = "lblDye";
            lblDye.Size = new Size(41, 30);
            lblDye.TabIndex = 19;
            lblDye.Text = "Dye";
            lblDye.Paint += lblDye_Paint;
            // 
            // lblChefs
            // 
            lblChefs.AutoSize = true;
            lblChefs.BackColor = Color.FromArgb(255, 192, 192);
            lblChefs.Font = new Font("Reem Kufi", 12F);
            lblChefs.Location = new Point(343, 28);
            lblChefs.Name = "lblChefs";
            lblChefs.Size = new Size(57, 30);
            lblChefs.TabIndex = 18;
            lblChefs.Text = "Chef's";
            lblChefs.Paint += lblChefs_Paint;
            // 
            // cklEnchanters
            // 
            cklEnchanters.BackColor = Color.FromArgb(255, 192, 255);
            cklEnchanters.BorderStyle = BorderStyle.FixedSingle;
            cklEnchanters.CheckOnClick = true;
            cklEnchanters.Font = new Font("Sitka Banner", 12F);
            cklEnchanters.FormattingEnabled = true;
            cklEnchanters.Location = new Point(431, 239);
            cklEnchanters.Name = "cklEnchanters";
            cklEnchanters.Size = new Size(155, 94);
            cklEnchanters.TabIndex = 17;
            cklEnchanters.ItemCheck += cklEnchanters_ItemCheck;
            // 
            // cklFodder
            // 
            cklFodder.BackColor = Color.FromArgb(255, 255, 192);
            cklFodder.BorderStyle = BorderStyle.FixedSingle;
            cklFodder.CheckOnClick = true;
            cklFodder.Font = new Font("Sitka Banner", 12F);
            cklFodder.FormattingEnabled = true;
            cklFodder.Location = new Point(520, 95);
            cklFodder.Name = "cklFodder";
            cklFodder.Size = new Size(155, 94);
            cklFodder.TabIndex = 16;
            cklFodder.ItemCheck += cklFodder_ItemCheck;
            // 
            // cklFieldResearch
            // 
            cklFieldResearch.BackColor = Color.FromArgb(192, 192, 255);
            cklFieldResearch.BorderStyle = BorderStyle.FixedSingle;
            cklFieldResearch.CheckOnClick = true;
            cklFieldResearch.Font = new Font("Sitka Banner", 12F);
            cklFieldResearch.FormattingEnabled = true;
            cklFieldResearch.Location = new Point(141, 239);
            cklFieldResearch.Name = "cklFieldResearch";
            cklFieldResearch.Size = new Size(155, 94);
            cklFieldResearch.TabIndex = 15;
            cklFieldResearch.ItemCheck += cklFieldResearch_ItemCheck;
            // 
            // cklDye
            // 
            cklDye.BackColor = Color.FromArgb(192, 255, 255);
            cklDye.BorderStyle = BorderStyle.FixedSingle;
            cklDye.CheckOnClick = true;
            cklDye.Font = new Font("Sitka Banner", 12F);
            cklDye.FormattingEnabled = true;
            cklDye.Location = new Point(71, 95);
            cklDye.Name = "cklDye";
            cklDye.Size = new Size(155, 94);
            cklDye.TabIndex = 13;
            cklDye.ItemCheck += cklDye_ItemCheck;
            // 
            // cklChefs
            // 
            cklChefs.BackColor = Color.FromArgb(255, 192, 192);
            cklChefs.BorderStyle = BorderStyle.FixedSingle;
            cklChefs.CheckOnClick = true;
            cklChefs.Font = new Font("Sitka Banner", 12F);
            cklChefs.FormattingEnabled = true;
            cklChefs.Location = new Point(295, 61);
            cklChefs.Name = "cklChefs";
            cklChefs.Size = new Size(155, 94);
            cklChefs.TabIndex = 12;
            cklChefs.ItemCheck += cklChefs_ItemCheck;
            // 
            // BulletinBoardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(763, 383);
            Controls.Add(lblEnchanters);
            Controls.Add(lblFodder);
            Controls.Add(lblFieldResearch);
            Controls.Add(lblDye);
            Controls.Add(lblChefs);
            Controls.Add(cklEnchanters);
            Controls.Add(cklFodder);
            Controls.Add(cklFieldResearch);
            Controls.Add(cklDye);
            Controls.Add(cklChefs);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BulletinBoardForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bulletin Board Bundles";
            Load += BulletinBoardForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEnchanters;
		private Label lblFodder;
		private Label lblFieldResearch;
		private Label lblDye;
		private Label lblChefs;
		private CheckedListBox cklEnchanters;
		private CheckedListBox cklFodder;
		private CheckedListBox cklFieldResearch;
		private CheckedListBox cklDye;
		private CheckedListBox cklChefs;
	}
}