<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_HubPC_CasseAudio
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
        Me.Icona_CassaAudio_S = New System.Windows.Forms.PictureBox()
        Me.Icona_StripLED = New System.Windows.Forms.PictureBox()
        Me.Btn_CassaAudio_S = New System.Windows.Forms.PictureBox()
        Me.Btn_StripLED = New System.Windows.Forms.PictureBox()
        Me.Btn_CassaAudio_D = New System.Windows.Forms.PictureBox()
        Me.Icona_CassaAudio_D = New System.Windows.Forms.PictureBox()
        Me.LaCassaAudio_S = New System.Windows.Forms.Label()
        Me.LaStriscaLED = New System.Windows.Forms.Label()
        Me.LaCassaAudio_D = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LaColore = New System.Windows.Forms.Label()
        Me.LaLuminosità = New System.Windows.Forms.Label()
        Me.LaSelezione = New System.Windows.Forms.Label()
        CType(Me.Icona_CassaAudio_S, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icona_StripLED, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_CassaAudio_S, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_StripLED, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_CassaAudio_D, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icona_CassaAudio_D, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Icona_CassaAudio_S
        '
        Me.Icona_CassaAudio_S.BackgroundImage = Global.ArduCenter.My.Resources.Resources.IconaCasaAudio_RGB_Colore_HSV_RGB
        Me.Icona_CassaAudio_S.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Icona_CassaAudio_S.Location = New System.Drawing.Point(33, 52)
        Me.Icona_CassaAudio_S.Name = "Icona_CassaAudio_S"
        Me.Icona_CassaAudio_S.Size = New System.Drawing.Size(70, 120)
        Me.Icona_CassaAudio_S.TabIndex = 0
        Me.Icona_CassaAudio_S.TabStop = False
        '
        'Icona_StripLED
        '
        Me.Icona_StripLED.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Icona_StripLED.BackgroundImage = Global.ArduCenter.My.Resources.Resources.Icona_Strisca__RGB_Colore_HSV_RGB_2_2_2
        Me.Icona_StripLED.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Icona_StripLED.Location = New System.Drawing.Point(153, 66)
        Me.Icona_StripLED.Name = "Icona_StripLED"
        Me.Icona_StripLED.Size = New System.Drawing.Size(160, 87)
        Me.Icona_StripLED.TabIndex = 1
        Me.Icona_StripLED.TabStop = False
        '
        'Btn_CassaAudio_S
        '
        Me.Btn_CassaAudio_S.BackgroundImage = Global.ArduCenter.My.Resources.Resources.IconaCasaAudio_RGB_Colore_HSV_RGB
        Me.Btn_CassaAudio_S.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_CassaAudio_S.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_CassaAudio_S.Location = New System.Drawing.Point(58, 286)
        Me.Btn_CassaAudio_S.Name = "Btn_CassaAudio_S"
        Me.Btn_CassaAudio_S.Size = New System.Drawing.Size(45, 78)
        Me.Btn_CassaAudio_S.TabIndex = 2
        Me.Btn_CassaAudio_S.TabStop = False
        '
        'Btn_StripLED
        '
        Me.Btn_StripLED.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Btn_StripLED.BackgroundImage = Global.ArduCenter.My.Resources.Resources.Icona_Strisca__RGB_Colore_HSV_RGB_2_2_2
        Me.Btn_StripLED.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_StripLED.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_StripLED.Location = New System.Drawing.Point(160, 283)
        Me.Btn_StripLED.Name = "Btn_StripLED"
        Me.Btn_StripLED.Size = New System.Drawing.Size(150, 81)
        Me.Btn_StripLED.TabIndex = 3
        Me.Btn_StripLED.TabStop = False
        '
        'Btn_CassaAudio_D
        '
        Me.Btn_CassaAudio_D.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Btn_CassaAudio_D.BackgroundImage = Global.ArduCenter.My.Resources.Resources.IconaCasaAudio_RGB_Colore_HSV_RGB
        Me.Btn_CassaAudio_D.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_CassaAudio_D.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_CassaAudio_D.Location = New System.Drawing.Point(366, 284)
        Me.Btn_CassaAudio_D.Name = "Btn_CassaAudio_D"
        Me.Btn_CassaAudio_D.Size = New System.Drawing.Size(45, 78)
        Me.Btn_CassaAudio_D.TabIndex = 4
        Me.Btn_CassaAudio_D.TabStop = False
        '
        'Icona_CassaAudio_D
        '
        Me.Icona_CassaAudio_D.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Icona_CassaAudio_D.BackgroundImage = Global.ArduCenter.My.Resources.Resources.IconaCasaAudio_RGB_Colore_HSV_RGB
        Me.Icona_CassaAudio_D.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Icona_CassaAudio_D.Location = New System.Drawing.Point(356, 52)
        Me.Icona_CassaAudio_D.Name = "Icona_CassaAudio_D"
        Me.Icona_CassaAudio_D.Size = New System.Drawing.Size(70, 120)
        Me.Icona_CassaAudio_D.TabIndex = 5
        Me.Icona_CassaAudio_D.TabStop = False
        '
        'LaCassaAudio_S
        '
        Me.LaCassaAudio_S.AutoSize = True
        Me.LaCassaAudio_S.BackColor = System.Drawing.Color.Transparent
        Me.LaCassaAudio_S.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LaCassaAudio_S.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaCassaAudio_S.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.LaCassaAudio_S.Location = New System.Drawing.Point(47, 256)
        Me.LaCassaAudio_S.Name = "LaCassaAudio_S"
        Me.LaCassaAudio_S.Size = New System.Drawing.Size(73, 18)
        Me.LaCassaAudio_S.TabIndex = 103
        Me.LaCassaAudio_S.Text = "Sinsitro"
        '
        'LaStriscaLED
        '
        Me.LaStriscaLED.AutoSize = True
        Me.LaStriscaLED.BackColor = System.Drawing.Color.Transparent
        Me.LaStriscaLED.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LaStriscaLED.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaStriscaLED.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.LaStriscaLED.Location = New System.Drawing.Point(195, 256)
        Me.LaStriscaLED.Name = "LaStriscaLED"
        Me.LaStriscaLED.Size = New System.Drawing.Size(88, 18)
        Me.LaStriscaLED.TabIndex = 104
        Me.LaStriscaLED.Text = "Strip LED"
        '
        'LaCassaAudio_D
        '
        Me.LaCassaAudio_D.AutoSize = True
        Me.LaCassaAudio_D.BackColor = System.Drawing.Color.Transparent
        Me.LaCassaAudio_D.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LaCassaAudio_D.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaCassaAudio_D.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.LaCassaAudio_D.Location = New System.Drawing.Point(356, 256)
        Me.LaCassaAudio_D.Name = "LaCassaAudio_D"
        Me.LaCassaAudio_D.Size = New System.Drawing.Size(67, 18)
        Me.LaCassaAudio_D.TabIndex = 105
        Me.LaCassaAudio_D.Text = "Destro"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(122, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 18)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "Colore"
        '
        'LaColore
        '
        Me.LaColore.AutoSize = True
        Me.LaColore.BackColor = System.Drawing.Color.Transparent
        Me.LaColore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LaColore.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaColore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.LaColore.Location = New System.Drawing.Point(244, 175)
        Me.LaColore.Name = "LaColore"
        Me.LaColore.Size = New System.Drawing.Size(96, 18)
        Me.LaColore.TabIndex = 108
        Me.LaColore.Text = "Arancione"
        '
        'LaLuminosità
        '
        Me.LaLuminosità.AutoSize = True
        Me.LaLuminosità.BackColor = System.Drawing.Color.Transparent
        Me.LaLuminosità.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LaLuminosità.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaLuminosità.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.LaLuminosità.Location = New System.Drawing.Point(115, 203)
        Me.LaLuminosità.Name = "LaLuminosità"
        Me.LaLuminosità.Size = New System.Drawing.Size(215, 18)
        Me.LaLuminosità.TabIndex = 109
        Me.LaLuminosità.Text = "Luminosità            100%"
        '
        'LaSelezione
        '
        Me.LaSelezione.BackColor = System.Drawing.Color.Transparent
        Me.LaSelezione.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaSelezione.ForeColor = System.Drawing.Color.White
        Me.LaSelezione.Location = New System.Drawing.Point(63, 9)
        Me.LaSelezione.Name = "LaSelezione"
        Me.LaSelezione.Size = New System.Drawing.Size(343, 23)
        Me.LaSelezione.TabIndex = 128
        Me.LaSelezione.Text = "Colore attuale [Mod Sinc]"
        Me.LaSelezione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'F_HubPC_CasseAudio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BackgroundImage = Global.ArduCenter.My.Resources.Resources.GUI_Fan_Menù_4_v1_0
        Me.ClientSize = New System.Drawing.Size(618, 381)
        Me.Controls.Add(Me.LaSelezione)
        Me.Controls.Add(Me.LaLuminosità)
        Me.Controls.Add(Me.LaColore)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LaCassaAudio_D)
        Me.Controls.Add(Me.LaStriscaLED)
        Me.Controls.Add(Me.LaCassaAudio_S)
        Me.Controls.Add(Me.Icona_CassaAudio_D)
        Me.Controls.Add(Me.Btn_CassaAudio_D)
        Me.Controls.Add(Me.Btn_StripLED)
        Me.Controls.Add(Me.Btn_CassaAudio_S)
        Me.Controls.Add(Me.Icona_StripLED)
        Me.Controls.Add(Me.Icona_CassaAudio_S)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_HubPC_CasseAudio"
        Me.Text = "F_HubPC_CasseAudio"
        CType(Me.Icona_CassaAudio_S, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icona_StripLED, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_CassaAudio_S, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_StripLED, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_CassaAudio_D, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icona_CassaAudio_D, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Icona_CassaAudio_S As PictureBox
    Friend WithEvents Icona_StripLED As PictureBox
    Friend WithEvents Btn_CassaAudio_S As PictureBox
    Friend WithEvents Btn_StripLED As PictureBox
    Friend WithEvents Btn_CassaAudio_D As PictureBox
    Friend WithEvents Icona_CassaAudio_D As PictureBox
    Friend WithEvents LaCassaAudio_S As Label
    Friend WithEvents LaStriscaLED As Label
    Friend WithEvents LaCassaAudio_D As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LaColore As Label
    Friend WithEvents LaLuminosità As Label
    Friend WithEvents LaSelezione As Label
End Class
