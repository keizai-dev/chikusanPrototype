   M S B A M L   `   `   `  ����C  ?Chikusan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:JaGunma.Chikusan.BehaviorsJaGunma.Chikusan.Behaviors  5      I)clr-namespace:JaGunma.Chikusan.ConvertersJaGunma.Chikusan.Converters  5      C&clr-namespace:JaGunma.Chikusan.MessageJaGunma.Chikusan.Message  5	      C&clr-namespace:JaGunma.Chikusan.LoadingJaGunma.Chikusan.Loading  5
      ?$clr-namespace:JaGunma.Chikusan.ViewsJaGunma.Chikusan.Views  5      (    "JaGunma.Chikusan.Views.AN22020View   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      0b(clr-namespace:JaGunma.Chikusan.Behaviors  5      1c)clr-namespace:JaGunma.Chikusan.Converters  5      .m&clr-namespace:JaGunma.Chikusan.Message  5	      1ring&clr-namespace:JaGunma.Chikusan.Loading  5
      0local$clr-namespace:JaGunma.Chikusan.Views  5      P LPrism.Wpf, Version=6.3.0.0, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59$prismhttp://prismlibrary.com/  5      -   5        !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  . $��Bottom=�5      $��Center=�5      ���#BDBDBD&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5       �� BitmapScalingMode$ NearestNeighbor=�5       � 	Resources 5      4   .JaGunma.Chikusan.Converters.StopKubunConverter  5   
      KeystopKubunConverter  6   =   7JaGunma.Chikusan.Converters.MessageRegionColorConverter  5   
   messageRegionColorConverter  6(   �� 5   
   boolToVisibilityConverter  6'   .  (System.Windows.Interactivity.Interaction   Triggers 5      F  @Prism.Interactivity.InteractionRequest.InteractionRequestTrigger  5    
   3  -System.Windows.Interactivity.EventTriggerBase   SourceObject 6*   �� *NewPageRequest+.  (System.Windows.Interactivity.TriggerBase   Actions. 5!      8	   2JaGunma.Chikusan.Behaviors.ShowAnotherWindowAction	  5"        5#   
    6*   �� *SinglePageRequest+. 5$      >
   8JaGunma.Chikusan.Behaviors.ShowAnotherSingleWindowAction
  5%      ,   &JaGunma.Chikusan.Message.DialogTrigger  5&   
   . 5'      +   %JaGunma.Chikusan.Message.DialogAction  5(         	Behaviors 5*      4   .JaGunma.Chikusan.Behaviors.UserControlBehavior  5+   
   .��5.      (� $��0q�6   	 (� Stretch$
	 Fill=�6   .��5/   
   � 
 � RowDefinitions
 50      �� 51      $��40 �6    �� 52      $	��728 �6    .+�58      �� $��2��6   
���   � K� ZIndex$ 10��69    J� Opacity$	 0.6Q�6K   y�6Y   �� *	IsLoading+  boolToVisibilityConverter �� 	Converter# [ ._�59      0   *JaGunma.Chikusan.Loading.LoadingDottedRing  $	��300q�6)   5:      '   !JaGunma.Chikusan.Views.HeaderView  5;      $��0��6   ]� 5=      $��1��6   .+�5>      � $	��Top=�6   $
��1366��6,   $	��638��69   $��0,10,0,0q�6F   
 5?      �� 5@      $��3* �6(   �� 5A      $��8* �6(   .+�5D      �� $��0��6     ItemGroupAreaGroupBox#��[ 6-   $��	10,0,10,0q�6\   .��5E      � $��
10,5,10,10q�6     ItemGroupAreaGrid#��[ 63   
 5F      �� 5G   "   $��1* �60   �� 5H   "   $��2* �60   �� 5I   "   $��2* �60   �� 5J   "   $��2* �60   �� 5K   "   $��2* �60   .+�5M      �� $��0��6)    �� Orientation$ 
Horizontal=�66   $��	-10,0,0,0q�6O   .+�5N   "   �� ���#FF5252$��3q�6?   ���	#FFFFFFFF �� Padding$ 0q�6k    �� CornerRadius$ 10��6w   $��15��6�   $��15��6�   $��Center=�6�   $��Center=�6�   �� 5O   "   $��0��6,     TextBlockBase#��[ 69   $�� 検索条件��6`    �� TextAlignment$
 Left=�6m   $
