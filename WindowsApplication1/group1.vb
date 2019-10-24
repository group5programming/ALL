Public Class group1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim temp As Double
        Dim sta As String

        temp = Val(TextBox1.Text)

        If (temp >= 0) And (temp <= 30) Then
            sta = "cold"
        ElseIf (temp > 30) And (temp <= 50) Then
            sta = "medium"
        ElseIf (temp > 50) And (temp <= 70) Then
            sta = "hot"
        ElseIf (temp > 70) And (temp <= 100) Then
            sta = "very hot"
        End If

        TextBox2.Text = sta
        MsgBox(sta)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()

    End Sub
End Class
