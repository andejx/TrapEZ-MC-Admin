<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBoxconfig = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CheckBoxjar = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Set Build Number :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(50, 100)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 47)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Generate Server Build"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBoxconfig
        '
        Me.CheckBoxconfig.AutoSize = True
        Me.CheckBoxconfig.Location = New System.Drawing.Point(50, 77)
        Me.CheckBoxconfig.Name = "CheckBoxconfig"
        Me.CheckBoxconfig.Size = New System.Drawing.Size(142, 17)
        Me.CheckBoxconfig.TabIndex = 1
        Me.CheckBoxconfig.Text = "Have Configs Changed?"
        Me.CheckBoxconfig.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(148, 28)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(97, 20)
        Me.TextBox1.TabIndex = 3
        '
        'CheckBoxjar
        '
        Me.CheckBoxjar.AutoSize = True
        Me.CheckBoxjar.Location = New System.Drawing.Point(50, 54)
        Me.CheckBoxjar.Name = "CheckBoxjar"
        Me.CheckBoxjar.Size = New System.Drawing.Size(112, 17)
        Me.CheckBoxjar.TabIndex = 0
        Me.CheckBoxjar.Text = "Has Jar Updated?"
        Me.CheckBoxjar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(50, 153)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(164, 47)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Generate Server ModLists"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBoxjar)
        Me.Controls.Add(Me.CheckBoxconfig)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "admin"
        Me.Text = "TrapEZ-MC-Admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CheckBoxconfig As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxjar As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
