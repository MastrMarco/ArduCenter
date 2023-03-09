Public Class F_Impostazioni_HUB_Ventole
    Public Ventola_1_Data As String
    Public Fan1_EN As Integer = 0
    Public Fan1_Load As Integer

    Public Fan2_EN As Integer = 0


    Public Fan3_EN As Integer = 0


    Public Fan4_EN As Integer = 0



    Private Sub F_Impostazioni_HUB_Ventole_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VentoleData()


        If Fan1_EN = 1 Then
            BtnFan1.ForeColor = Color.Gold
            BtnRGBON_Fan1.Enabled = True
            BtnRGBOFF_Fan1.Enabled = True
            NumLED_Fan1.Enabled = True
            BtnFan1_P2.Enabled = True
            BtnFan1_P3.Enabled = True
            BtnFan1_P4.Enabled = True
            ListFanTipe_1.Enabled = True
        ElseIf Fan1_EN = 0 Then
            BtnFan1.ForeColor = Color.Silver
            BtnRGBON_Fan1.Enabled = False
            BtnRGBOFF_Fan1.Enabled = False
            NumLED_Fan1.Enabled = False
            BtnFan1_P2.Enabled = False
            BtnFan1_P3.Enabled = False
            BtnFan1_P4.Enabled = False
            ListFanTipe_1.Enabled = False
        End If



        If Fan2_EN = 1 Then
            BtnFan2.ForeColor = Color.Gold
            BtnRGBON_Fan2.Enabled = True
            BtnRGBOFF_Fan2.Enabled = True
            NumLED_Fan2.Enabled = True
            BtnFan2_P2.Enabled = True
            BtnFan2_P3.Enabled = True
            BtnFan2_P4.Enabled = True
            ListFanTipe_2.Enabled = True
        ElseIf Fan2_EN = 0 Then
            BtnFan2.ForeColor = Color.Silver
            BtnRGBON_Fan2.Enabled = False
            BtnRGBOFF_Fan2.Enabled = False
            NumLED_Fan2.Enabled = False
            BtnFan2_P2.Enabled = False
            BtnFan2_P3.Enabled = False
            BtnFan2_P4.Enabled = False
            ListFanTipe_2.Enabled = False
        End If




        If Fan3_EN = 1 Then
            BtnFan3.ForeColor = Color.Gold
            BtnRGBON_Fan3.Enabled = True
            BtnRGBOFF_Fan3.Enabled = True
            NumLED_Fan3.Enabled = True
            BtnFan3_P2.Enabled = True
            BtnFan3_P3.Enabled = True
            BtnFan3_P4.Enabled = True
            ListFanTipe_3.Enabled = True
        ElseIf Fan3_EN = 0 Then
            BtnFan3.ForeColor = Color.Silver
            BtnRGBON_Fan3.Enabled = False
            BtnRGBOFF_Fan3.Enabled = False
            NumLED_Fan3.Enabled = False
            BtnFan3_P2.Enabled = False
            BtnFan3_P3.Enabled = False
            BtnFan3_P4.Enabled = False
            ListFanTipe_3.Enabled = False
        End If





        If Fan4_EN = 1 Then
            BtnFan4.ForeColor = Color.Gold
            BtnRGBON_Fan4.Enabled = True
            BtnRGBOFF_Fan4.Enabled = True
            NumLED_Fan4.Enabled = True
            BtnFan4_P2.Enabled = True
            BtnFan4_P3.Enabled = True
            BtnFan4_P4.Enabled = True
            ListFanTipe_3.Enabled = True
        ElseIf Fan4_EN = 0 Then
            BtnFan4.ForeColor = Color.Silver
            BtnRGBON_Fan4.Enabled = False
            BtnRGBOFF_Fan4.Enabled = False
            NumLED_Fan4.Enabled = False
            BtnFan4_P2.Enabled = False
            BtnFan4_P3.Enabled = False
            BtnFan4_P4.Enabled = False
            ListFanTipe_4.Enabled = False
        End If
    End Sub

    Public Sub VentoleData()

        If My.Settings.VentolaN1 = 1 Then
            BtnFan1.ForeColor = Color.Gold
            BtnRGBON_Fan1.Enabled = True
            BtnRGBOFF_Fan1.Enabled = True
            NumLED_Fan1.Enabled = True
            BtnFan1_P2.Enabled = True
            BtnFan1_P3.Enabled = True
            BtnFan1_P4.Enabled = True
            ListFanTipe_1.Enabled = True
        ElseIf My.Settings.VentolaN1 = 0 Then
            BtnFan1.ForeColor = Color.Silver
            BtnRGBON_Fan1.Enabled = False
            BtnRGBOFF_Fan1.Enabled = False
            NumLED_Fan1.Enabled = False
            BtnFan1_P2.Enabled = False
            BtnFan1_P3.Enabled = False
            BtnFan1_P4.Enabled = False
            ListFanTipe_1.Enabled = False
        End If

        If My.Settings.VentolaN1_LOAD = 1 Then
            ListFanTipe_1.Text = "Fan2P22L-V1 C"
            BtnRGBON_Fan1.ForeColor = Color.Gold
            BtnRGBOFF_Fan1.Enabled = False

            NumLED_Fan1.Text = "22"

            BtnFan1_P2.ForeColor = Color.Gold
            BtnFan1_P3.Enabled = False
            BtnFan1_P4.Enabled = False

        ElseIf My.Settings.VentolaN1_LOAD = 2 Then
            ListFanTipe_1.Text = "Fan2P22L-V2 C"
            BtnRGBON_Fan1.ForeColor = Color.Gold
            BtnRGBOFF_Fan1.Enabled = False

            NumLED_Fan1.Text = "22"

            BtnFan1_P2.ForeColor = Color.Gold
            BtnFan1_P3.Enabled = False
            BtnFan1_P4.Enabled = False

        ElseIf My.Settings.VentolaN1_LOAD = 0 Then
            ListFanTipe_1.Text = "Personalizzato"
            BtnRGBON_Fan1.ForeColor = Color.White
            BtnRGBON_Fan1.Enabled = True
            BtnRGBOFF_Fan1.Enabled = True
            NumLED_Fan1.Text = "???"
            BtnFan1_P2.ForeColor = Color.White
            BtnFan1_P2.Enabled = True
            BtnFan1_P3.Enabled = True
            BtnFan1_P4.Enabled = True
        End If


    End Sub


    Private Sub BtnFan1_Click(sender As Object, e As EventArgs) Handles BtnFan1.Click
        If BtnFan1.ForeColor = Color.Silver Then
            Fan1_EN = 1
            My.Settings.VentolaN1 = Fan1_EN

            BtnFan1.ForeColor = Color.Gold



            BtnRGBON_Fan1.Enabled = True
            BtnRGBOFF_Fan1.Enabled = True
            NumLED_Fan1.Enabled = True
            BtnFan1_P2.Enabled = True
            BtnFan1_P3.Enabled = True
            BtnFan1_P4.Enabled = True
            ListFanTipe_1.Enabled = True

        ElseIf BtnFan1.ForeColor = Color.Gold Then
            Fan1_EN = 0
            My.Settings.VentolaN1 = Fan1_EN

            BtnFan1.ForeColor = Color.Silver

            BtnRGBON_Fan1.Enabled = False
            BtnRGBOFF_Fan1.Enabled = False
            NumLED_Fan1.Enabled = False
            BtnFan1_P2.Enabled = False
            BtnFan1_P3.Enabled = False
            BtnFan1_P4.Enabled = False
            ListFanTipe_1.Enabled = False
        End If

        VentoleData()
    End Sub
    Private Sub ListFanTipe_1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListFanTipe_1.SelectedIndexChanged

        'My.Settings.VentolaN1_LOAD = ListFanTipe_1.Text


        If ListFanTipe_1.Text = "Fan2P22L-V1 C" Then
            Fan1_Load = 1
            My.Settings.VentolaN1_LOAD = Fan1_Load

            BtnRGBON_Fan1.ForeColor = Color.Gold
            BtnRGBOFF_Fan1.Enabled = False

            NumLED_Fan1.Text = "22"

            BtnFan1_P2.ForeColor = Color.Gold
            BtnFan1_P3.Enabled = False
            BtnFan1_P4.Enabled = False

        ElseIf ListFanTipe_1.Text = "Fan2P22L-V2 C" Then
            Fan1_Load = 2
            My.Settings.VentolaN1_LOAD = Fan1_Load

            BtnRGBON_Fan1.ForeColor = Color.Gold
            BtnRGBOFF_Fan1.Enabled = False

            NumLED_Fan1.Text = "22"

            BtnFan1_P2.ForeColor = Color.Gold
            BtnFan1_P3.Enabled = False
            BtnFan1_P4.Enabled = False

        ElseIf ListFanTipe_1.Text = "Personalizzato" Then
            Fan1_Load = 0
            My.Settings.VentolaN1_LOAD = Fan1_Load

            BtnRGBON_Fan1.ForeColor = Color.White
            BtnRGBON_Fan1.Enabled = True
            BtnRGBOFF_Fan1.Enabled = True
            NumLED_Fan1.Text = "???"
            BtnFan1_P2.ForeColor = Color.White
            BtnFan1_P2.Enabled = True
            BtnFan1_P3.Enabled = True
            BtnFan1_P4.Enabled = True
        End If
    End Sub






    Private Sub BtnFan2_Click(sender As Object, e As EventArgs) Handles BtnFan2.Click
        If BtnFan2.ForeColor = Color.Silver Then
            Fan2_EN = 1
            BtnFan2.ForeColor = Color.Gold

            BtnRGBON_Fan2.Enabled = True
            BtnRGBOFF_Fan2.Enabled = True
            NumLED_Fan2.Enabled = True
            BtnFan2_P2.Enabled = True
            BtnFan2_P3.Enabled = True
            BtnFan2_P4.Enabled = True
            ListFanTipe_2.Enabled = True

        ElseIf BtnFan2.ForeColor = Color.Gold Then
            Fan2_EN = 0
            BtnFan2.ForeColor = Color.Silver

            BtnRGBON_Fan2.Enabled = False
            BtnRGBOFF_Fan2.Enabled = False
            NumLED_Fan2.Enabled = False
            BtnFan2_P2.Enabled = False
            BtnFan2_P3.Enabled = False
            BtnFan2_P4.Enabled = False
            ListFanTipe_2.Enabled = False
        End If
    End Sub

    Private Sub ListFanTipe_2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListFanTipe_2.SelectedIndexChanged
        If ListFanTipe_2.Text = "Fan2P22L-V1 C" Then
            BtnRGBON_Fan2.ForeColor = Color.Gold
            BtnRGBOFF_Fan2.Enabled = False

            NumLED_Fan2.Text = "22"

            BtnFan2_P2.ForeColor = Color.Gold
            BtnFan2_P3.Enabled = False
            BtnFan2_P4.Enabled = False

        ElseIf ListFanTipe_2.Text = "Fan2P22L-V2 C" Then
            BtnRGBON_Fan2.ForeColor = Color.Gold
            BtnRGBOFF_Fan2.Enabled = False

            NumLED_Fan2.Text = "22"

            BtnFan2_P2.ForeColor = Color.Gold
            BtnFan2_P3.Enabled = False
            BtnFan2_P4.Enabled = False

        ElseIf ListFanTipe_2.Text = "Personalizzato" Then

        End If
    End Sub






    Private Sub BtnFan3_Click(sender As Object, e As EventArgs) Handles BtnFan3.Click
        If BtnFan3.ForeColor = Color.Silver Then
            Fan3_EN = 1
            BtnFan3.ForeColor = Color.Gold

            BtnRGBON_Fan3.Enabled = True
            BtnRGBOFF_Fan3.Enabled = True
            NumLED_Fan3.Enabled = True
            BtnFan3_P2.Enabled = True
            BtnFan3_P3.Enabled = True
            BtnFan3_P4.Enabled = True
            ListFanTipe_3.Enabled = True

        ElseIf BtnFan3.ForeColor = Color.Gold Then
            Fan3_EN = 0
            BtnFan3.ForeColor = Color.Silver

            BtnRGBON_Fan3.Enabled = False
            BtnRGBOFF_Fan3.Enabled = False
            NumLED_Fan3.Enabled = False
            BtnFan3_P2.Enabled = False
            BtnFan3_P3.Enabled = False
            BtnFan3_P4.Enabled = False
            ListFanTipe_3.Enabled = False
        End If
    End Sub

    Private Sub ListFanTipe_3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListFanTipe_3.SelectedIndexChanged
        If ListFanTipe_3.Text = "Fan2P22L-V1 C" Then
            BtnRGBON_Fan3.ForeColor = Color.Gold
            BtnRGBOFF_Fan3.Enabled = False

            NumLED_Fan3.Text = "22"

            BtnFan3_P2.ForeColor = Color.Gold
            BtnFan3_P3.Enabled = False
            BtnFan3_P4.Enabled = False

        ElseIf ListFanTipe_3.Text = "Fan2P22L-V2 C" Then
            BtnRGBON_Fan3.ForeColor = Color.Gold
            BtnRGBOFF_Fan3.Enabled = False

            NumLED_Fan3.Text = "22"

            BtnFan3_P2.ForeColor = Color.Gold
            BtnFan3_P3.Enabled = False
            BtnFan3_P4.Enabled = False

        ElseIf ListFanTipe_3.Text = "Personalizzato" Then

        End If
    End Sub






    Private Sub BtnFan4_Click(sender As Object, e As EventArgs) Handles BtnFan4.Click
        If BtnFan4.ForeColor = Color.Silver Then
            Fan4_EN = 1
            BtnFan4.ForeColor = Color.Gold

            BtnRGBON_Fan4.Enabled = True
            BtnRGBOFF_Fan4.Enabled = True
            NumLED_Fan4.Enabled = True
            BtnFan4_P2.Enabled = True
            BtnFan4_P3.Enabled = True
            BtnFan4_P4.Enabled = True
            ListFanTipe_4.Enabled = True

        ElseIf BtnFan4.ForeColor = Color.Gold Then
            Fan4_EN = 0
            BtnFan4.ForeColor = Color.Silver

            BtnRGBON_Fan4.Enabled = False
            BtnRGBOFF_Fan4.Enabled = False
            NumLED_Fan4.Enabled = False
            BtnFan4_P2.Enabled = False
            BtnFan4_P3.Enabled = False
            BtnFan4_P4.Enabled = False
            ListFanTipe_4.Enabled = False
        End If
    End Sub

    Private Sub ListFanTipe_4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListFanTipe_4.SelectedIndexChanged
        If ListFanTipe_4.Text = "Fan2P22L-V1 C" Then
            BtnRGBON_Fan4.ForeColor = Color.Gold
            BtnRGBOFF_Fan4.Enabled = False

            NumLED_Fan4.Text = "22"

            BtnFan4_P2.ForeColor = Color.Gold
            BtnFan4_P3.Enabled = False
            BtnFan4_P4.Enabled = False

        ElseIf ListFanTipe_4.Text = "Fan2P22L-V2 C" Then
            BtnRGBON_Fan4.ForeColor = Color.Gold
            BtnRGBOFF_Fan4.Enabled = False

            NumLED_Fan4.Text = "22"

            BtnFan4_P2.ForeColor = Color.Gold
            BtnFan4_P3.Enabled = False
            BtnFan4_P4.Enabled = False

        ElseIf ListFanTipe_4.Text = "Personalizzato" Then

        End If
    End Sub
End Class