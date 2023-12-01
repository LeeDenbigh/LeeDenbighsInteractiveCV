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
    public class SkillViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Skill> _skills;
        public ObservableCollection<Skill> Skills
        {
            get { return _skills; }
            set
            {
                _skills = value;
                OnPropertyChanged(nameof(Skills));
            }
        }

        public SkillViewModel()
        {
            Skills = new ObservableCollection<Skill>
            {
                new Skill { Name = "Software", Level = 30, ColorHex = "#E89416" },
                new Skill { Name = "Design", Level = 25, ColorHex = "#3896CB" },
                new Skill { Name = "Web", Level = 20, ColorHex = "#ADCB38" },
                new Skill { Name = "Game Design", Level = 25, ColorHex = "#8A38CB" }
            };
        }

        private void OnPropertyChanged(string PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
