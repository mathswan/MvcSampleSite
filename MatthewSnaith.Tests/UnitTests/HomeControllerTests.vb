Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports MatthewSnaith.MatthewSnaith.Models
Imports System.Web.Mvc

<TestClass()> Public Class HomeControllerTests

    <TestMethod()> Public Sub Home_Controller_Returns_Index_View()
        Dim controller As New HomeController
        Dim result As ViewResult = controller.Index()

        Assert.AreEqual("Index", result.ViewName)
    End Sub

End Class