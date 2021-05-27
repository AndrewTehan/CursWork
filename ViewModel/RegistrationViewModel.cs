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
    internal class RegistrationViewModel
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

        private string passConfirm;

        public string PassConfirm
        {
            get { return passConfirm; }
            set
            {
                passConfirm = value;
                OnPropertyChanged("PassConfirm");
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

        private RelayCommand regeister;

        public RelayCommand Regeister
        {
            get
            {
                return regeister ?? new RelayCommand(
                obg =>
                {
                    if (Login != null)
                    {
                        if (Pass == PassConfirm)
                        {
                            using (ApplicationContext db = new ApplicationContext())
                            {
                                var users = db.Users.Where(p => p.Nickname == Login).ToList();
                                if (users.Count == 0)
                                {
                                    using (ApplicationContext applicatinContext = new ApplicationContext())
                                    {
                                        User user1 = new User { Nickname = Login, Password = Pass };

                                        applicatinContext.Users.Add(user1);
                                        applicatinContext.SaveChanges();

                                        MessageBox.Show("Пользователь " + Login + " зарегистрирован");
                                    }
                                    //using (ApplicationContext applicatinContext = new ApplicationContext())
                                    //{
                                    //    Media p1 = new Media { Location = @"C:\Users\Andrew\Videos\11Авыпуск2019.mp4", Type = "video" };
                                    //    Media p2 = new Media { Location = @"C:\Users\Andrew\Videos\Mando.mp4", Type = "video" };
                                    //    Media p3 = new Media { Location = @"C:\Users\Andrew\Videos\War.mp4", Type = "video" };
                                    //    Media p4 = new Media { Location = @"C:\Users\Andrew\Videos\11Авыпуск2019.mp4", Type = "video" };
                                    //    Media p5 = new Media { Location = @"C:\Users\Andrew\Videos\Mando.mp4", Type = "video" };
                                    //    Media p6 = new Media { Location = @"C:\Users\Andrew\Videos\War.mp4", Type = "video" };

                                    //    // добавление
                                    //    db.Medias.Add(p1);
                                    //    db.Medias.Add(p2);
                                    //    db.Medias.Add(p3);
                                    //    db.Medias.Add(p4);
                                    //    db.Medias.Add(p5);
                                    //    db.Medias.Add(p6);
                                    //    db.SaveChanges();   // сохранение изменений

                                    //    //var phones = db.Medias.ToList();
                                    //    //foreach (var p in phones)
                                    //    //    Console.WriteLine("{0} - {1} - {2}", p.Id, p.Name, p.Price);
                                    //}
                                    mainWinVM.WelcomPage = new Home(mainWinVM);
                                }
                                else
                                {
                                    MessageBox.Show("Этот ник уже существует!!!");
                                }
                            }
                        }
                        else MessageBox.Show("Пароли не совподают");
                    }
                    else
                    {
                        MessageBox.Show("Введите логин");
                    }
                }
                );
            }
        }

        public RegistrationViewModel(ApplicationViewModel mainWinVm)
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