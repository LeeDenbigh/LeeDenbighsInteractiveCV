using LeeDenbighsInteractiveCV.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeDenbighsInteractiveCV.ViewModels
{
    public class SubjectSkillViewModel : INotifyPropertyChanged
    {
        // Event to notify subscribers when a property changes
        public event PropertyChangedEventHandler PropertyChanged;

        // Collection to store subject-related skills with property change notification
        public ObservableCollection<SubjectSkill> Skills { get; set; }

        // Constructor initializes the Skills collection and loads skills from a JSON file
        public SubjectSkillViewModel()
        {
            // Initialize the Skills collection
            Skills = new ObservableCollection<SubjectSkill>();

            // Load skills from a JSON file
            LoadSkills();
        }

        // Method to load subject-related skills from a JSON file
        private void LoadSkills()
        {
            try
            {
                // Define the file path for the subject skills JSON file
                string filePath = "Assets/Files/Data/subject_skills.json";

                // Check if the file exists
                if (File.Exists(filePath))
                {
                    // Read the JSON data from the file
                    string jsonData = File.ReadAllText(filePath);

                    // Deserialize the JSON data into a list of SubjectSkill objects
                    var skills = JsonConvert.DeserializeObject<List<SubjectSkill>>(jsonData);

                    // Add each skill to the ObservableCollection
                    if (skills != null)
                    {
                        foreach (var skill in skills)
                        {
                            Skills.Add(skill);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Propagate the exception up the call stack
                throw;
            }
        }

        // Method to notify subscribers when a property changes
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
