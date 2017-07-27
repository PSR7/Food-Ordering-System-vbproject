'Purpose: This form is for the main menu where user can select the category calculate the total for the selected items and check out.
Public Class MenuForm
    ' Local varaibles are intialized here
    Dim CalcTotal As Integer
    Dim Total As Integer
    Dim RNumber As Integer
    Dim RObject As New Random()


    Private Sub Button_Salads_Click(sender As Object, e As EventArgs) Handles Button_Salads.Click
        ' Sets the Salads form visible as soon as the user clicks on the Salad button
        Dim SaladsForm As New SaladsForm(Me.ListBox_Items, Me.ListBox_Price)
        SaladsForm.Visible = True
        Me.Hide()
    End Sub

    Private Sub Button_SandWitch_Click(sender As Object, e As EventArgs) Handles Button_SandWitch.Click
        ' Sets the Sandwith form visible as soon as the user clicks on the Sandwitch button
        Dim SandWitchForm As New SandWitchForm(Me.ListBox_Items, Me.ListBox_Price)
        SandWitchForm.Visible = True
        Me.Hide()
    End Sub

    Private Sub Button_Snacks_Click(sender As Object, e As EventArgs) Handles Button_Snacks.Click
        ' Sets the Snacks form visible as soon as the user clicks on the Snacks button
        Dim SnacksForm As New SnacksForm(Me.ListBox_Items, Me.ListBox_Price)
        SnacksForm.Visible = True
        Me.Hide()
    End Sub

    Private Sub Button_Deserts_Click(sender As Object, e As EventArgs) Handles Button_Deserts.Click
        ' Sets the deserts form visible as soon as the user clicks on the Deserts button
        Dim DesertsForm As New DesertsForm(Me.ListBox_Items, Me.ListBox_Price)
        DesertsForm.Visible = True
        Me.Hide()

    End Sub

    Private Sub Button_Total_Click(sender As Object, e As EventArgs) Handles Button_Total.Click

        'The selected items total cost is calculated
        'If there is no items entred then the following error message is displayed
        If ListBox_Items.Items.Count = 0 Then
            MsgBox("No Items Selected")
            TextBox_Total.Clear()
        Else
            'If the items are entered the total cost is calculated
            For Each Str As Integer In ListBox_Price.Items
                Total = Total + CInt(Str)
            Next
            TextBox_Total.Text = "$" & Total
            CalcTotal = Total
            Total = 0
        End If
    End Sub

    Private Sub Button_Remove_Click(sender As Object, e As EventArgs) Handles Button_Remove.Click
        ' The Removal of the previous items selected can be removed using the following code
        If ListBox_Items.Items.Count = 0 Then ' here if no items selected this error message is shown
            MsgBox("No Items selected")
            TextBox_Total.Clear()
        Else
            'If Items selected then the previous item selected will be removed

            ListBox_Items.Items.RemoveAt(ListBox_Items.Items.Count - 1)
            ListBox_Price.Items.RemoveAt(ListBox_Price.Items.Count - 1)
            TextBox_Total.Clear()
        End If
    End Sub

    Private Sub Button_Cancle_Click(sender As Object, e As EventArgs) Handles Button_Cancle.Click
        'This initalization is used to cancle the order and place an new order
        ListBox_Items.Items.Clear()
        ListBox_Price.Items.Clear()
        TextBox_Total.Clear()
        RathodFinalProject.Visible = True
        Me.Hide()
    End Sub

    Private Sub Button_CheckOut_Click(sender As Object, e As EventArgs) Handles Button_CheckOut.Click
        'Here the final task check out will be done here

        'If no items are selected and the users click then an error message is appread
        If ListBox_Items.Items.Count = 0 Then
            MsgBox("Place  your  Order !")
            Me.Hide()
            RathodFinalProject.Visible = True
        ElseIf (TextBox_Total.Text = "") Then
            MsgBox("Caluculate Total")
        Else
            ' If the values are entered then the total calculated value will be displayed with the order number and a message of Order recieved and Pay the amount to the cashier
            RNumber = RObject.Next(1, 5)
            MsgBox("Order Number is :" & RNumber & vbNewLine & vbNewLine & "Total Amount is :" & "$" & CalcTotal & vbNewLine & vbNewLine & "Sucessfully Order Received " & vbNewLine & vbNewLine & "Pay Cash to Cashier ")
            Me.Hide()
            ListBox_Price.Items.Clear()
            ListBox_Items.Items.Clear()
            TextBox_Total.Clear()
            RathodFinalProject.Visible = True
        End If
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        'This Event helps to go to the home page that is order now page.
        Dim Home As New RathodFinalProject
        Hide()
        Home.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'This event closes the application
        Application.Exit()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        'This event pops out the message box helping out to place an order
        MsgBox("Select an appropriate Category you want to eat by clicking on the Category that is if you want to select Salad click on the salad or if you want to eat snacks click on snacks after clicking on the particular category then select the items which you want to eat and then press continue after this you can even add other category and then calculate the total cost and if your mood change you can even remove the previously selected items by clicking on the remove items and then by clicking on the checkout button you you need to pay the cash displayed to the cashier and wait to get your meal and Have a Nice Meal !! :)")
    End Sub

    Private Sub MenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim toolTip1 As New ToolTip()

        ' Set up the delays for the ToolTip.
        toolTip1.AutoPopDelay = 5000
        toolTip1.InitialDelay = 1000
        toolTip1.ReshowDelay = 500
        ' Force the ToolTip text to be displayed whether or not the form is active.
        toolTip1.ShowAlways = True

        ' Set up the ToolTip text for the Button and Checkbox.
        toolTip1.SetToolTip(Me.Button_Salads, "By clicking On this it displays all the salad items")
        toolTip1.SetToolTip(Me.Button_SandWitch, "By clicking On this it displays all the Sandwith & Burger items")
        toolTip1.SetToolTip(Me.Button_Snacks, "By clicking On this it displays all the Snack & Beverage items")
        toolTip1.SetToolTip(Me.Button_Deserts, "By clicking On this it displays all the Deserts & Shakes items")
        toolTip1.SetToolTip(Me.Button_Total, "By clicking On this it the total of the selected items will be calculated")
        toolTip1.SetToolTip(Me.Button_Remove, "By clicking On this the previously entered items can be removed")
        toolTip1.SetToolTip(Me.Button_CheckOut, "By clicking On this user will check out and need to pay the cash to cashier")
        toolTip1.SetToolTip(Me.ListBox_Items, "Displays the item selected")
        toolTip1.SetToolTip(Me.ListBox_Price, "Displays the price of the items selected")
    End Sub
End Class