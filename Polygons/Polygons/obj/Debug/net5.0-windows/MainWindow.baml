   M S B A M L   `   `   `  ����C  ?Polygons, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PolygonsPolygons  5   	   7 clr-namespace:Polygons.ResourcesPolygons.Resources  6.       Polygons.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Polygons     5   	   6	resources clr-namespace:Polygons.Resources     6.   *   $Polygons.Resources.MainWindowStrings    WindowTitle � Title# Z  5   	   $	��450��6D   $	��800��6Q   $	��500��6]   $	��300��6l   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��2* �6   $	��140��6*   $	��200��69   �� 5      $��5 �6   �� 5      $��8* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��1��6   $��5��6'   $��Stretch=�61   $��3��6O   �� 5   
   -   5         ��Name$$ numberOfVerticesOfPolygonLabel��5      )   "NumberOfVerticesOfPolygonLabelText#��Z 68   $��0��6�   $��0��6�   $
��Left=�6�   $��Bottom=�6�   $��	10,30,0,0q�6�   �� 5   
   -   5         ��Name$ polygonVertexTextBox��5      $
��Left=�60   $��10,5,0,5q�6K   $��1��6]   $��0��6j    �� TextWrapping$
 Wrap=�6z   $	��Top=�6�   $	��119��6�   �� 5   
   -   5         ��Name$ DrawPolygonButton��5      !	   CreatePoligonButtonContent#��Z	 6,   $
��Left=�6x   $��
10,0,0,325q�6�   $��2��6�   $	��119��6�   $��20��6�   $��Bottom=�6�   6�   �� 5   
   -   5        
 ��Name$
 Canvas��5      $��2��6!   $��0��61   $��3��6>   5      5      