Imports System.Data.SqlClient



Public Class Form1
    Public Shared loggedin As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles login.Click


        Dim username As String = usernameform1.Text

        Dim password As String = passwordform1.Text


        Dim con_str As String = "Data source=LIWEI; Initial catalog=bioskop; Integrated Security=true"
        Using con As New SqlConnection(con_str)
            Try
                con.Open()
                Dim query As String = "SELECT * From Pelanggan where username=@username and password=@password"
                Dim cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                If reader.HasRows Then
                    While reader.Read
                        loggedin = reader("pelanggan_id").ToString()
                    End While
                    Form2.Show()

                Else
                    MessageBox.Show("USERNAME/PASSWORD INVALID")
                End If

            Catch ex As Exception
                MessageBox.Show("an error occured: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Using





    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click



    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form9.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BioskopDataSet1.Pelanggan' table. You can move, or remove it, as needed.
        Me.PelangganTableAdapter.Fill(Me.BioskopDataSet1.Pelanggan)

    End Sub
End Class
