   M S B A M L   `   `   `  ����F  BFootballers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:FootballersFootballers  5   	       Footballers.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Footballers     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	       �� 
TargetType �� Property �� Value��%  '��       '�� q     '�� �     �� 5
   
   " ��6   .�5      ��  � ��$ 14(�6)   �� 5       � ��$ 5,5,5,0q�6'   5      �� 5   
   " ��6   .�5      ��  � ��$ 20(�6)   5      �� 5   
   " ��6   .�5      ��  � ��$ 5q�6'   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��3* �6   .+�5   
   �� $��0��6   
�������.+�5      �� -   5         ��Name$ textBlockName��5      $
��Name��6/   *   $Footballers.TextBoxWithErrorProvider  5      -   5          Name$ textBoxName��5       �� 5$      -   5        $ textBlockSurname��5$      $��Surname��62     5%      -   5        $ textBoxSurname��5&      �� 5*      -   5        $ textBlockHeight��5*      $��Height [cm]��61     5+      -   5        $ textBoxHeight��5,      �� 50      -   5        $ textBlockWeight��50      $��Weight [kg]��61     51      -   5        $ textBoxWeight��52      �� 56      -	   5        $��comboBoxPosition��56      $��24(�57      $��5q�58      .@�5:      �� $��
Goalkeeper��6   �� 5;      $��Defender��6   �� 5<      $��
Midfielder��6   �� 5=      $��Striker��6   5>      � 5@       5A      �� 5B      �� 5C      �� 5D      .+�5F      �� -
   5        $��	buttonAdd��5F      $	��Add��5G      5H      �� 5J      -   5        $��
buttonEdit��5J      $
��Edit��5K      $��1��5L      5M      �� 5O      -   5        $��buttonDelete��5O      $��Delete��5P      $��2��5Q      5R      5S      5T      �� 5V   
   -   5         ��Name$ listBoxFootballers��5V      $��1��5W      5X      5Y      5Z      