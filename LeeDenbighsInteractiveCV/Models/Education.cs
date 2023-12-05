using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Represents my educational background.
/// </summary>
namespace LeeDenbighsInteractiveCV.Models
{
    public class Education
    {
        /// <summary>
        /// Gets or sets the title of the education.
        /// </summary>
        public string EducationTitle { get; set; }
        /// <summary>
        /// Gets or sets the subtitle or additional details about the education.
        /// </summary>
        public string EducationSubtitle { get; set; }
        /// <summary>
        /// Gets or sets the image associated with the education (e.g., university logo).
        /// </summary>
        public string EducationImage { get; set; }
    }
}
