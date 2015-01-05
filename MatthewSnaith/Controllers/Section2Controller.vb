Namespace MatthewSnaith.Models

    Public Class Section2Controller
        Inherits System.Web.Mvc.Controller

        Public Function Section2() As ActionResult
            Dim pageDetails As New Section2
            ViewData("SectionDetails") = pageDetails.SectionDetails
            Return View("Section2")
        End Function

    End Class
End Namespace