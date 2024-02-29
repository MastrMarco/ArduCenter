Public Class P_Impostazioni_HUB_GPU_StripLED

    Private Sub F_Impostazioni_HUB_GPU_StripLED_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Aggiorna Dati Elementi
        F_Avvio.Classe_Impostazioni_HUB_LED.Aggiorna_Data(8, 9)
    End Sub

    '----------------------------------------------------------------------------------------------------------------------
    'Colona GPU Scheda Video
    Private Sub BtnGPU_Click() Handles BtnGPU.Click
        BtnColorSet()
        F_Avvio.Classe_Impostazioni_HUB_LED.ImpostaElemanto(F_Hub_PC.IndirizzoElemento_SchedaVideo)
    End Sub

    Private Sub IconaSchedaVideo_Click(sender As Object, e As EventArgs) Handles IconaSchedaVideo.Click
        BtnGPU_Click()
    End Sub

    Private Sub BtnRGBON_GPU_Click(sender As Object, e As EventArgs) Handles BtnRGBON_GPU.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.RGB_ON(F_Hub_PC.IndirizzoElemento_SchedaVideo)
    End Sub

    Private Sub BtnRGBOFF_GPU_Click(sender As Object, e As EventArgs) Handles BtnRGBOFF_GPU.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.RGB_OFF(F_Hub_PC.IndirizzoElemento_SchedaVideo)
    End Sub

    Private Sub BtnGPU_SU_Click(sender As Object, e As EventArgs) Handles BtnGPU_SU.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.LED_N_SU(F_Hub_PC.IndirizzoElemento_SchedaVideo)
    End Sub

    Private Sub BtnGPU_GU_Click(sender As Object, e As EventArgs) Handles BtnGPU_GU.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.LED_N_GU(F_Hub_PC.IndirizzoElemento_SchedaVideo)
    End Sub

    Private Sub NumLED_GPU_TextChanged(sender As Object, e As EventArgs) Handles NumLED_GPU.TextChanged
        F_Avvio.Classe_Impostazioni_HUB_LED.N_LED_Set(F_Hub_PC.IndirizzoElemento_SchedaVideo, NumLED_GPU.Text)
    End Sub

    Private Sub Stato_GPU_Click(sender As Object, e As EventArgs) Handles Stato_GPU.Click

    End Sub


    '----------------------------------------------------------------------------------------------------------------------
    'Colona StripLED Strisca LED
    Private Sub BtnStripLED_Click() Handles BtnStripLED.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.ImpostaElemanto(F_Hub_PC.IndirizzoElemento_StriscaLED)
    End Sub

    Private Sub IconaStriscaLED_Click(sender As Object, e As EventArgs) Handles IconaStriscaLED.Click
        BtnStripLED_Click()
    End Sub

    Private Sub BtnRGBON_StripLED_Click(sender As Object, e As EventArgs) Handles BtnRGBON_StripLED.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.RGB_ON(F_Hub_PC.IndirizzoElemento_StriscaLED)
    End Sub

    Private Sub BtnRGBOFF_StripLED_Click(sender As Object, e As EventArgs) Handles BtnRGBOFF_StripLED.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.RGB_OFF(F_Hub_PC.IndirizzoElemento_StriscaLED)
    End Sub

    Private Sub BtnStripLED_SU_Click(sender As Object, e As EventArgs) Handles BtnStripLED_SU.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.LED_N_SU(F_Hub_PC.IndirizzoElemento_StriscaLED)
    End Sub

    Private Sub BtnStripLED_GU_Click(sender As Object, e As EventArgs) Handles BtnStripLED_GU.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.LED_N_GU(F_Hub_PC.IndirizzoElemento_StriscaLED)
    End Sub

    Private Sub NumLED_StripLED_TextChanged(sender As Object, e As EventArgs) Handles NumLED_StripLED.TextChanged
        F_Avvio.Classe_Impostazioni_HUB_LED.N_LED_Set(F_Hub_PC.IndirizzoElemento_StriscaLED, NumLED_StripLED.Text)
    End Sub

    Private Sub Stato_StripLED_Click(sender As Object, e As EventArgs) Handles Stato_StripLED.Click

    End Sub


    '/-----/
    Public Sub BtnColorSet()
        BtnGPU.ForeColor = Color.DarkGray
        BtnStripLED.ForeColor = Color.DarkGray
    End Sub


End Class