<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_HubPC_HUB
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
        Me.Btn_Casse_Info = New System.Windows.Forms.Button()
        Me.Btn_Dissipatore_Info = New System.Windows.Forms.Button()
        Me.Btn_GPU_Info = New System.Windows.Forms.Button()
        Me.Btn_StriscaLED_Info = New System.Windows.Forms.Button()
        Me.IconaHUB_Color = New System.Windows.Forms.PictureBox()
        Me.La_Fan_Info = New System.Windows.Forms.Label()
        Me.La_Casse_Info = New System.Windows.Forms.Label()
        Me.La_SchedaVideo_Info = New System.Windows.Forms.Label()
        Me.La_Dissipatore_Info = New System.Windows.Forms.Label()
        Me.La_StrepLED_Info = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.La_Elemento = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.Label15 = New System.Windows.Forms.Label()
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
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.BarTempCPU = New System.Windows.Forms.PictureBox()
        Me.BarLoadCPU = New System.Windows.Forms.PictureBox()
        Me.BarLoadGPU = New System.Windows.Forms.PictureBox()
        Me.BarTempGPU = New System.Windows.Forms.PictureBox()
        Me.BarLoadRAM = New System.Windows.Forms.PictureBox()
        CType(Me.IconaHUB_Color, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pixcpu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarTempCPU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarLoadCPU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarLoadGPU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarTempGPU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarLoadRAM, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Btn_Fan_Info.Location = New System.Drawing.Point(23, 283)
        Me.Btn_Fan_Info.Margin = New System.Windows.Forms.Padding(0)
        Me.Btn_Fan_Info.Name = "Btn_Fan_Info"
        Me.Btn_Fan_Info.Size = New System.Drawing.Size(75, 75)
        Me.Btn_Fan_Info.TabIndex = 0
        Me.Btn_Fan_Info.UseVisualStyleBackColor = False
        '
        'Btn_Casse_Info
        '
        Me.Btn_Casse_Info.BackColor = System.Drawing.Color.Lime
        Me.Btn_Casse_Info.BackgroundImage = Global.ArduCenter.My.Resources.Resources.IconaCasaAudio_RGB_Colore_HSV_RGB
        Me.Btn_Casse_Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_Casse_Info.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Casse_Info.FlatAppearance.BorderSize = 0
        Me.Btn_Casse_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Casse_Info.Location = New System.Drawing.Point(133, 280)
        Me.Btn_Casse_Info.Margin = New System.Windows.Forms.Padding(0)
        Me.Btn_Casse_Info.Name = "Btn_Casse_Info"
        Me.Btn_Casse_Info.Size = New System.Drawing.Size(46, 79)
        Me.Btn_Casse_Info.TabIndex = 1
        Me.Btn_Casse_Info.UseVisualStyleBackColor = False
        '
        'Btn_Dissipatore_Info
        '
        Me.Btn_Dissipatore_Info.BackColor = System.Drawing.Color.Lime
        Me.Btn_Dissipatore_Info.BackgroundImage = Global.ArduCenter.My.Resources.Resources.Dissipatore240mm_HSV_v1_1
        Me.Btn_Dissipatore_Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_Dissipatore_Info.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Dissipatore_Info.FlatAppearance.BorderSize = 0
        Me.Btn_Dissipatore_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Dissipatore_Info.Location = New System.Drawing.Point(203, 285)
        Me.Btn_Dissipatore_Info.Margin = New System.Windows.Forms.Padding(0)
        Me.Btn_Dissipatore_Info.Name = "Btn_Dissipatore_Info"
        Me.Btn_Dissipatore_Info.Size = New System.Drawing.Size(112, 69)
        Me.Btn_Dissipatore_Info.TabIndex = 2
        Me.Btn_Dissipatore_Info.UseVisualStyleBackColor = False
        '
        'Btn_GPU_Info
        '
        Me.Btn_GPU_Info.BackColor = System.Drawing.Color.Lime
        Me.Btn_GPU_Info.BackgroundImage = Global.ArduCenter.My.Resources.Resources.Icona_SchedaVideo_RGB_Colore_HSV_RGB_21
        Me.Btn_GPU_Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_GPU_Info.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_GPU_Info.FlatAppearance.BorderSize = 0
        Me.Btn_GPU_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_GPU_Info.Location = New System.Drawing.Point(335, 285)
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
        Me.Btn_StriscaLED_Info.Location = New System.Drawing.Point(472, 284)
        Me.Btn_StriscaLED_Info.Margin = New System.Windows.Forms.Padding(0)
        Me.Btn_StriscaLED_Info.Name = "Btn_StriscaLED_Info"
        Me.Btn_StriscaLED_Info.Size = New System.Drawing.Size(120, 65)
        Me.Btn_StriscaLED_Info.TabIndex = 4
        Me.Btn_StriscaLED_Info.UseVisualStyleBackColor = False
        '
        'IconaHUB_Color
        '
        Me.IconaHUB_Color.BackColor = System.Drawing.Color.Lime
        Me.IconaHUB_Color.BackgroundImage = Global.ArduCenter.My.Resources.Resources.Icona_HUB_1_1
        Me.IconaHUB_Color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IconaHUB_Color.Location = New System.Drawing.Point(34, 47)
        Me.IconaHUB_Color.Margin = New System.Windows.Forms.Padding(0)
        Me.IconaHUB_Color.Name = "IconaHUB_Color"
        Me.IconaHUB_Color.Size = New System.Drawing.Size(95, 167)
        Me.IconaHUB_Color.TabIndex = 5
        Me.IconaHUB_Color.TabStop = False
        '
        'La_Fan_Info
        '
        Me.La_Fan_Info.AutoSize = True
        Me.La_Fan_Info.BackColor = System.Drawing.Color.Transparent
        Me.La_Fan_Info.Cursor = System.Windows.Forms.Cursors.Hand
        Me.La_Fan_Info.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.La_Fan_Info.ForeColor = System.Drawing.Color.White
        Me.La_Fan_Info.Location = New System.Drawing.Point(28, 255)
        Me.La_Fan_Info.Name = "La_Fan_Info"
        Me.La_Fan_Info.Size = New System.Drawing.Size(70, 18)
        Me.La_Fan_Info.TabIndex = 6
        Me.La_Fan_Info.Text = "Ventole"
        '
        'La_Casse_Info
        '
        Me.La_Casse_Info.AutoSize = True
        Me.La_Casse_Info.BackColor = System.Drawing.Color.Transparent
        Me.La_Casse_Info.Cursor = System.Windows.Forms.Cursors.Hand
        Me.La_Casse_Info.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.La_Casse_Info.ForeColor = System.Drawing.Color.DarkGray
        Me.La_Casse_Info.Location = New System.Drawing.Point(127, 255)
        Me.La_Casse_Info.Name = "La_Casse_Info"
        Me.La_Casse_Info.Size = New System.Drawing.Size(57, 18)
        Me.La_Casse_Info.TabIndex = 7
        Me.La_Casse_Info.Text = "Casse"
        '
        'La_SchedaVideo_Info
        '
        Me.La_SchedaVideo_Info.AutoSize = True
        Me.La_SchedaVideo_Info.BackColor = System.Drawing.Color.Transparent
        Me.La_SchedaVideo_Info.Cursor = System.Windows.Forms.Cursors.Hand
        Me.La_SchedaVideo_Info.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.La_SchedaVideo_Info.ForeColor = System.Drawing.Color.DarkGray
        Me.La_SchedaVideo_Info.Location = New System.Drawing.Point(337, 255)
        Me.La_SchedaVideo_Info.Name = "La_SchedaVideo_Info"
        Me.La_SchedaVideo_Info.Size = New System.Drawing.Size(117, 18)
        Me.La_SchedaVideo_Info.TabIndex = 8
        Me.La_SchedaVideo_Info.Text = "Scheda Video"
        '
        'La_Dissipatore_Info
        '
        Me.La_Dissipatore_Info.AutoSize = True
        Me.La_Dissipatore_Info.BackColor = System.Drawing.Color.Transparent
        Me.La_Dissipatore_Info.Cursor = System.Windows.Forms.Cursors.Hand
        Me.La_Dissipatore_Info.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.La_Dissipatore_Info.ForeColor = System.Drawing.Color.DarkGray
        Me.La_Dissipatore_Info.Location = New System.Drawing.Point(212, 255)
        Me.La_Dissipatore_Info.Name = "La_Dissipatore_Info"
        Me.La_Dissipatore_Info.Size = New System.Drawing.Size(100, 18)
        Me.La_Dissipatore_Info.TabIndex = 9
        Me.La_Dissipatore_Info.Text = "Dissipatore"
        '
        'La_StrepLED_Info
        '
        Me.La_StrepLED_Info.AutoSize = True
        Me.La_StrepLED_Info.BackColor = System.Drawing.Color.Transparent
        Me.La_StrepLED_Info.Cursor = System.Windows.Forms.Cursors.Hand
        Me.La_StrepLED_Info.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.La_StrepLED_Info.ForeColor = System.Drawing.Color.DarkGray
        Me.La_StrepLED_Info.Location = New System.Drawing.Point(482, 255)
        Me.La_StrepLED_Info.Name = "La_StrepLED_Info"
        Me.La_StrepLED_Info.Size = New System.Drawing.Size(101, 18)
        Me.La_StrepLED_Info.TabIndex = 10
        Me.La_StrepLED_Info.Text = "Strisca LED"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(57, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 23)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Hub"
        '
        'La_Elemento
        '
        Me.La_Elemento.BackColor = System.Drawing.Color.Transparent
        Me.La_Elemento.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.La_Elemento.ForeColor = System.Drawing.Color.White
        Me.La_Elemento.Location = New System.Drawing.Point(173, 14)
        Me.La_Elemento.Name = "La_Elemento"
        Me.La_Elemento.Size = New System.Drawing.Size(267, 23)
        Me.La_Elemento.TabIndex = 12
        Me.La_Elemento.Text = "Elemento"
        Me.La_Elemento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(170, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 18)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Colore"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(170, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 18)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Luminosità"
        '
        'LaN_Rotazione
        '
        Me.LaN_Rotazione.AutoSize = True
        Me.LaN_Rotazione.BackColor = System.Drawing.Color.Transparent
        Me.LaN_Rotazione.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaN_Rotazione.ForeColor = System.Drawing.Color.White
        Me.LaN_Rotazione.Location = New System.Drawing.Point(170, 102)
        Me.LaN_Rotazione.Name = "LaN_Rotazione"
        Me.LaN_Rotazione.Size = New System.Drawing.Size(167, 18)
        Me.LaN_Rotazione.TabIndex = 15
        Me.LaN_Rotazione.Text = "Gestione Rotazione"
        '
        'LaN_Velocità
        '
        Me.LaN_Velocità.AutoSize = True
        Me.LaN_Velocità.BackColor = System.Drawing.Color.Transparent
        Me.LaN_Velocità.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaN_Velocità.ForeColor = System.Drawing.Color.White
        Me.LaN_Velocità.Location = New System.Drawing.Point(170, 129)
        Me.LaN_Velocità.Name = "LaN_Velocità"
        Me.LaN_Velocità.Size = New System.Drawing.Size(72, 18)
        Me.LaN_Velocità.TabIndex = 16
        Me.LaN_Velocità.Text = "Velocità"
        '
        'LaN_RPM
        '
        Me.LaN_RPM.AutoSize = True
        Me.LaN_RPM.BackColor = System.Drawing.Color.Transparent
        Me.LaN_RPM.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaN_RPM.ForeColor = System.Drawing.Color.White
        Me.LaN_RPM.Location = New System.Drawing.Point(170, 157)
        Me.LaN_RPM.Name = "LaN_RPM"
        Me.LaN_RPM.Size = New System.Drawing.Size(45, 18)
        Me.LaN_RPM.TabIndex = 17
        Me.LaN_RPM.Text = "RPM"
        '
        'LaColore
        '
        Me.LaColore.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LaColore.BackColor = System.Drawing.Color.Transparent
        Me.LaColore.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaColore.ForeColor = System.Drawing.Color.White
        Me.LaColore.Location = New System.Drawing.Point(303, 47)
        Me.LaColore.Name = "LaColore"
        Me.LaColore.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LaColore.Size = New System.Drawing.Size(140, 18)
        Me.LaColore.TabIndex = 18
        Me.LaColore.Text = "Null"
        Me.LaColore.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LaLuminosità
        '
        Me.LaLuminosità.BackColor = System.Drawing.Color.Transparent
        Me.LaLuminosità.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaLuminosità.ForeColor = System.Drawing.Color.White
        Me.LaLuminosità.Location = New System.Drawing.Point(343, 74)
        Me.LaLuminosità.Name = "LaLuminosità"
        Me.LaLuminosità.Size = New System.Drawing.Size(100, 18)
        Me.LaLuminosità.TabIndex = 19
        Me.LaLuminosità.Text = "Null"
        Me.LaLuminosità.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LaFanModalità
        '
        Me.LaFanModalità.BackColor = System.Drawing.Color.Transparent
        Me.LaFanModalità.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaFanModalità.ForeColor = System.Drawing.Color.White
        Me.LaFanModalità.Location = New System.Drawing.Point(343, 102)
        Me.LaFanModalità.Name = "LaFanModalità"
        Me.LaFanModalità.Size = New System.Drawing.Size(100, 18)
        Me.LaFanModalità.TabIndex = 20
        Me.LaFanModalità.Text = "Null"
        Me.LaFanModalità.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LaVelocità
        '
        Me.LaVelocità.BackColor = System.Drawing.Color.Transparent
        Me.LaVelocità.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaVelocità.ForeColor = System.Drawing.Color.White
        Me.LaVelocità.Location = New System.Drawing.Point(346, 129)
        Me.LaVelocità.Name = "LaVelocità"
        Me.LaVelocità.Size = New System.Drawing.Size(97, 18)
        Me.LaVelocità.TabIndex = 21
        Me.LaVelocità.Text = "Null"
        Me.LaVelocità.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LaRPMvnetola
        '
        Me.LaRPMvnetola.BackColor = System.Drawing.Color.Transparent
        Me.LaRPMvnetola.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaRPMvnetola.ForeColor = System.Drawing.Color.White
        Me.LaRPMvnetola.Location = New System.Drawing.Point(346, 157)
        Me.LaRPMvnetola.Name = "LaRPMvnetola"
        Me.LaRPMvnetola.Size = New System.Drawing.Size(97, 18)
        Me.LaRPMvnetola.TabIndex = 22
        Me.LaRPMvnetola.Text = "Null"
        Me.LaRPMvnetola.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(494, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 18)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Temp Sens"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(486, 135)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 16)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "CPU"
        Me.Label14.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(560, 135)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 16)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "RAM"
        Me.Label15.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(522, 135)
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
        Me.TempSenS.Location = New System.Drawing.Point(507, 35)
        Me.TempSenS.Margin = New System.Windows.Forms.Padding(0)
        Me.TempSenS.MarqueeAnimationSpeed = 2000
        Me.TempSenS.Maximum = 120
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
        Me.TempSenS.Value = 120
        '
        'Btn_EL_1
        '
        Me.Btn_EL_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Btn_EL_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_EL_1.FlatAppearance.BorderSize = 0
        Me.Btn_EL_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_EL_1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_EL_1.ForeColor = System.Drawing.Color.DarkGray
        Me.Btn_EL_1.Location = New System.Drawing.Point(163, 192)
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
        Me.Btn_EL_3.Location = New System.Drawing.Point(303, 192)
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
        Me.Btn_EL_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_EL_4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_EL_4.ForeColor = System.Drawing.Color.DarkGray
        Me.Btn_EL_4.Location = New System.Drawing.Point(373, 192)
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
        Me.Btn_EL_2.Location = New System.Drawing.Point(233, 192)
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
        Me.PictureBox1.Location = New System.Drawing.Point(492, 157)
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
        Me.pixcpu.Location = New System.Drawing.Point(506, 157)
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
        Me.PictureBox3.Location = New System.Drawing.Point(542, 157)
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
        Me.PictureBox4.Location = New System.Drawing.Point(528, 157)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(10, 45)
        Me.PictureBox4.TabIndex = 34
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Lime
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox5.Location = New System.Drawing.Point(572, 157)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(10, 45)
        Me.PictureBox5.TabIndex = 36
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Visible = False
        '
        'BarTempCPU
        '
        Me.BarTempCPU.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.BarTempCPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BarTempCPU.Location = New System.Drawing.Point(506, 157)
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
        Me.BarLoadCPU.Location = New System.Drawing.Point(492, 157)
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
        Me.BarLoadGPU.Location = New System.Drawing.Point(528, 157)
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
        Me.BarTempGPU.Location = New System.Drawing.Point(542, 157)
        Me.BarTempGPU.Margin = New System.Windows.Forms.Padding(0)
        Me.BarTempGPU.Name = "BarTempGPU"
        Me.BarTempGPU.Size = New System.Drawing.Size(10, 35)
        Me.BarTempGPU.TabIndex = 40
        Me.BarTempGPU.TabStop = False
        Me.BarTempGPU.Visible = False
        '
        'BarLoadRAM
        '
        Me.BarLoadRAM.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.BarLoadRAM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BarLoadRAM.Location = New System.Drawing.Point(572, 157)
        Me.BarLoadRAM.Margin = New System.Windows.Forms.Padding(0)
        Me.BarLoadRAM.Name = "BarLoadRAM"
        Me.BarLoadRAM.Size = New System.Drawing.Size(10, 35)
        Me.BarLoadRAM.TabIndex = 41
        Me.BarLoadRAM.TabStop = False
        Me.BarLoadRAM.Visible = False
        '
        'F_HubPC_HUB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BackgroundImage = Global.ArduCenter.My.Resources.Resources.GUI_Fan_Menù_5_v1_0
        Me.ClientSize = New System.Drawing.Size(618, 381)
        Me.Controls.Add(Me.BarLoadRAM)
        Me.Controls.Add(Me.BarTempGPU)
        Me.Controls.Add(Me.BarLoadGPU)
        Me.Controls.Add(Me.BarLoadCPU)
        Me.Controls.Add(Me.BarTempCPU)
        Me.Controls.Add(Me.PictureBox5)
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
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.LaRPMvnetola)
        Me.Controls.Add(Me.LaVelocità)
        Me.Controls.Add(Me.LaFanModalità)
        Me.Controls.Add(Me.LaLuminosità)
        Me.Controls.Add(Me.LaColore)
        Me.Controls.Add(Me.LaN_RPM)
        Me.Controls.Add(Me.LaN_Velocità)
        Me.Controls.Add(Me.LaN_Rotazione)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.La_Elemento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.La_StrepLED_Info)
        Me.Controls.Add(Me.La_Dissipatore_Info)
        Me.Controls.Add(Me.La_SchedaVideo_Info)
        Me.Controls.Add(Me.La_Casse_Info)
        Me.Controls.Add(Me.La_Fan_Info)
        Me.Controls.Add(Me.IconaHUB_Color)
        Me.Controls.Add(Me.Btn_StriscaLED_Info)
        Me.Controls.Add(Me.Btn_GPU_Info)
        Me.Controls.Add(Me.Btn_Dissipatore_Info)
        Me.Controls.Add(Me.Btn_Casse_Info)
        Me.Controls.Add(Me.Btn_Fan_Info)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_HubPC_HUB"
        Me.Text = "F_HubPC_HUB"
        CType(Me.IconaHUB_Color, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pixcpu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarTempCPU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarLoadCPU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarLoadGPU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarTempGPU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarLoadRAM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Fan_Info As Button
    Friend WithEvents Btn_Casse_Info As Button
    Friend WithEvents Btn_Dissipatore_Info As Button
    Friend WithEvents Btn_GPU_Info As Button
    Friend WithEvents Btn_StriscaLED_Info As Button
    Friend WithEvents IconaHUB_Color As PictureBox
    Friend WithEvents La_Fan_Info As Label
    Friend WithEvents La_Casse_Info As Label
    Friend WithEvents La_SchedaVideo_Info As Label
    Friend WithEvents La_Dissipatore_Info As Label
    Friend WithEvents La_StrepLED_Info As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents La_Elemento As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
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
    Friend WithEvents Label15 As Label
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
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents BarTempCPU As PictureBox
    Friend WithEvents BarLoadCPU As PictureBox
    Friend WithEvents BarLoadGPU As PictureBox
    Friend WithEvents BarTempGPU As PictureBox
    Friend WithEvents BarLoadRAM As PictureBox
End Class
