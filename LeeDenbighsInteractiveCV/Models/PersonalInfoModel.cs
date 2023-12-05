using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeDenbighsInteractiveCV.Models
{
    /// <summary>
    /// Represents personal information about me.
    /// </summary>
    public class PersonalInfoModel
    {
        /// <summary>
        /// Gets or sets the full name of the individual.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets my age.
        /// </summary>
        public string Age { get; set; }
        /// <summary>
        /// Gets or sets my phone number.
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Gets or sets my email address.
        /// </summary>
        public string Email { get; set; }
    }
}
