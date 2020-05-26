Imports Microsoft.Office.Interop.Excel
Imports System.Data
Imports System.Data.SqlClient

Public Class Form2
    Dim Ex As New Application
    Dim BookEx As Workbook
    Dim PageEx As Worksheet
    Dim cn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Типография.mdf;Integrated Security=True;Connect Timeout=30")
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            Form3.Show()
        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
            Form4.Show()
        End Sub

        Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
            Form5.Show()
        End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form7.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Close()

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub СотрудникиТипографииToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СотрудникиТипографииToolStripMenuItem.Click

        Ex.Visible = True
        BookEx = Ex.Workbooks.Add
        PageEx = BookEx.Worksheets(1)
        PageEx.Activate()
        PageEx.Range("a1:f1").MergeCells = True
        PageEx.Range("a1:f1").Value = "Сотрудники полиграфии"
        PageEx.Range("a1:f1").Font.Bold = True
        PageEx.Range("a1:f1").Font.Size = 16
        PageEx.Range("a1:h100").ColumnWidth = 25
        PageEx.Range("a1:f10").Borders.LineStyle = XlLineStyle.xlContinuous
        PageEx.Range("a1:f1").HorizontalAlignment = XlHAlign.xlHAlignCenter
        PageEx.Range("a2").Value = "Номер сотрудника"
        PageEx.Range("b2").Value = "Фамилия"
        PageEx.Range("c2").Value = "Имя"
        PageEx.Range("d2").Value = "Отчество"
        PageEx.Range("e2").Value = "Дата рождения"
        PageEx.Range("f2").Value = "Дата принятия на работу"


        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM Сотрудник"
        cn.Open()
        dr = cmd.ExecuteReader
        Dim i As Integer
        i = 3
        While dr.Read
            PageEx.Cells(i, 1) = dr("Номер_сотрудника")
            PageEx.Range("i1").HorizontalAlignment = XlHAlign.xlHAlignCenter
            PageEx.Cells(i, 2) = dr("Фамилия")

            PageEx.Cells(i, 3) = dr("Имя")

            PageEx.Cells(i, 4) = dr("Отчество")

            PageEx.Cells(i, 5) = dr("Дата_рождения")

            PageEx.Cells(i, 6) = dr("Дата_принятия_на_работу")
            i = i + 1
        End While
        cn.Close()
    End Sub

    Private Sub ПредоставляемыеУслуиToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ПредоставляемыеУслуиToolStripMenuItem.Click
        Ex.Visible = True
        BookEx = Ex.Workbooks.Add
        PageEx = BookEx.Worksheets(1)
        PageEx.Activate()
        PageEx.Range("a1:c1").MergeCells = True
        PageEx.Range("a1:c1").Value = "Услуги"
        PageEx.Range("a1:c1").Font.Bold = True
        PageEx.Range("a1:c1").Font.Size = 16
        PageEx.Range("a1:h100").ColumnWidth = 25
        PageEx.Range("a1:c10").Borders.LineStyle = XlLineStyle.xlContinuous
        PageEx.Range("a1:c1").HorizontalAlignment = XlHAlign.xlHAlignCenter
        PageEx.Range("a2").Value = "Номер услуги"
        PageEx.Range("b2").Value = "Название услуги"
        PageEx.Range("c2").Value = "Стоимость услуги, BYN"
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM Услуга"
        cn.Open()
        dr = cmd.ExecuteReader
        Dim i As Integer
        i = 3
        While dr.Read
            PageEx.Cells(i, 1) = dr("Номер_услуги")
            PageEx.Range("i1").HorizontalAlignment = XlHAlign.xlHAlignCenter
            PageEx.Cells(i, 2) = dr("Название_услуги")

            PageEx.Cells(i, 3) = dr("Стоимость")
            i = i + 1
        End While
        cn.Close()
    End Sub

    Private Sub КлиентыToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles КлиентыToolStripMenuItem.Click
        Ex.Visible = True
        BookEx = Ex.Workbooks.Add
        PageEx = BookEx.Worksheets(1)
        PageEx.Activate()
        PageEx.Range("a1:e1").MergeCells = True
        PageEx.Range("a1:e1").Value = "Клиенты"
        PageEx.Range("a1:e1").Font.Bold = True
        PageEx.Range("a1:e1").Font.Size = 16
        PageEx.Range("a1:h100").ColumnWidth = 25
        PageEx.Range("a1:e10").Borders.LineStyle = XlLineStyle.xlContinuous
        PageEx.Range("a1:e1").HorizontalAlignment = XlHAlign.xlHAlignCenter
        PageEx.Range("a2").Value = "Номер клиента"
        PageEx.Range("b2").Value = "Фамилия"
        PageEx.Range("c2").Value = "Имя"
        PageEx.Range("d2").Value = "Отчество"
        PageEx.Range("e2").Value = "Паспортные данные"



        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM Клиент"
        cn.Open()
        dr = cmd.ExecuteReader
        Dim i As Integer
        i = 3
        While dr.Read
            PageEx.Cells(i, 1) = dr("Номер_клиента")
            PageEx.Range("i1").HorizontalAlignment = XlHAlign.xlHAlignCenter
            PageEx.Cells(i, 2) = dr("Фамилия")

            PageEx.Cells(i, 3) = dr("Имя")

            PageEx.Cells(i, 4) = dr("Отчество")

            PageEx.Cells(i, 5) = dr("Паспортные_данные")
            i = i + 1
        End While
        cn.Close()
    End Sub

    Private Sub ДолжностиСотрудниковToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Ex.Visible = True
        BookEx = Ex.Workbooks.Add
        PageEx = BookEx.Worksheets(1)
        PageEx.Activate()
        PageEx.Range("a1:b1").MergeCells = True
        PageEx.Range("a1:b1").Value = "Должности сотрудников"
        PageEx.Range("a1:b1").Font.Bold = True
        PageEx.Range("a1:b1").Font.Size = 16
        PageEx.Range("a1:h100").ColumnWidth = 25
        PageEx.Range("a1:b10").Borders.LineStyle = XlLineStyle.xlContinuous
        PageEx.Range("a1:b1").HorizontalAlignment = XlHAlign.xlHAlignCenter
        PageEx.Range("a2").Value = "Номер сотрудника"
        PageEx.Range("b2").Value = "Наименование должности"
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM Должность_сотрудника"
        cn.Open()
        dr = cmd.ExecuteReader
        Dim i As Integer
        i = 3
        While dr.Read
            PageEx.Cells(i, 1) = dr("Номер_сотрудника")
            PageEx.Range("i1").HorizontalAlignment = XlHAlign.xlHAlignCenter
            PageEx.Cells(i, 2) = dr("Наименование_должности")
            i = i + 1
        End While
        cn.Close()
    End Sub


    Private Sub ВыполнениеЗаказовToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Ex.Visible = True
        BookEx = Ex.Workbooks.Add
        PageEx = BookEx.Worksheets(1)
        PageEx.Activate()
        PageEx.Range("a1:e1").MergeCells = True
        PageEx.Range("a1:e1").Value = "Выполнение заказов"
        PageEx.Range("a1:e1").Font.Bold = True
        PageEx.Range("a1:e1").Font.Size = 16
        PageEx.Range("a1:h100").ColumnWidth = 25
        PageEx.Range("a1:e10").Borders.LineStyle = XlLineStyle.xlContinuous
        PageEx.Range("a1:e1").HorizontalAlignment = XlHAlign.xlHAlignCenter
        PageEx.Range("a2").Value = "Номер заказа"
        PageEx.Range("b2").Value = "Дата выдачи заказа"


        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM Выполнение_заказа"
        cn.Open()
        dr = cmd.ExecuteReader
        Dim i As Integer
        i = 3
        While dr.Read
            PageEx.Cells(i, 1) = dr("Номер_заказа")
            PageEx.Range("i1").HorizontalAlignment = XlHAlign.xlHAlignCenter
            PageEx.Cells(i, 2) = dr("Дата_выдачи_заказа")
            i = i + 1
        End While
        cn.Close()
    End Sub
End Class

