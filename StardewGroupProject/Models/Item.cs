using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace StardewGroupProject.Models
{
    /// <summary>
    /// Represents an a unique item within a bundle. 
    /// An item is specific to the bundle it is in.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// The unique id of the item. 
        /// </summary>
        [Key]
        public int ItemId { get; set; }

        /// <summary>
        /// The name of the item.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// True if the item has been added to the bundle, 
        /// false if it has not. The default is false. 
        /// </summary>
        [DefaultValue(false)]
        public bool Complete { get; set; }

        /// <summary>
        /// The quantity of the item needed to complete the bundle.
        /// </summary>
        public int Quantity { get; set; }
    }
}
