<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarJugador
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
        Me.jugadoresCB = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.detalleJugadorGB = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.posicionCB = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fechaNactxt = New System.Windows.Forms.TextBox()
        Me.camisetaTxt = New System.Windows.Forms.TextBox()
        Me.apellidoTxt = New System.Windows.Forms.TextBox()
        Me.equiposCB = New System.Windows.Forms.ComboBox()
        Me.nombreTxt = New System.Windows.Forms.TextBox()
        Me.detalleJugadorGB.SuspendLayout()
        Me.SuspendLayout()
        '
        'jugadoresCB
        '
        Me.jugadoresCB.FormattingEnabled = True
        Me.jugadoresCB.Location = New System.Drawing.Point(12, 80)
        Me.jugadoresCB.Name = "jugadoresCB"
        Me.jugadoresCB.Size = New System.Drawing.Size(118, 23)
        Me.jugadoresCB.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 15)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Jugador"
        '
        'detalleJugadorGB
        '
        Me.detalleJugadorGB.Controls.Add(Me.Button1)
        Me.detalleJugadorGB.Controls.Add(Me.posicionCB)
        Me.detalleJugadorGB.Controls.Add(Me.Label7)
        Me.detalleJugadorGB.Controls.Add(Me.Label6)
        Me.detalleJugadorGB.Controls.Add(Me.Label5)
        Me.detalleJugadorGB.Controls.Add(Me.Label4)
        Me.detalleJugadorGB.Controls.Add(Me.Label3)
        Me.detalleJugadorGB.Controls.Add(Me.Label2)
        Me.detalleJugadorGB.Controls.Add(Me.fechaNactxt)
        Me.detalleJugadorGB.Controls.Add(Me.camisetaTxt)
        Me.detalleJugadorGB.Controls.Add(Me.apellidoTxt)
        Me.detalleJugadorGB.Controls.Add(Me.equiposCB)
        Me.detalleJugadorGB.Controls.Add(Me.nombreTxt)
        Me.detalleJugadorGB.Location = New System.Drawing.Point(175, 45)
        Me.detalleJugadorGB.Name = "detalleJugadorGB"
        Me.detalleJugadorGB.Size = New System.Drawing.Size(361, 353)
        Me.detalleJugadorGB.TabIndex = 46
        Me.detalleJugadorGB.TabStop = False
        Me.detalleJugadorGB.Text = "Detalle Jugador"
        Me.detalleJugadorGB.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(113, 298)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 23)
        Me.Button1.TabIndex = 56
        Me.Button1.Text = "Editar Jugador"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'posicionCB
        '
        Me.posicionCB.FormattingEnabled = True
        Me.posicionCB.Location = New System.Drawing.Point(6, 154)
        Me.posicionCB.Name = "posicionCB"
        Me.posicionCB.Size = New System.Drawing.Size(166, 23)
        Me.posicionCB.TabIndex = 55
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(198, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 15)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Fecha Nac. (YYYY-MM-DD)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 15)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Número Camiseta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(198, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 15)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Equipo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 15)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Posición"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(198, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Nombre"
        '
        'fechaNactxt
        '
        Me.fechaNactxt.Location = New System.Drawing.Point(198, 248)
        Me.fechaNactxt.Name = "fechaNactxt"
        Me.fechaNactxt.Size = New System.Drawing.Size(143, 23)
        Me.fechaNactxt.TabIndex = 48
        '
        'camisetaTxt
        '
        Me.camisetaTxt.Location = New System.Drawing.Point(6, 248)
        Me.camisetaTxt.Name = "camisetaTxt"
        Me.camisetaTxt.Size = New System.Drawing.Size(166, 23)
        Me.camisetaTxt.TabIndex = 47
        '
        'apellidoTxt
        '
        Me.apellidoTxt.Location = New System.Drawing.Point(198, 73)
        Me.apellidoTxt.Name = "apellidoTxt"
        Me.apellidoTxt.Size = New System.Drawing.Size(143, 23)
        Me.apellidoTxt.TabIndex = 46
        '
        'equiposCB
        '
        Me.equiposCB.FormattingEnabled = True
        Me.equiposCB.Location = New System.Drawing.Point(198, 154)
        Me.equiposCB.Name = "equiposCB"
        Me.equiposCB.Size = New System.Drawing.Size(143, 23)
        Me.equiposCB.TabIndex = 45
        '
        'nombreTxt
        '
        Me.nombreTxt.Location = New System.Drawing.Point(6, 73)
        Me.nombreTxt.Name = "nombreTxt"
        Me.nombreTxt.Size = New System.Drawing.Size(166, 23)
        Me.nombreTxt.TabIndex = 44
        '
        'EditarJugador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 410)
        Me.Controls.Add(Me.detalleJugadorGB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.jugadoresCB)
        Me.Name = "EditarJugador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Jugador"
        Me.detalleJugadorGB.ResumeLayout(False)
        Me.detalleJugadorGB.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents jugadoresCB As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents detalleJugadorGB As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents posicionCB As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents fechaNactxt As TextBox
    Friend WithEvents camisetaTxt As TextBox
    Friend WithEvents apellidoTxt As TextBox
    Friend WithEvents equiposCB As ComboBox
    Friend WithEvents nombreTxt As TextBox
End Class
