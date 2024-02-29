<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Impostazioni
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
        Me.SetLingua = New System.Windows.Forms.ComboBox()
        Me.La_lingua = New System.Windows.Forms.Label()
        Me.BoxDonazione = New System.Windows.Forms.PictureBox()
        Me.LaInfoSoft = New System.Windows.Forms.Label()
        Me.LaSartSoft = New System.Windows.Forms.Label()
        Me.LaTema = New System.Windows.Forms.Label()
        Me.SetTema = New System.Windows.Forms.ComboBox()
        Me.LaCredit = New System.Windows.Forms.Label()
        Me.LaInfoData = New System.Windows.Forms.Label()
        Me.BtnAutoConnessione = New System.Windows.Forms.PictureBox()
        Me.LaStatoAvvioAuto = New System.Windows.Forms.Label()
        Me.LaCreatore = New System.Windows.Forms.Label()
        Me.LaSupporto = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.BoxDonazione, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnAutoConnessione, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SetLingua
        '
        Me.SetLingua.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SetLingua.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetLingua.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetLingua.FormattingEnabled = True
        Me.SetLingua.Items.AddRange(New Object() {"Italiano", "English"})
        Me.SetLingua.Location = New System.Drawing.Point(662, 90)
        Me.SetLingua.Name = "SetLingua"
        Me.SetLingua.Size = New System.Drawing.Size(121, 24)
        Me.SetLingua.TabIndex = 1
        '
        'La_lingua
        '
        Me.La_lingua.BackColor = System.Drawing.Color.Transparent
        Me.La_lingua.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.La_lingua.ForeColor = System.Drawing.Color.White
        Me.La_lingua.Location = New System.Drawing.Point(609, 35)
        Me.La_lingua.Name = "La_lingua"
        Me.La_lingua.Size = New System.Drawing.Size(222, 24)
        Me.La_lingua.TabIndex = 2
        Me.La_lingua.Text = "Lingua"
        Me.La_lingua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BoxDonazione
        '
        Me.BoxDonazione.BackColor = System.Drawing.Color.Transparent
        Me.BoxDonazione.BackgroundImage = Global.ArduCenter.My.Resources.Resources.photo_2023_11_24_17_00_32
        Me.BoxDonazione.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BoxDonazione.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BoxDonazione.Location = New System.Drawing.Point(64, 274)
        Me.BoxDonazione.Name = "BoxDonazione"
        Me.BoxDonazione.Size = New System.Drawing.Size(238, 118)
        Me.BoxDonazione.TabIndex = 3
        Me.BoxDonazione.TabStop = False
        '
        'LaInfoSoft
        '
        Me.LaInfoSoft.BackColor = System.Drawing.Color.Transparent
        Me.LaInfoSoft.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaInfoSoft.ForeColor = System.Drawing.Color.White
        Me.LaInfoSoft.Location = New System.Drawing.Point(558, 214)
        Me.LaInfoSoft.Name = "LaInfoSoft"
        Me.LaInfoSoft.Size = New System.Drawing.Size(314, 24)
        Me.LaInfoSoft.TabIndex = 4
        Me.LaInfoSoft.Text = "Info"
        Me.LaInfoSoft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LaSartSoft
        '
        Me.LaSartSoft.BackColor = System.Drawing.Color.Transparent
        Me.LaSartSoft.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaSartSoft.ForeColor = System.Drawing.Color.White
        Me.LaSartSoft.Location = New System.Drawing.Point(335, 36)
        Me.LaSartSoft.Name = "LaSartSoft"
        Me.LaSartSoft.Size = New System.Drawing.Size(224, 24)
        Me.LaSartSoft.TabIndex = 5
        Me.LaSartSoft.Text = "Auto Avvio"
        Me.LaSartSoft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LaTema
        '
        Me.LaTema.BackColor = System.Drawing.Color.Transparent
        Me.LaTema.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaTema.ForeColor = System.Drawing.Color.White
        Me.LaTema.Location = New System.Drawing.Point(65, 35)
        Me.LaTema.Name = "LaTema"
        Me.LaTema.Size = New System.Drawing.Size(222, 24)
        Me.LaTema.TabIndex = 6
        Me.LaTema.Text = "Tema"
        Me.LaTema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SetTema
        '
        Me.SetTema.Enabled = False
        Me.SetTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetTema.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetTema.FormattingEnabled = True
        Me.SetTema.Items.AddRange(New Object() {"Tema Scuro"})
        Me.SetTema.Location = New System.Drawing.Point(116, 90)
        Me.SetTema.Name = "SetTema"
        Me.SetTema.Size = New System.Drawing.Size(121, 24)
        Me.SetTema.TabIndex = 7
        Me.SetTema.Text = "Tema Scuro"
        '
        'LaCredit
        '
        Me.LaCredit.BackColor = System.Drawing.Color.Transparent
        Me.LaCredit.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaCredit.ForeColor = System.Drawing.Color.White
        Me.LaCredit.Location = New System.Drawing.Point(26, 214)
        Me.LaCredit.Name = "LaCredit"
        Me.LaCredit.Size = New System.Drawing.Size(313, 24)
        Me.LaCredit.TabIndex = 8
        Me.LaCredit.Text = "Crediti"
        Me.LaCredit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LaInfoData
        '
        Me.LaInfoData.BackColor = System.Drawing.Color.Transparent
        Me.LaInfoData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LaInfoData.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaInfoData.ForeColor = System.Drawing.Color.White
        Me.LaInfoData.Location = New System.Drawing.Point(562, 247)
        Me.LaInfoData.Margin = New System.Windows.Forms.Padding(0)
        Me.LaInfoData.Name = "LaInfoData"
        Me.LaInfoData.Size = New System.Drawing.Size(310, 172)
        Me.LaInfoData.TabIndex = 9
        Me.LaInfoData.Text = "-"
        Me.LaInfoData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnAutoConnessione
        '
        Me.BtnAutoConnessione.BackColor = System.Drawing.Color.Transparent
        Me.BtnAutoConnessione.BackgroundImage = Global.ArduCenter.My.Resources.Resources.btn_Swich
        Me.BtnAutoConnessione.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAutoConnessione.Enabled = False
        Me.BtnAutoConnessione.Location = New System.Drawing.Point(414, 82)
        Me.BtnAutoConnessione.Name = "BtnAutoConnessione"
        Me.BtnAutoConnessione.Size = New System.Drawing.Size(70, 25)
        Me.BtnAutoConnessione.TabIndex = 27
        Me.BtnAutoConnessione.TabStop = False
        '
        'LaStatoAvvioAuto
        '
        Me.LaStatoAvvioAuto.BackColor = System.Drawing.Color.Transparent
        Me.LaStatoAvvioAuto.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaStatoAvvioAuto.ForeColor = System.Drawing.Color.DarkCyan
        Me.LaStatoAvvioAuto.Location = New System.Drawing.Point(339, 124)
        Me.LaStatoAvvioAuto.Name = "LaStatoAvvioAuto"
        Me.LaStatoAvvioAuto.Size = New System.Drawing.Size(220, 18)
        Me.LaStatoAvvioAuto.TabIndex = 26
        Me.LaStatoAvvioAuto.Text = "Disattivo"
        Me.LaStatoAvvioAuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LaCreatore
        '
        Me.LaCreatore.BackColor = System.Drawing.Color.Transparent
        Me.LaCreatore.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaCreatore.ForeColor = System.Drawing.Color.White
        Me.LaCreatore.Location = New System.Drawing.Point(30, 247)
        Me.LaCreatore.Name = "LaCreatore"
        Me.LaCreatore.Size = New System.Drawing.Size(309, 24)
        Me.LaCreatore.TabIndex = 28
        Me.LaCreatore.Text = "Creatore MastrMarco"
        Me.LaCreatore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LaSupporto
        '
        Me.LaSupporto.BackColor = System.Drawing.Color.Transparent
        Me.LaSupporto.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaSupporto.ForeColor = System.Drawing.Color.White
        Me.LaSupporto.Location = New System.Drawing.Point(30, 395)
        Me.LaSupporto.Name = "LaSupporto"
        Me.LaSupporto.Size = New System.Drawing.Size(309, 24)
        Me.LaSupporto.TabIndex = 29
        Me.LaSupporto.Text = "Supporta con una donazione"
        Me.LaSupporto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 14)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Beta"
        '
        'F_Impostazioni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BackgroundImage = Global.ArduCenter.My.Resources.Resources.GUI_Impostazioni
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(900, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LaSupporto)
        Me.Controls.Add(Me.LaCreatore)
        Me.Controls.Add(Me.BtnAutoConnessione)
        Me.Controls.Add(Me.LaStatoAvvioAuto)
        Me.Controls.Add(Me.LaInfoData)
        Me.Controls.Add(Me.LaCredit)
        Me.Controls.Add(Me.SetTema)
        Me.Controls.Add(Me.LaTema)
        Me.Controls.Add(Me.LaSartSoft)
        Me.Controls.Add(Me.LaInfoSoft)
        Me.Controls.Add(Me.BoxDonazione)
        Me.Controls.Add(Me.La_lingua)
        Me.Controls.Add(Me.SetLingua)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_Impostazioni"
        Me.Text = "F_Impostazioni"
        CType(Me.BoxDonazione, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnAutoConnessione, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SetLingua As ComboBox
    Friend WithEvents La_lingua As Label
    Friend WithEvents BoxDonazione As PictureBox
    Friend WithEvents LaInfoSoft As Label
    Friend WithEvents LaSartSoft As Label
    Friend WithEvents LaTema As Label
    Friend WithEvents SetTema As ComboBox
    Friend WithEvents LaCredit As Label
    Friend WithEvents LaInfoData As Label
    Friend WithEvents BtnAutoConnessione As PictureBox
    Friend WithEvents LaStatoAvvioAuto As Label
    Friend WithEvents LaCreatore As Label
    Friend WithEvents LaSupporto As Label
    Friend WithEvents Label2 As Label
End Class
