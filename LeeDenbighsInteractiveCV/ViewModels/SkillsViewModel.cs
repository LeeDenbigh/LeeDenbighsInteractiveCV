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
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Skill> Skills { get; private set; }

        public SkillsViewModel()
        {
            Skills = new ObservableCollection<Skill>
            {
                new Skill { Name = "Software", Percentage = 30, ColorHex = "#E89416" },
                new Skill { Name = "Design", Percentage = 20, ColorHex = "#3896CB" },
                new Skill { Name = "Web", Percentage = 20, ColorHex = "#ADCB38" },
                new Skill { Name = "Game Design", Percentage = 30, ColorHex = "#8A38CB" }
            };
        }
    }
}
