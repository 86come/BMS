   M S B A M L   `   `   `  ����>  :BMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:BMSBMS  5          BMS.readerreturn   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      #localclr-namespace:BMS     5        N� Title$  readerreturn��5	      .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��	dataGrid1��5         AutoGenerateColumns .  $	��200��6@      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	用户名��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *id+  5      $ 书籍编号��6%    63   �� *bno+  5      $ 借书时间��6%    63   �� *btime+5      �� 5   
   -   5        $��查询借书��5      $
��Left=�6    $��799,118,0,0q�6;   $	��Top=�6P   $��75��6h   6s   �� 5   
   -   5        $��txtid��5      $
��Left=�6   $��23��6:   $��496,118,0,0q�6F    �� TextWrapping$
 Wrap=�6[   $	��Top=�6o   $	��120��6�   �� 5   
   $
��Left=�6   $��329,122,0,0q�6/   $
��Wrap=�6D   $	��Top=�6X   �� 6q   $�	用户名��6u   �� 6�   $	�：��6�   6�   �� 5   
   -   5        $��还书��5      $
��Left=�6   $��1021,99,0,0q�69   $	��Top=�6N   $��75��6f   $��57��6q   6}   5      5      