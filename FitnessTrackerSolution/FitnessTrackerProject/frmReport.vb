' Andrew Moss
Option Explicit On
Option Strict On
Option Infer Off

Imports System.Data
Imports System.Data.SqlClient
Public Class frmReport
    ' Instantiate SQLConnection object
    Dim connection As SqlConnection = New SqlConnection(frmUserInfo.connectionString)
    ' Store user's height value from db
    Dim dblHeight As Double
    Dim dblInitWeight As Double

    Private Sub UserBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AndrewDataset)

    End Sub

    Public Function calcBMI(ByVal ht As Double, ByVal wt As Double) As Double
        Return (wt / Math.Pow(ht, 2)) * 703
    End Function

    Private Sub FrmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AndrewDataset.User' table. You can move, or remove it, as needed.
        ' Me.UserTableAdapter.Fill(Me.AndrewDataset.User)
        lblGoodJob.Visible = False

        ' Gender radio button
        If radFemale.Checked Then
            lblHips.Visible = True
            txtHips.Visible = True
        Else
            lblHips.Visible = False
            txtHips.Visible = False
        End If

        ' Setting up db connection and sql command
        Dim selectUserInfo As String = "SELECT * FROM Fit_User WHERE Username = @Username"
        Dim selectHtCmd As New SqlCommand(selectUserInfo, connection)
        selectHtCmd.Parameters.Add("@Username", SqlDbType.NVarChar, 50).Value = frmLogin.txtUsername.Text
        connection.Open()
        Dim reader As SqlDataReader = selectHtCmd.ExecuteReader()

        If reader.HasRows Then
            While reader.Read
                lblInitWtCalc.Text = reader.Item("Init_wt").ToString
                lblNameDisplay.Text = reader.Item("Name").ToString
                If IsDBNull(reader.Item("Age")) Then
                    lblAge.Visible = False
                    lblAgeDisplay.Visible = False
                Else

                    lblAgeDisplay.Text = reader.Item("Age").ToString
                End If

                Double.TryParse(reader.Item("Height").ToString, dblHeight)
            End While
        Else
            MessageBox.Show("no rows found!")
        End If
        reader.Close()
        connection.Close()

        ' Date
        lblDateDisplay.Text = Format(Now, "dddd, MMM d, yyyy")

        Double.TryParse(lblInitWtCalc.Text, dblInitWeight)
        lblCurrBMICalc.Text = Math.Round(calcBMI(dblHeight, dblInitWeight), 2, MidpointRounding.AwayFromZero).ToString
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub BtnCalcBMI_Click(sender As Object, e As EventArgs) Handles btnCalcBMI.Click
        Dim dblNewWeight As Double
        'Dim dblBMI As Double = Math.Round(, MidpointRounding.AwayFromZero)
        ' Calc new BMI
        Double.TryParse(txtNewWt.Text, dblNewWeight)
        lblNewBMICalc.Text = Math.Round(calcBMI(dblHeight, dblNewWeight), 2, MidpointRounding.AwayFromZero).ToString

        If dblNewWeight < dblInitWeight Then
            lblGoodJob.Visible = True
        Else
            lblGoodJob.Visible = False
        End If
    End Sub

    Private Sub BtnCalcBodyFat_Click(sender As Object, e As EventArgs) Handles btnCalcBF.Click
        ' BF variables
        Dim dblAbdominal As Double
        Dim dblNeck As Double
        Dim dblHips As Double
        Dim dblBFPercentage As Double

        If radMale.Checked Then
            Double.TryParse(txtAbdominal.Text, dblAbdominal)
            Double.TryParse(txtNeck.Text, dblNeck)

            dblBFPercentage = (86.01 * Math.Log10((dblAbdominal - dblNeck))) - (70.041 * Math.Log10(dblHeight)) + 36.76
            lblBFCalc.Text = Math.Round(dblBFPercentage, 2, MidpointRounding.AwayFromZero).ToString

        Else
            Double.TryParse(txtAbdominal.Text, dblAbdominal)
            Double.TryParse(txtNeck.Text, dblNeck)
            Double.TryParse(txtHips.Text, dblHips)

            dblBFPercentage = (163.205 * Math.Log10((dblAbdominal + dblHips - dblNeck))) - (97.684 * Math.Log10(dblHeight)) + 36.76
            lblBFCalc.Text = Math.Round(dblBFPercentage, 2, MidpointRounding.AwayFromZero).ToString
        End If

    End Sub

    Private Sub RadFemale_CheckedChanged(sender As Object, e As EventArgs) Handles radFemale.CheckedChanged
        lblHips.Visible = True
        txtHips.Visible = True
        txtAbdominal.Text = String.Empty
        txtNeck.Text = String.Empty
        txtHips.Text = String.Empty

    End Sub

    Private Sub RadMale_CheckedChanged(sender As Object, e As EventArgs) Handles radMale.CheckedChanged
        lblHips.Visible = False
        txtHips.Visible = False
        txtAbdominal.Text = String.Empty
        txtNeck.Text = String.Empty

    End Sub
End Class