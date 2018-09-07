﻿Module Main
    Dim ScaleID, ClassID As Integer
    Public names(1) As String
    Public values(1) As String
    Private datafiles As Integer
    Public datadirectory As String
    Public filenames(1), filesgcd(1), gcddata(1) As String
    Public gcdfiles, counter3 As Integer
    Sub Calculate()
        Dim enabled(5) As Boolean
        Dim Input(5), InputOut(5), Percentages(5), Weights(5), Worth(5) As Single
        Dim entries As Integer
        entries = 0
        If Form1.In1.Text <> "" And Form1.InOut1.Text <> "" And Form1.InW1.Text <> "" Then
            Input(1) = Val(Form1.In1.Text)
            InputOut(1) = Val(Form1.InOut1.Text)
            Percentages(1) = (Input(1)) / (InputOut(1))
            Weights(1) = Val(Form1.InW1.Text) / 100
            entries += 1
        End If
        If Form1.In2.Text <> "" And Form1.InOut2.Text <> "" And Form1.InW2.Text <> "" Then
            Input(2) = Val(Form1.In2.Text)
            InputOut(2) = Val(Form1.InOut2.Text)
            Percentages(2) = (Input(2)) / (InputOut(2))
            Weights(2) = Val(Form1.InW2.Text) / 100
            entries += 1
        End If
        If Form1.In3.Text <> "" And Form1.InOut3.Text <> "" And Form1.InW3.Text <> "" Then
            Input(3) = Val(Form1.In3.Text)
            InputOut(3) = Val(Form1.InOut3.Text)
            Percentages(3) = (Input(3)) / (InputOut(3))
            Weights(3) = Val(Form1.InW3.Text) / 100
            entries += 1
        End If
        If Form1.In4.Text <> "" And Form1.InOut4.Text <> "" And Form1.InW4.Text <> "" Then
            Input(4) = Val(Form1.In4.Text)
            InputOut(4) = Val(Form1.InOut4.Text)
            Percentages(4) = (Input(4)) / (InputOut(4))
            Weights(4) = Val(Form1.InW4.Text) / 100
            entries += 1
        End If
        If Form1.In5.Text <> "" And Form1.InOut5.Text <> "" And Form1.InW5.Text <> "" Then
            Input(5) = Val(Form1.In5.Text)
            InputOut(5) = Val(Form1.InOut5.Text)
            Percentages(5) = (Input(5)) / (InputOut(5))
            Weights(5) = Val(Form1.InW5.Text) / 100
            entries += 1
        End If
        Dim total As Single
        For x = 1 To 5
            Worth(x) = Weights(x) * Percentages(x) * 100
            total = total + Worth(x)
        Next
        Form1.NumberOut.Text = total

        If entries > 0 Then
            Form1.Out1.Text = Worth(1)
            Form1.InP1.Text = Percentages(1) * 100
        End If
        If entries > 1 Then
            Form1.Out2.Text = Worth(2)
            Form1.InP2.Text = Percentages(2) * 100
        End If
        If entries > 2 Then
            Form1.Out3.Text = Worth(3)
            Form1.InP3.Text = Percentages(3) * 100
        End If
        If entries > 3 Then
            Form1.Out4.Text = Worth(4)
            Form1.InP4.Text = Percentages(4) * 100
        End If
        If entries > 4 Then
            Form1.Out5.Text = Worth(5)
            Form1.InP5.Text = Percentages(5) * 100
        End If

        If Form1.ClassCB.Text <> "" Then
            Form1.LetterOut.Text = exportgrade(total)
        End If
    End Sub

    Public Sub ClearText()
        Form1.In1.Text = ""
        Form1.In2.Text = ""
        Form1.In3.Text = ""
        Form1.In4.Text = ""
        Form1.InOut1.Text = ""
        Form1.InOut2.Text = ""
        Form1.InOut3.Text = ""
        Form1.InOut4.Text = ""
        Form1.InP1.Text = ""
        Form1.InP2.Text = ""
        Form1.InP3.Text = ""
        Form1.InP4.Text = ""
        Form1.Out1.Text = ""
        Form1.Out2.Text = ""
        Form1.Out3.Text = ""
        Form1.Out4.Text = ""
        Form1.Out5.Text = ""
        Form1.NumberOut.Text = ""
        Form1.LetterOut.Text = ""
    End Sub

    Private Sub ButtonSelectScale_Click(sender As Object, e As EventArgs)
        SelectScale.Show()
    End Sub

    Public Sub SetScaleID(id)
        ScaleID = id
    End Sub
    Public Sub PopulateNameList(namelist, length)
        ReDim names(length)
        names = namelist
    End Sub

    Public Sub PopulateValueList(valuelist, length)
        ReDim values(length)
        values = valuelist
    End Sub

    Public Function checkconflicts(name)
        Return checkforconflicts(name)
    End Function
    Public Sub ImportFileAmount(amount)
        datafiles = gcdfiles
    End Sub

    Public Sub SetupClasses()
        Form1.ClassCB.Items.Clear()
        If names(1) <> "" Then
            For x = 1 To names.Length() - 1
                Form1.ClassCB.Items.Add(names(x))
            Next
        End If
    End Sub

    Public Sub Startup2()
        PopulateNameList(names, gcdfiles)
        PopulateValueList(values, counter3)
    End Sub

    Public Sub startup()
        If Not My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Grade Calculator\Classes\") Then
            My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Grade Calculator\Classes\")
            MsgBox("No grading scales were found", MsgBoxStyle.Exclamation, "Grade Calculator")
            Exit Sub
        End If
        datadirectory = (My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Grade Calculator\Classes\")
        getGCDfiles(datadirectory)
        If Not gcdfiles = 0 Then
            getDataFromGCD(filesgcd)
            exportnames()
            exportvalues()
        End If
    End Sub

    Public Function getGCDfiles(dir)
        Dim x, y, z As Integer
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Grade Calculator\Classes\")
            x = x + 1
            ReDim Preserve filenames(x)
            filenames(x) = foundFile
            x = x + 1
        Next
        y = 1
        z = 1
        If x <> 0 Then

            Do Until y = x
                If Strings.Right(filenames(y), 4) = ".gcd" Then
                    z = z + 1
                    ReDim Preserve filesgcd(z)
                    filesgcd(z) = filenames(y)
                End If
                y = y + 1
            Loop
            gcdfiles = z - 1
        End If
        Return z
    End Function

    Public Sub getDataFromGCD(files)
        Dim a As Integer
        a = 0
        ReDim Preserve gcddata(gcdfiles * 35)
        Do Until a = gcdfiles
            a = a + 1
            FileOpen(1, filesgcd(a + 1), OpenMode.Input)
            For x = (1 + 35 * (a - 1)) To (35 + 35 * (a - 1)) Step 1
                gcddata(x) = LineInput(1)
            Next
            FileClose(1)
        Loop
    End Sub
    Public Sub exportnames()
        Dim counter As Integer
        counter = 0
        Do Until counter = gcdfiles
            For runs = 1 To (gcdfiles * 35) Step 35
                ReDim Preserve names(counter + 1)
                names(counter + 1) = gcddata(runs)
                counter = counter + 1
            Next
        Loop
    End Sub

    Public Sub exportvalues()
        ReDim values(gcddata.Length)
        values = gcddata
    End Sub

    Public Function checkforconflicts(name)
        Dim errortf As Boolean
        errortf = False
        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Grade Calculator\Classes\" & name & ".gcd") Then
            errortf = True
        End If
        Return errortf
    End Function
    Private Sub ClassCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ClassCB.SelectedIndexChanged
        Dim foundmatch As Boolean = False
        ClassID = 0
        Do While foundmatch = False And ClassCB.Text <> "Default"
            If names(ClassID) = ClassCB.Text Then
                foundmatch = True
            ElseIf ClassID > 100 Then
                MsgBox("Invalid class name, aborting", MsgBoxStyle.Critical, "Error")
                Me.Close()
            Else
                ClassID = ClassID + 1
            End If
        Loop
        SetCategories(ClassID)
    End Sub

    Private Sub SelectFolderToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SelectFolderToolStripMenuItem.Click
        DeleteClass.Show()
    End Sub

    Private Function exportgrade(grade)
        Dim lettergrade As String
        Select Case grade
            Case >= values(2 + (ClassID - 1) * 35)
                lettergrade = "A+"
            Case values(15 + (ClassID - 1) * 35) To values(3 + (ClassID - 1) * 35)
                lettergrade = "A"
            Case values(16 + (ClassID - 1) * 35) To values(4 + (ClassID - 1) * 35)
                lettergrade = "A-"
            Case values(17 + (ClassID - 1) * 35) To values(5 + (ClassID - 1) * 35)
                lettergrade = "B+"
            Case values(18 + (ClassID - 1) * 35) To values(6 + (ClassID - 1) * 35)
                lettergrade = "B"
            Case values(19 + (ClassID - 1) * 35) To values(7 + (ClassID - 1) * 35)
                lettergrade = "B-"
            Case values(20 + (ClassID - 1) * 35) To values(8 + (ClassID - 1) * 35)
                lettergrade = "C+"
            Case values(21 + (ClassID - 1) * 35) To values(9 + (ClassID - 1) * 35)
                lettergrade = "C"
            Case values(22 + (ClassID - 1) * 35) To values(10 + (ClassID - 1) * 35)
                lettergrade = "C-"
            Case values(23 + (ClassID - 1) * 35) To values(11 + (ClassID - 1) * 35)
                lettergrade = "D+"
            Case values(24 + (ClassID - 1) * 35) To values(12 + (ClassID - 1) * 35)
                lettergrade = "D"
            Case values(25 + (ClassID - 1) * 35) To values(13 + (ClassID - 1) * 35)
                lettergrade = "D-"
            Case <= values(14 + (ClassID - 1) * 35)
                lettergrade = "F"
            Case Else
                lettergrade = "Unknown"
        End Select
        Return lettergrade
    End Function

    Private Sub SetCategories(ClassID)
        'write code for displaying the categories and their data here
        Dim defaultID As Boolean = True
        If ClassID <> 0 Then
            defaultID = False
        End If
        TextBox6.ReadOnly = defaultID
        TextBox7.ReadOnly = defaultID
        TextBox8.ReadOnly = defaultID
        TextBox9.ReadOnly = defaultID
        TextBox10.ReadOnly = defaultID
        Form1.InW1.ReadOnly = defaultID
        Form1.InW2.ReadOnly = defaultID
        Form1.InW3.ReadOnly = defaultID
        Form1.InW4.ReadOnly = defaultID
        Form1.InW5.ReadOnly = defaultID

        Dim categorynames(5) As String
        For x = 1 To 5
            categorynames(x) = values(30 + x + (ClassID - 1) * 35)
        Next

        TextBox6.Text = categorynames(1)
        TextBox7.Text = categorynames(2)
        TextBox8.Text = categorynames(3)
        TextBox9.Text = categorynames(4)
        TextBox10.Text = categorynames(5)

        Dim used(5) As Boolean
        For x = 1 To 5
            used(x) = True
        Next

        For x = 2 To 5
            If categorynames(x) = "" Then
                used(x) = False
            End If
        Next
        enabletextboxes(used)

        Dim worth(5) As String
        For x = 1 To 5
            worth(x) = values(25 + x + (ClassID - 1) * 35)
        Next

        Form1.InW1.Text = worth(1)
        Form1.InW2.Text = worth(2)
        Form1.InW3.Text = worth(3)
        Form1.InW4.Text = worth(4)
        Form1.InW5.Text = worth(5)

    End Sub

    Private Sub enabletextboxes(usedc)
        TextBox7.Visible = usedc(2)
        In2.Visible = usedc(2)
        Form1.InOut2.Visible = usedc(2)
        InP2.Visible = usedc(2)
        Form1.InW2.Visible = usedc(2)
        Out2.Visible = usedc(2)

        TextBox8.Visible = usedc(3)
        In3.Visible = usedc(3)
        Form1.InOut3.Visible = usedc(3)
        InP3.Visible = usedc(3)
        Form1.InW3.Visible = usedc(3)
        Out3.Visible = usedc(3)

        TextBox9.Visible = usedc(4)
        In4.Visible = usedc(4)
        Form1.InOut4.Visible = usedc(4)
        InP4.Visible = usedc(4)
        Form1.InW4.Visible = usedc(4)
        Out4.Visible = usedc(4)

        TextBox10.Visible = usedc(5)
        In5.Visible = usedc(5)
        Form1.InOut5.Visible = usedc(5)
        InP5.Visible = usedc(5)
        Form1.InW5.Visible = usedc(5)
        Out5.Visible = usedc(5)

    End Sub
    Public Sub RefreshList()
        startup()
        Startup2()
        SetupClasses()
    End Sub
End Module