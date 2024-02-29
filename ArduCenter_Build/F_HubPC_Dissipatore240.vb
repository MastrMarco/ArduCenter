Public Class F_HubPC_Dissipatore240
    Private Sub F_Fan_Menù_3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LaN_MaderBoard.Text = "Nome Scheda Madre

 " & F_Avvio.Nome_Scheda_Madre

        LaN_CPU.Text = "Nome Proccessore

" & F_Avvio.Nome_CPU_All

        LaN_GPU.Text = "Nome Scheda Video

" & F_Avvio.Nome_GPU_All
    End Sub




    Public Sub Btn_CPU_LED_Click(sender As Object, e As EventArgs) Handles Btn_PompCPU_LED.Click
        If F_Avvio.Data10 <> 3 Then
            F_Avvio.Data1 = 7
            If F_Avvio.Data1 = 7 Then
                F_Avvio.Data3 = F_Hub_PC.H_CPU_OP
                F_Avvio.Data4 = F_Hub_PC.S_CPU_OP
                F_Avvio.Data2 = F_Hub_PC.V_CPU_OP
            End If
            F_Hub_PC.BtnOFF_Animation()
        End If
    End Sub
    Private Sub Btn_PompCPU_LED_MouseHover(sender As Object, e As EventArgs) Handles Btn_PompCPU_LED.MouseHover
        F_Home.ToolTip1.SetToolTip(Btn_PompCPU_LED, "Colore " & F_Hub_PC.H_CPU_OP & "
Luminosità " & Int(F_Hub_PC.V_CPU_OP / 2.55) & "%" & "
Velocità Null")
    End Sub

    Private Sub Btn_FanCPU_LED01_Click(sender As Object, e As EventArgs) Handles Btn_FanCPU_LED01.Click
        If F_Avvio.Data10 <> 3 Then
            F_Avvio.Data1 = 5
            If F_Avvio.Data1 = 5 Then
                F_Avvio.Data3 = F_Hub_PC.H_Fan_CPU_OP_01
                F_Avvio.Data4 = F_Hub_PC.S_Fan_CPU_OP_01
                F_Avvio.Data2 = F_Hub_PC.V_Fan_CPU_OP_01
            End If
            F_Hub_PC.BtnOFF_Animation()
        End If
    End Sub
    Private Sub Btn_FanCPU_LED01_MouseHover(sender As Object, e As EventArgs) Handles Btn_FanCPU_LED01.MouseHover
        F_Home.ToolTip1.SetToolTip(Btn_FanCPU_LED01, "Colore " & F_Hub_PC.H_Fan_CPU_OP_01 & "
Luminosità " & Int(F_Hub_PC.V_Fan_CPU_OP_01 / 2.55) & "%" & "
Velocità Null")
    End Sub

    Private Sub Btn_FanCPU_LED02_Click(sender As Object, e As EventArgs) Handles Btn_FanCPU_LED02.Click
        If F_Avvio.Data10 <> 3 Then
            F_Avvio.Data1 = 6
            If F_Avvio.Data1 = 6 Then
                F_Avvio.Data3 = F_Hub_PC.H_Fan_CPU_OP_02
                F_Avvio.Data4 = F_Hub_PC.S_Fan_CPU_OP_02
                F_Avvio.Data2 = F_Hub_PC.V_Fan_CPU_OP_02
            End If
            F_Hub_PC.BtnOFF_Animation()
        End If
    End Sub
    Private Sub Btn_FanCPU_LED02_MouseHover(sender As Object, e As EventArgs) Handles Btn_FanCPU_LED02.MouseHover
        F_Home.ToolTip1.SetToolTip(Btn_FanCPU_LED02, "Colore " & F_Hub_PC.H_Fan_CPU_OP_02 & "
Luminosità " & Int(F_Hub_PC.V_Fan_CPU_OP_02 / 2.55) & "%" & "
Velocità Null")
    End Sub

    Private Sub Btn_FanPO_1_Click(sender As Object, e As EventArgs) Handles Btn_FanCPU_1.Click
        Btn_FanCPU_LED01_Click(sender, e)
    End Sub
    Private Sub Btn_FanPO_2_Click(sender As Object, e As EventArgs) Handles Btn_FanCPU_2.Click
        Btn_FanCPU_LED02_Click(sender, e)
    End Sub
    Private Sub Btn_PompPO_Click(sender As Object, e As EventArgs) Handles Btn_PompCPU.Click
        Btn_CPU_LED_Click(sender, e)
    End Sub










    Private Sub LaSelezione_Click(sender As Object, e As EventArgs) Handles LaSelezione.Click

    End Sub

    Private Sub LaLuminosità_Click(sender As Object, e As EventArgs) Handles LaLuminosità.Click

    End Sub

    Private Sub LaColore_Click(sender As Object, e As EventArgs) Handles LaColore.Click

    End Sub

    Private Sub IconaStatoFan_Menù_3_MouseLeave(sender As Object, e As EventArgs) Handles IconaStatoFan_Menù_3.MouseLeave
        If F_Avvio.DatiRX_7(0) = 0 Then

            Select Case F_Avvio.DatiRX_5(F_Avvio.DatiRX_7(0))

                Case = F_Hub_PC.Animazione_RGB_Discontinuo
                    IconaStatoFan_Menù_3.BackgroundImage = My.Resources.Icona_DeepCool_RGB_Discontinuo_v1_3
                Case = F_Hub_PC.Animazione_RGB_Transiszione
                    IconaStatoFan_Menù_3.BackgroundImage = My.Resources.Icona_DeepCool_RGB_Transizione_v1_3
                Case = F_Hub_PC.Animazione_RGB_Rainbow
                    IconaStatoFan_Menù_3.BackgroundImage = My.Resources.Icona_DeepCool_RGB_RainBow_v1_3
                Case = F_Hub_PC.Animazione_RGB_Musica
                    IconaStatoFan_Menù_3.BackgroundImage = My.Resources.Icona_DeepCool_RGB_Musica_v1_3
                Case = F_Hub_PC.Animazione_RGB_Tepmeratura
                'IconaStatoFan_Menù_3.BackgroundImage = My.Resources.
                Case <= F_Hub_PC.Hue_Max
                    IconaStatoFan_Menù_3.BackgroundImage = My.Resources.Icona_DeepCool_HSV_RGB_v1_3
            End Select

        End If
    End Sub

    Private Sub IconaStatoFan_Menù_3_MouseMove(sender As Object, e As MouseEventArgs) Handles IconaStatoFan_Menù_3.MouseMove

        If F_Avvio.DatiRX_7(0) = 0 Then

            Select Case F_Avvio.DatiRX_5(F_Avvio.DatiRX_7(0))

                Case = F_Hub_PC.Animazione_RGB_Discontinuo
                    IconaStatoFan_Menù_3.BackgroundImage = My.Resources.Icona_Fan_Dissipatore_RGB_Discontinuo_v1_3
                Case = F_Hub_PC.Animazione_RGB_Transiszione
                    IconaStatoFan_Menù_3.BackgroundImage = My.Resources.Icona_Fan_Dissipatore_RGB_Transizione_v1_3
                Case = F_Hub_PC.Animazione_RGB_Rainbow
                    IconaStatoFan_Menù_3.BackgroundImage = My.Resources.Icona_Fan_Dissipatore_RGB_RainBow_v1_3
                Case = F_Hub_PC.Animazione_RGB_Musica
                    IconaStatoFan_Menù_3.BackgroundImage = My.Resources.Icona_Fan_Dissipatore_RGB_Musica_v1_3
                Case = F_Hub_PC.Animazione_RGB_Tepmeratura
                'IconaStatoFan_Menù_3.BackgroundImage = My.Resources.
                Case <= F_Hub_PC.Hue_Max
                    IconaStatoFan_Menù_3.BackgroundImage = My.Resources.Icona_FanPO_1_3_
            End Select

        End If
    End Sub
End Class