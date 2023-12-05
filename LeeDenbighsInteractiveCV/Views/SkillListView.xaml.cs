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
    /// Interaction logic for SkillListView.xaml
    /// </summary>
    public partial class SkillListView : UserControl
    {
        public SkillListView()
        {
            InitializeComponent();
            // Add SubjectSkillViewModel as the DataContext.
            DataContext = new SubjectSkillViewModel();
        }

        // Couldn't for the life of my figure out how to do this in MVVM
        // My bad.
        private void ProgressBar_Loaded(object sender, RoutedEventArgs e)
        {
            if (sender is ProgressBar progressBar && progressBar.DataContext is SubjectSkill skills)
            {
                // Animate the progresbar, so when the progressbar has been
                // generated (loaded), then the progress will animate from
                // 0 to the subject skill level.
                var animation = new DoubleAnimation
                {
                    From = 0,
                    To = skills.Level,
                    Duration = TimeSpan.FromSeconds(2),
                };
                progressBar.BeginAnimation(ProgressBar.ValueProperty, animation);
                // Add a tooltip to the progressbar, so when the viewer hovers over,
                // they can see the percentage.

                Style toolTipStyle = FindResource("ToolTipStyle") as Style;

                if(toolTipStyle != null)
                {
                    ToolTip customToolTip = new ToolTip
                    {
                        Style = toolTipStyle,
                        Content = $"My skill level for {skills.Name} is {skills.Level}%"
                    };

                    progressBar.ToolTip = customToolTip;
                }
                else
                {
                    MessageBox.Show("Tooltip not found");
                }

                
            }
        }
    }
}
