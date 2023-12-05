using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LeeDenbighsInteractiveCV.ViewModels
{
    public class GitHubViewModel : SkillsViewModel
    {
        // Command to open GitHub profile
        public ICommand GitHubCommand => new RelayCommand(OpenGitHub);

        // Method to open the GitHub profile in a web browser
        private void OpenGitHub()
        {
            // GitHub profile URL
            string url = "https://github.com/LeeDenbigh";

            // Start the default web browser to open the GitHub profile
            Process.Start(url);
        }
    }

}
