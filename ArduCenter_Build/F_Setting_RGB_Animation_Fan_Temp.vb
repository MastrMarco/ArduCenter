Public Class F_Setting_RGB_Animation_Fan_Temp
    Private Sub F_Setting_RGB_Animation_Fan_Temp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Btn_Temp_CPU.Click
        ' F_Avvio.Data3 = 304
        F_Avvio.Data9 = 2

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Btn_Temp_GPU.Click
        ' F_Avvio.Data3 = 304
        F_Avvio.Data9 = 3
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Btn_Temp_SenS.Click
        'F_Avvio.Data3 = 304
        F_Avvio.Data9 = 1
    End Sub
End Class