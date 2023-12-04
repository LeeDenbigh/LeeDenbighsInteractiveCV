using LeeDenbighsInteractiveCV.Services;
using System;
using System.Collections.Generic;
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

        // On Property changed method.
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // MainWindowViewModel constructor.
        public MainWindowViewModel()
        {
            FileService fileService = new FileService();
            SummaryContent = fileService.ReadTextFromFile("Assets/Files/summary.txt");

            ExperienceSummaryContent = fileService.ReadTextFromFile("Assets/Files/experience_summary.txt");
        }
    }
}
