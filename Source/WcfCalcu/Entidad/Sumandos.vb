Public Class Sumandos
    Private _sumando1 As Int32
    Private _sumando2 As Int32

    Public Property Sumando1 As Int32
        Get
            Return _sumando1
        End Get
        Set(value As Int32)
            _sumando1 = value
        End Set
    End Property

    Public Property Sumando2 As Int32
        Get
            Return _sumando2
        End Get
        Set(value As Int32)
            _sumando2 = value
        End Set
    End Property
End Class