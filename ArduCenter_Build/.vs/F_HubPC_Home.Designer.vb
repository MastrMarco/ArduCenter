<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_HubPC_Home
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
        Me.Btn_F_HubPC_SLED = New System.Windows.Forms.Button()
        Me.Btn_F_HubPC_GPU = New System.Windows.Forms.Button()
        Me.Btn_F_HubPC_Ventole = New System.Windows.Forms.Button()
        Me.La_GPU = New System.Windows.Forms.Label()
        Me.La_SLED = New System.Windows.Forms.Label()
        Me.La_Ventole = New System.Windows.Forms.Label()
        Me.Btn_F_HubPC_Dissipatore = New System.Windows.Forms.Button()
        Me.La_Dissipatore = New System.Windows.Forms.Label()
        Me.La_CasseAudio = New System.Windows.Forms.Label()
        Me.Btn_F_HubPC_CasseAudio = New System.Windows.Forms.Button()
        Me.La_SyncMode = New System.Windows.Forms.Label()
        Me.Btn_Hub_SyncMode = New System.Windows.Forms.Button()
        Me.LoopAutoSetColor = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Btn_F_HubPC_SLED
        '
        Me.Btn_F_HubPC_SLED.BackColor = System.Drawing.Color.Lime
        Me.Btn_F_HubPC_SLED.BackgroundImage = Global.ArduCenter.My.Resources.Resources.Icona_Strisca__RGB_Colore_HSV_RGB_2_2_2
        Me.Btn_F_HubPC_SLED.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_F_HubPC_SLED.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_F_HubPC_SLED.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue
        Me.Btn_F_HubPC_SLED.FlatAppearance.BorderSize = 0
        Me.Btn_F_HubPC_SLED.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_F_HubPC_SLED.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_F_HubPC_SLED.Location = New System.Drawing.Point(383, 236)
        Me.Btn_F_HubPC_SLED.Margin = New System.Windows.Forms.Padding(0)
        Me.Btn_F_HubPC_SLED.Name = "Btn_F_HubPC_SLED"
        Me.Btn_F_HubPC_SLED.Size = New System.Drawing.Size(201, 109)
        Me.Btn_F_HubPC_SLED.TabIndex = 0
        Me.Btn_F_HubPC_SLED.UseVisualStyleBackColor = False
        '
        'Btn_F_HubPC_GPU
        '
        Me.Btn_F_HubPC_GPU.BackColor = System.Drawing.Color.Lime
        Me.Btn_F_HubPC_GPU.BackgroundImage = Global.ArduCenter.My.Resources.Resources.Icona_SchedaVideo_RGB_Colore_HSV_RGB_2_1
        Me.Btn_F_HubPC_GPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_F_HubPC_GPU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_F_HubPC_GPU.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue
        Me.Btn_F_HubPC_GPU.FlatAppearance.BorderSize = 0
        Me.Btn_F_HubPC_GPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_F_HubPC_GPU.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_F_HubPC_GPU.Location = New System.Drawing.Point(383, 53)
        Me.Btn_F_HubPC_GPU.Margin = New System.Windows.Forms.Padding(0)
        Me.Btn_F_HubPC_GPU.Name = "Btn_F_HubPC_GPU"
        Me.Btn_F_HubPC_GPU.Size = New System.Drawing.Size(201, 109)
        Me.Btn_F_HubPC_GPU.TabIndex = 1
        Me.Btn_F_HubPC_GPU.UseVisualStyleBackColor = False
        '
        'Btn_F_HubPC_Ventole
        '
        Me.Btn_F_HubPC_Ventole.BackColor = System.Drawing.Color.Lime
        Me.Btn_F_HubPC_Ventole.BackgroundImage = Global.ArduCenter.My.Resources.Resources.IconaFan_RGB_Colore_HSV_RGB_2_0
        Me.Btn_F_HubPC_Ventole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_F_HubPC_Ventole.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_F_HubPC_Ventole.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue
        Me.Btn_F_HubPC_Ventole.FlatAppearance.BorderSize = 0
        Me.Btn_F_HubPC_Ventole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_F_HubPC_Ventole.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_F_HubPC_Ventole.Location = New System.Drawing.Point(32, 53)
        Me.Btn_F_HubPC_Ventole.Margin = New System.Windows.Forms.Padding(0)
        Me.Btn_F_HubPC_Ventole.Name = "Btn_F_HubPC_Ventole"
        Me.Btn_F_HubPC_Ventole.Size = New System.Drawing.Size(109, 109)
        Me.Btn_F_HubPC_Ventole.TabIndex = 2
        Me.Btn_F_HubPC_Ventole.UseVisualStyleBackColor = False
        '
        'La_GPU
        '
        Me.La_GPU.AutoSize = True
        Me.La_GPU.BackColor = System.Drawing.Color.Transparent
        Me.La_GPU.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.La_GPU.ForeColor = System.Drawing.Color.DarkGray
        Me.La_GPU.Location = New System.Drawing.Point(416, 25)
        Me.La_GPU.Name = "La_GPU"
        Me.La_GPU.Size = New System.Drawing.Size(126, 18)
        Me.La_GPU.TabIndex = 3
        Me.La_GPU.Text = "Scheda Video"
        '
        'La_SLED
        '
        Me.La_SLED.AutoSize = True
        Me.La_SLED.BackColor = System.Drawing.Color.Transparent
        Me.La_SLED.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.La_SLED.ForeColor = System.Drawing.Color.DarkGray
        Me.La_SLED.Location = New System.Drawing.Point(416, 207)
        Me.La_SLED.Name = "La_SLED"
        Me.La_SLED.Size = New System.Drawing.Size(135, 18)
        Me.La_SLED.TabIndex = 4
        Me.La_SLED.Text = "Strisca LED PC"
        '
        'La_Ventole
        '
        Me.La_Ventole.AutoSize = True
        Me.La_Ventole.BackColor = System.Drawing.Color.Transparent
        Me.La_Ventole.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.La_Ventole.ForeColor = System.Drawing.Color.DarkGray
        Me.La_Ventole.Location = New System.Drawing.Point(37, 25)
        Me.La_Ventole.Name = "La_Ventole"
        Me.La_Ventole.Size = New System.Drawing.Size(104, 18)
        Me.La_Ventole.TabIndex = 5
        Me.La_Ventole.Text = "Ventole PC"
        '
        'Btn_F_HubPC_Dissipatore
        '
        Me.Btn_F_HubPC_Dissipatore.BackColor = System.Drawing.Color.Lime
        Me.Btn_F_HubPC_Dissipatore.BackgroundImage = Global.ArduCenter.My.Resources.Resources.Dissipatore240mm_HSV_v1_1
        Me.Btn_F_HubPC_Dissipatore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_F_HubPC_Dissipatore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_F_HubPC_Dissipatore.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue
        Me.Btn_F_HubPC_Dissipatore.FlatAppearance.BorderSize = 0
        Me.Btn_F_HubPC_Dissipatore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_F_HubPC_Dissipatore.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_F_HubPC_Dissipatore.Location = New System.Drawing.Point(173, 53)
        Me.Btn_F_HubPC_Dissipatore.Margin = New System.Windows.Forms.Padding(0)
        Me.Btn_F_HubPC_Dissipatore.Name = "Btn_F_HubPC_Dissipatore"
        Me.Btn_F_HubPC_Dissipatore.Size = New System.Drawing.Size(177, 109)
        Me.Btn_F_HubPC_Dissipatore.TabIndex = 6
        Me.Btn_F_HubPC_Dissipatore.UseVisualStyleBackColor = False
        '
        'La_Dissipatore
        '
        Me.La_Dissipatore.AutoSize = True
        Me.La_Dissipatore.BackColor = System.Drawing.Color.Transparent
        Me.La_Dissipatore.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.La_Dissipatore.ForeColor = System.Drawing.Color.DarkGray
        Me.La_Dissipatore.Location = New System.Drawing.Point(196, 25)
        Me.La_Dissipatore.Name = "La_Dissipatore"
        Me.La_Dissipatore.Size = New System.Drawing.Size(135, 18)
        Me.La_Dissipatore.TabIndex = 7
        Me.La_Dissipatore.Text = "Dissipatore PC"
        '
        'La_CasseAudio
        '
        Me.La_CasseAudio.AutoSize = True
        Me.La_CasseAudio.BackColor = System.Drawing.Color.Transparent
        Me.La_CasseAudio.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.La_CasseAudio.ForeColor = System.Drawing.Color.DarkGray
        Me.La_CasseAudio.Location = New System.Drawing.Point(213, 207)
        Me.La_CasseAudio.Name = "La_CasseAudio"
        Me.La_CasseAudio.Size = New System.Drawing.Size(114, 18)
        Me.La_CasseAudio.TabIndex = 8
        Me.La_CasseAudio.Text = "Casse Audio"
        '
        'Btn_F_HubPC_CasseAudio
        '
        Me.Btn_F_HubPC_CasseAudio.BackColor = System.Drawing.Color.Lime
        Me.Btn_F_HubPC_CasseAudio.BackgroundImage = Global.ArduCenter.My.Resources.Resources.IconaCasaAudio_RGB_Colore_HSV_RGB
        Me.Btn_F_HubPC_CasseAudio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_F_HubPC_CasseAudio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_F_HubPC_CasseAudio.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue
        Me.Btn_F_HubPC_CasseAudio.FlatAppearance.BorderSize = 0
        Me.Btn_F_HubPC_CasseAudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_F_HubPC_CasseAudio.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_F_HubPC_CasseAudio.Location = New System.Drawing.Point(240, 236)
        Me.Btn_F_HubPC_CasseAudio.Margin = New System.Windows.Forms.Padding(0)
        Me.Btn_F_HubPC_CasseAudio.Name = "Btn_F_HubPC_CasseAudio"
        Me.Btn_F_HubPC_CasseAudio.Size = New System.Drawing.Size(63, 109)
        Me.Btn_F_HubPC_CasseAudio.TabIndex = 9
        Me.Btn_F_HubPC_CasseAudio.UseVisualStyleBackColor = False
        '
        'La_SyncMode
        '
        Me.La_SyncMode.AutoSize = True
        Me.La_SyncMode.BackColor = System.Drawing.Color.Transparent
        Me.La_SyncMode.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.La_SyncMode.ForeColor = System.Drawing.Color.DarkGray
        Me.La_SyncMode.Location = New System.Drawing.Point(39, 207)
        Me.La_SyncMode.Name = "La_SyncMode"
        Me.La_SyncMode.Size = New System.Drawing.Size(102, 18)
        Me.La_SyncMode.TabIndex = 10
        Me.La_SyncMode.Text = "Sync Mode"
        '
        'Btn_Hub_SyncMode
        '
        Me.Btn_Hub_SyncMode.BackColor = System.Drawing.Color.Lime
        Me.Btn_Hub_SyncMode.BackgroundImage = Global.ArduCenter.My.Resources.Resources.Icona_HUB_1_1
        Me.Btn_Hub_SyncMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_Hub_SyncMode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Hub_SyncMode.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue
        Me.Btn_Hub_SyncMode.FlatAppearance.BorderSize = 0
        Me.Btn_Hub_SyncMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Hub_SyncMode.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Hub_SyncMode.Location = New System.Drawing.Point(56, 236)
        Me.Btn_Hub_SyncMode.Margin = New System.Windows.Forms.Padding(0)
        Me.Btn_Hub_SyncMode.Name = "Btn_Hub_SyncMode"
        Me.Btn_Hub_SyncMode.Size = New System.Drawing.Size(62, 109)
        Me.Btn_Hub_SyncMode.TabIndex = 11
        Me.Btn_Hub_SyncMode.UseVisualStyleBackColor = False
        '
        'LoopAutoSetColor
        '
        Me.LoopAutoSetColor.Enabled = True
        Me.LoopAutoSetColor.Interval = 1000
        '
        'F_HubPC_Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BackgroundImage = Global.ArduCenter.My.Resources.Resources.GUI_F_HubPC_Home_0_1_2
        Me.ClientSize = New System.Drawing.Size(618, 381)
        Me.Controls.Add(Me.Btn_Hub_SyncMode)
        Me.Controls.Add(Me.La_SyncMode)
        Me.Controls.Add(Me.Btn_F_HubPC_CasseAudio)
        Me.Controls.Add(Me.La_CasseAudio)
        Me.Controls.Add(Me.La_Dissipatore)
        Me.Controls.Add(Me.Btn_F_HubPC_Dissipatore)
        Me.Controls.Add(Me.La_Ventole)
        Me.Controls.Add(Me.La_SLED)
        Me.Controls.Add(Me.La_GPU)
        Me.Controls.Add(Me.Btn_F_HubPC_Ventole)
        Me.Controls.Add(Me.Btn_F_HubPC_GPU)
        Me.Controls.Add(Me.Btn_F_HubPC_SLED)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_HubPC_Home"
        Me.Text = "F_HubPC_Home"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_F_HubPC_SLED As Button
    Friend WithEvents Btn_F_HubPC_GPU As Button
    Friend WithEvents Btn_F_HubPC_Ventole As Button
    Friend WithEvents La_GPU As Label
    Friend WithEvents La_SLED As Label
    Friend WithEvents La_Ventole As Label
    Friend WithEvents Btn_F_HubPC_Dissipatore As Button
    Friend WithEvents La_Dissipatore As Label
    Friend WithEvents La_CasseAudio As Label
    Friend WithEvents Btn_F_HubPC_CasseAudio As Button
    Friend WithEvents La_SyncMode As Label
    Friend WithEvents Btn_Hub_SyncMode As Button
    Friend WithEvents LoopAutoSetColor As Timer
End Class
