' Application Name :Place an McDonalds order
' Author:           Prashanth Singh Rathod
' Date:             May 12th 2016
' Purpose:          This Windows application allows user to slect the Category that is salad , sandwitch, desert, snacks
'                   and then select the items from selected category and then will calculate the total cost of the 
'                   selected items And If wanted the user can also remove the previous items selected then check out 
'                   and pay the cash to the cashier where at the check out this application shows the order number , total cost.

Public Class RathodFinalProject
    Private Sub Button_Order_Click(sender As Object, e As EventArgs) Handles Button_Order.Click
        ' This event executes to display MenuForm
        Dim MenuForm As New MenuForm
        Hide()
        MenuForm.ShowDialog()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        ' This event executes to display RathodFinalProject 
        Dim Home As New RathodFinalProject
        Hide()
        Home.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'This event exits this application
        Application.Exit()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        ' Msg box is display to help the user to navigate
        MsgBox("In order to start selecting the items click on the Order Now and select the category")
    End Sub

End Class
