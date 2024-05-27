Imports System.IO

Public Class F_Impostazioni
    Private Sub F_Impostazioni_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub SetLingua_SelectedIndexChanged() Handles SetLingua.SelectedIndexChanged
        ' Esegui uno switch in base alla selezione del ComboBox per cambiare la lingua dei testi
        Select Case SetLingua.SelectedItem.ToString()
            Case "Italiano"
                CambiaLingua("ITA")

                F_HardwareMonitor.CambiaLingua("ITA")

                F_Hub_PC.CambiaLingua("ITA")
                F_Hub_PC.CambiaLinguaColore("ITA")
                F_Avvio.ConvertiColore.BtnColore(F_Hub_PC.RGBAMenù)

                P_HubPC_HUB.CambiaLingua("ITA")
                F_SettingColor.CambiaLingua("ITA")



                My.Settings.Lingua = "Italiano"
            Case "English"
                CambiaLingua("ENG")

                F_HardwareMonitor.CambiaLingua("ENG")

                F_Hub_PC.CambiaLingua("ENG")
                F_Hub_PC.CambiaLinguaColore("ENG")
                F_Avvio.ConvertiColore.BtnColore(F_Hub_PC.RGBAMenù)

                P_HubPC_HUB.CambiaLingua("ENG")
                F_SettingColor.CambiaLingua("ENG")



                My.Settings.Lingua = "English"
            Case "Null"
                '  CambiaLingua("")
        End Select
    End Sub



    ' //--
    Public cartellaLingue As String = Path.Combine(Application.StartupPath, "Lingua")
    Public cartellaDataUser As String = Path.Combine(Application.StartupPath, "UserDati")
    Sub CambiaLingua(lingua As String)
        ' Ottieni il percorso del file di testo per la lingua specificata
        Dim nomeFile As String = ""
        Select Case lingua
            Case "ITA"
                nomeFile = "F_Impostazioni.txt"
            Case "ENG"
                nomeFile = "F_Impostazioni.txt"
            Case "Null"
                'nomeFile = "F_Impostazioni.txt"
        End Select

        ' Combina il percorso relativo del file con il percorso della cartella dell'applicazione
        Dim percorsoFile As String = Path.Combine(cartellaLingue, lingua, nomeFile)

        ' Leggi il testo dal file per le due etichette
        Dim testo As String() = LeggiTestoDaFile(percorsoFile)

        Try
            ' Modifica il testo delle etichette dell'interfaccia con il testo letto dal file
            'Titoli
            La_lingua.Text = testo(1) ' La prima riga del file di testo va nella Label1
            LaTema.Text = testo(2) ' La seconda riga del file di testo...
            LaInfoSoft.Text = testo(3)
            LaSartSoft.Text = testo(4)
            LaCredit.Text = testo(5)

            'Elementi

            ' info
            Dim parolaChiave As String = "Beta "
            Dim indiceParolaChiave As Integer = F_Avvio.InfoSoft_HOME.IndexOf(parolaChiave)
            Dim betaN As String = F_Avvio.InfoSoft_HOME.Substring(indiceParolaChiave + parolaChiave.Length)
            LaInfoData.Text = "ArduCenter 2.0 " & F_Avvio.Versione & " t" & betaN & vbCrLf & testo(22) & F_Avvio.DataRilascio & vbCrLf & testo(23) 'Info

            'Tema
            SetTema.Text = testo(41)

            'Stato Auto Avvio
            LaStatoAvvioAuto.Text = testo(61)

            'Creatore
            LaCreatore.Text = testo(81)

            'Supporto
            LaSupporto.Text = testo(82)

        Catch ex As Exception

        End Try

    End Sub

    Public Function LeggiTestoDaFile(percorsoFile As String) As String()
        Dim righe As String() = {}

        ' Verifica se il file esiste
        If File.Exists(percorsoFile) Then
            ' Leggi tutte le righe dal file
            righe = File.ReadAllLines(percorsoFile)
        Else
            ' Se il file non esiste, mostra un messaggio di errore
            MessageBox.Show("Il file non esiste", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Return righe
    End Function
    ' //--
    Private Sub BoxDonazione_Click(sender As Object, e As EventArgs) Handles BoxDonazione.Click
        Dim url As String = "https://ko-fi.com/mastrmarco"
        ' Avvia il browser web predefinito con l'URL specificato
        Process.Start(url)
    End Sub



    'Private Sub AvvioWindows_Click(sender As Object, e As EventArgs) Handles AvvioWindows.Click

    '    Dim reg As RegistryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
    '    reg.SetValue("ArduCenter", Application.ExecutablePath.ToString())

    'End Sub
End Class