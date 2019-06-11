<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserInfo
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserInfo))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblInitWeight = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AndrewDataset = New FitnessTrackerProject.andrewDataset()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtInitWeight = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.lblTargetWeight = New System.Windows.Forms.Label()
        Me.txtTarWeight = New System.Windows.Forms.TextBox()
        Me.lblWelcomeBack = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblMsgNoName = New System.Windows.Forms.Label()
        Me.lblMsgNoInitWeight = New System.Windows.Forms.Label()
        Me.lblMsgNoTargWeight = New System.Windows.Forms.Label()
        Me.UserTableAdapter = New FitnessTrackerProject.andrewDatasetTableAdapters.UserTableAdapter()
        Me.TableAdapterManager = New FitnessTrackerProject.andrewDatasetTableAdapters.TableAdapterManager()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblMsgNoPW = New System.Windows.Forms.Label()
        Me.lblTestConn = New System.Windows.Forms.Label()
        Me.lblMsgNoHt = New System.Windows.Forms.Label()
        Me.lblMsgNoUsername = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AndrewDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(676, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileExit, Me.SaveToolStripMenuItem})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(46, 24)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuFileExit.Size = New System.Drawing.Size(173, 26)
        Me.mnuFileExit.Text = "E&xit"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(173, 26)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(179, 123)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(58, 20)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name:"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(195, 232)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(42, 20)
        Me.lblAge.TabIndex = 3
        Me.lblAge.Text = "Age:"
        Me.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblInitWeight
        '
        Me.lblInitWeight.AutoSize = True
        Me.lblInitWeight.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInitWeight.Location = New System.Drawing.Point(124, 340)
        Me.lblInitWeight.Name = "lblInitWeight"
        Me.lblInitWeight.Size = New System.Drawing.Size(113, 20)
        Me.lblInitWeight.TabIndex = 9
        Me.lblInitWeight.Text = "Initial Weight:"
        Me.lblInitWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeight.Location = New System.Drawing.Point(174, 268)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(63, 20)
        Me.lblHeight.TabIndex = 5
        Me.lblHeight.Text = "Height:"
        Me.lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZip.Location = New System.Drawing.Point(190, 303)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(38, 20)
        Me.lblZip.TabIndex = 7
        Me.lblZip.Text = "Zip:"
        Me.lblZip.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(239, 123)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(217, 22)
        Me.txtName.TabIndex = 0
        '
        'UserBindingSource
        '
        Me.UserBindingSource.DataMember = "User"
        Me.UserBindingSource.DataSource = Me.AndrewDataset
        '
        'AndrewDataset
        '
        Me.AndrewDataset.DataSetName = "andrewDataset"
        Me.AndrewDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(239, 303)
        Me.txtZip.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(100, 22)
        Me.txtZip.TabIndex = 5
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(239, 267)
        Me.txtHeight.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(100, 22)
        Me.txtHeight.TabIndex = 4
        '
        'txtInitWeight
        '
        Me.txtInitWeight.Location = New System.Drawing.Point(239, 339)
        Me.txtInitWeight.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtInitWeight.Name = "txtInitWeight"
        Me.txtInitWeight.Size = New System.Drawing.Size(100, 22)
        Me.txtInitWeight.TabIndex = 6
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(239, 231)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(100, 22)
        Me.txtAge.TabIndex = 3
        '
        'lblTargetWeight
        '
        Me.lblTargetWeight.AutoSize = True
        Me.lblTargetWeight.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTargetWeight.Location = New System.Drawing.Point(118, 376)
        Me.lblTargetWeight.Name = "lblTargetWeight"
        Me.lblTargetWeight.Size = New System.Drawing.Size(119, 20)
        Me.lblTargetWeight.TabIndex = 11
        Me.lblTargetWeight.Text = "Target Weight:"
        Me.lblTargetWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTarWeight
        '
        Me.txtTarWeight.Location = New System.Drawing.Point(239, 375)
        Me.txtTarWeight.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTarWeight.Name = "txtTarWeight"
        Me.txtTarWeight.Size = New System.Drawing.Size(100, 22)
        Me.txtTarWeight.TabIndex = 7
        '
        'lblWelcomeBack
        '
        Me.lblWelcomeBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWelcomeBack.Font = New System.Drawing.Font("Maiandra GD", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeBack.Location = New System.Drawing.Point(0, 34)
        Me.lblWelcomeBack.Name = "lblWelcomeBack"
        Me.lblWelcomeBack.Size = New System.Drawing.Size(676, 47)
        Me.lblWelcomeBack.TabIndex = 14
        Me.lblWelcomeBack.Text = "Please fill out the following"
        Me.lblWelcomeBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(170, 449)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(113, 33)
        Me.btnSubmit.TabIndex = 8
        Me.btnSubmit.Text = "S&ubmit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblMsgNoName
        '
        Me.lblMsgNoName.AutoSize = True
        Me.lblMsgNoName.ForeColor = System.Drawing.Color.Red
        Me.lblMsgNoName.Location = New System.Drawing.Point(458, 125)
        Me.lblMsgNoName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMsgNoName.Name = "lblMsgNoName"
        Me.lblMsgNoName.Size = New System.Drawing.Size(99, 17)
        Me.lblMsgNoName.TabIndex = 16
        Me.lblMsgNoName.Text = "Required field!"
        Me.lblMsgNoName.Visible = False
        '
        'lblMsgNoInitWeight
        '
        Me.lblMsgNoInitWeight.AutoSize = True
        Me.lblMsgNoInitWeight.ForeColor = System.Drawing.Color.Red
        Me.lblMsgNoInitWeight.Location = New System.Drawing.Point(341, 341)
        Me.lblMsgNoInitWeight.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMsgNoInitWeight.Name = "lblMsgNoInitWeight"
        Me.lblMsgNoInitWeight.Size = New System.Drawing.Size(99, 17)
        Me.lblMsgNoInitWeight.TabIndex = 17
        Me.lblMsgNoInitWeight.Text = "Required field!"
        Me.lblMsgNoInitWeight.Visible = False
        '
        'lblMsgNoTargWeight
        '
        Me.lblMsgNoTargWeight.AutoSize = True
        Me.lblMsgNoTargWeight.ForeColor = System.Drawing.Color.Red
        Me.lblMsgNoTargWeight.Location = New System.Drawing.Point(341, 377)
        Me.lblMsgNoTargWeight.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMsgNoTargWeight.Name = "lblMsgNoTargWeight"
        Me.lblMsgNoTargWeight.Size = New System.Drawing.Size(99, 17)
        Me.lblMsgNoTargWeight.TabIndex = 18
        Me.lblMsgNoTargWeight.Text = "Required field!"
        Me.lblMsgNoTargWeight.Visible = False
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = FitnessTrackerProject.andrewDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserTableAdapter = Me.UserTableAdapter
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(239, 195)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(152, 22)
        Me.txtPassword.TabIndex = 2
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(154, 196)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(83, 20)
        Me.lblPassword.TabIndex = 19
        Me.lblPassword.Text = "Password:"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMsgNoPW
        '
        Me.lblMsgNoPW.AutoSize = True
        Me.lblMsgNoPW.ForeColor = System.Drawing.Color.Red
        Me.lblMsgNoPW.Location = New System.Drawing.Point(393, 197)
        Me.lblMsgNoPW.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMsgNoPW.Name = "lblMsgNoPW"
        Me.lblMsgNoPW.Size = New System.Drawing.Size(99, 17)
        Me.lblMsgNoPW.TabIndex = 21
        Me.lblMsgNoPW.Text = "Required field!"
        Me.lblMsgNoPW.Visible = False
        '
        'lblTestConn
        '
        Me.lblTestConn.Location = New System.Drawing.Point(8, 53)
        Me.lblTestConn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTestConn.Name = "lblTestConn"
        Me.lblTestConn.Size = New System.Drawing.Size(133, 28)
        Me.lblTestConn.TabIndex = 22
        Me.lblTestConn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMsgNoHt
        '
        Me.lblMsgNoHt.AutoSize = True
        Me.lblMsgNoHt.ForeColor = System.Drawing.Color.Red
        Me.lblMsgNoHt.Location = New System.Drawing.Point(341, 269)
        Me.lblMsgNoHt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMsgNoHt.Name = "lblMsgNoHt"
        Me.lblMsgNoHt.Size = New System.Drawing.Size(99, 17)
        Me.lblMsgNoHt.TabIndex = 23
        Me.lblMsgNoHt.Text = "Required field!"
        Me.lblMsgNoHt.Visible = False
        '
        'lblMsgNoUsername
        '
        Me.lblMsgNoUsername.AutoSize = True
        Me.lblMsgNoUsername.ForeColor = System.Drawing.Color.Red
        Me.lblMsgNoUsername.Location = New System.Drawing.Point(458, 161)
        Me.lblMsgNoUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMsgNoUsername.Name = "lblMsgNoUsername"
        Me.lblMsgNoUsername.Size = New System.Drawing.Size(99, 17)
        Me.lblMsgNoUsername.TabIndex = 26
        Me.lblMsgNoUsername.Text = "Required field!"
        Me.lblMsgNoUsername.Visible = False
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(239, 159)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(217, 22)
        Me.txtUsername.TabIndex = 1
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(150, 159)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(87, 20)
        Me.lblUsername.TabIndex = 25
        Me.lblUsername.Text = "Username:"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(344, 449)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(113, 33)
        Me.btnCancel.TabIndex = 27
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmUserInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 521)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblMsgNoUsername)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblMsgNoHt)
        Me.Controls.Add(Me.lblTestConn)
        Me.Controls.Add(Me.lblMsgNoPW)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblMsgNoTargWeight)
        Me.Controls.Add(Me.lblMsgNoInitWeight)
        Me.Controls.Add(Me.lblMsgNoName)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblWelcomeBack)
        Me.Controls.Add(Me.txtTarWeight)
        Me.Controls.Add(Me.lblTargetWeight)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtInitWeight)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblZip)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.lblInitWeight)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmUserInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Info"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AndrewDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents lblName As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblInitWeight As Label
    Friend WithEvents lblHeight As Label
    Friend WithEvents lblZip As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtZip As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtInitWeight As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents lblTargetWeight As Label
    Friend WithEvents txtTarWeight As TextBox
    Friend WithEvents lblWelcomeBack As Label
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblMsgNoName As Label
    Friend WithEvents lblMsgNoInitWeight As Label
    Friend WithEvents lblMsgNoTargWeight As Label
    Friend WithEvents AndrewDataset As andrewDataset
    Friend WithEvents UserBindingSource As BindingSource
    Friend WithEvents UserTableAdapter As andrewDatasetTableAdapters.UserTableAdapter
    Friend WithEvents TableAdapterManager As andrewDatasetTableAdapters.TableAdapterManager
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblMsgNoPW As Label
    Friend WithEvents lblTestConn As Label
    Friend WithEvents lblMsgNoHt As Label
    Friend WithEvents lblMsgNoUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents btnCancel As Button
End Class
