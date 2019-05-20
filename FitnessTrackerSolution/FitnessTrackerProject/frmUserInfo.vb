' Andrew Moss
Option Explicit On
Option Strict On
Option Infer Off
' For calling MySQL objects
Imports MySql.Data.MySqlClient

Public Class frmUserInfo
    Dim mysqlConn As MySqlConnection
    Dim mysqlCmd As MySqlCommand
    Dim mysqlReader As MySqlDataReader

    Private Function ErrorMsg() As String
        If txtName.Text = "" Then
            lblMsgNoName.Visible = True
        Else
            lblMsgNoName.Visible = False
        End If

        If txtInitWeight.Text = "" Then
            lblMsgNoInitWeight.Visible = True
        Else
            lblMsgNoInitWeight.Visible = False
        End If

        If txtTargetWeight.Text = "" Then
            lblMsgNoTargWeight.Visible = True
        Else
            lblMsgNoTargWeight.Visible = False
        End If
    End Function
    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        ' Closes entire application instead of just the form e.g. (Me.Close())
        Application.Exit()
    End Sub

    Private Sub AnyTextBox_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged, txtAge.TextChanged, txtHeight.TextChanged, txtZip.TextChanged, txtInitWeight.TextChanged, txtTargetWeight.TextChanged
        ' Turn off saved message when user edits the field
        lblSaveMessage.Visible = False
    End Sub

    Private Sub lblWelcomeBack_Click(sender As Object, e As EventArgs) Handles lblWelcomeBack.Click
        Dim selectQuery As String = "SELECT name FROM fitnesstracker_dev.users"
        Dim strName As String
        mysqlCmd = New MySqlCommand(selectQuery, mysqlConn)
        mysqlReader = mysqlCmd.ExecuteReader
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Displays error message if required field is missing
        ErrorMsg()

        '' create new MySqlConnection object for each button click
        'mysqlConn = New MySqlConnection
        '' access mysql server
        'mysqlConn.ConnectionString = "server=localhost;uid=root;database=fitnesstracker_dev"


        'Try
        '    mysqlConn.Open()

        '    Dim insertQuery As String = "INSERT INTO fitnesstracker_dev.users (name, age, height, zip, init_weight, target_weight)
        '                           VALUES ('" & txtName.Text & "', '" & txtAge.Text & "', '" & txtHeight.Text & "', '" & txtZip.Text & "', '" & txtInitWeight.Text & "', '" & txtTargetWeight.Text & "');"
        '    mysqlCmd = New MySqlCommand(insertQuery, mysqlConn)
        '    mysqlReader = mysqlCmd.ExecuteReader
        '    MessageBox.Show("Data Saved!")
        '    lblSaveMessage.Visible = True
        '    mysqlConn.Close()
        'Catch ex As MySqlException
        '    MessageBox.Show(ex.Message)
        'End Try
        Me.Close()
    End Sub
End Class
