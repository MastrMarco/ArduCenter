<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_HubPC_GPU_SLED
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
        Me.IconaStatoFan_Menù_2 = New System.Windows.Forms.PictureBox()
        Me.LoadBarGPU = New CircularProgressBar.CircularProgressBar()
        Me.LoadBarCPU = New CircularProgressBar.CircularProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnGPU_LED = New System.Windows.Forms.Label()
        Me.LaLuminosità = New System.Windows.Forms.Label()
        Me.InColore = New System.Windows.Forms.Label()
        Me.LaColore = New System.Windows.Forms.Label()
        Me.BtnStrip_LED = New System.Windows.Forms.Label()
        Me.BtnIMG_GPU_LED = New System.Windows.Forms.PictureBox()
        Me.BtnIMG_Strip_LED = New System.Windows.Forms.PictureBox()
        Me.LoadBarRAM = New CircularProgressBar.CircularProgressBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LaSelezione = New System.Windows.Forms.Label()
        CType(Me.IconaStatoFan_Menù_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnIMG_GPU_LED, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnIMG_Strip_LED, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IconaStatoFan_Menù_2
        '
        Me.IconaStatoFan_Menù_2.BackColor = System.Drawing.Color.Transparent
        Me.IconaStatoFan_Menù_2.BackgroundImage = Global.ArduCenter.My.Resources.Resources.Icona_SchedaVideo_RGB_Colore_HSV_RGB_21
        Me.IconaStatoFan_Menù_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IconaStatoFan_Menù_2.Location = New System.Drawing.Point(43, 16)
        Me.IconaStatoFan_Menù_2.Name = "IconaStatoFan_Menù_2"
        Me.IconaStatoFan_Menù_2.Size = New System.Drawing.Size(295, 160)
        Me.IconaStatoFan_Menù_2.TabIndex = 0
        Me.IconaStatoFan_Menù_2.TabStop = False
        '
        'LoadBarGPU
        '
        Me.LoadBarGPU.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.LoadBarGPU.AnimationSpeed = 300
        Me.LoadBarGPU.BackColor = System.Drawing.Color.Transparent
        Me.LoadBarGPU.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadBarGPU.ForeColor = System.Drawing.Color.Fuchsia
        Me.LoadBarGPU.InnerColor = System.Drawing.Color.Transparent
        Me.LoadBarGPU.InnerMargin = 2
        Me.LoadBarGPU.InnerWidth = -1
        Me.LoadBarGPU.Location = New System.Drawing.Point(399, 148)
        Me.LoadBarGPU.MarqueeAnimationSpeed = 2000
        Me.LoadBarGPU.Name = "LoadBarGPU"
        Me.LoadBarGPU.OuterColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.LoadBarGPU.OuterMargin = -25
        Me.LoadBarGPU.OuterWidth = 26
        Me.LoadBarGPU.ProgressColor = System.Drawing.Color.Fuchsia
        Me.LoadBarGPU.ProgressWidth = 11
        Me.LoadBarGPU.SecondaryFont = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadBarGPU.Size = New System.Drawing.Size(85, 85)
        Me.LoadBarGPU.StartAngle = 90
        Me.LoadBarGPU.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.LoadBarGPU.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.LoadBarGPU.SubscriptText = ""
        Me.LoadBarGPU.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.LoadBarGPU.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.LoadBarGPU.SuperscriptText = ""
        Me.LoadBarGPU.TabIndex = 118
        Me.LoadBarGPU.Text = "100"
        Me.LoadBarGPU.TextMargin = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.LoadBarGPU.Value = 100
        '
        'LoadBarCPU
        '
        Me.LoadBarCPU.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.LoadBarCPU.AnimationSpeed = 300
        Me.LoadBarCPU.BackColor = System.Drawing.Color.Transparent
        Me.LoadBarCPU.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadBarCPU.ForeColor = System.Drawing.Color.MediumTurquoise
        Me.LoadBarCPU.InnerColor = System.Drawing.Color.Transparent
        Me.LoadBarCPU.InnerMargin = 2
        Me.LoadBarCPU.InnerWidth = -1
        Me.LoadBarCPU.Location = New System.Drawing.Point(399, 30)
        Me.LoadBarCPU.MarqueeAnimationSpeed = 2000
        Me.LoadBarCPU.Name = "LoadBarCPU"
        Me.LoadBarCPU.OuterColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.LoadBarCPU.OuterMargin = -25
        Me.LoadBarCPU.OuterWidth = 26
        Me.LoadBarCPU.ProgressColor = System.Drawing.Color.MediumTurquoise
        Me.LoadBarCPU.ProgressWidth = 11
        Me.LoadBarCPU.SecondaryFont = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadBarCPU.Size = New System.Drawing.Size(85, 85)
        Me.LoadBarCPU.StartAngle = 90
        Me.LoadBarCPU.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.LoadBarCPU.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.LoadBarCPU.SubscriptText = ""
        Me.LoadBarCPU.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.LoadBarCPU.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.LoadBarCPU.SuperscriptText = ""
        Me.LoadBarCPU.TabIndex = 119
        Me.LoadBarCPU.Text = "100"
        Me.LoadBarCPU.TextMargin = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.LoadBarCPU.Value = 100
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(482, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 23)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "Utilizzo CPU"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(482, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 23)
        Me.Label2.TabIndex = 121
        Me.Label2.Text = "Utilizzo GPU"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnGPU_LED
        '
        Me.BtnGPU_LED.AutoSize = True
        Me.BtnGPU_LED.BackColor = System.Drawing.Color.Transparent
        Me.BtnGPU_LED.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGPU_LED.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGPU_LED.ForeColor = System.Drawing.Color.White
        Me.BtnGPU_LED.Location = New System.Drawing.Point(64, 254)
        Me.BtnGPU_LED.Name = "BtnGPU_LED"
        Me.BtnGPU_LED.Size = New System.Drawing.Size(67, 16)
        Me.BtnGPU_LED.TabIndex = 122
        Me.BtnGPU_LED.Text = "LED GPU"
        Me.BtnGPU_LED.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LaLuminosità
        '
        Me.LaLuminosità.BackColor = System.Drawing.Color.Transparent
        Me.LaLuminosità.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaLuminosità.ForeColor = System.Drawing.Color.White
        Me.LaLuminosità.Location = New System.Drawing.Point(40, 202)
        Me.LaLuminosità.Name = "LaLuminosità"
        Me.LaLuminosità.Size = New System.Drawing.Size(274, 18)
        Me.LaLuminosità.TabIndex = 127
        Me.LaLuminosità.Text = "Luminosità               100%"
        Me.LaLuminosità.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'InColore
        '
        Me.InColore.BackColor = System.Drawing.Color.Transparent
        Me.InColore.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InColore.ForeColor = System.Drawing.Color.White
        Me.InColore.Location = New System.Drawing.Point(36, 175)
        Me.InColore.Name = "InColore"
        Me.InColore.Size = New System.Drawing.Size(121, 18)
        Me.InColore.TabIndex = 126
        Me.InColore.Text = "Colore"
        Me.InColore.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LaColore
        '
        Me.LaColore.BackColor = System.Drawing.Color.Transparent
        Me.LaColore.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaColore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.LaColore.Location = New System.Drawing.Point(196, 175)
        Me.LaColore.Name = "LaColore"
        Me.LaColore.Size = New System.Drawing.Size(124, 18)
        Me.LaColore.TabIndex = 128
        Me.LaColore.Text = "Spento"
        Me.LaColore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnStrip_LED
        '
        Me.BtnStrip_LED.AutoSize = True
        Me.BtnStrip_LED.BackColor = System.Drawing.Color.Transparent
        Me.BtnStrip_LED.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnStrip_LED.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStrip_LED.ForeColor = System.Drawing.Color.White
        Me.BtnStrip_LED.Location = New System.Drawing.Point(241, 255)
        Me.BtnStrip_LED.Name = "BtnStrip_LED"
        Me.BtnStrip_LED.Size = New System.Drawing.Size(72, 16)
        Me.BtnStrip_LED.TabIndex = 130
        Me.BtnStrip_LED.Text = "LED Strip"
        Me.BtnStrip_LED.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnIMG_GPU_LED
        '
        Me.BtnIMG_GPU_LED.BackColor = System.Drawing.Color.Transparent
        Me.BtnIMG_GPU_LED.BackgroundImage = Global.ArduCenter.My.Resources.Resources.Icona_SchedaVideo_RGB_Colore_HSV_RGB_21
        Me.BtnIMG_GPU_LED.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnIMG_GPU_LED.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIMG_GPU_LED.Location = New System.Drawing.Point(30, 277)
        Me.BtnIMG_GPU_LED.Name = "BtnIMG_GPU_LED"
        Me.BtnIMG_GPU_LED.Size = New System.Drawing.Size(137, 74)
        Me.BtnIMG_GPU_LED.TabIndex = 137
        Me.BtnIMG_GPU_LED.TabStop = False
        '
        'BtnIMG_Strip_LED
        '
        Me.BtnIMG_Strip_LED.BackColor = System.Drawing.Color.Transparent
        Me.BtnIMG_Strip_LED.BackgroundImage = Global.ArduCenter.My.Resources.Resources.Icona_Strisca__RGB_Colore_HSV_RGB_2_2_2
        Me.BtnIMG_Strip_LED.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnIMG_Strip_LED.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIMG_Strip_LED.Location = New System.Drawing.Point(204, 277)
        Me.BtnIMG_Strip_LED.Name = "BtnIMG_Strip_LED"
        Me.BtnIMG_Strip_LED.Size = New System.Drawing.Size(137, 74)
        Me.BtnIMG_Strip_LED.TabIndex = 138
        Me.BtnIMG_Strip_LED.TabStop = False
        '
        'LoadBarRAM
        '
        Me.LoadBarRAM.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.LoadBarRAM.AnimationSpeed = 300
        Me.LoadBarRAM.BackColor = System.Drawing.Color.Transparent
        Me.LoadBarRAM.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadBarRAM.ForeColor = System.Drawing.Color.LimeGreen
        Me.LoadBarRAM.InnerColor = System.Drawing.Color.Transparent
        Me.LoadBarRAM.InnerMargin = 2
        Me.LoadBarRAM.InnerWidth = -1
        Me.LoadBarRAM.Location = New System.Drawing.Point(399, 266)
        Me.LoadBarRAM.MarqueeAnimationSpeed = 2000
        Me.LoadBarRAM.Name = "LoadBarRAM"
        Me.LoadBarRAM.OuterColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.LoadBarRAM.OuterMargin = -25
        Me.LoadBarRAM.OuterWidth = 26
        Me.LoadBarRAM.ProgressColor = System.Drawing.Color.LimeGreen
        Me.LoadBarRAM.ProgressWidth = 11
        Me.LoadBarRAM.SecondaryFont = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadBarRAM.Size = New System.Drawing.Size(85, 85)
        Me.LoadBarRAM.StartAngle = 90
        Me.LoadBarRAM.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.LoadBarRAM.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.LoadBarRAM.SubscriptText = ""
        Me.LoadBarRAM.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.LoadBarRAM.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.LoadBarRAM.SuperscriptText = ""
        Me.LoadBarRAM.TabIndex = 139
        Me.LoadBarRAM.Text = "100"
        Me.LoadBarRAM.TextMargin = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.LoadBarRAM.Value = 100
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(482, 297)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 23)
        Me.Label3.TabIndex = 140
        Me.Label3.Text = "Utilizzo RAM"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LaSelezione
        '
        Me.LaSelezione.BackColor = System.Drawing.Color.Transparent
        Me.LaSelezione.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaSelezione.ForeColor = System.Drawing.Color.White
        Me.LaSelezione.Location = New System.Drawing.Point(3, 9)
        Me.LaSelezione.Name = "LaSelezione"
        Me.LaSelezione.Size = New System.Drawing.Size(375, 23)
        Me.LaSelezione.TabIndex = 141
        Me.LaSelezione.Text = "Colore attuale [Mod Sinc]"
        Me.LaSelezione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'F_HubPC_GPU_SLED
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BackgroundImage = Global.ArduCenter.My.Resources.Resources.GUI_Fan_Menù_2_v21
        Me.ClientSize = New System.Drawing.Size(618, 381)
        Me.Controls.Add(Me.LaColore)
        Me.Controls.Add(Me.InColore)
        Me.Controls.Add(Me.LaSelezione)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LoadBarRAM)
        Me.Controls.Add(Me.BtnIMG_Strip_LED)
        Me.Controls.Add(Me.BtnIMG_GPU_LED)
        Me.Controls.Add(Me.BtnStrip_LED)
        Me.Controls.Add(Me.LaLuminosità)
        Me.Controls.Add(Me.BtnGPU_LED)
        Me.Controls.Add(Me.LoadBarGPU)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LoadBarCPU)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IconaStatoFan_Menù_2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_HubPC_GPU_SLED"
        Me.Text = "F_HubPC_GPU_SLED"
        CType(Me.IconaStatoFan_Menù_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnIMG_GPU_LED, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnIMG_Strip_LED, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IconaStatoFan_Menù_2 As PictureBox
    Friend WithEvents LoadBarGPU As CircularProgressBar.CircularProgressBar
    Friend WithEvents LoadBarCPU As CircularProgressBar.CircularProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnGPU_LED As Label
    Friend WithEvents LaLuminosità As Label
    Friend WithEvents InColore As Label
    Friend WithEvents LaColore As Label
    Friend WithEvents BtnStrip_LED As Label
    Friend WithEvents BtnIMG_GPU_LED As PictureBox
    Friend WithEvents BtnIMG_Strip_LED As PictureBox
    Friend WithEvents LoadBarRAM As CircularProgressBar.CircularProgressBar
    Friend WithEvents Label3 As Label
    Friend WithEvents LaSelezione As Label
End Class
