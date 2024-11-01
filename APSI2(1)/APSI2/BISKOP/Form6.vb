Public Class Form6
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        jumlah = 0

        If ComboBox1.SelectedItem = "Simpson The Movie" Then
            film = "Simpson The Movie"
        ElseIf ComboBox1.SelectedItem = "Tekotok The Movie" Then
            film = "Tekotok The Movie"
        ElseIf ComboBox1.SelectedItem = "ETERNALS" Then
            film = "ETERNALS"
        ElseIf ComboBox1.SelectedItem = "365 DAYS" Then
            film = "365 DAYS"
        End If


        If ComboBox2.SelectedItem = "26-5-2023" Then
            tanggal = "26-5-2023"
        ElseIf ComboBox2.SelectedItem = "27-5-2023" Then
            tanggal = "27-5-2023"
        ElseIf ComboBox2.SelectedItem = "28-5-2023" Then
            tanggal = "28-5-2023"
        ElseIf ComboBox2.SelectedItem = "29-5-2023" Then
            tanggal = "29-5-2023"
        ElseIf ComboBox2.SelectedItem = "30-5-2023" Then
            tanggal = "30-5-2023"
        End If

        If ComboBox3.SelectedItem = "10:00" Then
            jam = "10:00"
        ElseIf ComboBox3.SelectedItem = "11:00" Then
            jam = "11:00"
        ElseIf ComboBox3.SelectedItem = "14:00" Then
            jam = "14:00"
        ElseIf ComboBox3.SelectedItem = "18:00" Then
            jam = "18:00"
        End If

        If CheckBox1.Checked Then
            seat = seat + CheckBox1.Text + ", "
            jumlah = jumlah + 1
        End If
        If CheckBox2.Checked Then
            seat = seat + CheckBox2.Text + ", "
            jumlah = jumlah + 1

        End If
        If CheckBox3.Checked Then
            seat = seat + CheckBox3.Text + ", "
            jumlah = jumlah + 1
        End If
        If CheckBox4.Checked Then
            seat = seat + CheckBox4.Text + ", "
            jumlah = jumlah + 1
        End If
        If CheckBox5.Checked Then
            seat = seat + CheckBox5.Text + ", "
            jumlah = jumlah + 1
        End If
        If CheckBox6.Checked Then
            seat = seat + CheckBox6.Text + ", "
            jumlah = jumlah + 1
        End If
        If CheckBox7.Checked Then
            seat = seat + CheckBox7.Text + ", "
            jumlah = jumlah + 1
        End If
        If CheckBox8.Checked Then
            seat = seat + CheckBox8.Text + ", "
            jumlah = jumlah + 1
        End If
        If CheckBox9.Checked Then
            seat = seat + CheckBox9.Text + ", "
            jumlah = jumlah + 1
        End If
        If CheckBox10.Checked Then
            seat = seat + CheckBox9.Text + ", "
            jumlah = jumlah + 1
        End If
        If CheckBox11.Checked Then
            seat = seat + CheckBox9.Text + ", "
            jumlah = jumlah + 1
        End If
        If CheckBox12.Checked Then
            seat = seat + CheckBox9.Text + ", "
            jumlah = jumlah + 1
        End If
        If CheckBox13.Checked Then
            seat = seat + CheckBox9.Text + ", "
            jumlah = jumlah + 1
        End If
        If CheckBox14.Checked Then
            seat = seat + CheckBox9.Text + ", "
            jumlah = jumlah + 1
        End If
        If CheckBox15.Checked Then
            seat = seat + CheckBox9.Text + ", "
            jumlah = jumlah + 1
        End If
        If CheckBox16.Checked Then
            seat = seat + CheckBox9.Text + ", "
            jumlah = jumlah + 1

        End If
        If CheckBox17.Checked Then
            seat = seat + CheckBox9.Text + ", "
            jumlah = jumlah + 1

        End If
        If CheckBox18.Checked Then
            seat = seat + CheckBox9.Text + ", "
            jumlah = jumlah + 1

        End If
        If CheckBox19.Checked Then
            seat = seat + CheckBox9.Text + ", "
            jumlah = jumlah + 1

        End If
        If CheckBox20.Checked Then
            seat = seat + CheckBox9.Text + ", "
            jumlah = jumlah + 1
        End If
        If CheckBox21.Checked Then
            seat = seat + CheckBox9.Text + ", "
            jumlah = jumlah + 1
        End If
        If CheckBox22.Checked Then
            seat = seat + CheckBox9.Text + ", "
            jumlah = jumlah + 1
        End If
        If CheckBox23.Checked Then
            seat = seat + CheckBox9.Text + ", "
            jumlah = jumlah + 1
        End If
        If CheckBox24.Checked Then
            seat = seat + CheckBox9.Text + ", "
            jumlah = jumlah + 1
        End If
        If CheckBox25.Checked Then
            seat = seat + CheckBox9.Text + ", "
            jumlah = jumlah + 1
        End If
        If CheckBox26.Checked Then
            seat = seat + CheckBox9.Text + ", "
            jumlah = jumlah + 1
        End If
        If CheckBox27.Checked Then
            seat = seat + CheckBox9.Text + ", "
            jumlah = jumlah + 1
        End If
        If CheckBox28.Checked Then
            seat = seat + CheckBox9.Text + ", "
            jumlah = jumlah + 1
        End If
        If CheckBox29.Checked Then
            seat = seat + CheckBox9.Text + ", "
            jumlah = jumlah + 1
        End If

        harga = jumlah * 40000

        Form7.Show()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class