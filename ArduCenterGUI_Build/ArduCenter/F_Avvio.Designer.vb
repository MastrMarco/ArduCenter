<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_Avvio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Avvio))
        Me.SerialPortArduino = New System.IO.Ports.SerialPort(Me.components)
        Me.TimerSerialPort_TX_RX = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerTaskManager = New System.Windows.Forms.Timer(Me.components)
        Me.StatoAPP = New System.Windows.Forms.Label()
        Me.Creatore = New System.Windows.Forms.Label()
        Me.ID_Versione = New System.Windows.Forms.Label()
        Me.AnimazioneAvvioGIF = New System.Windows.Forms.PictureBox()
        Me.TimerAvvioForm = New System.Windows.Forms.Timer(Me.components)
        Me.TimerBoot_Reset = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorkerTaskMenager = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorkerSerialPort = New System.ComponentModel.BackgroundWorker()
        CType(Me.AnimazioneAvvioGIF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TimerSerialPort_TX_RX
        '
        Me.TimerSerialPort_TX_RX.Interval = 30
        '
        'TimerTaskManager
        '
        Me.TimerTaskManager.Enabled = True
        Me.TimerTaskManager.Interval = 1500
        '
        'StatoAPP
        '
        Me.StatoAPP.AutoSize = True
        Me.StatoAPP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatoAPP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StatoAPP.Location = New System.Drawing.Point(0, 230)
        Me.StatoAPP.Name = "StatoAPP"
        Me.StatoAPP.Size = New System.Drawing.Size(35, 16)
        Me.StatoAPP.TabIndex = 5
        Me.StatoAPP.Text = "xxxx"
        '
        'Creatore
        '
        Me.Creatore.AutoSize = True
        Me.Creatore.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Creatore.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Creatore.Location = New System.Drawing.Point(372, 230)
        Me.Creatore.Name = "Creatore"
        Me.Creatore.Size = New System.Drawing.Size(43, 16)
        Me.Creatore.TabIndex = 4
        Me.Creatore.Text = "xxxx"
        '
        'ID_Versione
        '
        Me.ID_Versione.AutoSize = True
        Me.ID_Versione.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_Versione.ForeColor = System.Drawing.Color.Gray
        Me.ID_Versione.Location = New System.Drawing.Point(173, 232)
        Me.ID_Versione.Name = "ID_Versione"
        Me.ID_Versione.Size = New System.Drawing.Size(115, 14)
        Me.ID_Versione.TabIndex = 3
        Me.ID_Versione.Text = "xxxx  gg-mm-aa"
        '
        'AnimazioneAvvioGIF
        '
        Me.AnimazioneAvvioGIF.BackgroundImage = Global.ArduCenter.My.Resources.Resources.ImgArduCenter2_0
        Me.AnimazioneAvvioGIF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AnimazioneAvvioGIF.Enabled = False
        Me.AnimazioneAvvioGIF.Location = New System.Drawing.Point(0, 0)
        Me.AnimazioneAvvioGIF.Name = "AnimazioneAvvioGIF"
        Me.AnimazioneAvvioGIF.Size = New System.Drawing.Size(463, 249)
        Me.AnimazioneAvvioGIF.TabIndex = 6
        Me.AnimazioneAvvioGIF.TabStop = False
        Me.AnimazioneAvvioGIF.Visible = False
        '
        'TimerAvvioForm
        '
        Me.TimerAvvioForm.Interval = 3000
        '
        'TimerBoot_Reset
        '
        Me.TimerBoot_Reset.Interval = 200
        '
        'BackgroundWorkerSerialPort
        '
        '
        'F_Avvio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BackgroundImage = Global.ArduCenter.My.Resources.Resources.ImgArduCenter2_0
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(463, 249)
        Me.Controls.Add(Me.StatoAPP)
        Me.Controls.Add(Me.Creatore)
        Me.Controls.Add(Me.ID_Versione)
        Me.Controls.Add(Me.AnimazioneAvvioGIF)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "F_Avvio"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ArduCenter"
        CType(Me.AnimazioneAvvioGIF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPortArduino As IO.Ports.SerialPort
    Friend WithEvents TimerSerialPort_TX_RX As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents TimerTaskManager As Timer
    Friend WithEvents StatoAPP As Label
    Friend WithEvents Creatore As Label
    Friend WithEvents ID_Versione As Label
    Friend WithEvents AnimazioneAvvioGIF As PictureBox
    Friend WithEvents TimerAvvioForm As Timer
    Friend WithEvents TimerBoot_Reset As Timer
    Friend WithEvents BackgroundWorkerTaskMenager As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorkerSerialPort As System.ComponentModel.BackgroundWorker
End Class
