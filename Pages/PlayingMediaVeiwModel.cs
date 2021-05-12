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
    internal class PlayingMediaVeiwModel : INotifyPropertyChanged
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

        public PlayingMediaVeiwModel(Media media, ApplicationViewModel mainWinVM)
        {
            this.media = media;
            this.mainWinVm = mainWinVm;
        }

        public PlayingMediaVeiwModel(HistoryMedia historyMedia, ApplicationViewModel mainWinVM)
        {
            this.historyMedia = historyMedia;
            this.mainWinVm = mainWinVm;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}