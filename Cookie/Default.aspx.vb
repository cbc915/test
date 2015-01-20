Imports Class1

Partial Class _Default
    Inherits System.Web.UI.Page
    Dim mClass As New Class1

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click

        Response.Cookies("TEST_COOKIE").Value = TextBox1.Text

    End Sub


    Protected Sub Button2_Click(sender As Object, e As System.EventArgs) Handles Button2.Click

        'Label1.Text = Request.Cookies("TEST_COOKIE").Value
        Label1.Text = mClass.getCookie()

    End Sub
End Class
