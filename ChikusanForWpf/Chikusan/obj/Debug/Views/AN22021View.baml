   M S B A M L   `   `   `  ����C  ?Chikusan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:JaGunma.Chikusan.BehaviorsJaGunma.Chikusan.Behaviors  5      I)clr-namespace:JaGunma.Chikusan.ConvertersJaGunma.Chikusan.Converters  5      ?$clr-namespace:JaGunma.Chikusan.ViewsJaGunma.Chikusan.Views  5	      (    "JaGunma.Chikusan.Views.AN22021View   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      0b(clr-namespace:JaGunma.Chikusan.Behaviors  5      1c)clr-namespace:JaGunma.Chikusan.Converters  5      0local$clr-namespace:JaGunma.Chikusan.Views  5	      P LPrism.Wpf, Version=6.3.0.0, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59$prismhttp://prismlibrary.com/  5
      -   5        $��Bottom=�5      $��Center=�5      ���#BDBDBD&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5       � 	Resources 5         boolToVisibilityConverter4   .JaGunma.Chikusan.Converters.TextColorConverter  textColorConverter=   7JaGunma.Chikusan.Converters.MessageRegionColorConverter  messageRegionColorConverter��%W   &	        &	      &	 &     �� 5   
   6'     5   
   6     5   
   6(   5      .  (System.Windows.Interactivity.Interaction   Triggers 5      F  @Prism.Interactivity.InteractionRequest.InteractionRequestTrigger  5   
   3  -System.Windows.Interactivity.EventTriggerBase   SourceObject 6*   �� *NewPageRequest+.  (System.Windows.Interactivity.TriggerBase   Actions. 5      8   2JaGunma.Chikusan.Behaviors.ShowAnotherWindowAction  5        5   
    6*   �� *SinglePageRequest+. 5      >	   8JaGunma.Chikusan.Behaviors.ShowAnotherSingleWindowAction	  5         	Behaviors 5!      4
   .JaGunma.Chikusan.Behaviors.UserControlBehavior
  5"   
   .��5%      (� $��0q�6    (� Stretch$
 Fill=�6   .��5&   
   �  � RowDefinitions 5'      �� 5(      $��40 �6    �� 5)      $	��728 �6    .+�5/      '   !JaGunma.Chikusan.Views.HeaderView  $��0��6   ]� 51      $��1��6   .+�52      � $	��Top=�6   $
��1366��6,   $	��638��69   $��0,10,0,0q�6F   	 � ColumnDefinitions	 53      �� 54      $
��163* �6+   �� 55      $
��520* �6+    57      �� 58      $
��0.7* �6(   �� 59      $��6* �6(   �� 5:      $��7* �6(   .+�5>      � y�6   �� *IsIconGroupVisible+
 �� 	Converter#
 [  .+�5?      A� $��0��6'    A� Rows$ 1��64    A� Columns$ 2��6=   $
��Left=�6I   ��5@      �� 5A   "    �� 
TargetType" A�6(    �� Triggers 5B   &   �� 5C   *    �� Binding 66   �� *IsStopIconVisible+ �� Value True6\   .a�5D   .   ��  �� Property � y� �� Value$ Visible=�6K   5E   +   �� 5F   *    66   �� *IsStopIconVisible+	 False6\   .a�5G   .   ��  � y�$ Hidden=�6K   5H   +   5J   #   .+�5L      �� $��0q�6%    �� CornerRadius$ 	15,0,0,15��69   $
��Left=�6R   $	��100��6m   $��10,0,0,5q�6y     AccentDarkBrush#��[ 6�   #��[ 6�   ._�5R   "   ��  �� Orientation$ 
Horizontal=�6-   .+�5S   &   ��   LockIcon#��[ 6,   $��20��6O   $��20��6[   $��10,0,0,0q�6g   $
��Fill=�6y   $��Center=�6�   $��Center=�6�    �� BitmapScalingMode$ HighQuality=�6�   �� 5T   &   
�������$��	停止中��6?   $��Center=�6M     	LabelBase#��[ 6h   $��5,0,0,0q�6�   5V   #   5W      �� 5X      $��30��6%   $��0,0,0,5q�60   #��[ 6A   $��2q�6p   $
��Left=�6�     
WhiteBrush#��[ 6�   ._�5Y   "   ��   CheckBoxBase#��[ 6+   $��0,0,0,0q�6�   $��Center=�6�    d� 	IsChecked 6Q   �� *	IsCheck+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   5Z      5r      A� 5s      $��0��6'   $ 1��64   $ 2��6=   $
��Left=�6I   ��5t      �� 5u   "   " A�6(    5v   &   �� 5w   *    66   �� *IsUseIconVisible+ True6[   .a�5x   .   ��  � y�$ Visible=�6K   5y   +   �� 5z   *    66   �� *IsUseIconVisible+	 False6[   .a�5{   .   ��  � y�$ Hidden=�6K   5|   +   5~   #   .+�5�      �� $��0��6%   $��0q�62   $ 	15,0,0,15��6F   $
��Left=�6_   $	��100��6z   $��10,0,0,5q�6�     SuccessBrush#��[ 6�   #��[ 6�   ._�5�   "   �� $ 
Horizontal=�6-   .+�5�   &   ��  	 LockOpenIcon#��[	 6,   $��20��6S   $��20��6_   $��10,0,0,0q�6k   $
��Fill=�6}   $��Center=�6�   $��Center=�6�   $ HighQuality=�6�   �� 5�   &   $��	利用中��6,   
�������$��Center=�6M   #��[ 6h   $��5,0,0,0q�6�   5�   #   5�      �� 5�      $��30��6%   $��0,0,0,5q�60   #��[ 6A   $��2q�6m   $
��Left=�6�   #��[ 6�   ._�5�   "   �� #��[ 6+   $��0,0,0,0q�6�   $��Center=�6�    6Q   �� *	IsCheck+$ TwoWay=�$ PropertyChanged=�6�   5�      5�      5�      �� 5�       
 ItemGroupAreaGroupBox#��[
 6   $��	10,0,10,0q�6N   $��1��6a   $��2��6n   .��5�      � $��	10,5,10,5q�6     ItemGroupAreaGrid#��[ 62    5�      �� 5�   "   $��1* �60   �� 5�   "   $��2* �60   �� 5�   "   $��2* �60   �� 5�   "   $��2* �60   �� 5�   "   $��2* �60   �� 5�   "   $��2* �60   .+�5�      �� $��0��6)   $ 
Horizontal=�66   $��	-10,0,0,0q�6O   .+�5�   "   �� ���#FF5252$��3q�6?   ���	#FFFFFFFF �� Padding$ 0q�6k   $��0,0,2,0q�6w   $ 10��6�   $��15��6�   $��15��6�   $��Center=�6�   $��Center=�6�   �� 5�   "   $��0��6,     TextBlockBase#��[ 69   $��入力項目��6`    �� TextAlignment$
 Left=�6l   $
