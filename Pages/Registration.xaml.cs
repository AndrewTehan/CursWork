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

namespace course_work.Pages
{
    /// <summary>
    /// Логика взаимодействия для Welcom.xaml
    /// </summary>
    public partial class Registration : Page
    {
        public Registration(ApplicationViewModel mainWinVm)
        {
            InitializeComponent();

            DataContext = new RegistrationViewModel(mainWinVm);
        }
    }
}