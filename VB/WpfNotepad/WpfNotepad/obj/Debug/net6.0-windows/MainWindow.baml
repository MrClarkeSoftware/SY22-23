   M S B A M L   `   `   `  ����E  AWpfNotepad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WpfNotepad
WpfNotepad  5   	       WpfNotepad.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WpfNotepad     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   o� .@�5      m� $��_File��6   .@�5      m� $
��_New��6   6+   m� 5      -   5        $��_Open��5      6?   m� 5      -   5        $��_Save��5      6?   m� 5      -   5        $��_Exit��5      6?   5      o� 5      .@�5      m� $��A��6   .@�5      m� $��C��6   6,   5      5      m� 5      $��_Edit��6    J� RenderTransformOrigin$ 0.5,0.5&�6&   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ 40.556Q�6*   T� 5      5      .@�5      m�  m� Command$ ApplicationCommands.Copy��6   m� 5       $ ApplicationCommands.Cut��6   m� 5!      $ ApplicationCommands.Paste��6   5"      m� 5#      $��_Font��6   ���	#FFF25454$ 0.5,0.5&�6=   z�5$      V� 5%      .~�5&      �� �� 5'      �� 5(      $ 37.951Q�6*   T� 5)      5*      .@�5,      m� -   5        $��_Bold��5,       m� IsCheckable$
 True��6*   5.      m� 5/      -   5        $��_Italic��5/      $
 True��6,   51      �� 52      m� 53      -   5        $��I_ncrease Font Size��53      54      m� 55      -   5        $��_Decrease Font Size��55      56      58      59      �� 5:   
   -   5         ��Name$ textBox2��5:       �� TextWrapping$
 Wrap=�6%   $��TextBox��69   $	��120��6H   $ 0.5,0.5&�6T   $y�Hidden=�6t   .��6�   z�5;      V� 5<      .~�5=      �� �� 5>      �� 5?      $ 11Q�6&   T� 5@      5A      .��5B   '   5C      �� 5E   
   -	   5        $��textBox1��5E      $
 Wrap=�6"   $��
0,74,4,-70q�5F   
    �� AcceptsReturn$
 True��6    �� 
AcceptsTab$
 True��63   $ 0.5,0.5&�6E   .��6e   z�5G      V� 5H      .~�5I      �� �� 5J      �� 5K      $ 0Q�6&   T� 5L      5M      .��5N   '   .,The quick brown fox jumps over the lazy dog.5P      5Q      5R      