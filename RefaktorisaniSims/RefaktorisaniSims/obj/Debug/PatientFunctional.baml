   M S B A M L   `   `   `  ����L  HRefaktorisaniSims, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:RefaktorisaniSimsRefaktorisaniSims  5   	   )    #RefaktorisaniSims.PatientFunctional   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:RefaktorisaniSims     5   	     � Title$  PatientFunctional��5   	   $	��450��6#   $	��800��60   ��5	      �� 5
   
    �� EndPoint$ 0.5,1&�6    � MappingMode$ RelativeToBoundingBox=�6/    �� 
StartPoint$ 0.5,0&�6S   .��5      �  � Color$ 	#FF159E9E��6   � 5      $ 	#FF44B280��6    � Offset$ 0.752Q�6-   5      .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5       � ColumnDefinitions 5   
   �� 5      $	��307 �6   �� 5      $
��317* �6   �� 5      $
��168* �6   .+�5   
   �� $��0��6   .+�5       �� $��Patient - profile��6   $��40(�5!      $��Medium"�5"      $��15,0,0,0q�5#      5%      �� 5'   
   $��1��6   .+�5(      �� $	��200��6   $
��Left=�6%   �� 5*      $	��150��6   $	��150��6!   $
��Left=�5+      $��20q�5,       �� CornerRadius$ 10��6%   ��5-      �� 5.      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5/      � $ 	#FF44B280��6'   $ 1Q�69   � 50      $ White��6'   $ 0.453Q�65   51      ._�53      �� $����Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque neque leo, ornare ac congue at, fermentum sit amet mi. Nullam ornare maximus ultrices. ��54      $
��Wrap=�55      $��5q�56      5;      �� 5<      $�� Patient Description��5=      $��15(�5>      $��Medium"�5?      $	��150��5@      $
��Left=�5A      $��20,0,0,0q�5B      5D      �� 5G   
   $��1��6   $��1��6"   .+�5H      �� $ 15��6   $��5q�6(   $��	58,5,26,5q�5I      $	��178��6%   ��5J      �� 5K      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5L      � $ 	#FF44B280��6'   $ 1Q�69   � 5M      $ White��6'   5N      ._�5Q      �� $��0,0,0,5q�6   .+�5X      �� $��	Therapies��6    $��30(�5Y      $��0,5,0,0q�5Z      $��Center=�5[      $��Center=�5\      5�      5�      &   System.Windows.Controls.Calendar  5�      $��	58,0,26,0q�6   5�      �� 5�   
   $��2��6   ���#353b485�      �� 5�   
   $��1��6   $��2��6"   ���#353b48.+�5�      �� -   5        $��CRUD Appointments��5�      $
��Left=�61   $��40��5�      $	��Top=�6!   $	��150��5�      ���#353b48���	#FF353B48
�������5�      �� 5�      -   5        $"��Create Appointment(priority)��5�      $��11(�5�      $��40��6#   $
��Left=�6/   $	��Top=�5�      $	��150��6-   ���#353b48���	#FF353B48
�������5�      �� 5�      -   5        $��Survey��5�      $
��Left=�6&   $��40��5�      $	��Top=�6!   $	��150��5�      ���	#FF353B48���#353b48
�������5�      �� 5�      -   5        $��CreateAppByReferral��5�      $��40��5�      $
��Left=�5�      $	��Top=�60   $	��150��5�      ���#353b48���	#FF353B48
�������5�      �� 5�      -   5        $��Medical Record��5�      $��40��5�      $
��Left=�5�      $	��Top=�61   $	��150��5�      ���	#FF353B48
����������	#FF353B485�   (   �� 5�      -   5        $��	Make Note��5�      $
��Left=�5�      $	��Top=�5�      $	��150��5�      $��40��5�      ���#353b48���	#FF353B48
�������5�      5�      5�      5�      