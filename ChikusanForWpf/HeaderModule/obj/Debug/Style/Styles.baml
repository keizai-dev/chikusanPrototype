   M S B A M L   `   `   `  ����G  CHeaderModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:JaGunma.HeaderModule.StyleJaGunma.HeaderModule.Style  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   HeaderFontSize  HeaderFontFamily  AccentBrush  �� Color  PrimaryBrush �� 
TargetType �� BasedOn �� Triggers P� Property P� Value �� Property �� Value3   -System.Windows.Media.Effects.DropShadowEffect    Color	    
BlurRadius
    ShadowDepth    Opacity    	Direction �� 
TargetType �� CornerRadius  SliderThumbStyle �� RelativeSource �� AncestorType �� Mode  CustomSliderStyle � RowDefinitions m�Name m� 	Placement m� Fill J� Opacity m� TickFrequency ]�Name ]� DecreaseRepeatButton ]� IncreaseRepeatButton ]� Thumb �� Triggers �� 
TargetName�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      2local(clr-namespace:JaGunma.HeaderModule.Style  5      ;ee4http://schemas.microsoft.com/expression/2010/effects  5      .sys&clr-namespace:System;assembly=mscorlib  5      %`  &	        &	      &	 ?     &	 `     '�� �     7��'�� S    7��'�� =    7��&	 �    &	 c    7  X�5      
13.667Q�60   *�5	      	Meiryo UI)�65   �� 5      $  #FF5252��6*   �� 5      $  #BDBDBD��6+   �� 5      " ��6   8    5   
   P� 5       �@J�	IsFocused . 5      .�5   
   ��  � ��# �   6%   �� 5   
    � ��$ Center=�65   �� 5   
    � ��# �  6'   �� 5   
    � ��$
 30px��6#   �� 5   
    � ��
 �����6'   �� 5   
    � �� �#BDBDBD6:   �� 5   
    �@J�Effect 5         5      $ Black��6#   $	 5Q�61   $
 1Q�6@   $	 0.2Q�6P   $	 270Q�6^   5       5!      �� 5$      " ��6   8   .�5%   
   ��  � ��# �   6%   �� 5&   
    � ��$ Center=�65   �� 5'   
    � ��$ Center=�67   �� 5(   
    � ��# �  6'   �� 5)   
    � ��$
 33px��6#   �� 5*   
    � ��$ 120px��6"   �� 5+   
    � �� �#FF52526'   �� 5,   
    � ��
 �����6'   �� 5-   
    � ��$ 0q�6,   68   �� 5.   
    �@J�Effect 5/         50      $ Black��6#   $	 5Q�61   $
 2Q�6@   $	 0.2Q�6P   $	 270Q�6^   52      �� 53   
    � �� 54      �� 55      " ��6"   .R�56      �� $ 3��6   #��z��6.   ._�57      �� #��z��6$   $��Center=�6F   $��Center=�6a   59      5:      5<       5=   
   P� 5>       �@J�IsMouseOver . . �5?      ��  � �� �#FF17446/   5@      P� 5A       � �� . . �5B      ��  �@J�Effect 5C         5D      $ Black��6+   $	 0Q�69   $
 0Q�6H   $ 0Q�6X   $	 270Q�6d   5F      5G      5I      �� 5L      " ��6   8   .�5M   
   ��  � ��# �   6%   �� 5N   
    � ��$ Center=�60   �� 5O   
    � ��# �  6'   �� 5P   
    � ��
 �����6'   5Q      �� 5T      " n�6%   .�5U   
   ��  � �� 5V      �� 5W      " n�6"   .R�5X      A� $��15��6�   $��15��6�   ��6   �� *
Foreground+ �� " ��$ FindAncestor=�6�   5Y      5[      �� 5\   
    �@J�Effect 5]         5^      $ Black��6#   $	 5Q�61   $
 2Q�6@   $	 0.2Q�6P   $	 270Q�6^   5`      5a      �� 5d      " ��6&   .�5e   
   ��  �@�Minimum$ 11Q�6$   61   �� 5f   
    �@�Maximum$ 19Q�6$   61   �� 5g   
    �@�SmallChange$ 1Q�6(   64   �� 5h   
    �@�LargeChange$ 1Q�6(   64   �� 5i   
    � ��$ Center=�6.   6?   �� 5j   
    �@��TickPlacement$ BottomRight=�6*   6@    5k   
   P� 5l       �@��Orientation$ 
Horizontal=�6-   . �5n      ��  � �� 5o      �� 5p      .R�5q      �  5r   "   �� 5s   &   $
��Auto �64   �� 5t   &   $��15 �64   �� 5u   &   $
��Auto �64   .+�5x   "   m� $ TopTick��67   $��0��6*   $	 Top=�6H   $y�	Collapsed=�6X   # z��6o   $��8��6�   $	 0.8Q�6�   $��0,0,0,2q�6�   m� 5{   "   $ 
BottomTick��67   $��2��6*   $ Bottom=�6K   $y�	Collapsed=�6^   # z��6u   $ 2Q�6�   $��8��6�   $��0,2,0,0q�6�   ]� 5}   "   $ 
PART_Track��65   $��1��6(    5   &   �� 5�   *   $��Slider.DecreaseLarge��67   #��z��6V   $��3��6�   $	 0.5Q�6�   ��6�   Z� 6�    5�   &   �� 5�   *   $��Slider.IncreaseLarge��67   #��z��6V   $��3��6�   ��6�   Z�  5�   &   n� 5�   *   8��  60   5�   #   5�       5�      P� 5�   "    �@��TickPlacement$ TopLeft=�6J   . �5�   &   �� $ TopTick��6-    � y�$ Visible=�6X   5�   #   P� 5�   "    �@��TickPlacement$ BottomRight=�6J   . �5�   &   �� $ 
BottomTick��6-    � y�$ Visible=�6[   5�   #   P� 5�   "    �@��TickPlacement$
 Both=�6J   . �5�   &   �� $ TopTick��6-    � y�$ Visible=�6X   �� 5�   &   $ 
BottomTick��6-    � y�$ Visible=�6[   5�   #   5�      5�      5�      5�      5�      