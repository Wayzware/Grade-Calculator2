﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPoints
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddPoints))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PointsEarnedTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PointsPossibleTB = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CategoryLabel = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add assignment/test/quiz to:"
        '
        'PointsEarnedTB
        '
        Me.PointsEarnedTB.Location = New System.Drawing.Point(11, 50)
        Me.PointsEarnedTB.Name = "PointsEarnedTB"
        Me.PointsEarnedTB.Size = New System.Drawing.Size(72, 20)
        Me.PointsEarnedTB.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Points Earned"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(104, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Points Possible"
        '
        'PointsPossibleTB
        '
        Me.PointsPossibleTB.Location = New System.Drawing.Point(107, 50)
        Me.PointsPossibleTB.Name = "PointsPossibleTB"
        Me.PointsPossibleTB.Size = New System.Drawing.Size(72, 20)
        Me.PointsPossibleTB.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(11, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CategoryLabel
        '
        Me.CategoryLabel.AutoSize = True
        Me.CategoryLabel.Location = New System.Drawing.Point(12, 28)
        Me.CategoryLabel.Name = "CategoryLabel"
        Me.CategoryLabel.Size = New System.Drawing.Size(74, 13)
        Me.CategoryLabel.TabIndex = 6
        Me.CategoryLabel.Text = "{CATEGORY}"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(96, 90)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(79, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Remove"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'AddPoints
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(188, 125)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CategoryLabel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PointsPossibleTB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PointsEarnedTB)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(204, 164)
        Me.MinimumSize = New System.Drawing.Size(204, 164)
        Me.Name = "AddPoints"
        Me.Text = "Add"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PointsEarnedTB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PointsPossibleTB As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CategoryLabel As Label
    Friend WithEvents Button2 As Button
End Class
