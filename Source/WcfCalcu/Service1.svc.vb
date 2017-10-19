
Public Class Service1
    Implements IService1



    Private Function IService1_SumaNumeros(reqSumandos As Sumandos) As Integer Implements IService1.SumaNumeros
        Dim negSuma As New SumaNumeros
        Return negSuma.SumaNumeros(reqSumandos)
    End Function
End Class
