using System.Windows.Controls;

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
    }
}