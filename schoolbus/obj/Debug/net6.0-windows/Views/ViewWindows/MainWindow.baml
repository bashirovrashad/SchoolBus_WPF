   M S B A M L   `   `   `  ����D  @schoolbus, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:schoolbus	schoolbus  5   	       schoolbus.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:schoolbus     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � WindowState$ 	Maximized=�5	   	    � 
ResizeMode$ NoResize=�6"    � WindowStyle$ SingleBorderWindow=�68   .��5
      �  � ColumnDefinitions 5   
   �� 5      $
��1.5* �6   6.   �� 5      $
��8.5* �6   6.   .+�5   
   � $��0��6    � RowDefinitions 5      �� 5      $
��2.5* �6    60   �� 5      $
��7.5* �6    60   .+�5      �� $'��!..\..\Images\schoolbus612x612.jpg��6   $��0��6A   6P   �� 5      $��1��6   $	��Top=�6&   $	��150��6>   .+�5      �� -   5        $��create_ride_button��5      $��5,70,5,5q�6R   $��14(�6e   $��35��6s   $��Create Ride��6�   
�������$��1q�6�   
��� ���$��Center=�6�   $��Center=�6�   6  �� 5      -   5        $��rides_button��5      $��14(�6F   $��35��6T   $��5q�6`   $��Rides��6k   
�������$��1q�6�   
��� ���$��Center=�6�   $��Center=�6�   6  �� 5      -   5        $��class_button��5      $��14(�6G   $��35��6U   $��5q�6a   $��Class��6l   
�������$��1q�6�   
��� ���$��Center=�6�   $��Center=�6�   6  �� 5      -   5        $��student_button��5      $��14(�6K   $��35��6Y   $��5q�6e   $��Student��6p   
�������$��1q�6�   
��� ���$��Center=�6�   $��Center=�6�   6
  �� 5      -   5        $��parent_button��5      $��14(�6H   $��35��6V   $��5q�6b   $��Parent��6m   
�������$��1q�6�   
��� ���$��Center=�6�   $��Center=�6�   6  �� 5      -   5        $��driver_button��5      $��14(�6H   $��35��6V   $��5q�6c   $��Driver��6n   
�������$��1q�6�   
��� ���$��Center=�6�   $��Center=�6�   6  �� 5      -   5        $��
car_button��5      $��14(�6B   $��35��6P   $��5q�6\   $	��Car��6g   
�������$��1q�6�   
��� ���$��Center=�6�   $��Center=�6�   6�   �� 5       -   5        $��holiday_button��5       $��14(�6F   $��35��6T   $��5q�6a   $��Holidays��6l   
�������$��1q�6�   
��� ���$��Center=�6�   $��Center=�6�   6  5!      5#       � 5$   
   -	   5          �Name$ 	mainframe��5$       $��1��6   65   5&      5'      