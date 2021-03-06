﻿Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium.PhantomJS
Imports OpenQA.Selenium.Support.UI
Imports MatthewSnaith.Tests.PhantomJSSetup

<TestClass()> Public Class AboutViewTests

    <TestMethod()> Public Sub About_View_Page_Title()
        Dim webPage As PhantomJSDriver = LaunchApplication("About/About")

        Assert.AreEqual("About", webPage.Title)
        webPage.Close()
    End Sub

End Class