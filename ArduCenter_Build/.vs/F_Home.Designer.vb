<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Home))
        Me.PanBarraTop = New System.Windows.Forms.Panel()
        Me.BtnChiudi = New System.Windows.Forms.PictureBox()
        Me.BtnNascondi = New System.Windows.Forms.PictureBox()
        Me.PanForm = New System.Windows.Forms.Panel()
        Me.LabelFinestraID = New System.Windows.Forms.Label()
        Me.InVersione = New System.Windows.Forms.Label()
        Me.InV = New System.Windows.Forms.Label()
        Me.BtnImpostazioni = New System.Windows.Forms.PictureBox()
        Me.BtnAudio = New System.Windows.Forms.PictureBox()
        Me.BtnConnessione = New System.Windows.Forms.PictureBox()
        Me.BtnVentole = New System.Windows.Forms.PictureBox()
        Me.BtnProjectArduino = New System.Windows.Forms.PictureBox()
        Me.InFormHover = New System.Windows.Forms.PictureBox()
        Me.InForm = New System.Windows.Forms.PictureBox()
        Me.LaInfoSoft = New System.Windows.Forms.Label()
        Me.La_Caricamentro = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Info_ArduCenter = New System.Windows.Forms.Button()
        Me.PanBarraTop.SuspendLayout()
        CType(Me.BtnChiudi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnNascondi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnImpostazioni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnAudio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnConnessione, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnVentole, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnProjectArduino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InFormHover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanBarraTop
        '
        Me.PanBarraTop.BackColor = System.Drawing.Color.Transparent
        Me.PanBarraTop.Controls.Add(Me.BtnChiudi)
        Me.PanBarraTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanBarraTop.ForeColor = System.Drawing.Color.White
        Me.PanBarraTop.Location = New System.Drawing.Point(0, 0)
        Me.PanBarraTop.Margin = New System.Windows.Forms.Padding(0)
        Me.PanBarraTop.Name = "PanBarraTop"
        Me.PanBarraTop.Size = New System.Drawing.Size(1020, 32)
        Me.PanBarraTop.TabIndex = 2
        '
        'BtnChiudi
        '
        Me.BtnChiudi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnChiudi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnChiudi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnChiudi.Image = Global.ArduCenter.My.Resources.Resources.BtnChiudi21
        Me.BtnChiudi.Location = New System.Drawing.Point(989, 3)
        Me.BtnChiudi.Name = "BtnChiudi"
        Me.BtnChiudi.Size = New System.Drawing.Size(25, 25)
        Me.BtnChiudi.TabIndex = 6
        Me.BtnChiudi.TabStop = False
        '
        'BtnNascondi
        '
        Me.BtnNascondi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNascondi.BackColor = System.Drawing.Color.Transparent
        Me.BtnNascondi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNascondi.Image = Global.ArduCenter.My.Resources.Resources.BtnNascondi2_0
        Me.BtnNascondi.Location = New System.Drawing.Point(956, 3)
        Me.BtnNascondi.Name = "BtnNascondi"
        Me.BtnNascondi.Size = New System.Drawing.Size(25, 25)
        Me.BtnNascondi.TabIndex = 5
        Me.BtnNascondi.TabStop = False
        '
        'PanForm
        '
        Me.PanForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.PanForm.Location = New System.Drawing.Point(106, 45)
        Me.PanForm.Name = "PanForm"
        Me.PanForm.Size = New System.Drawing.Size(900, 450)
        Me.PanForm.TabIndex = 15
        '
        'LabelFinestraID
        '
        Me.LabelFinestraID.AutoSize = True
        Me.LabelFinestraID.BackColor = System.Drawing.Color.Transparent
        Me.LabelFinestraID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFinestraID.ForeColor = System.Drawing.Color.DarkOrange
        Me.LabelFinestraID.Location = New System.Drawing.Point(148, 515)
        Me.LabelFinestraID.Name = "LabelFinestraID"
        Me.LabelFinestraID.Size = New System.Drawing.Size(75, 20)
        Me.LabelFinestraID.TabIndex = 0
        Me.LabelFinestraID.Text = "Finestra"
        '
        'InVersione
        '
        Me.InVersione.AutoSize = True
        Me.InVersione.BackColor = System.Drawing.Color.Transparent
        Me.InVersione.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InVersione.ForeColor = System.Drawing.Color.Red
        Me.InVersione.Location = New System.Drawing.Point(954, 511)
        Me.InVersione.Name = "InVersione"
        Me.InVersione.Size = New System.Drawing.Size(36, 13)
        Me.InVersione.TabIndex = 16
        Me.InVersione.Text = "Beta"
        '
        'InV
        '
        Me.InV.AutoSize = True
        Me.InV.BackColor = System.Drawing.Color.Transparent
        Me.InV.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InV.ForeColor = System.Drawing.Color.Gold
        Me.InV.Location = New System.Drawing.Point(947, 525)
        Me.InV.Name = "InV"
        Me.InV.Size = New System.Drawing.Size(51, 13)
        Me.InV.TabIndex = 17
        Me.InV.Text = "V 2.0.0"
        '
        'BtnImpostazioni
        '
        Me.BtnImpostazioni.BackColor = System.Drawing.Color.Transparent
        Me.BtnImpostazioni.BackgroundImage = Global.ArduCenter.My.Resources.Resources.BtnGUI_HomeImpostazioni
        Me.BtnImpostazioni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnImpostazioni.Location = New System.Drawing.Point(13, 69)
        Me.BtnImpostazioni.Name = "BtnImpostazioni"
        Me.BtnImpostazioni.Size = New System.Drawing.Size(65, 65)
        Me.BtnImpostazioni.TabIndex = 0
        Me.BtnImpostazioni.TabStop = False
        '
        'BtnAudio
        '
        Me.BtnAudio.BackColor = System.Drawing.Color.Transparent
        Me.BtnAudio.BackgroundImage = Global.ArduCenter.My.Resources.Resources.BtnGUI_HomeAudio
        Me.BtnAudio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnAudio.Enabled = False
        Me.BtnAudio.Location = New System.Drawing.Point(13, 321)
        Me.BtnAudio.Name = "BtnAudio"
        Me.BtnAudio.Size = New System.Drawing.Size(65, 65)
        Me.BtnAudio.TabIndex = 1
        Me.BtnAudio.TabStop = False
        Me.BtnAudio.Visible = False
        '
        'BtnConnessione
        '
        Me.BtnConnessione.BackColor = System.Drawing.Color.Transparent
        Me.BtnConnessione.BackgroundImage = Global.ArduCenter.My.Resources.Resources.BtnGUI_Home
        Me.BtnConnessione.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnConnessione.Location = New System.Drawing.Point(13, 151)
        Me.BtnConnessione.Name = "BtnConnessione"
        Me.BtnConnessione.Size = New System.Drawing.Size(65, 65)
        Me.BtnConnessione.TabIndex = 2
        Me.BtnConnessione.TabStop = False
        '
        'BtnVentole
        '
        Me.BtnVentole.BackColor = System.Drawing.Color.Transparent
        Me.BtnVentole.BackgroundImage = Global.ArduCenter.My.Resources.Resources.BtnGUI_Fan
        Me.BtnVentole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnVentole.Enabled = False
        Me.BtnVentole.Location = New System.Drawing.Point(13, 236)
        Me.BtnVentole.Name = "BtnVentole"
        Me.BtnVentole.Size = New System.Drawing.Size(65, 65)
        Me.BtnVentole.TabIndex = 3
        Me.BtnVentole.TabStop = False
        '
        'BtnProjectArduino
        '
        Me.BtnProjectArduino.BackColor = System.Drawing.Color.Transparent
        Me.BtnProjectArduino.BackgroundImage = Global.ArduCenter.My.Resources.Resources.BtnGUI_HomeProject
        Me.BtnProjectArduino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnProjectArduino.Enabled = False
        Me.BtnProjectArduino.Location = New System.Drawing.Point(13, 408)
        Me.BtnProjectArduino.Name = "BtnProjectArduino"
        Me.BtnProjectArduino.Size = New System.Drawing.Size(65, 65)
        Me.BtnProjectArduino.TabIndex = 4
        Me.BtnProjectArduino.TabStop = False
        '
        'InFormHover
        '
        Me.InFormHover.BackColor = System.Drawing.Color.Gray
        Me.InFormHover.Location = New System.Drawing.Point(0, 250)
        Me.InFormHover.Name = "InFormHover"
        Me.InFormHover.Size = New System.Drawing.Size(6, 35)
        Me.InFormHover.TabIndex = 7
        Me.InFormHover.TabStop = False
        Me.InFormHover.Visible = False
        '
        'InForm
        '
        Me.InForm.BackColor = System.Drawing.Color.Gold
        Me.InForm.Location = New System.Drawing.Point(0, 166)
        Me.InForm.Name = "InForm"
        Me.InForm.Size = New System.Drawing.Size(6, 35)
        Me.InForm.TabIndex = 6
        Me.InForm.TabStop = False
        '
        'LaInfoSoft
        '
        Me.LaInfoSoft.AutoSize = True
        Me.LaInfoSoft.BackColor = System.Drawing.Color.Transparent
        Me.LaInfoSoft.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaInfoSoft.ForeColor = System.Drawing.Color.Gray
        Me.LaInfoSoft.Location = New System.Drawing.Point(4, 504)
        Me.LaInfoSoft.Name = "LaInfoSoft"
        Me.LaInfoSoft.Size = New System.Drawing.Size(82, 39)
        Me.LaInfoSoft.TabIndex = 18
        Me.LaInfoSoft.Text = "By " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MastrMarco" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Beta XX"
        Me.LaInfoSoft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'La_Caricamentro
        '
        Me.La_Caricamentro.BackColor = System.Drawing.Color.Transparent
        Me.La_Caricamentro.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.La_Caricamentro.ForeColor = System.Drawing.Color.OrangeRed
        Me.La_Caricamentro.Location = New System.Drawing.Point(107, 510)
        Me.La_Caricamentro.Name = "La_Caricamentro"
        Me.La_Caricamentro.Size = New System.Drawing.Size(892, 29)
        Me.La_Caricamentro.TabIndex = 0
        Me.La_Caricamentro.Text = "Connessione in corso Attendere..."
        Me.La_Caricamentro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.La_Caricamentro.Visible = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.BackColor = System.Drawing.Color.White
        Me.ToolTip1.ForeColor = System.Drawing.Color.Black
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.ReshowDelay = 100
        '
        'Info_ArduCenter
        '
        Me.Info_ArduCenter.BackColor = System.Drawing.Color.Transparent
        Me.Info_ArduCenter.Cursor = System.Windows.Forms.Cursors.Help
        Me.Info_ArduCenter.FlatAppearance.BorderSize = 0
        Me.Info_ArduCenter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Info_ArduCenter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Info_ArduCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Info_ArduCenter.Location = New System.Drawing.Point(12, 11)
        Me.Info_ArduCenter.Margin = New System.Windows.Forms.Padding(0)
        Me.Info_ArduCenter.Name = "Info_ArduCenter"
        Me.Info_ArduCenter.Size = New System.Drawing.Size(63, 31)
        Me.Info_ArduCenter.TabIndex = 7
        Me.Info_ArduCenter.UseVisualStyleBackColor = False
        '
        'F_Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BackgroundImage = Global.ArduCenter.My.Resources.Resources.F_Home_2_3
        Me.ClientSize = New System.Drawing.Size(1020, 550)
        Me.Controls.Add(Me.Info_ArduCenter)
        Me.Controls.Add(Me.LaInfoSoft)
        Me.Controls.Add(Me.InForm)
        Me.Controls.Add(Me.InV)
        Me.Controls.Add(Me.BtnConnessione)
        Me.Controls.Add(Me.InVersione)
        Me.Controls.Add(Me.BtnImpostazioni)
        Me.Controls.Add(Me.LabelFinestraID)
        Me.Controls.Add(Me.BtnProjectArduino)
        Me.Controls.Add(Me.BtnAudio)
        Me.Controls.Add(Me.BtnNascondi)
        Me.Controls.Add(Me.BtnVentole)
        Me.Controls.Add(Me.InFormHover)
        Me.Controls.Add(Me.PanForm)
        Me.Controls.Add(Me.La_Caricamentro)
        Me.Controls.Add(Me.PanBarraTop)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "F_Home"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ArduCenter 2.0.0V"
        Me.PanBarraTop.ResumeLayout(False)
        CType(Me.BtnChiudi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnNascondi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnImpostazioni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnAudio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnConnessione, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnVentole, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnProjectArduino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InFormHover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanBarraTop As Panel
    Friend WithEvents BtnChiudi As PictureBox
    Friend WithEvents BtnNascondi As PictureBox
    Friend WithEvents LabelFinestraID As Label
    Friend WithEvents InVersione As Label
    Friend WithEvents InV As Label
    Friend WithEvents BtnImpostazioni As PictureBox
    Friend WithEvents BtnAudio As PictureBox
    Friend WithEvents BtnConnessione As PictureBox
    Friend WithEvents BtnVentole As PictureBox
    Friend WithEvents BtnProjectArduino As PictureBox
    Friend WithEvents LaInfoSoft As Label
    Public WithEvents InFormHover As PictureBox
    Public WithEvents InForm As PictureBox
    Public WithEvents PanForm As Panel
    Friend WithEvents La_Caricamentro As Label
    Friend WithEvents Info_ArduCenter As Button
    Public WithEvents ToolTip1 As ToolTip
End Class
