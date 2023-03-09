Public Class F_Debug_HubFan
    Private Sub F_Debug_HubFan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub




    Dim S_dati_0 As String
    Dim S_dati_1 As String
    Dim S_dati_2 As String
    Dim S_dati_3 As String
    Dim S_dati_4 As String
    Dim S_dati_5 As String
    Dim S_dati_6 As String
    Dim S_dati_7 As String
    Dim S_dati_8 As String
    Dim S_dati_9 As String
    Dim S_dati_10 As String
    Dim S_dati_11 As String
    Public Sub Debug_Fan_Loop()

        '*
        S_dati_0 = "
Dati [0]  {0 - 4}
0) Stato Software = " & F_Connessione.LaFirmware.Text & "
1) Tipo di Arduino = " & F_Connessione.LaNomePCB.Text & "  " & F_Connessione.LaSoc.Text & "  " & F_Connessione.LaBoot.Text & "
2) Null" & "
3) Dispositivo / Proggetto = " & F_Connessione.LaProgetto.Text & "
4) " & F_Connessione.LabelSoftArduino.Text
        '*

        S_dati_1 = "
Dati [1]  {0 - 4}
0) Temperatura sensore = " & F_Avvio.DatiRX_1(0) & " °C
1) Tensione della 5V = " & F_Avvio.DatiRX_1(1) & "
2) Tensione della 12V = " & F_Avvio.DatiRX_1(2) & "
3) Stato Protezione 12V = " & F_Avvio.DatiRX_1(3) & "
4) Stato Protezione LED = " & F_Avvio.DatiRX_1(4) & ""
        '*

        S_dati_2 = "
Dati [2]  {0 - 2}
0) Stato salvataggio dati = " & F_Avvio.DatiRX_2(0) & "
1) Stato Protezzione 12V 5V = " & F_Avvio.DatiRX_2(1) & "
2) Stato Peotezione LED Limit = " & F_Avvio.DatiRX_2(2) & ""
        '*////////////////////////////////////////////////////////////////////

        If F_Avvio.DatiRX_0(3) <> "3" Then
            S_dati_3 = "
Dati [3]  {0 - 9}
0) Nummero LED totale Ventoloe + LED Dis + GPU + Strip = " & F_Avvio.DatiRX_3(0) & "
1) Nummero LED Ventola Numero 1 = " & F_Avvio.DatiRX_3(1) & "
2) Nummero LED Ventola Numero 2 = " & F_Avvio.DatiRX_3(2) & "
3) Nummero LED Ventola Numero 3 = " & F_Avvio.DatiRX_3(3) & "
4) Nummero LED Ventola Numero 4 = " & F_Avvio.DatiRX_3(4) & "
5) Nummero LED Fan_pompa = " & F_Avvio.DatiRX_3(5) & "
6) Nummero LED Fan_pompa = " & F_Avvio.DatiRX_3(6) & "
7) Nummero LED Pompa = " & F_Avvio.DatiRX_3(7) & "
8) Nummero LED Scheda Video = " & F_Avvio.DatiRX_3(8) & "
9) Nummero LED Strisca LED = " & F_Avvio.DatiRX_3(9) & ""
        End If
        If F_Avvio.DatiRX_0(3) = "3" Then
            S_dati_3 = "
Dati [3]  {0 - 12}
0) Nummero LED totale Ventoloe + GPU + Strip + Casse Audio + Strp cassa Audio = " & F_Avvio.DatiRX_3(0) & "
1) Nummero LED Ventola Numero 1 = " & F_Avvio.DatiRX_3(1) & "
2) Nummero LED Ventola Numero 2 = " & F_Avvio.DatiRX_3(2) & "
3) Nummero LED Ventola Numero 3 = " & F_Avvio.DatiRX_3(3) & "
4) Nummero LED Ventola Numero 4 = " & F_Avvio.DatiRX_3(4) & "
5) Nummero LED Fan_pompa = " & F_Avvio.DatiRX_3(5) & "
6) Nummero LED Fan_pompa = " & F_Avvio.DatiRX_3(6) & "
7) Nummero LED Pompa = " & F_Avvio.DatiRX_3(7) & "
8) Nummero LED Scheda Video = " & F_Avvio.DatiRX_3(8) & "
9) Nummero LED Strisca LED = " & F_Avvio.DatiRX_3(9) & "
10) Nummero LED Cassa Audio Sinistra = " & F_Avvio.DatiRX_3(10) & "
11) Nummero LED Cassa Audio Destra = " & F_Avvio.DatiRX_3(11) & "
12) Nummero LED Cassa Audio Strisca a LED = " & F_Avvio.DatiRX_3(12) & ""
        End If
        '*////////////////////////////////////////////////////////////////////
        If F_Avvio.DatiRX_0(3) <> "3" Then
            S_dati_4 = "
