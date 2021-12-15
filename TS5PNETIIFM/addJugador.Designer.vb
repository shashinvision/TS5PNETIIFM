<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addJugador
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
        Me.addJugadorBtn = New System.Windows.Forms.Button()
        Me.posicionCB = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(234, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 15)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Fecha Nac. (YYYY-MM-DD)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 15)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Número Camiseta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(234, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 15)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Equipo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 15)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Posición"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(234, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Nombre"
        '
        'fechaNactxt
        '
        Me.fechaNactxt.Location = New System.Drawing.Point(234, 245)
        Me.fechaNactxt.Name = "fechaNactxt"
        Me.fechaNactxt.Size = New System.Drawing.Size(143, 23)
        Me.fechaNactxt.TabIndex = 21
        '
        'camisetaTxt
        '
        Me.camisetaTxt.Location = New System.Drawing.Point(42, 245)
        Me.camisetaTxt.Name = "camisetaTxt"
        Me.camisetaTxt.Size = New System.Drawing.Size(166, 23)
        Me.camisetaTxt.TabIndex = 20
        '
        'apellidoTxt
        '
        Me.apellidoTxt.Location = New System.Drawing.Point(234, 70)
        Me.apellidoTxt.Name = "apellidoTxt"
        Me.apellidoTxt.Size = New System.Drawing.Size(143, 23)
        Me.apellidoTxt.TabIndex = 17
        '
        'equiposCB
        '
        Me.equiposCB.FormattingEnabled = True
        Me.equiposCB.Location = New System.Drawing.Point(234, 151)
        Me.equiposCB.Name = "equiposCB"
        Me.equiposCB.Size = New System.Drawing.Size(143, 23)
        Me.equiposCB.TabIndex = 15
        '
        'nombreTxt
        '
        Me.nombreTxt.Location = New System.Drawing.Point(42, 70)
        Me.nombreTxt.Name = "nombreTxt"
        Me.nombreTxt.Size = New System.Drawing.Size(166, 23)
        Me.nombreTxt.TabIndex = 14
        '
        'addJugadorBtn
        '
        Me.addJugadorBtn.Location = New System.Drawing.Point(134, 300)
        Me.addJugadorBtn.Name = "addJugadorBtn"
        Me.addJugadorBtn.Size = New System.Drawing.Size(166, 23)
        Me.addJugadorBtn.TabIndex = 28
        Me.addJugadorBtn.Text = "Añadir"
        Me.addJugadorBtn.UseVisualStyleBackColor = True
        '
        'posicionCB
        '
        Me.posicionCB.FormattingEnabled = True
        Me.posicionCB.Location = New System.Drawing.Point(42, 151)
        Me.posicionCB.Name = "posicionCB"
        Me.posicionCB.Size = New System.Drawing.Size(166, 23)
        Me.posicionCB.TabIndex = 29
        '
        'addJugador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 354)
        Me.Controls.Add(Me.posicionCB)
        Me.Controls.Add(Me.addJugadorBtn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fechaNactxt)
        Me.Controls.Add(Me.camisetaTxt)
        Me.Controls.Add(Me.apellidoTxt)
        Me.Controls.Add(Me.equiposCB)
        Me.Controls.Add(Me.nombreTxt)
        Me.Name = "addJugador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Añadir jugador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents addJugadorBtn As Button
    Friend WithEvents posicionCB As ComboBox
End Class
