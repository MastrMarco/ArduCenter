Public Class P_Impostazioni_HUB_Altro_Dissipatore

    Private Sub F_Impostazioni_Altro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Aggiorna Dati Elementi
        F_Avvio.Classe_Impostazioni_HUB_LED.Aggiorna_Data(5, 7)
    End Sub



    '----------------------------------------------------------------------------------------------------------------------
    'Colona Ventola 1
    Private Sub BtnFan1_Click() Handles BtnFan1.Click
        BtnColorSet()
        F_Avvio.Classe_Impostazioni_HUB_LED.ImpostaElemanto(5)
    End Sub

    Private Sub IconaVentola_1_Click(sender As Object, e As EventArgs) Handles IconaVentola_1.Click
        BtnFan1_Click()
    End Sub

    Private Sub BtnRGBON_Fan1_Click(sender As Object, e As EventArgs) Handles BtnRGBON_Fan1.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.RGB_ON(5)
    End Sub

    Private Sub BtnRGBOFF_Fan1_Click(sender As Object, e As EventArgs) Handles BtnRGBOFF_Fan1.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.RGB_OFF(5)
    End Sub

    Private Sub BtnVen_1_SU_Click(sender As Object, e As EventArgs) Handles BtnVen_1_SU.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.LED_N_SU(5)
    End Sub

    Private Sub BtnVen_1_GU_Click(sender As Object, e As EventArgs) Handles BtnVen_1_GU.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.LED_N_GU(5)
    End Sub

    Private Sub NumLED_Fan1_TextChanged(sender As Object, e As EventArgs) Handles NumLED_Fan1.TextChanged
        F_Avvio.Classe_Impostazioni_HUB_LED.N_LED_Set(5, NumLED_Fan1.Text)
    End Sub

    Private Sub Stato_Fan_1_Click(sender As Object, e As EventArgs) Handles Stato_Fan_1.Click

    End Sub


    '----------------------------------------------------------------------------------------------------------------------
    'Colona Pompa
    Private Sub BtnPomp_Click() Handles BtnPomp.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.ImpostaElemanto(7)
    End Sub

    Private Sub IconaPompa_Click(sender As Object, e As EventArgs) Handles IconaPompa.Click
        BtnPomp_Click()
    End Sub

    Private Sub BtnRGBON_Pomp_Click(sender As Object, e As EventArgs) Handles BtnRGBON_Pomp.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.RGB_ON(7)
    End Sub

    Private Sub BtnRGBOFF_Pomp_Click(sender As Object, e As EventArgs) Handles BtnRGBOFF_Pomp.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.RGB_OFF(7)
    End Sub

    Private Sub BtnPomp_SU_Click(sender As Object, e As EventArgs) Handles BtnPomp_SU.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.LED_N_SU(7)
    End Sub

    Private Sub BtnPomp_GU_Click(sender As Object, e As EventArgs) Handles BtnPomp_GU.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.LED_N_GU(7)
    End Sub

    Private Sub NumLED_Pomp_TextChanged(sender As Object, e As EventArgs) Handles NumLED_Pomp.TextChanged
        F_Avvio.Classe_Impostazioni_HUB_LED.N_LED_Set(7, NumLED_Pomp.Text)
    End Sub

    Private Sub Stato_Pomp_Click(sender As Object, e As EventArgs) Handles Stato_Pomp.Click

    End Sub



    '----------------------------------------------------------------------------------------------------------------------
    'Colona Ventola 2
    Private Sub BtnFan2_Click() Handles BtnFan2.Click
        BtnColorSet()
        F_Avvio.Classe_Impostazioni_HUB_LED.ImpostaElemanto(6)
    End Sub

    Private Sub IconaVentola_2_Click(sender As Object, e As EventArgs) Handles IconaVentola_2.Click
        BtnFan2_Click()
    End Sub

    Private Sub BtnRGBON_Fan2_Click(sender As Object, e As EventArgs) Handles BtnRGBON_Fan2.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.RGB_ON(6)
    End Sub

    Private Sub BtnRGBOFF_Fan2_Click(sender As Object, e As EventArgs) Handles BtnRGBOFF_Fan2.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.RGB_OFF(6)
    End Sub

    Private Sub BtnVen_2_SU_Click(sender As Object, e As EventArgs) Handles BtnVen_2_SU.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.LED_N_SU(6)
    End Sub

    Private Sub BtnVen_2_GU_Click(sender As Object, e As EventArgs) Handles BtnVen_2_GU.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.LED_N_GU(6)
    End Sub

    Private Sub NumLED_Fan2_TextChanged(sender As Object, e As EventArgs) Handles NumLED_Fan2.TextChanged
        F_Avvio.Classe_Impostazioni_HUB_LED.N_LED_Set(6, NumLED_Fan2.Text)
    End Sub

    Private Sub Stato_Fan_2_Click(sender As Object, e As EventArgs) Handles Stato_Fan_2.Click

    End Sub



    '/-----/
    Public Sub BtnColorSet()
        BtnFan1.ForeColor = Color.DarkGray
        BtnFan2.ForeColor = Color.DarkGray
        BtnPomp.ForeColor = Color.DarkGray

    End Sub






End Class