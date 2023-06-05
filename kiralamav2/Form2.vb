Imports System.Data.OleDb

Public Class Form2
    Public bag As New OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=vt1.mdb")
    Public kmt As New OleDbCommand
    Public adtr As OleDbDataAdapter
    Public musteriTablo As New DataTable
    Public aracTablo As New DataTable
    Public sozlesmeTablo As New DataTable

    Sub listele()
        musteriTablo.Clear()
        bag.Open()
        adtr = New OleDbDataAdapter("select * From musbil", bag)
        adtr.Fill(musteriTablo)
        DataGridView1.DataSource = musteriTablo
        bag.Close()
        adtr.Dispose()
    End Sub
    Sub aracListele()
        aracTablo.Clear()
        bag.Open()
        adtr = New OleDbDataAdapter("select * From aracbil", bag)
        adtr.Fill(aracTablo)
        Form3.DataGridView1.DataSource = aracTablo
        bag.Close()
        adtr.Dispose()
    End Sub
    Sub sozlesmeListele()
        sozlesmeTablo.Clear()
        bag.Open()
        adtr = New OleDbDataAdapter("select * From sozlesmebil", bag)
        adtr.Fill(sozlesmeTablo)
        Form4.DataGridView1.DataSource = sozlesmeTablo
        bag.Close()
        adtr.Dispose()
    End Sub
    Sub comboTcKimlik()
        Form4.ComboBox1.Items.Clear()
        bag.Open()
        kmt.Connection = bag
        kmt.CommandText = "Select TcKimlikNo from musbil"
        Dim oku As OleDbDataReader
        oku = kmt.ExecuteReader()
        While oku.Read()
            Form4.ComboBox1.Items.Add(oku(0).ToString())
        End While
        bag.Close()
        oku.Dispose()
    End Sub
    Sub comboPlaka()
        Form4.ComboBox3.Items.Clear()
        bag.Open()
        kmt.Connection = bag
        kmt.CommandText = "Select Plaka from aracbil Where Durum='Uygun'"
        Dim oku As OleDbDataReader
        oku = kmt.ExecuteReader()
        While oku.Read()
            Form4.ComboBox3.Items.Add(oku(0).ToString())
        End While
        bag.Close()
        oku.Dispose()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form5.TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        Form5.TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        Form5.TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        Form5.ComboBox1.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        Form5.DateTimePicker1.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        Form5.TextBox4.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        Form5.TextBox5.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()
        Form5.TextBox6.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString()
        Form5.TextBox7.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString()
        Form5.TextBox8.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString()
        Form5.TextBox9.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString()
        Form5.DateTimePicker2.Text = DataGridView1.CurrentRow.Cells(11).Value.ToString()
        Form5.TextBox10.Text = DataGridView1.CurrentRow.Cells(12).Value.ToString()
        Form5.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listele()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If (TextBox1.Text.Trim() <> "") Then
                bag.Open()
                kmt.Connection = bag
                kmt.CommandText = "INSERT INTO musbil(TcKimlikNo,Ad,Soyad,Cinsiyet,DogumTarihi,DogumYeri,Telefon,CepTel,Email,Adres,EhliyetNo,EhliyetTarihi,EhliyetVerilenYer) VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "','" & DateTimePicker1.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & DateTimePicker2.Text & "','" & TextBox10.Text & "') "
                kmt.ExecuteNonQuery()
                kmt.Dispose()
                bag.Close()
                listele()
                MessageBox.Show("Kayıt işlemi tamamlandı ! ")
                For i As Integer = 0 To Me.Controls.Count - 1
                    If TypeOf Me.Controls(i) Is TextBox Then
                        Me.Controls(i).Text = ""
                    End If
                    If TypeOf Me.Controls(i) Is ComboBox Then
                        Me.Controls(i).Text = ""
                    End If
                Next
            Else
                MessageBox.Show("Tc Kimlik alanını boş bırakmayınız !")
            End If
        Catch ex As Exception
            MessageBox.Show("Kayıtlı Tc Kimlik Girişi !")
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim cevap As DialogResult
            cevap = MessageBox.Show("Kaydı silmek istediğinizden eminmisiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If cevap = DialogResult.Yes And DataGridView1.CurrentRow.Cells(0).Value.ToString().Trim() <> "" Then

                bag.Open()
                kmt.Connection = bag
                kmt.CommandText = "DELETE from musbil WHERE TcKimlikNo='" & DataGridView1.CurrentRow.Cells(0).Value.ToString() & "'"

                kmt.ExecuteNonQuery()
                kmt.Dispose()
                bag.Close()
                listele()
            End If
        Catch

        End Try
    End Sub

    Private Sub TcNumaraToolStripButton_Click(sender As Object, e As EventArgs) Handles TcNumaraToolStripButton.Click
        Dim adtr As New OleDbDataAdapter("select * From musbil", bag)
        If TcNumaraToolStripTextBox.Text = "" Then
            kmt.Connection = bag
            kmt.CommandText = "Select * from musbil"
            adtr.SelectCommand = kmt
            adtr.Fill(musteriTablo)
        End If
        If Convert.ToBoolean(bag.State) = False Then
            bag.Open()
        End If
        adtr.SelectCommand.CommandText = (" Select * From musbil" & " where(TcKimlikNo like '%") & TcNumaraToolStripTextBox.Text & "%' )"
        musteriTablo.Clear()
        adtr.Fill(musteriTablo)
        bag.Close()
    End Sub

    Private Sub SoyadToolStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles SoyadToolStrip.ItemClicked

    End Sub
End Class