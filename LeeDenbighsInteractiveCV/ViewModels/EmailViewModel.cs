using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LeeDenbighsInteractiveCV.ViewModels
{
    public class EmailViewModel : SkillsViewModel
    {


        private string emailAddress;
        private string subject;
        private string body;

        public EmailViewModel()
        {
            emailAddress = "leedenbigh@googlemail.com";
            subject = "Sent from the Interactive CV";
            body = "Email Content...";
        }

        // Binding properties.
        public string EmailAddress
        {
            get => emailAddress;
            set
            {
                emailAddress = value;
                OnPropertyChanged(nameof(EmailAddress));
            }
        }

        public string Subject
        {
            get => subject;
            set
            {
                subject = value;
                OnPropertyChanged(nameof(Subject));
            }
        }

        public string Body
        {
            get => body;
            set
            {
                body = value;
                OnPropertyChanged(nameof(Body));
            }
        }

        public ICommand OpenEmailCommand => new RelayCommand(OpenEmail);

        private void OpenEmail()
        {
            // Emailto
            string mailToUrl = $"mailto:{EmailAddress}?subject={Uri.EscapeDataString(Subject)}&body={Uri.EscapeDataString(Body)}";

            Process.Start(new ProcessStartInfo(mailToUrl));
        }

    }
}
