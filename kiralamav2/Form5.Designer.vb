<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Label1 As System.Windows.Forms.Label
        Dim Tc_Kimlik_NoLabel As System.Windows.Forms.Label
        Dim SoyadLabel As System.Windows.Forms.Label
        Dim AdLabel As System.Windows.Forms.Label
        Dim Dogum_TarihiLabel As System.Windows.Forms.Label
        Dim Dogum_YeriLabel As System.Windows.Forms.Label
        Dim TelefonLabel As System.Windows.Forms.Label
        Dim Cep_TelefonuLabel As System.Windows.Forms.Label
        Dim E_MailLabel As System.Windows.Forms.Label
        Dim AdresLabel As System.Windows.Forms.Label
        Dim Ehliyet_NoLabel As System.Windows.Forms.Label
        Dim Eliyet_TarihiLabel As System.Windows.Forms.Label
        Dim Ehliyet_Verilen_YerLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Label1 = New System.Windows.Forms.Label()
        Tc_Kimlik_NoLabel = New System.Windows.Forms.Label()
        SoyadLabel = New System.Windows.Forms.Label()
        AdLabel = New System.Windows.Forms.Label()
        Dogum_TarihiLabel = New System.Windows.Forms.Label()
        Dogum_YeriLabel = New System.Windows.Forms.Label()
        TelefonLabel = New System.Windows.Forms.Label()
        Cep_TelefonuLabel = New System.Windows.Forms.Label()
        E_MailLabel = New System.Windows.Forms.Label()
        AdresLabel = New System.Windows.Forms.Label()
        Ehliyet_NoLabel = New System.Windows.Forms.Label()
        Eliyet_TarihiLabel = New System.Windows.Forms.Label()
        Ehliyet_Verilen_YerLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Label1.Location = New System.Drawing.Point(30, 138)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(87, 28)
        Label1.TabIndex = 140
        Label1.Text = "Cinsiyet"
        '
        'Tc_Kimlik_NoLabel
        '
        Tc_Kimlik_NoLabel.AutoSize = True
        Tc_Kimlik_NoLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Tc_Kimlik_NoLabel.Location = New System.Drawing.Point(30, 34)
        Tc_Kimlik_NoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Tc_Kimlik_NoLabel.Name = "Tc_Kimlik_NoLabel"
        Tc_Kimlik_NoLabel.Size = New System.Drawing.Size(137, 28)
        Tc_Kimlik_NoLabel.TabIndex = 128
        Tc_Kimlik_NoLabel.Text = "Tc Kimlik No:"
        '
        'SoyadLabel
        '
        SoyadLabel.AutoSize = True
        SoyadLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        SoyadLabel.Location = New System.Drawing.Point(30, 100)
        SoyadLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SoyadLabel.Name = "SoyadLabel"
        SoyadLabel.Size = New System.Drawing.Size(74, 28)
        SoyadLabel.TabIndex = 130
        SoyadLabel.Text = "Soyad:"
        '
        'AdLabel
        '
        AdLabel.AutoSize = True
        AdLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        AdLabel.Location = New System.Drawing.Point(30, 68)
        AdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AdLabel.Name = "AdLabel"
        AdLabel.Size = New System.Drawing.Size(43, 28)
        AdLabel.TabIndex = 129
        AdLabel.Text = "Ad:"
        '
        'Dogum_TarihiLabel
        '
        Dogum_TarihiLabel.AutoSize = True
        Dogum_TarihiLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Dogum_TarihiLabel.Location = New System.Drawing.Point(30, 184)
        Dogum_TarihiLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Dogum_TarihiLabel.Name = "Dogum_TarihiLabel"
        Dogum_TarihiLabel.Size = New System.Drawing.Size(145, 28)
        Dogum_TarihiLabel.TabIndex = 131
        Dogum_TarihiLabel.Text = "Doğum Tarihi:"
        AddHandler Dogum_TarihiLabel.Click, AddressOf Me.Dogum_TarihiLabel_Click
        '
        'Dogum_YeriLabel
        '
        Dogum_YeriLabel.AutoSize = True
        Dogum_YeriLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Dogum_YeriLabel.Location = New System.Drawing.Point(30, 216)
        Dogum_YeriLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Dogum_YeriLabel.Name = "Dogum_YeriLabel"
        Dogum_YeriLabel.Size = New System.Drawing.Size(127, 28)
        Dogum_YeriLabel.TabIndex = 132
        Dogum_YeriLabel.Text = "Doğum Yeri:"
        '
        'TelefonLabel
        '
        TelefonLabel.AutoSize = True
        TelefonLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        TelefonLabel.Location = New System.Drawing.Point(30, 248)
        TelefonLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TelefonLabel.Name = "TelefonLabel"
        TelefonLabel.Size = New System.Drawing.Size(87, 28)
        TelefonLabel.TabIndex = 133
        TelefonLabel.Text = "Telefon:"
        '
        'Cep_TelefonuLabel
        '
        Cep_TelefonuLabel.AutoSize = True
        Cep_TelefonuLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Cep_TelefonuLabel.Location = New System.Drawing.Point(30, 280)
        Cep_TelefonuLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Cep_TelefonuLabel.Name = "Cep_TelefonuLabel"
        Cep_TelefonuLabel.Size = New System.Drawing.Size(140, 28)
        Cep_TelefonuLabel.TabIndex = 134
        Cep_TelefonuLabel.Text = "Cep Telefonu:"
        '
        'E_MailLabel
        '
        E_MailLabel.AutoSize = True
        E_MailLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        E_MailLabel.Location = New System.Drawing.Point(30, 312)
        E_MailLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        E_MailLabel.Name = "E_MailLabel"
        E_MailLabel.Size = New System.Drawing.Size(78, 28)
        E_MailLabel.TabIndex = 135
        E_MailLabel.Text = "E-Mail:"
        '
        'AdresLabel
        '
        AdresLabel.AutoSize = True
        AdresLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        AdresLabel.Location = New System.Drawing.Point(30, 344)
        AdresLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AdresLabel.Name = "AdresLabel"
        AdresLabel.Size = New System.Drawing.Size(71, 28)
        AdresLabel.TabIndex = 136
        AdresLabel.Text = "Adres:"
        '
        'Ehliyet_NoLabel
        '
        Ehliyet_NoLabel.AutoSize = True
        Ehliyet_NoLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Ehliyet_NoLabel.Location = New System.Drawing.Point(30, 390)
        Ehliyet_NoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Ehliyet_NoLabel.Name = "Ehliyet_NoLabel"
        Ehliyet_NoLabel.Size = New System.Drawing.Size(116, 28)
        Ehliyet_NoLabel.TabIndex = 137
        Ehliyet_NoLabel.Text = "Ehliyet No:"
        '
        'Eliyet_TarihiLabel
        '
        Eliyet_TarihiLabel.AutoSize = True
        Eliyet_TarihiLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Eliyet_TarihiLabel.Location = New System.Drawing.Point(30, 422)
        Eliyet_TarihiLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Eliyet_TarihiLabel.Name = "Eliyet_TarihiLabel"
        Eliyet_TarihiLabel.Size = New System.Drawing.Size(141, 28)
        Eliyet_TarihiLabel.TabIndex = 138
        Eliyet_TarihiLabel.Text = "Ehliyet Tarihi:"
        '
        'Ehliyet_Verilen_YerLabel
        '
        Ehliyet_Verilen_YerLabel.AutoSize = True
        Ehliyet_Verilen_YerLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Ehliyet_Verilen_YerLabel.Location = New System.Drawing.Point(30, 454)
        Ehliyet_Verilen_YerLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Ehliyet_Verilen_YerLabel.Name = "Ehliyet_Verilen_YerLabel"
        Ehliyet_Verilen_YerLabel.Size = New System.Drawing.Size(190, 28)
        Ehliyet_Verilen_YerLabel.TabIndex = 139
        Ehliyet_Verilen_YerLabel.Text = "Ehliyet Verilen Yer:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button1.Location = New System.Drawing.Point(298, 513)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 41)
        Me.Button1.TabIndex = 143
        Me.Button1.Text = "Vazgeç"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button2.Location = New System.Drawing.Point(113, 513)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 41)
        Me.Button2.TabIndex = 142
        Me.Button2.Text = "Kaydet"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Kadın", "Erkek"})
        Me.ComboBox1.Location = New System.Drawing.Point(245, 142)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox1.TabIndex = 141
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(245, 461)
        Me.TextBox10.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(132, 22)
        Me.TextBox10.TabIndex = 127
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(245, 395)
        Me.TextBox9.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(132, 22)
        Me.TextBox9.TabIndex = 126
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(245, 347)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(132, 22)
        Me.TextBox8.TabIndex = 125
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(245, 314)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(132, 22)
        Me.TextBox7.TabIndex = 124
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(245, 281)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox6.MaxLength = 11
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(132, 22)
        Me.TextBox6.TabIndex = 123
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(245, 248)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox5.MaxLength = 11
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(132, 22)
        Me.TextBox5.TabIndex = 122
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(245, 214)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(132, 22)
        Me.TextBox4.TabIndex = 121
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(245, 105)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(132, 22)
        Me.TextBox3.TabIndex = 120
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(245, 72)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(132, 22)
        Me.TextBox2.TabIndex = 119
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(245, 40)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.MaxLength = 11
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 22)
        Me.TextBox1.TabIndex = 118
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(245, 429)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(265, 22)
        Me.DateTimePicker2.TabIndex = 117
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(245, 182)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(265, 22)
        Me.DateTimePicker1.TabIndex = 116
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 613)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Tc_Kimlik_NoLabel)
        Me.Controls.Add(SoyadLabel)
        Me.Controls.Add(AdLabel)
        Me.Controls.Add(Dogum_TarihiLabel)
        Me.Controls.Add(Dogum_YeriLabel)
        Me.Controls.Add(TelefonLabel)
        Me.Controls.Add(Cep_TelefonuLabel)
        Me.Controls.Add(E_MailLabel)
        Me.Controls.Add(AdresLabel)
        Me.Controls.Add(Ehliyet_NoLabel)
        Me.Controls.Add(Eliyet_TarihiLabel)
        Me.Controls.Add(Ehliyet_Verilen_YerLabel)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form5"
        Me.Text = "Müşteri Düzenleme"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
