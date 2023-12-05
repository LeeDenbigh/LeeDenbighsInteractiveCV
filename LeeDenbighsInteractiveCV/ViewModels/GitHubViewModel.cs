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

        public ICommand GitHubCommand => new RelayCommand(OpenGitHub);

        private void OpenGitHub()
        {
            string url = "https://github.com/LeeDenbigh";
            Process.Start(url);
        }
    }
}
