namespace StardewGroupProject
{
	partial class CraftsRoomForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CraftsRoomForm));
            cklSpringForaging = new CheckedListBox();
            cklWinterForaging = new CheckedListBox();
            cklExoticForaging = new CheckedListBox();
            cklSummerForaging = new CheckedListBox();
            cklConstruction = new CheckedListBox();
            cklFallForaging = new CheckedListBox();
            lblSpringForaging = new Label();
            lblWinterForaging = new Label();
            lblExoticForaging = new Label();
            lblSummerForaging = new Label();
            lblConstruction = new Label();
            lblFallForaging = new Label();
            SuspendLayout();
            // 
            // cklSpringForaging
            // 
            cklSpringForaging.BackColor = Color.FromArgb(192, 255, 192);
            cklSpringForaging.BorderStyle = BorderStyle.FixedSingle;
            cklSpringForaging.CheckOnClick = true;
            cklSpringForaging.Font = new Font("Reem Kufi", 10F);
            cklSpringForaging.FormattingEnabled = true;
            cklSpringForaging.Location = new Point(289, 51);
            cklSpringForaging.Name = "cklSpringForaging";
            cklSpringForaging.Size = new Size(158, 114);
            cklSpringForaging.TabIndex = 0;
            cklSpringForaging.ItemCheck += cklSpringForaging_ItemCheck;
            // 
            // cklWinterForaging
            // 
            cklWinterForaging.BackColor = Color.FromArgb(192, 255, 255);
            cklWinterForaging.BorderStyle = BorderStyle.FixedSingle;
            cklWinterForaging.CheckOnClick = true;
            cklWinterForaging.Font = new Font("Reem Kufi", 10F);
            cklWinterForaging.FormattingEnabled = true;
            cklWinterForaging.Location = new Point(114, 86);
            cklWinterForaging.Name = "cklWinterForaging";
            cklWinterForaging.Size = new Size(120, 114);
            cklWinterForaging.TabIndex = 1;
            cklWinterForaging.ItemCheck += cklWinterForaging_ItemCheck;
            // 
            // cklExoticForaging
            // 
            cklExoticForaging.BackColor = Color.FromArgb(255, 192, 255);
            cklExoticForaging.BorderStyle = BorderStyle.FixedSingle;
            cklExoticForaging.CheckOnClick = true;
            cklExoticForaging.Font = new Font("Reem Kufi", 10F);
            cklExoticForaging.FormattingEnabled = true;
            cklExoticForaging.Location = new Point(289, 219);
            cklExoticForaging.Name = "cklExoticForaging";
            cklExoticForaging.Size = new Size(158, 114);
            cklExoticForaging.TabIndex = 2;
            cklExoticForaging.ItemCheck += cklExoticForaging_ItemCheck;
            // 
            // cklSummerForaging
            // 
            cklSummerForaging.BackColor = Color.FromArgb(255, 255, 192);
            cklSummerForaging.BorderStyle = BorderStyle.FixedSingle;
            cklSummerForaging.CheckOnClick = true;
            cklSummerForaging.Font = new Font("Reem Kufi", 10F);
            cklSummerForaging.FormattingEnabled = true;
            cklSummerForaging.Location = new Point(66, 242);
            cklSummerForaging.Name = "cklSummerForaging";
            cklSummerForaging.Size = new Size(180, 114);
            cklSummerForaging.TabIndex = 3;
            cklSummerForaging.ItemCheck += cklSummerForaging_ItemCheck;
            // 
            // cklConstruction
            // 
            cklConstruction.BackColor = Color.FromArgb(255, 192, 192);
            cklConstruction.BorderStyle = BorderStyle.FixedSingle;
            cklConstruction.CheckOnClick = true;
            cklConstruction.Font = new Font("Reem Kufi", 10F);
            cklConstruction.FormattingEnabled = true;
            cklConstruction.Location = new Point(506, 84);
            cklConstruction.Name = "cklConstruction";
            cklConstruction.Size = new Size(120, 114);
            cklConstruction.TabIndex = 4;
            cklConstruction.ItemCheck += cklConstruction_ItemCheck;
            // 
            // cklFallForaging
            // 
            cklFallForaging.BackColor = Color.FromArgb(255, 224, 192);
            cklFallForaging.BorderStyle = BorderStyle.FixedSingle;
            cklFallForaging.CheckOnClick = true;
            cklFallForaging.Font = new Font("Reem Kufi", 10F);
            cklFallForaging.FormattingEnabled = true;
            cklFallForaging.Location = new Point(492, 242);
            cklFallForaging.Name = "cklFallForaging";
            cklFallForaging.Size = new Size(180, 114);
            cklFallForaging.TabIndex = 5;
            cklFallForaging.ItemCheck += cklFallForaging_ItemCheck;
            // 
            // lblSpringForaging
            // 
            lblSpringForaging.AutoSize = true;
            lblSpringForaging.BackColor = Color.FromArgb(192, 255, 192);
            lblSpringForaging.Font = new Font("Reem Kufi", 12F);
            lblSpringForaging.Location = new Point(305, 18);
            lblSpringForaging.Name = "lblSpringForaging";
            lblSpringForaging.Size = new Size(128, 30);
            lblSpringForaging.TabIndex = 6;
            lblSpringForaging.Text = "Spring Foraging";
            lblSpringForaging.Paint += lblSpringForaging_Paint;
            // 
            // lblWinterForaging
            // 
            lblWinterForaging.AutoSize = true;
            lblWinterForaging.BackColor = Color.FromArgb(192, 255, 255);
            lblWinterForaging.Font = new Font("Reem Kufi", 12F);
            lblWinterForaging.Location = new Point(111, 51);
            lblWinterForaging.Name = "lblWinterForaging";
            lblWinterForaging.Size = new Size(129, 30);
            lblWinterForaging.TabIndex = 7;
            lblWinterForaging.Text = "Winter Foraging";
            lblWinterForaging.Paint += lblWinterForaging_Paint;
            // 
            // lblExoticForaging
            // 
            lblExoticForaging.AutoSize = true;
            lblExoticForaging.BackColor = Color.FromArgb(255, 192, 255);
            lblExoticForaging.Font = new Font("Reem Kufi", 12F);
            lblExoticForaging.Location = new Point(309, 186);
            lblExoticForaging.Name = "lblExoticForaging";
            lblExoticForaging.Size = new Size(124, 30);
            lblExoticForaging.TabIndex = 8;
            lblExoticForaging.Text = "Exotic Foraging";
            lblExoticForaging.Paint += lblExoticForaging_Paint;
            // 
            // lblSummerForaging
            // 
            lblSummerForaging.AutoSize = true;
            lblSummerForaging.BackColor = Color.FromArgb(255, 255, 192);
            lblSummerForaging.Font = new Font("Reem Kufi", 12F);
            lblSummerForaging.Location = new Point(84, 209);
            lblSummerForaging.Name = "lblSummerForaging";
            lblSummerForaging.Size = new Size(138, 30);
            lblSummerForaging.TabIndex = 9;
            lblSummerForaging.Text = "Summer Foraging";
            lblSummerForaging.Paint += lblSummerForaging_Paint;
            // 
            // lblConstruction
            // 
            lblConstruction.AutoSize = true;
            lblConstruction.BackColor = Color.FromArgb(255, 192, 192);
            lblConstruction.Font = new Font("Reem Kufi", 12F);
            lblConstruction.Location = new Point(513, 51);
            lblConstruction.Name = "lblConstruction";
            lblConstruction.Size = new Size(105, 30);
            lblConstruction.TabIndex = 10;
            lblConstruction.Text = "Construction";
            lblConstruction.Paint += lblConstruction_Paint;
            // 
            // lblFallForaging
            // 
            lblFallForaging.AutoSize = true;
            lblFallForaging.BackColor = Color.FromArgb(255, 224, 192);
            lblFallForaging.Font = new Font("Reem Kufi", 12F);
            lblFallForaging.Location = new Point(531, 209);
            lblFallForaging.Name = "lblFallForaging";
            lblFallForaging.Size = new Size(105, 30);
            lblFallForaging.TabIndex = 11;
            lblFallForaging.Text = "Fall Foraging";
            lblFallForaging.Paint += lblFallForaging_Paint;
            // 
            // CraftsRoomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(763, 383);
            Controls.Add(lblFallForaging);
            Controls.Add(lblConstruction);
            Controls.Add(lblSummerForaging);
            Controls.Add(lblExoticForaging);
            Controls.Add(lblWinterForaging);
            Controls.Add(lblSpringForaging);
            Controls.Add(cklFallForaging);
            Controls.Add(cklConstruction);
            Controls.Add(cklSummerForaging);
            Controls.Add(cklExoticForaging);
            Controls.Add(cklWinterForaging);
            Controls.Add(cklSpringForaging);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CraftsRoomForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Crafts Room Bundles";
            Load += CraftsRoomForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox cklSpringForaging;
		private CheckedListBox cklWinterForaging;
		private CheckedListBox cklExoticForaging;
		private CheckedListBox cklSummerForaging;
		private CheckedListBox cklConstruction;
		private CheckedListBox cklFallForaging;
		private Label lblSpringForaging;
		private Label lblWinterForaging;
		private Label lblExoticForaging;
		private Label lblSummerForaging;
		private Label lblConstruction;
		private Label lblFallForaging;
	}
}