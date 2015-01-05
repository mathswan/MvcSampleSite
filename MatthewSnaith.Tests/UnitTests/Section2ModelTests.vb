Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports MatthewSnaith.MatthewSnaith.Models

<TestClass()> Public Class Section2ModelTests

    <TestMethod()> Public Sub Section2_Model_Produces_SectionDetails()
        Dim section As New Section2

        Assert.AreEqual(section.SectionDetails, "This is the content of section 2")
    End Sub

End Class