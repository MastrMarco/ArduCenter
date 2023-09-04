<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Connessione
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Connessione))
        Me.LabelSD = New System.Windows.Forms.Label()
        Me.LabelLD_COM = New System.Windows.Forms.Label()
        Me.LabelCollegamento = New System.Windows.Forms.Label()
        Me.LaStato = New System.Windows.Forms.Label()
        Me.LabelDatiSeriali = New System.Windows.Forms.Label()
        Me.LabelTX_RX = New System.Windows.Forms.Label()
        Me.LabelSoftArduino = New System.Windows.Forms.Label()
        Me.LabelSoftArduCenter = New System.Windows.Forms.Label()
        Me.LaFirmware = New System.Windows.Forms.Label()
        Me.LabelFirmware = New System.Windows.Forms.Label()
        Me.LaBoot = New System.Windows.Forms.Label()
        Me.LaSoc = New System.Windows.Forms.Label()
        Me.LabelSOC = New System.Windows.Forms.Label()
        Me.LaNomePCB = New System.Windows.Forms.Label()
        Me.LabelNome_PCB = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LaProgetto = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.LabelConnessioneAuto = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.LabelRX = New System.Windows.Forms.Label()
        Me.BtnConnettiDisconnetti = New System.Windows.Forms.PictureBox()
        Me.BtnAutoConnessione = New System.Windows.Forms.PictureBox()
        Me.S_COM = New System.Windows.Forms.ComboBox()
        Me.BtnAuto_Form = New System.Windows.Forms.PictureBox()
        Me.LabelTX = New System.Windows.Forms.Label()
        Me.BtnHardwareMonitor = New System.Windows.Forms.PictureBox()
        Me.BtnDataArduino = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnFile = New System.Windows.Forms.PictureBox()
        Me.Btn_Riavvio = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelAutoForm = New System.Windows.Forms.Label()
        Me.LaErrorDispositivo = New System.Windows.Forms.Label()
        Me.PictureBoxER_ROM = New System.Windows.Forms.PictureBox()
        Me.PictureBoxER_LED_Power = New System.Windows.Forms.PictureBox()
        Me.PictureBoxER_Power = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.BtnConnettiDisconnetti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnAutoConnessione, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnAuto_Form, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnHardwareMonitor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDataArduino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnFile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_Riavvio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxER_ROM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxER_LED_Power, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxER_Power, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelSD
        '
        Me.LabelSD.AutoSize = True
        Me.LabelSD.BackColor = System.Drawing.Color.Transparent
        Me.LabelSD.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSD.ForeColor = System.Drawing.Color.White
        Me.LabelSD.Location = New System.Drawing.Point(324, 26)
        Me.LabelSD.Name = "LabelSD"
        Me.LabelSD.Size = New System.Drawing.Size(273, 25)
        Me.LabelSD.TabIndex = 0
        Me.LabelSD.Text = "Seleziona il Dispositivo"
        '
        'LabelLD_COM
        '
        Me.LabelLD_COM.AutoSize = True
        Me.LabelLD_COM.BackColor = System.Drawing.Color.Transparent
        Me.LabelLD_COM.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLD_COM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabelLD_COM.Location = New System.Drawing.Point(330, 83)
        Me.LabelLD_COM.Name = "LabelLD_COM"
        Me.LabelLD_COM.Size = New System.Drawing.Size(168, 40)
        Me.LabelLD_COM.TabIndex = 1
        Me.LabelLD_COM.Text = "Lista Dispositivi " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "COM"
        Me.LabelLD_COM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelCollegamento
        '
        Me.LabelCollegamento.AutoSize = True
        Me.LabelCollegamento.BackColor = System.Drawing.Color.Transparent
        Me.LabelCollegamento.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCollegamento.ForeColor = System.Drawing.Color.White
        Me.LabelCollegamento.Location = New System.Drawing.Point(294, 193)
        Me.LabelCollegamento.Name = "LabelCollegamento"
        Me.LabelCollegamento.Size = New System.Drawing.Size(195, 20)
        Me.LabelCollegamento.TabIndex = 2
        Me.LabelCollegamento.Text = "Stato collegamento"
        Me.LabelCollegamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LaStato
        '
        Me.LaStato.AutoSize = True
        Me.LaStato.BackColor = System.Drawing.Color.Transparent
        Me.LaStato.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaStato.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LaStato.Location = New System.Drawing.Point(319, 226)
        Me.LaStato.Name = "LaStato"
        Me.LaStato.Size = New System.Drawing.Size(144, 23)
        Me.LaStato.TabIndex = 3
        Me.LaStato.Text = "Disconnesso"
        '
        'LabelDatiSeriali
        '
        Me.LabelDatiSeriali.BackColor = System.Drawing.Color.Transparent
        Me.LabelDatiSeriali.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDatiSeriali.ForeColor = System.Drawing.Color.White
        Me.LabelDatiSeriali.Location = New System.Drawing.Point(293, 283)
        Me.LabelDatiSeriali.Name = "LabelDatiSeriali"
        Me.LabelDatiSeriali.Size = New System.Drawing.Size(335, 23)
        Me.LabelDatiSeriali.TabIndex = 4
        Me.LabelDatiSeriali.Text = "Dati RX in Arrivo dalla Seriale"
        Me.LabelDatiSeriali.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelTX_RX
        '
        Me.LabelTX_RX.BackColor = System.Drawing.Color.Transparent
        Me.LabelTX_RX.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTX_RX.ForeColor = System.Drawing.Color.DarkOrange
        Me.LabelTX_RX.Location = New System.Drawing.Point(307, 311)
        Me.LabelTX_RX.Name = "LabelTX_RX"
        Me.LabelTX_RX.Size = New System.Drawing.Size(321, 43)
        Me.LabelTX_RX.TabIndex = 5
        Me.LabelTX_RX.Text = "Nessun Dato Ricevuto"
        Me.LabelTX_RX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelSoftArduino
        '
        Me.LabelSoftArduino.AutoSize = True
        Me.LabelSoftArduino.BackColor = System.Drawing.Color.Transparent
        Me.LabelSoftArduino.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSoftArduino.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.LabelSoftArduino.Location = New System.Drawing.Point(317, 388)
        Me.LabelSoftArduino.Name = "LabelSoftArduino"
        Me.LabelSoftArduino.Size = New System.Drawing.Size(288, 16)
        Me.LabelSoftArduino.TabIndex = 6
        Me.LabelSoftArduino.Text = "Versione Firmware di  Arduino :   V ----"
        '
        'LabelSoftArduCenter
        '
        Me.LabelSoftArduCenter.AutoSize = True
        Me.LabelSoftArduCenter.BackColor = System.Drawing.Color.Transparent
        Me.LabelSoftArduCenter.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSoftArduCenter.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.LabelSoftArduCenter.Location = New System.Drawing.Point(304, 406)
        Me.LabelSoftArduCenter.Name = "LabelSoftArduCenter"
        Me.LabelSoftArduCenter.Size = New System.Drawing.Size(312, 16)
        Me.LabelSoftArduCenter.TabIndex = 7
        Me.LabelSoftArduCenter.Text = "Versione che supporta ArduCenter : V ----"
        '
        'LaFirmware
        '
        Me.LaFirmware.AutoSize = True
        Me.LaFirmware.BackColor = System.Drawing.Color.Transparent
        Me.LaFirmware.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaFirmware.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LaFirmware.Location = New System.Drawing.Point(139, 377)
        Me.LaFirmware.Name = "LaFirmware"
        Me.LaFirmware.Size = New System.Drawing.Size(43, 18)
        Me.LaFirmware.TabIndex = 8
        Me.LaFirmware.Text = "-----"
        '
        'LabelFirmware
        '
        Me.LabelFirmware.AutoSize = True
        Me.LabelFirmware.BackColor = System.Drawing.Color.Transparent
        Me.LabelFirmware.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFirmware.ForeColor = System.Drawing.Color.White
        Me.LabelFirmware.Location = New System.Drawing.Point(119, 356)
        Me.LabelFirmware.Name = "LabelFirmware"
        Me.LabelFirmware.Size = New System.Drawing.Size(92, 18)
        Me.LabelFirmware.TabIndex = 9
        Me.LabelFirmware.Text = "Firmware"
        '
        'LaBoot
        '
        Me.LaBoot.AutoSize = True
        Me.LaBoot.BackColor = System.Drawing.Color.Transparent
        Me.LaBoot.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaBoot.ForeColor = System.Drawing.Color.DarkCyan
        Me.LaBoot.Location = New System.Drawing.Point(83, 330)
        Me.LaBoot.Name = "LaBoot"
        Me.LaBoot.Size = New System.Drawing.Size(123, 18)
        Me.LaBoot.TabIndex = 10
        Me.LaBoot.Text = "       ----------"
        Me.LaBoot.Visible = False
        '
        'LaSoc
        '
        Me.LaSoc.AutoSize = True
        Me.LaSoc.BackColor = System.Drawing.Color.Transparent
        Me.LaSoc.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaSoc.ForeColor = System.Drawing.Color.DarkCyan
        Me.LaSoc.Location = New System.Drawing.Point(98, 308)
        Me.LaSoc.Name = "LaSoc"
        Me.LaSoc.Size = New System.Drawing.Size(108, 18)
        Me.LaSoc.TabIndex = 11
        Me.LaSoc.Text = "    ----------"
        '
        'LabelSOC
        '
        Me.LabelSOC.AutoSize = True
        Me.LabelSOC.BackColor = System.Drawing.Color.Transparent
        Me.LabelSOC.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSOC.ForeColor = System.Drawing.Color.White
        Me.LabelSOC.Location = New System.Drawing.Point(138, 284)
        Me.LabelSOC.Name = "LabelSOC"
        Me.LabelSOC.Size = New System.Drawing.Size(45, 20)
        Me.LabelSOC.TabIndex = 12
        Me.LabelSOC.Text = "SoC"
        '
        'LaNomePCB
        '
        Me.LaNomePCB.AutoSize = True
        Me.LaNomePCB.BackColor = System.Drawing.Color.Transparent
        Me.LaNomePCB.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaNomePCB.ForeColor = System.Drawing.Color.DarkCyan
        Me.LaNomePCB.Location = New System.Drawing.Point(101, 247)
        Me.LaNomePCB.Name = "LaNomePCB"
        Me.LaNomePCB.Size = New System.Drawing.Size(103, 18)
        Me.LaNomePCB.TabIndex = 13
        Me.LaNomePCB.Text = "   ----------"
        '
        'LabelNome_PCB
        '
        Me.LabelNome_PCB.AutoSize = True
        Me.LabelNome_PCB.BackColor = System.Drawing.Color.Transparent
        Me.LabelNome_PCB.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNome_PCB.ForeColor = System.Drawing.Color.White
        Me.LabelNome_PCB.Location = New System.Drawing.Point(86, 224)
        Me.LabelNome_PCB.Name = "LabelNome_PCB"
        Me.LabelNome_PCB.Size = New System.Drawing.Size(156, 20)
        Me.LabelNome_PCB.TabIndex = 14
        Me.LabelNome_PCB.Text = "Tipo di Arduino"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(39, 175)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(183, 20)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Dettagli Hardware"
        '
        'LaProgetto
        '
        Me.LaProgetto.BackColor = System.Drawing.Color.Transparent
        Me.LaProgetto.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaProgetto.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LaProgetto.Location = New System.Drawing.Point(24, 60)
        Me.LaProgetto.Name = "LaProgetto"
        Me.LaProgetto.Size = New System.Drawing.Size(208, 18)
        Me.LaProgetto.TabIndex = 16
        Me.LaProgetto.Text = "-------------------------"
        Me.LaProgetto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(28, 23)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(209, 23)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "Tipo di Dispositivo"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(677, 15)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(210, 18)
        Me.Label19.TabIndex = 20
        Me.Label19.Text = "Connessione Automatica"
        '
        'LabelConnessioneAuto
        '
        Me.LabelConnessioneAuto.AutoSize = True
        Me.LabelConnessioneAuto.BackColor = System.Drawing.Color.Transparent
        Me.LabelConnessioneAuto.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelConnessioneAuto.ForeColor = System.Drawing.Color.DarkCyan
        Me.LabelConnessioneAuto.Location = New System.Drawing.Point(690, 45)
        Me.LabelConnessioneAuto.Name = "LabelConnessioneAuto"
        Me.LabelConnessioneAuto.Size = New System.Drawing.Size(81, 18)
        Me.LabelConnessioneAuto.TabIndex = 21
        Me.LabelConnessioneAuto.Text = "Disattivo"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(691, 196)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(181, 18)
        Me.Label21.TabIndex = 22
        Me.Label21.Text = "Visualizza Dati Seriali"
        '
        'LabelRX
        '
        Me.LabelRX.AutoSize = True
        Me.LabelRX.BackColor = System.Drawing.Color.Transparent
        Me.LabelRX.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelRX.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRX.ForeColor = System.Drawing.Color.Gold
        Me.LabelRX.Location = New System.Drawing.Point(724, 227)
        Me.LabelRX.Name = "LabelRX"
        Me.LabelRX.Size = New System.Drawing.Size(33, 18)
        Me.LabelRX.TabIndex = 23
        Me.LabelRX.Text = "RX"
        '
        'BtnConnettiDisconnetti
        '
        Me.BtnConnettiDisconnetti.BackColor = System.Drawing.Color.Transparent
        Me.BtnConnettiDisconnetti.BackgroundImage = Global.ArduCenter.My.Resources.Resources.BtnConnettiDisconnetti_2_0
        Me.BtnConnettiDisconnetti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnConnettiDisconnetti.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnConnettiDisconnetti.Location = New System.Drawing.Point(534, 63)
        Me.BtnConnettiDisconnetti.Name = "BtnConnettiDisconnetti"
        Me.BtnConnettiDisconnetti.Size = New System.Drawing.Size(90, 90)
        Me.BtnConnettiDisconnetti.TabIndex = 24
        Me.BtnConnettiDisconnetti.TabStop = False
        '
        'BtnAutoConnessione
        '
        Me.BtnAutoConnessione.BackColor = System.Drawing.Color.Transparent
        Me.BtnAutoConnessione.BackgroundImage = Global.ArduCenter.My.Resources.Resources.btn_Swich
        Me.BtnAutoConnessione.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAutoConnessione.Location = New System.Drawing.Point(791, 44)
        Me.BtnAutoConnessione.Name = "BtnAutoConnessione"
        Me.BtnAutoConnessione.Size = New System.Drawing.Size(70, 25)
        Me.BtnAutoConnessione.TabIndex = 25
        Me.BtnAutoConnessione.TabStop = False
        '
        'S_COM
        '
        Me.S_COM.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S_COM.FormattingEnabled = True
        Me.S_COM.Location = New System.Drawing.Point(391, 105)
        Me.S_COM.Name = "S_COM"
        Me.S_COM.Size = New System.Drawing.Size(88, 24)
        Me.S_COM.TabIndex = 26
        '
        'BtnAuto_Form
        '
        Me.BtnAuto_Form.BackColor = System.Drawing.Color.Transparent
        Me.BtnAuto_Form.BackgroundImage = Global.ArduCenter.My.Resources.Resources.btn_Swich
        Me.BtnAuto_Form.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAuto_Form.Location = New System.Drawing.Point(791, 133)
        Me.BtnAuto_Form.Name = "BtnAuto_Form"
        Me.BtnAuto_Form.Size = New System.Drawing.Size(70, 25)
        Me.BtnAuto_Form.TabIndex = 29
        Me.BtnAuto_Form.TabStop = False
        '
        'LabelTX
        '
        Me.LabelTX.AutoSize = True
        Me.LabelTX.BackColor = System.Drawing.Color.Transparent
        Me.LabelTX.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelTX.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTX.ForeColor = System.Drawing.Color.Silver
        Me.LabelTX.Location = New System.Drawing.Point(806, 227)
        Me.LabelTX.Name = "LabelTX"
        Me.LabelTX.Size = New System.Drawing.Size(32, 18)
        Me.LabelTX.TabIndex = 31
        Me.LabelTX.Text = "TX"
        '
        'BtnHardwareMonitor
        '
        Me.BtnHardwareMonitor.AccessibleName = ""
        Me.BtnHardwareMonitor.BackColor = System.Drawing.Color.Transparent
        Me.BtnHardwareMonitor.BackgroundImage = Global.ArduCenter.My.Resources.Resources.Icona_Parametri_Fan
        Me.BtnHardwareMonitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnHardwareMonitor.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnHardwareMonitor.Location = New System.Drawing.Point(758, 288)
        Me.BtnHardwareMonitor.Name = "BtnHardwareMonitor"
        Me.BtnHardwareMonitor.Size = New System.Drawing.Size(50, 50)
        Me.BtnHardwareMonitor.TabIndex = 32
        Me.BtnHardwareMonitor.TabStop = False
        Me.BtnHardwareMonitor.Tag = ""
        '
        'BtnDataArduino
        '
        Me.BtnDataArduino.BackColor = System.Drawing.Color.Transparent
        Me.BtnDataArduino.BackgroundImage = Global.ArduCenter.My.Resources.Resources.Incona_Comandi_Fan
        Me.BtnDataArduino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnDataArduino.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnDataArduino.Location = New System.Drawing.Point(681, 283)
        Me.BtnDataArduino.Name = "BtnDataArduino"
        Me.BtnDataArduino.Size = New System.Drawing.Size(60, 60)
        Me.BtnDataArduino.TabIndex = 33
        Me.BtnDataArduino.TabStop = False
        Me.BtnDataArduino.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(695, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 18)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Apertura GUI AUTO."
        '
        'BtnFile
        '
        Me.BtnFile.BackColor = System.Drawing.Color.Transparent
        Me.BtnFile.BackgroundImage = Global.ArduCenter.My.Resources.Resources.Icona_Cartella_1_1
        Me.BtnFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnFile.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnFile.Location = New System.Drawing.Point(531, 195)
        Me.BtnFile.Name = "BtnFile"
        Me.BtnFile.Size = New System.Drawing.Size(90, 60)
        Me.BtnFile.TabIndex = 35
        Me.BtnFile.TabStop = False
        '
        'Btn_Riavvio
        '
        Me.Btn_Riavvio.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Riavvio.BackgroundImage = CType(resources.GetObject("Btn_Riavvio.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Riavvio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Riavvio.Location = New System.Drawing.Point(689, 373)
        Me.Btn_Riavvio.Name = "Btn_Riavvio"
        Me.Btn_Riavvio.Size = New System.Drawing.Size(58, 58)
        Me.Btn_Riavvio.TabIndex = 36
        Me.Btn_Riavvio.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(749, 383)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 36)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Riavvio Forzato" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Dispositivo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelAutoForm
        '
        Me.LabelAutoForm.AutoSize = True
        Me.LabelAutoForm.BackColor = System.Drawing.Color.Transparent
        Me.LabelAutoForm.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAutoForm.ForeColor = System.Drawing.Color.DarkCyan
        Me.LabelAutoForm.Location = New System.Drawing.Point(690, 137)
        Me.LabelAutoForm.Name = "LabelAutoForm"
        Me.LabelAutoForm.Size = New System.Drawing.Size(81, 18)
        Me.LabelAutoForm.TabIndex = 38
        Me.LabelAutoForm.Text = "Disattivo"
        '
        'LaErrorDispositivo
        '
        Me.LaErrorDispositivo.BackColor = System.Drawing.Color.Transparent
        Me.LaErrorDispositivo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LaErrorDispositivo.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaErrorDispositivo.ForeColor = System.Drawing.Color.DarkCyan
        Me.LaErrorDispositivo.Location = New System.Drawing.Point(13, 80)
        Me.LaErrorDispositivo.Name = "LaErrorDispositivo"
        Me.LaErrorDispositivo.Size = New System.Drawing.Size(230, 23)
        Me.LaErrorDispositivo.TabIndex = 39
        Me.LaErrorDispositivo.Text = "Errori HUB: -------"
        Me.LaErrorDispositivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBoxER_ROM
        '
        Me.PictureBoxER_ROM.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxER_ROM.BackgroundImage = Global.ArduCenter.My.Resources.Resources.Icona_ROM
        Me.PictureBoxER_ROM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBoxER_ROM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxER_ROM.Location = New System.Drawing.Point(25, 101)
        Me.PictureBoxER_ROM.Name = "PictureBoxER_ROM"
        Me.PictureBoxER_ROM.Size = New System.Drawing.Size(40, 40)
        Me.PictureBoxER_ROM.TabIndex = 40
        Me.PictureBoxER_ROM.TabStop = False
        '
        'PictureBoxER_LED_Power
        '
        Me.PictureBoxER_LED_Power.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxER_LED_Power.BackgroundImage = Global.ArduCenter.My.Resources.Resources.Icone_ProtezioneLED_1_0
        Me.PictureBoxER_LED_Power.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBoxER_LED_Power.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxER_LED_Power.Location = New System.Drawing.Point(139, 101)
        Me.PictureBoxER_LED_Power.Name = "PictureBoxER_LED_Power"
        Me.PictureBoxER_LED_Power.Size = New System.Drawing.Size(40, 40)
        Me.PictureBoxER_LED_Power.TabIndex = 41
        Me.PictureBoxER_LED_Power.TabStop = False
        '
        'PictureBoxER_Power
        '
        Me.PictureBoxER_Power.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxER_Power.BackgroundImage = Global.ArduCenter.My.Resources.Resources.Icone_ProtezioneDispositivo_2_0
        Me.PictureBoxER_Power.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBoxER_Power.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxER_Power.Location = New System.Drawing.Point(82, 101)
        Me.PictureBoxER_Power.Name = "PictureBoxER_Power"
        Me.PictureBoxER_Power.Size = New System.Drawing.Size(40, 40)
        Me.PictureBoxER_Power.TabIndex = 42
        Me.PictureBoxER_Power.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox4.Location = New System.Drawing.Point(194, 101)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox4.TabIndex = 43
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'F_Connessione
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BackgroundImage = Global.ArduCenter.My.Resources.Resources.GUI_Connessione2_0_5
        Me.ClientSize = New System.Drawing.Size(900, 450)
        Me.Controls.Add(Me.LaErrorDispositivo)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBoxER_Power)
        Me.Controls.Add(Me.PictureBoxER_LED_Power)
        Me.Controls.Add(Me.PictureBoxER_ROM)
        Me.Controls.Add(Me.LabelAutoForm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btn_Riavvio)
        Me.Controls.Add(Me.BtnFile)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnDataArduino)
        Me.Controls.Add(Me.BtnHardwareMonitor)
        Me.Controls.Add(Me.LabelTX)
        Me.Controls.Add(Me.S_COM)
        Me.Controls.Add(Me.BtnAuto_Form)
        Me.Controls.Add(Me.BtnAutoConnessione)
        Me.Controls.Add(Me.BtnConnettiDisconnetti)
        Me.Controls.Add(Me.LabelRX)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.LabelConnessioneAuto)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.LaProgetto)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.LabelNome_PCB)
        Me.Controls.Add(Me.LaNomePCB)
        Me.Controls.Add(Me.LabelSOC)
        Me.Controls.Add(Me.LaSoc)
        Me.Controls.Add(Me.LaBoot)
        Me.Controls.Add(Me.LabelFirmware)
        Me.Controls.Add(Me.LaFirmware)
        Me.Controls.Add(Me.LabelSoftArduCenter)
        Me.Controls.Add(Me.LabelSoftArduino)
        Me.Controls.Add(Me.LabelTX_RX)
        Me.Controls.Add(Me.LabelDatiSeriali)
        Me.Controls.Add(Me.LaStato)
        Me.Controls.Add(Me.LabelCollegamento)
        Me.Controls.Add(Me.LabelLD_COM)
        Me.Controls.Add(Me.LabelSD)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "F_Connessione"
        Me.Text = "F_Connessione"
        CType(Me.BtnConnettiDisconnetti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnAutoConnessione, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnAuto_Form, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnHardwareMonitor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDataArduino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnFile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_Riavvio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxER_ROM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxER_LED_Power, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxER_Power, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelSD As Label
    Friend WithEvents LabelLD_COM As Label
    Friend WithEvents LabelCollegamento As Label
    Friend WithEvents LaStato As Label
    Friend WithEvents LabelDatiSeriali As Label
    Friend WithEvents LabelTX_RX As Label
    Friend WithEvents LabelSoftArduino As Label
    Friend WithEvents LabelSoftArduCenter As Label
    Friend WithEvents LaFirmware As Label
    Friend WithEvents LabelFirmware As Label
    Friend WithEvents LaBoot As Label
    Friend WithEvents LaSoc As Label
    Friend WithEvents LabelSOC As Label
    Friend WithEvents LaNomePCB As Label
    Friend WithEvents LabelNome_PCB As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents LaProgetto As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents LabelConnessioneAuto As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents LabelRX As Label
    Friend WithEvents BtnConnettiDisconnetti As PictureBox
    Friend WithEvents BtnAutoConnessione As PictureBox
    Friend WithEvents S_COM As ComboBox
    Friend WithEvents BtnAuto_Form As PictureBox
    Friend WithEvents LabelTX As Label
    Friend WithEvents BtnHardwareMonitor As PictureBox
    Friend WithEvents BtnDataArduino As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnFile As PictureBox
    Friend WithEvents Btn_Riavvio As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelAutoForm As Label
    Friend WithEvents LaErrorDispositivo As Label
    Friend WithEvents PictureBoxER_ROM As PictureBox
    Friend WithEvents PictureBoxER_LED_Power As PictureBox
    Friend WithEvents PictureBoxER_Power As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
