   M S B A M L   `   `   `  ����C  ?Chikusan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:JaGunma.Chikusan.BehaviorsJaGunma.Chikusan.Behaviors  5      ?$clr-namespace:JaGunma.Chikusan.ViewsJaGunma.Chikusan.Views  5      '    !JaGunma.Chikusan.Views.HeaderView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      0b(clr-namespace:JaGunma.Chikusan.Behaviors  5      0local$clr-namespace:JaGunma.Chikusan.Views  5      P LPrism.Wpf, Version=6.3.0.0, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59$prismhttp://prismlibrary.com/  5	      !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  . $	��Top=�5      $��Center=�5         PrimaryDarkBrush#��[  5      .  (System.Windows.Interactivity.Interaction   Triggers 5      F  @Prism.Interactivity.InteractionRequest.InteractionRequestTrigger  5   
   3  -System.Windows.Interactivity.EventTriggerBase   SourceObject 6*   �� *MenuPageRequest+.  (System.Windows.Interactivity.TriggerBase   Actions. 5      8   2JaGunma.Chikusan.Behaviors.ShowAnotherWindowAction  5      .��5      � $
��1366��6   $��40��6   $��0q�6$    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $
��2.5* �6   �� 5      $
��0.3* �6   �� 5      $��2* �6   �� 5      $
��0.3* �6   �� 5      $��1* �6   .+�5"   
   �� -   5          HeaderButton#��[ 5"      $��0��68   $��メニュー��6H   $��5,0,0,0q�6W   6h   �� 5#   
     HeaderTextBox#��[ 6   $��1��69   $��Center=�6a   $��5,0,0,0q�6�   ��6I   �� *JaCode+6�   �� 5$   
   #��[ 6   $��2��69   $��Center=�6d   $��5,0,0,0q�6�   ��6I   �� *	TempoCode+6�   �� 5(   
   #��[ 6   $��3��69   $��5,0,0,0q�6d   ��6I   �� *
UserInfo+6w   �� 5)   
     HeaderTextBlock#��[ 6   $��4��6?   $
��Wrap=�6O   $	��小��6c   $��Center=�6l   $��Center=�6�   
�������6�   �� 5*   
   -   5         ��Name$ CustomSliderWithTick��5*   L     CustomSliderStyle#��[ 6   $��5��6<     AccentBrush#���  6�    � Value 6j   �� *
FontSize+ �� Mode$ TwoWay=�6�   �� 5+   
   #��[ 6   $��6��6?   $
��Wrap=�6O   $	��大��6c   $��Center=�6l   $��Center=�6�   
�������6�   �� 5,   
   #��[ 6   $��7��67   $��ログアウト��6G   $��0,0,5,0q�6y   ��6Y   �� *TestCommand+6�   5-      5/      