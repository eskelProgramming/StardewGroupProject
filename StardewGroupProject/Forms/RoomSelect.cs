using StardewGroupProject.Data;
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

namespace StardewGroupProject.Forms
{
    public partial class RoomSelect : Form
    {
        private string roomName;

        public RoomSelect()
        {
            InitializeComponent();
        }

        public RoomSelect(string RoomName)
        {
            InitializeComponent();

            roomName = RoomName;
        }

        private void Room_Load(object sender, EventArgs e)
        {
            PopulateForm();
        }

        /// <summary>
        /// Grabs the Bundles for the Room selected. 
        /// </summary>
        private void PopulateForm()
        {
            FarmContext context = new();

            // Get the Room using the context
            Room room = context.Rooms.FirstOrDefault(r => r.Name == roomName);

            // Get the Bundles for the Room
            List<Bundle> bundles = room.Bundles;

            ckl1.Items.AddRange(bundles[1].Items.ToArray());

            // Change the Text of the Form to the Room Name
        }
    }
}
