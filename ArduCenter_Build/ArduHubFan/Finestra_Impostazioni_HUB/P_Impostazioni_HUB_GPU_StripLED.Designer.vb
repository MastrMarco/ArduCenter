<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_Impostazioni_HUB_GPU_StripLED
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
        Me.BtnGPU_GU = New System.Windows.Forms.Label()
        Me.BtnGPU_SU = New System.Windows.Forms.Label()
        Me.Stato_GPU = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnRGBOFF_GPU = New System.Windows.Forms.Label()
        Me.BtnRGBON_GPU = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumLED_GPU = New System.Windows.Forms.TextBox()
        Me.BtnGPU = New System.Windows.Forms.Label()
        Me.IconaSchedaVideo = New System.Windows.Forms.PictureBox()
        Me.BtnStripLED_GU = New System.Windows.Forms.Label()
        Me.BtnStripLED_SU = New System.Windows.Forms.Label()
        Me.Stato_StripLED = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnRGBOFF_StripLED = New System.Windows.Forms.Label()
        Me.BtnRGBON_StripLED = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.NumLED_StripLED = New System.Windows.Forms.TextBox()
        Me.BtnStripLED = New System.Windows.Forms.Label()
        Me.IconaStriscaLED = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.IconaSchedaVideo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconaStriscaLED, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnGPU_GU
        '
        Me.BtnGPU_GU.BackColor = System.Drawing.Color.Transparent
        Me.BtnGPU_GU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGPU_GU.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGPU_GU.ForeColor = System.Drawing.Color.Gold
        Me.BtnGPU_GU.Location = New System.Drawing.Point(276, 194)
        Me.BtnGPU_GU.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnGPU_GU.Name = "BtnGPU_GU"
        Me.BtnGPU_GU.Size = New System.Drawing.Size(25, 25)
        Me.BtnGPU_GU.TabIndex = 72
        Me.BtnGPU_GU.Text = "-"
        Me.BtnGPU_GU.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnGPU_SU
        '
        Me.BtnGPU_SU.BackColor = System.Drawing.Color.Transparent
        Me.BtnGPU_SU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGPU_SU.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGPU_SU.ForeColor = System.Drawing.Color.Gold
        Me.BtnGPU_SU.Location = New System.Drawing.Point(162, 196)
        Me.BtnGPU_SU.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnGPU_SU.Name = "BtnGPU_SU"
        Me.BtnGPU_SU.Size = New System.Drawing.Size(25, 25)
        Me.BtnGPU_SU.TabIndex = 71
        Me.BtnGPU_SU.Text = "+"
        '
        'Stato_GPU
        '
        Me.Stato_GPU.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Stato_GPU.BackColor = System.Drawing.Color.Transparent
        Me.Stato_GPU.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stato_GPU.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Stato_GPU.Location = New System.Drawing.Point(178, 304)
        Me.Stato_GPU.Margin = New System.Windows.Forms.Padding(0)
        Me.Stato_GPU.Name = "Stato_GPU"
        Me.Stato_GPU.Size = New System.Drawing.Size(105, 18)
        Me.Stato_GPU.TabIndex = 70
        Me.Stato_GPU.Text = "???"
        Me.Stato_GPU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(183, 270)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 18)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Stato GPU"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(174, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 18)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Numero LED"
        '
        'BtnRGBOFF_GPU
        '
        Me.BtnRGBOFF_GPU.AutoSize = True
        Me.BtnRGBOFF_GPU.BackColor = System.Drawing.Color.Transparent
        Me.BtnRGBOFF_GPU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRGBOFF_GPU.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRGBOFF_GPU.ForeColor = System.Drawing.Color.Silver
        Me.BtnRGBOFF_GPU.Location = New System.Drawing.Point(265, 166)
        Me.BtnRGBOFF_GPU.Name = "BtnRGBOFF_GPU"
        Me.BtnRGBOFF_GPU.Size = New System.Drawing.Size(26, 16)
        Me.BtnRGBOFF_GPU.TabIndex = 67
        Me.BtnRGBOFF_GPU.Text = "No"
        '
        'BtnRGBON_GPU
        '
        Me.BtnRGBON_GPU.AutoSize = True
        Me.BtnRGBON_GPU.BackColor = System.Drawing.Color.Transparent
        Me.BtnRGBON_GPU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRGBON_GPU.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRGBON_GPU.ForeColor = System.Drawing.Color.DarkGray
        Me.BtnRGBON_GPU.Location = New System.Drawing.Point(232, 166)
        Me.BtnRGBON_GPU.Name = "BtnRGBON_GPU"
        Me.BtnRGBON_GPU.Size = New System.Drawing.Size(20, 16)
        Me.BtnRGBON_GPU.TabIndex = 66
        Me.BtnRGBON_GPU.Text = "Si"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(172, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 16)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "RGB"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(177, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 18)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Tipo di GPU"
        '
        'NumLED_GPU
        '
        Me.NumLED_GPU.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.NumLED_GPU.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumLED_GPU.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumLED_GPU.ForeColor = System.Drawing.Color.Gold
        Me.NumLED_GPU.Location = New System.Drawing.Point(200, 199)
        Me.NumLED_GPU.Name = "NumLED_GPU"
        Me.NumLED_GPU.Size = New System.Drawing.Size(60, 19)
        Me.NumLED_GPU.TabIndex = 63
        Me.NumLED_GPU.Text = "???"
        Me.NumLED_GPU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnGPU
        '
        Me.BtnGPU.AutoSize = True
        Me.BtnGPU.BackColor = System.Drawing.Color.Transparent
        Me.BtnGPU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGPU.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGPU.ForeColor = System.Drawing.Color.DarkGray
        Me.BtnGPU.Location = New System.Drawing.Point(154, 11)
        Me.BtnGPU.Name = "BtnGPU"
        Me.BtnGPU.Size = New System.Drawing.Size(156, 23)
        Me.BtnGPU.TabIndex = 62
        Me.BtnGPU.Text = "Scheda Video"
        '
        'IconaSchedaVideo
        '
        Me.IconaSchedaVideo.BackColor = System.Drawing.Color.Transparent
        Me.IconaSchedaVideo.BackgroundImage = Global.ArduCenter.My.Resources.Resources.Icona_SchedaVideo_Nero
        Me.IconaSchedaVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IconaSchedaVideo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconaSchedaVideo.Location = New System.Drawing.Point(165, 55)
        Me.IconaSchedaVideo.Name = "IconaSchedaVideo"
        Me.IconaSchedaVideo.Size = New System.Drawing.Size(134, 79)
        Me.IconaSchedaVideo.TabIndex = 61
        Me.IconaSchedaVideo.TabStop = False
        '
        'BtnStripLED_GU
        '
        Me.BtnStripLED_GU.BackColor = System.Drawing.Color.Transparent
        Me.BtnStripLED_GU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnStripLED_GU.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStripLED_GU.ForeColor = System.Drawing.Color.Gold
        Me.BtnStripLED_GU.Location = New System.Drawing.Point(612, 194)
        Me.BtnStripLED_GU.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnStripLED_GU.Name = "BtnStripLED_GU"
        Me.BtnStripLED_GU.Size = New System.Drawing.Size(25, 25)
        Me.BtnStripLED_GU.TabIndex = 84
        Me.BtnStripLED_GU.Text = "-"
        Me.BtnStripLED_GU.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnStripLED_SU
        '
        Me.BtnStripLED_SU.BackColor = System.Drawing.Color.Transparent
        Me.BtnStripLED_SU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnStripLED_SU.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStripLED_SU.ForeColor = System.Drawing.Color.Gold
        Me.BtnStripLED_SU.Location = New System.Drawing.Point(498, 196)
        Me.BtnStripLED_SU.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnStripLED_SU.Name = "BtnStripLED_SU"
        Me.BtnStripLED_SU.Size = New System.Drawing.Size(25, 25)
        Me.BtnStripLED_SU.TabIndex = 83
        Me.BtnStripLED_SU.Text = "+"
        '
        'Stato_StripLED
        '
        Me.Stato_StripLED.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Stato_StripLED.BackColor = System.Drawing.Color.Transparent
        Me.Stato_StripLED.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stato_StripLED.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Stato_StripLED.Location = New System.Drawing.Point(514, 304)
        Me.Stato_StripLED.Margin = New System.Windows.Forms.Padding(0)
        Me.Stato_StripLED.Name = "Stato_StripLED"
        Me.Stato_StripLED.Size = New System.Drawing.Size(105, 18)
        Me.Stato_StripLED.TabIndex = 82
        Me.Stato_StripLED.Text = "???"
        Me.Stato_StripLED.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(501, 270)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 18)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "Stato StripLED"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(510, 228)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 18)
        Me.Label9.TabIndex = 80
        Me.Label9.Text = "Numero LED"
        '
        'BtnRGBOFF_StripLED
        '
        Me.BtnRGBOFF_StripLED.AutoSize = True
        Me.BtnRGBOFF_StripLED.BackColor = System.Drawing.Color.Transparent
        Me.BtnRGBOFF_StripLED.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRGBOFF_StripLED.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRGBOFF_StripLED.ForeColor = System.Drawing.Color.Silver
        Me.BtnRGBOFF_StripLED.Location = New System.Drawing.Point(601, 166)
        Me.BtnRGBOFF_StripLED.Name = "BtnRGBOFF_StripLED"
        Me.BtnRGBOFF_StripLED.Size = New System.Drawing.Size(26, 16)
        Me.BtnRGBOFF_StripLED.TabIndex = 79
        Me.BtnRGBOFF_StripLED.Text = "No"
        '
        'BtnRGBON_StripLED
        '
        Me.BtnRGBON_StripLED.AutoSize = True
        Me.BtnRGBON_StripLED.BackColor = System.Drawing.Color.Transparent
        Me.BtnRGBON_StripLED.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRGBON_StripLED.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRGBON_StripLED.ForeColor = System.Drawing.Color.DarkGray
        Me.BtnRGBON_StripLED.Location = New System.Drawing.Point(568, 166)
        Me.BtnRGBON_StripLED.Name = "BtnRGBON_StripLED"
        Me.BtnRGBON_StripLED.Size = New System.Drawing.Size(20, 16)
        Me.BtnRGBON_StripLED.TabIndex = 78
        Me.BtnRGBON_StripLED.Text = "Si"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(508, 166)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 16)
        Me.Label12.TabIndex = 77
        Me.Label12.Text = "RGB"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(501, 140)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(131, 18)
        Me.Label13.TabIndex = 76
        Me.Label13.Text = "Tipo Strip LED"
        '
        'NumLED_StripLED
        '
        Me.NumLED_StripLED.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.NumLED_StripLED.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumLED_StripLED.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumLED_StripLED.ForeColor = System.Drawing.Color.Gold
        Me.NumLED_StripLED.Location = New System.Drawing.Point(537, 199)
        Me.NumLED_StripLED.Name = "NumLED_StripLED"
        Me.NumLED_StripLED.Size = New System.Drawing.Size(60, 19)
        Me.NumLED_StripLED.TabIndex = 75
        Me.NumLED_StripLED.Text = "???"
        Me.NumLED_StripLED.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnStripLED
        '
        Me.BtnStripLED.AutoSize = True
        Me.BtnStripLED.BackColor = System.Drawing.Color.Transparent
        Me.BtnStripLED.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnStripLED.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStripLED.ForeColor = System.Drawing.Color.DarkGray
        Me.BtnStripLED.Location = New System.Drawing.Point(502, 11)
        Me.BtnStripLED.Name = "BtnStripLED"
        Me.BtnStripLED.Size = New System.Drawing.Size(132, 23)
        Me.BtnStripLED.TabIndex = 74
        Me.BtnStripLED.Text = "Strisca LED"
        '
        'IconaStriscaLED
        '
        Me.IconaStriscaLED.BackColor = System.Drawing.Color.Transparent
        Me.IconaStriscaLED.BackgroundImage = Global.ArduCenter.My.Resources.Resources.Icona_Strisca_LED_Nero
        Me.IconaStriscaLED.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IconaStriscaLED.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconaStriscaLED.Location = New System.Drawing.Point(502, 55)
        Me.IconaStriscaLED.Name = "IconaStriscaLED"
        Me.IconaStriscaLED.Size = New System.Drawing.Size(131, 79)
        Me.IconaStriscaLED.TabIndex = 73
        Me.IconaStriscaLED.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 14)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Beta"
        '
        'F_Impostazioni_HUB_GPU_StripLED
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BackgroundImage = Global.ArduCenter.My.Resources.Resources.F_Impostazioni_HUB_GPU_StripLED
        Me.ClientSize = New System.Drawing.Size(800, 365)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnStripLED_GU)
        Me.Controls.Add(Me.BtnStripLED_SU)
        Me.Controls.Add(Me.Stato_StripLED)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BtnRGBOFF_StripLED)
        Me.Controls.Add(Me.BtnRGBON_StripLED)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.NumLED_StripLED)
        Me.Controls.Add(Me.BtnStripLED)
        Me.Controls.Add(Me.IconaStriscaLED)
        Me.Controls.Add(Me.BtnGPU_GU)
        Me.Controls.Add(Me.BtnGPU_SU)
        Me.Controls.Add(Me.Stato_GPU)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnRGBOFF_GPU)
        Me.Controls.Add(Me.BtnRGBON_GPU)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NumLED_GPU)
        Me.Controls.Add(Me.BtnGPU)
        Me.Controls.Add(Me.IconaSchedaVideo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_Impostazioni_HUB_GPU_StripLED"
        Me.Text = "F_Impostazioni_HUB_GPU_StripLED"
        CType(Me.IconaSchedaVideo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconaStriscaLED, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnGPU_GU As Label
    Friend WithEvents BtnGPU_SU As Label
    Friend WithEvents Stato_GPU As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnRGBOFF_GPU As Label
    Friend WithEvents BtnRGBON_GPU As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NumLED_GPU As TextBox
    Friend WithEvents BtnGPU As Label
    Friend WithEvents IconaSchedaVideo As PictureBox
    Friend WithEvents BtnStripLED_GU As Label
    Friend WithEvents BtnStripLED_SU As Label
    Friend WithEvents Stato_StripLED As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnRGBOFF_StripLED As Label
    Friend WithEvents BtnRGBON_StripLED As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents NumLED_StripLED As TextBox
    Friend WithEvents BtnStripLED As Label
    Friend WithEvents IconaStriscaLED As PictureBox
    Friend WithEvents Label4 As Label
End Class
