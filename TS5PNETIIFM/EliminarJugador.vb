Imports MySql.Data.MySqlClient
Public Class EliminarJugador
    Private connString As String = "Server=127.0.0.1;User=root;Password=Qwerty123.,;Port=3306;database=baby_calle"
    Dim reader As MySqlDataReader
    Private Sub EliminarJugador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        jugadoresComboBox()
    End Sub

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

    Public Function extractorId(seleccionado As String) As Int32

        Dim idSeleccionado = Int32.Parse(seleccionado.Substring(0, seleccionado.LastIndexOf(" - ")))
        'MessageBox.Show(idSeleccionado)
        Return idSeleccionado
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id = extractorId(jugadoresCB.SelectedItem.ToString)
        Dim Conexion As New MySqlConnection(connString)
        Conexion.Open()

        Dim Query As String = "DELETE FROM baby_calle.jugador
                                WHERE jug_id=@id;"

        Try
                Dim comando As MySqlCommand = New MySqlCommand(Query, Conexion)

                comando.Parameters.AddWithValue("@id", id.ToString)


                If comando.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Jugador " + jugadoresCB.SelectedItem.ToString + " se elimino con éxito")
                    jugadoresComboBox()
                End If

            Catch ex As Exception
                MessageBox.Show("Error ingreso de jugador: " + ex.Message)
            Finally
                Conexion.Close()
            End Try

    End Sub
End Class