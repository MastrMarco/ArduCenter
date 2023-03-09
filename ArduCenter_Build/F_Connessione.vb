Public Class F_Connessione
    Private Sub F_Connessione_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If My.Settings.AutoConnesione = "No" Then
            PreCaricamentroCOM_Port()
            BtnAutoConnessione.BackgroundImage = My.Resources.btn_Swich
            LabelConnessioneAuto.Text = "Disattivo"
        ElseIf My.Settings.AutoConnesione = "Si" Then
            PreCaricamentroCOM_Port()
            ConnessioneAutomatica()
            BtnAutoConnessione.BackgroundImage = My.Resources.btn_SwichON
            LabelConnessioneAuto.Text = "Attivo"
        End If



        If My.Settings.AutoForm_Pan = "No" Then
            BtnAuto_Form.BackgroundImage = My.Resources.btn_Swich
            LabelAutoForm.Text = "Disattivo"
        ElseIf My.Settings.AutoForm_Pan = "Si" Then
            BtnAuto_Form.BackgroundImage = My.Resources.btn_SwichON
            LabelAutoForm.Text = "Attivo"
        End If

    End Sub

    '//Funzione PreCaricamento lista Poerta COM
    Public Sub PreCaricamentroCOM_Port()
        '//Precaricamento delle porte COM qunado è disattivato il collegamento Automatico
        Try
            'If My.Settings.MemotizaImp = "No" Then
            S_COM.Items.Clear()
            S_COM.Items.AddRange(IO.Ports.SerialPort.GetPortNames())
            S_COM.SelectedIndex = 0
            'End If
        Catch ex As Exception
            '//Modalità Errore COM, si attiva quando non rileva Porte COM
            S_COM.Items.Clear()
            S_COM.Items.Add("Aggiorna")
            S_COM.SelectedIndex = 0

            F_Avvio.ErrorMod = 1
            F_Avvisi.LabelID_Error.Text = "Error Code " & F_Avvio.ErrorMod
            F_Avvisi.AvvisoErrore()
            'GUI_Error.ErrorSoftMod()
        End Try
    End Sub

    Private Sub BtnConnettiDisconnetti_Click(sender As Object, e As EventArgs) Handles BtnConnettiDisconnetti.Click
        Try
            If F_Avvio.SerialPortArduino.IsOpen = False Then
                ConnessioneAutomatica()
            ElseIf F_Avvio.SerialPortArduino.IsOpen = True Then
                Disconnessione()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub ConnessioneAutomatica()
        Try
            If My.Settings.AutoConnesione = "Si" Then
                F_Avvio.SerialPortArduino.PortName = My.Settings.SerialCOM
            ElseIf My.Settings.AutoConnesione = "No" Then
                F_Avvio.SerialPortArduino.PortName = S_COM.Text
            End If

            F_Avvio.SerialPortArduino.BaudRate = (115200)
            F_Avvio.SerialPortArduino.Open()
            F_Avvio.TimerSerialPort_TX_RX.Enabled = True
            F_Avvio.BackgroundWorkerSerialPort.RunWorkerAsync()

            LabelTX_RX.Font = New Font("Verdana", 8, FontStyle.Bold)
        Catch ex As Exception
            If My.Settings.AutoConnesione = "Si" Then
                F_Avvio.ErrorMod = 2
            ElseIf My.Settings.AutoConnesione = "No" Then
                F_Avvio.ErrorMod = 8
            End If
            F_Avvisi.LabelID_Error.Text = "Error Code " & F_Avvio.ErrorMod
            F_Avvisi.AvvisoErrore()
        End Try

    End Sub

    Public Sub Disconnessione()
        F_Avvio.TimerSerialPort_TX_RX.Enabled = False
        F_Avvio.SerialPortArduino.Close()
        BtnConnettiDisconnetti.BackgroundImage = My.Resources.BtnConnettiDisconnetti_2_0
        S_COM.Enabled = True

        LaStato.ForeColor = Color.FromArgb(149, 9, 0)
        LaStato.Text = "Disconnesso"
        LaNomePCB.Text = "   ----------"
        LaSoc.Text = "    ----------"
        LaBoot.Text = "     ----------"
        LaFirmware.Text = "-----"

        LabelTX_RX.Location = New Point(307, 310)
        LabelTX_RX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        LabelTX_RX.Font = New Font("Verdana", 14, FontStyle.Bold)
        LabelTX_RX.Text = "Nessun Dato Ricevuto"
        LabelSoftArduino.Text = "Versione Firmware di  Arduino :   V ----"
        LabelSoftArduCenter.Text = "Versione che supporta ArduCenter : V ----"
        LaProgetto.Text = "-------------------------"

        F_Avvio.Aggiorna = 1
        F_Avvio.VerificaSeriale = 1
        F_Avvio.DTX = 1
        F_Avvio.CaricaDati_Boot = 0

        My.Settings.AutoConnesione = "No"
        BtnAutoConnessione.BackgroundImage = My.Resources.btn_Swich
        'PictureFunzioni.BackgroundImage = My.Resources.Funzioni_Dispositivo_Null

        F_Avvio.DatiRicevuti = 0

        F_Home.BtnVentole.Enabled = False
        F_Home.BtnAudio.Enabled = False
        F_Hub_PC.BtnMenùEX.Visible = False

        LaErrorDispositivo.ForeColor = Color.DarkCyan
        LaErrorDispositivo.Text = "Errori HUB: -------"
        PictureBoxER_ROM.Visible = True
        PictureBoxER_Power.Visible = True
        PictureBoxER_LED_Power.Visible = True
    End Sub

    Private Sub BtnAutoConnessione_Click(sender As Object, e As EventArgs) Handles BtnAutoConnessione.Click
        Try
            If F_Avvio.SerialPortArduino.IsOpen = True Then
                If My.Settings.AutoConnesione = "No" Then
                    My.Settings.AutoConnesione = "Si"
                    My.Settings.SerialCOM = F_Avvio.SerialPortArduino.PortName
                    BtnAutoConnessione.BackgroundImage = My.Resources.btn_SwichON

                    LabelConnessioneAuto.Text = "Attivo"
                ElseIf My.Settings.AutoConnesione = "Si" Then
                    My.Settings.AutoConnesione = "No"
                    BtnAutoConnessione.BackgroundImage = My.Resources.btn_Swich

                    LabelConnessioneAuto.Text = "Disattivo"
                End If

            ElseIf F_Avvio.SerialPortArduino.IsOpen = False Then
                My.Settings.AutoConnesione = "No"
                BtnAutoConnessione.BackgroundImage = My.Resources.btn_Swich
                LabelConnessioneAuto.Text = "Disattivo"

                F_Avvio.ErrorMod = 101
                F_Avvisi.LabelID_Error.Text = "Error Code " & F_Avvio.ErrorMod
                F_Avvisi.AvvisoErrore()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public ViewSerial As Integer = 0
    Private Sub LabelRX_Click(sender As Object, e As EventArgs) Handles LabelRX.Click
        If F_Avvio.SerialPortArduino.IsOpen = True And ViewSerial <> 0 Then
            ' F_Avvio.AggiornaGUI()
            LabelTX_RX.TextAlign = System.Drawing.ContentAlignment.TopCenter
            LabelTX_RX.Location = New Point(307, 318)
            LabelTX_RX.Font = New Font("Verdana", 9, FontStyle.Bold)

            ViewSerial = 0
            LabelRX.ForeColor = Color.Gold
            LabelTX.ForeColor = Color.Silver
            'LabelTX_RX.Font = New Font("Verdana", 7.5, FontStyle.Bold)
            LabelDatiSeriali.Text = "Dati RX in Arrivo dalla Seriale"


        End If
    End Sub

    Private Sub LabelTX_Click(sender As Object, e As EventArgs) Handles LabelTX.Click
        If F_Avvio.SerialPortArduino.IsOpen = True And ViewSerial <> 1 Then
            'F_Avvio.AggiornaGUI()
            LabelTX_RX.TextAlign = System.Drawing.ContentAlignment.TopCenter
            LabelTX_RX.Location = New Point(307, 318)
            LabelTX_RX.Font = New Font("Verdana", 10, FontStyle.Bold)

            ViewSerial = 1
            LabelRX.ForeColor = Color.Silver
            LabelTX.ForeColor = Color.Gold
            'LabelTX_RX.Font = New Font("Verdana", 10, FontStyle.Bold)
            LabelDatiSeriali.Text = "Dati TX inviati dalla Seriale"


        End If
    End Sub


    Private Sub COM_MouseDown(sender As Object, e As MouseEventArgs) Handles S_COM.MouseDown
        PreCaricamentroCOM_Port()
    End Sub

    Private Sub BtnHardwareMonitor_Click(sender As Object, e As EventArgs) Handles BtnHardwareMonitor.Click
        F_Hub_PC.BtnTaskHardware_GUI_Click(sender, e)
    End Sub

    Private Sub BtnDataArduino_Click(sender As Object, e As EventArgs) Handles BtnDataArduino.Click
        If F_Avvio.SerialPortArduino.IsOpen = True Then
            F_Hub_PC.BtnSerialData_Click(sender, e)
        Else
            F_Avvio.ErrorMod = 101
            F_Avvisi.LabelID_Error.Text = "Error Code " & F_Avvio.ErrorMod
            F_Avvisi.AvvisoErrore()
        End If

    End Sub

    Private Sub BtnDataArduino_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnDataArduino.MouseMove
        If F_SerialCommand_Fan.CMD_Open = 0 Then
            BtnDataArduino.BackgroundImage = My.Resources.Incona_Comandi_FanON
        End If
    End Sub

    Private Sub BtnDataArduino_MouseLeave(sender As Object, e As EventArgs) Handles BtnDataArduino.MouseLeave
        If F_SerialCommand_Fan.CMD_Open = 0 Then
            BtnDataArduino.BackgroundImage = My.Resources.Incona_Comandi_Fan
        End If
    End Sub

    Private Sub BtnHardwareMonitor_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnHardwareMonitor.MouseMove
        If F_HardwareMonitor.HardwareOpern = 0 Then
            BtnHardwareMonitor.BackgroundImage = My.Resources.Icona_Parametri_FanON
        End If
    End Sub

    Private Sub BtnHardwareMonitor_MouseLeave(sender As Object, e As EventArgs) Handles BtnHardwareMonitor.MouseLeave
        If F_HardwareMonitor.HardwareOpern = 0 Then
            BtnHardwareMonitor.BackgroundImage = My.Resources.Icona_Parametri_Fan
        End If
    End Sub

    Private Sub BtnFile_Click(sender As Object, e As EventArgs) Handles BtnFile.Click
        Process.Start("explorer.exe", Application.StartupPath())
    End Sub

    Private Sub BtnFile_MouseLeave(sender As Object, e As EventArgs) Handles BtnFile.MouseLeave
        BtnFile.BackgroundImage = My.Resources.Icona_Cartella_1_1
    End Sub

    Private Sub BtnFile_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnFile.MouseMove
        BtnFile.BackgroundImage = My.Resources.Icona_Cartella_1_1_ON
    End Sub

    Private Sub BtnAuto_Form_Click(sender As Object, e As EventArgs) Handles BtnAuto_Form.Click

        If My.Settings.AutoForm_Pan = "No" Then

            BtnAuto_Form.BackgroundImage = My.Resources.btn_SwichON
            My.Settings.AutoForm_Pan = "Si"
            LabelAutoForm.Text = "Attivo"

        ElseIf My.Settings.AutoForm_Pan = "Si" Then

            BtnAuto_Form.BackgroundImage = My.Resources.btn_Swich
            My.Settings.AutoForm_Pan = "No"
            LabelAutoForm.Text = "Disattivo"

        End If
    End Sub

    Public Sub Btn_Riavvio_Click(sender As Object, e As EventArgs) Handles Btn_Riavvio.Click
        'F_Avvio.SerialPortArduino.RtsEnable = True
        'F_Avvio.SerialPortArduino.DtrEnable = True
        If F_Avvio.SerialPortArduino.IsOpen = True Then
            F_Avvio.ErrorMod = 10
            F_Avvisi.LabelID_Error.Text = "Avviso Code " & F_Avvio.ErrorMod
            F_Avvisi.AvvisoErrore()
        Else
            F_Avvio.ErrorMod = 1
            F_Avvisi.LabelID_Error.Text = "Avviso Code " & F_Avvio.ErrorMod
            F_Avvisi.AvvisoErrore()
        End If
    End Sub

    Private Sub LaErrorDispositivo_Click(sender As Object, e As EventArgs) Handles LaErrorDispositivo.Click
        F_Impostazioni_HUB_Fan.InStato_Click(sender, e)
    End Sub

    Private Sub PictureBoxER_ROM_Click(sender As Object, e As EventArgs) Handles PictureBoxER_ROM.Click
        F_Avvio.ErrorMod = 40
        F_Avvisi.LabelID_Error.Text = "Avviso Code " & F_Avvio.ErrorMod
        F_Avvisi.AvvisoErrore()
    End Sub

    Private Sub PictureBoxER_Power_Click(sender As Object, e As EventArgs) Handles PictureBoxER_Power.Click
        F_Avvio.ErrorMod = 41
        F_Avvisi.LabelID_Error.Text = "Avviso Code " & F_Avvio.ErrorMod
        F_Avvisi.AvvisoErrore()
    End Sub

    Private Sub PictureBoxER_LED_Power_Click(sender As Object, e As EventArgs) Handles PictureBoxER_LED_Power.Click
        F_Avvio.ErrorMod = 42
        F_Avvisi.LabelID_Error.Text = "Avviso Code " & F_Avvio.ErrorMod
        F_Avvisi.AvvisoErrore()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        F_Avvio.ErrorMod = 43
        F_Avvisi.LabelID_Error.Text = "Avviso Code " & F_Avvio.ErrorMod
        F_Avvisi.AvvisoErrore()
    End Sub
End Class