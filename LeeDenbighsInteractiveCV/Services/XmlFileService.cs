using LeeDenbighsInteractiveCV.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LeeDenbighsInteractiveCV.Services
{
    public class XmlFileService
    {
        // String path to the ExperienceData.xml file
        private const string xmlFilePath = "Assets/Files/ExperienceData.xml";

        /// <summary>
        /// Get a list of all the experiences.
        /// </summary>
        /// <returns></returns>
        public Experiences GetExperiences()
        {
            try
            {
                // Initialise the serialiser.
                XmlSerializer serializer = new XmlSerializer(typeof(Experiences));

                // User a streamreader to read the file
                using (FileStream reader = new FileStream(xmlFilePath, FileMode.Open))
                {
                    // Deserialise the file content.
                    Experiences experiences = (Experiences)serializer.Deserialize(reader);
                    // Return the list of experiences.
                    return experiences;
                }
            }
            catch (Exception ex)
            {
                // Log the error
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
