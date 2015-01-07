Namespace MatthewSnaith.Models

    Public Class About
        Public Property Disclamer As String = Repeat(My.Resources.About_P1)

        Public Function Repeat(ByVal disclamer As String) As String
            Dim result As String = Nothing
            Dim maxValue As Integer = 3


            For index As Integer = 1 To maxValue
                result &= disclamer
            Next

            Return result
        End Function

    End Class
End Namespace