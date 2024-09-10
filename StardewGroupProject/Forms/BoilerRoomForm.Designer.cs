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
            label5.Location = new Point(345, 164);
            label5.Name = "label5";
            label5.Size = new Size(90, 23);
            label5.TabIndex = 22;
            label5.Text = "Adventurer's";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 12F);
            label3.Location = new Point(49, 164);
            label3.Name = "label3";
            label3.Size = new Size(76, 23);
            label3.TabIndex = 20;
            label3.Text = "Geologist's";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 12F);
            label1.Location = new Point(196, 22);
            label1.Name = "label1";
            label1.Size = new Size(87, 23);
            label1.TabIndex = 18;
            label1.Text = "Blacksmith's";
            // 
            // cklAdventurers
            // 
            cklAdventurers.CheckOnClick = true;
            cklAdventurers.Font = new Font("Sitka Banner", 12F);
            cklAdventurers.FormattingEnabled = true;
            cklAdventurers.Location = new Point(330, 190);
            cklAdventurers.Name = "cklAdventurers";
            cklAdventurers.Size = new Size(120, 50);
            cklAdventurers.TabIndex = 16;
            cklAdventurers.ItemCheck += cklAdventurers_ItemCheck;
            // 
            // cklGeologists
            // 
            cklGeologists.CheckOnClick = true;
            cklGeologists.Font = new Font("Sitka Banner", 12F);
            cklGeologists.FormattingEnabled = true;
            cklGeologists.Location = new Point(32, 190);
            cklGeologists.Name = "cklGeologists";
            cklGeologists.Size = new Size(120, 50);
            cklGeologists.TabIndex = 14;
            cklGeologists.ItemCheck += cklGeologists_ItemCheck;
            // 
            // cklBlacksmiths
            // 
            cklBlacksmiths.CheckOnClick = true;
            cklBlacksmiths.Font = new Font("Sitka Banner", 12F);
            cklBlacksmiths.FormattingEnabled = true;
            cklBlacksmiths.Location = new Point(182, 48);
            cklBlacksmiths.Name = "cklBlacksmiths";
            cklBlacksmiths.Size = new Size(120, 50);
            cklBlacksmiths.TabIndex = 12;
            cklBlacksmiths.ItemCheck += cklBlacksmiths_ItemCheck;
            // 
            // BoilerRoomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 321);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(cklAdventurers);
            Controls.Add(cklGeologists);
            Controls.Add(cklBlacksmiths);
            Name = "BoilerRoomForm";
            StartPosition = FormStartPosition.CenterParent;
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