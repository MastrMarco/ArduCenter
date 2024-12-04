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
        F_Setting_HUB.Enabled = True
        Close()

        If ((F_Avvio.ErrorMod >= 2 And F_Avvio.ErrorMod <= 8) Or F_Avvio.ErrorMod = "00") Then
            'If F_Avvio.ErrorMod >= 2 And F_Avvio.ErrorMod <= 8 Then
            F_Connessione.Disconnessione()
            F_Connessione.PreCaricamentroCOM_Port()
            F_Home.BtnConnessione_Click(sender, e)
        End If

    End Sub


    'Public Sub AvvisoErrore(Errore As Integer, InfoErrore As String)
    Public Sub AvvisoErrore()

        Select Case F_Avvio.ErrorMod

            Case "00"
                LabelTextError.Text = "Errore sconosciuto"




            Case 1
                LabelTextError.Text = "
Nessun dispositivo collegato,
si prega di collegare il dispositivo.


Clicca OK per continuare
"



            Case 2
                LabelTextError.Text = "
La connessione Automatica è stata disattivata,
perché non è stato rilevato il dispositivo memorizzato.
La connessione Manuale è stata attivata.

Clicca OK per continuare
"



            Case 3
                LabelTextError.Text = "
Il dispositivo selezionato, 
non è compatibile con il Software.


Clicca OK per continuare
"



            Case 4
                LabelTextError.Text = "
Si è verificato un errore nel
caricamento dei dati del dispositivo.
Si prega di riconnettere il dispositivo manualmente.

Clicca OK per continuare
"



            Case 5
                LabelTextError.Text = "
Il dispositivo si è scollegato in modo 
anomalo.
Attivata la modalità di connessione manuale.

Clicca OK per continuare
"




            Case 6
                LabelTextError.Text = "
Il dispositivo selezionato ha una versione
del Firmware non aggiornata e supportata dalla
Versione corrente del Software 'ArduCenter 2.0'.
Si prega di aggiornare il Firmware del dispositivo

Clicca OK per continuare
"



            Case 7
                LabelTextError.Text = "
Il dispositivo selezionato ha una versione
del Firmware più avanzata rispetto alla versione 
che supporta il Software 'ArduCenter 2.0'.
Si prega di aggiornare il Software alla versione compatibile.

Clicca OK per continuare
"



            Case 8
                LabelTextError.Text = "
Il dispositivo selezionato non è compatibile
con il Software o non è più connesso al PC.

Clicca OK per continuare
"



            Case 9




            Case 10
                LabelTextError.Text = "
Il dispositivo verrà Riavviato
è anche il Software verrà Riavviato.
!!! Attenzione funzione Beta !!!

Clicca OK per continuare
"



            Case 11
                LabelTextError.Text = "
Il sistema per acquisire i dati
 Hardware del PC è andato in errore.
 Riavviare il Software per risolvere

Clicca OK per continuare
"

                '/------------------------------------------------------------------------------/


            Case 31
                LabelTextError.Text = "I parametri dell'Hub 
sono tutti Buoni.

Clicca OK per continuare."

            Case 32
                LabelTextError.Text = "!ATTENZIONE!
Il sensore di temperatura, 
rileva una temperatura anomala.

Clicca OK per continuare."

            Case 33
                LabelTextError.Text = "!ATTENZIONE!
L'alimentazione all'Hub, ha un'anomalia,
si consiglia di fare Manutenzione.

Clicca OK per continuare."


            Case 34
                LabelTextError.Text = "!ATTENZIONE! 
L'alimentazione dell'Hub ha un'anomalia. 
È Stata attivata la protezione PowerLED.

Clicca OK per continuare."



            Case 35
                LabelTextError.Text = "!ATTENZIONE! 
L'alimentazione dell'Hub ha un'anomalia, 
Il sensore di temperatura, 
rileva una temperatura anomala.
Clicca OK per continuare."



            Case 36
                LabelTextError.Text = "!ATTENZIONE!  
Il sensore di temperatura, 
rileva una temperatura anomala.
È Stata attivata la protezione PowerLED.
Clicca OK per continuare."



            Case 37
                LabelTextError.Text = "!!!ATTENZIONE!!!
Si consiglia di disattivare l'HUB,
per evitare eventuali danni!!!

