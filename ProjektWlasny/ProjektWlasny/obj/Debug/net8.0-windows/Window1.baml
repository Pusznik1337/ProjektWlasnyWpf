   M S B A M L   `   `   `  ����H  DProjektWlasny, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ProjektWlasnyProjektWlasny  5   	       ProjektWlasny.Window1   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:ProjektWlasny     5   	     � Title$  Dodawanie ucznia��5   	   $	��450��6"   $	��800��6/   .��5	      � .+�5
   
   o� $��20��6   $	��Top=�6   .@�5      m� $��_Edit��6   .@�5      m�  m� Command$ ApplicationCommands.Copy��6   m� 5      $ ApplicationCommands.Cut��6   m� 5      $ ApplicationCommands.Paste��6   5      5      � 5   
    � Orientation$ Vertical=�6   $��Center=�6+   .+�5      �� $"��Dodaj nowego ucznia do listy��6   $��50(�6<   
�������6_   �� 5      $��Imię:��6   $��30(�6$   64   �� 5      -   5         ��Name$ 	nameInput��5      $��30��6)   $	��300��65   $��1q�6A   $
��Left=�6U   6�   �� 5      $��	Nazwisko:��6   $��30(�6(   68   �� 5      -   5        $ lastnameInput��5      $��30��6-   $	��300��69   $��1q�6E   $
��Left=�6Y   6v   �� 5      $��PESEL:��6   $��30(�6%   65   �� 5      -   5        $ 
peselInput��5      $��30��6*   $	��300��66   $��1q�6B   $
��Left=�6V   6s   �� 5      -   5         ��Name$ 
addStudent��5      $��
Potwierdź��6)   $��50��6=   $	��150��6I   $��0 20 0 0q�6U   $
��Left=�6g   
�������6�   5      5      5      