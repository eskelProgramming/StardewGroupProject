namespace StardewGroupProject
{
	partial class BoilerRoomForm
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
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            cklAdventurers = new CheckedListBox();
            cklGeologists = new CheckedListBox();
            cklBlacksmiths = new CheckedListBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Banner", 12F);
            label5.Location = new Point(394, 219);
            label5.Name = "label5";
            label5.Size = new Size(110, 29);
            label5.TabIndex = 22;
            label5.Text = "Adventurer's";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 12F);
            label3.Location = new Point(56, 219);
            label3.Name = "label3";
            label3.Size = new Size(94, 29);
            label3.TabIndex = 20;
            label3.Text = "Geologist's";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 12F);
            label1.Location = new Point(224, 29);
            label1.Name = "label1";
            label1.Size = new Size(108, 29);
            label1.TabIndex = 18;
            label1.Text = "Blacksmith's";
            // 
            // cklAdventurers
            // 
            cklAdventurers.Font = new Font("Sitka Banner", 12F);
            cklAdventurers.FormattingEnabled = true;
            cklAdventurers.Location = new Point(377, 253);
            cklAdventurers.Margin = new Padding(3, 4, 3, 4);
            cklAdventurers.Name = "cklAdventurers";
            cklAdventurers.Size = new Size(137, 88);
            cklAdventurers.TabIndex = 16;
            cklAdventurers.ItemCheck += cklAdventurers_ItemCheck;
            // 
            // cklGeologists
            // 
            cklGeologists.Font = new Font("Sitka Banner", 12F);
            cklGeologists.FormattingEnabled = true;
            cklGeologists.Location = new Point(37, 253);
            cklGeologists.Margin = new Padding(3, 4, 3, 4);
            cklGeologists.Name = "cklGeologists";
            cklGeologists.Size = new Size(137, 88);
            cklGeologists.TabIndex = 14;
            cklGeologists.ItemCheck += cklGeologists_ItemCheck;
            // 
            // cklBlacksmiths
            // 
            cklBlacksmiths.Font = new Font("Sitka Banner", 12F);
            cklBlacksmiths.FormattingEnabled = true;
            cklBlacksmiths.Location = new Point(208, 64);
            cklBlacksmiths.Margin = new Padding(3, 4, 3, 4);
            cklBlacksmiths.Name = "cklBlacksmiths";
            cklBlacksmiths.Size = new Size(137, 88);
            cklBlacksmiths.TabIndex = 12;
            cklBlacksmiths.ItemCheck += cklBlacksmiths_ItemCheck;
            // 
            // BoilerRoomForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 428);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(cklAdventurers);
            Controls.Add(cklGeologists);
            Controls.Add(cklBlacksmiths);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BoilerRoomForm";
            Text = "Boiler Room Bundles";
            Load += BoilerRoomForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
		private Label label3;
		private Label label1;
		private CheckedListBox cklAdventurers;
		private CheckedListBox cklGeologists;
		private CheckedListBox cklBlacksmiths;
	}
}