Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium.Support.UI

Public Class ChromeSetup
    Public Shared Function LaunchApplication(Optional ByVal address As String = "") As ChromeDriver

        Dim myDriver As New ChromeDriver("C:\Users\snaithm\Downloads\chromedriver_win32")

        myDriver.Navigate.GoToUrl("http://localhost:4356/" + address)

        Return myDriver
    End Function
End Class
