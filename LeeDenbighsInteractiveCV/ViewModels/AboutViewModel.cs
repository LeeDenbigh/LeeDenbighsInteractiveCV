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
        // Private field to store the content of the "About" information
        private string _aboutContent;

        // Public property to access and modify the "About" content
        public string AboutContent
        {
            get => _aboutContent;
            set
            {
                // Update the value and notify subscribers of the property change
                _aboutContent = value;
                OnPropertyChanged(nameof(AboutContent));
            }
        }

        // Constructor for the AboutViewModel
        public AboutViewModel()
        {
            // Define the file path for the "About" text file
            var filePath = "Assets/Files/Txt/about_summary.txt";

            // Check if the file exists
            if (File.Exists(filePath))
            {
                // Create an instance of the FileService class
                FileService fileService = new FileService();

                // Read the text content from the file using the FileService
                var content = fileService.ReadTextFromFile(filePath);

                // Set the AboutContent property with the retrieved content
                AboutContent = content;
            }
        }
    }
}
