Imports System.Data.OleDb

Public Class Form3
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GünlükLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub HaftalıkLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AylıkLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form6.TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        Form6.TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        Form6.TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        Form6.TextBox4.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        Form6.TextBox5.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        Form6.TextBox6.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        Form6.TextBox7.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()
        Form6.TextBox8.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString()
        Form6.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim cevap As DialogResult
            cevap = MessageBox.Show("Kaydı silmek istediğinizden eminmisiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If cevap = DialogResult.Yes And DataGridView1.CurrentRow.Cells(0).Value.ToString().Trim() <> "" Then

                Form2.bag.Open()
                Form2.kmt.Connection = Form2.bag
                Form2.kmt.CommandText = "DELETE from aracbil WHERE Plaka='" & DataGridView1.CurrentRow.Cells(0).Value.ToString() & "'"
                Form2.kmt.ExecuteNonQuery()
                Form2.kmt.Dispose()
                Form2.bag.Close()
                Form2.aracListele()
            End If
        Catch

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If (TextBox1.Text.Trim() <> "") Then
                Form2.bag.Open()
                Form2.kmt.Connection = Form2.bag
                Form2.kmt.CommandText = "INSERT INTO aracbil(Plaka,Marka,Tip,Model,Renk,Gunluk,Haftalik,Aylik,Durum) VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','Uygun') "
                Form2.kmt.ExecuteNonQuery()
                Form2.kmt.Dispose()
                Form2.bag.Close()
                Form2.aracListele()
                MessageBox.Show("Kayıt işlemi tamamlandı ! ")
                For i As Integer = 0 To Me.Controls.Count - 1
                    If TypeOf Me.Controls(i) Is TextBox Then
                        Me.Controls(i).Text = ""
                    End If
                Next
            Else
                MessageBox.Show("Plaka alanını boş bırakmayınız !")
            End If
        Catch ex As Exception
            MessageBox.Show("Kayıtlı Plaka Girişi !")
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.aracListele()
    End Sub

    Private Sub PlakaToolStripButton1_Click(sender As Object, e As EventArgs) Handles PlakaToolStripButton1.Click
        Dim adtr As New OleDbDataAdapter("select * From aracbil", Form2.bag)
        If PlakaToolStripTextBox1.Text = "" Then
            Form2.kmt.Connection = Form2.bag
            Form2.kmt.CommandText = "Select * from aracbil"
            adtr.SelectCommand = Form2.kmt
            adtr.Fill(Form2.aracTablo)
        End If
        If Convert.ToBoolean(Form2.bag.State) = False Then
            Form2.bag.Open()
        End If
        adtr.SelectCommand.CommandText = (" Select * From aracbil" & " where(Plaka like '%") & PlakaToolStripTextBox1.Text & "%' )"
        Form2.aracTablo.Clear()
        adtr.Fill(Form2.aracTablo)
        Form2.bag.Close()
    End Sub
End Class