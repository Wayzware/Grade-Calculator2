<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectScale
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
        Me.ButtonHealth = New System.Windows.Forms.Button()
        Me.ButtonBioX = New System.Windows.Forms.Button()
        Me.ButtonEnglish = New System.Windows.Forms.Button()
        Me.ButtonMath4X = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonHealth
        '
        Me.ButtonHealth.Location = New System.Drawing.Point(12, 12)
        Me.ButtonHealth.Name = "ButtonHealth"
        Me.ButtonHealth.Size = New System.Drawing.Size(75, 75)
        Me.ButtonHealth.TabIndex = 0
        Me.ButtonHealth.Text = "Health"
        Me.ButtonHealth.UseVisualStyleBackColor = True
        '
        'ButtonBioX
        '
        Me.ButtonBioX.Location = New System.Drawing.Point(93, 12)
        Me.ButtonBioX.Name = "ButtonBioX"
        Me.ButtonBioX.Size = New System.Drawing.Size(75, 75)
        Me.ButtonBioX.TabIndex = 1
        Me.ButtonBioX.Text = "Bio X"
        Me.ButtonBioX.UseVisualStyleBackColor = True
        '
        'ButtonEnglish
        '
        Me.ButtonEnglish.Location = New System.Drawing.Point(12, 93)
        Me.ButtonEnglish.Name = "ButtonEnglish"
        Me.ButtonEnglish.Size = New System.Drawing.Size(75, 75)
        Me.ButtonEnglish.TabIndex = 2
        Me.ButtonEnglish.Text = "English"
        Me.ButtonEnglish.UseVisualStyleBackColor = True
        '
        'ButtonMath4X
        '
        Me.ButtonMath4X.Location = New System.Drawing.Point(93, 93)
        Me.ButtonMath4X.Name = "ButtonMath4X"
        Me.ButtonMath4X.Size = New System.Drawing.Size(75, 75)
        Me.ButtonMath4X.TabIndex = 3
        Me.ButtonMath4X.Text = "Math 4X"
        Me.ButtonMath4X.UseVisualStyleBackColor = True
        '
        'SelectScale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(176, 180)
        Me.Controls.Add(Me.ButtonMath4X)
        Me.Controls.Add(Me.ButtonEnglish)
        Me.Controls.Add(Me.ButtonBioX)
        Me.Controls.Add(Me.ButtonHealth)
        Me.Name = "SelectScale"
        Me.Text = "Scale"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonHealth As Button
    Friend WithEvents ButtonBioX As Button
    Friend WithEvents ButtonEnglish As Button
    Friend WithEvents ButtonMath4X As Button
End Class
