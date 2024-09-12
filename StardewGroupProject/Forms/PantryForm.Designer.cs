namespace StardewGroupProject
{
	partial class PantryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantryForm));
            lblFallCrops = new Label();
            lblAnimal = new Label();
            lblSummerCrops = new Label();
            lblArtisan = new Label();
            lblQualityCrops = new Label();
            cklFallCrops = new CheckedListBox();
            cklAnimal = new CheckedListBox();
            cklSummerCrops = new CheckedListBox();
            cklArtisan = new CheckedListBox();
            cklQualityCrops = new CheckedListBox();
            cklSpringCrops = new CheckedListBox();
            lblSpringCrops = new Label();
            SuspendLayout();
            // 
            // lblFallCrops
            // 
            lblFallCrops.AutoSize = true;
            lblFallCrops.BackColor = Color.FromArgb(255, 224, 192);
            lblFallCrops.Font = new Font("Reem Kufi", 12F);
            lblFallCrops.Location = new Point(486, 207);
            lblFallCrops.Name = "lblFallCrops";
            lblFallCrops.Size = new Size(83, 30);
            lblFallCrops.TabIndex = 23;
            lblFallCrops.Text = "Fall Crops";
            lblFallCrops.Paint += lblFallCrops_Paint;
            // 
            // lblAnimal
            // 
            lblAnimal.AutoSize = true;
            lblAnimal.BackColor = Color.FromArgb(255, 192, 192);
            lblAnimal.Font = new Font("Reem Kufi", 12F);
            lblAnimal.Location = new Point(536, 64);
            lblAnimal.Name = "lblAnimal";
            lblAnimal.Size = new Size(63, 30);
            lblAnimal.TabIndex = 22;
            lblAnimal.Text = "Animal";
            lblAnimal.Paint += lblAnimal_Paint;
            // 
            // lblSummerCrops
            // 
            lblSummerCrops.AutoSize = true;
            lblSummerCrops.BackColor = Color.FromArgb(255, 255, 192);
            lblSummerCrops.Font = new Font("Reem Kufi", 12F);
            lblSummerCrops.Location = new Point(152, 207);
            lblSummerCrops.Name = "lblSummerCrops";
            lblSummerCrops.Size = new Size(116, 30);
            lblSummerCrops.TabIndex = 21;
            lblSummerCrops.Text = "Summer Crops";
            lblSummerCrops.Paint += lblSummerCrops_Paint;
            // 
            // lblArtisan
            // 
            lblArtisan.AutoSize = true;
            lblArtisan.BackColor = Color.FromArgb(192, 192, 255);
            lblArtisan.Font = new Font("Reem Kufi", 12F);
            lblArtisan.Location = new Point(337, 194);
            lblArtisan.Name = "lblArtisan";
            lblArtisan.Size = new Size(65, 30);
            lblArtisan.TabIndex = 20;
            lblArtisan.Text = "Artisan";
            lblArtisan.Paint += lblArtisan_Paint;
            // 
            // lblQualityCrops
            // 
            lblQualityCrops.AutoSize = true;
            lblQualityCrops.BackColor = Color.FromArgb(192, 255, 255);
            lblQualityCrops.Font = new Font("Reem Kufi", 12F);
            lblQualityCrops.Location = new Point(114, 64);
            lblQualityCrops.Name = "lblQualityCrops";
            lblQualityCrops.Size = new Size(112, 30);
            lblQualityCrops.TabIndex = 19;
            lblQualityCrops.Text = "Quality Crops";
            lblQualityCrops.Paint += lblQualityCrops_Paint;
            // 
            // cklFallCrops
            // 
            cklFallCrops.BackColor = Color.FromArgb(255, 224, 192);
            cklFallCrops.BorderStyle = BorderStyle.FixedSingle;
            cklFallCrops.CheckOnClick = true;
            cklFallCrops.Font = new Font("Sitka Banner", 12F);
            cklFallCrops.FormattingEnabled = true;
            cklFallCrops.Location = new Point(466, 240);
            cklFallCrops.Name = "cklFallCrops";
            cklFallCrops.Size = new Size(120, 94);
            cklFallCrops.TabIndex = 17;
            cklFallCrops.ItemCheck += cklFallCrops_ItemCheck;
            // 
            // cklAnimal
            // 
            cklAnimal.BackColor = Color.FromArgb(255, 192, 192);
            cklAnimal.BorderStyle = BorderStyle.FixedSingle;
            cklAnimal.CheckOnClick = true;
            cklAnimal.Font = new Font("Sitka Banner", 12F);
            cklAnimal.FormattingEnabled = true;
            cklAnimal.Location = new Point(486, 97);
            cklAnimal.Name = "cklAnimal";
            cklAnimal.Size = new Size(170, 94);
            cklAnimal.TabIndex = 16;
            cklAnimal.ItemCheck += cklAnimal_ItemCheck;
            // 
            // cklSummerCrops
            // 
            cklSummerCrops.BackColor = Color.FromArgb(255, 255, 192);
            cklSummerCrops.BorderStyle = BorderStyle.FixedSingle;
            cklSummerCrops.CheckOnClick = true;
            cklSummerCrops.Font = new Font("Sitka Banner", 12F);
            cklSummerCrops.FormattingEnabled = true;
            cklSummerCrops.Location = new Point(150, 240);
            cklSummerCrops.Name = "cklSummerCrops";
            cklSummerCrops.Size = new Size(120, 94);
            cklSummerCrops.TabIndex = 15;
            cklSummerCrops.ItemCheck += cklSummerCrops_ItemCheck;
            // 
            // cklArtisan
            // 
            cklArtisan.BackColor = Color.FromArgb(192, 192, 255);
            cklArtisan.BorderStyle = BorderStyle.FixedSingle;
            cklArtisan.CheckOnClick = true;
            cklArtisan.Font = new Font("Sitka Banner", 12F);
            cklArtisan.FormattingEnabled = true;
            cklArtisan.Location = new Point(309, 227);
            cklArtisan.Name = "cklArtisan";
            cklArtisan.Size = new Size(120, 94);
            cklArtisan.TabIndex = 14;
            cklArtisan.ItemCheck += cklArtisan_ItemCheck;
            // 
            // cklQualityCrops
            // 
            cklQualityCrops.BackColor = Color.FromArgb(192, 255, 255);
            cklQualityCrops.BorderStyle = BorderStyle.FixedSingle;
            cklQualityCrops.CheckOnClick = true;
            cklQualityCrops.Font = new Font("Sitka Banner", 12F);
            cklQualityCrops.FormattingEnabled = true;
            cklQualityCrops.Location = new Point(83, 97);
            cklQualityCrops.Name = "cklQualityCrops";
            cklQualityCrops.Size = new Size(170, 94);
            cklQualityCrops.TabIndex = 13;
            cklQualityCrops.ItemCheck += cklQualityCrops_ItemCheck;
            // 
            // cklSpringCrops
            // 
            cklSpringCrops.BackColor = Color.FromArgb(192, 255, 192);
            cklSpringCrops.BorderStyle = BorderStyle.FixedSingle;
            cklSpringCrops.CheckOnClick = true;
            cklSpringCrops.Font = new Font("Sitka Banner", 12F);
            cklSpringCrops.FormattingEnabled = true;
            cklSpringCrops.Location = new Point(309, 83);
            cklSpringCrops.Name = "cklSpringCrops";
            cklSpringCrops.Size = new Size(120, 94);
            cklSpringCrops.TabIndex = 12;
            cklSpringCrops.ItemCheck += cklSpringCrops_ItemCheck;
            // 
            // lblSpringCrops
            // 
            lblSpringCrops.AutoSize = true;
            lblSpringCrops.BackColor = Color.FromArgb(192, 255, 192);
            lblSpringCrops.Font = new Font("Reem Kufi", 12F);
            lblSpringCrops.Location = new Point(317, 50);
            lblSpringCrops.Name = "lblSpringCrops";
            lblSpringCrops.Size = new Size(106, 30);
            lblSpringCrops.TabIndex = 18;
            lblSpringCrops.Text = "Spring Crops";
            lblSpringCrops.Paint += lblSpringCrops_Paint;
            // 
            // PantryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(763, 383);
            Controls.Add(lblFallCrops);
            Controls.Add(lblAnimal);
            Controls.Add(lblSummerCrops);
            Controls.Add(lblArtisan);
            Controls.Add(lblQualityCrops);
            Controls.Add(lblSpringCrops);
            Controls.Add(cklFallCrops);
            Controls.Add(cklAnimal);
            Controls.Add(cklSummerCrops);
            Controls.Add(cklArtisan);
            Controls.Add(cklQualityCrops);
            Controls.Add(cklSpringCrops);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PantryForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Pantry Bundles";
            Load += PantryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFallCrops;
		private Label lblAnimal;
		private Label lblSummerCrops;
		private Label lblArtisan;
		private Label lblQualityCrops;
		private CheckedListBox cklFallCrops;
		private CheckedListBox cklAnimal;
		private CheckedListBox cklSummerCrops;
		private CheckedListBox cklArtisan;
		private CheckedListBox cklQualityCrops;
		private CheckedListBox cklSpringCrops;
        private Label lblSpringCrops;
    }
}