Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium.Support.UI
Imports OpenQA.Selenium.PhantomJS
Imports MatthewSnaith.Tests.PhantomJSSetup

<TestClass()> Public Class HomeViewTests

    <TestMethod()> Public Sub Home_View_Title_Test()
        Dim webPage As PhantomJSDriver = LaunchApplication()

        Assert.AreEqual("Home", webPage.Title)
        webPage.Close()
    End Sub

    <TestMethod()> Public Sub Home_View_Content_Test()
        Dim contentText As String = "A little bit about the person called John Smith"
        Dim webPage As PhantomJSDriver = LaunchApplication()

        Assert.IsTrue(webPage.PageSource.Contains(contentText))
        webPage.Close()
    End Sub

    <TestMethod()> Public Sub Home_View_Next_Button_Click_Redirects_To_About_View()
        Dim webPage As PhantomJSDriver = LaunchApplication()

        webPage.FindElementById("Next").Click()

        Assert.AreEqual("About", webPage.Title)
        webPage.Close()
    End Sub

End Class