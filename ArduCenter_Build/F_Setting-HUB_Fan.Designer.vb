<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Setting_HUB_Fan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Setting_HUB_Fan))
        Me.BtnChiudi = New System.Windows.Forms.PictureBox()
        Me.BtnNascondi = New System.Windows.Forms.PictureBox()
        Me.PanelFormSet = New System.Windows.Forms.Panel()
        Me.InfoSetForm = New System.Windows.Forms.Label()
        Me.BtnImpostazioni = New System.Windows.Forms.Label()
        Me.BtnVentole = New System.Windows.Forms.Label()
        Me.BtnSetGPU = New System.Windows.Forms.Label()
        Me.BtnStriscaLED = New System.Windows.Forms.Label()
        Me.BtnConnessione = New System.Windows.Forms.Label()
        CType(Me.BtnChiudi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnNascondi, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BtnChiudi.Location = New System.Drawing.Point(772, 3)
        Me.BtnChiudi.Name = "BtnChiudi"
        Me.BtnChiudi.Size = New System.Drawing.Size(25, 25)
        Me.BtnChiudi.TabIndex = 8
        Me.BtnChiudi.TabStop = False
        '
        'BtnNascondi
        '
        Me.BtnNascondi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNascondi.BackColor = System.Drawing.Color.Transparent
        Me.BtnNascondi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNascondi.Image = Global.ArduCenter.My.Resources.Resources.BtnNascondi2_0
        Me.BtnNascondi.Location = New System.Drawing.Point(739, 3)
        Me.BtnNascondi.Name = "BtnNascondi"
        Me.BtnNascondi.Size = New System.Drawing.Size(25, 25)
        Me.BtnNascondi.TabIndex = 7
        Me.BtnNascondi.TabStop = False
        '
        'PanelFormSet
        '
        Me.PanelFormSet.BackColor = System.Drawing.Color.Transparent
        Me.PanelFormSet.Location = New System.Drawing.Point(0, 37)
        Me.PanelFormSet.Name = "PanelFormSet"
        Me.PanelFormSet.Size = New System.Drawing.Size(800, 365)
        Me.PanelFormSet.TabIndex = 9
        '
        'InfoSetForm
        '
        Me.InfoSetForm.AutoSize = True
        Me.InfoSetForm.BackColor = System.Drawing.Color.Transparent
        Me.InfoSetForm.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoSetForm.ForeColor = System.Drawing.Color.White
        Me.InfoSetForm.Location = New System.Drawing.Point(8, 4)
        Me.InfoSetForm.Name = "InfoSetForm"
        Me.InfoSetForm.Size = New System.Drawing.Size(204, 18)
        Me.InfoSetForm.TabIndex = 10
        Me.InfoSetForm.Text = "Impostazioni Hub_Fan"
        '
        'BtnImpostazioni
        '
        Me.BtnImpostazioni.AutoSize = True
        Me.BtnImpostazioni.BackColor = System.Drawing.Color.Transparent
        Me.BtnImpostazioni.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImpostazioni.ForeColor = System.Drawing.Color.White
        Me.BtnImpostazioni.Location = New System.Drawing.Point(28, 420)
        Me.BtnImpostazioni.Name = "BtnImpostazioni"
        Me.BtnImpostazioni.Size = New System.Drawing.Size(121, 18)
        Me.BtnImpostazioni.TabIndex = 11
        Me.BtnImpostazioni.Text = "Impostazioni"
        '
        'BtnVentole
        '
        Me.BtnVentole.AutoSize = True
        Me.BtnVentole.BackColor = System.Drawing.Color.Transparent
        Me.BtnVentole.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVentole.ForeColor = System.Drawing.Color.White
        Me.BtnVentole.Location = New System.Drawing.Point(188, 420)
        Me.BtnVentole.Name = "BtnVentole"
        Me.BtnVentole.Size = New System.Drawing.Size(75, 18)
        Me.BtnVentole.TabIndex = 12
        Me.BtnVentole.Text = "Ventole"
        '
        'BtnSetGPU
        '
        Me.BtnSetGPU.AutoSize = True
        Me.BtnSetGPU.BackColor = System.Drawing.Color.Transparent
        Me.BtnSetGPU.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSetGPU.ForeColor = System.Drawing.Color.White
        Me.BtnSetGPU.Location = New System.Drawing.Point(304, 420)
        Me.BtnSetGPU.Name = "BtnSetGPU"
        Me.BtnSetGPU.Size = New System.Drawing.Size(126, 18)
        Me.BtnSetGPU.TabIndex = 13
        Me.BtnSetGPU.Text = "Scheda Video"
        '
        'BtnStriscaLED
        '
        Me.BtnStriscaLED.AutoSize = True
        Me.BtnStriscaLED.BackColor = System.Drawing.Color.Transparent
        Me.BtnStriscaLED.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStriscaLED.ForeColor = System.Drawing.Color.White
        Me.BtnStriscaLED.Location = New System.Drawing.Point(465, 420)
        Me.BtnStriscaLED.Name = "BtnStriscaLED"
        Me.BtnStriscaLED.Size = New System.Drawing.Size(106, 18)
        Me.BtnStriscaLED.TabIndex = 14
        Me.BtnStriscaLED.Text = "Strisca LED"
        '
        'BtnConnessione
        '
        Me.BtnConnessione.AutoSize = True
        Me.BtnConnessione.BackColor = System.Drawing.Color.Transparent
        Me.BtnConnessione.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConnessione.ForeColor = System.Drawing.Color.White
        Me.BtnConnessione.Location = New System.Drawing.Point(610, 420)
        Me.BtnConnessione.Name = "BtnConnessione"
        Me.BtnConnessione.Size = New System.Drawing.Size(161, 18)
        Me.BtnConnessione.TabIndex = 15
        Me.BtnConnessione.Text = "Controllo Remoto"
        '
        'F_Setting_HUB_Fan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BackgroundImage = Global.ArduCenter.My.Resources.Resources.F_ImpostazioniFan_1_1
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnConnessione)
        Me.Controls.Add(Me.BtnStriscaLED)
        Me.Controls.Add(Me.BtnSetGPU)
        Me.Controls.Add(Me.BtnVentole)
        Me.Controls.Add(Me.BtnImpostazioni)
        Me.Controls.Add(Me.InfoSetForm)
        Me.Controls.Add(Me.PanelFormSet)
        Me.Controls.Add(Me.BtnChiudi)
        Me.Controls.Add(Me.BtnNascondi)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "F_Setting_HUB_Fan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impostazioni F_Fan"
        CType(Me.BtnChiudi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnNascondi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnChiudi As PictureBox
    Friend WithEvents BtnNascondi As PictureBox
    Friend WithEvents PanelFormSet As Panel
    Friend WithEvents InfoSetForm As Label
    Friend WithEvents BtnImpostazioni As Label
    Friend WithEvents BtnVentole As Label
    Friend WithEvents BtnSetGPU As Label
    Friend WithEvents BtnStriscaLED As Label
    Friend WithEvents BtnConnessione As Label
End Class
