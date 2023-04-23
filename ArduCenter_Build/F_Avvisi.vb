Imports System.Runtime.InteropServices
Public Class F_Avvisi
    Private Sub F_Avvisi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AngoliSmussati(Me)
    End Sub

    '//Smussa Angoli della Finestra Principale
    Private Sub AngoliSmussati(obj As Form)
        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()
        Dim A_S As Integer = 40
        Dim A_D As Integer = 40
        Dim B_D As Integer = 40
        Dim B_S As Integer = 40
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


    '//Funzione Trascian Libreria SyS
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub PanelTop_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTop.MouseDown
        Try
            ReleaseCapture()
            SendMessage(Me.Handle, &H112&, &HF012&, 0)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LabelTitolo_MouseDown(sender As Object, e As MouseEventArgs) Handles LabelTitolo.MouseDown
        Try
            ReleaseCapture()
            SendMessage(Me.Handle, &H112&, &HF012&, 0)
        Catch ex As Exception

        End Try
    End Sub



    Private Sub BtnChiudi_Click(sender As Object, e As EventArgs) Handles BtnChiudi.Click
        F_Avvio.ErrorMod = 0
        F_Home.Enabled = True
        F_Setting_HUB_Fan.Enabled = True
        Close()

        If F_Avvio.ErrorMod >= 2 And F_Avvio.ErrorMod <= 8 Then
            F_Connessione.Disconnessione()
            F_Connessione.PreCaricamentroCOM_Port()
            F_Home.BtnConnessione_Click(sender, e)
        End If

    End Sub

    Dim ITA As String = "ITALIANO"
    Dim ENG As String = "ENGLISH"
    Public Sub AvvisoErrore()

        If F_Avvio.ErrorMod = "00" Then
            If My.Settings.Lingua = ITA Then
                LabelTextError.Text = "Errore sconosciuto"
            ElseIf My.Settings.Lingua = ENG Then

            End If



        ElseIf F_Avvio.ErrorMod = 1 Then
            If My.Settings.Lingua = ITA Then
                LabelTextError.Text = "
Nessun dispositivo collegato,
si prega di collegare il dispositivo.


Clicca OK per continuare
"
            ElseIf My.Settings.Lingua = ENG Then

            End If



        ElseIf F_Avvio.ErrorMod = 2 Then
            If My.Settings.Lingua = ITA Then
                LabelTextError.Text = "
La connessione Automatica è stata disattivata,
perché non è stato rilevato il dispositivo alla porta memorizzata.
La connessione Manuale è stata attivata.

Clicca OK per continuare
"
            ElseIf My.Settings.Lingua = ENG Then

            End If



        ElseIf F_Avvio.ErrorMod = 3 Then
            If My.Settings.Lingua = ITA Then
                LabelTextError.Text = "
Il dispositivo selezionato, 
non è compatibile con il Software.


Clicca OK per continuare
"
            ElseIf My.Settings.Lingua = ENG Then

            End If



        ElseIf F_Avvio.ErrorMod = 4 Then
            If My.Settings.Lingua = ITA Then
                LabelTextError.Text = "
Si è verificato un errore nel
caricamento dei dati del dispositivo.
Si prega di riconnettere il dispositivo manualmente.

Clicca OK per continuare
"
            ElseIf My.Settings.Lingua = ENG Then

            End If



        ElseIf F_Avvio.ErrorMod = 5 Then
            If My.Settings.Lingua = ITA Then
                LabelTextError.Text = "
Il dispositivo si è scollegato in modo 
anomalo.
Attivata la modalità di connessione manuale.

Clicca OK per continuare
"
            ElseIf My.Settings.Lingua = ENG Then

            End If



        ElseIf F_Avvio.ErrorMod = 6 Then
            If My.Settings.Lingua = ITA Then
                LabelTextError.Text = "
Il dispositivo selezionato ha una versione
del Firmware non aggiornata e supportata dalla
Versione corrente del Software 'ArduCenter 2.0'.
Si prega di aggiornare il Firmware del dispositivo

Clicca OK per continuare
"
            ElseIf My.Settings.Lingua = ENG Then

            End If



        ElseIf F_Avvio.ErrorMod = 7 Then
            If My.Settings.Lingua = ITA Then
                LabelTextError.Text = "
Il dispositivo selezionato ha una versione
del Firmware più avanzata rispetto alla versione 
che supporta il Software 'ArduCenter 2.0'.
Si prega di aggiornare il Software alla versione compatibile.

Clicca OK per continuare
"
            ElseIf My.Settings.Lingua = ENG Then

            End If



        ElseIf F_Avvio.ErrorMod = 8 Then
            If My.Settings.Lingua = ITA Then
                LabelTextError.Text = "
Il dispositivo selezionato non è compatibile
con il Software o non è più connesso al PC.