Dati [4]  {0 - 9}
0) Luminosità di tutti i LED = " & F_Avvio.DatiRX_4(0) & "
1) Luminosita LED Ventola Numero 1 = " & F_Avvio.DatiRX_4(1) & "
2) Luminosita LED Ventola Numero 2 = " & F_Avvio.DatiRX_4(2) & "
3) Luminosita LED Ventola Numero 3 = " & F_Avvio.DatiRX_4(3) & "
4) Luminosita LED Ventola Numero 4 = " & F_Avvio.DatiRX_4(4) & "
5) Luminosita LED Fan_pompa = " & F_Avvio.DatiRX_4(5) & "
6) Luminosita LED Fan_pompa = " & F_Avvio.DatiRX_4(6) & "
7) Luminosita LED Pompa = " & F_Avvio.DatiRX_4(7) & "
8) Luminosita LED Scheda Video = " & F_Avvio.DatiRX_4(8) & "
9) Luminosita LED Strisca LED = " & F_Avvio.DatiRX_4(9) & ""
        End If
        If F_Avvio.DatiRX_0(3) = "3" Then
            S_dati_4 = "
Dati [4]  {0 - 12}
0) Luminosità di tutti i LED = " & F_Avvio.DatiRX_4(0) & "
1) Luminosita LED Ventola Numero 1 = " & F_Avvio.DatiRX_4(1) & "
2) Luminosita LED Ventola Numero 2 = " & F_Avvio.DatiRX_4(2) & "
3) Luminosita LED Ventola Numero 3 = " & F_Avvio.DatiRX_4(3) & "
4) Luminosita LED Ventola Numero 4 = " & F_Avvio.DatiRX_4(4) & "
5) Luminosita LED Fan_pompa = " & F_Avvio.DatiRX_4(5) & "
6) Luminosita LED Fan_pompa = " & F_Avvio.DatiRX_4(6) & "
7) Luminosita LED Pompa = " & F_Avvio.DatiRX_4(7) & "
8) Luminosita LED Scheda Video = " & F_Avvio.DatiRX_4(8) & "
9) Luminosita LED Strisca LED = " & F_Avvio.DatiRX_4(9) & "
10) Luminosita LED Cassa Audio Sinistra = " & F_Avvio.DatiRX_4(10) & "
11) Luminosita LED Cassa Audio Destra = " & F_Avvio.DatiRX_4(11) & "
12) Luminosita LED Cassa Audio Strisca a LED = " & F_Avvio.DatiRX_4(12) & ""
        End If
        '*////////////////////////////////////////////////////////////////////

        If F_Avvio.DatiRX_0(3) <> "3" Then
            S_dati_5 = "
Dati [5]  {0 - 9}
0) Colore HSV di tutti i LED = " & F_Avvio.DatiRX_5(0) & "
1) Colore HSV LED Ventola Numero 1 = " & F_Avvio.DatiRX_5(1) & "
2) Colore HSV LED Ventola Numero 2 = " & F_Avvio.DatiRX_5(2) & "
3) Colore HSV LED Ventola Numero 3 = " & F_Avvio.DatiRX_5(3) & "
4) Colore HSV LED Ventola Numero 4 = " & F_Avvio.DatiRX_5(4) & "
5) Colore HSV LED Fan_pompa = " & F_Avvio.DatiRX_5(5) & "
6) Colore HSV LED Fan_pompa = " & F_Avvio.DatiRX_5(6) & "
7) Colore HSV LED Pompa = " & F_Avvio.DatiRX_5(7) & "
8) Colore HSV LED Scheda Video = " & F_Avvio.DatiRX_5(8) & "
9) Colore HSV LED Strisca LED = " & F_Avvio.DatiRX_5(9) & ""
        End If
        If F_Avvio.DatiRX_0(3) = "3" Then
            S_dati_5 = "
