<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Button7 = New System.Windows.Forms.Button()
        Me.SoyadToolStrip = New System.Windows.Forms.ToolStrip()
        Me.TcNumaraToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.TcNumaraToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.TcNumaraToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
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
        Me.SoyadToolStrip.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Label1.Location = New System.Drawing.Point(13, 136)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(87, 28)
        Label1.TabIndex = 118
        Label1.Text = "Cinsiyet"
        '
        'Tc_Kimlik_NoLabel
        '
        Tc_Kimlik_NoLabel.AutoSize = True
        Tc_Kimlik_NoLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Tc_Kimlik_NoLabel.Location = New System.Drawing.Point(13, 33)
        Tc_Kimlik_NoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Tc_Kimlik_NoLabel.Name = "Tc_Kimlik_NoLabel"
        Tc_Kimlik_NoLabel.Size = New System.Drawing.Size(137, 28)
        Tc_Kimlik_NoLabel.TabIndex = 106
        Tc_Kimlik_NoLabel.Text = "Tc Kimlik No:"
        '
        'SoyadLabel
        '
        SoyadLabel.AutoSize = True
        SoyadLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        SoyadLabel.Location = New System.Drawing.Point(13, 98)
        SoyadLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SoyadLabel.Name = "SoyadLabel"
        SoyadLabel.Size = New System.Drawing.Size(74, 28)
        SoyadLabel.TabIndex = 108
        SoyadLabel.Text = "Soyad:"
        '
        'AdLabel
        '
        AdLabel.AutoSize = True
        AdLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        AdLabel.Location = New System.Drawing.Point(13, 66)
        AdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AdLabel.Name = "AdLabel"
        AdLabel.Size = New System.Drawing.Size(43, 28)
        AdLabel.TabIndex = 107
        AdLabel.Text = "Ad:"
        '
        'Dogum_TarihiLabel
        '
        Dogum_TarihiLabel.AutoSize = True
        Dogum_TarihiLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Dogum_TarihiLabel.Location = New System.Drawing.Point(13, 183)
        Dogum_TarihiLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Dogum_TarihiLabel.Name = "Dogum_TarihiLabel"
        Dogum_TarihiLabel.Size = New System.Drawing.Size(145, 28)
        Dogum_TarihiLabel.TabIndex = 109
        Dogum_TarihiLabel.Text = "Doğum Tarihi:"
        '
        'Dogum_YeriLabel
        '
        Dogum_YeriLabel.AutoSize = True
        Dogum_YeriLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Dogum_YeriLabel.Location = New System.Drawing.Point(13, 215)
        Dogum_YeriLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Dogum_YeriLabel.Name = "Dogum_YeriLabel"
        Dogum_YeriLabel.Size = New System.Drawing.Size(127, 28)
        Dogum_YeriLabel.TabIndex = 110
        Dogum_YeriLabel.Text = "Doğum Yeri:"
        '
        'TelefonLabel
        '
        TelefonLabel.AutoSize = True
        TelefonLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        TelefonLabel.Location = New System.Drawing.Point(13, 247)
        TelefonLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TelefonLabel.Name = "TelefonLabel"
        TelefonLabel.Size = New System.Drawing.Size(87, 28)
        TelefonLabel.TabIndex = 111
        TelefonLabel.Text = "Telefon:"
        '
        'Cep_TelefonuLabel
        '
        Cep_TelefonuLabel.AutoSize = True
        Cep_TelefonuLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Cep_TelefonuLabel.Location = New System.Drawing.Point(13, 279)
        Cep_TelefonuLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Cep_TelefonuLabel.Name = "Cep_TelefonuLabel"
        Cep_TelefonuLabel.Size = New System.Drawing.Size(140, 28)
        Cep_TelefonuLabel.TabIndex = 112
        Cep_TelefonuLabel.Text = "Cep Telefonu:"
        '
        'E_MailLabel
        '
        E_MailLabel.AutoSize = True
        E_MailLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        E_MailLabel.Location = New System.Drawing.Point(13, 311)
        E_MailLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        E_MailLabel.Name = "E_MailLabel"
        E_MailLabel.Size = New System.Drawing.Size(78, 28)
        E_MailLabel.TabIndex = 113
        E_MailLabel.Text = "E-Mail:"
        '
        'AdresLabel
        '
        AdresLabel.AutoSize = True
        AdresLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        AdresLabel.Location = New System.Drawing.Point(13, 343)
        AdresLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AdresLabel.Name = "AdresLabel"
        AdresLabel.Size = New System.Drawing.Size(71, 28)
        AdresLabel.TabIndex = 114
        AdresLabel.Text = "Adres:"
        '
        'Ehliyet_NoLabel
        '
        Ehliyet_NoLabel.AutoSize = True
        Ehliyet_NoLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Ehliyet_NoLabel.Location = New System.Drawing.Point(13, 466)
        Ehliyet_NoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Ehliyet_NoLabel.Name = "Ehliyet_NoLabel"
        Ehliyet_NoLabel.Size = New System.Drawing.Size(116, 28)
        Ehliyet_NoLabel.TabIndex = 115
        Ehliyet_NoLabel.Text = "Ehliyet No:"
        '
        'Eliyet_TarihiLabel
        '
        Eliyet_TarihiLabel.AutoSize = True
        Eliyet_TarihiLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Eliyet_TarihiLabel.Location = New System.Drawing.Point(13, 498)
        Eliyet_TarihiLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Eliyet_TarihiLabel.Name = "Eliyet_TarihiLabel"
        Eliyet_TarihiLabel.Size = New System.Drawing.Size(141, 28)
        Eliyet_TarihiLabel.TabIndex = 116
        Eliyet_TarihiLabel.Text = "Ehliyet Tarihi:"
        '
        'Ehliyet_Verilen_YerLabel
        '
        Ehliyet_Verilen_YerLabel.AutoSize = True
        Ehliyet_Verilen_YerLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Ehliyet_Verilen_YerLabel.Location = New System.Drawing.Point(13, 530)
        Ehliyet_Verilen_YerLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Ehliyet_Verilen_YerLabel.Name = "Ehliyet_Verilen_YerLabel"
        Ehliyet_Verilen_YerLabel.Size = New System.Drawing.Size(190, 28)
        Ehliyet_Verilen_YerLabel.TabIndex = 117
        Ehliyet_Verilen_YerLabel.Text = "Ehliyet Verilen Yer:"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button7.Location = New System.Drawing.Point(1399, 35)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(84, 33)
        Me.Button7.TabIndex = 121
        Me.Button7.Text = "Çıkış"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'SoyadToolStrip
        '
        Me.SoyadToolStrip.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SoyadToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.SoyadToolStrip.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SoyadToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.SoyadToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TcNumaraToolStripLabel, Me.TcNumaraToolStripTextBox, Me.TcNumaraToolStripButton})
        Me.SoyadToolStrip.Location = New System.Drawing.Point(887, 33)
        Me.SoyadToolStrip.Name = "SoyadToolStrip"
        Me.SoyadToolStrip.Size = New System.Drawing.Size(460, 35)
        Me.SoyadToolStrip.TabIndex = 120
        Me.SoyadToolStrip.Text = "TcNumaraToolStrip"
        '
        'TcNumaraToolStripLabel
        '
        Me.TcNumaraToolStripLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None
        Me.TcNumaraToolStripLabel.Enabled = False
        Me.TcNumaraToolStripLabel.Name = "TcNumaraToolStripLabel"
        Me.TcNumaraToolStripLabel.Size = New System.Drawing.Size(0, 32)
        Me.TcNumaraToolStripLabel.Text = "TcNumara:"
        '
        'TcNumaraToolStripTextBox
        '
        Me.TcNumaraToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TcNumaraToolStripTextBox.Name = "TcNumaraToolStripTextBox"
        Me.TcNumaraToolStripTextBox.Size = New System.Drawing.Size(265, 35)
        '
        'TcNumaraToolStripButton
        '
        Me.TcNumaraToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.TcNumaraToolStripButton.Name = "TcNumaraToolStripButton"
        Me.TcNumaraToolStripButton.Size = New System.Drawing.Size(141, 32)
        Me.TcNumaraToolStripButton.Text = "Tc Kimlik Ara"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Kadın", "Erkek"})
        Me.ComboBox1.Location = New System.Drawing.Point(184, 142)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox1.TabIndex = 119
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button3.Location = New System.Drawing.Point(699, 29)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(107, 33)
        Me.Button3.TabIndex = 105
        Me.Button3.Text = "Sil"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button2.Location = New System.Drawing.Point(813, 29)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 34)
        Me.Button2.TabIndex = 104
        Me.Button2.Text = "Kaydet"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button1.Location = New System.Drawing.Point(557, 28)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 34)
        Me.Button1.TabIndex = 103
        Me.Button1.Text = "Düzenle"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(557, 88)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(925, 485)
        Me.DataGridView1.TabIndex = 102
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(231, 537)
        Me.TextBox10.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(132, 22)
        Me.TextBox10.TabIndex = 101
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(184, 473)
        Me.TextBox9.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(132, 22)
        Me.TextBox9.TabIndex = 100
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(184, 348)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(132, 22)
        Me.TextBox8.TabIndex = 99
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(184, 314)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(132, 22)
        Me.TextBox7.TabIndex = 98
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(184, 281)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox6.MaxLength = 11
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(132, 22)
        Me.TextBox6.TabIndex = 97
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(184, 248)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox5.MaxLength = 11
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(132, 22)
        Me.TextBox5.TabIndex = 96
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(184, 215)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(132, 22)
        Me.TextBox4.TabIndex = 95
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(184, 105)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(132, 22)
        Me.TextBox3.TabIndex = 94
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(184, 72)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(132, 22)
        Me.TextBox2.TabIndex = 93
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(184, 40)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.MaxLength = 11
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 22)
        Me.TextBox1.TabIndex = 92
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(184, 506)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(265, 22)
        Me.DateTimePicker2.TabIndex = 91
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(184, 183)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(265, 22)
        Me.DateTimePicker1.TabIndex = 90
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1520, 651)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.SoyadToolStrip)
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
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
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
        Me.Name = "Form2"
        Me.Text = "Müşteriler"
        Me.SoyadToolStrip.ResumeLayout(False)
        Me.SoyadToolStrip.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button7 As Button
    Friend WithEvents SoyadToolStrip As ToolStrip
    Friend WithEvents TcNumaraToolStripLabel As ToolStripLabel
    Friend WithEvents TcNumaraToolStripTextBox As ToolStripTextBox
    Friend WithEvents TcNumaraToolStripButton As ToolStripButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
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