Clicca OK per continuare
"
            ElseIf My.Settings.Lingua = ENG Then

            End If



        ElseIf F_Avvio.ErrorMod = 9 Then
            If My.Settings.Lingua = ITA Then

            ElseIf My.Settings.Lingua = ENG Then

            End If



        ElseIf F_Avvio.ErrorMod = 10 Then
            If My.Settings.Lingua = ITA Then
                LabelTextError.Text = "
Il dispositivo verrà riavviato
!!! Attenzione funzione Beta !!!

Clicca OK per continuare
"
            ElseIf My.Settings.Lingua = ENG Then

            End If

            '/------------------------------------------------------------------------------/


        ElseIf F_Avvio.ErrorMod = 31 Then
            If My.Settings.Lingua = ITA Then
                LabelTextError.Text = "I parametri dell'Hub 
sono tutti Buoni.

Clicca OK per continuare."

            ElseIf My.Settings.Lingua = ENG Then
                LabelTextError.Text = "Hub parameters
they are all good.

Click OK to continue."
            End If

        ElseIf F_Avvio.ErrorMod = 32 Then
            If My.Settings.Lingua = ITA Then
                LabelTextError.Text = "!ATTENZIONE!
Il sensore di temperatura, 
rileva una temperatura anomala.

Clicca OK per continuare."

            ElseIf My.Settings.Lingua = ENG Then
                LabelTextError.Text = "!ATTENTION!
The temperature sensor,
detects an abnormal temperature.

Click OK to continue."
            End If

        ElseIf F_Avvio.ErrorMod = 33 Then
            If My.Settings.Lingua = ITA Then
                LabelTextError.Text = "!ATTENZIONE!
L'alimentazione all'Hub, ha un'anomalia,
si consiglia di fare Manutenzione.

Clicca OK per continuare."

            ElseIf My.Settings.Lingua = ENG Then
                LabelTextError.Text = "!ATTENTION!
The power supply at the Hub, has an anomaly,
Maintenance is recommended.
Click OK to continue."
            End If

        ElseIf F_Avvio.ErrorMod = 34 Then
            If My.Settings.Lingua = ITA Then
                LabelTextError.Text = "!ATTENZIONE! 
L'alimentazione dell'Hub ha un'anomalia. 
È Stata attivata la protezione PowerLED.

Clicca OK per continuare."

            ElseIf My.Settings.Lingua = ENG Then
                LabelTextError.Text = "!ATTENTION!
The Hub power supply has an anomaly.
The PowerLED protection has been activated.

Click OK to continue."
            End If

        ElseIf F_Avvio.ErrorMod = 35 Then
            If My.Settings.Lingua = ITA Then
                LabelTextError.Text = "!ATTENZIONE! 
L'alimentazione dell'Hub ha un'anomalia, 
Il sensore di temperatura, 
rileva una temperatura anomala.
Clicca OK per continuare."

            ElseIf My.Settings.Lingua = ENG Then
                LabelTextError.Text = "!ATTENTION!
Hub power supply has an anomaly,
The temperature sensor,
detects an abnormal temperature.
Click OK to continue."
            End If

        ElseIf F_Avvio.ErrorMod = 36 Then
            If My.Settings.Lingua = ITA Then
                LabelTextError.Text = "!ATTENZIONE!  
Il sensore di temperatura, 
rileva una temperatura anomala.
È Stata attivata la protezione PowerLED.
Clicca OK per continuare."

            ElseIf My.Settings.Lingua = ENG Then
                LabelTextError.Text = "!!ATTENTION!
The temperature sensor,
detects an abnormal temperature.
The PowerLED protection has been activated.
Click OK to continue."
            End If

        ElseIf F_Avvio.ErrorMod = 37 Then
            If My.Settings.Lingua = ITA Then
                LabelTextError.Text = "!!!ATTENZIONE!!!
Si consiglia di disattivare l'HUB,
per evitare eventuali danni!!!

Clicca OK per continuare."

            ElseIf My.Settings.Lingua = ENG Then
                LabelTextError.Text = "!!!ATTENTION!!!
It is recommended to deactivate the HUB,
to avoid any damage !!!

Click OK to continue."
            End If



        ElseIf F_Avvio.ErrorMod = 40 Then
            If My.Settings.Lingua = ITA Then
                LabelTextError.Text = "!!!ATTENTION!!!
Indica che le varie impostazioni dell’utente
non verranno salvate alla prossima 
accensione o riavvio del dispositivo.
Andare nelle impostazioni per 
attivare il salvataggio dei dati
Clicca OK per continuare
"
            ElseIf My.Settings.Lingua = ENG Then

            End If

        ElseIf F_Avvio.ErrorMod = 41 Then
            If My.Settings.Lingua = ITA Then
                LabelTextError.Text = "!!!ATTENTION!!!
Indica che il dispositivo non rileva una corretta 
alimentazione dal cavo POWER, andando in modalità 
protezione che causa lo scollegamento dalla 
linea Power 12V 5V. Causando lo spegnimento 
dei LED e l’arresto delle ventole
Clicca OK per continuare
"
            ElseIf My.Settings.Lingua = ENG Then

            End If

        ElseIf F_Avvio.ErrorMod = 42 Then
            If My.Settings.Lingua = ITA Then
                LabelTextError.Text = "!!!ATTENTION!!!
