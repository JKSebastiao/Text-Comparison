   M S B A M L   `   `   `  ����R  NTextDocumentsComparison, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:TextDocumentsComparisonTextDocumentsComparison  5   	   (    "TextDocumentsComparison.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:TextDocumentsComparison     5   	     � Title$  Text Documents Comparison��5   	   $	��540��6+   $	��800��68   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��79* �6   �� 5      $
��185* �6   .+�5   
   �� ���	#FFF4F4F5$
��Left=�6%   $	��509��6@   
���   �$	��Top=�6\   $	��792��6t   $��2��6�   �� 5   
   $��Document 1:��6   $
��Left=�6&   $��	10,33,0,0q�6A   $	��Top=�6T   $��81��6l   �� 5   
   $��Document 2:��6   $
��Left=�6&   $��	10,64,0,0q�6A   $	��Top=�6T   �� 5   
   -   5         ��Name$ textBoxDoc1��5      $
��Left=�6'   $��23��6B   $��
105,36,0,0q�6N    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��581��6�   $��2��6�   �� 5   
   -   5        $ textBoxDoc2��5      $
��Left=�6'   $��23��6B   $��
105,68,0,0q�6N   $
 Wrap=�6b   $	��Top=�6v   $	��581��6�   $��2��6�   �� 5   
   -   5         ��Name$ browserButton1��5      $��Browser��6)   $
��Left=�6;   $��
454,33,0,0q�6V   $	��Top=�6j   $��75��6�   $��23��6�   $��1��6�   �� 5   
   -   5        $ browserButton2��5      $��Browser��6)   $
��Left=�6;   $��
454,67,0,0q�6V   $	��Top=�6j   $��75��6�   $��23��6�    J� RenderTransformOrigin$ 
1.56,0.609&�6�   $��1��6�   6�   �� 5   
   $��Algorithms:��6   $
��Left=�6&   $��	10,98,0,0q�6A   $	��Top=�6T   $ 0.155,0.385&�6l   �� 5   
   -   5         ��Name$ jaroWinklerCheckBox��5      $��Jaro Winkler��60   $
��Left=�6G   $��105,106,0,0q�6b   $	��Top=�6w   6�   �� 5   
   -   5        $ levenshteinCheckBox��5      $��Levenshtein��60   $
��Left=�6F   $��203,109,0,0q�6a   $	��Top=�6v   $��2��6�   �� 5   
   -   5        $# normalizedLevenshteinCheckBox��5      $��Normalized Levenshtein��6:   $
��Left=�6[   $��
66,109,0,0q�6v   $	��Top=�6�   $��1��6�   �� 5   
   -   5        $ nGramCheckBox��5      $��NGram��6*   $
��Left=�6:   $��228,109,0,0q�6U   $	��Top=�6j   $��1��6�   �� 5   
   $��Comparison:��6   $
��Left=�6&   $��
10,140,0,0q�6A   $	��Top=�6U   �� 5   
   -	   5        $ resultTexBox��5      $
��Left=�6(   $	��275��6C   $��
19,171,0,0q�6P   $
 Wrap=�6d   $	��Top=�6x   $	��747��6�    �� 	UndoLimit$ 100000��6�   $��2��6�   �� 5   
   -
   5        $��Compare��5      $
��Left=�6#   $��454,466,0,0q�6>   $	��Top=�6S   $��75��6k   $��1��6v   6�   �� 5   
   $��Button��6   $
��Left=�6"   $��359,466,0,0q�6=   $	��Top=�6R   $��74��6j   $ 	0.287,0.4&�6u   $��1��6�   � 5   
   -   5         �Name$ progressBar��5      $
��Left=�6+   $��20��6F   $��
19,466,0,0q�6R   $	��Top=�6f   $	��540��6~   $��2��6�   5!      5"      