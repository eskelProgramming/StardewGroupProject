using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StardewGroupProject.Forms
{
    public partial class AbandonedJojamartForm : Form
    {
        public AbandonedJojamartForm()
        {
            InitializeComponent();
        }

        private void lblMissingBundle_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = sender as Label;

            if (lbl != null)
            {
                // Define the color
                Color woodBrown = Color.FromArgb(226, 122, 62);

                // Create a rounded rectangle path
                int radius = 10;
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(lbl.Width - radius - 1, 0, radius, radius, 270, 90);
                path.AddArc(lbl.Width - radius - 1, lbl.Height - radius - 1, radius, radius, 0, 90);
                path.AddArc(0, lbl.Height - radius - 1, radius, radius, 90, 90);
                path.CloseAllFigures();

                // Set the label's region to the rounded rectangle
                lbl.Region = new Region(path);

                // Draw the custom border
                Pen pen = new Pen(woodBrown, 4);
                e.Graphics.DrawPath(pen, path);
            }
        }
    }
}
