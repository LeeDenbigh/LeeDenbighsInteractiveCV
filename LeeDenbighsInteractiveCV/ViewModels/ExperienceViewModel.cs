using LeeDenbighsInteractiveCV.Models;
using LeeDenbighsInteractiveCV.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeDenbighsInteractiveCV.ViewModels
{
    public class ExperienceViewModel : MainWindowViewModel
    {
        private ObservableCollection<Experience> _experiences;
        public ObservableCollection<Experience> Experiences
        {
            get => _experiences;
            set
            {
                _experiences = value;
                OnPropertyChanged(nameof(Experiences));
            }
        }

        // Experience Summary content
        private string _experienceSummaryContent;
        // Experience Summary content property
        public string ExperienceSummaryContent
        {
            get => _experienceSummaryContent;
            set
            {
                _experienceSummaryContent = value;
                OnPropertyChanged(nameof(ExperienceSummaryContent));
            }
        }

        public ExperienceViewModel()
        {
            LoadExperiences();

            var fileService = new FileService();
            ExperienceSummaryContent = fileService.ReadTextFromFile("Assets/Files/experience_summary.txt");
        }

        private void LoadExperiences()
        {
            _experiences = new ObservableCollection<Experience>();

            try
            {
                JsonFileService jsonFileService = new JsonFileService();
                List<Experience> exList = jsonFileService.GetExperienceList();

                foreach (var ed in exList)
                {
                    Experiences.Add(ed);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
