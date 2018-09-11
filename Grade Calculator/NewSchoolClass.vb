Imports System.IO
Public Class NewSchoolClass
    Dim values(45) As String
    Dim categoryData(20) As String
    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        gatherdata()
        If checkforconflicts() Then
            SaveFileForValues()
        End If
        Main.RefreshList()
    End Sub

    Private Sub gatherdata()
        values(1) = subjectNameTxt.Text
        values(2) = Val(TextBox2.Text)
        values(3) = Val(TextBox2.Text) - 0.0001
        values(4) = Val(TextBox3.Text) - 0.0001
        values(5) = Val(TextBox4.Text) - 0.0001
        values(6) = Val(TextBox5.Text) - 0.0001
        values(7) = Val(TextBox6.Text) - 0.0001
        values(8) = Val(TextBox7.Text) - 0.0001
        values(9) = Val(TextBox8.Text) - 0.0001
        values(10) = Val(TextBox9.Text) - 0.0001
        values(11) = Val(TextBox10.Text) - 0.0001
        values(12) = Val(TextBox11.Text) - 0.0001
        values(13) = Val(TextBox12.Text) - 0.0001
        values(14) = Val(TextBox13.Text) - 0.0001
        values(15) = Val(TextBox3.Text)
        values(16) = Val(TextBox4.Text)
        values(17) = Val(TextBox5.Text)
        values(18) = Val(TextBox6.Text)
        values(19) = Val(TextBox7.Text)
        values(20) = Val(TextBox8.Text)
        values(21) = Val(TextBox9.Text)
        values(22) = Val(TextBox10.Text)
        values(23) = Val(TextBox11.Text)
        values(24) = Val(TextBox12.Text)
        values(25) = Val(TextBox13.Text)

        For x = 0 To 19
            values(26 + x) = categoryData(x)
        Next

    End Sub

    Private Sub pageSwitch(oldPage As Integer)
        If oldPage = 1 Then
            categoryData(0) = Val(TextBox14.Text)
            categoryData(1) = Val(TextBox27.Text)
            categoryData(2) = Val(TextBox29.Text)
            categoryData(3) = Val(TextBox31.Text)
            categoryData(4) = Val(TextBox33.Text)
            categoryData(5) = TextBox1.Text & ""
            categoryData(6) = TextBox28.Text & ""
            categoryData(7) = TextBox30.Text & ""
            categoryData(8) = TextBox32.Text & ""
            categoryData(9) = TextBox34.Text & ""
            Button2.Visible = False
            Button1.Visible = True
        ElseIf oldPage = 2 Then
            categoryData(10) = Val(TextBox14.Text)
            categoryData(11) = Val(TextBox27.Text)
            categoryData(12) = Val(TextBox29.Text)
            categoryData(13) = Val(TextBox31.Text)
            categoryData(14) = Val(TextBox33.Text)
            categoryData(15) = TextBox1.Text & ""
            categoryData(16) = TextBox28.Text & ""
            categoryData(17) = TextBox30.Text & ""
            categoryData(18) = TextBox32.Text & ""
            categoryData(19) = TextBox34.Text & ""
            Button1.Visible = False
            Button2.Visible = True
        End If

        If oldPage = 1 Then
            populateCategoryTBs(2)
        Else
            populateCategoryTBs(1)
        End If

        'clearCategoryTBs()
    End Sub

    Private Sub clearCategoryTBs()
        TextBox1.Clear()
        TextBox14.Clear()
        TextBox28.Clear()
        TextBox27.Clear()
        TextBox30.Clear()
        TextBox29.Clear()
        TextBox32.Clear()
        TextBox31.Clear()
        TextBox34.Clear()
        TextBox33.Clear()
    End Sub

    Private Sub populateCategoryTBs(newPage As Integer)
        TextBox14.Text = categoryData(0 + (newPage - 1) * 10)
        TextBox27.Text = categoryData(1 + (newPage - 1) * 10)
        TextBox29.Text = categoryData(2 + (newPage - 1) * 10)
        TextBox31.Text = categoryData(3 + (newPage - 1) * 10)
        TextBox33.Text = categoryData(4 + (newPage - 1) * 10)
        TextBox1.Text = categoryData(5 + (newPage - 1) * 10)
        TextBox28.Text = categoryData(6 + (newPage - 1) * 10)
        TextBox30.Text = categoryData(7 + (newPage - 1) * 10)
        TextBox32.Text = categoryData(8 + (newPage - 1) * 10)
        TextBox34.Text = categoryData(9 + (newPage - 1) * 10)

        If Not TextBox1.Text <> "" Then
            TextBox14.Text = ""
        End If
        If Not TextBox28.Text <> "" Then
            TextBox27.Text = ""
        End If
        If Not TextBox30.Text <> "" Then
            TextBox29.Text = ""
        End If
        If Not TextBox32.Text <> "" Then
            TextBox31.Text = ""
        End If
        If Not TextBox34.Text <> "" Then
            TextBox33.Text = ""
        End If

    End Sub

    Private Function errorCheck()

    End Function

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
        For x = 1 To 45
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pageSwitch(2)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        pageSwitch(1)
    End Sub

    Private Sub NewSchoolClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Visible = False
    End Sub
End Class