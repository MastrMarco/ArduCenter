Imports System.Runtime.InteropServices
Public Class F_Setting_HUB

    Public Imp_Open = 0
    Private Sub F_SettingFan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AngoliSmussati(Me)

        BtnImpostazioni_Click(sender, e)

        'Carica Array GUI
        F_Avvio.Classe_Impostazioni_HUB_LED.Load()
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
        F_Hub_PC.BtnImpostazioniFan.BackgroundImage = My.Resources.BtnGUI_HomeImpostazioni

        'Salva Dati Impostati [Esce dalla Modalità Configurazione]
        If F_Avvio.Data10 = 3 Then
            F_Avvio.Data10 = F_Avvio.Classe_Impostazioni_HUB_LED.DataEEPROM_Save
            F_Avvio.Data1 = F_Avvio.Classe_Impostazioni_HUB_LED.DataElement_Save
        End If
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
            BtnColorSet()
            PanelFormSet.Visible = True
            SwitchPannelSet(P_Impostazioni_HUB)
            BtnImpostazioni.ForeColor = Color.Gold

            InfoSetForm.Text = "Impostazioni Hub_Fan"
        End If
    End Sub

    Private Sub BtnVentole_Click(sender As Object, e As EventArgs) Handles BtnVentole.Click
        If BtnVentole.ForeColor <> Color.Gold Then
            BtnColorSet()
            PanelFormSet.Visible = True
            SwitchPannelSet(P_Impostazioni_HUB_Ventole)
            BtnVentole.ForeColor = Color.Gold

            If F_Avvio.Data10 = 3 Then
                P_Impostazioni_HUB_Ventole.BtnColorSet()
                'Classe_Impostazioni_HUB_LED.Loop_Set_Elementi(F_Avvio.Data1)           
            End If

            InfoSetForm.Text = "Impostazioni Ventole"

            'Aggiorna Dati Elementi
            F_Avvio.Classe_Impostazioni_HUB_LED.Aggiorna_Data(1, 4)
        End If

    End Sub

    Private Sub BtnSetGPU_Click(sender As Object, e As EventArgs) Handles BtnSet_GPU_StripLED.Click
        If BtnSet_GPU_StripLED.ForeColor <> Color.Gold Then
            BtnColorSet()
            PanelFormSet.Visible = True
            SwitchPannelSet(P_Impostazioni_HUB_GPU_StripLED)
            BtnSet_GPU_StripLED.ForeColor = Color.Gold

            If F_Avvio.Data10 = 3 Then
                P_Impostazioni_HUB_GPU_StripLED.BtnColorSet()
                'Classe_Impostazioni_HUB_LED.Loop_Set_Elementi(F_Avvio.Data1)
            End If

            InfoSetForm.Text = "Impostazioni LED Scheda video e Strica LED"

            'Aggiorna Dati Elementi
            F_Avvio.Classe_Impostazioni_HUB_LED.Aggiorna_Data(8, 9)
        End If

    End Sub

    Private Sub BtnAltro_Click(sender As Object, e As EventArgs) Handles BtnAltro.Click
        If BtnAltro.ForeColor <> Color.Gold Then
            BtnColorSet()
            PanelFormSet.Visible = True

            BtnAltro.ForeColor = Color.Gold


            If F_Avvio.DatiRX_0(1) = "3" Then
                InfoSetForm.Text = "Impostazioni Casse Audio e Strisca LED"
                SwitchPannelSet(P_Impostazioni_HUB_Altro_CassaAudio)
                If F_Avvio.Data10 = 3 Then
                    P_Impostazioni_HUB_Altro_CassaAudio.BtnColorSet()
                End If
                'Aggiorna Dati Elementi
                F_Avvio.Classe_Impostazioni_HUB_LED.Aggiorna_Data(10, 12)
            ElseIf F_Avvio.DatiRX_0(1) = "5" Then
                InfoSetForm.Text = "Impostazioni Dissipatore"
                SwitchPannelSet(P_Impostazioni_HUB_Altro_Dissipatore)
                If F_Avvio.Data10 = 3 Then
                    P_Impostazioni_HUB_Altro_Dissipatore.BtnColorSet()
                End If
                'Aggiorna Dati Elementi
                F_Avvio.Classe_Impostazioni_HUB_LED.Aggiorna_Data(5, 7)
            End If



        End If
        'F_Avvio.FunzioneNull()
    End Sub

    Private Sub BtnConnessione_Click(sender As Object, e As EventArgs) Handles BtnConfigurazione.Click
        If BtnConfigurazione.ForeColor <> Color.Gold Then
            BtnColorSet()
            PanelFormSet.Visible = True
            'SwitchPannelSet(F_Impostazioni_HUB_Fan)
            BtnConfigurazione.ForeColor = Color.Gold

            InfoSetForm.Text = "Impostazioni Controllo Remoto"
        End If
        F_Avvio.FunzioneNull()
    End Sub

    Private Sub BtnNascondi_Click(sender As Object, e As EventArgs) Handles BtnNascondi.Click
        WindowState = FormWindowState.Minimized
    End Sub




    'Info Finestra
    Private Sub Info_Settings_HUB_Click(sender As Object, e As EventArgs) Handles Info_Settings_HUB.Click
        '
        If BtnImpostazioni.ForeColor = Color.Gold Then

        End If
        '
        If BtnVentole.ForeColor = Color.Gold Then
            If F_Avvio.DatiRX_0(1) = "3" Or F_Avvio.DatiRX_0(1) = "4" Then
                F_Avvio.ErrorMod = 201
            ElseIf F_Avvio.DatiRX_0(1) = "5" Then
                F_Avvio.ErrorMod = 200
            End If
            F_Avvisi.LabelID_Error.Text = "Info Code " & F_Avvio.ErrorMod
            F_Avvisi.AvvisoErrore()
        End If
        '
        If BtnSet_GPU_StripLED.ForeColor = Color.Gold Then
            If F_Avvio.DatiRX_0(1) = "3" Or F_Avvio.DatiRX_0(1) = "4" Then
                F_Avvio.ErrorMod = 201
            ElseIf F_Avvio.DatiRX_0(1) = "5" Then
                F_Avvio.ErrorMod = 200
            End If
            F_Avvisi.LabelID_Error.Text = "Info Code " & F_Avvio.ErrorMod
            F_Avvisi.AvvisoErrore()
        End If
        '
        If BtnAltro.ForeColor = Color.Gold Then
            If F_Avvio.DatiRX_0(1) = "3" Or F_Avvio.DatiRX_0(1) = "4" Then
                F_Avvio.ErrorMod = 201
            ElseIf F_Avvio.DatiRX_0(1) = "5" Then
                F_Avvio.ErrorMod = 200
            End If
            F_Avvisi.LabelID_Error.Text = "Info Code " & F_Avvio.ErrorMod
            F_Avvisi.AvvisoErrore()
        End If
        '
        If BtnConfigurazione.ForeColor = Color.Gold Then

        End If
    End Sub











    Private Sub BtnColorSet()
        BtnConfigurazione.ForeColor = Color.White
        BtnImpostazioni.ForeColor = Color.White
        BtnVentole.ForeColor = Color.White
        BtnSet_GPU_StripLED.ForeColor = Color.White
        BtnAltro.ForeColor = Color.White
    End Sub
End Class