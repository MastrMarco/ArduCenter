Imports System.Runtime.InteropServices
Public Class F_HardwareMonitor
    Public F_HomeWidth As Integer = F_Home.Width

    Dim Pagina As String = "PC"
    Public HardwareOpern As Integer = 0
    Private Sub HardwareMonitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AngoliSmussati(Me)
        Me.Location = New Point(F_Home.Location.X + F_HomeWidth + 5, F_Home.Location.Y - 50%)

        SwitchPannelHrdwareMonitor(F_MonitorHardware_PC)
        Pagina = "PC"

        If My.Settings.TimerHardwareMonitor = "Veloce" Then
            F_Avvio.TimerTaskManager.Interval = 800
            ComboBoxSpeed.Text = "Veloce"
        ElseIf My.Settings.TimerHardwareMonitor = "Normale" Then
            F_Avvio.TimerTaskManager.Interval = 1500
            ComboBoxSpeed.Text = "Normale"
        ElseIf My.Settings.TimerHardwareMonitor = "Lento" Then
            F_Avvio.TimerTaskManager.Interval = 2000
            ComboBoxSpeed.Text = "Lento"
        End If

        Me.Opacity = My.Settings.FormHrdwareTras
        If My.Settings.FormHrdwareTras * 100 <= 100 Then
            TrackBarTrasparenza.Value = My.Settings.FormHrdwareTras * 100
        Else
            TrackBarTrasparenza.Value = 100
        End If

        If My.Settings.FormHrdwareTop = "Normale" Then
            PrioritàForm.Text = "Normale"
            Me.TopMost = False
        ElseIf My.Settings.FormHrdwareTop = "Prioritario" Then
            PrioritàForm.Text = "Prioritario"
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

    '//Funzione Trascian Libreria SyS
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnChiudi.Click
        Me.Close()
        HardwareOpern = 0
        F_Hub_PC.BtnTaskHardware_GUI.BackgroundImage = My.Resources.BtnFanPage_Fan_Task_1_0
        F_Connessione.BtnHardwareMonitor.BackgroundImage = My.Resources.Icona_Parametri_Fan
    End Sub

    Private Sub BtnPC_Click(sender As Object, e As EventArgs) Handles BtnPC.Click
        If Pagina <> "PC" Then
            SwitchPannelHrdwareMonitor(F_MonitorHardware_PC)
            Pagina = "PC"
        End If
    End Sub

    Private Sub BtnHUB_Click(sender As Object, e As EventArgs) Handles BtnHUB.Click
        If Pagina <> "HUB" Then
            'SwitchPannelHrdwareMonitor(F_MonitorHardware_HUB)
            Pagina = "HUB"

            F_Avvio.ErrorMod = 100
            F_Avvisi.LabelID_Error.Text = "Error Code " & F_Avvio.ErrorMod
            F_Avvisi.AvvisoErrore()
        End If
    End Sub

    Private Sub BtnSet_Click(sender As Object, e As EventArgs) Handles BtnSet.Click
        If PanelSettings.Visible = False Then
            PanelSettings.Visible = True
            PanelTaskMonitor.Enabled = False
        ElseIf PanelSettings.Visible = True Then
            PanelSettings.Visible = False
            PanelTaskMonitor.Enabled = True
        End If
    End Sub

    Public Sub BtnSetImp_Click(sender As Object, e As EventArgs) Handles BtnSetImp.Click
        If ComboBoxSpeed.Text = "Veloce" Then
            F_Avvio.TimerTaskManager.Interval = 800
            My.Settings.TimerHardwareMonitor = "Veloce"
        ElseIf ComboBoxSpeed.Text = "Normale" Then
            F_Avvio.TimerTaskManager.Interval = 1500
            My.Settings.TimerHardwareMonitor = "Normale"
        ElseIf ComboBoxSpeed.Text = "Lento" Then
            F_Avvio.TimerTaskManager.Interval = 2000
            My.Settings.TimerHardwareMonitor = "Lento"
        End If

        If PrioritàForm.Text = "Normale" Then
            My.Settings.FormHrdwareTop = "Normale"
            Me.TopMost = False
        ElseIf PrioritàForm.Text = "Prioritario" Then
            My.Settings.FormHrdwareTop = "Prioritario"
            Me.TopMost = True
        End If

        PanelSettings.Visible = False
        PanelTaskMonitor.Enabled = True
    End Sub

    Private Sub BtnSetImp2_Click_1(sender As Object, e As EventArgs) Handles BtnSetImp2.Click
        BtnSetImp_Click(sender, e)
    End Sub

    Private Sub TrackBarTrasparenza_Scroll(sender As Object, e As EventArgs) Handles TrackBarTrasparenza.Scroll
        Me.Opacity = TrackBarTrasparenza.Value / TrackBarTrasparenza.Maximum
        My.Settings.FormHrdwareTras = TrackBarTrasparenza.Value / TrackBarTrasparenza.Maximum
    End Sub
End Class