Namespace MatthewSnaith.Models

    Public Class AboutController
        Inherits System.Web.Mvc.Controller

        Public Function About() As ActionResult
            Dim aboutContent As New About
            ViewData("Disclamer") = aboutContent.Disclamer
            Return View()
        End Function

    End Class

End Namespace
