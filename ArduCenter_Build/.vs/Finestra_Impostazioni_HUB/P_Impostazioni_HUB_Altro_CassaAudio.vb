Public Class P_Impostazioni_HUB_Altro_CassaAudio

    Private Sub P_Impostazioni_HUB_Altro_CassaAudio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Aggiorna Dati Elementi
        F_Avvio.Classe_Impostazioni_HUB_LED.Aggiorna_Data(10, 12)
    End Sub

    '----------------------------------------------------------------------------------------------------------------------
    'Colona Cassa Sinistra
    Private Sub BtnCassaS_Click() Handles BtnCassaS.Click
        BtnColorSet()
        F_Avvio.Classe_Impostazioni_HUB_LED.ImpostaElemanto(10)
    End Sub

    Private Sub IconaCassaS_Click(sender As Object, e As EventArgs) Handles IconaCassaS.Click
        BtnCassaS_Click()
    End Sub

    Private Sub BtnRGBON_CassaS_Click(sender As Object, e As EventArgs) Handles BtnRGBON_CassaS.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.RGB_ON(10)
    End Sub

    Private Sub BtnRGBOFF_CassaS_Click(sender As Object, e As EventArgs) Handles BtnRGBOFF_CassaS.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.RGB_OFF(10)
    End Sub

    Private Sub BtnCassaS_SU_Click(sender As Object, e As EventArgs) Handles BtnCassaS_SU.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.LED_N_SU(10)
    End Sub

    Private Sub BtnCassaS_GU_Click(sender As Object, e As EventArgs) Handles BtnCassaS_GU.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.LED_N_GU(10)
    End Sub

    Private Sub NumLED_CassaS_TextChanged(sender As Object, e As EventArgs) Handles NumLED_CassaS.TextChanged
        F_Avvio.Classe_Impostazioni_HUB_LED.N_LED_Set(10, NumLED_CassaS.Text)
    End Sub

    Private Sub Stato_CassaS_Click(sender As Object, e As EventArgs) Handles Stato_CassaS.Click

    End Sub


    '----------------------------------------------------------------------------------------------------------------------
    'Colona Striscia LED
    Private Sub BtnStripLED_Click() Handles BtnStripLED.Click
        BtnColorSet()
        F_Avvio.Classe_Impostazioni_HUB_LED.ImpostaElemanto(12)
    End Sub

    Private Sub IconaStripLED_Click(sender As Object, e As EventArgs) Handles IconaStripLED.Click
        BtnStripLED_Click()
    End Sub

    Private Sub BtnRGBON_StripLED_Click(sender As Object, e As EventArgs) Handles BtnRGBON_StripLED.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.RGB_ON(12)
    End Sub

    Private Sub BtnRGBOFF_StripLED_Click(sender As Object, e As EventArgs) Handles BtnRGBOFF_StripLED.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.RGB_OFF(12)
    End Sub

    Private Sub BtnStripLED_SU_Click(sender As Object, e As EventArgs) Handles BtnStripLED_SU.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.LED_N_SU(12)
    End Sub

    Private Sub BtnStripLED_GU_Click(sender As Object, e As EventArgs) Handles BtnStripLED_GU.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.LED_N_GU(12)
    End Sub

    Private Sub NumLED_StripLED_TextChanged(sender As Object, e As EventArgs) Handles NumLED_StripLED.TextChanged
        F_Avvio.Classe_Impostazioni_HUB_LED.N_LED_Set(12, NumLED_StripLED.Text)
    End Sub

    Private Sub Stato_StripLED_Click(sender As Object, e As EventArgs) Handles Stato_StripLED.Click

    End Sub



    '----------------------------------------------------------------------------------------------------------------------
    'Colona Cassa Destra
    Private Sub BtnCassaD_Click() Handles BtnCassaD.Click
        BtnColorSet()
        F_Avvio.Classe_Impostazioni_HUB_LED.ImpostaElemanto(11)
    End Sub

    Private Sub IconaCassaD_Click(sender As Object, e As EventArgs) Handles IconaCassaD.Click
        BtnCassaD_Click()
    End Sub

    Private Sub BtnRGBON_CassaD_Click(sender As Object, e As EventArgs) Handles BtnRGBON_CassaD.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.RGB_ON(11)
    End Sub

    Private Sub BtnRGBOFF_CassaD_Click(sender As Object, e As EventArgs) Handles BtnRGBOFF_CassaD.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.RGB_OFF(11)
    End Sub

    Private Sub BtnCassaD_SU_Click(sender As Object, e As EventArgs) Handles BtnCassaD_SU.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.LED_N_SU(11)
    End Sub

    Private Sub BtnCassaD_GU_Click(sender As Object, e As EventArgs) Handles BtnCassaD_GU.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.LED_N_GU(11)
    End Sub

    Private Sub NumLED_CassaD_TextChanged(sender As Object, e As EventArgs) Handles NumLED_CassaD.TextChanged
        F_Avvio.Classe_Impostazioni_HUB_LED.N_LED_Set(11, NumLED_CassaD.Text)
    End Sub

    Private Sub Stato_CassaD_Click(sender As Object, e As EventArgs) Handles Stato_CassaD.Click

    End Sub



    '/-----/
    Public Sub BtnColorSet()
        BtnCassaS.ForeColor = Color.DarkGray
        BtnCassaD.ForeColor = Color.DarkGray
        BtnStripLED.ForeColor = Color.DarkGray

    End Sub


End Class