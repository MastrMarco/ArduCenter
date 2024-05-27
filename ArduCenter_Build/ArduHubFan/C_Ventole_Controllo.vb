Public Class C_Ventole_Controllo

    '                                         0    1    2    3    4    5    6    7    8    9    10   11   12
    Public Elemento_SpeedFan() As Integer = {128, 128, 128, 128, 128} 'Velocità Ventole

    'Imposta il Valore del Elemento Sulla seriale quando si cambia l'elemento selezionato
    Public Sub Set_Velocità(Speed As Integer)
        F_Avvio.Data5 = Elemento_SpeedFan(Speed)
    End Sub

    'Aggiorna la Velocità dell'Elemento Selezionato
    Public Sub Velocità_Elemento(Speed As Integer)
        If F_Avvio.Data1 >= 0 And F_Avvio.Data1 < 5 Then
            F_Avvio.Data5 = Speed
            Elemento_SpeedFan(F_Avvio.Data1) = Speed
        End If
    End Sub

End Class
