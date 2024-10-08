﻿using StardewGroupProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StardewGroupProject.Data;
using System.Drawing.Drawing2D;
using StardewGroupProject.Forms;

namespace StardewGroupProject
{
    public partial class AddNewFarmForm : Form
    {
        public AddNewFarmForm()
        {
            InitializeComponent();
        }

        private void btnNewFarmCreate_Click(object sender, EventArgs e)
        {
            string newFarmName = txtNewFarmName.Text;

            if (Validator.IsValidFarmName(newFarmName)) // Checks if the farm name is valid using the Validator class
            {
                Farm farm = new(newFarmName);

                farm.Rooms =
                [
                    new Room("Crafts Room",
                        [
                            new Bundle("Spring Foraging",
                                [
                                    new Item("Wild Horseradish", 1),
                                    new Item("Daffodil", 1),
                                    new Item("Leek", 1),
                                    new Item("Dandelion", 1)
                                ], 4),
                            new Bundle("Summer Foraging",
                                [
                                    new Item("Grape", 1),
                                    new Item("Spice Berry", 1),
                                    new Item("Sweet Pea", 1)
                                ], 3),
                            new Bundle("Fall Foraging",
                                [
                                    new Item("Common Mushroom", 1),
                                    new Item("Wild Plum", 1),
                                    new Item("Hazelnut", 1),
                                    new Item("Blackberry", 1)
                                ], 4),
                            new Bundle("Winter Foraging",
                                [
                                    new Item("Winter Root", 1),
                                    new Item("Crystal Fruit", 1),
                                    new Item("Snow Yam", 1),
                                    new Item("Crocus", 1)
                                ], 4),
                            new Bundle("Construction",
                                [
                                    new Item("Wood", 99),
                                    new Item("Wood", 99),
                                    new Item("Stone", 99),
                                    new Item("Hardwood", 10)
                                ], 4),
                            new Bundle("Exotic Foraging",
                                [
                                    new Item("Coconut", 1),
                                    new Item("Cactus Fruit", 1),
                                    new Item("Cave Carrot", 1),
                                    new Item("Red Mushroom", 1),
                                    new Item("Purple Mushroom", 1),
                                    new Item("Maple Syrup", 1),
                                    new Item("Oak Resin", 1),
                                    new Item("Pine Tar", 1),
                                    new Item("Morel", 1)
                                ], 5)
                        ]),

                    new Room("Pantry",
                        [
                            new Bundle("Spring Crops",
                                [
                                    new Item("Parsnip", 1),
                                    new Item("Green Bean", 1),
                                    new Item("Cauliflower", 1),
                                    new Item("Potato", 1)
                                ], 4),
                            new Bundle("Summer Crops",
                                [
                                    new Item("Tomato", 1),
                                    new Item("Hot Pepper", 1),
                                    new Item("Blueberry", 1),
                                    new Item("Melon", 1)
                                ], 4),
                            new Bundle("Fall Crops",
                                [
                                    new Item("Corn", 1),
                                    new Item("Eggplant", 1),
                                    new Item("Pumpkin", 1),
                                    new Item("Yam", 1)
                                ], 4),
                            new Bundle("Quality Crops",
                                [
                                    new Item("Gold Quality Parsnip", 5),
                                    new Item("Gold Quality Melon", 5),
                                    new Item("Gold Quality Pumpkin", 5),
                                    new Item("Gold Quality Corn", 5)
                                ], 3),
                            new Bundle("Animal Bundle",
                                [
                                    new Item("Large Milk", 1),
                                    new Item("Large Brown Egg", 1),
                                    new Item("Large White Egg", 1),
                                    new Item("Large Goat Milk", 1),
                                    new Item("Wool", 1),
                                    new Item("Duck Egg", 1)
                                ], 5),
                            new Bundle("Artisan Bundle",
                                [
                                    new Item("Truffle Oil", 1),
                                    new Item("Cloth", 1),
                                    new Item("Goat Cheese", 1),
                                    new Item("Cheese", 1),
                                    new Item("Honey", 1),
                                    new Item("Jelly", 1),
                                    new Item("Apple", 1),
                                    new Item("Apricot", 1),
                                    new Item("Orange", 1),
                                    new Item("Peach", 1),
                                    new Item("Pomegranate", 1),
                                    new Item("Cherry", 1)
                                ], 6)
                        ]),
                    new Room("Fish Tank",
                        [
                            new Bundle("River Fish",
                                [
                                    new Item("Sunfish", 1),
                                    new Item("Catfish", 1),
                                    new Item("Shad", 1),
                                    new Item("Tiger Trout", 1)
                                ], 4),
                            new Bundle("Lake Fish",
                                [
                                    new Item("Largemouth Bass", 1),
                                    new Item("Carp", 1),
                                    new Item("Bullhead", 1),
                                    new Item("Sturgeon", 1)
                                ], 4),
                            new Bundle("Ocean Fish",
                                [
                                    new Item("Sardine", 1),
                                    new Item("Tuna", 1),
                                    new Item("Red Snapper", 1),
                                    new Item("Tilapia", 1)
                                ], 4),
                            new Bundle("Night Fishing",
                                [
                                    new Item("Walleye", 1),
                                    new Item("Bream", 1),
                                    new Item("Eel", 1),
                                ], 3),
                            new Bundle("Specialty Fish",
                                [
                                    new Item("Pufferfish", 1),
                                    new Item("Ghostfish", 1),
                                    new Item("Sandfish", 1),
                                    new Item("Woodskip", 1)
                                ], 4),
                            new Bundle("Crab Pot",
                                [
                                    new Item("Lobster", 1),
                                    new Item("Crayfish", 1),
                                    new Item("Crab", 1),
                                    new Item("Cockle", 1),
                                    new Item("Mussel", 1),
                                    new Item("Shrimp", 1),
                                    new Item("Snail", 1),
                                    new Item("Periwinkle", 1),
                                    new Item("Oyster", 1),
                                    new Item("Clam", 1)
                                ], 5)
                        ]),
                    new Room("Boiler Room",
                        [
                            new Bundle("Blacksmith's Bundle",
                                [
                                    new Item("Copper Bar", 1),
                                    new Item("Iron Bar", 1),
                                    new Item("Gold Bar", 1)
                                ], 3),
                            new Bundle("Geologist's Bundle",
                                [
                                    new Item("Quartz", 1),
                                    new Item("Earth Crystal", 1),
                                    new Item("Frozen Tear", 1),
                                    new Item("Fire Quartz", 1)
                                ], 4),
                            new Bundle("Adventurer's Bundle",
                                [
                                    new Item("Slime", 99),
                                    new Item("Bat Wing", 10),
                                    new Item("Solar Essence", 1),
                                    new Item("Void Essence", 1)
                                ], 2)
                        ]),
                    new Room("Vault",
                        [
                            new Bundle("2,500g",
                                [
                                    new Item("2,500g", 1)
                                ], 1),
                            new Bundle("5,000g",
                                [
                                    new Item("5,000g", 1)
                                ], 1),
                            new Bundle("10,000g",
                                [
                                    new Item("10,000g", 1)
                                ], 1),
                            new Bundle("25,000g",
                                [
                                    new Item("25,000g", 1)
                                ], 1)
                        ]),
                    new Room("Bulletin Board",
                        [
                            new Bundle("Chef's Bundle",
                                [
                                    new Item("Maple Syrup", 1),
                                    new Item("Fiddlehead Fern", 1),
                                    new Item("Truffle", 1),
                                    new Item("Poppy", 1),
                                    new Item("Maki Roll", 1),
                                    new Item("Fried Egg", 1),
                                ], 6),
                            new Bundle("Dye Bundle",
                                [
                                    new Item("Red Mushroom", 1),
                                    new Item("Sea Urchin", 1),
                                    new Item("Sunflower", 1),
                                    new Item("Duck Feather", 1),
                                    new Item("Aquamarine", 1),
                                    new Item("Red Cabbage", 1)
                                ], 6),
                            new Bundle("Field Research Bundle",
                                [
                                    new Item("Purple Mushroom", 1),
                                    new Item("Nautilus Shell", 1),
                                    new Item("Chub", 1),
                                    new Item("Frozen Geode", 1)
                                ], 4),
                            new Bundle("Fodder Bundle",
                                [
                                    new Item("Wheat", 10),
                                    new Item("Hay", 10),
                                    new Item("Apple", 3)
                                ], 3),
                            new Bundle("Enchanter's Bundle",
                                [
                                    new Item("Oak Resin", 1),
                                    new Item("Wine", 1),
                                    new Item("Rabbit's Foot", 1),
                                    new Item("Pomegranate", 1)
                                ], 4)
                        ]),
                    new Room("Abandoned JojaMart",
                        [
                            new Bundle("Missing Bundle",
                            [
                                new Item("Silver or better quality wine", 1),
                                new Item("Dinosaur Mayonnaise", 1),
                                new Item("Prismatic Shard", 1),
                                new Item("Gold Quality Ancient Fruit", 5),
                                new Item("Gold or Iridium Quality Void Salmon", 1),
                                new Item("Caviar", 1)
                             ], 5)
                        ])
                ];

                ObjectTransferHelper.Context.Farms.Add(farm); // Adds the new Farm object to the Database using Entity Framework
                ObjectTransferHelper.Context.SaveChanges(); // Saves those changes

                CustomMessageBoxForm messageBox = new();

                messageBox.ValidFarmNameMessage();
                messageBox.ShowDialog();

                Close();
            }
            else
            {
                CustomMessageBoxForm messageBox = new();

                messageBox.InvalidFarmNameMessage();
                messageBox.ShowDialog();

                txtNewFarmName.Clear();
            }
        }

