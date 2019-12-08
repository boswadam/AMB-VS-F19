<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dice_Tracker
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.rollDiceButton = New System.Windows.Forms.Button()
        Me.listBoxViewer = New System.Windows.Forms.ListBox()
        Me.rollCountMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rollDiceButton
        '
        Me.rollDiceButton.AllowDrop = True
        Me.rollDiceButton.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rollDiceButton.Location = New System.Drawing.Point(119, 27)
        Me.rollDiceButton.Name = "rollDiceButton"
        Me.rollDiceButton.Size = New System.Drawing.Size(290, 70)
        Me.rollDiceButton.TabIndex = 0
        Me.rollDiceButton.Text = "Roll Dice"
        Me.rollDiceButton.UseVisualStyleBackColor = True
        '
        'listBoxViewer
        '
        Me.listBoxViewer.FormattingEnabled = True
        Me.listBoxViewer.Location = New System.Drawing.Point(119, 103)
        Me.listBoxViewer.Name = "listBoxViewer"
        Me.listBoxViewer.Size = New System.Drawing.Size(472, 290)
        Me.listBoxViewer.TabIndex = 1
        '
        'rollCountMaskedTextBox
        '
        Me.rollCountMaskedTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip
        Me.rollCountMaskedTextBox.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rollCountMaskedTextBox.Location = New System.Drawing.Point(451, 55)
        Me.rollCountMaskedTextBox.Mask = "0000000"
        Me.rollCountMaskedTextBox.Name = "rollCountMaskedTextBox"
        Me.rollCountMaskedTextBox.Size = New System.Drawing.Size(140, 33)
        Me.rollCountMaskedTextBox.TabIndex = 2
        Me.rollCountMaskedTextBox.Text = "0010000"
        Me.rollCountMaskedTextBox.ValidatingType = GetType(Integer)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(415, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "How many times?"
        '
        'clearButton
        '
        Me.clearButton.AutoEllipsis = True
        Me.clearButton.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.Location = New System.Drawing.Point(119, 399)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(226, 70)
        Me.clearButton.TabIndex = 4
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.AutoEllipsis = True
        Me.exitButton.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(351, 399)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(240, 70)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Dice_Tracker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 488)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rollCountMaskedTextBox)
        Me.Controls.Add(Me.listBoxViewer)
        Me.Controls.Add(Me.rollDiceButton)
        Me.Name = "Dice_Tracker"
        Me.Text = "Dice Tracker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rollDiceButton As Button
    Friend WithEvents listBoxViewer As ListBox
    Friend WithEvents rollCountMaskedTextBox As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents clearButton As Button
    Friend WithEvents exitButton As Button
End Class
