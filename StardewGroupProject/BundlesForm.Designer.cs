namespace StardewGroupProject
{
	partial class BundlesForm
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
			btnCraftsRoom = new Button();
			btnVault = new Button();
			btnBulletinBoard = new Button();
			btnPantry = new Button();
			btnFishTank = new Button();
			btnBoilerRoom = new Button();
			SuspendLayout();
			// 
			// btnCraftsRoom
			// 
			btnCraftsRoom.Font = new Font("Sitka Subheading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnCraftsRoom.Location = new Point(176, 12);
			btnCraftsRoom.Name = "btnCraftsRoom";
			btnCraftsRoom.Size = new Size(107, 66);
			btnCraftsRoom.TabIndex = 0;
			btnCraftsRoom.Text = "Crafts Room";
			btnCraftsRoom.UseVisualStyleBackColor = true;
			btnCraftsRoom.Click += btnCraftsRoom_Click;
			// 
			// btnVault
			// 
			btnVault.Font = new Font("Sitka Subheading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnVault.Location = new Point(31, 81);
			btnVault.Name = "btnVault";
			btnVault.Size = new Size(107, 66);
			btnVault.TabIndex = 1;
			btnVault.Text = "Vault";
			btnVault.UseVisualStyleBackColor = true;
			btnVault.Click += btnVault_Click;
			// 
			// btnBulletinBoard
			// 
			btnBulletinBoard.Font = new Font("Sitka Subheading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnBulletinBoard.Location = new Point(31, 184);
			btnBulletinBoard.Name = "btnBulletinBoard";
			btnBulletinBoard.Size = new Size(107, 66);
			btnBulletinBoard.TabIndex = 2;
			btnBulletinBoard.Text = "Bulletin Board";
			btnBulletinBoard.UseVisualStyleBackColor = true;
			btnBulletinBoard.Click += btnBulletinBoard_Click;
			// 
			// btnPantry
			// 
			btnPantry.Font = new Font("Sitka Subheading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnPantry.Location = new Point(327, 81);
			btnPantry.Name = "btnPantry";
			btnPantry.Size = new Size(107, 66);
			btnPantry.TabIndex = 3;
			btnPantry.Text = "Pantry";
			btnPantry.UseVisualStyleBackColor = true;
			btnPantry.Click += btnPantry_Click;
			// 
			// btnFishTank
			// 
			btnFishTank.Font = new Font("Sitka Subheading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnFishTank.Location = new Point(327, 184);
			btnFishTank.Name = "btnFishTank";
			btnFishTank.Size = new Size(107, 66);
			btnFishTank.TabIndex = 4;
			btnFishTank.Text = "Fish Tank";
			btnFishTank.UseVisualStyleBackColor = true;
			btnFishTank.Click += btnFishTank_Click;
			// 
			// btnBoilerRoom
			// 
			btnBoilerRoom.Font = new Font("Sitka Subheading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnBoilerRoom.Location = new Point(176, 255);
			btnBoilerRoom.Name = "btnBoilerRoom";
			btnBoilerRoom.Size = new Size(107, 66);
			btnBoilerRoom.TabIndex = 5;
			btnBoilerRoom.Text = "Boiler Room";
			btnBoilerRoom.UseVisualStyleBackColor = true;
			btnBoilerRoom.Click += btnBoilerRoom_Click;
			// 
			// BundlesForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(470, 346);
			Controls.Add(btnBoilerRoom);
			Controls.Add(btnFishTank);
			Controls.Add(btnPantry);
			Controls.Add(btnBulletinBoard);
			Controls.Add(btnVault);
			Controls.Add(btnCraftsRoom);
			Name = "BundlesForm";
			Text = "Bundles";
			ResumeLayout(false);
		}

		#endregion

		private Button btnCraftsRoom;
		private Button btnVault;
		private Button btnBulletinBoard;
		private Button btnPantry;
		private Button btnFishTank;
		private Button btnBoilerRoom;
	}
}