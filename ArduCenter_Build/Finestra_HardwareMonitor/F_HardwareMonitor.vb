Imports System.Runtime.InteropServices
Imports System.IO
Public Class F_HardwareMonitor
    Public F_HomeWidth As Integer = F_Home.Width

    Dim Pagina As String = "PC"
    Public HardwareOpern As Integer = 0

    'Avvio form
    Private Sub HardwareMonitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AngoliSmussati(Me)


        'SwitchPannelHrdwareMonitor(P_HardwareMonitor_PC)
        'Pagina = "PC"

        'Speed
        If My.Settings.TimerHardwareMonitor = 0 Then 'Veloce
            'F_Avvio.TimerTaskManager.Interval = 800
            ComboBoxSpeed.Text = ComboBoxSpeed.Items(0)
        ElseIf My.Settings.TimerHardwareMonitor = 1 Then 'Normale
            'F_Avvio.TimerTaskManager.Interval = 1500
            ComboBoxSpeed.Text = ComboBoxSpeed.Items(1)
        ElseIf My.Settings.TimerHardwareMonitor = 2 Then 'Lento
            'F_Avvio.TimerTaskManager.Interval = 2000
            ComboBoxSpeed.Text = ComboBoxSpeed.Items(2)
        End If

        'Opacità
        Me.Opacity = My.Settings.FormHrdwareTras
        If My.Settings.FormHrdwareTras * 100 <= 100 Then
            TrackBarTrasparenza.Value = My.Settings.FormHrdwareTras * 100
        Else
            TrackBarTrasparenza.Value = 100
        End If

        'Priorità
        If My.Settings.FormHrdwareTop = 0 Then
            PrioritàForm.Text = PrioritàForm.Items(0)
            Me.TopMost = False
        ElseIf My.Settings.FormHrdwareTop = 1 Then
            PrioritàForm.Text = PrioritàForm.Items(1)
            Me.TopMost = True
        End If
    End Sub

    '//Smussa Angoli della Finestra Principale
    Private Sub AngoliSmussati(obj As Form)
        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()
        Dim A_S As Integer = 26
        Dim A_D As Integer = 26
        Dim B_D As Integer = 26
        Dim B_S As Integer = 26
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
    '//Funzione Trascian Finestra
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub HardwareMonitor_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        Try
            ReleaseCapture()
            SendMessage(Me.Handle, &H112&, &HF012&, 0)
        Catch ex As Exception

        End Try
    End Sub
    '//Funzione Multi Form GUI
    Public Sub SwitchPannelHrdwareMonitor(ByVal GUI_Hrdware_Form As Form)
        Try
            PanelTaskMonitor.Controls.Clear()
            GUI_Hrdware_Form.TopLevel = False
            PanelTaskMonitor.Controls.Add(GUI_Hrdware_Form)
            GUI_Hrdware_Form.Show()
        Catch ex As Exception

        End Try
    End Sub


    'Chiudi Finestra
    Private Sub Chiudi_Click(sender As Object, e As EventArgs) Handles BtnChiudi.Click
        Me.Close()
        HardwareOpern = 0
        F_Hub_PC.BtnTaskHardware_GUI.BackgroundImage = My.Resources.Icona_Parametri_Fan
        F_Connessione.BtnHardwareMonitor.BackgroundImage = My.Resources.Icona_Parametri_Fan
    End Sub


    'PC info
    Private Sub BtnPC_Click(sender As Object, e As EventArgs) Handles BtnPC.Click
        If Pagina <> "PC" Then
            SwitchPannelHrdwareMonitor(P_HardwareMonitor_PC)
            Pagina = "PC"

            F_Avvio.ErrorMod = 100
            F_Avvisi.LabelID_Error.Text = "Error Code " & F_Avvio.ErrorMod
            F_Avvisi.AvvisoErrore()
        End If
    End Sub
    'Arduino info
    Private Sub BtnHUB_Click(sender As Object, e As EventArgs) Handles BtnHUB.Click
        If Pagina <> "HUB" Then
            SwitchPannelHrdwareMonitor(P_HardwareMonitor_Arduino)
            Pagina = "HUB"

            F_Avvio.ErrorMod = 100
            F_Avvisi.LabelID_Error.Text = "Error Code " & F_Avvio.ErrorMod
            F_Avvisi.AvvisoErrore()
        End If
    End Sub


    'Panel Impostazioni
    Private Sub BtnSet_Click(sender As Object, e As EventArgs) Handles BtnSet.Click
        If PanelSettings.Visible = False Then
            PanelSettings.Visible = True
            PanelTaskMonitor.Enabled = False
        ElseIf PanelSettings.Visible = True Then
            PanelSettings.Visible = False
            PanelTaskMonitor.Enabled = True
        End If
    End Sub

    'Imposata valori
    Public Sub BtnSetImp_Click(sender As Object, e As EventArgs) Handles BtnSetImp.Click
        If ComboBoxSpeed.Text = ComboBoxSpeed.Items(0) Then
            'F_Avvio.TimerTaskManager.Interval = 800
            My.Settings.TimerHardwareMonitor = 0
        ElseIf ComboBoxSpeed.Text = ComboBoxSpeed.Items(1) Then
            'F_Avvio.TimerTaskManager.Interval = 1500
            My.Settings.TimerHardwareMonitor = 1
        ElseIf ComboBoxSpeed.Text = ComboBoxSpeed.Items(2) Then
            'F_Avvio.TimerTaskManager.Interval = 2000
            My.Settings.TimerHardwareMonitor = 2
        End If

        If PrioritàForm.Text = PrioritàForm.Items(0) Then
            My.Settings.FormHrdwareTop = 0
            Me.TopMost = False
        ElseIf PrioritàForm.Text = PrioritàForm.Items(1) Then
            My.Settings.FormHrdwareTop = 1
            Me.TopMost = True
        End If

        PanelSettings.Visible = False
        PanelTaskMonitor.Enabled = True
    End Sub

    'Trasparenza Finestra
    Private Sub TrackBarTrasparenza_Scroll(sender As Object, e As EventArgs) Handles TrackBarTrasparenza.Scroll
        Me.Opacity = TrackBarTrasparenza.Value / TrackBarTrasparenza.Maximum
        My.Settings.FormHrdwareTras = TrackBarTrasparenza.Value / TrackBarTrasparenza.Maximum
    End Sub



    ' //-- Lingua finestra e pagine
    Public Sub CambiaLingua(lingua As String)
        ' Ottieni il percorso del file di testo per la lingua specificata
        Dim nomeFile As String = ""
        Select Case lingua
            Case "ITA"
                nomeFile = "F_HardwareMonitor.txt"
            Case "ENG"
                nomeFile = "F_HardwareMonitor.txt"
            Case "Null"
                'nomeFile = "F_Impostazioni.txt"
        End Select
        ' Combina il percorso relativo del file con il percorso della cartella dell'applicazione
        Dim percorsoFile As String = Path.Combine(F_Impostazioni.cartellaLingue, lingua, nomeFile)
        ' Leggi il testo dal file per le due etichette
        Dim testo As String() = F_Impostazioni.LeggiTestoDaFile(percorsoFile)


        Try
            ' Modifica il testo delle etichette dell'interfaccia con il testo letto dal file
            'Titoli
            BtnPC.Text = testo(1)
            BtnHUB.Text = testo(2)
            TitoloSet.Text = testo(3)
            Label1.Text = testo(4)
            Label2.Text = testo(5)
            BtnSetImp.Text = testo(6)

            'Elementi

            'Velocità Aggiornamento
            ComboBoxSpeed.Items(0) = testo(22)
            ComboBoxSpeed.Items(1) = testo(23)
            ComboBoxSpeed.Items(2) = testo(24)

            'Priorità Finestra
            PrioritàForm.Items(0) = testo(41)
            PrioritàForm.Items(1) = testo(42)






            '//------Pagina PC

            'Titoli
            P_HardwareMonitor_PC.Label1.Text = testo(101) 'Clock CPU
            P_HardwareMonitor_PC.Label5.Text = testo(103) 'Carico CPU
            P_HardwareMonitor_PC.Label6.Text = testo(104) 'Temperatura CPU
            P_HardwareMonitor_PC.Label7.Text = testo(105) 'Potenza CPU

            P_HardwareMonitor_PC.Label11.Text = testo(102) 'Clock GPU
            P_HardwareMonitor_PC.Label10.Text = testo(103) 'Carico GPU
            P_HardwareMonitor_PC.Label9.Text = testo(104)  'Temperatura GPU
            P_HardwareMonitor_PC.Label8.Text = testo(105) 'Potenza GPU

            P_HardwareMonitor_PC.InHrdware.Text = testo(106) 'Titolo RAM
            P_HardwareMonitor_PC.Label15.Text = testo(107) 'Usati
            P_HardwareMonitor_PC.Label16.Text = testo(108) 'Totale

            'Elementi




            '//------Pagina Arduino

            'Titoli
            'P_HardwareMonitor_PC.Label1.Text = testo(101) 'Clock CPU
            'P_HardwareMonitor_PC.Label5.Text = testo(103) 'Carico CPU
            'P_HardwareMonitor_PC.Label6.Text = testo(104) 'Temperatura CPU
            'P_HardwareMonitor_PC.Label7.Text = testo(105) 'Potenza CPU

            'P_HardwareMonitor_PC.Label11.Text = testo(102) 'Clock GPU
            'P_HardwareMonitor_PC.Label10.Text = testo(103) 'Carico GPU
            'P_HardwareMonitor_PC.Label9.Text = testo(104)  'Temperatura GPU
            'P_HardwareMonitor_PC.Label8.Text = testo(105) 'Potenza GPU

            'P_HardwareMonitor_PC.InHrdware.Text = testo(106) 'Titolo RAM
            'P_HardwareMonitor_PC.Label15.Text = testo(107) 'Usati
            'P_HardwareMonitor_PC.Label16.Text = testo(108) 'Totale

            'Elementi



        Catch ex As Exception

        End Try

    End Sub


End Class