namespace StardewGroupProject
{
	partial class AddNewFarmForm
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
			txtNewFarmName = new TextBox();
			btnNewFarmCreate = new Button();
			label1 = new Label();
			btnNewFarmCancel = new Button();
			SuspendLayout();
			// 
			// txtNewFarmName
			// 
			txtNewFarmName.Location = new Point(186, 26);
			txtNewFarmName.Name = "txtNewFarmName";
			txtNewFarmName.Size = new Size(100, 23);
			txtNewFarmName.TabIndex = 0;
			// 
			// btnNewFarmCreate
			// 
			btnNewFarmCreate.Font = new Font("Sitka Subheading", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnNewFarmCreate.Location = new Point(59, 94);
			btnNewFarmCreate.Name = "btnNewFarmCreate";
			btnNewFarmCreate.Size = new Size(75, 26);
			btnNewFarmCreate.TabIndex = 1;
			btnNewFarmCreate.Text = "Create";
			btnNewFarmCreate.UseVisualStyleBackColor = true;
			btnNewFarmCreate.Click += btnNewFarmCreate_Click;
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
			// btnNewFarmCancel
			// 
			btnNewFarmCancel.Font = new Font("Sitka Subheading", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnNewFarmCancel.Location = new Point(186, 94);
			btnNewFarmCancel.Name = "btnNewFarmCancel";
			btnNewFarmCancel.Size = new Size(74, 26);
			btnNewFarmCancel.TabIndex = 3;
			btnNewFarmCancel.Text = "Cancel";
			btnNewFarmCancel.UseVisualStyleBackColor = true;
			btnNewFarmCancel.Click += btnNewFarmCancel_Click;
			// 
			// AddNewFarmForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(319, 170);
			Controls.Add(btnNewFarmCancel);
			Controls.Add(label1);
			Controls.Add(btnNewFarmCreate);
			Controls.Add(txtNewFarmName);
			Name = "AddNewFarmForm";
			Text = "Add a new Farm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtNewFarmName;
		private Button btnNewFarmCreate;
		private Label label1;
		private Button btnNewFarmCancel;
	}
}