Public Class F_HubPC_HUB

    Dim Info_Num_Btn As Integer
    Dim EL_Btn As Integer

    Private Sub F_HubPC_HUB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EL_Btn = 1
        Info_Num_Btn = 1
        Btn_EL_1_Click()
        Fan_Set_GUI()
    End Sub

    Public Sub GUI_Btn_HUB_Info()
        If F_Avvio.DatiRX_0(3) = "3" Then
            Btn_Casse_Info.Visible = True
            La_Casse_Info.Visible = True
            Btn_Dissipatore_Info.Visible = False
            La_Dissipatore_Info.Visible = False

        ElseIf F_Avvio.DatiRX_0(3) = "4" Then
            Btn_Casse_Info.Visible = False
            La_Casse_Info.Visible = False
            Btn_Dissipatore_Info.Visible = False
            La_Dissipatore_Info.Visible = False

        ElseIf F_Avvio.DatiRX_0(3) = "5" Then
            Btn_Casse_Info.Visible = False
            La_Casse_Info.Visible = False
            Btn_Dissipatore_Info.Visible = True
            La_Dissipatore_Info.Visible = True
        End If
    End Sub



    Private Sub Btn_Fan_Info_Click() Handles Btn_Fan_Info.Click
        Fan_Set_GUI()
    End Sub

    Private Sub Btn_Casse_Info_Click() Handles Btn_Casse_Info.Click
        CasseAudio_Set_GUI()
    End Sub

    Private Sub Btn_Dissipatore_Info_Click() Handles Btn_Dissipatore_Info.Click
        Dissipatore_Set_GUI()
    End Sub

    Private Sub Btn_GPU_Info_Click() Handles Btn_GPU_Info.Click
        GPU_Set_GUI()
    End Sub

    Private Sub Btn_StriscaLED_Info_Click() Handles Btn_StriscaLED_Info.Click
        StripLED_Set_GUI()
    End Sub





    Private Sub Fan_Set_GUI()
        EL_Btn = 1
        Info_Num_Btn = 1
        Btn_EL_1_Click()
        GUI_Full()
        Text_Set()
        La_Fan_Info.ForeColor = Color.White
        La_Elemento.Text = "Ventola 1"
        Btn_EL_1.Text = "Fan 1"
        Btn_EL_2.Text = "Fan 2"
        Btn_EL_3.Text = "Fan 3"
        Btn_EL_4.Text = "Fan 4"


    End Sub

    Private Sub CasseAudio_Set_GUI()
        EL_Btn = 2
        Info_Num_Btn = 1
        Btn_EL_1_Click()
        GUI_Lite()
        Text_Set()
        La_Casse_Info.ForeColor = Color.White
        La_Elemento.Text = "Cassa Audio Sinistra"
        Btn_EL_1.Text = "C - S"
        Btn_EL_2.Text = " LED "
        Btn_EL_3.Text = "C - D"
        Btn_EL_4.Text = ""
    End Sub

    Private Sub Dissipatore_Set_GUI()
        EL_Btn = 3
        Info_Num_Btn = 1
        Btn_EL_1_Click()
        'GUI_Lite()
        GUI_Mid()
        'GUI_Full()
        Text_Set()
        La_Dissipatore_Info.ForeColor = Color.White
        La_Elemento.Text = "Dissipatore CPU"
        Btn_EL_1.Text = "Fan 1"
        Btn_EL_2.Text = " CPU "
        Btn_EL_3.Text = "Fan 2"
        Btn_EL_4.Text = ""

        LaFanModalità.Text = "Auto"
    End Sub

    Private Sub GPU_Set_GUI()
        EL_Btn = 4
        'GUI_Lite()
        GUI_Mid()
        'GUI_Full()
        Text_Set()
        La_SchedaVideo_Info.ForeColor = Color.White
        La_Elemento.Text = "Scheda Video"
        Btn_EL_1.Text = ""
        Btn_EL_2.Text = ""
        Btn_EL_3.Text = ""
        Btn_EL_4.Text = ""

        LaFanModalità.Text = "Auto"
    End Sub

    Private Sub StripLED_Set_GUI()
        EL_Btn = 5
        GUI_Lite()
        Text_Set()
        La_StrepLED_Info.ForeColor = Color.White
        La_Elemento.Text = "Strisca LED"
        Btn_EL_1.Text = ""
        Btn_EL_2.Text = ""
        Btn_EL_3.Text = ""
        Btn_EL_4.Text = ""
    End Sub


    Private Sub GUI_Lite()
        LaN_Rotazione.Visible = False
        LaFanModalità.Visible = False
        LaN_Velocità.Visible = False
        LaVelocità.Visible = False
        LaN_RPM.Visible = False
        LaRPMvnetola.Visible = False
    End Sub

    Private Sub GUI_Mid()
        LaN_Rotazione.Visible = True
        LaFanModalità.Visible = True
        LaN_Velocità.Visible = False
        LaVelocità.Visible = False
        LaN_RPM.Visible = False
        LaRPMvnetola.Visible = False
    End Sub

    Private Sub GUI_Full()
        LaN_Rotazione.Visible = True
        LaFanModalità.Visible = True
        LaN_Velocità.Visible = True
        LaVelocità.Visible = True
        LaN_RPM.Visible = True
        LaRPMvnetola.Visible = True
    End Sub

    Private Sub Text_Set()
        La_Fan_Info.ForeColor = Color.DarkGray
        La_Casse_Info.ForeColor = Color.DarkGray
        La_Dissipatore_Info.ForeColor = Color.DarkGray
        La_SchedaVideo_Info.ForeColor = Color.DarkGray
        La_StrepLED_Info.ForeColor = Color.DarkGray
    End Sub



    Private Sub Btn_EL_1_Click() Handles Btn_EL_1.Click
        Btn_EL_Color()
        Btn_EL_1.ForeColor = Color.White
        Info_Num_Btn = 1
    End Sub

    Private Sub Btn_EL_2_Click() Handles Btn_EL_2.Click
        Btn_EL_Color()
        Btn_EL_2.ForeColor = Color.White
        Info_Num_Btn = 2
    End Sub

    Private Sub Btn_EL_3_Click() Handles Btn_EL_3.Click
        Btn_EL_Color()
        Btn_EL_3.ForeColor = Color.White
        Info_Num_Btn = 3
    End Sub

    Private Sub Btn_EL_4_Click() Handles Btn_EL_4.Click
        Btn_EL_Color()
        Btn_EL_4.ForeColor = Color.White
        Info_Num_Btn = 4
    End Sub

    Private Sub Btn_EL_Color()
        Btn_EL_1.ForeColor = Color.DarkGray
        Btn_EL_2.ForeColor = Color.DarkGray
        Btn_EL_3.ForeColor = Color.DarkGray
        Btn_EL_4.ForeColor = Color.DarkGray

    End Sub


    Public Sub Void_Loop()
        Select Case EL_Btn
            Case 1
                GUI_Ventole()
            Case 2
                GUI_Casse_Audio()
            Case 3
                GUI_Dissipatore()
            Case 4
                GUI_Scheda_Video()
            Case 5
                GUI_StriscaLED()
        End Select
    End Sub


    Public Sub GUI_Ventole()
        'Informazione RPM ventole
        Select Case Info_Num_Btn
            'Case = 0
            '    Dim ValRPM As Integer
            '    ValRPM = (((F_Avvio.DatiRX_10(0) * 30) + (F_Avvio.DatiRX_10(1) * 60) + (F_Avvio.DatiRX_10(2) * 60) + (F_Avvio.DatiRX_10(3) * 60) / 4)
            '    Select Case ValRPM
            '        Case 0 To 900
            '            LaRPMvnetola.Text = "Bassi" & ValRPM
            '        Case 901 To 1500
            '            LaRPMvnetola.Text = "Medi" & ValRPM
            '        Case 1501 To 3000
            '            LaRPMvnetola.Text = "Alti" & ValRPM
            '    End Select
            Case = 1
                La_Elemento.Text = "Ventola 1"
                LaRPMvnetola.Text = (F_Avvio.DatiRX_10(0) * 30)
            Case = 2
                La_Elemento.Text = "Ventola 2"
                LaRPMvnetola.Text = (F_Avvio.DatiRX_10(1) * 30)
            Case = 3
                La_Elemento.Text = "Ventola 3"
                LaRPMvnetola.Text = (F_Avvio.DatiRX_10(2) * 30)
            Case = 4
                La_Elemento.Text = "Ventola 4"
                LaRPMvnetola.Text = (F_Avvio.DatiRX_10(3) * 30)
        End Select
    End Sub
    Public Sub GUI_Casse_Audio()
        'Informazione Cassa Audio
        Select Case Info_Num_Btn
            Case = 1
                La_Elemento.Text = "Cassa Sinistra"
                LaRPMvnetola.Text = "-"
            Case = 2
                La_Elemento.Text = "Strisca LED"
                LaRPMvnetola.Text = "-"
            Case = 3
                La_Elemento.Text = "Cassa Destra"
                LaRPMvnetola.Text = "-"
            Case = 4

        End Select
    End Sub
    Public Sub GUI_Dissipatore()
        'Informazione Dissipatore
        Select Case Info_Num_Btn
            Case = 1
                La_Elemento.Text = "Ventola 1 CPU"
                LaRPMvnetola.Text = "-"
            Case = 2
                La_Elemento.Text = "Pompa CPU"
                LaRPMvnetola.Text = "-"
            Case = 3
                La_Elemento.Text = "Ventola 2 CPU"
                LaRPMvnetola.Text = "-"
            Case = 4

        End Select
    End Sub
    Public Sub GUI_Scheda_Video()

    End Sub
    Public Sub GUI_StriscaLED()

    End Sub






    Private Sub La_Fan_Info_Click(sender As Object, e As EventArgs) Handles La_Fan_Info.Click
        Btn_Fan_Info_Click()
    End Sub
    Private Sub La_Casse_Info_Click(sender As Object, e As EventArgs) Handles La_Casse_Info.Click
        CasseAudio_Set_GUI()
    End Sub
    Private Sub La_Dissipatore_Info_Click(sender As Object, e As EventArgs) Handles La_Dissipatore_Info.Click
        Dissipatore_Set_GUI()
    End Sub
    Private Sub La_SchedaVideo_Info_Click(sender As Object, e As EventArgs) Handles La_SchedaVideo_Info.Click
        GPU_Set_GUI()
    End Sub
    Private Sub La_StrepLED_Info_Click(sender As Object, e As EventArgs) Handles La_StrepLED_Info.Click
        StripLED_Set_GUI()
    End Sub
End Class