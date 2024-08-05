namespace StardewGroupProject.Forms
{
	partial class AbandonedJojomartForm
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
			label1 = new Label();
			cklMissingBundle = new CheckedListBox();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Sitka Banner", 12F);
			label1.Location = new Point(110, 58);
			label1.Name = "label1";
			label1.Size = new Size(105, 23);
			label1.TabIndex = 20;
			label1.Text = "Missing Bundle";
			// 
			// cklMissingBundle
			// 
			cklMissingBundle.Font = new Font("Sitka Banner", 12F);
			cklMissingBundle.FormattingEnabled = true;
			cklMissingBundle.Location = new Point(103, 84);
			cklMissingBundle.Name = "cklMissingBundle";
			cklMissingBundle.Size = new Size(120, 73);
			cklMissingBundle.TabIndex = 19;
			// 
			// AbandonedJojomartForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(320, 231);
			Controls.Add(label1);
			Controls.Add(cklMissingBundle);
			Name = "AbandonedJojomartForm";
			Text = "Abandoned JojoMart";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private CheckedListBox cklMissingBundle;
	}
}