
Public Class F_HubPC_Ventole

    Public S_Fan_All As Integer
    Public S_Fan_1 As Integer
    Public S_Fan_2 As Integer
    Public S_Fan_3 As Integer
    Public S_Fan_4 As Integer

    Public PercentualeLuminosità As Integer
    Public PercentualeVelocità As Integer
    Dim TempSensMin As Integer = 100
    Dim TempSensMax As Integer = 0

    'Memorizza il dato Impostato [Velocità ventola] quando si cambia dispositivo
    Public Sub TX_Btn_Velocità()
        Select Case F_Avvio.Data1
            Case = 0
                S_Fan_All = F_Avvio.Data5
            Case = 1
                S_Fan_1 = F_Avvio.Data5
            Case = 2
                S_Fan_2 = F_Avvio.Data5
            Case = 3
                S_Fan_3 = F_Avvio.Data5
            Case = 4
                S_Fan_4 = F_Avvio.Data5
        End Select
    End Sub

    'Funzione Btn Tutto Sincoronizato
    Private Sub IconaFanAll_Click(sender As Object, e As EventArgs)

        F_Avvio.Data1 = 0

        TitoloFan.ForeColor = Color.White

        F_Hub_PC.Btn_Men_RGB_Animation.Visible = True

        F_Hub_PC.BtnAN_Transiszione.Visible = True
        'F_Fan.Btn_Spento.Visible = False
        F_Hub_PC.BtnAN_Rainbow.Visible = True
        F_Hub_PC.BtnAN_Musica.Visible = True
        F_Hub_PC.BtnAN_Discontinuo.Visible = True
        F_Hub_PC.BtnAN_Tepmeratura.Visible = True

        If F_Avvio.Data1 = 0 Then
            F_Avvio.Data3 = F_Hub_PC.H_SyncMode
            F_Avvio.Data4 = F_Hub_PC.S_SyncMode
            F_Avvio.Data2 = F_Hub_PC.V_SyncMode
            F_Avvio.Data5 = S_Fan_All
        End If

    End Sub

    'Funzione Btn Seleziona Ventola 1
    Public Sub IconaFan1_Click(sender As Object, e As EventArgs) Handles IconaFan1.Click
        F_Avvio.Data1 = 1

        TitoloFan.ForeColor = Color.White

        F_Hub_PC.BtnOFF_Animation()

        'If F_Avvio.DatiRX_3(0) = 1 Then
        If F_Avvio.Data1 = 1 Then
            F_Avvio.Data3 = F_Hub_PC.H_Fan1
            F_Avvio.Data4 = F_Hub_PC.S_Fan1
            F_Avvio.Data2 = F_Hub_PC.V_Fan1
            F_Avvio.Data5 = S_Fan_1
        End If

    End Sub

    Private Sub IconaFan1_MouseHover(sender As Object, e As EventArgs) Handles IconaFan1.MouseHover
        F_Home.ToolTip1.SetToolTip(IconaFan1, "Colore " & F_Hub_PC.H_Fan1 & "
Luminosità " & Int(F_Hub_PC.V_Fan1 / 2.55) & "%" & "
Velocità " & Int(S_Fan_1 / 2.55) & "%")
    End Sub



    'Funzione Btn Seleziona Ventola 2
    Private Sub IconaFan2_Click(sender As Object, e As EventArgs) Handles IconaFan2.Click
        F_Avvio.Data1 = 2

        TitoloFan.ForeColor = Color.White

        F_Hub_PC.BtnOFF_Animation()

        If F_Avvio.Data1 = 2 Then
            F_Avvio.Data3 = F_Hub_PC.H_Fan2
            F_Avvio.Data4 = F_Hub_PC.S_Fan2
            F_Avvio.Data2 = F_Hub_PC.V_Fan2
            F_Avvio.Data5 = S_Fan_2
        End If

    End Sub
    Private Sub IconaFan2_MouseHover(sender As Object, e As EventArgs) Handles IconaFan2.MouseHover
        F_Home.ToolTip1.SetToolTip(IconaFan2, "Colore " & F_Hub_PC.H_Fan2 & "
Luminosità " & Int(F_Hub_PC.V_Fan2 / 2.55) & "%" & "
Velocità " & Int(S_Fan_2 / 2.55) & "%")
    End Sub

    'Funzione Btn Seleziona Ventola 3
    Private Sub IconaFan3_Click(sender As Object, e As EventArgs) Handles IconaFan3.Click
        F_Avvio.Data1 = 3

        TitoloFan.ForeColor = Color.White

        F_Hub_PC.BtnOFF_Animation()

        If F_Avvio.Data1 = 3 Then
            F_Avvio.Data3 = F_Hub_PC.H_Fan3
            F_Avvio.Data4 = F_Hub_PC.S_Fan3
            F_Avvio.Data2 = F_Hub_PC.V_Fan3
            F_Avvio.Data5 = S_Fan_3
        End If

    End Sub
    Private Sub IconaFan3_MouseHover(sender As Object, e As EventArgs) Handles IconaFan3.MouseHover
        F_Home.ToolTip1.SetToolTip(IconaFan3, "Colore " & F_Hub_PC.H_Fan3 & "
Luminosità " & Int(F_Hub_PC.V_Fan3 / 2.55) & "%" & "
Velocità " & Int(S_Fan_3 / 2.55) & "%")
    End Sub

    'Funzione Btn Seleziona Ventola 4
    Private Sub IconaFan4_Click(sender As Object, e As EventArgs) Handles IconaFan4.Click
        F_Avvio.Data1 = 4

        TitoloFan.ForeColor = Color.White

        F_Hub_PC.BtnOFF_Animation()

        If F_Avvio.Data1 = 4 Then
            F_Avvio.Data3 = F_Hub_PC.H_Fan4
            F_Avvio.Data4 = F_Hub_PC.S_Fan4
            F_Avvio.Data2 = F_Hub_PC.V_Fan4
            F_Avvio.Data5 = S_Fan_4
        End If

    End Sub
    Private Sub IconaFan4_MouseHover(sender As Object, e As EventArgs) Handles IconaFan4.MouseHover
        F_Home.ToolTip1.SetToolTip(IconaFan4, "Colore " & F_Hub_PC.H_Fan4 & "
Luminosità " & Int(F_Hub_PC.V_Fan4 / 2.55) & "%" & "
Velocità " & Int(S_Fan_4 / 2.55) & "%")
    End Sub

    'Richiama la Funzione Btn Tutto Sincoronizato
    Private Sub LaFAN_All_Click(sender As Object, e As EventArgs)
        IconaFanAll_Click(sender, e)
    End Sub

    'Richiama la Funzione Btn Seleziona Ventola 1
    Private Sub LaFAN_1_Click(sender As Object, e As EventArgs) Handles LaFAN_1.Click
        IconaFan1_Click(sender, e)
    End Sub

    'Richiama la Funzione Btn Seleziona Ventola 2
    Private Sub LaFAN_2_Click(sender As Object, e As EventArgs) Handles LaFAN_2.Click
        IconaFan2_Click(sender, e)
    End Sub

    'Richiama la Funzione Btn Seleziona Ventola 3
    Private Sub LaFAN_3_Click(sender As Object, e As EventArgs) Handles LaFAN_3.Click
        IconaFan3_Click(sender, e)
    End Sub

    'Richiama la Funzione Btn Seleziona Ventola 4
    Private Sub LaFAN_4_Click(sender As Object, e As EventArgs) Handles LaFAN_4.Click
        IconaFan4_Click(sender, e)
    End Sub

    'Funzione Btn Seleziona Attiva/Disattiva Moadalita Velocita Auto con acquisizione Temperatura del HUB
    Private Sub LaTempSens_Click(sender As Object, e As EventArgs) Handles LaTempSens.Click
        F_Avvio.ErrorMod = 70
        F_Avvisi.LabelID_Error.Text = "Avviso Code " & F_Avvio.ErrorMod
        F_Avvisi.AvvisoErrore()
    End Sub

    'Funzione Btn Seleziona Attiva/Disattiva Moadalita Velocita Auto con acquisizione Temperatura della CPU
    Private Sub LaTempCPU_Click(sender As Object, e As EventArgs) Handles LaTempCPU.Click
        F_Avvio.ErrorMod = 71
        F_Avvisi.LabelID_Error.Text = "Avviso Code " & F_Avvio.ErrorMod
        F_Avvisi.AvvisoErrore()
    End Sub

    'Funzione Btn Seleziona Attiva/Disattiva Moadalita Velocita Auto con acquisizione Temperatura della GPU
    Private Sub LaTempGPU_Click(sender As Object, e As EventArgs) Handles LaTempGPU.Click
        F_Avvio.ErrorMod = 72
        F_Avvisi.LabelID_Error.Text = "Avviso Code " & F_Avvio.ErrorMod
        F_Avvisi.AvvisoErrore()
    End Sub


    'Finzione Btn Attiva/Disattiva Velocità ventola riferito al SensoreTemperatura di Arduino
    Private Sub BtnTSens_Click(sender As Object, e As EventArgs) Handles BtnTSens.Click
        If F_Avvio.DatiRX_1(0) < "85" And F_Avvio.DatiRX_1(0) > "10" And F_Avvio.DatiRX_7(0) = "0" Then
            If F_Avvio.DatiRX_9(0) <> "1" Then
                F_Avvio.Data6 = 1

            ElseIf F_Avvio.DatiRX_9(0) = "1" Then
                F_Avvio.Data6 = 0

            End If
        Else
            F_Avvio.FunzioneNull()
            F_Avvio.Data6 = 0
        End If
    End Sub

    'Finzione Btn Attiva/Disattiva Velocità ventola riferito alla CPU del PC
    Private Sub BtnTCPU_Click(sender As Object, e As EventArgs) Handles BtnTCPU.Click
        If F_Avvio.ErrorHardwareCPU = 0 And F_Avvio.DatiRX_7(0) = "0" Then
            If F_Avvio.DatiRX_9(0) <> "2" Then
                F_Avvio.Data6 = 2

            ElseIf F_Avvio.DatiRX_9(0) = "2" Then
                F_Avvio.Data6 = 0

            End If
        Else
            F_Avvio.FunzioneNull()
            F_Avvio.Data6 = 0
        End If
    End Sub

    'Finzione Btn Attiva/Disattiva Velocità ventola riferito alla GPU del PC
    Private Sub BtnTGPU_Click(sender As Object, e As EventArgs) Handles BtnTGPU.Click
        If F_Avvio.ErrorHardwareGPU = 0 And F_Avvio.DatiRX_7(0) = "0" Then
            If F_Avvio.DatiRX_9(0) <> "3" Then
                F_Avvio.Data6 = 3

            ElseIf F_Avvio.DatiRX_9(0) = "3" Then
                F_Avvio.Data6 = 0

            End If
        Else
            F_Avvio.FunzioneNull()
            F_Avvio.Data6 = 0
        End If
    End Sub

    'Crea una Fuzione loop che gestisce l'Animazione Musica, Cura ventola Automatica [CPU-GPU-Sens], fa visualizare la temperatura del sensore Hub e Invio dati CPU,GPU all'HUB
    Public Sub GUI_Ventole()

        'Avvia Finzione Acquisizione Audio PC Sofware Naudio.dll
        If F_Avvio.DatiRX_7(0) = 0 And F_Avvio.DatiRX_5(0) = F_Hub_PC.Animazione_RGB_Musica And F_Setting_RGB_Animation_Fan.ComboBox1.Text <> "" Then
            Try
                F_Setting_RGB_Animation_Fan.AniamzioneRGB_Musica()
            Catch ex As Exception

            End Try
        End If

        'Informazione RPM ventole
        If F_Avvio.DatiRX_0(1) = "4" Or F_Avvio.DatiRX_0(1) = "5" Then
            Select Case F_Avvio.DatiRX_7(0)
                Case = 0
                    LaRPMvnetola.Text = "RPM               ???"
                Case = 1
                    LaRPMvnetola.Text = "RPM              " & (F_Avvio.DatiRX_10(0) * 30)
                Case = 2
                    LaRPMvnetola.Text = "RPM              " & (F_Avvio.DatiRX_10(1) * 30)
                Case = 3
                    LaRPMvnetola.Text = "RPM              " & (F_Avvio.DatiRX_10(2) * 30)
                Case = 4
                    LaRPMvnetola.Text = "RPM              " & (F_Avvio.DatiRX_10(3) * 30)
            End Select
        Else
            LaRPMvnetola.Text = "RPM Non disponibbile"
        End If

        'Curva Ventola riferito alla temperatura della CPU
        If F_Avvio.DatiRX_9(0) = "2" And F_Avvio.DatiRX_7(0) = 0 Then

            FanMOD_Auto()

            LaVelocità.ForeColor = Color.FromArgb(0, 238, 247)
            LaFanModalità.ForeColor = Color.FromArgb(0, 238, 247)
            LaFanModalità.Text = "Modalità      Auto"

            BtnTCPU.BackgroundImage = My.Resources.btn_SwichON
            BtnTSens.BackgroundImage = My.Resources.btn_Swich
            BtnTGPU.BackgroundImage = My.Resources.btn_Swich

            'LodBarSpeeAll.BackColor = Color.FromArgb(0, 238, 247)

            'If TempBarCPU.Value < 31 Then

            '    F_Avvio.Data5 = 0
            '    F_Fan.TrackBarVelocità.Value = 0
            '    LodBarSpeeAll.Height = 0 + F_Avvio.DatiRX_8(0) / 5.66

            'ElseIf TempBarCPU.Value > 32 And TempBarCPU.Value < 44 Then

            '    F_Avvio.Data5 = 100
            '    F_Fan.TrackBarVelocità.Value = 40
            '    LodBarSpeeAll.Height = 0 + F_Avvio.DatiRX_8(0) / 5.66

            'ElseIf TempBarCPU.Value > 45 And TempBarCPU.Value < 59 Then

            '    F_Avvio.Data5 = 150
            '    F_Fan.TrackBarVelocità.Value = 60
            '    LodBarSpeeAll.Height = 0 + F_Avvio.DatiRX_8(0) / 5.66

            'ElseIf TempBarCPU.Value > 60 Then

            '    F_Avvio.Data5 = 255
            '    F_Fan.TrackBarVelocità.Value = 100
            '    LodBarSpeeAll.Height = 0 + F_Avvio.DatiRX_8(0) / 5.66

            'End If

        End If

        'Curva Ventola riferito alla temperatura della GPU
        If F_Avvio.DatiRX_9(0) = "3" And F_Avvio.DatiRX_7(0) = 0 Then

            FanMOD_Auto()

            LaVelocità.ForeColor = Color.Fuchsia
            LaFanModalità.ForeColor = Color.Fuchsia
            LaFanModalità.Text = "Modalità      Auto"

            BtnTGPU.BackgroundImage = My.Resources.btn_SwichON
            BtnTSens.BackgroundImage = My.Resources.btn_Swich
            BtnTCPU.BackgroundImage = My.Resources.btn_Swich

            'LodBarSpeeAll.BackColor = Color.Fuchsia

            'If TempBarGPU.Value < 31 Then

            '    F_Avvio.Data11 = 0
            '    F_Fan.TrackBarVelocità.Value = 0
            '    LodBarSpeeAll.Height = 0 + F_Fan.TrackBarVelocità.Value / 5.66

            'ElseIf TempBarGPU.Value > 32 And TempBarCPU.Value < 44 Then

            '    F_Avvio.Data11 = 100
            '    F_Fan.TrackBarVelocità.Value = 100
            '    LodBarSpeeAll.Height = 0 + F_Fan.TrackBarVelocità.Value / 5.66

            'ElseIf TempBarGPU.Value > 45 And TempBarCPU.Value < 59 Then

            '    F_Avvio.Data11 = 150
            '    F_Fan.TrackBarVelocità.Value = 150
            '    LodBarSpeeAll.Height = 0 + F_Fan.TrackBarVelocità.Value / 5.66

            'ElseIf TempBarGPU.Value > 60 Then

            '    F_Avvio.Data11 = 255
            '    F_Fan.TrackBarVelocità.Value = 255
            '    LodBarSpeeAll.Height = 0 + F_Fan.TrackBarVelocità.Value / 5.66

            'End If

        Else
            'F_Avvio.FunzioneNull()
        End If






        'Manuale TempSens
        'If F_Fan.Aggiorna_Speed = 1 Then

        If F_Avvio.DatiRX_9(0) = "0" And F_Avvio.DatiRX_7(0) = 0 Then
            'BtnAutoVelocità.ForeColor = Color.Gold
            'F_Hub_PC.TrackBarVelocità.Enabled = True

            BtnTSens.BackgroundImage = My.Resources.btn_Swich
            BtnTCPU.BackgroundImage = My.Resources.btn_Swich
            BtnTGPU.BackgroundImage = My.Resources.btn_Swich

        ElseIf F_Avvio.DatiRX_7(0) > "4" Then
            FanMOD_Auto()
        End If


        If F_Avvio.DatiRX_9(0) = "1" And F_Avvio.DatiRX_7(0) = 0 Then

            FanMOD_Auto()

            LaVelocità.ForeColor = Color.FromArgb(255, 128, 0)
            'LaVelocità.Text = "Velocità   Automatica"
            LaFanModalità.ForeColor = Color.FromArgb(255, 128, 0)
            LaFanModalità.Text = "Modalità      Auto"

            BtnTSens.BackgroundImage = My.Resources.btn_SwichON
            BtnTCPU.BackgroundImage = My.Resources.btn_Swich
            BtnTGPU.BackgroundImage = My.Resources.btn_Swich

            'LodBarSpeeAll.BackColor = Color.FromArgb(255, 128, 0)

        End If


        'F_Fan.Aggiorna_Speed = 0
        'End If




        '        LaTempSens.Text = "Temperatura
        '" & F_Avvio.DatiRX_1(0) & " °C
        '" & "Curva Ventole"

        If TempBarSens.Maximum >= F_Avvio.DatiRX_1(0) Then

            TempBarSens.Value = F_Avvio.DatiRX_1(0)
            TempBarSens.Text = F_Avvio.DatiRX_1(0)

            '            LaTempSens.Text = "Temperatura
            'Min " & TempSensMin & " °C
            '" & "Max " & TempSensMax & " °C"
        End If

        If TempSensMin >= F_Avvio.DatiRX_1(0) Then
            TempSensMin = F_Avvio.DatiRX_1(0)
        End If

        If TempSensMax <= F_Avvio.DatiRX_1(0) Then
            TempSensMax = F_Avvio.DatiRX_1(0)
            TempBarSens.Maximum = TempSensMax
        End If

        F_Avvio.Data7 = F_Avvio.CPU_TemperaturaL
        F_Avvio.Data8 = F_Avvio.GPU_Temperatura

        'LaFAN_2.Text = S_All
        'LaFAN_2.Text = F_Avvio.Data3
    End Sub

    'Qunado e in modalità Velocità Auto i selettori per la velocità Manuale vengono Disattivati
    Public Sub FanMOD_Auto()
        F_Hub_PC.TrackBarVelocità.Enabled = False
        F_Hub_PC.BtnV_min.Enabled = False
        F_Hub_PC.BtnV_max.Enabled = False
    End Sub


    'Dim BtnSens_Temp = 0
    'Dim BtnCPU_Temp = 0






    Public Sub UI_Ventole()
        'LaColore.ForeColor = Color.FromArgb(R, G, B)

        ''If F_Avvio.DatiRX_5(F_Avvio.DatiRX_7(0)) < 256 Then
        'If H = F_Avvio.DatiRX_5(F_Avvio.DatiRX_7(0)) Then
        '    IconaFanScolor.BackColor = Color.FromArgb(R, G, B)
        'End If

        'If F_Fan.H_All < 256 Then
        '    IconaFanAll.BackColor = Color.FromArgb(R_All, G_All, B_All)
        'Else
        '    IconaFanAll.BackColor = Color.FromArgb(7, 4, 31)
        'End If

        'Barra Luminosità
        'If F_Avvio.DatiRX_7(0) >= 0 And F_Avvio.DatiRX_7(0) <= 4 Then
        F_Hub_PC.PercentualeLuminosità = F_Avvio.DatiRX_4(F_Avvio.DatiRX_7(0)) / 2.55
        LaLuminosità.Text = "Luminosità   " & F_Hub_PC.PercentualeLuminosità & "%"
        'End If
        'LodBarLimAll.Height = F_Avvio.DatiRX_4(0) / 5.66
        LodBarLimFan1.Height = F_Avvio.DatiRX_4(1) / 5.66
        LodBarLimFan2.Height = F_Avvio.DatiRX_4(2) / 5.66
        LodBarLimFan3.Height = F_Avvio.DatiRX_4(3) / 5.66
        LodBarLimFan4.Height = F_Avvio.DatiRX_4(4) / 5.66
        'Dim L_GLED As Integer = F_Avvio.DatiRX_4(8) / 2.55
        'F_Fan_Menù_2.LaLuminosità_Fan_Menù_2.Text = L_GLED & "%"
        'Dim L_SLED As Integer = F_Avvio.DatiRX_4(9) / 2.55
        'F_Fan_Menù_2.LaLuminosità_StrLED.Text = L_SLED & "%"


        'Barra Velocità
        F_Hub_PC.PercentualeVelocità = F_Avvio.DatiRX_8(F_Avvio.DatiRX_7(1)) / 2.55
        LaVelocità.Text = "Velocità        " & F_Hub_PC.PercentualeVelocità & "%"
        'LodBarSpeeAll.Height = F_Avvio.DatiRX_8(0) / 5.66
        LodBarSpeeFan1.Height = F_Avvio.DatiRX_8(1) / 5.66
        LodBarSpeeFan2.Height = F_Avvio.DatiRX_8(2) / 5.66
        LodBarSpeeFan3.Height = F_Avvio.DatiRX_8(3) / 5.66
        LodBarSpeeFan4.Height = F_Avvio.DatiRX_8(4) / 5.66


    End Sub

    'Public Sub UI_Fan_RGBA()
    '    If F_Avvio.DatiRX_7(0) <> 0 And F_Avvio.DatiRX_5(0) > 255 Then
    '        'Stato Btn GUI_Fan / Btn RGB Discontinuo 
    '        If F_Avvio.DatiRX_5(0) = "300" Then

    '            'IconaFanScolor.BackgroundImage = My.Resources.IconaFan_RGB_Colore_Discontinuo
    '            IconaFanAll.BackgroundImage = My.Resources.IconaFan_RGB_Colore_Discontinuo

    '        End If

    '        'Stato Btn GUI_Fan / BtnRGB Transizione
    '        If F_Avvio.DatiRX_5(0) = "301" Then

    '            'IconaFanScolor.BackgroundImage = My.Resources.IconaFan_RGB_Colore_Transizione
    '            IconaFanAll.BackgroundImage = My.Resources.IconaFan_RGB_Colore_Transizione

    '        End If

    '        'Stato Btn GUI_Fan / BtnRGB RainBow
    '        If F_Avvio.DatiRX_5(0) = "302" Then

    '            'IconaFanScolor.BackgroundImage = My.Resources.IconaFan_RGB_Colore_RainBow
    '            IconaFanAll.BackgroundImage = My.Resources.IconaFan_RGB_Colore_RainBow

    '        End If

    '        'Stato Btn GUI_Fan / BtnRGB Musica
    '        If F_Avvio.DatiRX_5(0) = "303" Then

    '            'IconaFanScolor.BackgroundImage = My.Resources.IconaFan_RGB_Colore_Musica
    '            IconaFanAll.BackgroundImage = My.Resources.IconaFan_RGB_Colore_Musica

    '        End If

    '        'Stato Btn GUI_Fan / BtnRGB Transizione
    '        If F_Avvio.DatiRX_5(0) = "304" Then

    '            'IconaFanScolor.BackgroundImage = My.Resources.IconaFan_RGB_Colore_Transizione
    '            IconaFanAll.BackgroundImage = My.Resources.IconaFan_RGB_Colore_Transizione

    '        End If
    '    End If
    'End Sub

    Public Sub UI_GPU_Strip()

        'If F_Fan.LED_CFan = 1 Then
        '    LaColoreGPU.ForeColor = Color.FromArgb(0, 140, 149)
        '    LaColoreGPU.Text = "Sistema"
        'End If

        If F_Avvio.DatiRX_7(0) <> 0 Or F_Avvio.DatiRX_7(0) <> 8 Then

            'F_Fan_Menù.FanMOD_Auto()

            'Stato Btn GUI_Fan / Btn Spento ON 
            If F_Avvio.DatiRX_4(8) = "0" Then
                F_HubPC_GPU_SLED.LaColore.ForeColor = Color.FromArgb(0, 140, 149)
                F_HubPC_GPU_SLED.LaColore.Text = "Spento"
            End If

            'ColorBtn Bianco
            If F_Avvio.DatiRX_6(8) = "0" Then
                F_HubPC_GPU_SLED.LaColore.ForeColor = Color.White
                F_HubPC_GPU_SLED.LaColore.Text = "Bianco"
                'FanControlManual()
            End If

            ''Stato Btn GUI_Fan / Btn RGB M1 ON 
            'If F_Avvio.DatiRX_5(F_Fan.LED_CFan) = "10" Then
            '    ' F_Fan_Menù_2.IconaStatoGPU.BackgroundImage = My.Resources.Icona_SchedaVideo_Nero
            '    F_Fan_Menù_2.LaColoreGPU.ForeColor = Color.FromArgb(0, 140, 149)
            '    F_Fan_Menù_2.LaColoreGPU.Text = "Discontinuo"
            '    'FanControlManual()
            'End If
            ''Stato Btn GUI_Fan / BtnRGB ??
            'If F_Avvio.DatiRX_5(F_Fan.LED_CFan) = "11" Then
            '    ' F_Fan_Menù_2.IconaStatoGPU.BackgroundImage = My.Resources.Icona_SchedaVideo_Nero
            '    F_Fan_Menù_2.LaColoreGPU.ForeColor = Color.FromArgb(0, 140, 149)
            '    F_Fan_Menù_2.LaColoreGPU.Text = "Transizione"
            '    'FanControlManual()
            'End If
            ''Stato Btn GUI_Fan / BtnRGB ??
            'If F_Avvio.DatiRX_5(F_Fan.LED_CFan) = "12" Then
            '    'F_Fan_Menù_2.IconaStatoGPU.BackgroundImage = My.Resources.Icona_SchedaVideo_Effeto_RainBow
            '    F_Fan_Menù_2.LaColoreGPU.ForeColor = Color.FromArgb(0, 140, 149)
            '    F_Fan_Menù_2.LaColoreGPU.Text = "Rainbow"
            '    'FanControlManual()
            'End If
            ''Stato Btn GUI_Fan / BtnRGB ??
            'If F_Avvio.DatiRX_5(F_Fan.LED_CFan) = "13" Then
            '    F_Fan_Menù_2.IconaStatoGPU.BackgroundImage = My.Resources.Icona_SchedaVideo_Nero
            '    F_Fan_Menù_2.LaColoreGPU.ForeColor = Color.FromArgb(0, 140, 149)
            '    F_Fan_Menù_2.LaColoreGPU.Text = "Musica"
            '    'FanControlManual()
            'End If

            If F_Avvio.DatiRX_4(8) <> "0" And F_Avvio.DatiRX_6(8) <> "0" Then

                'ColorBtn Rosso
                If F_Avvio.DatiRX_5(8) = "0" Then
                    F_HubPC_GPU_SLED.LaColore.ForeColor = Color.Red
                    F_HubPC_GPU_SLED.LaColore.Text = "Rosso"
                    'FanControlManual()
                End If
                'ColorBtn Blu
                If F_Avvio.DatiRX_5(8) = "170" Then
                    F_HubPC_GPU_SLED.LaColore.ForeColor = Color.Blue
                    F_HubPC_GPU_SLED.LaColore.Text = "Blu"
                    'FanControlManual()
                End If
                'ColorBtn Giallo
                If F_Avvio.DatiRX_5(8) = "20" Then
                    F_HubPC_GPU_SLED.LaColore.ForeColor = Color.Yellow
                    F_HubPC_GPU_SLED.LaColore.Text = "Giallo"
                    'FanControlManual()
                End If
                'ColorBtn Verde
                If F_Avvio.DatiRX_5(8) = "80" Then
                    F_HubPC_GPU_SLED.LaColore.ForeColor = Color.Lime
                    F_HubPC_GPU_SLED.LaColore.Text = "Verde"
                    'FanControlManual()
                End If
                'ColorBtn Viola
                If F_Avvio.DatiRX_5(8) = "250" Then
                    F_HubPC_GPU_SLED.LaColore.ForeColor = Color.Fuchsia
                    F_HubPC_GPU_SLED.LaColore.Text = "Fucsia"
                    'FanControlManual()
                End If
                'ColorBtn Arancio
                If F_Avvio.DatiRX_5(8) = "5" Then
                    F_HubPC_GPU_SLED.LaColore.ForeColor = Color.Orange
                    F_HubPC_GPU_SLED.LaColore.Text = "Arancione"
                    'FanControlManual()
                End If
                'ColorBtn Azzurro
                If F_Avvio.DatiRX_5(8) = "135" Then
                    F_HubPC_GPU_SLED.LaColore.ForeColor = Color.Cyan
                    F_HubPC_GPU_SLED.LaColore.Text = "Azzurro"
                    'FanControlManual()
                End If

            End If
        End If

    End Sub



    Public Sub Color_Set_Ventole_IMG()
        'Imposta il colore selezionato alle icone del dispositivo selezionato
        Dim Colore As Integer() = {F_Hub_PC.R, F_Hub_PC.G, F_Hub_PC.B}
        Select Case F_Avvio.DatiRX_7(0)
            Case = 1
                IconaFan1.BackColor = Color.FromArgb(Colore(0), Colore(1), Colore(2))
            Case = 2
                IconaFan2.BackColor = Color.FromArgb(Colore(0), Colore(1), Colore(2))
            Case = 3
                IconaFan3.BackColor = Color.FromArgb(Colore(0), Colore(1), Colore(2))
            Case = 4
                IconaFan4.BackColor = Color.FromArgb(Colore(0), Colore(1), Colore(2))
        End Select
    End Sub


    Private Sub F_HubPC_Ventole_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class