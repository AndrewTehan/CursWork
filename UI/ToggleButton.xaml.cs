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

namespace ToggleSwitch
{
    /// <summary>
    /// Interaction logic for ToggleButton.xaml
    /// </summary>
    public partial class ToggleButton : UserControl
    {
        private Thickness LeftSide = new Thickness(-12, 0, 0, 0);
        private Thickness RightSide = new Thickness(0, 0, -12, 0);
        private SolidColorBrush Off = new SolidColorBrush(Color.FromRgb(238, 238, 238));
        private SolidColorBrush On = new SolidColorBrush(Color.FromRgb(255, 0, 0));
        private bool Toggled = false;
        public int _language;

        private readonly List<string> _languages = new List<string>();

        public ToggleButton()
        {
            InitializeComponent();

            _language = 0;
            _languages.Add("ru-RU");
            _languages.Add("en-US");

            Back.Fill = Off;
            Toggled = false;
            Dot.Margin = LeftSide;
        }

        public bool Toggled1 { get => Toggled; set => Toggled = value; }

        public void Dot_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (!Toggled)
            {
                Back.Fill = On;
                Toggled = true;
                Dot.Margin = RightSide;
            }
            else
            {
                Back.Fill = Off;
                Toggled = false;
                Dot.Margin = LeftSide;
            }
            try
            {
                _language = _language == 1 ? 0 : 1;
                var uri = new Uri("Localization/lang_" + _languages[_language] + ".xaml", UriKind.Relative);
                var resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
                Application.Current.Resources.Clear();
                Application.Current.Resources.MergedDictionaries.Add(resourceDict);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Back_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (!Toggled)
            {
                Back.Fill = On;
                Toggled = true;
                Dot.Margin = RightSide;
            }
            else
            {
                Back.Fill = Off;
                Toggled = false;
                Dot.Margin = LeftSide;
            }
            try
            {
                _language = _language == 1 ? 0 : 1;
                var uri = new Uri("Localization/lang_" + _languages[_language] + ".xaml", UriKind.Relative);
                var resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
                Application.Current.Resources.Clear();
                Application.Current.Resources.MergedDictionaries.Add(resourceDict);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}