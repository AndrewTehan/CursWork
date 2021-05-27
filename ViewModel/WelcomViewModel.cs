using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace course_work.Pages
{
    class WelcomViewModel
    {
        private ApplicationViewModel mainWinVM;

        private RelayCommand regis;

        public RelayCommand Registration
        {
            get
            {
                return regis ?? new RelayCommand(
                obg =>
                {
                    mainWinVM.WelcomPage = new Registration(mainWinVM);
                }
                );
            }
        }

        private RelayCommand author;

        public RelayCommand Authorization
        {
            get
            {
                return author ?? new RelayCommand(
                obg =>
                {
                    mainWinVM.WelcomPage = new Authorization(mainWinVM);
                }
                );
            }
        }

        public WelcomViewModel(ApplicationViewModel mainWinVm)
        {
            this.mainWinVM = mainWinVm;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}