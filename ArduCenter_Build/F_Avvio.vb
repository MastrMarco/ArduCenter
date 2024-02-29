'Imports System.IO

Public Class F_Avvio
    Public Classe_Impostazioni_HUB_LED As New C_Impostazioni_LED_HUB
    ' Public CartellaArduCenter As String = Path.Combine(Application.StartupPath)
    Public ErrorMod = 0     '//Indica il tipo di errore Errore

    'Nummero Versione Arduino
    Public ReadOnly InfoSoft_HOME As String = "By " & vbCrLf & "MastrMarco" & vbCrLf & "Beta 48"

    Private ReadOnly StatoSoft As String = "Versione Prova"
    Public ReadOnly StatoSoftm As String = "Beta"
    Public ReadOnly Versione As String = "v 2.1.0"
    Public DataRilascio As String = "01-03-24"


    'Old
    'Public DataRilascio_GUI_Fan As String = "22/04/2021"
    'Public Versione_GUI_Fan As String = "5.00"

    'Old
    'Public DataRilascio_GUI_Audio As String = "02/04/2021"
    'Public Versione_GUI_Audio As String = "3.00"



    'Hub 2.0
    Public DataRilascio_GUI_Fan_Audio As String = "00/00/2024"
    Public Versione_GUI_Fan_Audio As String = "4.07"

    'Hub 3.0
    Public DataRilascio_GUI_Fan_3 As String = "00/00/2024"
    Public Old_Versione_GUI_Fan_3 As String = "2.06"
    Public Versione_GUI_Fan_3 As String = "2.07"

    'Hub 4.0
    Public DataRilascio_GUI_Fan_4 As String = "11/01/2024"
    Public Old_Versione_GUI_Fan_4 As String = "1.06"
    Public Versione_GUI_Fan_4 As String = "1.07"


    Public DatiRicevuti As String = ""
    Public DatiRX() As String
    Public DatiRX_0() As String 'Info Software Arduino
    Public DatiRX_1() As String 'Dati Temp, Volt, Protezioni
    Public DatiRX_2() As String 'Abbilita Protezioni, Memoria/Configurazione
    Public DatiRX_3() As String 'Numero LED
    Public DatiRX_3_1() As String 'Numero LED Array
    Public DatiRX_4() As String 'Luminosità
    Public DatiRX_5() As String 'Colore
    Public DatiRX_6() As String 'Saturazione
    Public DatiRX_7() As String 'Seleziona Elemento
    Public DatiRX_8() As String 'Velocità ventola
    Public DatiRX_9() As String 'Modalità Ventola
    Public DatiRX_10() As String    'RPM Ventola
    Public DatiRX_11() As String    'Animazione RGB


    Dim DatiTX As String = ""
    Public DTX As Integer = 1
    Public Aggiorna As Integer = 1


    Public Data0 As String = 0 'Boot Avvio HUB
    Public Data1 As Integer = 0 'Seleziona Oggetto LED
    Public Data2 As Integer = 0 'Luminosità dei LED
    Public Data3 As Integer = 0 'Colore LED
    Public Data4 As Integer = 0 'Saturazione Colore LED
    Public Data5 As Integer = 0 'Velocità Ventole

    Public Data6 As String = 0 '//Null                                         Audio Digital Music
    Public Data7 As String = 0 '//Luminosità
    Public Data8 As String = 0 '//Modalità seleziona ventola LED

    Public Data9 As String = 0 '//
    Public Data10 As String = 0 'Attiva/Disattiva Memoria, Reset dati utente, Configura HUB
    Public Data11 As String = 0 '//Velocità rotazione ventole
    Public Data12 As String = 0 'Attiva/Disattiva Protezione LED
    Public Data13 As String = 0 'Imposta il Nummero dei LED
    Public Data14 As String = 0 '//Null                                        Aquisizione Audio
    Public Data15 As String = 0 '//Modalità seleziona Audio LED
    Public Data16 As String = 0 '//Modalità Colore Audio


    Public VerificaSeriale As String = 1
    Dim Riavvio_Arduino As String = 1
    Private ReadOnly DelayCOM As Integer = 1100
    Public RipristinoArduino As Integer = 0
    Public RiavvioArduino As Integer = 0

    Private Sub F_Avvio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '//Smussa Angoli della Finestra Principale
        AngoliSmussati(Me)
        AvvioFormITA()

        'BackgroundWorkerTaskMenager.RunWorkerAsync()
        TimerAvvioForm.Enabled = True


        'F_Avvio.ActiveForm.Opacity = 0
        'Dim x As Integer
        'For x = 0 To 1100
        '    F_Avvio.ActiveForm.Opacity = x - 1000
        'Next x

        'ErrorMod = 8
        'F_Avvisi.LabelID_Error.Text = "Error Code " & ErrorMod
        'F_Avvisi.AvvisoErrore()

        'Lingua Soft
        If My.Settings.Lingua = "Italiano" Then
            F_Impostazioni.SetLingua.Text = F_Impostazioni.SetLingua.Items(0)
            F_Impostazioni.CambiaLingua("ITA")
            F_HardwareMonitor.CambiaLingua("ITA")
        ElseIf My.Settings.Lingua = "English" Then
            F_Impostazioni.SetLingua.Text = F_Impostazioni.SetLingua.Items(1)
            F_Impostazioni.CambiaLingua("ENG")
            F_HardwareMonitor.CambiaLingua("ENG")
        End If
    End Sub

    'Private Sub BackgroundWorkerTaskMenager_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerTaskMenager.DoWork
    '    TaskListPC.Open()
    'End Sub

    '//Smussa Angoli della Finestra Principale
    Private Sub AngoliSmussati(obj As Form)
        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()
        Dim A_S As Integer = 22
        Dim A_D As Integer = 22
        Dim B_D As Integer = 22
        Dim B_S As Integer = 22
        'Angolo Alto Sinistro
        DGP.AddArc(New Rectangle(0, 0, A_S, A_S), 180, 90)
        DGP.AddLine(A_S, 0, obj.Width - A_S, 0)
        'Angolo Alto Destro
        DGP.AddArc(New Rectangle(obj.Width - A_D, 0, A_D, A_D), -90, 90)
        DGP.AddLine(obj.Width, A_D, obj.Width, obj.Height - A_D)
        'Angolo Basso Destro
        DGP.AddArc(New Rectangle(obj.Width - B_D, obj.Height - B_D, B_D, B_D), 0, 90)
        DGP.AddLine(obj.Width - B_D, obj.Height, B_D, obj.Height)
        'Angolo Basso Sinistro
        DGP.AddArc(New Rectangle(0, obj.Height - B_S, B_S, B_S), 90, 90)
        DGP.CloseFigure()

        obj.Region = New Region(DGP)
    End Sub

    Public Sub AvvioFormITA()
        'GUI_Avvio_Lingua
        StatoAPP.Text = StatoSoft
        ID_Versione.Text = Versione & "  " & DataRilascio
        Creatore.Text = "MastrMarco"
    End Sub

    Private Sub TimerAvvioForm_Tick(sender As Object, e As EventArgs) Handles TimerAvvioForm.Tick
        If ErrorMod = 0 Then
            Me.Hide()
            'Me.Visible = False
            AnimazioneAvvioGIF.Enabled = False
            AnimazioneAvvioGIF.Visible = False
            F_Home.Show()
            'F_Home.Visible = True
            TimerAvvioForm.Enabled = False


            'TimerTaskManager.Enabled = True
        End If
    End Sub


    Private Sub BackgroundWorkerSerialPort_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerSerialPort.DoWork
        Try
            If SerialPortArduino.IsOpen = True Then
                Do

                    DatiRicevuti = SerialPortArduino.ReadLine().ToString()

                    If VerificaSeriale = 0 And DTX = 0 Then
                        SerialPortArduino.WriteLine(DatiTX)
                    End If

                Loop

                Threading.Thread.Sleep(40)

            End If

        Catch ex As Exception
            'F_Connessione.Disconnessione()
        End Try
    End Sub


    '//Verifica se' la comunicazione tra il PC e l'Arduino avviene Correttamente, Verifica anchè se è Compatibbile    
    Sub Verifica()
        Try
            If DatiRicevuti.Length > 80 Then
                ' R = Relise  /  B = Beta  / D = Debug
                If DatiRX_0(0) = "R" Or DatiRX_0(0) = "B" Or DatiRX_0(0) = "D" Then
                    'ConnessioneAttiva
                    VerificaSeriale = 0
                    Riavvio_Arduino = 0

                    'Cursor = Cursors.Default
                    F_Home.La_Caricamentro.Visible = False
                    F_Home.LabelFinestraID.Visible = True
                    F_Home.PanForm.Enabled = True
                End If
            ElseIf Riavvio_Arduino >= DelayCOM Then
                If F_Avvisi.Visible = False Then
                    ErrorMod = "00"
                    F_Avvisi.LabelID_Error.Text = "Error Code " & ErrorMod & " A-0"
                    F_Avvisi.AvvisoErrore()
                End If
                VerificaSeriale = 1
                Riavvio_Arduino = 1
            End If

        Catch ex As Exception

        End Try
    End Sub


    Private Sub TimerSerialPort_TX_RX_Tick(sender As Object, e As EventArgs) Handles TimerSerialPort_TX_RX.Tick

        'Divisione dati
        'F_Home.LabelRXs.Text = DatiRicevuti.Length
        Try
            If ((DatiRicevuti.Length < 80 And DTX = 0) Or (DatiRicevuti.Length > 80 And DTX = 1)) Then
                DatiRX = Split(DatiRicevuti, ";")       'Variabbile Principlae Dati ricevuti

                If DatiRX.Length = 13 Then 'Verifica i dati seriali sono tutti
                    DatiRX_0 = Split(DatiRX(0), ",")       'Tipo Di Configurazione/Dispositivo
                    DatiRX_1 = Split(DatiRX(1), ",")        'Informazioni della alimentazione/protezione del dispositivo
                    DatiRX_2 = Split(DatiRX(2), ",")        'Impostazioni dei parametri
                    DatiRX_3 = Split(DatiRX(3), ",")
                    DatiRX_4 = Split(DatiRX(4), ",")
                    DatiRX_5 = Split(DatiRX(5), ",")
                    DatiRX_6 = Split(DatiRX(6), ",")
                    DatiRX_7 = Split(DatiRX(7), ",")
                    DatiRX_8 = Split(DatiRX(8), ",")
                    DatiRX_9 = Split(DatiRX(9), ",")
                    DatiRX_10 = Split(DatiRX(10), ",")
                    DatiRX_11 = Split(DatiRX(11), ",")
                End If
            End If
        Catch ex As Exception
            'If F_Avvisi.Visible = False Then
            'ErrorMod = 4
            'F_Avvisi.LabelID_Error.Text = "Error Code " & ErrorMod & " A-1"
            'F_Avvisi.AvvisoErrore()
            'End If
        End Try


        Try
            'Verifica se la porta COM è Compatibbile
            If VerificaSeriale = 1 Then
                If DatiRX_0(0) = "R" Or DatiRX_0(0) = "B" Or DatiRX_0(0) = "D" Then
                    Verifica()
                Else
                    Verifica()
                    If Riavvio_Arduino <= DelayCOM Then
                        Riavvio_Arduino += 1
                    End If
                End If
            End If
        Catch ex As Exception

        End Try



        'Verifica se riceve dati dalla Seriale
        If Riavvio_Arduino = 0 And VerificaSeriale = 0 Then
            'Divide i dati ricevuti in vari pacchetti

            Try
                'If Riavvio_Arduino = 0 And VerificaSeriale = 0 Then

                '/****************************************************************************/
                If Aggiorna = 1 Then
                    AggiornaGUI()
                End If
                '/****************************************************************************/
                If DatiRX_0(0) = "D" Then
                    F_Debug_HubFan.Debug_Fan_Loop()
                End If
                '/****************************************************************************/
                'GUI_Audio Project
                Try
                    If Aggiorna = 0 And CaricaDati_Boot = 1 And DatiRX_0(0) <> "D" Then
                        If DatiRX_0(1) = "1" Then
                        End If

                        '/****************************************************************************/
                        'GUI_Fan Project
                        If DatiRX_0(1) = "2" Then
                        End If



                        '/****************************************************************************/
                        'GUI_Fan && GUI_Audio Project - GUI_Fan 3 - ArduFanHub 4.0
                        If DatiRX_0(1) = "3" Or DatiRX_0(1) = "4" Or DatiRX_0(1) = "5" Then
                            F_Hub_PC.RX_TX()
                            F_HubPC_Ventole.GUI_Ventole()
                            P_Impostazioni_HUB.DataImpostazioni()
                        End If



                        '/****************************************************************************/ 
                    End If
                Catch ex As Exception
                    If F_Avvisi.Visible = False Then
                        ErrorMod = 4
                        F_Avvisi.LabelID_Error.Text = "Error Code " & ErrorMod & " A-3"
                        F_Avvisi.AvvisoErrore()
                    End If
                End Try

                If SerialPortArduino.IsOpen = False Then
                    If F_Avvisi.Visible = False Then
                        ErrorMod = 5
                        F_Avvisi.LabelID_Error.Text = "Error Code " & ErrorMod & " A-4"
                        F_Avvisi.AvvisoErrore()
                    End If
                    F_Connessione.Disconnessione()
                End If

                If DTX = 0 Then

                    'Salva lo stato impostato dall'utente prima della Modifica del Numero dei LED
                    If Data10 <> 3 Then
                        Classe_Impostazioni_HUB_LED.DataElement_Save = Data1
                        Classe_Impostazioni_HUB_LED.DataColor_Save = Data3
                    Else
                        'Evita la Modifica dei dati impostati dall'utente quando vine attivata la Modifica del Numero dei LED
                        Data3 = 700
                    End If

                    'Aggorna Dati invio TX
                    DatiTX = (Data0 + ";" + Data1.ToString() + ";" + Data2.ToString() + ";" + Data3.ToString() + ";" + Data4.ToString() + ";" + Data5.ToString() + ";" + Data6 + ";" + Data7 + ";" + Data8 + ";" + Data9 + ";" + Data10 + ";" + Data11 + ";" + Data12 + ";" + Data13 + ";" + Data14 + ";" + Data15 + ";" + Data16 + ";")
                Else
                    If CaricaDati_Boot = 0 Then
                        CaricamentoDatiAggiornamento()
                        'DTX = 0
                    End If
                End If

                If F_Connessione.ViewSerial = 0 Then
                    F_Connessione.LaSerialData.Text = DatiRicevuti
                ElseIf F_Connessione.ViewSerial = 1 Then
                    F_Connessione.LaSerialData.Text = DatiTX
                End If


                '/****************************************************************************/

                'F_Home.LabelFinestraID.Text = DatiRicevuti.ToString()                    
                'End If
            Catch ex As Exception
                If F_Avvisi.Visible = False Then
                    ErrorMod = 4
                    F_Avvisi.LabelID_Error.Text = "Error Code " & ErrorMod & " A-2"
                    F_Avvisi.AvvisoErrore()
                End If
            End Try
        Else
            If VerificaSeriale = 1 Then
                If Riavvio_Arduino <= DelayCOM Then
                    Riavvio_Arduino += 1

                    'Cursor = Cursors.WaitCursor
                    F_Home.PanForm.Enabled = False
                    F_Home.LabelFinestraID.Visible = False
                    F_Home.La_Caricamentro.Visible = True
                End If
                Verifica()
            End If
        End If
    End Sub


    Dim AutoForm As String = 0
    'Dim Debug_MOD As Boolean = False
    Public Sub AggiornaGUI()
        Try


            F_Connessione.BtnConnettiDisconnetti.BackgroundImage = My.Resources.BtnDisconnettiConnetti
            F_Connessione.S_COM.Enabled = False
            F_Connessione.LaStato.Text = "   Connesso"
            F_Connessione.LaStato.ForeColor = Color.FromArgb(0, 140, 149)


            F_Connessione.LaSerialData.Font = New Font("Verdana", 9, FontStyle.Bold)

            '-Acuisizione informazioni del arduino

            'Tipo di Arduino
            If DatiRX_0(1) = "1" Or DatiRX_0(1) = "2" Then
                F_Connessione.LaNomePCB.Text = "Arduino Nano"
                F_Connessione.LaSoc.Text = "ATmega328P"

            ElseIf DatiRX_0(1) = "3" Then
                F_Connessione.LaNomePCB.Text = "Arduino Uno"
                F_Connessione.LaSoc.Text = "ATmega328P"
            End If

            'Versione Firmware di Arduino
            F_Connessione.LaVerFirmware.Text = "V " & DatiRX_0(4)

            'Tipo di Firmware
            If DatiRX_0(0) = "D" Then
                F_Connessione.LaFirmware.Text = "Debug"
            End If
            If DatiRX_0(0) = "B" Then
                F_Connessione.LaFirmware.Text = "Beta"
            End If
            If DatiRX_0(0) = "R" Then
                F_Connessione.LaFirmware.Text = "Relise"
            End If

            '????
            'If DatiRX_0(3) = "1" Then
            '    'F_Connessione.PictureFunzioni.BackgroundImage = My.Resources.Funzioni_Dispositivo_Audio_1_0
            '    F_Connessione.LabelSoftArduCenter.Text = "Versione che supporta ArduCenter : V " & Versione_GUI_Audio
            '    F_Connessione.LaProgetto.Text = "AudioHub1.0"

            '    'Verifica Versione Arduino Firmware
            '    If DatiRX_0(4) < Versione_GUI_Audio Then
            '        ErrorMod = 6
            '        F_Avvisi.LabelID_Error.Text = "Error Code " & ErrorMod
            '        F_Avvisi.AvvisoErrore()
            '    ElseIf DatiRX_0(4) > Versione_GUI_Audio Then
            '        ErrorMod = 7
            '        F_Avvisi.LabelID_Error.Text = "Error Code " & ErrorMod
            '        F_Avvisi.AvvisoErrore()
            '    End If
            'End If
            ''GUI_Fan Project
            'If DatiRX_0(3) = "2" Then
            '    'F_Connessione.PictureFunzioni.BackgroundImage = My.Resources.Funzioni_Dispositivo_Fan_1_0
            '    F_Connessione.LabelSoftArduCenter.Text = "Versione che supporta ArduCenter : V " & Versione_GUI_Fan
            '    F_Connessione.LaProgetto.Text = " SmartFanHub1.0"
            '    F_Home.BtnVentole.Enabled = True

            '    'Verifica Versione Arduino Firmware
            '    If DatiRX_0(4) < Versione_GUI_Fan Then
            '        ErrorMod = 6
            '        F_Avvisi.LabelID_Error.Text = "Avviso Code " & ErrorMod
            '        F_Avvisi.AvvisoErrore()
            '    ElseIf DatiRX_0(4) > Versione_GUI_Fan Then
            '        ErrorMod = 7
            '        F_Avvisi.LabelID_Error.Text = "Avviso Code " & ErrorMod
            '        F_Avvisi.AvvisoErrore()
            '    End If
            'End If
            'GUI_Fan && GUI_Audio Project
            If DatiRX_0(3) = "3" Then
                'F_Connessione.PictureFunzioni.BackgroundImage = My.Resources.Funzioni_Dispositivo
                F_Connessione.LabelSoftArduCenter.Text = "Versione Firmware che supporta" & vbCrLf & "ArduCenter : V " & Versione_GUI_Fan_Audio
                F_Connessione.LaProgetto.Text = "ArduHubFanAudio 2.0"

                If DatiRX_0(0) <> "D" Then
                    F_Home.BtnVentole.Enabled = True
                    'F_Hub_PC.BtnMenùEX.Visible = True
                    'F_Home.BtnAudio.Enabled = True
                Else
                    F_Home.BtnProjectArduino.Enabled = True
                End If

                'Verifica Versione Arduino Firmware
                If DatiRX_0(4) < Versione_GUI_Fan_Audio Then
                    ErrorMod = 6
                    F_Avvisi.LabelID_Error.Text = "Avviso Code " & ErrorMod
                    F_Avvisi.AvvisoErrore()
                ElseIf DatiRX_0(4) > Versione_GUI_Fan_Audio Then
                    ErrorMod = 7
                    F_Avvisi.LabelID_Error.Text = "Avviso Code " & ErrorMod
                    F_Avvisi.AvvisoErrore()
                End If
            End If
            'GUI_Fan 3
            If DatiRX_0(3) = "4" Then
                'F_Connessione.PictureFunzioni.BackgroundImage = My.Resources.Funzioni_Dispositivo
                F_Connessione.LabelSoftArduCenter.Text = "Versione Firmware che supporta" & vbCrLf & "ArduCenter : V " & Versione_GUI_Fan_3
                F_Connessione.LaProgetto.Text = "ArduHubFan 3.0"

                If DatiRX_0(0) <> "D" Then
                    F_Home.BtnVentole.Enabled = True
                Else
                    F_Home.BtnProjectArduino.Enabled = True
                    'F_Home.BtnConnessione.Enabled = False
                End If

                'Verifica Versione Arduino Firmware
                If DatiRX_0(4) < Versione_GUI_Fan_3 Then
                    ErrorMod = 6
                    F_Avvisi.LabelID_Error.Text = "Avviso Code " & ErrorMod
                    F_Avvisi.AvvisoErrore()
                ElseIf DatiRX_0(4) > Versione_GUI_Fan_3 Then
                    ErrorMod = 7
                    F_Avvisi.LabelID_Error.Text = "Avviso Code " & ErrorMod
                    F_Avvisi.AvvisoErrore()
                End If
            End If
            'GUI_Fan 4
            If DatiRX_0(3) = "5" Then
                'F_Connessione.PictureFunzioni.BackgroundImage = My.Resources.Funzioni_Dispositivo
                F_Connessione.LabelSoftArduCenter.Text = "Versione Firmware che supporta" & vbCrLf & "ArduCenter : V " & Versione_GUI_Fan_4
                F_Connessione.LaProgetto.Text = "ArduFanHub 4.0"

                If DatiRX_0(0) <> "D" Then
                    F_Home.BtnVentole.Enabled = True
                Else
                    F_Home.BtnProjectArduino.Enabled = True
                    'F_Home.BtnConnessione.Enabled = False
                End If

                'Verifica Versione Arduino Firmware
                If DatiRX_0(4) < Versione_GUI_Fan_4 Then
                    ErrorMod = 6
                    F_Avvisi.LabelID_Error.Text = "Avviso Code " & ErrorMod
                    F_Avvisi.AvvisoErrore()
                ElseIf DatiRX_0(4) > Versione_GUI_Fan_4 Then
                    ErrorMod = 7
                    F_Avvisi.LabelID_Error.Text = "Avviso Code " & ErrorMod
                    F_Avvisi.AvvisoErrore()
                End If
            End If

            F_HubPC_Home.GUI_home_HUB()
            F_HubPC_HUB.GUI_Btn_HUB_Info()

            If (My.Settings.AutoForm_Pan = "Si" And AutoForm = 0) And (DatiRX_0(3) = "3" Or DatiRX_0(3) = "2" Or DatiRX_0(3) = "4" Or DatiRX_0(3) = "5") And (DatiRX_0(0) = "B" Or DatiRX_0(0) = "R") Then

                If F_Home.InForm.Location <> New Point(0, 251) Then
                    F_Home.PanForm.Visible = True
                    F_Home.SwitchPannelHome(F_Hub_PC)

                    F_Home.InForm.Visible = True
                    F_Home.InForm.BackColor = Color.Gold
                    F_Home.InForm.Location = New Point(0, 251)
                    'F_Home.LabelFinestraID.Text = "Finestra controllo Ventole [F_Fan]"
                End If
                AutoForm = 1
            End If

            If AutoForm = 0 And DatiRX_0(0) = "D" Then
                If F_Home.InForm.Location <> New Point(0, 422) Then
                    F_Home.PanForm.Visible = True
                    F_Home.SwitchPannelHome(F_Debug_HubFan)

                    F_Home.InForm.Visible = True
                    F_Home.InForm.BackColor = Color.Red
                    F_Home.InForm.Location = New Point(0, 422)
                    F_Home.LabelFinestraID.Text = "Finestra di Debug Hub Ventole [F_Debug_HubFan]"
                End If
                AutoForm = 1
            End If

            Aggiorna = 0
        Catch ex As Exception
            ErrorMod = 4
            F_Avvisi.LabelID_Error.Text = "Error Code " & ErrorMod
            F_Avvisi.AvvisoErrore()
        End Try
    End Sub


    Public CaricaDati_Boot As Integer = 0
    Public Sub CaricamentoDatiAggiornamento()

        If CaricaDati_Boot = 0 Then
            If DatiRX_0(3) = "1" Then
                '//////////////////////////////////////////////////////////////////////////////////////////
            End If

            If DatiRX_0(3) = "2" Then
                '//////////////////////////////////////////////////////////////////////////////////////////
            End If

            If DatiRX_0(3) = "3" Or DatiRX_0(3) = "4" Or DatiRX_0(3) = "5" Then

                'Oggeto selezionato
                F_Hub_PC.LED_CFan = DatiRX_7(0)

                'Numero LED Array
                DatiRX_3_1 = DatiRX_3
                'Data Memoria EEPROM Arduino
                Classe_Impostazioni_HUB_LED.DataEEPROM_Save = DatiRX_2(0)
                Classe_Impostazioni_HUB_LED.DataElement_Save = DatiRX_7(0)

                If F_Hub_PC.LED_CFan <> 0 Then
                    F_Hub_PC.BtnOFF_Animation()
                End If

                'Caricamento colore principale oggetto
                If DatiRX_5(0) <= F_Hub_PC.Hue_Max Then
                    F_Hub_PC.H = DatiRX_5(DatiRX_7(0))
                ElseIf DatiRX_5(0) > F_Hub_PC.Hue_Max Then
                    F_Hub_PC.H_SyncMode = DatiRX_5(0)
                    F_Hub_PC.S_SyncMode = DatiRX_6(0)
                    F_Hub_PC.V_SyncMode = DatiRX_4(0)
                    Select Case DatiRX_5(0)
                        Case <= F_Hub_PC.Hue_Max
                            F_HubPC_Home.Btn_Hub_SyncMode.BackgroundImage = My.Resources.Icona_HUB_1_1
                        Case = F_Hub_PC.Animazione_RGB_Transiszione
                            F_HubPC_Home.Btn_Hub_SyncMode.BackgroundImage = My.Resources.Icona_HUB_1_1_RGB_Colore_Transizione
                        Case = F_Hub_PC.Animazione_RGB_Rainbow
                            F_HubPC_Home.Btn_Hub_SyncMode.BackgroundImage = My.Resources.Icona_HUB_1_1_RGB_Colore_RainBow
                        Case = F_Hub_PC.Animazione_RGB_Tepmeratura

                        Case = F_Hub_PC.Animazione_RGB_Musica
                            F_HubPC_Home.Btn_Hub_SyncMode.BackgroundImage = My.Resources.Icona_HUB_1_1_RGB_Colore_Musica
                        Case = F_Hub_PC.Animazione_RGB_Discontinuo
                            F_HubPC_Home.Btn_Hub_SyncMode.BackgroundImage = My.Resources.Icona_HUB_1_1_RGB_Colore_Discontinuo
                    End Select
                End If
                F_Hub_PC.S = DatiRX_6(DatiRX_7(0))
                If DatiRX_4(DatiRX_7(0)) > 0 Then
                    Dim MapLum As Integer = F_Hub_PC.map(DatiRX_4(DatiRX_7(0)), 0, 255, 80, 255)
                    F_Hub_PC.V = MapLum
                Else
                    F_Hub_PC.V = DatiRX_4(DatiRX_7(0))
                End If
                F_Hub_PC.HSV_to_RGB()


                Dim C As Integer
                For C = 0 To DatiRX_5.Length - 1

                    F_Hub_PC.ColorTextSet_Avvio(C)
                    If DatiRX_5(C) <= F_Hub_PC.Hue_Max Then
                        F_Hub_PC.H_Crica = DatiRX_5(C)
                        F_Hub_PC.S_Crica = DatiRX_6(C)
                        F_Hub_PC.V_Crica = DatiRX_4(C)
                        If DatiRX_4(C) > 0 Then
                            Dim MapLum As Integer = F_Hub_PC.map(DatiRX_4(C), 0, 255, 80, 255)
                            F_Hub_PC.V_Crica = MapLum
                        Else
                            F_Hub_PC.V_Crica = DatiRX_4(C)
                        End If
                        F_Hub_PC.HSV_to_RGB_Carica_Avvio()
                        Select Case C
                            Case = 0
                                F_Hub_PC.H_SyncMode = DatiRX_5(C)
                                F_Hub_PC.S_SyncMode = DatiRX_6(C)
                                F_Hub_PC.V_SyncMode = DatiRX_4(C)
                                F_Hub_PC.R_SyncMode = F_Hub_PC.R_Crica
                                F_Hub_PC.G_SyncMode = F_Hub_PC.G_Crica
                                F_Hub_PC.B_SyncMode = F_Hub_PC.B_Crica
                                F_HubPC_Home.Btn_Hub_SyncMode.BackColor = Color.FromArgb(F_Hub_PC.R_Crica, F_Hub_PC.G_Crica, F_Hub_PC.B_Crica)
                                F_Hub_PC.Text_Color_SyncMode = F_Hub_PC.TextColor
                            Case = 1
                                F_Hub_PC.H_Fan1 = DatiRX_5(C)
                                F_Hub_PC.S_Fan1 = DatiRX_6(C)
                                F_Hub_PC.V_Fan1 = DatiRX_4(C)
                                F_Hub_PC.R_Fan1 = F_Hub_PC.R_Crica
                                F_Hub_PC.G_Fan1 = F_Hub_PC.G_Crica
                                F_Hub_PC.B_Fan1 = F_Hub_PC.B_Crica
                                F_HubPC_Ventole.IconaFan1.BackColor = Color.FromArgb(F_Hub_PC.R_Crica, F_Hub_PC.G_Crica, F_Hub_PC.B_Crica)
                                F_Hub_PC.Text_Color_Fan1 = F_Hub_PC.TextColor
                            Case = 2
                                F_Hub_PC.H_Fan2 = DatiRX_5(C)
                                F_Hub_PC.S_Fan2 = DatiRX_6(C)
                                F_Hub_PC.V_Fan2 = DatiRX_4(C)
                                F_Hub_PC.R_Fan2 = F_Hub_PC.R_Crica
                                F_Hub_PC.G_Fan2 = F_Hub_PC.G_Crica
                                F_Hub_PC.B_Fan2 = F_Hub_PC.B_Crica
                                F_HubPC_Ventole.IconaFan2.BackColor = Color.FromArgb(F_Hub_PC.R_Crica, F_Hub_PC.G_Crica, F_Hub_PC.B_Crica)
                                F_Hub_PC.Text_Color_Fan2 = F_Hub_PC.TextColor
                            Case = 3
                                F_Hub_PC.H_Fan3 = DatiRX_5(C)
                                F_Hub_PC.S_Fan3 = DatiRX_6(C)
                                F_Hub_PC.V_Fan3 = DatiRX_4(C)
                                F_Hub_PC.R_Fan3 = F_Hub_PC.R_Crica
                                F_Hub_PC.G_Fan3 = F_Hub_PC.G_Crica
                                F_Hub_PC.B_Fan3 = F_Hub_PC.B_Crica
                                F_HubPC_Ventole.IconaFan3.BackColor = Color.FromArgb(F_Hub_PC.R_Crica, F_Hub_PC.G_Crica, F_Hub_PC.B_Crica)
                                F_Hub_PC.Text_Color_Fan3 = F_Hub_PC.TextColor
                            Case = 4
                                F_Hub_PC.H_Fan4 = DatiRX_5(C)
                                F_Hub_PC.S_Fan4 = DatiRX_6(C)
                                F_Hub_PC.V_Fan4 = DatiRX_4(C)
                                F_Hub_PC.R_Fan4 = F_Hub_PC.R_Crica
                                F_Hub_PC.G_Fan4 = F_Hub_PC.G_Crica
                                F_Hub_PC.B_Fan4 = F_Hub_PC.B_Crica
                                F_HubPC_Ventole.IconaFan4.BackColor = Color.FromArgb(F_Hub_PC.R_Crica, F_Hub_PC.G_Crica, F_Hub_PC.B_Crica)
                                F_Hub_PC.Text_Color_Fan4 = F_Hub_PC.TextColor
                            Case = 5
                                F_Hub_PC.H_Fan_CPU_OP_01 = DatiRX_5(C)
                                F_Hub_PC.S_Fan_CPU_OP_01 = DatiRX_6(C)
                                F_Hub_PC.V_Fan_CPU_OP_01 = DatiRX_4(C)
                                F_Hub_PC.R_Fan_CPU_OP_01 = F_Hub_PC.R_Crica
                                F_Hub_PC.G_Fan_CPU_OP_01 = F_Hub_PC.G_Crica
                                F_Hub_PC.B_Fan_CPU_OP_01 = F_Hub_PC.B_Crica
                                F_HubPC_Dissipatore240.Btn_FanCPU_LED01.BackColor = Color.FromArgb(F_Hub_PC.R_Crica, F_Hub_PC.G_Crica, F_Hub_PC.B_Crica)
                                F_Hub_PC.Text_Color_Fan_CPU_OP_01 = F_Hub_PC.TextColor
                            Case = 6
                                F_Hub_PC.H_Fan_CPU_OP_02 = DatiRX_5(C)
                                F_Hub_PC.S_Fan_CPU_OP_02 = DatiRX_6(C)
                                F_Hub_PC.V_Fan_CPU_OP_02 = DatiRX_4(C)
                                F_Hub_PC.R_Fan_CPU_OP_02 = F_Hub_PC.R_Crica
                                F_Hub_PC.G_Fan_CPU_OP_02 = F_Hub_PC.G_Crica
                                F_Hub_PC.B_Fan_CPU_OP_02 = F_Hub_PC.B_Crica
                                F_HubPC_Dissipatore240.Btn_FanCPU_LED02.BackColor = Color.FromArgb(F_Hub_PC.R_Crica, F_Hub_PC.G_Crica, F_Hub_PC.B_Crica)
                                F_Hub_PC.Text_Color_Fan_CPU_OP_02 = F_Hub_PC.TextColor
                            Case = 7
                                F_Hub_PC.H_CPU_OP = DatiRX_5(C)
                                F_Hub_PC.S_CPU_OP = DatiRX_6(C)
                                F_Hub_PC.V_CPU_OP = DatiRX_4(C)
                                F_Hub_PC.R_CPU_OP = F_Hub_PC.R_Crica
                                F_Hub_PC.G_CPU_OP = F_Hub_PC.G_Crica
                                F_Hub_PC.B_CPU_OP = F_Hub_PC.B_Crica
                                F_HubPC_Dissipatore240.Btn_PompCPU_LED.BackColor = Color.FromArgb(F_Hub_PC.R_Crica, F_Hub_PC.G_Crica, F_Hub_PC.B_Crica)
                                F_Hub_PC.Text_Color_CPU_OP = F_Hub_PC.TextColor

                            Case = F_Hub_PC.IndirizzoElemento_SchedaVideo
                                F_Hub_PC.H_GPU = DatiRX_5(C)
                                F_Hub_PC.S_GPU = DatiRX_6(C)
                                F_Hub_PC.V_GPU = DatiRX_4(C)
                                F_Hub_PC.R_GPU = F_Hub_PC.R_Crica
                                F_Hub_PC.G_GPU = F_Hub_PC.G_Crica
                                F_Hub_PC.B_GPU = F_Hub_PC.B_Crica
                                'F_HubPC_Home.Btn_F_HubPC_GPU.BackColor = Color.FromArgb(F_Hub_PC.R_Crica, F_Hub_PC.G_Crica, F_Hub_PC.B_Crica)
                                F_HubPC_GPU_SLED.BtnIMG_GPU_LED.BackColor = Color.FromArgb(F_Hub_PC.R_Crica, F_Hub_PC.G_Crica, F_Hub_PC.B_Crica)
                                F_Hub_PC.Text_Color_GPU = F_Hub_PC.TextColor

                            Case = F_Hub_PC.IndirizzoElemento_StriscaLED
                                F_Hub_PC.H_SLED = DatiRX_5(C)
                                F_Hub_PC.S_SLED = DatiRX_6(C)
                                F_Hub_PC.V_SLED = DatiRX_4(C)
                                F_Hub_PC.R_SLED = F_Hub_PC.R_Crica
                                F_Hub_PC.G_SLED = F_Hub_PC.G_Crica
                                F_Hub_PC.B_SLED = F_Hub_PC.B_Crica
                                'F_HubPC_Home.Btn_F_HubPC_SLED.BackColor = Color.FromArgb(F_Hub_PC.R_Crica, F_Hub_PC.G_Crica, F_Hub_PC.B_Crica)
                                F_HubPC_GPU_SLED.BtnIMG_Strip_LED.BackColor = Color.FromArgb(F_Hub_PC.R_Crica, F_Hub_PC.G_Crica, F_Hub_PC.B_Crica)
                                F_Hub_PC.Text_Color_SLED = F_Hub_PC.TextColor
                            Case = 10
                                F_Hub_PC.H_Cassa_Audio_S = DatiRX_5(C)
                                F_Hub_PC.S_Cassa_Audio_S = DatiRX_6(C)
                                F_Hub_PC.V_Cassa_Audio_S = DatiRX_4(C)
                                F_Hub_PC.R_Cassa_Audio_S = F_Hub_PC.R_Crica
                                F_Hub_PC.G_Cassa_Audio_S = F_Hub_PC.G_Crica
                                F_Hub_PC.B_Cassa_Audio_S = F_Hub_PC.B_Crica
                                F_HubPC_CasseAudio.Btn_CassaAudio_S.BackColor = Color.FromArgb(F_Hub_PC.R_Crica, F_Hub_PC.G_Crica, F_Hub_PC.B_Crica)
                                'If DatiRX_7(0) > 0 Then
                                F_HubPC_CasseAudio.Icona_CassaAudio_S.BackColor = Color.FromArgb(F_Hub_PC.R_Crica, F_Hub_PC.G_Crica, F_Hub_PC.B_Crica)

                                F_Hub_PC.Text_Color_Cassa_Audio_S = F_Hub_PC.TextColor
                            Case = 11
                                F_Hub_PC.H_Cassa_Audio_D = DatiRX_5(C)
                                F_Hub_PC.S_Cassa_Audio_D = DatiRX_6(C)
                                F_Hub_PC.V_Cassa_Audio_D = DatiRX_4(C)
                                F_Hub_PC.R_Cassa_Audio_D = F_Hub_PC.R_Crica
                                F_Hub_PC.G_Cassa_Audio_D = F_Hub_PC.G_Crica
                                F_Hub_PC.B_Cassa_Audio_D = F_Hub_PC.B_Crica
                                F_HubPC_CasseAudio.Btn_CassaAudio_D.BackColor = Color.FromArgb(F_Hub_PC.R_Crica, F_Hub_PC.G_Crica, F_Hub_PC.B_Crica)
                                'If DatiRX_7(0) > 0 Then
                                F_HubPC_CasseAudio.Icona_CassaAudio_D.BackColor = Color.FromArgb(F_Hub_PC.R_Crica, F_Hub_PC.G_Crica, F_Hub_PC.B_Crica)

                                F_Hub_PC.Text_Color_Cassa_Audio_D = F_Hub_PC.TextColor
                            Case = 12
                                F_Hub_PC.H_Strip_LED = DatiRX_5(C)
                                F_Hub_PC.S_Strip_LED = DatiRX_6(C)
                                F_Hub_PC.V_Strip_LED = DatiRX_4(C)
                                F_Hub_PC.R_Strip_LED = F_Hub_PC.R_Crica
                                F_Hub_PC.G_Strip_LED = F_Hub_PC.G_Crica
                                F_Hub_PC.B_Strip_LED = F_Hub_PC.B_Crica
                                F_HubPC_CasseAudio.Btn_StripLED.BackColor = Color.FromArgb(F_Hub_PC.R_Crica, F_Hub_PC.G_Crica, F_Hub_PC.B_Crica)
                                'If DatiRX_7(0) > 0 Then
                                F_HubPC_CasseAudio.Icona_StripLED.BackColor = Color.FromArgb(F_Hub_PC.R_Crica, F_Hub_PC.G_Crica, F_Hub_PC.B_Crica)

                                F_Hub_PC.Text_Color_Cassa_Strip_LED = F_Hub_PC.TextColor
                        End Select

                    End If
                Next

                'Test Output
                'F_Home.LabelFinestraID.Text = (" l = " & DatiRX_5.Length - 1)
                'F_Home.LabelFinestraID.Text = (F_HubPC_Ventole.Text_Color_All & " , " & F_HubPC_Ventole.Text_Color_Fan1 & " , " & F_HubPC_Ventole.Text_Color_Fan2 & " , " & F_HubPC_Ventole.Text_Color_Fan3 & " , " & F_HubPC_Ventole.Text_Color_Fan4 & " , " & F_HubPC_Dissipatore240.Text_Color_Fan_CPU_OP_01 & " , " & F_HubPC_Dissipatore240.Text_Color_Fan_CPU_OP_02 & " , " & F_HubPC_Dissipatore240.Text_Color_CPU_OP & " , " & F_HubPC_GPU_SLED.Text_Color_GPU & " , " & F_HubPC_GPU_SLED.Text_Color_SLED)

                F_HubPC_Home.Color_Set_Home_IMG() 'GUI HUB Home

                'Caricamento / copnfigurazione GUI_Fan / F_Fan
                F_Hub_PC.HubControlManual() ' Imposta il dispositivo selezionato l'ultima volta

                If DatiRX_7(0) = 0 And DatiRX_5(0) >= 605 Then F_Hub_PC.RGBAMenù = 1 'Visualizza altre aniamzioni RGB

                F_Hub_PC.Btn_Color_MOD() 'Carica i dati nella GUI Fan ColoreMod
                F_HubPC_Ventole.UI_Ventole() 'Carica i dati nella GUI Fan Velocità Luminosità

                'F_HubPC_Ventole.UI_GPU_Strip() Inserisce il Colore Attuale quando non e In sync

                'Barra Luminosità
                If DatiRX_4(DatiRX_7(0)) >= 13 Then
                    F_Hub_PC.TrackBarLuminosità.Value = DatiRX_4(DatiRX_7(0)) / 2.55
                Else
                    F_Hub_PC.TrackBarLuminosità.Value = F_Hub_PC.TrackBarLuminosità.Minimum
                End If

                'Barra Velocità
                ' If DatiRX_4(DatiRX_7(0)) <= 4 Then
                If DatiRX_7(0) <= 4 Then
                    F_Hub_PC.TrackBarVelocità.Value = DatiRX_8(DatiRX_7(0)) / 2.55
                Else
                    F_Hub_PC.TrackBarVelocità.Value = F_Hub_PC.TrackBarVelocità.Minimum
                End If

                F_HubPC_Ventole.S_Fan_All = DatiRX_8(0)
                F_HubPC_Ventole.S_Fan_1 = DatiRX_8(1)
                F_HubPC_Ventole.S_Fan_2 = DatiRX_8(2)
                F_HubPC_Ventole.S_Fan_3 = DatiRX_8(3)
                F_HubPC_Ventole.S_Fan_4 = DatiRX_8(4)


                'Caricamento Dati TX - RX 
                'Data0 = 0                        'Boot Arduino
                Data1 = DatiRX_7(0)               'Modalità seleziona oggetto LED
                Data2 = DatiRX_4(DatiRX_7(0))     'Luminosità
                Data3 = DatiRX_5(DatiRX_7(0))     'Colore
                Data4 = DatiRX_6(DatiRX_7(0))     'Saturazione
                Data5 = DatiRX_8(DatiRX_7(1))     'Velocità ventole

                Data6 = DatiRX_9(DatiRX_7(1))  'Curva di rotazione Ventole
                Data7 = 0 'Temperatura CPU
                Data8 = 0 'Temperatura GPU

                'Data9

                Data10 = DatiRX_2(0) 'Attiva Disattiva EEPROM "Salva dati Utente"
                Data11 = DatiRX_2(1) 'Attiva disattiva Protezione HUB
                Data12 = DatiRX_2(2) 'Attiva disattiva Protezione Luminosità LED


                'Data13 = 0            '//Modello di ventola
                'Data14 = DatiRX_1(5)  '//Audio Digitale Stato                         Aquisizione Audio
                'Data15 = DatiRX_10(0) '//Modalità seleziona Audio LED
                'Data16 = DatiRX_10(1) '//Modalità Colore Audio

                'Classe_Impostazioni_HUB_LED.Load()
            End If

        End If

        If DatiRX_0(0) <> "D" Then
            CaricaDati_Boot = 1
            TimerBoot_Reset.Start()
        End If

        'If RipristinoArduino = 1 Then
        '    RipristinoArduino = 0
        '    'TimerBoot_Reset.Stop()
        'End If

        If My.Settings.AutoConnesione = "SiRes" Then
            My.Settings.AutoConnesione = "No"
            F_Connessione.BtnAutoConnessione.BackgroundImage = My.Resources.btn_Swich
            F_Connessione.LabelConnessioneAuto.Text = "Disattivo"
        End If
    End Sub







    Public DelayReset_Boot As Integer = 1
    Private Sub TimerBoot_Reset_Tick(sender As Object, e As EventArgs) Handles TimerBoot_Reset.Tick
        'Boot_Arduino
        'If (CaricaDati_Boot = 1 And (DelayReset_Boot <> 0 And DelayReset_Boot <= 3) And (RipristinoArduino = 0 Or RiavvioArduino = 0)) Then
        If (CaricaDati_Boot = 1 And (DelayReset_Boot <= 3 And (RipristinoArduino = 0 Or RiavvioArduino = 0))) Then
            DelayReset_Boot += 1
        End If

        If DelayReset_Boot >= 3 And (RipristinoArduino = 0 Or RiavvioArduino = 0) Then
            Data0 = 200
            DTX = 0
            TimerBoot_Reset.Stop()
        End If


        'Inizio Ripristino
        If ((RipristinoArduino = 1 And DatiRX_2(0) = 2) Or (RiavvioArduino = 1)) Then
            SerialPortArduino.DtrEnable = True
            SerialPortArduino.DtrEnable = False
            My.Settings.SerialCOM = SerialPortArduino.PortName
            If My.Settings.AutoConnesione = "Si" Then
                My.Settings.AutoConnesione = "Si"
            ElseIf My.Settings.AutoConnesione = "No" Then
                My.Settings.AutoConnesione = "SiRes"
            End If
            'TaskListPC.Close()
            My.Settings.Save()
            F_Connessione.BtnConnettiDisconnetti_Click(sender, e)
            Application.Restart()
            TimerBoot_Reset.Stop()
        End If

    End Sub


    Public Sub FunzioneNull()
        ErrorMod = 100
        F_Avvisi.LabelID_Error.Text = "Error Code " & ErrorMod
        F_Avvisi.AvvisoErrore()
    End Sub

    Private Sub AnimazioneAvvioGIF_Click(sender As Object, e As EventArgs) Handles AnimazioneAvvioGIF.Click

    End Sub




















    'HardwareMonitor
    Public ErrorHardwareSchedaMadre As Byte = 0
    Public ErrorHardwareCPU As Byte = 0
    Public ErrorHardwareGPU As Byte = 0
    'Dim ErrorHardwareStoregHDD_SSD As Byte = 0
    Public ErrorHardwareRAM As Byte = 0

    '
    Public Nome_Scheda_Madre As String
    Dim CipSet_Temperatura As Integer

    '
    Public Nome_CPU_All As String
    Public Nome_CPU As String()

    Dim Old_CPU_Temperatura As Integer
    Public CPU_Temperatura As Integer
    Dim CPU_Utilizzo_Core_All As Integer
    Dim Old_CPU_Power As Integer
    Dim CPU_Power As Integer
    Dim CPU_Frequenza_Core_All As Integer

    Public Nome_GPU_All As String
    Dim Nome_GPU() As String
    Public GPU_Temperatura As Integer
    Dim Old_GPU_Temperatura As Integer
    Dim GPU_Frequenza As Integer
    Dim GPU_Power As Integer
    Dim Old_GPU_Power As Integer
    Dim GPU_Fan_RPM As Integer
    Dim GPU_Utilizzo As Integer
    Dim GPU_Utilizzo_RAM As Integer


    'Dim GPU_Temperatura_Hot_Spot As String


    Dim RAM_Utilizzo As Integer
    'Dim RAM_Disponible As Integer
    Dim RAM_Usato As Decimal
    Dim RAM_Totale As Decimal



End Class
