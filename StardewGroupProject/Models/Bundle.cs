using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StardewGroupProject.Models
{
    /// <summary>
    /// Represents a single Bundle.
    /// </summary>
    public class Bundle
    {
        /// <summary>
        /// The unique id for the Bundle.
        /// </summary>
        [Key]
        public int BundleId { get; set; }

        /// <summary>
        /// The name of the bundle.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// A list of the Items in the Bundle. 
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// True if the Bundle has been completed, false 
        /// if it has not. Default is false. 
        /// </summary>
        [DefaultValue(false)]
        public bool Complete { get; set; }

        /// <summary>
        /// The number of Items that must be completed
        /// for the Bundle to be completed. 
        /// </summary>
        public int Quantity { get; set; }
    }
}
