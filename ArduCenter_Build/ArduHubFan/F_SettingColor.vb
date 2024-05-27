Imports System.Runtime.InteropServices
Imports System.IO

Public Class F_SettingColor

    'Public ConvertiColore As New C_HSV_RGB()

    Public buttonName As String
    Public buttonNameTag As String

    Private Sub F_SettingColor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AngoliSmussati(Me)

        'TrackBarLuminosità.Value = F_Avvio.Data2
        'ColoreDinamico()
        ' TextBoxNomeColore.Text = buttonName

    End Sub

    Private Sub AngoliSmussati(obj As Form)
        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()
        Dim A_S As Integer = 35
        Dim A_D As Integer = 35
        Dim B_D As Integer = 35
        Dim B_S As Integer = 35
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
        'Me.Close()
        Me.Hide()
    End Sub




    Private Sub TrackBarColore_Scroll(sender As Object, e As EventArgs) Handles TrackBarColore.Scroll
        'F_Avvio.Data3 = TrackBarColore.Value
        DemoColore()
        ColoreDinamico()
    End Sub

    Private Sub TrackBarSaturazione_Scroll(sender As Object, e As EventArgs) Handles TrackBarSaturazione.Scroll
        'F_Avvio.Data4 = TrackBarSaturazione.Value
        DemoColore()
        ColoreDinamico()
    End Sub

    Private Sub TrackBarLuminosità_Scroll(sender As Object, e As EventArgs) Handles TrackBarLuminosità.Scroll
        'F_Avvio.Data2 = TrackBarLuminosità.Value
        DemoColore()
        F_Hub_PC.TrackBarLuminosità.Value = F_Avvio.Data2 / 2.55
        ColoreDinamico()
    End Sub


    Private Sub DemoColore()
        F_Avvio.Data3 = TrackBarColore.Value
        F_Avvio.Data4 = TrackBarSaturazione.Value
        F_Avvio.Data2 = TrackBarLuminosità.Value
    End Sub

    Public Sub ColoreDinamico()

        Dim R As Integer, G As Integer, B As Integer
        F_Avvio.ConvertiColore.HSV_to_RGB(TrackBarColore.Value, TrackBarSaturazione.Value, 255, R, G, B)
        Me.BackColor = Color.FromArgb(R, G, B)

        LaColore_V.Text = TrackBarColore.Value
        LaSaturazione_V.Text = TrackBarSaturazione.Value
        LaLuminosità_V.Text = F_Avvio.Data2

        ' ConvertiColore.BtnColore()
    End Sub









    'Aggungi una Nuova Riga Con il Colore nuovo
    Public Sub CreaNouovoColore(NomeColore As String, H As Integer, S As Integer, Btn As String, Menù As Integer)
        ' Combina il percorso relativo del file con il percorso della cartella dell'applicazione
        Dim percorsoFile As String = Path.Combine(F_Impostazioni.cartellaDataUser, "HUBFan_Dati", "T_Colore.txt")
        Dim ID As Integer = 20

        'Aggiunge una Righa Nuova
        For N = 0 To F_Hub_PC.ID_ColoreN.Length - 1

            Dim wordToCheck As String = ID
            Dim newLine As String = ID & " " & H & " " & S & " " & Btn & " " & Menù

            ' Verifica se il file esiste
            If File.Exists(percorsoFile) Then
                ' Leggi tutte le righe del file
                Dim lines() As String = File.ReadAllLines(percorsoFile)

                ' Controlla se ci sono righe esistenti che iniziano con lo stesso valore
                Dim duplicateFound As Boolean = False
                For Each line As String In lines
                    If line.StartsWith(wordToCheck) Then
                        duplicateFound = True
                        Exit For
                    End If
                Next

                If Not duplicateFound Then
                    ' Aggiungi la nuova riga al file
                    Using sw As StreamWriter = File.AppendText(percorsoFile)
                        sw.WriteLine(newLine)
                    End Using
                    'MessageBox.Show("Nuovo Colore aggiunto con successo.")
                    CreaNuovoNome(ID, NomeColore)
                    Exit For
                Else

                    ID = ID + 1

                    If ID >= 27 Then
                        MessageBox.Show("Errore" & Environment.NewLine & "Spazio Insufficente")
                        Exit For
                    End If
                End If
            Else
                MessageBox.Show("Errore" & Environment.NewLine & "Il file non esiste.")
                Exit For
            End If

        Next

        'CreaNuovoNome(ID, NomeColore)

    End Sub
    'Aggungi una Nuova Riga Con il Nome del Colore nuovo
    Public Sub CreaNuovoNome(ID As Integer, Nome As String)
        ' Combina il percorso relativo del file con il percorso della cartella dell'applicazione
        Dim percorsoFile As String = Path.Combine(F_Impostazioni.cartellaLingue, "ITA", "N_ColoreHUBFan.txt")


        'Aggiunge una Righa Nuova
        'For N = 0 To F_Hub_PC.ID_ColoreN.Length - 1


        Dim wordToCheck As String = ID
            Dim newLine As String = ID & " " & Nome

        ' Verifica se il file esiste
        If File.Exists(percorsoFile) Then
            ' Leggi tutte le righe del file
            Dim lines() As String = File.ReadAllLines(percorsoFile)

            ' Controlla se ci sono righe esistenti che iniziano con lo stesso valore
            Dim duplicateFound As Boolean = False
            For Each line As String In lines
                If line.StartsWith(wordToCheck) Then
                    duplicateFound = True
                    Exit For
                End If
            Next

            If Not duplicateFound Then
                ' Aggiungi la nuova riga al file
                Using sw As StreamWriter = File.AppendText(percorsoFile)
                    sw.WriteLine(newLine)
                End Using
                MessageBox.Show("Aggiunto Colore " & Nome)
                'Aggiorna GUI
                F_Hub_PC.CambiaLinguaColore("ITA")
                F_Hub_PC.UserData("HUBFan_Dati")

                'Imposta Colore come Selezionato
                ColoreNewSalvato = True

                'Exit For
            Else

                'ID = ID + 1

                'If ID >= 23 Then
                MessageBox.Show("Errore" & Environment.NewLine & "Esiste già una riga con lo stesso Nome iniziale.")
                'Exit For
                'End If
            End If
        Else
            MessageBox.Show("Errore" & Environment.NewLine & "Il file non esiste.")
            'Exit For
        End If

        'Next

        ''Aggiorna GUI
        'F_Hub_PC.CambiaLinguaColore("ITA")
        'F_Hub_PC.UserData("HUBFan_Dati")

    End Sub




    'Aggiorna la Riga Con il Colore nuovo
    Public Sub AggiornaRigaColore(ID_old As Integer, NomeColore As String, H As Integer, S As Integer, Btn As String, Menù As Integer, Clean As Boolean)
        ' Combina il percorso relativo del file con il percorso della cartella dell'applicazione
        Dim percorsoFile As String = Path.Combine(F_Impostazioni.cartellaDataUser, "HUBFan_Dati", "T_Colore.txt")


        'Modifica le Righe Esistenti

        Dim keyword As String = F_Hub_PC.ID_ColoreVal(ID_old) 'parola_chiave
        Dim wordToReplace As String 'parola_da_modificare
        Dim newWord As String 'nuova_parola

        If Clean = False Then
            'Aggiorna Colore
            wordToReplace = F_Hub_PC.H_Val(ID_old) & " " & F_Hub_PC.S_Val(ID_old) & " " & Btn & " " & 0
            newWord = H & " " & S & " " & Btn & " " & Menù ' ID & " " & H & " " & S & " " & Btn & " " & Menù
        Else
            'Cancella Colore
            wordToReplace = F_Hub_PC.ID_ColoreVal(ID_old) & " " & F_Hub_PC.H_Val(ID_old) & " " & F_Hub_PC.S_Val(ID_old) & " " & Btn & " " & 0
            newWord = " " ' ID & " " & H & " " & S & " " & Btn & " " & Menù
        End If

        ' Verifica se il file esiste
        If File.Exists(percorsoFile) Then
            ' Leggi tutte le righe del file
            Dim lines() As String = File.ReadAllLines(percorsoFile)

            ' Cerca la parola chiave e sostituisci la parola nella stessa riga
            For i As Integer = 0 To lines.Length - 1
                If lines(i).StartsWith(keyword) Then
                    ' Trovata la riga con la parola chiave, sostituisci la parola
                    lines(i) = lines(i).Replace(wordToReplace, newWord)
                    Exit For ' Esci dal ciclo dopo aver trovato la parola chiave
                End If
            Next

            ' Sovrascrivi il file con le righe modificate
            Using sw As StreamWriter = New StreamWriter(percorsoFile)
                For Each line As String In lines
                    sw.WriteLine(line)
                Next
            End Using
            'MessageBox.Show("Modifica Colore completata.")
            AggiornaRigaNomeColore(ID_old, NomeColore, Clean, "ITA")

        Else
            MessageBox.Show("Errore" & Environment.NewLine & "Il file non esiste.")
        End If
    End Sub
    'Aggiorna la Riga Con il Nome Colore nuovo
    Public Sub AggiornaRigaNomeColore(ID_old As Integer, Nome As String, Clean As Boolean, Lingua As String)
        ' Combina il percorso relativo del file con il percorso della cartella dell'applicazione
        Dim percorsoFile As String = Path.Combine(F_Impostazioni.cartellaLingue, Lingua, "N_ColoreHUBFan.txt")

        'Modifica le Righe Esistenti

        Dim keyword As String = F_Hub_PC.ID_ColoreN(ID_old) 'parola_chiave
        'Dim wordToReplace As String = F_Hub_PC.ColorNome(ID_old) 'parola_da_modificare
        'Dim newWord As String = Nome 'nuova_parola ID & " " & H & " " & S & " " & Btn & " " & Menù

        Dim wordToReplace As String 'parola_da_modificare
        Dim newWord As String 'nuova_parola
        If Clean = False Then
            'Aggiorna Nome
            wordToReplace = F_Hub_PC.ColorNome(ID_old)
            newWord = Nome
        Else
            'Cancella Nome
            wordToReplace = F_Hub_PC.ID_ColoreN(ID_old) & " " & F_Hub_PC.ColorNome(ID_old)
            newWord = ""
        End If


        ' Verifica se il file esiste
        If File.Exists(percorsoFile) Then
            ' Leggi tutte le righe del file
            Dim lines() As String = File.ReadAllLines(percorsoFile)

            ' Cerca la parola chiave e sostituisci la parola nella stessa riga
            For i As Integer = 0 To lines.Length - 1
                If lines(i).StartsWith(keyword) Then
                    ' Trovata la riga con la parola chiave, sostituisci la parola
                    lines(i) = lines(i).Replace(wordToReplace, newWord)
                    Exit For ' Esci dal ciclo dopo aver trovato la parola chiave
                End If
            Next

            ' Sovrascrivi il file con le righe modificate
            Using sw As StreamWriter = New StreamWriter(percorsoFile)
                For Each line As String In lines
                    sw.WriteLine(line)
                Next
            End Using

            If Clean = False Then
                'Aggiorna Nome
                MessageBox.Show("Aggiunto Colore " & Nome)
            Else
                'Cancella Nome
                MessageBox.Show("Ripristinato Colore")
                'Pulisci Colori array
                For i As Integer = 0 To F_Hub_PC.ID_ColoreVal.Length - 1
                    ' Lingua
                    F_Hub_PC.ID_ColoreN(i) = 0
                    F_Hub_PC.ColorNome(i) = ""
                    ' Data
                    F_Hub_PC.ID_ColoreVal(i) = 0
                    F_Hub_PC.H_Val(i) = 0
                    F_Hub_PC.S_Val(i) = 0
                    F_Hub_PC.BtnPosizione(i) = ""
                    F_Hub_PC.BtnMenuPos(i) = 0
                Next
            End If

            'Aggiorna GUI
            F_Hub_PC.CambiaLinguaColore("ITA")
            F_Hub_PC.UserData("HUBFan_Dati")

            'Imposta Colore come Selezionato
            ColoreNewSalvato = True
        Else
            MessageBox.Show("Errore" & Environment.NewLine & "Il file non esiste.")
        End If
    End Sub



    Dim ColoreNewSalvato As Boolean
    'Salva Colore
    Private Sub BtnSalva_Click(sender As Object, e As EventArgs) Handles BtnSalva.Click

        Dim VerNomeColore As Boolean = True
        For n As Integer = 0 To F_Hub_PC.ColorNome.Length - 1

            If F_Hub_PC.ColorNome(n) <> TextBoxNomeColore.Text Then
                VerNomeColore = False
            Else
                VerNomeColore = True
                Exit For
            End If
        Next


        ColoreNewSalvato = False
        'Verifica che la conbinazione colore non esiste
        If F_Avvio.ConvertiColore.Nome_Colore(TrackBarColore.Value, TrackBarSaturazione.Value) = "null" And VerNomeColore = False Then

            ' Lingua
            ' F_Hub_PC.  ID_ColoreN(24) As Integer
            ' F_Hub_PC. ColorNome(24) As String

            ' Data
            ' F_Hub_PC.  ID_ColoreVal(24) As Integer
            ' F_Hub_PC.  H_Val(24) As Integer
            ' F_Hub_PC. S_Val(24) As Integer
            ' Public BtnPosizione(24) As String
            ' Public BtnMenuPos(30) As Integer

            Dim ID_old As Integer = Array.IndexOf(F_Hub_PC.ColorNome, buttonNameTag)
            If F_Hub_PC.ID_ColoreVal(ID_old) > 15 Then
                'Sostituisci il colore
                AggiornaRigaColore(ID_old, TextBoxNomeColore.Text, TrackBarColore.Value, TrackBarSaturazione.Value, buttonName, 0, False)
            Else
                'Salva il Nuovo Colore 
                CreaNouovoColore(TextBoxNomeColore.Text, TrackBarColore.Value, TrackBarSaturazione.Value, buttonName, 0)
            End If



            ' Label1.Text = F_Hub_PC.ID_ColoreVal(ID_old)
        Else
            If VerNomeColore = False Then MessageBox.Show("Errore" & Environment.NewLine & "Il Colore esiste già " & F_Avvio.ConvertiColore.Nome_Colore(TrackBarColore.Value, TrackBarSaturazione.Value))
            If VerNomeColore = True Then MessageBox.Show("Errore" & Environment.NewLine & "Il Nome esiste già " & TextBoxNomeColore.Text)
        End If




        'Imposta Colore come Selezionato
        If ColoreNewSalvato = True Then
            'AggiornaBtnTag
            buttonNameTag = TextBoxNomeColore.Text
            ImpostaColore()
            'Aggiorna Grafica
            F_Hub_PC.AggiornaGUI = True
        End If

    End Sub

    'Imposta il colore aggiunto come colore selezionato
    Public Sub ImpostaColore()
        'ConvertiColore.ColorUP_Elemtnto(buttonNameTag, 0)
        F_Hub_PC.SetColore(buttonNameTag, 0)
    End Sub



















    'Lingua Finestra Titoli
    ' //-- Lingua finestra e pagine
    Dim testo As String()
    Public Sub CambiaLingua(lingua As String)

        ' Combina il percorso relativo del file con il percorso della cartella dell'applicazione
        Dim percorsoFile As String = Path.Combine(F_Impostazioni.cartellaLingue, lingua, "F_SettingColor.txt")
        ' Leggi il testo dal file per le due etichette
        testo = F_Impostazioni.LeggiTestoDaFile(percorsoFile)


        Try
            ' Modifica il testo delle etichette dell'interfaccia con il testo letto dal file
            'Titoli
            'LabelColore.Text = testo(1)

            N_Colore.Text = testo(1)
            La_Conversione_Tipo.Text = testo(2)


            LaNColore.Text = testo(14)
            LaNSaturazione.Text = testo(15)
            LaNLuminosità.Text = testo(16)


            BtnSalva.Text = testo(27)



        Catch ex As Exception

        End Try
        'F_SettingColor.ConvertiColore.BtnColore(RGBAMenù)
    End Sub
End Class