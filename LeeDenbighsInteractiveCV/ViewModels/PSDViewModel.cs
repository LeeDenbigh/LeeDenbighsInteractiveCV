using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LeeDenbighsInteractiveCV.ViewModels
{
    public class PSDViewModel : SkillsViewModel
    {
        public ICommand OpenPDF => new RelayCommand(OpenThePDFFile);

        /// <summary>
        /// Opens the PDF file in the default PDF viewer.
        /// </summary>
        private void OpenThePDFFile()
        {
            string filePath = "Assets/Files/PDF/leedenbigh-developer-cv.pdf";

            string fullPath = Path.GetFullPath(filePath);

            if (File.Exists(fullPath))
            {
                Process.Start(fullPath);
            }
            else
            {
                Console.WriteLine($"File not found: {fullPath}");
            }
            
        }
    }
}
