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
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // MainWindowViewModel constructor.
        public MainWindowViewModel()
        {
            LoadEducation();

            FileService fileService = new FileService();
            SummaryContent = fileService.ReadTextFromFile("Assets/Files/summary.txt");
            
            EducationSummaryContent = fileService.ReadTextFromFile("Assets/Files/education_summary.txt");
        }

        private void LoadEducation()
        {
            _education = new ObservableCollection<Education>();

            try
            {
                JsonFileService jsonFileService = new JsonFileService();
                List<Education> edList = jsonFileService.GetEducationList();

                foreach (var ed in edList)
                {
                    Education.Add(ed);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
