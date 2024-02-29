Public Class C_Impostazioni_LED_HUB


    Public Max_LED As Integer = 30
    'Public Num_LED_Max_Set As Integer = 1
    Public DataEEPROM_Save As Integer 'Salva lo stato impostato dall'utente prima della Modifica
    Public DataElement_Save As Integer 'Salva lo stato impostato dall'utente prima della Modifica
    Public DataColor_Save As Integer 'Salva lo stato impostato dall'utente prima della Modifica

    '                                  1  2  3  4  5  6  7  8  9  10 11 12
    Dim Elemento_EN() As Integer = {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}
    '                             1  2  3  4  5  6  7  8  9  10 11 12
    Dim LED_EN() As Integer = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


    'Btn Elemento
    Dim set_Btn_Elemento() As Label
    'Icona Elemento
    Dim set_Icona() As PictureBox
    'Elemento RGB
    Dim set_Btn_RGB_ON() As Label
    'Elemento non RGB
    Dim set_Btn_RGB_OFF() As Label
    'Aumenta Numero di LED
    Dim set_Btn_N_SU() As Label
    'Dimunuire Numero di LED
    Dim set_Btn_N_GU() As Label
    'Testo Numero LED
    Dim setTextBox_N_LED() As TextBox
    'Elemento Stato
    Dim setStato() As Label

    'Icona Elemento N RGB
    Dim set_IMG_Icona_NRGB() As Image
    'Icona Elemento RGB
    Dim set_IMG_Icona_RGB() As Image

    Public Sub Load()
        'Btn Elemento
        set_Btn_Elemento = New Label(12) {}
        set_Btn_Elemento(1) = P_Impostazioni_HUB_Ventole.BtnFan1 '1 Ventola 1
        set_Btn_Elemento(2) = P_Impostazioni_HUB_Ventole.BtnFan2 '2 Ventola 2
        set_Btn_Elemento(3) = P_Impostazioni_HUB_Ventole.BtnFan3 '3 Ventola 3
        set_Btn_Elemento(4) = P_Impostazioni_HUB_Ventole.BtnFan4 '4 Ventola 4
        set_Btn_Elemento(5) = P_Impostazioni_HUB_Altro_Dissipatore.BtnFan1 '5 Dissipatore CPU Ventola 1
        set_Btn_Elemento(6) = P_Impostazioni_HUB_Altro_Dissipatore.BtnFan2 '6 Dissipatore CPU Ventola 2
        set_Btn_Elemento(7) = P_Impostazioni_HUB_Altro_Dissipatore.BtnPomp '7 Dissipatore CPU
        set_Btn_Elemento(8) = P_Impostazioni_HUB_GPU_StripLED.BtnGPU         '8 Scheda Video
        set_Btn_Elemento(9) = P_Impostazioni_HUB_GPU_StripLED.BtnStripLED    '9 Strip LED
        set_Btn_Elemento(10) = P_Impostazioni_HUB_Altro_CassaAudio.BtnCassaS   '10 Cassa Audio Sinistra
        set_Btn_Elemento(11) = P_Impostazioni_HUB_Altro_CassaAudio.BtnCassaD   '11 Cassa Audio Destra
        set_Btn_Elemento(12) = P_Impostazioni_HUB_Altro_CassaAudio.BtnStripLED  '12 Strip LED


        'Icona Elemento
        set_Icona = New PictureBox() {
            Nothing,                                  '0
           P_Impostazioni_HUB_Ventole.IconaVentola_1, '1 Ventola 1
           P_Impostazioni_HUB_Ventole.IconaVentola_2, '2 Ventola 2
           P_Impostazioni_HUB_Ventole.IconaVentola_3, '3 Ventola 3
           P_Impostazioni_HUB_Ventole.IconaVentola_4, '4 Ventola 4
           P_Impostazioni_HUB_Altro_Dissipatore.IconaVentola_1, '5 Dissipatore CPU Ventola 1
           P_Impostazioni_HUB_Altro_Dissipatore.IconaVentola_2, '6 Dissipatore CPU Ventola 2
           P_Impostazioni_HUB_Altro_Dissipatore.IconaPompa,     '7 Dissipatore CPU
           P_Impostazioni_HUB_GPU_StripLED.IconaSchedaVideo,  '8 Scheda Video
           P_Impostazioni_HUB_GPU_StripLED.IconaStriscaLED,   '9 Strip LED
           P_Impostazioni_HUB_Altro_CassaAudio.IconaCassaS,   '10 Cassa Audio Sinistra
           P_Impostazioni_HUB_Altro_CassaAudio.IconaCassaD,   '11 Cassa Audio Destra
           P_Impostazioni_HUB_Altro_CassaAudio.IconaStripLED  '12 Strip LED
          }

        'Elemento RGB
        set_Btn_RGB_ON = New Label() {
            Nothing,                                 '0
           P_Impostazioni_HUB_Ventole.BtnRGBON_Fan1, '1 Ventola 1
           P_Impostazioni_HUB_Ventole.BtnRGBON_Fan2, '2 Ventola 2
           P_Impostazioni_HUB_Ventole.BtnRGBON_Fan3, '3 Ventola 3
           P_Impostazioni_HUB_Ventole.BtnRGBON_Fan4, '4 Ventola 4
           P_Impostazioni_HUB_Altro_Dissipatore.BtnRGBON_Fan1, '5 Dissipatore CPU Ventola 1
           P_Impostazioni_HUB_Altro_Dissipatore.BtnRGBON_Fan2, '6 Dissipatore CPU Ventola 2
           P_Impostazioni_HUB_Altro_Dissipatore.BtnRGBON_Pomp, '7 Dissipatore CPU
           P_Impostazioni_HUB_GPU_StripLED.BtnRGBON_GPU,        '8 Scheda Video
           P_Impostazioni_HUB_GPU_StripLED.BtnRGBON_StripLED,   '9 Strip LED
           P_Impostazioni_HUB_Altro_CassaAudio.BtnRGBON_CassaS,   '10 Cassa Audio Sinistra
           P_Impostazioni_HUB_Altro_CassaAudio.BtnRGBON_CassaD,   '11 Cassa Audio Destra
           P_Impostazioni_HUB_Altro_CassaAudio.BtnRGBON_StripLED  '12 Strip LED
          }

        'Elemento non RGB
        set_Btn_RGB_OFF = New Label() {
            Nothing,                                  '0
           P_Impostazioni_HUB_Ventole.BtnRGBOFF_Fan1, '1 Ventola 1
           P_Impostazioni_HUB_Ventole.BtnRGBOFF_Fan2, '2 Ventola 2
           P_Impostazioni_HUB_Ventole.BtnRGBOFF_Fan3, '3 Ventola 3
           P_Impostazioni_HUB_Ventole.BtnRGBOFF_Fan4, '4 Ventola 4
           P_Impostazioni_HUB_Altro_Dissipatore.BtnRGBOFF_Fan1, '5 Dissipatore CPU Ventola 1
           P_Impostazioni_HUB_Altro_Dissipatore.BtnRGBOFF_Fan2, '6 Dissipatore CPU Ventola 2
           P_Impostazioni_HUB_Altro_Dissipatore.BtnRGBOFF_Pomp, '7 Dissipatore CPU
           P_Impostazioni_HUB_GPU_StripLED.BtnRGBOFF_GPU,        '8 Scheda Video
           P_Impostazioni_HUB_GPU_StripLED.BtnRGBOFF_StripLED,   '9 Strip LED
           P_Impostazioni_HUB_Altro_CassaAudio.BtnRGBOFF_CassaS,   '10 Cassa Audio Sinistra
           P_Impostazioni_HUB_Altro_CassaAudio.BtnRGBOFF_CassaD,   '11 Cassa Audio Destra
           P_Impostazioni_HUB_Altro_CassaAudio.BtnRGBOFF_StripLED  '12 Strip LED
          }

        'Aumenta Numero di LED
        set_Btn_N_SU = New Label() {
           Nothing,                                '0
           P_Impostazioni_HUB_Ventole.BtnVen_1_SU, '1 Ventola 1
           P_Impostazioni_HUB_Ventole.BtnVen_2_SU, '2 Ventola 2
           P_Impostazioni_HUB_Ventole.BtnVen_3_SU, '3 Ventola 3
           P_Impostazioni_HUB_Ventole.BtnVen_4_SU, '4 Ventola 4
           P_Impostazioni_HUB_Altro_Dissipatore.BtnVen_1_SU, '5 Dissipatore CPU Ventola 1
           P_Impostazioni_HUB_Altro_Dissipatore.BtnVen_2_SU, '6 Dissipatore CPU Ventola 2
           P_Impostazioni_HUB_Altro_Dissipatore.BtnPomp_SU,  '7 Dissipatore CPU
           P_Impostazioni_HUB_GPU_StripLED.BtnGPU_SU,        '8 Scheda Video
           P_Impostazioni_HUB_GPU_StripLED.BtnStripLED_SU,   '9 Strip LED
           P_Impostazioni_HUB_Altro_CassaAudio.BtnCassaS_SU,   '10 Cassa Audio Sinistra
           P_Impostazioni_HUB_Altro_CassaAudio.BtnCassaD_SU,   '11 Cassa Audio Destra
           P_Impostazioni_HUB_Altro_CassaAudio.BtnStripLED_SU  '12 Strip LED
          }

        'Dimunuire Numero di LED
        set_Btn_N_GU = New Label() {
            Nothing,                               '0
           P_Impostazioni_HUB_Ventole.BtnVen_1_GU, '1 Ventola 1
           P_Impostazioni_HUB_Ventole.BtnVen_2_GU, '2 Ventola 2
           P_Impostazioni_HUB_Ventole.BtnVen_3_GU, '3 Ventola 3
           P_Impostazioni_HUB_Ventole.BtnVen_4_GU, '4 Ventola 4
           P_Impostazioni_HUB_Altro_Dissipatore.BtnVen_1_GU, '5 Dissipatore CPU Ventola 1
           P_Impostazioni_HUB_Altro_Dissipatore.BtnVen_2_GU, '6 Dissipatore CPU Ventola 2
           P_Impostazioni_HUB_Altro_Dissipatore.BtnPomp_GU,  '7 Dissipatore CPU
           P_Impostazioni_HUB_GPU_StripLED.BtnGPU_GU,        '8 Scheda Video
           P_Impostazioni_HUB_GPU_StripLED.BtnStripLED_GU,   '9 Strip LED
           P_Impostazioni_HUB_Altro_CassaAudio.BtnCassaS_GU,   '10 Cassa Audio Sinistra
           P_Impostazioni_HUB_Altro_CassaAudio.BtnCassaD_GU,   '11 Cassa Audio Destra
           P_Impostazioni_HUB_Altro_CassaAudio.BtnStripLED_GU  '12 Strip LED
          }

        'Testo Numero LED
        setTextBox_N_LED = New TextBox() {
            Nothing,                               '0
           P_Impostazioni_HUB_Ventole.NumLED_Fan1, '1 Ventola 1
           P_Impostazioni_HUB_Ventole.NumLED_Fan2, '2 Ventola 2
           P_Impostazioni_HUB_Ventole.NumLED_Fan3, '3 Ventola 3
           P_Impostazioni_HUB_Ventole.NumLED_Fan4, '4 Ventola 4
           P_Impostazioni_HUB_Altro_Dissipatore.NumLED_Fan1, '5 Dissipatore CPU Ventola 1
           P_Impostazioni_HUB_Altro_Dissipatore.NumLED_Fan2, '6 Dissipatore CPU Ventola 2
           P_Impostazioni_HUB_Altro_Dissipatore.NumLED_Pomp, '7 Dissipatore CPU
           P_Impostazioni_HUB_GPU_StripLED.NumLED_GPU,        '8 Scheda Video
           P_Impostazioni_HUB_GPU_StripLED.NumLED_StripLED,   '9 Strip LED
           P_Impostazioni_HUB_Altro_CassaAudio.NumLED_CassaS,   '10 Cassa Audio Sinistra
           P_Impostazioni_HUB_Altro_CassaAudio.NumLED_CassaD,   '11 Cassa Audio Destra
           P_Impostazioni_HUB_Altro_CassaAudio.NumLED_StripLED  '12 Strip LED
          }

        'Elemento Stato
        setStato = New Label() {
            Nothing,                               '0
           P_Impostazioni_HUB_Ventole.Stato_Fan_1, '1 Ventola 1
           P_Impostazioni_HUB_Ventole.Stato_Fan_2, '2 Ventola 2
           P_Impostazioni_HUB_Ventole.Stato_Fan_3, '3 Ventola 3
           P_Impostazioni_HUB_Ventole.Stato_Fan_4, '4 Ventola 4
           P_Impostazioni_HUB_Altro_Dissipatore.Stato_Fan_1, '5 Dissipatore CPU Ventola 1
           P_Impostazioni_HUB_Altro_Dissipatore.Stato_Fan_2, '6 Dissipatore CPU Ventola 2
           P_Impostazioni_HUB_Altro_Dissipatore.Stato_Pomp,  '7 Dissipatore CPU
           P_Impostazioni_HUB_GPU_StripLED.Stato_GPU,        '8 Scheda Video
           P_Impostazioni_HUB_GPU_StripLED.Stato_StripLED,   '9 Strip LED
           P_Impostazioni_HUB_Altro_CassaAudio.Stato_CassaS,   '10 Cassa Audio Sinistra
           P_Impostazioni_HUB_Altro_CassaAudio.Stato_CassaD,   '11 Cassa Audio Destra
           P_Impostazioni_HUB_Altro_CassaAudio.Stato_StripLED  '12 Strip LED
          }



        'Icona Elemento N RGB
        set_IMG_Icona_NRGB = New Image() {
           Nothing,                               '0
           My.Resources.IconaFan_RGB_Colore_Nero, '1 Ventola 1
           My.Resources.IconaFan_RGB_Colore_Nero, '2 Ventola 2
           My.Resources.IconaFan_RGB_Colore_Nero, '3 Ventola 3
           My.Resources.IconaFan_RGB_Colore_Nero, '4 Ventola 4
           My.Resources.IconaFan_RGB_Colore_Nero, '5 Dissipatore CPU Ventola 1
           My.Resources.IconaFan_RGB_Colore_Nero, '6 Dissipatore CPU Ventola 2
           My.Resources.Icona_DeepCool_HSV_RGB,   '7 Dissipatore CPU
           My.Resources.Icona_SchedaVideo_Nero,   '8 Scheda Video
           My.Resources.Icona_Strisca_LED_Nero,   '9 Strip LED
           My.Resources.Icona_Sund_Nero,          '10 Cassa Audio Sinistra
           My.Resources.Icona_Sund_Nero,          '11 Cassa Audio Destra
           My.Resources.Icona_Strisca_LED_Nero    '12 Strip LED
          }

        'Icona Elemento RGB
        set_IMG_Icona_RGB = New Image() {
           Nothing,                                  '0
           My.Resources.IconaFan_RGB_Colore_RainBow, '1 Ventola 1
           My.Resources.IconaFan_RGB_Colore_RainBow, '2 Ventola 2
           My.Resources.IconaFan_RGB_Colore_RainBow, '3 Ventola 3
           My.Resources.IconaFan_RGB_Colore_RainBow, '4 Ventola 4
           My.Resources.IconaFan_RGB_Colore_RainBow,          '5 Dissipatore CPU Ventola 1
           My.Resources.IconaFan_RGB_Colore_RainBow,          '6 Dissipatore CPU Ventola 2
           My.Resources.Icona_DeepCool_RGB_v1_3_RainBowOld,   '7 Dissipatore CPU
           My.Resources.Icona_SchedaVideo_Effeto_RainBow_Old,      '8 Scheda Video
           My.Resources.Icona_StriscaLED__RGB_Colore_RainBow_Old,  '9 Strip LED
           My.Resources.Icona_Sund_RGB_Old,                         '10 Cassa Audio Sinistra
           My.Resources.Icona_Sund_RGB_Old,                         '11 Cassa Audio Destra
           My.Resources.Icona_StriscaLED__RGB_Colore_RainBow_Old    '12 Strip LED
          }

    End Sub


    Public Sub Aggiorna_Data(Min As Integer, Max As Integer)
        'Ventole
        For i As Integer = Min To Max
            Loop_Set_Elementi(i)
        Next

    End Sub




    'Colona Ventola UNO
    Public Sub ImpostaElemanto(ID As Integer)
        If F_Avvio.Data10 <> 3 Then
            F_Avvio.Data10 = 3
            F_Avvio.Data1 = ID
            F_Avvio.DatiRX_3_1(ID) = 1

        ElseIf F_Avvio.Data10 = 3 And F_Avvio.Data1 <> ID Then
            F_Avvio.Data1 = ID
            F_Avvio.Data13 = 1
            F_Avvio.DatiRX_3_1(ID) = F_Avvio.Data13

            If F_Avvio.Data1 >= 1 And F_Avvio.Data1 <= 4 Then
                Aggiorna_Data(1, 4)
            ElseIf F_Avvio.Data1 >= 5 And F_Avvio.Data1 <= 7 Then
                Aggiorna_Data(5, 7)
            ElseIf F_Avvio.Data1 >= 8 And F_Avvio.Data1 <= 9 Then
                Aggiorna_Data(8, 9)
            ElseIf F_Avvio.Data1 >= 10 And F_Avvio.Data1 <= 12 Then
                Aggiorna_Data(10, 12)
            End If
        End If

        ' Load()
        If set_Btn_Elemento(ID).ForeColor <> Color.Gold And F_Avvio.Data1 = ID And F_Avvio.Data10 = 3 Then
            set_Btn_Elemento(ID).ForeColor = Color.Gold
        End If




        Loop_Set_Elementi(ID)
    End Sub

    Public Sub RGB_ON(ID As Integer)
        If F_Avvio.Data1 = ID And F_Avvio.Data10 = 3 Then
            If Elemento_EN(ID) = 1 And LED_EN(ID) = 0 Then
                LED_EN(ID) = 1

                If F_Avvio.DatiRX_0(F_Hub_PC.IndirizzoTipoDispositivo) = 3 Or F_Avvio.DatiRX_0(F_Hub_PC.IndirizzoTipoDispositivo) = 4 Then
                    F_Avvio.Data13 = 1
                    F_Avvio.DatiRX_3_1(ID) = F_Avvio.Data13
                End If

                Loop_Set_Elementi(ID)
            End If
        End If
    End Sub




    Public Sub RGB_OFF(ID As Integer)
        If F_Avvio.Data1 = ID And F_Avvio.Data10 = 3 Then
            If Elemento_EN(ID) = 1 And LED_EN(ID) = 1 Then
                LED_EN(ID) = 0

                Dim n As Integer
                If F_Avvio.DatiRX_0(F_Hub_PC.IndirizzoTipoDispositivo) = 3 Or F_Avvio.DatiRX_0(F_Hub_PC.IndirizzoTipoDispositivo) = 4 Then
                    'n = 0
                    n = NumLED_Min(ID)
                    ' F_Setting_HUB.BtnConfigurazione.Text = n.ToString
                ElseIf F_Avvio.DatiRX_0(F_Hub_PC.IndirizzoTipoDispositivo) = 5 Then
                    n = 1
                End If
                F_Avvio.Data13 = n
                F_Avvio.DatiRX_3_1(ID) = F_Avvio.Data13

                Loop_Set_Elementi(ID)
            End If
        End If
    End Sub




    Public Sub LED_N_SU(ID As Integer)
        If F_Avvio.DatiRX_3_1(ID) >= 1 Then
            F_Avvio.DatiRX_3_1(ID) += 1
            F_Avvio.Data13 = F_Avvio.DatiRX_3_1(ID)
            Loop_Set_Elementi(ID)
        End If
    End Sub
    Public Sub LED_N_GU(ID As Integer)
        If F_Avvio.DatiRX_3_1(ID) > 1 Then
            F_Avvio.DatiRX_3_1(ID) -= 1
            F_Avvio.Data13 = F_Avvio.DatiRX_3_1(ID)
            Loop_Set_Elementi(ID)
        End If
    End Sub




    Public Sub N_LED_Set(ID As Integer, Text As String)
        If F_Avvio.Data10 = 3 Then


            If F_Avvio.Data1 = ID.ToString Then

                If IsNumeric(Text) Then
                    Dim N As Integer = Text
                    If (N >= 1 And N <= Max_LED) Then
                        F_Avvio.DatiRX_3_1(ID) = N
                        F_Avvio.Data13 = F_Avvio.DatiRX_3_1(ID)
                        F_Avvio.DatiRX_3_1(ID) = F_Avvio.DatiRX_3_1(ID)
                    Else
                        If Text <> String.Empty And Elemento_EN(ID) = 1 And LED_EN(ID) = 1 Then
                            F_Avvio.Data13 = 1
                            F_Avvio.DatiRX_3_1(ID) = 1
                            setTextBox_N_LED(ID).Text = F_Avvio.DatiRX_3_1(ID)

                        End If

                    End If
                Else
                    If Text <> String.Empty And Elemento_EN(ID) = 1 And LED_EN(ID) = 1 Then
                        setTextBox_N_LED(ID).Text = F_Avvio.DatiRX_3_1(ID)
                    End If

                    If LED_EN(ID) = 0 Or Elemento_EN(ID) = 0 Then
                        setTextBox_N_LED(ID).Text = "---"
                    End If
                End If

                    Loop_Set_Elementi(ID)
            End If

        End If
    End Sub






    Public Sub Loop_Set_Elementi(ID As Integer)

        If F_Avvio.Data10 = 3 And F_Avvio.Data1 = ID.ToString And set_Btn_Elemento(ID).ForeColor <> Color.Gold Then
            set_Btn_Elemento(ID).ForeColor = Color.Gold
        End If

        Dim n As Integer
        If F_Avvio.DatiRX_0(F_Hub_PC.IndirizzoTipoDispositivo) = 3 Or F_Avvio.DatiRX_0(F_Hub_PC.IndirizzoTipoDispositivo) = 4 Then
            'n = 0
            n = NumLED_Min(ID)
        End If
        If F_Avvio.DatiRX_0(F_Hub_PC.IndirizzoTipoDispositivo) = 5 Then
            n = 1
        End If


        'Stato Connessione Ventola 1
        If Elemento_EN(ID) = 1 Then

            set_Btn_RGB_ON(ID).Enabled = True
            set_Btn_RGB_OFF(ID).Enabled = True

            'Sato LED ON OFF
            If ((F_Avvio.DatiRX_3_1(ID) > n And F_Avvio.Data1 <> ID.ToString) Or (F_Avvio.Data1 = ID.ToString And LED_EN(ID) = 1)) Then
                set_Btn_RGB_ON(ID).ForeColor = Color.Cyan
                set_Btn_RGB_OFF(ID).ForeColor = Color.DarkGray
                If F_Avvio.Data1 <> ID.ToString Then LED_EN(ID) = 1

            ElseIf (F_Avvio.DatiRX_3_1(ID) = n And F_Avvio.Data1 <> ID.ToString) Or (F_Avvio.Data1 = ID.ToString And LED_EN(ID) = 0) Then
                set_Btn_RGB_OFF(ID).ForeColor = Color.Cyan
                set_Btn_RGB_ON(ID).ForeColor = Color.DarkGray
                If F_Avvio.Data1 <> ID.ToString Then LED_EN(ID) = 0
            End If

            'Stato Modifica ON
            If LED_EN(ID) = 1 And F_Avvio.Data1 = ID.ToString Then
                setTextBox_N_LED(ID).Enabled = True
                set_Btn_N_GU(ID).Enabled = True
                set_Btn_N_SU(ID).Enabled = True
                If F_Avvio.Data1 <> ID.ToString And setTextBox_N_LED(ID).Text <> String.Empty Then setTextBox_N_LED(ID).Text = F_Avvio.DatiRX_3_1(ID)
                If F_Avvio.Data1 = ID.ToString And setTextBox_N_LED(ID).Text <> String.Empty Then setTextBox_N_LED(ID).Text = F_Avvio.DatiRX_3_1(ID)
                set_Icona(ID).BackgroundImage = set_IMG_Icona_RGB(ID)
                If F_Avvio.DatiRX_3_1(ID) > n Then F_Avvio.DatiRX_3_1(ID) = F_Avvio.DatiRX_3_1(ID)
            End If
            'Stato Modifica ON LED OFF
            If (((LED_EN(ID) = 1 Or LED_EN(ID) = 0) And F_Avvio.Data1 <> ID.ToString) Or (LED_EN(ID) = 0 And F_Avvio.Data1 = ID.ToString)) Then
                setTextBox_N_LED(ID).Enabled = False
                set_Btn_N_GU(ID).Enabled = False
                set_Btn_N_SU(ID).Enabled = False
                If LED_EN(ID) = 0 Then
                    setTextBox_N_LED(ID).Text = "---"
                    set_Icona(ID).BackgroundImage = set_IMG_Icona_NRGB(ID)
                Else
                    setTextBox_N_LED(ID).Text = F_Avvio.DatiRX_3_1(ID)
                    set_Icona(ID).BackgroundImage = set_IMG_Icona_RGB(ID)
                End If

            End If

            'Stato Connesione
            setStato(ID).ForeColor = Color.FromArgb(0, 192, 192)
                setStato(ID).Text = "Collegata"

            ElseIf Elemento_EN(ID) = 0 Then
                set_Btn_Elemento(ID).ForeColor = Color.Silver
            set_Btn_RGB_ON(ID).Enabled = False
            set_Btn_RGB_OFF(ID).Enabled = False
            setTextBox_N_LED(ID).Enabled = False
            set_Btn_N_GU(ID).Enabled = False
            set_Btn_N_SU(ID).Enabled = False
            setTextBox_N_LED(ID).Text = "---"
            setStato(ID).Text = "Scollegata"
            setStato(ID).ForeColor = Color.DarkRed
            set_Btn_RGB_ON(ID).ForeColor = Color.DarkGray
            set_Btn_RGB_OFF(ID).ForeColor = Color.DarkGray
            set_Icona(ID).BackgroundImage = set_IMG_Icona_NRGB(ID)
        End If


        'F_Setting_HUB.BtnConfigurazione.Text = LED_EN(1)

    End Sub



    'Verifica il Numero di LED
    Private Function NumLED_Min(ID As Integer)

        Dim Min As Integer = 0
        Dim Max As Integer = 0

        Dim NumLED_TOT As Integer = 0

        If ID >= 1 And ID <= 4 Then
            Min = 1
            Max = 4
            'GPU 8
        ElseIf ID = 9 Then
            Min = 9
            Max = 9
        ElseIf ID >= 10 And ID <= 12 Then
            Min = 10
            Max = 12
        End If

        For i As Integer = Min To Max
            NumLED_TOT += F_Avvio.DatiRX_3_1(ID)
            If i = 4 Then
                NumLED_TOT += F_Avvio.DatiRX_3_1(8)
            End If
        Next

        If NumLED_TOT > 1 Then
            Return 0
        Else
            Return 1
        End If

        'Return x
    End Function










End Class
