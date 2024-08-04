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
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			label2 = new Label();
			label1 = new Label();
			cklEnchanters = new CheckedListBox();
			cklFodder = new CheckedListBox();
			cklFieldResearch = new CheckedListBox();
			cklDye = new CheckedListBox();
			cklChefs = new CheckedListBox();
			SuspendLayout();
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Sitka Banner", 12F);
			label6.Location = new Point(408, 238);
			label6.Name = "label6";
			label6.Size = new Size(82, 23);
			label6.TabIndex = 23;
			label6.Text = "Enchanter's";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Sitka Banner", 12F);
			label5.Location = new Point(423, 16);
			label5.Name = "label5";
			label5.Size = new Size(54, 23);
			label5.TabIndex = 22;
			label5.Text = "Fodder";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Sitka Banner", 12F);
			label4.Location = new Point(77, 238);
			label4.Name = "label4";
			label4.Size = new Size(101, 23);
			label4.TabIndex = 21;
			label4.Text = "Field Research";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Sitka Banner", 12F);
			label2.Location = new Point(110, 16);
			label2.Name = "label2";
			label2.Size = new Size(34, 23);
			label2.TabIndex = 19;
			label2.Text = "Dye";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Sitka Banner", 12F);
			label1.Location = new Point(264, 126);
			label1.Name = "label1";
			label1.Size = new Size(48, 23);
			label1.TabIndex = 18;
			label1.Text = "Chef's";
			// 
			// cklEnchanters
			// 
			cklEnchanters.Font = new Font("Sitka Banner", 12F);
			cklEnchanters.FormattingEnabled = true;
			cklEnchanters.Location = new Point(387, 264);
			cklEnchanters.Name = "cklEnchanters";
			cklEnchanters.Size = new Size(120, 73);
			cklEnchanters.TabIndex = 17;
			// 
			// cklFodder
			// 
			cklFodder.Font = new Font("Sitka Banner", 12F);
			cklFodder.FormattingEnabled = true;
			cklFodder.Location = new Point(387, 42);
			cklFodder.Name = "cklFodder";
			cklFodder.Size = new Size(120, 73);
			cklFodder.TabIndex = 16;
			// 
			// cklFieldResearch
			// 
			cklFieldResearch.Font = new Font("Sitka Banner", 12F);
			cklFieldResearch.FormattingEnabled = true;
			cklFieldResearch.Location = new Point(68, 264);
			cklFieldResearch.Name = "cklFieldResearch";
			cklFieldResearch.Size = new Size(120, 73);
			cklFieldResearch.TabIndex = 15;
			// 
			// cklDye
			// 
			cklDye.Font = new Font("Sitka Banner", 12F);
			cklDye.FormattingEnabled = true;
			cklDye.Location = new Point(68, 42);
			cklDye.Name = "cklDye";
			cklDye.Size = new Size(120, 73);
			cklDye.TabIndex = 13;
			// 
			// cklChefs
			// 
			cklChefs.Font = new Font("Sitka Banner", 12F);
			cklChefs.FormattingEnabled = true;
			cklChefs.Location = new Point(228, 152);
			cklChefs.Name = "cklChefs";
			cklChefs.Size = new Size(120, 73);
			cklChefs.TabIndex = 12;
			// 
			// BulletinBoardForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(568, 405);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(cklEnchanters);
			Controls.Add(cklFodder);
			Controls.Add(cklFieldResearch);
			Controls.Add(cklDye);
			Controls.Add(cklChefs);
			Name = "BulletinBoardForm";
			Text = "Bulletin Board Bundles";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label6;
		private Label label5;
		private Label label4;
		private Label label2;
		private Label label1;
		private CheckedListBox cklEnchanters;
		private CheckedListBox cklFodder;
		private CheckedListBox cklFieldResearch;
		private CheckedListBox cklDye;
		private CheckedListBox cklChefs;
	}
}