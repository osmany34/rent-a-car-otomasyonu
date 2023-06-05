<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim GünlükLabel As System.Windows.Forms.Label
        Dim HaftalıkLabel As System.Windows.Forms.Label
        Dim AylıkLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.PlakaToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.PlakaToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.PlakaToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.PlakaToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        GünlükLabel = New System.Windows.Forms.Label()
        HaftalıkLabel = New System.Windows.Forms.Label()
        AylıkLabel = New System.Windows.Forms.Label()
        Me.PlakaToolStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Label1.Location = New System.Drawing.Point(22, 21)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(68, 28)
        Label1.TabIndex = 110
        Label1.Text = "Plaka:"
        AddHandler Label1.Click, AddressOf Me.Label1_Click
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Label2.Location = New System.Drawing.Point(22, 53)
        Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(77, 28)
        Label2.TabIndex = 111
        Label2.Text = "Marka:"
        AddHandler Label2.Click, AddressOf Me.Label2_Click
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Label3.Location = New System.Drawing.Point(22, 85)
        Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(47, 28)
        Label3.TabIndex = 112
        Label3.Text = "Tip:"
        AddHandler Label3.Click, AddressOf Me.Label3_Click
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Label4.Location = New System.Drawing.Point(22, 117)
        Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(77, 28)
        Label4.TabIndex = 113
        Label4.Text = "Model:"
        AddHandler Label4.Click, AddressOf Me.Label4_Click
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Label5.Location = New System.Drawing.Point(22, 149)
        Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(65, 28)
        Label5.TabIndex = 114
        Label5.Text = "Renk:"
        AddHandler Label5.Click, AddressOf Me.Label5_Click
        '
        'GünlükLabel
        '
        GünlükLabel.AutoSize = True
        GünlükLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        GünlükLabel.Location = New System.Drawing.Point(22, 205)
        GünlükLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        GünlükLabel.Name = "GünlükLabel"
        GünlükLabel.Size = New System.Drawing.Size(85, 28)
        GünlükLabel.TabIndex = 115
        GünlükLabel.Text = "Günlük:"
        AddHandler GünlükLabel.Click, AddressOf Me.GünlükLabel_Click
        '
        'HaftalıkLabel
        '
        HaftalıkLabel.AutoSize = True
        HaftalıkLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        HaftalıkLabel.Location = New System.Drawing.Point(22, 237)
        HaftalıkLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        HaftalıkLabel.Name = "HaftalıkLabel"
        HaftalıkLabel.Size = New System.Drawing.Size(94, 28)
        HaftalıkLabel.TabIndex = 116
        HaftalıkLabel.Text = "Haftalık:"
        AddHandler HaftalıkLabel.Click, AddressOf Me.HaftalıkLabel_Click
        '
        'AylıkLabel
        '
        AylıkLabel.AutoSize = True
        AylıkLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        AylıkLabel.Location = New System.Drawing.Point(22, 269)
        AylıkLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AylıkLabel.Name = "AylıkLabel"
        AylıkLabel.Size = New System.Drawing.Size(66, 28)
        AylıkLabel.TabIndex = 117
        AylıkLabel.Text = "Aylık:"
        AddHandler AylıkLabel.Click, AddressOf Me.AylıkLabel_Click
        '
        'PlakaToolStrip1
        '
        Me.PlakaToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.PlakaToolStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.PlakaToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.PlakaToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlakaToolStripLabel1, Me.PlakaToolStripTextBox1, Me.PlakaToolStripButton1})
        Me.PlakaToolStrip1.Location = New System.Drawing.Point(370, 28)
        Me.PlakaToolStrip1.Name = "PlakaToolStrip1"
        Me.PlakaToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.PlakaToolStrip1.Size = New System.Drawing.Size(349, 35)
        Me.PlakaToolStrip1.TabIndex = 118
        Me.PlakaToolStrip1.Text = "PlakaToolStrip1"
        '
        'PlakaToolStripLabel1
        '
        Me.PlakaToolStripLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PlakaToolStripLabel1.Name = "PlakaToolStripLabel1"
        Me.PlakaToolStripLabel1.Size = New System.Drawing.Size(137, 32)
        Me.PlakaToolStripLabel1.Text = "Araç [Plaka] :"
        '
        'PlakaToolStripTextBox1
        '
        Me.PlakaToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PlakaToolStripTextBox1.Name = "PlakaToolStripTextBox1"
        Me.PlakaToolStripTextBox1.Size = New System.Drawing.Size(150, 35)
        '
        'PlakaToolStripButton1
        '
        Me.PlakaToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.PlakaToolStripButton1.Name = "PlakaToolStripButton1"
        Me.PlakaToolStripButton1.Size = New System.Drawing.Size(47, 32)
        Me.PlakaToolStripButton1.Text = "Bul"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button7.Location = New System.Drawing.Point(1051, 242)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(213, 44)
        Me.Button7.TabIndex = 109
        Me.Button7.Text = "Çıkış"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button3.Location = New System.Drawing.Point(1051, 129)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(213, 48)
        Me.Button3.TabIndex = 108
        Me.Button3.Text = "Sil"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button2.Location = New System.Drawing.Point(1051, 185)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(213, 48)
        Me.Button2.TabIndex = 107
        Me.Button2.Text = "Kaydet"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button1.Location = New System.Drawing.Point(1051, 77)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(213, 44)
        Me.Button1.TabIndex = 106
        Me.Button1.Text = "Düzenle"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(289, 84)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(723, 482)
        Me.DataGridView1.TabIndex = 105
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(134, 276)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(132, 22)
        Me.TextBox8.TabIndex = 104
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(134, 242)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(132, 22)
        Me.TextBox7.TabIndex = 103
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(134, 209)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(132, 22)
        Me.TextBox6.TabIndex = 102
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(134, 156)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(132, 22)
        Me.TextBox5.TabIndex = 101
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(134, 124)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(132, 22)
        Me.TextBox4.TabIndex = 100
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(134, 92)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(132, 22)
        Me.TextBox3.TabIndex = 99
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(134, 60)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(132, 22)
        Me.TextBox2.TabIndex = 98
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(134, 28)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 22)
        Me.TextBox1.TabIndex = 97
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1320, 629)
        Me.Controls.Add(Me.PlakaToolStrip1)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label5)
        Me.Controls.Add(GünlükLabel)
        Me.Controls.Add(HaftalıkLabel)
        Me.Controls.Add(AylıkLabel)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.Text = "Araçlar"
        Me.PlakaToolStrip1.ResumeLayout(False)
        Me.PlakaToolStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PlakaToolStrip1 As ToolStrip
    Friend WithEvents PlakaToolStripLabel1 As ToolStripLabel
    Friend WithEvents PlakaToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents PlakaToolStripButton1 As ToolStripButton
    Friend WithEvents Button7 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Public WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
