   M S B A M L   `   `   `  ����L  HRefaktorisaniSims, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:RefaktorisaniSimsRefaktorisaniSims  5   	   4    .RefaktorisaniSims.SecretaryAppointmentPriority   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:RefaktorisaniSims     5   	     � Title$"  SecretaryAppointmentPriority��5   	   $	��450��6.   $	��800��6;   .��5	      � .+�5
   
   �� -   5         ��Name$ lvDataBinding3��5
   *   $��482,16,10,243q�6   ��5      �� 5      .R�5      � .+�5      �� $
��Id: ��6$   �� 5      $
��Bold"�68   ��6$   �� *Id+68   �� 5      $��, ��6$   �� 5      $��Start: ��6$   �� 5      $
��Bold"�6?   ��6$   �� *	StartTime+6?   �� 5      $�� DoctorID: ��6$   �� 5      $
��Bold"�6E   ��6$   �� *doctor.User.Id+6E   �� 5      $��, ��6$   �� 5      $��Doctor Name: ��6$   �� 5      $
��Bold"�6F   ��6$   �� *doctor.User.Name+6F   �� 5      $��, ��6$   �� 5      $��Doctor Surname: ��6$   �� 5      $
��Bold"�6I   ��6$   �� *doctor.User.Surname+6I   5      5      5      �� 5   
   -   5         ��Name$ textBox3��5      $
��Left=�6$   $��23��6?   $��440,316,0,0q�6K    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��120��6�   (  "System.Windows.Controls.DatePicker  5    
   -   5          Name$ datum��5       $
��Left=�6$   $��
130,76,0,0q�6?   $	��Top=�6S   $	��120��6k      FirstDayOfWeek$ Monday=�6w      SelectedDateFormat$ Short=�6�   �� 5!   
   $��Id of appointment��6   $
��Left=�6,   $��338,315,0,0q�6G   $	��Top=�6\   �� 5"   
   $��Select Start Date��6   $
��Left=�6,   $��	11,76,0,0q�6G   $	��Top=�6Z   �� 5#   
   -   5        $ textBox1��5#      $
��Left=�6$   $��23��6?   $��128,150,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   �� 5$   
   -   5        $ textBox4��5$      $
��Left=�6$   $��23��6?   $��440,344,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   �� 5%   
   $��DoctorId��6   $
��Left=�6#   $��
43,150,0,0q�6>   $	��Top=�6R   �� 5&   
   $��	PatientId��6   $
��Left=�6$   $��338,341,0,0q�6?   $	��Top=�6T     5'   
   -   5        $ datum2��5'      $
��Left=�6%   $��128,104,0,0q�6@   $	��Top=�6U   $	��120��6m   $ Monday=�6y   $ Short=�6�   �� 5(   
   $��Select Finish Date��6   $
��Left=�6-   $��	7,104,0,0q�6H   $	��Top=�6[   �� 5)   
   $��Priority��6   $
��Left=�6#   $��
52,193,0,0q�6>   $	��Top=�6R    J� RenderTransformOrigin$ 0.862,-0.333&�6j   �� 5*   
   -   5        $ textBox2��5*      $
��Left=�6$   $��23��6?   $��130,196,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   �� 5+   
   -   5        $
��View��5+      $
��Left=�6    $��173,247,0,0q�6;   $	��Top=�6P   $��75��6h   6s   �� 5,   
   -	   5        $	��Add��5,      $
��Left=�6   $��638,347,0,0q�6:   $	��Top=�6O   $��75��6g   6r   5.      5/      