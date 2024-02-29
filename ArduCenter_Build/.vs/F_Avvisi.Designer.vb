<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Avvisi
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Avvisi))
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.BtnChiudi = New System.Windows.Forms.PictureBox()
        Me.LabelTitolo = New System.Windows.Forms.Label()
        Me.LabelTextError = New System.Windows.Forms.Label()
        Me.Btn_OK = New System.Windows.Forms.Label()
        Me.LabelID_Error = New System.Windows.Forms.Label()
        Me.TimerDelay = New System.Windows.Forms.Timer(Me.components)
        Me.PanelTop.SuspendLayout()
        CType(Me.BtnChiudi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.Transparent
        Me.PanelTop.Controls.Add(Me.BtnChiudi)
        Me.PanelTop.Controls.Add(Me.LabelTitolo)
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(450, 44)
        Me.PanelTop.TabIndex = 0
        '
        'BtnChiudi
        '
        Me.BtnChiudi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnChiudi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnChiudi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnChiudi.Image = Global.ArduCenter.My.Resources.Resources.BtnChiudi21
        Me.BtnChiudi.Location = New System.Drawing.Point(409, 13)
        Me.BtnChiudi.Name = "BtnChiudi"
        Me.BtnChiudi.Size = New System.Drawing.Size(25, 25)
        Me.BtnChiudi.TabIndex = 7
        Me.BtnChiudi.TabStop = False
        '
        'LabelTitolo
        '
        Me.LabelTitolo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelTitolo.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitolo.ForeColor = System.Drawing.Color.Gold
        Me.LabelTitolo.Location = New System.Drawing.Point(0, 8)
        Me.LabelTitolo.Name = "LabelTitolo"
        Me.LabelTitolo.Size = New System.Drawing.Size(450, 35)
        Me.LabelTitolo.TabIndex = 0
        Me.LabelTitolo.Text = "ArduCenter Errore / Avviso"
        Me.LabelTitolo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelTextError
        '
        Me.LabelTextError.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelTextError.BackColor = System.Drawing.Color.Transparent
        Me.LabelTextError.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTextError.ForeColor = System.Drawing.Color.Gold
        Me.LabelTextError.Location = New System.Drawing.Point(0, 47)
        Me.LabelTextError.Name = "LabelTextError"
        Me.LabelTextError.Size = New System.Drawing.Size(450, 108)
        Me.LabelTextError.TabIndex = 1
        Me.LabelTextError.Text = "Error"
        Me.LabelTextError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn_OK
        '
        Me.Btn_OK.BackColor = System.Drawing.Color.Transparent
        Me.Btn_OK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_OK.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_OK.ForeColor = System.Drawing.Color.Gold
        Me.Btn_OK.Location = New System.Drawing.Point(178, 162)
        Me.Btn_OK.Name = "Btn_OK"
        Me.Btn_OK.Size = New System.Drawing.Size(87, 26)
        Me.Btn_OK.TabIndex = 2
        Me.Btn_OK.Text = "OK"
        Me.Btn_OK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelID_Error
        '
        Me.LabelID_Error.BackColor = System.Drawing.Color.Transparent
        Me.LabelID_Error.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelID_Error.ForeColor = System.Drawing.Color.DarkOrange
        Me.LabelID_Error.Location = New System.Drawing.Point(12, 162)
        Me.LabelID_Error.Name = "LabelID_Error"
        Me.LabelID_Error.Size = New System.Drawing.Size(146, 28)
        Me.LabelID_Error.TabIndex = 3
        Me.LabelID_Error.Text = "Error Code "
        Me.LabelID_Error.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'F_Avvisi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(450, 200)
        Me.Controls.Add(Me.LabelID_Error)
        Me.Controls.Add(Me.Btn_OK)
        Me.Controls.Add(Me.LabelTextError)
        Me.Controls.Add(Me.PanelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "F_Avvisi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Avviso ArduCenter 2.0"
        Me.PanelTop.ResumeLayout(False)
        CType(Me.BtnChiudi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTop As Panel
    Friend WithEvents LabelTitolo As Label
    Friend WithEvents LabelTextError As Label
    Friend WithEvents Btn_OK As Label
    Friend WithEvents LabelID_Error As Label
    Friend WithEvents BtnChiudi As PictureBox
    Friend WithEvents TimerDelay As Timer
End Class
