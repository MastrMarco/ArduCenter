Public Class P_Impostazioni_HUB_Ventole

    Private Sub F_Impostazioni_HUB_Ventole_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Carica Array GUI
        'Classe_Impostazioni_HUB_LED.Load()
        'Aggiorna Dati Elementi
        F_Avvio.Classe_Impostazioni_HUB_LED.Aggiorna_Data(1, 4)
    End Sub


    '----------------------------------------------------------------------------------------------------------------------
    'Colona Ventola UNO
    Private Sub BtnFan1_Click() Handles BtnFan1.Click
        BtnColorSet()
        '(x) = ID Elemento Ventola 1
        F_Avvio.Classe_Impostazioni_HUB_LED.ImpostaElemanto(1)
    End Sub

    Private Sub IconaVentola_1_Click(sender As Object, e As EventArgs) Handles IconaVentola_1.Click
        BtnFan1_Click()
    End Sub

    Private Sub BtnRGBON_Fan1_Click(sender As Object, e As EventArgs) Handles BtnRGBON_Fan1.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.RGB_ON(1)
    End Sub

    Private Sub BtnRGBOFF_Fan1_Click(sender As Object, e As EventArgs) Handles BtnRGBOFF_Fan1.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.RGB_OFF(1)
    End Sub

    Private Sub BtnVen_1_SU_Click(sender As Object, e As EventArgs) Handles BtnVen_1_SU.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.LED_N_SU(1)
    End Sub
    Private Sub BtnVen_1_GU_Click(sender As Object, e As EventArgs) Handles BtnVen_1_GU.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.LED_N_GU(1)
    End Sub
    Private Sub NumLED_Fan1_TextChanged(sender As Object, e As EventArgs) Handles NumLED_Fan1.TextChanged
        F_Avvio.Classe_Impostazioni_HUB_LED.N_LED_Set(1, NumLED_Fan1.Text)
    End Sub
    Private Sub Stato_Fan_1_Click(sender As Object, e As EventArgs) Handles Stato_Fan_1.Click

    End Sub



    '----------------------------------------------------------------------------------------------------------------------
    'Colona Ventola 2
    Private Sub BtnFan2_Click() Handles BtnFan2.Click
        BtnColorSet()
        '(x) = ID Elemento Ventola 2
        F_Avvio.Classe_Impostazioni_HUB_LED.ImpostaElemanto(2)
    End Sub

    Private Sub IconaVentola_2_Click(sender As Object, e As EventArgs) Handles IconaVentola_2.Click
        BtnFan2_Click()
    End Sub

    Private Sub BtnRGBON_Fan2_Click(sender As Object, e As EventArgs) Handles BtnRGBON_Fan2.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.RGB_ON(2)
    End Sub

    Private Sub BtnRGBOFF_Fan2_Click(sender As Object, e As EventArgs) Handles BtnRGBOFF_Fan2.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.RGB_OFF(2)
    End Sub

    Private Sub BtnVen_2_SU_Click(sender As Object, e As EventArgs) Handles BtnVen_2_SU.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.LED_N_SU(2)
    End Sub

    Private Sub BtnVen_2_GU_Click(sender As Object, e As EventArgs) Handles BtnVen_2_GU.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.LED_N_GU(2)
    End Sub

    Private Sub NumLED_Fan2_TextChanged(sender As Object, e As EventArgs) Handles NumLED_Fan2.TextChanged
        F_Avvio.Classe_Impostazioni_HUB_LED.N_LED_Set(2, NumLED_Fan2.Text)
    End Sub

    Private Sub Stato_Fan_2_Click(sender As Object, e As EventArgs) Handles Stato_Fan_2.Click

    End Sub



    '----------------------------------------------------------------------------------------------------------------------
    'Colona Ventola 3
    Private Sub BtnFan3_Click() Handles BtnFan3.Click
        BtnColorSet()
        '(x) = ID Elemento Ventola 3
        F_Avvio.Classe_Impostazioni_HUB_LED.ImpostaElemanto(3)

    End Sub

    Private Sub IconaVentola_3_Click(sender As Object, e As EventArgs) Handles IconaVentola_3.Click
        BtnFan3_Click()
    End Sub

    Private Sub BtnRGBON_Fan3_Click(sender As Object, e As EventArgs) Handles BtnRGBON_Fan3.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.RGB_ON(3)
    End Sub

    Private Sub BtnRGBOFF_Fan3_Click(sender As Object, e As EventArgs) Handles BtnRGBOFF_Fan3.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.RGB_OFF(3)
    End Sub

    Private Sub BtnVen_3_SU_Click(sender As Object, e As EventArgs) Handles BtnVen_3_SU.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.LED_N_SU(3)
    End Sub

    Private Sub BtnVen_3_GU_Click(sender As Object, e As EventArgs) Handles BtnVen_3_GU.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.LED_N_GU(3)
    End Sub

    Private Sub NumLED_Fan3_TextChanged(sender As Object, e As EventArgs) Handles NumLED_Fan3.TextChanged
        F_Avvio.Classe_Impostazioni_HUB_LED.N_LED_Set(3, NumLED_Fan3.Text)
    End Sub

    Private Sub Stato_Fan_3_Click(sender As Object, e As EventArgs) Handles Stato_Fan_3.Click

    End Sub



    '----------------------------------------------------------------------------------------------------------------------
    'Colona Ventola 4
    Private Sub BtnFan4_Click() Handles BtnFan4.Click
        BtnColorSet()
        '(x) = ID Elemento Ventola 4
        F_Avvio.Classe_Impostazioni_HUB_LED.ImpostaElemanto(4)
    End Sub

    Private Sub IconaVentola_4_Click(sender As Object, e As EventArgs) Handles IconaVentola_4.Click
        BtnFan4_Click()
    End Sub

    Private Sub BtnRGBON_Fan4_Click(sender As Object, e As EventArgs) Handles BtnRGBON_Fan4.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.RGB_ON(4)
    End Sub

    Private Sub BtnRGBOFF_Fan4_Click(sender As Object, e As EventArgs) Handles BtnRGBOFF_Fan4.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.RGB_OFF(4)
    End Sub

    Private Sub BtnVen_4_SU_Click(sender As Object, e As EventArgs) Handles BtnVen_4_SU.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.LED_N_SU(4)
    End Sub

    Private Sub BtnVen_4_GU_Click(sender As Object, e As EventArgs) Handles BtnVen_4_GU.Click
        F_Avvio.Classe_Impostazioni_HUB_LED.LED_N_GU(4)
    End Sub

    Private Sub NumLED_Fan4_TextChanged(sender As Object, e As EventArgs) Handles NumLED_Fan4.TextChanged
        F_Avvio.Classe_Impostazioni_HUB_LED.N_LED_Set(4, NumLED_Fan4.Text)
    End Sub

    Private Sub Stato_Fan_4_Click(sender As Object, e As EventArgs) Handles Stato_Fan_4.Click

    End Sub


    '/-----/



    Public Sub BtnColorSet()
        BtnFan1.ForeColor = Color.DarkGray
        BtnFan2.ForeColor = Color.DarkGray
        BtnFan3.ForeColor = Color.DarkGray
        BtnFan4.ForeColor = Color.DarkGray

    End Sub




End Class