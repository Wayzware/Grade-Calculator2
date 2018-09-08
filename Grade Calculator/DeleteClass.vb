Imports System.IO
Public Class DeleteClass
    Public Sub LoadClassList(names)
        For x = 1 To names.Length - 1
            ListBox1.Items.Add(names(x))
        Next
    End Sub

    Private Sub ClearClassList()
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If getSelectedItems().length > 0 Then
            If MsgBox("Are you sure you want to delete the grading scale for: " & ListBox1.SelectedItem & "?", MsgBoxStyle.YesNo, "Delete") = 6 Then
                deleteFiles(ListBox1.SelectedItem)
                Main.RefreshList()
                ClearClassList()
                LoadClassList(Main.returnNames())
            End If
        Else
            MsgBox("No class was selected!", MsgBoxStyle.OkOnly, "Error!")
        End If
    End Sub

    Private Function processStrings(data)
        Dim finalString As String = ""

        For x = 0 To Main.names.Length - 1
            If data(x, 1) Then
                finalString = finalString & " " & data(x, 0) & ","
            End If
        Next

        MessageBox.Show(finalString)

        finalString.Reverse
        finalString = finalString.Substring(1)
        finalString.Reverse

        Return finalString
    End Function

    Private Function getSelectedItems()
        Dim data(Main.names.Length, 2)
        For x = 0 To Main.names.Length - 1
            data(x, 0) = Main.names(x)
        Next

        Dim counter As Integer = 0
        For Each i In ListBox1.Items
            data(counter, 1) = ListBox1.GetSelected(counter)
            counter += 1
        Next

        Return data
    End Function

    Private Sub deleteFiles(selectedItem)
        'Dim amountOfFiles As Integer = 0
        'For x = 0 To Main.names.Length - 1
        '    If Data(x, 1) Then
        '        amountOfFiles += 1
        '    End If
        'Next

        'Dim filesToDelete(amountOfFiles) As String
        'Dim fileNum As Integer = 0
        'For x = 0 To Main.names.Length - 1
        '    If Data(x, 1) Then
        '        filesToDelete(fileNum) = Main.returnDataDirectory & Data(x, 0) & ".gcd"
        '        fileNum += 1
        '    End If
        'Next

        'For Each x In filesToDelete
        '    File.Delete(x)
        'Next

        File.Delete(Main.returnDataDirectory & selectedItem & ".gcd")

        MsgBox("File Deleted!", MsgBoxStyle.OkOnly, "File Deleted")
    End Sub

    Private Sub DeleteClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadClassList(Main.returnNames())
    End Sub
End Class
