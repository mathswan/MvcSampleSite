Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports MatthewSnaith.MatthewSnaith.Models
Imports System.Web.Mvc

<TestClass()> Public Class AboutControllerTest

    <TestMethod()> Public Sub About_Controller_Returns_About_View()
        Dim controller As New AboutController
        Dim result As ViewResult = controller.About()

        Assert.AreEqual("About", result.ViewName)
    End Sub

End Class