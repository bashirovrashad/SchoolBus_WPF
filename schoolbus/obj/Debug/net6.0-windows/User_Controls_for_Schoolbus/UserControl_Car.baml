   M S B A M L   `   `   `  ����D  @schoolbus, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:schoolbus.User_Controls_for_Schoolbus%schoolbus.User_Controls_for_Schoolbus  5      ;    5schoolbus.User_Controls_for_Schoolbus.UserControl_Car   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Elocal3clr-namespace:schoolbus.User_Controls_for_Schoolbus     5      .��5      � 
��� ���$	��430��6#   $	��450��60     � RowDefinitions  5   
   �� 5      $��2* �6   6*   �� 5      $��8* �6   6*   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      6%   �� 5      6%   �� 5      6%   .+�5      �� -   5        $��uc_noqte��5   K   $��45��6   $��45��6    $��5q�6,   
�������$��0��6[   $��Center=�6�   $��Center=�6�   $��0q�6�   .��5      �� $+��%..\Images\9112513_bars_solid_icon.png��6   6J   5      �� 5      -   5         ��Name$ Update_button��5   M   $��45��6*   $��45��65   $��5q�6B   $��1��6d   $y�	Collapsed=�6u   $��Center=�6�   $��Center=�6�   
�������$��0q�6�   .��5      �� $>��8..\Images\3688460_pencil_text_update_write_draw_icon.png��6   6\   5      �� 5      -   5        $ Remove_button��5   7   $��45��6   $��45��6    $��5q�6,   $��2��6N   $y�	Collapsed=�6_   $��Center=�6v   $��Center=�6�   
�������$��0q�6�   .��5       �� $5��/..\Images\1564502_basket_delete_remove_icon.png��6   6S   5!      5$      � 5&   
   $��1��6    5'      �� 5(      $��3* �6#   60   �� 5)      $��7* �6#   60     5+      �� 5,      6"   �� 5-      6"   �� 5.      6"   �� 5/      6"   �� 50      6"   .+�54      �� $��Center=�6   $��Center=�66   $��18(�6Z   
�������$��0��6{   $��0��6�   $��Driver Fullname��6�   6�   �� 55      $��Center=�6   $��Center=�66   $��20(�6Z   
�������$��1��6{   $��0��6�   $
��Name��6�   6�   �� 56      $��Center=�6   $��Center=�66   $��20(�6Z   
�������$��2��6{   $��0��6�   $��Number��6�   6�   �� 57      $��Center=�6   $��Center=�66   $��20(�6Z   
�������$��3��6{   $��0��6�   $��
Seat Count��6�   6�   �� 59      $��Center=�68   $��Center=�6S   $	��285��6p   $��40��6|   $��0��6�   $��Center=�6�   $��1��6�    �� 
IsReadOnly$
 True��6�   $��18(�6�   
�������$��0q�6�   $��15q�6  ��6   �� *Driver.FirstName+6  �� 5:      $��Center=�6,   $��Center=�6G   $	��285��6d   $��40��6p   $��Center=�6}   $��1��6�   $��1��6�   $
 True��6�   $��18(�6�   
�������$��0q�6�   $��15q�6  ��6   �� *Name+6  �� 5;      $��Center=�6/   $��Center=�6J   $	��285��6g   $��40��6s   $��Center=�6�   $��2��6�   $��1��6�   $
 True��6�   $��18(�6�   
�������$��0q�6�   $��15q�6
  ��6   �� *Number+6  �� 5<      $��Center=�62   $��Center=�6M   $	��285��6j   $��40��6v   $��Center=�6�   $��3��6�   $��1��6�   $
 True��6�   $��18(�6�   
�������$��0q�6�   $��15q�6  ��6   �� *
Seat_Count+6  �� 5A      -   5        $��	ok_button��5A      $��4��6&   $��1��63   $��35��6C   $��35��6N   $��0q�6Z   
��� ���$��	5,5,15,25q�6�   $��Bottom=�6�   $��Right=�6�   $y�	Collapsed=�6�   .��5B      �� $6��0..\Images\103184_checkmark_yes_ok_check_icon.png��6   6T   5C      5D      5H      5I      