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
        public event PropertyChangedEventHandler PropertyChanged;

        // Add the skills 
        //public ObservableCollection<SubjectSkill> SubjectSkills { get; } = new ObservableCollection<SubjectSkill>()
        //{
        //    new SubjectSkill { Name = "C#", Level = 80 },
        //    new SubjectSkill { Name = "Python", Level = 45},
        //    new SubjectSkill { Name = "HTML", Level = 85},
        //    new SubjectSkill { Name = "CSS", Level = 70},
        //    new SubjectSkill { Name = "Unity", Level = 85},
        //    new SubjectSkill { Name = "Js", Level = 45},
        //    new SubjectSkill { Name = "WPF", Level = 87},
        //    new SubjectSkill { Name = "UWP", Level = 89},
        //    new SubjectSkill { Name = "C++", Level = 25},
        //    new SubjectSkill { Name = "Googling", Level = 100},
        //    new SubjectSkill { Name = "Photoshop", Level = 90},
        //    new SubjectSkill { Name = "Illustrator", Level = 80},
        //    new SubjectSkill { Name = "Affinty Design", Level = 95},
        //    new SubjectSkill { Name = "Affinty Photo", Level = 90},
        //    new SubjectSkill { Name = "Figma", Level = 95},
        //    new SubjectSkill { Name = "GitHub", Level = 70}
        //};

        public ObservableCollection<SubjectSkill> Skills { get; set; }
        
        public SubjectSkillViewModel()
        {
            Skills = new ObservableCollection<SubjectSkill>();
            LoadSkills();
        }

        private void LoadSkills()
        {
            try
            {
                string filePath = "Assets/Files/subject_skills.json";
                if (File.Exists(filePath))
                {
                    string jsonData = File.ReadAllText(filePath);
                    var skills = JsonConvert.DeserializeObject<List<SubjectSkill>>(jsonData);
                    if(skills != null)
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

                throw;
            }
        }

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
