Public Class F_HubPC_CasseAudio
    Private Sub F_HubPC_CasseAudio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub F_HubPC_CasseAudio_Loop()


    End Sub

    Private Sub Btn_CassaAudio_S_Click(sender As Object, e As EventArgs) Handles Btn_CassaAudio_S.Click
        F_Avvio.Data1 = 10
        If F_Avvio.Data1 = 10 Then
            F_Avvio.Data3 = F_Hub_PC.H_Cassa_Audio_S
            F_Avvio.Data4 = F_Hub_PC.S_Cassa_Audio_S
            F_Avvio.Data2 = F_Hub_PC.V_Cassa_Audio_S
        End If
        F_Hub_PC.BtnOFF_Animation()
    End Sub

    Private Sub Btn_StripLED_Click(sender As Object, e As EventArgs) Handles Btn_StripLED.Click
        F_Avvio.Data1 = 12
        If F_Avvio.Data1 = 12 Then
            F_Avvio.Data3 = F_Hub_PC.H_Strip_LED
            F_Avvio.Data4 = F_Hub_PC.S_Strip_LED
            F_Avvio.Data2 = F_Hub_PC.V_Strip_LED
        End If
        F_Hub_PC.BtnOFF_Animation()
    End Sub

    Private Sub Btn_CassaAudio_D_Click(sender As Object, e As EventArgs) Handles Btn_CassaAudio_D.Click
        F_Avvio.Data1 = 11
        If F_Avvio.Data1 = 11 Then
            F_Avvio.Data3 = F_Hub_PC.H_Cassa_Audio_D
            F_Avvio.Data4 = F_Hub_PC.S_Cassa_Audio_D
            F_Avvio.Data2 = F_Hub_PC.V_Cassa_Audio_D
        End If
        F_Hub_PC.BtnOFF_Animation()
    End Sub

    Private Sub LaCassaAudio_S_Click(sender As Object, e As EventArgs) Handles LaCassaAudio_S.Click
        Btn_CassaAudio_S_Click(sender, e)
    End Sub
    Private Sub LaStriscaLED_Click(sender As Object, e As EventArgs) Handles LaStriscaLED.Click
        Btn_StripLED_Click(sender, e)
    End Sub
    Private Sub LaCassaAudio_D_Click(sender As Object, e As EventArgs) Handles LaCassaAudio_D.Click
        Btn_CassaAudio_D_Click(sender, e)
    End Sub




End Class