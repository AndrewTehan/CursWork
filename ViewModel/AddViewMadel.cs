using course_work.Pages;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace course_work.ViewModel
{
    internal class AddViewMadel
    {
        private ApplicationViewModel mainWinVM;

        private string titleFile;

        public string TitleFile
        {
            get { return titleFile; }
            set
            {
                titleFile = value;
                OnPropertyChanged("TitleFile");
            }
        }

        private string locationFile;

        public string LocationFile
        {
            get { return locationFile; }
            set
            {
                locationFile = value;
                OnPropertyChanged("LocationFile");
            }
        }

        private string typeFile;

        public string TypeFile
        {
            get { return typeFile; }
            set
            {
                typeFile = value;
                OnPropertyChanged("TypeFile");
            }
        }

        private RelayCommand add;

        public AddViewMadel(ApplicationViewModel mainWinVm)
        {
            mainWinVM = mainWinVm;
        }

        public RelayCommand Add
        {
            get
            {
                return add ?? new RelayCommand(
                obg =>
                {
                    using (ApplicationContext db = new ApplicationContext())
                    {
                        OpenFileDialog dialog = new OpenFileDialog();
                        byte[] arrImage = null;
                        if (dialog.ShowDialog() == true)
                        {
                            var imageBitMap = new BitmapImage();
                            imageBitMap.BeginInit();
                            imageBitMap.UriSource = new Uri(dialog.FileName);
                            imageBitMap.EndInit();
                            Uri uri = imageBitMap.UriSource;
                            arrImage = File.ReadAllBytes(uri.OriginalString);
                        }

                        Media p1 = new Media
                        {
                            Type = TypeFile,
                            Location = TypeFile,
                            ImageBytes = arrImage,
                            Title = TitleFile,
                            Like = 0,
                            Veiw = 0
                        };
                        db.Medias.Add(p1);
                        db.SaveChanges();
                    }
                }
                );
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