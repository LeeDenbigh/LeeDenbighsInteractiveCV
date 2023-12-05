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
