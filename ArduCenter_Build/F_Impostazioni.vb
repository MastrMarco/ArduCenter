Imports Microsoft.Win32

Public Class F_Impostazioni
    Private Sub AvvioWindows_Click(sender As Object, e As EventArgs) Handles AvvioWindows.Click

        Dim reg As RegistryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
        reg.SetValue("ArduCenter", Application.ExecutablePath.ToString())

    End Sub
End Class