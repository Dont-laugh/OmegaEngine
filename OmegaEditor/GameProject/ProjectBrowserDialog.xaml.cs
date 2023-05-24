using System.Windows;

namespace Omega
{
    /// <summary>
    /// Interaction logic for ProjectBrowserDialog.xaml
    /// </summary>
    public partial class ProjectBrowserDialog : Window
    {
        public ProjectBrowserDialog()
        {
            InitializeComponent();
        }

        private void OnOpenProjectClick(object sender, RoutedEventArgs e)
        {
            OpenProjectBtn.IsEnabled = true;
            CreateProjectBtn.IsChecked = false;
            BrowserContent.Margin = new Thickness(0);
        }

        private void OnCreateProjectClick(object sender, RoutedEventArgs e)
        {
            CreateProjectBtn.IsChecked = true;
            OpenProjectBtn.IsChecked = false;
            BrowserContent.Margin = new Thickness(-800, 0, 0, 0);
        }
    }
}
