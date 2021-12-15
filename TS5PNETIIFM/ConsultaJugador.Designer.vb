<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaJugador
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.nombreTxt = New System.Windows.Forms.TextBox()
        Me.jugadoresCB = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.apellidoTxt = New System.Windows.Forms.TextBox()
        Me.posicionTxt = New System.Windows.Forms.TextBox()
        Me.equipoTxt = New System.Windows.Forms.TextBox()
        Me.camisetaTxt = New System.Windows.Forms.TextBox()
        Me.fechaNactxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'nombreTxt
        '
        Me.nombreTxt.Location = New System.Drawing.Point(208, 65)
        Me.nombreTxt.Name = "nombreTxt"
        Me.nombreTxt.Size = New System.Drawing.Size(100, 23)
        Me.nombreTxt.TabIndex = 0
        '
        'jugadoresCB
        '
        Me.jugadoresCB.FormattingEnabled = True
        Me.jugadoresCB.Location = New System.Drawing.Point(34, 65)
        Me.jugadoresCB.Name = "jugadoresCB"
        Me.jugadoresCB.Size = New System.Drawing.Size(121, 23)
        Me.jugadoresCB.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Jugador"
        '
        'apellidoTxt
        '
        Me.apellidoTxt.Location = New System.Drawing.Point(333, 65)
        Me.apellidoTxt.Name = "apellidoTxt"
        Me.apellidoTxt.Size = New System.Drawing.Size(100, 23)
        Me.apellidoTxt.TabIndex = 3
        '
        'posicionTxt
        '
        Me.posicionTxt.Location = New System.Drawing.Point(208, 146)
        Me.posicionTxt.Name = "posicionTxt"
        Me.posicionTxt.Size = New System.Drawing.Size(100, 23)
        Me.posicionTxt.TabIndex = 4
        '
        'equipoTxt
        '
        Me.equipoTxt.Location = New System.Drawing.Point(333, 146)
        Me.equipoTxt.Name = "equipoTxt"
        Me.equipoTxt.Size = New System.Drawing.Size(100, 23)
        Me.equipoTxt.TabIndex = 5
        '
        'camisetaTxt
        '
        Me.camisetaTxt.Location = New System.Drawing.Point(208, 240)
        Me.camisetaTxt.Name = "camisetaTxt"
        Me.camisetaTxt.Size = New System.Drawing.Size(100, 23)
        Me.camisetaTxt.TabIndex = 6
        '
        'fechaNactxt
        '
        Me.fechaNactxt.Location = New System.Drawing.Point(333, 240)
        Me.fechaNactxt.Name = "fechaNactxt"
        Me.fechaNactxt.Size = New System.Drawing.Size(100, 23)
        Me.fechaNactxt.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(208, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(333, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(208, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Posición"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(333, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Equipo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(208, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Número Camiseta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(333, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Fecha Nac."
        '
        'ConsultaJugador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 328)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fechaNactxt)
        Me.Controls.Add(Me.camisetaTxt)
        Me.Controls.Add(Me.equipoTxt)
        Me.Controls.Add(Me.posicionTxt)
        Me.Controls.Add(Me.apellidoTxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.jugadoresCB)
        Me.Controls.Add(Me.nombreTxt)
        Me.Name = "ConsultaJugador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ConsultaJugador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nombreTxt As TextBox
    Friend WithEvents jugadoresCB As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents apellidoTxt As TextBox
    Friend WithEvents posicionTxt As TextBox
    Friend WithEvents equipoTxt As TextBox
    Friend WithEvents camisetaTxt As TextBox
    Friend WithEvents fechaNactxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
