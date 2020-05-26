Public Class Form5
    Private Sub КлиентBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles КлиентBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.КлиентBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ТипографияDataSet)

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "ТипографияDataSet.Клиент". При необходимости она может быть перемещена или удалена.
        Me.КлиентTableAdapter.Fill(Me.ТипографияDataSet.Клиент)

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
            Case 3
                Col = DataGridViewTextBoxColumn4
            Case 4
                Col = DataGridViewTextBoxColumn5
        End Select
        If RadioButton1.Checked Then
            КлиентDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending)
        Else
            КлиентDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        КлиентBindingSource.Filter = "Номер_клиента='" & ComboBox1.Text & "'"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        КлиентBindingSource.Filter = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i = 0 To КлиентDataGridView.ColumnCount - 1
            For j = 0 To КлиентDataGridView.RowCount - 1
                КлиентDataGridView.Item(i, j).Style.BackColor = Color.White
                КлиентDataGridView.Item(i, j).Style.BackColor = Color.Black
            Next j
        Next i
        For i = 0 To КлиентDataGridView.ColumnCount - 1
            For j = 0 To КлиентDataGridView.RowCount - 1
                If InStr(КлиентDataGridView.Item(i, j).Value, TextBox1.Text) Then
                    КлиентDataGridView.Item(i, j).Style.BackColor = Color.AliceBlue
                    КлиентDataGridView.Item(i, j).Style.ForeColor = Color.Blue
                End If

            Next j
        Next i
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()

    End Sub
End Class