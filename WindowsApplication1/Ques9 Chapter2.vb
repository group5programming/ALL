Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Unit As Double
        Dim Amount As Double
        Unit = Val(TextBox1.Text)

        If Unit <= 100 Then
            Amount = 20
        ElseIf Unit > 100 And Unit <= 300 Then
            Amount = (0.22 * (Unit - 100)) + 20
        ElseIf Unit > 300 Then
            Amount = (0.28 * (Unit - 300)) + ((300 - 100) * 0.22) + 20

        End If
        TextBox2.Text = Amount
    End Sub
End Class