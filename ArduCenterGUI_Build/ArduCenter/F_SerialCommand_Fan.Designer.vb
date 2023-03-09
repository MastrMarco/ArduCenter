<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_SerialCommand_Fan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_SerialCommand_Fan))
        Me.BtnChiudi = New System.Windows.Forms.PictureBox()
        Me.LaROM = New System.Windows.Forms.Label()
        Me.LaStatoLED_Audio = New System.Windows.Forms.Label()
        Me.LaStatoLED_Fan = New System.Windows.Forms.Label()
        Me.LaLuminosità = New System.Windows.Forms.Label()
        Me.LaSplitLED = New System.Windows.Forms.Label()
        Me.LaPAH = New System.Windows.Forms.Label()
        Me.LaPL = New System.Windows.Forms.Label()
        Me.LaVelocitàFan = New System.Windows.Forms.Label()
        Me.LaModVentole = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.InROM = New System.Windows.Forms.Label()
        Me.InModFan = New System.Windows.Forms.Label()
        Me.InVelocità = New System.Windows.Forms.Label()
        Me.InPL_Swich = New System.Windows.Forms.Label()
        Me.InPAH = New System.Windows.Forms.Label()
        Me.InSplitLED = New System.Windows.Forms.Label()
        Me.InLumninosità = New System.Windows.Forms.Label()
        Me.InFanHUB = New System.Windows.Forms.Label()
        Me.InAudioHUB = New System.Windows.Forms.Label()
        Me.LaPL_Stato = New System.Windows.Forms.Label()
        Me.InPL_Stato = New System.Windows.Forms.Label()
        CType(Me.BtnChiudi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnChiudi
        '
        Me.BtnChiudi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnChiudi.BackColor = System.Drawing.Color.Transparent
        Me.BtnChiudi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnChiudi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnChiudi.Image = Global.ArduCenter.My.Resources.Resources.BtnChiudi21
        Me.BtnChiudi.Location = New System.Drawing.Point(473, 3)
        Me.BtnChiudi.Name = "BtnChiudi"
        Me.BtnChiudi.Size = New System.Drawing.Size(25, 25)
        Me.BtnChiudi.TabIndex = 7
        Me.BtnChiudi.TabStop = False
        '
        'LaROM
        '
        Me.LaROM.BackColor = System.Drawing.Color.Transparent
        Me.LaROM.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaROM.ForeColor = System.Drawing.Color.White
        Me.LaROM.Location = New System.Drawing.Point(17, 43)
        Me.LaROM.Name = "LaROM"
        Me.LaROM.Size = New System.Drawing.Size(285, 23)
        Me.LaROM.TabIndex = 8
        Me.LaROM.Text = "Memorizza Dati impostati  "
        '
        'LaStatoLED_Audio
        '
        Me.LaStatoLED_Audio.BackColor = System.Drawing.Color.Transparent
        Me.LaStatoLED_Audio.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaStatoLED_Audio.ForeColor = System.Drawing.Color.White
        Me.LaStatoLED_Audio.Location = New System.Drawing.Point(17, 67)
        Me.LaStatoLED_Audio.Name = "LaStatoLED_Audio"
        Me.LaStatoLED_Audio.Size = New System.Drawing.Size(285, 23)
        Me.LaStatoLED_Audio.TabIndex = 9
        Me.LaStatoLED_Audio.Text = "Stato LED Hub Audio"
        '
        'LaStatoLED_Fan
        '
        Me.LaStatoLED_Fan.BackColor = System.Drawing.Color.Transparent
        Me.LaStatoLED_Fan.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaStatoLED_Fan.ForeColor = System.Drawing.Color.White
        Me.LaStatoLED_Fan.Location = New System.Drawing.Point(17, 90)
        Me.LaStatoLED_Fan.Name = "LaStatoLED_Fan"
        Me.LaStatoLED_Fan.Size = New System.Drawing.Size(285, 23)
        Me.LaStatoLED_Fan.TabIndex = 10
        Me.LaStatoLED_Fan.Text = "Stato LED Hub Ventole "
        '
        'LaLuminosità
        '
        Me.LaLuminosità.BackColor = System.Drawing.Color.Transparent
        Me.LaLuminosità.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaLuminosità.ForeColor = System.Drawing.Color.White
        Me.LaLuminosità.Location = New System.Drawing.Point(17, 113)
        Me.LaLuminosità.Name = "LaLuminosità"
        Me.LaLuminosità.Size = New System.Drawing.Size(285, 23)
        Me.LaLuminosità.TabIndex = 11
        Me.LaLuminosità.Text = "Luminosità LED "
        '
        'LaSplitLED
        '
        Me.LaSplitLED.BackColor = System.Drawing.Color.Transparent
        Me.LaSplitLED.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaSplitLED.ForeColor = System.Drawing.Color.White
        Me.LaSplitLED.Location = New System.Drawing.Point(17, 136)
        Me.LaSplitLED.Name = "LaSplitLED"
        Me.LaSplitLED.Size = New System.Drawing.Size(285, 23)
        Me.LaSplitLED.TabIndex = 12
        Me.LaSplitLED.Text = "Supporto Split LED"
        '
        'LaPAH
        '
        Me.LaPAH.BackColor = System.Drawing.Color.Transparent
        Me.LaPAH.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaPAH.ForeColor = System.Drawing.Color.White
        Me.LaPAH.Location = New System.Drawing.Point(17, 159)
        Me.LaPAH.Name = "LaPAH"
        Me.LaPAH.Size = New System.Drawing.Size(285, 23)
        Me.LaPAH.TabIndex = 13
        Me.LaPAH.Text = "Protezione Alimentazione HUB"
        '
        'LaPL
        '
        Me.LaPL.BackColor = System.Drawing.Color.Transparent
        Me.LaPL.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaPL.ForeColor = System.Drawing.Color.White
        Me.LaPL.Location = New System.Drawing.Point(17, 182)
        Me.LaPL.Name = "LaPL"
        Me.LaPL.Size = New System.Drawing.Size(285, 23)
        Me.LaPL.TabIndex = 14
        Me.LaPL.Text = "Protezione LED "
        '
        'LaVelocitàFan
        '
        Me.LaVelocitàFan.BackColor = System.Drawing.Color.Transparent
        Me.LaVelocitàFan.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaVelocitàFan.ForeColor = System.Drawing.Color.White
        Me.LaVelocitàFan.Location = New System.Drawing.Point(17, 227)
        Me.LaVelocitàFan.Name = "LaVelocitàFan"
        Me.LaVelocitàFan.Size = New System.Drawing.Size(285, 23)
        Me.LaVelocitàFan.TabIndex = 15
        Me.LaVelocitàFan.Text = "Velocità Ventole "
        '
        'LaModVentole
        '
        Me.LaModVentole.BackColor = System.Drawing.Color.Transparent
        Me.LaModVentole.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaModVentole.ForeColor = System.Drawing.Color.White
        Me.LaModVentole.Location = New System.Drawing.Point(17, 250)
        Me.LaModVentole.Name = "LaModVentole"
        Me.LaModVentole.Size = New System.Drawing.Size(285, 23)
        Me.LaModVentole.TabIndex = 16
        Me.LaModVentole.Text = "Modalità Curva Ventole"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(32, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(391, 18)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Dati / Valori dalla Serial Port  del Dispositivo"
        '
        'InROM
        '
        Me.InROM.BackColor = System.Drawing.Color.Transparent
        Me.InROM.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InROM.ForeColor = System.Drawing.Color.White
        Me.InROM.Location = New System.Drawing.Point(315, 43)
        Me.InROM.Name = "InROM"
        Me.InROM.Size = New System.Drawing.Size(177, 23)
        Me.InROM.TabIndex = 18
        Me.InROM.Text = "Disattivo    Val.0"
        '
        'InModFan
        '
        Me.InModFan.BackColor = System.Drawing.Color.Transparent
        Me.InModFan.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InModFan.ForeColor = System.Drawing.Color.White
        Me.InModFan.Location = New System.Drawing.Point(315, 250)
        Me.InModFan.Name = "InModFan"
        Me.InModFan.Size = New System.Drawing.Size(177, 23)
        Me.InModFan.TabIndex = 19
        Me.InModFan.Text = "Manuale     Val.1"
        '
        'InVelocità
        '
        Me.InVelocità.BackColor = System.Drawing.Color.Transparent
        Me.InVelocità.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InVelocità.ForeColor = System.Drawing.Color.White
        Me.InVelocità.Location = New System.Drawing.Point(315, 227)
        Me.InVelocità.Name = "InVelocità"
        Me.InVelocità.Size = New System.Drawing.Size(177, 23)
        Me.InVelocità.TabIndex = 20
        Me.InVelocità.Text = "100%         Val.255"
        '
        'InPL_Swich
        '
        Me.InPL_Swich.BackColor = System.Drawing.Color.Transparent
        Me.InPL_Swich.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InPL_Swich.ForeColor = System.Drawing.Color.White
        Me.InPL_Swich.Location = New System.Drawing.Point(315, 182)
        Me.InPL_Swich.Name = "InPL_Swich"
        Me.InPL_Swich.Size = New System.Drawing.Size(177, 23)
        Me.InPL_Swich.TabIndex = 21
        Me.InPL_Swich.Text = "Disattivo    Val.0"
        '
        'InPAH
        '
        Me.InPAH.BackColor = System.Drawing.Color.Transparent
        Me.InPAH.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InPAH.ForeColor = System.Drawing.Color.White
        Me.InPAH.Location = New System.Drawing.Point(315, 159)
        Me.InPAH.Name = "InPAH"
        Me.InPAH.Size = New System.Drawing.Size(177, 23)
        Me.InPAH.TabIndex = 22
        Me.InPAH.Text = "Non Supportato"
        '
        'InSplitLED
        '
        Me.InSplitLED.BackColor = System.Drawing.Color.Transparent
        Me.InSplitLED.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InSplitLED.ForeColor = System.Drawing.Color.White
        Me.InSplitLED.Location = New System.Drawing.Point(315, 136)
        Me.InSplitLED.Name = "InSplitLED"
        Me.InSplitLED.Size = New System.Drawing.Size(177, 23)
        Me.InSplitLED.TabIndex = 23
        Me.InSplitLED.Text = "Non Supportato"
        '
        'InLumninosità
        '
        Me.InLumninosità.BackColor = System.Drawing.Color.Transparent
        Me.InLumninosità.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InLumninosità.ForeColor = System.Drawing.Color.White
        Me.InLumninosità.Location = New System.Drawing.Point(315, 113)
        Me.InLumninosità.Name = "InLumninosità"
        Me.InLumninosità.Size = New System.Drawing.Size(177, 23)
        Me.InLumninosità.TabIndex = 24
        Me.InLumninosità.Text = "100%         Val.255"
        '
        'InFanHUB
        '
        Me.InFanHUB.BackColor = System.Drawing.Color.Transparent
        Me.InFanHUB.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InFanHUB.ForeColor = System.Drawing.Color.White
        Me.InFanHUB.Location = New System.Drawing.Point(315, 90)
        Me.InFanHUB.Name = "InFanHUB"
        Me.InFanHUB.Size = New System.Drawing.Size(177, 23)
        Me.InFanHUB.TabIndex = 25
        Me.InFanHUB.Text = "RGB            Val.11"
        '
        'InAudioHUB
        '
        Me.InAudioHUB.BackColor = System.Drawing.Color.Transparent
        Me.InAudioHUB.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InAudioHUB.ForeColor = System.Drawing.Color.White
        Me.InAudioHUB.Location = New System.Drawing.Point(315, 67)
        Me.InAudioHUB.Name = "InAudioHUB"
        Me.InAudioHUB.Size = New System.Drawing.Size(177, 23)
        Me.InAudioHUB.TabIndex = 26
        Me.InAudioHUB.Text = "Non Supportato"
        '
        'LaPL_Stato
        '
        Me.LaPL_Stato.BackColor = System.Drawing.Color.Transparent
        Me.LaPL_Stato.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaPL_Stato.ForeColor = System.Drawing.Color.White
        Me.LaPL_Stato.Location = New System.Drawing.Point(17, 204)
        Me.LaPL_Stato.Name = "LaPL_Stato"
        Me.LaPL_Stato.Size = New System.Drawing.Size(285, 23)
        Me.LaPL_Stato.TabIndex = 27
        Me.LaPL_Stato.Text = "Protezione basso voltaggio LED "
        '
        'InPL_Stato
        '
        Me.InPL_Stato.BackColor = System.Drawing.Color.Transparent
        Me.InPL_Stato.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InPL_Stato.ForeColor = System.Drawing.Color.White
        Me.InPL_Stato.Location = New System.Drawing.Point(315, 204)
        Me.InPL_Stato.Name = "InPL_Stato"
        Me.InPL_Stato.Size = New System.Drawing.Size(177, 23)
        Me.InPL_Stato.TabIndex = 28
        Me.InPL_Stato.Text = "Disattivo    Val.0"
        '
        'F_SerialCommand_Fan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(500, 300)
        Me.Controls.Add(Me.InPL_Stato)
        Me.Controls.Add(Me.LaPL_Stato)
        Me.Controls.Add(Me.InAudioHUB)
        Me.Controls.Add(Me.InFanHUB)
        Me.Controls.Add(Me.InLumninosità)
        Me.Controls.Add(Me.InSplitLED)
        Me.Controls.Add(Me.InPAH)
        Me.Controls.Add(Me.InPL_Swich)
        Me.Controls.Add(Me.InVelocità)
        Me.Controls.Add(Me.InModFan)
        Me.Controls.Add(Me.InROM)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LaModVentole)
        Me.Controls.Add(Me.LaVelocitàFan)
        Me.Controls.Add(Me.LaPL)
        Me.Controls.Add(Me.LaPAH)
        Me.Controls.Add(Me.LaSplitLED)
        Me.Controls.Add(Me.LaLuminosità)
        Me.Controls.Add(Me.LaStatoLED_Fan)
        Me.Controls.Add(Me.LaStatoLED_Audio)
        Me.Controls.Add(Me.LaROM)
        Me.Controls.Add(Me.BtnChiudi)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "F_SerialCommand_Fan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ArduCenterSerialData"
        CType(Me.BtnChiudi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnChiudi As PictureBox
    Friend WithEvents LaROM As Label
    Friend WithEvents LaStatoLED_Audio As Label
    Friend WithEvents LaStatoLED_Fan As Label
    Friend WithEvents LaLuminosità As Label
    Friend WithEvents LaSplitLED As Label
    Friend WithEvents LaPAH As Label
    Friend WithEvents LaPL As Label
    Friend WithEvents LaVelocitàFan As Label
    Friend WithEvents LaModVentole As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents InROM As Label
    Friend WithEvents InModFan As Label
    Friend WithEvents InVelocità As Label
    Friend WithEvents InPL_Swich As Label
    Friend WithEvents InPAH As Label
    Friend WithEvents InSplitLED As Label
    Friend WithEvents InLumninosità As Label
    Friend WithEvents InFanHUB As Label
    Friend WithEvents InAudioHUB As Label
    Friend WithEvents LaPL_Stato As Label
    Friend WithEvents InPL_Stato As Label
End Class
