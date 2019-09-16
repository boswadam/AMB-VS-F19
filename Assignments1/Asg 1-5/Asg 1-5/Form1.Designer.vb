<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menuApp))
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.soupButton = New System.Windows.Forms.Button()
        Me.chefButton = New System.Windows.Forms.Button()
        Me.fishButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.offeringLabel = New System.Windows.Forms.Label()
        Me.menuDisplay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.BackColor = System.Drawing.Color.Transparent
        Me.titleLabel.Font = New System.Drawing.Font("Modern No. 20", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.ForeColor = System.Drawing.Color.Crimson
        Me.titleLabel.Location = New System.Drawing.Point(123, 9)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(539, 65)
        Me.titleLabel.TabIndex = 0
        Me.titleLabel.Text = "Adam's Food Place"
        '
        'soupButton
        '
        Me.soupButton.BackColor = System.Drawing.Color.Transparent
        Me.soupButton.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.soupButton.Location = New System.Drawing.Point(134, 322)
        Me.soupButton.Name = "soupButton"
        Me.soupButton.Size = New System.Drawing.Size(109, 62)
        Me.soupButton.TabIndex = 1
        Me.soupButton.Text = "&Soup of the Day "
        Me.soupButton.UseVisualStyleBackColor = False
        '
        'chefButton
        '
        Me.chefButton.BackColor = System.Drawing.Color.Transparent
        Me.chefButton.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chefButton.Location = New System.Drawing.Point(335, 322)
        Me.chefButton.Name = "chefButton"
        Me.chefButton.Size = New System.Drawing.Size(109, 62)
        Me.chefButton.TabIndex = 2
        Me.chefButton.Tag = ""
        Me.chefButton.Text = "&Chef's Special"
        Me.chefButton.UseVisualStyleBackColor = False
        '
        'fishButton
        '
        Me.fishButton.BackColor = System.Drawing.Color.Transparent
        Me.fishButton.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fishButton.Location = New System.Drawing.Point(531, 322)
        Me.fishButton.Name = "fishButton"
        Me.fishButton.Size = New System.Drawing.Size(109, 62)
        Me.fishButton.TabIndex = 3
        Me.fishButton.Text = "&Daily Fish"
        Me.fishButton.UseVisualStyleBackColor = False
        '
        'exitButton
        '
        Me.exitButton.BackColor = System.Drawing.Color.Transparent
        Me.exitButton.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(679, 322)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(109, 62)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "&EXIT"
        Me.exitButton.UseVisualStyleBackColor = False
        '
        'offeringLabel
        '
        Me.offeringLabel.AutoSize = True
        Me.offeringLabel.BackColor = System.Drawing.Color.Transparent
        Me.offeringLabel.Font = New System.Drawing.Font("Modern No. 20", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.offeringLabel.Location = New System.Drawing.Point(69, 74)
        Me.offeringLabel.Name = "offeringLabel"
        Me.offeringLabel.Size = New System.Drawing.Size(204, 34)
        Me.offeringLabel.TabIndex = 5
        Me.offeringLabel.Text = "Now offering:"
        '
        'menuDisplay
        '
        Me.menuDisplay.AutoSize = True
        Me.menuDisplay.BackColor = System.Drawing.Color.Bisque
        Me.menuDisplay.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuDisplay.ForeColor = System.Drawing.Color.Firebrick
        Me.menuDisplay.Location = New System.Drawing.Point(98, 108)
        Me.menuDisplay.Name = "menuDisplay"
        Me.menuDisplay.Size = New System.Drawing.Size(0, 29)
        Me.menuDisplay.TabIndex = 6
        '
        'menuApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.menuDisplay)
        Me.Controls.Add(Me.offeringLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.fishButton)
        Me.Controls.Add(Me.chefButton)
        Me.Controls.Add(Me.soupButton)
        Me.Controls.Add(Me.titleLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "menuApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu App"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents titleLabel As Label
    Friend WithEvents soupButton As Button
    Friend WithEvents chefButton As Button
    Friend WithEvents fishButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents offeringLabel As Label
    Friend WithEvents menuDisplay As Label
End Class
