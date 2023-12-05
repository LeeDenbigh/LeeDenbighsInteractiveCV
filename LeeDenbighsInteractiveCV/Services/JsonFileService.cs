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
        public List<Education> GetEducationList()
        {
            List<Education> educationList = new List<Education>();

            try
            {
                string filePath = "Assets/Files/educationlist.json";
                if (File.Exists(filePath))
                {
                    string jsonData = File.ReadAllText(filePath);
                    var edList = JsonConvert.DeserializeObject<List<Education>>(jsonData);
                    if (edList != null)
                    {
                        educationList = edList;
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return educationList;
        }

        public List<Experience> GetExperienceList()
        {
            List<Experience> experienceList = new List<Experience>();

            try
            {
                string filePath = "Assets/Files/experiencedata.json";
                if (File.Exists(filePath))
                {
                    string jsonData = File.ReadAllText(filePath);
                    var exList = JsonConvert.DeserializeObject<List<Experience>>(jsonData);
                    if (exList != null)
                    {
                        experienceList = exList;
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return experienceList;
        }
    }
}
