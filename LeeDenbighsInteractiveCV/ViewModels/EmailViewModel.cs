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
        // Private fields to store email-related information
        private string emailAddress;
        private string subject;
        private string body;

        // Default constructor initializes default email-related information
        public EmailViewModel()
        {
            emailAddress = "leedenbigh@googlemail.com";
            subject = "";
            body = "";
        }

        // Binding properties for email-related information with property change notification
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

        // Command to open the default email client with pre-filled details
        public ICommand OpenEmailCommand => new RelayCommand(OpenEmail);

        // Method to open the default email client with pre-filled details
        private void OpenEmail()
        {
            // Generate the mailto URL with pre-filled details
            string mailToUrl = $"mailto:{EmailAddress}?subject={Uri.EscapeDataString(Subject)}&body={Uri.EscapeDataString(Body)}";

            // Start the default email client with the pre-filled mailto URL
            Process.Start(new ProcessStartInfo(mailToUrl));
        }
    }

}
