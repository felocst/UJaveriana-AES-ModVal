

Public Class SumaNumeros

    Public Function SumaNumeros(ByVal reqSumandos As Sumandos) As Int32
        Dim resultado As Int32
        resultado = reqSumandos.Sumando1 + reqSumandos.Sumando2

        Return resultado
    End Function

End Class