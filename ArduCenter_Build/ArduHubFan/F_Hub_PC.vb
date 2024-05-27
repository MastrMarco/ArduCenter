'Codice Rivisto Ver.2.1.0
Imports System.Runtime.InteropServices
Imports System.IO
Public Class F_Hub_PC

    Public ControlloVelocitaVentole As New C_Ventole_Controllo()

    Public IndirizzoTipoDispositivo As Integer = 1 'Tipo Progetto

    Public IndirizzoElemento_SchedaVideo As Integer = 8 'Scheda Video
    Public IndirizzoElemento_StriscaLED As Integer = 9  'Scheda Striscia LED Case


    'Public Luminosità_MIN As Integer = 13
    'Public Luminosità_MAX As Integer = 255


    Public FanMenù As String = "Hub PC Home"
    Public RGBAMenù As Integer = 0

    Private Sub F_Fan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SwitchPannelHUB(P_HubPC_HUB)
        FanMenù = "Hub PC"

        'Info Schermata
        F_Home.LabelFinestraID.Text = "Finestra di controllo " & FanMenù


        'Acquisisci lingua Colore
        'CambiaLinguaColore("ITA")
        'Acquisisci Dati Colore    
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
        ' SwitchPannelHUB(F_HubPC_Home)
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
        ControlloVelocitaVentole.Velocità_Elemento(TrackBarVelocità.Value * 2.55)
    End Sub
    Private Sub BtnV_min_Click(sender As Object, e As EventArgs) Handles BtnV_min.Click
        TrackBarVelocità.Value = 0
        ControlloVelocitaVentole.Velocità_Elemento(0)
    End Sub
    Private Sub BtnV_max_Click(sender As Object, e As EventArgs) Handles BtnV_max.Click
        TrackBarVelocità.Value = 100
        ControlloVelocitaVentole.Velocità_Elemento(100 * 2.55)
    End Sub

    'Luminosità
    Private Sub TrackBarLuminosità_Scroll(sender As Object, e As EventArgs) Handles TrackBarLuminosità.Scroll
        F_Avvio.ConvertiColore.Luminos_Elemento(TrackBarLuminosità.Value * 2.55)
    End Sub
    Private Sub BtnL_min_Click(sender As Object, e As EventArgs) Handles BtnL_min.Click
        TrackBarLuminosità.Value = 5
        F_Avvio.ConvertiColore.Luminos_Elemento(F_Avvio.ConvertiColore.Luminosità_MIN)
    End Sub
    Private Sub BtnL_max_Click(sender As Object, e As EventArgs) Handles BtnL_max.Click
        TrackBarLuminosità.Value = 100
        F_Avvio.ConvertiColore.Luminos_Elemento(F_Avvio.ConvertiColore.Luminosità_MAX)
    End Sub



    'Imposta il Colore selezionato e lo Memoriza
    Public Sub SetColore(Tag As String, ID_Menù As Integer)
        Dim V As Integer
        F_Avvio.ConvertiColore.ColorUP_Elemtnto(Tag, V, ID_Menù)
        If F_Avvio.DatiRX_4(0) > 13 Then
            TrackBarLuminosità.Value = F_Avvio.DatiRX_4(0) / 2.55
        End If

        'Imposta Luminosità al 50%
        If V <> 0 Then
            TrackBarLuminosità.Value = V / 2.55
        End If
    End Sub
    'Rosso
    Private Sub BtnColor1_Click(sender As Object, e As EventArgs) Handles BtnColor1.Click
        SetColore(BtnColor1.Tag, 0)
    End Sub
    'Verde
    Private Sub BtnColor2_Click(sender As Object, e As EventArgs) Handles BtnColor2.Click
        SetColore(BtnColor2.Tag, 0)
    End Sub
    'Blu
    Private Sub BtnColor3_Click(sender As Object, e As EventArgs) Handles BtnColor3.Click
        SetColore(BtnColor3.Tag, 0)
    End Sub
    'Arancione
    Private Sub BtnColor4_Click(sender As Object, e As EventArgs) Handles BtnColor4.Click
        SetColore(BtnColor4.Tag, 0)
    End Sub
    'Fucsia
    Private Sub BtnColor5_Click(sender As Object, e As EventArgs) Handles BtnColor5.Click
        SetColore(BtnColor5.Tag, 0)
    End Sub
    'Giallo
    Private Sub BtnColor6_Click(sender As Object, e As EventArgs) Handles BtnColor6.Click
        SetColore(BtnColor6.Tag, 0)
    End Sub
    'Azzurro
    Private Sub BtnColor7_Click(sender As Object, e As EventArgs) Handles BtnColor7.Click
        SetColore(BtnColor7.Tag, 0)
    End Sub
    'Bianco / Saturazione 0
    Private Sub BtnBianco_Click(sender As Object, e As EventArgs) Handles BtnColor0.Click
        SetColore(BtnColor0.Tag, 0)
    End Sub



    'Menù Btn Animazioni 0 - 1
    Public Sub Btn_Men_RGB_Animation_Click() Handles Btn_Men_RGB_Animation.Click
        If RGBAMenù = 0 Then
            RGBAMenù = 1
            Btn_Men_RGB_Animation.BackgroundImage = My.Resources.Btn_Indietro_50x50
            BtnOFF_Animation()
        ElseIf RGBAMenù = 1 Then
            RGBAMenù = 0
            Btn_Men_RGB_Animation.BackgroundImage = My.Resources.Btn_Avanti_50x50
            BtnRGB1.Visible = True
            BtnRGB2.Visible = True
            BtnRGB4.Visible = True
            BtnRGB5.Visible = True
            BtnRGB3.Visible = True
        End If

        F_Avvio.ConvertiColore.BtnColore(RGBAMenù)
        Btn_Color_ON(F_Avvio.ConvertiColore.Nome_Colore(F_Avvio.DatiRX_5(0), F_Avvio.DatiRX_6(0)))
        'LabelRGBAnimazioni.Text = RGBAMenù 'Debug Data Menù
    End Sub


    'Nero / Spento - AnimazioneRGB Mix
    Private Sub Btn_Spento_Click(sender As Object, e As EventArgs) Handles BtnRGB0.Click
        SetColore(BtnRGB0.Tag, RGBAMenù)
        'Luminosità_Reset()
    End Sub
    'Animazione RGB Trasiszione
    Private Sub BtnAN_Transiszione_Click(sender As Object, e As EventArgs) Handles BtnRGB1.Click
        If F_Avvio.DatiRX_7(0) = 0 Then
            SetColore(BtnRGB1.Tag, RGBAMenù)
            Luminosità_Reset()
        Else
            F_Avvio.FunzioneNull()
        End If

    End Sub
    'Animazione RGB RainBow
    Private Sub BtnAN_Rainbow_Click(sender As Object, e As EventArgs) Handles BtnRGB2.Click
        If F_Avvio.DatiRX_7(0) = 0 Then
            SetColore(BtnRGB2.Tag, RGBAMenù)
            Luminosità_Reset()
        Else
            F_Avvio.FunzioneNull()
        End If
    End Sub
    'Animazione RGB Temperatura
    Private Sub BtnANTepmeratura_Click(sender As Object, e As EventArgs) Handles BtnRGB3.Click
        If F_Avvio.DatiRX_7(0) = 0 Then
            SetColore(BtnRGB3.Tag, RGBAMenù)
            Luminosità_Reset()
        Else
            F_Avvio.FunzioneNull()
        End If
    End Sub
    'Animazione RGB Musica
    Private Sub BtnAN_Musica_Click(sender As Object, e As EventArgs) Handles BtnRGB4.Click
        If F_Avvio.DatiRX_7(0) = 0 Then
            'F_Avvio.Data3 = Animazione_RGB_Musica
            SetColore(BtnRGB4.Tag, RGBAMenù)
            Luminosità_Reset()
        Else
            F_Avvio.FunzioneNull()
        End If

        Dim Colore As Integer = Array.IndexOf(ColorNome, BtnRGB4.Tag)
        If BtnRGB4.Tag = ColorNome(Colore) Then
            'Luminosità_Reset()
            'My.Settings.AudioDigitalRGB = "Si"
            F_Setting_RGB_Animation_HUB.Show()
            F_Setting_RGB_Animation_HUB.TopMost = True
            F_Setting_RGB_Animation_HUB.TopMost = False
        End If
    End Sub
    'Animazione RGB Discontinuo
    Private Sub BtnANdiscontinuo_Click(sender As Object, e As EventArgs) Handles BtnRGB5.Click
        If F_Avvio.DatiRX_7(0) = 0 Then
            SetColore(BtnRGB5.Tag, RGBAMenù)
            Luminosità_Reset()
        Else
            F_Avvio.FunzioneNull()
        End If
    End Sub





    'Funzione Loop: aggiorna e inserisce i dati Modificati sia dal Utente che dai sensori
    Public AggiornaGUI As Boolean = False
    Dim EL_Selezionato As Integer
    Dim H_Stato As Integer
    Dim S_Stato As Integer
    Dim V_Stato As Integer
    Dim Ventole_Speed As Integer
    Dim SensoreTemperatura As Integer

    Dim Lingua As String
    Public Sub RX_TX()


        If AggiornaGUI = True Or F_Avvio.DatiRX_7(0) <> EL_Selezionato Or F_Avvio.DatiRX_5(0) <> H_Stato Or F_Avvio.DatiRX_6(0) <> S_Stato Or F_Avvio.DatiRX_4(0) <> V_Stato Or F_Avvio.DatiRX_8(0) <> Ventole_Speed Or SensoreTemperatura <> F_Avvio.DatiRX_1(0) Or Lingua <> My.Settings.Lingua Then

            'Nome Colore Elemento Selezionato
            P_HubPC_HUB.LaColore.Text = F_Avvio.ConvertiColore.Nome_Colore(F_Avvio.DatiRX_5(0), F_Avvio.DatiRX_6(0))

            'Modifica Lable e Immagine dell'Elemento Selezionato
            P_HubPC_HUB.Elementi_Selezionato(F_Avvio.DatiRX_7(0))

            'Conversione Colore Elemento Slezionato
            Dim R As Integer, G As Integer, B As Integer
            '                                                H                    S                    V
            F_Avvio.ConvertiColore.HSV_to_RGB(F_Avvio.DatiRX_5(0), F_Avvio.DatiRX_6(0), F_Avvio.DatiRX_4(0), R, G, B)
            'Imposta il Colore alle Barra icone Elementi
            P_HubPC_HUB.Carica_Colore_Elementi_Icone(F_Avvio.DatiRX_7(0), R, G, B)

            'Icona/e Selezionata con l'immagine Animazione A-RGB o HSV
            If F_Avvio.DatiRX_5(0) > F_Avvio.ConvertiColore.Hue_Max Then
                P_HubPC_HUB.Animazione_RGB_Icone(F_Avvio.DatiRX_7(0), P_HubPC_HUB.LaColore.Text)
            End If

            'Nome Colore Elemento Selezionato
            Btn_Color_ON(F_Avvio.ConvertiColore.Nome_Colore(F_Avvio.DatiRX_5(0), F_Avvio.DatiRX_6(0)))

            'Valore Luminosità
            P_HubPC_HUB.LaLuminosità.Text = Int(F_Avvio.DatiRX_4(0) / 2.55) & " %"
            'Luminosità Grafica
            If F_Avvio.DatiRX_4(0) <> 0 Then
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
            ElseIf F_Avvio.DatiRX_4(0) = 0 Then
                TrackBarLuminosità.Enabled = False
                BtnL_min.Enabled = False
                BtnL_max.Enabled = False
            End If
            'Aggiorna PosizioneTrackBar
            If EL_Selezionato <> F_Avvio.DatiRX_7(0) And F_Avvio.DatiRX_4(0) >= 13 Then TrackBarLuminosità.Value = F_Avvio.DatiRX_4(0) / 2.55



            'Valore Rotazione Ventole
            P_HubPC_HUB.LaVelocità.Text = Int(F_Avvio.DatiRX_8(0) / 2.55) & " %"
            'Rotazione Ventole Grafica
            If F_Avvio.DatiRX_7(0) <= 4 Then
                TrackBarVelocità.Enabled = True
                'Max
                If F_Avvio.DatiRX_8(0) = 255 Then
                    BtnV_min.Enabled = True
                    BtnV_max.Enabled = False
                End If
                'Min
                If F_Avvio.DatiRX_8(0) = 0 Then
                    BtnV_min.Enabled = False
                    BtnV_max.Enabled = True

                End If
                'Max / Min
                If F_Avvio.DatiRX_8(0) >= 1 And F_Avvio.DatiRX_8(0) <= 254 Then
                    BtnV_min.Enabled = True
                    BtnV_max.Enabled = True
                End If
                'Aggiorna PosizioneTrackBar
                If EL_Selezionato <> F_Avvio.DatiRX_7(0) Then TrackBarVelocità.Value = F_Avvio.DatiRX_8(0) / 2.55
            ElseIf F_Avvio.DatiRX_7(0) > 4 Then
                TrackBarVelocità.Enabled = False
                BtnV_min.Enabled = False
                BtnV_max.Enabled = False
            End If


            ' LabelColore.Text = F_Avvio.DatiRX_7(0) & " " & R & " " & " " & G & " " & B

            'Visualizza la Temperatura
            P_HubPC_HUB.Sensori_Dati(F_Avvio.DatiRX_1(0))


            'LabelColore.Text = RGBAMenù & " " & F_SettingColor.ConvertiColore.Elemento_H(0) & " " & F_SettingColor.ConvertiColore.Elemento_S(0) & " " & F_SettingColor.ConvertiColore.Elemento_V(0)

            'Stop Loop
            AggiornaGUI = False
            EL_Selezionato = F_Avvio.DatiRX_7(0)
            H_Stato = F_Avvio.DatiRX_5(0)
            S_Stato = F_Avvio.DatiRX_6(0)
            V_Stato = F_Avvio.DatiRX_4(0)
            Ventole_Speed = F_Avvio.DatiRX_8(0)
            SensoreTemperatura = F_Avvio.DatiRX_1(0)

            Lingua = My.Settings.Lingua

        End If


        'Valore RPM Ventola
        If F_Avvio.DatiRX_7(0) > 0 And F_Avvio.DatiRX_7(0) < 5 Then
            P_HubPC_HUB.LaN_RPM.Text = "RPM"
            P_HubPC_HUB.LaRPMvnetola.Text = (F_Avvio.DatiRX_10(F_Avvio.DatiRX_7(0) - 1) * 30)
        End If
        If F_Avvio.DatiRX_7(0) = 0 Then
            Dim RPM As Integer = 0
            For n = 0 To 3
                RPM = RPM + (F_Avvio.DatiRX_10(n) * 30)
            Next
            P_HubPC_HUB.LaN_RPM.Text = "RPM media"
            P_HubPC_HUB.LaRPMvnetola.Text = Int(RPM / 4)
        End If












        'Avvia Funzione Acquisizione Audio PC Sofware Naudio.dll
        If F_Avvio.DatiRX_7(0) = 0 And P_HubPC_HUB.LaColore.Text = BtnRGB4.Tag And F_Setting_RGB_Animation_HUB.ComboBox1.Text <> "" Then
            Try
                F_Setting_RGB_Animation_HUB.AniamzioneRGB_Musica()
            Catch ex As Exception

            End Try
        End If


    End Sub




    '
    Public Sub Btn_Color_ON(Tag As String)

        Btn_Color_OFF()
        Btn_Fan_GUI()

        'Dim Menù As Integer = Array.IndexOf(ColorNome, Tag)
        ' BtnMenuPos(Menù)

        Select Case Tag
            Case = BtnColor0.Tag
                BtnColor0.BorderStyle = BorderStyle.Fixed3D
            Case = BtnColor1.Tag
                BtnColor1.BorderStyle = BorderStyle.Fixed3D
            Case = BtnColor2.Tag
                BtnColor2.BorderStyle = BorderStyle.Fixed3D
            Case = BtnColor3.Tag
                BtnColor3.BorderStyle = BorderStyle.Fixed3D
            Case = BtnColor4.Tag
                BtnColor4.BorderStyle = BorderStyle.Fixed3D
            Case = BtnColor5.Tag
                BtnColor5.BorderStyle = BorderStyle.Fixed3D
            Case = BtnColor6.Tag
                BtnColor6.BorderStyle = BorderStyle.Fixed3D
            Case = BtnColor7.Tag
                BtnColor7.BorderStyle = BorderStyle.Fixed3D

                'Animazioni
            Case = BtnRGB0.Tag
                If RGBAMenù = 0 Then BtnRGB0.BackgroundImage = My.Resources.BtnLED_SpentoON
                If RGBAMenù = 1 Then BtnRGB0.BackgroundImage = My.Resources.BtnLED_halloween_ON
            Case = BtnRGB1.Tag
                BtnRGB1.BackgroundImage = My.Resources.BtnLED_TransizioneON
            Case = BtnRGB2.Tag
                BtnRGB2.BackgroundImage = My.Resources.BtnLED_RainBowON
            Case = BtnRGB3.Tag
                BtnRGB3.BackgroundImage = My.Resources.BtnLED_TemperaturaON
            Case = BtnRGB4.Tag
                BtnRGB4.BackgroundImage = My.Resources.BtnLED_MusicaON
            Case = BtnRGB5.Tag
                BtnRGB5.BackgroundImage = My.Resources.BtnLED_DiscontinuoON

        End Select

        'LabelColore.Text = BtnMenuPos(Menù)
    End Sub

    Public Sub Btn_Color_OFF()
        BtnColor0.BorderStyle = BorderStyle.None
        BtnColor3.BorderStyle = BorderStyle.None
        BtnColor2.BorderStyle = BorderStyle.None
        BtnColor4.BorderStyle = BorderStyle.None
        BtnColor1.BorderStyle = BorderStyle.None
        BtnColor5.BorderStyle = BorderStyle.None
        BtnColor6.BorderStyle = BorderStyle.None
        BtnColor7.BorderStyle = BorderStyle.None
    End Sub
    Public Sub Btn_Fan_GUI()
        BtnRGB1.BackgroundImage = My.Resources.BtnLED_Transizione

        If RGBAMenù = 0 Then BtnRGB0.BackgroundImage = My.Resources.BtnLED_Spento
        If RGBAMenù = 1 Then BtnRGB0.BackgroundImage = My.Resources.BtnLED_halloween_off

        BtnRGB2.BackgroundImage = My.Resources.BtnLED_RainBow
        BtnRGB4.BackgroundImage = My.Resources.BtnLED_Musica
        BtnRGB5.BackgroundImage = My.Resources.BtnLED_Discontinuo
        BtnRGB3.BackgroundImage = My.Resources.BtnLED_Temperatura
    End Sub





    'Public Sub RGB_Aniamtion_Img()
    '    F_HubPC_Ventole.IconaFanScolor.BackColor = Color.FromArgb(7, 4, 31)
    '    F_HubPC_Ventole.LaColore.BackColor = Color.FromArgb(7, 4, 31)

    '    F_HubPC_Home.Btn_F_HubPC_Dissipatore.BackColor = Color.FromArgb(7, 4, 31)
    '    F_HubPC_Home.Btn_F_HubPC_Ventole.BackColor = Color.FromArgb(7, 4, 31)
    '    F_HubPC_Home.Btn_F_HubPC_CasseAudio.BackColor = Color.FromArgb(7, 4, 31)
    '    F_HubPC_Home.Btn_F_HubPC_GPU.BackColor = Color.FromArgb(7, 4, 31)
    '    F_HubPC_Home.Btn_Hub_SyncMode.BackColor = Color.FromArgb(7, 4, 31)
    '    F_HubPC_Home.Btn_F_HubPC_SLED.BackColor = Color.FromArgb(7, 4, 31)

    '    'F_HubPC_HUB.Btn_Fan_Info.BackColor = Color.FromArgb(7, 4, 31)
    '    'F_HubPC_HUB.Btn_GPU_Info.BackColor = Color.FromArgb(7, 4, 31)
    '    'F_HubPC_HUB.Btn_Altro_Info.BackColor = Color.FromArgb(7, 4, 31)
    '    'F_HubPC_HUB.Btn_HUB_Info.BackColor = Color.FromArgb(7, 4, 31)
    '    'F_HubPC_HUB.Btn_StriscaLED_Info.BackColor = Color.FromArgb(7, 4, 31)
    '    'F_HubPC_HUB.Icona_Color.BackColor = Color.FromArgb(7, 4, 31)

    'End Sub

    Public Sub Luminosità_Reset()
        If F_Avvio.DatiRX_4(0) < 13 Then
            F_Avvio.Data2 = 255 / 2
            TrackBarLuminosità.Value = F_Avvio.Data2 / 2.55
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


    'Funzione map dati
    Public Function map(ByVal x As Long, ByVal in_min As Long, ByVal in_max As Long, ByVal out_min As Long, ByVal out_max As Long) As Long
        Return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min
    End Function


    'Setta in bottoni Animazione off
    Public Sub BtnOFF_Animation()
        If F_Avvio.Data1 <> 0 Then
            Btn_Men_RGB_Animation.Visible = False 'Menù agguntivo Animazione LED
            Btn_Men_RGB_Animation_Click()
        End If

        BtnRGB1.Visible = False
        'F_Fan.Btn_Spento.Visible = False
        BtnRGB2.Visible = False
        BtnRGB4.Visible = False
        BtnRGB5.Visible = False
        BtnRGB3.Visible = False
    End Sub


    'Lingua
    Public ID_ColoreN(30) As Integer
    Public ColorNome(30) As String
    'Data
    Public ID_ColoreVal(30) As Integer
    Public H_Val(30) As Integer
    Public S_Val(30) As Integer
    Public BtnPosizione(30) As String
    Public BtnMenuPos(30) As Integer

    ' //-- Lingua finestra e pagine
    Public Sub CambiaLinguaColore(lingua As String)
        ' Ottieni il percorso del file di testo per la lingua specificata

        Dim nomeFile As String = ""
        Select Case lingua
            Case "ITA"
                nomeFile = "N_ColoreHUBFan.txt"
            Case "ENG"
                nomeFile = "N_ColoreHUBFan.txt"
            Case "Null"
                'nomeFile = ""
        End Select

        ' Combina il percorso relativo del file con il percorso della cartella dell'applicazione
        Dim percorsoFile As String = Path.Combine(F_Impostazioni.cartellaLingue, lingua, nomeFile)
        ' Leggi il testo dal file per le due etichette
        Dim testo As String() = F_Impostazioni.LeggiTestoDaFile(percorsoFile)

        If nomeFile = "N_ColoreHUBFan.txt" Then
            ColoreNome(testo)
        End If

    End Sub


    ' //-- Dati User finestra e pagine
    Public Sub UserData(Data As String)
        ' Ottieni il percorso del file di testo per la lingua specificata
        Dim nomeFile As String = ""
        Select Case Data
            Case "HUBFan_Dati"
                nomeFile = "T_Colore.txt"
            Case "Null"
                nomeFile = ""
            Case "Null"
                'nomeFile = "F_Impostazioni.txt"
        End Select
        ' Combina il percorso relativo del file con il percorso della cartella dell'applicazione
        Dim percorsoFile As String = Path.Combine(F_Impostazioni.cartellaDataUser, Data, nomeFile)
        ' Leggi il testo dal file
        Dim testo As String() = F_Impostazioni.LeggiTestoDaFile(percorsoFile)

        If Data = "HUBFan_Dati" Then
            ColoreData(testo)
        End If

    End Sub

    'Dati Colore
    Public Sub ColoreData(testo)
        Try
            Dim x As Integer = 0
            For n As Integer = 2 To testo.Length - 1

                Dim val() As String
                val = testo(n).Split(" ")

                'If testo(n).Length > 5 And testo(n).Length < 23 Then
                If testo(n).Length > 5 And testo(n).Length < 23 And (val.Length = 5 Or val.Length = 4) Then
                    'Dim val() As String
                    'val = testo(n).Split(" ")
                    If IsNumeric(val(0)) Then
                        ID_ColoreVal((n - x) - 2) = val(0)
                        H_Val((n - x) - 2) = val(1)
                        S_Val((n - x) - 2) = val(2)
                    End If
                    If val.Length >= 4 Then
                        BtnPosizione((n - x) - 2) = val(3)
                    Else
                        BtnPosizione((n - x) - 2) = "null"
                    End If

                    If val.Length = 5 Then
                        BtnMenuPos((n - x) - 2) = val(4)
                    Else
                        BtnMenuPos((n - x) - 2) = -1
                    End If

                Else
                    x = x + 1
                End If
            Next

            F_Avvio.ConvertiColore.BtnColore(RGBAMenù)
            'LabelColore.Text = H_Val(15)
        Catch ex As Exception

        End Try
    End Sub

    'Nome Colore
    Public Sub ColoreNome(testo)
        Try
            Dim x As Integer = 0
            For n As Integer = 2 To testo.Length - 1
                If testo(n).Length > 3 And testo(n).Length < 20 Then
                    Dim val() As String
                    val = testo(n).Split(" ")
                    ID_ColoreN((n - x) - 2) = val(0)
                    ColorNome((n - x) - 2) = val(1)
                Else
                    x = x + 1
                End If
            Next


        Catch ex As Exception

        End Try

    End Sub




    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        ' Determina quale controllo ha attivato il menu contestuale
        Dim control As Control = ContextMenuStrip1.SourceControl

        ' Verifica se il controllo è un bottone (o qualsiasi altro tipo di controllo)
        If TypeOf control Is PictureBox Then
            Dim button As PictureBox = DirectCast(control, PictureBox)
            ' Ora puoi fare qualcosa con il bottone
            F_SettingColor.buttonName = button.Name
            F_SettingColor.buttonNameTag = button.Tag

            F_SettingColor.TextBoxNomeColore.Text = ColorNome(F_Avvio.ConvertiColore.SetColor(button.Name))
            F_SettingColor.TrackBarColore.Value = H_Val(F_Avvio.ConvertiColore.SetColor(button.Name))
            F_SettingColor.LaColore_V.Text = F_SettingColor.TrackBarColore.Value
            F_SettingColor.TrackBarSaturazione.Value = S_Val(F_Avvio.ConvertiColore.SetColor(button.Name))
            F_SettingColor.LaSaturazione_V.Text = F_SettingColor.TrackBarSaturazione.Value

        End If
    End Sub
    'Click tasto Destro
    Private Sub ModificaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificaToolStripMenuItem.Click

        F_SettingColor.TrackBarLuminosità.Value = F_Avvio.Data2
        F_SettingColor.ColoreDinamico()

        F_SettingColor.Show()
    End Sub

    'Reimposta il Colore Originale
    Private Sub PredefinitoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PredefinitoToolStripMenuItem.Click

        Dim ID_old As Integer = Array.IndexOf(ColorNome, F_SettingColor.buttonNameTag)

        If ID_ColoreVal(ID_old) > 15 Then
            'AggiornaRigaColore(ID_old, TextBoxNomeColore.Text, TrackBarColore.Value, TrackBarSaturazione.Value, buttonName, 0, False)
            F_SettingColor.AggiornaRigaColore(ID_old, "", 0, 0, F_SettingColor.buttonName, 0, True)

            ' Tenta di trovare il controllo con il nome specificato
            Dim control As Control = Me.Controls(F_SettingColor.buttonName)
            ' Verifica se il controllo esiste e se è un bottone
            If control IsNot Nothing AndAlso TypeOf control Is PictureBox Then
                ' Cast del controllo a Button
                Dim button As PictureBox = CType(control, PictureBox)
                ' Ottieni il tag del bottone e memorizzalo nella variabile buttonTag
                F_SettingColor.buttonNameTag = button.Tag.ToString()
                SetColore(F_SettingColor.buttonNameTag, 0)
            End If

            'Aggiorna Grafica
            AggiornaGUI = True
        End If
    End Sub







    'Lingua Finestra Titoli
    ' //-- Lingua finestra e pagine
    Public Sub CambiaLingua(lingua As String)

        ' Combina il percorso relativo del file con il percorso della cartella dell'applicazione
        Dim percorsoFile As String = Path.Combine(F_Impostazioni.cartellaLingue, lingua, "F_Hub_PC.txt")
        ' Leggi il testo dal file per le due etichette
        Dim testo As String() = F_Impostazioni.LeggiTestoDaFile(percorsoFile)


        Try
            ' Modifica il testo delle etichette dell'interfaccia con il testo letto dal file
            'Titoli
            LabelColore.Text = testo(1)
            LabelVelocità.Text = testo(2)
            LabelLuminosità.Text = testo(3)
            LabelRGBAnimazioni.Text = testo(4)

            'ToolTip
            'Barra Avvio Rapido
            ToolTip1.SetToolTip(BtnTaskHardware_GUI, testo(22))
            ToolTip1.SetToolTip(BtnImpostazioniFan, testo(23))

            'Luminosità
            ToolTip1.SetToolTip(BtnL_min, testo(37))
            ToolTip1.SetToolTip(BtnL_max, testo(38))
            'Velocità
            ToolTip1.SetToolTip(BtnV_min, testo(30))
            ToolTip1.SetToolTip(BtnV_max, testo(31))

            'Info Menù Animazioni A-rgb
            ToolTip1.SetToolTip(Btn_Men_RGB_Animation, testo(44))

        Catch ex As Exception

        End Try
        'F_SettingColor.ConvertiColore.BtnColore(RGBAMenù)
    End Sub


End Class