        private void btnNewFarmCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnNewFarmCancel_Paint(object sender, PaintEventArgs e)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;

            if (btn != null)
            {
                // Define the color
                Color woodBrown = Color.FromArgb(226, 122, 62);

                // Create a rounded rectangle path
                int radius = 10;
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(btn.Width - radius - 1, 0, radius, radius, 270, 90);
                path.AddArc(btn.Width - radius - 1, btn.Height - radius - 1, radius, radius, 0, 90);
                path.AddArc(0, btn.Height - radius - 1, radius, radius, 90, 90);
                path.CloseAllFigures();

                // Set the button's region to the rounded rectangle
                btn.Region = new Region(path);

                // Draw the custom border
                Pen pen = new Pen(woodBrown, 8);
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void btnNewFarmCreate_Paint(object sender, PaintEventArgs e)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;

            if (btn != null)
            {
                // Define the color
                Color woodBrown = Color.FromArgb(226, 122, 62);

                // Create a rounded rectangle path
                int radius = 10;
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(btn.Width - radius - 1, 0, radius, radius, 270, 90);
                path.AddArc(btn.Width - radius - 1, btn.Height - radius - 1, radius, radius, 0, 90);
                path.AddArc(0, btn.Height - radius - 1, radius, radius, 90, 90);
                path.CloseAllFigures();

                // Set the button's region to the rounded rectangle
                btn.Region = new Region(path);

                // Draw the custom border
                Pen pen = new Pen(woodBrown, 8);
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void grpAddNewFarm_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;

            if (box != null)
            {
                // Define the color
                Color woodBrown = Color.FromArgb(226, 122, 62);

                // Create a rounded rectangle path
                int radius = 10;
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(box.Width - radius - 1, 0, radius, radius, 270, 90);
                path.AddArc(box.Width - radius - 1, box.Height - radius - 1, radius, radius, 0, 90);
                path.AddArc(0, box.Height - radius - 1, radius, radius, 90, 90);
                path.CloseAllFigures();

                // Set the GroupBox's region to the rounded rectangle
                box.Region = new Region(path);

                // Draw the custom border
                Pen pen = new Pen(woodBrown, 8);
                e.Graphics.DrawPath(pen, path);
            }
        }
        private void btnNewFarmCancel_MouseEnter(object sender, EventArgs e)
        {
            btnNewFarmCancel.BackColor = Color.FromArgb(214, 180, 116);
        }

        private void btnNewFarmCancel_MouseLeave(object sender, EventArgs e)
        {
            btnNewFarmCancel.BackColor = Color.FromArgb(255, 215, 137);
        }

        private void btnNewFarmCreate_MouseEnter(object sender, EventArgs e)
        {
            btnNewFarmCreate.BackColor = Color.FromArgb(214, 180, 116);
        }

        private void btnNewFarmCreate_MouseLeave(object sender, EventArgs e)
        {
            btnNewFarmCreate.BackColor = Color.FromArgb(255, 215, 137);
        }
    }
}
