using LeeDenbighsInteractiveCV.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeDenbighsInteractiveCV.ViewModels
{
    public class PortfolioViewModel : MainWindowViewModel
    {
        private ObservableCollection<PortfolioItemModel> _portfolioItems = new ObservableCollection<PortfolioItemModel>();

        public ObservableCollection<PortfolioItemModel> PortfolioItems
        {
            get => _portfolioItems;
            set
            {
                _portfolioItems = value;
                OnPropertyChanged(nameof(PortfolioItems));
            }
        }
    }
}
