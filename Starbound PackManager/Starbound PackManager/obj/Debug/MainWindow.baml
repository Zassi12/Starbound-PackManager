   M S B A M L   `   `   `  ����P  LStarbound PackManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Starbound_PackManagerStarbound_PackManager  5   	   &     Starbound_PackManager.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:Starbound_PackManager     5   	     � Title$  
MainWindow��5   	   $��384.758��6   $��638.972��6-   .��5	      � $��0,0,0.8,-1.8q�6    � ColumnDefinitions 5
   
   �� 5      $	��86* �6   �� 5      $	��87* �6   .+�5   
   �� -   5         ��Name$ 
OutputPath��5      $
��Left=�6&   $��46��6A   $��
10,102,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $��Destination��6u   $	��Top=�6�   $	��498��6�   $��2��6�   �� 5   
   -   5        $ 	InputPath��5      $
��Left=�6%   $��46��6@   $��	10,31,0,0q�6L   $
 Wrap=�6_   $��Source��6s   $	��Top=�6�   $	��498��6�   $��2��6�   �� 5   
   -   5         ��Name$ OutputLabel��5      $
��Left=�6)   $��	10,86,0,0q�6D   $
��Wrap=�6W   $	��Top=�6k   $��16��6�   $	��294��6�   �� 6�   $�Destination��6�   �� 6�   $�:��6�   6�   �� 5   
   -   5        $ 
InputLabel��5      $
��Left=�6(   $��	10,15,0,0q�6C   $
��Wrap=�6V   $	��Top=�6j   $��16��6�   $	��304��6�   �� 6�   $�Source��6�   �� 6�   $�:��6�   6�   �� 5   
   -   5         ��Name$ Unpack��5      $��Unpack��6!   $
��Left=�6G   $��
27,174,0,0q�6b   $	��Top=�6v   $	��127��6�   $��39��6�   �� 5   
   -   5         ��Name$ 	Rectangle��5       J� 	AllowDrop . 
�������
���   �$
��Left=�6�   $	��173��6�   $��244,174,0,0q�6�   $	��Top=�6  $	��378��6(  $��2��64  �� 5   
   -   5         ��Name$ DropBoxLabel��5      	 J� IsManipulationEnabled	 .  $��Drop File Here��6E   $
��Left=�6�   $��72.6,252,0,0q�6�   $	��Top=�6   
 J� RenderTransformOrigin$
 -0.12,0.117&�6  $��25��6<  $��86��6H  $��1��6S  �� 5   
   -   5        $ label��5      $��Label��6   $
��Left=�6/   $��
10,265,0,0q�6J   $	��Top=�6^   $	��190��6v   5      5      