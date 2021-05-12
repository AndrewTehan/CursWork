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
    /// Логика взаимодействия для History.xaml
    /// </summary>
    public partial class History : Page
    {
        public History(ApplicationViewModel mainWinVm)
        {
            InitializeComponent();

            DataContext = new HistoryViewModel(mainWinVm);
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}