   M S B A M L   `   `   `  ����D  @StudentDB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:StudentDB	StudentDB  5   	   !    StudentDB.EditStudentWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:StudentDB     5   	     � Title$  EditStudentWindow��5   	   $	��450��6#   $	��800��60   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Student Management System��6   $��20(�64   $��0��6B   $��3��6R   $��0��6g   $��Center=�6t   $��10 10 10 15q�6�   �� 5   
   -   5        $��StudentNameText��5      $��Edytuj studenta: ��6'   $��20(�6C   $��0��6Q   $��3��6a   $��1��6u   $��Center=�6�   $��10 10 10 15q�6�   �� 5   
   -   5        $��FirstNameText��5      $��Nowe imię: ��6%   $��0��6;   $��2��6K   $	��130��6X   $��25��6d   $��Right=�6p   $��10 10 10 15q�6�   �� 5   
   -   5        $��LastNameText��5      $��Nowe nazwisko: ��6$   $��0��6>   $��3��6N   $	��130��6[   $��25��6g   $��Right=�6s   $��10 10 10 15q�6�   �� 5   
   -   5        $��DayOfBirthText��5      $��Nowa data urodzenia: ��6&   $��0��6F   $��4��6V   $	��130��6c   $��25��6o   $��Right=�6{   $��10 10 10 15q�6�   �� 5   
   -   5        $��IndexNumberText��5      $��Nowy numer indeksu: ��6'   $��0��6F   $��5��6V   $	��130��6c   $��25��6o   $��Right=�6{   $��10 10 10 15q�6�   �� 5    
   -   5        $��ChangeFirstNameText��5       $	��200��6-   $��30��69   $��1��6E   $��2��6U   $��Center=�6b   $��Center=�6   $��10 10 10 10q�6�   �� 5!   
   -   5        $��ChangeLastNameText��5!      $	��200��6,   $��30��68   $��1��6D   $��3��6T   $��Center=�6a   $��Center=�6~   $��10 10 10 10q�6�   (  "System.Windows.Controls.DatePicker  5"   
   -   5        $��ChangeDayOfBirthText��5"      $	��200��61   $��30��6=   $��1��6I   $��4��6Y   $��Center=�6f   $��Center=�6�   $��10 10 10 10q�6�   �� 5#   
   -	   5        $��ChangeIndexNumberText��5#      $	��200��6/   $��30��6;   $��1��6G   $��5��6W   $��Center=�6d   $��Center=�6�   $��10 10 10 10q�6�   �� 5%   
   -
   5        $��ChangeFirstName��5%      $��Zmień��6(   $	��100��68   $��30��6D   $��2��6P   $��2��6`   $
��Left=�6m   $��Center=�6�   $��10 10 10 10q�6�   6�   �� 5&   
   -   5        $��ChangeLastName��5&      $��Zmień��6'   $	��100��67   $��30��6C   $��2��6O   $��3��6_   $
��Left=�6l   $��Center=�6�   $��10 10 10 10q�6�   6�   �� 5'   
   -   5        $��ChangeDayOfBirth��5'      $��Zmień��6)   $	��100��69   $��30��6E   $��2��6Q   $��4��6a   $
��Left=�6n   $��Center=�6�   $��10 10 10 10q�6�   6�   �� 5(   
   -   5        $��ChangeIndexNumber��5(      $��Zmień��6*   $	��100��6:   $��30��6F   $��2��6R   $��5��6b   $
��Left=�6o   $��Center=�6�   $��10 10 10 10q�6�   6�   �� 5*   
   -   5        $��SaveBtn��5*      $��Zapisz��6    $	��100��61   $��50��6=   $��1��6I   $��6��6Y   $
��Left=�6f   $	��Top=�6�   $��10 10 10 15q�6�   �� 5+   
   -   5        $��CancelEditBtn��5+      $��Anuluj��6&   $	��100��67   $��50��6C   $��1��6O   $��6��6_   $��Right=�6l   $	��Top=�6�   $��10 10 10 15q�6�   5,      5-      