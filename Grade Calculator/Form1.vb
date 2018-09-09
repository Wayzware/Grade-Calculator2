Public Class Form1
    Private Sub ButtonCalculate_Click(sender As Object, e As EventArgs) Handles ButtonCalculate.Click
        Main.Calculate()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main.startup()
        Main.Startup2()
        Main.SetupClasses()
    End Sub
    Private Sub AddClassToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddClassToolStripMenuItem.Click
        NewSchoolClass.Show()
    End Sub
    Private Sub RefreshClassListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshClassListToolStripMenuItem.Click
        Main.startup()
        Main.Startup2()
        Main.SetupClasses()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub ClassCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ClassCB.SelectedIndexChanged
        Main.SelectionIndexChanged()
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        Main.ClearText()
    End Sub

    Private Sub SelectFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectFolderToolStripMenuItem.Click
        DeleteClass.Show()
    End Sub

    Private Sub GPACalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GPACalculatorToolStripMenuItem.Click
        GPA.Show()
    End Sub
End Class