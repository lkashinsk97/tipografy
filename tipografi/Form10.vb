Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Office.Interop.Excel
Imports System.Data
Public Class Form10
    Dim Ex As New Application
    Dim BookEx As Workbook
    Dim PageEx As Worksheet
    Dim cn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Типография.mdf;Integrated Security=True;Connect Timeout=30")
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Private Sub СотрудникBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles СотрудникBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.СотрудникBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ТипографияDataSet)

    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "ТипографияDataSet.Должность_сотрудника". При необходимости она может быть перемещена или удалена.
        Me.Должность_сотрудникаTableAdapter.Fill(Me.ТипографияDataSet.Должность_сотрудника)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "ТипографияDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
        Me.СотрудникTableAdapter.Fill(Me.ТипографияDataSet.Сотрудник)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String = String.Empty
        query &= "INSERT INTO [Сотрудник] (Номер_сотрудника, Фамилия, Имя, Отчество, Дата_рождения, Дата_принятия_на_работу) "

        query &= "VALUES (@Номер_сотрудника, @Фамилия, @Имя, @Отчество, @Дата_рождения, @Дата_принятия_на_работу)"

        Using conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Типография.mdf;Integrated Security=True;Connect Timeout=30")
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Номер_сотрудника", TextBox1.Text)
                    .Parameters.AddWithValue("@Фамилия", TextBox2.Text)
                    .Parameters.AddWithValue("@Имя", TextBox3.Text)
                    .Parameters.AddWithValue("@Отчество", TextBox4.Text)
                    .Parameters.AddWithValue("@Дата_рождения", Дата_рожденияDateTimePicker.Value)
                    .Parameters.AddWithValue("@Дата_принятия_на_работу", Дата_принятия_на_работуDateTimePicker.Value)
                End With
                conn.Open()
                comm.ExecuteNonQuery()


            End Using
        End Using
    End Sub
End Class