��Left=�6�   $��Center=�6�   5�      � 5�      $��1��6#   $��	10,5,10,5q�60     ItemGroupRowGrid#��[ 6C   	 5�   "   �� 5�   &   $��1* �67   �� 5�   &   $��1* �67   �� 5�   &   $
��0.3* �67   �� 5�   &   $��2* �67   �� 5�   &   $��4* �67   .+�5�   "   �� $��0��6(     RequiredLabel#��[ 68   $��品名��6_   $
��Left=�6l   $��	40,0,10,0q�6�   �� 5�   "   -   5         ��Name$ HimmeiCodeTextBox��5�   �   $��1��6*     TextBoxBase#��[ 6;    �� TextAlignment$
 Left=�6`    �� PreferredImeState$	 Off=�6�    �� 	MaxLength$ 4��6�   ��6u   �� *HimmeiCode.Value+$ TwoWay=�$ 	LostFocus=�/   )JaGunma.Chikusan.Behaviors.FocusExtension   	IsFocused 65  �� *IsHimmeiCodeFocused+$ TwoWay=�  �� 
IsReadOnly  6}  �� *IsHimmeiCodeReadOnly+$ TwoWay=��� 5�   "   -   5        $��HimmeiSearchButton��5�   i   $��2��6)     RightDockSearchButton#��[ 6:   6i   �� 5�   "   -   5        $��HimmeiTextBox��5�   �   $��3��6*   #��[ 6;   $
 Left=�6`     . ��6u   �� *Himmei.Value+$ OneWay=�6�   5�      � 5�      $��2��6#   $��	10,5,10,5q�60   #��[ 6C   	 5�   "   �� 5�   &   $��1* �67   �� 5�   &   $��1* �67   �� 5�   &   $
��6.3* �67   .+�5�   "   �� $��0��6(   #��[ 68   $��団体コード��6_   $
��Left=�6o   $��40,0,0,0q�6�   �� 5�   "   -   5        $��DantaiCodeTextBox��5�   �   $��1��6*   #��[ 6:   $
 Left=�6_   $	 Off=�6�   $ 3��6�   ��6t   �� *DantaiCode.Value+$ 	LostFocus=�  6&  �� *IsDantaiCodeReadOnly+$ TwoWay=�5�      � 5�      $��3��6#   $��	10,5,10,5q�60   #��[ 6C   	 5�   "   �� 5�   &   $��1* �67   �� 5�   &   $��2* �67   �� 5�   &   $
