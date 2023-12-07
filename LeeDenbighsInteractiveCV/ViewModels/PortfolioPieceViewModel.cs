using LeeDenbighsInteractiveCV.Models;
using LeeDenbighsInteractiveCV.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;

namespace LeeDenbighsInteractiveCV.ViewModels
{
    public class PortfolioPieceViewModel : MainWindowViewModel
    {
        #region Open Link Button Command
        public ICommand IOpenLinkCommand => new RelayCommand<PortfolioPiece>(OpenLink);

        private void OpenLink(PortfolioPiece portfolioPiece)
        {
            if (portfolioPiece != null)
            {
                Process.Start(portfolioPiece.link);
            }
        } 
        #endregion

        private ObservableCollection<PortfolioPiece> _portfolioPiece;
        public ObservableCollection<PortfolioPiece> PortfolioPieces
        {
            get => _portfolioPiece;
            set
            {
                _portfolioPiece = value;
                OnPropertyChanged(nameof(PortfolioPieces));
            }    
        }

        public PortfolioPieceViewModel()
        {
            PortfolioPieces = new ObservableCollection<PortfolioPiece>();
            LoadPortfolioPieces();
        }

        private void LoadPortfolioPieces()
        {
            JsonFileService jsonFileService = new JsonFileService();
            var potfolioList = jsonFileService.GetPortfolioPieces();

            foreach (var item in potfolioList)
            {
                PortfolioPieces.Add(item);
            }
        }
    }
}