Dati [5]  {0 - 12}
0) Colore HSV di tutti i LED = " & F_Avvio.DatiRX_5(0) & "
1) Colore HSV LED Ventola Numero 1 = " & F_Avvio.DatiRX_5(1) & "
2) Colore HSV LED Ventola Numero 2 = " & F_Avvio.DatiRX_5(2) & "
3) Colore HSV LED Ventola Numero 3 = " & F_Avvio.DatiRX_5(3) & "
4) Colore HSV LED Ventola Numero 4 = " & F_Avvio.DatiRX_5(4) & "
5) Colore HSV LED Fan_pompa = " & F_Avvio.DatiRX_5(5) & "
6) Colore HSV LED Fan_pompa = " & F_Avvio.DatiRX_5(6) & "
7) Colore HSV LED Pompa = " & F_Avvio.DatiRX_5(7) & "
8) Colore HSV LED Scheda Video = " & F_Avvio.DatiRX_5(8) & "
9) Colore HSV LED Strisca LED = " & F_Avvio.DatiRX_5(9) & "
10) Colore HSV  LED Cassa Audio Sinistra = " & F_Avvio.DatiRX_5(10) & "
11) Colore HSV  LED Cassa Audio Destra = " & F_Avvio.DatiRX_5(11) & "
12) Colore HSV  LED Cassa Audio Strisca a LED = " & F_Avvio.DatiRX_5(12) & ""
        End If
        '*////////////////////////////////////////////////////////////////////

        If F_Avvio.DatiRX_0(3) <> "3" Then
            S_dati_6 = "
Dati [6]  {0 - 9}
0) Saturazione HSV di tutti i LED = " & F_Avvio.DatiRX_6(0) & "
1) Saturazione HSV LED Ventola Numero 1 = " & F_Avvio.DatiRX_6(1) & "
2) Saturazione HSV LED Ventola Numero 2 = " & F_Avvio.DatiRX_6(2) & "
3) Saturazione HSV LED Ventola Numero 3 = " & F_Avvio.DatiRX_6(3) & "
4) Saturazione HSV LED Ventola Numero 4 = " & F_Avvio.DatiRX_6(4) & "
5) Saturazione HSV LED Fan_pompa = " & F_Avvio.DatiRX_6(5) & "
6) Saturazione HSV LED Fan_pompa = " & F_Avvio.DatiRX_6(6) & "
7) Saturazione HSV LED Pompa = " & F_Avvio.DatiRX_6(7) & "
8) Saturazione HSV LED Scheda Video = " & F_Avvio.DatiRX_6(8) & "
9) Saturazione HSV LED Strisca LED = " & F_Avvio.DatiRX_6(9) & ""
        End If
        If F_Avvio.DatiRX_0(3) = "3" Then
            S_dati_6 = "
Dati [6]  {0 - 12}
0) Saturazione HSV di tutti i LED = " & F_Avvio.DatiRX_6(0) & "
1) Saturazione HSV LED Ventola Numero 1 = " & F_Avvio.DatiRX_6(1) & "
2) Saturazione HSV LED Ventola Numero 2 = " & F_Avvio.DatiRX_6(2) & "
3) Saturazione HSV LED Ventola Numero 3 = " & F_Avvio.DatiRX_6(3) & "
4) Saturazione HSV LED Ventola Numero 4 = " & F_Avvio.DatiRX_6(4) & "
5) Saturazione HSV LED Fan_pompa = " & F_Avvio.DatiRX_6(5) & "
6) Saturazione HSV LED Fan_pompa = " & F_Avvio.DatiRX_6(6) & "
7) Saturazione HSV LED Pompa = " & F_Avvio.DatiRX_6(7) & "
8) Saturazione HSV LED Scheda Video = " & F_Avvio.DatiRX_6(8) & "
9) Saturazione HSV LED Strisca LED = " & F_Avvio.DatiRX_6(9) & "
10) Saturazione HSV LED Cassa Audio Sinistra = " & F_Avvio.DatiRX_6(10) & "
11) Saturazione HSV LED Cassa Audio Destra = " & F_Avvio.DatiRX_6(11) & "
12) Saturazione HSV LED Cassa Audio Strisca a LED = " & F_Avvio.DatiRX_6(12) & ""
        End If
        '*////////////////////////////////////////////////////////////////////

        S_dati_7 = "
Dati [7]  {0 - 2}
0) Modalità Sincronizzata / Manuale LED = " & F_Avvio.DatiRX_7(0) & "
1) Modalità Sincronizzata / Manuale Ventole = " & F_Avvio.DatiRX_7(1) & "
2) Modalità Animazione RGB LED = " & F_Avvio.DatiRX_7(2) & ""
        '*

        S_dati_8 = "
