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
        public bool screen = true;
        private TimeSpan ts2;
        private bool isDragging = false;

        public PlayingMedia(Media media, ApplicationViewModel mainWinVm)
        {
            InitializeComponent();

            DataContext = new PlayingMediaVeiwModel(media, mainWinVm);
        }

        public PlayingMedia(HistoryMedia historyMedia, ApplicationViewModel mainWinVm)
        {
            InitializeComponent();

            DataContext = new PlayingMediaVeiwModel(historyMedia, mainWinVm);
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

        // Play the media.
        private void OnMouseDownPlayMedia(object sender, MouseButtonEventArgs args)
        {
            // The Play method will begin the media if it is not currently active or
            // resume media if it is paused. This has no effect if the media is
            // already running.
            myMediaElement.Play();

            // Initialize the MediaElement property values.
            InitializePropertyValues();
        }

        // Pause the media.
        private void OnMouseDownPauseMedia(object sender, MouseButtonEventArgs args)
        {
            // The Pause method pauses the media if it is currently running.
            // The Play method can be used to resume.
            myMediaElement.Pause();
        }

        // Stop the media.
        private void OnMouseDownStopMedia(object sender, MouseButtonEventArgs args)
        {
            // The Stop method stops and resets the media to be played from
            // the beginning.
            myMediaElement.Stop();
            myMediaElement.Play();
            timelineSlider.Value = 0;
        }

        // Change the volume of the media.
        private void ChangeMediaVolume(object sender, RoutedPropertyChangedEventArgs<double> args)
        {
            myMediaElement.Volume = (double)volumeSlider.Value;
        }

        // Change the speed of the media.
        private void ChangeMediaSpeedRatio(object sender, RoutedPropertyChangedEventArgs<double> args)
        {
            myMediaElement.SpeedRatio = (double)speedRatioSlider.Value;
        }

        // When the media opens, initialize the "Seek To" slider maximum value
        // to the total number of miliseconds in the length of the media clip.
        private void Element_MediaOpened(object sender, EventArgs e)
        {
            timelineSlider.Maximum = myMediaElement.NaturalDuration.TimeSpan.TotalMilliseconds;
        }

        // When the media playback is finished. Stop() the media to seek to media start.
        private void Element_MediaEnded(object sender, EventArgs e)
        {
            myMediaElement.Stop();
        }

        // Jump to different parts of the media (seek to).

        private void SeekToMediaPosition(object sender, RoutedPropertyChangedEventArgs<double> args)
        {
            int SliderValue = (int)timelineSlider.Value;

            // Overloaded constructor takes the arguments days, hours, minutes, seconds, milliseconds.
            // Create a TimeSpan with miliseconds equal to the slider value.
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, SliderValue);
            myMediaElement.Position = ts;
        }

        private void InitializePropertyValues()
        {
            // Set the media's starting Volume and SpeedRatio to the current value of the
            // their respective slider controls.
            myMediaElement.Volume = (double)volumeSlider.Value;
            myMediaElement.SpeedRatio = (double)speedRatioSlider.Value;
        }

        #endregion MediaElementManipulating

        private void screenSize(object sender, MouseButtonEventArgs e)
        {
            if (!screen)
            {
                BitmapImage bi3 = new BitmapImage();
                bi3.BeginInit();
                bi3.UriSource = new Uri(@"\Images\normalScreenIcon.png", UriKind.Relative);
                bi3.EndInit();
                ImageScreen.Source = bi3;
            }
            else
            {
                BitmapImage bi3 = new BitmapImage();
                bi3.BeginInit();
                bi3.UriSource = new Uri(@"\Images\fullScreenIcon.png", UriKind.Relative);
                bi3.EndInit();
                ImageScreen.Source = bi3;
            }
            screen = !screen;
        }
    }
}