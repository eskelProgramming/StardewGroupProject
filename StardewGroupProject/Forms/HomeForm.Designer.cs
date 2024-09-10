namespace StardewGroupProject
{
    partial class HomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            btnAddNewFarm = new Button();
            btnDeleteFarm = new Button();
            btnViewCommunityCenter = new Button();
            cmbFarmNames = new ComboBox();
            lblChooseFarm = new Label();
            lblWelcomeMessage = new Label();
            SuspendLayout();
            // 
            // btnAddNewFarm
            // 
            btnAddNewFarm.BackColor = Color.FromArgb(255, 215, 137);
            btnAddNewFarm.Font = new Font("Reem Kufi", 15F);
            btnAddNewFarm.Location = new Point(392, 104);
            btnAddNewFarm.Name = "btnAddNewFarm";
            btnAddNewFarm.Size = new Size(188, 102);
            btnAddNewFarm.TabIndex = 0;
            btnAddNewFarm.Text = "Add a new Farm";
            btnAddNewFarm.UseVisualStyleBackColor = false;
            btnAddNewFarm.Click += btnAddNewFarm_Click;
            btnAddNewFarm.Paint += btnAddNewFarm_Paint;
            btnAddNewFarm.MouseEnter += btnAddNewFarm_MouseEnter;
            btnAddNewFarm.MouseLeave += btnAddNewFarm_MouseLeave;
            // 
            // btnDeleteFarm
            // 
            btnDeleteFarm.BackColor = Color.FromArgb(255, 215, 137);
            btnDeleteFarm.Font = new Font("Reem Kufi", 15F);
            btnDeleteFarm.Location = new Point(112, 277);
            btnDeleteFarm.Name = "btnDeleteFarm";
            btnDeleteFarm.Size = new Size(188, 102);
            btnDeleteFarm.TabIndex = 1;
            btnDeleteFarm.Text = "Delete selected Farm";
            btnDeleteFarm.UseVisualStyleBackColor = false;
            btnDeleteFarm.Click += btnDeleteFarm_Click;
            btnDeleteFarm.Paint += btnDeleteFarm_Paint;
            btnDeleteFarm.MouseEnter += btnDeleteFarm_MouseEnter;
            btnDeleteFarm.MouseLeave += btnDeleteFarm_MouseLeave;
            // 
            // btnViewCommunityCenter
            // 
            btnViewCommunityCenter.BackColor = Color.FromArgb(255, 215, 137);
            btnViewCommunityCenter.Font = new Font("Reem Kufi", 15F);
            btnViewCommunityCenter.Location = new Point(392, 277);
            btnViewCommunityCenter.Name = "btnViewCommunityCenter";
            btnViewCommunityCenter.Size = new Size(188, 102);
            btnViewCommunityCenter.TabIndex = 2;
            btnViewCommunityCenter.Text = "View the Bundles";
            btnViewCommunityCenter.UseVisualStyleBackColor = false;
            btnViewCommunityCenter.Click += btnViewCommunityCenter_Click;
            btnViewCommunityCenter.Paint += btnViewCommunityCenter_Paint;
            btnViewCommunityCenter.MouseEnter += btnViewCommunityCenter_MouseEnter;
            btnViewCommunityCenter.MouseLeave += btnViewCommunityCenter_MouseLeave;
            // 
            // cmbFarmNames
            // 
            cmbFarmNames.BackColor = Color.FromArgb(255, 215, 137);
            cmbFarmNames.DrawMode = DrawMode.OwnerDrawFixed;
            cmbFarmNames.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFarmNames.Font = new Font("Reem Kufi", 12F);
            cmbFarmNames.FormattingEnabled = true;
            cmbFarmNames.Location = new Point(123, 151);
            cmbFarmNames.Name = "cmbFarmNames";
            cmbFarmNames.Size = new Size(168, 39);
            cmbFarmNames.TabIndex = 3;
            cmbFarmNames.DrawItem += cmbFarmNames_DrawItem;
            cmbFarmNames.SelectedIndexChanged += cmbFarmNames_SelectedIndexChanged;
            // 
            // lblChooseFarm
            // 
            lblChooseFarm.AutoSize = true;
            lblChooseFarm.BackColor = Color.FromArgb(255, 215, 137);
            lblChooseFarm.Font = new Font("Reem Kufi", 12F);
            lblChooseFarm.Location = new Point(149, 118);
            lblChooseFarm.Name = "lblChooseFarm";
            lblChooseFarm.Size = new Size(118, 30);
            lblChooseFarm.TabIndex = 4;
            lblChooseFarm.Text = "Choose a Farm:";
            lblChooseFarm.Paint += lblChooseFarm_Paint;
            // 
            // lblWelcomeMessage
            // 
            lblWelcomeMessage.AutoSize = true;
            lblWelcomeMessage.BackColor = Color.FromArgb(255, 215, 137);
            lblWelcomeMessage.Font = new Font("Reem Kufi", 15F);
            lblWelcomeMessage.Location = new Point(184, 22);
            lblWelcomeMessage.Name = "lblWelcomeMessage";
            lblWelcomeMessage.Size = new Size(327, 38);
            lblWelcomeMessage.TabIndex = 5;
            lblWelcomeMessage.Text = "Welcome to the Community Center!";
            lblWelcomeMessage.Paint += lblWelcomeMessage_Paint;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(691, 426);
            Controls.Add(lblWelcomeMessage);
            Controls.Add(lblChooseFarm);
            Controls.Add(cmbFarmNames);
            Controls.Add(btnViewCommunityCenter);
            Controls.Add(btnDeleteFarm);
            Controls.Add(btnAddNewFarm);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HomeForm";
            Text = "Home";
            Load += HomeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddNewFarm;
		private Button btnDeleteFarm;
		private Button btnViewCommunityCenter;
		private ComboBox cmbFarmNames;
		private Label lblChooseFarm;
		private Label lblWelcomeMessage;
	}
}
