Imports MySql.Data.MySqlClient

Public Class addJugador
    Private connString As String = "Server=127.0.0.1;User=root;Password=Qwerty123.,;Port=3306;database=baby_calle"
    Dim reader As MySqlDataReader
    Private Sub addJugador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        equiposCombo()
        posicionCombo()
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
        Dim Conexion As New MySqlConnection(connString)
        Conexion.Open()

        Dim Query As String = "INSERT INTO baby_calle.jugador
                                    (jug_nom, jug_apl, pos_id, eqp_id, jug_nro_cst, jug_fec_nac)
                                    VALUES(@nom, @apl, @pid, @eid, @cst, @nac);"

        'MessageBox.Show(nombreTxt.Text.ToString + "-" + apellidoTxt.Text.ToString + "-" + posicionSeleccionada.ToString + "-" + equipoSeleccionado.ToString + "-" + camisetaTxt.Text.ToString + "-" + fechaNactxt.Text.ToString)

        If nombreTxt.Text = "" Or apellidoTxt.Text = "" Or posicionCB.SelectedIndex = -1 Or equiposCB.SelectedIndex = -1 Or camisetaTxt.Text = "" Or fechaNactxt.Text = "" Then
            MessageBox.Show("Debe llenar todos los campos para añadir un jugador")
        Else

            Try
                Dim posicionSeleccionada = extractorId(posicionCB.SelectedItem.ToString)
                Dim equipoSeleccionado = extractorId(equiposCB.SelectedItem.ToString)
                Dim comando As MySqlCommand = New MySqlCommand(Query, Conexion)
                comando.Parameters.AddWithValue("@nom", nombreTxt.Text.ToString)
                comando.Parameters.AddWithValue("@apl", apellidoTxt.Text.ToString)
                comando.Parameters.AddWithValue("@pid", posicionSeleccionada.ToString)
                comando.Parameters.AddWithValue("@eid", equipoSeleccionado.ToString)
                comando.Parameters.AddWithValue("@cst", camisetaTxt.Text.ToString)
                comando.Parameters.AddWithValue("@nac", fechaNactxt.Text.ToString)


                If comando.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Jugador " + nombreTxt.Text.ToString + " " + apellidoTxt.Text.ToString + " ingresado con éxito")
                End If


            Catch ex As Exception
                MessageBox.Show("Error ingreso de jugador: " + ex.Message)
            Finally
                Conexion.Close()
            End Try

        End If
    End Sub

    Public Function extractorId(seleccionado As String) As Int32

        Dim idSeleccionado = Int32.Parse(seleccionado.Substring(0, seleccionado.LastIndexOf(" - ")))
        'MessageBox.Show(idSeleccionado)
        Return idSeleccionado
    End Function
End Class