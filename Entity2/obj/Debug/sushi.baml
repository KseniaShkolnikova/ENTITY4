   M S B A M L   `   `   `  ����B  >Entity2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:Entity2Entity2  5          Entity2.sushi   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:Entity2     5        N� Title$  sushi��5	      .��5      �  � RowDefinitions 5      �� 5   
   $	��69* �6   �� 5   
   $	��69* �6   �� 5   
   $
��313* �6   .+�5      � $��1��6    � ColumnDefinitions 5   
   �� 5      $
��151* �6   �� 5      $	��49* �6   .+�5      �� -   5        $��combobox��5       �� DisplayMemberPath$! INGREDIENTS.NAME_INGREDIENT��6'   $��5q�6W   6b   �� 5   
   -   5        $��ОЧИСТИТЬ��5      $��5q�6$   $
��20px(�6/   $��1��6?   6O   5      &   System.Windows.Controls.DataGrid  5      -   5          Name$ ingridik��5      $��2��6      
IsReadOnly . 6.   � 5      $��0��6    5   
   �� 5      $
��301* �6   �� 5      $	��99* �6   .+�5   
   �� -   5         ��Name$ serch��5      $��0��6!   $��5q�61   �� 5    
   -   5         ��Name$ button_serh��5       $��1��6&   $��5q�66   $��
НАЙТИ��6A   $
��25px(�6Q   6a   5!      5"      5#      