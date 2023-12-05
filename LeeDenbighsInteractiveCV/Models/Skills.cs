using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeDenbighsInteractiveCV.Models
{
    public class Skills
    {
        // Property to store the name of the skill
        /// <summary>
        /// Represents the name of a skill (e.g., "Programming").
        /// </summary>
        public string Name { get; set; }
        // Property to store the percentage level of proficiency in the skill
        /// <summary>
        /// Indicates the proficiency level of the skill as a percentage.
        /// </summary>
        public double Percentage { get; set; }
        // Property to store the color hex code associated with the skill (for visualization)
        /// <summary>
        ///  Stores the color code associated with the skill, for visualization.
        /// </summary>
        public string ColorHex { get; set; }
    }
}
