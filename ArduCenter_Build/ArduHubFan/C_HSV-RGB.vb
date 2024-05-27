Public Class C_HSV_RGB

    Public IndirizzoTipoDispositivo As Integer = 1 'Tipo Progetto

    'ID_Dispositivo_ArduHubFanAudio_2_0 = "3"
    'ID_Dispositivo_ArduHubFan_3_0 = "4"
    'ID_Dispositivo_ArduHubFan_4_0 = "5"

    Public IndirizzoElemento_SchedaVideo As Integer = 8 'Scheda Video
    Public IndirizzoElemento_StriscaLED As Integer = 9  'Scheda Striscia LED Case

    'Valori Colore - Animazioni
    Public Hue_Min As Integer = 0
    Public Hue_Max As Integer = 512
    Public A_RGB_Max As Integer = 605

    Public Luminosità_MIN As Integer = 13
    Public Luminosità_MAX As Integer = 255


    'Funzione map dati
    Public Function map(ByVal x As Long, ByVal in_min As Long, ByVal in_max As Long, ByVal out_min As Long, ByVal out_max As Long) As Long
        Return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min
    End Function

    '                                  0    1    2    3    4    5    6    7    8    9    10   11   12
    Public Elemento_H() As Integer = {128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128} 'Colore
    Public Elemento_S() As Integer = {128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128} 'Saturazione
    Public Elemento_V() As Integer = {128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128} 'Luminosità

    'Old Versione H= 512 S= 255 V= 255
    Public Sub HSV_to_RGB(ByVal H As Integer, ByVal S As Integer, ByVal V As Integer, ByRef R As Integer, ByRef G As Integer, ByRef B As Integer)

        'Verifica la Modaliata di Colorazione
        If H >= Hue_Min And H <= Hue_Max Then

            'Correzione Luminosità Minima
            If V > 0 Then
                V = map(V, 0, 255, 100, 255)
            End If

            'HSV to RGB
            Dim MinVal As Byte
            Dim MaxVal As Byte
            Dim Chroma As Byte
            Dim TempH As Single

            If V = 0 Then
                R = 0
                G = 0
                B = 0
            Else
                If S = 0 Then
                    R = V
                    G = V
                    B = V
                Else
                    MaxVal = V
                    Chroma = S / 255 * MaxVal
                    MinVal = MaxVal - Chroma
                    Select Case H
                        Case Is >= 340
                            TempH = (H - 340) / 86
                            If TempH < 1 Then
                                B = MaxVal
                                R = MaxVal * TempH
                            Else
                                R = MaxVal
                                B = MaxVal * (2 - TempH)
                            End If
                            G = 0
                        Case Is >= 170
                            TempH = (H - 170) / 86
                            If TempH < 1 Then
                                G = MaxVal
                                B = MaxVal * TempH
                            Else
                                B = MaxVal
                                G = MaxVal * (2 - TempH)
                            End If
                            R = 0
                        Case Else
                            TempH = H / 86
                            If TempH < 1 Then
                                R = MaxVal
                                G = MaxVal * TempH
                            Else
                                G = MaxVal
                                R = MaxVal * (2 - TempH)
                            End If
                            B = 0
                    End Select
                    R = R / MaxVal * (MaxVal - MinVal) + MinVal
                    G = G / MaxVal * (MaxVal - MinVal) + MinVal
                    B = B / MaxVal * (MaxVal - MinVal) + MinVal
                End If

            End If


            'Se il colore mipostato è una Animazione
        ElseIf H > Hue_Max And H <= A_RGB_Max Then
            R = 7
            G = 4
            B = 31


        End If

    End Sub



    'Imposta il Valore del Elemento Sulla seriale quando si cambia l'elemento selezionato
    Public Sub Swich_Elemtnto()

        'If F_Avvio.DatiRX_3(0) = 1 Then
        'If F_Avvio.Data1 = 1 Then
        F_Avvio.Data3 = Elemento_H(F_Avvio.Data1)
        F_Avvio.Data4 = Elemento_S(F_Avvio.Data1)
        F_Avvio.Data2 = Elemento_V(F_Avvio.Data1)
        'F_Avvio.Data5 = S_Fan_1 'Speed
        'End If

        'Sincorniza i dati della Velocita con L'elemento Selezionato
        If F_Avvio.Data1 >= 0 And F_Avvio.Data1 < 5 Then F_Hub_PC.ControlloVelocitaVentole.Set_Velocità(F_Avvio.Data1)
    End Sub

    'Aggiorna il Valore del Elemento Sulla seriale quando si cambia il colore
    Public Sub ColorUP_Elemtnto(Tag As String, ByRef V As Integer, ID_Menù As Integer)

        'Dim Colore As Integer = Array.IndexOf(F_Hub_PC.ColorNome, Tag)
        Dim Colore As Integer
        For n = 0 To F_Hub_PC.ColorNome.Length - 1

            If F_Hub_PC.ColorNome(n) = Tag And ID_Menù = F_Hub_PC.BtnMenuPos(n) Then
                Colore = n
                Exit For
            End If

        Next


        'Carica Seriale.
        F_Avvio.Data3 = F_Hub_PC.H_Val(Colore)
        F_Avvio.Data4 = F_Hub_PC.S_Val(Colore)

        'Imposta Colore Spento
        If F_Hub_PC.H_Val(Colore) = 0 And F_Hub_PC.S_Val(Colore) = 0 Then
            Luminos_Elemento(0)
        ElseIf F_Avvio.DatiRX_4(0) < 13 Then
            'Imposta Luminosità al 50%
            V = 255 / 2
            Luminos_Elemento(V)
        End If


        'Aggiorna Valore Array
        Elemento_H(F_Avvio.Data1) = F_Avvio.Data3
        Elemento_S(F_Avvio.Data1) = F_Avvio.Data4

        '  F_Hub_PC.LabelColore.Text = ID_Menù & " " & F_Hub_PC.H_Val(Colore) & " " & F_Hub_PC.S_Val(Colore) & " " & Tag
    End Sub

    'Aggiorna la Luminosità Colore dell'Elemento Selezionato
    Public Sub Luminos_Elemento(Lux As Integer)
        F_Avvio.Data2 = Lux
        Elemento_V(F_Avvio.Data1) = F_Avvio.Data2
    End Sub



    ' 'Lingua
    ' F_Hub_PC.  ID_ColoreN(24) As Integer
    ' F_Hub_PC. ColorNome(24) As String
    ' 'Data
    ' F_Hub_PC.  ID_ColoreVal(24) As Integer
    ' F_Hub_PC.  H_Val(24) As Integer
    ' F_Hub_PC. S_Val(24) As Integer
    ' Public BtnPosizione(24) As String
    ' Public BtnMenuPos(30) As Integer

    'Button Carica Colore selezionato silla seriale











    'Restituisce il Nome del Colore
    Public Function Nome_Colore(H As Integer, S As Integer)
        Dim ID As Integer
        Dim n As Integer
        For n = 0 To F_Hub_PC.H_Val.Length - 1
            'For d As Integer = 0 To F_Hub_PC.S_Val.Length - 1

            If F_Hub_PC.H_Val(n) = H And F_Hub_PC.S_Val(n) = S Then
                ID = n
                Exit For
            End If

            'Next
        Next

        If ID = 0 And n = F_Hub_PC.H_Val.Length Then
            Return "null"
        Else
            Return F_Hub_PC.ColorNome(ID)
        End If


        'F_Hub_PC.LabelColore.Text = F_Hub_PC.H_Val(ID)
    End Function






    'Carica i Colori Memorizati sui Bottoni
    Private BtnColor As PictureBox() = {F_Hub_PC.BtnColor0, F_Hub_PC.BtnColor1, F_Hub_PC.BtnColor2, F_Hub_PC.BtnColor3, F_Hub_PC.BtnColor4, F_Hub_PC.BtnColor5, F_Hub_PC.BtnColor6, F_Hub_PC.BtnColor7}
    Private BtnARGB As Button() = {F_Hub_PC.BtnRGB0, F_Hub_PC.BtnRGB1, F_Hub_PC.BtnRGB2, F_Hub_PC.BtnRGB3, F_Hub_PC.BtnRGB4, F_Hub_PC.BtnRGB5}

    ' 'Lingua
    ' F_Hub_PC.  ID_ColoreN(24) As Integer
    ' F_Hub_PC. ColorNome(24) As String
    ' 'Data
    ' F_Hub_PC.  ID_ColoreVal(24) As Integer
    ' F_Hub_PC.  H_Val(24) As Integer
    ' F_Hub_PC. S_Val(24) As Integer
    ' Public BtnPosizione(24) As String
    ' Public BtnMenuPos(30) As Integer
    Public Sub BtnColore(PosMenù As Integer)

        For n As Integer = 0 To F_Hub_PC.ID_ColoreN.Length - 1

            'For d As Integer = 0 To F_Hub_PC.ID_ColoreVal.Length - 1

            If F_Hub_PC.ID_ColoreN(n) = F_Hub_PC.ID_ColoreVal(n) And F_Hub_PC.BtnPosizione(n) <> "null" Then
                'Bottoni Colore
                For btn As Integer = 0 To BtnColor.Length - 1

                    If F_Hub_PC.BtnPosizione(n) = BtnColor(btn).Name Then
                        ''Nome Colore, H S V, R G B,
                        BtnColor(btn).Tag = F_Hub_PC.ColorNome(n)
                        'ToolTip
                        F_Hub_PC.ToolTip1.SetToolTip(BtnColor(btn), F_Hub_PC.ColorNome(n))

                        Dim R As Integer, G As Integer, B As Integer
                        HSV_to_RGB(F_Hub_PC.H_Val(n), F_Hub_PC.S_Val(n), 255, R, G, B)
                        BtnColor(btn).BackColor = Color.FromArgb(R, G, B)
                        Exit For
                    End If

                Next
                'Bottoni Animazione
                For btn As Integer = 0 To BtnARGB.Length - 1

                    If F_Hub_PC.BtnPosizione(n) = BtnARGB(btn).Name And F_Hub_PC.BtnMenuPos(n) = PosMenù Then
                        'Nome Colore, H S V, R G B,
                        BtnARGB(btn).Tag = F_Hub_PC.ColorNome(n)
                        'ToolTip
                        F_Hub_PC.ToolTip1.SetToolTip(BtnARGB(btn), F_Hub_PC.ColorNome(n))

                        ' Dim R As Integer, G As Integer, B As Integer
                        'HSV_to_RGB(F_Hub_PC.H_Val(d), F_Hub_PC.S_Val(d), 255, R, G, B)
                        'BtnColor(btn).BackColor = Color.FromArgb(R, G, B)
                        Exit For
                    End If

                Next
            End If

            'Next
        Next

        'F_Hub_PC.LabelColore.Text = BtnARGB(0).Tag

    End Sub

    'Restituisce l'indice del Botton di colore
    Public Function SetColor(tag As String)
        Dim ID As Integer
        For x As Integer = 0 To F_Hub_PC.BtnPosizione.Length - 1
            If F_Hub_PC.BtnPosizione(x) = tag Then
                ID = x
            End If
        Next
        Return ID
    End Function











End Class
