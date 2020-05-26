<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ОтчетыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СотрудникиТипографииToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПредоставляемыеУслуиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.КлиентыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(76, 99)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(444, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Сотрудники полиграфии"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(76, 128)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(444, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Услуги"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(76, 157)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(444, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Заказчики"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(76, 186)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(444, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Заказы"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Location = New System.Drawing.Point(432, 287)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(137, 31)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Назад"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ОтчетыToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(581, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ОтчетыToolStripMenuItem
        '
        Me.ОтчетыToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СотрудникиТипографииToolStripMenuItem, Me.ПредоставляемыеУслуиToolStripMenuItem, Me.КлиентыToolStripMenuItem})
        Me.ОтчетыToolStripMenuItem.Name = "ОтчетыToolStripMenuItem"
        Me.ОтчетыToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ОтчетыToolStripMenuItem.Text = "Отчеты"
        '
        'СотрудникиТипографииToolStripMenuItem
        '
        Me.СотрудникиТипографииToolStripMenuItem.Name = "СотрудникиТипографииToolStripMenuItem"
        Me.СотрудникиТипографииToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.СотрудникиТипографииToolStripMenuItem.Text = "Сотрудники полиграфии"
        '
        'ПредоставляемыеУслуиToolStripMenuItem
        '
        Me.ПредоставляемыеУслуиToolStripMenuItem.Name = "ПредоставляемыеУслуиToolStripMenuItem"
        Me.ПредоставляемыеУслуиToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ПредоставляемыеУслуиToolStripMenuItem.Text = "Предоставляемые услуи"
        '
        'КлиентыToolStripMenuItem
        '
        Me.КлиентыToolStripMenuItem.Name = "КлиентыToolStripMenuItem"
        Me.КлиентыToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.КлиентыToolStripMenuItem.Text = "Клиенты"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(581, 330)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Для сотрудников"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ОтчетыToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СотрудникиТипографииToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ПредоставляемыеУслуиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents КлиентыToolStripMenuItem As ToolStripMenuItem
End Class
