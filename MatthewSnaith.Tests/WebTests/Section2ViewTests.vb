Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium.Support.UI
Imports MatthewSnaith.Tests.PhantomJSSetup
Imports OpenQA.Selenium.PhantomJS

<TestClass()> Public Class Section2ViewTests

    <TestMethod()> Public Sub Section1_View_Title_Test()

        Assert.AreEqual("Section 2", webPage.Title)
    End Sub

    <TestMethod()> Public Sub Section1_View_Wood_Img()

        Assert.IsTrue(webPage.PageSource.Contains("wood.jpg"))
    End Sub

    <TestInitialize()>
    Public Sub InitialiseDriver()
        webPage = LaunchApplication("Section2/Section2")
    End Sub

    <TestCleanup()>
    Public Sub Cleanup()
        webPage.Close()
    End Sub

    Dim webPage As PhantomJSDriver
End Class