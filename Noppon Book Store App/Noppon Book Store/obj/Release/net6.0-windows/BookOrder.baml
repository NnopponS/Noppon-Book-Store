   M S B A M L   `   `   `  ���� L  HNoppon Book Store, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Noppon_Book_StoreNoppon_Book_Store  !    Noppon_Book_Store.BookOrder   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:Noppon_Book_Store       � Title$  	BookOrder��$	��768��$	��432��.��� $��0,0,0,-6q�����  �� ImageSource$ /OrderUI.png�� � ColumnDefinitions �� $��0* ��� $��0* ��� .+��� -    ��Name$ cbdISN��$
��Left=�$��22��$��
54,150,0,0q�$	��Top=�$	��130��$��2���� -   $ cbdCustomers��$
��Left=�$��22��$��248,150,0,0q�$	��Top=�$	��128��$��2��&   System.Windows.Controls.DataGrid  -     Name$ dataGrid��$
��Left=�$	��324��$��
51,352,0,0q�$	��Top=�$	��326��$��2���� -    ��Name$ Back_to_menu��$��Back to menu��$
��Left=�$��26��$��	6,693,0,0q�$	��Top=�$	��148�� � Cursor$ AppStarting�����	#FFFF6F6F$
��Bold"�$��20(�$��2����Z� ��Z� �� -    ��Name$ 
txtQuatity��$
��Left=�$��22��$��248,230,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��128��$��2��	 J� RenderTransformOrigin$	 0.491,0.627&��� -   $ txtCart��$��Add to Cart��$
��Left=�$��26��$��
54,314,0,0q�$	��Top=�$	��130��
 J� Opacity$
 1Q�$��2��$
��Bold"����	#FFFFDE00�� -   $ txtBuy��$	��Buy��$
��Left=�$��26��$��248,314,0,0q�$	��Top=�$	��128��$
 1Q�$��2��$
��Bold"����	#FFFF7171�� -    ��Name$ 	txt_Email��$
��Left=�$��20��$��642,871,0,0q�$
��Wrap=�$��	TextBlock��$	��Top=�$	��198��$��2���� -	   $ 
txtCusName��$
��Left=�$��22��$��248,190,0,0q�$
 Wrap=�$	��Top=�$	��128��$��2��${�False���� -
   $ txtTotalPrice��$
��Left=�$��22��$��248,270,0,0q�$
 Wrap=�$	��Top=�$	��128��$��2��${�False���� -   $ txtNameBooks��$
��Left=�$��22��$��
54,190,0,0q�$
 Wrap=�$	��Top=�$	��130��$��2��${�False���� -   $ txtDescription��$
��Left=�$��22��$��
54,230,0,0q�$
 Wrap=�$	��Top=�$	��130��$��2��${�False���� -   $ txtPrice��$
��Left=�$��22��$��
54,270,0,0q�$
 Wrap=�$	��Top=�$	��130��$��2��${�False���� $
��Left=�$��16��$��
56,134,0,0q�$
 Wrap=�$��	Book ISBN��$	��Top=�$��66��$	 0.566,0.468&�$
��Bold"�${�False��$��3����Z� ��Z�  �� SelectionBrush Z�  �� SelectionTextBrush Z� �� $
��Left=�$��18��$��
56,172,0,0q�$
 Wrap=�$��
Book Title��$	��Top=�$��66��$	 0.566,0.468&�$
��Bold"�${�False��$��3����Z� ��Z�  Z�  Z� �� $
��Left=�$��18��$��
56,212,0,0q�$
 Wrap=�$��Book Description��$	��Top=�$	��118��$	 0.566,0.468&�$
��Bold"�${�False��$��3����Z� ��Z�  Z�  Z� �� $
��Left=�$��18��$��
56,252,0,0q�$
 Wrap=�$��
Book Price��$	��Top=�$��80��$	 0.566,0.468&�$
��Bold"�${�False��$��3����Z� ��Z�  Z�  Z� �� $
��Left=�$��16��$��248,252,0,0q�$
 Wrap=�$��Totel Price��$	��Top=�$��66��$	 0.566,0.468&�$
��Bold"�${�False��$��2����Z� ��Z�  Z�  Z� �� $
��Left=�$��18��$��248,212,0,0q�$
 Wrap=�$��Quatity��$	��Top=�$��66��$	 0.566,0.468&�$
��Bold"�${�False��$��2����Z� ��Z�  Z�  Z� �� $
��Left=�$��18��$��248,172,0,0q�$
 Wrap=�$��Name - Lastname��$	��Top=�$	��114��$	 0.566,0.468&�$
��Bold"�${�False��$��3����Z� ��Z�  Z�  Z� �� $
��Left=�$��16��$��248,134,0,0q�$
 Wrap=�$��Customer ID��$	��Top=�$��84��$	 0.566,0.468&�$
��Bold"�${�False��$��3����Z� ��Z�  Z�  Z� �� $
��Left=�$��38��$��
248,78,0,0q�$
 Wrap=�$��PAYMENT��$	��Top=�$	��128��$	 0.566,0.468&�$
��Bold"�${�False��$��3��$��30(���Z� ��Z�  Z�  Z� �� $
��Left=�$��50��$��	54,78,0,0q�$
 Wrap=�$
��BOOK��$	��Top=�$	��130��$	 0.566,0.468&�$
��Bold"�${�False��$��3��$��30(� �� TextAlignment$ Center=���Z� ��Z�  Z�  Z� �� $
��Left=�$��50��$��	54,78,0,0q�$
 Wrap=�$
��BOOK��$	��Top=�$	��130��$	 0.566,0.468&�$
��Bold"�${�False��$��3��$��30(�$ Center=���Z� ��Z�  Z�  Z� �� $
��Left=�$��38��$��
248,78,0,0q�$
 Wrap=�$��PAYMENT��$	��Top=�$	��128��$	 0.566,0.468&�$
��Bold"�${�False��$��3��$��30(���Z� ��Z�  Z�  Z� 