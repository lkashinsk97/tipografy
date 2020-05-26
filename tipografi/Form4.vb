Public Class Form4
    Private Sub УслугаBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles УслугаBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.УслугаBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ТипографияDataSet)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "ТипографияDataSet.Услуга". При необходимости она может быть перемещена или удалена.
        Me.УслугаTableAdapter.Fill(Me.ТипографияDataSet.Услуга)

    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Button1.Enabled = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Col As System.Windows.Forms.DataGridViewColumn
        Select Case ListBox1.SelectedIndex
            Case 0
                Col = DataGridViewTextBoxColumn1
            Case 1
                Col = DataGridViewTextBoxColumn2
            Case 2
                Col = DataGridViewTextBoxColumn3
        End Select
        If RadioButton1.Checked Then
            УслугаDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending)
        Else
            УслугаDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        УслугаBindingSource.Filter = "Номер_услуги='" & ComboBox1.Text & "'"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        УслугаBindingSource.Filter = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i = 0 To УслугаDataGridView.ColumnCount - 1
            For j = 0 To УслугаDataGridView.RowCount - 1
                УслугаDataGridView.Item(i, j).Style.BackColor = Color.White
                УслугаDataGridView.Item(i, j).Style.BackColor = Color.Black
            Next j
        Next i
        For i = 0 To УслугаDataGridView.ColumnCount - 1
            For j = 0 To УслугаDataGridView.RowCount - 1
                If InStr(УслугаDataGridView.Item(i, j).Value, TextBox1.Text) Then
                    УслугаDataGridView.Item(i, j).Style.BackColor = Color.AliceBlue
                    УслугаDataGridView.Item(i, j).Style.ForeColor = Color.Blue
                End If

            Next j
        Next i
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()

    End Sub

    Private Sub УслугаBindingNavigator_RefreshItems(sender As Object, e As EventArgs) Handles УслугаBindingNavigator.RefreshItems

    End Sub
End Class