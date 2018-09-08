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
        startup()
        Startup2()
        SetupClasses()
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
    Public Sub classNamesInTS_Click(sender As Object, e As ToolStripItemClickedEventHandler)
        If Main.isInNames(sender) Then
            MessageBox.Show("Hi")
        Else
            MessageBox.Show("Bye")
        End If

    End Sub

    Private Sub SelectFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectFolderToolStripMenuItem.Click
        DeleteClass.Show()
    End Sub
End Class