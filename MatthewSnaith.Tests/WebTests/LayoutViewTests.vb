Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium.Support.UI
Imports MatthewSnaith.Tests.Startup

<TestClass()> Public Class LayoutViewTests

    <TestMethod()> Public Sub Layout_Contains_Disclaimer()
        Dim disclaimerText As String = "DSD 2014. All Rights Reserved."
        Dim myDriver As ChromeDriver = StartApplicationLocally()

        Dim result As Boolean = False
        If myDriver.PageSource.Contains(disclaimerText) Then
            result = True
        End If
        myDriver.Close()

        Assert.IsTrue(result)
    End Sub

End Class