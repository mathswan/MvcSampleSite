﻿Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports OpenQA.Selenium.IE
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium.Support.UI

<TestClass()> Public Class HomeViewTests

    <TestMethod()> Public Sub Page_Title_Test()
        Dim expectedPageTitle As String = "Home"
        Dim myDriver As ChromeDriver = StartApplicationLocally()

        Dim actualpageTitle As String = myDriver.Title
        myDriver.Close()

        Assert.AreEqual(expectedPageTitle, actualpageTitle)
    End Sub

    <TestMethod()> Public Sub Page_Content_Text_Test()
        Dim contentText As String = "A little bit about the person called John Smith"
        Dim myDriver As ChromeDriver = StartApplicationLocally()
        
        Dim result As Boolean = False
        If myDriver.PageSource.Contains(contentText) Then
            result = True
        End If
        myDriver.Close()

        Assert.IsTrue(result)
    End Sub

    Public Function StartApplicationLocally() As ChromeDriver

        Dim myDriver As New ChromeDriver("C:\Users\snaithm\Downloads\chromedriver_win32")

        myDriver.Navigate.GoToUrl("http://localhost:4356/")

        Return myDriver
    End Function

End Class