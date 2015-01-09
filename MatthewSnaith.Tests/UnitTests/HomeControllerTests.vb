Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports MatthewSnaith.MatthewSnaith.Models
Imports System.Web.Mvc

<TestClass()> Public Class HomeControllerTests

    <TestMethod()> Public Sub Home_Controller_Returns_Index_View()
        Dim result As ViewResult = controller.Index()

        Assert.AreEqual("Index", result.ViewName)
    End Sub

    <TestMethod()> Public Sub Home_About_Method_Returns_About_View()
        Dim result As ViewResult = controller.About()

        Assert.AreEqual("About", result.ViewName)
    End Sub

    Dim controller As New HomeController
End Class