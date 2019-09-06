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
        Me.englishButton = New System.Windows.Forms.Button()
        Me.DaLabel = New System.Windows.Forms.Label()
        Me.FrenchButton = New System.Windows.Forms.Button()
        Me.DutchButton = New System.Windows.Forms.Button()
        Me.PortugueseButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'englishButton
        '
        Me.englishButton.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.englishButton.Location = New System.Drawing.Point(78, 141)
        Me.englishButton.Name = "englishButton"
        Me.englishButton.Size = New System.Drawing.Size(190, 94)
        Me.englishButton.TabIndex = 0
        Me.englishButton.Text = "&English"
        Me.englishButton.UseVisualStyleBackColor = False
        '
        'DaLabel
        '
        Me.DaLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DaLabel.Location = New System.Drawing.Point(115, 63)
        Me.DaLabel.Name = "DaLabel"
        Me.DaLabel.Size = New System.Drawing.Size(485, 60)
        Me.DaLabel.TabIndex = 1
        '
        'FrenchButton
        '
        Me.FrenchButton.Location = New System.Drawing.Point(78, 241)
        Me.FrenchButton.Name = "FrenchButton"
        Me.FrenchButton.Size = New System.Drawing.Size(190, 94)
        Me.FrenchButton.TabIndex = 2
        Me.FrenchButton.Text = "&French"
        Me.FrenchButton.UseVisualStyleBackColor = True
        '
        'DutchButton
        '
        Me.DutchButton.Location = New System.Drawing.Point(464, 141)
        Me.DutchButton.Name = "DutchButton"
        Me.DutchButton.Size = New System.Drawing.Size(184, 96)
        Me.DutchButton.TabIndex = 3
        Me.DutchButton.Text = "&Dutch"
        Me.DutchButton.UseVisualStyleBackColor = True
        '
        'PortugueseButton
        '
        Me.PortugueseButton.Location = New System.Drawing.Point(464, 243)
        Me.PortugueseButton.Name = "PortugueseButton"
        Me.PortugueseButton.Size = New System.Drawing.Size(184, 96)
        Me.PortugueseButton.TabIndex = 4
        Me.PortugueseButton.Text = "&Portuguese"
        Me.PortugueseButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(273, 342)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(184, 96)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "&Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PortugueseButton)
        Me.Controls.Add(Me.DutchButton)
        Me.Controls.Add(Me.FrenchButton)
        Me.Controls.Add(Me.DaLabel)
        Me.Controls.Add(Me.englishButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents englishButton As Button
    Friend WithEvents DaLabel As Label
    Friend WithEvents FrenchButton As Button
    Friend WithEvents DutchButton As Button
    Friend WithEvents PortugueseButton As Button
    Friend WithEvents ExitButton As Button
End Class
