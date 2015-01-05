Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports MatthewSnaith.MatthewSnaith.Models
Imports System.Web.Mvc

<TestClass()> Public Class Section1ControllerTests

    <TestMethod()> Public Sub Section1_Controller_Returns_Section1_View()
        Dim controller As New Section1Controller
        Dim result As ViewResult = controller.Section1

        Assert.AreEqual("Section1", result.ViewName)
    End Sub

End Class