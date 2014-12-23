Namespace MatthewSnaith.Models

    Public Class HomeController
        Inherits System.Web.Mvc.Controller

        Public Function Index() As ActionResult
            Dim myDetails As New MyDetails
            ViewData("Name") = myDetails.Name
            ViewData("Information") = myDetails.Information
            Return View()
        End Function

    End Class
End Namespace
