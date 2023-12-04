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
        public event PropertyChangedEventHandler PropertyChanged;

        private string _summaryContent;
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

        public string SummaryContent
        {
            get => _summaryContent;
            set
            {
                _summaryContent = value;
                OnPropertyChanged(nameof(SummaryContent));
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainWindowViewModel()
        {
            FileService fileService = new FileService();
            SummaryContent = fileService.ReadTextFromFile("Assets/Files/summary.txt");

            ExperienceSummaryContent = fileService.ReadTextFromFile("Assets/Files/experience_summary.txt");
        }
    }

    public enum ActivePage
    {
        Overview,
        Experience,
        Education,
        Portfolio,
    }
}
