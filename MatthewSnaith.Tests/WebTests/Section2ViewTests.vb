Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium.Support.UI
Imports MatthewSnaith.Tests.PhantomJSSetup
Imports OpenQA.Selenium.PhantomJS


<TestClass()> Public Class Section2ViewTests

    <TestMethod()> Public Sub Section1_View_Title_Test()
        Dim webPage As PhantomJSDriver = LaunchApplication("Section2/Section2")

        Assert.AreEqual("Section 2", webPage.Title)
        webPage.Close()
    End Sub

    <TestMethod()> Public Sub Section1_View_Wood_Img()
        Dim webPage As PhantomJSDriver = LaunchApplication("Section2/Section2")

        Assert.IsTrue(webPage.PageSource.Contains("wood.jpg"))
        webPage.Close()
    End Sub

End Class