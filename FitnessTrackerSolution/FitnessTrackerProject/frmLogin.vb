﻿Option Explicit On
Option Strict On
Option Infer Off
' Andrew Moss

' For calling SQL Server objects
Imports System.Data.SqlClient

Public Class frmLogin

    ' Instantiate SQLConnection object
    Dim connection As SqlConnection = New SqlConnection(frmUserInfo.connectionString)

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        frmUserInfo.Show()
        Me.Hide()
    End Sub

    Private Function ErrorMsg() As String
        If txtUsername.Text = String.Empty Then
            lblMsgNoUsername.Visible = True
        Else
            lblMsgNoUsername.Visible = False
        End If

        If txtPassword.Text = String.Empty Then
            lblMsgNoPW.Visible = True
        Else
            lblMsgNoPW.Visible = False
        End If
    End Function

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' String query
        Dim selectLoginInfo As String = "SELECT Username, Password FROM Fit_User WHERE Username = @Username AND Password = @Password"

        Try
            ' Set select command
            Dim selectCmd As New SqlCommand(selectLoginInfo, connection)

            ' Open sql connection if fields are filled
            If txtUsername.Text.Length <> 0 And txtPassword.Text.Length <> 0 Then
                connection.Open()
            Else
                ErrorMsg()
                MessageBox.Show("Please fill out required fields!")
                Exit Sub
            End If

            ' Required field parameters
            selectCmd.Parameters.Add("@Username", SqlDbType.NVarChar, 50).Value = txtUsername.Text
            selectCmd.Parameters.Add("@Password", SqlDbType.NVarChar, 50).Value = txtPassword.Text
            Dim adapter As New SqlDataAdapter(selectCmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            ' If at least one row of data is returned, login successful
            If table.Rows.Count <= 0 Then
                MessageBox.Show("Username or Password is Invalid!")
                connection.Close()
                Exit Sub
            Else
                MessageBox.Show("Login Successful!")
            End If
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Select Unsuccessful...", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        ' Redirect to Report form
        frmReport.Show()
        Me.Hide()

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class