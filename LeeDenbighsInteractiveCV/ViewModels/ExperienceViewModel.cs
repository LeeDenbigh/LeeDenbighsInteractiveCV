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
        // Collection to store experiences, with property change notification
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

        // Property for the content of the experience summary
        private string _experienceSummaryContent;
        public string ExperienceSummaryContent
        {
            get => _experienceSummaryContent;
            set
            {
                _experienceSummaryContent = value;
                OnPropertyChanged(nameof(ExperienceSummaryContent));
            }
        }

        // Default constructor
        public ExperienceViewModel()
        {
            // Load experiences and experience summary content during initialization
            LoadExperiences();

            // Read the experience summary content from a text file
            var fileService = new FileService();
            ExperienceSummaryContent = fileService.ReadTextFromFile("Assets/Files/experience_summary.txt");
        }

        // Method to load experiences from a JSON file
        private void LoadExperiences()
        {
            _experiences = new ObservableCollection<Experience>();

            try
            {
                // Use the JsonFileService to get a list of experiences from a JSON file
                JsonFileService jsonFileService = new JsonFileService();
                List<Experience> exList = jsonFileService.GetExperienceList();

                // Add each experience to the ObservableCollection
                foreach (var ed in exList)
                {
                    Experiences.Add(ed);
                }
            }
            catch (Exception ex)
            {
                // Propagate the exception up the call stack
                throw;
            }
        }
    }

}
