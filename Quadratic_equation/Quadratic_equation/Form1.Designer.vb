<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Quadratic_equation = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.a = New System.Windows.Forms.TextBox()
        Me.b = New System.Windows.Forms.TextBox()
        Me.c = New System.Windows.Forms.TextBox()
        Me.x1 = New System.Windows.Forms.TextBox()
        Me.x2 = New System.Windows.Forms.TextBox()
        Me.Calculate = New System.Windows.Forms.Button()
        Me.Close = New System.Windows.Forms.Button()
        Me.No_solution = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Quadratic_equation
        '
        Me.Quadratic_equation.AutoSize = True
        Me.Quadratic_equation.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Quadratic_equation.Location = New System.Drawing.Point(300, 58)
        Me.Quadratic_equation.Name = "Quadratic_equation"
        Me.Quadratic_equation.Size = New System.Drawing.Size(204, 31)
        Me.Quadratic_equation.TabIndex = 0
        Me.Quadratic_equation.Text = "a.x^2+b.x+c=0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(158, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "a="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(158, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "b="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(158, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "c="
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(422, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "x1="
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.Location = New System.Drawing.Point(422, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "x2="
        '
        'a
        '
        Me.a.Location = New System.Drawing.Point(195, 156)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(100, 20)
        Me.a.TabIndex = 6
        '
        'b
        '
        Me.b.Location = New System.Drawing.Point(196, 213)
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(100, 20)
        Me.b.TabIndex = 7
        '
        'c
        '
        Me.c.Location = New System.Drawing.Point(196, 272)
        Me.c.Name = "c"
        Me.c.Size = New System.Drawing.Size(100, 20)
        Me.c.TabIndex = 8
        '
        'x1
        '
        Me.x1.Location = New System.Drawing.Point(469, 155)
        Me.x1.Name = "x1"
        Me.x1.Size = New System.Drawing.Size(100, 20)
        Me.x1.TabIndex = 9
        '
        'x2
        '
        Me.x2.Location = New System.Drawing.Point(469, 214)
        Me.x2.Name = "x2"
        Me.x2.Size = New System.Drawing.Size(100, 20)
        Me.x2.TabIndex = 10
        '
        'Calculate
        '
        Me.Calculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Calculate.Location = New System.Drawing.Point(196, 372)
        Me.Calculate.Name = "Calculate"
        Me.Calculate.Size = New System.Drawing.Size(159, 43)
        Me.Calculate.TabIndex = 11
        Me.Calculate.Text = "Сметни"
        Me.Calculate.UseVisualStyleBackColor = True
        '
        'Close
        '
        Me.Close.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Close.Location = New System.Drawing.Point(469, 372)
        Me.Close.Name = "Close"
        Me.Close.Size = New System.Drawing.Size(159, 43)
        Me.Close.TabIndex = 12
        Me.Close.Text = "Край"
        Me.Close.UseVisualStyleBackColor = True
        '
        'No_solution
        '
        Me.No_solution.AutoSize = True
        Me.No_solution.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.No_solution.Location = New System.Drawing.Point(303, 320)
        Me.No_solution.Name = "No_solution"
        Me.No_solution.Size = New System.Drawing.Size(0, 31)
        Me.No_solution.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.No_solution)
        Me.Controls.Add(Me.Close)
        Me.Controls.Add(Me.Calculate)
        Me.Controls.Add(Me.x2)
        Me.Controls.Add(Me.x1)
        Me.Controls.Add(Me.c)
        Me.Controls.Add(Me.b)
        Me.Controls.Add(Me.a)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Quadratic_equation)
        Me.Name = "Form1"
        Me.Text = "Квадратно уравнение"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Quadratic_equation As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents a As TextBox
    Friend WithEvents b As TextBox
    Friend WithEvents c As TextBox
    Friend WithEvents x1 As TextBox
    Friend WithEvents x2 As TextBox
    Friend WithEvents Calculate As Button
    Friend WithEvents Close As Button
    Friend WithEvents No_solution As Label
End Class
