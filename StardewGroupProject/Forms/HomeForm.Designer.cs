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
			btnAddNewFarm = new Button();
			btnDeleteFarm = new Button();
			btnViewCommunityCenter = new Button();
			cmbFarmNames = new ComboBox();
			label1 = new Label();
			label2 = new Label();
			SuspendLayout();
			// 
			// btnAddNewFarm
			// 
			btnAddNewFarm.Font = new Font("Sitka Subheading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnAddNewFarm.Location = new Point(343, 22);
			btnAddNewFarm.Name = "btnAddNewFarm";
			btnAddNewFarm.Size = new Size(172, 71);
			btnAddNewFarm.TabIndex = 0;
			btnAddNewFarm.Text = "Add a new Farm";
			btnAddNewFarm.UseVisualStyleBackColor = true;
			btnAddNewFarm.Click += btnAddNewFarm_Click;
			// 
			// btnDeleteFarm
			// 
			btnDeleteFarm.Font = new Font("Sitka Subheading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnDeleteFarm.Location = new Point(343, 153);
			btnDeleteFarm.Name = "btnDeleteFarm";
			btnDeleteFarm.Size = new Size(172, 71);
			btnDeleteFarm.TabIndex = 1;
			btnDeleteFarm.Text = "Delete selected Farm";
			btnDeleteFarm.UseVisualStyleBackColor = true;
			// 
			// btnViewCommunityCenter
			// 
			btnViewCommunityCenter.Font = new Font("Sitka Subheading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnViewCommunityCenter.Location = new Point(343, 283);
			btnViewCommunityCenter.Name = "btnViewCommunityCenter";
			btnViewCommunityCenter.Size = new Size(172, 71);
			btnViewCommunityCenter.TabIndex = 2;
			btnViewCommunityCenter.Text = "View the Bundles";
			btnViewCommunityCenter.UseVisualStyleBackColor = true;
			btnViewCommunityCenter.Click += btnViewCommunityCenter_Click;
			// 
			// cmbFarmNames
			// 
			cmbFarmNames.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbFarmNames.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			cmbFarmNames.FormattingEnabled = true;
			cmbFarmNames.Location = new Point(90, 174);
			cmbFarmNames.Name = "cmbFarmNames";
			cmbFarmNames.Size = new Size(161, 31);
			cmbFarmNames.TabIndex = 3;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Sitka Subheading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(110, 137);
			label1.Name = "label1";
			label1.Size = new Size(119, 23);
			label1.TabIndex = 4;
			label1.Text = "Choose a Farm:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Sitka Subheading", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.Location = new Point(12, 44);
			label2.Name = "label2";
			label2.Size = new Size(309, 28);
			label2.TabIndex = 5;
			label2.Text = "Welcome to the Community Center!";
			// 
			// HomeForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(547, 386);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(cmbFarmNames);
			Controls.Add(btnViewCommunityCenter);
			Controls.Add(btnDeleteFarm);
			Controls.Add(btnAddNewFarm);
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
		private Label label1;
		private Label label2;
	}
}
