Imports System.Threading

Public Class F_HubPC_Home

    Dim ToolTip_SyncMode As String = "Colore Bianco
Luminosità 100%
Velocità 50%"

    Private Sub F_HubPC_Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'F_Home.ToolTip1.SetToolTip(Btn_Hub_SyncMode, "Colore " & F_Avvio.Data3)
    End Sub

    Public Sub GUI_home_HUB()
        If F_Avvio.DatiRX_0(3) = "3" Then
            Btn_F_HubPC_Ventole.Visible = True
            Btn_F_HubPC_Dissipatore.Visible = False
            Btn_F_HubPC_GPU.Visible = True
            Btn_Hub_SyncMode.Visible = True
            Btn_F_HubPC_CasseAudio.Visible = True
            Btn_F_HubPC_SLED.Visible = True

            La_Ventole.Visible = True
            La_SyncMode.Visible = True
            La_CasseAudio.Visible = True
            La_Dissipatore.Visible = False
            La_GPU.Visible = True
            La_SLED.Visible = True
            La_Ventole.Visible = True

        ElseIf F_Avvio.DatiRX_0(3) = "4" Then
            Btn_F_HubPC_Ventole.Visible = True
            Btn_F_HubPC_Dissipatore.Visible = False
            Btn_F_HubPC_GPU.Visible = True
            Btn_Hub_SyncMode.Visible = True
            Btn_F_HubPC_CasseAudio.Visible = False
            Btn_F_HubPC_SLED.Visible = True

            La_Ventole.Visible = True
            La_SyncMode.Visible = True
            La_CasseAudio.Visible = False
            La_Dissipatore.Visible = False
            La_GPU.Visible = True
            La_SLED.Visible = True
            La_Ventole.Visible = True

        ElseIf F_Avvio.DatiRX_0(3) = "5" Then
            Btn_F_HubPC_Ventole.Visible = True
            Btn_F_HubPC_Dissipatore.Visible = True
            Btn_F_HubPC_GPU.Visible = True
            Btn_Hub_SyncMode.Visible = True
            Btn_F_HubPC_CasseAudio.Visible = False
            Btn_F_HubPC_SLED.Visible = True

            La_Ventole.Visible = True
            La_SyncMode.Visible = True
            La_CasseAudio.Visible = False
            La_Dissipatore.Visible = True
            La_GPU.Visible = True
            La_SLED.Visible = True
            La_Ventole.Visible = True
        End If
    End Sub


    ' Btn Sync Mode Color All
    Private Sub Btn_Hub_SyncMode_Click(sender As Object, e As EventArgs) Handles Btn_Hub_SyncMode.Click
        F_Avvio.Data1 = 0
        If F_Avvio.Data1 = 0 And F_Avvio.DatiRX_7(0) <> 0 Then

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
                F_Avvio.Data5 = F_HubPC_Ventole.S_Fan_All
            End If
        End If
    End Sub


    Private Sub Btn_Hub_SyncMode_MouseHover(sender As Object, e As EventArgs) Handles Btn_Hub_SyncMode.MouseHover
        F_Home.ToolTip1.SetToolTip(Btn_Hub_SyncMode, "Colore " & F_Hub_PC.H_SyncMode & "
Luminosità " & Int(F_Hub_PC.V_SyncMode / 2.55) & "%" & "
Velocità " & Int(F_HubPC_Ventole.S_Fan_All / 2.55) & "%")
    End Sub





    Dim SettAllVentole As Boolean = False

    Private Sub Btn_F_HubPC_Ventole_Click(sender As Object, e As EventArgs) Handles Btn_F_HubPC_Ventole.Click
        F_Hub_PC.SwitchPannelHUB(F_HubPC_Ventole)
        FanMenù = "Hub PC Ventole"
        'Info Schermata
        F_Home.LabelFinestraID.Text = "Finestra di controllo " & FanMenù
        F_Hub_PC.BtnFan_GUI.Visible = True
        'SettAllVentole = True
        'LoopAutoSetColor.Start()
        ''F_Avvio.Data1 = 1
        'If F_Avvio.Data1 = 1 And F_Avvio.DatiRX_7(0) <> 1 Then
        '    F_Avvio.Data3 = F_Hub_PC.H_Fan1
        '    F_Avvio.Data4 = F_Hub_PC.S_Fan1
        '    F_Avvio.Data2 = F_Hub_PC.V_Fan1
        '    '   F_Hub_PC.BtnOFF_Animation()
        'ElseIf F_Avvio.Data1 = 1 And F_Avvio.DatiRX_7(0) = 1 Then
        '    F_Hub_PC.SwitchPannelHUB(F_HubPC_Ventole)
        'End If

        If F_Avvio.Data1 = 0 Or F_Avvio.Data1 > 4 Then
            F_HubPC_Ventole.IconaFan1_Click(sender, e)
        End If
    End Sub


    'Dim C As Integer = 1
    'Private Sub LoopAutoSetColor_Tick(sender As Object, e As EventArgs) Handles LoopAutoSetColor.Tick
    '    F_Home.LabelFinestraID.Text = C


    '    F_Avvio.Data1 = C

    '        F_Avvio.Data3 = F_Hub_PC.Colore_Giallo_HSV
    '        C = C + 1


    '    If C > 4 Then
    '        LoopAutoSetColor.Stop()
    '    End If

    'End Sub











    Private Sub Btn_F_HubPC_GPU_Click(sender As Object, e As EventArgs) Handles Btn_F_HubPC_GPU.Click
        F_Avvio.Data1 = 8
        If F_Avvio.Data1 = 8 And F_Avvio.DatiRX_7(0) <> 8 Then
            F_Avvio.Data3 = F_Hub_PC.H_GPU
            F_Avvio.Data4 = F_Hub_PC.S_GPU
            F_Avvio.Data2 = F_Hub_PC.V_GPU
            F_Hub_PC.BtnOFF_Animation()
        ElseIf F_Avvio.Data1 = 8 And F_Avvio.DatiRX_7(0) = 8 Then
            F_Hub_PC.SwitchPannelHUB(F_HubPC_GPU_SLED)
            FanMenù = "Hub PC GPU, Strisca LED"
            'Info Schermata
            F_Home.LabelFinestraID.Text = "Finestra di controllo " & FanMenù
            F_Hub_PC.BtnFan_GUI.Visible = True
        End If
    End Sub
    Private Sub Btn_F_HubPC_GPU_MouseHover(sender As Object, e As EventArgs) Handles Btn_F_HubPC_GPU.MouseHover
        F_Home.ToolTip1.SetToolTip(Btn_F_HubPC_GPU, "Colore " & F_Hub_PC.H_GPU & "
Luminosità " & Int(F_Hub_PC.V_GPU / 2.55) & "%" & "
Velocità Null")
    End Sub



    Private Sub Btn_F_HubPC_SLED_Click(sender As Object, e As EventArgs) Handles Btn_F_HubPC_SLED.Click
        F_Avvio.Data1 = 9
        If F_Avvio.Data1 = 9 And F_Avvio.DatiRX_7(0) <> 9 Then
            F_Avvio.Data3 = F_Hub_PC.H_SLED
            F_Avvio.Data4 = F_Hub_PC.S_SLED
            F_Avvio.Data2 = F_Hub_PC.V_SLED
            F_Hub_PC.BtnOFF_Animation()
        ElseIf F_Avvio.Data1 = 9 And F_Avvio.DatiRX_7(0) = 9 Then
            F_Hub_PC.SwitchPannelHUB(F_HubPC_GPU_SLED)
            FanMenù = "Hub PC GPU, Strisca LED"
            'Info Schermata
            F_Home.LabelFinestraID.Text = "Finestra di controllo " & FanMenù
            F_Hub_PC.BtnFan_GUI.Visible = True
        End If
    End Sub
    Private Sub Btn_F_HubPC_SLED_MouseHover(sender As Object, e As EventArgs) Handles Btn_F_HubPC_SLED.MouseHover
        F_Home.ToolTip1.SetToolTip(Btn_F_HubPC_SLED, "Colore " & F_Hub_PC.H_SLED & "
Luminosità " & Int(F_Hub_PC.V_SLED / 2.55) & "%")
    End Sub



    Private Sub Btn_F_HubPC_Dissipatore_Click(sender As Object, e As EventArgs) Handles Btn_F_HubPC_Dissipatore.Click
        'F_Avvio.Data1 = 7
        'If F_Avvio.Data1 = 7 And F_Avvio.DatiRX_7(0) <> 7 Then
        '    If F_Avvio.Data1 = 7 Then
        '        F_Avvio.Data3 = F_Hub_PC.H_CPU_OP
        '        F_Avvio.Data4 = F_Hub_PC.S_CPU_OP
        '        F_Avvio.Data2 = F_Hub_PC.V_CPU_OP
        '        F_Hub_PC.BtnOFF_Animation()
        '    End If
        'ElseIf F_Avvio.Data1 = 7 And F_Avvio.DatiRX_7(0) = 7 Then
        F_Hub_PC.SwitchPannelHUB(F_HubPC_Dissipatore240)
        FanMenù = "Hub PC Dissipatore 240"
        'Info Schermata
        F_Home.LabelFinestraID.Text = "Finestra di controllo " & FanMenù
        F_Hub_PC.BtnFan_GUI.Visible = True
        'End If


        If F_Avvio.Data1 < 5 Or F_Avvio.Data1 > 7 Then
            F_HubPC_Dissipatore240.Btn_CPU_LED_Click(sender, e)
        End If
    End Sub

    Private Sub Btn_F_HubPC_CasseAudio_Click(sender As Object, e As EventArgs) Handles Btn_F_HubPC_CasseAudio.Click
        F_Hub_PC.SwitchPannelHUB(F_HubPC_CasseAudio)
        FanMenù = "Hub PC Casse Audio, Strisca LED Esterna"
        'Info Schermata
        F_Home.LabelFinestraID.Text = "Finestra di controllo " & FanMenù
        F_Hub_PC.BtnFan_GUI.Visible = True

        If F_Avvio.Data1 < 10 Or F_Avvio.Data1 > 12 Then
            F_HubPC_CasseAudio.Btn_CassaAudio_D_Click(sender, e)
        End If
    End Sub








    Public Sub Color_Set_Home_IMG()
        'Imposta il colore selezionato alle icone del dispositivo selezionato
        Dim Colore As Integer() = {F_Hub_PC.R, F_Hub_PC.G, F_Hub_PC.B}

        Dim Colore_Salvati_Rosso As Integer() = {F_Hub_PC.R_SyncMode, F_Hub_PC.R_Fan1, F_Hub_PC.R_Fan2, F_Hub_PC.R_Fan3, F_Hub_PC.R_Fan4, F_Hub_PC.R_Fan_CPU_OP_01, F_Hub_PC.R_Fan_CPU_OP_02, F_Hub_PC.R_CPU_OP, F_Hub_PC.R_GPU, F_Hub_PC.R_SLED, F_Hub_PC.R_Cassa_Audio_S, F_Hub_PC.R_Cassa_Audio_D, F_Hub_PC.R_Strip_LED}
        Dim Colore_Salvati_Verde As Integer() = {F_Hub_PC.G_SyncMode, F_Hub_PC.G_Fan1, F_Hub_PC.G_Fan2, F_Hub_PC.G_Fan3, F_Hub_PC.G_Fan4, F_Hub_PC.G_Fan_CPU_OP_01, F_Hub_PC.G_Fan_CPU_OP_02, F_Hub_PC.G_CPU_OP, F_Hub_PC.G_GPU, F_Hub_PC.G_SLED, F_Hub_PC.G_Cassa_Audio_S, F_Hub_PC.G_Cassa_Audio_D, F_Hub_PC.G_Strip_LED}
        Dim Colore_Salvati_Blu As Integer() = {F_Hub_PC.B_SyncMode, F_Hub_PC.B_Fan1, F_Hub_PC.B_Fan2, F_Hub_PC.B_Fan3, F_Hub_PC.B_Fan4, F_Hub_PC.B_Fan_CPU_OP_01, F_Hub_PC.B_Fan_CPU_OP_02, F_Hub_PC.B_CPU_OP, F_Hub_PC.B_GPU, F_Hub_PC.B_SLED, F_Hub_PC.B_Cassa_Audio_S, F_Hub_PC.B_Cassa_Audio_D, F_Hub_PC.B_Strip_LED}

        If F_Avvio.DatiRX_7(0) = 0 And F_Avvio.DatiRX_5(0) <= F_Hub_PC.Hue_Max Then
            Btn_Hub_SyncMode.BackColor = Color.FromArgb(Colore(0), Colore(1), Colore(2))
            Btn_F_HubPC_CasseAudio.BackColor = Color.FromArgb(Colore(0), Colore(1), Colore(2))
            Btn_F_HubPC_SLED.BackColor = Color.FromArgb(Colore(0), Colore(1), Colore(2))
            Btn_F_HubPC_GPU.BackColor = Color.FromArgb(Colore(0), Colore(1), Colore(2))
            Btn_F_HubPC_Ventole.BackColor = Color.FromArgb(Colore(0), Colore(1), Colore(2))
            Btn_F_HubPC_Dissipatore.BackColor = Color.FromArgb(Colore(0), Colore(1), Colore(2))

        ElseIf F_Avvio.DatiRX_7(0) <> 0 Then
            Dim n As Integer
            For n = 0 To 12 'F_Avvio.DatiRX_5.Length - 1
                Select Case n
                    Case = 0

                    Case = 1
                        Btn_F_HubPC_Ventole.BackColor = Color.FromArgb(Colore_Salvati_Rosso(n), Colore_Salvati_Verde(n), Colore_Salvati_Blu(n))
                    Case = 2
                        'Btn_F_HubPC_Ventole.BackColor = Color.FromArgb(Colore_Salvati_Rosso(n), Colore_Salvati_Verde(n), Colore_Salvati_Blu(n))
                    Case = 3
                        'Btn_F_HubPC_Ventole.BackColor = Color.FromArgb(Colore_Salvati_Rosso(n), Colore_Salvati_Verde(n), Colore_Salvati_Blu(n))
                    Case = 4
                        'Btn_F_HubPC_Ventole.BackColor = Color.FromArgb(Colore_Salvati_Rosso(n), Colore_Salvati_Verde(n), Colore_Salvati_Blu(n))


                    Case = 5
                        Btn_F_HubPC_Dissipatore.BackColor = Color.FromArgb(Colore_Salvati_Rosso(n), Colore_Salvati_Verde(n), Colore_Salvati_Blu(n))
                        '        F_HubPC_Dissipatore240.Btn_FanCPU_LED01.BackColor = Color.FromArgb(R, G, B)
                        '        'F_HubPC_Dissipatore240.IconaStatoFan_Menù_3.BackColor = Color.FromArgb(R, G, B)
                    Case = 6
                        'Btn_F_HubPC_Dissipatore.BackColor = Color.FromArgb(Colore_Salvati_Rosso(n), Colore_Salvati_Verde(n), Colore_Salvati_Blu(n))
                        '        F_HubPC_Dissipatore240.Btn_FanCPU_LED02.BackColor = Color.FromArgb(R, G, B)
                        '        'F_HubPC_Dissipatore240.IconaStatoFan_Menù_3.BackColor = Color.FromArgb(R, G, B)
                    Case = 7
                        ' Btn_F_HubPC_Dissipatore.BackColor = Color.FromArgb(Colore_Salvati_Rosso(n), Colore_Salvati_Verde(n), Colore_Salvati_Blu(n))
                        '        F_HubPC_Dissipatore240.Btn_PompCPU_LED.BackColor = Color.FromArgb(R, G, B)
                        '        'F_HubPC_Dissipatore240.IconaStatoFan_Menù_3.BackColor = Color.FromArgb(R, G, B)


                    Case = 8
                        Btn_F_HubPC_GPU.BackColor = Color.FromArgb(Colore_Salvati_Rosso(n), Colore_Salvati_Verde(n), Colore_Salvati_Blu(n))
                       ' F_HubPC_GPU_SLED.IconaStatoFan_Menù_2.BackColor = Color.FromArgb(Colore_Salvati_Rosso(n), Colore_Salvati_Verde(n), Colore_Salvati_Blu(n))
                    Case = 9
                        Btn_F_HubPC_SLED.BackColor = Color.FromArgb(Colore_Salvati_Rosso(n), Colore_Salvati_Verde(n), Colore_Salvati_Blu(n))
                        'F_HubPC_GPU_SLED.IconaStatoFan_Menù_2.BackColor = Color.FromArgb(Colore_Salvati_Rosso(n), Colore_Salvati_Verde(n), Colore_Salvati_Blu(n))


                    Case = 10
                        Btn_F_HubPC_CasseAudio.BackColor = Color.FromArgb(Colore_Salvati_Rosso(n), Colore_Salvati_Verde(n), Colore_Salvati_Blu(n))
                        '        F_HubPC_CasseAudio.Btn_CassaAudio_S.BackColor = Color.FromArgb(R, G, B)
                        '       ' F_HubPC_CasseAudio.Icona_CassaAudio_S.BackColor = Color.FromArgb(R, G, B)
                    Case = 11
                        'Btn_F_HubPC_CasseAudio.BackColor = Color.FromArgb(Colore_Salvati_Rosso(n), Colore_Salvati_Verde(n), Colore_Salvati_Blu(n))
                        '        F_HubPC_CasseAudio.Btn_CassaAudio_D.BackColor = Color.FromArgb(R, G, B)
                        '        F_HubPC_CasseAudio.Icona_CassaAudio_D.BackColor = Color.FromArgb(R, G, B)
                    Case = 12
                        'Btn_F_HubPC_CasseAudio.BackColor = Color.FromArgb(Colore_Salvati_Rosso(n), Colore_Salvati_Verde(n), Colore_Salvati_Blu(n))
                        '        F_HubPC_CasseAudio.Btn_StripLED.BackColor = Color.FromArgb(R, G, B)
                        '        'F_HubPC_CasseAudio.Icona_StripLED.BackColor = Color.FromArgb(R, G, B)
                End Select
            Next n
        End If


    End Sub

    Private Sub LoopAutoSetColor_Tick(sender As Object, e As EventArgs) Handles LoopAutoSetColor.Tick

        If F_Avvio.DatiRX_7(0) = 0 And F_Avvio.DatiRX_5(0) > 512 Then

            For x As Integer = 0 To 512
                'F_Hub_PC.H = x
                'F_Hub_PC.HSV_to_RGB()
                'Color_Set_Home_IMG()
            Next

        End If
    End Sub
End Class