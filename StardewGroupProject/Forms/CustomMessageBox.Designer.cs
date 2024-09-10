namespace StardewGroupProject.Forms
{
    partial class CustomMessageBoxForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageBoxForm));
            grpCustomMessageBox = new GroupBox();
            btnUnderstood = new Button();
            btnNo = new Button();
            txtCustomMessageBox = new TextBox();
            btnYes = new Button();
            grpCustomMessageBox.SuspendLayout();
            SuspendLayout();
            // 
            // grpCustomMessageBox
            // 
            grpCustomMessageBox.Controls.Add(btnUnderstood);
            grpCustomMessageBox.Controls.Add(btnNo);
            grpCustomMessageBox.Controls.Add(txtCustomMessageBox);
            grpCustomMessageBox.Controls.Add(btnYes);
            grpCustomMessageBox.Font = new Font("Reem Kufi", 13F);
            grpCustomMessageBox.Location = new Point(0, 0);
            grpCustomMessageBox.Name = "grpCustomMessageBox";
            grpCustomMessageBox.Size = new Size(372, 141);
            grpCustomMessageBox.TabIndex = 0;
            grpCustomMessageBox.TabStop = false;
            grpCustomMessageBox.Paint += grpCustomMessageBox_Paint;
            // 
            // btnUnderstood
            // 
            btnUnderstood.BackColor = Color.FromArgb(255, 215, 137);
            btnUnderstood.Font = new Font("Reem Kufi", 13F);
            btnUnderstood.Location = new Point(125, 77);
            btnUnderstood.Name = "btnUnderstood";
            btnUnderstood.Size = new Size(120, 54);
            btnUnderstood.TabIndex = 4;
            btnUnderstood.Text = "Understood";
            btnUnderstood.UseVisualStyleBackColor = false;
            btnUnderstood.Visible = false;
            btnUnderstood.Click += btnUnderstood_Click;
            btnUnderstood.Paint += btnUnderstood_Paint;
            btnUnderstood.MouseEnter += btnUnderstood_MouseEnter;
            btnUnderstood.MouseLeave += btnUnderstood_MouseLeave;
            // 
            // btnNo
            // 
            btnNo.BackColor = Color.FromArgb(255, 215, 137);
            btnNo.Font = new Font("Reem Kufi", 15F);
            btnNo.Location = new Point(214, 77);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(120, 54);
            btnNo.TabIndex = 3;
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = false;
            btnNo.Visible = false;
            btnNo.Click += btnNo_Click;
            btnNo.Paint += btnNo_Paint;
            btnNo.MouseEnter += btnNo_MouseEnter;
            btnNo.MouseLeave += btnNo_MouseLeave;
            // 
            // txtCustomMessageBox
            // 
            txtCustomMessageBox.BackColor = Color.FromArgb(255, 215, 137);
            txtCustomMessageBox.BorderStyle = BorderStyle.FixedSingle;
            txtCustomMessageBox.Enabled = false;
            txtCustomMessageBox.Font = new Font("Reem Kufi", 12F);
            txtCustomMessageBox.ForeColor = Color.Firebrick;
            txtCustomMessageBox.Location = new Point(12, 33);
            txtCustomMessageBox.Name = "txtCustomMessageBox";
            txtCustomMessageBox.Size = new Size(348, 38);
            txtCustomMessageBox.TabIndex = 2;
            txtCustomMessageBox.TextAlign = HorizontalAlignment.Center;
            // 
            // btnYes
            // 
            btnYes.BackColor = Color.FromArgb(255, 215, 137);
            btnYes.Font = new Font("Reem Kufi", 15F);
            btnYes.Location = new Point(41, 77);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(120, 54);
            btnYes.TabIndex = 1;
            btnYes.Text = "Yes";
            btnYes.UseVisualStyleBackColor = false;
            btnYes.Visible = false;
            btnYes.Click += btnYes_Click;
            btnYes.Paint += btnYes_Paint;
            btnYes.MouseEnter += btnYes_MouseEnter;
            btnYes.MouseLeave += btnYes_MouseLeave;
            // 
            // CustomMessageBoxForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 215, 137);
            ClientSize = new Size(372, 140);
            Controls.Add(grpCustomMessageBox);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CustomMessageBoxForm";
            grpCustomMessageBox.ResumeLayout(false);
            grpCustomMessageBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpCustomMessageBox;
        private Button btnYes;
        private TextBox txtCustomMessageBox;
        private Button btnNo;
        private Button btnUnderstood;
    }
}