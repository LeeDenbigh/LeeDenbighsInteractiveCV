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
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        // Property changed event
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Experience> _experiences;

        private readonly XmlFileService _xmlFileService;

        public ObservableCollection<Experience> Experiences
        {
            get => _experiences;
            set
            {
                _experiences = value;
                OnPropertyChanged(nameof(Experiences));
            }
        }

        // Summary content
        private string _summaryContent;
        // Summary content property.
        public string SummaryContent
        {
            get => _summaryContent;
            set
            {
                _summaryContent = value;
                OnPropertyChanged(nameof(SummaryContent));
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


        // Education Summary content
        private string _educationSummaryContent;
        // Education Summary content property
        public string EducationSummaryContent
        {
            get => _educationSummaryContent;
            set
            {
                _educationSummaryContent = value;
                OnPropertyChanged(nameof(EducationSummaryContent));
            }
        }



        // On Property changed method.
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // MainWindowViewModel constructor.
        public MainWindowViewModel()
        {
            _xmlFileService = new XmlFileService();
            LoadExperiences();

            FileService fileService = new FileService();
            SummaryContent = fileService.ReadTextFromFile("Assets/Files/summary.txt");
            ExperienceSummaryContent = fileService.ReadTextFromFile("Assets/Files/experience_summary.txt");
            EducationSummaryContent = fileService.ReadTextFromFile("Assets/Files/education_summary.txt");
        }

        private void LoadExperiences()
        {
            // Call the GetExperiences method of the XmlFileService to retrieve the experiences data.
            var experienceData = _xmlFileService.GetExperiences();

            // Check if the experiences data is not null and if it contains a list of Experience objects.
            if (experienceData != null && experienceData.ExperienceList != null)
            {
                // If the data is valid, initialize the Experiences ObservableCollection with the data.
                // This ObservableCollection is used for data binding in the UI, enabling dynamic updates.
                Experiences = new ObservableCollection<Experience>(experienceData.ExperienceList);
            }
            else
            {
                // If the data is null or invalid (for example, if the XML file is empty or cannot be read),
                // initialize the Experiences property as an empty ObservableCollection.
                // This ensures that the Experiences property is never null, avoiding null reference exceptions.
                Experiences = new ObservableCollection<Experience>();
            }
        }
    }
}
