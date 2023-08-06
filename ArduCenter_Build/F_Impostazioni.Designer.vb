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
        Me.AvvioWindows = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AvvioWindows
        '
        Me.AvvioWindows.Enabled = False
        Me.AvvioWindows.Location = New System.Drawing.Point(84, 62)
        Me.AvvioWindows.Name = "AvvioWindows"
        Me.AvvioWindows.Size = New System.Drawing.Size(75, 23)
        Me.AvvioWindows.TabIndex = 0
        Me.AvvioWindows.Text = "Auto Run"
        Me.AvvioWindows.UseVisualStyleBackColor = True
        Me.AvvioWindows.Visible = False
        '
        'F_Impostazioni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(900, 450)
        Me.Controls.Add(Me.AvvioWindows)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_Impostazioni"
        Me.Text = "F_Impostazioni"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AvvioWindows As Button
End Class
