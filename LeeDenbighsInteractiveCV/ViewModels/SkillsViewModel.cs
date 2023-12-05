using LeeDenbighsInteractiveCV.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeDenbighsInteractiveCV.ViewModels
{
    public class SkillsViewModel : INotifyPropertyChanged
    {
        // Event to notify subscribers when a property changes
        public event PropertyChangedEventHandler PropertyChanged;

        // Collection to store skills with property change notification
        public ObservableCollection<Skills> Skills { get; private set; }

        // Constructor initializes the Skills collection with sample data
        public SkillsViewModel()
        {
            // Initialize the Skills collection with sample data
            Skills = new ObservableCollection<Skills>
        {
            new Skills { Name = "Software", Percentage = 30, ColorHex = "#E89416" },
            new Skills { Name = "Design", Percentage = 20, ColorHex = "#3896CB" },
            new Skills { Name = "Web", Percentage = 20, ColorHex = "#ADCB38" },
            new Skills { Name = "Game Design", Percentage = 30, ColorHex = "#8A38CB" }
        };
        }

        // Method to notify subscribers when a property changes
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
