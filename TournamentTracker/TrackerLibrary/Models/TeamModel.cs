using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Thsi represent a team.
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// This represent a list of people that are in the team.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        
        /// <summary>
        /// This is a team nane.
        /// </summary>
        public string TeamName { get; set; }

    }
}
