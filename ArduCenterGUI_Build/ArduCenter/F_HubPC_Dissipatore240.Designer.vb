<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_HubPC_Dissipatore240
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
        Me.Btn_FanCPU_LED01 = New System.Windows.Forms.PictureBox()
        Me.Btn_FanCPU_LED02 = New System.Windows.Forms.PictureBox()
        Me.Btn_PompCPU_LED = New System.Windows.Forms.PictureBox()
        Me.LaSelezione = New System.Windows.Forms.Label()
        Me.LaLuminosità = New System.Windows.Forms.Label()
        Me.LaColore = New System.Windows.Forms.Label()
        Me.LaN_CPU = New System.Windows.Forms.Label()
        Me.LaN_MaderBoard = New System.Windows.Forms.Label()
        Me.LaN_GPU = New System.Windows.Forms.Label()
        Me.Btn_FanCPU_1 = New System.Windows.Forms.Label()
        Me.Btn_FanCPU_2 = New System.Windows.Forms.Label()
        Me.Btn_PompCPU = New System.Windows.Forms.Label()
        Me.IconaStatoFan_Menù_3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.Btn_FanCPU_LED01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_FanCPU_LED02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_PompCPU_LED, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconaStatoFan_Menù_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_FanCPU_LED01
        '
        Me.Btn_FanCPU_LED01.BackColor = System.Drawing.Color.Black
        Me.Btn_FanCPU_LED01.BackgroundImage = Global.ArduCenter.My.Resources.Resources.Icona_FanPO_1_3_
        Me.Btn_FanCPU_LED01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_FanCPU_LED01.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_FanCPU_LED01.Location = New System.Drawing.Point(23, 270)
        Me.Btn_FanCPU_LED01.Name = "Btn_FanCPU_LED01"
        Me.Btn_FanCPU_LED01.Size = New System.Drawing.Size(90, 90)
        Me.Btn_FanCPU_LED01.TabIndex = 0
        Me.Btn_FanCPU_LED01.TabStop = False
        '
        'Btn_FanCPU_LED02
        '
        Me.Btn_FanCPU_LED02.BackColor = System.Drawing.Color.Black
        Me.Btn_FanCPU_LED02.BackgroundImage = Global.ArduCenter.My.Resources.Resources.Icona_FanPO_1_3_
        Me.Btn_FanCPU_LED02.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_FanCPU_LED02.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_FanCPU_LED02.Location = New System.Drawing.Point(268, 273)
        Me.Btn_FanCPU_LED02.Name = "Btn_FanCPU_LED02"
        Me.Btn_FanCPU_LED02.Size = New System.Drawing.Size(90, 90)
        Me.Btn_FanCPU_LED02.TabIndex = 2
        Me.Btn_FanCPU_LED02.TabStop = False
        '
        'Btn_PompCPU_LED
        '
        Me.Btn_PompCPU_LED.BackColor = System.Drawing.Color.Transparent
        Me.Btn_PompCPU_LED.BackgroundImage = Global.ArduCenter.My.Resources.Resources.Icona_DeepCool_HSV_RGB_v1_3
        Me.Btn_PompCPU_LED.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_PompCPU_LED.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_PompCPU_LED.Location = New System.Drawing.Point(143, 273)
        Me.Btn_PompCPU_LED.Name = "Btn_PompCPU_LED"
        Me.Btn_PompCPU_LED.Size = New System.Drawing.Size(90, 90)
        Me.Btn_PompCPU_LED.TabIndex = 3
        Me.Btn_PompCPU_LED.TabStop = False
        '
        'LaSelezione
        '
        Me.LaSelezione.BackColor = System.Drawing.Color.Transparent
        Me.LaSelezione.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaSelezione.ForeColor = System.Drawing.Color.White
        Me.LaSelezione.Location = New System.Drawing.Point(20, 9)
        Me.LaSelezione.Name = "LaSelezione"
        Me.LaSelezione.Size = New System.Drawing.Size(343, 23)
        Me.LaSelezione.TabIndex = 127
        Me.LaSelezione.Text = "Colore attuale [Mod Sinc]"
        Me.LaSelezione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LaLuminosità
        '
        Me.LaLuminosità.AutoSize = True
        Me.LaLuminosità.BackColor = System.Drawing.Color.Transparent
        Me.LaLuminosità.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaLuminosità.ForeColor = System.Drawing.Color.White
        Me.LaLuminosità.Location = New System.Drawing.Point(209, 84)
        Me.LaLuminosità.Name = "LaLuminosità"
        Me.LaLuminosità.Size = New System.Drawing.Size(165, 18)
        Me.LaLuminosità.TabIndex = 128
        Me.LaLuminosità.Text = "Luminosità  100%"
        Me.LaLuminosità.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LaColore
        '
        Me.LaColore.AutoSize = True
        Me.LaColore.BackColor = System.Drawing.Color.Transparent
        Me.LaColore.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaColore.ForeColor = System.Drawing.Color.White
        Me.LaColore.Location = New System.Drawing.Point(277, 50)
        Me.LaColore.Name = "LaColore"
        Me.LaColore.Size = New System.Drawing.Size(89, 18)
        Me.LaColore.TabIndex = 129
        Me.LaColore.Text = "Arancione"
        Me.LaColore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LaN_CPU
        '
        Me.LaN_CPU.BackColor = System.Drawing.Color.Transparent
        Me.LaN_CPU.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaN_CPU.ForeColor = System.Drawing.Color.Gold
        Me.LaN_CPU.Location = New System.Drawing.Point(396, 159)
        Me.LaN_CPU.Name = "LaN_CPU"
        Me.LaN_CPU.Size = New System.Drawing.Size(210, 63)
        Me.LaN_CPU.TabIndex = 130
        Me.LaN_CPU.Text = "Nome Proccessore"
        Me.LaN_CPU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LaN_MaderBoard
        '
        Me.LaN_MaderBoard.BackColor = System.Drawing.Color.Transparent
        Me.LaN_MaderBoard.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaN_MaderBoard.ForeColor = System.Drawing.Color.Gold
        Me.LaN_MaderBoard.Location = New System.Drawing.Point(396, 40)
        Me.LaN_MaderBoard.Name = "LaN_MaderBoard"
        Me.LaN_MaderBoard.Size = New System.Drawing.Size(210, 63)
        Me.LaN_MaderBoard.TabIndex = 131
        Me.LaN_MaderBoard.Text = "Nome Scheda Madre"
        Me.LaN_MaderBoard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LaN_GPU
        '
        Me.LaN_GPU.BackColor = System.Drawing.Color.Transparent
        Me.LaN_GPU.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaN_GPU.ForeColor = System.Drawing.Color.Gold
        Me.LaN_GPU.Location = New System.Drawing.Point(396, 278)
        Me.LaN_GPU.Name = "LaN_GPU"
        Me.LaN_GPU.Size = New System.Drawing.Size(210, 63)
        Me.LaN_GPU.TabIndex = 132
        Me.LaN_GPU.Text = "Nome Scheda Video"
        Me.LaN_GPU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn_FanCPU_1
        '
        Me.Btn_FanCPU_1.AutoSize = True
        Me.Btn_FanCPU_1.BackColor = System.Drawing.Color.Transparent
        Me.Btn_FanCPU_1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_FanCPU_1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_FanCPU_1.ForeColor = System.Drawing.Color.White
        Me.Btn_FanCPU_1.Location = New System.Drawing.Point(28, 249)
        Me.Btn_FanCPU_1.Name = "Btn_FanCPU_1"
        Me.Btn_FanCPU_1.Size = New System.Drawing.Size(80, 16)
        Me.Btn_FanCPU_1.TabIndex = 133
        Me.Btn_FanCPU_1.Text = "Fan CPU 1"
        '
        'Btn_FanCPU_2
        '
        Me.Btn_FanCPU_2.AutoSize = True
        Me.Btn_FanCPU_2.BackColor = System.Drawing.Color.Transparent
        Me.Btn_FanCPU_2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_FanCPU_2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_FanCPU_2.ForeColor = System.Drawing.Color.White
        Me.Btn_FanCPU_2.Location = New System.Drawing.Point(272, 252)
        Me.Btn_FanCPU_2.Name = "Btn_FanCPU_2"
        Me.Btn_FanCPU_2.Size = New System.Drawing.Size(80, 16)
        Me.Btn_FanCPU_2.TabIndex = 134
        Me.Btn_FanCPU_2.Text = "Fan CPU 2"
        '
        'Btn_PompCPU
        '
        Me.Btn_PompCPU.AutoSize = True
        Me.Btn_PompCPU.BackColor = System.Drawing.Color.Transparent
        Me.Btn_PompCPU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_PompCPU.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_PompCPU.ForeColor = System.Drawing.Color.White
        Me.Btn_PompCPU.Location = New System.Drawing.Point(142, 249)
        Me.Btn_PompCPU.Name = "Btn_PompCPU"
        Me.Btn_PompCPU.Size = New System.Drawing.Size(90, 16)
        Me.Btn_PompCPU.TabIndex = 135
        Me.Btn_PompCPU.Text = "Pompa CPU"
        '
        'IconaStatoFan_Menù_3
        '
        Me.IconaStatoFan_Menù_3.BackColor = System.Drawing.Color.Transparent
        Me.IconaStatoFan_Menù_3.BackgroundImage = Global.ArduCenter.My.Resources.Resources.Icona_DeepCool_HSV_RGB_v1_3
        Me.IconaStatoFan_Menù_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IconaStatoFan_Menù_3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconaStatoFan_Menù_3.Location = New System.Drawing.Point(14, 31)
        Me.IconaStatoFan_Menù_3.Name = "IconaStatoFan_Menù_3"
        Me.IconaStatoFan_Menù_3.Size = New System.Drawing.Size(190, 190)
        Me.IconaStatoFan_Menù_3.TabIndex = 136
        Me.IconaStatoFan_Menù_3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.ArduCenter.My.Resources.Resources.opt
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(223, 126)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 80)
        Me.PictureBox1.TabIndex = 137
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(209, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 18)
        Me.Label2.TabIndex = 138
        Me.Label2.Text = "Colore"
        '
        'F_HubPC_Dissipatore240
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BackgroundImage = Global.ArduCenter.My.Resources.Resources.GUI_Fan_Menù_2_v21
        Me.ClientSize = New System.Drawing.Size(618, 381)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.IconaStatoFan_Menù_3)
        Me.Controls.Add(Me.Btn_FanCPU_1)
        Me.Controls.Add(Me.Btn_FanCPU_2)
        Me.Controls.Add(Me.Btn_PompCPU)
        Me.Controls.Add(Me.LaN_GPU)
        Me.Controls.Add(Me.LaN_MaderBoard)
        Me.Controls.Add(Me.LaN_CPU)
        Me.Controls.Add(Me.LaColore)
        Me.Controls.Add(Me.LaLuminosità)
        Me.Controls.Add(Me.LaSelezione)
        Me.Controls.Add(Me.Btn_PompCPU_LED)
        Me.Controls.Add(Me.Btn_FanCPU_LED02)
        Me.Controls.Add(Me.Btn_FanCPU_LED01)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_HubPC_Dissipatore240"
        Me.Text = "F_HubPC_Dissipatore240"
        CType(Me.Btn_FanCPU_LED01, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_FanCPU_LED02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_PompCPU_LED, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconaStatoFan_Menù_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_FanCPU_LED01 As PictureBox
    Friend WithEvents Btn_FanCPU_LED02 As PictureBox
    Friend WithEvents Btn_PompCPU_LED As PictureBox
    Friend WithEvents LaSelezione As Label
    Friend WithEvents LaLuminosità As Label
    Friend WithEvents LaColore As Label
    Friend WithEvents LaN_CPU As Label
    Friend WithEvents LaN_MaderBoard As Label
    Friend WithEvents LaN_GPU As Label
    Friend WithEvents Btn_FanCPU_1 As Label
    Friend WithEvents Btn_FanCPU_2 As Label
    Friend WithEvents Btn_PompCPU As Label
    Friend WithEvents IconaStatoFan_Menù_3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
End Class
