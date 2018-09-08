Public Class GPA
    Dim startGrade, endGrade As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GetSchoolProgress()
        Dim maxUW, maxW, currentUW, currentW, scale As Single
        Dim startMultiplier = startGrade - 1
        If UWTextBox.Text = "" And WTextBox.Text = "" Then
            If startGrade <> 1 Then
                MsgBox("Error! Please enter your current GPA!", MsgBoxStyle.Exclamation, "Error")
                Exit Sub
            End If
        End If
        If startGrade > endGrade Then
            MsgBox("Error! Please recheck your school progress entry!", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If Not (Single.TryParse(UWTextBox.Text, currentUW) Or Single.TryParse(WTextBox.Text, currentW)) Then
            MsgBox("Error! Please recheck your current GPA!", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If

        If currentUW > 5 Then
            scale = 12
        Else
            scale = 4
        End If

        maxUW = (currentUW * (startGrade - 1) + (endGrade - (startGrade - 1)) * scale) / endGrade
        maxW = (currentW * (startGrade - 1) + (endGrade - (startGrade - 1)) * scale * 5 / 4) / endGrade

        UWMaxTextBox.Text = maxUW
        WMaxTextBox.Text = maxW

    End Sub

    Private Sub GetSchoolProgress()
        If RadioButton1.Checked Then
            startGrade = 1
        ElseIf RadioButton2.Checked Then
            startGrade = 2
        ElseIf RadioButton3.Checked Then
            startGrade = 3
        ElseIf RadioButton4.Checked Then
            startGrade = 4
        ElseIf RadioButton8.Checked Then
            startGrade = 5
        ElseIf RadioButton7.Checked Then
            startGrade = 6
        ElseIf RadioButton6.Checked Then
            startGrade = 7
        ElseIf RadioButton5.Checked Then
            startGrade = 8
        ElseIf RadioButton12.Checked Then
            startGrade = 9
        ElseIf RadioButton11.Checked Then
            startGrade = 10
        ElseIf RadioButton10.Checked Then
            startGrade = 11
        ElseIf RadioButton9.Checked Then
            startGrade = 12
        ElseIf RadioButton16.Checked Then
            startGrade = 13
        ElseIf RadioButton15.Checked Then
            startGrade = 14
        ElseIf RadioButton14.Checked Then
            startGrade = 15
        ElseIf RadioButton13.Checked Then
            startGrade = 16
        Else
            MsgBox("Select your current grade level!", MsgBoxStyle.OkOnly, "Error")
            startGrade = -1
            Exit Sub
        End If

        If RadioButton32.Checked Then
            endGrade = 1
        ElseIf RadioButton31.Checked Then
            endGrade = 2
        ElseIf RadioButton30.Checked Then
            endGrade = 3
        ElseIf RadioButton29.Checked Then
            endGrade = 4
        ElseIf RadioButton28.Checked Then
            endGrade = 5
        ElseIf RadioButton27.Checked Then
            endGrade = 6
        ElseIf RadioButton26.Checked Then
            endGrade = 7
        ElseIf RadioButton25.Checked Then
            endGrade = 8
        ElseIf RadioButton24.Checked Then
            endGrade = 9
        ElseIf RadioButton23.Checked Then
            endGrade = 10
        ElseIf RadioButton22.Checked Then
            endGrade = 11
        ElseIf RadioButton21.Checked Then
            endGrade = 12
        ElseIf RadioButton20.Checked Then
            endGrade = 13
        ElseIf RadioButton19.Checked Then
            endGrade = 14
        ElseIf RadioButton18.Checked Then
            endGrade = 15
        ElseIf RadioButton17.Checked Then
            endGrade = 16
        Else
            MsgBox("Select your end grade level!", MsgBoxStyle.OkOnly, "Error")
            endGrade = -1
            Exit Sub
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GetSchoolProgress()
        Dim maxUW, maxW, currentUW, currentW, scale As Single
        Dim startMultiplier = startGrade - 1
        If UWTextBox.Text = "" And WTextBox.Text = "" Then
            If startGrade <> 1 Then
                MsgBox("Error! Please enter your current GPA!", MsgBoxStyle.Exclamation, "Error")
                Exit Sub
            End If
        End If
        If startGrade <> endGrade Then
            MsgBox("Error! Current quarter and final quarter must be the same for this calculation!", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If Not (Single.TryParse(UWTextBox.Text, currentUW) Or Single.TryParse(WTextBox.Text, currentW)) Then
            MsgBox("Error! Please recheck your current GPA!", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If

        currentUW = Single.Parse(UWTextBox.Text & "")
        currentW = Single.Parse(WTextBox.Text & "")

        If currentUW > 5 Then
            scale = 12
        Else
            scale = 4
        End If

        Dim gradeTBs(4) As TextBox
        Dim gradeCBs(4) As CheckBox

        gradeTBs(0) = TextBox3
        gradeTBs(1) = TextBox4
        gradeTBs(2) = TextBox5
        gradeTBs(3) = TextBox6

        gradeCBs(0) = CheckBox1
        gradeCBs(1) = CheckBox2
        gradeCBs(2) = CheckBox3
        gradeCBs(3) = CheckBox4

        Dim GPAPointTotal, WGPAPointTotal As Single
        GPAPointTotal = 0
        WGPAPointTotal = 0

        Dim errors As Integer = 0


        For x = 0 To 3
            If gradeTBs(x).Text.ToUpper.Equals("A") Or gradeTBs(x).Text.ToUpper.Equals("A+") Then
                GPAPointTotal += 12
            ElseIf gradeTBs(x).Text.ToUpper.Equals("A-") Then
                GPAPointTotal += 11
            ElseIf gradeTBs(x).Text.ToUpper.Equals("B+") Then
                GPAPointTotal += 10
            ElseIf gradeTBs(x).Text.ToUpper.Equals("B") Then
                GPAPointTotal += 9
            ElseIf gradeTBs(x).Text.ToUpper.Equals("B-") Then
                GPAPointTotal += 8
            ElseIf gradeTBs(x).Text.ToUpper.Equals("C+") Then
                GPAPointTotal += 7
            ElseIf gradeTBs(x).Text.ToUpper.Equals("C") Then
                GPAPointTotal += 6
            ElseIf gradeTBs(x).Text.ToUpper.Equals("C-") Then
                GPAPointTotal += 5
            ElseIf gradeTBs(x).Text.ToUpper.Equals("D+") Then
                GPAPointTotal += 4
            ElseIf gradeTBs(x).Text.ToUpper.Equals("D") Then
                GPAPointTotal += 3
            ElseIf gradeTBs(x).Text.ToUpper.Equals("D-") Then
                GPAPointTotal += 2
            ElseIf gradeTBs(x).Text.ToUpper.Equals("F") Then
                GPAPointTotal += 0
            Else
                errors += 1
                If errors >= 1 Then
                    MsgBox("Error! Too few classes entered!", MsgBoxStyle.Exclamation, "Error!")
                    Exit Sub
                End If
            End If
            If gradeCBs(x).Checked Then
                WGPAPointTotal += 3
            End If
        Next

        If scale = 4 Then
            GPAPointTotal *= (1 / 3)
            WGPAPointTotal *= (1 / 3)
        End If

        WGPAPointTotal += GPAPointTotal

        WGPAPointTotal /= 4
        GPAPointTotal /= 4

        maxUW = (currentUW * (startGrade - 1) + GPAPointTotal) / endGrade
        maxW = (currentW * (startGrade - 1) + WGPAPointTotal) / endGrade

        TextBox2.Text = maxUW
        TextBox1.Text = maxW

    End Sub

    Private Sub GPA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolTip1.SetToolTip(Label12, "Assuming only AP classes, may not actually be possible")
        ToolTip2.SetToolTip(WMaxTextBox, "Assuming only AP classes, may not actually be possible")
        ToolTip3.SetToolTip(GroupBox9, "Note, this only works when the current quarter and the end quarter are the same!")
    End Sub

End Class