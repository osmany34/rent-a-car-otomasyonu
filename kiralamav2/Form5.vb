Public Class Form5
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text.Trim() <> "" Then
            Form2.bag.Open()
            Form2.kmt.Connection = Form2.bag
            Form2.kmt.CommandText = "UPDATE musbil SET TcKimlikNo='" & TextBox1.Text & "',Ad='" & TextBox2.Text & "',Soyad='" & TextBox3.Text & "',Cinsiyet='" & ComboBox1.Text & "',DogumTarihi='" & DateTimePicker1.Text & "',DogumYeri='" & TextBox4.Text & "',Telefon='" & TextBox5.Text & "',CepTel='" & TextBox6.Text & "',Email='" & TextBox7.Text & "',Adres='" & TextBox8.Text & "',EhliyetNo='" & TextBox9.Text & "',EhliyetTarihi='" & DateTimePicker2.Text & "',EhliyetVerilenYer='" & TextBox10.Text & "' WHERE TcKimlikNo='" & Form2.DataGridView1.CurrentRow.Cells(0).Value.ToString() & "' "
            Form2.kmt.ExecuteNonQuery()
            Form2.kmt.Dispose()
            Form2.bag.Close()
            Form2.listele()
            Me.Close()
        Else
            MessageBox.Show("Tckimlik alanını boş bırakmayınız !!!")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Dogum_TarihiLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class