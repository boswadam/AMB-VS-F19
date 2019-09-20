<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Flag_Viewer
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
        Me.FlagViewer = New System.Windows.Forms.PictureBox()
        Me.FlagButton1 = New System.Windows.Forms.Button()
        Me.FlagButton2 = New System.Windows.Forms.Button()
        Me.FlagButton3 = New System.Windows.Forms.Button()
        Me.FlagButton4 = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        CType(Me.FlagViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlagViewer
        '
        Me.FlagViewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.FlagViewer.Location = New System.Drawing.Point(193, 12)
        Me.FlagViewer.Name = "FlagViewer"
        Me.FlagViewer.Size = New System.Drawing.Size(415, 268)
        Me.FlagViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FlagViewer.TabIndex = 0
        Me.FlagViewer.TabStop = False
        '
        'FlagButton1
        '
        Me.FlagButton1.Location = New System.Drawing.Point(42, 294)
        Me.FlagButton1.Name = "FlagButton1"
        Me.FlagButton1.Size = New System.Drawing.Size(145, 85)
        Me.FlagButton1.TabIndex = 1
        Me.FlagButton1.Text = "&Arkansas"
        Me.FlagButton1.UseVisualStyleBackColor = True
        '
        'FlagButton2
        '
        Me.FlagButton2.Location = New System.Drawing.Point(235, 294)
        Me.FlagButton2.Name = "FlagButton2"
        Me.FlagButton2.Size = New System.Drawing.Size(145, 85)
        Me.FlagButton2.TabIndex = 2
        Me.FlagButton2.Text = "&Colorado"
        Me.FlagButton2.UseVisualStyleBackColor = True
        '
        'FlagButton3
        '
        Me.FlagButton3.Location = New System.Drawing.Point(430, 294)
        Me.FlagButton3.Name = "FlagButton3"
        Me.FlagButton3.Size = New System.Drawing.Size(145, 85)
        Me.FlagButton3.TabIndex = 3
        Me.FlagButton3.Text = "&Montana"
        Me.FlagButton3.UseVisualStyleBackColor = True
        '
        'FlagButton4
        '
        Me.FlagButton4.Location = New System.Drawing.Point(631, 294)
        Me.FlagButton4.Name = "FlagButton4"
        Me.FlagButton4.Size = New System.Drawing.Size(145, 85)
        Me.FlagButton4.TabIndex = 4
        Me.FlagButton4.Text = "&Louisiana"
        Me.FlagButton4.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(92, 403)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(602, 35)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Flag_Viewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.FlagButton4)
        Me.Controls.Add(Me.FlagButton3)
        Me.Controls.Add(Me.FlagButton2)
        Me.Controls.Add(Me.FlagButton1)
        Me.Controls.Add(Me.FlagViewer)
        Me.Name = "Flag_Viewer"
        Me.Text = "Flags!"
        CType(Me.FlagViewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlagViewer As PictureBox
    Friend WithEvents FlagButton1 As Button
    Friend WithEvents FlagButton2 As Button
    Friend WithEvents FlagButton3 As Button
    Friend WithEvents FlagButton4 As Button
    Friend WithEvents ExitButton As Button
End Class
