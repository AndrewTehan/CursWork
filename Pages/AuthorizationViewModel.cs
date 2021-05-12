using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows;

namespace course_work.Pages
{
    internal class AuthorizationViewModel
    {
        private ApplicationViewModel mainWinVM;

        private string login;

        public string Login
        {
            get { return login; }
            set
            {
                login = value;
                OnPropertyChanged("Login");
            }
        }

        private string pass;

        public string Pass
        {
            get { return pass; }
            set
            {
                pass = value;
                OnPropertyChanged("Pass");
            }
        }

        private RelayCommand cancel;

        public RelayCommand Cancel
        {
            get
            {
                return cancel ?? new RelayCommand(
                obg =>
                {
                    mainWinVM.WelcomPage = new Welcom(mainWinVM);
                }
                );
            }
        }

        private RelayCommand authorization;

        public RelayCommand Authorization
        {
            get
            {
                return authorization ?? new RelayCommand(
                obg =>
                {
                    if (Login != null && Pass != null)
                    {
                        using (ApplicationContext db = new ApplicationContext())
                        {
                            Media p1 = new Media { Type = "video", Location = @"C:\Users\Andrew\Videos\mp4" };
                            Media p2 = new Media { Type = "video", Location = @"C:\Users\Andrew\Videos\mp4" };
                            Media p3 = new Media { Type = "video", Location = @"C:\Users\Andrew\Videos\mp4" };
                            Media p4 = new Media { Type = "video", Location = @"C:\Users\Andrew\Videos\mp4" };

                            // добавление
                            db.Medias.Add(p1);
                            db.Medias.Add(p2);
                            db.Medias.Add(p3);
                            db.Medias.Add(p4);
                            db.SaveChanges();
                        }
                        using (ApplicationContext db = new ApplicationContext())
                        {
                            var user = db.Users.Where(u => u.Nickname == Login && u.Password == Pass).ToList();
                            if (user.Count == 1)
                            {
                                MessageBox.Show("Приветсвую тебя, чемпион!!!");
                                mainWinVM.WelcomPage = new Home(mainWinVM);
                            }
                            else
                            {
                                MessageBox.Show("Не существует польщователя с данным ником");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите данный");
                    }
                }
                );
            }
        }

        public AuthorizationViewModel(ApplicationViewModel mainWinVm)
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