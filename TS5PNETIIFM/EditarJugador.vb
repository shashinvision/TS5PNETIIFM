Imports MySql.Data.MySqlClient

Public Class EditarJugador
    Private connString As String = "Server=127.0.0.1;User=root;Password=Qwerty123.,;Port=3306;database=baby_calle"
    Dim reader As MySqlDataReader
    Private Sub EditarJugador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        jugadoresComboBox()
        posicionCombo()
        equiposCombo()
    End Sub

    Public Function extractorId(seleccionado As String) As Int32

        Dim idSeleccionado = Int32.Parse(seleccionado.Substring(0, seleccionado.LastIndexOf(" - ")))
        'MessageBox.Show(idSeleccionado)
        Return idSeleccionado
    End Function

    Public Sub jugadoresComboBox()

        Dim Conexion As New MySqlConnection(connString)
        Conexion.Open()

        Dim Query As String = "select concat(j.jug_id, ' - ', j.jug_nom, ' ', j.jug_apl) 
                                from baby_calle.jugador j;"

        Try

            Dim comando As MySqlCommand = New MySqlCommand(Query, Conexion)
            reader = comando.ExecuteReader()
            jugadoresCB.Items.Clear()
            While reader.Read()
                jugadoresCB.Items.Add(reader(0).ToString)
            End While

        Catch ex As Exception
            MessageBox.Show("Error jugadoresComboBox: " + ex.Message)
        Finally
            Conexion.Close()
        End Try

    End Sub

    Private Sub jugadoresCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles jugadoresCB.SelectedIndexChanged
        jugadorRelacionados(extractorId(jugadoresCB.SelectedItem.ToString))
        detalleJugadorGB.Visible = True
    End Sub

    Public Sub jugadorRelacionados(id As Int32)

        Dim Conexion As New MySqlConnection(connString)
        Conexion.Open()

        Dim Query As String = "select j.jug_nom, j.jug_apl, concat(p.pos_id, ' - ', p.pos_nom) ,  concat(e.eqp_id, ' - ', e.eqp_nom), j.jug_nro_cst, DATE_FORMAT(j.jug_fec_nac, '%Y-%m-%d')  
                                from baby_calle.jugador j 
                                inner join baby_calle.posicion p 
                                on p.pos_id = j.pos_id 
                                inner join baby_calle.equipo e 
                                on e.eqp_id = j.eqp_id
                                where j.jug_id = @id"

        Try

            Dim comando As MySqlCommand = New MySqlCommand(Query, Conexion)
            comando.Parameters.AddWithValue("@id", id)
            reader = comando.ExecuteReader()

            While reader.Read()

                nombreTxt.Text = reader(0).ToString
                apellidoTxt.Text = reader(1).ToString
                posicionCB.SelectedItem = reader(2).ToString
                equiposCB.SelectedItem = reader(3).ToString
                camisetaTxt.Text = reader(4).ToString
                fechaNactxt.Text = reader(5).ToString

            End While

        Catch ex As Exception
            MessageBox.Show("Error jugadoresEquipoRelacionados: " + ex.Message)
        Finally
            Conexion.Close()
        End Try

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id = extractorId(jugadoresCB.SelectedItem.ToString)
        Dim Conexion As New MySqlConnection(connString)
        Conexion.Open()

        Dim Query As String = "UPDATE baby_calle.jugador
                                SET jug_nom=@jnom, jug_apl=@japl, pos_id=@pid, eqp_id=@eid, jug_nro_cst=@cst, jug_fec_nac=@nac
                                WHERE jug_id=@id;"

        Dim posicionSeleccionada = extractorId(posicionCB.SelectedItem.ToString)
        Dim equipoSeleccionado = extractorId(equiposCB.SelectedItem.ToString)
        'MessageBox.Show(nombreTxt.Text.ToString + "-" + apellidoTxt.Text.ToString + "-" + posicionSeleccionada.ToString + "-" + equipoSeleccionado.ToString + "-" + camisetaTxt.Text.ToString + "-" + fechaNactxt.Text.ToString)

        If nombreTxt.Text = "" Or apellidoTxt.Text = "" Or posicionCB.SelectedIndex = -1 Or equiposCB.SelectedIndex = -1 Or camisetaTxt.Text = "" Or fechaNactxt.Text = "" Then
            MessageBox.Show("Debe llenar todos los campos para añadir un jugador")
        Else

            Try
                Dim comando As MySqlCommand = New MySqlCommand(Query, Conexion)
                comando.Parameters.AddWithValue("@jnom", nombreTxt.Text.ToString)
                comando.Parameters.AddWithValue("@japl", apellidoTxt.Text.ToString)
                comando.Parameters.AddWithValue("@pid", posicionSeleccionada.ToString)
                comando.Parameters.AddWithValue("@eid", equipoSeleccionado.ToString)
                comando.Parameters.AddWithValue("@cst", camisetaTxt.Text.ToString)
                comando.Parameters.AddWithValue("@nac", fechaNactxt.Text.ToString)
                comando.Parameters.AddWithValue("@id", id.ToString)


                If comando.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Jugador " + nombreTxt.Text.ToString + " " + apellidoTxt.Text.ToString + " editado con éxito")
                    jugadoresComboBox()
                End If

            Catch ex As Exception
                MessageBox.Show("Error ingreso de jugador: " + ex.Message)
            Finally
                Conexion.Close()
            End Try

        End If
    End Sub
End Class