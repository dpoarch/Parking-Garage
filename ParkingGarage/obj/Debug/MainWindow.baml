   M S B A M L   `   `   `  ����H  DParkingGarage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ParkingGarageParkingGarage  5   	       ParkingGarage.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:ParkingGarage     5   	     � Title$  Parking Garage��5   	   $	��450��6    $	��800��6-   .��5	      � .+�5
   
   �� -   5         ��Name$ selector��5
      $
��Left=�6%   $��	55,12,0,0q�6@   $	��Top=�6S   $	��120��6k    �� SelectedIndex$ 0��6w   4  .System.Windows.Automation.AutomationProperties   Name$ selector��6�   .@�5      �� $��Parked Vehicles��6   �� 5      $��Available Parking Garage��6   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
ParkedGrid��5      $
��Left=�6'   $	��368��6B   $��	10,41,0,0q�6O   $	��Top=�6b   $	��772��6z   $ 
ParkedGrid��6�   �� 5   
   -   5        $��Park New Vehicle��5      $
��Left=�6,   $��
650,10,0,0q�6G   $	��Top=�6[   $	��132��6s    J� RenderTransformOrigin$ 0.061,-0.184&�6   6�   �� 5   
   $��Filter��6   $
��Left=�6!   $��	10,10,0,0q�6<   $	��Top=�6O   $ -5.957,-0.101&�6g   5      5      