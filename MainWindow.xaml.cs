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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ToggleSwitch;

namespace course_work
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool mainMenuTrigger = true;

        public MainWindow()
        {
            InitializeComponent();

            DataContext = new ApplicationViewModel();
        }

        private void MainMenu(object sender, MouseButtonEventArgs e)
        {
            if (mainMenuTrigger == true)
            {
                mainFrame.Width += mainMenu.Width;
                mainMenu.Width = 0;
                BitmapImage bi3 = new BitmapImage();
                bi3.BeginInit();
                bi3.UriSource = new Uri("/Images/nextArrowIcon.png", UriKind.Relative);
                bi3.EndInit();
                Menu.Source = bi3;
            }
            else
            {
                mainFrame.Width -= 170;
                mainMenu.Width += 170;
                BitmapImage bi3 = new BitmapImage();
                bi3.BeginInit();
                bi3.UriSource = new Uri("/Images/backArrowIcon.png", UriKind.Relative);
                bi3.EndInit();
                Menu.Source = bi3;
            }
            mainMenuTrigger = !mainMenuTrigger;
        }

        private void Load(object sender, NavigationEventArgs e)
        {
            if (mainFrame.Content.ToString() != "course_work.Pages.Welcom" && mainFrame.Content.ToString() != "course_work.Pages.Authorization" && mainFrame.Content.ToString() != "course_work.Pages.Registration")
            {
                b1.IsEnabled = b2.IsEnabled = b3.IsEnabled = b4.IsEnabled = menuBut.IsEnabled = true;
            }
        }
    }
}