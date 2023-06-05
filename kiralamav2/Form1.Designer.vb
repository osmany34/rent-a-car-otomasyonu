<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MÜŞTERİToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MÜŞTERİTABLOSUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ARAÇToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ARAÇTABLOSUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SÖZLEŞMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YENİSÖZLEŞMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MÜŞTERİToolStripMenuItem, Me.ARAÇToolStripMenuItem, Me.SÖZLEŞMEToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1445, 36)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MÜŞTERİToolStripMenuItem
        '
        Me.MÜŞTERİToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MÜŞTERİTABLOSUToolStripMenuItem})
        Me.MÜŞTERİToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.MÜŞTERİToolStripMenuItem.Name = "MÜŞTERİToolStripMenuItem"
        Me.MÜŞTERİToolStripMenuItem.Size = New System.Drawing.Size(112, 32)
        Me.MÜŞTERİToolStripMenuItem.Text = "MÜŞTERİ"
        Me.MÜŞTERİToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MÜŞTERİTABLOSUToolStripMenuItem
        '
        Me.MÜŞTERİTABLOSUToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MÜŞTERİTABLOSUToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.MÜŞTERİTABLOSUToolStripMenuItem.Name = "MÜŞTERİTABLOSUToolStripMenuItem"
        Me.MÜŞTERİTABLOSUToolStripMenuItem.Size = New System.Drawing.Size(250, 28)
        Me.MÜŞTERİTABLOSUToolStripMenuItem.Text = "MÜŞTERİ TABLOSU"
        '
        'ARAÇToolStripMenuItem
        '
        Me.ARAÇToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ARAÇTABLOSUToolStripMenuItem})
        Me.ARAÇToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ARAÇToolStripMenuItem.Name = "ARAÇToolStripMenuItem"
        Me.ARAÇToolStripMenuItem.Size = New System.Drawing.Size(79, 32)
        Me.ARAÇToolStripMenuItem.Text = "ARAÇ"
        '
        'ARAÇTABLOSUToolStripMenuItem
        '
        Me.ARAÇTABLOSUToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ARAÇTABLOSUToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ARAÇTABLOSUToolStripMenuItem.Name = "ARAÇTABLOSUToolStripMenuItem"
        Me.ARAÇTABLOSUToolStripMenuItem.Size = New System.Drawing.Size(224, 28)
        Me.ARAÇTABLOSUToolStripMenuItem.Text = "ARAÇ TABLOSU"
        '
        'SÖZLEŞMEToolStripMenuItem
        '
        Me.SÖZLEŞMEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YENİSÖZLEŞMEToolStripMenuItem})
        Me.SÖZLEŞMEToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SÖZLEŞMEToolStripMenuItem.Name = "SÖZLEŞMEToolStripMenuItem"
        Me.SÖZLEŞMEToolStripMenuItem.Size = New System.Drawing.Size(126, 32)
        Me.SÖZLEŞMEToolStripMenuItem.Text = "SÖZLEŞME"
        '
        'YENİSÖZLEŞMEToolStripMenuItem
        '
        Me.YENİSÖZLEŞMEToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.YENİSÖZLEŞMEToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.YENİSÖZLEŞMEToolStripMenuItem.Name = "YENİSÖZLEŞMEToolStripMenuItem"
        Me.YENİSÖZLEŞMEToolStripMenuItem.Size = New System.Drawing.Size(224, 28)
        Me.YENİSÖZLEŞMEToolStripMenuItem.Text = "YENİ SÖZLEŞME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(356, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(814, 91)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "YELEK RENT A CAR"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1445, 724)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Ana Sayfa"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MÜŞTERİToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MÜŞTERİTABLOSUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ARAÇToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ARAÇTABLOSUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SÖZLEŞMEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YENİSÖZLEŞMEToolStripMenuItem As ToolStripMenuItem
    Private WithEvents Label2 As Label
End Class
