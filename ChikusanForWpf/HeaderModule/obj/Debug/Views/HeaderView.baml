   M S B A M L   `   `   `  ����G  CHeaderModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:JaGunma.HeaderModule.ViewsJaGunma.HeaderModule.Views  5      +    %JaGunma.HeaderModule.Views.HeaderView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:JaGunma.HeaderModule.Views     5      P LPrism.Wpf, Version=6.3.0.0, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59$prismhttp://prismlibrary.com/  5      !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  . $	��Top=�5      $��Center=�5      ���#9E9E9E.��5      � $
��1366��6   $��40��6   $��0q�6$    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $
��2.5* �6   �� 5      $
��0.3* �6   �� 5      $��2* �6   �� 5      $
��0.3* �6   �� 5      $��1* �6   .+�5"   
   ��    HeaderButton#��[  6   $��0��68   $��メニュー��6H   $��5,0,0,0q�6W   �� 5#   
     HeaderTextBox#��[ 6   $��1��69   $	��006��6I   $��Center=�6T   $��5,0,0,0q�6y   �� 5$   
   #��[ 6   $��2��69   $	��001��6I   $��Center=�6T   $��5,0,0,0q�6y   �� 5(   
   #��[ 6   $��3��69   $)��#AN000001 JA前橋市　電算太郎��6I   $��5,0,0,0q�6e   6x   �� 5)   
     HeaderTextBlock#��[ 6   $��4��6?   $
��Wrap=�6O   $	��小��6c   $��Center=�6l   $��Center=�6�   
�������6�   �� 5*   
   -   5         ��Name$ CustomSliderWithTick��5*   L     CustomSliderStyle#��[ 6   $��5��6<     AccentBrush#���  6�    � Value 6j   �� *
FontSize+ �� Mode$ TwoWay=�6�   �� 5+   
   #��[ 6   $��6��6?   $
��Wrap=�6O   $	��大��6c   $��Center=�6l   $��Center=�6�   
�������6�   �� 5,   
   #��[  6   $��7��67   $��ログアウト��6G   $��0,0,5,0q�6y   ��6Y   �� *TestCommand+6�   5-      5/      