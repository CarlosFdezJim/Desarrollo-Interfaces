   M S B A M L   `   `   `  ����  	ExpenseIt    ExpenseIt.ExpenseItHome   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N� Title$  ExpenseIt - Inicio��5      .��5
      � $��
10,0,10,10q�6    � 	Resources 5   
      ExpenseDataSource � XPath  nameItemTemplate �� XPath��%#  &	        &	 �    � 5      $ Expenses��68   .��5      �	�	<Expenses xmlns="">
                        <Person Name="Miguel" Department="Legal">
                            <Expense ExpenseType="Almuerzo" ExpenseAmount="50" />
                            <Expense ExpenseType="Desplazamiento" ExpenseAmount="50" />
                        </Person>
                        <Person Name="Luisa" Department="Marketing">
                            <Expense ExpenseType="Impresión de documentos" ExpenseAmount="50" />
                            <Expense ExpenseType="Obsequio" ExpenseAmount="125" />
                        </Person>
                        <Person Name="Juan" Department="Ingeniería">
                            <Expense ExpenseType="Suscripción a revista" ExpenseAmount="50" />
                            <Expense ExpenseType="Nueva Máquina" ExpenseAmount="600" />
                            <Expense ExpenseType="Software" ExpenseAmount="500" />
                        </Person>
                        <Person Name="María" Department="Finanzas">
                            <Expense ExpenseType="Dinner" ExpenseAmount="100" />
                        </Person>
                    </Expenses>        5"      �� 5$      .R�5%      �� ��6   �� $ @Name��5&      5'      ��5(   
   �� 5)       �� ImageSource$ watermark.png��6    � ColumnDefinitions 5,   
   �� 5-      $	��230 �6   �� 5.       � RowDefinitions 51   
   �� 52      �� 53      $
��Auto �6   �� 54      �� 55      $
��Auto �6   .+�5:   
   �� $��1��6     headerTextStyle#��[ 6    .��6J   Ver informe de gastos5<      �� 5>   
   $��1��6   $��1��6!     listHeaderStyle#��[ 6.   ._�5?      ��   listHeaderTextStyle#��[ 6   .��6A   Nombre6I   5@      �� 5A   
   -   5        $��peopleListBox��5A      $��1��6'   $��2��67   #��[ 5C   
   ��5B   
   ��  �� Source# [  $ Person��5D      �� 5G   
   -   5        $��1��5G      $��3��6!     buttonStyle#��[ 6E   .��6j   Ver6o   5H      5I      