Dati [8] {0 - 4}
0) Velocità Rotazione Ventole globale = " & F_Avvio.DatiRX_8(0) & "
1) Velocità Rotazione Ventole Numero 1 = " & F_Avvio.DatiRX_8(1) & "
2) Velocità Rotazione Ventole Numero 2 = " & F_Avvio.DatiRX_8(2) & "
3) Velocità Rotazione Ventole Numero 3 = " & F_Avvio.DatiRX_8(3) & "
4) Velocità Rotazione Ventole Numero 4 = " & F_Avvio.DatiRX_8(4) & ""
        '*

        S_dati_9 = "
Dati [9] {0 - 4}
0) Velocità Automatica / Manuale Rotazione Ventole globale = " & F_Avvio.DatiRX_9(0) & "
1) Velocità Automatica / Manuale Rotazione Ventole Numero 1 = " & F_Avvio.DatiRX_9(1) & "
2) Velocità Automatica / Manuale Rotazione Ventole Numero 2 = " & F_Avvio.DatiRX_9(2) & "
3) Velocità Automatica / Manuale Rotazione Ventole Numero 3 = " & F_Avvio.DatiRX_9(3) & "
4) Velocità Automatica / Manuale Rotazione Ventole Numero 4 = " & F_Avvio.DatiRX_9(4) & ""
        '*

        S_dati_10 = "
Dati [10] {0 - 3}
0) Velocità RPM Ventole Numero 1 = " & F_Avvio.DatiRX_10(0) * 30 & "
1) Velocità RPM Ventole Numero 2 = " & F_Avvio.DatiRX_10(1) * 30 & "
2) Velocità RPM Ventole Numero 3 = " & F_Avvio.DatiRX_10(2) * 30 & "
3) Velocità RPM Ventole Numero 4 = " & F_Avvio.DatiRX_10(3) * 30 & ""





        If Select_Dati = 0 Then
            Dati0.Text = S_dati_0
        End If
        If Select_Dati = 1 Then
            Dati0.Text = S_dati_1
        End If
        If Select_Dati = 2 Then
            Dati0.Text = S_dati_2
        End If
        If Select_Dati = 3 Then
            Dati0.Text = S_dati_3
        End If
        If Select_Dati = 4 Then
            Dati0.Text = S_dati_4
        End If
        If Select_Dati = 5 Then
            Dati0.Text = S_dati_5
        End If
        If Select_Dati = 6 Then
            Dati0.Text = S_dati_6
        End If
        If Select_Dati = 7 Then
            Dati0.Text = S_dati_7
        End If
        If Select_Dati = 8 Then
            Dati0.Text = S_dati_8
        End If
        If Select_Dati = 9 Then
            Dati0.Text = S_dati_9
        End If
        If Select_Dati = 10 Then
            Dati0.Text = S_dati_10
        End If
    End Sub



    Dim Select_Dati As Integer

    Private Sub BtnDati_0_Click(sender As Object, e As EventArgs) Handles BtnDati_0.Click
        Select_Dati = 0
    End Sub

    Private Sub BtnDati_1_Click(sender As Object, e As EventArgs) Handles BtnDati_1.Click
        Select_Dati = 1
    End Sub

    Private Sub BtnDati_2_Click(sender As Object, e As EventArgs) Handles BtnDati_2.Click
        Select_Dati = 2
    End Sub

    Private Sub BtnDati_3_Click(sender As Object, e As EventArgs) Handles BtnDati_3.Click
        Select_Dati = 3
    End Sub

    Private Sub BtnDati_4_Click(sender As Object, e As EventArgs) Handles BtnDati_4.Click
        Select_Dati = 4
    End Sub

    Private Sub BtnDati_5_Click(sender As Object, e As EventArgs) Handles BtnDati_5.Click
        Select_Dati = 5
    End Sub

    Private Sub BtnDati_6_Click(sender As Object, e As EventArgs) Handles BtnDati_6.Click
        Select_Dati = 6
    End Sub

    Private Sub BtnDati_7_Click(sender As Object, e As EventArgs) Handles BtnDati_7.Click
        Select_Dati = 7
    End Sub

    Private Sub BtnDati_8_Click(sender As Object, e As EventArgs) Handles BtnDati_8.Click
        Select_Dati = 8
    End Sub

    Private Sub BtnDati_9_Click(sender As Object, e As EventArgs) Handles BtnDati_9.Click
        Select_Dati = 9
    End Sub

    Private Sub BtnDati_10_Click(sender As Object, e As EventArgs) Handles BtnDati_10.Click
        Select_Dati = 10
    End Sub

End Class