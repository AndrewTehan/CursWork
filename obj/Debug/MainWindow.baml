   M S B A M L   `   `   `  ����F  Bcourse_work, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:course_workcourse_work  5   	   +clr-namespace:ToggleSwitchToggleSwitch  5   	   )clr-namespace:course_workcourse_work  5   	       course_work.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:course_work     5   	   -local1clr-namespace:ToggleSwitch     5   	   -controlclr-namespace:course_work     5   	     � Icon$C  =C:\Users\Andrew\source\repos\course_work\Images\smallLogo.png��5   	    � Title$ ML��5   	    � WindowState$ 	Maximized=�5   	   $
��1519��5   	   $	��722��5   	   $	��375��5   	    � 	Resources 5         ButtonTemplate �� 
TargetType �� CornerRadius �� Color  MultiTriggerButtonStyle �� 
TargetType �� Property	 �� Value
 �� Triggers P� Property P� Value �� 
StartPoint �� EndPoint � Color � Offset  MultiTriggerMenuButtonStyle��%b  &	        &	 �     &	 �    �� 5   
   " ��61   .R�5      �� 
������ $��0q�6/   $ 20��6C   ��5      �� 5      $ 	LightGray��6&   ._�5      �� ��. 6@   5      5      �� 5   
   " ��60   .�5      ��  � ��	 �	#FFEEEEEE6+   �� 5       � ��	 5      �� 5       " ��6&   .R�5!      �� #��z��6!   
������ $��1q�6e   ._�5"      �� $��Center=�6/   $��Center=�6L   5#      5$      5&      
 5(      P� 5)       �@J�IsMouseOver . . �5*      ��  � ��	 5+      �� 5,      $	 0,0&�62   $	 1,0&�6C   .��5-   "   � $ #F41C1C��6/   $ 0Q�6?   6L   � 5.   "   $ 	#FFEEEEEE��6/   $ 1Q�6A   6N   5/      51      52      57      �� 59   
   " ��64   .�5:      ��  � ��
	 ���� 6+   �� 5;       � ��	 5<      �� 5=      " ��6&   .R�5>      �� #��z��6!   
������ $��1q�6e   ._�5?      �� $��Center=�6/   $��Center=�6L   5@      5A      5C      
 5D      P� 5E       �@J�IsMouseOver . . �5F      ��  � ��	 �	#FFC5B8B863   5G      5I      5J      .��5L      �  � ShowGridLines .  
������� � RowDefinitions 5M   
   �� 5N      $��70 �6   �� 5O      $��* �6   .+�5R   
   � -   5        $��0��5R       � ColumnDefinitions 5S      �� 5T      -   5         ��Name$ menuGrid��5T   /   $	��99* �6#   $��34��6A   �� 5U      $
��113* �6#   $��70��60   �� 5V      $
��518* �6#   $	��220��60   �� 5W      $	��58* �6#   $��34��6/   .+�5Z      �� -   5         ��Name$ menuBut��5Z      #��[ 6&   {�.  $��Center=�6i   $��Center=�6�   $��50��6�   $��10,10,10.4,10.4q�6�   $	��170��6�   .��5[      �� -   5         ��Name$
 Menu��5[   (   $��0��6   $��/Images/backArrowIcon.png��66   $��Center=�6Y   $��Center=�6t   $��34��5\      $��34��6    6+   5]      �� 5_      $��50��6   $��1��6    $>��8C:\Users\Andrew\source\repos\course_work\Images\logo.png��60   � 5a      $��2��6    5b      �� 5c      $��40 �6$   �� 5d      $��30 �6$   .+�5g      ]� $��0��6   $��Center=�6)   .+�5h      �� $��3��6   $��40��6-   
������ 
������ .��5i      �� $2��,pack://application:,,,/Images/searchIcon.png��6    5j      �� 5k      $��3q�6   ���	#FFD9D9D9._�5l      �� $	��930��6"   $��5q�6.   $��0q�69    �� SelectionBrush 6M   Z� .��6g   5m      5n      5o      �� 5q      -   5        $��mainStackPanel��5q   *   $��1��6    �� Orientation$ 
Horizontal=�6A   $��Center=�6Z   $��Center=�6u   $	��513��6�   .+�5s      � $	��513��6    5t      �� 5u      �� 5v      �� 5w      �� 5x      .+�5z      �� $��0��6!   $��Center=�61   $��Center=�6N   $ 10��6i   ���	#FFD9D9D9._�5{      ��  �� Padding$ 5q�6(     allSelectBut#���  64   $��Center=�6Z   5|      �� 5~      $��1��6!   $��Center=�61   $��Center=�6N   $ 10��6i   ���	#FFD9D9D9._�5      �� $ 5q�6(     musicSelectBut#���  64   $��Center=�6\   5�      �� 5�      $��2��6!   $��Center=�61   $��Center=�6N   $ 10��6i   ���	#FFD9D9D9._�5�      �� $ 5q�6(     historySelectBut#���  64   $��Center=�6^   5�      �� 5�      $��3��6!   $��Center=�61   $��Center=�6N   $ 10��6i   ���	#FFD9D9D9._�5�      �� $ 5q�6(     scienceSelectbut#���  64   $��Center=�6^   5�      5�      5�      5�      �� 5�      $��3��6   $ 17��6%   ���	#FFD9D9D9$��42��6O   $��Center=�6Z   $��38.4,10,30.8,18.4q�6w   ._�5�      �� -   5        $��/Images/accountIcon.png��5�      $��0,0,-0.4,-0.4q�69   6P   5�      5�      � 5�   
   $��1��6    5�      �� 5�      5�      � 5�   
   $��2��6   $��0 0 0 0q�6    5�      �� 5�      $
��auto �6#   �� 5�      $��1* �6#   .+�5�      � $��0��6   .+�5�      �� -   5         ��Name$ mainMenu��5�      ���	#FFEEEEEE$	��Top=�6F   $��Center=�6^   $��10, 0, 10, 10q�6{   .+�5�      �� -   5        $ b1��5�      #��[ 6)   {�.  $�� 10 10 10 10q�6�   
������ $��0q�6�   $
��Left=�6�   ��6l   �� *SetHomePage+.��5�      �� $ 
Horizontal=�6%   $	��149��6>   .+�5�      �� $��/Images/homeIcon.png��6%   $��39��6C   $��37��6N   $��0q�6Z   $
��Left=�6e   �� 5�        homeBut#���  6(   $��center=�6I   $��15 0 0 0q�6d   5�      5�      �� 5�      -	   5        $ b2��5�      {�.  #��[ 6_   $�� 10 10 10 10q�6�   
������ $��0q�6�   $
��Left=�6�   ��6)   �� *SetHistoryPage+.��5�      �� $ 
Horizontal=�6%   $	��149��6>   .+�5�      �� $E��?C:\Users\Andrew\source\repos\course_work\Images\historyIcon.png��6$   $��35��6m   $��35��6x   $��0q�6�   $
��Left=�6�   �� 5�        
historyBut#���  6(   $��center=�6L   $��15 0 0 0q�6g   5�      5�      �� 5�      -
   5        $ b4��5�      {�.  #��[ 6\   $�� 10 10 10 10q�6�   
������ $��0q�6�   $
��Left=�6�   ��6)   �� *SetLikedPage+.��5�      �� $ 
Horizontal=�6%   $	��149��6>   .+�5�      �� $��/Images/likedListIcon.png��6$   $��35��6G   $��32��6R   $��0q�6^   $
��Left=�6i   �� 5�       	 likedBut#��� 	 6(   $��center=�6J   $��15 0 0 0q�6e   5�      5�      �� 5�      -   5        $ b5��5�      {�.  #��[ 6Z   $��
10,10,0,10q�6�   
������ $��0q�6�   $
��Left=�6�   ��6)   �� *
SetAddPage+.��5�      �� $ 
Horizontal=�6%   $	��149��6>   .+�5�      �� $E��?C:\Users\Andrew\source\course_workEFtest\Images\addFileIcon.png��6$   $��27��6m   $��30��6x   $��5 0 0 0q�6�   $
��Left=�6�   �� 5�       
 add#��� 
 6(   $��center=�6E   $��15 0 0 0q�6`   5�      5�      �� 5�      -   5        $ b6��5�   !   $��
10,10,0,10q�6-   $
��Left=�6A   
������ .+�5�      �� $ 
Horizontal=�6%   $	��149��6>   .+�5�         ToggleSwitch.ToggleButton  -   5          Name$ Bu��5�   2   $��Center=�6>   $��Center=�6[   �� 5�        lang#���  6(   $��center=�6F   $��15 0 0 0q�6a   5�      5�      �� 5�      $	��130��6    	 theme#���  6+   .��5�      �� -   5         ��Name$ styleBox��5�   #   $��1��65   $��3��6E   $��4 4 4 4q�6R   5�      5�      5�      � 5�      $��1��6   .+�5�       � -   5          �Name$ 	mainFrame��5�   -     � NavigationUIVisibility$ Hidden=�6@   ��6`   �� *
WelcomPage+5�      5�      5�      5�      