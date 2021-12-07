Public Class Rumah
    Inherits Gedung

    Public Overrides Function lantai() As Integer
        Return 5
    End Function

    Public Function PenghuniTerakhir() As String
        Return MsgBox("Penghuni terakhir yang beruntung adalah Fava")
    End Function
End Class
