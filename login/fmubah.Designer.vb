<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmubah
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmubah))
        Me.pnlLeftSide = New System.Windows.Forms.Panel()
        Me.pnlOnButtonPosition = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnkontak = New System.Windows.Forms.Button()
        Me.btnhasil = New System.Windows.Forms.Button()
        Me.btnnilai = New System.Windows.Forms.Button()
        Me.btndata = New System.Windows.Forms.Button()
        Me.pnlTopSide = New System.Windows.Forms.Panel()
        Me.btnminimize = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtPassword2 = New System.Windows.Forms.TextBox()
        Me.dgvLogin = New System.Windows.Forms.DataGridView()
        Me.cbUsername = New System.Windows.Forms.ComboBox()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.pnlLeftSide.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTopSide.SuspendLayout()
        CType(Me.dgvLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlLeftSide
        '
        Me.pnlLeftSide.BackColor = System.Drawing.Color.White
        Me.pnlLeftSide.Controls.Add(Me.pnlOnButtonPosition)
        Me.pnlLeftSide.Controls.Add(Me.PictureBox1)
        Me.pnlLeftSide.Controls.Add(Me.btnkontak)
        Me.pnlLeftSide.Controls.Add(Me.btnhasil)
        Me.pnlLeftSide.Controls.Add(Me.btnnilai)
        Me.pnlLeftSide.Controls.Add(Me.btndata)
        Me.pnlLeftSide.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeftSide.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeftSide.Name = "pnlLeftSide"
        Me.pnlLeftSide.Size = New System.Drawing.Size(158, 390)
        Me.pnlLeftSide.TabIndex = 10
        '
        'pnlOnButtonPosition
        '
        Me.pnlOnButtonPosition.BackColor = System.Drawing.Color.Red
        Me.pnlOnButtonPosition.Location = New System.Drawing.Point(0, 297)
        Me.pnlOnButtonPosition.Name = "pnlOnButtonPosition"
        Me.pnlOnButtonPosition.Size = New System.Drawing.Size(10, 32)
        Me.pnlOnButtonPosition.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImage = Global.spk.My.Resources.Resources.telkom_akses_logo_7ECCB5449C_seeklogo_com
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(0, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'btnkontak
        '
        Me.btnkontak.FlatAppearance.BorderSize = 0
        Me.btnkontak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnkontak.Image = Global.spk.My.Resources.Resources.contact__1_
        Me.btnkontak.Location = New System.Drawing.Point(2, 297)
        Me.btnkontak.Name = "btnkontak"
        Me.btnkontak.Size = New System.Drawing.Size(154, 31)
        Me.btnkontak.TabIndex = 2
        Me.btnkontak.Text = "     Ubah Kata Sandi"
        Me.btnkontak.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnkontak.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnkontak.UseVisualStyleBackColor = True
        '
        'btnhasil
        '
        Me.btnhasil.FlatAppearance.BorderSize = 0
        Me.btnhasil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhasil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhasil.Image = Global.spk.My.Resources.Resources.research
        Me.btnhasil.Location = New System.Drawing.Point(0, 233)
        Me.btnhasil.Name = "btnhasil"
        Me.btnhasil.Size = New System.Drawing.Size(156, 31)
        Me.btnhasil.TabIndex = 2
        Me.btnhasil.Text = "     Hasil Penilaian"
        Me.btnhasil.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnhasil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnhasil.UseVisualStyleBackColor = True
        '
        'btnnilai
        '
        Me.btnnilai.FlatAppearance.BorderSize = 0
        Me.btnnilai.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnilai.Image = Global.spk.My.Resources.Resources.calculator
        Me.btnnilai.Location = New System.Drawing.Point(3, 170)
        Me.btnnilai.Name = "btnnilai"
        Me.btnnilai.Size = New System.Drawing.Size(152, 31)
        Me.btnnilai.TabIndex = 2
        Me.btnnilai.Text = "     Penilaian"
        Me.btnnilai.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnnilai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnnilai.UseVisualStyleBackColor = True
        '
        'btndata
        '
        Me.btndata.FlatAppearance.BorderSize = 0
        Me.btndata.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndata.Image = Global.spk.My.Resources.Resources.recruitment__2_
        Me.btndata.Location = New System.Drawing.Point(2, 113)
        Me.btndata.Name = "btndata"
        Me.btndata.Size = New System.Drawing.Size(153, 32)
        Me.btndata.TabIndex = 2
        Me.btndata.Text = "     Data Master"
        Me.btndata.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btndata.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btndata.UseVisualStyleBackColor = True
        '
        'pnlTopSide
        '
        Me.pnlTopSide.BackColor = System.Drawing.Color.Red
        Me.pnlTopSide.Controls.Add(Me.btnminimize)
        Me.pnlTopSide.Controls.Add(Me.btnclose)
        Me.pnlTopSide.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopSide.Location = New System.Drawing.Point(158, 0)
        Me.pnlTopSide.Name = "pnlTopSide"
        Me.pnlTopSide.Size = New System.Drawing.Size(474, 52)
        Me.pnlTopSide.TabIndex = 16
        '
        'btnminimize
        '
        Me.btnminimize.BackColor = System.Drawing.Color.Red
        Me.btnminimize.BackgroundImage = Global.spk.My.Resources.Resources.iconfinder_723__minus__minimize__website_3838428
        Me.btnminimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnminimize.FlatAppearance.BorderSize = 0
        Me.btnminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnminimize.Location = New System.Drawing.Point(443, 0)
        Me.btnminimize.Name = "btnminimize"
        Me.btnminimize.Size = New System.Drawing.Size(14, 22)
        Me.btnminimize.TabIndex = 13
        Me.btnminimize.UseVisualStyleBackColor = False
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Red
        Me.btnclose.BackgroundImage = Global.spk.My.Resources.Resources.iconfinder_cancel_1303884
        Me.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Location = New System.Drawing.Point(460, 0)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(14, 22)
        Me.btnclose.TabIndex = 12
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(168, 61)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(174, 25)
        Me.lblPassword.TabIndex = 8
        Me.lblPassword.Text = "Ubah Kata Sandi"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(173, 129)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(158, 20)
        Me.txtPassword.TabIndex = 17
        Me.txtPassword.Text = "Kata Sandi"
        '
        'txtPassword2
        '
        Me.txtPassword2.Location = New System.Drawing.Point(173, 155)
        Me.txtPassword2.Name = "txtPassword2"
        Me.txtPassword2.Size = New System.Drawing.Size(158, 20)
        Me.txtPassword2.TabIndex = 18
        Me.txtPassword2.Text = "Ulangi Kata Sandi"
        '
        'dgvLogin
        '
        Me.dgvLogin.AllowUserToAddRows = False
        Me.dgvLogin.AllowUserToDeleteRows = False
        Me.dgvLogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLogin.Location = New System.Drawing.Point(173, 210)
        Me.dgvLogin.Name = "dgvLogin"
        Me.dgvLogin.ReadOnly = True
        Me.dgvLogin.Size = New System.Drawing.Size(442, 168)
        Me.dgvLogin.TabIndex = 19
        '
        'cbUsername
        '
        Me.cbUsername.FormattingEnabled = True
        Me.cbUsername.Location = New System.Drawing.Point(173, 102)
        Me.cbUsername.Name = "cbUsername"
        Me.cbUsername.Size = New System.Drawing.Size(158, 21)
        Me.cbUsername.TabIndex = 22
        Me.cbUsername.Text = "-- Pilih User --"
        '
        'btnUbah
        '
        Me.btnUbah.Location = New System.Drawing.Point(173, 181)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(158, 23)
        Me.btnUbah.TabIndex = 23
        Me.btnUbah.Text = "Ubah Kata Sandi"
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'fmubah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(632, 390)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.cbUsername)
        Me.Controls.Add(Me.dgvLogin)
        Me.Controls.Add(Me.txtPassword2)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.pnlTopSide)
        Me.Controls.Add(Me.pnlLeftSide)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fmubah"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fmkontak"
        Me.pnlLeftSide.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTopSide.ResumeLayout(False)
        CType(Me.dgvLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlLeftSide As System.Windows.Forms.Panel
    Friend WithEvents pnlOnButtonPosition As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnkontak As System.Windows.Forms.Button
    Friend WithEvents btnhasil As System.Windows.Forms.Button
    Friend WithEvents btnnilai As System.Windows.Forms.Button
    Friend WithEvents btndata As System.Windows.Forms.Button
    Friend WithEvents pnlTopSide As System.Windows.Forms.Panel
    Friend WithEvents btnminimize As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtPassword2 As TextBox
    Friend WithEvents dgvLogin As DataGridView
    Friend WithEvents cbUsername As ComboBox
    Friend WithEvents btnUbah As Button
End Class
