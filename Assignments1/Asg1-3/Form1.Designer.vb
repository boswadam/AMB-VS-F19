<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Txbox = New System.Windows.Forms.Label()
        Me.Heading = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.My_Name = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("French Script MT", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(42, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 108)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Wisdom Please"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Txbox
        '
        Me.Txbox.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Txbox.Font = New System.Drawing.Font("French Script MT", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txbox.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Txbox.Location = New System.Drawing.Point(572, 90)
        Me.Txbox.MinimumSize = New System.Drawing.Size(160, 200)
        Me.Txbox.Name = "Txbox"
        Me.Txbox.Size = New System.Drawing.Size(216, 237)
        Me.Txbox.TabIndex = 1
        '
        'Heading
        '
        Me.Heading.AutoSize = True
        Me.Heading.Font = New System.Drawing.Font("French Script MT", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Heading.Location = New System.Drawing.Point(564, 35)
        Me.Heading.Name = "Heading"
        Me.Heading.Size = New System.Drawing.Size(180, 55)
        Me.Heading.TabIndex = 2
        Me.Heading.Text = "Sensei say,"
        '
        'exitButton
        '
        Me.exitButton.AutoSize = True
        Me.exitButton.Font = New System.Drawing.Font("French Script MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(12, 269)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(205, 105)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "Bye, Bye Sensei"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'My_Name
        '
        Me.My_Name.AutoSize = True
        Me.My_Name.Location = New System.Drawing.Point(715, 428)
        Me.My_Name.Name = "My_Name"
        Me.My_Name.Size = New System.Drawing.Size(73, 13)
        Me.My_Name.TabIndex = 4
        Me.My_Name.Text = "Adam Boswell"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlueViolet
        Me.BackgroundImage = Global.Asg1_3.My.Resources.Resources.sensei
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.My_Name)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.Heading)
        Me.Controls.Add(Me.Txbox)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Wisdom Generator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Txbox As Label
    Friend WithEvents Heading As Label
    Friend WithEvents exitButton As Button
    Friend WithEvents My_Name As Label
End Class
