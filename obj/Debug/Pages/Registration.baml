   M S B A M L   `   `   `  ����F  Bcourse_work, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:course_work.Pagescourse_work.Pages  5      $    course_work.Pages.Registration   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:course_work.Pages     5        N� Title$  Registration��5	       � 	Resources 5         MultiTriggerMenuButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value��%|  &	        �� 5   
   " ��64   .�5      ��  � ��
 ���� 6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   
������ $��1q�6e   ._�5      �� $��Center=�6/   $��Center=�6L   5      5      5       5      P� 5       �@J�IsMouseOver . . �5      ��  � ��
 �����63   5      5      5      .��5      � 	 � RowDefinitions	 5!   
   �� 5"      $��2* �6   �� 5#      $��1* �6   �� 5$      $��2* �6   �� 5%      $��1* �6   �� 5&      $��2* �6   �� 5'      $��1* �6   �� 5(      $��2* �6   .+�5*   
   �� $��7��6   ��5+      �� 5,      
 �� 
StartPoint$	
 1,1&�6&    �� EndPoint$	 0,1&�67   .��5-      �  � Color$
 Cyan��6#    � Offset$	 0.0Q�60   � 5.      $ White��6#   $	 0.2Q�61   � 5/      $ 
BlueViolet��6#   $	 0.5Q�66   � 50      $ white��6#   $	 0.8Q�61   � 51      $
 Cyan��6#   $	 1.0Q�60   52      54      �� 56   
   $��0��6   $��Bottom=�6"    �� Orientation$ 
Horizontal=�6=   $	��149��6V   .+�57      �� $��/Images/nicknameIcon.png��6   $��39��67   $��37��6B   $��0q�6N   $
��Left=�6Y   �� 58      $��0��6   $��Enter login��6!   $��Center=�67   $��Center=�6T   59      �� 5:   
   -   5         ��Name$ login��5:      $��14(�6!   $	��200��6/   $��30��6;    �� TextAlignment$ Center=�6G   $��1��6u   $��5q�6�   
���������6^   �� *Login+6�   �� 5<   
   $��2��6   $��Bottom=�6"   $ 
Horizontal=�6=   $	��149��6V   .+�5=      �� $��/Images/passIcon.png��6   $��39��63   $��37��6>   $��0q�6J   $
��Left=�6U   �� 5>      $��Enter password��6   $��Center=�6-   $��Center=�6J   5?      �� 5@   
   -   5        $ password��5@   s   $��3��6   $��14(�6    $	��200��6.   $��30��6:   $ Center=�6F   $��5q�6�   
���������6]   �� *Pass+6�   �� 5B   
   $��4��6   $��Bottom=�6"   $ 
Horizontal=�6=   $��Center=�6V   .+�5C      �� $��/Images/passIcon.png��6   $��39��63   $��37��6>   $��0q�6J   $
��Left=�6U   �� 5D      $��Confirm the password��6   $��Center=�63   $��Center=�6P   5E      �� 5F   
   -   5        $ passwordConfirm��5F   z   $��5��6   $��14(�6   $	��200��6-   $��30��69   $ Center=�6E   $��5q�6�   
���������6\   �� *PassConfirm+6�   � 5H   
   $��6��6    � ColumnDefinitions 5I      �� 5J      �� 5K      .+�5M      �� -   5         ��Name$ b1��5M   Z   $��1��6   #��[  6%   
������ $��0q�6�   $��Center=�6�   $��Center=�6�   ��6f   �� *	Regeister+��6�   Z� .��5N      �� $ 
Horizontal=�6   .+�5O      �� $��/Images/nextIcon.png��6   $��50��6:   $��50��6E   $��Center=�6Q   $��Center=�6l   5P      5Q      �� 5S      -   5        $ b2��5S   Z   $��0��6   #��[  6%   
������ $��0q�6�   $��Center=�6�   $��Center=�6�   ��6f   �� *Cancel+��6�   Z� .��5T      �� $ 
Horizontal=�6   .+�5U      �� $��/Images/cancelIcon.png��6   $��50��6<   $��50��6G   $��Center=�6S   $��Center=�6n   5V      5W      5X      5Y      5Z      