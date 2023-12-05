using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Xml.Serialization;

namespace LeeDenbighsInteractiveCV.Models
{
    /// <summary>
    /// Represents my professional work experience.
    /// </summary>
    public class Experience
    {
        /// <summary>
        /// Gets or sets the overall title or category of the experience (e.g., "Work Experience").
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Gets or sets the specific job title or role within the experience.
        /// </summary>
        public string JobTitle { get; set; }
        /// <summary>
        /// Gets or sets the duration or dates of the experience.
        /// </summary>
        public string Dates { get; set; }
        /// <summary>
        /// Gets or sets a description of the tasks, responsibilities, or achievements during the experience.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Gets or sets the file path or URL to the logo associated with the experience (e.g., company logo).
        /// </summary>
        public string LogoPath { get; set; }
    }
}
