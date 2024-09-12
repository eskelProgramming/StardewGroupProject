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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VaultForm));
            chkVault10000 = new CheckBox();
            chkVault2500 = new CheckBox();
            chkVault5000 = new CheckBox();
            chkVault25000 = new CheckBox();
            gb2500g = new GroupBox();
            gb5000g = new GroupBox();
            gb10000g = new GroupBox();
            gb25000g = new GroupBox();
            gb2500g.SuspendLayout();
            gb5000g.SuspendLayout();
            gb10000g.SuspendLayout();
            gb25000g.SuspendLayout();
            SuspendLayout();
            // 
            // chkVault10000
            // 
            chkVault10000.AutoSize = true;
            chkVault10000.Location = new Point(21, 31);
            chkVault10000.Name = "chkVault10000";
            chkVault10000.Size = new Size(107, 34);
            chkVault10000.TabIndex = 24;
            chkVault10000.Text = "Purchased";
            chkVault10000.UseVisualStyleBackColor = true;
            chkVault10000.CheckedChanged += chkVault10000_CheckedChanged;
            // 
            // chkVault2500
            // 
            chkVault2500.AutoSize = true;
            chkVault2500.Font = new Font("Reem Kufi", 12F);
            chkVault2500.Location = new Point(21, 26);
            chkVault2500.Name = "chkVault2500";
            chkVault2500.Size = new Size(107, 34);
            chkVault2500.TabIndex = 25;
            chkVault2500.Text = "Purchased";
            chkVault2500.UseVisualStyleBackColor = true;
            chkVault2500.CheckedChanged += chkVault2500_CheckedChanged;
            // 
            // chkVault5000
            // 
            chkVault5000.AutoSize = true;
            chkVault5000.Font = new Font("Reem Kufi", 12F);
            chkVault5000.Location = new Point(26, 26);
            chkVault5000.Name = "chkVault5000";
            chkVault5000.Size = new Size(107, 34);
            chkVault5000.TabIndex = 26;
            chkVault5000.Text = "Purchased";
            chkVault5000.UseVisualStyleBackColor = true;
            chkVault5000.CheckedChanged += chkVault5000_CheckedChanged;
            // 
            // chkVault25000
            // 
            chkVault25000.AutoSize = true;
            chkVault25000.Location = new Point(26, 31);
            chkVault25000.Name = "chkVault25000";
            chkVault25000.Size = new Size(107, 34);
            chkVault25000.TabIndex = 27;
            chkVault25000.Text = "Purchased";
            chkVault25000.UseVisualStyleBackColor = true;
            chkVault25000.CheckedChanged += chkVault25000_CheckedChanged;
            // 
            // gb2500g
            // 
            gb2500g.BackColor = Color.FromArgb(255, 192, 192);
            gb2500g.Controls.Add(chkVault2500);
            gb2500g.Font = new Font("Reem Kufi", 12F);
            gb2500g.Location = new Point(297, 31);
            gb2500g.Name = "gb2500g";
            gb2500g.Size = new Size(146, 77);
            gb2500g.TabIndex = 28;
            gb2500g.TabStop = false;
            gb2500g.Text = "2,500g";
            gb2500g.Paint += gb2500g_Paint;
            // 
            // gb5000g
            // 
            gb5000g.BackColor = Color.FromArgb(255, 224, 192);
            gb5000g.Controls.Add(chkVault5000);
            gb5000g.Font = new Font("Reem Kufi", 12F);
            gb5000g.Location = new Point(411, 209);
            gb5000g.Name = "gb5000g";
            gb5000g.Size = new Size(146, 77);
            gb5000g.TabIndex = 26;
            gb5000g.TabStop = false;
            gb5000g.Text = "5,000g";
            gb5000g.Paint += gb5000g_Paint;
            // 
            // gb10000g
            // 
            gb10000g.BackColor = Color.FromArgb(255, 255, 192);
            gb10000g.Controls.Add(chkVault10000);
            gb10000g.Font = new Font("Reem Kufi", 12F);
            gb10000g.Location = new Point(178, 209);
            gb10000g.Name = "gb10000g";
            gb10000g.Size = new Size(146, 77);
            gb10000g.TabIndex = 0;
            gb10000g.TabStop = false;
            gb10000g.Text = "10,000g";
            gb10000g.Paint += gb10000g_Paint;
            // 
            // gb25000g
            // 
            gb25000g.BackColor = Color.FromArgb(255, 192, 255);
            gb25000g.Controls.Add(chkVault25000);
            gb25000g.Font = new Font("Reem Kufi", 12F);
            gb25000g.Location = new Point(93, 94);
            gb25000g.Name = "gb25000g";
            gb25000g.Size = new Size(146, 77);
            gb25000g.TabIndex = 0;
            gb25000g.TabStop = false;
            gb25000g.Text = "25,000g";
            gb25000g.Paint += gb25000g_Paint;
            // 
            // VaultForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(763, 383);
            Controls.Add(gb10000g);
            Controls.Add(gb25000g);
            Controls.Add(gb5000g);
            Controls.Add(gb2500g);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VaultForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Vault Bundles";
            Load += VaultForm_Load;
            gb2500g.ResumeLayout(false);
            gb2500g.PerformLayout();
            gb5000g.ResumeLayout(false);
            gb5000g.PerformLayout();
            gb10000g.ResumeLayout(false);
            gb10000g.PerformLayout();
            gb25000g.ResumeLayout(false);
            gb25000g.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private CheckBox chkVault10000;
		private CheckBox chkVault2500;
		private CheckBox chkVault5000;
		private CheckBox chkVault25000;
		private GroupBox gb2500g;
		private GroupBox gb5000g;
		private GroupBox gb10000g;
		private GroupBox gb25000g;
	}
}