��Left=�6�   $	��Top=�6�   5P      � 5R      $��1��6#   $��	10,2,10,2q�60     ItemGroupRowGrid#��[ 6C    � ColumnDefinitions 5S   "   �� 5T   &   $��1* �67   �� 5U   &   $��1* �67   �� 5V   &   $
��0.3* �67   �� 5W   &   $
��0.2* �67   �� 5X   &   $��1* �67   �� 5Y   &   $
��0.5* �67   �� 5Z   &   $��1* �67   �� 5[   &   $��1* �67   �� 5\   &   $��3* �67   .+�5^   "   �� $��0��6,   #��[ 6<   $��品名コード��6c   $
��Left=�6p   $��40,0,0,0q�6�   �� 5_   "   -   5         ��Name$ HimmeiCodeStartTextBox��5_   �   $��1��6*     TextBoxBase#��[ 6;    �� TextAlignment$
 Left=�6`    �� PreferredImeState$	 Off=�6�    �� 	MaxLength$ 4��6�   ��6u   �� *HimmeiCodeStart.Value+ �� UpdateSourceTrigger$ 	LostFocus=�/   )JaGunma.Chikusan.Behaviors.FocusExtension   	IsFocused 68  �� *IsHimmeiCodeStartFocused+ �� Mode$ TwoWay=��� 5`   "   -   5        $��HimmeiSearchButton��5`   i   $��2��6)     RightDockSearchButton#��[ 6:   ��6�   �� *ShowHimmeiSearchCommand+�� 5a   "   $��3��6,   #��[ 6<   $	��～��6c   �� 5b   "   -   5        $��HimmeiCodeEndTextBox��5b   �   $��4��6*   #��[ 6:   $
 Left=�6_   $��10,0,0,0q�6�   $	 Off=�6�   $ 4��6�   ��6t   �� *HimmeiCodeEnd.Value+$ 	LostFocus=�6  �� 5c   "   $��5��6)   #��[ 6:   �� 5d   "   $��7��6,   #��[ 6<   $��品名��6c   �� 5e   "   -   5        $��HimmeiTextBox��5e   8  $��8��6*     PlaceHolderTextBox#��[ 6;   $
 Left=�6g   $��0,0,5,0q�6�   $ On=�6�   ! �� PreferredImeConversionMode$ FullShape,Native=�6�   $	 100��6(  
 � Tag$ 部分一致検索��6m  ��6|   �� *Himmei.Value+$ 	LostFocus=�6m  5f      � 5h      $��2��6#   $��	10,2,10,2q�60   #��[ 6C    5i   "   �� 5j   &   $��1* �67   �� 5k   &   $��1* �67   �� 5l   &   $
��0.3* �67   �� 5m   &   $
��0.2* �67   �� 5n   &   $��1* �67   �� 5o   &   $
��0.5* �67   �� 5p   &   $��1* �67   �� 5q   &   $��1* �67   �� 5r   &   $��3* �67   .+�5t   "   �� $��0��6,   #��[ 6<   $��団体コード��6c   $
��Left=�6p   $��40,0,0,0q�6�   �� 5u   "   -   5        $��DantaiCodeStartTextBox��5u   �   $��1��6*   #��[ 6:   $
 Left=�6_   $	 Off=�6�   $ 3��6�   ��6t   �� *DantaiCodeStart.Value+$ 	LostFocus=�6  �� 5v   "   $��2��6)   #��[ 6:   �� 5w   "   $��3��6,   #��[ 6<   $	��～��6c   �� 5x   "   -   5        $��DantaiCodeEndTextBox��5x   �   $��4��6*   #��[ 6:   $
 Left=�6_   $��10,0,0,0q�6�   $	 Off=�6�   $ 3��6�   ��6u   �� *DantaiCodeEnd.Value+$ 	LostFocus=�6  �� 5y   "   $��5��6)   #��[ 6:   �� 5z   "   $��7��6,   #��[ 6<   $��団体��6c   �� 5{   "   -   5        $��DantaiNameTextBox��5{   <  $��8��6*   #��[ 6:   $
 Left=�6f   $��0,0,5,0q�6�   $ On=�6�   $ FullShape,Native=�6�   $ 20��6,  $ 部分一致検索��6z  ��6{   �� *DantaiName.Value+$ 	LostFocus=�6z  5|      � 5~      $��3��6#   $��	10,2,10,2q�60   #��[ 6C    5   "   �� 5�   &   $��1* �67   �� 5�   &   $��1* �67   �� 5�   &   $
��0.3* �67   �� 5�   &   $
��0.2* �67   �� 5�   &   $��1* �67   �� 5�   &   $
��0.5* �67   �� 5�   &   $��1* �67   �� 5�   &   $��1* �67   �� 5�   &   $��3* �67   .+�5�   "   �� $��0��6,   #��[ 6<   $��	更新者��6c   $
��Left=�6n   $��40,0,0,0q�6�   �� 5�   "   -	   5        $��KoushinshaCodeTextBox��5�   �   $��1��6*   #��[ 6:   $
 Left=�6_   $	 Off=�6�   $ 10��6�   ��6t   �� *KoushinshaCode.Value+$ 	LostFocus=�6  �� 5�   "   $��2��6)   #��[ 6:   �� 5�   "   -
   5        $��KoushinshaNameTextBox��5�   9  $��3��6*   #��[ 6:   $��3��6_   $
 Left=�6s   $ On=�6�   $ FullShape,Native=�6�   $ 20��6*  ��6�   �� *KoushinshaName.Value+$ 	LostFocus=�6V  5�      � 5�      $��4��6#   $��	10,2,10,2q�60   #��[ 6C    5�   "   �� 5�   &   $��1* �67   �� 5�   &   $��1* �67   �� 5�   &   $
��0.3* �67   �� 5�   &   $
��0.2* �67   �� 5�   &   $��1* �67   �� 5�   &   $
��0.5* �67   �� 5�   &   $��1* �67   �� 5�   &   $��1* �67   �� 5�   &   $��3* �67   .+�5�   "   �� $��0��6,   #��[ 6<   $��	更新日��6c   $
��Left=�6n   $��40,0,0,0q�6�   �� 5�   "   -   5        $��KoushinDateStartTextBox��5�     $��1��6*   #��[ 6;   $��2��6`   $
 Left=�6t   $	 Off=�6�   $ 10��6�   ��6�   �� *KoushinDateStart.Value+$ 	LostFocus=�6"  �� 5�   "   $��3��6,   #��[ 6<   $	��～��6c   �� 5�   "   -   5        $��KoushinDateEndTextBox��5�     $��4��6*   #��[ 6:   $��2��6_   $
 Left=�6s   $��10,0,0,0q�6�   $	 Off=�6�   $ 10��6  ��6�   �� *KoushinDateEnd.Value+$ 	LostFocus=�61  �� 5�   "   -   5        $��StopCheckBox��5�   �   $��7��6+    	 CheckBoxBase#��[	 6;   $��2��6a   $��停止中を含める��6u   $��60,0,0,0q�6�    d� 	IsChecked 6�   �� *IsStop.Value+$ PropertyChanged=�6�   �� 5�   "   -   5        $��SearchButton��5�   �   $��9��6)    
 
ButtonBase#��[
 69   $��	検　索��6]   $��Right=�6k   $��0,0,0,0q�6�   $��28��6�   ��6�   �� *SearchCommand+6�   5�      5�      5�      �� 5�      $��1��6   #��[ 6,   $��10q�6\   .��5�      � $��
15,2,15,10q�6   
 5�      �� 5�   "   $��1* �60   �� 5�   "   $	��19* �60   .+�5�      �� $��0��6)   $ 
