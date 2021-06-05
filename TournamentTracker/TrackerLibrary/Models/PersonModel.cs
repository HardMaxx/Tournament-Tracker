using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represent one person.
    /// </summary>
    /// 

    public class PersonModel
    {
        /// <summary>
        /// The first name of the persion.
        /// </summary>
        
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the person.
        /// </summary>

        public string LastName { get; set; }

        /// <summary>
        /// The primary email adress of the person.
        /// </summary>

        public string EmailAdress { get; set; }

        /// <summary>
        /// The primary cell phone number of the person.
        /// </summary>

        public string CellphoneNumber { get; set; }
    }
}
