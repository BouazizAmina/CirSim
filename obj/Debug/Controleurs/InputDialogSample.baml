   M S B A M L   `   `   `  ����B  >WpfApp6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Projet.ControleursProjet.Controleurs  5   	   *    $Projet.Controleurs.InputDialogSample   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Projet.Controleurs     5   	     � Title$  InputDialogSample��5   	   $	��400��6#   $	��300��60    � WindowStyle$
 None=�5	   
    � 
ResizeMode$ NoResize=�6    � WindowStartupLocation$ CenterScreen=�63   .��5
      � 
���   � � RowDefinitions 5   
   �� 5      $	��130 �6   �� 5      $��60 �6   �� 5      $	��100 �6   �� 5      $��* �6   .+�5   
   F� $��0��6   ����� 2� t�gffff�~@ tgffff>~@���gffff>~@��@�gffff>~@�o[�gffff>~@�.�gffff}@ ����p�]��fffff�P@�]��23333sF@�]�dffff�:@ ��������:@�o[�������:@ p��������:@`�0 ���fffff�P@@��`�@��gffff6h@@�gffff�h@���gffff�h@gfffffC@gffff�h@hfffff?@gffff6h@hfffff9@`�hfffff9@fffff�P@hfffff9@� J����@VM p��    �o[�     � J�������@fffff�P@������@Q��p������@S�_�������@43333�@23333�}@43333�@23333�{@�43333�@��@��p���` t 2� t�@K���>�@0� ��@_��{T�@�E�4�@K���>����
 ��� ���w�р��������
 ��� ��@�� ����̔}@dfffff
������A|@dfffff
���*@�� � �Q 6n� J �2����@�Y�fffff�@` �fffff�@��N��� ��� ��@�� 	 �� Stretch$
 Fill=�5   ;   $��40��6J   $��40��6V   ���#00D0B66a   �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6"   .+�5      �� $��Nombre d'entrées��6   
�������$��20(�6C   $��Light"�6Q    J� Opacity$	 0.9Q�6d   $��	20,10,0,0q�6r   �� 5      -   5        $��nombre��5      $��1��6&   $��30��63   $��60��6?   $��20,0,0,0q�6g   
���   �
���   ����#00D0B6��6J   �� *nbs+ � 	Resources 5      	 �� Color��%O   (��       5   &   *SystemColors.WindowBrushKey+)�� 6   $	 Black��6U   5      5       5!      �� 5"   
   $��2��6   $ Vertical=�6"   $��Center=�69   .+�5#      �� -   5        
 ��Name$
 	txtAnswer��5#      $��Light"�5$      $��Identifiant��5%      $��20(�5&      $��Center=�5'      
�������
������ $��0q�5*      $	��100��5+      $
��Left=�5,      $	 0.5Q�5-      $��32��5.      .��6*   5/      �� 50      $	��250��6   $��2��6!   
�������$ 1Q�6?   51      �� 52   
   $ 
Horizontal=�6   $��3��6.   .+�53      �� -   5        $��btnDialogOk��53   &    �� 	IsDefault . $��60��6S   $��Bottom=�6b   $��
35,0,10,30q�6}   ���#00D0B6���#00D0B6
�������$	��100��6�   $��30��6�   .��6�   
_Valider6�   �� 54       �� IsCancel . $��60��6%   $��Bottom=�64   ���#00D0B6���#00D0B6
�������$	��100��6�   $��30��6�   $��
20,0,10,30q�6�   .��6�   
_Annuler6�   55      57      58      