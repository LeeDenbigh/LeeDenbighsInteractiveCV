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

        // Collection to store education items, with property change notification
        private ObservableCollection<Education> _education;
        public ObservableCollection<Education> Education
        {
            get => _education;
            set
            {
                _education = value;
                OnPropertyChanged(nameof(Education));
            }
        }

        // Property for the content of the main summary
        private string _summaryContent;
        public string SummaryContent
        {
            get => _summaryContent;
            set
            {
                _summaryContent = value;
                OnPropertyChanged(nameof(SummaryContent));
            }
        }

        // Property for the content of the education summary
        private string _educationSummaryContent;
        public string EducationSummaryContent
        {
            get => _educationSummaryContent;
            set
            {
                _educationSummaryContent = value;
                OnPropertyChanged(nameof(EducationSummaryContent));
            }
        }

        // On Property changed method
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Constructor for MainWindowViewModel
        public MainWindowViewModel()
        {
            // Load education information during initialization
            LoadEducation();

            // Read the main summary content from a text file
            FileService fileService = new FileService();
            SummaryContent = fileService.ReadTextFromFile("Assets/Files/Txt/overview_summary.txt");

            // Read the education summary content from a text file
            EducationSummaryContent = fileService.ReadTextFromFile("Assets/Files/Txt/education_summary.txt");
        }

        // Method to load education information from a JSON file
        private void LoadEducation()
        {
            _education = new ObservableCollection<Education>();

            try
            {
                // Use the JsonFileService to get a list of education items from a JSON file
                JsonFileService jsonFileService = new JsonFileService();
                List<Education> edList = jsonFileService.GetEducationList();

                // Add each education item to the ObservableCollection
                foreach (var ed in edList)
                {
                    Education.Add(ed);
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