��5.3* �67   .+�5�   "   �� $��0��6(   #��[ 68   $��	団体名��6_   $
��Left=�6m   $��40,0,0,0q�6�   �� 5�   "   -   5        $��DantaiNameTextBox��5�   5  $��1��6*   #��[ 6:   $
 Left=�6_   $��0,0,5,0q�6�   $ On=�6�   !! �� PreferredImeConversionMode$! FullShape,Native=�6�   $ 20��6%  ��6t   �� *DantaiName.Value+$ 	LostFocus=� 6r  �� *IsDantaiNameFocused+$ TwoWay=�5�      � 5�      $��4��6#   $��	10,5,10,5q�60   #��[ 6C   	 5�   "   �� 5�   &   $��1* �67   �� 5�   &   $��1* �67   �� 5�   &   $
��0.3* �67   �� 5�   &   $��2* �67   �� 5�   &   $��4* �67   .+�5�   "   �� $��0��6,   #��[ 6<   $��	更新者��6c   $
��Left=�6n   $��40,0,0,0q�6�   �� 5�   "   -   5        $��KoushinshaCodeTextBox��5�     $��1��6*   #��[ 6:   $��2��6`   $
 Left=�6t   $	 Off=�6�   $ 10��6�     . $��0,0,20,0q�63  ��6�   �� *KoushinshaCode.Value+$ 	LostFocus=�63  �� 5�   "   -   5        $��KoushinshaNameTextBox��5�   %  $��3��6*   #��[ 6:   $
 Left=�6_   $ On=�6�   $! FullShape,Native=�6�   $ 20��6    . ��6t   �� *KoushinshaName.Value+$ 	LostFocus=�6B  5�      � 5�      $��5��6#   $��	10,5,10,5q�60   #��[ 6C   	 5�   "   �� 5�   &   $��1* �67   �� 5�   &   $��2* �67   �� 5�   &   $
��5.3* �67   .+�5�   "   �� $��0��6,   #��[ 6<   $��	更新日��6c   $
��Left=�6n   $
��40,0q�6�   �� 5�   "   -	   5        $��KoushinDateTextBox��5�   �   $��1��6*   #��[ 6;   $
 Left=�6a   $	 Off=�6�   $ 10��6�     . ��6v   �� *KoushinDate.Value+$ 	LostFocus=�6  5�      5�      5�      5�      � 5�      $��0q�6   $��Bottom=�6#   $��80��6;   $
��1366��6G    5�      �� 5�      $��1* �6(   �� 5�      $��2* �6(   .+�5�      ��   ErrorMessageRegion#��[ 6   ��6I   �� *CheckResult+$ TwoWay=�#
 [ ._�5�      �� -
   5        " ��Name$" ErrorMessageTextBlock��5�   �   $��0��6$   #��[ 61   $��Center=�6}   $
��Left=�6�   
���������6X   �� *CheckResult.Message+6�   5�      � 5�      $��1��6   $��0,0,0,0q�6(   	 5�      �� 5�      $��1* �6/   �� 5�      $��1* �6/   �� 5�      $��5* �6/   .+�5�      �� $��0��6!     CloseButton#��[ 61   ��6V   �� *MoveIchiranPageCommand+A� 5�      $��2��6&   $ 1��66   $��
10,0,-10,0q�6?   $��Right=�6S   .+�5�      ��   ClearButton#��[ 6%   $��	20,0,20,0q�6k   ��6J   �� *ClearCommand+6k   �� 5�      -   5        $��
CopyButton��5�   �     
ButtonBase#��[ 6%   $��	コピー��6�   $��	20,0,20,0q�6�   y�6I   �� *IsCopyButtonVisible+#
 [  $ TwoWay=���6�   �� *MoveCopyPageCommand+{�6  �� *IsCopyButtonEnabled+�� 5�      -   5        $��UpdateButton��5�   �   #��[ 6%   $��	修　正��6�   $��	20,0,20,0q�6�   y�6I   �� *IsUpdateButtonVisible+#
 [  $ TwoWay=���6�   �� *UpdateCommand+6�   �� 5�      -   5        $��EntryButton��5�   �   #��[ 6%   $��	登　録��6�   $��	20,0,20,0q�6�   y�6I   �� *IsEntryButtonVisible+#
 [  $ TwoWay=���6�   �� *EntryCommand+6�   5�      5�      5�      5�      5      5     5     