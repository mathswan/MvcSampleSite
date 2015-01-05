Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports MatthewSnaith.MatthewSnaith.Models

<TestClass()> Public Class Section1ModelTests

    <TestMethod()> Public Sub Section1_Model_Produces_SectionDetails()
        Dim section As New Section1

        Assert.AreEqual(section.SectionDetails, "This is the content of section 1")
    End Sub

End Class