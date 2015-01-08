Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium.Support.UI
Imports MatthewSnaith.Tests.PhantomJSSetup
Imports OpenQA.Selenium.PhantomJS

<TestClass()> Public Class LayoutViewTests

    <TestMethod()> Public Sub Layout_View_Contains_Disclaimer()
        Dim webPage As PhantomJSDriver = LaunchApplication()

        Assert.IsTrue(webPage.PageSource.Contains("DSD 2014. All Rights Reserved."))
        webPage.Close()
    End Sub

End Class