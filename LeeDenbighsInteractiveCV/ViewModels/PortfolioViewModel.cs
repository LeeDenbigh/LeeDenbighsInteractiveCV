using LeeDenbighsInteractiveCV.Models;
using LeeDenbighsInteractiveCV.Services;
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
        private string _portfolioSummary;
        public string PortfolioSummary
        {
            get => _portfolioSummary;
            set
            {
                _portfolioSummary = value;
                OnPropertyChanged(nameof(PortfolioSummary));
            }
        }



        public PortfolioViewModel()
        {
            GetPortfolioSummary();
        }

        private void GetPortfolioSummary()
        {
            FileService fileService = new FileService();
            PortfolioSummary = fileService.ReadTextFromFile("Assets/Files/Txt/portfolio_summary.txt");
        }
    }
}
