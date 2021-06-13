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
        /// This is a id team .
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// This is a team nane.
        /// </summary>
        public string TeamName { get; set; }
        /// <summary>
        /// This represent a list of people that are in the team.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        
       

    }
}
