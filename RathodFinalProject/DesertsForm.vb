'Purpose:   In this Sandwitch form the a data connection is created and the for the selected items price is extracted from the database
'           and the appropriate price for the appropriate item selected is displayed in the menu form.
Imports System.Data.OleDb
Public Class DesertsForm
    Private Class dataaccess
        Public Shared Function getconnection() As OleDbConnection
            'Here a connection string is connected to the database to retrive the data
            Dim ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=A:\P.S.R\MS\PSR VB\Project\Files\DataBase\Database.accdb"
            Return New OleDbConnection(ConnectionString)
        End Function
    End Class
    Private ListBox_Items As ListBox
    Private ListBox_Price As ListBox

    Public Sub New(ByRef TargetListBox As ListBox, ByRef TargetListBox1 As ListBox)
        ' Itialization are done here
        InitializeComponent()
        ListBox_Items = TargetListBox
        ListBox_Price = TargetListBox1
    End Sub

    Private Sub Button_Flurry_Click(sender As Object, e As EventArgs) Handles Button_Flurry.Click
        ' Here the data is grabed from the Databse from Flurry table and adds the item and price of the item Selected.
        Dim Connect As OleDbConnection = dataaccess.getconnection()
        Dim Query As String = "SELECT * FROM Deserts"
        Dim Command As New OleDbCommand(Query, Connect)
        Dim Data As New OleDbDataAdapter(Command)
        Dim DataSet As New DataSet()
        ' Dim x As Integer
        Data.Fill(DataSet)

        ListBox_Items.Items.Add(DataSet.Tables(0).Rows(0).ItemArray(0).ToString())
        ListBox_Price.Items.Add(DataSet.Tables(0).Rows(0).ItemArray(1))
    End Sub

    Private Sub Button_Fruit_Click(sender As Object, e As EventArgs) Handles Button_Fruit.Click
        ' Here the data is grabed from the Databse from Flurry table and adds the item and price of the item Selected.
        Dim Connect As OleDbConnection = dataaccess.getconnection()
        Dim Query As String = "SELECT * FROM Deserts"
        Dim Command As New OleDbCommand(Query, Connect)
        Dim Data As New OleDbDataAdapter(Command)
        Dim DataSet As New DataSet()
        ' Dim x As Integer
        Data.Fill(DataSet)
        ListBox_Items.Items.Add(DataSet.Tables(0).Rows(1).ItemArray(0).ToString())
        ListBox_Price.Items.Add(DataSet.Tables(0).Rows(1).ItemArray(1))
    End Sub

    Private Sub Button_Apple_Click(sender As Object, e As EventArgs) Handles Button_Apple.Click
        ' Here the data is grabed from the Databse from Flurry table and adds the item and price of the item Selected.
        Dim Connect As OleDbConnection = dataaccess.getconnection()
        Dim Query As String = "SELECT * FROM Deserts"
        Dim Command As New OleDbCommand(Query, Connect)
        Dim Data As New OleDbDataAdapter(Command)
        Dim DataSet As New DataSet()
        ' Dim x As Integer
        Data.Fill(DataSet)
        ListBox_Items.Items.Add(DataSet.Tables(0).Rows(2).ItemArray(0).ToString())
        ListBox_Price.Items.Add(DataSet.Tables(0).Rows(2).ItemArray(1))
    End Sub

    Private Sub Button_Cookie_Click(sender As Object, e As EventArgs) Handles Button_Cookie.Click
        ' Here the data is grabed from the Databse from Flurry table and adds the item and price of the item Selected.
        Dim Connect As OleDbConnection = dataaccess.getconnection()
        Dim Query As String = "SELECT * FROM Deserts"
        Dim Command As New OleDbCommand(Query, Connect)
        Dim Data As New OleDbDataAdapter(Command)
        Dim DataSet As New DataSet()
        ' Dim x As Integer
        Data.Fill(DataSet)

        ListBox_Items.Items.Add(DataSet.Tables(0).Rows(3).ItemArray(0).ToString())
        ListBox_Price.Items.Add(DataSet.Tables(0).Rows(3).ItemArray(1))
    End Sub

    Private Sub Button_Continue_Click(sender As Object, e As EventArgs) Handles Button_Continue.Click
        'This action is performed as soon as the user clicks on the Continue Button.
        MenuForm.Visible = True
        Me.Hide()
    End Sub

    Private Sub Button_Go_Click(sender As Object, e As EventArgs) Handles Button_Go.Click
        'This action is performed as soon as the user clicks on the Go Button.
        MenuForm.Visible = True
        Me.Hide()

    End Sub

    Private Sub Button_Cancel_Click(sender As Object, e As EventArgs) Handles Button_Cancel.Click
        'This action is performed as soon as the user clicks on the Cancel Button.
        RathodFinalProject.Visible = True
        Me.Hide()

    End Sub
End Class