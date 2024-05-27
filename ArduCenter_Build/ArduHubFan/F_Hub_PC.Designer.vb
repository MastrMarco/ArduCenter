<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_Hub_PC
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Hub_PC))
        Me.TrackBarLuminosità = New System.Windows.Forms.TrackBar()
        Me.TrackBarVelocità = New System.Windows.Forms.TrackBar()
        Me.LabelVelocità = New System.Windows.Forms.Label()
        Me.LabelLuminosità = New System.Windows.Forms.Label()
        Me.LabelRGBAnimazioni = New System.Windows.Forms.Label()
        Me.LabelColore = New System.Windows.Forms.Label()
        Me.BtnColor0 = New System.Windows.Forms.PictureBox()
        Me.BtnColor1 = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ModificaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PredefinitoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnColor2 = New System.Windows.Forms.PictureBox()
        Me.BtnColor3 = New System.Windows.Forms.PictureBox()
        Me.BtnColor4 = New System.Windows.Forms.PictureBox()
        Me.BtnColor5 = New System.Windows.Forms.PictureBox()
        Me.BtnColor6 = New System.Windows.Forms.PictureBox()
        Me.BtnColor7 = New System.Windows.Forms.PictureBox()
        Me.BtnFan_GUI = New System.Windows.Forms.PictureBox()
        Me.BtnMenùEX = New System.Windows.Forms.PictureBox()
        Me.BtnImpostazioniFan = New System.Windows.Forms.PictureBox()
        Me.BtnV_min = New System.Windows.Forms.Button()
        Me.BtnV_max = New System.Windows.Forms.Button()
        Me.BtnL_max = New System.Windows.Forms.Button()
        Me.BtnL_min = New System.Windows.Forms.Button()
        Me.BtnRGB0 = New System.Windows.Forms.Button()
        Me.BtnRGB1 = New System.Windows.Forms.Button()
        Me.BtnRGB2 = New System.Windows.Forms.Button()
        Me.BtnRGB3 = New System.Windows.Forms.Button()
        Me.BtnRGB4 = New System.Windows.Forms.Button()
        Me.BtnRGB5 = New System.Windows.Forms.Button()
        Me.BtnTaskHardware_GUI = New System.Windows.Forms.PictureBox()
        Me.PanelMenùHUB = New System.Windows.Forms.Panel()
        Me.Btn_Men_RGB_Animation = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.TrackBarLuminosità, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarVelocità, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnColor0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnColor1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.BtnColor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnColor3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnColor4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnColor5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnColor6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnColor7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnFan_GUI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnMenùEX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnImpostazioniFan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnTaskHardware_GUI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_Men_RGB_Animation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TrackBarLuminosità
        '
        Me.TrackBarLuminosità.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.TrackBarLuminosità.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TrackBarLuminosità.Location = New System.Drawing.Point(686, 235)
        Me.TrackBarLuminosità.Maximum = 100
        Me.TrackBarLuminosità.Minimum = 5
        Me.TrackBarLuminosità.Name = "TrackBarLuminosità"
        Me.TrackBarLuminosità.Size = New System.Drawing.Size(149, 45)
        Me.TrackBarLuminosità.TabIndex = 20
        Me.TrackBarLuminosità.TickFrequency = 0
        Me.TrackBarLuminosità.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.TrackBarLuminosità.Value = 5
        '
        'TrackBarVelocità
        '
        Me.TrackBarVelocità.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.TrackBarVelocità.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TrackBarVelocità.Location = New System.Drawing.Point(686, 179)
        Me.TrackBarVelocità.Maximum = 100
        Me.TrackBarVelocità.Name = "TrackBarVelocità"
        Me.TrackBarVelocità.Size = New System.Drawing.Size(149, 45)
        Me.TrackBarVelocità.TabIndex = 20
        Me.TrackBarVelocità.TickFrequency = 0
        Me.TrackBarVelocità.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'LabelVelocità
        '
        Me.LabelVelocità.BackColor = System.Drawing.Color.Transparent
        Me.LabelVelocità.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVelocità.ForeColor = System.Drawing.Color.White
        Me.LabelVelocità.Location = New System.Drawing.Point(655, 164)
        Me.LabelVelocità.Name = "LabelVelocità"
        Me.LabelVelocità.Size = New System.Drawing.Size(212, 18)
        Me.LabelVelocità.TabIndex = 26
        Me.LabelVelocità.Text = "-"
        Me.LabelVelocità.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelLuminosità
        '
        Me.LabelLuminosità.BackColor = System.Drawing.Color.Transparent
        Me.LabelLuminosità.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLuminosità.ForeColor = System.Drawing.Color.White
        Me.LabelLuminosità.Location = New System.Drawing.Point(657, 222)
        Me.LabelLuminosità.Name = "LabelLuminosità"
        Me.LabelLuminosità.Size = New System.Drawing.Size(209, 18)
        Me.LabelLuminosità.TabIndex = 27
        Me.LabelLuminosità.Text = "-"
        Me.LabelLuminosità.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelRGBAnimazioni
        '
        Me.LabelRGBAnimazioni.BackColor = System.Drawing.Color.Transparent
        Me.LabelRGBAnimazioni.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRGBAnimazioni.ForeColor = System.Drawing.Color.White
        Me.LabelRGBAnimazioni.Location = New System.Drawing.Point(670, 294)
        Me.LabelRGBAnimazioni.Name = "LabelRGBAnimazioni"
        Me.LabelRGBAnimazioni.Size = New System.Drawing.Size(182, 18)
        Me.LabelRGBAnimazioni.TabIndex = 28
        Me.LabelRGBAnimazioni.Text = "-"
        Me.LabelRGBAnimazioni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelColore
        '
        Me.LabelColore.BackColor = System.Drawing.Color.Transparent
        Me.LabelColore.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelColore.ForeColor = System.Drawing.Color.White
        Me.LabelColore.Location = New System.Drawing.Point(662, 76)
        Me.LabelColore.Name = "LabelColore"
        Me.LabelColore.Size = New System.Drawing.Size(199, 18)
        Me.LabelColore.TabIndex = 29
        Me.LabelColore.Text = "-"
        Me.LabelColore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnColor0
        '
        Me.BtnColor0.BackColor = System.Drawing.Color.Silver
        Me.BtnColor0.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnColor0.Location = New System.Drawing.Point(671, 103)
        Me.BtnColor0.Name = "BtnColor0"
        Me.BtnColor0.Size = New System.Drawing.Size(25, 12)
        Me.BtnColor0.TabIndex = 44
        Me.BtnColor0.TabStop = False
        '
        'BtnColor1
        '
        Me.BtnColor1.BackColor = System.Drawing.Color.Silver
        Me.BtnColor1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.BtnColor1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnColor1.Location = New System.Drawing.Point(726, 103)
        Me.BtnColor1.Name = "BtnColor1"
        Me.BtnColor1.Size = New System.Drawing.Size(25, 12)
        Me.BtnColor1.TabIndex = 45
        Me.BtnColor1.TabStop = False
        Me.BtnColor1.Tag = "Rosso"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificaToolStripMenuItem, Me.PredefinitoToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(181, 70)
        '
        'ModificaToolStripMenuItem
        '
        Me.ModificaToolStripMenuItem.Name = "ModificaToolStripMenuItem"
        Me.ModificaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ModificaToolStripMenuItem.Text = "Modifica"
        '
        'PredefinitoToolStripMenuItem
        '
        Me.PredefinitoToolStripMenuItem.Name = "PredefinitoToolStripMenuItem"
        Me.PredefinitoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PredefinitoToolStripMenuItem.Text = "Predefinito"
        '
        'BtnColor2
        '
        Me.BtnColor2.BackColor = System.Drawing.Color.Silver
        Me.BtnColor2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.BtnColor2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnColor2.Location = New System.Drawing.Point(779, 103)
        Me.BtnColor2.Name = "BtnColor2"
        Me.BtnColor2.Size = New System.Drawing.Size(25, 12)
        Me.BtnColor2.TabIndex = 46
        Me.BtnColor2.TabStop = False
        Me.BtnColor2.Tag = "Verde"
        '
        'BtnColor3
        '
        Me.BtnColor3.BackColor = System.Drawing.Color.Silver
        Me.BtnColor3.ContextMenuStrip = Me.ContextMenuStrip1
        Me.BtnColor3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnColor3.Location = New System.Drawing.Point(828, 103)
        Me.BtnColor3.Name = "BtnColor3"
        Me.BtnColor3.Size = New System.Drawing.Size(25, 12)
        Me.BtnColor3.TabIndex = 47
        Me.BtnColor3.TabStop = False
        Me.BtnColor3.Tag = "Blu"
        '
        'BtnColor4
        '
        Me.BtnColor4.BackColor = System.Drawing.Color.Silver
        Me.BtnColor4.ContextMenuStrip = Me.ContextMenuStrip1
        Me.BtnColor4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnColor4.Location = New System.Drawing.Point(671, 130)
        Me.BtnColor4.Name = "BtnColor4"
        Me.BtnColor4.Size = New System.Drawing.Size(25, 12)
        Me.BtnColor4.TabIndex = 48
        Me.BtnColor4.TabStop = False
        Me.BtnColor4.Tag = "Arancione"
        '
        'BtnColor5
        '
        Me.BtnColor5.BackColor = System.Drawing.Color.Silver
        Me.BtnColor5.ContextMenuStrip = Me.ContextMenuStrip1
        Me.BtnColor5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnColor5.Location = New System.Drawing.Point(726, 130)
        Me.BtnColor5.Name = "BtnColor5"
        Me.BtnColor5.Size = New System.Drawing.Size(25, 12)
        Me.BtnColor5.TabIndex = 49
        Me.BtnColor5.TabStop = False
        Me.BtnColor5.Tag = "Viola"
        '
        'BtnColor6
        '
        Me.BtnColor6.BackColor = System.Drawing.Color.Silver
        Me.BtnColor6.ContextMenuStrip = Me.ContextMenuStrip1
        Me.BtnColor6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnColor6.Location = New System.Drawing.Point(779, 130)
        Me.BtnColor6.Name = "BtnColor6"
        Me.BtnColor6.Size = New System.Drawing.Size(25, 12)
        Me.BtnColor6.TabIndex = 50
        Me.BtnColor6.TabStop = False
        Me.BtnColor6.Tag = "Giallo"
        '
        'BtnColor7
        '
        Me.BtnColor7.BackColor = System.Drawing.Color.Silver
        Me.BtnColor7.ContextMenuStrip = Me.ContextMenuStrip1
        Me.BtnColor7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnColor7.Location = New System.Drawing.Point(828, 130)
        Me.BtnColor7.Name = "BtnColor7"
        Me.BtnColor7.Size = New System.Drawing.Size(25, 12)
        Me.BtnColor7.TabIndex = 51
        Me.BtnColor7.TabStop = False
        Me.BtnColor7.Tag = "Celeste"
        '
        'BtnFan_GUI
        '
        Me.BtnFan_GUI.BackColor = System.Drawing.Color.Transparent
        Me.BtnFan_GUI.BackgroundImage = Global.ArduCenter.My.Resources.Resources.BtnFanPage_Indietro
        Me.BtnFan_GUI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnFan_GUI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFan_GUI.Location = New System.Drawing.Point(81, -1)
        Me.BtnFan_GUI.Name = "BtnFan_GUI"
        Me.BtnFan_GUI.Size = New System.Drawing.Size(135, 45)
        Me.BtnFan_GUI.TabIndex = 73
        Me.BtnFan_GUI.TabStop = False
        Me.BtnFan_GUI.Visible = False
        '
        'BtnMenùEX
        '
        Me.BtnMenùEX.BackColor = System.Drawing.Color.Transparent
        Me.BtnMenùEX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnMenùEX.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMenùEX.Location = New System.Drawing.Point(284, -1)
        Me.BtnMenùEX.Name = "BtnMenùEX"
        Me.BtnMenùEX.Size = New System.Drawing.Size(135, 45)
        Me.BtnMenùEX.TabIndex = 75
        Me.BtnMenùEX.TabStop = False
        Me.BtnMenùEX.Visible = False
        '
        'BtnImpostazioniFan
        '
        Me.BtnImpostazioniFan.BackColor = System.Drawing.Color.Transparent
        Me.BtnImpostazioniFan.BackgroundImage = Global.ArduCenter.My.Resources.Resources.BtnGUI_HomeImpostazioni
        Me.BtnImpostazioniFan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnImpostazioniFan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnImpostazioniFan.Location = New System.Drawing.Point(743, 3)
        Me.BtnImpostazioniFan.Name = "BtnImpostazioniFan"
        Me.BtnImpostazioniFan.Size = New System.Drawing.Size(35, 35)
        Me.BtnImpostazioniFan.TabIndex = 76
        Me.BtnImpostazioniFan.TabStop = False
        '
        'BtnV_min
        '
        Me.BtnV_min.BackColor = System.Drawing.Color.Transparent
        Me.BtnV_min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnV_min.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnV_min.FlatAppearance.BorderSize = 0
        Me.BtnV_min.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnV_min.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnV_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnV_min.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnV_min.Image = Global.ArduCenter.My.Resources.Resources.BtnVelocitàMin
        Me.BtnV_min.Location = New System.Drawing.Point(655, 186)
        Me.BtnV_min.Name = "BtnV_min"
        Me.BtnV_min.Size = New System.Drawing.Size(36, 31)
        Me.BtnV_min.TabIndex = 77
        Me.BtnV_min.UseVisualStyleBackColor = False
        '
        'BtnV_max
        '
        Me.BtnV_max.BackColor = System.Drawing.Color.Transparent
        Me.BtnV_max.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnV_max.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnV_max.FlatAppearance.BorderSize = 0
        Me.BtnV_max.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnV_max.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnV_max.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnV_max.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnV_max.Image = Global.ArduCenter.My.Resources.Resources.BtnVelocitàMax
        Me.BtnV_max.Location = New System.Drawing.Point(833, 183)
        Me.BtnV_max.Name = "BtnV_max"
        Me.BtnV_max.Size = New System.Drawing.Size(35, 36)
        Me.BtnV_max.TabIndex = 78
        Me.BtnV_max.UseVisualStyleBackColor = False
        '
        'BtnL_max
        '
        Me.BtnL_max.BackColor = System.Drawing.Color.Transparent
        Me.BtnL_max.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnL_max.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnL_max.FlatAppearance.BorderSize = 0
        Me.BtnL_max.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnL_max.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnL_max.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnL_max.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnL_max.Image = Global.ArduCenter.My.Resources.Resources.BtnLuminositàMax
        Me.BtnL_max.Location = New System.Drawing.Point(833, 240)
        Me.BtnL_max.Name = "BtnL_max"
        Me.BtnL_max.Size = New System.Drawing.Size(35, 35)
        Me.BtnL_max.TabIndex = 79
        Me.BtnL_max.UseVisualStyleBackColor = False
        '
        'BtnL_min
        '
        Me.BtnL_min.BackColor = System.Drawing.Color.Transparent
        Me.BtnL_min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnL_min.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnL_min.FlatAppearance.BorderSize = 0
        Me.BtnL_min.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnL_min.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnL_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnL_min.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnL_min.Image = Global.ArduCenter.My.Resources.Resources.BtnLuminositàMin
        Me.BtnL_min.Location = New System.Drawing.Point(656, 240)
        Me.BtnL_min.Name = "BtnL_min"
        Me.BtnL_min.Size = New System.Drawing.Size(35, 35)
        Me.BtnL_min.TabIndex = 80
        Me.BtnL_min.UseVisualStyleBackColor = False
        '
        'BtnRGB0
        '
        Me.BtnRGB0.BackColor = System.Drawing.Color.Transparent
        Me.BtnRGB0.BackgroundImage = Global.ArduCenter.My.Resources.Resources.BtnLED_Spento
        Me.BtnRGB0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnRGB0.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRGB0.FlatAppearance.BorderSize = 0
        Me.BtnRGB0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnRGB0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnRGB0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRGB0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnRGB0.Location = New System.Drawing.Point(670, 319)
        Me.BtnRGB0.Name = "BtnRGB0"
        Me.BtnRGB0.Size = New System.Drawing.Size(46, 46)
        Me.BtnRGB0.TabIndex = 81
        Me.BtnRGB0.UseVisualStyleBackColor = False
        '
        'BtnRGB1
        '
        Me.BtnRGB1.BackColor = System.Drawing.Color.Transparent
        Me.BtnRGB1.BackgroundImage = Global.ArduCenter.My.Resources.Resources.BtnLED_Transizione
        Me.BtnRGB1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnRGB1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRGB1.FlatAppearance.BorderSize = 0
        Me.BtnRGB1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnRGB1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnRGB1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRGB1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnRGB1.Location = New System.Drawing.Point(739, 319)
        Me.BtnRGB1.Name = "BtnRGB1"
        Me.BtnRGB1.Size = New System.Drawing.Size(46, 46)
        Me.BtnRGB1.TabIndex = 82
        Me.BtnRGB1.UseVisualStyleBackColor = False
        '
        'BtnRGB2
        '
        Me.BtnRGB2.BackColor = System.Drawing.Color.Transparent
        Me.BtnRGB2.BackgroundImage = CType(resources.GetObject("BtnRGB2.BackgroundImage"), System.Drawing.Image)
        Me.BtnRGB2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRGB2.FlatAppearance.BorderSize = 0
        Me.BtnRGB2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnRGB2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnRGB2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRGB2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnRGB2.Location = New System.Drawing.Point(806, 319)
        Me.BtnRGB2.Name = "BtnRGB2"
        Me.BtnRGB2.Size = New System.Drawing.Size(46, 46)
        Me.BtnRGB2.TabIndex = 83
        Me.BtnRGB2.UseVisualStyleBackColor = False
        '
        'BtnRGB3
        '
        Me.BtnRGB3.BackColor = System.Drawing.Color.Transparent
        Me.BtnRGB3.BackgroundImage = Global.ArduCenter.My.Resources.Resources.BtnLED_Temperatura
        Me.BtnRGB3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRGB3.FlatAppearance.BorderSize = 0
        Me.BtnRGB3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnRGB3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnRGB3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRGB3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnRGB3.Location = New System.Drawing.Point(670, 371)
        Me.BtnRGB3.Name = "BtnRGB3"
        Me.BtnRGB3.Size = New System.Drawing.Size(46, 46)
        Me.BtnRGB3.TabIndex = 84
        Me.BtnRGB3.UseVisualStyleBackColor = False
        '
        'BtnRGB4
        '
        Me.BtnRGB4.BackColor = System.Drawing.Color.Transparent
        Me.BtnRGB4.BackgroundImage = Global.ArduCenter.My.Resources.Resources.BtnLED_Musica
        Me.BtnRGB4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRGB4.FlatAppearance.BorderSize = 0
        Me.BtnRGB4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnRGB4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnRGB4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRGB4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnRGB4.Location = New System.Drawing.Point(739, 371)
        Me.BtnRGB4.Name = "BtnRGB4"
        Me.BtnRGB4.Size = New System.Drawing.Size(46, 46)
        Me.BtnRGB4.TabIndex = 85
        Me.BtnRGB4.UseVisualStyleBackColor = False
        '
        'BtnRGB5
        '
        Me.BtnRGB5.BackColor = System.Drawing.Color.Transparent
        Me.BtnRGB5.BackgroundImage = Global.ArduCenter.My.Resources.Resources.BtnLED_Discontinuo
        Me.BtnRGB5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRGB5.FlatAppearance.BorderSize = 0
        Me.BtnRGB5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnRGB5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnRGB5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRGB5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnRGB5.Location = New System.Drawing.Point(806, 371)
        Me.BtnRGB5.Name = "BtnRGB5"
        Me.BtnRGB5.Size = New System.Drawing.Size(46, 46)
        Me.BtnRGB5.TabIndex = 86
        Me.BtnRGB5.UseVisualStyleBackColor = False
        '
        'BtnTaskHardware_GUI
        '
        Me.BtnTaskHardware_GUI.BackColor = System.Drawing.Color.Transparent
        Me.BtnTaskHardware_GUI.BackgroundImage = Global.ArduCenter.My.Resources.Resources.Icona_Parametri_Fan
        Me.BtnTaskHardware_GUI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnTaskHardware_GUI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTaskHardware_GUI.Location = New System.Drawing.Point(568, 3)
        Me.BtnTaskHardware_GUI.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnTaskHardware_GUI.Name = "BtnTaskHardware_GUI"
        Me.BtnTaskHardware_GUI.Size = New System.Drawing.Size(35, 35)
        Me.BtnTaskHardware_GUI.TabIndex = 74
        Me.BtnTaskHardware_GUI.TabStop = False
        '
        'PanelMenùHUB
        '
        Me.PanelMenùHUB.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.PanelMenùHUB.Location = New System.Drawing.Point(23, 52)
        Me.PanelMenùHUB.Name = "PanelMenùHUB"
        Me.PanelMenùHUB.Size = New System.Drawing.Size(618, 381)
        Me.PanelMenùHUB.TabIndex = 87
        '
        'Btn_Men_RGB_Animation
        '
        Me.Btn_Men_RGB_Animation.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Men_RGB_Animation.BackgroundImage = Global.ArduCenter.My.Resources.Resources.Btn_Avanti_50x50
        Me.Btn_Men_RGB_Animation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Men_RGB_Animation.Location = New System.Drawing.Point(836, 291)
        Me.Btn_Men_RGB_Animation.Name = "Btn_Men_RGB_Animation"
        Me.Btn_Men_RGB_Animation.Size = New System.Drawing.Size(25, 25)
        Me.Btn_Men_RGB_Animation.TabIndex = 88
        Me.Btn_Men_RGB_Animation.TabStop = False
        '
        'F_Hub_PC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BackgroundImage = Global.ArduCenter.My.Resources.Resources.GUI_F_Hub_PC_0_1_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(900, 450)
        Me.Controls.Add(Me.Btn_Men_RGB_Animation)
        Me.Controls.Add(Me.PanelMenùHUB)
        Me.Controls.Add(Me.BtnRGB5)
        Me.Controls.Add(Me.BtnRGB4)
        Me.Controls.Add(Me.BtnRGB3)
        Me.Controls.Add(Me.BtnRGB2)
        Me.Controls.Add(Me.BtnRGB1)
        Me.Controls.Add(Me.BtnRGB0)
        Me.Controls.Add(Me.BtnL_max)
        Me.Controls.Add(Me.BtnV_max)
        Me.Controls.Add(Me.BtnL_min)
        Me.Controls.Add(Me.BtnV_min)
        Me.Controls.Add(Me.BtnImpostazioniFan)
        Me.Controls.Add(Me.BtnMenùEX)
        Me.Controls.Add(Me.BtnTaskHardware_GUI)
        Me.Controls.Add(Me.BtnFan_GUI)
        Me.Controls.Add(Me.BtnColor7)
        Me.Controls.Add(Me.BtnColor6)
        Me.Controls.Add(Me.BtnColor5)
        Me.Controls.Add(Me.BtnColor4)
        Me.Controls.Add(Me.BtnColor3)
        Me.Controls.Add(Me.BtnColor2)
        Me.Controls.Add(Me.BtnColor1)
        Me.Controls.Add(Me.BtnColor0)
        Me.Controls.Add(Me.LabelColore)
        Me.Controls.Add(Me.LabelRGBAnimazioni)
        Me.Controls.Add(Me.LabelLuminosità)
        Me.Controls.Add(Me.LabelVelocità)
        Me.Controls.Add(Me.TrackBarVelocità)
        Me.Controls.Add(Me.TrackBarLuminosità)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "F_Hub_PC"
        Me.Text = "F_Hub_PC"
        CType(Me.TrackBarLuminosità, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarVelocità, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnColor0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnColor1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.BtnColor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnColor3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnColor4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnColor5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnColor6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnColor7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnFan_GUI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnMenùEX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnImpostazioniFan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnTaskHardware_GUI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_Men_RGB_Animation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TrackBarLuminosità As TrackBar
    Friend WithEvents TrackBarVelocità As TrackBar
    Friend WithEvents LabelVelocità As Label
    Friend WithEvents LabelLuminosità As Label
    Friend WithEvents LabelRGBAnimazioni As Label
    Friend WithEvents LabelColore As Label
    Friend WithEvents BtnColor0 As PictureBox
    Friend WithEvents BtnColor1 As PictureBox
    Friend WithEvents BtnColor2 As PictureBox
    Friend WithEvents BtnColor3 As PictureBox
    Friend WithEvents BtnColor4 As PictureBox
    Friend WithEvents BtnColor5 As PictureBox
    Friend WithEvents BtnColor6 As PictureBox
    Friend WithEvents BtnColor7 As PictureBox
    Friend WithEvents BtnFan_GUI As PictureBox
    Friend WithEvents BtnMenùEX As PictureBox
    Friend WithEvents BtnImpostazioniFan As PictureBox
    Friend WithEvents BtnV_min As Button
    Friend WithEvents BtnV_max As Button
    Friend WithEvents BtnL_max As Button
    Friend WithEvents BtnL_min As Button
    Friend WithEvents BtnRGB0 As Button
    Friend WithEvents BtnRGB1 As Button
    Friend WithEvents BtnRGB2 As Button
    Friend WithEvents BtnRGB3 As Button
    Friend WithEvents BtnRGB4 As Button
    Friend WithEvents BtnRGB5 As Button
    Friend WithEvents BtnTaskHardware_GUI As PictureBox
    Friend WithEvents PanelMenùHUB As Panel
    Friend WithEvents Btn_Men_RGB_Animation As PictureBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ModificaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PredefinitoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
End Class
