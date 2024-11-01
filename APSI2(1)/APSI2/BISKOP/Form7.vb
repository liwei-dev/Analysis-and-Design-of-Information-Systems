Public Class Form7
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = film
        TextBox2.Text = tanggal
        TextBox3.Text = jam
        TextBox4.Text = seat
        TextBox5.Text = jumlah
        TextBox6.Text = harga






    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        saldo = TextBox7.Text

        If saldo > harga Then
            kembalian = saldo - harga
            Form10.Show()
            Me.Hide()
        Else
            MessageBox.Show("SALDO KURANG")
        End If



    End Sub
End Class