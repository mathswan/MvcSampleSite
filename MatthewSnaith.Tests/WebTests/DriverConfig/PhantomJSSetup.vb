Imports OpenQA.Selenium
Imports OpenQA.Selenium.PhantomJS
Imports OpenQA.Selenium.Support.UI

Public Class PhantomJSSetup
    Public Shared Function LaunchApplication(Optional ByVal address As String = "") As PhantomJSDriver

        Dim myDriver As New PhantomJSDriver("C:\Users\snaithm\Downloads\phantomjs-1.9.8-windows\phantomjs-1.9.8-windows")

        myDriver.Navigate.GoToUrl("http://localhost:4356/" + address)

        Return myDriver
    End Function
End Class
