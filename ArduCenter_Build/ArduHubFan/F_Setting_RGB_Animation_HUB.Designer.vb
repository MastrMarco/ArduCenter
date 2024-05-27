<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Setting_RGB_Animation_HUB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Setting_RGB_Animation_HUB))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TrackBarDelayAnimazione = New System.Windows.Forms.TrackBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TrackBarBitRateAudio = New System.Windows.Forms.TrackBar()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TrackBarAudioAmplificazione = New System.Windows.Forms.TrackBar()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.TrackBarDelayAnimazione, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarBitRateAudio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarAudioAmplificazione, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(18, 210)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(159, 21)
        Me.ComboBox1.TabIndex = 88
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(217, 213)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 14)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "???"
        '
        'TrackBarDelayAnimazione
        '
        Me.TrackBarDelayAnimazione.Enabled = False
        Me.TrackBarDelayAnimazione.Location = New System.Drawing.Point(18, 31)
        Me.TrackBarDelayAnimazione.Maximum = 155
        Me.TrackBarDelayAnimazione.Minimum = 11
        Me.TrackBarDelayAnimazione.Name = "TrackBarDelayAnimazione"
        Me.TrackBarDelayAnimazione.Size = New System.Drawing.Size(159, 45)
        Me.TrackBarDelayAnimazione.TabIndex = 92
        Me.TrackBarDelayAnimazione.TickFrequency = 0
        Me.TrackBarDelayAnimazione.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.TrackBarDelayAnimazione.Value = 11
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(194, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 93
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TrackBarBitRateAudio
        '
        Me.TrackBarBitRateAudio.Enabled = False
        Me.TrackBarBitRateAudio.Location = New System.Drawing.Point(18, 91)
        Me.TrackBarBitRateAudio.Name = "TrackBarBitRateAudio"
        Me.TrackBarBitRateAudio.Size = New System.Drawing.Size(159, 45)
        Me.TrackBarBitRateAudio.TabIndex = 94
        Me.TrackBarBitRateAudio.TickFrequency = 0
        Me.TrackBarBitRateAudio.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(194, 100)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 95
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TrackBarAudioAmplificazione
        '
        Me.TrackBarAudioAmplificazione.Enabled = False
        Me.TrackBarAudioAmplificazione.Location = New System.Drawing.Point(18, 152)
        Me.TrackBarAudioAmplificazione.Maximum = 255
        Me.TrackBarAudioAmplificazione.Minimum = 1
        Me.TrackBarAudioAmplificazione.Name = "TrackBarAudioAmplificazione"
        Me.TrackBarAudioAmplificazione.Size = New System.Drawing.Size(159, 45)
        Me.TrackBarAudioAmplificazione.TabIndex = 96
        Me.TrackBarAudioAmplificazione.TickFrequency = 0
        Me.TrackBarAudioAmplificazione.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.TrackBarAudioAmplificazione.Value = 1
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(194, 161)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 97
        Me.Button3.Text = "Default"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(14, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 13)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Regola la velocità dell'animazione"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(6, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(182, 13)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Regola la velocità del Bit rate AUDIO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Location = New System.Drawing.Point(21, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 13)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "Regola la sensibbilità dell'audio"
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(12, 253)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 101
        Me.Button4.Text = "Digitale"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.Location = New System.Drawing.Point(96, 253)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 102
        Me.Button5.Text = "Analogico"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 13)
        Me.Label5.TabIndex = 103
        Me.Label5.Text = "Seleziona sorgente Audio"
        '
        'F_Setting_RGB_Animation_HUB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 288)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TrackBarAudioAmplificazione)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TrackBarBitRateAudio)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TrackBarDelayAnimazione)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "F_Setting_RGB_Animation_HUB"
        Me.Text = "F_Setting_RGB_Animation_Fan"
        CType(Me.TrackBarDelayAnimazione, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarBitRateAudio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarAudioAmplificazione, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TrackBarDelayAnimazione As TrackBar
    Friend WithEvents Button1 As Button
    Friend WithEvents TrackBarBitRateAudio As TrackBar
    Friend WithEvents Button2 As Button
    Friend WithEvents TrackBarAudioAmplificazione As TrackBar
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label5 As Label
End Class
