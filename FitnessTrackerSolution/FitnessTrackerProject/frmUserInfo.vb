' Andrew Moss
Option Explicit On
Option Strict On
Option Infer Off

' For calling SQL Server objects
Imports System.Data.SqlClient
Public Class frmUserInfo

    ' Instantiate SQLConnection object and Command object as shown below
    Dim connection As SqlConnection = New SqlConnection("Data Source=SVY;Initial Catalog=FitnessTracker;Integrated Security=True")

    Private Function ErrorMsg() As String
        If txtName.Text = "" Then
            lblMsgNoName.Visible = True
        Else
            lblMsgNoName.Visible = False
        End If

        If txtPassword.Text = "" Then
            lblMsgNoPW.Visible = True
        Else
            lblMsgNoPW.Visible = False
        End If

        If txtInitWeight.Text = "" Then
            lblMsgNoInitWeight.Visible = True
        Else
            lblMsgNoInitWeight.Visible = False
        End If

        If txtTarWeight.Text = "" Then
            lblMsgNoTargWeight.Visible = True
        Else
            lblMsgNoTargWeight.Visible = False
        End If

        If txtHeight.Text = "" Then
            lblMsgNoHt.Visible = True
        Else
            lblMsgNoHt.Visible = False
        End If
    End Function
    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        ' Closes entire application instead of just the form e.g. (Me.Close())
        Application.Exit()
    End Sub

    Private Sub AnyTextBox_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged, txtAge.TextChanged, txtHeight.TextChanged, txtZip.TextChanged, txtInitWeight.TextChanged, txtTarWeight.TextChanged
        ' Turn off saved message when user edits the field
        lblSaveMessage.Visible = False
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        ' Query to insert user values
        Dim insertUserInfo As String = "INSERT INTO Fit_User (Name, Password, Age, Height, Init_wt, Target_wt) VALUES (@Name, @Password, @Age, @Height, @Init_wt, @Target_wt)"
        Try

            ' Sql command using the query and establishing connection
            Dim insertCmd As New SqlCommand(insertUserInfo, connection)

            ' Open db connection only if all required fields are field
            If txtName.Text <> String.Empty And
                txtPassword.Text <> String.Empty And
                txtHeight.Text <> String.Empty And
                txtInitWeight.Text <> String.Empty And
                txtTarWeight.Text <> String.Empty Then
                ' Open sql connection
                connection.Open()
            Else
                ErrorMsg()
                MessageBox.Show("Please fill out required fields!")
                Exit Sub
            End If

            ' required fields
            insertCmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = txtName.Text
            insertCmd.Parameters.Add("@Password", SqlDbType.NVarChar, 50).Value = txtPassword.Text
            insertCmd.Parameters.Add("@Height", SqlDbType.Int, 10).Value = txtHeight.Text
            insertCmd.Parameters.Add("@Init_wt", SqlDbType.Int, 10).Value = txtInitWeight.Text
            insertCmd.Parameters.Add("@Target_wt", SqlDbType.Int, 10).Value = txtTarWeight.Text

            ' If nullable fields are empty, assign null value (otherwise, will throw error
            If txtAge.Text = String.Empty Then
                insertCmd.Parameters.Add("@Age", SqlDbType.Int, 10).Value = DBNull.Value
            Else
                insertCmd.Parameters.Add("@Age", SqlDbType.Int, 10).Value = txtAge.Text
            End If

            If txtZip.Text = String.Empty Then
                insertCmd.Parameters.Add("@Zip", SqlDbType.Int, 10).Value = DBNull.Value
            Else
                insertCmd.Parameters.Add("@Zip", SqlDbType.Int, 10).Value = txtZip.Text
            End If

            ' If 1 row is successfully updated, then user has been added successfully
            If insertCmd.ExecuteNonQuery.Equals(1) Then
                MessageBox.Show("New User Added")
            Else
                MessageBox.Show("User Not Added")
            End If
            connection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Insert Unsuccessful...", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        'Me.Close()
    End Sub

    Private Sub FrmUserInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AndrewDataset.User' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.AndrewDataset.User)

    End Sub

End Class
