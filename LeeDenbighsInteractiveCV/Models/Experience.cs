using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Xml.Serialization;

namespace LeeDenbighsInteractiveCV.Models
{
    public class Experience
    {
        public string Title { get; set; }
        public string JobTitle { get; set; }
        public string Dates { get; set; }
        public string Description { get; set; }
        public string LogoPath { get; set; }
    }
}
