   M S B A M L   `   `   `  ����F  BTopoCentras, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:TopoCentras.ViewsTopoCentras.Views  5   	   &     TopoCentras.Views.AddOrderWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:TopoCentras.Views     5   	     � Title$  AddOrderWindow��5   	   $	��320��6    $	��600��6-   .��5	      � .+�5
   
   �  � ShowGridLines .  � ColumnDefinitions 5      �� 5      $	��200 �6#   61   �� 5      $	��200 �6#   61   �� 5      $	��200 �6#   61    � RowDefinitions 5      �� 5      $	��100 �6    6/   �� 5      $	��100 �6    6/   �� 5      $	��100 �6    6/   5      � 5   
    � DataContext 6   �� *myViewModel+.+�5      �� -   5        $��productCombobox��5      $��0��6.   $��0��6;   $
��Left=�6K   $��	41,49,0,0q�6f   $	��Top=�6y   $	��120��6�    �� DisplayMemberPath$
 Name��5      ��5      ��  �� Path$ ProductCollection� �� SelectedValue 5      �� *SelectedProduct+5      � 5   
   $��10,-10,-10,10q�68    6   �� *clientViewModel+.+�5      �� -   5        $��clientCombobox��5      $
��Left=�6-   $��0��6H   $��
237,61,0,0q�6U   $	��Top=�6i   $	��120��6�   $
 Name��5       ��5      �� $ ClientCollection� 5!      �� *SelectedClient+�� 5#      $��Select product��6   $
��Left=�6-   $��	50,35,0,0q�6H   $	��Top=�6[   �� 5$      $��Select Client��6   $
��Left=�6,   $��
251,35,0,0q�6G   $	��Top=�6[   $��97��6s   �� 5%      $��Product Name��6   $
��Left=�6+   $��26��6F   $��
50,128,0,0q�6R   $	��Top=�6f   $	��117��6~   �� 5&      $��Product Price��6   $
��Left=�6,   $��26��6G   $��251,128,0,0q�6S   $	��Top=�6h   $��86��6�   �� 5'      $��Client Name��6   $
��Left=�6*   $��
50,225,0,0q�6E   $	��Top=�6Y   $	��117��6q   5(      �� 5)   
   -   5        $��product_name��5)      $
��Left=�6&   $��23��6A   $��
44,144,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $	��Top=�6v   $	��120��6�   �� 5*   
   -   5        $��product_price��5*      $
��Left=�6'   $��23��6B   $��252,144,0,0q�6N   $
 Wrap=�6c   $	��Top=�6x   $	��120��6�   �� 5+   
   -   5        $��Add Product��5+      $
��Left=�6'   $��437,147,0,0q�6B   $	��Top=�6W   $��75��6o   6z   �� 5,   
   -   5        $��client_name��5,      $
��Left=�6%   $��23��6@   $��
44,239,0,0q�6L   $
 Wrap=�6`   $	��Top=�6u   $	��120��6�   �� 5-   
   -   5        $��
Add client��5-      $
��Left=�6>   $	��Top=�6Z   $��75��6r   $��267,242,0,0q�6}   �� 5.   
   -   5        $��	Add order��5.      $
��Left=�6%   $��
437,52,0,0q�6@   $	��Top=�6T   $��75��6l   6w   5/      50      