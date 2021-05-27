using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace course_work.Pages
{
    /// <summary>
    /// Логика взаимодействия для PlayingMedia.xaml
    /// </summary>
    public partial class PlayingMedia : Page
    {
        #region MediaElementManipulating

        public bool play = false;
        public bool sound_on = true;
        public bool like_on = true;
        public bool screen = true;
        private TimeSpan ts2;
        private bool isDragging = false;

        public PlayingMedia(Media media, ApplicationViewModel mainWinVm)
        {
            InitializeComponent();

            DataContext = new PlayingMediaVeiwModel(media, mainWinVm);
        }

        private void playMedia(object sender, RoutedEventArgs e)
        {
            if (!play)
            {
                myMediaElement.Play();
                BitmapImage bi3 = new BitmapImage();
                bi3.BeginInit();
                bi3.UriSource = new Uri("/Images/pauseIcon.png", UriKind.Relative);
                bi3.EndInit();
                ImagePlay.Source = bi3;
                Focus();
            }
            else
            {
                myMediaElement.Pause();
                BitmapImage bi3 = new BitmapImage();
                bi3.BeginInit();
                bi3.UriSource = new Uri("/Images/playIcon.png", UriKind.Relative);
                bi3.EndInit();
                ImagePlay.Source = bi3;
            }
            play = !play;
        }

        private void SoundMedia(object sender, RoutedEventArgs e)
        {
            if (!sound_on)
            {
                myMediaElement.Volume = 0;
                volumeSlider.Value = 0;
                myMediaElement.Volume = (double)volumeSlider.Value;
                BitmapImage bi3 = new BitmapImage();
                bi3.BeginInit();
                bi3.UriSource = new Uri("/Images/soundOffIcon.png", UriKind.Relative);
                bi3.EndInit();
                ImageSound.Source = bi3;
            }
            else
            {
                myMediaElement.Volume = 100;
                volumeSlider.Value = 0.5;
                BitmapImage bi3 = new BitmapImage();
                bi3.BeginInit();
                bi3.UriSource = new Uri("/Images/soundOnIcon.png", UriKind.Relative);
                bi3.EndInit();
                ImageSound.Source = bi3;
            }
            sound_on = !sound_on;
        }

        private void OnMouseDownPlayMedia(object sender, MouseButtonEventArgs args)
        {
            myMediaElement.Play();
            InitializePropertyValues();
        }

        private void OnMouseDownPauseMedia(object sender, MouseButtonEventArgs args)
        {
            myMediaElement.Pause();
        }

        private void OnMouseDownStopMedia(object sender, MouseButtonEventArgs args)
        {
            myMediaElement.Stop();
            myMediaElement.Play();
            timelineSlider.Value = 0;
        }

        private void ChangeMediaVolume(object sender, RoutedPropertyChangedEventArgs<double> args)
        {
            myMediaElement.Volume = (double)volumeSlider.Value;
        }

        private void ChangeMediaSpeedRatio(object sender, RoutedPropertyChangedEventArgs<double> args)
        {
            myMediaElement.SpeedRatio = (double)speedRatioSlider.Value;
        }

        private void Element_MediaOpened(object sender, EventArgs e)
        {
            timelineSlider.Maximum = myMediaElement.NaturalDuration.TimeSpan.TotalMilliseconds;
        }

        private void Element_MediaEnded(object sender, EventArgs e)
        {
            myMediaElement.Stop();
        }

        private void SeekToMediaPosition(object sender, RoutedPropertyChangedEventArgs<double> args)
        {
            int SliderValue = (int)timelineSlider.Value;

            TimeSpan ts = new TimeSpan(0, 0, 0, 0, SliderValue);
            myMediaElement.Position = ts;
        }

        private void InitializePropertyValues()
        {
            myMediaElement.Volume = (double)volumeSlider.Value;
            myMediaElement.SpeedRatio = (double)speedRatioSlider.Value;
        }

        #endregion MediaElementManipulating

        private void LikeMedia(object sender, MouseButtonEventArgs e)
        {
            if (!like_on)
            {
                BitmapImage bi3 = new BitmapImage();
                bi3.BeginInit();
                bi3.UriSource = new Uri(@"/Images/likeIcon.png", UriKind.Relative);
                bi3.EndInit();
                likeBut.Source = bi3;
            }
            else
            {
                BitmapImage bi3 = new BitmapImage();
                bi3.BeginInit();
                bi3.UriSource = new Uri(@"/Images/likedIcon.png", UriKind.Relative);
                bi3.EndInit();
                likeBut.Source = bi3;
            }
            like_on = !like_on;
        }
    }
}