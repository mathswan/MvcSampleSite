Namespace MatthewSnaith.Models

    Public Class HomeController
        Inherits System.Web.Mvc.Controller

        Public Function Index() As ActionResult
            Dim myDetails As New Home
            ViewData("Name") = myDetails.Name
            ViewData("Information") = myDetails.Information
            Return View("Index")
        End Function

    End Class
End Namespace