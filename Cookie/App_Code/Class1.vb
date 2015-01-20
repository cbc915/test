Imports Microsoft.VisualBasic

Public Class Class1
    Function getCookie() As String

        If HttpContext.Current.Request.Cookies("TEST_COOKIE") Is Nothing Then
            HttpContext.Current.Response.Cookies("TEST_COOKIE").Value = ""
        End If
        getCookie = HttpContext.Current.Request.Cookies("TEST_COOKIE").Value

        'getCookie = "1234"

    End Function
End Class
