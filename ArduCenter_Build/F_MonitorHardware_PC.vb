Public Class F_MonitorHardware_PC
    Private Sub F_MonitorHardware_PC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AngoliSmussati(Me)
    End Sub

    '//Smussa Angoli della Finestra Principale
    Private Sub AngoliSmussati(obj As Form)
        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()
        Dim A_S As Integer = 26
        Dim A_D As Integer = 26
        Dim B_D As Integer = 26
        Dim B_S As Integer = 26
        'Angolo Alto Sinistro
        DGP.AddArc(New Rectangle(0, 0, A_S, A_S), 180, 90)
        DGP.AddLine(A_S, 0, obj.Width - A_S, 0)
        'Angolo Alto Destro
        DGP.AddArc(New Rectangle(obj.Width - A_D, 0, A_D, A_D), -90, 90)
        DGP.AddLine(obj.Width, A_D, obj.Width, obj.Height - A_D)
        'Angolo Basso Destro
        DGP.AddArc(New Rectangle(obj.Width - B_D, obj.Height - B_D, B_D, B_D), 0, 90)
        DGP.AddLine(obj.Width - B_D, obj.Height, B_D, obj.Height)
        'Angolo Basso Sinistro
        DGP.AddArc(New Rectangle(0, obj.Height - B_S, B_S, B_S), 90, 90)
        DGP.CloseFigure()

        obj.Region = New Region(DGP)
    End Sub

    Private Sub NomeGPU_Click(sender As Object, e As EventArgs) Handles NomeGPU.Click
        If F_Avvio.ErrorHardwareGPU = 1 Then
            F_Avvio.ErrorHardwareGPU = 0
            NomeGPU.ForeColor = Color.White
        End If
    End Sub

    Private Sub NomeCPU_Click(sender As Object, e As EventArgs) Handles NomeCPU.Click
        If F_Avvio.ErrorHardwareCPU = 1 Then
            F_Avvio.ErrorHardwareCPU = 0
            NomeCPU.ForeColor = Color.White
        End If
    End Sub
End Class