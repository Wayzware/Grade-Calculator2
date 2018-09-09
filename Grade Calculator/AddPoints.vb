Public Class AddPoints
    Dim ID As Integer
    Private Sub AddPoints_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        importID()
        setCategoryName()
    End Sub

    Private Sub importID()
        ID = Main.returnCatID()
    End Sub

    Private Sub setCategoryName()
        If ID = 1 Then
            CategoryLabel.Text = Form1.TextBox6.Text
        ElseIf ID = 2 Then
            CategoryLabel.Text = Form1.TextBox7.Text
        ElseIf ID = 3 Then
            CategoryLabel.Text = Form1.TextBox8.Text
        ElseIf ID = 4 Then
            CategoryLabel.Text = Form1.TextBox9.Text
        ElseIf ID = 5 Then
            CategoryLabel.Text = Form1.TextBox10.Text
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Main.addPoints(ID, Val(PointsEarnedTB.Text), Val(PointsPossibleTB.Text))
    End Sub
End Class