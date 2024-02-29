'Codice Rivisto Ver.2.0.9
Public Class F_Hub_PC

    Public IndirizzoTipoDispositivo As Integer = 1 'Tipo Progetto

    Public IndirizzoElemento_SchedaVideo As Integer = 8 'Scheda Video
    Public IndirizzoElemento_StriscaLED As Integer = 9  'Scheda Striscia LED Case

    'Valori Colore - Animazioni
    Public Hue_Max As Integer = 512
    Public Colore_Rosso_HSV As Integer = 0
    Public Colore_Verde_HSV As Integer = 171
    Public Colore_Blu_HSV As Integer = 341
    Public Colore_Arancione_HSV As Integer = 8 '21
    Public Colore_Fucsioa_HSV As Integer = 427
    Public Colore_Giallo_HSV As Integer = 85
    Public Colore_Celeste_HSV As Integer = 256
    Public Animazione_RGB_Transiszione As Integer = 601
    Public Animazione_RGB_Rainbow As Integer = 602
    Public Animazione_RGB_Tepmeratura As Integer = 604
    Public Animazione_RGB_Musica As Integer = 603
    Public Animazione_RGB_Discontinuo As Integer = 600
    Public Animazione_RGB_Mix As Integer = 605

    Public Luminosità_MIN As Integer = 13
    Public Luminosità_MAX As Integer = 255


    Public FanMenù As String = "Hub PC Home"
    Public RGBAMenù As Integer = 0

    Private Sub F_Fan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Modalità Sync Mode
        If F_Avvio.DatiRX_7(0) = 0 Then
            SwitchPannelHUB(F_HubPC_HUB)
            FanMenù = "Hub PC Sync Mode"
            BtnFan_GUI.Visible = True
            'SwitchPannelHUB(F_HubPC_Home)
            'FanMenù = "Hub PC Home"
            'BtnFan_GUI.Visible = False

            'Modalità Controllo Ventole
        ElseIf F_Avvio.DatiRX_7(0) > 0 And F_Avvio.DatiRX_7(0) < 5 Then
            SwitchPannelHUB(F_HubPC_Ventole)
            FanMenù = "Hub PC Ventole"
            BtnFan_GUI.Visible = True

            'Modalità Controllo Scheda Video o Strisca LED
        ElseIf F_Avvio.DatiRX_7(0) > 7 And F_Avvio.DatiRX_7(0) < 10 Then
            SwitchPannelHUB(F_HubPC_GPU_SLED)
            FanMenù = "Hub PC GPU, Strisca LED"
            BtnFan_GUI.Visible = True

            'Modalità Controllo Dissipatore
        ElseIf F_Avvio.DatiRX_7(0) > 4 And F_Avvio.DatiRX_7(0) < 8 Then
            SwitchPannelHUB(F_HubPC_Dissipatore240)
            FanMenù = "Hub PC Dissipatore 240"
            BtnFan_GUI.Visible = True

            'Modalità Controllo Casse Audio o Strica LED Esterna
        ElseIf F_Avvio.DatiRX_7(0) > 9 Then
            SwitchPannelHUB(F_HubPC_CasseAudio)
            FanMenù = "Hub PC Casse Audio, Strisca LED Esterna"
            BtnFan_GUI.Visible = True
        End If

        'Info Schermata
        F_Home.LabelFinestraID.Text = "Finestra di controllo " & FanMenù

        'Grafica Menù Aniamzione ARGB
        If F_Avvio.DatiRX_5(0) >= Animazione_RGB_Mix Then
            Btn_Men_RGB_Animation_Click()
            F_Home.LaInfoSoft.Text = "000"
        End If



        'Tool_Tip

        'Barra Avvio Rapido
        F_Home.ToolTip1.SetToolTip(BtnTaskHardware_GUI, "Hardware Monitor")
        F_Home.ToolTip1.SetToolTip(BtnImpostazioniFan, "Impostazioni HUB")


        'Info Menù Animazioni A-rgb
        F_Home.ToolTip1.SetToolTip(Btn_Men_RGB_Animation, "Altre Animazioni")
        'If RGBAMenù = 0 Then F_Home.ToolTip1.SetToolTip(Btn_Men_RGB_Animation, "Altre Animazioni")
        'If RGBAMenù = 1 Then F_Home.ToolTip1.SetToolTip(Btn_Men_RGB_Animation, "Animazioni Precedenti")
        'Colore
        F_Home.ToolTip1.SetToolTip(BtnRosso, "Rosso")
        F_Home.ToolTip1.SetToolTip(BtnVerde, "Verde")
        F_Home.ToolTip1.SetToolTip(BtnBlu, "Blu")
        F_Home.ToolTip1.SetToolTip(BtnArancio, "Rosso Arancio")
        F_Home.ToolTip1.SetToolTip(BtnFucsia, "Fucsia")
        F_Home.ToolTip1.SetToolTip(BtnGiallo, "Giallo")
        F_Home.ToolTip1.SetToolTip(BtnAzzurro, "Azzurro")
        F_Home.ToolTip1.SetToolTip(BtnBianco, "Bianco")

        F_Home.ToolTip1.SetToolTip(Btn_Spento, "Spento/Nero - Mix Halloween")
        'If RGBAMenù = 0 Then F_Home.ToolTip1.SetToolTip(Btn_Spento, "Spento / Nero")
        'If RGBAMenù = 1 Then F_Home.ToolTip1.SetToolTip(Btn_Spento, "Mix Halloween")
        'ARGB
        F_Home.ToolTip1.SetToolTip(BtnAN_Transiszione, "Transizione")
        F_Home.ToolTip1.SetToolTip(BtnAN_Rainbow, "Rainbow")
        F_Home.ToolTip1.SetToolTip(BtnAN_Tepmeratura, "Temperatura")
        F_Home.ToolTip1.SetToolTip(BtnAN_Musica, "Musica")
        F_Home.ToolTip1.SetToolTip(BtnAN_Discontinuo, "Discontinuo")
        'Luminosità
        F_Home.ToolTip1.SetToolTip(BtnL_min, "Imposta la luminosità minima")
        F_Home.ToolTip1.SetToolTip(BtnL_max, "Imposta la luminosità massima")
        'Velocità
        F_Home.ToolTip1.SetToolTip(BtnV_min, "Imposta la velocità minima")
        F_Home.ToolTip1.SetToolTip(BtnV_max, "Imposta la velocità massima")

    End Sub


    '//Funzione Multi Form GUI
    Public Sub SwitchPannelHUB(ByVal GUI_Hub_Form As Form)
        Try
            PanelMenùHUB.Controls.Clear()
            GUI_Hub_Form.TopLevel = False
            PanelMenùHUB.Controls.Add(GUI_Hub_Form)
            GUI_Hub_Form.Show()
        Catch ex As Exception

        End Try
    End Sub



    'Bottoni Ausiliari
    '-----------------------------------------------------------------------------------------------------------------

    Private Sub BtnFan_GUI_Click(sender As Object, e As EventArgs) Handles BtnFan_GUI.Click
        FanMenù = "Hub PC Home"
        'Info Schermata
        F_Home.LabelFinestraID.Text = "Finestra di controllo " & FanMenù
        SwitchPannelHUB(F_HubPC_Home)
        BtnFan_GUI.Visible = False
    End Sub

    Public Sub BtnSerialData_Click(sender As Object, e As EventArgs) Handles BtnMenùEX.Click

    End Sub

    'Hardware Monitor PC Hub
    Public Sub BtnTaskHardware_GUI_Click(sender As Object, e As EventArgs) Handles BtnTaskHardware_GUI.Click
        'If F_HardwareMonitor.HardwareOpern = 0 Then
        '    F_HardwareMonitor.Show()
        '    BtnTaskHardware_GUI.BackgroundImage = My.Resources.BtnFanPage_Fan_Task_ON_1_0
        '    F_Connessione.BtnHardwareMonitor.BackgroundImage = My.Resources.Icona_Parametri_FanON
        'End If
        'F_HardwareMonitor.HardwareOpern = 1
        'F_HardwareMonitor.Location = New Point(F_Home.Location.X + F_HardwareMonitor.F_HomeWidth + 5, F_Home.Location.Y - 50%)

        'If F_HardwareMonitor.HardwareOpern = 1 And My.Settings.FormHrdwareTop = 0 Then
        '    F_HardwareMonitor.TopMost = True
        '    F_HardwareMonitor.TopMost = False
        'End If

        F_Avvio.ErrorMod = 100
        F_Avvisi.LabelID_Error.Text = "Error Code " & F_Avvio.ErrorMod
        F_Avvisi.AvvisoErrore()
    End Sub

    'Impostazioni Hub
    Private Sub BtnImpostazioniFan_Click(sender As Object, e As EventArgs) Handles BtnImpostazioniFan.Click
        If F_Setting_HUB.Imp_Open = 0 Then
            F_Setting_HUB.Show()
            BtnImpostazioniFan.BackgroundImage = My.Resources.BtnGUI_HomeImpostazioni
        End If
        F_Setting_HUB.Imp_Open = 1
        F_Setting_HUB.TopMost = True
        F_Setting_HUB.TopMost = False
    End Sub
    '-----------------------------------------------------------------------------------------------------------------



    'Controlli [Velocità - Luminosità - Colore - Animazione]
    '-----------------------------------------------------------------------------------------------------------------
    'Velocità
    Private Sub TrackBarVelocità_Scroll(sender As Object, e As EventArgs) Handles TrackBarVelocità.Scroll
        F_Avvio.Data5 = TrackBarVelocità.Value * 2.55
    End Sub
    Private Sub BtnV_min_Click(sender As Object, e As EventArgs) Handles BtnV_min.Click
        TrackBarVelocità.Value = 0
        F_Avvio.Data5 = 0
    End Sub
    Private Sub BtnV_max_Click(sender As Object, e As EventArgs) Handles BtnV_max.Click
        TrackBarVelocità.Value = 100
        F_Avvio.Data5 = 255
    End Sub

    'Luminosità
    Private Sub TrackBarLuminosità_Scroll(sender As Object, e As EventArgs) Handles TrackBarLuminosità.Scroll
        F_Avvio.Data2 = TrackBarLuminosità.Value * 2.55
    End Sub
    Private Sub BtnL_min_Click(sender As Object, e As EventArgs) Handles BtnL_min.Click
        TrackBarLuminosità.Value = 5
        F_Avvio.Data2 = Luminosità_MIN
    End Sub
    Private Sub BtnL_max_Click(sender As Object, e As EventArgs) Handles BtnL_max.Click
        TrackBarLuminosità.Value = 100
        F_Avvio.Data2 = Luminosità_MAX
    End Sub

    'Rosso
    Private Sub BtnRosso_Click(sender As Object, e As EventArgs) Handles BtnRosso.Click
        F_Avvio.Data3 = Colore_Rosso_HSV
        TX_Btn_Colore()
    End Sub

    'Verde
    Private Sub BtnVerde_Click(sender As Object, e As EventArgs) Handles BtnVerde.Click
        F_Avvio.Data3 = Colore_Verde_HSV
        TX_Btn_Colore()
    End Sub

    'Blu
    Private Sub BtnBlu_Click(sender As Object, e As EventArgs) Handles BtnBlu.Click
        F_Avvio.Data3 = Colore_Blu_HSV
        TX_Btn_Colore()
    End Sub

    'Arancione
    Private Sub BtnArancio_Click(sender As Object, e As EventArgs) Handles BtnArancio.Click
        F_Avvio.Data3 = Colore_Arancione_HSV
        TX_Btn_Colore()
    End Sub

    'Fucsia
    Private Sub BtnFucsia_Click(sender As Object, e As EventArgs) Handles BtnFucsia.Click
        F_Avvio.Data3 = Colore_Fucsioa_HSV
        TX_Btn_Colore()
    End Sub

    'Giallo
    Private Sub BtnGiallo_Click(sender As Object, e As EventArgs) Handles BtnGiallo.Click
        F_Avvio.Data3 = Colore_Giallo_HSV
        TX_Btn_Colore()
    End Sub

    'Azzurro
    Private Sub BtnAzzurro_Click(sender As Object, e As EventArgs) Handles BtnAzzurro.Click
        F_Avvio.Data3 = Colore_Celeste_HSV
        TX_Btn_Colore()
    End Sub

    'Bianco / Saturazione 0
    Private Sub BtnBianco_Click(sender As Object, e As EventArgs) Handles BtnBianco.Click
        F_Avvio.Data4 = 0
        F_Avvio.Data3 = Colore_Arancione_HSV

        If F_Avvio.DatiRX_4(0) < 13 Then
            F_Avvio.Data2 = 255 / 2
            TrackBarLuminosità.Value = 100 / 2
        End If

        TX_Btn_Saturazione()
        TX_Btn_Colore()
    End Sub


    'Menù Btn Animazioni
    Private Sub Btn_Men_RGB_Animation_Click() Handles Btn_Men_RGB_Animation.Click
        If RGBAMenù = 0 Then
            RGBAMenù = 1
            Btn_Men_RGB_Animation.BackgroundImage = My.Resources.Btn_Indietro_50x50
            BtnOFF_Animation()
            Btn_Color_MOD()

            If F_Avvio.Data2 > 0 And F_Avvio.Data3 = Animazione_RGB_Mix And F_Avvio.Data1 = 0 Then
                Btn_Spento.BackgroundImage = My.Resources.BtnLED_halloween_ON
            ElseIf F_Avvio.Data2 > 0 And F_Avvio.Data3 <> Animazione_RGB_Mix And F_Avvio.Data1 = 0 Then
                Btn_Spento.BackgroundImage = My.Resources.BtnLED_halloween_off
            End If

        ElseIf RGBAMenù = 1 Then
            RGBAMenù = 0
            Btn_Men_RGB_Animation.BackgroundImage = My.Resources.Btn_Avanti_50x50
            BtnAN_Transiszione.Visible = True
            'F_Fan.Btn_Spento.Visible = False
            BtnAN_Rainbow.Visible = True
            BtnAN_Musica.Visible = True
            BtnAN_Discontinuo.Visible = True
            BtnAN_Tepmeratura.Visible = True
            Btn_Color_MOD()


            If F_Avvio.Data2 = 0 Then
                Btn_Spento.BackgroundImage = My.Resources.BtnLED_SpentoON
            Else
                Btn_Spento.BackgroundImage = My.Resources.BtnLED_Spento
            End If
        End If

        'LabelRGBAnimazioni.Text = RGBAMenù 'Debug Data Menù
    End Sub


    'Nero / Spento - AnimazioneRGB Mix
    Private Sub Btn_Spento_Click(sender As Object, e As EventArgs) Handles Btn_Spento.Click

        'Nero / Spento
        If RGBAMenù = 0 Then

            F_Avvio.Data2 = 0
            F_Avvio.Data3 = Colore_Arancione_HSV
            TrackBarLuminosità.Value = 5

            If F_Avvio.DatiRX_6(0) = 0 Then
                F_Avvio.Data4 = 255
            End If



            ' AnimazioneRGB Mix
        ElseIf RGBAMenù = 1 Then

            If F_Avvio.DatiRX_7(0) = 0 Then
                F_Avvio.Data3 = Animazione_RGB_Mix
                Luminosità_Reset()
            Else
                F_Avvio.FunzioneNull()
            End If

        End If

        TX_Btn_Colore()

    End Sub


    'Animazione RGB Trasiszione
    Private Sub BtnAN_Transiszione_Click(sender As Object, e As EventArgs) Handles BtnAN_Transiszione.Click
        If F_Avvio.DatiRX_7(0) = 0 Then
            F_Avvio.Data3 = Animazione_RGB_Transiszione

            TX_Btn_Colore()
            Luminosità_Reset()
        Else
            F_Avvio.FunzioneNull()
        End If

    End Sub

    'Animazione RGB RainBow
    Private Sub BtnAN_Rainbow_Click(sender As Object, e As EventArgs) Handles BtnAN_Rainbow.Click
        If F_Avvio.DatiRX_7(0) = 0 Then
            F_Avvio.Data3 = Animazione_RGB_Rainbow
            TX_Btn_Colore()
            Luminosità_Reset()
        Else
            F_Avvio.FunzioneNull()
        End If
    End Sub

    'Animazione RGB Temperatura
    Private Sub BtnANTepmeratura_Click(sender As Object, e As EventArgs) Handles BtnAN_Tepmeratura.Click
        If F_Avvio.DatiRX_7(0) = 0 Then
            'F_Setting_RGB_Animation_Fan_Temp.Show()
            F_Avvio.Data3 = Animazione_RGB_Tepmeratura

            TX_Btn_Colore()
            Luminosità_Reset()
        Else
            F_Avvio.FunzioneNull()
        End If
    End Sub

    'Animazione RGB Musica
    Private Sub BtnAN_Musica_Click(sender As Object, e As EventArgs) Handles BtnAN_Musica.Click
        If F_Avvio.DatiRX_7(0) = 0 Then
            F_Avvio.Data3 = Animazione_RGB_Musica

            TX_Btn_Colore()
            Luminosità_Reset()
        Else
            F_Avvio.FunzioneNull()
        End If



        If F_Avvio.DatiRX_5(0) = Animazione_RGB_Musica Then
            'Luminosità_Reset()
            'My.Settings.AudioDigitalRGB = "Si"
            F_Setting_RGB_Animation_HUB.Show()
            F_Setting_RGB_Animation_HUB.TopMost = True
            F_Setting_RGB_Animation_HUB.TopMost = False
        End If
    End Sub

    'Animazione RGB Discontinuo
    Private Sub BtnANdiscontinuo_Click(sender As Object, e As EventArgs) Handles BtnAN_Discontinuo.Click
        If F_Avvio.DatiRX_7(0) = 0 Then
            F_Avvio.Data3 = Animazione_RGB_Discontinuo

            TX_Btn_Colore()
        Else
            F_Avvio.FunzioneNull()
        End If
    End Sub



    'Memorizza il Colore Impostato al dispositivo selezionato HSV = H
    'Public H_All As Integer
    Public Sub TX_Btn_Colore()
        Select Case F_Avvio.Data1
            Case = 0
                H_SyncMode = F_Avvio.Data3
            Case = 1
                H_Fan1 = F_Avvio.Data3
            Case = 2
                H_Fan2 = F_Avvio.Data3
            Case = 3
                H_Fan3 = F_Avvio.Data3
            Case = 4
                H_Fan4 = F_Avvio.Data3
            Case = 5
                H_Fan_CPU_OP_01 = F_Avvio.Data3
            Case = 6
                H_Fan_CPU_OP_02 = F_Avvio.Data3
            Case = 7
                H_CPU_OP = F_Avvio.Data3

            Case = IndirizzoElemento_SchedaVideo
                H_GPU = F_Avvio.Data3

            Case = IndirizzoElemento_StriscaLED
                H_SLED = F_Avvio.Data3
            Case = 10
                H_Cassa_Audio_S = F_Avvio.Data3
            Case = 11
                H_Cassa_Audio_D = F_Avvio.Data3
            Case = 12
                H_Strip_LED = F_Avvio.Data3
        End Select
        Luminosità_Reset()
        TX_Btn_Saturazione()
    End Sub

    'Memorizza la Saturazione Impostata al dispositivo selezionato HSV = S
    Public Sub TX_Btn_Saturazione()
        Select Case F_Avvio.Data1
            Case = 0
                S_SyncMode = F_Avvio.Data4
            Case = 1
                S_Fan1 = F_Avvio.Data4
            Case = 2
                S_Fan2 = F_Avvio.Data4
            Case = 3
                S_Fan3 = F_Avvio.Data4
            Case = 4
                S_Fan4 = F_Avvio.Data4
            Case = 5
                S_Fan_CPU_OP_01 = F_Avvio.Data4
            Case = 6
                S_Fan_CPU_OP_02 = F_Avvio.Data4
            Case = 7
                S_CPU_OP = F_Avvio.Data4

            Case = IndirizzoElemento_SchedaVideo
                S_GPU = F_Avvio.Data4

            Case = IndirizzoElemento_StriscaLED
                S_SLED = F_Avvio.Data4
            Case = 10
                S_Cassa_Audio_S = F_Avvio.Data4
            Case = 11
                S_Cassa_Audio_D = F_Avvio.Data4
            Case = 12
                S_Strip_LED = F_Avvio.Data4
        End Select
        Luminosità_Reset()
    End Sub

    'Memorizza la Luminosità Impostata al dispositivo selezionato HSV = V
    Public Sub TX_Btn_Luminosità()
        Select Case F_Avvio.Data1
            Case = 0
                V_SyncMode = F_Avvio.Data2
            Case = 1
                V_Fan1 = F_Avvio.Data2
            Case = 2
                V_Fan2 = F_Avvio.Data2
            Case = 3
                V_Fan3 = F_Avvio.Data2
            Case = 4
                V_Fan4 = F_Avvio.Data2
            Case = 5
                V_Fan_CPU_OP_01 = F_Avvio.Data2
            Case = 6
                V_Fan_CPU_OP_02 = F_Avvio.Data2
            Case = 7
                V_CPU_OP = F_Avvio.Data2

            Case = IndirizzoElemento_SchedaVideo
                V_GPU = F_Avvio.Data2

            Case = IndirizzoElemento_StriscaLED
                V_SLED = F_Avvio.Data2
            Case = 10
                V_Cassa_Audio_S = F_Avvio.Data2
            Case = 11
                V_Cassa_Audio_D = F_Avvio.Data2
            Case = 12
                V_Strip_LED = F_Avvio.Data2
        End Select
    End Sub














    'Funzione Loop: aggiorna e inserisce i dati Modificati sia dal Utente che dai sensori


    Public LED_CFan As Integer = 1
    Public Aggiorna_RX As String = 0
    '
    Public VerificaRX_Data_LED_Select As Byte = 1


    Public Aggiorna_RX_LED As String = 0
    '
    Dim VerificaRX_Data_Colore As String
    '
    Dim VerificaRX_Data_Saturazione As String
    '
    Dim VerificaAutoFan As String


    '
    Dim VerificaRX_Data_Luminosità As String
    Public Aggorna_Luminosità As Integer = 0
    Public PercentualeLuminosità As Integer
    '
    Dim VerificaRX_Data_Fan_Speed As String
    Dim VerificaRX_Data_Fan_Speed_Mod As String
    Public Aggiorna_Speed As Integer = 0
    Public PercentualeVelocità As Integer
    '

    Dim n As Integer
    '  n += 1
    '        F_Home.LabelFinestraID.Text = n
    'Funzione loop

    Public Sub RX_TX()

        'PowerLimitLED
        'If (F_Avvio.DatiRX_1(4) = 1 And F_Avvio.Data2 > F_Avvio.DatiRX_4(0)) Then
        '    Dim L As Integer = F_Avvio.DatiRX_4(0) / 2.55
        '    If ((L >= TrackBarLuminosità.Minimum) And (L <= TrackBarLuminosità.Maximum)) Then
        '        TrackBarLuminosità.Value = L
        '        F_Avvio.Data2 = F_Avvio.DatiRX_4(0)
        '    End If
        'End If


        'Imposta La barra di regolazione Luminosità / Velocita Venrtole
        If F_Avvio.DatiRX_7(0) <> VerificaRX_Data_LED_Select Then

            If F_Avvio.DatiRX_4(0) >= 13 Then TrackBarLuminosità.Value = F_Avvio.DatiRX_4(0) / 2.55
            TrackBarVelocità.Value = F_Avvio.DatiRX_8(0) / 2.55

        End If


        'Verifica Quando rileva un cambiamento nella SeralPort Data RX Fan LED ALL
        If ((F_Avvio.DatiRX_7(0) <> VerificaRX_Data_LED_Select) Or (F_Avvio.DatiRX_4(0) <> VerificaRX_Data_Luminosità) Or (F_Avvio.DatiRX_5(0) <> VerificaRX_Data_Colore) Or (F_Avvio.DatiRX_6(0) <> VerificaRX_Data_Saturazione) Or (F_Avvio.DatiRX_8(0) <> VerificaRX_Data_Fan_Speed) Or (F_Avvio.DatiRX_9(0) <> VerificaRX_Data_Fan_Speed_Mod)) Then
            '
            If F_Avvio.DatiRX_5(0) < Hue_Max Then
                H = F_Avvio.DatiRX_5(0)
                S = F_Avvio.DatiRX_6(0)
                If F_Avvio.DatiRX_4(0) > 0 Then
                    Dim MapLum As Integer = map(F_Avvio.DatiRX_4(0), 0, 255, 80, 255)
                    V = MapLum
                Else
                    V = F_Avvio.DatiRX_4(0)
                End If
                HSV_to_RGB()
            End If


            If F_Avvio.DatiRX_7(0) > 0 And F_Avvio.DatiRX_7(0) <= 4 Then
                F_HubPC_Ventole.IconaFanScolor.BackColor = Color.FromArgb(R, G, B)

            ElseIf F_Avvio.DatiRX_7(0) = 0 Then
                F_HubPC_HUB.IconaHUB_Color.BackColor = Color.FromArgb(R, G, B)
                'F_HubPC_Ventole.IconaFanScolor.BackColor = Color.FromArgb(R, G, B)
                'F_HubPC_GPU_SLED.IconaStatoFan_Menù_2.BackColor = Color.FromArgb(R, G, B)
                'F_HubPC_Dissipatore240.IconaStatoFan_Menù_3.BackColor = Color.FromArgb(R, G, B)
                'F_HubPC_CasseAudio.Icona_CassaAudio_S.BackColor = Color.FromArgb(R, G, B)
                'F_HubPC_CasseAudio.Icona_CassaAudio_D.BackColor = Color.FromArgb(R, G, B)
                'F_HubPC_CasseAudio.Icona_StripLED.BackColor = Color.FromArgb(R, G, B)
            End If

            '
            Aggorna_Luminosità = 1
            If F_Avvio.DatiRX_7(0) <= 4 Then
                Aggiorna_Speed = 1
            End If
            '
            Btn_Color_MOD()
            TX_Btn_Luminosità()
            HubControlManual()
            '
            VerificaRX_Data_LED_Select = F_Avvio.DatiRX_7(0)
            VerificaRX_Data_Luminosità = F_Avvio.DatiRX_4(0)
            VerificaRX_Data_Colore = F_Avvio.DatiRX_5(0)
            VerificaRX_Data_Saturazione = F_Avvio.DatiRX_6(0)
            VerificaRX_Data_Fan_Speed = F_Avvio.DatiRX_8(0)
            VerificaRX_Data_Fan_Speed_Mod = F_Avvio.DatiRX_9(0)

        End If



        'Aggornamento Fan Luminosita LED
        If Aggorna_Luminosità = 1 Then
            'Luminosità Grafica
            If F_Avvio.DatiRX_4(0) <> "0" Then
                TrackBarLuminosità.Enabled = True
                'Luminosità Max
                If ((F_Avvio.DatiRX_4(0) = 255)) Then
                    BtnL_min.Enabled = True
                    BtnL_max.Enabled = False
                End If
                'Luminosità Min
                If ((F_Avvio.DatiRX_4(0) = 13)) Then
                    BtnL_min.Enabled = False
                    BtnL_max.Enabled = True
                End If
                'Luminosità Max / Min
                If ((F_Avvio.DatiRX_4(0) >= 14) And (F_Avvio.DatiRX_4(0) <= 254)) Then
                    BtnL_min.Enabled = True
                    BtnL_max.Enabled = True
                End If
                'Luminosità Spento
            ElseIf F_Avvio.DatiRX_4(0) = "0" Then
                TrackBarLuminosità.Enabled = False
                BtnL_min.Enabled = False
                BtnL_max.Enabled = False
            End If

            'Imposta il colore selezionato alle icone del dispositivo selezionato
            Select Case F_Avvio.DatiRX_7(0)
                Case = 0 'And F_Avvio.DatiRX_5(0) < Hue_Max
                    F_HubPC_Home.Color_Set_Home_IMG()
                    'F_HubPC_Ventole.Color_Set_Ventole_IMG()
                Case = 1
                    F_HubPC_Home.Color_Set_Home_IMG()
                    F_HubPC_Ventole.Color_Set_Ventole_IMG()
                Case = 2
                    F_HubPC_Home.Color_Set_Home_IMG()
                    F_HubPC_Ventole.Color_Set_Ventole_IMG()
                Case = 3
                    F_HubPC_Home.Color_Set_Home_IMG()
                    F_HubPC_Ventole.Color_Set_Ventole_IMG()
                Case = 4
                    F_HubPC_Home.Color_Set_Home_IMG()
                    F_HubPC_Ventole.Color_Set_Ventole_IMG()

                Case = 5
                    F_HubPC_Home.Color_Set_Home_IMG()
                    F_HubPC_Dissipatore240.Btn_FanCPU_LED01.BackColor = Color.FromArgb(R, G, B)
                    F_HubPC_Dissipatore240.IconaStatoFan_Menù_3.BackColor = Color.FromArgb(R, G, B)
                Case = 6
                    F_HubPC_Home.Color_Set_Home_IMG()
                    F_HubPC_Dissipatore240.Btn_FanCPU_LED02.BackColor = Color.FromArgb(R, G, B)
                    F_HubPC_Dissipatore240.IconaStatoFan_Menù_3.BackColor = Color.FromArgb(R, G, B)
                Case = 7
                    F_HubPC_Home.Color_Set_Home_IMG()
                    F_HubPC_Dissipatore240.Btn_PompCPU_LED.BackColor = Color.FromArgb(R, G, B)
                    F_HubPC_Dissipatore240.IconaStatoFan_Menù_3.BackColor = Color.FromArgb(R, G, B)
                Case = IndirizzoElemento_SchedaVideo
                    F_HubPC_Home.Color_Set_Home_IMG()
                    F_HubPC_GPU_SLED.Color_Set_GPU_SLED_IMG()
                    F_HubPC_GPU_SLED.IconaStato_Menù_2.BackColor = Color.FromArgb(R, G, B)
                Case = IndirizzoElemento_StriscaLED
                    F_HubPC_Home.Color_Set_Home_IMG()
                    F_HubPC_GPU_SLED.Color_Set_GPU_SLED_IMG()
                    F_HubPC_GPU_SLED.IconaStato_Menù_2.BackColor = Color.FromArgb(R, G, B)
                Case = 10
                    F_HubPC_Home.Color_Set_Home_IMG()
                    F_HubPC_CasseAudio.Btn_CassaAudio_S.BackColor = Color.FromArgb(R, G, B)
                    F_HubPC_CasseAudio.Icona_CassaAudio_S.BackColor = Color.FromArgb(R, G, B)
                Case = 11
                    F_HubPC_Home.Color_Set_Home_IMG()
                    F_HubPC_CasseAudio.Btn_CassaAudio_D.BackColor = Color.FromArgb(R, G, B)
                    F_HubPC_CasseAudio.Icona_CassaAudio_D.BackColor = Color.FromArgb(R, G, B)
                Case = 12
                    F_HubPC_Home.Color_Set_Home_IMG()
                    F_HubPC_CasseAudio.Btn_StripLED.BackColor = Color.FromArgb(R, G, B)
                    F_HubPC_CasseAudio.Icona_StripLED.BackColor = Color.FromArgb(R, G, B)
            End Select



            If F_Avvio.DatiRX_4(0) >= 13 Then
                Dim L_Int As Integer = F_Avvio.DatiRX_4(0) / 2.55

                PercentualeLuminosità = F_Avvio.DatiRX_4(0) / 2.55

                Select Case F_Avvio.DatiRX_7(0)
                    Case = 0
                        F_HubPC_HUB.LaLuminosità.Text = PercentualeLuminosità & "%"
                        'F_HubPC_Ventole.LaLuminosità.Text = "Luminosità   " & PercentualeLuminosità & "%"
                        ''F_HubPC_Ventole.LodBarLimAll.Height = F_Avvio.DatiRX_4(0) / 5.66
                        'F_HubPC_GPU_SLED.LaLuminosità.Text = "Luminosità               " & L_Int & "%"
                        'F_HubPC_Dissipatore240.LaLuminosità.Text = "Luminosità  " & L_Int & "%"
                        'F_HubPC_CasseAudio.LaLuminosità.Text = "Luminosità            " & L_Int & "%"

                    Case = 1
                        F_HubPC_Ventole.LaLuminosità.Text = "Luminosità   " & PercentualeLuminosità & "%"
                        F_HubPC_Ventole.LodBarLimFan1.Height = F_Avvio.DatiRX_4(0) / 5.66
                    Case = 2
                        F_HubPC_Ventole.LaLuminosità.Text = "Luminosità   " & PercentualeLuminosità & "%"
                        F_HubPC_Ventole.LodBarLimFan2.Height = F_Avvio.DatiRX_4(0) / 5.66
                    Case = 3
                        F_HubPC_Ventole.LaLuminosità.Text = "Luminosità   " & PercentualeLuminosità & "%"
                        F_HubPC_Ventole.LodBarLimFan3.Height = F_Avvio.DatiRX_4(0) / 5.66
                    Case = 4
                        F_HubPC_Ventole.LaLuminosità.Text = "Luminosità   " & PercentualeLuminosità & "%"
                        F_HubPC_Ventole.LodBarLimFan4.Height = F_Avvio.DatiRX_4(0) / 5.66

                    Case = 5
                        F_HubPC_Dissipatore240.LaLuminosità.Text = "Luminosità  " & L_Int & "%"
                    Case = 6
                        F_HubPC_Dissipatore240.LaLuminosità.Text = "Luminosità  " & L_Int & "%"
                    Case = 7
                        F_HubPC_Dissipatore240.LaLuminosità.Text = "Luminosità  " & L_Int & "%"
                    Case = IndirizzoElemento_SchedaVideo
                        F_HubPC_GPU_SLED.LaLuminosità.Text = "Luminosità               " & L_Int & "%"
                    Case = IndirizzoElemento_StriscaLED
                        F_HubPC_GPU_SLED.LaLuminosità.Text = "Luminosità               " & L_Int & "%"
                    Case = 10
                        F_HubPC_CasseAudio.LaLuminosità.Text = "Luminosità            " & L_Int & "%"
                    Case = 11
                        F_HubPC_CasseAudio.LaLuminosità.Text = "Luminosità            " & L_Int & "%"
                    Case = 12
                        F_HubPC_CasseAudio.LaLuminosità.Text = "Luminosità            " & L_Int & "%"

                End Select
            End If

            Aggorna_Luminosità = 0
        End If


        'Aggornamento Fan Velocità
        If Aggiorna_Speed = 1 Then

            TrackBarVelocità.Enabled = True

            If F_Avvio.DatiRX_8(0) = 255 Then
                BtnV_min.Enabled = True
                BtnV_max.Enabled = False
            End If
            If F_Avvio.DatiRX_8(0) = 0 Then
                BtnV_min.Enabled = False
                BtnV_max.Enabled = True

            End If
            If F_Avvio.DatiRX_8(0) >= 1 And F_Avvio.DatiRX_8(0) <= 254 Then
                BtnV_min.Enabled = True
                BtnV_max.Enabled = True
            End If


            Select Case F_Avvio.DatiRX_7(1)
                Case = 0
                    'F_HubPC_Home.Btn_Hub_SyncMode.BackColor = Color.FromArgb(0, 140, 149)
                    'F_HubPC_Ventole.LodBarSpeeAll.Height = 0 + F_Avvio.DatiRX_8(0) / 5.66
                Case = 1
                    F_HubPC_Ventole.LodBarSpeeFan1.BackColor = Color.FromArgb(0, 140, 149)
                    F_HubPC_Ventole.LodBarSpeeFan1.Height = 0 + F_Avvio.DatiRX_8(0) / 5.66
                Case = 2
                    F_HubPC_Ventole.LodBarSpeeFan2.BackColor = Color.FromArgb(0, 140, 149)
                    F_HubPC_Ventole.LodBarSpeeFan2.Height = 0 + F_Avvio.DatiRX_8(0) / 5.66
                Case = 3
                    F_HubPC_Ventole.LodBarSpeeFan3.BackColor = Color.FromArgb(0, 140, 149)
                    F_HubPC_Ventole.LodBarSpeeFan3.Height = 0 + F_Avvio.DatiRX_8(0) / 5.66
                Case = 4
                    F_HubPC_Ventole.LodBarSpeeFan4.BackColor = Color.FromArgb(0, 140, 149)
                    F_HubPC_Ventole.LodBarSpeeFan4.Height = 0 + F_Avvio.DatiRX_8(0) / 5.66
            End Select


            PercentualeVelocità = F_Avvio.DatiRX_8(0) / 2.55
            F_HubPC_Ventole.LaVelocità.ForeColor = Color.FromArgb(0, 140, 149)
            F_HubPC_Ventole.LaVelocità.Text = "Velocità        " & PercentualeVelocità & "%"
            F_HubPC_Ventole.LaFanModalità.ForeColor = Color.FromArgb(0, 140, 149)
            F_HubPC_Ventole.LaFanModalità.Text = "Modalità      Manuale"
            F_HubPC_HUB.LaFanModalità.Text = "Manuale"
            F_HubPC_HUB.LaVelocità.Text = PercentualeVelocità & "%"
            F_HubPC_Ventole.TX_Btn_Velocità()

            Aggiorna_Speed = 0
        End If



        ''Verifica Quando rileva un cambiamento nella SeralPort Data RX Fan LED ALL
        'If ((F_Avvio.DatiRX_7(LED_CFan) <> VerificaRX_Data_Fan_Speed) Or (F_Avvio.DatiRX_6(0) <> F_Avvio.Data8) Or (F_Avvio.DatiRX_8(1) <> VerificaAutoFan)) Then
        '    Aggorna_SpeedFan = 1
        '    VerificaAutoFan = F_Avvio.DatiRX_8(1)
        '    VerificaRX_Data_Fan_Speed = F_Avvio.DatiRX_7(LED_CFan)
        'End If
        ''If Aggorna_SpeedFan = 1 Then
        ''    F_Fan_Menù.GUI_Ventole()
        ''End If


        'If F_Avvio.Data5 = 1 And F_Avvio.Data9 = 14 Then

        '    F_Setting_RGB_Animation_Fan_Temp.Label1.ForeColor = Color.Black
        '    F_Setting_RGB_Animation_Fan_Temp.Label2.ForeColor = Color.Black
        '    F_Setting_RGB_Animation_Fan_Temp.Label3.ForeColor = Color.OrangeRed
        'ElseIf F_Avvio.Data5 = 2 And F_Avvio.Data9 = 14 Then

        '    F_Avvio.Data4 = F_Avvio.CPU_TemperaturaL
        '    F_Setting_RGB_Animation_Fan_Temp.Label1.ForeColor = Color.OrangeRed
        '    F_Setting_RGB_Animation_Fan_Temp.Label2.ForeColor = Color.Black
        '    F_Setting_RGB_Animation_Fan_Temp.Label3.ForeColor = Color.Black
        'ElseIf F_Avvio.Data5 = 3 And F_Avvio.Data9 = 14 Then

        '    F_Avvio.Data4 = F_Avvio.GPU_Temperatura
        '    F_Setting_RGB_Animation_Fan_Temp.Label1.ForeColor = Color.Black
        '    F_Setting_RGB_Animation_Fan_Temp.Label2.ForeColor = Color.OrangeRed
        '    F_Setting_RGB_Animation_Fan_Temp.Label3.ForeColor = Color.Black
        'End If

        'If F_Avvio.DatiRX_5(0) = 604 And F_Setting_RGB_Animation_Fan_Temp.IsHandleCreated Then
        '    'F_Setting_RGB_Animation_Fan_Temp.Btn_Temp_CPU.ForeColor = Color.DarkOrange

        '    If F_Avvio.DatiRX_11(0) = 2 Then
        '        F_Setting_RGB_Animation_Fan_Temp.Btn_Temp_CPU.ForeColor = Color.DarkOrange
        '        F_Setting_RGB_Animation_Fan_Temp.Btn_Temp_GPU.ForeColor = Color.Black
        '        F_Setting_RGB_Animation_Fan_Temp.Btn_Temp_SenS.ForeColor = Color.Black
        '    End If
        '    If F_Avvio.DatiRX_11(0) = 3 Then
        '        F_Setting_RGB_Animation_Fan_Temp.Btn_Temp_GPU.ForeColor = Color.DarkOrange
        '        F_Setting_RGB_Animation_Fan_Temp.Btn_Temp_CPU.ForeColor = Color.Black
        '        F_Setting_RGB_Animation_Fan_Temp.Btn_Temp_SenS.ForeColor = Color.Black
        '    End If
        '    If F_Avvio.DatiRX_11(0) = 1 Then
        '        F_Setting_RGB_Animation_Fan_Temp.Btn_Temp_SenS.ForeColor = Color.DarkOrange
        '        F_Setting_RGB_Animation_Fan_Temp.Btn_Temp_CPU.ForeColor = Color.Black
        '        F_Setting_RGB_Animation_Fan_Temp.Btn_Temp_GPU.ForeColor = Color.Black
        '    End If

        'End If


    End Sub


    '//Btn Colori Indicatori
    Public Sub Btn_Color_MOD()
        Dim X As Integer
        If ((F_Avvio.DatiRX_5.Length - 1) > 0) Then
            X = F_Avvio.DatiRX_7(0)
        Else
            X = 0
        End If
        'Aggornamento GUI_Fan Grafica LED
        'Stato Btn GUI_Fan / ON LUM_OFF


        Btn_Fan_GUI()
        Btn_Color_Fan_GUI()

        'Stato Btn GUI_Fan / Btn Spento ON 
        If F_Avvio.DatiRX_4(X) = "0" And F_Avvio.DatiRX_6(X) <> "0" Then

            If F_Avvio.DatiRX_7(0) = 0 Then
                F_HubPC_HUB.LaColore.Text = "Spento"
                F_HubPC_HUB.LaColore.ForeColor = Color.White
            End If
            If F_Avvio.DatiRX_7(0) >= 1 And F_Avvio.DatiRX_7(0) <= 4 Then
                F_HubPC_Ventole.LaColore.ForeColor = Color.FromArgb(0, 140, 149)
                F_HubPC_Ventole.LaColore.Text = "Colore          Spento"
            End If
            If F_Avvio.DatiRX_7(0) > 4 And F_Avvio.DatiRX_7(0) < 8 Then
                F_HubPC_Dissipatore240.LaColore.ForeColor = Color.FromArgb(0, 140, 149)
                F_HubPC_Dissipatore240.LaColore.Text = "Colore Spento"
            End If
            'If F_Avvio.DatiRX_7(0) > (IndirizzoElemento_SchedaVideo - 1) And F_Avvio.DatiRX_7(0) < (IndirizzoElemento_StriscaLED + 1) Then
            If F_Avvio.DatiRX_7(0) > 7 And F_Avvio.DatiRX_7(0) < 10 Then
                    F_HubPC_GPU_SLED.LaColore.ForeColor = Color.FromArgb(0, 140, 149)
                    F_HubPC_GPU_SLED.LaColore.Text = "Spento"
                End If
                If F_Avvio.DatiRX_7(0) > 9 And F_Avvio.DatiRX_7(0) < 13 Then
                F_HubPC_CasseAudio.LaColore.ForeColor = Color.FromArgb(0, 140, 149)
                F_HubPC_CasseAudio.LaColore.Text = "Spento"
            End If

            'Btn_Spento.BackgroundImage = My.Resources.BtnLED_SpentoON
            If RGBAMenù = 0 Then Btn_Spento.BackgroundImage = My.Resources.BtnLED_SpentoON
            'If RGBAMenù = 1 Then Btn_Spento.BackgroundImage = My.Resources.BtnLED_halloween_ON
            Btn_RGB_IMG_GUI()
        End If
        'ColorBtn Bianco
        If F_Avvio.DatiRX_6(X) = "0" And F_Avvio.DatiRX_4(X) <> "0" Then

            If F_Avvio.DatiRX_7(0) = 0 Then
                F_HubPC_HUB.LaColore.Text = "Bianco"
                F_HubPC_HUB.LaColore.ForeColor = Color.White
            End If
            If F_Avvio.DatiRX_7(0) >= 1 And F_Avvio.DatiRX_7(0) <= 4 Then
                F_HubPC_Ventole.LaColore.ForeColor = Color.White
                F_HubPC_Ventole.LaColore.Text = "Colore          Bianco"
            End If
            If F_Avvio.DatiRX_7(0) > 4 And F_Avvio.DatiRX_7(0) < 8 Then
                F_HubPC_Dissipatore240.LaColore.ForeColor = Color.White
                F_HubPC_Dissipatore240.LaColore.Text = "Bianco"
            End If
            'If F_Avvio.DatiRX_7(0) > (IndirizzoElemento_SchedaVideo - 1) And F_Avvio.DatiRX_7(0) < (IndirizzoElemento_StriscaLED + 1) Then
            If F_Avvio.DatiRX_7(0) > 7 And F_Avvio.DatiRX_7(0) < 10 Then
                F_HubPC_GPU_SLED.LaColore.ForeColor = Color.White
                F_HubPC_GPU_SLED.LaColore.Text = "Bianco"
            End If
            If F_Avvio.DatiRX_7(0) > 9 And F_Avvio.DatiRX_7(0) < 13 Then
                F_HubPC_CasseAudio.LaColore.ForeColor = Color.White
                F_HubPC_CasseAudio.LaColore.Text = "Bianco"
            End If

            BtnBianco.BorderStyle = BorderStyle.Fixed3D
                Btn_RGB_IMG_GUI()
            End If


            If F_Avvio.DatiRX_4(X) <> "0" And F_Avvio.DatiRX_6(X) <> "0" Then

            'Stato Btn GUI_Fan / BtnRGB Discontinuo
            If F_Avvio.DatiRX_5(X) = Animazione_RGB_Discontinuo Then

                If F_Avvio.DatiRX_7(0) = 0 Then
                    F_HubPC_HUB.LaColore.Text = "Discontinuo"
                    F_HubPC_HUB.LaColore.ForeColor = Color.White
                End If

                'RGB HuB Home PC
                F_HubPC_Home.Btn_F_HubPC_Ventole.BackgroundImage = My.Resources.IconaFan_RGB_Colore_Transizione
                F_HubPC_Home.Btn_F_HubPC_Dissipatore.BackgroundImage = My.Resources.Dissipatore240mm_Colore_Discontinuo          'F_HubPC_Dissipatore240.IconaStatoFan_Menù_3.BackgroundImage = My.Resources.Icona_DeepCool_RGB_Discontinuo_v1_3
                F_HubPC_Home.Btn_F_HubPC_GPU.BackgroundImage = My.Resources.Icona_SchedaVideo_Effeto_Discontinuo
                F_HubPC_Home.Btn_F_HubPC_SLED.BackgroundImage = My.Resources.Icona_Strisca__RGB_Colore_Discontinuo
                F_HubPC_Home.Btn_F_HubPC_CasseAudio.BackgroundImage = My.Resources.IconaCasaAudio_RGB_Colore_Discontinuo
                F_HubPC_Home.Btn_Hub_SyncMode.BackgroundImage = My.Resources.Icona_HUB_1_1_RGB_Colore_Discontinuo

                'RGB HuB PC
                F_HubPC_HUB.IconaHUB_Color.BackgroundImage = My.Resources.Icona_HUB_1_1_RGB_Colore_Discontinuo
                F_HubPC_HUB.Btn_Fan_Info.BackgroundImage = My.Resources.IconaFan_RGB_Colore_Transizione
                F_HubPC_HUB.Btn_Casse_Info.BackgroundImage = My.Resources.IconaCasaAudio_RGB_Colore_Discontinuo
                F_HubPC_HUB.Btn_Dissipatore_Info.BackgroundImage = My.Resources.Dissipatore240mm_Colore_Discontinuo
                F_HubPC_HUB.Btn_GPU_Info.BackgroundImage = My.Resources.Icona_SchedaVideo_Effeto_Discontinuo
                F_HubPC_HUB.Btn_StriscaLED_Info.BackgroundImage = My.Resources.Icona_Strisca__RGB_Colore_Discontinuo

                Icona_Fan_All_RGB_Mod()
                RGB_Aniamtion_Img()

                BtnAN_Discontinuo.BackgroundImage = My.Resources.BtnLED_DiscontinuoON
            End If
            'Stato Btn GUI_Fan / BtnRGB Transizione
            If F_Avvio.DatiRX_5(X) = Animazione_RGB_Transiszione Then

                If F_Avvio.DatiRX_7(0) = 0 Then
                    F_HubPC_HUB.LaColore.Text = "Transizione"
                    F_HubPC_HUB.LaColore.ForeColor = Color.White
                End If

                'RGB HuB Home PC
                F_HubPC_Home.Btn_F_HubPC_Ventole.BackgroundImage = My.Resources.IconaFan_RGB_Colore_Transizione_2_0
                F_HubPC_Home.Btn_F_HubPC_Dissipatore.BackgroundImage = My.Resources.Dissipatore240mm_Colore_Transizione
                F_HubPC_Home.Btn_F_HubPC_GPU.BackgroundImage = My.Resources.Icona_SchedaVideo_Effeto_Transizione
                F_HubPC_Home.Btn_Hub_SyncMode.BackgroundImage = My.Resources.Icona_HUB_1_1_RGB_Colore_Transizione
                F_HubPC_Home.Btn_F_HubPC_CasseAudio.BackgroundImage = My.Resources.IconaCasaAudio_RGB_Colore_Transizione
                F_HubPC_Home.Btn_F_HubPC_SLED.BackgroundImage = My.Resources.Icona_Strisca__RGB_Colore_Transizione

                'RGB HuB PC
                F_HubPC_HUB.IconaHUB_Color.BackgroundImage = My.Resources.Icona_HUB_1_1_RGB_Colore_Transizione
                F_HubPC_HUB.Btn_Fan_Info.BackgroundImage = My.Resources.IconaFan_RGB_Colore_Transizione_2_0
                F_HubPC_HUB.Btn_Casse_Info.BackgroundImage = My.Resources.IconaCasaAudio_RGB_Colore_Transizione
                F_HubPC_HUB.Btn_Dissipatore_Info.BackgroundImage = My.Resources.Dissipatore240mm_Colore_Transizione
                F_HubPC_HUB.Btn_GPU_Info.BackgroundImage = My.Resources.Icona_SchedaVideo_Effeto_Transizione
                F_HubPC_HUB.Btn_StriscaLED_Info.BackgroundImage = My.Resources.Icona_Strisca__RGB_Colore_Transizione

                Icona_Fan_All_RGB_Mod()
                RGB_Aniamtion_Img()

                BtnAN_Transiszione.BackgroundImage = My.Resources.BtnLED_TransizioneON
            End If
            'Stato Btn GUI_Fan / BtnRGB RainBow
            If F_Avvio.DatiRX_5(X) = Animazione_RGB_Rainbow Then

                If F_Avvio.DatiRX_7(0) = 0 Then
                    F_HubPC_HUB.LaColore.Text = "RainBow"
                    F_HubPC_HUB.LaColore.ForeColor = Color.White
                End If

                'RGB HuB Home PC
                F_HubPC_Home.Btn_F_HubPC_Ventole.BackgroundImage = My.Resources.IconaFan_RGB_Colore_RainBow
                F_HubPC_Home.Btn_F_HubPC_Dissipatore.BackgroundImage = My.Resources.Dissipatore240mm_Colore_RainBow
                F_HubPC_Home.Btn_F_HubPC_GPU.BackgroundImage = My.Resources.Icona_SchedaVideo_Effeto_RainBow
                F_HubPC_Home.Btn_Hub_SyncMode.BackgroundImage = My.Resources.Icona_HUB_1_1_RGB_Colore_RainBow
                F_HubPC_Home.Btn_F_HubPC_CasseAudio.BackgroundImage = My.Resources.IconaCasaAudio_RGB_Colore_RainBow
                F_HubPC_Home.Btn_F_HubPC_SLED.BackgroundImage = My.Resources.Icona_Strisca__RGB_Colore_RainBow

                'RGB HuB PC
                F_HubPC_HUB.IconaHUB_Color.BackgroundImage = My.Resources.Icona_HUB_1_1_RGB_Colore_RainBow
                F_HubPC_HUB.Btn_Fan_Info.BackgroundImage = My.Resources.IconaFan_RGB_Colore_RainBow
                F_HubPC_HUB.Btn_Casse_Info.BackgroundImage = My.Resources.IconaCasaAudio_RGB_Colore_RainBow
                F_HubPC_HUB.Btn_Dissipatore_Info.BackgroundImage = My.Resources.Dissipatore240mm_Colore_RainBow
                F_HubPC_HUB.Btn_GPU_Info.BackgroundImage = My.Resources.Icona_SchedaVideo_Effeto_RainBow
                F_HubPC_HUB.Btn_StriscaLED_Info.BackgroundImage = My.Resources.Icona_Strisca__RGB_Colore_RainBow

                Icona_Fan_All_RGB_Mod()
                RGB_Aniamtion_Img()

                BtnAN_Rainbow.BackgroundImage = My.Resources.BtnLED_RainBowON
            End If
            'Stato Btn GUI_Fan / BtnRGB Musica
            If F_Avvio.DatiRX_5(X) = Animazione_RGB_Musica Then

                If F_Avvio.DatiRX_7(0) = 0 Then
                    F_HubPC_HUB.LaColore.Text = "Musica"
                    F_HubPC_HUB.LaColore.ForeColor = Color.White
                End If

                Icona_Fan_All_RGB_Mod()
                RGB_Aniamtion_Img()

                'RGB HuB Home PC
                F_HubPC_Home.Btn_F_HubPC_Ventole.BackgroundImage = My.Resources.IconaFan_RGB_Colore_Musica_2_0
                F_HubPC_Home.Btn_F_HubPC_Dissipatore.BackgroundImage = My.Resources.Dissipatore240mm_Colore_Musica
                F_HubPC_Home.Btn_F_HubPC_GPU.BackgroundImage = My.Resources.Icona_SchedaVideo_Effeto_Musica
                F_HubPC_Home.Btn_Hub_SyncMode.BackgroundImage = My.Resources.Icona_HUB_1_1_RGB_Colore_Musica
                F_HubPC_Home.Btn_F_HubPC_CasseAudio.BackgroundImage = My.Resources.IconaCasaAudio_RGB_Colore_Musica
                F_HubPC_Home.Btn_F_HubPC_SLED.BackgroundImage = My.Resources.Icona_Strisca__RGB_Colore_Musica

                'RGB HuB PC
                F_HubPC_HUB.IconaHUB_Color.BackgroundImage = My.Resources.Icona_HUB_1_1_RGB_Colore_Musica
                F_HubPC_HUB.Btn_Fan_Info.BackgroundImage = My.Resources.IconaFan_RGB_Colore_Musica_2_0
                F_HubPC_HUB.Btn_Casse_Info.BackgroundImage = My.Resources.IconaCasaAudio_RGB_Colore_Musica
                F_HubPC_HUB.Btn_Dissipatore_Info.BackgroundImage = My.Resources.Dissipatore240mm_Colore_Musica
                F_HubPC_HUB.Btn_GPU_Info.BackgroundImage = My.Resources.Icona_SchedaVideo_Effeto_Musica
                F_HubPC_HUB.Btn_StriscaLED_Info.BackgroundImage = My.Resources.Icona_Strisca__RGB_Colore_Musica

                BtnAN_Musica.BackgroundImage = My.Resources.BtnLED_MusicaON
            End If
            'Stato Btn GUI_Fan / BtnRGB Temperatura
            If F_Avvio.DatiRX_5(X) = Animazione_RGB_Tepmeratura Then

                If F_Avvio.DatiRX_7(0) = 0 Then
                    F_HubPC_HUB.LaColore.Text = "Temperatura"
                    F_HubPC_HUB.LaColore.ForeColor = Color.White
                End If

                Icona_Fan_All_RGB_Mod()
                RGB_Aniamtion_Img()

                'RGB HuB Home PC
                'F_HubPC_Home.Btn_F_HubPC_Ventole.BackgroundImage = My.Resources.IconaFan_RGB_Colore_Transizione
                'F_HubPC_Home.Btn_F_HubPC_Dissipatore.BackgroundImage = My.Resources.Dissipatore240mm_Colore_Musica
                'F_HubPC_Home.Btn_F_HubPC_GPU.BackgroundImage = My.Resources.Icona_SchedaVideo_Effeto_Musica
                'F_HubPC_Home.Btn_Hub_SyncMode.BackgroundImage = My.Resources.Icona_HUB_1_1_RGB_Colore_Musica
                'F_HubPC_Home.Btn_F_HubPC_CasseAudio.BackgroundImage = My.Resources.IconaCasaAudio_RGB_Colore_Musica
                'F_HubPC_Home.Btn_F_HubPC_SLED.BackgroundImage = My.Resources.Icona_Strisca__RGB_Colore_Musica

                'RGB HuB PC
                'F_HubPC_HUB.IconaHUB_Color.BackgroundImage = My.Resources.Icona_HUB_1_1_RGB_Colore_Musica
                'F_HubPC_HUB.Btn_Fan_Info.BackgroundImage = My.Resources.IconaFan_RGB_Colore_Transizione
                'F_HubPC_HUB.Btn_Casse_Info.BackgroundImage = My.Resources.IconaCasaAudio_RGB_Colore_Musica
                'F_HubPC_HUB.Btn_Dissipatore_Info.BackgroundImage = My.Resources.Dissipatore240mm_Colore_Musica
                'F_HubPC_HUB.Btn_GPU_Info.BackgroundImage = My.Resources.Icona_SchedaVideo_Effeto_Musica
                'F_HubPC_HUB.Btn_StriscaLED_Info.BackgroundImage = My.Resources.Icona_Strisca__RGB_Colore_Musica

                BtnAN_Tepmeratura.BackgroundImage = My.Resources.BtnLED_TemperaturaON
            End If



            'Stato Btn GUI_Fan / BtnRGB MIX Halloween
            If F_Avvio.DatiRX_5(X) = Animazione_RGB_Mix Then

                If F_Avvio.DatiRX_7(0) = 0 Then
                    F_HubPC_HUB.LaColore.Text = "Halloween"
                    F_HubPC_HUB.LaColore.ForeColor = Color.White
                End If

                Icona_Fan_All_RGB_Mod()
                'RGB_Aniamtion_Img()
                Btn_RGB_IMG_GUI()

                'RGB HuB Home PC
                'F_HubPC_Home.Btn_F_HubPC_Ventole.BackgroundImage = My.Resources.IconaFan_RGB_Colore_Transizione
                'F_HubPC_Home.Btn_F_HubPC_Dissipatore.BackgroundImage = My.Resources.Dissipatore240mm_Colore_Musica
                'F_HubPC_Home.Btn_F_HubPC_GPU.BackgroundImage = My.Resources.Icona_SchedaVideo_Effeto_Musica
                'F_HubPC_Home.Btn_Hub_SyncMode.BackgroundImage = My.Resources.Icona_HUB_1_1_RGB_Colore_Musica
                'F_HubPC_Home.Btn_F_HubPC_CasseAudio.BackgroundImage = My.Resources.IconaCasaAudio_RGB_Colore_Musica
                'F_HubPC_Home.Btn_F_HubPC_SLED.BackgroundImage = My.Resources.Icona_Strisca__RGB_Colore_Musica

                'RGB HuB PC
                'F_HubPC_HUB.IconaHUB_Color.BackgroundImage = My.Resources.Icona_HUB_1_1_RGB_Colore_Musica
                'F_HubPC_HUB.Btn_Fan_Info.BackgroundImage = My.Resources.IconaFan_RGB_Colore_Transizione
                'F_HubPC_HUB.Btn_Casse_Info.BackgroundImage = My.Resources.IconaCasaAudio_RGB_Colore_Musica
                'F_HubPC_HUB.Btn_Dissipatore_Info.BackgroundImage = My.Resources.Dissipatore240mm_Colore_Musica
                'F_HubPC_HUB.Btn_GPU_Info.BackgroundImage = My.Resources.Icona_SchedaVideo_Effeto_Musica
                'F_HubPC_HUB.Btn_StriscaLED_Info.BackgroundImage = My.Resources.Icona_Strisca__RGB_Colore_Musica

                F_HubPC_Home.Btn_F_HubPC_Dissipatore.BackColor = Color.DarkRed
                F_HubPC_Home.Btn_F_HubPC_Ventole.BackColor = Color.DarkRed
                F_HubPC_Home.Btn_F_HubPC_CasseAudio.BackColor = Color.DarkRed
                F_HubPC_Home.Btn_F_HubPC_GPU.BackColor = Color.DarkRed
                F_HubPC_Home.Btn_Hub_SyncMode.BackColor = Color.DarkRed
                F_HubPC_Home.Btn_F_HubPC_SLED.BackColor = Color.DarkRed

                F_HubPC_HUB.Btn_Fan_Info.BackColor = Color.DarkRed
                F_HubPC_HUB.Btn_GPU_Info.BackColor = Color.DarkRed
                F_HubPC_HUB.Btn_Dissipatore_Info.BackColor = Color.DarkRed
                F_HubPC_HUB.Btn_Casse_Info.BackColor = Color.DarkRed
                F_HubPC_HUB.Btn_StriscaLED_Info.BackColor = Color.DarkRed
                F_HubPC_HUB.IconaHUB_Color.BackColor = Color.DarkRed



                If RGBAMenù = 1 Then Btn_Spento.BackgroundImage = My.Resources.BtnLED_halloween_ON
            End If

            'ColorBtn Rosso
            If F_Avvio.DatiRX_5(X) = Colore_Rosso_HSV Then

                If F_Avvio.DatiRX_7(0) = 0 Then
                    F_HubPC_HUB.LaColore.ForeColor = Color.Red
                    F_HubPC_HUB.LaColore.Text = "Rosso"
                End If
                If F_Avvio.DatiRX_7(0) >= 1 And F_Avvio.DatiRX_7(0) <= 4 Then
                    F_HubPC_Ventole.LaColore.ForeColor = Color.Red
                    F_HubPC_Ventole.LaColore.Text = "Colore          Rosso"
                End If
                If F_Avvio.DatiRX_7(0) > 4 And F_Avvio.DatiRX_7(0) < 8 Then
                    F_HubPC_Dissipatore240.LaColore.ForeColor = Color.Red
                    F_HubPC_Dissipatore240.LaColore.Text = "Rosso"
                End If
                'If F_Avvio.DatiRX_7(0) > (IndirizzoElemento_SchedaVideo - 1) And F_Avvio.DatiRX_7(0) < (IndirizzoElemento_StriscaLED + 1) Then
                If F_Avvio.DatiRX_7(0) > 7 And F_Avvio.DatiRX_7(0) < 10 Then
                        F_HubPC_GPU_SLED.LaColore.ForeColor = Color.Red
                        F_HubPC_GPU_SLED.LaColore.Text = "Rosso"
                    End If
                    If F_Avvio.DatiRX_7(0) > 9 And F_Avvio.DatiRX_7(0) < 13 Then
                        F_HubPC_CasseAudio.LaColore.ForeColor = Color.Red
                        F_HubPC_CasseAudio.LaColore.Text = "Rosso"
                    End If

                    BtnRosso.BorderStyle = BorderStyle.Fixed3D

                    Btn_RGB_IMG_GUI()
                End If
                'ColorBtn Blu
                If F_Avvio.DatiRX_5(X) = Colore_Blu_HSV Then

                If F_Avvio.DatiRX_7(0) = 0 Then
                    F_HubPC_HUB.LaColore.ForeColor = Color.Blue
                    F_HubPC_HUB.LaColore.Text = "Blu"
                End If
                If F_Avvio.DatiRX_7(0) >= 1 And F_Avvio.DatiRX_7(0) <= 4 Then
                    F_HubPC_Ventole.LaColore.ForeColor = Color.Blue
                    F_HubPC_Ventole.LaColore.Text = "Colore            Blu"
                End If
                If F_Avvio.DatiRX_7(0) > 4 And F_Avvio.DatiRX_7(0) < 8 Then
                    F_HubPC_Dissipatore240.LaColore.ForeColor = Color.Blue
                    F_HubPC_Dissipatore240.LaColore.Text = "Blu"
                End If
                'If F_Avvio.DatiRX_7(0) > (IndirizzoElemento_SchedaVideo - 1) And F_Avvio.DatiRX_7(0) < (IndirizzoElemento_StriscaLED + 1) Then
                If F_Avvio.DatiRX_7(0) > 7 And F_Avvio.DatiRX_7(0) < 10 Then
                        F_HubPC_GPU_SLED.LaColore.ForeColor = Color.Blue
                        F_HubPC_GPU_SLED.LaColore.Text = "Blu"
                    End If
                    If F_Avvio.DatiRX_7(0) > 9 And F_Avvio.DatiRX_7(0) < 13 Then
                        F_HubPC_CasseAudio.LaColore.ForeColor = Color.Blue
                        F_HubPC_CasseAudio.LaColore.Text = "Blu"
                    End If

                    BtnBlu.BorderStyle = BorderStyle.Fixed3D

                    Btn_RGB_IMG_GUI()
                End If
                'ColorBtn Giallo
                If F_Avvio.DatiRX_5(X) = Colore_Giallo_HSV Then

                If F_Avvio.DatiRX_7(0) = 0 Then
                    F_HubPC_HUB.LaColore.ForeColor = Color.Yellow
                    F_HubPC_HUB.LaColore.Text = "Giallo"
                End If
                If F_Avvio.DatiRX_7(0) >= 1 And F_Avvio.DatiRX_7(0) <= 4 Then
                    F_HubPC_Ventole.LaColore.ForeColor = Color.Yellow
                    F_HubPC_Ventole.LaColore.Text = "Colore          Giallo"
                End If
                If F_Avvio.DatiRX_7(0) > 4 And F_Avvio.DatiRX_7(0) < 8 Then
                    F_HubPC_Dissipatore240.LaColore.ForeColor = Color.Yellow
                    F_HubPC_Dissipatore240.LaColore.Text = "Giallo"
                End If
                'If F_Avvio.DatiRX_7(0) > (IndirizzoElemento_SchedaVideo - 1) And F_Avvio.DatiRX_7(0) < (IndirizzoElemento_StriscaLED + 1) Then
                If F_Avvio.DatiRX_7(0) > 7 And F_Avvio.DatiRX_7(0) < 10 Then
                        F_HubPC_GPU_SLED.LaColore.ForeColor = Color.Yellow
                        F_HubPC_GPU_SLED.LaColore.Text = "Giallo"
                    End If
                    If F_Avvio.DatiRX_7(0) > 9 And F_Avvio.DatiRX_7(0) < 13 Then
                        F_HubPC_CasseAudio.LaColore.ForeColor = Color.Yellow
                        F_HubPC_CasseAudio.LaColore.Text = "Giallo"
                    End If

                    BtnGiallo.BorderStyle = BorderStyle.Fixed3D

                    Btn_RGB_IMG_GUI()
                End If
                'ColorBtn Verde
                If F_Avvio.DatiRX_5(X) = Colore_Verde_HSV Then

                If F_Avvio.DatiRX_7(0) = 0 Then
                    F_HubPC_HUB.LaColore.ForeColor = Color.Lime
                    F_HubPC_HUB.LaColore.Text = "Verde"
                End If
                If F_Avvio.DatiRX_7(0) >= 1 And F_Avvio.DatiRX_7(0) <= 4 Then
                    F_HubPC_Ventole.LaColore.ForeColor = Color.Lime
                    F_HubPC_Ventole.LaColore.Text = "Colore          Verde"
                End If
                If F_Avvio.DatiRX_7(0) > 4 And F_Avvio.DatiRX_7(0) < 8 Then
                    F_HubPC_Dissipatore240.LaColore.ForeColor = Color.Lime
                    F_HubPC_Dissipatore240.LaColore.Text = "Verde"
                End If
                'If F_Avvio.DatiRX_7(0) > (IndirizzoElemento_SchedaVideo - 1) And F_Avvio.DatiRX_7(0) < (IndirizzoElemento_StriscaLED + 1) Then
                If F_Avvio.DatiRX_7(0) > 7 And F_Avvio.DatiRX_7(0) < 10 Then
                        F_HubPC_GPU_SLED.LaColore.ForeColor = Color.Lime
                        F_HubPC_GPU_SLED.LaColore.Text = "Verde"
                    End If
                    If F_Avvio.DatiRX_7(0) > 9 And F_Avvio.DatiRX_7(0) < 13 Then
                        F_HubPC_CasseAudio.LaColore.ForeColor = Color.Lime
                        F_HubPC_CasseAudio.LaColore.Text = "Verde"
                    End If

                    BtnVerde.BorderStyle = BorderStyle.Fixed3D

                    Btn_RGB_IMG_GUI()
                End If
                'ColorBtn Viola
                If F_Avvio.DatiRX_5(X) = Colore_Fucsioa_HSV Then

                If F_Avvio.DatiRX_7(0) = 0 Then
                    F_HubPC_HUB.LaColore.ForeColor = Color.Fuchsia
                    F_HubPC_HUB.LaColore.Text = "Viola"
                End If
                If F_Avvio.DatiRX_7(0) >= 1 And F_Avvio.DatiRX_7(0) <= 4 Then
                    F_HubPC_Ventole.LaColore.ForeColor = Color.Fuchsia
                    F_HubPC_Ventole.LaColore.Text = "Colore          Viola"
                End If
                If F_Avvio.DatiRX_7(0) > 4 And F_Avvio.DatiRX_7(0) < 8 Then
                    F_HubPC_Dissipatore240.LaColore.ForeColor = Color.Fuchsia
                    F_HubPC_Dissipatore240.LaColore.Text = "Viola"
                End If
                'If F_Avvio.DatiRX_7(0) > (IndirizzoElemento_SchedaVideo - 1) And F_Avvio.DatiRX_7(0) < (IndirizzoElemento_StriscaLED + 1) Then
                If F_Avvio.DatiRX_7(0) > 7 And F_Avvio.DatiRX_7(0) < 10 Then
                        F_HubPC_GPU_SLED.LaColore.ForeColor = Color.Fuchsia
                        F_HubPC_GPU_SLED.LaColore.Text = "Viola"
                    End If
                    If F_Avvio.DatiRX_7(0) > 9 And F_Avvio.DatiRX_7(0) < 13 Then
                    F_HubPC_CasseAudio.LaColore.ForeColor = Color.Fuchsia
                    F_HubPC_CasseAudio.LaColore.Text = "Viola"
                End If

                BtnFucsia.BorderStyle = BorderStyle.Fixed3D

                Btn_RGB_IMG_GUI()
            End If
            'ColorBtn Arancio
            If F_Avvio.DatiRX_5(X) = Colore_Arancione_HSV Then

                If F_Avvio.DatiRX_7(0) = 0 Then
                    F_HubPC_HUB.LaColore.ForeColor = Color.DarkOrange
                    F_HubPC_HUB.LaColore.Text = "Arancione"
                End If
                If F_Avvio.DatiRX_7(0) >= 1 And F_Avvio.DatiRX_7(0) <= 4 Then
                    F_HubPC_Ventole.LaColore.ForeColor = Color.DarkOrange
                    F_HubPC_Ventole.LaColore.Text = "Colore        Arancione"
                End If
                If F_Avvio.DatiRX_7(0) > 4 And F_Avvio.DatiRX_7(0) < 8 Then
                    F_HubPC_Dissipatore240.LaColore.ForeColor = Color.DarkOrange
                    F_HubPC_Dissipatore240.LaColore.Text = "Arancione"
                End If
                ' If F_Avvio.DatiRX_7(0) > (IndirizzoElemento_SchedaVideo - 1) And F_Avvio.DatiRX_7(0) < (IndirizzoElemento_StriscaLED + 1) Then
                If F_Avvio.DatiRX_7(0) > 7 And F_Avvio.DatiRX_7(0) < 10 Then
                        F_HubPC_GPU_SLED.LaColore.ForeColor = Color.DarkOrange
                        F_HubPC_GPU_SLED.LaColore.Text = "Arancione"
                    End If
                    If F_Avvio.DatiRX_7(0) > 9 And F_Avvio.DatiRX_7(0) < 13 Then
                    F_HubPC_CasseAudio.LaColore.ForeColor = Color.DarkOrange
                    F_HubPC_CasseAudio.LaColore.Text = "Arancione"
                End If

                BtnArancio.BorderStyle = BorderStyle.Fixed3D

                Btn_RGB_IMG_GUI()
            End If
            'ColorBtn Azzurro
            If F_Avvio.DatiRX_5(X) = Colore_Celeste_HSV Then

                If F_Avvio.DatiRX_7(0) = 0 Then
                    F_HubPC_HUB.LaColore.ForeColor = Color.Cyan
                    F_HubPC_HUB.LaColore.Text = "Azzurro"
                End If
                If F_Avvio.DatiRX_7(0) >= 1 And F_Avvio.DatiRX_7(0) <= 4 Then
                    F_HubPC_Ventole.LaColore.ForeColor = Color.Cyan
                    F_HubPC_Ventole.LaColore.Text = "Colore         Azzurro"
                End If
                If F_Avvio.DatiRX_7(0) > 4 And F_Avvio.DatiRX_7(0) < 8 Then
                    F_HubPC_Dissipatore240.LaColore.ForeColor = Color.Cyan
                    F_HubPC_Dissipatore240.LaColore.Text = "Azzurro"
                End If
                'If F_Avvio.DatiRX_7(0) > (IndirizzoElemento_SchedaVideo - 1) And F_Avvio.DatiRX_7(0) < (IndirizzoElemento_StriscaLED + 1) Then
                If F_Avvio.DatiRX_7(0) > 7 And F_Avvio.DatiRX_7(0) < 10 Then
                        F_HubPC_GPU_SLED.LaColore.ForeColor = Color.Cyan
                        F_HubPC_GPU_SLED.LaColore.Text = "Azzurro"
                    End If
                    If F_Avvio.DatiRX_7(0) > 9 And F_Avvio.DatiRX_7(0) < 13 Then
                    F_HubPC_CasseAudio.LaColore.ForeColor = Color.Cyan
                    F_HubPC_CasseAudio.LaColore.Text = "Azzurro"
                End If


                BtnAzzurro.BorderStyle = BorderStyle.Fixed3D

                Btn_RGB_IMG_GUI()
            End If

        End If
    End Sub
    '// Btn GUI_Fan tutti Abbilitati
    Public Sub Btn_Fan_GUI()
        BtnAN_Transiszione.BackgroundImage = My.Resources.BtnLED_Transizione

        If RGBAMenù = 0 Then Btn_Spento.BackgroundImage = My.Resources.BtnLED_Spento
        If RGBAMenù = 1 Then Btn_Spento.BackgroundImage = My.Resources.BtnLED_halloween_off

        BtnAN_Rainbow.BackgroundImage = My.Resources.BtnLED_RainBow
        BtnAN_Musica.BackgroundImage = My.Resources.BtnLED_Musica
        BtnAN_Discontinuo.BackgroundImage = My.Resources.BtnLED_Discontinuo
        BtnAN_Tepmeratura.BackgroundImage = My.Resources.BtnLED_Temperatura
    End Sub
    '//Btn GUI_Fan RGB Menù tutti Abbilitati
    Public Sub Btn_RGB_IMG_GUI()
        'RGB Ventole PC
        ' F_HubPC_Ventole.IconaFanScolor.BackgroundImage = My.Resources.IconaFan_RGB_Colore_HSV_RGB_2_0
        F_HubPC_Home.Btn_F_HubPC_Ventole.BackgroundImage = My.Resources.IconaFan_RGB_Colore_HSV_RGB_2_0

        'RGB Dissipatore Liquido 240mm
        F_HubPC_Home.Btn_F_HubPC_Dissipatore.BackgroundImage = My.Resources.Dissipatore240mm_HSV_v1_1
        'F_HubPC_Dissipatore240.IconaStatoFan_Menù_3.BackgroundImage = My.Resources.Icona_DeepCool_HSV_RGB_v1_3

        F_HubPC_Home.Btn_F_HubPC_GPU.BackgroundImage = My.Resources.Icona_SchedaVideo_RGB_Colore_HSV_RGB_2_1
        If H_SyncMode <= Hue_Max Then F_HubPC_Home.Btn_Hub_SyncMode.BackgroundImage = My.Resources.Icona_HUB_1_1

        'RGB Casse Audio
        F_HubPC_Home.Btn_F_HubPC_CasseAudio.BackgroundImage = My.Resources.IconaCasaAudio_RGB_Colore_HSV_RGB
        'F_HubPC_CasseAudio.Icona_CassaAudio_S.BackgroundImage = My.Resources.IconaCasaAudio_RGB_Colore_HSV_RGB
        'F_HubPC_CasseAudio.Icona_CassaAudio_D.BackgroundImage = My.Resources.IconaCasaAudio_RGB_Colore_HSV_RGB
        'F_HubPC_CasseAudio.Icona_StripLED.BackgroundImage = My.Resources.Icona_Strisca__RGB_Colore_HSV_RGB_2_2_2

        '
        F_HubPC_Home.Btn_F_HubPC_SLED.BackgroundImage = My.Resources.Icona_Strisca__RGB_Colore_HSV_RGB_2_2_2


        'RGB HuB PC
        F_HubPC_HUB.IconaHUB_Color.BackgroundImage = My.Resources.Icona_HUB_1_1
        F_HubPC_HUB.Btn_Fan_Info.BackgroundImage = My.Resources.IconaFan_RGB_Colore_HSV_RGB_2_0
        F_HubPC_HUB.Btn_Casse_Info.BackgroundImage = My.Resources.IconaCasaAudio_RGB_Colore_HSV_RGB
        F_HubPC_HUB.Btn_Dissipatore_Info.BackgroundImage = My.Resources.Dissipatore240mm_HSV_v1_1
        F_HubPC_HUB.Btn_GPU_Info.BackgroundImage = My.Resources.Icona_SchedaVideo_RGB_Colore_HSV_RGB_2_1
        F_HubPC_HUB.Btn_StriscaLED_Info.BackgroundImage = My.Resources.Icona_Strisca__RGB_Colore_HSV_RGB_2_2_2

        If F_Avvio.DatiRX_7(0) = 0 Then
            'F_HubPC_Ventole.IconaFanAll.BackgroundImage = My.Resources.IconaFan_RGB_Colore_HSV_RGB_2_0
        End If
    End Sub
    '//Btn GUI_Fan_Color Menù tutti Abbilitati 
    Public Sub Btn_Color_Fan_GUI()
        BtnBianco.BorderStyle = BorderStyle.None
        BtnBlu.BorderStyle = BorderStyle.None
        BtnVerde.BorderStyle = BorderStyle.None
        BtnArancio.BorderStyle = BorderStyle.None
        BtnRosso.BorderStyle = BorderStyle.None
        BtnFucsia.BorderStyle = BorderStyle.None
        BtnGiallo.BorderStyle = BorderStyle.None
        BtnAzzurro.BorderStyle = BorderStyle.None
    End Sub

    Public Sub RGB_Aniamtion_Img()
        F_HubPC_Ventole.IconaFanScolor.BackColor = Color.FromArgb(7, 4, 31)
        F_HubPC_Ventole.LaColore.BackColor = Color.FromArgb(7, 4, 31)

        F_HubPC_Home.Btn_F_HubPC_Dissipatore.BackColor = Color.FromArgb(7, 4, 31)
        F_HubPC_Home.Btn_F_HubPC_Ventole.BackColor = Color.FromArgb(7, 4, 31)
        F_HubPC_Home.Btn_F_HubPC_CasseAudio.BackColor = Color.FromArgb(7, 4, 31)
        F_HubPC_Home.Btn_F_HubPC_GPU.BackColor = Color.FromArgb(7, 4, 31)
        F_HubPC_Home.Btn_Hub_SyncMode.BackColor = Color.FromArgb(7, 4, 31)
        F_HubPC_Home.Btn_F_HubPC_SLED.BackColor = Color.FromArgb(7, 4, 31)

        F_HubPC_HUB.Btn_Fan_Info.BackColor = Color.FromArgb(7, 4, 31)
        F_HubPC_HUB.Btn_GPU_Info.BackColor = Color.FromArgb(7, 4, 31)
        F_HubPC_HUB.Btn_Dissipatore_Info.BackColor = Color.FromArgb(7, 4, 31)
        F_HubPC_HUB.Btn_Casse_Info.BackColor = Color.FromArgb(7, 4, 31)
        F_HubPC_HUB.Btn_StriscaLED_Info.BackColor = Color.FromArgb(7, 4, 31)
        F_HubPC_HUB.IconaHUB_Color.BackColor = Color.FromArgb(7, 4, 31)

    End Sub

    Public Sub Luminosità_Reset()
        If F_Avvio.DatiRX_4(0) < 13 Then
            F_Avvio.Data2 = 255 / 2
            TrackBarLuminosità.Value = 100 / 2
        End If

        If F_Avvio.DatiRX_6(0) < 254 Then
            F_Avvio.Data4 = 255
        End If
    End Sub

    Public Sub Icona_Fan_All_RGB_Mod()
        If F_Avvio.DatiRX_7(0) = 0 Then
            'F_HubPC_Ventole.IconaFanAll.BackgroundImage = F_HubPC_Ventole.IconaFanScolor.BackgroundImage
        End If
    End Sub


    'Converte il codice colore in Testo Colore
    Public TextColor As String
    Public Sub ColorTextSet_Avvio(C As Integer)
        If F_Avvio.DatiRX_4(C) <> "0" And F_Avvio.DatiRX_6(C) <> "0" Then
            Select Case F_Avvio.DatiRX_5(C)
                Case = Colore_Rosso_HSV
                    TextColor = "Rosso"
                Case = Colore_Blu_HSV
                    TextColor = "Blu"
                Case = Colore_Verde_HSV
                    TextColor = "Verde"
                Case = Colore_Giallo_HSV
                    TextColor = "Giallo"
                Case = Colore_Fucsioa_HSV
                    TextColor = "Viola"
                Case = Colore_Arancione_HSV
                    TextColor = "Arancione"
                Case = Colore_Celeste_HSV
                    TextColor = "Celeste"
            End Select
        ElseIf F_Avvio.DatiRX_4(C) = "0" Then
            TextColor = "Spento"
        ElseIf F_Avvio.DatiRX_6(C) = "0" Then
            TextColor = "Bianco"
        End If
    End Sub



    'Funzione map dati
    Public Function map(ByVal x As Long, ByVal in_min As Long, ByVal in_max As Long, ByVal out_min As Long, ByVal out_max As Long) As Long
        Return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min
    End Function


    'Converte i dati ricevuti in formato HSV in RGB vine utilizato per tutte le icone selezionate
    Public H As Integer = 0
    Public S As Integer = 0
    Public V As Integer = 0
    Public R As Integer
    Public G As Integer
    Public B As Integer
    Public Sub HSV_to_RGB()
        'HSV to RGB
        Dim MinVal As Byte
        Dim MaxVal As Byte
        Dim Chroma As Byte
        Dim TempH As Single

        If V = 0 Then
            R = 0
            G = 0
            B = 0
        Else
            If S = 0 Then
                R = V
                G = V
                B = V
            Else
                MaxVal = V
                Chroma = S / 255 * MaxVal
                MinVal = MaxVal - Chroma
                Select Case H
                    Case Is >= 340
                        TempH = (H - 340) / 86
                        If TempH < 1 Then
                            B = MaxVal
                            R = MaxVal * TempH
                        Else
                            R = MaxVal
                            B = MaxVal * (2 - TempH)
                        End If
                        G = 0
                    Case Is >= 170
                        TempH = (H - 170) / 86
                        If TempH < 1 Then
                            G = MaxVal
                            B = MaxVal * TempH
                        Else
                            B = MaxVal
                            G = MaxVal * (2 - TempH)
                        End If
                        R = 0
                    Case Else
                        TempH = H / 86
                        If TempH < 1 Then
                            R = MaxVal
                            G = MaxVal * TempH
                        Else
                            G = MaxVal
                            R = MaxVal * (2 - TempH)
                        End If
                        B = 0
                End Select
                R = R / MaxVal * (MaxVal - MinVal) + MinVal
                G = G / MaxVal * (MaxVal - MinVal) + MinVal
                B = B / MaxVal * (MaxVal - MinVal) + MinVal
            End If

        End If


        If F_Avvio.DatiRX_7(0) <> 0 Then

            Select Case F_Avvio.Data1
                Case = 0
                    R_SyncMode = R
                    G_SyncMode = G
                    B_SyncMode = B

                Case = 1
                    R_Fan1 = R
                    G_Fan1 = G
                    B_Fan1 = B
                    'Btn_F_HubPC_Ventole.BackColor = Color.FromArgb(Colore_Salvati_Rosso(n), Colore_Salvati_Verde(n), Colore_Salvati_Blu(n))
                Case = 2
                    R_Fan2 = R
                    G_Fan2 = G
                    B_Fan2 = B
                        'Btn_F_HubPC_Ventole.BackColor = Color.FromArgb(Colore_Salvati_Rosso(n), Colore_Salvati_Verde(n), Colore_Salvati_Blu(n))
                Case = 3
                    R_Fan3 = R
                    G_Fan3 = G
                    B_Fan3 = B
                        'Btn_F_HubPC_Ventole.BackColor = Color.FromArgb(Colore_Salvati_Rosso(n), Colore_Salvati_Verde(n), Colore_Salvati_Blu(n))
                Case = 4
                    R_Fan4 = R
                    G_Fan4 = G
                    B_Fan4 = B
                        'Btn_F_HubPC_Ventole.BackColor = Color.FromArgb(Colore_Salvati_Rosso(n), Colore_Salvati_Verde(n), Colore_Salvati_Blu(n))


                Case = 5
                    R_Fan_CPU_OP_01 = R
                    G_Fan_CPU_OP_01 = G
                    B_Fan_CPU_OP_01 = B
                    'Btn_F_HubPC_Dissipatore.BackColor = Color.FromArgb(Colore_Salvati_Rosso(n), Colore_Salvati_Verde(n), Colore_Salvati_Blu(n))
                        '        F_HubPC_Dissipatore240.Btn_FanCPU_LED01.BackColor = Color.FromArgb(R, G, B)
                        '        'F_HubPC_Dissipatore240.IconaStatoFan_Menù_3.BackColor = Color.FromArgb(R, G, B)
                Case = 6
                    R_Fan_CPU_OP_02 = R
                    G_Fan_CPU_OP_02 = G
                    B_Fan_CPU_OP_02 = B
                        'Btn_F_HubPC_Dissipatore.BackColor = Color.FromArgb(Colore_Salvati_Rosso(n), Colore_Salvati_Verde(n), Colore_Salvati_Blu(n))
                        '        F_HubPC_Dissipatore240.Btn_FanCPU_LED02.BackColor = Color.FromArgb(R, G, B)
                        '        'F_HubPC_Dissipatore240.IconaStatoFan_Menù_3.BackColor = Color.FromArgb(R, G, B)
                Case = 7
                    R_CPU_OP = R
                    G_CPU_OP = G
                    B_CPU_OP = B
                        ' Btn_F_HubPC_Dissipatore.BackColor = Color.FromArgb(Colore_Salvati_Rosso(n), Colore_Salvati_Verde(n), Colore_Salvati_Blu(n))
                        '        F_HubPC_Dissipatore240.Btn_PompCPU_LED.BackColor = Color.FromArgb(R, G, B)
                        '        'F_HubPC_Dissipatore240.IconaStatoFan_Menù_3.BackColor = Color.FromArgb(R, G, B)


                Case = IndirizzoElemento_SchedaVideo
                    R_GPU = R
                    G_GPU = G
                    B_GPU = B
                    'Btn_F_HubPC_GPU.BackColor = Color.FromArgb(Colore_Salvati_Rosso(n), Colore_Salvati_Verde(n), Colore_Salvati_Blu(n))
                       ' F_HubPC_GPU_SLED.IconaStatoFan_Menù_2.BackColor = Color.FromArgb(Colore_Salvati_Rosso(n), Colore_Salvati_Verde(n), Colore_Salvati_Blu(n))
                Case = IndirizzoElemento_StriscaLED
                    R_SLED = R
                    G_SLED = G
                    B_SLED = B
                    'Btn_F_HubPC_SLED.BackColor = Color.FromArgb(Colore_Salvati_Rosso(n), Colore_Salvati_Verde(n), Colore_Salvati_Blu(n))
                        'F_HubPC_GPU_SLED.IconaStatoFan_Menù_2.BackColor = Color.FromArgb(Colore_Salvati_Rosso(n), Colore_Salvati_Verde(n), Colore_Salvati_Blu(n))


                Case = 10
                    R_Cassa_Audio_S = R
                    G_Cassa_Audio_S = G
                    B_Cassa_Audio_S = B
                    'Btn_F_HubPC_CasseAudio.BackColor = Color.FromArgb(Colore_Salvati_Rosso(n), Colore_Salvati_Verde(n), Colore_Salvati_Blu(n))
                        '        F_HubPC_CasseAudio.Btn_CassaAudio_S.BackColor = Color.FromArgb(R, G, B)
                        '       ' F_HubPC_CasseAudio.Icona_CassaAudio_S.BackColor = Color.FromArgb(R, G, B)
                Case = 11
                    R_Cassa_Audio_D = R
                    G_Cassa_Audio_D = G
                    B_Cassa_Audio_D = B
                        'Btn_F_HubPC_CasseAudio.BackColor = Color.FromArgb(Colore_Salvati_Rosso(n), Colore_Salvati_Verde(n), Colore_Salvati_Blu(n))
                        '        F_HubPC_CasseAudio.Btn_CassaAudio_D.BackColor = Color.FromArgb(R, G, B)
                        '        F_HubPC_CasseAudio.Icona_CassaAudio_D.BackColor = Color.FromArgb(R, G, B)
                Case = 12
                    R_Strip_LED = R
                    G_Strip_LED = G
                    B_Strip_LED = B
                    'Btn_F_HubPC_CasseAudio.BackColor = Color.FromArgb(Colore_Salvati_Rosso(n), Colore_Salvati_Verde(n), Colore_Salvati_Blu(n))
                    '        F_HubPC_CasseAudio.Btn_StripLED.BackColor = Color.FromArgb(R, G, B)
                    '        'F_HubPC_CasseAudio.Icona_StripLED.BackColor = Color.FromArgb(R, G, B)
            End Select
        End If


        'Dim MinVal As Byte
        'Dim MaxVal As Byte
        'Dim Chroma As Byte
        'Dim TempH As Single

        'If V = 0 Then
        '    R = 0
        '    G = 0
        '    B = 0
        'Else
        '    If S = 0 Then
        '        R = V
        '        G = V
        '        B = V
        '    Else
        '        MaxVal = V
        '        Chroma = S / 255 * MaxVal
        '        MinVal = MaxVal - Chroma
        '        Select Case H
        '            Case Is >= 170
        '                TempH = (H - 170) / 43
        '                If TempH < 1 Then
        '                    B = MaxVal
        '                    R = MaxVal * TempH
        '                Else
        '                    R = MaxVal
        '                    B = MaxVal * (2 - TempH)
        '                End If
        '                G = 0
        '            Case Is >= 85
        '                TempH = (H - 85) / 43
        '                If TempH < 1 Then
        '                    G = MaxVal
        '                    B = MaxVal * TempH
        '                Else
        '                    B = MaxVal
        '                    G = MaxVal * (2 - TempH)
        '                End If
        '                R = 0
        '            Case Else
        '                TempH = H / 43
        '                If TempH < 1 Then
        '                    R = MaxVal
        '                    G = MaxVal * TempH
        '                Else
        '                    G = MaxVal
        '                    R = MaxVal * (2 - TempH)
        '                End If
        '                B = 0
        '        End Select
        '        R = R / MaxVal * (MaxVal - MinVal) + MinVal
        '        G = G / MaxVal * (MaxVal - MinVal) + MinVal
        '        B = B / MaxVal * (MaxVal - MinVal) + MinVal
        '    End If

        'End If
    End Sub

    'Converte i dati ricevuti in formato HSV in RGB vine utilizato per il caricamento del colore all'avvio
    Public Text_Color_SyncMode As String
    Public H_SyncMode As Integer = 0
    Public S_SyncMode As Integer = 0
    Public V_SyncMode As Integer = 0
    Public R_SyncMode As Integer
    Public G_SyncMode As Integer
    Public B_SyncMode As Integer


    'Converte i dati ricevuti in formato HSV in RGB vine utilizato per il caricamento del colore all'avvio
    Public Text_Color_Fan1 As String
    Public H_Fan1 As Integer = 0
    Public S_Fan1 As Integer = 0
    Public V_Fan1 As Integer = 0
    Public R_Fan1 As Integer
    Public G_Fan1 As Integer
    Public B_Fan1 As Integer

    Public Text_Color_Fan2 As String
    Public H_Fan2 As Integer = 0
    Public S_Fan2 As Integer = 0
    Public V_Fan2 As Integer = 0
    Public R_Fan2 As Integer
    Public G_Fan2 As Integer
    Public B_Fan2 As Integer

    Public Text_Color_Fan3 As String
    Public H_Fan3 As Integer = 0
    Public S_Fan3 As Integer = 0
    Public V_Fan3 As Integer = 0
    Public R_Fan3 As Integer
    Public G_Fan3 As Integer
    Public B_Fan3 As Integer

    Public Text_Color_Fan4 As String
    Public H_Fan4 As Integer = 0
    Public S_Fan4 As Integer = 0
    Public V_Fan4 As Integer = 0
    Public R_Fan4 As Integer
    Public G_Fan4 As Integer
    Public B_Fan4 As Integer



    '
    Public Text_Color_GPU As String
    Public H_GPU As Integer = 0
    Public S_GPU As Integer = 0
    Public V_GPU As Integer = 0
    Public R_GPU As Integer
    Public G_GPU As Integer
    Public B_GPU As Integer

    Public Text_Color_SLED As String
    Public H_SLED As Integer = 0
    Public S_SLED As Integer = 0
    Public V_SLED As Integer = 0
    Public R_SLED As Integer
    Public G_SLED As Integer
    Public B_SLED As Integer



    '
    Public Text_Color_CPU_OP As String
    Public H_CPU_OP As Integer = 0
    Public S_CPU_OP As Integer = 0
    Public V_CPU_OP As Integer = 0
    Public R_CPU_OP As Integer
    Public G_CPU_OP As Integer
    Public B_CPU_OP As Integer

    Public Text_Color_Fan_CPU_OP_01 As String
    Public H_Fan_CPU_OP_01 As Integer = 0
    Public S_Fan_CPU_OP_01 As Integer = 0
    Public V_Fan_CPU_OP_01 As Integer = 0
    Public R_Fan_CPU_OP_01 As Integer
    Public G_Fan_CPU_OP_01 As Integer
    Public B_Fan_CPU_OP_01 As Integer

    Public Text_Color_Fan_CPU_OP_02 As String
    Public H_Fan_CPU_OP_02 As Integer = 0
    Public S_Fan_CPU_OP_02 As Integer = 0
    Public V_Fan_CPU_OP_02 As Integer = 0
    Public R_Fan_CPU_OP_02 As Integer
    Public G_Fan_CPU_OP_02 As Integer
    Public B_Fan_CPU_OP_02 As Integer



    Public Text_Color_Cassa_Audio_S As String
    Public H_Cassa_Audio_S As Integer = 0
    Public S_Cassa_Audio_S As Integer = 0
    Public V_Cassa_Audio_S As Integer = 0
    Public R_Cassa_Audio_S As Integer
    Public G_Cassa_Audio_S As Integer
    Public B_Cassa_Audio_S As Integer

    Public Text_Color_Cassa_Audio_D As String
    Public H_Cassa_Audio_D As Integer = 0
    Public S_Cassa_Audio_D As Integer = 0
    Public V_Cassa_Audio_D As Integer = 0
    Public R_Cassa_Audio_D As Integer
    Public G_Cassa_Audio_D As Integer
    Public B_Cassa_Audio_D As Integer

    Public Text_Color_Cassa_Strip_LED As String
    Public H_Strip_LED As Integer = 0
    Public S_Strip_LED As Integer = 0
    Public V_Strip_LED As Integer = 0
    Public R_Strip_LED As Integer
    Public G_Strip_LED As Integer
    Public B_Strip_LED As Integer




    '
    Public H_Crica As Integer = 0
    Public S_Crica As Integer = 0
    Public V_Crica As Integer = 0
    Public R_Crica As Integer
    Public G_Crica As Integer
    Public B_Crica As Integer
    Public Sub HSV_to_RGB_Carica_Avvio()
        'HSV to RGB
        Dim MinVal As Byte
        Dim MaxVal As Byte
        Dim Chroma As Byte
        Dim TempH As Single

        If V_Crica = 0 Then
            R_Crica = 0
            G_Crica = 0
            B_Crica = 0
        Else
            If S_Crica = 0 Then
                R_Crica = V_Crica
                G_Crica = V_Crica
                B_Crica = V_Crica
            Else
                MaxVal = V_Crica
                Chroma = S_Crica / 255 * MaxVal
                MinVal = MaxVal - Chroma
                Select Case H_Crica
                    Case Is >= 340
                        TempH = (H_Crica - 340) / 86
                        If TempH < 1 Then
                            B_Crica = MaxVal
                            R_Crica = MaxVal * TempH
                        Else
                            R_Crica = MaxVal
                            B_Crica = MaxVal * (2 - TempH)
                        End If
                        G_Crica = 0
                    Case Is >= 170
                        TempH = (H_Crica - 170) / 86
                        If TempH < 1 Then
                            G_Crica = MaxVal
                            B_Crica = MaxVal * TempH
                        Else
                            B_Crica = MaxVal
                            G_Crica = MaxVal * (2 - TempH)
                        End If
                        R_Crica = 0
                    Case Else
                        TempH = H_Crica / 86
                        If TempH < 1 Then
                            R_Crica = MaxVal
                            G_Crica = MaxVal * TempH
                        Else
                            G_Crica = MaxVal
                            R_Crica = MaxVal * (2 - TempH)
                        End If
                        B_Crica = 0
                End Select
                R_Crica = R_Crica / MaxVal * (MaxVal - MinVal) + MinVal
                G_Crica = G_Crica / MaxVal * (MaxVal - MinVal) + MinVal
                B_Crica = B_Crica / MaxVal * (MaxVal - MinVal) + MinVal
            End If

        End If
    End Sub




    'Cambia colore del testo che indica il dispositivo selezionato

    Public Mod_Color_Sync As String = "Colore attuale [Mod Sync]"
    Public Mod_Color_Manual As String = "Colore attuale [Mod Man...]"
    Public Sub HubControlManual()
        SelectDispositivoDefault()
        Select Case F_Avvio.DatiRX_7(0)


            'Imposta l'interfaccia In Sync Mode Controllo uniforme
            Case = 0
                F_HubPC_Home.La_SyncMode.ForeColor = Color.White


                 'Imposta l'interfaccia In Manual Mode Controllo della Ventola 1
            Case = 1
                F_HubPC_Ventole.TitoloFan.Text = "Ventola 1"
                F_HubPC_Ventole.LaFAN_1.ForeColor = Color.White
                F_HubPC_Home.La_Ventole.ForeColor = Color.White


                'Imposta l'interfaccia In Manual Mode Controllo della Ventola 2
            Case = 2
                F_HubPC_Ventole.TitoloFan.Text = "Ventola 2"
                F_HubPC_Ventole.LaFAN_2.ForeColor = Color.White
                F_HubPC_Home.La_Ventole.ForeColor = Color.White


                'Imposta l'interfaccia In Manual Mode Controllo della Ventola 3
            Case = 3
                F_HubPC_Ventole.TitoloFan.Text = "Ventola 3"
                F_HubPC_Ventole.LaFAN_3.ForeColor = Color.White
                F_HubPC_Home.La_Ventole.ForeColor = Color.White


                'Imposta l'interfaccia In Manual Mode Controllo della Ventola 4
            Case = 4
                F_HubPC_Ventole.TitoloFan.Text = "Ventola 4"
                F_HubPC_Ventole.LaFAN_4.ForeColor = Color.White
                F_HubPC_Home.La_Ventole.ForeColor = Color.White


                'Imposta l'interfaccia In Manual Mode Controllo del dissipatore a liquido 240 ventola 1
            Case = 5
                F_HubPC_Dissipatore240.LaSelezione.ForeColor = Color.White
                F_HubPC_Dissipatore240.IconaStatoFan_Menù_3.BackgroundImage = My.Resources.Icona_FanPO_1_3_
                F_HubPC_Dissipatore240.LaSelezione.Text = Mod_Color_Manual + " Fan CPU 1"
                F_HubPC_Dissipatore240.Btn_FanCPU_1.ForeColor = Color.White
                F_HubPC_Home.La_Dissipatore.ForeColor = Color.White


                'Imposta l'interfaccia In Manual Mode Controllo del dissipatore a liquido 240 ventola 2
            Case = 6
                F_HubPC_Dissipatore240.LaSelezione.ForeColor = Color.White
                F_HubPC_Dissipatore240.IconaStatoFan_Menù_3.BackgroundImage = My.Resources.Icona_FanPO_1_3_
                F_HubPC_Dissipatore240.LaSelezione.Text = Mod_Color_Manual + " Fan CPU 2"
                F_HubPC_Dissipatore240.Btn_FanCPU_2.ForeColor = Color.White
                F_HubPC_Home.La_Dissipatore.ForeColor = Color.White


                'Imposta l'interfaccia In Manual Mode Controllo del dissipatore a liquido 240 CPU
            Case = 7
                F_HubPC_Dissipatore240.LaSelezione.ForeColor = Color.Red
                F_HubPC_Dissipatore240.LaSelezione.ForeColor = Color.White
                F_HubPC_Dissipatore240.IconaStatoFan_Menù_3.BackgroundImage = My.Resources.Icona_DeepCool_HSV_RGB_v1_3
                F_HubPC_Dissipatore240.LaSelezione.Text = Mod_Color_Manual + " Pompa CPU"
                F_HubPC_Dissipatore240.Btn_PompCPU.ForeColor = Color.White
                F_HubPC_Home.La_Dissipatore.ForeColor = Color.White


                'Imposta l'interfaccia In Manual Mode Controllo della GPU
            Case = IndirizzoElemento_SchedaVideo
                F_HubPC_GPU_SLED.IconaStato_Menù_2.BackgroundImage = My.Resources.Icona_SchedaVideo_RGB_Colore_HSV_RGB_21
                F_HubPC_GPU_SLED.LaSelezione.ForeColor = Color.White
                F_HubPC_GPU_SLED.LaSelezione.Text = Mod_Color_Manual + " Scheda Video"
                F_HubPC_GPU_SLED.BtnGPU_LED.ForeColor = Color.White
                F_HubPC_Home.La_GPU.ForeColor = Color.White


                'Imposta l'interfaccia In Manual Mode Controllo della Strisca a LED
            Case = IndirizzoElemento_StriscaLED
                F_HubPC_GPU_SLED.IconaStato_Menù_2.BackgroundImage = My.Resources.Icona_Strisca__RGB_Colore_HSV_RGB_2_2_2
                F_HubPC_GPU_SLED.LaSelezione.ForeColor = Color.White
                F_HubPC_GPU_SLED.LaSelezione.Text = Mod_Color_Manual + " Strisca LED"
                F_HubPC_GPU_SLED.BtnStrip_LED.ForeColor = Color.White
                F_HubPC_Home.La_SLED.ForeColor = Color.White


                'Imposta l'interfaccia In Manual Mode Controllo della cassa Audio Sinistra
            Case = 10

                F_HubPC_CasseAudio.LaSelezione.Text = Mod_Color_Manual + " Cassa Audio Sinistra"
                F_HubPC_CasseAudio.LaSelezione.ForeColor = Color.White
                F_HubPC_CasseAudio.LaCassaAudio_S.ForeColor = Color.White
                F_HubPC_Home.La_CasseAudio.ForeColor = Color.White


                'Imposta l'interfaccia In Manual Mode Controllo della cassa Audio Destra
            Case = 11
                F_HubPC_CasseAudio.LaSelezione.Text = Mod_Color_Manual + " Cassa Audio Destra"
                F_HubPC_CasseAudio.LaSelezione.ForeColor = Color.White
                F_HubPC_CasseAudio.LaCassaAudio_D.ForeColor = Color.White
                F_HubPC_Home.La_CasseAudio.ForeColor = Color.White


                'Imposta l'interfaccia In Manual Mode Controllo della Strisca a LED Audio Esterna
            Case = 12
                F_HubPC_CasseAudio.LaSelezione.Text = Mod_Color_Manual + " Strisca a LED esterna"
                F_HubPC_CasseAudio.LaSelezione.ForeColor = Color.White
                F_HubPC_CasseAudio.LaStriscaLED.ForeColor = Color.White
                F_HubPC_Home.La_CasseAudio.ForeColor = Color.White
        End Select
    End Sub

    'Setta il testo di F_HubPC_... off
    Sub SelectDispositivoDefault()
        'F_HubPC_Ventole.LaFAN_All.ForeColor = Color.FromArgb(0, 140, 149)
        F_HubPC_Ventole.LaFAN_1.ForeColor = Color.FromArgb(0, 140, 149)
        F_HubPC_Ventole.LaFAN_2.ForeColor = Color.FromArgb(0, 140, 149)
        F_HubPC_Ventole.LaFAN_3.ForeColor = Color.FromArgb(0, 140, 149)
        F_HubPC_Ventole.LaFAN_4.ForeColor = Color.FromArgb(0, 140, 149)

        F_HubPC_GPU_SLED.BtnGPU_LED.ForeColor = Color.FromArgb(0, 140, 149)
        F_HubPC_GPU_SLED.BtnStrip_LED.ForeColor = Color.FromArgb(0, 140, 149)

        F_HubPC_Dissipatore240.Btn_FanCPU_1.ForeColor = Color.FromArgb(0, 140, 149)
        F_HubPC_Dissipatore240.Btn_FanCPU_2.ForeColor = Color.FromArgb(0, 140, 149)
        F_HubPC_Dissipatore240.Btn_PompCPU.ForeColor = Color.FromArgb(0, 140, 149)

        F_HubPC_CasseAudio.LaCassaAudio_S.ForeColor = Color.FromArgb(0, 140, 149)
        F_HubPC_CasseAudio.LaCassaAudio_D.ForeColor = Color.FromArgb(0, 140, 149)
        F_HubPC_CasseAudio.LaStriscaLED.ForeColor = Color.FromArgb(0, 140, 149)

        F_HubPC_Home.La_SyncMode.ForeColor = Color.FromArgb(0, 140, 149)
        F_HubPC_Home.La_CasseAudio.ForeColor = Color.FromArgb(0, 140, 149)
        F_HubPC_Home.La_Dissipatore.ForeColor = Color.FromArgb(0, 140, 149)
        F_HubPC_Home.La_GPU.ForeColor = Color.FromArgb(0, 140, 149)
        F_HubPC_Home.La_SLED.ForeColor = Color.FromArgb(0, 140, 149)
        F_HubPC_Home.La_Ventole.ForeColor = Color.FromArgb(0, 140, 149)

    End Sub

    'Setta in bottoni Animazione off
    Public Sub BtnOFF_Animation()
        If F_Avvio.Data1 <> 0 Then
            Btn_Men_RGB_Animation.Visible = False 'Menù agguntivo Animazione LED
            Btn_Men_RGB_Animation_Click()
        End If

        BtnAN_Transiszione.Visible = False
        'F_Fan.Btn_Spento.Visible = False
        BtnAN_Rainbow.Visible = False
        BtnAN_Musica.Visible = False
        BtnAN_Discontinuo.Visible = False
        BtnAN_Tepmeratura.Visible = False
    End Sub


End Class