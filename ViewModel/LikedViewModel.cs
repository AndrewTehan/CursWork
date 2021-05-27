using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace course_work.Pages
{
    internal class LikedViewModel
    {
        private ApplicationViewModel mainWinVM;

        private ObservableCollection<LikedMedia> likedMedia;

        public ObservableCollection<LikedMedia> LikedMedia
        {
            get
            {
                return likedMedia;
            }
            set
            {
                likedMedia = value;
                OnPropertyChanged("LikedMedia");
            }
        }

        private LikedMedia selectedMedia;

        public LikedMedia SelectedMedia
        {
            get { return selectedMedia; }
            set
            {
                selectedMedia = value;
                OnPropertyChanged("SelectedMedia");
            }
        }

        public LikedViewModel(ApplicationViewModel mainWinVm)
        {
            this.mainWinVM = mainWinVm;
            this.LikedMedia = new ObservableCollection<LikedMedia>();
            using (ApplicationContext applicatinContext = new ApplicationContext())
            {
                //var c = applicatinContext.HistorieMedias.ToList();
                //System.Data.SqlClient.SqlParameter param = new System.Data.SqlClient.SqlParameter("@name", AuthorizationViewModel.currentUser.Nickname);
                var curHistory = applicatinContext.Database.SqlQuery<LikedMedia>("select * from LikedMedias where NameUser = 'zxc'").ToList();
                foreach (var i in curHistory)
                    this.LikedMedia.Add(i);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        //private ApplicationViewModel mainWinVM;

        //private ObservableCollection<Liked> likedMedia;

        //public ObservableCollection<Liked> LikedMedia
        //{
        //    get
        //    {
        //        return likedMedia;
        //    }
        //    set
        //    {
        //        likedMedia = value;
        //        OnPropertyChanged("LikedMedia");
        //    }
        //}

        //public LikedViewModel(ApplicationViewModel mainWinVm)
        //{
        //    this.mainWinVM = mainWinVm;
        //    this.LikedMedia = new ObservableCollection<Liked>();
        //    using (ApplicationContext applicatinContext = new ApplicationContext())
        //    {
        //        //var c = applicatinContext.HistorieMedias.ToList();
        //        //System.Data.SqlClient.SqlParameter param = new System.Data.SqlClient.SqlParameter("@name", AuthorizationViewModel.currentUser.Nickname);
        //        var curLiked = applicatinContext.Database.SqlQuery<Liked>("select * from LikedMedias where NameUser = 'zxc'").ToList();
        //        foreach (var i in curLiked)
        //            this.LikedMedia.Add(i);
        //    }
        //}

        //public event PropertyChangedEventHandler PropertyChanged;

        //public void OnPropertyChanged([CallerMemberName] string prop = "")
        //{
        //    if (PropertyChanged != null)
        //        PropertyChanged(this, new PropertyChangedEventArgs(prop));
        //}
    }
}