   M S B A M L   `   `   `  ����F  Bcourse_work, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:course_work.Pagescourse_work.Pages  5          course_work.Pages.Home   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      +localclr-namespace:course_work.Pages  5        N� Title$
  Home��5
       � 	Resources 5         NoSelectionListBoxItemStyle �� 
TargetType �� Property �� Value �� RelativeSource �� AncestorType �� 
TargetType ��Name	 �� Padding
 J� SnapsToDevicePixels �� Triggers P� Property P� Value��%�  &	        �� 5   
   " ��64   .�5      ��  � ��
 ���� 6+   �� 5       � �� 6;   �� *HorizontalContentAlignment+ �� " ���� 5       � �� 69   �� *VerticalContentAlignment+ �� " ���� 5       � ��$ 2,0,0,0q�6(   �� 5       �@�FocusVisualStyle 5      �� 5      .�5      ��  � �� 6=   Z� 5      5      �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ Bd��6!   #��z��6-   #��z��6Y   #��z��6�   #	 z��6�   
 . ._�5      �� #��z��6/   #
 z
 6r   #��z��6�   5       5       P� 5!       � {� .  . �5"   "   �� # � ��6?    � ��5#      5&      5(      5)      5*      .��5,      � .+�5-   
   �� 
������ .��5.      �� $��Disabled=�6   
������ $��0q�6h   .+�5/      �� -   5         ��Name$ mainListBox��5/      $��0q�6/   $��0q�6;   $��Disabled=�6F   
������   WrapTemplate#��[ 6�   ��50      �� *Media+ �� SelectedItem 68   �� *SelectedMedia+.  (System.Windows.Interactivity.Interaction   Triggers 52      /  )System.Windows.Interactivity.EventTrigger  53         	EventName$ SelectionChanged��6)   .  (System.Windows.Interactivity.TriggerBase   Actions. 54      6  0System.Windows.Interactivity.InvokeCommandAction     Command 64   �� *	PlayMedia+55      ��58      �� 59      .R�5:      �� $��0q�6*   $��10q�65   #��[  6B   .��5;   "   � ��6'   Z�  � RowDefinitions 5<   &   �� 5=   *   $
��auto �68   �� 5>   *   $
��auto �68   �� 5?   *   $
��auto �68   .+�5A   &   �� $��0��6-   ���	#FFEEEEEE._�5B   *   �� ��60   �� *
ImageBytes+5C   '   �� 5E   &   $��1��6-   ���	#FFEEEEEE._�5F   *   �� $��18(�60   ��6>   �� *Title+5G   '   � 5I   &   $��2��6+   ���	#FFEEEEEE � ColumnDefinitions 5J   *   �� 5K   .   �� 5L   .   .+�5N   *   �� $��0��60   ��6@   �� *Veiw+�� 5O   *   $��1��60   ��6@   �� *Like+5P   '   5Q   #   5R      5S      5U      5w      5x      5y      5z      