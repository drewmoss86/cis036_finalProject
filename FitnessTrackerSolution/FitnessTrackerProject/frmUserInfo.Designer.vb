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
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtInitWeight = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.lblTargetWeight = New System.Windows.Forms.Label()
        Me.txtTargetWeight = New System.Windows.Forms.TextBox()
        Me.lblSaveMessage = New System.Windows.Forms.Label()
        Me.lblWelcomeBack = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblMsgNoName = New System.Windows.Forms.Label()
        Me.lblMsgNoInitWeight = New System.Windows.Forms.Label()
        Me.lblMsgNoTargWeight = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(492, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileExit, Me.SaveToolStripMenuItem})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuFileExit.Size = New System.Drawing.Size(138, 22)
        Me.mnuFileExit.Text = "E&xit"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(130, 75)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(45, 16)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name:"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(141, 106)
        Me.lblAge.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(34, 16)
        Me.lblAge.TabIndex = 3
        Me.lblAge.Text = "Age:"
        Me.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblInitWeight
        '
        Me.lblInitWeight.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInitWeight.Location = New System.Drawing.Point(86, 201)
        Me.lblInitWeight.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInitWeight.Name = "lblInitWeight"
        Me.lblInitWeight.Size = New System.Drawing.Size(89, 20)
        Me.lblInitWeight.TabIndex = 9
        Me.lblInitWeight.Text = "Initial Weight:"
        Me.lblInitWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeight.Location = New System.Drawing.Point(126, 138)
        Me.lblHeight.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(49, 16)
        Me.lblHeight.TabIndex = 5
        Me.lblHeight.Text = "Height:"
        Me.lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZip.Location = New System.Drawing.Point(144, 170)
        Me.lblZip.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(31, 16)
        Me.lblZip.TabIndex = 7
        Me.lblZip.Text = "Zip:"
        Me.lblZip.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(179, 74)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(164, 20)
        Me.txtName.TabIndex = 2
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(179, 169)
        Me.txtZip.Margin = New System.Windows.Forms.Padding(2)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(76, 20)
        Me.txtZip.TabIndex = 8
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(179, 137)
        Me.txtHeight.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(76, 20)
        Me.txtHeight.TabIndex = 6
        '
        'txtInitWeight
        '
        Me.txtInitWeight.Location = New System.Drawing.Point(179, 202)
        Me.txtInitWeight.Margin = New System.Windows.Forms.Padding(2)
        Me.txtInitWeight.Name = "txtInitWeight"
        Me.txtInitWeight.Size = New System.Drawing.Size(76, 20)
        Me.txtInitWeight.TabIndex = 10
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(179, 105)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(76, 20)
        Me.txtAge.TabIndex = 4
        '
        'lblTargetWeight
        '
        Me.lblTargetWeight.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTargetWeight.Location = New System.Drawing.Point(74, 233)
        Me.lblTargetWeight.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTargetWeight.Name = "lblTargetWeight"
        Me.lblTargetWeight.Size = New System.Drawing.Size(101, 20)
        Me.lblTargetWeight.TabIndex = 11
        Me.lblTargetWeight.Text = "Target Weight:"
        Me.lblTargetWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTargetWeight
        '
        Me.txtTargetWeight.Location = New System.Drawing.Point(179, 234)
        Me.txtTargetWeight.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTargetWeight.Name = "txtTargetWeight"
        Me.txtTargetWeight.Size = New System.Drawing.Size(76, 20)
        Me.txtTargetWeight.TabIndex = 12
        '
        'lblSaveMessage
        '
        Me.lblSaveMessage.Location = New System.Drawing.Point(2, 339)
        Me.lblSaveMessage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSaveMessage.Name = "lblSaveMessage"
        Me.lblSaveMessage.Size = New System.Drawing.Size(104, 21)
        Me.lblSaveMessage.TabIndex = 1
        Me.lblSaveMessage.Text = "Information Saved"
        Me.lblSaveMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSaveMessage.Visible = False
        '
        'lblWelcomeBack
        '
        Me.lblWelcomeBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWelcomeBack.Font = New System.Drawing.Font("Maiandra GD", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeBack.Location = New System.Drawing.Point(0, 24)
        Me.lblWelcomeBack.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblWelcomeBack.Name = "lblWelcomeBack"
        Me.lblWelcomeBack.Size = New System.Drawing.Size(492, 38)
        Me.lblWelcomeBack.TabIndex = 14
        Me.lblWelcomeBack.Text = "Please fill out the following"
        Me.lblWelcomeBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(179, 285)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(85, 27)
        Me.btnSubmit.TabIndex = 15
        Me.btnSubmit.Text = "S&ubmit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblMsgNoName
        '
        Me.lblMsgNoName.AutoSize = True
        Me.lblMsgNoName.ForeColor = System.Drawing.Color.Red
        Me.lblMsgNoName.Location = New System.Drawing.Point(348, 81)
        Me.lblMsgNoName.Name = "lblMsgNoName"
        Me.lblMsgNoName.Size = New System.Drawing.Size(75, 13)
        Me.lblMsgNoName.TabIndex = 16
        Me.lblMsgNoName.Text = "Required field!"
        Me.lblMsgNoName.Visible = False
        '
        'lblMsgNoInitWeight
        '
        Me.lblMsgNoInitWeight.AutoSize = True
        Me.lblMsgNoInitWeight.ForeColor = System.Drawing.Color.Red
        Me.lblMsgNoInitWeight.Location = New System.Drawing.Point(260, 209)
        Me.lblMsgNoInitWeight.Name = "lblMsgNoInitWeight"
        Me.lblMsgNoInitWeight.Size = New System.Drawing.Size(75, 13)
        Me.lblMsgNoInitWeight.TabIndex = 17
        Me.lblMsgNoInitWeight.Text = "Required field!"
        Me.lblMsgNoInitWeight.Visible = False
        '
        'lblMsgNoTargWeight
        '
        Me.lblMsgNoTargWeight.AutoSize = True
        Me.lblMsgNoTargWeight.ForeColor = System.Drawing.Color.Red
        Me.lblMsgNoTargWeight.Location = New System.Drawing.Point(260, 241)
        Me.lblMsgNoTargWeight.Name = "lblMsgNoTargWeight"
        Me.lblMsgNoTargWeight.Size = New System.Drawing.Size(75, 13)
        Me.lblMsgNoTargWeight.TabIndex = 18
        Me.lblMsgNoTargWeight.Text = "Required field!"
        Me.lblMsgNoTargWeight.Visible = False
        '
        'frmUserInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 369)
        Me.Controls.Add(Me.lblMsgNoTargWeight)
        Me.Controls.Add(Me.lblMsgNoInitWeight)
        Me.Controls.Add(Me.lblMsgNoName)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblWelcomeBack)
        Me.Controls.Add(Me.lblSaveMessage)
        Me.Controls.Add(Me.txtTargetWeight)
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
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmUserInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Info"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
    Friend WithEvents txtTargetWeight As TextBox
    Friend WithEvents lblSaveMessage As Label
    Friend WithEvents lblWelcomeBack As Label
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblMsgNoName As Label
    Friend WithEvents lblMsgNoInitWeight As Label
    Friend WithEvents lblMsgNoTargWeight As Label
End Class
