<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaladsForm
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
        Me.Label_Salad = New System.Windows.Forms.Label()
        Me.Button_Side = New System.Windows.Forms.Button()
        Me.Button_Butter = New System.Windows.Forms.Button()
        Me.Button_Grilled = New System.Windows.Forms.Button()
        Me.Button_Ranch = New System.Windows.Forms.Button()
        Me.Button_Continue = New System.Windows.Forms.Button()
        Me.Button_Go = New System.Windows.Forms.Button()
        Me.Button_Cancel = New System.Windows.Forms.Button()
        Me.Label_Butter = New System.Windows.Forms.Label()
        Me.Label_Ranch = New System.Windows.Forms.Label()
        Me.Label_Side = New System.Windows.Forms.Label()
        Me.Label_Grilled = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label_Salad
        '
        Me.Label_Salad.AutoSize = True
        Me.Label_Salad.BackColor = System.Drawing.Color.Transparent
        Me.Label_Salad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label_Salad.Font = New System.Drawing.Font("Tahoma", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Salad.ForeColor = System.Drawing.Color.Black
        Me.Label_Salad.Location = New System.Drawing.Point(306, -5)
        Me.Label_Salad.Name = "Label_Salad"
        Me.Label_Salad.Size = New System.Drawing.Size(242, 77)
        Me.Label_Salad.TabIndex = 0
        Me.Label_Salad.Text = "Salads"
        '
        'Button_Side
        '
        Me.Button_Side.BackgroundImage = Global.RathodFinalProject.My.Resources.Resources.SideSalad
        Me.Button_Side.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Side.Location = New System.Drawing.Point(38, 78)
        Me.Button_Side.Name = "Button_Side"
        Me.Button_Side.Size = New System.Drawing.Size(203, 180)
        Me.Button_Side.TabIndex = 1
        Me.Button_Side.UseVisualStyleBackColor = True
        '
        'Button_Butter
        '
        Me.Button_Butter.BackgroundImage = Global.RathodFinalProject.My.Resources.Resources.ButterChicken_Salad
        Me.Button_Butter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Butter.Location = New System.Drawing.Point(336, 78)
        Me.Button_Butter.Name = "Button_Butter"
        Me.Button_Butter.Size = New System.Drawing.Size(203, 180)
        Me.Button_Butter.TabIndex = 2
        Me.Button_Butter.UseVisualStyleBackColor = True
        '
        'Button_Grilled
        '
        Me.Button_Grilled.BackgroundImage = Global.RathodFinalProject.My.Resources.Resources.GrilledChicken_Salad
        Me.Button_Grilled.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Grilled.Location = New System.Drawing.Point(38, 303)
        Me.Button_Grilled.Name = "Button_Grilled"
        Me.Button_Grilled.Size = New System.Drawing.Size(203, 180)
        Me.Button_Grilled.TabIndex = 3
        Me.Button_Grilled.UseVisualStyleBackColor = True
        '
        'Button_Ranch
        '
        Me.Button_Ranch.BackgroundImage = Global.RathodFinalProject.My.Resources.Resources.RanchSalad
        Me.Button_Ranch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Ranch.Location = New System.Drawing.Point(336, 303)
        Me.Button_Ranch.Name = "Button_Ranch"
        Me.Button_Ranch.Size = New System.Drawing.Size(203, 180)
        Me.Button_Ranch.TabIndex = 4
        Me.Button_Ranch.UseVisualStyleBackColor = True
        '
        'Button_Continue
        '
        Me.Button_Continue.BackColor = System.Drawing.Color.Maroon
        Me.Button_Continue.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Continue.ForeColor = System.Drawing.Color.White
        Me.Button_Continue.Location = New System.Drawing.Point(616, 163)
        Me.Button_Continue.Name = "Button_Continue"
        Me.Button_Continue.Size = New System.Drawing.Size(203, 49)
        Me.Button_Continue.TabIndex = 5
        Me.Button_Continue.Text = "Continue"
        Me.Button_Continue.UseVisualStyleBackColor = False
        '
        'Button_Go
        '
        Me.Button_Go.BackColor = System.Drawing.Color.Maroon
        Me.Button_Go.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Go.ForeColor = System.Drawing.Color.White
        Me.Button_Go.Location = New System.Drawing.Point(616, 258)
        Me.Button_Go.Name = "Button_Go"
        Me.Button_Go.Size = New System.Drawing.Size(203, 49)
        Me.Button_Go.TabIndex = 6
        Me.Button_Go.Text = "Go Back"
        Me.Button_Go.UseVisualStyleBackColor = False
        '
        'Button_Cancel
        '
        Me.Button_Cancel.BackColor = System.Drawing.Color.Maroon
        Me.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button_Cancel.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Cancel.ForeColor = System.Drawing.Color.White
        Me.Button_Cancel.Location = New System.Drawing.Point(616, 351)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(203, 49)
        Me.Button_Cancel.TabIndex = 7
        Me.Button_Cancel.Text = "Cancel Order"
        Me.Button_Cancel.UseVisualStyleBackColor = False
        '
        'Label_Butter
        '
        Me.Label_Butter.AutoSize = True
        Me.Label_Butter.BackColor = System.Drawing.Color.Transparent
        Me.Label_Butter.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Butter.Location = New System.Drawing.Point(348, 267)
        Me.Label_Butter.Name = "Label_Butter"
        Me.Label_Butter.Size = New System.Drawing.Size(180, 19)
        Me.Label_Butter.TabIndex = 8
        Me.Label_Butter.Text = "Butter Chicken Salad"
        '
        'Label_Ranch
        '
        Me.Label_Ranch.AutoSize = True
        Me.Label_Ranch.BackColor = System.Drawing.Color.Transparent
        Me.Label_Ranch.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Ranch.Location = New System.Drawing.Point(387, 486)
        Me.Label_Ranch.Name = "Label_Ranch"
        Me.Label_Ranch.Size = New System.Drawing.Size(109, 19)
        Me.Label_Ranch.TabIndex = 9
        Me.Label_Ranch.Text = "Ranch Salad"
        '
        'Label_Side
        '
        Me.Label_Side.AutoSize = True
        Me.Label_Side.BackColor = System.Drawing.Color.Transparent
        Me.Label_Side.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Side.Location = New System.Drawing.Point(72, 271)
        Me.Label_Side.Name = "Label_Side"
        Me.Label_Side.Size = New System.Drawing.Size(94, 19)
        Me.Label_Side.TabIndex = 10
        Me.Label_Side.Text = "Side Salad"
        '
        'Label_Grilled
        '
        Me.Label_Grilled.AutoSize = True
        Me.Label_Grilled.BackColor = System.Drawing.Color.Transparent
        Me.Label_Grilled.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Grilled.Location = New System.Drawing.Point(72, 486)
        Me.Label_Grilled.Name = "Label_Grilled"
        Me.Label_Grilled.Size = New System.Drawing.Size(182, 19)
        Me.Label_Grilled.TabIndex = 11
        Me.Label_Grilled.Text = "Grilled Chicken Salad"
        '
        'SaladsForm
        '
        Me.AcceptButton = Me.Button_Continue
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.RathodFinalProject.My.Resources.Resources.Splash_Screen
        Me.CancelButton = Me.Button_Cancel
        Me.ClientSize = New System.Drawing.Size(871, 506)
        Me.Controls.Add(Me.Label_Grilled)
        Me.Controls.Add(Me.Label_Side)
        Me.Controls.Add(Me.Label_Ranch)
        Me.Controls.Add(Me.Label_Butter)
        Me.Controls.Add(Me.Button_Cancel)
        Me.Controls.Add(Me.Button_Go)
        Me.Controls.Add(Me.Button_Continue)
        Me.Controls.Add(Me.Button_Ranch)
        Me.Controls.Add(Me.Button_Grilled)
        Me.Controls.Add(Me.Button_Butter)
        Me.Controls.Add(Me.Button_Side)
        Me.Controls.Add(Me.Label_Salad)
        Me.Name = "SaladsForm"
        Me.Text = "SaladsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_Salad As Label
    Friend WithEvents Button_Side As Button
    Friend WithEvents Button_Butter As Button
    Friend WithEvents Button_Grilled As Button
    Friend WithEvents Button_Ranch As Button
    Friend WithEvents Button_Continue As Button
    Friend WithEvents Button_Go As Button
    Friend WithEvents Button_Cancel As Button
    Friend WithEvents Label_Butter As Label
    Friend WithEvents Label_Ranch As Label
    Friend WithEvents Label_Side As Label
    Friend WithEvents Label_Grilled As Label
End Class
