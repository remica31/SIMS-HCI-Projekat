   M S B A M L   `   `   `  ����L  HRefaktorisaniSims, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:RefaktorisaniSimsRefaktorisaniSims  5   	   4    .RefaktorisaniSims.DoctorCreateHospitalReferral   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:RefaktorisaniSims     5   	     � Title$"  DoctorCreateHospitalReferral��5   	   $	��450��6.   $	��800��6;   .��5	      � .+�5
   
   �� -   5        $��lvDataBinding��5
   (   $��436,0,3,223q�6   ��5      �� 5      .R�5      � .+�5      �� $
��Id: ��6$   �� 5      $
��Bold"�6=   ��6$   �� *	User.Id+6=   �� 5      $��, ��6$   �� 5      $��Name: ��6$   �� 5      $
��Bold"�6?   ��6$   �� *	User.Name+6?   �� 5      $��, ��6$   �� 5      $��	Surname: ��6$   �� 5      $
��Bold"�6B   ��6$   �� *User.Surname+6B   5      5      5      �� 5   
   -   5        $��Create��5      $
��Left=�6"   $��305,331,0,0q�6=   $	��Top=�6R   $��75��6j   6u   �� 5   
   -   5         ��Name$ fromIdD��5      $
��Left=�6#   $��23��6>   $��142,153,0,0q�6J    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��120��6�   �� 5   
   -   5        $ toIdD��5      $
��Left=�6!   $��23��6<   $��142,204,0,0q�6H   $
 Wrap=�6]   $	��Top=�6q   $	��120��6�   �� 5   
   $��FromDoctorId��6   $
��Left=�6'   $��
27,148,0,0q�6B   $	��Top=�6V   �� 5   
   $��
ToDoctorId��6   $
��Left=�6%   $��
27,199,0,0q�6@   $	��Top=�6T   �� 5   
   $��Explanation��6   $
��Left=�6&   $��
27,243,0,0q�6A   $	��Top=�6U   �� 5    
   $��	PatientId��6   $
��Left=�6$   $��
27,277,0,0q�6?   $	��Top=�6S   �� 5!   
   -   5        $ explanation��5!      $
��Left=�6'   $��23��6B   $��142,248,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��120��6�   �� 5"   
   -   5        $ 	patientId��5"      $
��Left=�6%   $��23��6@   $��142,281,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   �� 5#   
   -   5        $ specializationType��5#      $
��Left=�6.   $��23��6I   $��
142,13,0,0q�6U   $
 Wrap=�6i   $	��Top=�6}   $	��120��6�   �� 5$   
   $��Specialization��6   $
��Left=�6)   $��	27,10,0,0q�6D   $	��Top=�6W    J� RenderTransformOrigin$ 0.241,0.427&�6o   �� 5%   
   -   5        $��Search��5%      $
��Left=�6"   $��
305,16,0,0q�6=   $	��Top=�6Q   $��75��6i   6t   �� 5&   
   -	   5         ��Name$ lvDataBinding_Show��5&   )   $��436,199,3,29q�6   ��5'      �� 5(      .R�5)      � .+�5*      �� $
��Id: ��6$   �� 5+      $
��Bold"�68   ��6$   �� *Id+68   �� 5,      $��, ��6$   �� 5-      $��Explanation: ��6$   �� 5.      $
��Bold"�6A   ��6$   �� *Explanation+6A   �� 5/      $��, ��6$   �� 50      $��Id Doctor: ��6$   �� 51      $
��Bold"�6@   ��6$   �� *
ToDoctorId+6@   52      53      55      �� 56   
   -
   5        $
��Show��56      $
��Left=�6    $��583,395,0,0q�6;   $	��Top=�6P   $��75��6h   6s   59      5:      