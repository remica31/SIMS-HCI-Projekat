   M S B A M L   `   `   `  ����L  HRefaktorisaniSims, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:RefaktorisaniSimsRefaktorisaniSims  5   	   K*clr-namespace:RefaktorisaniSims.ValidationRefaktorisaniSims.Validation  67   '    !RefaktorisaniSims.PatientReferral   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:RefaktorisaniSims     5   	   =local1*clr-namespace:RefaktorisaniSims.Validation     67     � Title$  PatientReferral��5   	   $	��450��6!   $	��800��6.   ��5
      �� 5   
    �� EndPoint$ 0.5,1&�6    � MappingMode$ RelativeToBoundingBox=�6/    �� 
StartPoint$ 0.5,0&�6S   .��5      �  � Color$ 	#FF159E9E��6   � 5      $ 	#FF44B280��6    � Offset$ 0.752Q�6-   5      .��5      � .+�5   
   �� -   5        $	��Add��5      $
��Left=�6   $��253,143,0,0q�6:   $	��Top=�6O   $��75��6g   6r   �� 5   
   -   5         ��Name$ lvDataBinding_Show��5   *   $��10,205,429,23q�6   ��5      �� 5      .R�5      � .+�5      �� $
��Id: ��6$   �� 5      $
��Bold"�68   ��6$   �� *Id+68   �� 5      $��, ��6$   �� 5      $��Explanation: ��6$   �� 5      $
��Bold"�6A   ��6$   �� *Explanation+6A   �� 5      $��, ��6$   �� 5       $��Id Doctor: ��6$   �� 5!      $
��Bold"�6@   ��6$   �� *
ToDoctorId+6@   5"      5#      5%      �� 5&   
   -   5        $ lvDataBinding3��5&   )   $��551,36,10,94q�6   ��5'      �� 5(      .R�5)      � .+�5*      �� $
��Id: ��6$   �� 5+      $
��Bold"�68   ��6$   �� *Id+68   �� 5,      $��, ��6$   �� 5-      $��Start: ��6$   �� 5.      $
��Bold"�6?   ��6$   �� *	StartTime+6?   �� 5/      $�� DoctorID: ��6$   �� 50      $
��Bold"�6E   ��6$   �� *doctor.User.Id+6E   �� 51      $��, ��6$   �� 52      $��Doctor Name: ��6$   �� 53      $
��Bold"�6F   ��6$   �� *doctor.User.Name+6F   �� 54      $��, ��6$   �� 55      $��Doctor Surname: ��6$   �� 56      $
��Bold"�6I   ��6$   �� *doctor.User.Surname+6I   57      58      5:      �� 5;   
   -   5        $��View referrals��5;      $
��Left=�6*   $��253,109,0,0q�6E   $	��Top=�6Z   $	��100��6r   $��15(�6~   6�   �� 5<   
   -   5         ��Name$ textBox1��5<      $
��Left=�6$   $��23��6?   $��110,112,0,0q�6K    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��120��6�   .��6�   	 =� ErrorTemplate	 5=      �� 5>      .R�5?      �� .+�5@      �� �� 5A      
���  ����6$   �� *[0].ErrorContent+6F   5B      5C      .��5D   (   ��5E      �� 5F      
 �� Path$
 Test3�6    �� UpdateSourceTrigger$ PropertyChanged=�6'    �� ValidationRules 5G      +   %RefaktorisaniSims.Validation.IsNumber  5H      ,  &System.Windows.Controls.ValidationRule   ValidationStep$ RawProposedValue=�6*   5J      .��5L      5N      �� 5O   
   $��ID of patient��6   $
��Left=�6(   $��
25,109,0,0q�6C   $	��Top=�6W    J� RenderTransformOrigin$ -0.168,0.978&�6o   �� 5P   
   -   5        $ textBox2��5P      $
��Left=�6$   $��23��6?   $��110,140,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   �� 5Q   
   -   5        $��View available dates��5Q      $
��Left=�60   $��637,330,0,0q�6K   $	��Top=�6`   $	��130��6x   $��13(�6�   6�   �� 5R   
   $��
ID of Date��6   $
��Left=�6%   $��
25,140,0,0q�6@   $	��Top=�6T   �� 5S   
   $��Referral��6   $
��Left=�6#   $��	10,10,0,0q�6>   $��40(�6Q   $	��Top=�6_   5U      5V      