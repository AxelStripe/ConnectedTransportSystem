   M S B A M L   `   `   `  ����Z  VConnectedTransportSystem_Adrian, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:ConnectedTransportSystem_AdrianConnectedTransportSystem_Adrian  5      0    *ConnectedTransportSystem_Adrian.choosePaym   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:ConnectedTransportSystem_Adrian     5        � Title$  
choosePaym��5      $	��450��6   $	��800��6'   .��5
      � ��5   
   �� 5       �� ImageSource$ images\background.png��6   .+�5   
   � $
��Left=�6   $��61��6*   $��	75,10,0,0q�66   $	��Top=�6I   $	��649��6a   .+�5      �� -   5         ��Name$ 	pageTitle��5      $��payment method��6'   $
��Left=�6@   $��Center=�6[   $��10,0,0,0q�6   $	��Top=�6�   $	��629��6�   $��51��6�   ���	#FFFDF9F9$��36(�6�   $��Perpetua Titling MT)�6�   5      � 5   
   $
��Left=�6   $	��199��6*   $��
10,114,0,0q�67   $	��Top=�6K   $	��774��6c   .+�5      �� $
��Left=�6   $��	290,0,0,0q�63   $
��Wrap=�6F   $ ��How would you like to pay?��6Z   $	��Top=�6|   ���	#FFFDFBFB$��16(�6�   �� 5      -   5         ��Name$ imgCash��5      $��images\cashI.jpg��6%   $��66,38,508,10q�6?   6�   �� 5      -   5        $ imgCard��5      $��images\cardI.jpg��6%   $��285,38,289,10q�6?   6�   �� 5      -   5        $ 	imgPayPal��5      $��images\paypalI.jpg��6'   $��509,38,65,10q�6C   $
��Fill=�6Y   6�   5      � 5   
   $
��Left=�6   $��61��6*   $��
10,343,0,0q�66   $	��Top=�6J   $	��774��6b   .+�5      �� -   5         ��Name$ btnCash��5      $
��Left=�6&   $��93,0,0,0q�6A   $	��Top=�6S   $	��150��6k   $��50��6w   ��6�   Z� ��6�   Z� ��5      �� 5      $ images\cash.png��6!   5      �� 5      -   5        $ btnCard��5      $
��Left=�6&   $��	314,0,0,0q�6A   $	��Top=�6T   $	��150��6l   $��50��6x    J� RenderTransformOrigin$ 0.424,0.433&�6�   ��6�   Z� ��6�   Z� ��5      �� 5      $ images\card.png��6!   5!      �� 5"      -   5        $ 	btnPayPal��5"      $
��Left=�6(   $��	533,0,0,0q�6C   $	��Top=�6V   $	��150��6n   $��50��6z   ��6�   Z� ��6�   Z� ��5#      �� 5$      $ images\paypal.png��6!   5&      5'      �� 5(   
   -   5        $ btnBack��5(      $�� ��6"   $
��Left=�6-   $	��Top=�6H   $��75��6`   $��75��6k   ��5)      �� 5*      $ images\back.png��6   5,      o� 5-   
   $��Right=�6   $	��Top=�6+   $	��200��6C   $��75��6P   
����  �.@�5.      m� -	   5         m�Name$ mnuUser��5.      $��Username��6(   $	��200��6:   $��75��6F   $��DemiBold"�6R   $
��16px(�6h   $��30,0,0,0q�6x    m� Icon 5/      �� 50      $��images\Users-icon.png��6   .@�52      m� -
   5        $ mnuChangePw��52      $��Reset Password��60   $	��200��6H   $��25��6T    53      �� 54      $ ��images\change-password.png��6    56      m� 57      -   5        $ logOut��57      $��Log Out��6+   $	��200��6<   $��25��6H    58      �� 59      $��images\log-out.png��6    5;      5<      5=      5?      5@      