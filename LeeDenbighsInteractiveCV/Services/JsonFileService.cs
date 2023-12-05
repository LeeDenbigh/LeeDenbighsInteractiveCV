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
                        foreach (var ed in edList)
                        {
                            educationList.Add(ed);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return educationList;
        }
    }
}
