Public Class Form9
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Find the highest current id_pelanggan in the table
        Dim id_pelanggan As Integer = 0

        If BioskopDataSet1.Pelanggan.Rows.Count > 0 Then
            Dim maxIdString As String = BioskopDataSet1.Pelanggan.Compute("MAX(Pelanggan_id)", "").ToString()

            ' Check if the string is not empty and can be converted to an integer
            If Not String.IsNullOrEmpty(maxIdString) AndAlso Integer.TryParse(maxIdString, id_pelanggan) Then
                ' Increment id_pelanggan
                id_pelanggan += 1
            Else
                ' Handle the case where conversion fails (e.g., maxIdString is not a valid integer)
                ' You might want to provide a default value or take appropriate action
                ' For now, we set id_pelanggan to 1
                id_pelanggan = 1
            End If
        End If

        ' Generate the new id
        Dim id As String = "p" & id_pelanggan

        ' Insert data into the database
        PelangganTableAdapter.Insert(id, TextBox2.Text, TextBox3.Text)

        ' Refresh the data in the DataGridView or any other UI element displaying the data
        Me.PelangganTableAdapter.Fill(Me.BioskopDataSet1.Pelanggan)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BISKOPDataSet.Pelanggan' table. You can move, or remove it, as needed.
        Me.PelangganTableAdapter.Fill(Me.BioskopDataSet1.Pelanggan)

    End Sub
End Class