Horizontal=�66   $��	-15,2,0,0q�6O   .+�5�   "   �� ���#FF5252$��3q�6?   ���	#FFFFFFFF$ 0q�6k   $ 10��6w   $��15��6�   $��15��6�   $��Center=�6�   $��Center=�6�   �� 5�   "   $��0��6-   #��[ 6:   $�� 検索結果��6a   $
 Left=�6n   $
��Left=�6�   $	��Top=�6�   5�      &   System.Windows.Controls.DataGrid  5�      -   5        $��DantaiDataGrid��5�   �   $��1��6'   $��5,2,5,0q�64   ��6E   �� *DantaiList.Value+ �� SelectedItem 6n   �� *SelectedDantai.Value+ �� SelectedIndex 6�   �� *SelectedIndex+$ TwoWay=�$ PropertyChanged=� J� InputBindings 5�   "   d� 5�   &     d� MouseAction$  LeftDoubleClicke�63   ! �� Command! 6R   �� *MoveUpdatePageCommand+�� 5�   &   " �� Gesture$" Enter��61   ! 6B   �� *MoveUpdatePageCommand+#   Columns# 5�   "   4  .System.Windows.Controls.DataGridTemplateColumn  5�   &   ,  &System.Windows.Controls.DataGridColumn$   
IsReadOnly$ .  %   HeaderTemplate% 5�   *   �� 5�   .   .R�5�   2   �� $��Center=�6�   $��Center=�6�   #��[	 6�    6;   �� *IsAllSelected+$ TwoWay=�$ PropertyChanged=���6�   �� *AllSelectChangeCommand+& � DataContext& 6  �� ' �� RelativeSource' �� ( �� AncestorType"(  ) �� Path$) DataContext�5�   /   *   CellTemplate* 5�   *   �� 5�   .   .R�5�   2   �� -   5        $��Center=�5�   p   $��Center=�6�   #��[	 6�    5�   ;   �� *
IsSelected+$ TwoWay=�$ PropertyChanged=�5�   3   5�   /   5�   '   0  *System.Windows.Controls.DataGridTextColumn  5�   &   +   Width5  /System.Windows.Controls.DataGridLengthConverter$+ 1* 69   ,   Header$, 停止��6D   1  +System.Windows.Controls.DataGridBoundColumn-   Binding- 6P   �� *	StopKubun+  stopKubunConverter# [ .   ElementStyle. 5�   *   �� 5�   .   / �� 
TargetType"/ ��64   .�5�   2   �� 0 �� Property0 � ��1 �� Value$1 Center=�6V   �� 5�   2   0 � ��$1 Center=�6X   5�   /   5�   '     5�   &   $+ 4* 6=   2   SortMemberPath$2 
HimmeiCode��6H   3   CanUserSort3 . % 5�   *   �� 5�   .   .R�5�   2   �� $��品名��6<   5�   /   * 5�   *   �� 5�   .   .R�5�   2   �  5�   6   �� 5�   :   $��2* �6K   �� 5�   :   $��8* �6K   .+�5�   6   �� $��0��6@   $ Center=�6l   ��6P   �� *
HimmeiCode+6l   �� 5�   6   $��1��6=   $��1,0,0,0q�6N     PrimaryBrush#��[ 6h   $��-3q�6�   �� 5�   6   $��1��6@   $
 Left=�6h   ��6P   �� *Himmei+6h   5�   3   5�   /   5�   '     5�   &   $+ 4* 6=   $2 
