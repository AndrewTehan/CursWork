using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace course_work.Pages
{
    public partial class Liked : Page
    {
        public Liked()
        {
            InitializeComponent();
        }

        public Liked(ApplicationViewModel mainWinVm)
        {
            InitializeComponent();

            DataContext = new LikedViewModel(mainWinVm);
        }
    }
}