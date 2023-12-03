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

        private string _fileContent;
        public string FileContent
        {
            get => _fileContent;
            set
            {
                _fileContent = value;
                OnPropertyChanged(nameof(FileContent));
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainWindowViewModel()
        {
            FileService fileService = new FileService();
            FileContent = fileService.ReadTextFromFile("Assets/Files/summary.txt");
        }
    }
}
