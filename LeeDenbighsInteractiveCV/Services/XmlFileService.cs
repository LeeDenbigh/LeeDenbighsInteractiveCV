using LeeDenbighsInteractiveCV.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
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

                // REMOVE THE WHITE SPACES...
                XmlReaderSettings settings = new XmlReaderSettings
                {
                    IgnoreWhitespace = true
                };

                // User a streamreader to read the file
                using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Open))
                using (XmlReader reader = XmlReader.Create(fileStream, settings))
                {
                    // Deserialise the file content.
                    var experiences = (Experiences)serializer.Deserialize(reader);

                    foreach (var experience in experiences.ExperienceList)
                    {
                        experience.Title = experience.Title?.Trim();
                        experience.JobTitle = experience.JobTitle?.Trim();
                        experience.Dates = experience.Dates?.Trim();
                        experience.Description = experience.Description?.Trim();
                        experience.LogoPath = experience.LogoPath?.Trim();
                    }

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
