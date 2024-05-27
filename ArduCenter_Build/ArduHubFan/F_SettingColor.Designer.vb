<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_SettingColor
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.N_Colore = New System.Windows.Forms.Label()
        Me.TextBoxNomeColore = New System.Windows.Forms.TextBox()
        Me.La_Conversione_Tipo = New System.Windows.Forms.Label()
        Me.LaNColore = New System.Windows.Forms.Label()
        Me.LaNSaturazione = New System.Windows.Forms.Label()
        Me.TrackBarLuminosità = New System.Windows.Forms.TrackBar()
        Me.LaNLuminosità = New System.Windows.Forms.Label()
        Me.TrackBarSaturazione = New System.Windows.Forms.TrackBar()
        Me.TrackBarColore = New System.Windows.Forms.TrackBar()
        Me.BtnChiudi = New System.Windows.Forms.PictureBox()
        Me.BtnSalva = New System.Windows.Forms.Label()
        Me.LaColore_V = New System.Windows.Forms.Label()
        Me.LaSaturazione_V = New System.Windows.Forms.Label()
        Me.LaLuminosità_V = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.TrackBarLuminosità, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarSaturazione, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarColore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnChiudi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'N_Colore
        '
        Me.N_Colore.BackColor = System.Drawing.Color.Transparent
        Me.N_Colore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.N_Colore.ForeColor = System.Drawing.Color.White
        Me.N_Colore.Location = New System.Drawing.Point(132, 17)
        Me.N_Colore.Name = "N_Colore"
        Me.N_Colore.Size = New System.Drawing.Size(142, 20)
        Me.N_Colore.TabIndex = 0
        Me.N_Colore.Text = "-"
        Me.N_Colore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxNomeColore
        '
        Me.TextBoxNomeColore.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNomeColore.Location = New System.Drawing.Point(96, 54)
        Me.TextBoxNomeColore.MaxLength = 20
        Me.TextBoxNomeColore.Name = "TextBoxNomeColore"
        Me.TextBoxNomeColore.Size = New System.Drawing.Size(215, 24)
        Me.TextBoxNomeColore.TabIndex = 1
        Me.TextBoxNomeColore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'La_Conversione_Tipo
        '
        Me.La_Conversione_Tipo.BackColor = System.Drawing.Color.Transparent
        Me.La_Conversione_Tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.La_Conversione_Tipo.ForeColor = System.Drawing.Color.White
        Me.La_Conversione_Tipo.Location = New System.Drawing.Point(134, 100)
        Me.La_Conversione_Tipo.Name = "La_Conversione_Tipo"
        Me.La_Conversione_Tipo.Size = New System.Drawing.Size(139, 20)
        Me.La_Conversione_Tipo.TabIndex = 4
        Me.La_Conversione_Tipo.Text = "-"
        Me.La_Conversione_Tipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LaNColore
        '
        Me.LaNColore.BackColor = System.Drawing.Color.Transparent
        Me.LaNColore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaNColore.ForeColor = System.Drawing.Color.White
        Me.LaNColore.Location = New System.Drawing.Point(12, 142)
        Me.LaNColore.Name = "LaNColore"
        Me.LaNColore.Size = New System.Drawing.Size(93, 20)
        Me.LaNColore.TabIndex = 22
        Me.LaNColore.Text = "-"
        Me.LaNColore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LaNSaturazione
        '
        Me.LaNSaturazione.BackColor = System.Drawing.Color.Transparent
        Me.LaNSaturazione.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaNSaturazione.ForeColor = System.Drawing.Color.White
        Me.LaNSaturazione.Location = New System.Drawing.Point(11, 202)
        Me.LaNSaturazione.Name = "LaNSaturazione"
        Me.LaNSaturazione.Size = New System.Drawing.Size(95, 20)
        Me.LaNSaturazione.TabIndex = 23
        Me.LaNSaturazione.Text = "-"
        Me.LaNSaturazione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TrackBarLuminosità
        '
        Me.TrackBarLuminosità.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.TrackBarLuminosità.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TrackBarLuminosità.Location = New System.Drawing.Point(111, 253)
        Me.TrackBarLuminosità.Maximum = 255
        Me.TrackBarLuminosità.Minimum = 13
        Me.TrackBarLuminosità.Name = "TrackBarLuminosità"
        Me.TrackBarLuminosità.Size = New System.Drawing.Size(215, 45)
        Me.TrackBarLuminosità.TabIndex = 24
        Me.TrackBarLuminosità.TickFrequency = 0
        Me.TrackBarLuminosità.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.TrackBarLuminosità.Value = 128
        '
        'LaNLuminosità
        '
        Me.LaNLuminosità.BackColor = System.Drawing.Color.Transparent
        Me.LaNLuminosità.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaNLuminosità.ForeColor = System.Drawing.Color.White
        Me.LaNLuminosità.Location = New System.Drawing.Point(11, 263)
        Me.LaNLuminosità.Name = "LaNLuminosità"
        Me.LaNLuminosità.Size = New System.Drawing.Size(95, 20)
        Me.LaNLuminosità.TabIndex = 25
        Me.LaNLuminosità.Text = "-"
        Me.LaNLuminosità.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TrackBarSaturazione
        '
        Me.TrackBarSaturazione.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.TrackBarSaturazione.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TrackBarSaturazione.Location = New System.Drawing.Point(111, 191)
        Me.TrackBarSaturazione.Maximum = 255
        Me.TrackBarSaturazione.Minimum = 100
        Me.TrackBarSaturazione.Name = "TrackBarSaturazione"
        Me.TrackBarSaturazione.Size = New System.Drawing.Size(215, 45)
        Me.TrackBarSaturazione.TabIndex = 21
        Me.TrackBarSaturazione.TickFrequency = 0
        Me.TrackBarSaturazione.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.TrackBarSaturazione.Value = 148
        '
        'TrackBarColore
        '
        Me.TrackBarColore.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.TrackBarColore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TrackBarColore.Location = New System.Drawing.Point(111, 130)
        Me.TrackBarColore.Maximum = 512
        Me.TrackBarColore.Name = "TrackBarColore"
        Me.TrackBarColore.Size = New System.Drawing.Size(215, 45)
        Me.TrackBarColore.TabIndex = 26
        Me.TrackBarColore.TickFrequency = 0
        Me.TrackBarColore.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.TrackBarColore.Value = 250
        '
        'BtnChiudi
        '
        Me.BtnChiudi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnChiudi.BackColor = System.Drawing.Color.Transparent
        Me.BtnChiudi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnChiudi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnChiudi.Image = Global.ArduCenter.My.Resources.Resources.BtnChiudi21
        Me.BtnChiudi.Location = New System.Drawing.Point(374, 7)
        Me.BtnChiudi.Name = "BtnChiudi"
        Me.BtnChiudi.Size = New System.Drawing.Size(25, 25)
        Me.BtnChiudi.TabIndex = 27
        Me.BtnChiudi.TabStop = False
        '
        'BtnSalva
        '
        Me.BtnSalva.BackColor = System.Drawing.Color.Transparent
        Me.BtnSalva.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalva.ForeColor = System.Drawing.Color.Gold
        Me.BtnSalva.Location = New System.Drawing.Point(164, 316)
        Me.BtnSalva.Name = "BtnSalva"
        Me.BtnSalva.Size = New System.Drawing.Size(78, 20)
        Me.BtnSalva.TabIndex = 28
        Me.BtnSalva.Text = "-"
        Me.BtnSalva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LaColore_V
        '
        Me.LaColore_V.BackColor = System.Drawing.Color.Transparent
        Me.LaColore_V.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaColore_V.ForeColor = System.Drawing.Color.White
        Me.LaColore_V.Location = New System.Drawing.Point(333, 142)
        Me.LaColore_V.Name = "LaColore_V"
        Me.LaColore_V.Size = New System.Drawing.Size(55, 20)
        Me.LaColore_V.TabIndex = 29
        Me.LaColore_V.Text = "-"
        Me.LaColore_V.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LaSaturazione_V
        '
        Me.LaSaturazione_V.BackColor = System.Drawing.Color.Transparent
        Me.LaSaturazione_V.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaSaturazione_V.ForeColor = System.Drawing.Color.White
        Me.LaSaturazione_V.Location = New System.Drawing.Point(333, 203)
        Me.LaSaturazione_V.Name = "LaSaturazione_V"
        Me.LaSaturazione_V.Size = New System.Drawing.Size(55, 20)
        Me.LaSaturazione_V.TabIndex = 30
        Me.LaSaturazione_V.Text = "-"
        Me.LaSaturazione_V.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LaLuminosità_V
        '
        Me.LaLuminosità_V.BackColor = System.Drawing.Color.Transparent
        Me.LaLuminosità_V.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaLuminosità_V.ForeColor = System.Drawing.Color.White
        Me.LaLuminosità_V.Location = New System.Drawing.Point(333, 265)
        Me.LaLuminosità_V.Name = "LaLuminosità_V"
        Me.LaLuminosità_V.Size = New System.Drawing.Size(55, 20)
        Me.LaLuminosità_V.TabIndex = 31
        Me.LaLuminosità_V.Text = "-"
        Me.LaLuminosità_V.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'F_SettingColor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.BackgroundImage = Global.ArduCenter.My.Resources.Resources.F_Colore_1_0_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(404, 349)
        Me.Controls.Add(Me.LaLuminosità_V)
        Me.Controls.Add(Me.LaSaturazione_V)
        Me.Controls.Add(Me.LaColore_V)
        Me.Controls.Add(Me.BtnSalva)
        Me.Controls.Add(Me.BtnChiudi)
        Me.Controls.Add(Me.TrackBarColore)
        Me.Controls.Add(Me.LaNLuminosità)
        Me.Controls.Add(Me.TrackBarLuminosità)
        Me.Controls.Add(Me.LaNSaturazione)
        Me.Controls.Add(Me.LaNColore)
        Me.Controls.Add(Me.TrackBarSaturazione)
        Me.Controls.Add(Me.La_Conversione_Tipo)
        Me.Controls.Add(Me.TextBoxNomeColore)
        Me.Controls.Add(Me.N_Colore)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_SettingColor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "F_SettingColor"
        CType(Me.TrackBarLuminosità, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarSaturazione, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarColore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnChiudi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents N_Colore As Label
    Friend WithEvents TextBoxNomeColore As TextBox
    Friend WithEvents La_Conversione_Tipo As Label
    Friend WithEvents LaNColore As Label
    Friend WithEvents LaNSaturazione As Label
    Friend WithEvents TrackBarLuminosità As TrackBar
    Friend WithEvents LaNLuminosità As Label
    Friend WithEvents TrackBarSaturazione As TrackBar
    Friend WithEvents TrackBarColore As TrackBar
    Friend WithEvents BtnChiudi As PictureBox
    Friend WithEvents BtnSalva As Label
    Friend WithEvents LaColore_V As Label
    Friend WithEvents LaSaturazione_V As Label
    Friend WithEvents LaLuminosità_V As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
