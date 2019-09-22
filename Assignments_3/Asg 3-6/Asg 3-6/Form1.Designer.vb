<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class shippingCalc
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
        Me.InputGroupBox = New System.Windows.Forms.GroupBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ozTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CostGroupBox = New System.Windows.Forms.GroupBox()
        Me.costTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.InputGroupBox.SuspendLayout()
        Me.CostGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "6 Digit ID Code"
        '
        'InputGroupBox
        '
        Me.InputGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.InputGroupBox.Controls.Add(Me.MaskedTextBox1)
        Me.InputGroupBox.Controls.Add(Me.Label5)
        Me.InputGroupBox.Controls.Add(Me.ozTextBox)
        Me.InputGroupBox.Controls.Add(Me.Label3)
        Me.InputGroupBox.Controls.Add(Me.lbTextBox)
        Me.InputGroupBox.Controls.Add(Me.Label2)
        Me.InputGroupBox.Controls.Add(Me.Label1)
        Me.InputGroupBox.Location = New System.Drawing.Point(41, 39)
        Me.InputGroupBox.Name = "InputGroupBox"
        Me.InputGroupBox.Size = New System.Drawing.Size(380, 313)
        Me.InputGroupBox.TabIndex = 2
        Me.InputGroupBox.TabStop = False
        Me.InputGroupBox.Text = "Package Data"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(32, 80)
        Me.MaskedTextBox1.Mask = "000000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(55, 30)
        Me.MaskedTextBox1.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.MaskedTextBox1, "Enter your 6 digit ID code here")
        Me.MaskedTextBox1.ValidatingType = GetType(Integer)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(216, 32)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Package Shipping Weight"
        '
        'ozTextBox
        '
        Me.ozTextBox.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ozTextBox.Location = New System.Drawing.Point(208, 246)
        Me.ozTextBox.Name = "ozTextBox"
        Me.ozTextBox.Size = New System.Drawing.Size(100, 30)
        Me.ozTextBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.ozTextBox, "How many ounces does your package weigh? Enter That value here as a number")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(313, 252)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "oz"
        '
        'lbTextBox
        '
        Me.lbTextBox.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTextBox.Location = New System.Drawing.Point(23, 246)
        Me.lbTextBox.Name = "lbTextBox"
        Me.lbTextBox.Size = New System.Drawing.Size(100, 30)
        Me.lbTextBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.lbTextBox, "How many pounds is your package? Enter that value here as a number")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(129, 252)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "lbs"
        '
        'CostGroupBox
        '
        Me.CostGroupBox.Controls.Add(Me.costTextBox)
        Me.CostGroupBox.Controls.Add(Me.Label4)
        Me.CostGroupBox.Location = New System.Drawing.Point(452, 162)
        Me.CostGroupBox.Name = "CostGroupBox"
        Me.CostGroupBox.Size = New System.Drawing.Size(298, 153)
        Me.CostGroupBox.TabIndex = 3
        Me.CostGroupBox.TabStop = False
        '
        'costTextBox
        '
        Me.costTextBox.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.costTextBox.Location = New System.Drawing.Point(19, 113)
        Me.costTextBox.Name = "costTextBox"
        Me.costTextBox.Size = New System.Drawing.Size(100, 30)
        Me.costTextBox.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.costTextBox, "Displays the shipping cost in US dollars")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Shipping Cost"
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(41, 358)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(380, 80)
        Me.CalculateButton.TabIndex = 4
        Me.CalculateButton.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.CalculateButton, "Calculates the shipping cost at a rate of 12 cents an ounce ")
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.clearButton.Location = New System.Drawing.Point(452, 321)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(145, 117)
        Me.clearButton.TabIndex = 5
        Me.clearButton.Text = "&Clear"
        Me.ToolTip1.SetToolTip(Me.clearButton, "Clears the shipping and input data ")
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(605, 321)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(145, 117)
        Me.exitButton.TabIndex = 6
        Me.exitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.exitButton, "Exits the program")
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'shippingCalc
        '
        Me.AcceptButton = Me.CalculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.clearButton
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.CostGroupBox)
        Me.Controls.Add(Me.InputGroupBox)
        Me.Name = "shippingCalc"
        Me.Text = "Shipping Cost Calculator"
        Me.InputGroupBox.ResumeLayout(False)
        Me.InputGroupBox.PerformLayout()
        Me.CostGroupBox.ResumeLayout(False)
        Me.CostGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents InputGroupBox As GroupBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ozTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CostGroupBox As GroupBox
    Friend WithEvents costTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CalculateButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