DantaiCode��6H   3 . % 5�   *   �� 5�   .   .R�5�   2   �� $��団体��6<   5�   /   * 5�   *   �� 5�   .   .R�5�   2   �  5�   6   �� 5�   :   $��2* �6K   �� 5�   :   $��8* �6K   .+�5�   6   �� $��0��6@   $ Center=�6l   ��6P   �� *
DantaiCode+6l   �� 5�   6   $��1��6=   $��1,0,0,0q�6N   #��[ 6h   $��-3q�6�   �� 5�   6   $��1��6@   $
 Left=�6l   ��6P   �� *
DantaiName+6l   5�   3   5�   /   5  '     5  &   $+ 2* 6\   $, 更新者名��6g   - 69   �� *KoushinshaName+6g     5  &   $+ 2* 6   $, 	更新日��6�   - 69   �� *KoushinDateTime+4 �� StringFormat$4 yyyy/MM/dd hh:mm:ss��6�   5     5     5     5     � 5     $��0q�6   $��Bottom=�6#   $��80��6;   $
��1366��6G   
 5     �� 5     $��1* �6(   �� 5     $��2* �6(   .+�5     ��   ErrorMessageRegion#��[ 6   $��	10,0,10,0q�6�   ��6I   �� *CheckResult+$ TwoWay=�  messageRegionColorConverter# [ ._�5     �� -   5        5 ��Name$5 ErrorMessageTextBlock��5  �   $��0��6$   #��[ 61   $��Center=�6�   $
��Left=�6�   
���������6X   �� *CheckResult.Message+$ TwoWay=�6�   5     � 5     $��1��6   $��0,0,10,0q�6(    5     �� 5      $��1* �6/   �� 5!     $��1* �6/   �� 5"     $��5* �6/   .+�5$     �� $��0��6!     CloseButton#��[ 61   $��Close��6W   $��	20,0,20,0q�6g   A� 5%     $��2��6&   6 A� Rows$6 1��66   $��
10,0,-20,0q�6?   $��Right=�6S   .+�5&     ��   ClearButton#��[ 6%   $��	20,0,20,0q�6k   ��6J   �� *ClearCommand+6k   �� 5'     #��[
 6%   $��帳票出力��6I   $��	20,0,20,0q�6x   ��6X   �� *TestCommand+6x   �� 5(     #��[
 6%   $��データ出力��6I   $��	20,0,20,0q�6   ��6Y   �� *DataOutputCommand+6   �� 5)     #��[
 6%   $��	新　規��6I   $��	20,0,20,0q�6�   ��6W   �� *MoveEntryPageCommand+6�   �� 5*     #��[
 6%   $��	詳　細��6I   $��	20,0,20,0q�6�   ��6W   �� *MoveUpdatePageCommand+6�   5+     5,     5-     5.     5/     50     51     