using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace course_work.Pages
{
    internal class HomeViewModel : INotifyPropertyChanged
    {
        private ApplicationViewModel mainWinVM;

        private Media selectedMedia;
        private ObservableCollection<Media> media;

        public ObservableCollection<Media> Media
        {
            get
            {
                return media;
            }
            set
            {
                media = value;
                OnPropertyChanged("Media");
            }
        }

        public Media SelectedMedia
        {
            get { return selectedMedia; }
            set
            {
                selectedMedia = value;
                OnPropertyChanged("SelectedMedia");
            }
        }

        private RelayCommand playMedia;

        public RelayCommand PlayMedia
        {
            get
            {
                return playMedia ?? new RelayCommand(
                    obg =>
                    {
                        mainWinVM.WelcomPage = new Pages.PlayingMedia(SelectedMedia, mainWinVM);
                    }

                //    using (ApplicationContext db = new ApplicationContext())
                //{
                //    var user = db.Users.Where(u => u.Nickname == Login && u.Password == Pass).ToList();
                //    if (user.Count == 1)
                //    {
                //        MessageBox.Show("Приветсвую тебя, чемпион!!!");
                //        mainWinVM.WelcomPage = new Home(mainWinVM);
                //    }
                //    else
                //    {
                //        MessageBox.Show("Не существует польщователя с данным ником");
                //    }
                //}
                );
            }
        }

        public int Id
        {
            get
            {
                return SelectedMedia.Id;
            }
            set
            {
                SelectedMedia.Id = value;
                OnPropertyChanged("Id");
            }
        }

        public string Location
        {
            get
            {
                return SelectedMedia.Location;
            }
            set
            {
                SelectedMedia.Location = value;
                OnPropertyChanged("Location");
            }
        }

        public string Type
        {
            get
            {
                return SelectedMedia.Type;
            }
            set
            {
                SelectedMedia.Type = value;
                OnPropertyChanged("Type");
            }
        }

        public HomeViewModel(ApplicationViewModel mainWinVm)
        {
            this.Media = new ObservableCollection<Media>();
            using (ApplicationContext applicatinContext = new ApplicationContext())
            {
                var c = applicatinContext.Medias.Where(u => true).ToList();
                foreach (var i in c)
                    this.Media.Add(i);
            }
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