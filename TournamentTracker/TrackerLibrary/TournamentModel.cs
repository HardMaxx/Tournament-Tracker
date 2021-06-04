using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    /// <summary>
    /// This class represent a toournament.
    /// </summary>
    public class TournamentModel
    {
        /// <summary>
        /// This trpresent a tournament name.
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// This represent a entry fee for this tournament.
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// This represent a list of teams that will compea in this tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// This represent a list of a prizes that will be in this tournament.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// This represent a rounds in a matchup.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
