Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Office.Interop.Excel
Imports System.Data
Public Class Form9
    Dim Ex As New Application
    Dim BookEx As Workbook
    Dim PageEx As Worksheet
    Dim cn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Типография.mdf;Integrated Security=True;Connect Timeout=30")
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Private Sub КлиентBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles КлиентBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.КлиентBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ТипографияDataSet)

    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "ТипографияDataSet.Заказ". При необходимости она может быть перемещена или удалена.
        Me.ЗаказTableAdapter.Fill(Me.ТипографияDataSet.Заказ)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "ТипографияDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
        Me.СотрудникTableAdapter.Fill(Me.ТипографияDataSet.Сотрудник)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "ТипографияDataSet.Услуга". При необходимости она может быть перемещена или удалена.
        Me.УслугаTableAdapter.Fill(Me.ТипографияDataSet.Услуга)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "ТипографияDataSet.Клиент". При необходимости она может быть перемещена или удалена.
        Me.КлиентTableAdapter.Fill(Me.ТипографияDataSet.Клиент)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String = String.Empty
        query &= "INSERT INTO [Заказ1] (Номер_заказа, Вид_услуги, Фамилия_клиента, Фамилия_сотрудника, Дата_оформления_заказа) "

        query &= "VALUES (@Номер_заказа ,@Вид_услуги, @Фамилия_клиента, @Фамилия_сотрудника, @Дата_оформления_заказа)"

        Using conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Типография.mdf;Integrated Security=True;Connect Timeout=30")
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Номер_заказа", Номер_заказаTextBox.Text)
                    .Parameters.AddWithValue("@Вид_услуги", Название_услугиComboBox.SelectedItem)
                    .Parameters.AddWithValue("@Фамилия_клиента", ComboBox1.Text)
                    .Parameters.AddWithValue("@Фамилия_сотрудника", ФамилияComboBox.SelectedItem)
                    .Parameters.AddWithValue("@Дата_оформления_заказа", Дата_оформления_заказаDateTimePicker.Value)
                End With
                conn.Open()
                comm.ExecuteNonQuery()


            End Using
        End Using

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim text As StreamWriter
        text = New StreamWriter("order_list.txt")
        text.WriteLine("Организация: " + " ООО «Друк Сервис»")
        text.WriteLine("                              ЗАКАЗ: №" + Номер_заказаTextBox.Text)
        text.WriteLine("Кому: " + ComboBox1.Text)
        text.WriteLine("Паспортные данные заказчика: " + ComboBox2.Text)
        text.WriteLine("Сотрудник, обслуживающий клиента: " + ФамилияComboBox.SelectedItem)
        text.WriteLine("Услуга: " + Название_услугиComboBox.SelectedItem)
        text.WriteLine("Количество: " + TextBox1.Text)
        text.WriteLine("Вид оплаты: " + ComboBox3.Text)
        text.WriteLine("------------------------------------------------------------------")
        text.WriteLine("Дата заказа: " + DateTime.Now)

        text.WriteLine("------------------------------------------------------------------")
        text.WriteLine("Итого к оплате: " + Label3.Text + " руб.")
        text.Close()
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("order_list.txt")
        MsgBox(fileReader)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) 
        Ex.Visible = True
        BookEx = Ex.Workbooks.Add
        PageEx = BookEx.Worksheets(1)
        PageEx.Activate()
        PageEx.Range("a1:c1").MergeCells = True
        PageEx.Range("a1:c1").Value = "Акт выполненных работ типографии"
        PageEx.Range("a1:c1").Font.Bold = True
        PageEx.Range("a1:c1").Font.Size = 16
        PageEx.Range("a1:h100").ColumnWidth = 25
        PageEx.Range("a1:c10").Borders.LineStyle = XlLineStyle.xlContinuous
        PageEx.Range("a1:c1").HorizontalAlignment = XlHAlign.xlHAlignCenter
        PageEx.Range("a2").Value = "Наименование услуги"
        PageEx.Range("b2").Value = "Сотрудник, выполнявший заказ"
        PageEx.Range("c2").Value = "Дата выполнения заказа"

        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM Заказ1"
        cn.Open()
        dr = cmd.ExecuteReader
        Dim i As Integer
        i = 3
        While dr.Read
            PageEx.Cells(i, 1) = dr("Вид_услуги")
            PageEx.Range("i1").HorizontalAlignment = XlHAlign.xlHAlignCenter
            PageEx.Cells(i, 2) = dr("Фамилия_сотрудника")

            PageEx.Cells(i, 3) = dr("Дата_оформления_заказа")
            i = i + 1
        End While
        cn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (Название_услугиComboBox.SelectedIndex = 0) Then
            Dim a As Integer
            Dim c As String = TextBox1.Text
            a = Convert.ToInt32(c)
            Dim cost As Double = 0.8
            Dim b As Double = cost * a
            Label3.Text = b.ToString()
        End If
        If (Название_услугиComboBox.SelectedIndex = 1) Then
            Dim a As Integer
            Dim c As String = TextBox1.Text
            a = Convert.ToInt32(c)
            Dim cost As Double = 1.6
            Dim b As Double = cost * a
            Label3.Text = b.ToString()
        End If
        If (Название_услугиComboBox.SelectedIndex = 2) Then
            Dim a As Integer
            Dim c As String = TextBox1.Text
            a = Convert.ToInt32(c)
            Dim cost As Double = 2.2
            Dim b As Double = cost * a
            Label3.Text = b.ToString()
        End If
        If (Название_услугиComboBox.SelectedIndex = 3) Then
            Dim a As Integer
            Dim c As String = TextBox1.Text
            a = Convert.ToInt32(c)
            Dim cost As Double = 6
            Dim b As Double = cost * a
            Label3.Text = b.ToString()
        End If
        If (Название_услугиComboBox.SelectedIndex = 4) Then
            Dim a As Integer
            Dim c As String = TextBox1.Text
            a = Convert.ToInt32(c)
            Dim cost As Double = 3
            Dim b As Double = cost * a
            Label3.Text = b.ToString()
        End If
        If (Название_услугиComboBox.SelectedIndex = 5) Then
            Dim a As Integer
            Dim c As String = TextBox1.Text
            a = Convert.ToInt32(c)
            Dim cost As Double = 2.5
            Dim b As Double = cost * a
            Label3.Text = b.ToString()
        End If
        If (Название_услугиComboBox.SelectedIndex = 6) Then
            Dim a As Integer
            Dim c As String = TextBox1.Text
            a = Convert.ToInt32(c)
            Dim cost As Double = 3
            Dim b As Double = cost * a
            Label3.Text = b.ToString()
        End If
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Ex.Visible = True
        BookEx = Ex.Workbooks.Add
        PageEx = BookEx.Worksheets(1)
        PageEx.Activate()
        PageEx.Range("a1:c1").MergeCells = True
        PageEx.Range("a1:c1").Value = "Акт выполненных работ полиграфии"
        PageEx.Range("a1:c1").Font.Bold = True
        PageEx.Range("a1:c1").Font.Size = 20
        PageEx.Range("a1:h100").ColumnWidth = 50
        PageEx.Range("a1:c10").Borders.LineStyle = XlLineStyle.xlContinuous
        PageEx.Range("a1:c1").HorizontalAlignment = XlHAlign.xlHAlignCenter
        PageEx.Range("a2").Value = "Наименование услуги"
        PageEx.Range("b2").Value = "Сотрудник, выполнявший заказ"
        PageEx.Range("c2").Value = "Дата оформления заказа"
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM Заказ1"
        cn.Open()
        dr = cmd.ExecuteReader
        Dim i As Integer
        i = 3
        While dr.Read
            PageEx.Cells(i, 1) = dr("Вид_услуги")
            PageEx.Range("i1").HorizontalAlignment = XlHAlign.xlHAlignCenter
            PageEx.Cells(i, 2) = dr("Фамилия_сотрудника")

            PageEx.Cells(i, 3) = dr("Дата_оформления_заказа")
            i = i + 1
        End While
        cn.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim text As StreamWriter
        text = New StreamWriter("zak.doc")
        text.WriteLine("                   Договор-заказ на оформление: №" + Номер_заказаTextBox.Text)
        text.WriteLine("Организация: " + "ООО «Друк Сервис».")
        text.WriteLine("ИСПОЛНИТЕЛЕМ предоставляет гарантию товара на предостовляемые услуги ИСПОЛНИТЕЛЕМ.")
        text.WriteLine("Фактом полного расчёта за выполненную работу является подпись ИСПОЛНИТЕЛЯ.")
        text.WriteLine("Фамилия заказчика: " + ComboBox1.Text)
        text.WriteLine("Паспортные данные заказчика: " + ComboBox2.Text)
        text.WriteLine("Услуга: " + Название_услугиComboBox.SelectedItem)
        text.WriteLine("Количество заказываемой услуги: " + TextBox1.Text)
        text.WriteLine("Вид оплаты: " + ComboBox3.Text)
        text.WriteLine("Итого к оплате: " + Label3.Text + " руб.")
        text.WriteLine("Сумма за услугу вносится ЗАКАЗЧИКОМ в момент подписания данного договора.")
        text.WriteLine("Директор организации: Угначёв A.A")
        text.WriteLine("Место подписи для организации:_________________")
        text.WriteLine("Подпись со стороны заказчика:_________________")
        text.WriteLine("Дата оформления заказа: " + DateTime.Now)
        text.Close()
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("zak.doc")

    End Sub


End Class