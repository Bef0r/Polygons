   M S B A M L   `   `   `  ����C  ?Polygons, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PolygonsPolygons  5   	   7 clr-namespace:Polygons.ResourcesPolygons.Resources  6.       Polygons.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Polygons     5   	   6	resources clr-namespace:Polygons.Resources     6.   *   $Polygons.Resources.MainWindowStrings    WindowTitle � Title# Z  5   	   $	��450��6D   $	��800��6Q   $	��500��6]   $	��300��6l   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��2* �6   $	��140��6*   $	��200��69   �� 5      $��5 �6   �� 5      $��8* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��289* �6   .+�5   
   �� $��1��6   $��Stretch=�6'   $��5��6E   �� 5   
   -   5         ��Name$$ numberOfVerticesOfPolygonLabel��5      )   "NumberOfVerticesOfPolygonLabelText#��Z 68   $��0��6�   $��0��6�   $
��Left=�6�   $��Bottom=�6�   $��	10,0,0,28q�6�   $��26��6�   $��2��6�   $��89��6  �� 5   
   -   5         ��Name$ polygonVertexTextBox��5      $
��Left=�60   $��10,0,0,0q�6K   $��1��6]   $��0��6j    �� TextWrapping$
 Wrap=�6z   $��Center=�6�   $	��119��6�   $��18��6�   �� 5   
   -   5         ��Name$ DrawPolygonButton��5      !	   CreatePoligonButtonContent#��Z	 6,   $��	10,10,0,0q�6x   $��2��6�   $��20��6�   $��Center=�6�   $
��Left=�6�   $	��119��6�   �� 5   
   -   5        
 ��Name$
 myCanvas��5      $��2��6#   $��0��63   $��5��6@   �� 5   
   -   5         ��Name$ MainWindowErrorLabel��5      $
��Left=�62   $��	10,19,0,0q�6M   $��4��6`   $
��Wrap=�6m   $	��Top=�6�   $	��119��6�   $	��116��6�   $�� ��6�   ���	#FFF108086�   �� 5   
   -   5        $ storageButton��5         StorageButtonContent#��Z 6(   $
��Left=�6n   $��	10,10,0,0q�6�   $��3��6�   $��Center=�6�   $	��119��6�   $��20��6�   6�   5      5      