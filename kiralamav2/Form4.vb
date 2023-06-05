Imports System.Data.OleDb

Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.comboTcKimlik()
        Form2.comboPlaka()
        Form2.sozlesmeListele()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Try
            Dim cevap As DialogResult
            cevap = MessageBox.Show("Kaydı silmek istediğinizden eminmisiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If cevap = DialogResult.Yes And DataGridView1.CurrentRow.Cells(0).Value.ToString().Trim() <> "" Then

                Form2.bag.Open()
                Form2.kmt.Connection = Form2.bag
                Form2.kmt.CommandText = "DELETE from sozlesmebil WHERE Plaka='" & DataGridView1.CurrentRow.Cells(19).Value.ToString() & "'"

                Form2.kmt.ExecuteNonQuery()
                Form2.kmt.Dispose()
                Form2.bag.Close()
                Form2.sozlesmeListele()
            End If
        Catch

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (TextBox1.Text.Trim() <> "" And TextBox17.Text.Trim() <> "") Then
            Form2.bag.Open()
            Form2.kmt.Connection = Form2.bag
            Form2.kmt.CommandText = "INSERT INTO sozlesmebil(TcKimlikNo,Ad,Soyad,Cinsiyet,DogumTarihi,DogumYeri,Telefon,CepTel,Email,Adres,EhliyetNo,EhliyetTarihi,EhliyetVerilenYer,SurucuAd,KefilAd,KefilSoyad,KefilAdres,KefilTel,KefilCep,Plaka,Marka,Tip,Model,Renk,Gunluk,Haftalik,Aylik,CikisZamani,DonusZamani,EkTutar,Toplam,Aciklama) VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox2.Text & "','" & DateTimePicker1.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & DateTimePicker2.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox13.Text & "','" & TextBox14.Text & "','" & TextBox15.Text & "','" & TextBox16.Text & "','" & TextBox17.Text & "','" & TextBox18.Text & "','" & TextBox19.Text & "','" & TextBox20.Text & "','" & TextBox21.Text & "','" & TextBox22.Text & "','" & TextBox23.Text & "','" & TextBox24.Text & "','" & DateTimePicker3.Text & "','" & DateTimePicker4.Text & "','" & TextBox25.Text & "','" & TextBox26.Text & "','" & TextBox27.Text & "') "
            Form2.kmt.ExecuteNonQuery()
            Form2.kmt.CommandText = "UPDATE aracbil SET Durum='Kirada' WHERE Plaka='" & ComboBox3.Text & "' "
            Form2.kmt.ExecuteNonQuery()
            Form2.kmt.Dispose()
            Form2.bag.Close()
            Form2.sozlesmeListele()
            ComboBox3.Text = ""
            Form2.comboPlaka()
            MessageBox.Show("Kiralama işlemi tamamlandı ! ")
            For i As Integer = 0 To Me.Controls.Count - 1
                If TypeOf Me.Controls(i) Is TextBox Then
                    Me.Controls(i).Text = ""
                End If
                If TypeOf Me.Controls(i) Is ComboBox Then
                    Me.Controls(i).Text = ""
                End If
            Next
        Else
            MessageBox.Show("Müşteri ve Araç seçimi yapınız !")
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            If DataGridView1.CurrentRow.Cells(0).Value.ToString().Trim() <> "" Then

                Form2.bag.Open()
                Form2.kmt.Connection = Form2.bag
                Form2.kmt.CommandText = "UPDATE aracbil SET Durum='Uygun' WHERE Plaka='" & DataGridView1.CurrentRow.Cells(19).Value.ToString() & "' "
                Form2.kmt.ExecuteNonQuery()
                Form2.kmt.CommandText = "DELETE from sozlesmebil WHERE Plaka='" & DataGridView1.CurrentRow.Cells(19).Value.ToString() & "'"

                Form2.kmt.ExecuteNonQuery()
                Form2.kmt.Dispose()
                Form2.bag.Close()
                Form2.comboPlaka()
                Form2.sozlesmeListele()
                MessageBox.Show("Teslim alma işlemi gerçekleştirildi !")
            End If
        Catch

        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Form2.bag.Open()
        Form2.kmt.Connection = Form2.bag
        Form2.kmt.CommandText = "Select * from musbil where TcKimlikNo='" & ComboBox1.Text & "'"
        Dim oku As OleDbDataReader
        oku = Form2.kmt.ExecuteReader()
        While oku.Read()
            TextBox1.Text = oku(0).ToString()
            TextBox2.Text = oku(1).ToString()
            TextBox3.Text = oku(2).ToString()
            ComboBox2.Text = oku(3).ToString()
            DateTimePicker1.Text = oku(4).ToString()
            TextBox4.Text = oku(5).ToString()
            TextBox5.Text = oku(6).ToString()
            TextBox6.Text = oku(7).ToString()
            TextBox7.Text = oku(8).ToString()
            TextBox8.Text = oku(9).ToString()
            TextBox9.Text = oku(10).ToString()
            DateTimePicker2.Text = oku(11).ToString()
            TextBox10.Text = oku(12).ToString()
        End While
        Form2.kmt.Dispose()
        Form2.bag.Close()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Form2.bag.Open()
        Form2.kmt.Connection = Form2.bag
        Form2.kmt.CommandText = "Select * from aracbil where Plaka='" & ComboBox3.Text & "'"
        Dim oku As OleDbDataReader
        oku = Form2.kmt.ExecuteReader()
        While oku.Read()
            TextBox17.Text = oku(0).ToString()
            TextBox18.Text = oku(1).ToString()
            TextBox19.Text = oku(2).ToString()
            TextBox20.Text = oku(3).ToString()
            TextBox21.Text = oku(4).ToString()
            TextBox22.Text = oku(5).ToString()
            TextBox23.Text = oku(6).ToString()
            TextBox24.Text = oku(7).ToString()
        End While
        Form2.kmt.Dispose()
        Form2.bag.Close()
    End Sub
End Class