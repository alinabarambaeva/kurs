   M S B A M L   `   `   `  ����?  ;kurs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:kurskurs  5   	       kurs.AddEditWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:kurs     5   	     � Title$$  Добавьте заявку ��5      $	��450��6'   $	��400��64    � WindowStartupLocation$ CenterScreen=�6@   $��Cascadia Mono ExtraLight)�6e   .��5	      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   6-   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   .+�5   
   �� $��   Дата сдачи:��6   $��16(�6+   $��	0,51,0,21q�69   $��2��6L   �� 5   
   $��   Клиент:��6   $��1��6&   $��16(�64   $��0,59,0,6q�6B   $��2��6T   6g   �� 5   
   $��   Тип ремонта:��6   $��2��6+   $��16(�69   $��	0,71,0,68q�6G   $��3��6Z   6m   �� 5   
   $��   Устройство:��6   $��4��6*   $��16(�68   $��0,5,0,63q�6F   $��2��6X   6k   �� 5   
   -   5        $��DataTextBox��5      $��1��6%   $	��170��65   $
��Left=�6A   $��	0,51,0,50q�6\   $��2��6o   �� 5   
   -   5        $��ClientTextBox��5      $��1��6'   $��1��67   $	��170��6D   $
��Left=�6P   $��	0,59,0,43q�6k   $��2��6~   �� 5    
   -   5         ��Name$ TypeComboBox��5       $��1��6Q   $��2��6a   $	��170��6n    �� DisplayMemberPath$ name_type_of_repair��6z   $
��Left=�6�   $��	0,71,0,32q�6�   $��2��6�    �� SelectedItem 6)   �� *Type_of_repair+6�   �� 5!   
   -   5        $ DeviceComboBox��5!      $��1��6L   $��4��6\   $	��170��6i   $ device_name��6u   $
��Left=�6�   $��0,6,0,25q�6�    6+   �� *	Devices+6�   �� 5#   
   -   5        $��BtnSave��5#   F   $��Сохранить��6   $��2��6%   $��8��69   $��15(�6l   6|   5$      5%      