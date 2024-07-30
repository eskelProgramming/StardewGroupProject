namespace StardewGroupProject
{
	partial class VaultForm
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
			chkVault10000 = new CheckBox();
			chkVault2500 = new CheckBox();
			chkVault5000 = new CheckBox();
			chkVault25000 = new CheckBox();
			groupBox1 = new GroupBox();
			groupBox2 = new GroupBox();
			groupBox3 = new GroupBox();
			groupBox4 = new GroupBox();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox3.SuspendLayout();
			groupBox4.SuspendLayout();
			SuspendLayout();
			// 
			// chkVault10000
			// 
			chkVault10000.AutoSize = true;
			chkVault10000.Location = new Point(21, 31);
			chkVault10000.Name = "chkVault10000";
			chkVault10000.Size = new Size(81, 19);
			chkVault10000.TabIndex = 24;
			chkVault10000.Text = "Purchased";
			chkVault10000.UseVisualStyleBackColor = true;
			// 
			// chkVault2500
			// 
			chkVault2500.AutoSize = true;
			chkVault2500.Location = new Point(21, 26);
			chkVault2500.Name = "chkVault2500";
			chkVault2500.Size = new Size(81, 19);
			chkVault2500.TabIndex = 25;
			chkVault2500.Text = "Purchased";
			chkVault2500.UseVisualStyleBackColor = true;
			// 
			// chkVault5000
			// 
			chkVault5000.AutoSize = true;
			chkVault5000.Location = new Point(26, 26);
			chkVault5000.Name = "chkVault5000";
			chkVault5000.Size = new Size(81, 19);
			chkVault5000.TabIndex = 26;
			chkVault5000.Text = "Purchased";
			chkVault5000.UseVisualStyleBackColor = true;
			// 
			// chkVault25000
			// 
			chkVault25000.AutoSize = true;
			chkVault25000.Location = new Point(26, 31);
			chkVault25000.Name = "chkVault25000";
			chkVault25000.Size = new Size(81, 19);
			chkVault25000.TabIndex = 27;
			chkVault25000.Text = "Purchased";
			chkVault25000.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			groupBox1.BackColor = SystemColors.ControlLight;
			groupBox1.Controls.Add(chkVault2500);
			groupBox1.Location = new Point(58, 37);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(130, 66);
			groupBox1.TabIndex = 28;
			groupBox1.TabStop = false;
			groupBox1.Text = "2,500g";
			// 
			// groupBox2
			// 
			groupBox2.BackColor = SystemColors.ControlLight;
			groupBox2.Controls.Add(chkVault5000);
			groupBox2.Location = new Point(283, 37);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(130, 66);
			groupBox2.TabIndex = 26;
			groupBox2.TabStop = false;
			groupBox2.Text = "5,000g";
			// 
			// groupBox3
			// 
			groupBox3.BackColor = SystemColors.ControlLight;
			groupBox3.Controls.Add(chkVault10000);
			groupBox3.Location = new Point(58, 208);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(130, 66);
			groupBox3.TabIndex = 0;
			groupBox3.TabStop = false;
			groupBox3.Text = "10,000g";
			// 
			// groupBox4
			// 
			groupBox4.BackColor = SystemColors.ControlLight;
			groupBox4.Controls.Add(chkVault25000);
			groupBox4.Location = new Point(283, 208);
			groupBox4.Name = "groupBox4";
			groupBox4.Size = new Size(130, 66);
			groupBox4.TabIndex = 0;
			groupBox4.TabStop = false;
			groupBox4.Text = "25,000g";
			// 
			// VaultForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(481, 339);
			Controls.Add(groupBox3);
			Controls.Add(groupBox4);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Name = "VaultForm";
			Text = "VaultForm";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			groupBox4.ResumeLayout(false);
			groupBox4.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private CheckBox chkVault10000;
		private CheckBox chkVault2500;
		private CheckBox chkVault5000;
		private CheckBox chkVault25000;
		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private GroupBox groupBox3;
		private GroupBox groupBox4;
	}
}