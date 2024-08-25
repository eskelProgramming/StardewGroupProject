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
            cklSpringForaging = new CheckedListBox();
            cklWinterForaging = new CheckedListBox();
            cklExoticForaging = new CheckedListBox();
            cklSummerForaging = new CheckedListBox();
            cklConstruction = new CheckedListBox();
            cklFallForaging = new CheckedListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // cklSpringForaging
            // 
            cklSpringForaging.Font = new Font("Sitka Banner", 12F);
            cklSpringForaging.FormattingEnabled = true;
            cklSpringForaging.Location = new Point(257, 59);
            cklSpringForaging.Margin = new Padding(3, 4, 3, 4);
            cklSpringForaging.Name = "cklSpringForaging";
            cklSpringForaging.Size = new Size(137, 88);
            cklSpringForaging.TabIndex = 0;
            cklSpringForaging.ItemCheck += cklSpringForaging_ItemCheck;
            // 
            // cklWinterForaging
            // 
            cklWinterForaging.Font = new Font("Sitka Banner", 12F);
            cklWinterForaging.FormattingEnabled = true;
            cklWinterForaging.Location = new Point(40, 115);
            cklWinterForaging.Margin = new Padding(3, 4, 3, 4);
            cklWinterForaging.Name = "cklWinterForaging";
            cklWinterForaging.Size = new Size(137, 88);
            cklWinterForaging.TabIndex = 1;
            cklWinterForaging.ItemCheck += cklWinterForaging_ItemCheck;
            // 
            // cklExoticForaging
            // 
            cklExoticForaging.Font = new Font("Sitka Banner", 12F);
            cklExoticForaging.FormattingEnabled = true;
            cklExoticForaging.Location = new Point(257, 257);
            cklExoticForaging.Margin = new Padding(3, 4, 3, 4);
            cklExoticForaging.Name = "cklExoticForaging";
            cklExoticForaging.Size = new Size(137, 88);
            cklExoticForaging.TabIndex = 2;
            cklExoticForaging.ItemCheck += cklExoticForaging_ItemCheck;
            // 
            // cklSummerForaging
            // 
            cklSummerForaging.Font = new Font("Sitka Banner", 12F);
            cklSummerForaging.FormattingEnabled = true;
            cklSummerForaging.Location = new Point(77, 363);
            cklSummerForaging.Margin = new Padding(3, 4, 3, 4);
            cklSummerForaging.Name = "cklSummerForaging";
            cklSummerForaging.Size = new Size(137, 88);
            cklSummerForaging.TabIndex = 3;
            cklSummerForaging.ItemCheck += cklSummerForaging_ItemCheck;
            // 
            // cklConstruction
            // 
            cklConstruction.Font = new Font("Sitka Banner", 12F);
            cklConstruction.FormattingEnabled = true;
            cklConstruction.Location = new Point(467, 115);
            cklConstruction.Margin = new Padding(3, 4, 3, 4);
            cklConstruction.Name = "cklConstruction";
            cklConstruction.Size = new Size(137, 88);
            cklConstruction.TabIndex = 4;
            cklConstruction.ItemCheck += cklConstruction_ItemCheck;
            // 
            // cklFallForaging
            // 
            cklFallForaging.Font = new Font("Sitka Banner", 12F);
            cklFallForaging.FormattingEnabled = true;
            cklFallForaging.Location = new Point(443, 363);
            cklFallForaging.Margin = new Padding(3, 4, 3, 4);
            cklFallForaging.Name = "cklFallForaging";
            cklFallForaging.Size = new Size(137, 88);
            cklFallForaging.TabIndex = 5;
            cklFallForaging.ItemCheck += cklFallForaging_ItemCheck;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 12F);
            label1.Location = new Point(262, 24);
            label1.Name = "label1";
            label1.Size = new Size(136, 29);
            label1.TabIndex = 6;
            label1.Text = "Spring Foraging";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 12F);
            label2.Location = new Point(50, 80);
            label2.Name = "label2";
            label2.Size = new Size(138, 29);
            label2.TabIndex = 7;
            label2.Text = "Winter Foraging";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 12F);
            label3.Location = new Point(262, 223);
            label3.Name = "label3";
            label3.Size = new Size(133, 29);
            label3.TabIndex = 8;
            label3.Text = "Exotic Foraging";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Banner", 12F);
            label4.Location = new Point(75, 328);
            label4.Name = "label4";
            label4.Size = new Size(150, 29);
            label4.TabIndex = 9;
            label4.Text = "Summer Foraging";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Banner", 12F);
            label5.Location = new Point(479, 80);
            label5.Name = "label5";
            label5.Size = new Size(111, 29);
            label5.TabIndex = 10;
            label5.Text = "Construction";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Banner", 12F);
            label6.Location = new Point(457, 328);
            label6.Name = "label6";
            label6.Size = new Size(113, 29);
            label6.TabIndex = 11;
            label6.Text = "Fall Foraging";
            // 
            // CraftsRoomForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 540);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cklFallForaging);
            Controls.Add(cklConstruction);
            Controls.Add(cklSummerForaging);
            Controls.Add(cklExoticForaging);
            Controls.Add(cklWinterForaging);
            Controls.Add(cklSpringForaging);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CraftsRoomForm";
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
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
	}
}