<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Supporto
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Supporto))
        Me.La_Titolo = New System.Windows.Forms.Label()
        Me.La_info = New System.Windows.Forms.Label()
        Me.Btn_Dona = New System.Windows.Forms.PictureBox()
        Me.BtnChiudi = New System.Windows.Forms.PictureBox()
        CType(Me.Btn_Dona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnChiudi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'La_Titolo
        '
        Me.La_Titolo.AutoSize = True
        Me.La_Titolo.BackColor = System.Drawing.Color.Transparent
        Me.La_Titolo.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.La_Titolo.ForeColor = System.Drawing.Color.White
        Me.La_Titolo.Location = New System.Drawing.Point(75, 6)
        Me.La_Titolo.Name = "La_Titolo"
        Me.La_Titolo.Size = New System.Drawing.Size(250, 25)
        Me.La_Titolo.TabIndex = 0
        Me.La_Titolo.Text = "Supporta il Progetto"
        '
        'La_info
        '
        Me.La_info.BackColor = System.Drawing.Color.Transparent
        Me.La_info.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.La_info.ForeColor = System.Drawing.Color.Gold
        Me.La_info.Location = New System.Drawing.Point(2, 196)
        Me.La_info.Name = "La_info"
        Me.La_info.Size = New System.Drawing.Size(397, 46)
        Me.La_info.TabIndex = 1
        Me.La_info.Text = "Supportando puoi aumentare la vita degli Aggiornamenti che corrisponde a Nuove FU" &
    "NZIONI"
        Me.La_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn_Dona
        '
        Me.Btn_Dona.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Dona.BackgroundImage = Global.ArduCenter.My.Resources.Resources.photo_2023_11_24_17_00_32
        Me.Btn_Dona.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_Dona.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Dona.Location = New System.Drawing.Point(12, 32)
        Me.Btn_Dona.Name = "Btn_Dona"
        Me.Btn_Dona.Size = New System.Drawing.Size(376, 169)
        Me.Btn_Dona.TabIndex = 2
        Me.Btn_Dona.TabStop = False
        '
        'BtnChiudi
        '
        Me.BtnChiudi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnChiudi.BackColor = System.Drawing.Color.Transparent
        Me.BtnChiudi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnChiudi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnChiudi.Image = Global.ArduCenter.My.Resources.Resources.BtnChiudi21
        Me.BtnChiudi.Location = New System.Drawing.Point(370, 8)
        Me.BtnChiudi.Name = "BtnChiudi"
        Me.BtnChiudi.Size = New System.Drawing.Size(25, 25)
        Me.BtnChiudi.TabIndex = 8
        Me.BtnChiudi.TabStop = False
        '
        'Supporto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BackgroundImage = Global.ArduCenter.My.Resources.Resources.PanSetHardware_1_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(400, 250)
        Me.Controls.Add(Me.Btn_Dona)
        Me.Controls.Add(Me.BtnChiudi)
        Me.Controls.Add(Me.La_info)
        Me.Controls.Add(Me.La_Titolo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Supporto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supporto"
        CType(Me.Btn_Dona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnChiudi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents La_Titolo As Label
    Friend WithEvents La_info As Label
    Friend WithEvents Btn_Dona As PictureBox
    Friend WithEvents BtnChiudi As PictureBox
End Class
