<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SandWitchForm
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
        Me.Label_Double = New System.Windows.Forms.Label()
        Me.Label_Big = New System.Windows.Forms.Label()
        Me.Label_Mc = New System.Windows.Forms.Label()
        Me.Label_Quater = New System.Windows.Forms.Label()
        Me.Button_Cancel = New System.Windows.Forms.Button()
        Me.Button_Go = New System.Windows.Forms.Button()
        Me.Button_Continue = New System.Windows.Forms.Button()
        Me.Button_Mc = New System.Windows.Forms.Button()
        Me.Button_Double = New System.Windows.Forms.Button()
        Me.Button_Quater = New System.Windows.Forms.Button()
        Me.Button_Big = New System.Windows.Forms.Button()
        Me.Label_Sandwitch = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label_Double
        '
        Me.Label_Double.AutoSize = True
        Me.Label_Double.BackColor = System.Drawing.Color.Transparent
        Me.Label_Double.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Double.Location = New System.Drawing.Point(54, 478)
        Me.Label_Double.Name = "Label_Double"
        Me.Label_Double.Size = New System.Drawing.Size(203, 19)
        Me.Label_Double.TabIndex = 23
        Me.Label_Double.Text = "Double Cheese Pounder"
        '
        'Label_Big
        '
        Me.Label_Big.AutoSize = True
        Me.Label_Big.BackColor = System.Drawing.Color.Transparent
        Me.Label_Big.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Big.Location = New System.Drawing.Point(79, 264)
        Me.Label_Big.Name = "Label_Big"
        Me.Label_Big.Size = New System.Drawing.Size(72, 19)
        Me.Label_Big.TabIndex = 22
        Me.Label_Big.Text = "Big Mac"
        '
        'Label_Mc
        '
        Me.Label_Mc.AutoSize = True
        Me.Label_Mc.BackColor = System.Drawing.Color.Transparent
        Me.Label_Mc.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Mc.Location = New System.Drawing.Point(396, 478)
        Me.Label_Mc.Name = "Label_Mc"
        Me.Label_Mc.Size = New System.Drawing.Size(100, 19)
        Me.Label_Mc.TabIndex = 21
        Me.Label_Mc.Text = "Mc Chicken"
        '
        'Label_Quater
        '
        Me.Label_Quater.AutoSize = True
        Me.Label_Quater.BackColor = System.Drawing.Color.Transparent
        Me.Label_Quater.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Quater.Location = New System.Drawing.Point(344, 264)
        Me.Label_Quater.Name = "Label_Quater"
        Me.Label_Quater.Size = New System.Drawing.Size(202, 19)
        Me.Label_Quater.TabIndex = 20
        Me.Label_Quater.Text = "Quater Cheese Pounder"
        '
        'Button_Cancel
        '
        Me.Button_Cancel.BackColor = System.Drawing.Color.Maroon
        Me.Button_Cancel.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Cancel.ForeColor = System.Drawing.Color.White
        Me.Button_Cancel.Location = New System.Drawing.Point(623, 354)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(203, 49)
        Me.Button_Cancel.TabIndex = 19
        Me.Button_Cancel.Text = "Cancel Order"
        Me.Button_Cancel.UseVisualStyleBackColor = False
        '
        'Button_Go
        '
        Me.Button_Go.BackColor = System.Drawing.Color.Maroon
        Me.Button_Go.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Go.ForeColor = System.Drawing.Color.White
        Me.Button_Go.Location = New System.Drawing.Point(623, 261)
        Me.Button_Go.Name = "Button_Go"
        Me.Button_Go.Size = New System.Drawing.Size(203, 49)
        Me.Button_Go.TabIndex = 18
        Me.Button_Go.Text = "Go Back"
        Me.Button_Go.UseVisualStyleBackColor = False
        '
        'Button_Continue
        '
        Me.Button_Continue.BackColor = System.Drawing.Color.Maroon
        Me.Button_Continue.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Continue.ForeColor = System.Drawing.Color.White
        Me.Button_Continue.Location = New System.Drawing.Point(623, 166)
        Me.Button_Continue.Name = "Button_Continue"
        Me.Button_Continue.Size = New System.Drawing.Size(203, 49)
        Me.Button_Continue.TabIndex = 17
        Me.Button_Continue.Text = "Continue"
        Me.Button_Continue.UseVisualStyleBackColor = False
        '
        'Button_Mc
        '
        Me.Button_Mc.BackgroundImage = Global.RathodFinalProject.My.Resources.Resources.Mc_Chiken
        Me.Button_Mc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Mc.Location = New System.Drawing.Point(343, 286)
        Me.Button_Mc.Name = "Button_Mc"
        Me.Button_Mc.Size = New System.Drawing.Size(203, 180)
        Me.Button_Mc.TabIndex = 16
        Me.Button_Mc.UseVisualStyleBackColor = True
        '
        'Button_Double
        '
        Me.Button_Double.BackgroundImage = Global.RathodFinalProject.My.Resources.Resources.Double_Quarter_pounder
        Me.Button_Double.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Double.Location = New System.Drawing.Point(45, 286)
        Me.Button_Double.Name = "Button_Double"
        Me.Button_Double.Size = New System.Drawing.Size(203, 180)
        Me.Button_Double.TabIndex = 15
        Me.Button_Double.UseVisualStyleBackColor = True
        '
        'Button_Quater
        '
        Me.Button_Quater.BackgroundImage = Global.RathodFinalProject.My.Resources.Resources.Quater_Pounder
        Me.Button_Quater.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Quater.Location = New System.Drawing.Point(343, 81)
        Me.Button_Quater.Name = "Button_Quater"
        Me.Button_Quater.Size = New System.Drawing.Size(203, 180)
        Me.Button_Quater.TabIndex = 14
        Me.Button_Quater.UseVisualStyleBackColor = True
        '
        'Button_Big
        '
        Me.Button_Big.BackgroundImage = Global.RathodFinalProject.My.Resources.Resources.Big_MAc
        Me.Button_Big.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Big.Location = New System.Drawing.Point(45, 81)
        Me.Button_Big.Name = "Button_Big"
        Me.Button_Big.Size = New System.Drawing.Size(203, 180)
        Me.Button_Big.TabIndex = 13
        Me.Button_Big.UseVisualStyleBackColor = True
        '
        'Label_Sandwitch
        '
        Me.Label_Sandwitch.AutoSize = True
        Me.Label_Sandwitch.BackColor = System.Drawing.Color.Transparent
        Me.Label_Sandwitch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label_Sandwitch.Font = New System.Drawing.Font("Tahoma", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Sandwitch.ForeColor = System.Drawing.Color.Black
        Me.Label_Sandwitch.Location = New System.Drawing.Point(25, 1)
        Me.Label_Sandwitch.Name = "Label_Sandwitch"
        Me.Label_Sandwitch.Size = New System.Drawing.Size(801, 77)
        Me.Label_Sandwitch.TabIndex = 12
        Me.Label_Sandwitch.Text = "Sandwitches &&  Burgers"
        '
        'SandWitchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.RathodFinalProject.My.Resources.Resources.Splash_Screen
        Me.ClientSize = New System.Drawing.Size(871, 506)
        Me.Controls.Add(Me.Label_Double)
        Me.Controls.Add(Me.Label_Big)
        Me.Controls.Add(Me.Label_Mc)
        Me.Controls.Add(Me.Label_Quater)
        Me.Controls.Add(Me.Button_Cancel)
        Me.Controls.Add(Me.Button_Go)
        Me.Controls.Add(Me.Button_Continue)
        Me.Controls.Add(Me.Button_Mc)
        Me.Controls.Add(Me.Button_Double)
        Me.Controls.Add(Me.Button_Quater)
        Me.Controls.Add(Me.Button_Big)
        Me.Controls.Add(Me.Label_Sandwitch)
        Me.Name = "SandWitchForm"
        Me.Text = "SandWitchForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_Double As Label
    Friend WithEvents Label_Big As Label
    Friend WithEvents Label_Mc As Label
    Friend WithEvents Label_Quater As Label
    Friend WithEvents Button_Cancel As Button
    Friend WithEvents Button_Go As Button
    Friend WithEvents Button_Continue As Button
    Friend WithEvents Button_Mc As Button
    Friend WithEvents Button_Double As Button
    Friend WithEvents Button_Quater As Button
    Friend WithEvents Button_Big As Button
    Friend WithEvents Label_Sandwitch As Label
End Class
