Public Class frmTestApplication
    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        lblStatus.Text = "This Test application was successful"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
