﻿#pragma checksum "..\..\..\Pages\Liked.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3481EFC78E7239755B98375879AEFD12431CCE89F7530D83E242960D3BC813F3"
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


namespace course_work.Pages {
    
    
    /// <summary>
    /// Liked
    /// </summary>
    public partial class Liked : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 93 "..\..\..\Pages\Liked.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement myMediaElement;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\Pages\Liked.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider timelineSlider;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\Pages\Liked.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImagePlay;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\Pages\Liked.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImageSound;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\..\Pages\Liked.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider volumeSlider;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\..\Pages\Liked.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider speedRatioSlider;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\..\Pages\Liked.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImageScreen;
        
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
            System.Uri resourceLocater = new System.Uri("/course_work;component/pages/liked.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Liked.xaml"
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
            this.myMediaElement = ((System.Windows.Controls.MediaElement)(target));
            
            #line 95 "..\..\..\Pages\Liked.xaml"
            this.myMediaElement.MediaOpened += new System.Windows.RoutedEventHandler(this.Element_MediaOpened);
            
            #line default
            #line hidden
            
            #line 95 "..\..\..\Pages\Liked.xaml"
            this.myMediaElement.MediaEnded += new System.Windows.RoutedEventHandler(this.Element_MediaEnded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.timelineSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 103 "..\..\..\Pages\Liked.xaml"
            this.timelineSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.SeekToMediaPosition);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ImagePlay = ((System.Windows.Controls.Image)(target));
            
            #line 117 "..\..\..\Pages\Liked.xaml"
            this.ImagePlay.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnMouseDownPlayMedia);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 118 "..\..\..\Pages\Liked.xaml"
            ((System.Windows.Controls.Image)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnMouseDownStopMedia);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ImageSound = ((System.Windows.Controls.Image)(target));
            
            #line 119 "..\..\..\Pages\Liked.xaml"
            this.ImageSound.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.SoundMedia);
            
            #line default
            #line hidden
            return;
            case 6:
            this.volumeSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 123 "..\..\..\Pages\Liked.xaml"
            this.volumeSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.ChangeMediaVolume);
            
            #line default
            #line hidden
            return;
            case 7:
            this.speedRatioSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 126 "..\..\..\Pages\Liked.xaml"
            this.speedRatioSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.ChangeMediaSpeedRatio);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ImageScreen = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

