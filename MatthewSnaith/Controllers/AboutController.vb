Namespace MatthewSnaith.Models

    Public Class AboutController
        Inherits System.Web.Mvc.Controller

        Public Function About() As ActionResult
            Dim aboutContent As New About
            ViewData("Disclamer") = aboutContent.Disclamer
            Return View("About")
        End Function

        Function Index() As ViewResult
            Throw New NotImplementedException
        End Function

    End Class

End Namespace
