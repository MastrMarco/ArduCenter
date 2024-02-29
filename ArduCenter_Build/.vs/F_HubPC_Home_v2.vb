Public Class F_HubPC_Home_v2




    Dim count As Integer = 1
    Dim btn As Button
    Dim txt As Label
    Dim y As Integer = 1



    Dim Nome_Btn() As String = {"", "Btn_Ventole", "Btn_Dissipatore", "Btn_SchedaVideo", "Btn_SyncMode", "Btn_CasseAudio", "Btn_StripLED"}
    Dim Nome_txt() As String = {"", "La_Ventole", "La_Dissipatore", "La_SchedaVideo", "La_SyncMode", "La_CasseAudio", "La_StripLED"}



    'Dim btncontrol As Integer = 1
    'Dim btn As Button
    'Dim y As Integer = 0
    'Dim x As Integer = 0
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    'If btncontrol < 7 Then
    '    btn = New Button()
    '    Controls.Add(btn)
    '    btn.Top = btncontrol * 25
    '    btn.Left = 25
    '    btn.Size = New Size(50, 50)

    '    If btncontrol < 4 Then
    '        btn.Location = New Point(60 * y, 60)
    '    ElseIf btncontrol = 4 Then
    '        btn.Location = New Point(60 * 0, 60 * y)
    '    ElseIf btncontrol > 4 Then
    '        btn.Location = New Point(60 * (y - 3), 60 * 3)
    '    End If

    '    y = y + 1
    '    btn.Name = btncontrol.ToString()
    '    btn.Text = btncontrol.ToString()
    '    btn.ForeColor = Color.White
    '    btncontrol = btncontrol + 1
    'End If



    'End Sub

    Private Sub F_HubPC_Home_v2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'For r As Integer = 1 To 2
        '    For i As Integer = 1 To 3
        '        btn = New Button()
        '        btn.Name = Nome_Btn(count).ToString()
        '        btn.Text = Nome_Btn(count).ToString()
        '        btn.ForeColor = Color.White
        '        btn.Size = New Size(110, 110)
        '        btn.Location = New Point(115 * (i + 1), 115 * y)
        '        Controls.Add(btn)
        '        count += 1
        '    Next
        '    y += 1
        'Next




        For r As Integer = 1 To 2
            For i As Integer = 1 To 3

                btn = New Button()
                btn.Name = Nome_Btn(count).ToString()
                btn.Text = Nome_Btn(count).ToString()
                btn.ForeColor = Color.White
                btn.Size = New Size(110, 110)
                btn.Location = New Point(115 * (i + 1), 115 * y)

                txt = New Label()
                txt.Name = Nome_txt(count).ToString()
                txt.Text = Nome_txt(count).ToString()
                txt.ForeColor = Color.White
                'txt.TextAlign = Left
                txt.Size = New Size(110, 35)
                txt.Location = New Point(115 * (i + 1), 115 * y - 15)


                Controls.Add(btn)
                Controls.Add(txt)
                count += 1
            Next
            y += 2
        Next

    End Sub
End Class