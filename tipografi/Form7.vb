Public Class Form7
    Private Sub ЗаказBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Заказ1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Заказ1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ТипографияDataSet)

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "ТипографияDataSet.Заказ1". При необходимости она может быть перемещена или удалена.
        Me.Заказ1TableAdapter.Fill(Me.ТипографияDataSet.Заказ1)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "ТипографияDataSet.Услуга". При необходимости она может быть перемещена или удалена.


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form9.Show()
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Button3.Enabled = True

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Col As System.Windows.Forms.DataGridViewColumn
        Select Case ListBox1.SelectedIndex
            Case 0
                Col = Заказ1DataGridView.Columns(0)
            Case 1
                Col = Заказ1DataGridView.Columns(1)
            Case 2
                Col = Заказ1DataGridView.Columns(2)
            Case 3
                Col = Заказ1DataGridView.Columns(3)
            Case 4
                Col = Заказ1DataGridView.Columns(4)
        End Select
        If RadioButton1.Checked Then
            Заказ1DataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending)
        Else
            Заказ1DataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending)
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Заказ1DataGridView.Refresh()
        Me.Заказ1TableAdapter.Fill(Me.ТипографияDataSet.Заказ1)
    End Sub
End Class