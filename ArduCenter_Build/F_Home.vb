Imports System.Runtime.InteropServices

Public Class F_Home
    Private Sub F_Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AngoliSmussati(Me)

        PanForm.Visible = True
        SwitchPannelHome(F_Connessione)
        LabelFinestraID.Text = "Finestra di Connessione [F_Home]"

        InVersione.Text = F_Avvio.StatoSoftm
        InV.Text = F_Avvio.Versione

        LaInfoSoft.Text = F_Avvio.InfoSoft_HOME
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

    '//Funzione Trascian Libreria SyS
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanBarraTop_MouseDown(sender As Object, e As MouseEventArgs) Handles PanBarraTop.MouseDown
        Try
            ReleaseCapture()
            SendMessage(Me.Handle, &H112&, &HF012&, 0)
        Catch ex As Exception

        End Try
    End Sub

    '//ChiudiNascondi Btn
    Private Sub BtnChiudi_Click(sender As Object, e As EventArgs) Handles BtnChiudi.Click
        'F_Avvisi.Close()
        'F_HardwareMonitor.Close()
        'F_SerialCommand_Fan.Close()
        'F_Setting_HUB_Fan.Close()
        'F_Setting_RGB_Animation_Fan.Close()
        'F_Setting_RGB_Animation_Fan_Temp.Close()
        'Me.Close()
        'F_Avvio.Close()
        My.Settings.Save()
        Application.Exit()

        'For Each Form In My.Application.OpenForms
        '    Form.Close()
        'Next
    End Sub

    Private Sub BtnNascondi_Click(sender As Object, e As EventArgs) Handles BtnNascondi.Click
        WindowState = FormWindowState.Minimized
    End Sub

    '//Button Form Impostazioni
    Private Sub BtnImpostazioni_Click(sender As Object, e As EventArgs) Handles BtnImpostazioni.Click
        If InForm.Location <> New Point(0, 84) Then
            InForm.Visible = True
            InForm.BackColor = Color.Gold
            InForm.Location = New Point(0, 84)
            LabelFinestraID.Text = "Finestra Impostazioni [F_Set]"
        End If
        F_Avvio.FunzioneNull()
    End Sub
    Private Sub BtnImpostazioni_MouseLeave(sender As Object, e As EventArgs) Handles BtnImpostazioni.MouseLeave
        If InForm.Location <> New Point(0, 84) Then
            InFormHover.Visible = False
        End If
    End Sub
    Private Sub BtnImpostazioni_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnImpostazioni.MouseMove
        If InForm.Location <> New Point(0, 84) Then
            InFormHover.Visible = True
            InFormHover.Location = New Point(0, 84)
        End If
    End Sub


    '//Button Form Connessione
    Public Sub BtnConnessione_Click(sender As Object, e As EventArgs) Handles BtnConnessione.Click
        If InForm.Location <> New Point(0, 166) Then
            PanForm.Visible = True
            SwitchPannelHome(F_Connessione)

            InForm.Visible = True
            InForm.BackColor = Color.Gold
            InForm.Location = New Point(0, 166)
            LabelFinestraID.Text = "Finestra di Connessione [F_Home]"
        End If
    End Sub
    Private Sub BtnConnessione_MouseLeave(sender As Object, e As EventArgs) Handles BtnConnessione.MouseLeave
        If InForm.Location <> New Point(0, 166) Then
            InFormHover.Visible = False
        End If
    End Sub
    Private Sub BtnConnessione_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnConnessione.MouseMove
        If InForm.Location <> New Point(0, 166) Then
            InFormHover.Visible = True
            InFormHover.Location = New Point(0, 166)
        End If
    End Sub


    '//Button Form Audio
    Private Sub BtnAudio_Click(sender As Object, e As EventArgs) Handles BtnAudio.Click
        If InForm.Location <> New Point(0, 335) Then
            PanForm.Visible = True
            SwitchPannelHome(F_Audio)

            InForm.Visible = True
            InForm.BackColor = Color.Gold
            InForm.Location = New Point(0, 335)
            LabelFinestraID.Text = "Finestra Audio [F_Audio]"
        End If
        F_Avvio.FunzioneNull()
    End Sub
    Private Sub BtnAudio_MouseLeave(sender As Object, e As EventArgs) Handles BtnAudio.MouseLeave
        If InForm.Location <> New Point(0, 335) Then
            InFormHover.Visible = False
        End If
    End Sub
    Private Sub BtnAudio_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnAudio.MouseMove
        If InForm.Location <> New Point(0, 335) Then
            InFormHover.Visible = True
            InFormHover.Location = New Point(0, 335)
        End If
    End Sub


    '//Button Form Ventole
    Private Sub BtnVentole_Click(sender As Object, e As EventArgs) Handles BtnVentole.Click
        If InForm.Location <> New Point(0, 251) Then
            PanForm.Visible = True
            SwitchPannelHome(F_Hub_PC)

            InForm.Visible = True
            InForm.BackColor = Color.Gold
            InForm.Location = New Point(0, 251)
            LabelFinestraID.Text = "Finestra di controllo " & F_Hub_PC.FanMenù
        End If
    End Sub
    Private Sub BtnVentole_MouseLeave(sender As Object, e As EventArgs) Handles BtnVentole.MouseLeave
        If InForm.Location <> New Point(0, 251) Then
            InFormHover.Visible = False
        End If
    End Sub
    Private Sub BtnVentole_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnVentole.MouseMove
        If InForm.Location <> New Point(0, 251) Then
            InFormHover.Visible = True
            InFormHover.Location = New Point(0, 251)
        End If
    End Sub


    '//Button Form Project
    Private Sub BtnProjectArduino_Click(sender As Object, e As EventArgs) Handles BtnProjectArduino.Click
        If InForm.Location <> New Point(0, 422) Then
            InForm.Visible = True
            SwitchPannelHome(F_Debug_HubFan)
            InForm.BackColor = Color.Gold
            InForm.Location = New Point(0, 422)
            LabelFinestraID.Text = "Finestra di Debug Hub PC [F_Debug_HubFan]"
            'LabelFinestraID.Text = "Finestra Project Arduino [F_ProjArdu]"
        End If
        'F_Avvio.FunzioneNull()
    End Sub
    Private Sub BtnProjectArduino_MouseLeave(sender As Object, e As EventArgs) Handles BtnProjectArduino.MouseLeave
        If InForm.Location <> New Point(0, 422) Then
            InFormHover.Visible = False
        End If
    End Sub
    Private Sub BtnProjectArduino_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnProjectArduino.MouseMove
        If InForm.Location <> New Point(0, 422) Then
            InFormHover.Visible = True
            InFormHover.Location = New Point(0, 422)
        End If
    End Sub


    '//Funzione Multi Form GUI
    Public Sub SwitchPannelHome(ByVal GUI_Home_Form As Form)
        Try
            PanForm.Controls.Clear()
            GUI_Home_Form.TopLevel = False
            PanForm.Controls.Add(GUI_Home_Form)
            GUI_Home_Form.Show()
        Catch ex As Exception

        End Try
    End Sub
End Class