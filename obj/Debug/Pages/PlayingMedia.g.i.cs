﻿#pragma checksum "..\..\..\Pages\PlayingMedia.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5AB5F2F596EE7F260663414D30862C56EEB1401E6AA7AC46506E2F6F46A1EBF2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using course_work.Pages;


namespace course_work.Pages {
    
    
    /// <summary>
    /// PlayingMedia
    /// </summary>
    public partial class PlayingMedia : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 90 "..\..\..\Pages\PlayingMedia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel MediaStack;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\Pages\PlayingMedia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement myMediaElement;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\Pages\PlayingMedia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider timelineSlider;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\Pages\PlayingMedia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image likeBut;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\..\Pages\PlayingMedia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImagePlay;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\..\Pages\PlayingMedia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImageSound;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\..\Pages\PlayingMedia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider volumeSlider;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\..\Pages\PlayingMedia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider speedRatioSlider;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/course_work;component/pages/playingmedia.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PlayingMedia.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.MediaStack = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.myMediaElement = ((System.Windows.Controls.MediaElement)(target));
            
            #line 93 "..\..\..\Pages\PlayingMedia.xaml"
            this.myMediaElement.MediaOpened += new System.Windows.RoutedEventHandler(this.Element_MediaOpened);
            
            #line default
            #line hidden
            
            #line 93 "..\..\..\Pages\PlayingMedia.xaml"
            this.myMediaElement.MediaEnded += new System.Windows.RoutedEventHandler(this.Element_MediaEnded);
            
            #line default
            #line hidden
            return;
            case 3:
            this.timelineSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 103 "..\..\..\Pages\PlayingMedia.xaml"
            this.timelineSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.SeekToMediaPosition);
            
            #line default
            #line hidden
            return;
            case 4:
            this.likeBut = ((System.Windows.Controls.Image)(target));
            
            #line 119 "..\..\..\Pages\PlayingMedia.xaml"
            this.likeBut.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.LikeMedia);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ImagePlay = ((System.Windows.Controls.Image)(target));
            
            #line 123 "..\..\..\Pages\PlayingMedia.xaml"
            this.ImagePlay.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.playMedia);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 125 "..\..\..\Pages\PlayingMedia.xaml"
            ((System.Windows.Controls.Image)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnMouseDownStopMedia);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ImageSound = ((System.Windows.Controls.Image)(target));
            
            #line 127 "..\..\..\Pages\PlayingMedia.xaml"
            this.ImageSound.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.SoundMedia);
            
            #line default
            #line hidden
            return;
            case 8:
            this.volumeSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 132 "..\..\..\Pages\PlayingMedia.xaml"
            this.volumeSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.ChangeMediaVolume);
            
            #line default
            #line hidden
            return;
            case 9:
            this.speedRatioSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 138 "..\..\..\Pages\PlayingMedia.xaml"
            this.speedRatioSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.ChangeMediaSpeedRatio);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

