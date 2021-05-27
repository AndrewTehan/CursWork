using course_work.Pages;
using System;
using System.Media;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace course_work
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool mainMenuTrigger = true;
        public bool speech = true;

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
                b1.IsEnabled = b2.IsEnabled = b4.IsEnabled = b5.IsEnabled = menuBut.IsEnabled = true;
            }
        }

        private void playWelocoming(object sender, RoutedEventArgs e)
        {
            SoundPlayer sp = new SoundPlayer
            {
                SoundLocation = @"C:\Users\Andrew\source\course_workEFtest\Sound\welcom.wav"
            };
            sp.Load();
            sp.Play();
        }

        private void OpenProfile(object sender, MouseButtonEventArgs e)
        {
            if (AuthorizationViewModel.currentUser != null)
            {
                string profikeInfo = "Привет, " + AuthorizationViewModel.currentUser.Nickname + "!!!";
                MessageBox.Show(profikeInfo);
            }
            else
            {
                MessageBox.Show("Вначале зайди в аккаунт!!!");
            }
        }
    }
}