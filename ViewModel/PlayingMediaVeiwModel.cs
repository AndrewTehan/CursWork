using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using course_work.Model;

namespace course_work.Pages
{
    public class PlayingMediaVeiwModel : INotifyPropertyChanged
    {
        private ApplicationViewModel mainWinVm;

        private Media selectedMedia;
        public Media media { get; set; }
        public HistoryMedia historyMedia { get; set; }

        public Media SelectedMedia
        {
            get { return selectedMedia; }
            set
            {
                selectedMedia = value;
                OnPropertyChanged("SelectedMedia");
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

        public RelayCommand SetLike => new RelayCommand(obg =>
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                LikedMedia p1 = new LikedMedia { NameUser = AuthorizationViewModel.currentUser.Nickname, IdMedia = media.Id };

                // добавление
                db.LikedMedias.Add(p1);
                db.SaveChanges();
                MessageBox.Show("лайк");

                var m = db.Medias.First(x => x.Id == media.Id);
                m.Like += 1;
            }
        });

        public PlayingMediaVeiwModel(Media media, ApplicationViewModel mainWinVM)
        {
            this.media = media;
            this.mainWinVm = mainWinVm;
            SelectedMedia = new Media();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}