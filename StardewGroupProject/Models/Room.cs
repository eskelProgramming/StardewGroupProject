﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StardewGroupProject.Models
{
    /// <summary>
    /// Represents a single Room
    /// </summary>
    public class Room
    {
		// Parameterless constructor required by EF Core
		public Room() { }
        /// <summary>
        /// Represents a single Farm
        /// </summary>
        /// <param name="name">The name of the Room</param>
        /// <param name="bundles">The Bundles in the Room</param>
        public Room(string name, List<Bundle> bundles)
        {
            Name = name;
            Bundles = bundles;
            Completed = false;
        }

        /// <summary>
        /// The unique primary key of the Room. 
        /// </summary>
        [Key]
        public int RoomId { get; set; }

        /// <summary>
        /// The name of the Room. 
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// A list of the Bundles associated with the Room.
        /// </summary>
        public List<Bundle> Bundles { get; set; }

        /// <summary>
        /// True if the all Bundles in the room have been complete,
        /// false if they have not. 
        /// </summary>
        [DefaultValue(false)]
        public bool Completed { get; set;}
    }
}
