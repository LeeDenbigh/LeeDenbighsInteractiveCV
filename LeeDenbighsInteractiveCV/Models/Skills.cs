using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace LeeDenbighsInteractiveCV.Models
{
    public class Skill
    {
        public string Name { get; set; }
        public double Level { get; set; }
        private string _colorHex;
        public string ColorHex
        {
            get { return _colorHex; }
            set
            {
                _colorHex = value;
                Color = (Color)ColorConverter.ConvertFromString(value);
            }
        }

        public Color Color { get; private set; }

    }
}
