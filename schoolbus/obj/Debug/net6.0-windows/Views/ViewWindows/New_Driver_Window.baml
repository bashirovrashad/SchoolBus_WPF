   M S B A M L   `   `   `  ����D  @schoolbus, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:schoolbus.Views.ViewWindowsschoolbus.Views.ViewWindows  5   	   3    -schoolbus.Views.ViewWindows.New_Driver_Window   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:schoolbus.Views.ViewWindows     5   	     � Title$  New_Driver_Window��5   	   $	��840��6$   $	��450��61    � 
ResizeMode$ NoResize=�6=    � WindowStyle$ SingleBorderWindow=�6S    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      �  � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� $��0��6   $��
New Driver��6   $
��Bold"�62   $��16(�6D   $��Center=�6R   $��15q�6t   6�   �� 5   
   -   5        $��firstname_textbox��5      $��1��6U   $��40��6b   $	��Top=�6n   $��	Firstname��6�   $��Center=�6�   $��15,15,30,15q�6�   6�   �� 5   
   -   5        $��lastname_textbox��5      $��2��6U   $��40��6b   $	��Top=�6n   $��Lastname��6�   $��Center=�6�   $��15,15,30,15q�6�   6�   �� 5   
   -   5        $��phone_textbox��5      $��3��6R   $��40��6_   $	��Top=�6k   $��Phone��6�   $��Center=�6�   $��15,15,30,15q�6�   6�   �� 5   
   -   5        $��username_textbox��5      $��4��6U   $��40��6b   $	��Top=�6n   $��Username��6�   $��Center=�6�   $��15,15,30,15q�6�   6�   �� 5   
   -   5        $��password_textbox��5      $��5��6U   $��40��6b   $	��Top=�6n   $��Password��6�   $��Center=�6�   $��15,15,30,15q�6�   6�   � 5   
   $��6��6    � ColumnDefinitions 5      �� 5       $��* �6#   6/   �� 5!      $��4* �6#   60   .+�5#      �� $	��Car��6   $��16(�6"   $��Center=�60   $��Center=�6R   6x   �� 5$      -   5        $��	car_combo��5$      $��1��6(   $��40��68   $��Center=�6D   $��15,15,30,15q�6f   6}   5&      � 5'   
   $��7��6    5(      �� 5)      $��* �6#   6/   �� 5*      $��4* �6#   60   .+�5,      �� $
��Ride��6   $��16(�6#   $��Center=�61   $��Center=�6S   6y   �� 5-      -   5        $��
ride_combo��5-      $��1��6)   $��40��69   $��Center=�6E   $��15,15,30,15q�6g   6~   5/      �� 50   
   -   5        $��address_textbox��50      $��8��6T   $��40��6a   $	��Top=�6m   $��Home Address��6�   $��Center=�6�   $��15,15,30,15q�6�   6�   �� 51   
   -	   5        $��Licence_textbox��51      $��9��6T   $��40��6a   $	��Top=�6m   $��Licence��6�   $��Center=�6�   $��15,15,30,15q�6�   6�   �� 52   
   -
   5        $��Center=�52   &   $��10��6A   $��Create��6O   $��14(�6`   
�������
��� ���$��80��6�   $��Right=�6�   $��40��6�   $��0q�6�   $��0,0,30,0q�6�   $��Center=�6�   $��Center=�6  6:  54      55      