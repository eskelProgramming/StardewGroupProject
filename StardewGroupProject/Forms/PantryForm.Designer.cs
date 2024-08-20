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
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cklFallCrops = new CheckedListBox();
            cklAnimal = new CheckedListBox();
            cklSummerCrops = new CheckedListBox();
            cklArtisan = new CheckedListBox();
            cklQualityCrops = new CheckedListBox();
            cklSpringCrops = new CheckedListBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Banner", 12F);
            label6.Location = new Point(409, 246);
            label6.Name = "label6";
            label6.Size = new Size(73, 23);
            label6.TabIndex = 23;
            label6.Text = "Fall Crops";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Banner", 12F);
            label5.Location = new Point(443, 60);
            label5.Name = "label5";
            label5.Size = new Size(54, 23);
            label5.TabIndex = 22;
            label5.Text = "Animal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Banner", 12F);
            label4.Location = new Point(75, 243);
            label4.Name = "label4";
            label4.Size = new Size(103, 23);
            label4.TabIndex = 21;
            label4.Text = "Summer Crops";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 12F);
            label3.Location = new Point(258, 167);
            label3.Name = "label3";
            label3.Size = new Size(55, 23);
            label3.TabIndex = 20;
            label3.Text = "Artisan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 12F);
            label2.Location = new Point(48, 60);
            label2.Name = "label2";
            label2.Size = new Size(95, 23);
            label2.TabIndex = 19;
            label2.Text = "Quality Crops";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 12F);
            label1.Location = new Point(238, 18);
            label1.Name = "label1";
            label1.Size = new Size(91, 23);
            label1.TabIndex = 18;
            label1.Text = "Spring Crops";
            // 
            // cklFallCrops
            // 
            cklFallCrops.Font = new Font("Sitka Banner", 12F);
            cklFallCrops.FormattingEnabled = true;
            cklFallCrops.Location = new Point(388, 272);
            cklFallCrops.Name = "cklFallCrops";
            cklFallCrops.Size = new Size(120, 73);
            cklFallCrops.TabIndex = 17;
            // 
            // cklAnimal
            // 
            cklAnimal.Font = new Font("Sitka Banner", 12F);
            cklAnimal.FormattingEnabled = true;
            cklAnimal.Location = new Point(409, 86);
            cklAnimal.Name = "cklAnimal";
            cklAnimal.Size = new Size(120, 73);
            cklAnimal.TabIndex = 16;
            // 
            // cklSummerCrops
            // 
            cklSummerCrops.Font = new Font("Sitka Banner", 12F);
            cklSummerCrops.FormattingEnabled = true;
            cklSummerCrops.Location = new Point(68, 272);
            cklSummerCrops.Name = "cklSummerCrops";
            cklSummerCrops.Size = new Size(120, 73);
            cklSummerCrops.TabIndex = 15;
            // 
            // cklArtisan
            // 
            cklArtisan.Font = new Font("Sitka Banner", 12F);
            cklArtisan.FormattingEnabled = true;
            cklArtisan.Location = new Point(225, 193);
            cklArtisan.Name = "cklArtisan";
            cklArtisan.Size = new Size(120, 73);
            cklArtisan.TabIndex = 14;
            // 
            // cklQualityCrops
            // 
            cklQualityCrops.Font = new Font("Sitka Banner", 12F);
            cklQualityCrops.FormattingEnabled = true;
            cklQualityCrops.Location = new Point(35, 86);
            cklQualityCrops.Name = "cklQualityCrops";
            cklQualityCrops.Size = new Size(120, 73);
            cklQualityCrops.TabIndex = 13;
            // 
            // cklSpringCrops
            // 
            cklSpringCrops.Font = new Font("Sitka Banner", 12F);
            cklSpringCrops.FormattingEnabled = true;
            cklSpringCrops.Location = new Point(225, 44);
            cklSpringCrops.Name = "cklSpringCrops";
            cklSpringCrops.Size = new Size(120, 73);
            cklSpringCrops.TabIndex = 12;
            // 
            // PantryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 405);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cklFallCrops);
            Controls.Add(cklAnimal);
            Controls.Add(cklSummerCrops);
            Controls.Add(cklArtisan);
            Controls.Add(cklQualityCrops);
            Controls.Add(cklSpringCrops);
            Name = "PantryForm";
            Text = "Pantry Bundles";
            Load += PantryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private CheckedListBox cklFallCrops;
		private CheckedListBox cklAnimal;
		private CheckedListBox cklSummerCrops;
		private CheckedListBox cklArtisan;
		private CheckedListBox cklQualityCrops;
		private CheckedListBox cklSpringCrops;
	}
}