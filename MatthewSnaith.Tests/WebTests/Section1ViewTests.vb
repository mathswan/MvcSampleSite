Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium.Support.UI
Imports MatthewSnaith.Tests.PhantomJSSetup
Imports OpenQA.Selenium.PhantomJS

<TestClass()> Public Class Section1ViewTests

    <TestMethod()> Public Sub Section1_View_Title_Test()
        Dim webPage As PhantomJSDriver = LaunchApplication("Section1/Section1")

        Assert.AreEqual("Section 1", webPage.Title)
        webPage.Close()
    End Sub

    <TestMethod()> Public Sub Section1_View_Wave_Img()
        Dim webPage As PhantomJSDriver = LaunchApplication("Section1/Section1")

        Assert.IsTrue(webPage.PageSource.Contains("wave.jpg"))
        webPage.Close()
    End Sub

End Class