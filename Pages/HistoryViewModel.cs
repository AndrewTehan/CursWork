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
                OnPropertyChanged("HstoryMedia");
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

        //    private RelayCommand playMedia;

        //    public RelayCommand PlayMedia
        //    {
        //        get
        //        {
        //            return playMedia ?? new RelayCommand(
        //                obg =>
        //                {
        //                    mainWinVM.WelcomPage = new Pages.PlayingMedia(SelectedMedia, mainWinVM);
        //                }
        //            );
        //        }
        //    }

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
                var c = applicatinContext.HistorieMedias.ToList();
                foreach (var i in c)
                    this.HistoryMedia.Add(i);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}