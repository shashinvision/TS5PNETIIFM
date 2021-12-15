Imports MySql.Data.MySqlClient

Public Class PrincipalFM
    Private connString As String = "Server=127.0.0.1;User=root;Password=Qwerty123.,;Port=3306;database=baby_calle"
    Dim reader As MySqlDataReader

    Private Sub PrincipalFM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        testConection()
        equiposCombo()
        posicionCombo()
        regionCombo()
    End Sub

    ' funcion solo con fines de testear la conexin con la base de datos

    Public Sub testConection()

        Dim Conexion As New MySqlConnection(connString)
        Try
            Conexion.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
        MessageBox.Show("Conectado a la base de datos")
        Conexion.Close()
    End Sub

    Public Sub equiposCombo()
        Dim Conexion As New MySqlConnection(connString)
        Conexion.Open()
        Dim Query As String = "select concat(e.eqp_id,' - ',e.eqp_nom)
                                from baby_calle.equipo e"
        Try
            Dim comando As MySqlCommand = New MySqlCommand(Query, Conexion)
            reader = comando.ExecuteReader()

            equiposCB.Items.Clear()
            While reader.Read()
                equiposCB.Items.Add(reader(0).ToString)
            End While

        Catch ex As Exception
            MessageBox.Show("Error equiposCombo: " + ex.Message)
        Finally
            Conexion.Close()
        End Try
    End Sub

    Public Sub posicionCombo()
        Dim Conexion As New MySqlConnection(connString)
        Conexion.Open()
        Dim Query As String = "select concat(p.pos_id,' - ',p.pos_nom)
                                from baby_calle.posicion p"
        Try
            Dim comando As MySqlCommand = New MySqlCommand(Query, Conexion)
            reader = comando.ExecuteReader()

            posicionCB.Items.Clear()
            While reader.Read()
                posicionCB.Items.Add(reader(0).ToString)
            End While

        Catch ex As Exception
            MessageBox.Show("Error posicionCombo: " + ex.Message)
        Finally
            Conexion.Close()
        End Try
    End Sub

    Public Sub regionCombo()
        Dim Conexion As New MySqlConnection(connString)
        Conexion.Open()
        Dim Query As String = "select concat(e.reg_id,' - ',e.reg_nom)
                                from baby_calle.region e"
        Try
            Dim comando As MySqlCommand = New MySqlCommand(Query, Conexion)
            reader = comando.ExecuteReader()

            regionCB.Items.Clear()
            While reader.Read()
                regionCB.Items.Add(reader(0).ToString)
            End While

        Catch ex As Exception
            MessageBox.Show("Error regionCombo: " + ex.Message)
        Finally
            Conexion.Close()
        End Try
    End Sub

    Private Sub equiposCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles equiposCB.SelectedIndexChanged
        jugadoresEquipoRelacionados(extractorId(equiposCB.SelectedItem.ToString))
    End Sub

    Public Function extractorId(seleccionado As String) As Int32

        Dim idSeleccionado = Int32.Parse(seleccionado.Substring(0, seleccionado.LastIndexOf(" - ")))
        'MessageBox.Show(idSeleccionado)
        Return idSeleccionado
    End Function

    Public Sub jugadoresEquipoRelacionados(id As Int32)

        Dim Conexion As New MySqlConnection(connString)
        Conexion.Open()

        Dim Query As String = "SELECT concat('Nombre: ', j.jug_nom, ' ', j.jug_apl, ' - Posición: ', p.pos_nom, ' - Num Camiseta: ', jug_nro_cst), concat(dt.dte_nom, ' ', dt.dte_apl) 
                                FROM baby_calle.jugador j
                                inner join baby_calle.equipo e 
                                on e.eqp_id = j.eqp_id 
                                inner join baby_calle.directorio_tecnico dt 
                                on dt.dte_id = e.dte_id 
                                left join baby_calle.posicion p 
                                on p.pos_id = j.pos_id 
                                where e.eqp_id = @id"

        Try

            Dim comando As MySqlCommand = New MySqlCommand(Query, Conexion)
            comando.Parameters.AddWithValue("@id", id)
            reader = comando.ExecuteReader()
            jugadoresEquipoLB.Items.Clear()
            While reader.Read()

                jugadoresEquipoLB.Items.Add(reader(0).ToString)
                directorTecnicoTxt.Text = reader(1).ToString

            End While

            detallesEquipoGB.Visible = True

        Catch ex As Exception
            MessageBox.Show("Error jugadoresEquipoRelacionados: " + ex.Message)
        Finally
            Conexion.Close()
        End Try

    End Sub

    Private Sub posicionCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles posicionCB.SelectedIndexChanged
        jugadoresPosicionRelacionados(extractorId(posicionCB.SelectedItem.ToString))
    End Sub

    Public Sub jugadoresPosicionRelacionados(id As Int32)

        Dim Conexion As New MySqlConnection(connString)
        Conexion.Open()

        Dim Query As String = "select concat('Nombre: ', j.jug_nom, ' ', j.jug_apl, ' - Equipo: ', e.eqp_nom)
                                from baby_calle.jugador j 
                                inner join baby_calle.equipo e 
                                on e.eqp_id = j.eqp_id
                                inner join baby_calle.posicion p 
                                on p.pos_id = j.pos_id 
                                where p.pos_id = @id"

        Try

            Dim comando As MySqlCommand = New MySqlCommand(Query, Conexion)
            comando.Parameters.AddWithValue("@id", id)
            reader = comando.ExecuteReader()
            jugadoresPosicionLB.Items.Clear()
            While reader.Read()
                jugadoresPosicionLB.Items.Add(reader(0).ToString)
            End While

            jugadoresGB.Visible = True

        Catch ex As Exception
            MessageBox.Show("Error jugadoresEquipoRelacionados: " + ex.Message)
        Finally
            Conexion.Close()
        End Try

    End Sub

    Private Sub regionCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles regionCB.SelectedIndexChanged
        equiposRegionRelacionados(extractorId(regionCB.SelectedItem.ToString))
    End Sub

    Public Sub equiposRegionRelacionados(id As Int32)

        Dim Conexion As New MySqlConnection(connString)
        Conexion.Open()

        Dim Query As String = "select e.eqp_nom 
                                from baby_calle.equipo e
                                where e.reg_id = @id"

        Try

            Dim comando As MySqlCommand = New MySqlCommand(Query, Conexion)
            comando.Parameters.AddWithValue("@id", id)
            reader = comando.ExecuteReader()
            equiposRegionLB.Items.Clear()
            While reader.Read()
                equiposRegionLB.Items.Add(reader(0).ToString)
            End While

            equiposGB.Visible = True

        Catch ex As Exception
            MessageBox.Show("Error equiposRegionRelacionados: " + ex.Message)
        Finally
            Conexion.Close()
        End Try

    End Sub


    Private Sub ConsultarPorUnJugadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarPorUnJugadorToolStripMenuItem.Click
        Panel1.Visible = False

        Dim consultaJugadorFR As New ConsultaJugador
        consultaJugadorFR.MdiParent = Me
        consultaJugadorFR.Show()
    End Sub

    Private Sub ContenidoPrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContenidoPrincipalToolStripMenuItem.Click
        contenidoPrincipal()
    End Sub

    Public Sub contenidoPrincipal()

        Panel1.Visible = True
    End Sub

    Private Sub AgregarUnNuevoJugadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarUnNuevoJugadorToolStripMenuItem.Click
        Panel1.Visible = False

        Dim addJugadorFR As New addJugador
        addJugadorFR.MdiParent = Me
        addJugadorFR.Show()
    End Sub

    Private Sub ModificarDatosDeUnJugadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarDatosDeUnJugadorToolStripMenuItem.Click
        Panel1.Visible = False

        Dim editJugadorFR As New EditarJugador
        editJugadorFR.MdiParent = Me
        editJugadorFR.Show()
    End Sub

    Private Sub EliminarUnJugadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarUnJugadorToolStripMenuItem.Click
        Panel1.Visible = False

        Dim elimarJugadorFR As New EliminarJugador
        elimarJugadorFR.MdiParent = Me
        elimarJugadorFR.Show()
    End Sub
End Class
