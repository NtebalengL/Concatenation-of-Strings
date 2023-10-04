Public Class Form1
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim text1, text2, text3, text4 As String
        text1 = "Visual"
        text2 = "Basic"
        text3 = "2023"
        text4 = text1 + " " + text2 + " " + text3
        MsgBox(text4)


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
