<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_HubPC_HUB
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
        Me.Btn_Fan_Info = New System.Windows.Forms.Button()
        Me.Btn_HUB_Info = New System.Windows.Forms.Button()
        Me.Btn_Altro_Info = New System.Windows.Forms.Button()
        Me.Btn_GPU_Info = New System.Windows.Forms.Button()
        Me.Btn_StriscaLED_Info = New System.Windows.Forms.Button()
        Me.Icona_Color = New System.Windows.Forms.PictureBox()
        Me.La_Fan_Info = New System.Windows.Forms.Label()
        Me.La_HUB_Info = New System.Windows.Forms.Label()
        Me.La_SchedaVideo_Info = New System.Windows.Forms.Label()
        Me.La_Altro_Info = New System.Windows.Forms.Label()
        Me.La_StrepLED_Info = New System.Windows.Forms.Label()
        Me.La_Elemento = New System.Windows.Forms.Label()
        Me.LColore = New System.Windows.Forms.Label()
        Me.LLuminosità = New System.Windows.Forms.Label()
        Me.LaN_Rotazione = New System.Windows.Forms.Label()
        Me.LaN_Velocità = New System.Windows.Forms.Label()
        Me.LaN_RPM = New System.Windows.Forms.Label()
        Me.LaColore = New System.Windows.Forms.Label()
        Me.LaLuminosità = New System.Windows.Forms.Label()
        Me.LaFanModalità = New System.Windows.Forms.Label()
        Me.LaVelocità = New System.Windows.Forms.Label()
        Me.LaRPMvnetola = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TempSenS = New CircularProgressBar.CircularProgressBar()
        Me.Btn_EL_1 = New System.Windows.Forms.Button()
        Me.Btn_EL_3 = New System.Windows.Forms.Button()
        Me.Btn_EL_4 = New System.Windows.Forms.Button()
        Me.Btn_EL_2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pixcpu = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.BarTempCPU = New System.Windows.Forms.PictureBox()
        Me.BarLoadCPU = New System.Windows.Forms.PictureBox()
        Me.BarLoadGPU = New System.Windows.Forms.PictureBox()
        Me.BarTempGPU = New System.Windows.Forms.PictureBox()
        CType(Me.Icona_Color, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pixcpu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarTempCPU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarLoadCPU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarLoadGPU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarTempGPU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Fan_Info
        '
        Me.Btn_Fan_Info.BackColor = System.Drawing.Color.Lime
        Me.Btn_Fan_Info.BackgroundImage = Global.ArduCenter.My.Resources.Resources.IconaFan_RGB_Colore_HSV_RGB_2_0
        Me.Btn_Fan_Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_Fan_Info.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Fan_Info.FlatAppearance.BorderSize = 0
        Me.Btn_Fan_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Fan_Info.Location = New System.Drawing.Point(111, 283)
        Me.Btn_Fan_Info.Margin = New System.Windows.Forms.Padding(0)
        Me.Btn_Fan_Info.Name = "Btn_Fan_Info"
        Me.Btn_Fan_Info.Size = New System.Drawing.Size(75, 75)
        Me.Btn_Fan_Info.TabIndex = 0
        Me.Btn_Fan_Info.UseVisualStyleBackColor = False
        '
        'Btn_HUB_Info
        '
        Me.Btn_HUB_Info.BackColor = System.Drawing.Color.Lime
        Me.Btn_HUB_Info.BackgroundImage = Global.ArduCenter.My.Resources.Resources.Icona_HUB_1_1
        Me.Btn_HUB_Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_HUB_Info.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_HUB_Info.FlatAppearance.BorderSize = 0
        Me.Btn_HUB_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_HUB_Info.Location = New System.Drawing.Point(34, 280)
        Me.Btn_HUB_Info.Margin = New System.Windows.Forms.Padding(0)
        Me.Btn_HUB_Info.Name = "Btn_HUB_Info"
        Me.Btn_HUB_Info.Size = New System.Drawing.Size(46, 80)
        Me.Btn_HUB_Info.TabIndex = 1
        Me.Btn_HUB_Info.UseVisualStyleBackColor = False
        '
        'Btn_Altro_Info
        '
        Me.Btn_Altro_Info.BackColor = System.Drawing.Color.Lime
        Me.Btn_Altro_Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_Altro_Info.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Altro_Info.FlatAppearance.BorderSize = 0
        Me.Btn_Altro_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Altro_Info.Location = New System.Drawing.Point(203, 286)
        Me.Btn_Altro_Info.Margin = New System.Windows.Forms.Padding(0)
        Me.Btn_Altro_Info.Name = "Btn_Altro_Info"
        Me.Btn_Altro_Info.Size = New System.Drawing.Size(112, 69)
        Me.Btn_Altro_Info.TabIndex = 2
        Me.Btn_Altro_Info.UseVisualStyleBackColor = False
        '
        'Btn_GPU_Info
        '
        Me.Btn_GPU_Info.BackColor = System.Drawing.Color.Lime
        Me.Btn_GPU_Info.BackgroundImage = Global.ArduCenter.My.Resources.Resources.Icona_SchedaVideo_RGB_Colore_HSV_RGB_21
        Me.Btn_GPU_Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_GPU_Info.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_GPU_Info.FlatAppearance.BorderSize = 0
        Me.Btn_GPU_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_GPU_Info.Location = New System.Drawing.Point(335, 288)
        Me.Btn_GPU_Info.Margin = New System.Windows.Forms.Padding(0)
        Me.Btn_GPU_Info.Name = "Btn_GPU_Info"
        Me.Btn_GPU_Info.Size = New System.Drawing.Size(120, 65)
        Me.Btn_GPU_Info.TabIndex = 3
        Me.Btn_GPU_Info.UseVisualStyleBackColor = False
        '
        'Btn_StriscaLED_Info
        '
        Me.Btn_StriscaLED_Info.BackColor = System.Drawing.Color.Lime
        Me.Btn_StriscaLED_Info.BackgroundImage = Global.ArduCenter.My.Resources.Resources.Icona_Strisca__RGB_Colore_HSV_RGB_2_2_2
        Me.Btn_StriscaLED_Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_StriscaLED_Info.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_StriscaLED_Info.FlatAppearance.BorderSize = 0
        Me.Btn_StriscaLED_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_StriscaLED_Info.Location = New System.Drawing.Point(472, 288)
        Me.Btn_StriscaLED_Info.Margin = New System.Windows.Forms.Padding(0)
        Me.Btn_StriscaLED_Info.Name = "Btn_StriscaLED_Info"
        Me.Btn_StriscaLED_Info.Size = New System.Drawing.Size(120, 65)
        Me.Btn_StriscaLED_Info.TabIndex = 4
        Me.Btn_StriscaLED_Info.UseVisualStyleBackColor = False
        '
        'Icona_Color
        '
        Me.Icona_Color.BackColor = System.Drawing.Color.Lime
        Me.Icona_Color.BackgroundImage = Global.ArduCenter.My.Resources.Resources.Icona_HUB_1_1
        Me.Icona_Color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Icona_Color.Location = New System.Drawing.Point(21, 27)
        Me.Icona_Color.Margin = New System.Windows.Forms.Padding(0)
        Me.Icona_Color.Name = "Icona_Color"
        Me.Icona_Color.Size = New System.Drawing.Size(180, 180)
        Me.Icona_Color.TabIndex = 5
        Me.Icona_Color.TabStop = False
        '
        'La_Fan_Info
        '
        Me.La_Fan_Info.BackColor = System.Drawing.Color.Transparent
        Me.La_Fan_Info.Cursor = System.Windows.Forms.Cursors.Hand
        Me.La_Fan_Info.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.La_Fan_Info.ForeColor = System.Drawing.Color.DarkGray
        Me.La_Fan_Info.Location = New System.Drawing.Point(111, 255)
        Me.La_Fan_Info.Name = "La_Fan_Info"
        Me.La_Fan_Info.Size = New System.Drawing.Size(75, 18)
        Me.La_Fan_Info.TabIndex = 6
        Me.La_Fan_Info.Text = "-"
        Me.La_Fan_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'La_HUB_Info
        '
        Me.La_HUB_Info.BackColor = System.Drawing.Color.Transparent
        Me.La_HUB_Info.Cursor = System.Windows.Forms.Cursors.Hand
        Me.La_HUB_Info.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.La_HUB_Info.ForeColor = System.Drawing.Color.DarkGray
        Me.La_HUB_Info.Location = New System.Drawing.Point(34, 255)
        Me.La_HUB_Info.Name = "La_HUB_Info"
        Me.La_HUB_Info.Size = New System.Drawing.Size(46, 18)
        Me.La_HUB_Info.TabIndex = 7
        Me.La_HUB_Info.Text = "-"
        Me.La_HUB_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'La_SchedaVideo_Info
        '
        Me.La_SchedaVideo_Info.BackColor = System.Drawing.Color.Transparent
        Me.La_SchedaVideo_Info.Cursor = System.Windows.Forms.Cursors.Hand
        Me.La_SchedaVideo_Info.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.La_SchedaVideo_Info.ForeColor = System.Drawing.Color.DarkGray
        Me.La_SchedaVideo_Info.Location = New System.Drawing.Point(335, 255)
        Me.La_SchedaVideo_Info.Name = "La_SchedaVideo_Info"
        Me.La_SchedaVideo_Info.Size = New System.Drawing.Size(120, 18)
        Me.La_SchedaVideo_Info.TabIndex = 8
        Me.La_SchedaVideo_Info.Text = "-"
        Me.La_SchedaVideo_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'La_Altro_Info
        '
        Me.La_Altro_Info.BackColor = System.Drawing.Color.Transparent
        Me.La_Altro_Info.Cursor = System.Windows.Forms.Cursors.Hand
        Me.La_Altro_Info.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.La_Altro_Info.ForeColor = System.Drawing.Color.DarkGray
        Me.La_Altro_Info.Location = New System.Drawing.Point(203, 255)
        Me.La_Altro_Info.Name = "La_Altro_Info"
        Me.La_Altro_Info.Size = New System.Drawing.Size(112, 18)
        Me.La_Altro_Info.TabIndex = 9
        Me.La_Altro_Info.Text = "-"
        Me.La_Altro_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'La_StrepLED_Info
        '
        Me.La_StrepLED_Info.BackColor = System.Drawing.Color.Transparent
        Me.La_StrepLED_Info.Cursor = System.Windows.Forms.Cursors.Hand
        Me.La_StrepLED_Info.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.La_StrepLED_Info.ForeColor = System.Drawing.Color.DarkGray
        Me.La_StrepLED_Info.Location = New System.Drawing.Point(472, 255)
        Me.La_StrepLED_Info.Name = "La_StrepLED_Info"
        Me.La_StrepLED_Info.Size = New System.Drawing.Size(120, 18)
        Me.La_StrepLED_Info.TabIndex = 10
        Me.La_StrepLED_Info.Text = "-"
        Me.La_StrepLED_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'La_Elemento
        '
        Me.La_Elemento.BackColor = System.Drawing.Color.Transparent
        Me.La_Elemento.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.La_Elemento.ForeColor = System.Drawing.Color.White
        Me.La_Elemento.Location = New System.Drawing.Point(219, 14)
        Me.La_Elemento.Name = "La_Elemento"
        Me.La_Elemento.Size = New System.Drawing.Size(267, 23)
        Me.La_Elemento.TabIndex = 12
        Me.La_Elemento.Text = "-"
        Me.La_Elemento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LColore
        '
        Me.LColore.AutoSize = True
        Me.LColore.BackColor = System.Drawing.Color.Transparent
        Me.LColore.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LColore.ForeColor = System.Drawing.Color.White
        Me.LColore.Location = New System.Drawing.Point(216, 47)
        Me.LColore.Name = "LColore"
        Me.LColore.Size = New System.Drawing.Size(15, 18)
        Me.LColore.TabIndex = 13
        Me.LColore.Text = "-"
        '
        'LLuminosità
        '
        Me.LLuminosità.AutoSize = True
        Me.LLuminosità.BackColor = System.Drawing.Color.Transparent
        Me.LLuminosità.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLuminosità.ForeColor = System.Drawing.Color.White
        Me.LLuminosità.Location = New System.Drawing.Point(216, 74)
        Me.LLuminosità.Name = "LLuminosità"
        Me.LLuminosità.Size = New System.Drawing.Size(15, 18)
        Me.LLuminosità.TabIndex = 14
        Me.LLuminosità.Text = "-"
        '
        'LaN_Rotazione
        '
        Me.LaN_Rotazione.AutoSize = True
        Me.LaN_Rotazione.BackColor = System.Drawing.Color.Transparent
        Me.LaN_Rotazione.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaN_Rotazione.ForeColor = System.Drawing.Color.White
        Me.LaN_Rotazione.Location = New System.Drawing.Point(216, 102)
        Me.LaN_Rotazione.Name = "LaN_Rotazione"
        Me.LaN_Rotazione.Size = New System.Drawing.Size(15, 18)
        Me.LaN_Rotazione.TabIndex = 15
        Me.LaN_Rotazione.Text = "-"
        '
        'LaN_Velocità
        '
        Me.LaN_Velocità.AutoSize = True
        Me.LaN_Velocità.BackColor = System.Drawing.Color.Transparent
        Me.LaN_Velocità.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaN_Velocità.ForeColor = System.Drawing.Color.White
        Me.LaN_Velocità.Location = New System.Drawing.Point(216, 129)
        Me.LaN_Velocità.Name = "LaN_Velocità"
        Me.LaN_Velocità.Size = New System.Drawing.Size(15, 18)
        Me.LaN_Velocità.TabIndex = 16
        Me.LaN_Velocità.Text = "-"
        '
        'LaN_RPM
        '
        Me.LaN_RPM.AutoSize = True
        Me.LaN_RPM.BackColor = System.Drawing.Color.Transparent
        Me.LaN_RPM.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaN_RPM.ForeColor = System.Drawing.Color.White
        Me.LaN_RPM.Location = New System.Drawing.Point(216, 157)
        Me.LaN_RPM.Name = "LaN_RPM"
        Me.LaN_RPM.Size = New System.Drawing.Size(15, 18)
        Me.LaN_RPM.TabIndex = 17
        Me.LaN_RPM.Text = "-"
        '
        'LaColore
        '
        Me.LaColore.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LaColore.BackColor = System.Drawing.Color.Transparent
        Me.LaColore.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaColore.ForeColor = System.Drawing.Color.White
        Me.LaColore.Location = New System.Drawing.Point(349, 47)
        Me.LaColore.Name = "LaColore"
        Me.LaColore.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LaColore.Size = New System.Drawing.Size(140, 18)
        Me.LaColore.TabIndex = 18
        Me.LaColore.Text = "-"
        Me.LaColore.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LaLuminosità
        '
        Me.LaLuminosità.BackColor = System.Drawing.Color.Transparent
        Me.LaLuminosità.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaLuminosità.ForeColor = System.Drawing.Color.White
        Me.LaLuminosità.Location = New System.Drawing.Point(389, 74)
        Me.LaLuminosità.Name = "LaLuminosità"
        Me.LaLuminosità.Size = New System.Drawing.Size(100, 18)
        Me.LaLuminosità.TabIndex = 19
        Me.LaLuminosità.Text = "-"
        Me.LaLuminosità.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LaFanModalità
        '
        Me.LaFanModalità.BackColor = System.Drawing.Color.Transparent
        Me.LaFanModalità.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaFanModalità.ForeColor = System.Drawing.Color.White
        Me.LaFanModalità.Location = New System.Drawing.Point(389, 102)
        Me.LaFanModalità.Name = "LaFanModalità"
        Me.LaFanModalità.Size = New System.Drawing.Size(100, 18)
        Me.LaFanModalità.TabIndex = 20
        Me.LaFanModalità.Text = "-"
        Me.LaFanModalità.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LaVelocità
        '
        Me.LaVelocità.BackColor = System.Drawing.Color.Transparent
        Me.LaVelocità.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaVelocità.ForeColor = System.Drawing.Color.White
        Me.LaVelocità.Location = New System.Drawing.Point(392, 129)
        Me.LaVelocità.Name = "LaVelocità"
        Me.LaVelocità.Size = New System.Drawing.Size(97, 18)
        Me.LaVelocità.TabIndex = 21
        Me.LaVelocità.Text = "-"
        Me.LaVelocità.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LaRPMvnetola
        '
        Me.LaRPMvnetola.BackColor = System.Drawing.Color.Transparent
        Me.LaRPMvnetola.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaRPMvnetola.ForeColor = System.Drawing.Color.White
        Me.LaRPMvnetola.Location = New System.Drawing.Point(392, 157)
        Me.LaRPMvnetola.Name = "LaRPMvnetola"
        Me.LaRPMvnetola.Size = New System.Drawing.Size(97, 18)
        Me.LaRPMvnetola.TabIndex = 22
        Me.LaRPMvnetola.Text = "-"
        Me.LaRPMvnetola.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(535, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 18)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Temp"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(526, 135)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 16)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "CPU"
        Me.Label14.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(562, 135)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(36, 16)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "GPU"
        Me.Label16.Visible = False
        '
        'TempSenS
        '
        Me.TempSenS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TempSenS.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.TempSenS.AnimationSpeed = 500
        Me.TempSenS.BackColor = System.Drawing.Color.Transparent
        Me.TempSenS.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TempSenS.ForeColor = System.Drawing.Color.White
        Me.TempSenS.InnerColor = System.Drawing.Color.Transparent
        Me.TempSenS.InnerMargin = 0
        Me.TempSenS.InnerWidth = 0
        Me.TempSenS.Location = New System.Drawing.Point(525, 35)
        Me.TempSenS.Margin = New System.Windows.Forms.Padding(0)
        Me.TempSenS.MarqueeAnimationSpeed = 2000
        Me.TempSenS.Maximum = 1
        Me.TempSenS.Name = "TempSenS"
        Me.TempSenS.OuterColor = System.Drawing.Color.Transparent
        Me.TempSenS.OuterMargin = 8
        Me.TempSenS.OuterWidth = 2
        Me.TempSenS.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TempSenS.ProgressWidth = 8
        Me.TempSenS.SecondaryFont = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TempSenS.Size = New System.Drawing.Size(75, 75)
        Me.TempSenS.StartAngle = 270
        Me.TempSenS.Step = 5
        Me.TempSenS.SubscriptColor = System.Drawing.Color.White
        Me.TempSenS.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.TempSenS.SubscriptText = "  °C"
        Me.TempSenS.SuperscriptColor = System.Drawing.Color.White
        Me.TempSenS.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.TempSenS.SuperscriptText = ""
        Me.TempSenS.TabIndex = 27
        Me.TempSenS.Text = "99"
        Me.TempSenS.TextMargin = New System.Windows.Forms.Padding(8, 1, 0, 0)
        Me.TempSenS.Value = 1
        '
        'Btn_EL_1
        '
        Me.Btn_EL_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Btn_EL_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_EL_1.FlatAppearance.BorderSize = 0
        Me.Btn_EL_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_EL_1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_EL_1.ForeColor = System.Drawing.Color.DarkGray
        Me.Btn_EL_1.Location = New System.Drawing.Point(209, 192)
        Me.Btn_EL_1.Margin = New System.Windows.Forms.Padding(0)
        Me.Btn_EL_1.Name = "Btn_EL_1"
        Me.Btn_EL_1.Size = New System.Drawing.Size(70, 25)
        Me.Btn_EL_1.TabIndex = 28
        Me.Btn_EL_1.Text = "-"
        Me.Btn_EL_1.UseVisualStyleBackColor = False
        '
        'Btn_EL_3
        '
        Me.Btn_EL_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Btn_EL_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_EL_3.FlatAppearance.BorderSize = 0
        Me.Btn_EL_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_EL_3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_EL_3.ForeColor = System.Drawing.Color.DarkGray
        Me.Btn_EL_3.Location = New System.Drawing.Point(349, 192)
        Me.Btn_EL_3.Margin = New System.Windows.Forms.Padding(0)
        Me.Btn_EL_3.Name = "Btn_EL_3"
        Me.Btn_EL_3.Size = New System.Drawing.Size(70, 25)
        Me.Btn_EL_3.TabIndex = 29
        Me.Btn_EL_3.Text = "-"
        Me.Btn_EL_3.UseVisualStyleBackColor = False
        '
        'Btn_EL_4
        '
        Me.Btn_EL_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Btn_EL_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_EL_4.FlatAppearance.BorderSize = 0
        Me.Btn_EL_4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Btn_EL_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_EL_4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_EL_4.ForeColor = System.Drawing.Color.DarkGray
        Me.Btn_EL_4.Location = New System.Drawing.Point(419, 192)
        Me.Btn_EL_4.Margin = New System.Windows.Forms.Padding(0)
        Me.Btn_EL_4.Name = "Btn_EL_4"
        Me.Btn_EL_4.Size = New System.Drawing.Size(70, 25)
        Me.Btn_EL_4.TabIndex = 30
        Me.Btn_EL_4.Text = "-"
        Me.Btn_EL_4.UseVisualStyleBackColor = False
        '
        'Btn_EL_2
        '
        Me.Btn_EL_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Btn_EL_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_EL_2.FlatAppearance.BorderSize = 0
        Me.Btn_EL_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_EL_2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_EL_2.ForeColor = System.Drawing.Color.DarkGray
        Me.Btn_EL_2.Location = New System.Drawing.Point(279, 192)
        Me.Btn_EL_2.Margin = New System.Windows.Forms.Padding(0)
        Me.Btn_EL_2.Name = "Btn_EL_2"
        Me.Btn_EL_2.Size = New System.Drawing.Size(70, 25)
        Me.Btn_EL_2.TabIndex = 31
        Me.Btn_EL_2.Text = "-"
        Me.Btn_EL_2.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Cyan
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(532, 157)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(10, 45)
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'pixcpu
        '
        Me.pixcpu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pixcpu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pixcpu.Location = New System.Drawing.Point(546, 157)
        Me.pixcpu.Margin = New System.Windows.Forms.Padding(0)
        Me.pixcpu.Name = "pixcpu"
        Me.pixcpu.Size = New System.Drawing.Size(10, 45)
        Me.pixcpu.TabIndex = 33
        Me.pixcpu.TabStop = False
        Me.pixcpu.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(582, 157)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(10, 45)
        Me.PictureBox3.TabIndex = 35
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Fuchsia
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox4.Location = New System.Drawing.Point(568, 157)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(10, 45)
        Me.PictureBox4.TabIndex = 34
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'BarTempCPU
        '
        Me.BarTempCPU.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.BarTempCPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BarTempCPU.Location = New System.Drawing.Point(546, 157)
        Me.BarTempCPU.Margin = New System.Windows.Forms.Padding(0)
        Me.BarTempCPU.Name = "BarTempCPU"
        Me.BarTempCPU.Size = New System.Drawing.Size(10, 35)
        Me.BarTempCPU.TabIndex = 37
        Me.BarTempCPU.TabStop = False
        Me.BarTempCPU.Visible = False
        '
        'BarLoadCPU
        '
        Me.BarLoadCPU.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.BarLoadCPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BarLoadCPU.Location = New System.Drawing.Point(532, 157)
        Me.BarLoadCPU.Margin = New System.Windows.Forms.Padding(0)
        Me.BarLoadCPU.Name = "BarLoadCPU"
        Me.BarLoadCPU.Size = New System.Drawing.Size(10, 35)
        Me.BarLoadCPU.TabIndex = 38
        Me.BarLoadCPU.TabStop = False
        Me.BarLoadCPU.Visible = False
        '
        'BarLoadGPU
        '
        Me.BarLoadGPU.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.BarLoadGPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BarLoadGPU.Location = New System.Drawing.Point(568, 157)
        Me.BarLoadGPU.Margin = New System.Windows.Forms.Padding(0)
        Me.BarLoadGPU.Name = "BarLoadGPU"
        Me.BarLoadGPU.Size = New System.Drawing.Size(10, 35)
        Me.BarLoadGPU.TabIndex = 39
        Me.BarLoadGPU.TabStop = False
        Me.BarLoadGPU.Visible = False
        '
        'BarTempGPU
        '
        Me.BarTempGPU.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.BarTempGPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BarTempGPU.Location = New System.Drawing.Point(582, 157)
        Me.BarTempGPU.Margin = New System.Windows.Forms.Padding(0)
        Me.BarTempGPU.Name = "BarTempGPU"
        Me.BarTempGPU.Size = New System.Drawing.Size(10, 35)
        Me.BarTempGPU.TabIndex = 40
        Me.BarTempGPU.TabStop = False
        Me.BarTempGPU.Visible = False
        '
        'P_HubPC_HUB
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.BackgroundImage = Global.ArduCenter.My.Resources.Resources.GUI_Fan_Menù_5_v1_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(618, 381)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.BarTempGPU)
        Me.Controls.Add(Me.BarLoadGPU)
        Me.Controls.Add(Me.BarLoadCPU)
        Me.Controls.Add(Me.BarTempCPU)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.pixcpu)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Btn_EL_2)
        Me.Controls.Add(Me.Btn_EL_4)
        Me.Controls.Add(Me.Btn_EL_3)
        Me.Controls.Add(Me.Btn_EL_1)
        Me.Controls.Add(Me.TempSenS)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.LaRPMvnetola)
        Me.Controls.Add(Me.LaVelocità)
        Me.Controls.Add(Me.LaFanModalità)
        Me.Controls.Add(Me.LaLuminosità)
        Me.Controls.Add(Me.LaColore)
        Me.Controls.Add(Me.LaN_RPM)
        Me.Controls.Add(Me.LaN_Velocità)
        Me.Controls.Add(Me.LaN_Rotazione)
        Me.Controls.Add(Me.LLuminosità)
        Me.Controls.Add(Me.LColore)
        Me.Controls.Add(Me.La_Elemento)
        Me.Controls.Add(Me.La_StrepLED_Info)
        Me.Controls.Add(Me.La_Altro_Info)
        Me.Controls.Add(Me.La_SchedaVideo_Info)
        Me.Controls.Add(Me.La_HUB_Info)
        Me.Controls.Add(Me.La_Fan_Info)
        Me.Controls.Add(Me.Icona_Color)
        Me.Controls.Add(Me.Btn_StriscaLED_Info)
        Me.Controls.Add(Me.Btn_GPU_Info)
        Me.Controls.Add(Me.Btn_Altro_Info)
        Me.Controls.Add(Me.Btn_HUB_Info)
        Me.Controls.Add(Me.Btn_Fan_Info)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "P_HubPC_HUB"
        Me.Text = "F_HubPC_HUB"
        CType(Me.Icona_Color, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pixcpu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarTempCPU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarLoadCPU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarLoadGPU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarTempGPU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Fan_Info As Button
    Friend WithEvents Btn_HUB_Info As Button
    Friend WithEvents Btn_Altro_Info As Button
    Friend WithEvents Btn_GPU_Info As Button
    Friend WithEvents Btn_StriscaLED_Info As Button
    Friend WithEvents Icona_Color As PictureBox
    Friend WithEvents La_Fan_Info As Label
    Friend WithEvents La_HUB_Info As Label
    Friend WithEvents La_SchedaVideo_Info As Label
    Friend WithEvents La_Altro_Info As Label
    Friend WithEvents La_StrepLED_Info As Label
    Friend WithEvents La_Elemento As Label
    Friend WithEvents LColore As Label
    Friend WithEvents LLuminosità As Label
    Friend WithEvents LaN_Rotazione As Label
    Friend WithEvents LaN_Velocità As Label
    Friend WithEvents LaN_RPM As Label
    Friend WithEvents LaColore As Label
    Friend WithEvents LaLuminosità As Label
    Friend WithEvents LaFanModalità As Label
    Friend WithEvents LaVelocità As Label
    Friend WithEvents LaRPMvnetola As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TempSenS As CircularProgressBar.CircularProgressBar
    Friend WithEvents Btn_EL_1 As Button
    Friend WithEvents Btn_EL_3 As Button
    Friend WithEvents Btn_EL_4 As Button
    Friend WithEvents Btn_EL_2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pixcpu As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents BarTempCPU As PictureBox
    Friend WithEvents BarLoadCPU As PictureBox
    Friend WithEvents BarLoadGPU As PictureBox
    Friend WithEvents BarTempGPU As PictureBox
End Class
