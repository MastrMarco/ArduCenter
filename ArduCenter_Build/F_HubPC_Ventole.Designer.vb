<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_HubPC_Ventole
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
        Me.BtnTSens = New System.Windows.Forms.PictureBox()
        Me.TempBarSens = New CircularProgressBar.CircularProgressBar()
        Me.LaTempSens = New System.Windows.Forms.Label()
        Me.TempBarCPU = New CircularProgressBar.CircularProgressBar()
        Me.BtnTCPU = New System.Windows.Forms.PictureBox()
        Me.LaTempCPU = New System.Windows.Forms.Label()
        Me.TempBarGPU = New CircularProgressBar.CircularProgressBar()
        Me.BtnTGPU = New System.Windows.Forms.PictureBox()
        Me.IconaFan4 = New System.Windows.Forms.PictureBox()
        Me.IconaFan1 = New System.Windows.Forms.PictureBox()
        Me.IconaFan2 = New System.Windows.Forms.PictureBox()
        Me.IconaFan3 = New System.Windows.Forms.PictureBox()
        Me.IconaFanScolor = New System.Windows.Forms.PictureBox()
        Me.LaFAN_4 = New System.Windows.Forms.Label()
        Me.LaFAN_3 = New System.Windows.Forms.Label()
        Me.LaFAN_2 = New System.Windows.Forms.Label()
        Me.LaFAN_1 = New System.Windows.Forms.Label()
        Me.TitoloFan = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LaFanModalità = New System.Windows.Forms.Label()
        Me.LaLuminosità = New System.Windows.Forms.Label()
        Me.LaVelocità = New System.Windows.Forms.Label()
        Me.LaColore = New System.Windows.Forms.Label()
        Me.LodBarSpeeFan3 = New System.Windows.Forms.PictureBox()
        Me.LodBarSpeeFan2 = New System.Windows.Forms.PictureBox()
        Me.LodBarSpeeFan1 = New System.Windows.Forms.PictureBox()
        Me.LodBarLimFan1 = New System.Windows.Forms.PictureBox()
        Me.LodBarLimFan2 = New System.Windows.Forms.PictureBox()
        Me.LodBarLimFan3 = New System.Windows.Forms.PictureBox()
        Me.LodBarLimFan4 = New System.Windows.Forms.PictureBox()
        Me.LodBarLimFan1_0 = New System.Windows.Forms.PictureBox()
        Me.LodBarLimFan2_0 = New System.Windows.Forms.PictureBox()
        Me.LodBarLimFan3_0 = New System.Windows.Forms.PictureBox()
        Me.LodBarLimFan4_0 = New System.Windows.Forms.PictureBox()
        Me.LodBarSpeeFan1_0 = New System.Windows.Forms.PictureBox()
        Me.LodBarSpeeFan2_0 = New System.Windows.Forms.PictureBox()
        Me.LodBarSpeeFan3_0 = New System.Windows.Forms.PictureBox()
        Me.LodBarSpeeFan4 = New System.Windows.Forms.PictureBox()
        Me.LodBarSpeeFan4_0 = New System.Windows.Forms.PictureBox()
        Me.LaTempGPU = New System.Windows.Forms.Label()
        Me.LaRPMvnetola = New System.Windows.Forms.Label()
        CType(Me.BtnTSens, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnTCPU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnTGPU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconaFan4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconaFan1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconaFan2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconaFan3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconaFanScolor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LodBarSpeeFan3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LodBarSpeeFan2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LodBarSpeeFan1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LodBarLimFan1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LodBarLimFan2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LodBarLimFan3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LodBarLimFan4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LodBarLimFan1_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LodBarLimFan2_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LodBarLimFan3_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LodBarLimFan4_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LodBarSpeeFan1_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LodBarSpeeFan2_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LodBarSpeeFan3_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LodBarSpeeFan4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LodBarSpeeFan4_0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnTSens
        '
        Me.BtnTSens.BackColor = System.Drawing.Color.Transparent
        Me.BtnTSens.BackgroundImage = Global.ArduCenter.My.Resources.Resources.btn_Swich
        Me.BtnTSens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnTSens.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTSens.Enabled = False
        Me.BtnTSens.Location = New System.Drawing.Point(517, 98)
        Me.BtnTSens.Name = "BtnTSens"
        Me.BtnTSens.Size = New System.Drawing.Size(55, 21)
        Me.BtnTSens.TabIndex = 108
        Me.BtnTSens.TabStop = False
        '
        'TempBarSens
        '
        Me.TempBarSens.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.TempBarSens.AnimationSpeed = 300
        Me.TempBarSens.BackColor = System.Drawing.Color.Transparent
        Me.TempBarSens.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TempBarSens.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TempBarSens.InnerColor = System.Drawing.Color.Transparent
        Me.TempBarSens.InnerMargin = 2
        Me.TempBarSens.InnerWidth = -1
        Me.TempBarSens.Location = New System.Drawing.Point(402, 40)
        Me.TempBarSens.MarqueeAnimationSpeed = 2000
        Me.TempBarSens.Name = "TempBarSens"
        Me.TempBarSens.OuterColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.TempBarSens.OuterMargin = -25
        Me.TempBarSens.OuterWidth = 26
        Me.TempBarSens.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TempBarSens.ProgressWidth = 11
        Me.TempBarSens.SecondaryFont = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TempBarSens.Size = New System.Drawing.Size(85, 85)
        Me.TempBarSens.StartAngle = 90
        Me.TempBarSens.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.TempBarSens.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.TempBarSens.SubscriptText = ""
        Me.TempBarSens.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.TempBarSens.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.TempBarSens.SuperscriptText = ""
        Me.TempBarSens.TabIndex = 115
        Me.TempBarSens.Text = "100"
        Me.TempBarSens.TextMargin = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.TempBarSens.Value = 100
        '
        'LaTempSens
        '
        Me.LaTempSens.BackColor = System.Drawing.Color.Transparent
        Me.LaTempSens.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LaTempSens.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaTempSens.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LaTempSens.Location = New System.Drawing.Point(483, 42)
        Me.LaTempSens.Name = "LaTempSens"
        Me.LaTempSens.Size = New System.Drawing.Size(121, 70)
        Me.LaTempSens.TabIndex = 118
        Me.LaTempSens.Text = "Temperatura" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sensore" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Curva Ventole"
        Me.LaTempSens.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TempBarCPU
        '
        Me.TempBarCPU.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TempBarCPU.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.TempBarCPU.AnimationSpeed = 300
        Me.TempBarCPU.BackColor = System.Drawing.Color.Transparent
        Me.TempBarCPU.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TempBarCPU.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.TempBarCPU.InnerColor = System.Drawing.Color.Transparent
        Me.TempBarCPU.InnerMargin = 2
        Me.TempBarCPU.InnerWidth = -1
        Me.TempBarCPU.Location = New System.Drawing.Point(402, 160)
        Me.TempBarCPU.MarqueeAnimationSpeed = 2000
        Me.TempBarCPU.Name = "TempBarCPU"
        Me.TempBarCPU.OuterColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.TempBarCPU.OuterMargin = -25
        Me.TempBarCPU.OuterWidth = 26
        Me.TempBarCPU.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.TempBarCPU.ProgressWidth = 11
        Me.TempBarCPU.SecondaryFont = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TempBarCPU.Size = New System.Drawing.Size(85, 85)
        Me.TempBarCPU.StartAngle = 90
        Me.TempBarCPU.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.TempBarCPU.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.TempBarCPU.SubscriptText = ""
        Me.TempBarCPU.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.TempBarCPU.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.TempBarCPU.SuperscriptText = ""
        Me.TempBarCPU.TabIndex = 116
        Me.TempBarCPU.Text = "100"
        Me.TempBarCPU.TextMargin = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.TempBarCPU.Value = 100
        Me.TempBarCPU.Visible = False
        '
        'BtnTCPU
        '
        Me.BtnTCPU.BackColor = System.Drawing.Color.Transparent
        Me.BtnTCPU.BackgroundImage = Global.ArduCenter.My.Resources.Resources.btn_Swich
        Me.BtnTCPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnTCPU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTCPU.Enabled = False
        Me.BtnTCPU.Location = New System.Drawing.Point(518, 220)
        Me.BtnTCPU.Name = "BtnTCPU"
        Me.BtnTCPU.Size = New System.Drawing.Size(55, 21)
        Me.BtnTCPU.TabIndex = 113
        Me.BtnTCPU.TabStop = False
        Me.BtnTCPU.Visible = False
        '
        'LaTempCPU
        '
        Me.LaTempCPU.BackColor = System.Drawing.Color.Transparent
        Me.LaTempCPU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LaTempCPU.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaTempCPU.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.LaTempCPU.Location = New System.Drawing.Point(483, 164)
        Me.LaTempCPU.Name = "LaTempCPU"
        Me.LaTempCPU.Size = New System.Drawing.Size(121, 70)
        Me.LaTempCPU.TabIndex = 119
        Me.LaTempCPU.Text = "Temperatura" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CPU" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Curva Ventole"
        Me.LaTempCPU.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LaTempCPU.Visible = False
        '
        'TempBarGPU
        '
        Me.TempBarGPU.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.TempBarGPU.AnimationSpeed = 300
        Me.TempBarGPU.BackColor = System.Drawing.Color.Transparent
        Me.TempBarGPU.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TempBarGPU.ForeColor = System.Drawing.Color.Fuchsia
        Me.TempBarGPU.InnerColor = System.Drawing.Color.Transparent
        Me.TempBarGPU.InnerMargin = 2
        Me.TempBarGPU.InnerWidth = -1
        Me.TempBarGPU.Location = New System.Drawing.Point(402, 282)
        Me.TempBarGPU.MarqueeAnimationSpeed = 2000
        Me.TempBarGPU.Name = "TempBarGPU"
        Me.TempBarGPU.OuterColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.TempBarGPU.OuterMargin = -25
        Me.TempBarGPU.OuterWidth = 26
        Me.TempBarGPU.ProgressColor = System.Drawing.Color.Fuchsia
        Me.TempBarGPU.ProgressWidth = 11
        Me.TempBarGPU.SecondaryFont = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TempBarGPU.Size = New System.Drawing.Size(85, 85)
        Me.TempBarGPU.StartAngle = 90
        Me.TempBarGPU.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.TempBarGPU.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.TempBarGPU.SubscriptText = ""
        Me.TempBarGPU.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.TempBarGPU.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.TempBarGPU.SuperscriptText = ""
        Me.TempBarGPU.TabIndex = 117
        Me.TempBarGPU.Text = "100"
        Me.TempBarGPU.TextMargin = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.TempBarGPU.Value = 100
        Me.TempBarGPU.Visible = False
        '
        'BtnTGPU
        '
        Me.BtnTGPU.BackColor = System.Drawing.Color.Transparent
        Me.BtnTGPU.BackgroundImage = Global.ArduCenter.My.Resources.Resources.btn_Swich
        Me.BtnTGPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnTGPU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTGPU.Enabled = False
        Me.BtnTGPU.Location = New System.Drawing.Point(518, 340)
        Me.BtnTGPU.Name = "BtnTGPU"
        Me.BtnTGPU.Size = New System.Drawing.Size(55, 21)
        Me.BtnTGPU.TabIndex = 114
        Me.BtnTGPU.TabStop = False
        Me.BtnTGPU.Visible = False
        '
        'IconaFan4
        '
        Me.IconaFan4.BackColor = System.Drawing.Color.Black
        Me.IconaFan4.BackgroundImage = Global.ArduCenter.My.Resources.Resources.IconaFan_RGB_Colore_HSV_RGB_2_0
        Me.IconaFan4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IconaFan4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconaFan4.Location = New System.Drawing.Point(274, 251)
        Me.IconaFan4.Name = "IconaFan4"
        Me.IconaFan4.Size = New System.Drawing.Size(55, 55)
        Me.IconaFan4.TabIndex = 112
        Me.IconaFan4.TabStop = False
        '
        'IconaFan1
        '
        Me.IconaFan1.BackColor = System.Drawing.Color.Black
        Me.IconaFan1.BackgroundImage = Global.ArduCenter.My.Resources.Resources.IconaFan_RGB_Colore_HSV_RGB_2_0
        Me.IconaFan1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IconaFan1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconaFan1.Location = New System.Drawing.Point(54, 251)
        Me.IconaFan1.Name = "IconaFan1"
        Me.IconaFan1.Size = New System.Drawing.Size(55, 55)
        Me.IconaFan1.TabIndex = 111
        Me.IconaFan1.TabStop = False
        '
        'IconaFan2
        '
        Me.IconaFan2.BackColor = System.Drawing.Color.Black
        Me.IconaFan2.BackgroundImage = Global.ArduCenter.My.Resources.Resources.IconaFan_RGB_Colore_HSV_RGB_2_0
        Me.IconaFan2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IconaFan2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconaFan2.Location = New System.Drawing.Point(127, 251)
        Me.IconaFan2.Name = "IconaFan2"
        Me.IconaFan2.Size = New System.Drawing.Size(55, 55)
        Me.IconaFan2.TabIndex = 110
        Me.IconaFan2.TabStop = False
        '
        'IconaFan3
        '
        Me.IconaFan3.BackColor = System.Drawing.Color.Black
        Me.IconaFan3.BackgroundImage = Global.ArduCenter.My.Resources.Resources.IconaFan_RGB_Colore_HSV_RGB_2_0
        Me.IconaFan3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IconaFan3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconaFan3.Location = New System.Drawing.Point(201, 251)
        Me.IconaFan3.Name = "IconaFan3"
        Me.IconaFan3.Size = New System.Drawing.Size(55, 55)
        Me.IconaFan3.TabIndex = 109
        Me.IconaFan3.TabStop = False
        '
        'IconaFanScolor
        '
        Me.IconaFanScolor.BackColor = System.Drawing.Color.Black
        Me.IconaFanScolor.BackgroundImage = Global.ArduCenter.My.Resources.Resources.IconaFan_RGB_Colore_HSV_RGB_2_0
        Me.IconaFanScolor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IconaFanScolor.Location = New System.Drawing.Point(20, 21)
        Me.IconaFanScolor.Margin = New System.Windows.Forms.Padding(0)
        Me.IconaFanScolor.Name = "IconaFanScolor"
        Me.IconaFanScolor.Size = New System.Drawing.Size(160, 160)
        Me.IconaFanScolor.TabIndex = 106
        Me.IconaFanScolor.TabStop = False
        '
        'LaFAN_4
        '
        Me.LaFAN_4.AutoSize = True
        Me.LaFAN_4.BackColor = System.Drawing.Color.Transparent
        Me.LaFAN_4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LaFAN_4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaFAN_4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.LaFAN_4.Location = New System.Drawing.Point(274, 226)
        Me.LaFAN_4.Name = "LaFAN_4"
        Me.LaFAN_4.Size = New System.Drawing.Size(56, 18)
        Me.LaFAN_4.TabIndex = 105
        Me.LaFAN_4.Text = "Fan 4"
        '
        'LaFAN_3
        '
        Me.LaFAN_3.AutoSize = True
        Me.LaFAN_3.BackColor = System.Drawing.Color.Transparent
        Me.LaFAN_3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LaFAN_3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaFAN_3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.LaFAN_3.Location = New System.Drawing.Point(201, 226)
        Me.LaFAN_3.Name = "LaFAN_3"
        Me.LaFAN_3.Size = New System.Drawing.Size(56, 18)
        Me.LaFAN_3.TabIndex = 104
        Me.LaFAN_3.Text = "Fan 3"
        '
        'LaFAN_2
        '
        Me.LaFAN_2.AutoSize = True
        Me.LaFAN_2.BackColor = System.Drawing.Color.Transparent
        Me.LaFAN_2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LaFAN_2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaFAN_2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.LaFAN_2.Location = New System.Drawing.Point(127, 226)
        Me.LaFAN_2.Name = "LaFAN_2"
        Me.LaFAN_2.Size = New System.Drawing.Size(56, 18)
        Me.LaFAN_2.TabIndex = 103
        Me.LaFAN_2.Text = "Fan 2"
        '
        'LaFAN_1
        '
        Me.LaFAN_1.AutoSize = True
        Me.LaFAN_1.BackColor = System.Drawing.Color.Transparent
        Me.LaFAN_1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LaFAN_1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaFAN_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.LaFAN_1.Location = New System.Drawing.Point(54, 226)
        Me.LaFAN_1.Name = "LaFAN_1"
        Me.LaFAN_1.Size = New System.Drawing.Size(56, 18)
        Me.LaFAN_1.TabIndex = 102
        Me.LaFAN_1.Text = "Fan 1"
        '
        'TitoloFan
        '
        Me.TitoloFan.BackColor = System.Drawing.Color.Transparent
        Me.TitoloFan.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitoloFan.ForeColor = System.Drawing.Color.White
        Me.TitoloFan.Location = New System.Drawing.Point(186, 17)
        Me.TitoloFan.Name = "TitoloFan"
        Me.TitoloFan.Size = New System.Drawing.Size(183, 23)
        Me.TitoloFan.TabIndex = 100
        Me.TitoloFan.Text = "Tutte le ventole"
        Me.TitoloFan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(420, 257)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(168, 18)
        Me.Label11.TabIndex = 99
        Me.Label11.Text = "Temperatura GPU"
        Me.Label11.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(420, 136)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(167, 18)
        Me.Label10.TabIndex = 98
        Me.Label10.Text = "Temperatura CPU"
        Me.Label10.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(402, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(202, 18)
        Me.Label9.TabIndex = 97
        Me.Label9.Text = "Temperatura Sensore"
        Me.Label9.Visible = False
        '
        'LaFanModalità
        '
        Me.LaFanModalità.AutoSize = True
        Me.LaFanModalità.BackColor = System.Drawing.Color.Transparent
        Me.LaFanModalità.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaFanModalità.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.LaFanModalità.Location = New System.Drawing.Point(185, 129)
        Me.LaFanModalità.Name = "LaFanModalità"
        Me.LaFanModalità.Size = New System.Drawing.Size(186, 18)
        Me.LaFanModalità.TabIndex = 96
        Me.LaFanModalità.Text = "Modalità      Manuale"
        '
        'LaLuminosità
        '
        Me.LaLuminosità.AutoSize = True
        Me.LaLuminosità.BackColor = System.Drawing.Color.Transparent
        Me.LaLuminosità.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaLuminosità.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.LaLuminosità.Location = New System.Drawing.Point(184, 77)
        Me.LaLuminosità.Name = "LaLuminosità"
        Me.LaLuminosità.Size = New System.Drawing.Size(170, 18)
        Me.LaLuminosità.TabIndex = 95
        Me.LaLuminosità.Text = "Luminosità   100%"
        '
        'LaVelocità
        '
        Me.LaVelocità.AutoSize = True
        Me.LaVelocità.BackColor = System.Drawing.Color.Transparent
        Me.LaVelocità.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaVelocità.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.LaVelocità.Location = New System.Drawing.Point(185, 103)
        Me.LaVelocità.Name = "LaVelocità"
        Me.LaVelocità.Size = New System.Drawing.Size(170, 18)
        Me.LaVelocità.TabIndex = 94
        Me.LaVelocità.Text = "Velocità        100%"
        '
        'LaColore
        '
        Me.LaColore.AutoSize = True
        Me.LaColore.BackColor = System.Drawing.Color.Transparent
        Me.LaColore.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaColore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.LaColore.Location = New System.Drawing.Point(184, 51)
        Me.LaColore.Name = "LaColore"
        Me.LaColore.Size = New System.Drawing.Size(177, 18)
        Me.LaColore.TabIndex = 93
        Me.LaColore.Text = "Colore          Spento"
        '
        'LodBarSpeeFan3
        '
        Me.LodBarSpeeFan3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.LodBarSpeeFan3.Location = New System.Drawing.Point(231, 310)
        Me.LodBarSpeeFan3.Name = "LodBarSpeeFan3"
        Me.LodBarSpeeFan3.Size = New System.Drawing.Size(10, 5)
        Me.LodBarSpeeFan3.TabIndex = 81
        Me.LodBarSpeeFan3.TabStop = False
        '
        'LodBarSpeeFan2
        '
        Me.LodBarSpeeFan2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.LodBarSpeeFan2.Location = New System.Drawing.Point(157, 310)
        Me.LodBarSpeeFan2.Name = "LodBarSpeeFan2"
        Me.LodBarSpeeFan2.Size = New System.Drawing.Size(10, 5)
        Me.LodBarSpeeFan2.TabIndex = 80
        Me.LodBarSpeeFan2.TabStop = False
        '
        'LodBarSpeeFan1
        '
        Me.LodBarSpeeFan1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.LodBarSpeeFan1.Location = New System.Drawing.Point(84, 310)
        Me.LodBarSpeeFan1.Name = "LodBarSpeeFan1"
        Me.LodBarSpeeFan1.Size = New System.Drawing.Size(10, 5)
        Me.LodBarSpeeFan1.TabIndex = 79
        Me.LodBarSpeeFan1.TabStop = False
        '
        'LodBarLimFan1
        '
        Me.LodBarLimFan1.BackColor = System.Drawing.Color.Orange
        Me.LodBarLimFan1.Location = New System.Drawing.Point(67, 310)
        Me.LodBarLimFan1.Name = "LodBarLimFan1"
        Me.LodBarLimFan1.Size = New System.Drawing.Size(10, 5)
        Me.LodBarLimFan1.TabIndex = 77
        Me.LodBarLimFan1.TabStop = False
        '
        'LodBarLimFan2
        '
        Me.LodBarLimFan2.BackColor = System.Drawing.Color.Orange
        Me.LodBarLimFan2.Location = New System.Drawing.Point(140, 310)
        Me.LodBarLimFan2.Name = "LodBarLimFan2"
        Me.LodBarLimFan2.Size = New System.Drawing.Size(10, 5)
        Me.LodBarLimFan2.TabIndex = 76
        Me.LodBarLimFan2.TabStop = False
        '
        'LodBarLimFan3
        '
        Me.LodBarLimFan3.BackColor = System.Drawing.Color.Orange
        Me.LodBarLimFan3.Location = New System.Drawing.Point(214, 310)
        Me.LodBarLimFan3.Name = "LodBarLimFan3"
        Me.LodBarLimFan3.Size = New System.Drawing.Size(10, 5)
        Me.LodBarLimFan3.TabIndex = 75
        Me.LodBarLimFan3.TabStop = False
        '
        'LodBarLimFan4
        '
        Me.LodBarLimFan4.BackColor = System.Drawing.Color.Orange
        Me.LodBarLimFan4.Location = New System.Drawing.Point(288, 310)
        Me.LodBarLimFan4.Name = "LodBarLimFan4"
        Me.LodBarLimFan4.Size = New System.Drawing.Size(10, 5)
        Me.LodBarLimFan4.TabIndex = 74
        Me.LodBarLimFan4.TabStop = False
        '
        'LodBarLimFan1_0
        '
        Me.LodBarLimFan1_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.LodBarLimFan1_0.Location = New System.Drawing.Point(67, 310)
        Me.LodBarLimFan1_0.Name = "LodBarLimFan1_0"
        Me.LodBarLimFan1_0.Size = New System.Drawing.Size(10, 45)
        Me.LodBarLimFan1_0.TabIndex = 85
        Me.LodBarLimFan1_0.TabStop = False
        '
        'LodBarLimFan2_0
        '
        Me.LodBarLimFan2_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.LodBarLimFan2_0.Location = New System.Drawing.Point(140, 310)
        Me.LodBarLimFan2_0.Name = "LodBarLimFan2_0"
        Me.LodBarLimFan2_0.Size = New System.Drawing.Size(10, 45)
        Me.LodBarLimFan2_0.TabIndex = 87
        Me.LodBarLimFan2_0.TabStop = False
        '
        'LodBarLimFan3_0
        '
        Me.LodBarLimFan3_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.LodBarLimFan3_0.Location = New System.Drawing.Point(214, 310)
        Me.LodBarLimFan3_0.Name = "LodBarLimFan3_0"
        Me.LodBarLimFan3_0.Size = New System.Drawing.Size(10, 45)
        Me.LodBarLimFan3_0.TabIndex = 89
        Me.LodBarLimFan3_0.TabStop = False
        '
        'LodBarLimFan4_0
        '
        Me.LodBarLimFan4_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.LodBarLimFan4_0.Location = New System.Drawing.Point(288, 310)
        Me.LodBarLimFan4_0.Name = "LodBarLimFan4_0"
        Me.LodBarLimFan4_0.Size = New System.Drawing.Size(10, 45)
        Me.LodBarLimFan4_0.TabIndex = 91
        Me.LodBarLimFan4_0.TabStop = False
        '
        'LodBarSpeeFan1_0
        '
        Me.LodBarSpeeFan1_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.LodBarSpeeFan1_0.Location = New System.Drawing.Point(84, 310)
        Me.LodBarSpeeFan1_0.Name = "LodBarSpeeFan1_0"
        Me.LodBarSpeeFan1_0.Size = New System.Drawing.Size(10, 45)
        Me.LodBarSpeeFan1_0.TabIndex = 86
        Me.LodBarSpeeFan1_0.TabStop = False
        '
        'LodBarSpeeFan2_0
        '
        Me.LodBarSpeeFan2_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.LodBarSpeeFan2_0.Location = New System.Drawing.Point(157, 310)
        Me.LodBarSpeeFan2_0.Name = "LodBarSpeeFan2_0"
        Me.LodBarSpeeFan2_0.Size = New System.Drawing.Size(10, 45)
        Me.LodBarSpeeFan2_0.TabIndex = 88
        Me.LodBarSpeeFan2_0.TabStop = False
        '
        'LodBarSpeeFan3_0
        '
        Me.LodBarSpeeFan3_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.LodBarSpeeFan3_0.Location = New System.Drawing.Point(231, 310)
        Me.LodBarSpeeFan3_0.Name = "LodBarSpeeFan3_0"
        Me.LodBarSpeeFan3_0.Size = New System.Drawing.Size(10, 45)
        Me.LodBarSpeeFan3_0.TabIndex = 90
        Me.LodBarSpeeFan3_0.TabStop = False
        '
        'LodBarSpeeFan4
        '
        Me.LodBarSpeeFan4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.LodBarSpeeFan4.Location = New System.Drawing.Point(304, 310)
        Me.LodBarSpeeFan4.Name = "LodBarSpeeFan4"
        Me.LodBarSpeeFan4.Size = New System.Drawing.Size(10, 5)
        Me.LodBarSpeeFan4.TabIndex = 82
        Me.LodBarSpeeFan4.TabStop = False
        '
        'LodBarSpeeFan4_0
        '
        Me.LodBarSpeeFan4_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.LodBarSpeeFan4_0.Location = New System.Drawing.Point(304, 310)
        Me.LodBarSpeeFan4_0.Name = "LodBarSpeeFan4_0"
        Me.LodBarSpeeFan4_0.Size = New System.Drawing.Size(10, 45)
        Me.LodBarSpeeFan4_0.TabIndex = 92
        Me.LodBarSpeeFan4_0.TabStop = False
        '
        'LaTempGPU
        '
        Me.LaTempGPU.BackColor = System.Drawing.Color.Transparent
        Me.LaTempGPU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LaTempGPU.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaTempGPU.ForeColor = System.Drawing.Color.Fuchsia
        Me.LaTempGPU.Location = New System.Drawing.Point(483, 286)
        Me.LaTempGPU.Name = "LaTempGPU"
        Me.LaTempGPU.Size = New System.Drawing.Size(121, 70)
        Me.LaTempGPU.TabIndex = 120
        Me.LaTempGPU.Text = "Temperatura" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "GPU" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Curva Ventole"
        Me.LaTempGPU.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LaTempGPU.Visible = False
        '
        'LaRPMvnetola
        '
        Me.LaRPMvnetola.AutoSize = True
        Me.LaRPMvnetola.BackColor = System.Drawing.Color.Transparent
        Me.LaRPMvnetola.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaRPMvnetola.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.LaRPMvnetola.Location = New System.Drawing.Point(186, 156)
        Me.LaRPMvnetola.Name = "LaRPMvnetola"
        Me.LaRPMvnetola.Size = New System.Drawing.Size(175, 18)
        Me.LaRPMvnetola.TabIndex = 121
        Me.LaRPMvnetola.Text = "RPM            Ventola"
        '
        'F_HubPC_Ventole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BackgroundImage = Global.ArduCenter.My.Resources.Resources.GUI_Fan_Menù
        Me.ClientSize = New System.Drawing.Size(618, 381)
        Me.Controls.Add(Me.LaRPMvnetola)
        Me.Controls.Add(Me.BtnTSens)
        Me.Controls.Add(Me.TempBarSens)
        Me.Controls.Add(Me.LaTempSens)
        Me.Controls.Add(Me.TempBarCPU)
        Me.Controls.Add(Me.BtnTCPU)
        Me.Controls.Add(Me.LaTempCPU)
        Me.Controls.Add(Me.TempBarGPU)
        Me.Controls.Add(Me.BtnTGPU)
        Me.Controls.Add(Me.IconaFan4)
        Me.Controls.Add(Me.IconaFan1)
        Me.Controls.Add(Me.IconaFan2)
        Me.Controls.Add(Me.IconaFan3)
        Me.Controls.Add(Me.IconaFanScolor)
        Me.Controls.Add(Me.LaFAN_4)
        Me.Controls.Add(Me.LaFAN_3)
        Me.Controls.Add(Me.LaFAN_2)
        Me.Controls.Add(Me.LaFAN_1)
        Me.Controls.Add(Me.TitoloFan)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LaFanModalità)
        Me.Controls.Add(Me.LaLuminosità)
        Me.Controls.Add(Me.LaVelocità)
        Me.Controls.Add(Me.LaColore)
        Me.Controls.Add(Me.LodBarSpeeFan3)
        Me.Controls.Add(Me.LodBarSpeeFan2)
        Me.Controls.Add(Me.LodBarSpeeFan1)
        Me.Controls.Add(Me.LodBarLimFan1)
        Me.Controls.Add(Me.LodBarLimFan2)
        Me.Controls.Add(Me.LodBarLimFan3)
        Me.Controls.Add(Me.LodBarLimFan4)
        Me.Controls.Add(Me.LodBarLimFan1_0)
        Me.Controls.Add(Me.LodBarLimFan2_0)
        Me.Controls.Add(Me.LodBarLimFan3_0)
        Me.Controls.Add(Me.LodBarLimFan4_0)
        Me.Controls.Add(Me.LodBarSpeeFan1_0)
        Me.Controls.Add(Me.LodBarSpeeFan2_0)
        Me.Controls.Add(Me.LodBarSpeeFan3_0)
        Me.Controls.Add(Me.LodBarSpeeFan4)
        Me.Controls.Add(Me.LodBarSpeeFan4_0)
        Me.Controls.Add(Me.LaTempGPU)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_HubPC_Ventole"
        Me.Text = "F_HubPC_Ventole"
        CType(Me.BtnTSens, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnTCPU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnTGPU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconaFan4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconaFan1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconaFan2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconaFan3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconaFanScolor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LodBarSpeeFan3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LodBarSpeeFan2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LodBarSpeeFan1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LodBarLimFan1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LodBarLimFan2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LodBarLimFan3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LodBarLimFan4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LodBarLimFan1_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LodBarLimFan2_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LodBarLimFan3_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LodBarLimFan4_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LodBarSpeeFan1_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LodBarSpeeFan2_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LodBarSpeeFan3_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LodBarSpeeFan4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LodBarSpeeFan4_0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnTSens As PictureBox
    Friend WithEvents TempBarSens As CircularProgressBar.CircularProgressBar
    Friend WithEvents LaTempSens As Label
    Friend WithEvents TempBarCPU As CircularProgressBar.CircularProgressBar
    Friend WithEvents BtnTCPU As PictureBox
    Friend WithEvents LaTempCPU As Label
    Friend WithEvents TempBarGPU As CircularProgressBar.CircularProgressBar
    Friend WithEvents BtnTGPU As PictureBox
    Friend WithEvents IconaFan4 As PictureBox
    Friend WithEvents IconaFan1 As PictureBox
    Friend WithEvents IconaFan2 As PictureBox
    Friend WithEvents IconaFan3 As PictureBox
    Friend WithEvents IconaFanScolor As PictureBox
    Friend WithEvents LaFAN_4 As Label
    Friend WithEvents LaFAN_3 As Label
    Friend WithEvents LaFAN_2 As Label
    Friend WithEvents LaFAN_1 As Label
    Friend WithEvents TitoloFan As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LaFanModalità As Label
    Friend WithEvents LaLuminosità As Label
    Friend WithEvents LaVelocità As Label
    Friend WithEvents LaColore As Label
    Friend WithEvents LodBarSpeeFan3 As PictureBox
    Friend WithEvents LodBarSpeeFan2 As PictureBox
    Friend WithEvents LodBarSpeeFan1 As PictureBox
    Friend WithEvents LodBarLimFan1 As PictureBox
    Friend WithEvents LodBarLimFan2 As PictureBox
    Friend WithEvents LodBarLimFan3 As PictureBox
    Friend WithEvents LodBarLimFan4 As PictureBox
    Friend WithEvents LodBarLimFan1_0 As PictureBox
    Friend WithEvents LodBarLimFan2_0 As PictureBox
    Friend WithEvents LodBarLimFan3_0 As PictureBox
    Friend WithEvents LodBarLimFan4_0 As PictureBox
    Friend WithEvents LodBarSpeeFan1_0 As PictureBox
    Friend WithEvents LodBarSpeeFan2_0 As PictureBox
    Friend WithEvents LodBarSpeeFan3_0 As PictureBox
    Friend WithEvents LodBarSpeeFan4 As PictureBox
    Friend WithEvents LodBarSpeeFan4_0 As PictureBox
    Friend WithEvents LaTempGPU As Label
    Friend WithEvents LaRPMvnetola As Label
End Class
