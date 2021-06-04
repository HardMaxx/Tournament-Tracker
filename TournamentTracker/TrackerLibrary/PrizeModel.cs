using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    /// <summary>
    /// Represent prize of the tournament.
    /// </summary>
    public class PrizeModel
    {
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
    }
}
