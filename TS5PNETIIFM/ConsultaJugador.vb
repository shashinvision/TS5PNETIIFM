Imports MySql.Data.MySqlClient

Public Class ConsultaJugador
    Private connString As String = "Server=127.0.0.1;User=root;Password=Qwerty123.,;Port=3306;database=baby_calle"
    Dim reader As MySqlDataReader


    Private Sub jugadoresCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles jugadoresCB.SelectedIndexChanged
        jugadorRelacionados(extractorId(jugadoresCB.SelectedItem.ToString))
    End Sub

    Private Sub ConsultaJugador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        jugadoresComboBox()
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

    Public Sub jugadorRelacionados(id As Int32)

        Dim Conexion As New MySqlConnection(connString)
        Conexion.Open()

        Dim Query As String = "select j.jug_nom, j.jug_apl, p.pos_nom , e.eqp_nom, j.jug_nro_cst, DATE_FORMAT(j.jug_fec_nac, '%Y-%m-%d')  
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
                posicionTxt.Text = reader(2).ToString
                equipoTxt.Text = reader(3).ToString
                camisetaTxt.Text = reader(4).ToString
                fechaNactxt.Text = reader(5).ToString

            End While

        Catch ex As Exception
            MessageBox.Show("Error jugadoresEquipoRelacionados: " + ex.Message)
        Finally
            Conexion.Close()
        End Try

    End Sub
End Class