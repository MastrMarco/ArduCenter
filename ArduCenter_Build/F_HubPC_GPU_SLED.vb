Public Class F_HubPC_GPU_SLED
    Private Sub F_Fan_Menù_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Public Sub F_Fan_Men2()


    End Sub

    Private Sub BtnGPU_LED_Click(sender As Object, e As EventArgs) Handles BtnGPU_LED.Click

        F_Avvio.Data1 = 8

        'TitoloFan.ForeColor = Color.White

        'If F_Avvio.DatiRX_3(0) = 1 Then
        If F_Avvio.Data1 = 8 Then
            F_Avvio.Data3 = F_Hub_PC.H_GPU
            F_Avvio.Data4 = F_Hub_PC.S_GPU
            F_Avvio.Data2 = F_Hub_PC.V_GPU
            'F_Avvio.Data5 = S_GPU
        End If

        F_Hub_PC.BtnOFF_Animation()

        'If F_Avvio.DatiRX_6(6) <> F_Avvio.Data9 Then
        '    F_Avvio.Data9 = F_Avvio.DatiRX_6(6)
        'End If

    End Sub
    Private Sub BtnIMG_GPU_LED_MouseHover(sender As Object, e As EventArgs) Handles BtnIMG_GPU_LED.MouseHover
        F_Home.ToolTip1.SetToolTip(BtnIMG_GPU_LED, "Colore " & F_Hub_PC.H_GPU & "
Luminosità " & Int(F_Hub_PC.V_GPU / 2.55) & "%" & "
Velocità Null")
    End Sub





    Private Sub BtnStrip_LED_Click(sender As Object, e As EventArgs) Handles BtnStrip_LED.Click

        F_Avvio.Data1 = 9

        'TitoloFan.ForeColor = Color.White

        'If F_Avvio.DatiRX_3(0) = 1 Then
        If F_Avvio.Data1 = 9 Then
            F_Avvio.Data3 = F_Hub_PC.H_SLED
            F_Avvio.Data4 = F_Hub_PC.S_SLED
            F_Avvio.Data2 = F_Hub_PC.V_SLED
            'F_Avvio.Data5 = S_GPU
        End If

        F_Hub_PC.BtnOFF_Animation()

        'If F_Avvio.DatiRX_6(6) <> F_Avvio.Data9 Then
        '    F_Avvio.Data9 = F_Avvio.DatiRX_6(6)
        'End If

    End Sub
    Private Sub BtnIMG_Strip_LED_MouseHover(sender As Object, e As EventArgs) Handles BtnIMG_Strip_LED.MouseHover
        F_Home.ToolTip1.SetToolTip(BtnIMG_Strip_LED, "Colore " & F_Hub_PC.H_SLED & "
Luminosità " & Int(F_Hub_PC.V_SLED / 2.55) & "%")
    End Sub







    Private Sub BtnIMG_GPU_LED_Click(sender As Object, e As EventArgs) Handles BtnIMG_GPU_LED.Click
        BtnGPU_LED_Click(sender, e)
    End Sub

    Private Sub BtnIMG_Strip_LED_Click(sender As Object, e As EventArgs) Handles BtnIMG_Strip_LED.Click
        BtnStrip_LED_Click(sender, e)
    End Sub



    Public Sub Color_Set_GPU_SLED_IMG()
        'Imposta il colore selezionato alle icone del dispositivo selezionato
        Dim Colore As Integer() = {F_Hub_PC.R, F_Hub_PC.G, F_Hub_PC.B}
        Select Case F_Avvio.DatiRX_7(0)
            Case = 8
                BtnIMG_GPU_LED.BackColor = Color.FromArgb(Colore(0), Colore(1), Colore(2))
            Case = 9
                BtnIMG_Strip_LED.BackColor = Color.FromArgb(Colore(0), Colore(1), Colore(2))
        End Select
    End Sub


End Class