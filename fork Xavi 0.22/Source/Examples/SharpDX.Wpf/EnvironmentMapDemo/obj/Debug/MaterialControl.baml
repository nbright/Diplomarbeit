   M S B A M L   `   `   `  ����M  IEnvironmentMapDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:HelixToolkit.SharpDX.WpfHelixToolkit.SharpDX.Wpf  5      7 clr-namespace:EnvironmentMapDemoEnvironmentMapDemo  5      (    "EnvironmentMapDemo.MaterialControl   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Z VWPFToolkit.Extended, Version=1.8.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5      0htx&clr-namespace:HelixToolkit.SharpDX.Wpf  5      ,local clr-namespace:EnvironmentMapDemo  5      -   5          >�Name$  
matControl��5	       � 	Resources 5      '   !EnvironmentMapDemo.ColorConverter   htxColorConverter��%   &	          5   
   6   5      .��5      �  5   
    �� 
TargetType �� Property �� Value �� ElementName#  Xceed.Wpf.Toolkit.ColorPicker��%@  '��       '�� �     '�� A    '  �    �� 5      " ��6   .�5      ��  � �� 6+   �� *Margin+$ 
matControl���� 5       � ��$ Center=�66   �� 5       � ��$ Stretch=�68   5      �� 5      " ��6   .�5      ��  � �� 6+   �� *Margin+$ 
matControl���� 5       � ��$ Center=�66   5      �� 5      " ��6   .�5      ��  � ��$
 Auto �6+   5      �� 5      "  6   .�5      ��  � �� 6+   �� *Margin+$ 
matControl���� 5       � ��$ Stretch=�68   5       5!       � ColumnDefinitions 5"   
   �� 5#      $��60 �6   �� 5$      $	��40* �6    � RowDefinitions 5&   
   �� 5'      $��0 �6   �� 5(      -   5         ��Name$	 row��5(      �� 5)      �� 5*      �� 5+      �� 5,      �� 5-      ��6   �� *ActualHeight+$	 row��.+�50   
   �� $��1��6   $��0��6*   $��Ambient:��6:   �� 51   
   $��2��6   $��0��6*   $��Diffuse:��6:   �� 52   
   $��3��6   $��0��6*   $��	Emissive:��6:   �� 53   
   $��4��6   $��0��6*   $��Reflective:��6:   �� 54   
   $��5��6   $��0��6*   $��	Specular:��6:   �� 55   
   $��6��6   $��0��6*   $��
Shininess:��6:     58   
   $��1��6   $��1��6*   	   SelectedColor	 6:   �� *AmbientColor+
 �� 	Converter#
 [    59   
   $��2��6   $��1��6*   	 6:   �� *DiffuseColor+#
 [    5:   
   $��3��6   $��1��6*   	 6:   �� *EmissiveColor+#
 [    5;   
   $��4��6   $��1��6*   	 6:   �� *ReflectiveColor+#
 [    5<   
   $��5��6   $��1��6*   	 6:   �� *SpecularColor+#
 [  �� 5=   
   $��6��6   $��1��6*    � Minimum$ 1Q�6^    � Maximum$	 100Q�6j    � Value 6:   �� *SpecularShininess+6j   5>      5?      