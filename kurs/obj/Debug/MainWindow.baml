   M S B A M L   `   `   `  ����?  ;kurs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:kurskurs  5   	       kurs.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:kurs     5   	     � Title$%  Главная страница��5   	   $	��450��6"   $	��800��6/   $��Cascadia Mono ExtraLight)�6;   .��5	      � ��5
   
   �� 5       � RowDefinitions 5   
   �� 5      $	��377 �6   �� 5      $��50 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ Service��5         AutoGenerateColumns .     
IsReadOnly .    CanUserResizeColumns .  $��	0,44,0,-7q�5   	   $��2��6      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Дата сдачи��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6_   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 69   �� *Times1.name_time1+6_     5      $ Время ремонта��6%   $
 Auto 6b   	 6<   �� *Times2.name_time2+6b     5      $ Клиент��6%   $
 Auto 6]   	 65   �� *Clients.client_name+6]     5      $! Тип устройства��6%   $
 Auto 6e   	 6=   �� *Devices.device_name+6e     5      $ Тип ремонта��6%   $
 Auto 6q   	 6:   �� *$"Type_of_repair.name_type_of_repair+6q     5      $ Цена��6%   $
 Auto 6X   	 63   �� *Price.name_price+6X     5      $ Сотрудник��6%   $
 Auto 6`   	 68   �� *Workers.name_worker+6`     5      $ Гарантия��6%   $
 Auto 6b   	 67   �� *Warranty.name_warranty+6b   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 Auto 6)   -   5        Red��
   CellTemplate
 5       �� 5!      .R�5"      ��  ��Name$ BtnEdit��6=   -   5        $ ��Редактировать��5"   %   6N   5#      5%      5'      �� 5(   
   -   5        $��BtnAdd��5(   L   $��Добавить��6   $��1��6$   $
��Left=�61   6Z   �� 5)   
   -   5        $��BtnAuthorization��5)   M   $��Вернуться��6   $��1��6%   $
��Left=�62   $��417, 0, 0, 0q�6�   �� 5*   
   -   5        $��BtnUp��5*   L   $��Обновить��6   $��1��6$   $
��Left=�61   $��	213,0,0,0q�6m   �� 5+   
   -   5        $��BtnOut��5+   @   $��Применить��6   $
��Left=�6%   $��
501,10,0,0q�6c   $	��Top=�6w   $��24��6�   $	��109��6�   ���	#FFAFCEFF6�   �� 5,   
   -   5        $��BtnDelet��5,   L   $��Удалить��6   $��1��6#   $��Right=�60   6\   �� 5-   
   -	   5         ��Name$ ComboStatus��5-   O    �� DisplayMemberPath$ name_type_of_repair��6d   $��
378,12,0,0q�6�   $	��Top=�6�   $��20��6�   $
��Left=�5.      $	��118��6.    �� SelectedItem 5-      �� *$"Type_of_repair.name_type_of_repair+5.   :   �� 5/   
   $��Фильтр��6   $
��Left=�6"   $��
328,12,0,0q�6=   $	��Top=�6Q   $��50��6i   �� 50   
   $��
Поиск��6   $
��Left=�6!   $��	29,10,0,0q�6<   $	��Top=�6O   $��50��6g   �� 51   
   -
   5         ��Name$ 	SearchBox��51      $	��200��6%   $��22��61   $��79,8,0,0q�6a   $	��Top=�6s   $
��Left=�6�   
�������6�   52      53      