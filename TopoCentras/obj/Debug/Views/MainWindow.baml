   M S B A M L   `   `   `  ����F  BTopoCentras, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:TopoCentrasTopoCentras  5   	       TopoCentras.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:TopoCentras     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5
      � $��0,145,204,0q�6   .+�5   
   �  � ShowGridLines . $��0,-135,-199,0q�6$    � ColumnDefinitions 5      �� 5      $	��500 �6#   61   �� 5      $	��325 �6#   61    � RowDefinitions 5      �� 5      $	��300 �6    6/   �� 5      $	��150 �6    6/   .+�5      �� -   5        $��	Add Order��5      $��0��6)   $��1��69   $
��Left=�6F   $	��Top=�6c   $��75��6{   $��
322,60,0,0q�6�   6�   �� 5      -   5        $��Delete Order��5      $��0��6,   $��1��6<   $
��Left=�6I   $��	48,60,0,0q�6d   $	��Top=�6x   $��75��6�   6�   �� 5      -   5        $��Delete product��5      $��1��6.   $��0��6>   $
��Left=�6K   $��
163,10,0,0q�6f   $	��Top=�6{   $	��100��6�   6�   �� 5      -   5        $��Delete client��5      $��1��6-   $��0��6=   $
��Left=�6J   $��
163,75,0,0q�6e   $	��Top=�6z   $	��100��6�   6�   � 5       � DataContext 6   �� *myViewModel+.+�5      �� -   5        $��ProductCombo��5      $
��Left=�6/   $��1��6K   $��0��6[   $��518,9,-138,0q�6h   $	��Top=�6~   $	��120��6�    �� DisplayMemberPath$
 Name��5      ��5      ��  �� Path$ ProductCollection� �� SelectedValue 5      �� *SelectedProduct+5      � 5        6   �� *clientViewModel+.+�5!      �� -   5        $��ClientCombo��5!      $
��Left=�6.   $��1��6J   $��0��6Z   $��517,75,-137,0q�6g   $	��Top=�6~   $	��120��6�   $
 Name��5#      ��5"      �� $ ClientCollection� 5$      �� *SelectedClient+5&      5(      &   System.Windows.Controls.DataGrid  5)   
   -   5        $��datagrid��5)   W   $��0��6:   $��0��6J   $��0,-135,89,109q�6g      AutoGenerateColumns .  6   �� *orderViewModel+��6�   �� *OrderCollection+	 �� SelectedItem	 6�   �� *SelectedOrdersList+5*      5+      