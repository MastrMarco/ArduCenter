<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Setting_RGB_Animation_Fan_Temp
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
        Me.Btn_Temp_CPU = New System.Windows.Forms.Label()
        Me.Btn_Temp_GPU = New System.Windows.Forms.Label()
        Me.Btn_Temp_SenS = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn_Temp_CPU
        '
        Me.Btn_Temp_CPU.AutoSize = True
        Me.Btn_Temp_CPU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Temp_CPU.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Temp_CPU.Location = New System.Drawing.Point(12, 43)
        Me.Btn_Temp_CPU.Name = "Btn_Temp_CPU"
        Me.Btn_Temp_CPU.Size = New System.Drawing.Size(106, 32)
        Me.Btn_Temp_CPU.TabIndex = 0
        Me.Btn_Temp_CPU.Text = "Temperatura " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CPU"
        Me.Btn_Temp_CPU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn_Temp_GPU
        '
        Me.Btn_Temp_GPU.AutoSize = True
        Me.Btn_Temp_GPU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Temp_GPU.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Temp_GPU.Location = New System.Drawing.Point(124, 43)
        Me.Btn_Temp_GPU.Name = "Btn_Temp_GPU"
        Me.Btn_Temp_GPU.Size = New System.Drawing.Size(106, 32)
        Me.Btn_Temp_GPU.TabIndex = 1
        Me.Btn_Temp_GPU.Text = "Temperatura " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "GPU"
        Me.Btn_Temp_GPU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn_Temp_SenS
        '
        Me.Btn_Temp_SenS.AutoSize = True
        Me.Btn_Temp_SenS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Temp_SenS.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Temp_SenS.Location = New System.Drawing.Point(236, 43)
        Me.Btn_Temp_SenS.Name = "Btn_Temp_SenS"
        Me.Btn_Temp_SenS.Size = New System.Drawing.Size(106, 32)
        Me.Btn_Temp_SenS.TabIndex = 2
        Me.Btn_Temp_SenS.Text = "Temperatura " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Case"
        Me.Btn_Temp_SenS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(325, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Selezione da dove acquisire la Temperatura" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'F_Setting_RGB_Animation_Fan_Temp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 111)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Btn_Temp_SenS)
        Me.Controls.Add(Me.Btn_Temp_GPU)
        Me.Controls.Add(Me.Btn_Temp_CPU)
        Me.Name = "F_Setting_RGB_Animation_Fan_Temp"
        Me.Text = "F_Setting_RGB_Animation_Fan_Temp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Temp_CPU As Label
    Friend WithEvents Btn_Temp_GPU As Label
    Friend WithEvents Btn_Temp_SenS As Label
    Friend WithEvents Label4 As Label
End Class
