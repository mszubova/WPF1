   M S B A M L   `   `   `  ����A  =_8Ball, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:_8Ball_8Ball  5          _8Ball.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      &localclr-namespace:_8Ball     5        � Title$  
MainWindow��5      $	��450��6   $	��800��6#   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��100* �6   �� 5      $
��Auto �6   �� 5      $
��100* �6   ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 0,1&�63   ��5      �  � Offset$ 1Q�6#    � Color$ 	#FFEEEEEE��6.   � 5      $ 0.881Q�6#   $ 	#FF302F2F��62   5      .+�5   
   �� -   5        $��txtQuestion��5      $��Stretch=�6%   $��Stretch=�6C   $��10q�6_    �� TextWrapping$
 Wrap=�6k   $��Verdana)�6   $��20(�6�   $��0��6�   ���	#FF646464$-��'[Введите свой вопрос.]��6�   �� 5      -   5        $
��Left=�5      $��Center=�6&   $��	10,0,10,0q�6A   $��5q�6T   $��1��6`   $"��Ответ на вопрос��6n    �� 	IsDefault . 6�   �� 5      -   5        $��	txtAnswer��5      $��Stretch=�6   $��Stretch=�6;   $��10q�6W   $
 Wrap=�6c   $��Verdana)�6w   $��20(�6�    �� 
IsReadOnly . $��2��6�   ���	#FF009BFF$/��)[Ответ появится здесь.]��6�   5      5      