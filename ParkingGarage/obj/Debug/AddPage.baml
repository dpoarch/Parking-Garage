   M S B A M L   `   `   `  ����H  DParkingGarage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ParkingGarageParkingGarage  5   	       ParkingGarage.AddPage   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:ParkingGarage     5   	     � Title$  Add Vehicle On Parking��5   	   $	��450��6(   $	��800��65   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��19* �6   �� 5      $	��29* �6   �� 5      $
��744* �6   .+�5   
   �� $��Plate Number��6   $
��Left=�6'   $��297.182,52,0,0q�6B   $	��Top=�6Z   $��2��6r   �� 5   
   -   5         ��Name$ plateNumber��5      $
��Left=�6'   $��23��6B   $��297.182,78,0,0q�6N    �� TextWrapping$
 Wrap=�6f   $	��Top=�6z   $	��120��6�    J� RenderTransformOrigin$ 0.035,-1.075&�6�   $��2��6�   �� 5   
   -   5         ��Name$ vehicleType��5      $
��Left=�6(   $��297.182,147,0,0q�6C   $	��Top=�6\   $	��120��6t   $��2��6�    �� SelectedIndex$ 0��6�   .@�5      �� $��Motorcycle Spot��6   �� 5      $��Compact Spot��6   �� 5      $��
Large Spot��6   5      �� 5   
   $��Vehicle Type��6   $
��Left=�6'   $��297.182,121,0,0q�6B   $	��Top=�6[   $	��120��6s   $��2��6   �� 5   
   -   5        $ parkingGarage��5      $
��Left=�6*   $��297.182,222,0,0q�6E   $	��Top=�6^   $	��120��6v   $ -0.247,0.537&�6�   $��2��6�   $ 0��6�   �� 5   
   $��Parking Garage��6   $
��Left=�6)   $��297.182,196,0,0q�6D   $	��Top=�6]   $ -0.545,-0.115&�6u   $��99��6�   $��2��6�   �� 5   
   -   5        $	��Add��5      $
��Left=�6   $��321.182,280,0,0q�6:   $	��Top=�6S   $��75��6k   $��2��6v   6�   �� 5   
   -   5         ��Name$ lblError��5      $��2��6"   $��Center=�62   $��370,37,364,0q�6O   $	��Top=�6e   $ -0.402,-0.056&�6}   5      5      