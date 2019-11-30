<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fmpenilaian
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbnama = New System.Windows.Forms.ComboBox()
        Me.txtkerja = New System.Windows.Forms.TextBox()
        Me.txtjabatan = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.dg3 = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbRekomdasi = New System.Windows.Forms.ComboBox()
        Me.cbTest = New System.Windows.Forms.ComboBox()
        Me.cbNki = New System.Windows.Forms.ComboBox()
        Me.cbAparsial = New System.Windows.Forms.ComboBox()
        Me.cbMasaJabatan = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnminimize = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(111, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NAMA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(131, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "TANGGAL MULAI KERJA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(94, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "JABATAN"
        '
        'cbnama
        '
        Me.cbnama.FormattingEnabled = True
        Me.cbnama.Location = New System.Drawing.Point(162, 139)
        Me.cbnama.Name = "cbnama"
        Me.cbnama.Size = New System.Drawing.Size(121, 21)
        Me.cbnama.TabIndex = 5
        '
        'txtkerja
        '
        Me.txtkerja.Location = New System.Drawing.Point(162, 166)
        Me.txtkerja.Name = "txtkerja"
        Me.txtkerja.Size = New System.Drawing.Size(121, 20)
        Me.txtkerja.TabIndex = 6
        '
        'txtjabatan
        '
        Me.txtjabatan.Location = New System.Drawing.Point(162, 192)
        Me.txtjabatan.Name = "txtjabatan"
        Me.txtjabatan.Size = New System.Drawing.Size(121, 20)
        Me.txtjabatan.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImage = Global.spk.My.Resources.Resources.telkom_akses_logo_7ECCB5449C_seeklogo_com
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(636, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 53)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(401, 357)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 12
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(482, 357)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(75, 23)
        Me.btnedit.TabIndex = 13
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(563, 357)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 14
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnrefresh
        '
        Me.btnrefresh.Location = New System.Drawing.Point(320, 357)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnrefresh.TabIndex = 16
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'dg3
        '
        Me.dg3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg3.Location = New System.Drawing.Point(321, 139)
        Me.dg3.Name = "dg3"
        Me.dg3.Size = New System.Drawing.Size(473, 212)
        Me.dg3.TabIndex = 17
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(595, 112)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(149, 20)
        Me.txtSearch.TabIndex = 18
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(533, 120)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(56, 13)
        Me.lblSearch.TabIndex = 19
        Me.lblSearch.Text = "Cari Nama"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbRekomdasi)
        Me.GroupBox1.Controls.Add(Me.cbTest)
        Me.GroupBox1.Controls.Add(Me.cbNki)
        Me.GroupBox1.Controls.Add(Me.cbAparsial)
        Me.GroupBox1.Controls.Add(Me.cbMasaJabatan)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 223)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(282, 161)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kriteria"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(49, 127)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "REKOMENDASI"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(110, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "NKI"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(100, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "TEST"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(80, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "APRAISAL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "MASA JABATAN"
        '
        'cbRekomdasi
        '
        Me.cbRekomdasi.FormattingEnabled = True
        Me.cbRekomdasi.Items.AddRange(New Object() {"1. Tidak", "2. Ya"})
        Me.cbRekomdasi.Location = New System.Drawing.Point(141, 124)
        Me.cbRekomdasi.Name = "cbRekomdasi"
        Me.cbRekomdasi.Size = New System.Drawing.Size(121, 21)
        Me.cbRekomdasi.TabIndex = 5
        Me.cbRekomdasi.Text = "-- pilih --"
        '
        'cbTest
        '
        Me.cbTest.FormattingEnabled = True
        Me.cbTest.Items.AddRange(New Object() {"1. 0 - 49", "2. 50 - 59", "3. 60 - 74", "4. 75 - 84", "5. 85 - 100"})
        Me.cbTest.Location = New System.Drawing.Point(141, 97)
        Me.cbTest.Name = "cbTest"
        Me.cbTest.Size = New System.Drawing.Size(121, 21)
        Me.cbTest.TabIndex = 4
        Me.cbTest.Text = "-- pilih --"
        '
        'cbNki
        '
        Me.cbNki.FormattingEnabled = True
        Me.cbNki.Items.AddRange(New Object() {"1. P5", "2. P4", "3. P3", "4. P2", "5. P1"})
        Me.cbNki.Location = New System.Drawing.Point(141, 70)
        Me.cbNki.Name = "cbNki"
        Me.cbNki.Size = New System.Drawing.Size(121, 21)
        Me.cbNki.TabIndex = 3
        Me.cbNki.Text = "-- pilih --"
        '
        'cbAparsial
        '
        Me.cbAparsial.FormattingEnabled = True
        Me.cbAparsial.Items.AddRange(New Object() {"1. C5", "2. C4", "3. C3", "4. C2", "5. C1"})
        Me.cbAparsial.Location = New System.Drawing.Point(141, 43)
        Me.cbAparsial.Name = "cbAparsial"
        Me.cbAparsial.Size = New System.Drawing.Size(121, 21)
        Me.cbAparsial.TabIndex = 2
        Me.cbAparsial.Text = "-- pilih --"
        '
        'cbMasaJabatan
        '
        Me.cbMasaJabatan.FormattingEnabled = True
        Me.cbMasaJabatan.Items.AddRange(New Object() {"1. < 6 bulan", "2. > 1 tahun", "3. > 2 tahun", "4. > 3 tahun", "5. > 4 tahun"})
        Me.cbMasaJabatan.Location = New System.Drawing.Point(141, 16)
        Me.cbMasaJabatan.Name = "cbMasaJabatan"
        Me.cbMasaJabatan.Size = New System.Drawing.Size(121, 21)
        Me.cbMasaJabatan.TabIndex = 0
        Me.cbMasaJabatan.Text = "-- pilih --"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(750, 110)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(44, 23)
        Me.btnSearch.TabIndex = 21
        Me.btnSearch.Text = "Cari"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnminimize
        '
        Me.btnminimize.BackgroundImage = Global.spk.My.Resources.Resources.iconfinder_723__minus__minimize__website_3838428
        Me.btnminimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnminimize.FlatAppearance.BorderSize = 0
        Me.btnminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnminimize.Location = New System.Drawing.Point(760, 12)
        Me.btnminimize.Name = "btnminimize"
        Me.btnminimize.Size = New System.Drawing.Size(14, 22)
        Me.btnminimize.TabIndex = 19
        Me.btnminimize.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.BackgroundImage = Global.spk.My.Resources.Resources.iconfinder_cancel_1303884
        Me.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Location = New System.Drawing.Point(780, 12)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(14, 22)
        Me.btnclose.TabIndex = 18
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'fmpenilaian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(811, 392)
        Me.Controls.Add(Me.btnminimize)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dg3)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.txtjabatan)
        Me.Controls.Add(Me.txtkerja)
        Me.Controls.Add(Me.cbnama)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "fmpenilaian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "penilaian"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbnama As System.Windows.Forms.ComboBox
    Friend WithEvents txtkerja As System.Windows.Forms.TextBox
    Friend WithEvents txtjabatan As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnrefresh As System.Windows.Forms.Button
    Friend WithEvents dg3 As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbRekomdasi As System.Windows.Forms.ComboBox
    Friend WithEvents cbTest As System.Windows.Forms.ComboBox
    Friend WithEvents cbNki As System.Windows.Forms.ComboBox
    Friend WithEvents cbAparsial As System.Windows.Forms.ComboBox
    Friend WithEvents cbMasaJabatan As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnminimize As Button
    Friend WithEvents btnclose As Button
End Class
