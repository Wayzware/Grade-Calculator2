Imports System.IO
Public Class DeleteClass
    Public Sub LoadClassList(names)
        For x = 1 To names.Length - 1
            MsgBox(names(x))
            ComboBox1.Items.Add(names(x))
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text <> "" Then
            If MsgBox("Are you sure you want to delete the grading scale for " & ComboBox1.Text & "?", MsgBoxStyle.YesNo, "Delete") = 6 Then
                File.Delete(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Grade Calculator\Classes\" & ComboBox1.Text & ".gcd")
                MsgBox("File Deleted!", MsgBoxStyle.OkOnly, "File Deleted")
            End If
        End If
    End Sub

    Private Sub DeleteClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class