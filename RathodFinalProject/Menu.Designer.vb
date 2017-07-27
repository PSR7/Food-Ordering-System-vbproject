<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
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
        Me.Button_SandWitch = New System.Windows.Forms.Button()
        Me.Button_Snacks = New System.Windows.Forms.Button()
        Me.Button_Salads = New System.Windows.Forms.Button()
        Me.ListBox_Items = New System.Windows.Forms.ListBox()
        Me.ListBox_Price = New System.Windows.Forms.ListBox()
        Me.Button_Total = New System.Windows.Forms.Button()
        Me.TextBox_Total = New System.Windows.Forms.TextBox()
        Me.Button_Remove = New System.Windows.Forms.Button()
        Me.Button_Cancle = New System.Windows.Forms.Button()
        Me.Button_CheckOut = New System.Windows.Forms.Button()
        Me.Button_Deserts = New System.Windows.Forms.Button()
        Me.Label_SandWitch = New System.Windows.Forms.Label()
        Me.Label_Salads = New System.Windows.Forms.Label()
        Me.Label_Snacks = New System.Windows.Forms.Label()
        Me.Label_Deserts = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_SandWitch
        '
        Me.Button_SandWitch.BackgroundImage = Global.RathodFinalProject.My.Resources.Resources.Sandwich1
        Me.Button_SandWitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_SandWitch.Location = New System.Drawing.Point(229, 28)
        Me.Button_SandWitch.Name = "Button_SandWitch"
        Me.Button_SandWitch.Size = New System.Drawing.Size(176, 178)
        Me.Button_SandWitch.TabIndex = 1
        Me.Button_SandWitch.UseVisualStyleBackColor = True
        '
        'Button_Snacks
        '
        Me.Button_Snacks.BackgroundImage = Global.RathodFinalProject.My.Resources.Resources.Snacks
        Me.Button_Snacks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Snacks.Location = New System.Drawing.Point(28, 261)
        Me.Button_Snacks.Name = "Button_Snacks"
        Me.Button_Snacks.Size = New System.Drawing.Size(176, 180)
        Me.Button_Snacks.TabIndex = 2
        Me.Button_Snacks.UseVisualStyleBackColor = True
        '
        'Button_Salads
        '
        Me.Button_Salads.BackgroundImage = Global.RathodFinalProject.My.Resources.Resources.Salad
        Me.Button_Salads.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Salads.Location = New System.Drawing.Point(28, 28)
        Me.Button_Salads.Name = "Button_Salads"
        Me.Button_Salads.Size = New System.Drawing.Size(176, 178)
        Me.Button_Salads.TabIndex = 3
        Me.Button_Salads.UseVisualStyleBackColor = True
        '
        'ListBox_Items
        '
        Me.ListBox_Items.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ListBox_Items.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox_Items.ForeColor = System.Drawing.Color.Black
        Me.ListBox_Items.FormattingEnabled = True
        Me.ListBox_Items.ItemHeight = 16
        Me.ListBox_Items.Location = New System.Drawing.Point(488, 57)
        Me.ListBox_Items.Name = "ListBox_Items"
        Me.ListBox_Items.Size = New System.Drawing.Size(159, 212)
        Me.ListBox_Items.TabIndex = 4
        '
        'ListBox_Price
        '
        Me.ListBox_Price.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ListBox_Price.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox_Price.ForeColor = System.Drawing.Color.Black
        Me.ListBox_Price.FormattingEnabled = True
        Me.ListBox_Price.ItemHeight = 16
        Me.ListBox_Price.Location = New System.Drawing.Point(701, 57)
        Me.ListBox_Price.Name = "ListBox_Price"
        Me.ListBox_Price.Size = New System.Drawing.Size(159, 212)
        Me.ListBox_Price.TabIndex = 5
        '
        'Button_Total
        '
        Me.Button_Total.BackColor = System.Drawing.Color.Maroon
        Me.Button_Total.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Total.ForeColor = System.Drawing.Color.White
        Me.Button_Total.Location = New System.Drawing.Point(518, 283)
        Me.Button_Total.Name = "Button_Total"
        Me.Button_Total.Size = New System.Drawing.Size(105, 31)
        Me.Button_Total.TabIndex = 6
        Me.Button_Total.Text = "Total"
        Me.Button_Total.UseVisualStyleBackColor = False
        '
        'TextBox_Total
        '
        Me.TextBox_Total.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox_Total.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Total.ForeColor = System.Drawing.Color.Black
        Me.TextBox_Total.Location = New System.Drawing.Point(716, 286)
        Me.TextBox_Total.Name = "TextBox_Total"
        Me.TextBox_Total.Size = New System.Drawing.Size(122, 23)
        Me.TextBox_Total.TabIndex = 7
        '
        'Button_Remove
        '
        Me.Button_Remove.BackColor = System.Drawing.Color.Maroon
        Me.Button_Remove.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Remove.ForeColor = System.Drawing.Color.White
        Me.Button_Remove.Location = New System.Drawing.Point(502, 354)
        Me.Button_Remove.Name = "Button_Remove"
        Me.Button_Remove.Size = New System.Drawing.Size(145, 50)
        Me.Button_Remove.TabIndex = 8
        Me.Button_Remove.Text = "Remove Items"
        Me.Button_Remove.UseVisualStyleBackColor = False
        '
        'Button_Cancle
        '
        Me.Button_Cancle.BackColor = System.Drawing.Color.Maroon
        Me.Button_Cancle.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button_Cancle.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Cancle.ForeColor = System.Drawing.Color.White
        Me.Button_Cancle.Location = New System.Drawing.Point(701, 354)
        Me.Button_Cancle.Name = "Button_Cancle"
        Me.Button_Cancle.Size = New System.Drawing.Size(158, 50)
        Me.Button_Cancle.TabIndex = 9
        Me.Button_Cancle.Text = "Cancle Order"
        Me.Button_Cancle.UseVisualStyleBackColor = False
        '
        'Button_CheckOut
        '
        Me.Button_CheckOut.BackColor = System.Drawing.Color.Maroon
        Me.Button_CheckOut.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_CheckOut.ForeColor = System.Drawing.Color.White
        Me.Button_CheckOut.Location = New System.Drawing.Point(608, 426)
        Me.Button_CheckOut.Name = "Button_CheckOut"
        Me.Button_CheckOut.Size = New System.Drawing.Size(141, 56)
        Me.Button_CheckOut.TabIndex = 10
        Me.Button_CheckOut.Text = "Check Out"
        Me.Button_CheckOut.UseVisualStyleBackColor = False
        '
        'Button_Deserts
        '
        Me.Button_Deserts.BackgroundImage = Global.RathodFinalProject.My.Resources.Resources.Desert
        Me.Button_Deserts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Deserts.Location = New System.Drawing.Point(229, 261)
        Me.Button_Deserts.Name = "Button_Deserts"
        Me.Button_Deserts.Size = New System.Drawing.Size(176, 178)
        Me.Button_Deserts.TabIndex = 11
        Me.Button_Deserts.UseVisualStyleBackColor = True
        '
        'Label_SandWitch
        '
        Me.Label_SandWitch.AutoSize = True
        Me.Label_SandWitch.BackColor = System.Drawing.Color.Transparent
        Me.Label_SandWitch.Font = New System.Drawing.Font("Tahoma", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_SandWitch.Location = New System.Drawing.Point(244, 209)
        Me.Label_SandWitch.Name = "Label_SandWitch"
        Me.Label_SandWitch.Size = New System.Drawing.Size(167, 50)
        Me.Label_SandWitch.TabIndex = 12
        Me.Label_SandWitch.Text = "Sandwitches &&" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     Burgers"
        '
        'Label_Salads
        '
        Me.Label_Salads.AutoSize = True
        Me.Label_Salads.BackColor = System.Drawing.Color.Transparent
        Me.Label_Salads.Font = New System.Drawing.Font("Tahoma", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Salads.Location = New System.Drawing.Point(70, 217)
        Me.Label_Salads.Name = "Label_Salads"
        Me.Label_Salads.Size = New System.Drawing.Size(81, 25)
        Me.Label_Salads.TabIndex = 13
        Me.Label_Salads.Text = "Salads"
        '
        'Label_Snacks
        '
        Me.Label_Snacks.AutoSize = True
        Me.Label_Snacks.BackColor = System.Drawing.Color.Transparent
        Me.Label_Snacks.Font = New System.Drawing.Font("Tahoma", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Snacks.Location = New System.Drawing.Point(47, 450)
        Me.Label_Snacks.Name = "Label_Snacks"
        Me.Label_Snacks.Size = New System.Drawing.Size(120, 50)
        Me.Label_Snacks.TabIndex = 14
        Me.Label_Snacks.Text = "Snacks &&" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Beverages"
        '
        'Label_Deserts
        '
        Me.Label_Deserts.AutoSize = True
        Me.Label_Deserts.BackColor = System.Drawing.Color.Transparent
        Me.Label_Deserts.Font = New System.Drawing.Font("Tahoma", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Deserts.Location = New System.Drawing.Point(259, 442)
        Me.Label_Deserts.Name = "Label_Deserts"
        Me.Label_Deserts.Size = New System.Drawing.Size(114, 50)
        Me.Label_Deserts.TabIndex = 15
        Me.Label_Deserts.Text = "Deserts &&" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Shakes"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(514, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 19)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Items Added"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(740, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 19)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Price"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(871, 24)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'MenuForm
        '
        Me.AcceptButton = Me.Button_Total
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.RathodFinalProject.My.Resources.Resources.Splash_Screen
        Me.CancelButton = Me.Button_Cancle
        Me.ClientSize = New System.Drawing.Size(871, 506)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label_Deserts)
        Me.Controls.Add(Me.Label_Snacks)
        Me.Controls.Add(Me.Label_Salads)
        Me.Controls.Add(Me.Label_SandWitch)
        Me.Controls.Add(Me.Button_Deserts)
        Me.Controls.Add(Me.Button_CheckOut)
        Me.Controls.Add(Me.Button_Cancle)
        Me.Controls.Add(Me.Button_Remove)
        Me.Controls.Add(Me.TextBox_Total)
        Me.Controls.Add(Me.Button_Total)
        Me.Controls.Add(Me.ListBox_Price)
        Me.Controls.Add(Me.ListBox_Items)
        Me.Controls.Add(Me.Button_Salads)
        Me.Controls.Add(Me.Button_Snacks)
        Me.Controls.Add(Me.Button_SandWitch)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuForm"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_SandWitch As Button
    Friend WithEvents Button_Snacks As Button
    Friend WithEvents Button_Salads As Button
    Friend WithEvents ListBox_Items As ListBox
    Friend WithEvents ListBox_Price As ListBox
    Friend WithEvents Button_Total As Button
    Friend WithEvents TextBox_Total As TextBox
    Friend WithEvents Button_Remove As Button
    Friend WithEvents Button_Cancle As Button
    Friend WithEvents Button_CheckOut As Button
    Friend WithEvents Button_Deserts As Button
    Friend WithEvents Label_SandWitch As Label
    Friend WithEvents Label_Salads As Label
    Friend WithEvents Label_Snacks As Label
    Friend WithEvents Label_Deserts As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