Clicca OK per continuare."





            Case 40
                LabelTextError.Text = "!!!ATTENTION!!!
Indica che le varie impostazioni dell’utente
non verranno salvate alla prossima 
accensione o riavvio del dispositivo.
Andare nelle impostazioni per 
attivare il salvataggio dei dati
Clicca OK per continuare
"


            Case 41
                LabelTextError.Text = "!!!ATTENTION!!!
Indica che il dispositivo non rileva una corretta 
alimentazione dal cavo POWER, andando in modalità 
protezione che causa il distacco dalla 
linea Power 12V 5V. Causando lo spegnimento 
dei LED e l’arresto delle ventole
Clicca OK per continuare
"


            Case 42
                LabelTextError.Text = "!!!ATTENTION!!!
Indica che la linea di alimentazione LED 
non rileva una corretta alimentazione per 
funzionare correttamente, o è stata attivata la 
modalità 'Protezione LED' per limitare il 
consumo di corrente.
Clicca OK per continuare
"


            Case 43
                LabelTextError.Text = "!!!ATTENTION!!!

Clicca OK per continuare
"


                '/------------------------------------------------------------------------------/


            Case 70
                LabelTextError.Text = "Le ventole verranno controllate 
in base alla temperatura del sensore del dispositivo.
T = Temperatura: T < 31 Fan 0%, 
T > 32 – T < 35 Fan 35%, 
T > 36 – T < 40 Fan 63%, 
T > 41 Fan 100%
Clicca OK per continuare
"


            Case 71
                LabelTextError.Text = "Le ventole verranno controllate 
in base alla temperatura della CPU.
T = Temperatura: T < 31 Fan 0%, 
T > 32 – T < 44 Fan 39%, 
T > 45 – T < 59 Fan 59%, 
T > 60 Fan 100%
Clicca OK per continuare
"


            Case 72
                LabelTextError.Text = "Le ventole verranno controllate 
in base alla temperatura della GPU.
T = Temperatura: T < 31 Fan 0%, 
T > 32 – T < 44 Fan 39%, 
T > 45 – T < 59 Fan 59%, 
T > 60 Fan 100%
Clicca OK per continuare
"



                '/------------------------------------------------------------------------------/

            Case 100
                LabelTextError.Text = "
Al momento questa funzione non è disponibile

Clicca OK per continuare
"





            Case 101
                LabelTextError.Text = "
Per attivare questa funzione devi 
essere connesso al dispositivo.

Clicca OK per continuare
"





            Case 102
                LabelTextError.Text = "
Verranno reimpostati tutti 
i valori di fabbrica.
Il Software verrà Riavviato.
Clicca OK per continuare
"


                '---------------------------------Informazioni-----------------------------------
                '/------------------------------------------------------------------------------/

            Case 200
                LabelTextError.Text = "
Il Numero Massimo di LED 
 è di 30 e il Minimo è di 2.

Clicca OK per continuare
"





            Case 201
                LabelTextError.Text = "
Il Numero Massimo di LED 
 è di 30 e il Minimo è di 1.

Clicca OK per continuare
"




        End Select

        Me.TopMost = True
        Show()
        F_Home.Enabled = False
        F_Setting_HUB.Enabled = False

    End Sub

    Private Sub Btn_OK_Click(sender As Object, e As EventArgs) Handles Btn_OK.Click

        If ((F_Avvio.ErrorMod >= 2 And F_Avvio.ErrorMod <= 8) Or F_Avvio.ErrorMod = "00") Then
            F_Connessione.Disconnessione()
            F_Connessione.PreCaricamentroCOM_Port()
            F_Home.BtnConnessione_Click(sender, e)

            If F_Home.PanForm.Enabled = False Then
                F_Home.PanForm.Enabled = True
            End If
        End If

        'Riavvio
        If F_Avvio.ErrorMod = 10 Then
            F_Avvio.RiavvioArduino = 1
            F_Avvio.TimerBoot_Reset.Start()
        End If

        'Ripristino
        If F_Avvio.ErrorMod = 102 Then
            F_Avvio.Data10 = 2
            F_Avvio.RipristinoArduino = 1
            F_Avvio.TimerBoot_Reset.Start()
        End If

        F_Home.Enabled = True
        F_Setting_HUB.Enabled = True
        F_Avvio.ErrorMod = 0
        Close()
    End Sub

End Class