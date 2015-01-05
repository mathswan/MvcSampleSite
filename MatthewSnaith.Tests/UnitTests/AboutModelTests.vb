Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports MatthewSnaith.MatthewSnaith.Models

<TestClass()> Public Class AboutModelTests

    <TestMethod()> Public Sub About_Model_Generates_Disclamer()
        Dim about = New About

        Assert.AreEqual(about.Disclamer, "Under Construction. Under Construction. Under Construction. ")
    End Sub

End Class