using LeeDenbighsInteractiveCV.Models;
using LeeDenbighsInteractiveCV.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LeeDenbighsInteractiveCV.Views
{
    /// <summary>
    /// Interaction logic for VisualSkillsView.xaml
    /// </summary>
    public partial class VisualSkillsView : UserControl
    {
        
        public VisualSkillsView()
        {
            InitializeComponent();

            // This line sets the data context of the current UserControl 
            // to an instance of the SkillViewModel class.
            //
            // By setting the SkillViewModel instance as the DataContext, all data bindings in the XAML
            // that rely on the DataContext will now be bound to properties and commands of the SkillViewModel.
            // For example, if your SkillViewModel has a property called 'Skills', and your XAML has a
            // ListBox with its ItemsSource property bound to 'Skills', the ListBox will display data
            // from the SkillViewModel's 'Skills' property.
            this.DataContext = new SkillViewModel();
        }

    }
}
