   M S B A M L   `   `   `  ����L  HRefaktorisaniSims, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:RefaktorisaniSimsRefaktorisaniSims  5   	   '    !RefaktorisaniSims.SecretaryUrgent   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:RefaktorisaniSims     5   	     � Title$  SecretaryUrgent��5   	   $	��450��6!   $	��800��6.   .��5	      � .+�5
   
   �� -   5         ��Name$ lvDataBinding3��5
   *   $��482,25,10,243q�6   ��5      �� 5      .R�5      � .+�5      �� $
��Id: ��6$   �� 5      $
��Bold"�68   ��6$   �� *Id+68   �� 5      $��, ��6$   �� 5      $��Start: ��6$   �� 5      $
��Bold"�6?   ��6$   �� *	StartTime+6?   �� 5      $�� DoctorID: ��6$   �� 5      $
��Bold"�6E   ��6$   �� *doctor.User.Id+6E   �� 5      $��, ��6$   �� 5      $��Doctor Name: ��6$   �� 5      $
��Bold"�6F   ��6$   �� *doctor.User.Name+6F   �� 5      $��, ��6$   �� 5      $��Doctor Surname: ��6$   �� 5      $
��Bold"�6I   ��6$   �� *doctor.User.Surname+6I   5      5      5      �� 5   
   -   5        $ patientsSHOW��5   *   $��482,181,10,78q�6   ��5       �� 5!      .R�5"      � .+�5#      �� $�� Id: ��6$   �� 5$      $
��Bold"�6>   ��6$   �� *	User.Id+6>   �� 5%      $��, ��6$   �� 5&      $��Name: ��6$   �� 5'      $
��Bold"�6?   ��6$   �� *	User.Name+6?   �� 5(      $��, ��6$   �� 5)      $��	Surname: ��6$   �� 5*      $
��Bold"�6B   ��6$   �� *User.Surname+6B   5+      5,      5.      �� 5/   
   -   5        $��Create Guest��5/      $
��Left=�6(   $��694,359,0,0q�6C   $	��Top=�6X   $��75��6p   6{   �� 50   
   -   5        $��
View dates��50      $
��Left=�6&   $��402,156,0,0q�6A   $	��Top=�6V   $��75��6n   6y   �� 51   
   -   5        $��View patients��51      $
��Left=�6)   $��402,321,0,0q�6D   $	��Top=�6Y   $��75��6q   6|   �� 52   
   -   5         ��Name$ specialization��52      $
��Left=�6*   $��23��6E   $��	68,62,0,0q�6Q    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��120��6�   �� 53   
   $
��Spec��6   $
��Left=�6   $��	10,59,0,0q�6:   $	��Top=�6M   �� 54   
   -   5        $	��Add��54      $
��Left=�6   $��
68,181,0,0q�6:   $	��Top=�6N   $��75��6f   6q   �� 55   
   -   5        $ 	patientID��55      $
��Left=�6%   $��23��6@   $��
68,111,0,0q�6L   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   �� 56   
   $��
Id patient��6   $
��Left=�6%   $��	0,108,0,0q�6@   $	��Top=�6S   �� 57   
   -	   5        $��Add with guest��57      $
��Left=�6*   $��
68,225,0,0q�6E   $	��Top=�6Y   $��75��6q   6|   �� 58   
   -
   5         ��Name$ labelica��58      $��Label��6"   $
��Left=�62   $��	373,0,0,0q�6M   $	��Top=�6`   $y�Hidden=�6x   59      5:      