using LeeDenbighsInteractiveCV.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeDenbighsInteractiveCV.ViewModels
{
    public class AboutViewModel : MainWindowViewModel
    {
        private string _aboutContent;
        public string AboutContent
        {
            get => _aboutContent;
            set
            {
                _aboutContent = value;
                OnPropertyChanged(nameof(AboutContent));
            }
        }

        public AboutViewModel()
        {
            var filePath = "Assets/Files/about.txt";

            if (File.Exists(filePath))
            {
                FileService fileService = new FileService();
                var content = fileService.ReadTextFromFile(filePath);

                AboutContent = content;
            }
        }
    }
}
