using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Xml.Serialization;

namespace LeeDenbighsInteractiveCV.Models
{
    [XmlRoot(ElementName ="experience")]
    public class Experience
    {
        [XmlElement(ElementName = "title")]
        public string Title { get; set; }

        [XmlElement(ElementName = "jobtite")]
        public string JobTitle { get; set; }

        [XmlElement(ElementName = "dates")]
        public string Dates { get; set; }

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "logopath")]
        public ImageSource Logo { get; set; }
    }

    [XmlRoot(ElementName = "experiences")]
    public class Experiences
    {
        [XmlElement(ElementName = "experiences")]
        public List<Experience> ExperienceList { get; set; } 

        public Experiences()
        {
            ExperienceList = new List<Experience>();
        }
    }
}