Indica che la linea di alimentazione LED 
non rileva una corretta alimentazione per 
funzionare correttamente, o è stata attivata la 
modalità 'Protezione LED' per limitare il 
consumo di corrente impostato nel Firmware
Clicca OK per continuare
"
            ElseIf My.Settings.Lingua = ENG Then

            End If

        ElseIf F_Avvio.ErrorMod = 43 Then
            If My.Settings.Lingua = ITA Then
                LabelTextError.Text = "!!!ATTENTION!!!

Clicca OK per continuare
"
            ElseIf My.Settings.Lingua = ENG Then

            End If

            '/------------------------------------------------------------------------------/


        ElseIf F_Avvio.ErrorMod = 70 Then
            If My.Settings.Lingua = ITA Then
                LabelTextError.Text = "Le ventole verranno controllate 
in base alla temperatura del sensore del dispositivo.
T = Temperatura: T < 31 Fan 0%, 
T > 32 – T < 35 Fan 35%, 
T > 36 – T < 40 Fan 63%, 
T > 41 Fan 100%
Clicca OK per continuare
"
            ElseIf My.Settings.Lingua = ENG Then

            End If

        ElseIf F_Avvio.ErrorMod = 71 Then
            If My.Settings.Lingua = ITA Then
                LabelTextError.Text = "Le ventole verranno controllate 
in base alla temperatura della CPU.
T = Temperatura: T < 31 Fan 0%, 
T > 32 – T < 44 Fan 39%, 
T > 45 – T < 59 Fan 59%, 
T > 60 Fan 100%
Clicca OK per continuare
"
            ElseIf My.Settings.Lingua = ENG Then

            End If

        ElseIf F_Avvio.ErrorMod = 72 Then
            If My.Settings.Lingua = ITA Then
                LabelTextError.Text = "Le ventole verranno controllate 
in base alla temperatura della GPU.
T = Temperatura: T < 31 Fan 0%, 
T > 32 – T < 44 Fan 39%, 
T > 45 – T < 59 Fan 59%, 
T > 60 Fan 100%
Clicca OK per continuare
"
            ElseIf My.Settings.Lingua = ENG Then

            End If


            '/------------------------------------------------------------------------------/

        ElseIf F_Avvio.ErrorMod = 100 Then
                If My.Settings.Lingua = ITA Then
                    LabelTextError.Text = "
Al momento questa funzione non è disponibile

Clicca OK per continuare
"
                ElseIf My.Settings.Lingua = ENG Then

                End If




            ElseIf F_Avvio.ErrorMod = 101 Then
                If My.Settings.Lingua = ITA Then
                    LabelTextError.Text = "
Per attivare questa funzione devi 
essere connesso al dispositivo.

Clicca OK per continuare
"
                ElseIf My.Settings.Lingua = ENG Then

                End If




            ElseIf F_Avvio.ErrorMod = 102 Then
                If My.Settings.Lingua = ITA Then
                LabelTextError.Text = "
Verranno reimpostati tutti 
i valori di fabbrica.
Il Software verrà Riavviato.
Clicca OK per continuare
"
            ElseIf My.Settings.Lingua = ENG Then

            End If
        End If

        Me.TopMost = True
        Show()
        F_Home.Enabled = False
        F_Setting_HUB_Fan.Enabled = False

    End Sub

    Private Sub Btn_OK_Click(sender As Object, e As EventArgs) Handles Btn_OK.Click

        If F_Avvio.ErrorMod >= 2 And F_Avvio.ErrorMod <= 8 Or F_Avvio.ErrorMod = "00" Then
            F_Connessione.Disconnessione()
            F_Connessione.PreCaricamentroCOM_Port()
            F_Home.BtnConnessione_Click(sender, e)

            If F_Home.PanForm.Enabled = False Then
                F_Home.PanForm.Enabled = True
            End If
        End If

        If F_Avvio.ErrorMod = 10 Then
            'F_Avvio.SerialPortArduino.RtsEnable = True
            F_Avvio.SerialPortArduino.DtrEnable = True
            F_Avvio.SerialPortArduino.DtrEnable = False
        End If

        If F_Avvio.ErrorMod = 102 Then

            'F_Avvio.Rirpristino_Dati()
            F_Avvio.Data10 = 2
            'F_Avvio.DelayReset = 1
            F_Avvio.RipristinoArduino = 1
            F_Avvio.TimerBoot_Reset.Start()


            'F_Avvio.Aggiorna = 1
            'F_Avvio.VerificaSeriale = 1
            'F_Avvio.DTX = 1
            'F_Avvio.CaricaDati_Boot = 0
            'F_Avvio.DatiRicevuti = 0
        End If

        F_Home.Enabled = True
        F_Setting_HUB_Fan.Enabled = True
        F_Avvio.ErrorMod = 0
        Close()
    End Sub

End Class