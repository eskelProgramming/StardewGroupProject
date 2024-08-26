using StardewGroupProject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace StardewGroupProject.Models
{
    /// <summary>
    /// Represents a single Farm.
    /// </summary>
    public class Farm
    {
        /// <summary>
        /// Represents a single Farm using the Default Rooms, Bundles, and Items 
        /// </summary>
        /// <param name="name">The name of the player's farm</param>
        public Farm(string name)
        {
            Name = name;
        }

        /// <summary>
        /// The unique id of the farm.
        /// </summary>
        [Key]
        public int FarmId { get; set; }

        /// <summary>
        /// The name of the Farm.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// A list of Rooms in the Community Center
        /// </summary>
        public List<Room> Rooms { get; set; }

        public Room GetRoom(string roomName)
        {
            return ObjectTransferHelper.CurrentFarm.Rooms.FirstOrDefault(r => r.Name == roomName);
        }
    }
}
