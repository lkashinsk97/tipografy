<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form9
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ФамилияLabel As System.Windows.Forms.Label
        Dim Название_услугиLabel As System.Windows.Forms.Label
        Dim ФамилияLabel1 As System.Windows.Forms.Label
        Dim Дата_оформления_заказаLabel As System.Windows.Forms.Label
        Dim Номер_заказаLabel As System.Windows.Forms.Label
        Dim Паспортные_данныеLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form9))
        Me.ТипографияDataSet = New tipografi.ТипографияDataSet()
        Me.КлиентBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.КлиентTableAdapter = New tipografi.ТипографияDataSetTableAdapters.КлиентTableAdapter()
        Me.TableAdapterManager = New tipografi.ТипографияDataSetTableAdapters.TableAdapterManager()
        Me.ЗаказTableAdapter = New tipografi.ТипографияDataSetTableAdapters.ЗаказTableAdapter()
        Me.СотрудникTableAdapter = New tipografi.ТипографияDataSetTableAdapters.СотрудникTableAdapter()
        Me.УслугаTableAdapter = New tipografi.ТипографияDataSetTableAdapters.УслугаTableAdapter()
        Me.КлиентBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.КлиентBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.УслугаBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Название_услугиComboBox = New System.Windows.Forms.ComboBox()
        Me.СотрудникBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ФамилияComboBox = New System.Windows.Forms.ComboBox()
        Me.ЗаказBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Дата_оформления_заказаDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Номер_заказаTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        ФамилияLabel = New System.Windows.Forms.Label()
        Название_услугиLabel = New System.Windows.Forms.Label()
        ФамилияLabel1 = New System.Windows.Forms.Label()
        Дата_оформления_заказаLabel = New System.Windows.Forms.Label()
        Номер_заказаLabel = New System.Windows.Forms.Label()
        Паспортные_данныеLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.ТипографияDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.КлиентBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.КлиентBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.КлиентBindingNavigator.SuspendLayout()
        CType(Me.УслугаBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СотрудникBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЗаказBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ФамилияLabel
        '
        ФамилияLabel.AutoSize = True
        ФамилияLabel.Location = New System.Drawing.Point(84, 63)
        ФамилияLabel.Name = "ФамилияLabel"
        ФамилияLabel.Size = New System.Drawing.Size(59, 13)
        ФамилияLabel.TabIndex = 1
        ФамилияLabel.Text = "Фамилия:"
        '
        'Название_услугиLabel
        '
        Название_услугиLabel.AutoSize = True
        Название_услугиLabel.Location = New System.Drawing.Point(47, 34)
        Название_услугиLabel.Name = "Название_услугиLabel"
        Название_услугиLabel.Size = New System.Drawing.Size(96, 13)
        Название_услугиLabel.TabIndex = 3
        Название_услугиLabel.Text = "Название услуги:"
        '
        'ФамилияLabel1
        '
        ФамилияLabel1.AutoSize = True
        ФамилияLabel1.Location = New System.Drawing.Point(23, 146)
        ФамилияLabel1.Name = "ФамилияLabel1"
        ФамилияLabel1.Size = New System.Drawing.Size(120, 13)
        ФамилияLabel1.TabIndex = 5
        ФамилияLabel1.Text = "Фамилия сотрудника:"
        '
        'Дата_оформления_заказаLabel
        '
        Дата_оформления_заказаLabel.AutoSize = True
        Дата_оформления_заказаLabel.Location = New System.Drawing.Point(1, 175)
        Дата_оформления_заказаLabel.Name = "Дата_оформления_заказаLabel"
        Дата_оформления_заказаLabel.Size = New System.Drawing.Size(142, 13)
        Дата_оформления_заказаLabel.TabIndex = 7
        Дата_оформления_заказаLabel.Text = "Дата оформления заказа:"
        '
        'Номер_заказаLabel
        '
        Номер_заказаLabel.AutoSize = True
        Номер_заказаLabel.Location = New System.Drawing.Point(60, 239)
        Номер_заказаLabel.Name = "Номер_заказаLabel"
        Номер_заказаLabel.Size = New System.Drawing.Size(83, 13)
        Номер_заказаLabel.TabIndex = 9
        Номер_заказаLabel.Text = "Номер заказа:"
        '
        'Паспортные_данныеLabel
        '
        Паспортные_данныеLabel.AutoSize = True
        Паспортные_данныеLabel.Location = New System.Drawing.Point(29, 90)
        Паспортные_данныеLabel.Name = "Паспортные_данныеLabel"
        Паспортные_данныеLabel.Size = New System.Drawing.Size(114, 13)
        Паспортные_данныеLabel.TabIndex = 15
        Паспортные_данныеLabel.Text = "Паспортные данные:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(74, 116)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(69, 13)
        Label1.TabIndex = 22
        Label1.Text = "Количество:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(74, 208)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(69, 13)
        Label2.TabIndex = 23
        Label2.Text = "Вид оплаты:"
        '
        'ТипографияDataSet
        '
        Me.ТипографияDataSet.DataSetName = "ТипографияDataSet"
        Me.ТипографияDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'КлиентBindingSource
        '
        Me.КлиентBindingSource.DataMember = "Клиент"
        Me.КлиентBindingSource.DataSource = Me.ТипографияDataSet
        '
        'КлиентTableAdapter
        '
        Me.КлиентTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = tipografi.ТипографияDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Выполнение_заказаTableAdapter = Nothing
        Me.TableAdapterManager.Должность_сотрудникаTableAdapter = Nothing
        Me.TableAdapterManager.Заказ1TableAdapter = Nothing
        Me.TableAdapterManager.ЗаказTableAdapter = Me.ЗаказTableAdapter
        Me.TableAdapterManager.КлиентTableAdapter = Me.КлиентTableAdapter
        Me.TableAdapterManager.СотрудникTableAdapter = Me.СотрудникTableAdapter
        Me.TableAdapterManager.УслугаTableAdapter = Me.УслугаTableAdapter
        '
        'ЗаказTableAdapter
        '
        Me.ЗаказTableAdapter.ClearBeforeFill = True
        '
        'СотрудникTableAdapter
        '
        Me.СотрудникTableAdapter.ClearBeforeFill = True
        '
        'УслугаTableAdapter
        '
        Me.УслугаTableAdapter.ClearBeforeFill = True
        '
        'КлиентBindingNavigator
        '
        Me.КлиентBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.КлиентBindingNavigator.BindingSource = Me.КлиентBindingSource
        Me.КлиентBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.КлиентBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.КлиентBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.КлиентBindingNavigatorSaveItem})
        Me.КлиентBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.КлиентBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.КлиентBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.КлиентBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.КлиентBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.КлиентBindingNavigator.Name = "КлиентBindingNavigator"
        Me.КлиентBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.КлиентBindingNavigator.Size = New System.Drawing.Size(700, 25)
        Me.КлиентBindingNavigator.TabIndex = 0
        Me.КлиентBindingNavigator.Text = "BindingNavigator1"
        Me.КлиентBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Добавить"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Общее число элементов"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Удалить"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Переместить в начало"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Переместить назад"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Положение"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Текущее положение"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Переместить вперед"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Переместить в конец"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'КлиентBindingNavigatorSaveItem
        '
        Me.КлиентBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.КлиентBindingNavigatorSaveItem.Image = CType(resources.GetObject("КлиентBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.КлиентBindingNavigatorSaveItem.Name = "КлиентBindingNavigatorSaveItem"
        Me.КлиентBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.КлиентBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'УслугаBindingSource
        '
        Me.УслугаBindingSource.DataMember = "Услуга"
        Me.УслугаBindingSource.DataSource = Me.ТипографияDataSet
        '
        'Название_услугиComboBox
        '
        Me.Название_услугиComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.УслугаBindingSource, "Название_услуги", True))
        Me.Название_услугиComboBox.FormattingEnabled = True
        Me.Название_услугиComboBox.Items.AddRange(New Object() {"Печать односторонняя", "Печать двусторонняя", "Лакированная печать", "Фото на документы", "Печать фотографий", "Создание визитки", "Создание календаря"})
        Me.Название_услугиComboBox.Location = New System.Drawing.Point(149, 32)
        Me.Название_услугиComboBox.Name = "Название_услугиComboBox"
        Me.Название_услугиComboBox.Size = New System.Drawing.Size(196, 21)
        Me.Название_услугиComboBox.TabIndex = 4
        '
        'СотрудникBindingSource
        '
        Me.СотрудникBindingSource.DataMember = "Сотрудник"
        Me.СотрудникBindingSource.DataSource = Me.ТипографияDataSet
        '
        'ФамилияComboBox
        '
        Me.ФамилияComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СотрудникBindingSource, "Фамилия", True))
        Me.ФамилияComboBox.FormattingEnabled = True
        Me.ФамилияComboBox.Items.AddRange(New Object() {"Иванов", "Булаш", "Сергеев", "Петренко", "Коган", "Мартин", "Тонк"})
        Me.ФамилияComboBox.Location = New System.Drawing.Point(149, 144)
        Me.ФамилияComboBox.Name = "ФамилияComboBox"
        Me.ФамилияComboBox.Size = New System.Drawing.Size(196, 21)
        Me.ФамилияComboBox.TabIndex = 6
        '
        'ЗаказBindingSource
        '
        Me.ЗаказBindingSource.DataMember = "Номер_клиента_ch"
        Me.ЗаказBindingSource.DataSource = Me.КлиентBindingSource
        '
        'Дата_оформления_заказаDateTimePicker
        '
        Me.Дата_оформления_заказаDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ЗаказBindingSource, "Дата_оформления_заказа", True))
        Me.Дата_оформления_заказаDateTimePicker.Enabled = False
        Me.Дата_оформления_заказаDateTimePicker.Location = New System.Drawing.Point(149, 174)
        Me.Дата_оформления_заказаDateTimePicker.Name = "Дата_оформления_заказаDateTimePicker"
        Me.Дата_оформления_заказаDateTimePicker.Size = New System.Drawing.Size(275, 20)
        Me.Дата_оформления_заказаDateTimePicker.TabIndex = 8
        Me.Дата_оформления_заказаDateTimePicker.Value = New Date(2020, 8, 6, 7, 0, 0, 0, 0)
        '
        'Номер_заказаTextBox
        '
        Me.Номер_заказаTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ЗаказBindingSource, "Номер_заказа", True))
        Me.Номер_заказаTextBox.Location = New System.Drawing.Point(149, 238)
        Me.Номер_заказаTextBox.Name = "Номер_заказаTextBox"
        Me.Номер_заказаTextBox.Size = New System.Drawing.Size(196, 20)
        Me.Номер_заказаTextBox.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Sylfaen", 17.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(362, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(248, 56)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Оформить заказ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Sylfaen", 17.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button3.Location = New System.Drawing.Point(362, 88)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(248, 80)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Получить лист" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "заказа"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.КлиентBindingSource, "Фамилия", True))
        Me.ComboBox1.DataSource = Me.КлиентBindingSource
        Me.ComboBox1.DisplayMember = "Фамилия"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(149, 61)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(196, 21)
        Me.ComboBox1.TabIndex = 19
        Me.ComboBox1.ValueMember = "Фамилия"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.КлиентBindingSource, "Паспортные_данные", True))
        Me.ComboBox2.DataSource = Me.КлиентBindingSource
        Me.ComboBox2.DisplayMember = "Паспортные_данные"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(149, 88)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(196, 21)
        Me.ComboBox2.TabIndex = 20
        Me.ComboBox2.ValueMember = "Паспортные_данные"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ЗаказBindingSource, "Номер_заказа", True))
        Me.TextBox1.Location = New System.Drawing.Point(149, 115)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(196, 20)
        Me.TextBox1.TabIndex = 21
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Наличные деньги", "Банковская карта"})
        Me.ComboBox3.Location = New System.Drawing.Point(149, 206)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(196, 21)
        Me.ComboBox3.TabIndex = 24
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Sylfaen", 17.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button2.Location = New System.Drawing.Point(430, 174)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(180, 106)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Рассчитать стоимость заказа"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sylfaen", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(510, 302)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 25)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sylfaen", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(319, 302)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 25)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Стоимость заказа:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Sylfaen", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(559, 302)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 25)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "руб."
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Sylfaen", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button4.Location = New System.Drawing.Point(26, 342)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(273, 34)
        Me.Button4.TabIndex = 29
        Me.Button4.Text = "Акт выполненных услуг"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Sylfaen", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button5.Location = New System.Drawing.Point(26, 302)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(273, 34)
        Me.Button5.TabIndex = 30
        Me.Button5.Text = "Получить договор о заказе"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Sylfaen", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label6.Location = New System.Drawing.Point(27, 396)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(299, 25)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Стоимость услуг за 1 единицу:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 431)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Sylfaen", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label8.Location = New System.Drawing.Point(82, 431)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(347, 25)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "— Печать одностороняя: 80 копеек."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Sylfaen", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label9.Location = New System.Drawing.Point(82, 457)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(364, 25)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "— Печать двусторонняя: 1,6 бел. руб." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Sylfaen", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label10.Location = New System.Drawing.Point(82, 482)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(364, 25)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "— Лакированная печать: 2,2 бел. руб."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Sylfaen", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label11.Location = New System.Drawing.Point(82, 507)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(332, 25)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "— Фото на документы: 6 бел. руб."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Sylfaen", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label12.Location = New System.Drawing.Point(82, 532)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(330, 25)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "— Печать фотографий: 3 бел. руб."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Sylfaen", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label13.Location = New System.Drawing.Point(82, 557)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(333, 25)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "— Создание визитки: 2,5 бел. руб."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Sylfaen", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label14.Location = New System.Drawing.Point(82, 582)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(336, 25)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "— Создание календаря: 3 бел. руб."
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(637, 625)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Паспортные_данныеLabel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Номер_заказаLabel)
        Me.Controls.Add(Me.Номер_заказаTextBox)
        Me.Controls.Add(Дата_оформления_заказаLabel)
        Me.Controls.Add(Me.Дата_оформления_заказаDateTimePicker)
        Me.Controls.Add(ФамилияLabel1)
        Me.Controls.Add(Me.ФамилияComboBox)
        Me.Controls.Add(Название_услугиLabel)
        Me.Controls.Add(Me.Название_услугиComboBox)
        Me.Controls.Add(ФамилияLabel)
        Me.Controls.Add(Me.КлиентBindingNavigator)
        Me.Name = "Form9"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Добавить заказ"
        CType(Me.ТипографияDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.КлиентBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.КлиентBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.КлиентBindingNavigator.ResumeLayout(False)
        Me.КлиентBindingNavigator.PerformLayout()
        CType(Me.УслугаBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.СотрудникBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЗаказBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ТипографияDataSet As ТипографияDataSet
    Friend WithEvents КлиентBindingSource As BindingSource
    Friend WithEvents КлиентTableAdapter As ТипографияDataSetTableAdapters.КлиентTableAdapter
    Friend WithEvents TableAdapterManager As ТипографияDataSetTableAdapters.TableAdapterManager
    Friend WithEvents КлиентBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents КлиентBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents УслугаTableAdapter As ТипографияDataSetTableAdapters.УслугаTableAdapter
    Friend WithEvents УслугаBindingSource As BindingSource
    Friend WithEvents Название_услугиComboBox As ComboBox
    Friend WithEvents СотрудникTableAdapter As ТипографияDataSetTableAdapters.СотрудникTableAdapter
    Friend WithEvents СотрудникBindingSource As BindingSource
    Friend WithEvents ФамилияComboBox As ComboBox
    Friend WithEvents ЗаказTableAdapter As ТипографияDataSetTableAdapters.ЗаказTableAdapter
    Friend WithEvents ЗаказBindingSource As BindingSource
    Friend WithEvents Дата_оформления_заказаDateTimePicker As DateTimePicker
    Friend WithEvents Номер_заказаTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
End Class
