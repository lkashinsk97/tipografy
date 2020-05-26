Public Class Form3
    Private Sub СотрудникBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles СотрудникBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.СотрудникBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ТипографияDataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "ТипографияDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
        Me.СотрудникTableAdapter.Fill(Me.ТипографияDataSet.Сотрудник)

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
            Case 5
                Col = DataGridViewTextBoxColumn6
        End Select
        If RadioButton1.Checked Then
            СотрудникDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending)
        Else
            СотрудникDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        СотрудникBindingSource.Filter = "Номер_сотрудника='" & ComboBox1.Text & "'"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        СотрудникBindingSource.Filter = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i = 0 To СотрудникDataGridView.ColumnCount - 1
            For j = 0 To СотрудникDataGridView.RowCount - 1
                СотрудникDataGridView.Item(i, j).Style.BackColor = Color.White
                СотрудникDataGridView.Item(i, j).Style.BackColor = Color.Black
            Next j
        Next i
        For i = 0 To СотрудникDataGridView.ColumnCount - 1
            For j = 0 To СотрудникDataGridView.RowCount - 1
                If InStr(СотрудникDataGridView.Item(i, j).Value, TextBox1.Text) Then
                    СотрудникDataGridView.Item(i, j).Style.BackColor = Color.AliceBlue
                    СотрудникDataGridView.Item(i, j).Style.ForeColor = Color.Blue
                End If

            Next j
        Next i
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form10.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.СотрудникTableAdapter.Fill(Me.ТипографияDataSet.Сотрудник)
    End Sub
End Class