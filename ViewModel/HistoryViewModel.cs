using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace course_work.Pages
{
    internal class HistoryViewModel
    {
        private ApplicationViewModel mainWinVM;

        private ObservableCollection<HistoryMedia> historyMedia;

        public ObservableCollection<HistoryMedia> HistoryMedia
        {
            get
            {
                return historyMedia;
            }
            set
            {
                historyMedia = value;
                OnPropertyChanged("HistoryMedia");
            }
        }

        private HistoryMedia selectedMedia;

        public HistoryMedia SelectedMedia
        {
            get { return selectedMedia; }
            set
            {
                selectedMedia = value;
                OnPropertyChanged("SelectedMedia");
            }
        }

        //    public int HistoryMediaId
        //    {
        //        get
        //        {
        //            return SelectedMedia.HistoryMediaId;
        //        }
        //        set
        //        {
        //            SelectedMedia.HistoryMediaId = value;
        //            OnPropertyChanged("HistoryMediaId");
        //        }
        //    }

        //    public string NameUser
        //    {
        //        get
        //        {
        //            return SelectedMedia.NameUser;
        //        }
        //        set
        //        {
        //            SelectedMedia.NameUser = value;
        //            OnPropertyChanged("NameUser");
        //        }
        //    }

        //    public int MediaId
        //    {
        //        get
        //        {
        //            return SelectedMedia.MediaId;
        //        }
        //        set
        //        {
        //            SelectedMedia.MediaId = value;
        //            OnPropertyChanged("Type");
        //        }
        //    }

        public HistoryViewModel(ApplicationViewModel mainWinVm)
        {
            this.mainWinVM = mainWinVm;
            this.HistoryMedia = new ObservableCollection<HistoryMedia>();
            using (ApplicationContext applicatinContext = new ApplicationContext())
            {
                //var c = applicatinContext.HistorieMedias.ToList();
                //System.Data.SqlClient.SqlParameter param = new System.Data.SqlClient.SqlParameter("@name", AuthorizationViewModel.currentUser.Nickname);
                var curHistory = applicatinContext.Database.SqlQuery<HistoryMedia>("select * from HistoryMedias where NameUser = 'zxc'").ToList();
                foreach (var i in curHistory)
                    this.HistoryMedia.Add(i);
            }
        }

        //public HistoryViewModel(ApplicationViewModel mainWinVm)
        //{
        //    this.mainWinVM = mainWinVm;
        //    this.HistoryMedia = new ObservableCollection<HistoryMedia>();
        //    if (AuthorizationViewModel.currentUser != null)
        //    {
        //        using (ApplicationContext applicatinContext = new ApplicationContext())
        //        {
        //            var c = applicatinContext.HistorieMedias.ToList();
        //            //System.Data.SqlClient.SqlParameter param = new System.Data.SqlClient.SqlParameter("@name", AuthorizationViewModel.currentUser.Nickname);
        //            //var curHistory = applicatinContext.Database.SqlQuery<HistoryMedia>("select * from HistoryMedias where NameUser = @name", param).ToList();
        //            foreach (var i in c)
        //            {
        //                this.HistoryMedia.Add(i);
        //            }
        //        }
        //    }
        //}

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}