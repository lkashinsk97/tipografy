<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form10))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.ТипографияDataSet = New tipografi.ТипографияDataSet()
        Me.СотрудникBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.СотрудникTableAdapter = New tipografi.ТипографияDataSetTableAdapters.СотрудникTableAdapter()
        Me.TableAdapterManager = New tipografi.ТипографияDataSetTableAdapters.TableAdapterManager()
        Me.Должность_сотрудникаTableAdapter = New tipografi.ТипографияDataSetTableAdapters.Должность_сотрудникаTableAdapter()
        Me.СотрудникBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.СотрудникBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Дата_рожденияDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Дата_принятия_на_работуDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Должность_сотрудникаBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.ТипографияDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СотрудникBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СотрудникBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.СотрудникBindingNavigator.SuspendLayout()
        CType(Me.Должность_сотрудникаBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Личный номер сотрудника:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(152, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Фамилия:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(177, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Имя:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(152, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Отчество:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(126, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Дата Рождения:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(71, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Дата принятия на работу:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(219, 52)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 20)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(219, 82)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(200, 20)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(219, 108)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(200, 20)
        Me.TextBox3.TabIndex = 8
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(219, 137)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(200, 20)
        Me.TextBox4.TabIndex = 9
        '
        'ТипографияDataSet
        '
        Me.ТипографияDataSet.DataSetName = "ТипографияDataSet"
        Me.ТипографияDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'СотрудникBindingSource
        '
        Me.СотрудникBindingSource.DataMember = "Сотрудник"
        Me.СотрудникBindingSource.DataSource = Me.ТипографияDataSet
        '
        'СотрудникTableAdapter
        '
        Me.СотрудникTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = tipografi.ТипографияDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Выполнение_заказаTableAdapter = Nothing
        Me.TableAdapterManager.Должность_сотрудникаTableAdapter = Me.Должность_сотрудникаTableAdapter
        Me.TableAdapterManager.Заказ1TableAdapter = Nothing
        Me.TableAdapterManager.ЗаказTableAdapter = Nothing
        Me.TableAdapterManager.КлиентTableAdapter = Nothing
        Me.TableAdapterManager.СотрудникTableAdapter = Me.СотрудникTableAdapter
        Me.TableAdapterManager.УслугаTableAdapter = Nothing
        '
        'Должность_сотрудникаTableAdapter
        '
        Me.Должность_сотрудникаTableAdapter.ClearBeforeFill = True
        '
        'СотрудникBindingNavigator
        '
        Me.СотрудникBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.СотрудникBindingNavigator.BindingSource = Me.СотрудникBindingSource
        Me.СотрудникBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.СотрудникBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.СотрудникBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.СотрудникBindingNavigatorSaveItem})
        Me.СотрудникBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.СотрудникBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.СотрудникBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.СотрудникBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.СотрудникBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.СотрудникBindingNavigator.Name = "СотрудникBindingNavigator"
        Me.СотрудникBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.СотрудникBindingNavigator.Size = New System.Drawing.Size(440, 25)
        Me.СотрудникBindingNavigator.TabIndex = 10
        Me.СотрудникBindingNavigator.Text = "BindingNavigator1"
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
        'СотрудникBindingNavigatorSaveItem
        '
        Me.СотрудникBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.СотрудникBindingNavigatorSaveItem.Image = CType(resources.GetObject("СотрудникBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.СотрудникBindingNavigatorSaveItem.Name = "СотрудникBindingNavigatorSaveItem"
        Me.СотрудникBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.СотрудникBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'Дата_рожденияDateTimePicker
        '
        Me.Дата_рожденияDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.СотрудникBindingSource, "Дата_рождения", True))
        Me.Дата_рожденияDateTimePicker.Location = New System.Drawing.Point(219, 163)
        Me.Дата_рожденияDateTimePicker.Name = "Дата_рожденияDateTimePicker"
        Me.Дата_рожденияDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Дата_рожденияDateTimePicker.TabIndex = 12
        '
        'Дата_принятия_на_работуDateTimePicker
        '
        Me.Дата_принятия_на_работуDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.СотрудникBindingSource, "Дата_принятия_на_работу", True))
        Me.Дата_принятия_на_работуDateTimePicker.Location = New System.Drawing.Point(219, 189)
        Me.Дата_принятия_на_работуDateTimePicker.Name = "Дата_принятия_на_работуDateTimePicker"
        Me.Дата_принятия_на_работуDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Дата_принятия_на_работуDateTimePicker.TabIndex = 13
        '
        'Должность_сотрудникаBindingSource
        '
        Me.Должность_сотрудникаBindingSource.DataMember = "Номер_сотрудника_c"
        Me.Должность_сотрудникаBindingSource.DataSource = Me.СотрудникBindingSource
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(263, 254)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(156, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Добавить сотрудника"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(440, 310)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Дата_принятия_на_работуDateTimePicker)
        Me.Controls.Add(Me.Дата_рожденияDateTimePicker)
        Me.Controls.Add(Me.СотрудникBindingNavigator)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form10"
        Me.Text = "Form10"
        CType(Me.ТипографияDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.СотрудникBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.СотрудникBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.СотрудникBindingNavigator.ResumeLayout(False)
        Me.СотрудникBindingNavigator.PerformLayout()
        CType(Me.Должность_сотрудникаBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents ТипографияDataSet As ТипографияDataSet
    Friend WithEvents СотрудникBindingSource As BindingSource
    Friend WithEvents СотрудникTableAdapter As ТипографияDataSetTableAdapters.СотрудникTableAdapter
    Friend WithEvents TableAdapterManager As ТипографияDataSetTableAdapters.TableAdapterManager
    Friend WithEvents СотрудникBindingNavigator As BindingNavigator
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
    Friend WithEvents СотрудникBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Должность_сотрудникаTableAdapter As ТипографияDataSetTableAdapters.Должность_сотрудникаTableAdapter
    Friend WithEvents Дата_рожденияDateTimePicker As DateTimePicker
    Friend WithEvents Дата_принятия_на_работуDateTimePicker As DateTimePicker
    Friend WithEvents Должность_сотрудникаBindingSource As BindingSource
    Friend WithEvents Button1 As Button
End Class
