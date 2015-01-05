Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports MatthewSnaith.MatthewSnaith.Models
Imports System.Web.Mvc

<TestClass()> Public Class Section2ControllerTests

    <TestMethod()> Public Sub Section2_Controller_Returns_Section1_View()
        Dim controller As New Section2Controller
        Dim result As ViewResult = controller.Section2

        Assert.AreEqual("Section2", result.ViewName)
    End Sub

End Class