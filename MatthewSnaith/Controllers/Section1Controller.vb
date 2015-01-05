Namespace MatthewSnaith.Models

    Public Class Section1Controller
        Inherits System.Web.Mvc.Controller

        Public Function Section1() As ActionResult
            Dim pageDetails As New Section1
            ViewData("SectionDetails") = pageDetails.SectionDetails
            Return View("Section1")
        End Function

    End Class
End Namespace