   M S B A M L   `   `   `  ����L  HRefaktorisaniSims, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:RefaktorisaniSimsRefaktorisaniSims  5   	       RefaktorisaniSims.Orders   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:RefaktorisaniSims     5   	     � Title$  Orders��5   	   $	��450��6   $	��430��6%   .��5	      � .+�5   
   �� -   5        $
��Add ��5      $
��Left=�6    $��293,148,0,0q�6;   $	��Top=�6P   $��75��6h   $��16(�6�   �� 5   
   -   5        $��View Orders��5      $
��Left=�6'   $��
71,180,0,0q�6B   $	��Top=�6V   $��89��6n    J� RenderTransformOrigin$ 0.2,0.45&�6�   $��16(�6�   �� 5   
   -   5        $��Update ��5      $
��Left=�6#   $��293,184,0,0q�6>   $	��Top=�6S   $��75��6k   $��16(�6�   �� 5   
   -   5        $��lvDataBinding��5   )   $��10,5,220,242q�6   ��5      �� 5      .R�5      � .+�5      �� $
��Id: ��6$   �� 5      $
��Bold"�68   ��6$   �� *Id+68   �� 5      $��, ��6$   �� 5      $��Name: ��6$   �� 5      $
��Bold"�6J   ��6$   �� *DynamicEquipmentName+6J   �� 5      $��, ��6$   �� 5      $��
Quantity: ��6$   �� 5      $
��Bold"�6>   ��6$   �� *
Quantity+6>   �� 5      $��, ��6$   �� 5      $��Date: ��6$   �� 5      $
��Bold"�6:   ��6$   �� *Date+6:   �� 5      $��, ��6$   �� 5      $��Status: ��6$   �� 5      $
��Bold"�6<   $��	Underline{�6N   
����  � � Cursor$
 Hand��6|   ��6$   �� *Status+6|   5       5!      5#      �� 5$   
   -   5        $��lvDataBinding1��5$   *   $��10,208,220,39q�6   ��5%      �� 5&      .R�5'      � .+�5(      �� $
��Id: ��6$   �� 5)      $
��Bold"�68   ��6$   �� *Id+68   �� 5*      $��, ��6$   �� 5+      $��Name: ��6$   �� 5,      $
��Bold"�6:   ��6$   �� *Name+6:   �� 5-      $��, ��6$   �� 5.      $��Date:: ��6$   �� 5/      $
��Bold"�6:   ��6$   �� *Date+6:   �� 50      $��, ��6$   �� 51      $��Status: ��6$   �� 52      $
��Bold"�6<   ��6$   �� *Status+6<   �� 53      $��, ��6$   �� 54      $��	Comment: ��6$   �� 55      $
��Bold"�6D   $��	Underline{�6V   
����  �$
 Hand��6�   ��6$   �� *WardensComment+6�   56      57      59      �� 5:   
   -   5         ��Name$ id��5:      $
��Left=�6   $��23��69   $��
282,16,0,0q�6E    �� TextWrapping$
 Wrap=�6Y   $	��Top=�6m   $	��120��6�   �� 5;   
   -   5        $ dname��5;      $
��Left=�6!   $��23��6<   $��
282,65,0,0q�6H   $
 Wrap=�6\   $	��Top=�6p   $	��120��6�   �� 5<   
   $��Id��6   $
��Left=�6   $��
217,15,0,0q�68   $	��Top=�6L   $��16(�6d   �� 5=   
   $
��Name��6   $
��Left=�6   $��
207,61,0,0q�6:   $	��Top=�6N   $��16(�6f   �� 5>   
   -   5        $��Delete��5>      $
��Left=�6"   $��27��6=   $��293,217,0,0q�6I   $	��Top=�6^   $��75��6v   $��16(�6�   �� 5?   
   $��Quantity��6   $
��Left=�6#   $��31��6>   $��205,106,0,0q�6J   $	��Top=�6_   $��72��6w   $ 0.5,0.5&�6�   $��16(�6�   z�5@      V� 5A      .~�5B      �� �� 5C      �� 5D       �� Angle$ -0.458Q�6&   T� 5E      5F      5H      �� 5I   
   -	   5        $ quantity��5I      $
��Left=�6$   $��27��6?   $��292,106,0,0q�6K   $
 Wrap=�6`   $	��Top=�6u   $��76��6�   �� 5J   
   -
   5        $
 name��5J      $
��Left=�6    $��27��6;   $��317,265,0,0q�6G   $
 Wrap=�6\   $	��Top=�6q   $��93��6�   �� 5K   
   -   5        $ status��5K      $
��Left=�6"   $��27��6=   $��317,309,0,0q�6I   $
 Wrap=�6^   $	��Top=�6s   $��93��6�   �� 5L   
   -   5        $��Search��5L      $
��Left=�6"   $��36��6=   $��286,356,0,0q�6I   $	��Top=�6^   $��78��6v   $��16(�6�   �� 5M   
   $��
Enter name��6   $
��Left=�6%   $��31��6@   $��215,262,0,0q�6L   $	��Top=�6a   $��92��6y   $ 1.063,-0.039&�6�   $��16(�6�   �� 5N   
   $��Enter status��6   $
��Left=�6'   $��31��6B   $��214,309,0,0q�6N   $	��Top=�6c   $	��104��6{   $ 1.063,-0.039&�6�   $��16(�6�   �� 5O   
   -   5        $��View Requests��5O      $
��Left=�6)   $��27��6D   $��
68,384,0,0q�6P   $	��Top=�6d   $	��111��6|   $��16(�6�   5P      5Q      