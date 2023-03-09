<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_MonitorHardware_PC
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
        Me.BarLoadCore_1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.LaFreqCPU = New System.Windows.Forms.Label()
        Me.LaTempCPU = New System.Windows.Forms.Label()
        Me.LaTempCPU_CCD = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LaFreqGPU = New System.Windows.Forms.Label()
        Me.LaTempGPU = New System.Windows.Forms.Label()
        Me.LaFanGPU = New System.Windows.Forms.Label()
        Me.LaMemoryGPU = New System.Windows.Forms.Label()
        Me.LaTempHotSpotGPU = New System.Windows.Forms.Label()
        Me.InHrdware = New System.Windows.Forms.Label()
        Me.LaMemoryUsataRAM = New System.Windows.Forms.Label()
        Me.LaTotRAM = New System.Windows.Forms.Label()
        Me.BarLoadCore_1_0 = New System.Windows.Forms.PictureBox()
        Me.BarPowerCore_1_0 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.BarLoadCore_2_0 = New System.Windows.Forms.PictureBox()
        Me.BarPowerCore_2_0 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.BarPowerCore_3_0 = New System.Windows.Forms.PictureBox()
        Me.BarLoadCore_3_0 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.BarPowerCore_4_0 = New System.Windows.Forms.PictureBox()
        Me.BarLoadCore_4_0 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.BarPowerCore_8_0 = New System.Windows.Forms.PictureBox()
        Me.BarLoadCore_8_0 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.BarPowerCore_7_0 = New System.Windows.Forms.PictureBox()
        Me.BarLoadCore_7_0 = New System.Windows.Forms.PictureBox()
        Me.PictureBox17 = New System.Windows.Forms.PictureBox()
        Me.PictureBox18 = New System.Windows.Forms.PictureBox()
        Me.BarPowerCore_6_0 = New System.Windows.Forms.PictureBox()
        Me.BarLoadCore_6_0 = New System.Windows.Forms.PictureBox()
        Me.BarLoadCore_5_0 = New System.Windows.Forms.PictureBox()
        Me.PictureBox22 = New System.Windows.Forms.PictureBox()
        Me.PictureBox23 = New System.Windows.Forms.PictureBox()
        Me.BarPowerCore_5_0 = New System.Windows.Forms.PictureBox()
        Me.PictureBox25 = New System.Windows.Forms.PictureBox()
        Me.PictureBox26 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarLoadCore_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarLoadCore_1_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarPowerCore_1_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarLoadCore_2_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarPowerCore_2_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarPowerCore_3_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarLoadCore_3_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarPowerCore_4_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarLoadCore_4_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarPowerCore_8_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarLoadCore_8_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarPowerCore_7_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarLoadCore_7_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarPowerCore_6_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarLoadCore_6_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarLoadCore_5_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarPowerCore_5_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox26, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CaricoCPU.Location = New System.Drawing.Point(9, 72)
        Me.CaricoCPU.MarqueeAnimationSpeed = 2000
        Me.CaricoCPU.Name = "CaricoCPU"
        Me.CaricoCPU.OuterColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.CaricoCPU.OuterMargin = -25
        Me.CaricoCPU.OuterWidth = 25
        Me.CaricoCPU.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.CaricoCPU.ProgressWidth = 8
        Me.CaricoCPU.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.CaricoCPU.Size = New System.Drawing.Size(65, 65)
        Me.CaricoCPU.StartAngle = 90
        Me.CaricoCPU.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CaricoCPU.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CaricoCPU.SubscriptText = ""
        Me.CaricoCPU.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CaricoCPU.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CaricoCPU.SuperscriptText = ""
        Me.CaricoCPU.TabIndex = 0
        Me.CaricoCPU.Text = "100%"
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
        Me.PowerCPU.Location = New System.Drawing.Point(9, 146)
        Me.PowerCPU.MarqueeAnimationSpeed = 2000
        Me.PowerCPU.Name = "PowerCPU"
        Me.PowerCPU.OuterColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.PowerCPU.OuterMargin = -25
        Me.PowerCPU.OuterWidth = 25
        Me.PowerCPU.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PowerCPU.ProgressWidth = 8
        Me.PowerCPU.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.PowerCPU.Size = New System.Drawing.Size(65, 65)
        Me.PowerCPU.StartAngle = 90
        Me.PowerCPU.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.PowerCPU.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.PowerCPU.SubscriptText = ""
        Me.PowerCPU.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.PowerCPU.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.PowerCPU.SuperscriptText = ""
        Me.PowerCPU.TabIndex = 1
        Me.PowerCPU.Text = "100W"
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
        Me.PowerGPU.Location = New System.Drawing.Point(10, 350)
        Me.PowerGPU.MarqueeAnimationSpeed = 2000
        Me.PowerGPU.Name = "PowerGPU"
        Me.PowerGPU.OuterColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.PowerGPU.OuterMargin = -25
        Me.PowerGPU.OuterWidth = 25
        Me.PowerGPU.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PowerGPU.ProgressWidth = 8
        Me.PowerGPU.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.PowerGPU.Size = New System.Drawing.Size(65, 65)
        Me.PowerGPU.StartAngle = 90
        Me.PowerGPU.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.PowerGPU.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.PowerGPU.SubscriptText = ""
        Me.PowerGPU.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.PowerGPU.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.PowerGPU.SuperscriptText = ""
        Me.PowerGPU.TabIndex = 2
        Me.PowerGPU.Text = "100W"
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
        Me.CaricoGPU.Location = New System.Drawing.Point(9, 282)
        Me.CaricoGPU.MarqueeAnimationSpeed = 2000
        Me.CaricoGPU.Name = "CaricoGPU"
        Me.CaricoGPU.OuterColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.CaricoGPU.OuterMargin = -25
        Me.CaricoGPU.OuterWidth = 25
        Me.CaricoGPU.ProgressColor = System.Drawing.Color.Fuchsia
        Me.CaricoGPU.ProgressWidth = 8
        Me.CaricoGPU.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.CaricoGPU.Size = New System.Drawing.Size(65, 65)
        Me.CaricoGPU.StartAngle = 90
        Me.CaricoGPU.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CaricoGPU.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CaricoGPU.SubscriptText = ""
        Me.CaricoGPU.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CaricoGPU.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CaricoGPU.SuperscriptText = ""
        Me.CaricoGPU.TabIndex = 3
        Me.CaricoGPU.Text = "100%"
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
        Me.CaricoRAM.Location = New System.Drawing.Point(9, 466)
        Me.CaricoRAM.MarqueeAnimationSpeed = 2000
        Me.CaricoRAM.Name = "CaricoRAM"
        Me.CaricoRAM.OuterColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.CaricoRAM.OuterMargin = -25
        Me.CaricoRAM.OuterWidth = 25
        Me.CaricoRAM.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CaricoRAM.ProgressWidth = 8
        Me.CaricoRAM.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.CaricoRAM.Size = New System.Drawing.Size(65, 65)
        Me.CaricoRAM.StartAngle = 90
        Me.CaricoRAM.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CaricoRAM.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CaricoRAM.SubscriptText = ""
        Me.CaricoRAM.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CaricoRAM.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CaricoRAM.SuperscriptText = ""
        Me.CaricoRAM.TabIndex = 4
        Me.CaricoRAM.Text = "100%"
        Me.CaricoRAM.TextMargin = New System.Windows.Forms.Padding(0)
        Me.CaricoRAM.Value = 100
        '
        'NomeCPU
        '
        Me.NomeCPU.AutoSize = True
        Me.NomeCPU.BackColor = System.Drawing.Color.Transparent
        Me.NomeCPU.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeCPU.ForeColor = System.Drawing.Color.White
        Me.NomeCPU.Location = New System.Drawing.Point(8, 26)
        Me.NomeCPU.Name = "NomeCPU"
        Me.NomeCPU.Size = New System.Drawing.Size(212, 20)
        Me.NomeCPU.TabIndex = 5
        Me.NomeCPU.Text = "AMD Ryzen 5 3600XT"
        '
        'NomeGPU
        '
        Me.NomeGPU.AutoSize = True
        Me.NomeGPU.BackColor = System.Drawing.Color.Transparent
        Me.NomeGPU.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeGPU.ForeColor = System.Drawing.Color.White
        Me.NomeGPU.Location = New System.Drawing.Point(11, 239)
        Me.NomeGPU.Name = "NomeGPU"
        Me.NomeGPU.Size = New System.Drawing.Size(197, 20)
        Me.NomeGPU.TabIndex = 6
        Me.NomeGPU.Text = "Radeon RX 5500 XT"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.ArduCenter.My.Resources.Resources.IconaHardware_AMD_GPU
        Me.PictureBox1.Location = New System.Drawing.Point(237, 233)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 33)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.ArduCenter.My.Resources.Resources.IconaHardware_AMD_CPU
        Me.PictureBox2.Location = New System.Drawing.Point(237, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(37, 33)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.ArduCenter.My.Resources.Resources.IconaHardware_RAM
        Me.PictureBox3.Location = New System.Drawing.Point(205, 440)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(69, 28)
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'BarLoadCore_1
        '
        Me.BarLoadCore_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.BarLoadCore_1.Location = New System.Drawing.Point(79, 173)
        Me.BarLoadCore_1.Name = "BarLoadCore_1"
        Me.BarLoadCore_1.Size = New System.Drawing.Size(10, 38)
        Me.BarLoadCore_1.TabIndex = 10
        Me.BarLoadCore_1.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.PictureBox5.Location = New System.Drawing.Point(104, 173)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(10, 38)
        Me.PictureBox5.TabIndex = 11
        Me.PictureBox5.TabStop = False
        '
        'LaFreqCPU
        '
        Me.LaFreqCPU.AutoSize = True
        Me.LaFreqCPU.BackColor = System.Drawing.Color.Transparent
        Me.LaFreqCPU.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaFreqCPU.ForeColor = System.Drawing.Color.White
        Me.LaFreqCPU.Location = New System.Drawing.Point(75, 75)
        Me.LaFreqCPU.Name = "LaFreqCPU"
        Me.LaFreqCPU.Size = New System.Drawing.Size(204, 18)
        Me.LaFreqCPU.TabIndex = 17
        Me.LaFreqCPU.Text = "CPU Clock      4500 MHz"
        '
        'LaTempCPU
        '
        Me.LaTempCPU.AutoSize = True
        Me.LaTempCPU.BackColor = System.Drawing.Color.Transparent
        Me.LaTempCPU.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaTempCPU.ForeColor = System.Drawing.Color.White
        Me.LaTempCPU.Location = New System.Drawing.Point(75, 101)
        Me.LaTempCPU.Name = "LaTempCPU"
        Me.LaTempCPU.Size = New System.Drawing.Size(206, 18)
        Me.LaTempCPU.TabIndex = 18
        Me.LaTempCPU.Text = "CPU Temp           100 °C"
        '
        'LaTempCPU_CCD
        '
        Me.LaTempCPU_CCD.AutoSize = True
        Me.LaTempCPU_CCD.BackColor = System.Drawing.Color.Transparent
        Me.LaTempCPU_CCD.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaTempCPU_CCD.ForeColor = System.Drawing.Color.White
        Me.LaTempCPU_CCD.Location = New System.Drawing.Point(75, 126)
        Me.LaTempCPU_CCD.Name = "LaTempCPU_CCD"
        Me.LaTempCPU_CCD.Size = New System.Drawing.Size(204, 18)
        Me.LaTempCPU_CCD.TabIndex = 19
        Me.LaTempCPU_CCD.Text = "CPU CCD             100 °C"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(81, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(188, 16)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "C1 C2 C3 C4 C5 C6 C7 C8"
        '
        'LaFreqGPU
        '
        Me.LaFreqGPU.AutoSize = True
        Me.LaFreqGPU.BackColor = System.Drawing.Color.Transparent
        Me.LaFreqGPU.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaFreqGPU.ForeColor = System.Drawing.Color.White
        Me.LaFreqGPU.Location = New System.Drawing.Point(75, 286)
        Me.LaFreqGPU.Name = "LaFreqGPU"
        Me.LaFreqGPU.Size = New System.Drawing.Size(205, 18)
        Me.LaFreqGPU.TabIndex = 21
        Me.LaFreqGPU.Text = "GPU Clock      1730 MHz"
        '
        'LaTempGPU
        '
        Me.LaTempGPU.AutoSize = True
        Me.LaTempGPU.BackColor = System.Drawing.Color.Transparent
        Me.LaTempGPU.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaTempGPU.ForeColor = System.Drawing.Color.White
        Me.LaTempGPU.Location = New System.Drawing.Point(75, 313)
        Me.LaTempGPU.Name = "LaTempGPU"
        Me.LaTempGPU.Size = New System.Drawing.Size(207, 18)
        Me.LaTempGPU.TabIndex = 22
        Me.LaTempGPU.Text = "GPU Temp           100 °C"
        '
        'LaFanGPU
        '
        Me.LaFanGPU.AutoSize = True
        Me.LaFanGPU.BackColor = System.Drawing.Color.Transparent
        Me.LaFanGPU.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaFanGPU.ForeColor = System.Drawing.Color.White
        Me.LaFanGPU.Location = New System.Drawing.Point(75, 337)
        Me.LaFanGPU.Name = "LaFanGPU"
        Me.LaFanGPU.Size = New System.Drawing.Size(205, 18)
        Me.LaFanGPU.TabIndex = 23
        Me.LaFanGPU.Text = "GPU Fan              100 %"
        '
        'LaMemoryGPU
        '
        Me.LaMemoryGPU.AutoSize = True
        Me.LaMemoryGPU.BackColor = System.Drawing.Color.Transparent
        Me.LaMemoryGPU.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaMemoryGPU.ForeColor = System.Drawing.Color.White
        Me.LaMemoryGPU.Location = New System.Drawing.Point(75, 363)
        Me.LaMemoryGPU.Name = "LaMemoryGPU"
        Me.LaMemoryGPU.Size = New System.Drawing.Size(207, 18)
        Me.LaMemoryGPU.TabIndex = 24
        Me.LaMemoryGPU.Text = "GPU Memory       100 %"
        '
        'LaTempHotSpotGPU
        '
        Me.LaTempHotSpotGPU.AutoSize = True
        Me.LaTempHotSpotGPU.BackColor = System.Drawing.Color.Transparent
        Me.LaTempHotSpotGPU.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaTempHotSpotGPU.ForeColor = System.Drawing.Color.White
        Me.LaTempHotSpotGPU.Location = New System.Drawing.Point(75, 387)
        Me.LaTempHotSpotGPU.Name = "LaTempHotSpotGPU"
        Me.LaTempHotSpotGPU.Size = New System.Drawing.Size(208, 18)
        Me.LaTempHotSpotGPU.TabIndex = 25
        Me.LaTempHotSpotGPU.Text = "GPU Hot Spot      100 °C"
        '
        'InHrdware
        '
        Me.InHrdware.AutoSize = True
        Me.InHrdware.BackColor = System.Drawing.Color.Transparent
        Me.InHrdware.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InHrdware.ForeColor = System.Drawing.Color.White
        Me.InHrdware.Location = New System.Drawing.Point(12, 443)
        Me.InHrdware.Name = "InHrdware"
        Me.InHrdware.Size = New System.Drawing.Size(139, 20)
        Me.InHrdware.TabIndex = 26
        Me.InHrdware.Text = "Memoria RAM"
        '
        'LaMemoryUsataRAM
        '
        Me.LaMemoryUsataRAM.AutoSize = True
        Me.LaMemoryUsataRAM.BackColor = System.Drawing.Color.Transparent
        Me.LaMemoryUsataRAM.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaMemoryUsataRAM.ForeColor = System.Drawing.Color.White
        Me.LaMemoryUsataRAM.Location = New System.Drawing.Point(75, 475)
        Me.LaMemoryUsataRAM.Name = "LaMemoryUsataRAM"
        Me.LaMemoryUsataRAM.Size = New System.Drawing.Size(209, 18)
        Me.LaMemoryUsataRAM.TabIndex = 27
        Me.LaMemoryUsataRAM.Text = "RAM Usata            16 GB"
        '
        'LaTotRAM
        '
        Me.LaTotRAM.AutoSize = True
        Me.LaTotRAM.BackColor = System.Drawing.Color.Transparent
        Me.LaTotRAM.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaTotRAM.ForeColor = System.Drawing.Color.White
        Me.LaTotRAM.Location = New System.Drawing.Point(75, 501)
        Me.LaTotRAM.Name = "LaTotRAM"
        Me.LaTotRAM.Size = New System.Drawing.Size(207, 18)
        Me.LaTotRAM.TabIndex = 28
        Me.LaTotRAM.Text = "RAM Totale           16 GB"
        '
        'BarLoadCore_1_0
        '
        Me.BarLoadCore_1_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BarLoadCore_1_0.Location = New System.Drawing.Point(79, 173)
        Me.BarLoadCore_1_0.Name = "BarLoadCore_1_0"
        Me.BarLoadCore_1_0.Size = New System.Drawing.Size(10, 38)
        Me.BarLoadCore_1_0.TabIndex = 30
        Me.BarLoadCore_1_0.TabStop = False
        '
        'BarPowerCore_1_0
        '
        Me.BarPowerCore_1_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BarPowerCore_1_0.Location = New System.Drawing.Point(91, 173)
        Me.BarPowerCore_1_0.Name = "BarPowerCore_1_0"
        Me.BarPowerCore_1_0.Size = New System.Drawing.Size(10, 38)
        Me.BarPowerCore_1_0.TabIndex = 31
        Me.BarPowerCore_1_0.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.Color.Gold
        Me.PictureBox12.Location = New System.Drawing.Point(91, 173)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(10, 38)
        Me.PictureBox12.TabIndex = 32
        Me.PictureBox12.TabStop = False
        '
        'BarLoadCore_2_0
        '
        Me.BarLoadCore_2_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BarLoadCore_2_0.Location = New System.Drawing.Point(104, 173)
        Me.BarLoadCore_2_0.Name = "BarLoadCore_2_0"
        Me.BarLoadCore_2_0.Size = New System.Drawing.Size(10, 38)
        Me.BarLoadCore_2_0.TabIndex = 33
        Me.BarLoadCore_2_0.TabStop = False
        '
        'BarPowerCore_2_0
        '
        Me.BarPowerCore_2_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BarPowerCore_2_0.Location = New System.Drawing.Point(116, 173)
        Me.BarPowerCore_2_0.Name = "BarPowerCore_2_0"
        Me.BarPowerCore_2_0.Size = New System.Drawing.Size(10, 38)
        Me.BarPowerCore_2_0.TabIndex = 34
        Me.BarPowerCore_2_0.TabStop = False
        '
        'PictureBox13
        '
        Me.PictureBox13.BackColor = System.Drawing.Color.Gold
        Me.PictureBox13.Location = New System.Drawing.Point(116, 173)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(10, 38)
        Me.PictureBox13.TabIndex = 35
        Me.PictureBox13.TabStop = False
        '
        'BarPowerCore_3_0
        '
        Me.BarPowerCore_3_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BarPowerCore_3_0.Location = New System.Drawing.Point(141, 173)
        Me.BarPowerCore_3_0.Name = "BarPowerCore_3_0"
        Me.BarPowerCore_3_0.Size = New System.Drawing.Size(10, 38)
        Me.BarPowerCore_3_0.TabIndex = 38
        Me.BarPowerCore_3_0.TabStop = False
        '
        'BarLoadCore_3_0
        '
        Me.BarLoadCore_3_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BarLoadCore_3_0.Location = New System.Drawing.Point(129, 173)
        Me.BarLoadCore_3_0.Name = "BarLoadCore_3_0"
        Me.BarLoadCore_3_0.Size = New System.Drawing.Size(10, 38)
        Me.BarLoadCore_3_0.TabIndex = 37
        Me.BarLoadCore_3_0.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.PictureBox7.Location = New System.Drawing.Point(129, 173)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(10, 38)
        Me.PictureBox7.TabIndex = 36
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Gold
        Me.PictureBox8.Location = New System.Drawing.Point(141, 173)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(10, 38)
        Me.PictureBox8.TabIndex = 39
        Me.PictureBox8.TabStop = False
        '
        'BarPowerCore_4_0
        '
        Me.BarPowerCore_4_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BarPowerCore_4_0.Location = New System.Drawing.Point(165, 173)
        Me.BarPowerCore_4_0.Name = "BarPowerCore_4_0"
        Me.BarPowerCore_4_0.Size = New System.Drawing.Size(10, 38)
        Me.BarPowerCore_4_0.TabIndex = 42
        Me.BarPowerCore_4_0.TabStop = False
        '
        'BarLoadCore_4_0
        '
        Me.BarLoadCore_4_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BarLoadCore_4_0.Location = New System.Drawing.Point(153, 173)
        Me.BarLoadCore_4_0.Name = "BarLoadCore_4_0"
        Me.BarLoadCore_4_0.Size = New System.Drawing.Size(10, 38)
        Me.BarLoadCore_4_0.TabIndex = 41
        Me.BarLoadCore_4_0.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.PictureBox9.Location = New System.Drawing.Point(153, 173)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(10, 38)
        Me.PictureBox9.TabIndex = 40
        Me.PictureBox9.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Gold
        Me.PictureBox10.Location = New System.Drawing.Point(165, 173)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(10, 38)
        Me.PictureBox10.TabIndex = 43
        Me.PictureBox10.TabStop = False
        '
        'BarPowerCore_8_0
        '
        Me.BarPowerCore_8_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BarPowerCore_8_0.Location = New System.Drawing.Point(262, 173)
        Me.BarPowerCore_8_0.Name = "BarPowerCore_8_0"
        Me.BarPowerCore_8_0.Size = New System.Drawing.Size(10, 38)
        Me.BarPowerCore_8_0.TabIndex = 58
        Me.BarPowerCore_8_0.TabStop = False
        '
        'BarLoadCore_8_0
        '
        Me.BarLoadCore_8_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BarLoadCore_8_0.Location = New System.Drawing.Point(250, 173)
        Me.BarLoadCore_8_0.Name = "BarLoadCore_8_0"
        Me.BarLoadCore_8_0.Size = New System.Drawing.Size(10, 38)
        Me.BarLoadCore_8_0.TabIndex = 57
        Me.BarLoadCore_8_0.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.PictureBox11.Location = New System.Drawing.Point(250, 173)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(10, 38)
        Me.PictureBox11.TabIndex = 56
        Me.PictureBox11.TabStop = False
        '
        'PictureBox14
        '
        Me.PictureBox14.BackColor = System.Drawing.Color.Gold
        Me.PictureBox14.Location = New System.Drawing.Point(262, 173)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(10, 38)
        Me.PictureBox14.TabIndex = 59
        Me.PictureBox14.TabStop = False
        '
        'BarPowerCore_7_0
        '
        Me.BarPowerCore_7_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BarPowerCore_7_0.Location = New System.Drawing.Point(238, 173)
        Me.BarPowerCore_7_0.Name = "BarPowerCore_7_0"
        Me.BarPowerCore_7_0.Size = New System.Drawing.Size(10, 38)
        Me.BarPowerCore_7_0.TabIndex = 54
        Me.BarPowerCore_7_0.TabStop = False
        '
        'BarLoadCore_7_0
        '
        Me.BarLoadCore_7_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BarLoadCore_7_0.Location = New System.Drawing.Point(226, 173)
        Me.BarLoadCore_7_0.Name = "BarLoadCore_7_0"
        Me.BarLoadCore_7_0.Size = New System.Drawing.Size(10, 38)
        Me.BarLoadCore_7_0.TabIndex = 53
        Me.BarLoadCore_7_0.TabStop = False
        '
        'PictureBox17
        '
        Me.PictureBox17.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.PictureBox17.Location = New System.Drawing.Point(226, 173)
        Me.PictureBox17.Name = "PictureBox17"
        Me.PictureBox17.Size = New System.Drawing.Size(10, 38)
        Me.PictureBox17.TabIndex = 52
        Me.PictureBox17.TabStop = False
        '
        'PictureBox18
        '
        Me.PictureBox18.BackColor = System.Drawing.Color.Gold
        Me.PictureBox18.Location = New System.Drawing.Point(238, 173)
        Me.PictureBox18.Name = "PictureBox18"
        Me.PictureBox18.Size = New System.Drawing.Size(10, 38)
        Me.PictureBox18.TabIndex = 55
        Me.PictureBox18.TabStop = False
        '
        'BarPowerCore_6_0
        '
        Me.BarPowerCore_6_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BarPowerCore_6_0.Location = New System.Drawing.Point(213, 173)
        Me.BarPowerCore_6_0.Name = "BarPowerCore_6_0"
        Me.BarPowerCore_6_0.Size = New System.Drawing.Size(10, 38)
        Me.BarPowerCore_6_0.TabIndex = 50
        Me.BarPowerCore_6_0.TabStop = False
        '
        'BarLoadCore_6_0
        '
        Me.BarLoadCore_6_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BarLoadCore_6_0.Location = New System.Drawing.Point(201, 173)
        Me.BarLoadCore_6_0.Name = "BarLoadCore_6_0"
        Me.BarLoadCore_6_0.Size = New System.Drawing.Size(10, 38)
        Me.BarLoadCore_6_0.TabIndex = 49
        Me.BarLoadCore_6_0.TabStop = False
        '
        'BarLoadCore_5_0
        '
        Me.BarLoadCore_5_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BarLoadCore_5_0.Location = New System.Drawing.Point(177, 173)
        Me.BarLoadCore_5_0.Name = "BarLoadCore_5_0"
        Me.BarLoadCore_5_0.Size = New System.Drawing.Size(10, 38)
        Me.BarLoadCore_5_0.TabIndex = 46
        Me.BarLoadCore_5_0.TabStop = False
        '
        'PictureBox22
        '
        Me.PictureBox22.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.PictureBox22.Location = New System.Drawing.Point(201, 173)
        Me.PictureBox22.Name = "PictureBox22"
        Me.PictureBox22.Size = New System.Drawing.Size(10, 38)
        Me.PictureBox22.TabIndex = 45
        Me.PictureBox22.TabStop = False
        '
        'PictureBox23
        '
        Me.PictureBox23.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.PictureBox23.Location = New System.Drawing.Point(177, 173)
        Me.PictureBox23.Name = "PictureBox23"
        Me.PictureBox23.Size = New System.Drawing.Size(10, 38)
        Me.PictureBox23.TabIndex = 44
        Me.PictureBox23.TabStop = False
        '
        'BarPowerCore_5_0
        '
        Me.BarPowerCore_5_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BarPowerCore_5_0.Location = New System.Drawing.Point(189, 173)
        Me.BarPowerCore_5_0.Name = "BarPowerCore_5_0"
        Me.BarPowerCore_5_0.Size = New System.Drawing.Size(10, 38)
        Me.BarPowerCore_5_0.TabIndex = 47
        Me.BarPowerCore_5_0.TabStop = False
        '
        'PictureBox25
        '
        Me.PictureBox25.BackColor = System.Drawing.Color.Gold
        Me.PictureBox25.Location = New System.Drawing.Point(189, 173)
        Me.PictureBox25.Name = "PictureBox25"
        Me.PictureBox25.Size = New System.Drawing.Size(10, 38)
        Me.PictureBox25.TabIndex = 48
        Me.PictureBox25.TabStop = False
        '
        'PictureBox26
        '
        Me.PictureBox26.BackColor = System.Drawing.Color.Gold
        Me.PictureBox26.Location = New System.Drawing.Point(213, 173)
        Me.PictureBox26.Name = "PictureBox26"
        Me.PictureBox26.Size = New System.Drawing.Size(10, 38)
        Me.PictureBox26.TabIndex = 51
        Me.PictureBox26.TabStop = False
        '
        'F_MonitorHardware_PC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BackgroundImage = Global.ArduCenter.My.Resources.Resources.GUI_HardwareMonitor_PC
        Me.ClientSize = New System.Drawing.Size(280, 546)
        Me.Controls.Add(Me.BarPowerCore_8_0)
        Me.Controls.Add(Me.BarLoadCore_8_0)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox14)
        Me.Controls.Add(Me.BarPowerCore_7_0)
        Me.Controls.Add(Me.BarLoadCore_7_0)
        Me.Controls.Add(Me.PictureBox17)
        Me.Controls.Add(Me.PictureBox18)
        Me.Controls.Add(Me.BarPowerCore_6_0)
        Me.Controls.Add(Me.BarLoadCore_6_0)
        Me.Controls.Add(Me.BarLoadCore_5_0)
        Me.Controls.Add(Me.PictureBox22)
        Me.Controls.Add(Me.PictureBox23)
        Me.Controls.Add(Me.BarPowerCore_5_0)
        Me.Controls.Add(Me.PictureBox25)
        Me.Controls.Add(Me.PictureBox26)
        Me.Controls.Add(Me.BarPowerCore_4_0)
        Me.Controls.Add(Me.BarLoadCore_4_0)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.BarPowerCore_3_0)
        Me.Controls.Add(Me.BarLoadCore_3_0)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.BarPowerCore_2_0)
        Me.Controls.Add(Me.BarLoadCore_2_0)
        Me.Controls.Add(Me.BarLoadCore_1_0)
        Me.Controls.Add(Me.LaTotRAM)
        Me.Controls.Add(Me.LaMemoryUsataRAM)
        Me.Controls.Add(Me.InHrdware)
        Me.Controls.Add(Me.LaTempHotSpotGPU)
        Me.Controls.Add(Me.LaMemoryGPU)
        Me.Controls.Add(Me.LaFanGPU)
        Me.Controls.Add(Me.LaTempGPU)
        Me.Controls.Add(Me.LaFreqGPU)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LaTempCPU_CCD)
        Me.Controls.Add(Me.LaTempCPU)
        Me.Controls.Add(Me.LaFreqCPU)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.BarLoadCore_1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.NomeGPU)
        Me.Controls.Add(Me.NomeCPU)
        Me.Controls.Add(Me.CaricoRAM)
        Me.Controls.Add(Me.CaricoGPU)
        Me.Controls.Add(Me.PowerGPU)
        Me.Controls.Add(Me.PowerCPU)
        Me.Controls.Add(Me.CaricoCPU)
        Me.Controls.Add(Me.BarPowerCore_1_0)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.PictureBox13)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_MonitorHardware_PC"
        Me.Text = "F_MonitorHardware_PC"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarLoadCore_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarLoadCore_1_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarPowerCore_1_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarLoadCore_2_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarPowerCore_2_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarPowerCore_3_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarLoadCore_3_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarPowerCore_4_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarLoadCore_4_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarPowerCore_8_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarLoadCore_8_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarPowerCore_7_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarLoadCore_7_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarPowerCore_6_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarLoadCore_6_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarLoadCore_5_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarPowerCore_5_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox26, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents BarLoadCore_1 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents LaFreqCPU As Label
    Friend WithEvents LaTempCPU As Label
    Friend WithEvents LaTempCPU_CCD As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LaFreqGPU As Label
    Friend WithEvents LaTempGPU As Label
    Friend WithEvents LaFanGPU As Label
    Friend WithEvents LaMemoryGPU As Label
    Friend WithEvents LaTempHotSpotGPU As Label
    Friend WithEvents InHrdware As Label
    Friend WithEvents LaMemoryUsataRAM As Label
    Friend WithEvents LaTotRAM As Label
    Friend WithEvents BarLoadCore_1_0 As PictureBox
    Friend WithEvents BarPowerCore_1_0 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents BarLoadCore_2_0 As PictureBox
    Friend WithEvents BarPowerCore_2_0 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents BarPowerCore_3_0 As PictureBox
    Friend WithEvents BarLoadCore_3_0 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents BarPowerCore_4_0 As PictureBox
    Friend WithEvents BarLoadCore_4_0 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents BarPowerCore_8_0 As PictureBox
    Friend WithEvents BarLoadCore_8_0 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents BarPowerCore_7_0 As PictureBox
    Friend WithEvents BarLoadCore_7_0 As PictureBox
    Friend WithEvents PictureBox17 As PictureBox
    Friend WithEvents PictureBox18 As PictureBox
    Friend WithEvents BarPowerCore_6_0 As PictureBox
    Friend WithEvents BarLoadCore_6_0 As PictureBox
    Friend WithEvents BarLoadCore_5_0 As PictureBox
    Friend WithEvents PictureBox22 As PictureBox
    Friend WithEvents PictureBox23 As PictureBox
    Friend WithEvents BarPowerCore_5_0 As PictureBox
    Friend WithEvents PictureBox25 As PictureBox
    Friend WithEvents PictureBox26 As PictureBox
End Class
