using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeDenbighsInteractiveCV.Models
{
    public class PortfolioItemModel
    {
        public string Name { get; set; }
        public string Platform { get; set; }
        public string Year { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public bool Available { get; set; }
        public string ImageURL { get; set; }
    }
}
