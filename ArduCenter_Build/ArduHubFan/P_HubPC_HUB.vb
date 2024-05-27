Imports System.IO
Public Class P_HubPC_HUB

    Dim Info_Num_Btn As Integer

    Private Sub F_HubPC_HUB_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub GUI_Btn_HUB_Info()
        If F_Avvio.DatiRX_0(3) = F_Avvio.ID_Dispositivo_ArduHubFan_3_0 Then
            Btn_Altro_Info.Visible = False
            La_Altro_Info.Visible = False

        ElseIf F_Avvio.DatiRX_0(3) = F_Avvio.ID_Dispositivo_ArduHubFanAudio_2_0 Or F_Avvio.DatiRX_0(3) = F_Avvio.ID_Dispositivo_ArduHubFan_4_0 Then
            Btn_Altro_Info.Visible = True
            La_Altro_Info.Visible = True
        End If
    End Sub


    'Bottoni Elemnti Click
    Private Sub Btn_HUB_Info_Click() Handles Btn_HUB_Info.Click
        'CasseAudio_Set_GUI()
        Hub_Set_GUI()
    End Sub
    Private Sub Btn_Fan_Info_Click() Handles Btn_Fan_Info.Click
        Fan_Set_GUI()
    End Sub
    Private Sub Btn_Altro_Info_Click() Handles Btn_Altro_Info.Click
        Dim Index As Integer
        If F_Avvio.CaricaDati_Boot = 0 Then
            Index = 3
        ElseIf F_Avvio.CaricaDati_Boot = 1 Then
            Index = 1
        End If

        If F_Avvio.DatiRX_0(Index) = F_Avvio.ID_Dispositivo_ArduHubFan_4_0 Then
            Dissipatore_Set_GUI()
        End If
        If F_Avvio.DatiRX_0(Index) = F_Avvio.ID_Dispositivo_ArduHubFanAudio_2_0 Then
            CasseAudio_Set_GUI()
        End If

    End Sub
    Private Sub Btn_GPU_Info_Click() Handles Btn_GPU_Info.Click
        GPU_Set_GUI()
    End Sub
    Private Sub Btn_StriscaLED_Info_Click() Handles Btn_StriscaLED_Info.Click
        StripLED_Set_GUI()
    End Sub



    'Imposta Graficamente L'elemento selezionato
    Public Sub Testo_ElementoSelezionato()
        Select Case F_Avvio.DatiRX_7(0)
            Case 0
                Hub_Set_GUI()
            Case 1, 2, 3, 4
                Fan_Set_GUI()
            Case 5, 6, 7
                Dissipatore_Set_GUI()
            Case 8
                GPU_Set_GUI()
            Case 9
                StripLED_Set_GUI()
            Case 10, 11, 12
                CasseAudio_Set_GUI()
        End Select

        'Label13.Text = Int(F_Avvio.DatiRX_7(0))
    End Sub

    'Quando viene premuto l'icona HUB
    Private Sub Hub_Set_GUI()
        If F_Avvio.Data10 <> 3 And F_Avvio.DatiRX_7(0) <> 0 Then
            F_Avvio.Data1 = 0
            F_Avvio.ConvertiColore.Swich_Elemtnto()

            F_Hub_PC.Btn_Men_RGB_Animation.Visible = True
            F_Hub_PC.BtnRGB1.Visible = True
            F_Hub_PC.BtnRGB2.Visible = True
            F_Hub_PC.BtnRGB4.Visible = True
            F_Hub_PC.BtnRGB5.Visible = True
            F_Hub_PC.BtnRGB3.Visible = True
        End If

        'Titolo Colorato come Selezionato
        'Btn_EL_1_Click()


        'Visualizza le Informzazione
        GUI_Full()

        'Nome Elemento Selezionato
        La_Elemento.Text = testo(1)

        'Testo Bottoni 
        Btn_EL_1.Text = ""
        Btn_EL_2.Text = ""
        Btn_EL_3.Text = ""
        Btn_EL_4.Text = ""

        'Gestione Rotazione Ventole
        LaFanModalità.Text = testo(41)
    End Sub



    'Quando viene premuto l'icona Ventola
    Private Sub Fan_Set_GUI()


        If F_Avvio.DatiRX_7(0) < 1 Or F_Avvio.DatiRX_7(0) > 4 Or F_Avvio.CaricaDati_Boot = 0 Then
            Set_Elemento(1)
            Btn_EL_1_Click()

            GUI_Full()
            La_Elemento.Text = testo(2)
            Btn_EL_1.Text = "Fan 1"
            Btn_EL_2.Text = "Fan 2"
            Btn_EL_3.Text = "Fan 3"
            Btn_EL_4.Text = "Fan 4"
        End If

        'Gestione Rotazione Ventole
        LaFanModalità.Text = testo(41)
    End Sub

    Private Sub CasseAudio_Set_GUI()

        If F_Avvio.DatiRX_7(0) < 10 Or F_Avvio.DatiRX_7(0) > 12 Or F_Avvio.CaricaDati_Boot = 0 Then
            Set_Elemento(10)
            Btn_EL_1_Click()


            GUI_Lite()
            La_Elemento.Text = testo(11)
            Btn_EL_1.Text = "C - S"
            Btn_EL_2.Text = " LED "
            Btn_EL_3.Text = "C - D"
            Btn_EL_4.Text = ""
        End If
    End Sub

    Private Sub Dissipatore_Set_GUI()

        If F_Avvio.DatiRX_7(0) < 5 Or F_Avvio.DatiRX_7(0) > 7 Or F_Avvio.CaricaDati_Boot = 0 Then
            Set_Elemento(7)
            Btn_EL_2_Click()

            GUI_Mid()
            La_Elemento.Text = testo(8)
            Btn_EL_1.Text = "Fan 1"
            Btn_EL_2.Text = " CPU "
            Btn_EL_3.Text = "Fan 2"
            Btn_EL_4.Text = ""

            LaFanModalità.Text = testo(42)

        End If
    End Sub

    Private Sub GPU_Set_GUI()

        If F_Avvio.DatiRX_7(0) <> 8 Then
            Set_Elemento(8)
        End If

        GUI_Mid()
        La_Elemento.Text = testo(9)
        Btn_EL_1.Text = ""
        Btn_EL_2.Text = ""
        Btn_EL_3.Text = ""
        Btn_EL_4.Text = ""

        LaFanModalità.Text = testo(42)
    End Sub

    Private Sub StripLED_Set_GUI()

        If F_Avvio.DatiRX_7(0) <> 9 Then
            Set_Elemento(9)
        End If

        GUI_Lite()
        La_Elemento.Text = testo(10)
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





    Private Sub Btn_EL_1_Click() Handles Btn_EL_1.Click
        'Btn_EL_Color()
        'Btn_EL_1.ForeColor = Color.White
        Info_Num_Btn = 1

        Elemento_Selezionato(F_Avvio.Data1)
    End Sub

    Private Sub Btn_EL_2_Click() Handles Btn_EL_2.Click
        'Btn_EL_Color()
        'Btn_EL_2.ForeColor = Color.White
        Info_Num_Btn = 2

        Elemento_Selezionato(F_Avvio.Data1)
    End Sub

    Private Sub Btn_EL_3_Click() Handles Btn_EL_3.Click
        'Btn_EL_Color()
        'Btn_EL_3.ForeColor = Color.White
        Info_Num_Btn = 3

        Elemento_Selezionato(F_Avvio.Data1)
    End Sub

    Private Sub Btn_EL_4_Click() Handles Btn_EL_4.Click
        'Btn_EL_Color()
        'Btn_EL_4.ForeColor = Color.White
        Info_Num_Btn = 4

        Elemento_Selezionato(F_Avvio.Data1)
    End Sub

    Private Sub Btn_EL_Color()
        Btn_EL_1.ForeColor = Color.DarkGray
        Btn_EL_2.ForeColor = Color.DarkGray
        Btn_EL_3.ForeColor = Color.DarkGray
        Btn_EL_4.ForeColor = Color.DarkGray

    End Sub

    'Imposta Graficamente L'elemento selezionato
    Public Sub Elemento_Selezionato(EL_ID As Integer)
        Select Case EL_ID
            Case 0
                GUI_Hub()
            Case 1, 2, 3, 4
                If F_Avvio.CaricaDati_Boot = 0 Then Info_Num_Btn = EL_ID
                GUI_Ventole()
            Case 5, 6, 7
                If F_Avvio.CaricaDati_Boot = 0 Then Info_Num_Btn = EL_ID - 4
                GUI_Dissipatore()
            Case 8
                GUI_Scheda_Video()
            Case 9
                GUI_StriscaLED()
            Case 10, 11, 12
                If F_Avvio.CaricaDati_Boot = 0 Then
                    Info_Num_Btn = EL_ID - 9
                    If Info_Num_Btn = 2 Then
                        Info_Num_Btn = 3
                    ElseIf Info_Num_Btn = 3 Then
                        Info_Num_Btn = 2
                    End If
                End If
                GUI_Casse_Audio()
        End Select
    End Sub


    Private Sub GUI_Hub()

    End Sub


    Public Sub GUI_Ventole()
        'Informazione RPM ventole
        Dim ID_EL As Integer = 0
        Btn_EL_Color()
        Select Case Info_Num_Btn
            Case = 1
                La_Elemento.Text = testo(2)
                'LaRPMvnetola.Text = (F_Avvio.DatiRX_10(0) * 30)
                Btn_EL_1.ForeColor = Color.White
                ID_EL = 1
            Case = 2
                La_Elemento.Text = testo(3)
                'LaRPMvnetola.Text = (F_Avvio.DatiRX_10(1) * 30)
                Btn_EL_2.ForeColor = Color.White
                ID_EL = 2
            Case = 3
                La_Elemento.Text = testo(4)
                'LaRPMvnetola.Text = (F_Avvio.DatiRX_10(2) * 30)
                Btn_EL_3.ForeColor = Color.White
                ID_EL = 3
            Case = 4
                La_Elemento.Text = testo(5)
                'LaRPMvnetola.Text = (F_Avvio.DatiRX_10(3) * 30)
                Btn_EL_4.ForeColor = Color.White
                ID_EL = 4
        End Select


        Set_Elemento(ID_EL)
    End Sub
    Public Sub GUI_Casse_Audio()
        'Informazione Cassa Audio
        Dim ID_EL As Integer = 0
        Btn_EL_Color()
        Select Case Info_Num_Btn
            Case = 1
                La_Elemento.Text = testo(11)
                LaRPMvnetola.Text = "-"
                Btn_EL_1.ForeColor = Color.White
                ID_EL = 10
            Case = 2
                La_Elemento.Text = testo(13)
                LaRPMvnetola.Text = "-"
                Btn_EL_2.ForeColor = Color.White
                ID_EL = 12
            Case = 3
                La_Elemento.Text = testo(12)
                LaRPMvnetola.Text = "-"
                Btn_EL_3.ForeColor = Color.White
                ID_EL = 11
            Case = 4

        End Select


        Set_Elemento(ID_EL)
    End Sub
    Public Sub GUI_Dissipatore()
        'Informazione Dissipatore
        Dim ID_EL As Integer = 0
        Btn_EL_Color()
        Select Case Info_Num_Btn
            Case = 1
                La_Elemento.Text = testo(6)
                LaRPMvnetola.Text = "-"
                Btn_EL_1.ForeColor = Color.White
                ID_EL = 5
            Case = 2
                La_Elemento.Text = testo(8)
                LaRPMvnetola.Text = "-"
                Btn_EL_2.ForeColor = Color.White
                ID_EL = 7
            Case = 3
                La_Elemento.Text = testo(7)
                LaRPMvnetola.Text = "-"
                Btn_EL_3.ForeColor = Color.White
                ID_EL = 6
            Case = 4

        End Select

        Set_Elemento(ID_EL)
    End Sub
    Public Sub GUI_Scheda_Video()

    End Sub
    Public Sub GUI_StriscaLED()

    End Sub


    Public Sub Set_Elemento(ID_EL As Integer)
        If F_Avvio.Data10 <> 3 And ID_EL <> F_Avvio.DatiRX_7(0) Then
            F_Avvio.Data1 = ID_EL
            F_Avvio.ConvertiColore.Swich_Elemtnto()
            F_Hub_PC.BtnOFF_Animation()
        End If
    End Sub

    'Lable Elemnti Click
    Private Sub La_HUB_Info_Click(sender As Object, e As EventArgs) Handles La_HUB_Info.Click
        'CasseAudio_Set_GUI()
        Hub_Set_GUI()
    End Sub
    Private Sub La_Fan_Info_Click(sender As Object, e As EventArgs) Handles La_Fan_Info.Click
        Btn_Fan_Info_Click()
    End Sub
    Private Sub La_Altro_Info_Click(sender As Object, e As EventArgs) Handles La_Altro_Info.Click
        Dim Index As Integer
        If F_Avvio.CaricaDati_Boot = 0 Then
            Index = 3
        ElseIf F_Avvio.CaricaDati_Boot = 1 Then
            Index = 1
        End If

        If F_Avvio.DatiRX_0(Index) = F_Avvio.ID_Dispositivo_ArduHubFan_4_0 Then
            Dissipatore_Set_GUI()
        End If
        If F_Avvio.DatiRX_0(Index) = F_Avvio.ID_Dispositivo_ArduHubFanAudio_2_0 Then
            CasseAudio_Set_GUI()
        End If
    End Sub
    Private Sub La_SchedaVideo_Info_Click(sender As Object, e As EventArgs) Handles La_SchedaVideo_Info.Click
        GPU_Set_GUI()
    End Sub
    Private Sub La_StrepLED_Info_Click(sender As Object, e As EventArgs) Handles La_StrepLED_Info.Click
        StripLED_Set_GUI()
    End Sub











    'Imposta la Finestra con l'Elemento selezionato
    Public Sub Elementi_Selezionato(ID As Integer)
        Text_Set()
        Select Case ID

            Case = 0
                La_HUB_Info.ForeColor = Color.White'Icona Hub

            Case = 1
                La_Fan_Info.ForeColor = Color.White 'Icona Ventola 1            
            Case = 2
                La_Fan_Info.ForeColor = Color.White  'Icona Ventola 2
            Case = 3
                La_Fan_Info.ForeColor = Color.White  'Icona Ventola 3
            Case = 4
                La_Fan_Info.ForeColor = Color.White 'Icona Ventola 4

            Case = 5
                La_Altro_Info.ForeColor = Color.White  'Icona Ventola 1 Dissipatore
            Case = 6
                La_Altro_Info.ForeColor = Color.White  'Icona Ventola 2 Dissipatore
            Case = 7
                La_Altro_Info.ForeColor = Color.White  'Icona Pompa Dissipatore



            Case = F_Hub_PC.IndirizzoElemento_SchedaVideo
                La_SchedaVideo_Info.ForeColor = Color.White 'Icona Scheda Video

            Case = F_Hub_PC.IndirizzoElemento_StriscaLED
                La_StrepLED_Info.ForeColor = Color.White 'Icona Striscia LED



            Case = 10
                La_Altro_Info.ForeColor = Color.White 'Icona Cassa Audio Sinistra
            Case = 11
                'If F_Avvio.DatiRX_0(3) = F_Avvio.ID_Dispositivo_ArduHubFanAudio_2_0 Then
                La_Altro_Info.ForeColor = Color.White 'Icona Cassa Audio Destra
                'End If
            Case = 12
                La_Altro_Info.ForeColor = Color.White 'Icona Striscia LED Cassa Audio


        End Select

        'If ID = 0 Then

        'Else

        'End If

        Dim R As Integer, G As Integer, B As Integer
        If F_Avvio.CaricaDati_Boot = 0 Then
            F_Avvio.ConvertiColore.HSV_to_RGB(F_Avvio.ConvertiColore.Elemento_H(F_Avvio.DatiRX_7(0)), F_Avvio.ConvertiColore.Elemento_S(F_Avvio.DatiRX_7(0)), F_Avvio.ConvertiColore.Elemento_V(F_Avvio.DatiRX_7(0)), R, G, B)
            'Colore_Elementi_Icone_Stato(F_Avvio.DatiRX_7(0), R, G, B)

        ElseIf F_Avvio.CaricaDati_Boot = 1 Then
            F_Avvio.ConvertiColore.HSV_to_RGB(F_Avvio.DatiRX_5(0), F_Avvio.DatiRX_6(0), F_Avvio.DatiRX_4(0), R, G, B)
        End If
        Colore_Elementi_Icone_Stato(F_Avvio.DatiRX_7(0), R, G, B)

        'La_HUB_Info.Text = F_SettingColor.ConvertiColore.Elemento_H(F_Avvio.DatiRX_7(0))
    End Sub
    Private Sub Text_Set()
        La_Fan_Info.ForeColor = Color.DarkGray
        La_HUB_Info.ForeColor = Color.DarkGray
        La_Altro_Info.ForeColor = Color.DarkGray
        La_SchedaVideo_Info.ForeColor = Color.DarkGray
        La_StrepLED_Info.ForeColor = Color.DarkGray
    End Sub



    'Calcola la posizione X della icona Elemento
    Public Function IconElemento_X(W_X As Decimal)
        Dim Pos_0 As Integer = 21
        Dim Pos_Full As Integer = 201
        Dim PosMid As Integer = (Pos_0 + Pos_Full) / 2
        PosMid = (PosMid - (W_X / 2))
        Return PosMid
    End Function

    'Calcola la posizione Y della icona Elemento
    Public Function IconElemento_Y(H_Y As Decimal)
        Dim Pos_0 As Integer = 27
        Dim Pos_Full As Integer = 207
        Dim PosMid As Integer = (Pos_0 + Pos_Full) / 2
        PosMid = (PosMid - (H_Y / 2))
        Return PosMid
    End Function


    'Imposta il Colore Icona Sato Elemento
    Public Sub Colore_Elementi_Icone_Stato(ID As Integer, R As Integer, G As Integer, B As Integer)

        Select Case ID
            Case = 0
                Icona_Color.BackColor = Color.FromArgb(R, G, B) 'Icona Hub
                Icona_Color.Size = New Size(My.Resources.Icona_HUB_1_1.Width * 1.5, My.Resources.Icona_HUB_1_1.Height * 1.5)
                Icona_Color.Location = New Point(IconElemento_X(Icona_Color.Width), (IconElemento_Y(Icona_Color.Height)))
                Icona_Color.BackgroundImage = My.Resources.Icona_HUB_1_1



            Case 1, 2, 3, 4
                Icona_Color.BackColor = Color.FromArgb(R, G, B) 'Icona Ventola 1,2,3,4           
                Icona_Color.Size = New Size(My.Resources.IconaFan_RGB_Colore_HSV_RGB_2_0.Width * 0.45, My.Resources.IconaFan_RGB_Colore_HSV_RGB_2_0.Height * 0.45)
                Icona_Color.Location = New Point(IconElemento_X(Icona_Color.Width), (IconElemento_Y(Icona_Color.Height)))
                Icona_Color.BackgroundImage = My.Resources.IconaFan_RGB_Colore_HSV_RGB_2_0



            Case 5, 6, 7
                Icona_Color.BackColor = Color.FromArgb(R, G, B) 'Icona Ventola 1 - 2, Pompa Dissipatore       
                Icona_Color.Size = New Size(My.Resources.Dissipatore240mm_HSV_v1_1.Width * 1.5, My.Resources.Dissipatore240mm_HSV_v1_1.Height * 1.5)
                Icona_Color.Location = New Point(IconElemento_X(Icona_Color.Width), (IconElemento_Y(Icona_Color.Height)))
                Icona_Color.BackgroundImage = My.Resources.Dissipatore240mm_HSV_v1_1




            Case = F_Hub_PC.IndirizzoElemento_SchedaVideo
                Icona_Color.BackColor = Color.FromArgb(R, G, B) 'Icona Scheda Video
                Icona_Color.Size = New Size(My.Resources.Icona_SchedaVideo_RGB_Colore_HSV_RGB_21.Width * 0.55, My.Resources.Icona_SchedaVideo_RGB_Colore_HSV_RGB_21.Height * 0.55)
                Icona_Color.Location = New Point(IconElemento_X(Icona_Color.Width), (IconElemento_Y(Icona_Color.Height)))
                Icona_Color.BackgroundImage = My.Resources.Icona_SchedaVideo_RGB_Colore_HSV_RGB_21

            Case = F_Hub_PC.IndirizzoElemento_StriscaLED
                Icona_Color.BackColor = Color.FromArgb(R, G, B) 'Icona Striscia LED
                Icona_Color.Size = New Size(My.Resources.Icona_Strisca__RGB_Colore_HSV_RGB_2_2_2.Width * 0.55, My.Resources.Icona_Strisca__RGB_Colore_HSV_RGB_2_2_2.Height * 0.55)
                Icona_Color.Location = New Point(IconElemento_X(Icona_Color.Width), (IconElemento_Y(Icona_Color.Height)))
                Icona_Color.BackgroundImage = ArduCenter.My.Resources.Icona_Strisca__RGB_Colore_HSV_RGB_2_2_2



            Case 10, 11, 12
                Icona_Color.BackColor = Color.FromArgb(R, G, B) 'Icona Cassa Audio Sinistra , Destra, Striscia LED 
                Icona_Color.Size = New Size(My.Resources.IconaCasaAudio_RGB_Colore_HSV_RGB.Width * 1.35, My.Resources.IconaCasaAudio_RGB_Colore_HSV_RGB.Height * 1.35)
                Icona_Color.Location = New Point(IconElemento_X(Icona_Color.Width), (IconElemento_Y(Icona_Color.Height)))
                Icona_Color.BackgroundImage = My.Resources.IconaCasaAudio_RGB_Colore_HSV_RGB


        End Select
        If F_Avvio.CaricaDati_Boot = 1 Then Icona_Clore_Animazione_UP()
    End Sub

    'Imposta le immagini della barra degli Elementi con o senza l'immagine HSV o Animazione in base all'elemento selezionato
    Public Sub Icona_Clore_Animazione_UP()

        'Carica il colore per ogni Elemento
        For C As Integer = 0 To 12
            'Colora le Icone
            Dim R As Integer, G As Integer, B As Integer
            F_Avvio.ConvertiColore.HSV_to_RGB(F_Avvio.ConvertiColore.Elemento_H(C), F_Avvio.ConvertiColore.Elemento_S(C), F_Avvio.ConvertiColore.Elemento_V(C), R, G, B)
            Carica_Colore_Elementi_Icone(C, R, G, B)
        Next

        'Imposta l'immagine degli Elementi HSV
        If F_Avvio.ConvertiColore.Elemento_H(0) <= F_Avvio.ConvertiColore.Hue_Max Then Btn_HUB_Info.BackgroundImage = My.Resources.Icona_HUB_1_1
        Btn_Fan_Info.BackgroundImage = My.Resources.IconaFan_RGB_Colore_HSV_RGB_2_0
        If F_Avvio.DatiRX_0(1) = F_Avvio.ID_Dispositivo_ArduHubFanAudio_2_0 Then Btn_Altro_Info.BackgroundImage = My.Resources.IconaCasaAudio_RGB_Colore_HSV_RGB
        If F_Avvio.DatiRX_0(1) = F_Avvio.ID_Dispositivo_ArduHubFan_4_0 Then Btn_Altro_Info.BackgroundImage = My.Resources.Dissipatore240mm_HSV_v1_1
        Btn_GPU_Info.BackgroundImage = My.Resources.Icona_SchedaVideo_RGB_Colore_HSV_RGB_21
        Btn_StriscaLED_Info.BackgroundImage = My.Resources.Icona_Strisca__RGB_Colore_HSV_RGB_2_2_2


    End Sub


    'Imposta il Colore all'Avvio Icone barra Elementi
    Public Sub Carica_Colore_Elementi_Icone(ID As Integer, R As Integer, G As Integer, B As Integer)


        'Verifica lo stato della connesione Seriale
        Dim Index As Integer
        If F_Avvio.CaricaDati_Boot = 0 Then
            Index = 3
        ElseIf F_Avvio.CaricaDati_Boot = 1 Then
            Index = 1
        End If

        Select Case ID
            Case = 0
                Btn_HUB_Info.BackColor = Color.FromArgb(R, G, B) 'Icona Hub

                Btn_Fan_Info.BackColor = Color.FromArgb(R, G, B) 'Icona Ventola 1    
                If F_Avvio.DatiRX_0(Index) = F_Avvio.ID_Dispositivo_ArduHubFan_4_0 Or F_Avvio.DatiRX_0(Index) = F_Avvio.ID_Dispositivo_ArduHubFanAudio_2_0 Then
                    Btn_Altro_Info.BackColor = Color.FromArgb(R, G, B) 'Icona Dissipatore 'Icona Cassa Audio
                End If
                Btn_GPU_Info.BackColor = Color.FromArgb(R, G, B) 'Icona Scheda Video
                Btn_StriscaLED_Info.BackColor = Color.FromArgb(R, G, B) 'Icona Striscia LED

            Case = 1
                Btn_Fan_Info.BackColor = Color.FromArgb(R, G, B) 'Icona Ventola 1            
            Case = 2
                'Icona Ventola 2
            Case = 3
                'Icona Ventola 3
            Case = 4
                'Icona Ventola 4



            Case = 5
                'Icona Ventola 1 Dissipatore
            Case = 6
                'Icona Ventola 2 Dissipatore
            Case = 7
                If F_Avvio.DatiRX_0(Index) = F_Avvio.ID_Dispositivo_ArduHubFan_4_0 Then
                    Btn_Altro_Info.BackColor = Color.FromArgb(R, G, B) 'Icona Pompa Dissipatore
                End If



            Case = F_Hub_PC.IndirizzoElemento_SchedaVideo
                Btn_GPU_Info.BackColor = Color.FromArgb(R, G, B) 'Icona Scheda Video

            Case = F_Hub_PC.IndirizzoElemento_StriscaLED
                Btn_StriscaLED_Info.BackColor = Color.FromArgb(R, G, B) 'Icona Striscia LED



            Case = 10
                'Icona Cassa Audio Sinistra
                If F_Avvio.DatiRX_0(Index) = F_Avvio.ID_Dispositivo_ArduHubFanAudio_2_0 Then
                    Btn_Altro_Info.BackColor = Color.FromArgb(R, G, B)
                End If
            Case = 11
                   'Icona Cassa Audio Destra

            Case = 12
                'Icona Striscia LED Cassa Audio


        End Select

    End Sub








    'Calcola la posizione X della icona Elemento
    Public Function IconElementi_X(W_X As Decimal, Pos_0 As Integer, Pos_Full As Integer)
        'Dim Pos_0 As Integer = 21
        'Dim Pos_Full As Integer = 201
        Dim PosMid As Integer = (Pos_0 + Pos_Full) / 2
        PosMid = (PosMid - (W_X / 2))
        Return PosMid
    End Function

    'Calcola la posizione Y della icona Elemento
    Public Function IconElementi_Y(H_Y As Decimal, Pos_0 As Integer, Pos_Full As Integer)
        'Dim Pos_0 As Integer = 27
        'Dim Pos_Full As Integer = 207
        Dim PosMid As Integer = (Pos_0 + Pos_Full) / 2
        PosMid = (PosMid - (H_Y / 2))
        Return PosMid
    End Function

    'Imposta l'immagine all'Avvio Icone barra Elementi
    Public Sub Carica_Immagini_Elementi_Icone()

        Dim Index As Integer
        If F_Avvio.CaricaDati_Boot = 0 Then
            Index = 3
        ElseIf F_Avvio.CaricaDati_Boot = 1 Then
            Index = 1
        End If

        If F_Avvio.DatiRX_0(Index) = F_Avvio.ID_Dispositivo_ArduHubFan_4_0 Then
            Btn_Altro_Info.Size = New Size(My.Resources.Dissipatore240mm_HSV_v1_1.Width * 0.9, My.Resources.Dissipatore240mm_HSV_v1_1.Height * 0.9)
            Btn_Altro_Info.Location = New Point(IconElementi_X(Btn_Altro_Info.Width, 203, 315), (IconElementi_Y(Btn_Altro_Info.Height, 286, 355)))
            Btn_Altro_Info.BackgroundImage = My.Resources.Dissipatore240mm_HSV_v1_1
        ElseIf F_Avvio.DatiRX_0(Index) = F_Avvio.ID_Dispositivo_ArduHubFanAudio_2_0 Then
            Btn_Altro_Info.Size = New Size(My.Resources.IconaCasaAudio_RGB_Colore_HSV_RGB.Width * 0.8, My.Resources.IconaCasaAudio_RGB_Colore_HSV_RGB.Height * 0.8)
            Btn_Altro_Info.Location = New Point(IconElementi_X(Btn_Altro_Info.Width, 203, 315), (IconElementi_Y(Btn_Altro_Info.Height, 286, 355)))
            Btn_Altro_Info.BackgroundImage = My.Resources.IconaCasaAudio_RGB_Colore_HSV_RGB
        End If


    End Sub




    'Imposta l'immagine della icona selezionata cona l'immagine "Annimata"
    Public Sub Animazione_RGB_Icone(EL As Integer, A_RGB As String)

        'Verifica lo stato della connesione Seriale
        Dim Index As Integer
        Dim Colore As Integer
        If F_Avvio.CaricaDati_Boot = 0 Then
            Index = 3
            Colore = F_Avvio.DatiRX_5(F_Avvio.DatiRX_7(0))
        ElseIf F_Avvio.CaricaDati_Boot = 1 Then
            Index = 1
            Colore = F_Avvio.DatiRX_5(0)
        End If

        If EL = 0 And Colore > F_Avvio.ConvertiColore.Hue_Max Then
            Select Case A_RGB

                Case = F_Hub_PC.ColorNome(9)
                    Icona_Color.BackgroundImage = My.Resources.Icona_HUB_1_1_RGB_Colore_Transizione
                    '
                    Btn_HUB_Info.BackgroundImage = My.Resources.Icona_HUB_1_1_RGB_Colore_Transizione
                    Btn_Fan_Info.BackgroundImage = My.Resources.IconaFan_RGB_Colore_Transizione_2_0
                    If F_Avvio.DatiRX_0(Index) = F_Avvio.ID_Dispositivo_ArduHubFanAudio_2_0 Then Btn_Altro_Info.BackgroundImage = My.Resources.IconaCasaAudio_RGB_Colore_Transizione
                    If F_Avvio.DatiRX_0(Index) = F_Avvio.ID_Dispositivo_ArduHubFan_4_0 Then Btn_Altro_Info.BackgroundImage = My.Resources.Dissipatore240mm_Colore_Transizione
                    Btn_GPU_Info.BackgroundImage = My.Resources.Icona_SchedaVideo_Effeto_Transizione
                    Btn_StriscaLED_Info.BackgroundImage = My.Resources.Icona_Strisca__RGB_Colore_Transizione

                Case = F_Hub_PC.ColorNome(10)
                    Icona_Color.BackgroundImage = My.Resources.Icona_HUB_1_1_RGB_Colore_RainBow
                    '
                    Btn_HUB_Info.BackgroundImage = My.Resources.Icona_HUB_1_1_RGB_Colore_RainBow
                    Btn_Fan_Info.BackgroundImage = My.Resources.IconaFan_RGB_Colore_RainBow
                    If F_Avvio.DatiRX_0(Index) = F_Avvio.ID_Dispositivo_ArduHubFanAudio_2_0 Then Btn_Altro_Info.BackgroundImage = My.Resources.IconaCasaAudio_RGB_Colore_RainBow
                    If F_Avvio.DatiRX_0(Index) = F_Avvio.ID_Dispositivo_ArduHubFan_4_0 Then Btn_Altro_Info.BackgroundImage = My.Resources.Dissipatore240mm_Colore_RainBow
                    Btn_GPU_Info.BackgroundImage = My.Resources.Icona_SchedaVideo_Effeto_RainBow
                    Btn_StriscaLED_Info.BackgroundImage = My.Resources.Icona_Strisca__RGB_Colore_RainBow

                Case = F_Hub_PC.ColorNome(13)
                    Icona_Color.BackgroundImage = My.Resources.Icona_HUB_1_1_RGB_Colore_Discontinuo
                    '
                    Btn_HUB_Info.BackgroundImage = My.Resources.Icona_HUB_1_1_RGB_Colore_Discontinuo
                    Btn_Fan_Info.BackgroundImage = My.Resources.IconaFan_RGB_Colore_Transizione
                    If F_Avvio.DatiRX_0(Index) = F_Avvio.ID_Dispositivo_ArduHubFanAudio_2_0 Then Btn_Altro_Info.BackgroundImage = My.Resources.IconaCasaAudio_RGB_Colore_Discontinuo
                    If F_Avvio.DatiRX_0(Index) = F_Avvio.ID_Dispositivo_ArduHubFan_4_0 Then Btn_Altro_Info.BackgroundImage = My.Resources.Dissipatore240mm_Colore_Discontinuo
                    Btn_GPU_Info.BackgroundImage = My.Resources.Icona_SchedaVideo_Effeto_Discontinuo
                    Btn_StriscaLED_Info.BackgroundImage = My.Resources.Icona_Strisca__RGB_Colore_Discontinuo

                Case = F_Hub_PC.ColorNome(12)
                    Icona_Color.BackgroundImage = My.Resources.Icona_HUB_1_1_RGB_Colore_Musica
                    '
                    Btn_HUB_Info.BackgroundImage = My.Resources.Icona_HUB_1_1_RGB_Colore_Musica
                    Btn_Fan_Info.BackgroundImage = My.Resources.IconaFan_RGB_Colore_Musica_2_0
                    If F_Avvio.DatiRX_0(Index) = F_Avvio.ID_Dispositivo_ArduHubFanAudio_2_0 Then Btn_Altro_Info.BackgroundImage = My.Resources.IconaCasaAudio_RGB_Colore_Musica
                    If F_Avvio.DatiRX_0(Index) = F_Avvio.ID_Dispositivo_ArduHubFan_4_0 Then Btn_Altro_Info.BackgroundImage = My.Resources.Dissipatore240mm_Colore_Musica
                    Btn_GPU_Info.BackgroundImage = My.Resources.Icona_SchedaVideo_Effeto_Musica
                    Btn_StriscaLED_Info.BackgroundImage = My.Resources.Icona_Strisca__RGB_Colore_Musica

                Case = F_Hub_PC.ColorNome(9)
                    'Temperatura
                    'Icona_Color.BackgroundImage = My.Resources.Icona_HUB_1_1_RGB_Colore_Musica
                    ''
                    'Btn_HUB_Info.BackgroundImage = My.Resources.Icona_HUB_1_1_RGB_Colore_Musica
                    'Btn_Fan_Info.BackgroundImage = My.Resources.IconaFan_RGB_Colore_Musica_2_0
                    'If F_Avvio.DatiRX_0(3) = F_Avvio.ID_Dispositivo_ArduHubFanAudio_2_0 Then Btn_Altro_Info.BackgroundImage = My.Resources.IconaCasaAudio_RGB_Colore_Musica
                    'If F_Avvio.DatiRX_0(3) = F_Avvio.ID_Dispositivo_ArduHubFan_4_0 Then Btn_Altro_Info.BackgroundImage = My.Resources.Dissipatore240mm_Colore_Musica
                    'Btn_GPU_Info.BackgroundImage = My.Resources.Icona_SchedaVideo_Effeto_Musica
                    'Btn_StriscaLED_Info.BackgroundImage = My.Resources.Icona_Strisca__RGB_Colore_Musica

                Case = F_Hub_PC.ColorNome(14)
                    'Hallowen
                    'Icona_Color.BackgroundImage = My.Resources.Icona_HUB_1_1_RGB_Colore_Musica
                    ''
                    'Btn_HUB_Info.BackgroundImage = My.Resources.Icona_HUB_1_1_RGB_Colore_Musica
                    'Btn_Fan_Info.BackgroundImage = My.Resources.IconaFan_RGB_Colore_Musica_2_0
                    'If F_Avvio.DatiRX_0(3) = F_Avvio.ID_Dispositivo_ArduHubFanAudio_2_0 Then Btn_Altro_Info.BackgroundImage = My.Resources.IconaCasaAudio_RGB_Colore_Musica
                    'If F_Avvio.DatiRX_0(3) = F_Avvio.ID_Dispositivo_ArduHubFan_4_0 Then Btn_Altro_Info.BackgroundImage = My.Resources.Dissipatore240mm_Colore_Musica
                    'Btn_GPU_Info.BackgroundImage = My.Resources.Icona_SchedaVideo_Effeto_Musica
                    'Btn_StriscaLED_Info.BackgroundImage = My.Resources.Icona_Strisca__RGB_Colore_Musica

            End Select

        Else

            Select Case A_RGB

                Case = F_Hub_PC.ColorNome(9)
                    Btn_HUB_Info.BackgroundImage = My.Resources.Icona_HUB_1_1_RGB_Colore_Transizione

                Case = F_Hub_PC.ColorNome(10)
                    Btn_HUB_Info.BackgroundImage = My.Resources.Icona_HUB_1_1_RGB_Colore_RainBow

                Case = F_Hub_PC.ColorNome(13)
                    Btn_HUB_Info.BackgroundImage = My.Resources.Icona_HUB_1_1_RGB_Colore_Discontinuo

                Case = F_Hub_PC.ColorNome(12)
                    Btn_HUB_Info.BackgroundImage = My.Resources.Icona_HUB_1_1_RGB_Colore_Musica

                Case = F_Hub_PC.ColorNome(9)
                    'Temperatura
                    'F_HubPC_HUB.Btn_HUB_Info.BackgroundImage = My.Resources.Icona_HUB_1_1_RGB_Colore_Musica

                Case = F_Hub_PC.ColorNome(14)
                    'Hallowen
                    'F_HubPC_HUB.Btn_HUB_Info.BackColor = Color.DarkRed

            End Select

        End If

        'La_HUB_Info.Text = EL
    End Sub

    Public Sub Sensori_Dati(Temperatura As Integer)

        'Visualiza la Temepratura del Sensore HUB
        If TempSenS.Maximum >= Temperatura Then
            TempSenS.Text = Temperatura
            TempSenS.Value = Temperatura
        End If
        If Temperatura > TempSenS.Maximum Then
            TempSenS.Maximum = Temperatura
            TempSenS.Text = Temperatura
            TempSenS.Value = Temperatura
        End If

    End Sub

















    'Lingua Finestra Titoli
    ' //-- Lingua finestra e pagine
    Dim testo As String()
    Public Sub CambiaLingua(lingua As String)

        ' Combina il percorso relativo del file con il percorso della cartella dell'applicazione
        Dim percorsoFile As String = Path.Combine(F_Impostazioni.cartellaLingue, lingua, "F_HubPC_HUB.txt")
        ' Leggi il testo dal file per le due etichette
        testo = F_Impostazioni.LeggiTestoDaFile(percorsoFile)


        Try
            ' Modifica il testo delle etichette dell'interfaccia con il testo letto dal file
            'Titoli
            'LabelColore.Text = testo(1)

            LColore.Text = testo(25)
            LLuminosità.Text = testo(26)
            LaN_Rotazione.Text = testo(27)
            LaN_Velocità.Text = testo(28)

            'LaN_RPM.Text = testo(29)
            'LaN_RPM.Text = testo(30)


            La_HUB_Info.Text = testo(53)
            La_Fan_Info.Text = testo(54)


            Dim Index As Integer
            If F_Avvio.CaricaDati_Boot = 0 Then
                Index = 3
            ElseIf F_Avvio.CaricaDati_Boot = 1 Then
                Index = 1
            End If

            If F_Avvio.SerialPortArduino.IsOpen = True Then
                If F_Avvio.DatiRX_0(Index) = F_Avvio.ID_Dispositivo_ArduHubFan_4_0 Then
                    La_Altro_Info.Text = testo(55)
                End If
                If F_Avvio.DatiRX_0(Index) = F_Avvio.ID_Dispositivo_ArduHubFanAudio_2_0 Then
                    La_Altro_Info.Text = testo(58)
                End If
                'La_Altro_Info.Text = testo(55)
                'La_Altro_Info.Text = testo(58)
            End If

            La_SchedaVideo_Info.Text = testo(56)
            La_StrepLED_Info.Text = testo(57)


        Catch ex As Exception

        End Try
        'F_SettingColor.ConvertiColore.BtnColore(RGBAMenù)
    End Sub
End Class