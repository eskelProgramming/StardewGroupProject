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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewFarmForm));
            txtNewFarmName = new TextBox();
            btnNewFarmCreate = new Button();
            label1 = new Label();
            btnNewFarmCancel = new Button();
            grpAddNewFarm = new GroupBox();
            grpAddNewFarm.SuspendLayout();
            SuspendLayout();
            // 
            // txtNewFarmName
            // 
            txtNewFarmName.BackColor = Color.FromArgb(255, 215, 137);
            txtNewFarmName.BorderStyle = BorderStyle.FixedSingle;
            txtNewFarmName.Font = new Font("Reem Kufi", 10F);
            txtNewFarmName.Location = new Point(214, 6);
            txtNewFarmName.Name = "txtNewFarmName";
            txtNewFarmName.Size = new Size(128, 33);
            txtNewFarmName.TabIndex = 0;
            // 
            // btnNewFarmCreate
            // 
            btnNewFarmCreate.BackColor = Color.FromArgb(255, 215, 137);
            btnNewFarmCreate.Font = new Font("Reem Kufi", 15F);
            btnNewFarmCreate.Location = new Point(127, 90);
            btnNewFarmCreate.Name = "btnNewFarmCreate";
            btnNewFarmCreate.Size = new Size(118, 61);
            btnNewFarmCreate.TabIndex = 1;
            btnNewFarmCreate.Text = "Create";
            btnNewFarmCreate.UseVisualStyleBackColor = false;
            btnNewFarmCreate.Click += btnNewFarmCreate_Click;
            btnNewFarmCreate.Paint += btnNewFarmCreate_Paint;
            btnNewFarmCreate.MouseEnter += btnNewFarmCreate_MouseEnter;
            btnNewFarmCreate.MouseLeave += btnNewFarmCreate_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 215, 137);
            label1.Font = new Font("Reem Kufi", 12F);
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(202, 30);
            label1.TabIndex = 2;
            label1.Text = "Enter a name for your Farm:";
            // 
            // btnNewFarmCancel
            // 
            btnNewFarmCancel.BackColor = Color.FromArgb(255, 215, 137);
            btnNewFarmCancel.Font = new Font("Reem Kufi", 15F);
            btnNewFarmCancel.Location = new Point(282, 90);
            btnNewFarmCancel.Name = "btnNewFarmCancel";
            btnNewFarmCancel.Size = new Size(118, 61);
            btnNewFarmCancel.TabIndex = 3;
            btnNewFarmCancel.Text = "Cancel";
            btnNewFarmCancel.UseVisualStyleBackColor = false;
            btnNewFarmCancel.Click += btnNewFarmCancel_Click;
            btnNewFarmCancel.Paint += btnNewFarmCancel_Paint;
            btnNewFarmCancel.MouseEnter += btnNewFarmCancel_MouseEnter;
            btnNewFarmCancel.MouseLeave += btnNewFarmCancel_MouseLeave;
            // 
            // grpAddNewFarm
            // 
            grpAddNewFarm.BackColor = Color.FromArgb(255, 215, 137);
            grpAddNewFarm.Controls.Add(label1);
            grpAddNewFarm.Controls.Add(txtNewFarmName);
            grpAddNewFarm.Location = new Point(81, 38);
            grpAddNewFarm.Name = "grpAddNewFarm";
            grpAddNewFarm.Size = new Size(364, 46);
            grpAddNewFarm.TabIndex = 4;
            grpAddNewFarm.TabStop = false;
            grpAddNewFarm.Paint += grpAddNewFarm_Paint;
            // 
            // AddNewFarmForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(525, 176);
            Controls.Add(grpAddNewFarm);
            Controls.Add(btnNewFarmCancel);
            Controls.Add(btnNewFarmCreate);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddNewFarmForm";
            Text = "Add a new Farm";
            grpAddNewFarm.ResumeLayout(false);
            grpAddNewFarm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNewFarmName;
		private Button btnNewFarmCreate;
		private Label label1;
		private Button btnNewFarmCancel;
        private GroupBox grpAddNewFarm;
    }
}