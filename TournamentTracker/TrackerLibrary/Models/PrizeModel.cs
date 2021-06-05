using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represent prize of the tournament.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// It is a place namber in a tournament.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// It is a place name in a tournament.
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// It is a amount of prize for the place.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// It is a % of prize for the place.
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, String prizePercentage)
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
            PrizePercentage = prizePercentageValue;
        }
    }
}
