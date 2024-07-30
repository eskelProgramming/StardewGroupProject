﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
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
        /// A list of the Bundles for the Farm. 
        /// </summary>
        public List<Bundle> Bundles { get; set; }
    }
}