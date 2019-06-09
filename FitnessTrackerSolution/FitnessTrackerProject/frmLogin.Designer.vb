<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblLoginTitle = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.lblNewUser = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblMsgNoUsername = New System.Windows.Forms.Label()
        Me.lblMsgNoPW = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Maiandra GD", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblUsername.Location = New System.Drawing.Point(83, 199)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(83, 16)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "Username:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Maiandra GD", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblPassword.Location = New System.Drawing.Point(87, 247)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(79, 16)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Password:"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(168, 196)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(217, 22)
        Me.txtUsername.TabIndex = 2
        '
        'lblLoginTitle
        '
        Me.lblLoginTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLoginTitle.Font = New System.Drawing.Font("Magneto", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblLoginTitle.Location = New System.Drawing.Point(3, 122)
        Me.lblLoginTitle.Name = "lblLoginTitle"
        Me.lblLoginTitle.Size = New System.Drawing.Size(528, 27)
        Me.lblLoginTitle.TabIndex = 4
        Me.lblLoginTitle.Text = "Please Login"
        Me.lblLoginTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRegister
        '
        Me.btnRegister.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnRegister.Location = New System.Drawing.Point(168, 306)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(75, 23)
        Me.btnRegister.TabIndex = 5
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'lblNewUser
        '
        Me.lblNewUser.AutoSize = True
        Me.lblNewUser.Font = New System.Drawing.Font("Maiandra GD", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNewUser.Location = New System.Drawing.Point(77, 309)
        Me.lblNewUser.Name = "lblNewUser"
        Me.lblNewUser.Size = New System.Drawing.Size(85, 16)
        Me.lblNewUser.TabIndex = 6
        Me.lblNewUser.Text = "New User?"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(168, 389)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(217, 29)
        Me.btnLogin.TabIndex = 7
        Me.btnLogin.Text = "&Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'lblMsgNoUsername
        '
        Me.lblMsgNoUsername.AutoSize = True
        Me.lblMsgNoUsername.ForeColor = System.Drawing.Color.Red
        Me.lblMsgNoUsername.Location = New System.Drawing.Point(387, 199)
        Me.lblMsgNoUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMsgNoUsername.Name = "lblMsgNoUsername"
        Me.lblMsgNoUsername.Size = New System.Drawing.Size(99, 17)
        Me.lblMsgNoUsername.TabIndex = 17
        Me.lblMsgNoUsername.Text = "Required field!"
        Me.lblMsgNoUsername.Visible = False
        '
        'lblMsgNoPW
        '
        Me.lblMsgNoPW.AutoSize = True
        Me.lblMsgNoPW.ForeColor = System.Drawing.Color.Red
        Me.lblMsgNoPW.Location = New System.Drawing.Point(387, 247)
        Me.lblMsgNoPW.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMsgNoPW.Name = "lblMsgNoPW"
        Me.lblMsgNoPW.Size = New System.Drawing.Size(99, 17)
        Me.lblMsgNoPW.TabIndex = 18
        Me.lblMsgNoPW.Text = "Required field!"
        Me.lblMsgNoPW.Visible = False
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(168, 244)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(217, 22)
        Me.txtPassword.TabIndex = 19
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(533, 516)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblMsgNoPW)
        Me.Controls.Add(Me.lblMsgNoUsername)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lblNewUser)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.lblLoginTitle)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblLoginTitle As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents lblNewUser As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblMsgNoUsername As Label
    Friend WithEvents lblMsgNoPW As Label
    Friend WithEvents txtPassword As MaskedTextBox
End Class
