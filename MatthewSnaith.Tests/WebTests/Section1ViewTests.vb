Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium.Support.UI
Imports MatthewSnaith.Tests.PhantomJSSetup
Imports OpenQA.Selenium.PhantomJS

<TestClass()> Public Class Section1ViewTests

    <TestMethod()> Public Sub Section1_View_Title_Test()

        Assert.AreEqual("Section 1", webPage.Title)
    End Sub

    <TestMethod()> Public Sub Section1_View_Wave_Img()

        Assert.IsTrue(webPage.PageSource.Contains("wave.jpg"))
    End Sub

    <TestInitialize()>
    Public Sub InitialiseDriver()
        webPage = LaunchApplication("Section1/Section1")
    End Sub

    <TestCleanup()>
    Public Sub Cleanup()
        webPage.Close()
    End Sub

    Dim webPage As PhantomJSDriver
End Class