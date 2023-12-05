using LeeDenbighsInteractiveCV.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeDenbighsInteractiveCV.Services
{
    public class JsonFileService
    {
        /// <summary>
        /// Retrieves a list of education items from a JSON file.
        /// </summary>
        /// <returns>A list of Education objects.</returns>
        public List<Education> GetEducationList()
        {
            List<Education> educationList = new List<Education>();

            try
            {
                // Define the file path for the education data JSON file
                string filePath = "Assets/Files/educationlist.json";

                // Check if the file exists
                if (File.Exists(filePath))
                {
                    // Read the JSON data from the file
                    string jsonData = File.ReadAllText(filePath);

                    // Deserialize the JSON data into a list of Education objects
                    var edList = JsonConvert.DeserializeObject<List<Education>>(jsonData);

                    // Update the educationList if the deserialization is successful
                    if (edList != null)
                    {
                        educationList = edList;
                    }
                }
            }
            catch (Exception ex)
            {
                // Propagate the exception up the call stack
                throw;
            }

            // Return the list of education items
            return educationList;
        }

        /// <summary>
        /// Retrieves a list of experience items from a JSON file.
        /// </summary>
        /// <returns>A list of Experience objects.</returns>
        public List<Experience> GetExperienceList()
        {
            
            List<Experience> experienceList = new List<Experience>();

            try
            {
                // Define the file path for the experience data JSON file
                string filePath = "Assets/Files/experiencedata.json";

                // Check if the file exists
                if (File.Exists(filePath))
                {

                    // Read the JSON data from the file
                    string jsonData = File.ReadAllText(filePath);

                    // Deserialize the JSON data into a list of Experience objects
                    var exList = JsonConvert.DeserializeObject<List<Experience>>(jsonData);

                    // Update the experienceList if the deserialization is successful
                    if (exList != null)
                    {
                        experienceList = exList;
                    }
                }
            }
            catch (Exception ex)
            {
                // Propagate the exception up the call stack
                throw;
            }

            // Return the list of experience items
            return experienceList;
        }
    }
}
