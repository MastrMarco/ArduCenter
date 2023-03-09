<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Impostazioni_HUB_Fan
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnROM = New System.Windows.Forms.PictureBox()
        Me.BtnProtezioneLED = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.LabelPL = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnProtezioneHUB = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.LabelPD = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnDebugFan = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BtnRipristino = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.InStato = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnROM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnProtezioneLED, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnProtezioneHUB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDebugFan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnRipristino, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(74, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Attiva / Disattiva " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Memorizazione dei dati " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "che imposta l’utente"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(74, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 14)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Data ROM"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.ArduCenter.My.Resources.Resources.Icona_ROM
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(87, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 45)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'BtnROM
        '
        Me.BtnROM.BackColor = System.Drawing.Color.Transparent
        Me.BtnROM.BackgroundImage = Global.ArduCenter.My.Resources.Resources.btn_Swich
        Me.BtnROM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnROM.Location = New System.Drawing.Point(167, 53)
        Me.BtnROM.Name = "BtnROM"
        Me.BtnROM.Size = New System.Drawing.Size(70, 25)
        Me.BtnROM.TabIndex = 26
        Me.BtnROM.TabStop = False
        '
        'BtnProtezioneLED
        '
        Me.BtnProtezioneLED.BackColor = System.Drawing.Color.Transparent
        Me.BtnProtezioneLED.BackgroundImage = Global.ArduCenter.My.Resources.Resources.btn_Swich
        Me.BtnProtezioneLED.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnProtezioneLED.Location = New System.Drawing.Point(167, 222)
        Me.BtnProtezioneLED.Name = "BtnProtezioneLED"
        Me.BtnProtezioneLED.Size = New System.Drawing.Size(70, 25)
        Me.BtnProtezioneLED.TabIndex = 30
        Me.BtnProtezioneLED.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.ArduCenter.My.Resources.Resources.Icone_ProtezioneLED_1_0
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(89, 215)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(45, 38)
        Me.PictureBox3.TabIndex = 29
        Me.PictureBox3.TabStop = False
        '
        'LabelPL
        '
        Me.LabelPL.AutoSize = True
        Me.LabelPL.BackColor = System.Drawing.Color.Transparent
        Me.LabelPL.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPL.ForeColor = System.Drawing.Color.White
        Me.LabelPL.Location = New System.Drawing.Point(65, 255)
        Me.LabelPL.Name = "LabelPL"
        Me.LabelPL.Size = New System.Drawing.Size(108, 14)
        Me.LabelPL.TabIndex = 28
        Me.LabelPL.Text = "Protezione LED" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(65, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 52)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Attiva / Disattiva " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "limita la luminosità dei LED " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "quando la tensione ha una " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a" &
    "nomalia (+5v)"
        '
        'BtnProtezioneHUB
        '
        Me.BtnProtezioneHUB.BackColor = System.Drawing.Color.Transparent
        Me.BtnProtezioneHUB.BackgroundImage = Global.ArduCenter.My.Resources.Resources.btn_Swich
        Me.BtnProtezioneHUB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnProtezioneHUB.Location = New System.Drawing.Point(407, 46)
        Me.BtnProtezioneHUB.Name = "BtnProtezioneHUB"
        Me.BtnProtezioneHUB.Size = New System.Drawing.Size(70, 25)
        Me.BtnProtezioneHUB.TabIndex = 34
        Me.BtnProtezioneHUB.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImage = Global.ArduCenter.My.Resources.Resources.Icone_ProtezioneDispositivo_2_0
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox5.Location = New System.Drawing.Point(327, 40)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(45, 38)
        Me.PictureBox5.TabIndex = 33
        Me.PictureBox5.TabStop = False
        '
        'LabelPD
        '
        Me.LabelPD.AutoSize = True
        Me.LabelPD.BackColor = System.Drawing.Color.Transparent
        Me.LabelPD.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPD.ForeColor = System.Drawing.Color.White
        Me.LabelPD.Location = New System.Drawing.Point(320, 80)
        Me.LabelPD.Name = "LabelPD"
        Me.LabelPD.Size = New System.Drawing.Size(155, 14)
        Me.LabelPD.TabIndex = 32
        Me.LabelPD.Text = "Protezione Dispositivo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(320, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 52)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Attiva / Disattiva " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Stacca l’alimentazione " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "esterna quando viene " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "rilevata una" &
    " anomalia"
        '
        'BtnDebugFan
        '
        Me.BtnDebugFan.BackColor = System.Drawing.Color.Transparent
        Me.BtnDebugFan.BackgroundImage = Global.ArduCenter.My.Resources.Resources.btn_Swich
        Me.BtnDebugFan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDebugFan.Location = New System.Drawing.Point(408, 227)
        Me.BtnDebugFan.Name = "BtnDebugFan"
        Me.BtnDebugFan.Size = New System.Drawing.Size(70, 25)
        Me.BtnDebugFan.TabIndex = 38
        Me.BtnDebugFan.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.BackgroundImage = Global.ArduCenter.My.Resources.Resources.IconaHubStruments
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox7.Location = New System.Drawing.Point(328, 216)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(45, 45)
        Me.PictureBox7.TabIndex = 37
        Me.PictureBox7.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(311, 265)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 14)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Debug MOD"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gray
        Me.Label8.Location = New System.Drawing.Point(311, 279)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(175, 42)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Attiva / Disattiva " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Consente di avere più " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "informazioni sviluppatore"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(552, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 14)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Stato Dispositivo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gray
        Me.Label10.Location = New System.Drawing.Point(552, 119)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(176, 28)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Indica le condizioni del " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "dispositivo con delle sigle"
        '
        'BtnRipristino
        '
        Me.BtnRipristino.BackColor = System.Drawing.Color.Transparent
        Me.BtnRipristino.BackgroundImage = Global.ArduCenter.My.Resources.Resources.Icona_Reset_1_0
        Me.BtnRipristino.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRipristino.Location = New System.Drawing.Point(619, 218)
        Me.BtnRipristino.Name = "BtnRipristino"
        Me.BtnRipristino.Size = New System.Drawing.Size(52, 53)
        Me.BtnRipristino.TabIndex = 44
        Me.BtnRipristino.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(546, 275)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 14)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Ripristino Dati"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Gray
        Me.Label12.Location = New System.Drawing.Point(546, 289)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(190, 28)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Ripristina tutti i dati " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "concellando quelli impostati"
        '
        'InStato
        '
        Me.InStato.BackColor = System.Drawing.Color.Transparent
        Me.InStato.Cursor = System.Windows.Forms.Cursors.Help
        Me.InStato.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InStato.ForeColor = System.Drawing.Color.White
        Me.InStato.Location = New System.Drawing.Point(597, 61)
        Me.InStato.Name = "InStato"
        Me.InStato.Size = New System.Drawing.Size(91, 18)
        Me.InStato.TabIndex = 45
        Me.InStato.Text = "Stato"
        Me.InStato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(381, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 14)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Beta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(136, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 14)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Beta"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(626, 205)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 14)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "Beta"
        '
        'F_Impostazioni_HUB_Fan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BackgroundImage = Global.ArduCenter.My.Resources.Resources.F_ImpostazioniFan_1_3
        Me.ClientSize = New System.Drawing.Size(800, 365)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.InStato)
        Me.Controls.Add(Me.BtnRipristino)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BtnDebugFan)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnProtezioneHUB)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.LabelPD)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnProtezioneLED)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.LabelPL)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnROM)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_Impostazioni_HUB_Fan"
        Me.Text = "F_Impostazioni_HUB_Fan"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnROM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnProtezioneLED, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnProtezioneHUB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDebugFan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnRipristino, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnROM As PictureBox
    Friend WithEvents BtnProtezioneLED As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents LabelPL As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnProtezioneHUB As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents LabelPD As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnDebugFan As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents BtnRipristino As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents InStato As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label13 As Label
End Class
