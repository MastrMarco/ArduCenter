Public Class F_Impostazioni_HUB_Fan
    Private Sub F_Impostazioni_HUB_Fan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Dim PreSetROM As String
    Dim PreSetPL As String
    Dim PreSetPLs As String
    Dim PreSetPHUB As String
    Dim PreSetPHUBs As String



    'Dim RX_PC_ROM_Data As String
    'Dim RX_PC_PowerLimit_Data As String
    Dim StatoTempSens As Integer = 0
    Dim StatoTensione As Integer = 0
    Dim StatoPowerLimit As Integer = 0
    Public Sub DataImpostazioni()
        'EEPROM
        If F_Avvio.DatiRX_2(0) = 0 And F_Avvio.DatiRX_2(0) <> PreSetROM Then
            BtnROM.BackgroundImage = My.Resources.btn_Swich
            PreSetROM = F_Avvio.DatiRX_2(0)
        ElseIf F_Avvio.DatiRX_2(0) = 1 And F_Avvio.DatiRX_2(0) <> PreSetROM Then
            BtnROM.BackgroundImage = My.Resources.btn_SwichON
            PreSetROM = F_Avvio.DatiRX_2(0)
        ElseIf F_Avvio.DatiRX_2(0) = 2 And F_Avvio.DatiRX_2(0) <> PreSetROM Then
            BtnROM.BackgroundImage = My.Resources.btn_Swich
            PreSetROM = F_Avvio.DatiRX_2(0)
        End If



        'EN_OV Protezione Tensione
        If F_Avvio.DatiRX_2(1) = 0 And F_Avvio.DatiRX_2(1) <> PreSetPHUB Then
            BtnProtezioneHUB.BackgroundImage = My.Resources.btn_Swich
            PreSetPHUB = F_Avvio.DatiRX_2(1)
        ElseIf F_Avvio.DatiRX_2(1) = 1 And F_Avvio.DatiRX_2(1) <> PreSetPHUB Then
            BtnProtezioneHUB.BackgroundImage = My.Resources.btn_SwichON
            PreSetPHUB = F_Avvio.DatiRX_2(1)
        End If
        If F_Avvio.DatiRX_1(3) = 0 And F_Avvio.DatiRX_1(3) <> PreSetPHUBs Then
            LabelPD.ForeColor = Color.White
            PreSetPHUBs = F_Avvio.DatiRX_1(3)
        ElseIf F_Avvio.DatiRX_1(3) = 1 And F_Avvio.DatiRX_1(3) <> PreSetPHUBs Then
            LabelPD.ForeColor = Color.Red
            PreSetPHUBs = F_Avvio.DatiRX_1(3)
        End If



        'PowerLimitLED Protezione LED Tensione
        If F_Avvio.DatiRX_2(2) = 0 And F_Avvio.DatiRX_2(2) <> PreSetPL Then
            BtnProtezioneLED.BackgroundImage = My.Resources.btn_Swich
            PreSetPL = F_Avvio.DatiRX_2(2)
        ElseIf F_Avvio.DatiRX_2(2) = 1 And F_Avvio.DatiRX_2(2) <> PreSetPL Then
            BtnProtezioneLED.BackgroundImage = My.Resources.btn_SwichON
            PreSetPL = F_Avvio.DatiRX_2(2)
        End If
        If F_Avvio.DatiRX_1(4) = 0 And F_Avvio.DatiRX_1(4) <> PreSetPLs Then
            LabelPL.ForeColor = Color.White
            PreSetPLs = F_Avvio.DatiRX_1(4)
            F_Hub_PC.LabelLuminosità.ForeColor = Color.White
            F_HubPC_Ventole.LaLuminosità.ForeColor = Color.FromArgb(0, 140, 149)
            F_HubPC_GPU_SLED.LaLuminosità.ForeColor = Color.FromArgb(0, 140, 149)
            F_HubPC_Dissipatore240.LaLuminosità.ForeColor = Color.FromArgb(0, 140, 149)
            F_HubPC_CasseAudio.LaLuminosità.ForeColor = Color.FromArgb(0, 140, 149)
        ElseIf F_Avvio.DatiRX_1(4) = 1 And F_Avvio.DatiRX_1(4) <> PreSetPLs Then
            LabelPL.ForeColor = Color.Red
            PreSetPLs = F_Avvio.DatiRX_1(4)
            F_Hub_PC.LabelLuminosità.ForeColor = Color.Red
            F_HubPC_Ventole.LaLuminosità.ForeColor = Color.Red
            F_HubPC_GPU_SLED.LaLuminosità.ForeColor = Color.Red
            F_HubPC_Dissipatore240.LaLuminosità.ForeColor = Color.Red
            F_HubPC_CasseAudio.LaLuminosità.ForeColor = Color.Red
        End If









        'If F_Avvio.DatiRX_0(1) = 3 Or F_Avvio.DatiRX_0(1) = 4 Then

        If F_Avvio.DatiRX_1(0) >= "10" And F_Avvio.DatiRX_1(0) <= "50" Then
            StatoTempSens = 1
        Else
            StatoTempSens = 0
        End If

        If F_Avvio.DatiRX_1(1) >= "4.5" And F_Avvio.DatiRX_1(1) <= "5.25" And F_Avvio.DatiRX_1(2) >= "11.5" And F_Avvio.DatiRX_1(2) <= "12.5" Then
            StatoTensione = 1
        Else
            StatoTensione = 0
        End If


        If F_Avvio.DatiRX_1(4) = 1 Then
            StatoPowerLimit = 0
        Else
            StatoPowerLimit = 1
        End If

        If F_Avvio.DatiRX_2(0) = 1 Then
            F_Connessione.PictureBoxER_ROM.Visible = False
        ElseIf F_Avvio.DatiRX_2(0) = 0 Then
            F_Connessione.PictureBoxER_ROM.Visible = True
        End If


        If StatoTempSens = 1 And StatoTensione = 1 And StatoPowerLimit = 1 Then
            InStato.Text = "Buono"
            InStato.ForeColor = Color.FromArgb(128, 255, 128)

            F_Connessione.PictureBoxER_Power.Visible = False
            F_Connessione.PictureBoxER_LED_Power.Visible = False
        End If

        If StatoTempSens = 0 And StatoTensione = 1 And StatoPowerLimit = 1 Then
            InStato.Text = "ErTemp"
            InStato.ForeColor = Color.Orange

            F_Connessione.PictureBoxER_Power.Visible = False
            F_Connessione.PictureBoxER_LED_Power.Visible = False
        End If

        If StatoTempSens = 1 And StatoTensione = 0 And StatoPowerLimit = 1 Then
            InStato.Text = "ErVolt"
            InStato.ForeColor = Color.Orange

            F_Connessione.PictureBoxER_Power.Visible = True
            F_Connessione.PictureBoxER_LED_Power.Visible = False
        End If

        If StatoTempSens = 1 And StatoTensione = 1 And StatoPowerLimit = 0 Then
            InStato.Text = "LED Lim"
            InStato.ForeColor = Color.Orange

            F_Connessione.PictureBoxER_Power.Visible = False
            F_Connessione.PictureBoxER_LED_Power.Visible = True
        End If

        If StatoTempSens = 0 And StatoTensione = 0 And StatoPowerLimit = 1 Then
            InStato.Text = "ErT-V"
            InStato.ForeColor = Color.Red

            F_Connessione.PictureBoxER_Power.Visible = True
            F_Connessione.PictureBoxER_LED_Power.Visible = False
        End If

        If StatoTempSens = 1 And StatoTensione = 0 And StatoPowerLimit = 0 Then
            InStato.Text = "ErV-Power"
            InStato.ForeColor = Color.Red

            F_Connessione.PictureBoxER_Power.Visible = True
            F_Connessione.PictureBoxER_LED_Power.Visible = True
        End If

        If StatoTempSens = 0 And StatoTensione = 1 And StatoPowerLimit = 0 Then
            InStato.Text = "ErT-Power"
            InStato.ForeColor = Color.Red

            F_Connessione.PictureBoxER_Power.Visible = False
            F_Connessione.PictureBoxER_LED_Power.Visible = True
        End If

        If StatoTempSens = 0 And StatoTensione = 0 And StatoPowerLimit = 0 Then
            InStato.Text = "Blocco"
            InStato.ForeColor = Color.Red

            F_Connessione.PictureBoxER_Power.Visible = True
            F_Connessione.PictureBoxER_LED_Power.Visible = True
        End If
        F_Connessione.LaErrorDispositivo.Text = InStato.Text
        F_Connessione.LaErrorDispositivo.ForeColor = InStato.ForeColor

        'Else
        'InStato.Text = "NS"
        'InStato.ForeColor = Color.Gray
        'End If


    End Sub

    Private Sub BtnROM_Click(sender As Object, e As EventArgs) Handles BtnROM.Click
        If F_Avvio.DatiRX_2(0) = 0 Then
            F_Avvio.Data10 = 1
        ElseIf F_Avvio.DatiRX_2(0) = 1 Then
            F_Avvio.Data10 = 0
        ElseIf F_Avvio.DatiRX_2(0) = 2 Then
            F_Avvio.Data10 = 1
        End If
    End Sub


    Private Sub BtnProtezioneHUB_Click(sender As Object, e As EventArgs) Handles BtnProtezioneHUB.Click

        If F_Avvio.DatiRX_2(1) = 0 Then
            F_Avvio.Data11 = 1
            'F_Connessione.Btn_Riavvio_Click(sender, e)
        ElseIf F_Avvio.DatiRX_2(1) = 1 Then
            F_Avvio.Data11 = 0
            'F_Connessione.Btn_Riavvio_Click(sender, e)
        End If

    End Sub


    Private Sub BtnProtezioneLED_Click(sender As Object, e As EventArgs) Handles BtnProtezioneLED.Click
        If F_Avvio.DatiRX_2(2) = 0 Then
            F_Avvio.Data12 = 1
            'F_Connessione.Btn_Riavvio_Click(sender, e)
        ElseIf F_Avvio.DatiRX_2(2) = 1 Then
            F_Avvio.Data12 = 0
            'F_Connessione.Btn_Riavvio_Click(sender, e)
        End If
    End Sub



    Private Sub BtnRipristino_Click(sender As Object, e As EventArgs) Handles BtnRipristino.Click
        'F_Avvio.ErrorMod = 102
        'F_Avvisi.LabelID_Error.Text = "Error Code " & F_Avvio.ErrorMod
        'F_Avvisi.AvvisoErrore()
        F_Avvio.FunzioneNull()
    End Sub

    Public Sub InStato_Click(sender As Object, e As EventArgs) Handles InStato.Click

        If InStato.Text = "Buono" Then
            F_Avvio.ErrorMod = 31
            F_Avvisi.AvvisoErrore()
        ElseIf InStato.Text = "ErTemp" Then
            F_Avvio.ErrorMod = 32
            F_Avvisi.AvvisoErrore()
        ElseIf InStato.Text = "ErVolt" Then
            F_Avvio.ErrorMod = 33
            F_Avvisi.AvvisoErrore()
        ElseIf InStato.Text = "LED Lim" Then
            F_Avvio.ErrorMod = 34
            F_Avvisi.AvvisoErrore()
        ElseIf InStato.Text = "ErT-V" Then
            F_Avvio.ErrorMod = 35
            F_Avvisi.AvvisoErrore()
        ElseIf InStato.Text = "ErV-Power" Then
            F_Avvio.ErrorMod = 36
            F_Avvisi.AvvisoErrore()
        ElseIf InStato.Text = "ErT-Power" Then
            F_Avvio.ErrorMod = 37
            F_Avvisi.AvvisoErrore()
        ElseIf InStato.Text = "Blocco" Then

        ElseIf InStato.Text = "NS" Then
            F_Avvio.FunzioneNull()
        End If

        F_Avvisi.LabelID_Error.Text = "Avviso Code " & F_Avvio.ErrorMod
    End Sub

    Private Sub BtnDebugFan_Click(sender As Object, e As EventArgs) Handles BtnDebugFan.Click
        F_Avvio.FunzioneNull()
    End Sub
End Class