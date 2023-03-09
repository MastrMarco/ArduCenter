﻿Imports NAudio.CoreAudioApi
Public Class F_Setting_RGB_Animation_Fan

    Dim enumerator As MMDeviceEnumerator

    Private Sub F_Setting_RGB_Animation_Fan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        enumerator = New MMDeviceEnumerator
        Dim Devices = enumerator.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active)
        ComboBox1.Items.AddRange(Devices.ToArray)

        If ComboBox1.Items(My.Settings.Sorgente_Audio_N).ToString = (My.Settings.Sorgente_Audio) And My.Settings.Sorgente_Audio <> "null" Then
            ComboBox1.SelectedIndex = My.Settings.Sorgente_Audio_N
        End If

        'If My.Settings.Sorgente_Audio = 0 Then

        'End If

        If F_Avvio.DatiRX_5(0) = F_Hub_PC.Animazione_RGB_Musica Then
            'TrackBarBitRateAudio.Value = F_Avvio.DatiRX_5(4)
            TrackBarAudioAmplificazione.Value = My.Settings.AudioDigitalRGB
            RGB_Audio_Regolazione = My.Settings.AudioDigitalRGB * 10
        End If

        'If F_Avvio.DatiRX_0(3) = "3" Then
        '    Button4.Visible = True
        '    Button5.Visible = True
        'Else
        '    Button4.Visible = False
        '    Button5.Visible = False
        'End If

    End Sub

    Dim RGB_Audio_Regolazione As String
    Dim AudioDEC As Integer

    'Dim device As MMDevice
    Public Sub AniamzioneRGB_Musica()

        If ComboBox1.Text <> "" Then
            Try
                'If Not ComboBox1.Text = "" Then

                Dim device As MMDevice = ComboBox1.SelectedItem
                'device = ComboBox1.SelectedItem
                AudioDEC = device.AudioMeterInformation.MasterPeakValue * RGB_Audio_Regolazione
                Label1.Text = RGB_Audio_Regolazione

                F_Avvio.Data9 = AudioDEC

                'My.Settings.DelayRGB_Audio = ComboBox2.Text
                'End If

                My.Settings.Sorgente_Audio = ComboBox1.Items(ComboBox1.SelectedIndex).ToString
                My.Settings.Sorgente_Audio_N = ComboBox1.SelectedIndex
            Catch ex As Exception
                Label1.Text = "Error"
            End Try
        Else
            Label1.Text = "Seleziona Audio"
        End If

        'If F_Avvio.Data14 = "1" Then
        '    Button4.Enabled = True
        '    Button5.Enabled = False
        'ElseIf F_Avvio.Data14 = "2" Then
        '    Button4.Enabled = False
        '    Button5.Enabled = True
        'End If

        'Label2.Text = ComboBox1.SelectedIndex & "  " & ComboBox1.Items(2).ToString
        'Label2.Text = My.Settings.Sorgente_Audio_N
        'Label2.Text = ComboBox1.Items(ComboBox1.SelectedIndex).ToString
    End Sub

    Private Sub TrackBarAudioAmplificazione_Scroll(sender As Object, e As EventArgs) Handles TrackBarAudioAmplificazione.Scroll
        RGB_Audio_Regolazione = TrackBarAudioAmplificazione.Value * 10
        My.Settings.AudioDigitalRGB = TrackBarAudioAmplificazione.Value
    End Sub

    Private Sub TrackBarBitRateAudio_Scroll(sender As Object, e As EventArgs) Handles TrackBarBitRateAudio.Scroll
        'F_Avvio.Data10 = TrackBarBitRateAudio.Value
    End Sub

    Private Sub TrackBarDelayAnimazione_Scroll(sender As Object, e As EventArgs) Handles TrackBarDelayAnimazione.Scroll
        'F_Avvio.Data10 = TrackBarDelayAnimazione.Value
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'F_Avvio.Data14 = "2"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'F_Avvio.Data14 = "1"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TrackBarAudioAmplificazione.Value = 100
        RGB_Audio_Regolazione = 100 * 10
        My.Settings.AudioDigitalRGB = TrackBarAudioAmplificazione.Value
    End Sub
End Class