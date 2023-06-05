Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text.Trim() <> "" Then
            Form2.bag.Open()
            Form2.kmt.Connection = Form2.bag
            Form2.kmt.CommandText = "UPDATE aracbil SET Plaka='" & TextBox1.Text & "',Marka='" & TextBox2.Text & "',Tip='" & TextBox3.Text & "',Model='" & TextBox4.Text & "',Renk='" & TextBox5.Text & "',Gunluk='" & TextBox6.Text & "',Haftalik='" & TextBox7.Text & "',Aylik='" & TextBox8.Text & "' WHERE Plaka='" & Form3.DataGridView1.CurrentRow.Cells(0).Value.ToString() & "' "
            Form2.kmt.ExecuteNonQuery()
            Form2.kmt.Dispose()
            Form2.bag.Close()
            Form2.aracListele()
            Me.Close()
        Else
            MessageBox.Show("Tckimlik alanını boş bırakmayınız !!!")
        End If
    End Sub
End Class