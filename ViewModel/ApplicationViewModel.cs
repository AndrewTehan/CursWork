using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using course_work.Pages;

namespace course_work
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        //    private MediaVeiwModel mediaFiles;

        private Page welcomPage;
        private Page registrationPage;
        private Page authorizationPage;
        private Page homePage;
        private Page historyPage;
        private Page likedPage;
        private Page addPage;

        public Page WelcomPage
        {
            get { return welcomPage; }
            set
            {
                welcomPage = value;
                OnPropertyChanged("WelcomPage");
            }
        }

        public Page AddPage
        {
            get { return addPage; }
            set
            {
                addPage = value;
                OnPropertyChanged("AddPage");
            }
        }

        public Page RegistrationPage
        {
            get { return registrationPage; }
            set
            {
                registrationPage = value;
                OnPropertyChanged("RegistrationPage");
            }
        }

        public Page AuthorizationPage
        {
            get { return authorizationPage; }
            set
            {
                authorizationPage = value;
                OnPropertyChanged("AuthorizationPage");
            }
        }

        public Page HomePage
        {
            get { return homePage; }
            set
            {
                homePage = value;
                OnPropertyChanged("HomePage");
            }
        }

        public Page HistoryPage
        {
            get { return historyPage; }
            set
            {
                historyPage = value;
                OnPropertyChanged("HistoryPage");
            }
        }

        public Page LikedPage
        {
            get
            {
                return likedPage;
            }
            set
            {
                likedPage = value;
                OnPropertyChanged("LikedPage");
            }
        }

        private RelayCommand setWelcomPage;

        public RelayCommand SetWelcomPage
        {
            get
            {
                return setWelcomPage ?? new RelayCommand(
                    obj =>
                    {
                        WelcomPage = WelcomPage;
                    }
                );
            }
        }

        private RelayCommand setAddPage;

        public RelayCommand SetAddPage
        {
            get
            {
                return setAddPage ?? new RelayCommand(
                    obj =>
                    {
                        WelcomPage = AddPage;
                    }
                );
            }
        }

        private RelayCommand setRegistrationPage;

        public RelayCommand SetRegistrationPage
        {
            get
            {
                return setRegistrationPage ?? new RelayCommand(
                    obj =>
                    {
                        WelcomPage = RegistrationPage;
                    }
                );
            }
        }

        private RelayCommand setAuthorizationPage;

        public RelayCommand SetAuthorizationPage
        {
            get
            {
                return setAuthorizationPage ?? new RelayCommand(
                    obj =>
                    {
                        WelcomPage = AuthorizationPage;
                    }
                );
            }
        }

        private RelayCommand setHomePage;

        public RelayCommand SetHomePage
        {
            get
            {
                return setHomePage ?? new RelayCommand(
                    obj =>
                    {
                        WelcomPage = HomePage;
                    }
                );
            }
        }

        private RelayCommand setLikedPage;

        public RelayCommand SetLikedPage
        {
            get
            {
                return setLikedPage ?? new RelayCommand(
                    obj =>
                    {
                        WelcomPage = new Liked(this);
                    }
                );
            }
        }

        private RelayCommand setHistoryPage;

        public RelayCommand SetHistoryPage
        {
            get
            {
                return setHistoryPage ?? new RelayCommand(
                        obj =>
                        {
                            WelcomPage = new History(this);
                        }
                    );
            }
        }

        public ApplicationViewModel()
        {
            //mediaFiles = MediaVeiwModel.GetInstance();

            WelcomPage = new Welcom(this);
            AuthorizationPage = new Authorization(this);
            RegistrationPage = new Registration(this);
            HomePage = new Home(this);
            LikedPage = new Liked(this);
            HistoryPage = new History(this);
            AddPage = new Add(this);

            WelcomPage = welcomPage;
            RegistrationPage = registrationPage;
            AuthorizationPage = authorizationPage;
            HomePage = homePage;
            HistoryPage = historyPage;
            LikedPage = likedPage;
            AddPage = addPage;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}