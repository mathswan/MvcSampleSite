Namespace MatthewSnaith.Models

    Public Class HomeController
        Inherits System.Web.Mvc.Controller

        Public Function Index() As ActionResult
            Dim myDetails As New Home
            ViewData("Name") = myDetails.Name
            ViewData("Information") = myDetails.Information
            ViewData("NameLabel") = myDetails.NameLabel
            Return View("Index")
        End Function

        <HttpPost()>
        Public Function About() As ActionResult
            Return View("About")
        End Function

    End Class
End Namespace