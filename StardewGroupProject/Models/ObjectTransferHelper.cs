using StardewGroupProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StardewGroupProject.Models
{
    /// <summary>
    /// A static class that is used to transfer objects between different forms and classes.
    /// </summary>
    public static class ObjectTransferHelper
    {
        private static FarmContext _context;

        /// <summary>
        /// The Farm that was most recently selected by the user.
        /// </summary>
        public static Farm CurrentFarm { get; set; }

        /// <summary>
        /// A reference to the FarmContext object that is used to interact with the database.
        /// </summary>
        public static FarmContext Context
        {
            get
            {
                if (_context == null)
                {
                    _context = new FarmContext();
                }
                return _context;
            }
            set
            {
                _context = value;
            }
        }
    }
}
