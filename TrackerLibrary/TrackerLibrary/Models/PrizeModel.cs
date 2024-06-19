using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        public int Id { get; set; }
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

        public PrizeModel()
        {

        }
        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            Percentage = prizePercentageValue;

        }

    }
}
