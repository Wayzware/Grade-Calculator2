Imports System.IO
Public Class NewSchoolClass
    Dim values(35) As String
    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        gatherdata()
        If checkforconflicts() Then
            SaveFileForValues()
        End If
        Main.RefreshList()
    End Sub

    Private Sub gatherdata()
        values(1) = subjectNameTxt.Text
        values(2) = TextBox2.Text
        values(3) = TextBox2.Text - 0.0001
        values(4) = TextBox3.Text - 0.0001
        values(5) = TextBox4.Text - 0.0001
        values(6) = TextBox5.Text - 0.0001
        values(7) = TextBox6.Text - 0.0001
        values(8) = TextBox7.Text - 0.0001
        values(9) = TextBox8.Text - 0.0001
        values(10) = TextBox9.Text - 0.0001
        values(11) = TextBox10.Text - 0.0001
        values(12) = TextBox11.Text - 0.0001
        values(13) = TextBox12.Text - 0.0001
        values(14) = TextBox13.Text - 0.0001
        values(15) = TextBox3.Text
        values(16) = TextBox4.Text
        values(17) = TextBox5.Text
        values(18) = TextBox6.Text
        values(19) = TextBox7.Text
        values(20) = TextBox8.Text
        values(21) = TextBox9.Text
        values(22) = TextBox10.Text
        values(23) = TextBox11.Text
        values(24) = TextBox12.Text
        values(25) = TextBox13.Text
        values(26) = TextBox14.Text
        values(27) = TextBox27.Text
        values(28) = TextBox29.Text
        values(29) = TextBox31.Text
        values(30) = TextBox33.Text
        values(31) = TextBox1.Text & ""
        values(32) = TextBox28.Text & ""
        values(33) = TextBox30.Text & ""
        values(34) = TextBox32.Text & ""
        values(35) = TextBox34.Text & ""
        values = reformdata(values)
    End Sub

    Private Function checkforconflicts()
        Dim good As Boolean
        good = True
        If values(1) = "" Then
            MsgBox("Enter a name for the class", MsgBoxStyle.OkOnly, "Error")
            good = False
        End If
        If checkforconflicts2(subjectNameTxt.Text) And good = True Then
            If MsgBox("Do you want to overwrite the grading scale for " & subjectNameTxt.Text & "?", MsgBoxStyle.YesNo, "Overwrite File") = 7 Then
                good = False
            Else
                File.Delete(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Grade Calculator\Classes\" & values(1) & ".gcd")
                good = True
            End If
        Else
            good = True
        End If
        If values(2) = 0 Then
            values(2) = 100.001
        End If
        Return good
    End Function
    Public Function checkforconflicts2(name)
        Dim errortf As Boolean
        errortf = False
        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Grade Calculator\Classes\" & name & ".gcd") Then
            errortf = True
        End If
        Return errortf
    End Function
    Private Function reformdata(values)
        Dim idk As Double
        For x = 2 To 30
            If Not Double.TryParse(values(x), idk) Then
                values(x) = "0"
            End If
        Next
        Return values
    End Function

    Private Sub SaveFileForValues()
        Dim datafilelocation As String
        datafilelocation = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Grade Calculator\Classes\" & values(1) & ".gcd"
        FileOpen(1, datafilelocation, OpenMode.Output)
        For x = 1 To 35
            PrintLine(1, values(x))
        Next
        FileClose(1)
        MsgBox("File saved!", MsgBoxStyle.OkOnly, "Success")
        Main.RefreshList()
        Me.Close()
    End Sub

    Private Sub DefaultButton_Click(sender As Object, e As EventArgs) Handles DefaultButton.Click
        TextBox2.Text = 97
        TextBox3.Text = 93
        TextBox4.Text = 90
        TextBox5.Text = 87
        TextBox6.Text = 83
        TextBox7.Text = 80
        TextBox8.Text = 77
        TextBox9.Text = 73
        TextBox10.Text = 70
        TextBox11.Text = 67
        TextBox12.Text = 63
        TextBox13.Text = 60
    End Sub

    Private Sub LangDefaultButton_Click(sender As Object, e As EventArgs) Handles LangDefaultButton.Click
        'TextBox2.Text = 97
        'TextBox3.Text = 93
        'TextBox4.Text = 90
        'TextBox5.Text = 87
        'TextBox6.Text = 83
        'TextBox7.Text = 80
        'TextBox8.Text = 77
        'TextBox9.Text = 73
        'TextBox10.Text = 70
        'TextBox11.Text = 67
        'TextBox12.Text = 63
        'TextBox13.Text = 60
        MsgBox("To be added soon", MsgBoxStyle.OkOnly, "Not yet implemented")
    End Sub
End Class