<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrincipalFM
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.equiposCB = New System.Windows.Forms.ComboBox()
        Me.detallesEquipoGB = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.directorTecnicoTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.jugadoresEquipoLB = New System.Windows.Forms.ListBox()
        Me.jugadoresGB = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.jugadoresPosicionLB = New System.Windows.Forms.ListBox()
        Me.posicionCB = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.equiposGB = New System.Windows.Forms.GroupBox()
        Me.equiposLB = New System.Windows.Forms.Label()
        Me.equiposRegionLB = New System.Windows.Forms.ListBox()
        Me.regionCB = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenúToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarPorUnJugadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarUnNuevoJugadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarDatosDeUnJugadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarUnJugadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContenidoPrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.detallesEquipoGB.SuspendLayout()
        Me.jugadoresGB.SuspendLayout()
        Me.equiposGB.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(32, 614)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 15)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Región"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(32, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 15)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Equipos"
        '
        'equiposCB
        '
        Me.equiposCB.FormattingEnabled = True
        Me.equiposCB.Location = New System.Drawing.Point(32, 92)
        Me.equiposCB.Name = "equiposCB"
        Me.equiposCB.Size = New System.Drawing.Size(121, 23)
        Me.equiposCB.TabIndex = 17
        Me.equiposCB.Text = "-- selección --"
        '
        'detallesEquipoGB
        '
        Me.detallesEquipoGB.BackColor = System.Drawing.Color.Transparent
        Me.detallesEquipoGB.Controls.Add(Me.Label3)
        Me.detallesEquipoGB.Controls.Add(Me.directorTecnicoTxt)
        Me.detallesEquipoGB.Controls.Add(Me.Label2)
        Me.detallesEquipoGB.Controls.Add(Me.jugadoresEquipoLB)
        Me.detallesEquipoGB.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.detallesEquipoGB.Location = New System.Drawing.Point(196, 74)
        Me.detallesEquipoGB.Name = "detallesEquipoGB"
        Me.detallesEquipoGB.Size = New System.Drawing.Size(549, 251)
        Me.detallesEquipoGB.TabIndex = 19
        Me.detallesEquipoGB.TabStop = False
        Me.detallesEquipoGB.Text = "Detalles Equipo"
        Me.detallesEquipoGB.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(258, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Director Técnico:"
        '
        'directorTecnicoTxt
        '
        Me.directorTecnicoTxt.Location = New System.Drawing.Point(366, 42)
        Me.directorTecnicoTxt.Name = "directorTecnicoTxt"
        Me.directorTecnicoTxt.Size = New System.Drawing.Size(160, 23)
        Me.directorTecnicoTxt.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(20, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Jugadores"
        '
        'jugadoresEquipoLB
        '
        Me.jugadoresEquipoLB.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.jugadoresEquipoLB.FormattingEnabled = True
        Me.jugadoresEquipoLB.ItemHeight = 15
        Me.jugadoresEquipoLB.Location = New System.Drawing.Point(20, 73)
        Me.jugadoresEquipoLB.Name = "jugadoresEquipoLB"
        Me.jugadoresEquipoLB.Size = New System.Drawing.Size(506, 154)
        Me.jugadoresEquipoLB.TabIndex = 4
        '
        'jugadoresGB
        '
        Me.jugadoresGB.BackColor = System.Drawing.Color.Transparent
        Me.jugadoresGB.Controls.Add(Me.Label5)
        Me.jugadoresGB.Controls.Add(Me.jugadoresPosicionLB)
        Me.jugadoresGB.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.jugadoresGB.Location = New System.Drawing.Point(196, 344)
        Me.jugadoresGB.Name = "jugadoresGB"
        Me.jugadoresGB.Size = New System.Drawing.Size(549, 251)
        Me.jugadoresGB.TabIndex = 22
        Me.jugadoresGB.TabStop = False
        Me.jugadoresGB.Text = "Detalle Jugadores"
        Me.jugadoresGB.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(20, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Jugadores"
        '
        'jugadoresPosicionLB
        '
        Me.jugadoresPosicionLB.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.jugadoresPosicionLB.FormattingEnabled = True
        Me.jugadoresPosicionLB.ItemHeight = 15
        Me.jugadoresPosicionLB.Location = New System.Drawing.Point(20, 73)
        Me.jugadoresPosicionLB.Name = "jugadoresPosicionLB"
        Me.jugadoresPosicionLB.Size = New System.Drawing.Size(506, 154)
        Me.jugadoresPosicionLB.TabIndex = 4
        '
        'posicionCB
        '
        Me.posicionCB.FormattingEnabled = True
        Me.posicionCB.Location = New System.Drawing.Point(32, 362)
        Me.posicionCB.Name = "posicionCB"
        Me.posicionCB.Size = New System.Drawing.Size(121, 23)
        Me.posicionCB.TabIndex = 20
        Me.posicionCB.Text = "-- selección --"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(32, 335)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 15)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Posición"
        '
        'equiposGB
        '
        Me.equiposGB.BackColor = System.Drawing.Color.Transparent
        Me.equiposGB.Controls.Add(Me.equiposLB)
        Me.equiposGB.Controls.Add(Me.equiposRegionLB)
        Me.equiposGB.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.equiposGB.Location = New System.Drawing.Point(196, 614)
        Me.equiposGB.Name = "equiposGB"
        Me.equiposGB.Size = New System.Drawing.Size(549, 251)
        Me.equiposGB.TabIndex = 25
        Me.equiposGB.TabStop = False
        Me.equiposGB.Text = "Detalle Equipos"
        Me.equiposGB.Visible = False
        '
        'equiposLB
        '
        Me.equiposLB.AutoSize = True
        Me.equiposLB.BackColor = System.Drawing.Color.Transparent
        Me.equiposLB.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.equiposLB.Location = New System.Drawing.Point(20, 42)
        Me.equiposLB.Name = "equiposLB"
        Me.equiposLB.Size = New System.Drawing.Size(49, 15)
        Me.equiposLB.TabIndex = 7
        Me.equiposLB.Text = "Equipos"
        '
        'equiposRegionLB
        '
        Me.equiposRegionLB.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.equiposRegionLB.FormattingEnabled = True
        Me.equiposRegionLB.ItemHeight = 15
        Me.equiposRegionLB.Location = New System.Drawing.Point(20, 73)
        Me.equiposRegionLB.Name = "equiposRegionLB"
        Me.equiposRegionLB.Size = New System.Drawing.Size(506, 154)
        Me.equiposRegionLB.TabIndex = 4
        '
        'regionCB
        '
        Me.regionCB.FormattingEnabled = True
        Me.regionCB.Location = New System.Drawing.Point(32, 632)
        Me.regionCB.Name = "regionCB"
        Me.regionCB.Size = New System.Drawing.Size(121, 23)
        Me.regionCB.TabIndex = 23
        Me.regionCB.Text = "-- selección --"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.AutoSize = True
        Me.Panel1.Controls.Add(Me.regionCB)
        Me.Panel1.Controls.Add(Me.equiposGB)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.posicionCB)
        Me.Panel1.Controls.Add(Me.jugadoresGB)
        Me.Panel1.Controls.Add(Me.detallesEquipoGB)
        Me.Panel1.Controls.Add(Me.equiposCB)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(775, 887)
        Me.Panel1.TabIndex = 22
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenúToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(775, 24)
        Me.MenuStrip.TabIndex = 24
        Me.MenuStrip.Text = "MenuStrip"
        '
        'MenúToolStripMenuItem
        '
        Me.MenúToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarPorUnJugadorToolStripMenuItem, Me.AgregarUnNuevoJugadorToolStripMenuItem, Me.ModificarDatosDeUnJugadorToolStripMenuItem, Me.EliminarUnJugadorToolStripMenuItem, Me.ContenidoPrincipalToolStripMenuItem})
        Me.MenúToolStripMenuItem.Name = "MenúToolStripMenuItem"
        Me.MenúToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenúToolStripMenuItem.Text = "Menú"
        '
        'ConsultarPorUnJugadorToolStripMenuItem
        '
        Me.ConsultarPorUnJugadorToolStripMenuItem.Name = "ConsultarPorUnJugadorToolStripMenuItem"
        Me.ConsultarPorUnJugadorToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.ConsultarPorUnJugadorToolStripMenuItem.Text = "Consultar por un jugador"
        '
        'AgregarUnNuevoJugadorToolStripMenuItem
        '
        Me.AgregarUnNuevoJugadorToolStripMenuItem.Name = "AgregarUnNuevoJugadorToolStripMenuItem"
        Me.AgregarUnNuevoJugadorToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.AgregarUnNuevoJugadorToolStripMenuItem.Text = "Agregar un nuevo jugador"
        '
        'ModificarDatosDeUnJugadorToolStripMenuItem
        '
        Me.ModificarDatosDeUnJugadorToolStripMenuItem.Name = "ModificarDatosDeUnJugadorToolStripMenuItem"
        Me.ModificarDatosDeUnJugadorToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.ModificarDatosDeUnJugadorToolStripMenuItem.Text = "Modificar datos de un Jugador"
        '
        'EliminarUnJugadorToolStripMenuItem
        '
        Me.EliminarUnJugadorToolStripMenuItem.Name = "EliminarUnJugadorToolStripMenuItem"
        Me.EliminarUnJugadorToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.EliminarUnJugadorToolStripMenuItem.Text = "Eliminar un Jugador"
        '
        'ContenidoPrincipalToolStripMenuItem
        '
        Me.ContenidoPrincipalToolStripMenuItem.Name = "ContenidoPrincipalToolStripMenuItem"
        Me.ContenidoPrincipalToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.ContenidoPrincipalToolStripMenuItem.Text = "Contenido Principal"
        '
        'PrincipalFM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(775, 887)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.Panel1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "PrincipalFM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Baby Calle - Felipe Mancilla"
        Me.detallesEquipoGB.ResumeLayout(False)
        Me.detallesEquipoGB.PerformLayout()
        Me.jugadoresGB.ResumeLayout(False)
        Me.jugadoresGB.PerformLayout()
        Me.equiposGB.ResumeLayout(False)
        Me.equiposGB.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents equiposCB As ComboBox
    Friend WithEvents detallesEquipoGB As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents directorTecnicoTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents jugadoresEquipoLB As ListBox
    Friend WithEvents jugadoresGB As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents jugadoresPosicionLB As ListBox
    Friend WithEvents posicionCB As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents equiposGB As GroupBox
    Friend WithEvents equiposLB As Label
    Friend WithEvents equiposRegionLB As ListBox
    Friend WithEvents regionCB As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents MenúToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarPorUnJugadorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarUnNuevoJugadorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarDatosDeUnJugadorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarUnJugadorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContenidoPrincipalToolStripMenuItem As ToolStripMenuItem
End Class
