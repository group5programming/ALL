Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim id As String
        Dim password As String

        id = Val(TextBox1.Text)
        password = Val(TextBox2.Text)

        If id = "helloworld" And password = "abc1234" Then
            form2.show()
        Else
            MsgBox("not valid")

        End If
    End Sub
End Class
