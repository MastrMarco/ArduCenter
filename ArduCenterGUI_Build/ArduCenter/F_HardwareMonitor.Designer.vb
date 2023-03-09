<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_HardwareMonitor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_HardwareMonitor))
        Me.BtnChiudi = New System.Windows.Forms.Button()
        Me.PanelTaskMonitor = New System.Windows.Forms.Panel()
        Me.BtnPC = New System.Windows.Forms.Button()
        Me.BtnHUB = New System.Windows.Forms.Button()
        Me.BtnSet = New System.Windows.Forms.Button()
        Me.PanelSettings = New System.Windows.Forms.Panel()
        Me.BtnSetImp2 = New System.Windows.Forms.Button()
        Me.PrioritàForm = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TrackBarTrasparenza = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSetImp = New System.Windows.Forms.Button()
        Me.ComboBoxSpeed = New System.Windows.Forms.ComboBox()
        Me.TitoloSet = New System.Windows.Forms.Label()
        Me.PanelSettings.SuspendLayout()
        CType(Me.TrackBarTrasparenza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnChiudi
        '
        Me.BtnChiudi.BackColor = System.Drawing.Color.Transparent
        Me.BtnChiudi.BackgroundImage = Global.ArduCenter.My.Resources.Resources.BtnChiudi21
        Me.BtnChiudi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnChiudi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnChiudi.FlatAppearance.BorderSize = 0
        Me.BtnChiudi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnChiudi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnChiudi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnChiudi.Location = New System.Drawing.Point(250, 4)
        Me.BtnChiudi.Name = "BtnChiudi"
        Me.BtnChiudi.Size = New System.Drawing.Size(26, 26)
        Me.BtnChiudi.TabIndex = 0
        Me.BtnChiudi.UseVisualStyleBackColor = False
        '
        'PanelTaskMonitor
        '
        Me.PanelTaskMonitor.BackColor = System.Drawing.Color.Transparent
        Me.PanelTaskMonitor.Location = New System.Drawing.Point(0, 34)
        Me.PanelTaskMonitor.Name = "PanelTaskMonitor"
        Me.PanelTaskMonitor.Size = New System.Drawing.Size(280, 546)
        Me.PanelTaskMonitor.TabIndex = 1
        '
        'BtnPC
        '
        Me.BtnPC.BackColor = System.Drawing.Color.Transparent
        Me.BtnPC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnPC.FlatAppearance.BorderSize = 0
        Me.BtnPC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnPC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPC.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPC.ForeColor = System.Drawing.Color.Gold
        Me.BtnPC.Location = New System.Drawing.Point(12, 7)
        Me.BtnPC.Name = "BtnPC"
        Me.BtnPC.Size = New System.Drawing.Size(85, 31)
        Me.BtnPC.TabIndex = 2
        Me.BtnPC.Text = "PC"
        Me.BtnPC.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnPC.UseVisualStyleBackColor = False
        '
        'BtnHUB
        '
        Me.BtnHUB.BackColor = System.Drawing.Color.Transparent
        Me.BtnHUB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnHUB.FlatAppearance.BorderSize = 0
        Me.BtnHUB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnHUB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnHUB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHUB.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHUB.ForeColor = System.Drawing.Color.Gold
        Me.BtnHUB.Location = New System.Drawing.Point(113, 7)
        Me.BtnHUB.Name = "BtnHUB"
        Me.BtnHUB.Size = New System.Drawing.Size(85, 31)
        Me.BtnHUB.TabIndex = 3
        Me.BtnHUB.Text = "Hub"
        Me.BtnHUB.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnHUB.UseVisualStyleBackColor = False
        '
        'BtnSet
        '
        Me.BtnSet.BackColor = System.Drawing.Color.Transparent
        Me.BtnSet.BackgroundImage = Global.ArduCenter.My.Resources.Resources.BtnGUI_HomeImpostazioni
        Me.BtnSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSet.FlatAppearance.BorderSize = 0
        Me.BtnSet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSet.Location = New System.Drawing.Point(218, 4)
        Me.BtnSet.Name = "BtnSet"
        Me.BtnSet.Size = New System.Drawing.Size(26, 26)
        Me.BtnSet.TabIndex = 4
        Me.BtnSet.UseVisualStyleBackColor = False
        '
        'PanelSettings
        '
        Me.PanelSettings.BackColor = System.Drawing.Color.Transparent
        Me.PanelSettings.BackgroundImage = Global.ArduCenter.My.Resources.Resources.PanSetHardware_1_1
        Me.PanelSettings.Controls.Add(Me.BtnSetImp2)
        Me.PanelSettings.Controls.Add(Me.PrioritàForm)
        Me.PanelSettings.Controls.Add(Me.Label2)
        Me.PanelSettings.Controls.Add(Me.TrackBarTrasparenza)
        Me.PanelSettings.Controls.Add(Me.Label1)
        Me.PanelSettings.Controls.Add(Me.BtnSetImp)
        Me.PanelSettings.Controls.Add(Me.ComboBoxSpeed)
        Me.PanelSettings.Controls.Add(Me.TitoloSet)
        Me.PanelSettings.Location = New System.Drawing.Point(0, 188)
        Me.PanelSettings.Name = "PanelSettings"
        Me.PanelSettings.Size = New System.Drawing.Size(280, 220)
        Me.PanelSettings.TabIndex = 5
        Me.PanelSettings.Visible = False
        '
        'BtnSetImp2
        '
        Me.BtnSetImp2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnSetImp2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnSetImp2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSetImp2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSetImp2.ForeColor = System.Drawing.Color.Gold
        Me.BtnSetImp2.Location = New System.Drawing.Point(174, 175)
        Me.BtnSetImp2.Name = "BtnSetImp2"
        Me.BtnSetImp2.Size = New System.Drawing.Size(70, 25)
        Me.BtnSetImp2.TabIndex = 7
        Me.BtnSetImp2.Text = "Chiudi"
        Me.BtnSetImp2.UseVisualStyleBackColor = True
        '
        'PrioritàForm
        '
        Me.PrioritàForm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrioritàForm.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrioritàForm.FormattingEnabled = True
        Me.PrioritàForm.Items.AddRange(New Object() {"Prioritario", "Normale"})
        Me.PrioritàForm.Location = New System.Drawing.Point(16, 175)
        Me.PrioritàForm.Name = "PrioritàForm"
        Me.PrioritàForm.Size = New System.Drawing.Size(100, 24)
        Me.PrioritàForm.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(280, 22)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Imposta priorità finestra" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TrackBarTrasparenza
        '
        Me.TrackBarTrasparenza.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TrackBarTrasparenza.Cursor = System.Windows.Forms.Cursors.Default
        Me.TrackBarTrasparenza.Location = New System.Drawing.Point(40, 101)
        Me.TrackBarTrasparenza.Maximum = 100
        Me.TrackBarTrasparenza.Minimum = 30
        Me.TrackBarTrasparenza.Name = "TrackBarTrasparenza"
        Me.TrackBarTrasparenza.Size = New System.Drawing.Size(200, 45)
        Me.TrackBarTrasparenza.TabIndex = 4
        Me.TrackBarTrasparenza.TickFrequency = 0
        Me.TrackBarTrasparenza.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.TrackBarTrasparenza.Value = 30
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Imposta Trasparenza finestra"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSetImp
        '
        Me.BtnSetImp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnSetImp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnSetImp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSetImp.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSetImp.ForeColor = System.Drawing.Color.Gold
        Me.BtnSetImp.Location = New System.Drawing.Point(174, 41)
        Me.BtnSetImp.Name = "BtnSetImp"
        Me.BtnSetImp.Size = New System.Drawing.Size(70, 25)
        Me.BtnSetImp.TabIndex = 2
        Me.BtnSetImp.Text = "Chiudi"
        Me.BtnSetImp.UseVisualStyleBackColor = True
        '
        'ComboBoxSpeed
        '
        Me.ComboBoxSpeed.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxSpeed.FormattingEnabled = True
        Me.ComboBoxSpeed.Items.AddRange(New Object() {"Veloce", "Normale", "Lento"})
        Me.ComboBoxSpeed.Location = New System.Drawing.Point(16, 41)
        Me.ComboBoxSpeed.Name = "ComboBoxSpeed"
        Me.ComboBoxSpeed.Size = New System.Drawing.Size(100, 24)
        Me.ComboBoxSpeed.TabIndex = 1
        '
        'TitoloSet
        '
        Me.TitoloSet.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitoloSet.ForeColor = System.Drawing.Color.White
        Me.TitoloSet.Location = New System.Drawing.Point(0, 5)
        Me.TitoloSet.Name = "TitoloSet"
        Me.TitoloSet.Size = New System.Drawing.Size(280, 22)
        Me.TitoloSet.TabIndex = 0
        Me.TitoloSet.Text = "Imposta tempo di aggornamento"
        Me.TitoloSet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'F_HardwareMonitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BackgroundImage = Global.ArduCenter.My.Resources.Resources.F_HardwareMonitor
        Me.ClientSize = New System.Drawing.Size(280, 600)
        Me.Controls.Add(Me.PanelSettings)
        Me.Controls.Add(Me.BtnSet)
        Me.Controls.Add(Me.BtnChiudi)
        Me.Controls.Add(Me.PanelTaskMonitor)
        Me.Controls.Add(Me.BtnHUB)
        Me.Controls.Add(Me.BtnPC)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "F_HardwareMonitor"
        Me.Opacity = 0.95R
        Me.Text = "HardwareMonitor"
        Me.TopMost = True
        Me.PanelSettings.ResumeLayout(False)
        Me.PanelSettings.PerformLayout()
        CType(Me.TrackBarTrasparenza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnChiudi As Button
    Friend WithEvents PanelTaskMonitor As Panel
    Friend WithEvents BtnPC As Button
    Friend WithEvents BtnHUB As Button
    Friend WithEvents BtnSet As Button
    Friend WithEvents PanelSettings As Panel
    Friend WithEvents TitoloSet As Label
    Friend WithEvents ComboBoxSpeed As ComboBox
    Friend WithEvents BtnSetImp As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TrackBarTrasparenza As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents PrioritàForm As ComboBox
    Friend WithEvents BtnSetImp2 As Button
End Class
