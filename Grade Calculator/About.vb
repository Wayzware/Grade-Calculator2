Public Class About
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Version " & Main.version
    End Sub
End Class