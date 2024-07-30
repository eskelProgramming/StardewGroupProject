namespace StardewGroupProject
{
	partial class AddNewFarm
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
			textBox1 = new TextBox();
			button1 = new Button();
			label1 = new Label();
			button2 = new Button();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new Point(186, 26);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(100, 23);
			textBox1.TabIndex = 0;
			// 
			// button1
			// 
			button1.Font = new Font("Sitka Subheading", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			button1.Location = new Point(59, 94);
			button1.Name = "button1";
			button1.Size = new Size(75, 26);
			button1.TabIndex = 1;
			button1.Text = "Create";
			button1.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Sitka Subheading", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(28, 29);
			label1.Name = "label1";
			label1.Size = new Size(158, 18);
			label1.TabIndex = 2;
			label1.Text = "Enter a name for your Farm:";
			// 
			// button2
			// 
			button2.Font = new Font("Sitka Subheading", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			button2.Location = new Point(186, 94);
			button2.Name = "button2";
			button2.Size = new Size(74, 26);
			button2.TabIndex = 3;
			button2.Text = "Cancel";
			button2.UseVisualStyleBackColor = true;
			// 
			// AddNewFarm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(319, 170);
			Controls.Add(button2);
			Controls.Add(label1);
			Controls.Add(button1);
			Controls.Add(textBox1);
			Name = "AddNewFarm";
			Text = "Add a new Farm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private Button button1;
		private Label label1;
		private Button button2;
	}
}