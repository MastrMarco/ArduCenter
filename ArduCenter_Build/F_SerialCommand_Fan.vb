Imports System.Runtime.InteropServices
Public Class F_SerialCommand_Fan

    Public CMD_Open = 0

    Private Sub F_SerialCommand_Fan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub BtnChiudi_Click(sender As Object, e As EventArgs) Handles BtnChiudi.Click
        CMD_Open = 0
        'F_Hub_PC.BtnMenùEX.BackgroundImage = My.Resources.BtnFanPage_Fan_CMD_1_0
        'F_Connessione.BtnDataArduino.BackgroundImage = My.Resources.Incona_Comandi_Fan
        Close()
    End Sub


    '//Funzione Trascian Libreria SyS
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub F_SerialCommand_Fan_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        Try
            ReleaseCapture()
            SendMessage(Me.Handle, &H112&, &HF012&, 0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label10_MouseDown(sender As Object, e As MouseEventArgs) Handles Label10.MouseDown
        Try
            ReleaseCapture()
            SendMessage(Me.Handle, &H112&, &HF012&, 0)
        Catch ex As Exception

        End Try
    End Sub


    Public Sub COM_Data_Serial()

        If F_Avvio.DatiRX_2(0) = 0 Then
            InROM.Text = "Disattivo    Val." & F_Avvio.DatiRX_2(0)
            InROM.ForeColor = Color.White
        ElseIf F_Avvio.DatiRX_2(0) = 1 Then
            InROM.Text = "Attivo         Val." & F_Avvio.DatiRX_2(0)
            InROM.ForeColor = Color.White
        ElseIf F_Avvio.DatiRX_2(0) > 1 Then
            InROM.Text = "Dato errato  Val." & F_Avvio.DatiRX_2(0)
            InROM.ForeColor = Color.FromArgb(255, 128, 0)
        End If




        If F_Avvio.DatiRX_0(3) <> 3 Then
            InAudioHUB.Text = "Non Supportato"
            InAudioHUB.ForeColor = Color.FromArgb(0, 140, 149)
        Else F_Avvio.DatiRX_0(3) = 3

            If F_Avvio.DatiRX_10(1) = 0 Or F_Avvio.DatiRX_10(1) > 13 Then
                InAudioHUB.Text = "Dato errato    Val." & F_Avvio.DatiRX_10(1)
            ElseIf F_Avvio.DatiRX_10(1) = 1 Then
                InAudioHUB.Text = "Spento        Val." & F_Avvio.DatiRX_10(1)
            ElseIf F_Avvio.DatiRX_10(1) = 2 Then
                InAudioHUB.Text = "Bianco        Val." & F_Avvio.DatiRX_10(1)
            ElseIf F_Avvio.DatiRX_10(1) = 3 Then
                InAudioHUB.Text = "Rosso         Val." & F_Avvio.DatiRX_10(1)
            ElseIf F_Avvio.DatiRX_10(1) = 4 Then
                InAudioHUB.Text = "Verde         Val." & F_Avvio.DatiRX_10(1)
            ElseIf F_Avvio.DatiRX_10(1) = 5 Then
                InAudioHUB.Text = "Blu              Val." & F_Avvio.DatiRX_10(1)
            ElseIf F_Avvio.DatiRX_10(1) = 6 Then
                InAudioHUB.Text = "Ciano          Val." & F_Avvio.DatiRX_10(1)
            ElseIf F_Avvio.DatiRX_10(1) = 7 Then
                InAudioHUB.Text = "Arancione  Val." & F_Avvio.DatiRX_10(1)
            ElseIf F_Avvio.DatiRX_10(1) = 8 Then
                InAudioHUB.Text = "Fucsia         Val." & F_Avvio.DatiRX_10(1)
            ElseIf F_Avvio.DatiRX_10(1) = 9 Then
                InAudioHUB.Text = "Giallo          Val." & F_Avvio.DatiRX_10(1)
            ElseIf F_Avvio.DatiRX_10(1) = 10 Then
                InAudioHUB.Text = "RGB            Val." & F_Avvio.DatiRX_10(1)
            ElseIf F_Avvio.DatiRX_10(1) = 11 Then
                InAudioHUB.Text = "RGB            Val." & F_Avvio.DatiRX_10(1)
            ElseIf F_Avvio.DatiRX_10(1) = 12 Then
                InAudioHUB.Text = "RGB            Val." & F_Avvio.DatiRX_10(1)
            ElseIf F_Avvio.DatiRX_10(1) = 13 Then
                InAudioHUB.Text = "RGB            Val." & F_Avvio.DatiRX_10(1)
            End If

        End If





        If F_Avvio.DatiRX_6(1) = 0 Or F_Avvio.DatiRX_6(1) > 13 Then
            InFanHUB.Text = "Dato errato    Val." & F_Avvio.DatiRX_6(1)
        ElseIf F_Avvio.DatiRX_6(1) = 1 Then
            InFanHUB.Text = "Spento        Val." & F_Avvio.DatiRX_6(1)
        ElseIf F_Avvio.DatiRX_6(1) = 2 Then
            InFanHUB.Text = "Bianco        Val." & F_Avvio.DatiRX_6(1)
        ElseIf F_Avvio.DatiRX_6(1) = 3 Then
            InFanHUB.Text = "Rosso         Val." & F_Avvio.DatiRX_6(1)
        ElseIf F_Avvio.DatiRX_6(1) = 4 Then
            InFanHUB.Text = "Verde         Val." & F_Avvio.DatiRX_6(1)
        ElseIf F_Avvio.DatiRX_6(1) = 5 Then
            InFanHUB.Text = "Blu              Val." & F_Avvio.DatiRX_6(1)
        ElseIf F_Avvio.DatiRX_6(1) = 6 Then
            InFanHUB.Text = "Ciano          Val." & F_Avvio.DatiRX_6(1)
        ElseIf F_Avvio.DatiRX_6(1) = 7 Then
            InFanHUB.Text = "Arancione  Val." & F_Avvio.DatiRX_6(1)
        ElseIf F_Avvio.DatiRX_6(1) = 8 Then
            InFanHUB.Text = "Fucsia         Val." & F_Avvio.DatiRX_6(1)
        ElseIf F_Avvio.DatiRX_6(1) = 9 Then
            InFanHUB.Text = "Giallo          Val." & F_Avvio.DatiRX_6(1)
        ElseIf F_Avvio.DatiRX_6(1) = 10 Then
            InFanHUB.Text = "RGB            Val." & F_Avvio.DatiRX_6(1)
        ElseIf F_Avvio.DatiRX_6(1) = 11 Then
            InFanHUB.Text = "RGB            Val." & F_Avvio.DatiRX_6(1)
        ElseIf F_Avvio.DatiRX_6(1) = 12 Then
            InFanHUB.Text = "RGB            Val." & F_Avvio.DatiRX_6(1)
        ElseIf F_Avvio.DatiRX_6(1) = 13 Then
            InFanHUB.Text = "RGB            Val." & F_Avvio.DatiRX_6(1)
        End If

        InLumninosità.Text = F_HubPC_Ventole.PercentualeLuminosità & "%          Val." & F_Avvio.DatiRX(4)

        If F_Avvio.DatiRX_0(3) <> 3 Then
            InSplitLED.Text = "Non Supportato"
            InSplitLED.ForeColor = Color.FromArgb(0, 140, 149)
        End If


        If F_Avvio.DatiRX_0(3) <> 3 Then
            InPAH.Text = "Non Supportato"
            InPAH.ForeColor = Color.FromArgb(0, 140, 149)
        Else
            If F_Avvio.DatiRX_1(4) = 0 Then
                InPAH.Text = "Normale  Val." & F_Avvio.DatiRX_1(4)
                InPAH.ForeColor = Color.White
            ElseIf F_Avvio.DatiRX_1(4) = 1 Then
                InPAH.Text = "Anomalia    Val." & F_Avvio.DatiRX_1(4)
                InPAH.ForeColor = Color.Red
            ElseIf F_Avvio.DatiRX_1(4) > 1 Then
                InPAH.Text = "Dato errato   Val." & F_Avvio.DatiRX_1(4)
                InPAH.ForeColor = Color.FromArgb(255, 128, 0)
            End If
        End If


        If F_Avvio.DatiRX_2(2) = 0 Then
            InPL_Swich.Text = "Disattivo     Val." & F_Avvio.DatiRX_2(2)
        ElseIf F_Avvio.DatiRX_2(2) = 1 Then
            InPL_Swich.Text = "Attivo       Val." & F_Avvio.DatiRX_2(2)
        ElseIf F_Avvio.DatiRX_2(2) > 1 Then
            InPL_Swich.Text = "Dato errato   Val." & F_Avvio.DatiRX_2(2)
        End If

        If F_Avvio.DatiRX_1(3) = 0 Then
            InPL_Stato.Text = "Disattivo     Val." & F_Avvio.DatiRX_1(3)
            InPL_Stato.ForeColor = Color.White
        ElseIf F_Avvio.DatiRX_1(3) = 1 Then
            InPL_Stato.Text = "Attivo       Val." & F_Avvio.DatiRX_1(3)
            InPL_Stato.ForeColor = Color.Red
        ElseIf F_Avvio.DatiRX_1(3) > 1 Then
            InPL_Stato.Text = "Dato errato   Val." & F_Avvio.DatiRX_1(3)
            InPL_Stato.ForeColor = Color.FromArgb(255, 128, 0)
        End If



        InVelocità.Text = F_HubPC_Ventole.PercentualeVelocità & "%          Val." & F_Avvio.DatiRX_7(1)

        If F_Avvio.DatiRX_8(1) = 1 Then
            InModFan.Text = "Manuale     Val." & F_Avvio.DatiRX_8(1)
        ElseIf F_Avvio.DatiRX_8(1) = 2 Then
            InModFan.Text = "Automatico  Val." & F_Avvio.DatiRX_8(1)
        ElseIf F_Avvio.DatiRX_8(1) > 2 Or F_Avvio.DatiRX_8(1) = 0 Then
            InModFan.Text = "Dato errato   Val." & F_Avvio.DatiRX_8(1)
        End If

    End Sub

End Class