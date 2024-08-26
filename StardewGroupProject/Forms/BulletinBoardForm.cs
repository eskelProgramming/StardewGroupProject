using StardewGroupProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StardewGroupProject
{
    public partial class BulletinBoardForm : Form
    {
        public BulletinBoardForm()
        {
            InitializeComponent();
        }

        private void BulletinBoardForm_Load(object sender, EventArgs e)
        {
            LoadBundles();
            UpdateCheckboxes();
        }

        private void UpdateCheckboxes()
        {
            for (int i = 0; i < cklChefs.Items.Count; i++)
            {
                cklChefs.SetItemChecked(i, FarmHelper.IsItemComplete((Item)cklChefs.Items[i]));
            }

            for (int i = 0; i < cklDye.Items.Count; i++)
            {
                cklDye.SetItemChecked(i, FarmHelper.IsItemComplete((Item)cklDye.Items[i]));
            }

            for (int i = 0; i < cklFieldResearch.Items.Count; i++)
            {
                cklFieldResearch.SetItemChecked(i, FarmHelper.IsItemComplete((Item)cklFieldResearch.Items[i]));
            }

            for (int i = 0; i < cklFodder.Items.Count; i++)
            {
                cklFodder.SetItemChecked(i, FarmHelper.IsItemComplete((Item)cklFodder.Items[i]));
            }

            for (int i = 0; i < cklEnchanters.Items.Count; i++)
            {
                cklEnchanters.SetItemChecked(i, FarmHelper.IsItemComplete((Item)cklEnchanters.Items[i]));
            }
        }

        private void LoadBundles()
        {
            List<Bundle> bundles = ObjectTransferHelper.CurrentFarm.GetRoom("Bulletin Board").Bundles;

            foreach (var item in bundles[0].Items)
            {
                cklChefs.Items.Add(item);
            }

            foreach (var item in bundles[1].Items)
            {
                cklDye.Items.Add(item);
            }

            foreach (var item in bundles[2].Items)
            {
                cklFieldResearch.Items.Add(item);
            }

            foreach (var item in bundles[3].Items)
            {
                cklFodder.Items.Add(item);
            }

            foreach (var item in bundles[4].Items)
            {
                cklEnchanters.Items.Add(item);
            }
        }

        private void cklChefs_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Get the item that was clicked
            Item item = (Item)cklChefs.Items[e.Index];
            if (item != null)
            {
                FarmHelper.UpdateItemComplete(e.NewValue == CheckState.Checked, item);
            }
        }

        private void cklDye_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Get the item that was clicked
            Item item = (Item)cklDye.Items[e.Index];
            if (item != null)
            {
                FarmHelper.UpdateItemComplete(e.NewValue == CheckState.Checked, item);
            }
        }

        private void cklFieldResearch_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Get the item that was clicked
            Item item = (Item)cklFieldResearch.Items[e.Index];
            if (item != null)
            {
                FarmHelper.UpdateItemComplete(e.NewValue == CheckState.Checked, item);
            }
        }

        private void cklFodder_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Get the item that was clicked
            Item item = (Item)cklFodder.Items[e.Index];
            if (item != null)
            {
                FarmHelper.UpdateItemComplete(e.NewValue == CheckState.Checked, item);
            }
        }

        private void cklEnchanters_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Get the item that was clicked
            Item item = (Item)cklEnchanters.Items[e.Index];
            if (item != null)
            {
                FarmHelper.UpdateItemComplete(e.NewValue == CheckState.Checked, item);
            }
        }
    }
}
