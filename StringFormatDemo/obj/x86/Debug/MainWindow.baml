   M S B A M L   `   `   `  ����  StringFormatDemo!    StringFormatDemo.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  String Format Demo��5   	   $	��210��5   	   $	��270��5   	   
�������.��5      � $��10q�6    � ColumnDefinitions 5	   
   �� 5
      $	��110 �6   �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� -   5        $��MyValue��5   %   $��2��6    � Minimum$ 0Q�64    � Maximum$ 10Q�6@   $��10q�6M   �� 5   
   $��1��6   No Formatting60   �� 5   
   $��1��6   $��1��6!   ��5      ��  �� ElementName$ MyValue�� �� Path$ Value��� 5   
   $��2��6   
Currency6+   �� 5   
   $��2��6   $��1��6!   ��5       �� $ MyValue��$ Value� �� StringFormat$ N2��5"      5#      