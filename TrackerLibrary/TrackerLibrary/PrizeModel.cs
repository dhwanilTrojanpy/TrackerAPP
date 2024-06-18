using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents the place number of the team.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Represents the place name of the team.
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Represents the prize amount according to the place.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Represents the prize percentage.
        /// </summary>
        public double Percentage { get; set; }
    }
}
