   M S B A M L   `   `   `  ����L  HRefaktorisaniSims, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:RefaktorisaniSims.DoctorXAMLRefaktorisaniSims.DoctorXAML  5   	   -    'RefaktorisaniSims.DoctorXAML.PrepisiLek   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:RefaktorisaniSims.DoctorXAML     5   	     � Title$  
PrepisiLek��5   	   $	��768��6   $
��1024��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��45 �6   5      �� 5      $��30 �6   �� 5      $��30 �6    � ColumnDefinitions 5   
   �� 5      5      .+�5   
   � 
�������$��2��5       5      �� 5      �� 5      �� 5      �� 5       �� 5!      �� 5"      .+�5'      �� -   5        $��0��5'      $��Licne informacije��5(      
�������$��16(�5)   '   $
��Bold"�65   5*      �� 5+      $��1��6   $��Pregledi��5,      
�������$��16(�5-   )   $
��Bold"�67   5.      �� 5/      -   5        $��2��5/      $��Odobri lekove��50      
�������$��16(�51   (   $
��Bold"�66   52      �� 53      $��3��6   $��Zahtevi��54      
�������$��16(�55   (   $
��Bold"�66   56      �� 57      $��4��6   $��Opcije��58      
�������$��16(�59   (   $
��Bold"�66   5:      5>      � 5?   
   
�������$��1��5@       5B      �� 5C      �� 5D      �� 5E      �� 5F      �� 5G      �� 5H      .+�5L      �� -   5        $��0��5L      $��Termin��5M      
�������$��16(�5N   '   $
��Bold"�65   5O      �� 5P      $��1��6   $��Prepisi lekove��5Q      
�������$��16(�5R   )   $
��Bold"�67   5S      �� 5T      $��2��6   $
��Uput��5U      
�������$��16(�5V   (   $
��Bold"�66   5W      �� 5X      $��3��6   $��	Dijagnoza��5Y      
�������$��16(�5Z   (   $
��Bold"�66   5[      5]      �� 5^   
   
���   �$��1q�6%   $
��Left=�69   $	��660��6T   $��
0,0,0,-629q�6a   $��2��6u   $	��Top=�6�   $	��537��6�   ._�5_      �� -   5         ��Name$ lvDataBinding��5_   .   $��9,172,197,108q�6   ��5`      �� 5a      .R�5b      � .+�5c      �� $
��Id: ��6(   �� 5d      $
��Bold"�6<   ��6(   �� *Id+6<   �� 5e      $��, ��6(   �� 5f      $��Name: ��6(   �� 5g      $
��Bold"�6>   ��6(   �� *Name+6>   �� 5h      $�� Description: ��6(   �� 5i      $
��Bold"�6F   ��6(   �� *Description+6F   �� 5j      $��, ��6(   �� 5k      $��Ingredients: ��6(   �� 5l      $
��Bold"�6E   ��6(   �� *Ingredients+6E   5m      5n      5p      5r      �� 5s   
   $��Pregled ID:��6   $
��Left=�6&   $��37��6A   $��186,31,0,-37q�6M   $��2��6c   $	��Top=�6p   $��20(�6�   $
��Bold"�6�   �� 5t   
   -   5         ��Name$ appId��5t      $��/��6   $
��Left=�6+   $��37��6F   $��377,31,0,-37q�6R   $��2��6h   $	��Top=�6u   $��20(�6�   $
��Bold"�6�   �� 5u   
   -   5        $��Translate to English��5u      $
��Left=�60   $��37��6K   $��	874,6,0,0q�6W   $	��Top=�6j   $	��111��6�   
����������	#FF1FBBB4
�������6�   �� 5v   
   $��Lista lekova:��6   $
��Left=�6(   $��37��6C   $��10,94,0,-100q�6O   $	��Top=�6e   $��18(�6}   $
��Bold"�6�   $��2��6�   �� 5w   
   $��Kolicina��6   $
��Left=�6#   $��37��6>   $��377,215,0,-221q�6J   $��2��6b   $	��Top=�6o   �� 5x   
   -   5         ��Name$ instruction��5x      $
��Left=�6'   $��23��6B   $��377,372,0,-364q�6N   $��2��6f    �� TextWrapping$
 Wrap=�6s   $	��Top=�6�   $	��120��6�   �� 5y   
   -   5        $ quantity��5y      $
��Left=�6$   $��23��6?   $��377,267,0,-259q�6K   $��2��6c   $
 Wrap=�6p   $	��Top=�6�   $	��120��6�   �� 5z   
   $��Instrukcije��6   $
��Left=�6&   $��30��6A   $��377,320,0,-319q�6M   $��2��6e   $	��Top=�6r   �� 5{   
   -	   5        $��Prepisi��5{      $
��Left=�6#   $��40��6>   $��358,497,0,-506q�6J   $��2��6b   $	��Top=�6o   $��75��6�   6�   5}      5~      