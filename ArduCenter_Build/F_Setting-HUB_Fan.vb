Imports System.Runtime.InteropServices
Public Class F_Setting_HUB_Fan
    Public Imp_Open = 0
    Private Sub F_SettingFan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AngoliSmussati(Me)

        BtnImpostazioni_Click(sender, e)
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
    Private Sub F_SettingFan_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        Try
            ReleaseCapture()
            SendMessage(Me.Handle, &H112&, &HF012&, 0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnChiudi_Click(sender As Object, e As EventArgs) Handles BtnChiudi.Click
        Imp_Open = 0
        F_Hub_PC.BtnImpostazioniFan.BackgroundImage = My.Resources.BtnFanPage_Fan_Impostazioni_1_0
        Close()
    End Sub




    '//Funzione Multi Form GUI
    Public Sub SwitchPannelSet(ByVal GUI_Set_Form As Form)
        Try
            PanelFormSet.Controls.Clear()
            GUI_Set_Form.TopLevel = False
            PanelFormSet.Controls.Add(GUI_Set_Form)
            GUI_Set_Form.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnImpostazioni_Click(sender As Object, e As EventArgs) Handles BtnImpostazioni.Click
        If BtnImpostazioni.ForeColor <> Color.Gold Then
            PanelFormSet.Visible = True
            SwitchPannelSet(F_Impostazioni_HUB_Fan)
            BtnImpostazioni.ForeColor = Color.Gold

            BtnVentole.ForeColor = Color.White
            BtnSetGPU.ForeColor = Color.White
            BtnStriscaLED.ForeColor = Color.White
            BtnConnessione.ForeColor = Color.White

            InfoSetForm.Text = "Impostazioni Hub_Fan"
        End If
    End Sub

    Private Sub BtnVentole_Click(sender As Object, e As EventArgs) Handles BtnVentole.Click
        If BtnVentole.ForeColor <> Color.Gold Then
            PanelFormSet.Visible = True
            'SwitchPannelSet(F_Impostazioni_HUB_Ventole)
            BtnVentole.ForeColor = Color.Gold

            BtnImpostazioni.ForeColor = Color.White
            BtnSetGPU.ForeColor = Color.White
            BtnStriscaLED.ForeColor = Color.White
            BtnConnessione.ForeColor = Color.White

            InfoSetForm.Text = "Impostazioni Ventole"
        End If
        F_Avvio.FunzioneNull()
    End Sub

    Private Sub BtnSetGPU_Click(sender As Object, e As EventArgs) Handles BtnSetGPU.Click
        If BtnSetGPU.ForeColor <> Color.Gold Then
            PanelFormSet.Visible = True
            'SwitchPannelSet(F_Impostazioni_HUB_Fan)
            BtnSetGPU.ForeColor = Color.Gold

            BtnImpostazioni.ForeColor = Color.White
            BtnVentole.ForeColor = Color.White
            BtnStriscaLED.ForeColor = Color.White
            BtnConnessione.ForeColor = Color.White

            InfoSetForm.Text = "Impostazioni LED Scheda video"
        End If
        F_Avvio.FunzioneNull()
    End Sub

    Private Sub BtnStriscaLED_Click(sender As Object, e As EventArgs) Handles BtnStriscaLED.Click
        If BtnStriscaLED.ForeColor <> Color.Gold Then
            PanelFormSet.Visible = True
            'SwitchPannelSet(F_Impostazioni_HUB_Fan)
            BtnStriscaLED.ForeColor = Color.Gold

            BtnImpostazioni.ForeColor = Color.White
            BtnVentole.ForeColor = Color.White
            BtnSetGPU.ForeColor = Color.White
            BtnConnessione.ForeColor = Color.White

            InfoSetForm.Text = "Impostazioni Strisca LED"
        End If
        F_Avvio.FunzioneNull()
    End Sub

    Private Sub BtnConnessione_Click(sender As Object, e As EventArgs) Handles BtnConnessione.Click
        If BtnConnessione.ForeColor <> Color.Gold Then
            PanelFormSet.Visible = True
            'SwitchPannelSet(F_Impostazioni_HUB_Fan)
            BtnConnessione.ForeColor = Color.Gold

            BtnImpostazioni.ForeColor = Color.White
            BtnVentole.ForeColor = Color.White
            BtnSetGPU.ForeColor = Color.White
            BtnStriscaLED.ForeColor = Color.White

            InfoSetForm.Text = "Impostazioni Controllo Remoto"
        End If
        F_Avvio.FunzioneNull()
    End Sub

    Private Sub BtnNascondi_Click(sender As Object, e As EventArgs) Handles BtnNascondi.Click
        WindowState = FormWindowState.Minimized
    End Sub
End Class