Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports MatthewSnaith.MatthewSnaith.Models

<TestClass()> Public Class MyDetailsModelTests

    <TestMethod()> Public Sub MyDetails_Model_Generates_Name()
        Dim myDetails = New Home

        Assert.AreEqual(myDetails.Name, "John Smith")
    End Sub

    <TestMethod()> Public Sub MyDetails_Model_Generates_Information()
        Dim myDetails = New Home

        Assert.AreEqual(myDetails.Information, "A little bit about the person called John Smith")
    End Sub

    <TestMethod()> Public Sub MyDetails_Model_Generates_NameLabel()
        Dim myDetails = New Home

        Assert.AreEqual(myDetails.NameLabel, "Please enter your name")
    End Sub

End Class