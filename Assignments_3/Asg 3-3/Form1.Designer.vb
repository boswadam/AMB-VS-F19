<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory_Calc
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BeginningTextBox = New System.Windows.Forms.TextBox()
        Me.EndingTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CostTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AverageTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TurnoverTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("TI-Nspire", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Beginning Inventory"
        '
        'BeginningTextBox
        '
        Me.BeginningTextBox.Font = New System.Drawing.Font("TI-Nspire", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeginningTextBox.Location = New System.Drawing.Point(21, 49)
        Me.BeginningTextBox.Name = "BeginningTextBox"
        Me.BeginningTextBox.Size = New System.Drawing.Size(202, 31)
        Me.BeginningTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.BeginningTextBox, "Enter your starting inventory data here")
        '
        'EndingTextBox
        '
        Me.EndingTextBox.Font = New System.Drawing.Font("TI-Nspire", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndingTextBox.Location = New System.Drawing.Point(21, 119)
        Me.EndingTextBox.Name = "EndingTextBox"
        Me.EndingTextBox.Size = New System.Drawing.Size(202, 31)
        Me.EndingTextBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.EndingTextBox, "Enter your final inventory data here")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("TI-Nspire", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ending Inventory"
        '
        'CostTextBox
        '
        Me.CostTextBox.Font = New System.Drawing.Font("TI-Nspire", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CostTextBox.Location = New System.Drawing.Point(21, 188)
        Me.CostTextBox.Name = "CostTextBox"
        Me.CostTextBox.Size = New System.Drawing.Size(202, 31)
        Me.CostTextBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.CostTextBox, "Enter the cost of your goods here in US dollars")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("TI-Nspire", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cost of Goods Sold"
        '
        'AverageTextBox
        '
        Me.AverageTextBox.Font = New System.Drawing.Font("TI-Nspire", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AverageTextBox.Location = New System.Drawing.Point(19, 46)
        Me.AverageTextBox.Name = "AverageTextBox"
        Me.AverageTextBox.ReadOnly = True
        Me.AverageTextBox.Size = New System.Drawing.Size(214, 31)
        Me.AverageTextBox.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.AverageTextBox, "Displays average inventory here in US Dollars")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("TI-Nspire", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Average Inventory"
        '
        'TurnoverTextBox
        '
        Me.TurnoverTextBox.Font = New System.Drawing.Font("TI-Nspire", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TurnoverTextBox.Location = New System.Drawing.Point(19, 116)
        Me.TurnoverTextBox.Name = "TurnoverTextBox"
        Me.TurnoverTextBox.ReadOnly = True
        Me.TurnoverTextBox.Size = New System.Drawing.Size(214, 31)
        Me.TurnoverTextBox.TabIndex = 92
        Me.ToolTip1.SetToolTip(Me.TurnoverTextBox, "Displays the turnover")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("TI-Nspire", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Turnover"
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(103, 299)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(244, 60)
        Me.CalculateButton.TabIndex = 4
        Me.CalculateButton.Text = "C&alculate"
        Me.ToolTip1.SetToolTip(Me.CalculateButton, "Clicking this will calculate your average inventory and turnover")
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(420, 299)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(256, 60)
        Me.ExitButton.TabIndex = 6
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Exits the program. Happy Trails!")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ClearButton.Location = New System.Drawing.Point(420, 233)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(256, 60)
        Me.ClearButton.TabIndex = 5
        Me.ClearButton.Text = "&Clear"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Clears Input and Output data")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.EndingTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BeginningTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CostTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(103, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(244, 235)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Input"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TurnoverTextBox)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.AverageTextBox)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(420, 58)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(256, 161)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Output Data"
        '
        'Inventory_Calc
        '
        Me.AcceptButton = Me.CalculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ClearButton
        Me.ClientSize = New System.Drawing.Size(789, 485)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Name = "Inventory_Calc"
        Me.Text = "Inventory Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BeginningTextBox As TextBox
    Friend WithEvents EndingTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CostTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents AverageTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TurnoverTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GroupBox2 As GroupBox
End Class
