   M S B A M L   `   `   `  ����L  HRefaktorisaniSims, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:RefaktorisaniSimsRefaktorisaniSims  5   	   K*clr-namespace:RefaktorisaniSims.ValidationRefaktorisaniSims.Validation  67   2    ,RefaktorisaniSims.PatientAppointmentPriority   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:RefaktorisaniSims     5   	   =local1*clr-namespace:RefaktorisaniSims.Validation     67     � Title$   PatientAppointmentPriority��5   	   $	��540��6,   $	��850��69   ��5
      �� 5   
    �� EndPoint$ 0.5,1&�6    � MappingMode$ RelativeToBoundingBox=�6/    �� 
StartPoint$ 0.5,0&�6S   .��5      �  � Color$ 	#FF159E9E��6   � 5      $ 	#FF44B280��6    � Offset$ 0.752Q�6-   5      .��5      � $��-1,0,1,0q�6   .+�5   
   �� -   5         ��Name$ lvDataBinding3��5   C   $��423,16,10,200q�6   $	��250��6*   $	��300��67   ��5      �� 5      .R�5      � .+�5      �� $
��Id: ��6$   �� 5      $
��Bold"�68   ��6$   �� *Id+68   �� 5      $��, ��6$   �� 5      $��Start: ��6$   �� 5      $
��Bold"�6?   ��6$   �� *	StartTime+6?   �� 5      $�� DoctorID: ��6$   �� 5      $
��Bold"�6E   ��6$   �� *doctor.User.Id+6E   �� 5      $��, ��6$   �� 5      $��Doctor Name: ��6$   �� 5      $
��Bold"�6F   ��6$   �� *doctor.User.Name+6F   �� 5      $��, ��6$   �� 5       $��Doctor Surname: ��6$   �� 5!      $
��Bold"�6I   ��6$   �� *doctor.User.Surname+6I   5"      5#      5%      �� 5&   
   -   5         ��Name$ textBox3��5&      $
��Left=�6$   $��23��6?   $��658,331,0,0q�6K    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��120��6�   .��6�   	 =� ErrorTemplate	 5'      �� 5(      .R�5)      �� .+�5*      �� �� 5+      
���  ����6$   �� *[0].ErrorContent+6F   5,      5-      .��5.   (   ��5/      �� 50      
 �� Path$
 Test3�6    �� UpdateSourceTrigger$ PropertyChanged=�6'    �� ValidationRules 51      +   %RefaktorisaniSims.Validation.IsNumber  52      ,  &System.Windows.Controls.ValidationRule   ValidationStep$ RawProposedValue=�6*   54      .��56      59      (  "System.Windows.Controls.DatePicker  5;   
   -   5          Name$ datum��5;      $
��Left=�6$   $��
160,68,0,0q�6?   $	��Top=�6S   $	��120��6k      FirstDayOfWeek$ Monday=�6w      SelectedDateFormat$ Short=�6�     5<   
   -   5        $ datum2��5<      $
��Left=�6&   $��159,105,0,0q�6A   $	��Top=�6V   $	��120��6n   $ Monday=�6z   $ Short=�6�   �� 5>   
   $��25��6   $	��120��6    �� CornerRadius$ 10��6)   
�������$��459,286,213,108q�6N   ._�5?      �� $��Id of appointment��6   $��Center=�60   $��Center=�6N   5@      �� 5B   
   $��25��6   $	��120��6   $ 10��6*   
�������$��10,71,662,413q�6O   ._�5C      �� $��Select Start Date��6   $��Center=�60   $��center=�6N   5D      �� 5F   
   -   5        $ textBox1��5F      $
��Left=�6$   $��27��6?   $��160,140,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   �� 5I   
   -   5        $ textBox4��5I      $
��Left=�6$   $��23��6?   $��658,374,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   .��6�   	 5J      �� 5K      .R�5L      �� .+�5M      �� �� 5N      
���  ����6$   �� *[0].ErrorContent+6F   5O      5P      .��5Q   (   ��5R      �� 5S      $
 Test3�6   $ PropertyChanged=�6'    5T        5U      $ RawProposedValue=�6*   5W      .��5Y      5\      �� 5^   
   $��25��6   $	��120��6   $ 10��6*   
�������$��10,144,662,340q�6O   ._�5_      �� $��	Doctor Id��6   $��Center=�6(   $��Center=�6F   5`      �� 5b   
   $��25��6   $	��120��6   $ 10��6*   
�������$��459,329,213,65q�6O   ._�5c      �� $��
Patient Id��6   $��Center=�6)   $��Center=�6F   5d      �� 5h   
   $��25��6   $	��120��6   $ 10��6*   
�������$��10,107,662,377q�6O   ._�5i      �� $��Select Finish Date��6   $
��Left=�61   $	��Top=�6M   $��7,0,0,0q�6e   5j      �� 5l   
   $��25��6   $	��120��6   $ 10��6*   
�������$��10,190,662,294q�6O   ._�5m      �� $��Priority��6   $��Center=�6'   $��Center=�6E   5n      �� 5p   
   -   5        $ textBox2��5p      $
��Left=�6$   $��27��6?   $��160,186,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   �� 5s   
   -   5        $
��View��5s      $
��Left=�5t      $��205,232,0,0q�5u      $	��Top=�5v      $��75��5w      $��28��5y       � 	Resources 5z       �� 
TargetType �� Property �� Value��%_   '��       �� 5{      " ��6   .�5|      ��  �@��CornerRadius$ 10��65   5}      5~      5      �� 5�   
   -	   5        $	��Add��5�      $
��Left=�5�      $��703,411,0,0q�5�      $	��Top=�5�      $��75��5�      $��28��5�       5�      ��%_   '��       �� 5�      " ��6   .�5�      ��  �@��CornerRadius$ 10��65   5�      5�      5�      5�      5�      