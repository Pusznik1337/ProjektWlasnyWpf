   M S B A M L   `   `   `  ����H  DProjektWlasny, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ProjektWlasnyProjektWlasny  5   	       ProjektWlasny.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:ProjektWlasny     5   	     � Title$  Lista uczniów��5   	   $	��450��6   $	��800��6,    � 	Resources 5	       �� 
TargetType �� Property �� Value��%�   '��       �� 5
   
   " ��6   .�5      ��  � ��$ Segoe UI)�6+   �� 5       � ��$ 14(�6)   �� 5       � ��
 � � �6,   �� 5       � ��$ 2q�60   �� 5       � ��
 � � �6+   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��621* �6   �� 5      $
��179* �6    � RowDefinitions 5   
   �� 5      $	��24* �6   �� 5      $	��31* �6   �� 5      $	��65* �6   �� 5      $
��314* �6   .+�5    
   �� $��50(�6   $��Lista uczniów��6"   $��0��67   $
��Left=�6G   $��	254,1,0,0q�6b   $	��293��6u   $��2��6�   �� 5!   
   $��1��6   $��3��6%   $��0,5,0,0q�62   .+�5"      �� -   5         ��Name$ 
addStudent��5"      $��Dodaj ucznia��6)   $��50��6@   
������6   �� 5#      -   5        $ removeStudent��5#      $��Usuń ucznia��6,   $��50��6B   
�������6~   �� 5$      -   5        $ infoStudent��5$      $"��Informacje o wybranym uczniu��6*   $��50��6Q   
����·�6�   �� 5%      -   5        $ addGrade��5%      $��Dodaj ocenę��6'   $��50��6=   
������6v   5&      &   System.Windows.Controls.DataGrid  5(   
   -   5          Name$ students��5(   �   $��3��6�   $��0��6�   	   AutoGenerateColumns$	 False��6�   $��0,5,0,0q�6�   
   Columns
 5)      0  *System.Windows.Controls.DataGridTextColumn  5*      ,  &System.Windows.Controls.DataGridColumn   Header$ Nr��6&      Width5  /System.Windows.Controls.DataGridLengthConverter$ 30 62      
IsReadOnly$
 true��6[   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   ��  �� Path$ Id�6o     5+      $ Imię��6&   $	 100 64   $
 true��6`    6@   �� $
 Name�6t     5,      $ Nazwisko��6&   $	 100 68   $
 true��6h    6D   �� $ Lastname�6|   50      `� 5P   
   $��2��6   $��1��6*   $��0,5,0,5q�67   .�5Q      c� .@�5R      �� -   5        $��Resetuj��5R      5S      �� 5T      -   5        $��Usuń ocenę��5T      5U      5V      5X      o� 5Z   
   $��20��6   $��Center=�6   $��2��66   .@�5[      m� $��_Edit��6   .@�5\      m�  m� Command$ ApplicationCommands.Copy��6   m� 5]      $ ApplicationCommands.Cut��6   m� 5^      $ ApplicationCommands.Paste��6   5_      m� 5`      $��Pomoc��6   .@�5a      m� -   5        $��Dodawanie ocen��5a      6M   5b      5c      5e      5f      