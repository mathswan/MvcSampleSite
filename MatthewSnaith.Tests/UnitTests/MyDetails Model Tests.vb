Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports MatthewSnaith.MatthewSnaith.Models

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub MyDetails_Model_Generates_Name()
        Dim myDetails = New MyDetails

        Assert.AreEqual(myDetails.Name, "John Smith")
    End Sub

    <TestMethod()> Public Sub MyDetails_Model_Generates_Information()
        Dim myDetails = New MyDetails

        Assert.AreEqual(myDetails.Information, "A little bit about the person called John Smith")
    End Sub

End Class