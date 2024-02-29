Public Class Supporto


    '//Smussa Angoli della Finestra Principale
    Private Sub AngoliSmussati(obj As Form)
        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()
        Dim A_S As Integer = 45
        Dim A_D As Integer = 45
        Dim B_D As Integer = 45
        Dim B_S As Integer = 45
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


    Private Sub Supporto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AngoliSmussati(Me)
    End Sub



    Public Sub Visualizza()
        Me.TopMost = True
        Show()
        F_Home.Enabled = False
        F_Setting_HUB.Enabled = False
    End Sub

    Private Sub BtnChiudi_Click(sender As Object, e As EventArgs) Handles BtnChiudi.Click

        F_Home.Enabled = True
        F_Setting_HUB.Enabled = True
        Close()

    End Sub

    Private Sub Btn_Dona_Click(sender As Object, e As EventArgs) Handles Btn_Dona.Click
        Dim url As String = "https://ko-fi.com/mastrmarco"
        ' Avvia il browser web predefinito con l'URL specificato
        Process.Start(url)
    End Sub


    Public Function GenRandomInt(min As Int32, max As Int32) As Int32
        Static staticRandomGenerator As New System.Random
        Return staticRandomGenerator.Next(min, max + 1)
    End Function


End Class