   M S B A M L   `   `   `  ����L  HRefaktorisaniSims, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:RefaktorisaniSims.DoctorXAMLRefaktorisaniSims.DoctorXAML  5   	   /    )RefaktorisaniSims.DoctorXAML.Appointments   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:RefaktorisaniSims.DoctorXAML     5   	     � Title$  Appointments��5   	   $	��768��6   $
��1024��6+   .��5	      �  � RowDefinitions 5
   
   �� 5      $��45 �6   5      �� 5      $��30 �6   �� 5      $��30 �6    � ColumnDefinitions 5   
   �� 5      5      .+�5   
   � 
�������$��2��5       5      �� 5      �� 5      �� 5      �� 5       �� 5!      �� 5"      .+�5'      �� -   5        $��0��5'      $��Personal Information��5(      
�������$��16(�5)   '   $
��Bold"�65   5*      �� 5+      $��1��6   $��Appointments��5,      
�������$��16(�5-   )   $
��Bold"�67   5.      �� 5/      -   5        $��2��5/      $��Approve��50      
�������$��16(�51   (   $
��Bold"�66   52      �� 53      $��3��6   $��Request��54      
�������$��16(�55   (   $
��Bold"�66   56      �� 57      $��4��6   $��Options��58      
�������$��16(�59   (   $
��Bold"�66   5:      �� 5;      -   5        $��Translate to Serbian��5;      $
��Left=�64   $��37��6O   $��27,6,0,0q�6[   $	��Top=�6m   $	��111��6�   
����������	#FF1FBBB4
�������$��5��6�   5?      � 5@   
   
�������$��1��5A       5C      �� 5D      �� 5E      �� 5F      �� 5G      �� 5H      �� 5I      .+�5M      �� -   5        $��0��5M      $��Termin��5N      
�������$��16(�5O   (   $
��Bold"�66   5P      �� 5Q      -   5        $��1��5Q      $��Prescribe medition��5R      
�������$��16(�5S   (   $
��Bold"�66   5T      �� 5U      $��2��6   $��Referral��5V      
�������$��16(�5W   (   $
��Bold"�66   5X      �� 5Y      $��3��6   $��Diagnose��5Z      
�������$��16(�5[   (   $
��Bold"�66   5\      5^      �� 5_   
   
���   �$��1q�6%   $
��Left=�69   $	��660��6T   $��
0,0,0,-629q�6a   $��2��6u   $	��Top=�6�   $	��537��6�   5a      �� 5b   
   $��Address:��6   $
��Left=�6#   $��28��6>   $��10,311,0,-308q�6J   $��2��6a   $	��Top=�6n   $��16(�6�   $
��Bold"�6�   �� 5c   
   $��Phone:��6   $
��Left=�6!   $��28��6<   $��10,261,0,-258q�6H   $��2��6_   $	��Top=�6l   $��16(�6�   $
��Bold"�6�   �� 5d   
   $��Surname:��6   $
��Left=�6#   $��28��6>   $��10,213,0,-210q�6J   $��2��6a   $	��Top=�6n   $��16(�6�   $
��Bold"�6�   �� 5e   
   $��
Firstname:��6   $
��Left=�6%   $��28��6@   $��10,163,0,-160q�6L   $��2��6c   $	��Top=�6p   $��16(�6�   $
��Bold"�6�   �� 5f   
   $��Info about patient:��6   $
��Left=�6.   $��40��6I   $��10,103,0,-112q�6U   $��2��6l   $	��Top=�6y   $��18(�6�   $
��Bold"�6�   �� 5g   
   $��Appointment ID:��6   $
��Left=�6*   $��37��6E   $��186,31,0,-37q�6Q   $��2��6g   $	��Top=�6t   $��20(�6�   $
��Bold"�6�   �� 5h   
   -   5         ��Name$
 name��5h      $��/��6   $
��Left=�6*   $��28��6E   $��250,163,0,-160q�6Q   $��2��6i   $	��Top=�6v   $��16(�6�   $
��Bold"�6�   �� 5i   
   -   5        $ surname��5i      $��/��6!   $
��Left=�6-   $��28��6H   $��250,213,0,-210q�6T   $��2��6l   $	��Top=�6y   $��16(�6�   $
��Bold"�6�   �� 5j   
   -   5        $ phone��5j      $��/��6   $
��Left=�6+   $��28��6F   $��250,261,0,-258q�6R   $��2��6j   $	��Top=�6w   $��16(�6�   $
��Bold"�6�   �� 5k   
   -	   5        $ address��5k      $��/��6!   $
��Left=�6-   $��28��6H   $��250,311,0,-308q�6T   $��2��6l   $	��Top=�6y   $��16(�6�   $
��Bold"�6�   �� 5l   
   -
   5        $ appId��5l      $��/��6   $
��Left=�6+   $��37��6F   $��377,31,0,-37q�6R   $��2��6h   $	��Top=�6u   $��20(�6�   $
��Bold"�6�   �� 5m   
   -   5         ��Name$ bindingApps��5m   ,   $��537,233,15,-551q�6   $��2��6A   ��5n      �� 5o      .R�5p      � .+�5q      �� $
��Id: ��6$   �� 5r      $
��Bold"�68   ��6$   �� *Id+68   �� 5s      $��, ��6$   �� 5t      $��Start: ��6$   �� 5u      $
��Bold"�6?   ��6$   �� *	StartTime+6?   �� 5v      $�� Duration: ��6$   �� 5w      $
��Bold"�6?   ��6$   �� *
Duration+6?   �� 5x      $�� minutes��6$   �� 5y      $��, ��6$   �� 5z      $��PatientID: ��6$   �� 5{      $
��Bold"�6E   ��6$   �� *patient.User.Id+6E   �� 5|      $��, ��6$   �� 5}      $��	Patient: ��6$   �� 5~      $
��Bold"�6G   ��6$   �� *patient.User.Name+6G   5      5�      5�      (  "System.Windows.Controls.DatePicker  5�   
   -   5          Name$
 date��5�      $
��Left=�6#   $	��100��6>   $��835,18,0,-87q�6K   $��2��6a   $	��Top=�6n   �� 5�   
   -   5        $
��Show��5�      $
��Left=�6    $��36��6;   $��835,125,0,-130q�6G   $��2��6_   $	��102��6m   $
��Bold"�6�   �� 5�   
   -   5        $��Select��5�      $
��Left=�6"   $��40��6=   $��901,587,0,-596q�6I   $��2��6a   $	��Top=�6n   $	��100��6�   $
��Bold"�6�   �� 5�   
   $��SELECT APPOINTMENT:��6   $
��Left=�6.   $��33��6I   $��537,200,0,-202q�6U   $��2��6m   $	��Top=�6z   $
��Bold"�6�   $��16(�6�   �� 5�   
   $(��"Select a date to see appointments:��6   $
��Left=�6=   $��34��6X   $��542,13,0,-16q�6d   $��2��6z   $	��Top=�6�   $��16(�6�   $
��Bold"�6�   �� 5�   
   -   5        $��HospitalTreatment��5�      $
��Left=�6-   $��36��6H   $��332,414,0,-419q�6T   $	��Top=�6l   $��95��6�   $��2��6�   �� 5�   
   -   5        $��Button��5�      $
��Left=�6"   $��33��6=   $��430,158,0,-160q�6I   $��2��6a   $	��Top=�6n   $��72��6�   6�   5�      5�      