'Purpose:   In this Salads form the a data connection is created and the for the selected items price is extracted from the database
'           and the appropriate price for the appropriate item selected is displayed in the menu form.
Imports System.Data.OleDb
Public Class SaladsForm

    Private Class dataaccess
        Public Shared Function getconnection() As OleDbConnection
            'Here a connection string is connected to the database to retrive the data
            Dim ConnectionStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=A:\P.S.R\MS\PSR VB\Project\Files\DataBase\Database.accdb"
            Return New OleDbConnection(ConnectionStr)
        End Function
    End Class
    Private ListBoxItems As ListBox
    Private ListBoxPrice As ListBox
    Sub New(ByVal listBox As ListBox, ByVal listBox1 As ListBox)
        ' Itialization are done here
        InitializeComponent()
        ListBoxItems = listBox
        ListBoxPrice = listBox1
    End Sub

    Private Sub Button_Continue_Click(sender As Object, e As EventArgs) Handles Button_Continue.Click
        MenuForm.Visible = True 'This action is performed as soon as the user clicks on the Continue Button.
    End Sub

    Private Sub Button_Go_Click(sender As Object, e As EventArgs) Handles Button_Go.Click
        MenuForm.Visible = True ' This action is performed as soon as the user clicks on the Go Back Button.
    End Sub

    Private Sub Button_Cancel_Click(sender As Object, e As EventArgs) Handles Button_Cancel.Click
        RathodFinalProject.Visible = True 'This action is performed as soon as the user clicks on the Cancel Button.
    End Sub

    Private Sub Button_Side_Click(sender As Object, e As EventArgs) Handles Button_Side.Click
        ' Here the data is grabed from the Databse from Salad table and adds the item and price of the item Selected.
        Dim Connect As OleDbConnection = dataaccess.getconnection()
        Dim Query As String = "SELECT * FROM Salads"
        Dim Command As New OleDbCommand(Query, Connect)
        Dim Data As New OleDbDataAdapter(Command)
        Dim DataSet As New DataSet()
        Data.Fill(DataSet)

        ListBoxItems.Items.Add(DataSet.Tables(0).Rows(0).ItemArray(0).ToString())
        ListBoxPrice.Items.Add(DataSet.Tables(0).Rows(0).ItemArray(1))
    End Sub

    Private Sub Button_Butter_Click(sender As Object, e As EventArgs) Handles Button_Butter.Click
        ' Here the data is grabed from the Databse from Salad table and adds the item and price of the item Selected.
        Dim Connect As OleDbConnection = dataaccess.getconnection()
        Dim Query As String = "SELECT * FROM Salads"
        Dim Command As New OleDbCommand(Query, Connect)
        Dim Data As New OleDbDataAdapter(Command)
        Dim DataSet As New DataSet()
        Data.Fill(DataSet)
        ListBoxItems.Items.Add(DataSet.Tables(0).Rows(1).ItemArray(0).ToString())
        ListBoxPrice.Items.Add(DataSet.Tables(0).Rows(1).ItemArray(1))

    End Sub

    Private Sub Button_Grilled_Click(sender As Object, e As EventArgs) Handles Button_Grilled.Click
        ' Here the data is grabed from the Databse from Salad table and adds the item and price of the item Selected.
        Dim Connect As OleDbConnection = dataaccess.getconnection()
        Dim Query As String = "SELECT * FROM Salads"
        Dim Command As New OleDbCommand(Query, Connect)
        Dim Data As New OleDbDataAdapter(Command)
        Dim DataSet As New DataSet()
        ' Dim x As Integer
        Data.Fill(DataSet)
        ListBoxItems.Items.Add(DataSet.Tables(0).Rows(2).ItemArray(0).ToString())
        ListBoxPrice.Items.Add(DataSet.Tables(0).Rows(2).ItemArray(1))
    End Sub

    Private Sub Button_Ranch_Click(sender As Object, e As EventArgs) Handles Button_Ranch.Click
        ' Here the data is grabed from the Databse from Salad table and adds the item and price of the item Selected.
        Dim Connect As OleDbConnection = dataaccess.getconnection()
        Dim Query As String = "SELECT * FROM Salads"
        Dim Command As New OleDbCommand(Query, Connect)
        Dim Data As New OleDbDataAdapter(Command)
        Dim DataSet As New DataSet()
        ' Dim x As Integer
        Data.Fill(DataSet)

        ListBoxItems.Items.Add(DataSet.Tables(0).Rows(3).ItemArray(0).ToString())
        ListBoxPrice.Items.Add(DataSet.Tables(0).Rows(3).ItemArray(1))
    End Sub
End Class