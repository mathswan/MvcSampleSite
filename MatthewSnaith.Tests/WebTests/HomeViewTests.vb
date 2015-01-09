Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium.Support.UI
Imports OpenQA.Selenium.PhantomJS
Imports MatthewSnaith.Tests.PhantomJSSetup

<TestClass()> Public Class HomeViewTests

    <TestMethod()> Public Sub Home_View_Title_Test()

        Assert.AreEqual("Home", webPage.Title)
    End Sub

    <TestMethod()> Public Sub Home_View_Content_Test()

        Dim contentText As String = "A little bit about the person called John Smith"

        Assert.IsTrue(webPage.PageSource.Contains(contentText))
    End Sub

    <TestMethod()> Public Sub Home_View_Next_Button_Click_Redirects_To_About_View()

        webPage.FindElementById("Next").Click()

        Assert.AreEqual("About", webPage.Title)
    End Sub

    <TestMethod()> Public Sub Home_View_Contains_Name_Textbox()

        Assert.IsTrue(webPage.PageSource.Contains("NameTextbox"))
    End Sub

    <TestInitialize()>
    Public Sub InitialiseDriver()
        webPage = LaunchApplication()
    End Sub

    <TestCleanup()>
    Public Sub Cleanup()
        webPage.Close()
    End Sub

    Dim webPage As PhantomJSDriver
End Class