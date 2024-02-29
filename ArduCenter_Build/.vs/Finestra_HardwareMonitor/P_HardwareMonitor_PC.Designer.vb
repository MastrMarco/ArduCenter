<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_HardwareMonitor_PC
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
        Me.CaricoCPU = New CircularProgressBar.CircularProgressBar()
        Me.PowerCPU = New CircularProgressBar.CircularProgressBar()
        Me.PowerGPU = New CircularProgressBar.CircularProgressBar()
        Me.CaricoGPU = New CircularProgressBar.CircularProgressBar()
        Me.CaricoRAM = New CircularProgressBar.CircularProgressBar()
        Me.NomeCPU = New System.Windows.Forms.Label()
        Me.NomeGPU = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.LaFreqCPU = New System.Windows.Forms.Label()
        Me.LaFreqGPU = New System.Windows.Forms.Label()
        Me.LaFanGPU = New System.Windows.Forms.Label()
        Me.LaMemoryGPU = New System.Windows.Forms.Label()
        Me.InHrdware = New System.Windows.Forms.Label()
        Me.LaMemoryUsataRAM = New System.Windows.Forms.Label()
        Me.LaTotRAM = New System.Windows.Forms.Label()
        Me.TempCPU = New CircularProgressBar.CircularProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TempGPU = New CircularProgressBar.CircularProgressBar()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CaricoCPU
        '
        Me.CaricoCPU.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CaricoCPU.AnimationSpeed = 300
        Me.CaricoCPU.BackColor = System.Drawing.Color.Transparent
        Me.CaricoCPU.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CaricoCPU.ForeColor = System.Drawing.Color.White
        Me.CaricoCPU.InnerColor = System.Drawing.Color.Transparent
        Me.CaricoCPU.InnerMargin = 2
        Me.CaricoCPU.InnerWidth = -1
        Me.CaricoCPU.Location = New System.Drawing.Point(13, 117)
        Me.CaricoCPU.MarqueeAnimationSpeed = 2000
        Me.CaricoCPU.Name = "CaricoCPU"
        Me.CaricoCPU.OuterColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.CaricoCPU.OuterMargin = -25
        Me.CaricoCPU.OuterWidth = 25
        Me.CaricoCPU.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.CaricoCPU.ProgressWidth = 8
        Me.CaricoCPU.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CaricoCPU.Size = New System.Drawing.Size(60, 60)
        Me.CaricoCPU.StartAngle = 90
        Me.CaricoCPU.SubscriptColor = System.Drawing.Color.White
        Me.CaricoCPU.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CaricoCPU.SubscriptText = ""
        Me.CaricoCPU.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CaricoCPU.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CaricoCPU.SuperscriptText = ""
        Me.CaricoCPU.TabIndex = 0
        Me.CaricoCPU.Text = "-"
        Me.CaricoCPU.TextMargin = New System.Windows.Forms.Padding(0)
        Me.CaricoCPU.Value = 100
        '
        'PowerCPU
        '
        Me.PowerCPU.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.PowerCPU.AnimationSpeed = 300
        Me.PowerCPU.BackColor = System.Drawing.Color.Transparent
        Me.PowerCPU.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PowerCPU.ForeColor = System.Drawing.Color.White
        Me.PowerCPU.InnerColor = System.Drawing.Color.Transparent
        Me.PowerCPU.InnerMargin = 2
        Me.PowerCPU.InnerWidth = -1
        Me.PowerCPU.Location = New System.Drawing.Point(206, 117)
        Me.PowerCPU.MarqueeAnimationSpeed = 2000
        Me.PowerCPU.Name = "PowerCPU"
        Me.PowerCPU.OuterColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.PowerCPU.OuterMargin = -25
        Me.PowerCPU.OuterWidth = 25
        Me.PowerCPU.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PowerCPU.ProgressWidth = 8
        Me.PowerCPU.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.PowerCPU.Size = New System.Drawing.Size(60, 60)
        Me.PowerCPU.StartAngle = 90
        Me.PowerCPU.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.PowerCPU.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.PowerCPU.SubscriptText = ""
        Me.PowerCPU.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.PowerCPU.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.PowerCPU.SuperscriptText = ""
        Me.PowerCPU.TabIndex = 1
        Me.PowerCPU.Text = "-"
        Me.PowerCPU.TextMargin = New System.Windows.Forms.Padding(0)
        Me.PowerCPU.Value = 100
        '
        'PowerGPU
        '
        Me.PowerGPU.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.PowerGPU.AnimationSpeed = 300
        Me.PowerGPU.BackColor = System.Drawing.Color.Transparent
        Me.PowerGPU.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PowerGPU.ForeColor = System.Drawing.Color.White
        Me.PowerGPU.InnerColor = System.Drawing.Color.Transparent
        Me.PowerGPU.InnerMargin = 2
        Me.PowerGPU.InnerWidth = -1
        Me.PowerGPU.Location = New System.Drawing.Point(206, 311)
        Me.PowerGPU.MarqueeAnimationSpeed = 2000
        Me.PowerGPU.Name = "PowerGPU"
        Me.PowerGPU.OuterColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.PowerGPU.OuterMargin = -25
        Me.PowerGPU.OuterWidth = 25
        Me.PowerGPU.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PowerGPU.ProgressWidth = 8
        Me.PowerGPU.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.PowerGPU.Size = New System.Drawing.Size(60, 60)
        Me.PowerGPU.StartAngle = 90
        Me.PowerGPU.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.PowerGPU.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.PowerGPU.SubscriptText = ""
        Me.PowerGPU.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.PowerGPU.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.PowerGPU.SuperscriptText = ""
        Me.PowerGPU.TabIndex = 2
        Me.PowerGPU.Text = "-"
        Me.PowerGPU.TextMargin = New System.Windows.Forms.Padding(0)
        Me.PowerGPU.Value = 100
        '
        'CaricoGPU
        '
        Me.CaricoGPU.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CaricoGPU.AnimationSpeed = 300
        Me.CaricoGPU.BackColor = System.Drawing.Color.Transparent
        Me.CaricoGPU.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CaricoGPU.ForeColor = System.Drawing.Color.White
        Me.CaricoGPU.InnerColor = System.Drawing.Color.Transparent
        Me.CaricoGPU.InnerMargin = 2
        Me.CaricoGPU.InnerWidth = -1
        Me.CaricoGPU.Location = New System.Drawing.Point(13, 311)
        Me.CaricoGPU.MarqueeAnimationSpeed = 2000
        Me.CaricoGPU.Name = "CaricoGPU"
        Me.CaricoGPU.OuterColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.CaricoGPU.OuterMargin = -25
        Me.CaricoGPU.OuterWidth = 25
        Me.CaricoGPU.ProgressColor = System.Drawing.Color.Fuchsia
        Me.CaricoGPU.ProgressWidth = 8
        Me.CaricoGPU.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.CaricoGPU.Size = New System.Drawing.Size(60, 60)
        Me.CaricoGPU.StartAngle = 90
        Me.CaricoGPU.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CaricoGPU.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CaricoGPU.SubscriptText = ""
        Me.CaricoGPU.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CaricoGPU.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CaricoGPU.SuperscriptText = ""
        Me.CaricoGPU.TabIndex = 3
        Me.CaricoGPU.Text = "-"
        Me.CaricoGPU.TextMargin = New System.Windows.Forms.Padding(0)
        Me.CaricoGPU.Value = 100
        '
        'CaricoRAM
        '
        Me.CaricoRAM.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CaricoRAM.AnimationSpeed = 300
        Me.CaricoRAM.BackColor = System.Drawing.Color.Transparent
        Me.CaricoRAM.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CaricoRAM.ForeColor = System.Drawing.Color.White
        Me.CaricoRAM.InnerColor = System.Drawing.Color.Transparent
        Me.CaricoRAM.InnerMargin = 2
        Me.CaricoRAM.InnerWidth = -1
        Me.CaricoRAM.Location = New System.Drawing.Point(13, 468)
        Me.CaricoRAM.MarqueeAnimationSpeed = 2000
        Me.CaricoRAM.Name = "CaricoRAM"
        Me.CaricoRAM.OuterColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.CaricoRAM.OuterMargin = -25
        Me.CaricoRAM.OuterWidth = 25
        Me.CaricoRAM.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CaricoRAM.ProgressWidth = 8
        Me.CaricoRAM.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.CaricoRAM.Size = New System.Drawing.Size(60, 60)
        Me.CaricoRAM.StartAngle = 90
        Me.CaricoRAM.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CaricoRAM.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CaricoRAM.SubscriptText = ""
        Me.CaricoRAM.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CaricoRAM.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CaricoRAM.SuperscriptText = ""
        Me.CaricoRAM.TabIndex = 4
        Me.CaricoRAM.Text = "-"
        Me.CaricoRAM.TextMargin = New System.Windows.Forms.Padding(0)
        Me.CaricoRAM.Value = 100
        '
        'NomeCPU
        '
        Me.NomeCPU.AutoEllipsis = True
        Me.NomeCPU.BackColor = System.Drawing.Color.Transparent
        Me.NomeCPU.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeCPU.ForeColor = System.Drawing.Color.White
        Me.NomeCPU.Location = New System.Drawing.Point(8, 23)
        Me.NomeCPU.Name = "NomeCPU"
        Me.NomeCPU.Size = New System.Drawing.Size(229, 20)
        Me.NomeCPU.TabIndex = 5
        Me.NomeCPU.Text = "N/A"
        Me.NomeCPU.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NomeGPU
        '
        Me.NomeGPU.AutoEllipsis = True
        Me.NomeGPU.BackColor = System.Drawing.Color.Transparent
        Me.NomeGPU.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeGPU.ForeColor = System.Drawing.Color.White
        Me.NomeGPU.Location = New System.Drawing.Point(8, 219)
        Me.NomeGPU.Name = "NomeGPU"
        Me.NomeGPU.Size = New System.Drawing.Size(229, 20)
        Me.NomeGPU.TabIndex = 6
        Me.NomeGPU.Text = "N/A"
        Me.NomeGPU.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.ArduCenter.My.Resources.Resources.IconaHardware_AMD_GPU
        Me.PictureBox1.Location = New System.Drawing.Point(237, 212)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 33)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.ArduCenter.My.Resources.Resources.IconaHardware_AMD_CPU
        Me.PictureBox2.Location = New System.Drawing.Point(236, 18)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(37, 33)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.ArduCenter.My.Resources.Resources.IconaHardware_RAM
        Me.PictureBox3.Location = New System.Drawing.Point(205, 436)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(69, 28)
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'LaFreqCPU
        '
        Me.LaFreqCPU.BackColor = System.Drawing.Color.Transparent
        Me.LaFreqCPU.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaFreqCPU.ForeColor = System.Drawing.Color.White
        Me.LaFreqCPU.Location = New System.Drawing.Point(107, 65)
        Me.LaFreqCPU.Name = "LaFreqCPU"
        Me.LaFreqCPU.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LaFreqCPU.Size = New System.Drawing.Size(165, 18)
        Me.LaFreqCPU.TabIndex = 17
        Me.LaFreqCPU.Text = "N/A MHz"
        Me.LaFreqCPU.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LaFreqGPU
        '
        Me.LaFreqGPU.BackColor = System.Drawing.Color.Transparent
        Me.LaFreqGPU.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaFreqGPU.ForeColor = System.Drawing.Color.White
        Me.LaFreqGPU.Location = New System.Drawing.Point(110, 259)
        Me.LaFreqGPU.Name = "LaFreqGPU"
        Me.LaFreqGPU.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LaFreqGPU.Size = New System.Drawing.Size(165, 18)
        Me.LaFreqGPU.TabIndex = 21
        Me.LaFreqGPU.Text = "N/A MHz"
        Me.LaFreqGPU.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LaFanGPU
        '
        Me.LaFanGPU.BackColor = System.Drawing.Color.Transparent
        Me.LaFanGPU.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaFanGPU.ForeColor = System.Drawing.Color.White
        Me.LaFanGPU.Location = New System.Drawing.Point(149, 390)
        Me.LaFanGPU.Name = "LaFanGPU"
        Me.LaFanGPU.Size = New System.Drawing.Size(125, 18)
        Me.LaFanGPU.TabIndex = 23
        Me.LaFanGPU.Text = "N/A %"
        Me.LaFanGPU.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LaMemoryGPU
        '
        Me.LaMemoryGPU.BackColor = System.Drawing.Color.Transparent
        Me.LaMemoryGPU.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaMemoryGPU.ForeColor = System.Drawing.Color.White
        Me.LaMemoryGPU.Location = New System.Drawing.Point(9, 390)
        Me.LaMemoryGPU.Name = "LaMemoryGPU"
        Me.LaMemoryGPU.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LaMemoryGPU.Size = New System.Drawing.Size(130, 18)
        Me.LaMemoryGPU.TabIndex = 24
        Me.LaMemoryGPU.Text = "N/A %"
        Me.LaMemoryGPU.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'InHrdware
        '
        Me.InHrdware.AutoEllipsis = True
        Me.InHrdware.BackColor = System.Drawing.Color.Transparent
        Me.InHrdware.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InHrdware.ForeColor = System.Drawing.Color.White
        Me.InHrdware.Location = New System.Drawing.Point(10, 439)
        Me.InHrdware.Name = "InHrdware"
        Me.InHrdware.Size = New System.Drawing.Size(189, 20)
        Me.InHrdware.TabIndex = 26
        Me.InHrdware.Text = "Memoria RAM"
        Me.InHrdware.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LaMemoryUsataRAM
        '
        Me.LaMemoryUsataRAM.BackColor = System.Drawing.Color.Transparent
        Me.LaMemoryUsataRAM.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaMemoryUsataRAM.ForeColor = System.Drawing.Color.White
        Me.LaMemoryUsataRAM.Location = New System.Drawing.Point(189, 476)
        Me.LaMemoryUsataRAM.Name = "LaMemoryUsataRAM"
        Me.LaMemoryUsataRAM.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LaMemoryUsataRAM.Size = New System.Drawing.Size(83, 18)
        Me.LaMemoryUsataRAM.TabIndex = 27
        Me.LaMemoryUsataRAM.Text = "N/A GB"
        Me.LaMemoryUsataRAM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LaTotRAM
        '
        Me.LaTotRAM.BackColor = System.Drawing.Color.Transparent
        Me.LaTotRAM.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaTotRAM.ForeColor = System.Drawing.Color.White
        Me.LaTotRAM.Location = New System.Drawing.Point(190, 504)
        Me.LaTotRAM.Name = "LaTotRAM"
        Me.LaTotRAM.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LaTotRAM.Size = New System.Drawing.Size(80, 18)
        Me.LaTotRAM.TabIndex = 28
        Me.LaTotRAM.Text = "N/A GB"
        Me.LaTotRAM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TempCPU
        '
        Me.TempCPU.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.TempCPU.AnimationSpeed = 300
        Me.TempCPU.BackColor = System.Drawing.Color.Transparent
        Me.TempCPU.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TempCPU.ForeColor = System.Drawing.Color.White
        Me.TempCPU.InnerColor = System.Drawing.Color.Transparent
        Me.TempCPU.InnerMargin = 2
        Me.TempCPU.InnerWidth = -1
        Me.TempCPU.Location = New System.Drawing.Point(111, 117)
        Me.TempCPU.MarqueeAnimationSpeed = 2000
        Me.TempCPU.Name = "TempCPU"
        Me.TempCPU.OuterColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.TempCPU.OuterMargin = -25
        Me.TempCPU.OuterWidth = 25
        Me.TempCPU.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TempCPU.ProgressWidth = 8
        Me.TempCPU.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.TempCPU.Size = New System.Drawing.Size(60, 60)
        Me.TempCPU.StartAngle = 90
        Me.TempCPU.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.TempCPU.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.TempCPU.SubscriptText = ""
        Me.TempCPU.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.TempCPU.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.TempCPU.SuperscriptText = ""
        Me.TempCPU.TabIndex = 29
        Me.TempCPU.Text = "-"
        Me.TempCPU.TextMargin = New System.Windows.Forms.Padding(0)
        Me.TempCPU.Value = 100
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 18)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "CPU Clock"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(67, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 18)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "%"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(163, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 18)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "°C"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(257, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 18)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "W"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(14, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 18)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Carico"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(112, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 18)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Temp."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(206, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 18)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Power"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TempGPU
        '
        Me.TempGPU.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.TempGPU.AnimationSpeed = 300
        Me.TempGPU.BackColor = System.Drawing.Color.Transparent
        Me.TempGPU.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TempGPU.ForeColor = System.Drawing.Color.White
        Me.TempGPU.InnerColor = System.Drawing.Color.Transparent
        Me.TempGPU.InnerMargin = 2
        Me.TempGPU.InnerWidth = -1
        Me.TempGPU.Location = New System.Drawing.Point(111, 311)
        Me.TempGPU.MarqueeAnimationSpeed = 2000
        Me.TempGPU.Name = "TempGPU"
        Me.TempGPU.OuterColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.TempGPU.OuterMargin = -25
        Me.TempGPU.OuterWidth = 25
        Me.TempGPU.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TempGPU.ProgressWidth = 8
        Me.TempGPU.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.TempGPU.Size = New System.Drawing.Size(60, 60)
        Me.TempGPU.StartAngle = 90
        Me.TempGPU.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.TempGPU.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.TempGPU.SubscriptText = ""
        Me.TempGPU.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.TempGPU.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.TempGPU.SuperscriptText = ""
        Me.TempGPU.TabIndex = 37
        Me.TempGPU.Text = "-"
        Me.TempGPU.TextMargin = New System.Windows.Forms.Padding(0)
        Me.TempGPU.Value = 100
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(206, 290)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 18)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Power"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(112, 290)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 18)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Temp."
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(14, 290)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 18)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Carico"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(9, 259)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 18)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "GPU Clock"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(257, 363)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(24, 18)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "W"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(163, 363)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 18)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "°C"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(67, 363)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(27, 18)
        Me.Label14.TabIndex = 42
        Me.Label14.Text = "%"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(104, 476)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 18)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "Usati"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(103, 504)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 18)
        Me.Label16.TabIndex = 46
        Me.Label16.Text = "Totale"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(68, 511)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(27, 18)
        Me.Label17.TabIndex = 47
        Me.Label17.Text = "%"
        '
        'P_HardwareMonitor_PC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BackgroundImage = Global.ArduCenter.My.Resources.Resources.GUI_HardwareMonitor_PC_1_1_1
        Me.ClientSize = New System.Drawing.Size(280, 546)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PowerGPU)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TempGPU)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TempCPU)
        Me.Controls.Add(Me.LaTotRAM)
        Me.Controls.Add(Me.LaMemoryUsataRAM)
        Me.Controls.Add(Me.InHrdware)
        Me.Controls.Add(Me.LaMemoryGPU)
        Me.Controls.Add(Me.LaFanGPU)
        Me.Controls.Add(Me.LaFreqGPU)
        Me.Controls.Add(Me.LaFreqCPU)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.NomeGPU)
        Me.Controls.Add(Me.NomeCPU)
        Me.Controls.Add(Me.CaricoRAM)
        Me.Controls.Add(Me.CaricoGPU)
        Me.Controls.Add(Me.PowerCPU)
        Me.Controls.Add(Me.CaricoCPU)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "P_HardwareMonitor_PC"
        Me.Text = "F_MonitorHardware_PC"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CaricoCPU As CircularProgressBar.CircularProgressBar
    Friend WithEvents PowerCPU As CircularProgressBar.CircularProgressBar
    Friend WithEvents PowerGPU As CircularProgressBar.CircularProgressBar
    Friend WithEvents CaricoGPU As CircularProgressBar.CircularProgressBar
    Friend WithEvents CaricoRAM As CircularProgressBar.CircularProgressBar
    Friend WithEvents NomeCPU As Label
    Friend WithEvents NomeGPU As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents LaFreqCPU As Label
    Friend WithEvents LaFreqGPU As Label
    Friend WithEvents LaFanGPU As Label
    Friend WithEvents LaMemoryGPU As Label
    Friend WithEvents InHrdware As Label
    Friend WithEvents LaMemoryUsataRAM As Label
    Friend WithEvents LaTotRAM As Label
    Friend WithEvents TempCPU As CircularProgressBar.CircularProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TempGPU As CircularProgressBar.CircularProgressBar
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
End Class
