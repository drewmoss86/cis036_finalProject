<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
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
        Dim lblWelcome As System.Windows.Forms.Label
        Me.AndrewDataset = New FitnessTrackerProject.andrewDataset()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserTableAdapter = New FitnessTrackerProject.andrewDatasetTableAdapters.UserTableAdapter()
        Me.TableAdapterManager = New FitnessTrackerProject.andrewDatasetTableAdapters.TableAdapterManager()
        Me.lblNameDisplay = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblNewBMI = New System.Windows.Forms.Label()
        Me.lblNewWt = New System.Windows.Forms.Label()
        Me.txtNewWt = New System.Windows.Forms.TextBox()
        Me.lblNewBMICalc = New System.Windows.Forms.Label()
        Me.btnCalcBMI = New System.Windows.Forms.Button()
        Me.grpBMI = New System.Windows.Forms.GroupBox()
        Me.lblInitWt = New System.Windows.Forms.Label()
        Me.lblInitWtCalc = New System.Windows.Forms.Label()
        Me.lblCurrBMI = New System.Windows.Forms.Label()
        Me.lblCurrBMICalc = New System.Windows.Forms.Label()
        Me.lblGoodJob = New System.Windows.Forms.Label()
        Me.lblDateDisplay = New System.Windows.Forms.Label()
        Me.lblToday = New System.Windows.Forms.Label()
        Me.grpBFPercentage = New System.Windows.Forms.GroupBox()
        Me.lblBFCalc = New System.Windows.Forms.Label()
        Me.lblBF = New System.Windows.Forms.Label()
        Me.btnCalcBF = New System.Windows.Forms.Button()
        Me.lblHips = New System.Windows.Forms.Label()
        Me.lblNeck = New System.Windows.Forms.Label()
        Me.lblAbdominal = New System.Windows.Forms.Label()
        Me.txtHips = New System.Windows.Forms.TextBox()
        Me.txtNeck = New System.Windows.Forms.TextBox()
        Me.txtAbdominal = New System.Windows.Forms.TextBox()
        Me.grpGender = New System.Windows.Forms.GroupBox()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.grpProfile = New System.Windows.Forms.GroupBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblAgeDisplay = New System.Windows.Forms.Label()
        lblWelcome = New System.Windows.Forms.Label()
        CType(Me.AndrewDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.grpBMI.SuspendLayout()
        Me.grpBFPercentage.SuspendLayout()
        Me.grpGender.SuspendLayout()
        Me.grpProfile.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        lblWelcome.Font = New System.Drawing.Font("Magneto", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblWelcome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        lblWelcome.Location = New System.Drawing.Point(24, 18)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New System.Drawing.Size(131, 34)
        lblWelcome.TabIndex = 1
        lblWelcome.Text = "Welcome"
        lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AndrewDataset
        '
        Me.AndrewDataset.DataSetName = "andrewDataset"
        Me.AndrewDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserBindingSource
        '
        Me.UserBindingSource.DataMember = "User"
        Me.UserBindingSource.DataSource = Me.AndrewDataset
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
        'lblNameDisplay
        '
        Me.lblNameDisplay.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "Name", True))
        Me.lblNameDisplay.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameDisplay.Location = New System.Drawing.Point(170, 18)
        Me.lblNameDisplay.Name = "lblNameDisplay"
        Me.lblNameDisplay.Size = New System.Drawing.Size(100, 34)
        Me.lblNameDisplay.TabIndex = 2
        Me.lblNameDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(825, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(116, 26)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'lblNewBMI
        '
        Me.lblNewBMI.AutoSize = True
        Me.lblNewBMI.Font = New System.Drawing.Font("Maiandra GD", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewBMI.Location = New System.Drawing.Point(61, 257)
        Me.lblNewBMI.Name = "lblNewBMI"
        Me.lblNewBMI.Size = New System.Drawing.Size(94, 20)
        Me.lblNewBMI.TabIndex = 4
        Me.lblNewBMI.Text = "New BMI:"
        '
        'lblNewWt
        '
        Me.lblNewWt.AutoSize = True
        Me.lblNewWt.Font = New System.Drawing.Font("Maiandra GD", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewWt.Location = New System.Drawing.Point(36, 94)
        Me.lblNewWt.Name = "lblNewWt"
        Me.lblNewWt.Size = New System.Drawing.Size(119, 20)
        Me.lblNewWt.TabIndex = 5
        Me.lblNewWt.Text = "New Weight:"
        '
        'txtNewWt
        '
        Me.txtNewWt.Location = New System.Drawing.Point(178, 94)
        Me.txtNewWt.Name = "txtNewWt"
        Me.txtNewWt.Size = New System.Drawing.Size(119, 22)
        Me.txtNewWt.TabIndex = 6
        Me.txtNewWt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNewBMICalc
        '
        Me.lblNewBMICalc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNewBMICalc.Location = New System.Drawing.Point(178, 257)
        Me.lblNewBMICalc.Name = "lblNewBMICalc"
        Me.lblNewBMICalc.Size = New System.Drawing.Size(100, 23)
        Me.lblNewBMICalc.TabIndex = 7
        Me.lblNewBMICalc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalcBMI
        '
        Me.btnCalcBMI.Location = New System.Drawing.Point(178, 142)
        Me.btnCalcBMI.Name = "btnCalcBMI"
        Me.btnCalcBMI.Size = New System.Drawing.Size(100, 31)
        Me.btnCalcBMI.TabIndex = 8
        Me.btnCalcBMI.Text = "Calculate"
        Me.btnCalcBMI.UseVisualStyleBackColor = True
        '
        'grpBMI
        '
        Me.grpBMI.Controls.Add(Me.lblInitWt)
        Me.grpBMI.Controls.Add(Me.btnCalcBMI)
        Me.grpBMI.Controls.Add(Me.lblInitWtCalc)
        Me.grpBMI.Controls.Add(Me.lblCurrBMI)
        Me.grpBMI.Controls.Add(Me.lblCurrBMICalc)
        Me.grpBMI.Controls.Add(Me.txtNewWt)
        Me.grpBMI.Controls.Add(Me.lblNewBMI)
        Me.grpBMI.Controls.Add(Me.lblNewBMICalc)
        Me.grpBMI.Controls.Add(Me.lblNewWt)
        Me.grpBMI.Location = New System.Drawing.Point(27, 172)
        Me.grpBMI.Name = "grpBMI"
        Me.grpBMI.Size = New System.Drawing.Size(346, 298)
        Me.grpBMI.TabIndex = 9
        Me.grpBMI.TabStop = False
        Me.grpBMI.Text = "BMI Calculator"
        '
        'lblInitWt
        '
        Me.lblInitWt.AutoSize = True
        Me.lblInitWt.Font = New System.Drawing.Font("Maiandra GD", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInitWt.Location = New System.Drawing.Point(27, 49)
        Me.lblInitWt.Name = "lblInitWt"
        Me.lblInitWt.Size = New System.Drawing.Size(128, 20)
        Me.lblInitWt.TabIndex = 10
        Me.lblInitWt.Text = "Initail Weight:"
        '
        'lblInitWtCalc
        '
        Me.lblInitWtCalc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInitWtCalc.Location = New System.Drawing.Point(178, 49)
        Me.lblInitWtCalc.Name = "lblInitWtCalc"
        Me.lblInitWtCalc.Size = New System.Drawing.Size(119, 23)
        Me.lblInitWtCalc.TabIndex = 11
        Me.lblInitWtCalc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCurrBMI
        '
        Me.lblCurrBMI.AutoSize = True
        Me.lblCurrBMI.Font = New System.Drawing.Font("Maiandra GD", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrBMI.Location = New System.Drawing.Point(37, 218)
        Me.lblCurrBMI.Name = "lblCurrBMI"
        Me.lblCurrBMI.Size = New System.Drawing.Size(118, 20)
        Me.lblCurrBMI.TabIndex = 8
        Me.lblCurrBMI.Text = "Current BMI:"
        '
        'lblCurrBMICalc
        '
        Me.lblCurrBMICalc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCurrBMICalc.Location = New System.Drawing.Point(178, 218)
        Me.lblCurrBMICalc.Name = "lblCurrBMICalc"
        Me.lblCurrBMICalc.Size = New System.Drawing.Size(100, 23)
        Me.lblCurrBMICalc.TabIndex = 9
        Me.lblCurrBMICalc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGoodJob
        '
        Me.lblGoodJob.AutoSize = True
        Me.lblGoodJob.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGoodJob.ForeColor = System.Drawing.Color.Chartreuse
        Me.lblGoodJob.Location = New System.Drawing.Point(110, 490)
        Me.lblGoodJob.Name = "lblGoodJob"
        Me.lblGoodJob.Size = New System.Drawing.Size(175, 32)
        Me.lblGoodJob.TabIndex = 10
        Me.lblGoodJob.Text = "Great JOB!!"
        '
        'lblDateDisplay
        '
        Me.lblDateDisplay.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateDisplay.Location = New System.Drawing.Point(170, 65)
        Me.lblDateDisplay.Name = "lblDateDisplay"
        Me.lblDateDisplay.Size = New System.Drawing.Size(160, 23)
        Me.lblDateDisplay.TabIndex = 11
        Me.lblDateDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblToday
        '
        Me.lblToday.Font = New System.Drawing.Font("Magneto", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToday.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblToday.Location = New System.Drawing.Point(25, 66)
        Me.lblToday.Name = "lblToday"
        Me.lblToday.Size = New System.Drawing.Size(130, 23)
        Me.lblToday.TabIndex = 12
        Me.lblToday.Text = "Today's Date: "
        Me.lblToday.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpBFPercentage
        '
        Me.grpBFPercentage.Controls.Add(Me.lblBFCalc)
        Me.grpBFPercentage.Controls.Add(Me.lblBF)
        Me.grpBFPercentage.Controls.Add(Me.btnCalcBF)
        Me.grpBFPercentage.Controls.Add(Me.lblHips)
        Me.grpBFPercentage.Controls.Add(Me.lblNeck)
        Me.grpBFPercentage.Controls.Add(Me.lblAbdominal)
        Me.grpBFPercentage.Controls.Add(Me.txtHips)
        Me.grpBFPercentage.Controls.Add(Me.txtNeck)
        Me.grpBFPercentage.Controls.Add(Me.txtAbdominal)
        Me.grpBFPercentage.Controls.Add(Me.grpGender)
        Me.grpBFPercentage.Location = New System.Drawing.Point(418, 172)
        Me.grpBFPercentage.Name = "grpBFPercentage"
        Me.grpBFPercentage.Size = New System.Drawing.Size(328, 397)
        Me.grpBFPercentage.TabIndex = 13
        Me.grpBFPercentage.TabStop = False
        Me.grpBFPercentage.Text = "Body Fat % (Circumference)"
        '
        'lblBFCalc
        '
        Me.lblBFCalc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBFCalc.Location = New System.Drawing.Point(138, 260)
        Me.lblBFCalc.Name = "lblBFCalc"
        Me.lblBFCalc.Size = New System.Drawing.Size(119, 23)
        Me.lblBFCalc.TabIndex = 18
        Me.lblBFCalc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBF
        '
        Me.lblBF.AutoSize = True
        Me.lblBF.Font = New System.Drawing.Font("Maiandra GD", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBF.Location = New System.Drawing.Point(34, 260)
        Me.lblBF.Name = "lblBF"
        Me.lblBF.Size = New System.Drawing.Size(90, 20)
        Me.lblBF.TabIndex = 17
        Me.lblBF.Text = "Body Fat:"
        '
        'btnCalcBF
        '
        Me.btnCalcBF.Location = New System.Drawing.Point(138, 343)
        Me.btnCalcBF.Name = "btnCalcBF"
        Me.btnCalcBF.Size = New System.Drawing.Size(100, 31)
        Me.btnCalcBF.TabIndex = 15
        Me.btnCalcBF.Text = "Calculate"
        Me.btnCalcBF.UseVisualStyleBackColor = True
        '
        'lblHips
        '
        Me.lblHips.AutoSize = True
        Me.lblHips.Font = New System.Drawing.Font("Maiandra GD", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHips.Location = New System.Drawing.Point(71, 221)
        Me.lblHips.Name = "lblHips"
        Me.lblHips.Size = New System.Drawing.Size(52, 20)
        Me.lblHips.TabIndex = 13
        Me.lblHips.Text = "Hips:"
        '
        'lblNeck
        '
        Me.lblNeck.AutoSize = True
        Me.lblNeck.Font = New System.Drawing.Font("Maiandra GD", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNeck.Location = New System.Drawing.Point(66, 183)
        Me.lblNeck.Name = "lblNeck"
        Me.lblNeck.Size = New System.Drawing.Size(57, 20)
        Me.lblNeck.TabIndex = 12
        Me.lblNeck.Text = "Neck:"
        '
        'lblAbdominal
        '
        Me.lblAbdominal.AutoSize = True
        Me.lblAbdominal.Font = New System.Drawing.Font("Maiandra GD", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbdominal.Location = New System.Drawing.Point(19, 146)
        Me.lblAbdominal.Name = "lblAbdominal"
        Me.lblAbdominal.Size = New System.Drawing.Size(104, 20)
        Me.lblAbdominal.TabIndex = 11
        Me.lblAbdominal.Text = "Abdominal:"
        '
        'txtHips
        '
        Me.txtHips.Location = New System.Drawing.Point(138, 219)
        Me.txtHips.Name = "txtHips"
        Me.txtHips.Size = New System.Drawing.Size(119, 22)
        Me.txtHips.TabIndex = 9
        Me.txtHips.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNeck
        '
        Me.txtNeck.Location = New System.Drawing.Point(138, 183)
        Me.txtNeck.Name = "txtNeck"
        Me.txtNeck.Size = New System.Drawing.Size(119, 22)
        Me.txtNeck.TabIndex = 8
        Me.txtNeck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAbdominal
        '
        Me.txtAbdominal.Location = New System.Drawing.Point(138, 146)
        Me.txtAbdominal.Name = "txtAbdominal"
        Me.txtAbdominal.Size = New System.Drawing.Size(119, 22)
        Me.txtAbdominal.TabIndex = 7
        Me.txtAbdominal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpGender
        '
        Me.grpGender.Controls.Add(Me.radMale)
        Me.grpGender.Controls.Add(Me.radFemale)
        Me.grpGender.Location = New System.Drawing.Point(23, 33)
        Me.grpGender.Name = "grpGender"
        Me.grpGender.Size = New System.Drawing.Size(115, 100)
        Me.grpGender.TabIndex = 2
        Me.grpGender.TabStop = False
        Me.grpGender.Text = "Gender"
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Checked = True
        Me.radMale.Location = New System.Drawing.Point(15, 30)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(59, 21)
        Me.radMale.TabIndex = 0
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Location = New System.Drawing.Point(15, 57)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(75, 21)
        Me.radFemale.TabIndex = 1
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "Female"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'grpProfile
        '
        Me.grpProfile.Controls.Add(Me.lblAge)
        Me.grpProfile.Controls.Add(Me.lblAgeDisplay)
        Me.grpProfile.Controls.Add(Me.lblNameDisplay)
        Me.grpProfile.Controls.Add(lblWelcome)
        Me.grpProfile.Controls.Add(Me.lblToday)
        Me.grpProfile.Controls.Add(Me.lblDateDisplay)
        Me.grpProfile.Location = New System.Drawing.Point(27, 31)
        Me.grpProfile.Name = "grpProfile"
        Me.grpProfile.Size = New System.Drawing.Size(362, 135)
        Me.grpProfile.TabIndex = 14
        Me.grpProfile.TabStop = False
        Me.grpProfile.Text = "Profile"
        '
        'lblAge
        '
        Me.lblAge.Font = New System.Drawing.Font("Magneto", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblAge.Location = New System.Drawing.Point(25, 97)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(130, 23)
        Me.lblAge.TabIndex = 14
        Me.lblAge.Text = "Age:"
        Me.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAgeDisplay
        '
        Me.lblAgeDisplay.Font = New System.Drawing.Font("Rockwell", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgeDisplay.Location = New System.Drawing.Point(170, 97)
        Me.lblAgeDisplay.Name = "lblAgeDisplay"
        Me.lblAgeDisplay.Size = New System.Drawing.Size(160, 23)
        Me.lblAgeDisplay.TabIndex = 13
        Me.lblAgeDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(825, 610)
        Me.Controls.Add(Me.grpProfile)
        Me.Controls.Add(Me.grpBFPercentage)
        Me.Controls.Add(Me.lblGoodJob)
        Me.Controls.Add(Me.grpBMI)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        CType(Me.AndrewDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpBMI.ResumeLayout(False)
        Me.grpBMI.PerformLayout()
        Me.grpBFPercentage.ResumeLayout(False)
        Me.grpBFPercentage.PerformLayout()
        Me.grpGender.ResumeLayout(False)
        Me.grpGender.PerformLayout()
        Me.grpProfile.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AndrewDataset As andrewDataset
    Friend WithEvents UserBindingSource As BindingSource
    Friend WithEvents UserTableAdapter As andrewDatasetTableAdapters.UserTableAdapter
    Friend WithEvents TableAdapterManager As andrewDatasetTableAdapters.TableAdapterManager
    Friend WithEvents lblNameDisplay As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblNewBMI As Label
    Friend WithEvents lblNewWt As Label
    Friend WithEvents txtNewWt As TextBox
    Friend WithEvents lblNewBMICalc As Label
    Friend WithEvents btnCalcBMI As Button
    Friend WithEvents grpBMI As GroupBox
    Friend WithEvents lblCurrBMI As Label
    Friend WithEvents lblCurrBMICalc As Label
    Friend WithEvents lblInitWt As Label
    Friend WithEvents lblInitWtCalc As Label
    Friend WithEvents lblGoodJob As Label
    Friend WithEvents lblDateDisplay As Label
    Friend WithEvents lblToday As Label
    Friend WithEvents grpBFPercentage As GroupBox
    Friend WithEvents lblHips As Label
    Friend WithEvents lblNeck As Label
    Friend WithEvents lblAbdominal As Label
    Friend WithEvents txtHips As TextBox
    Friend WithEvents txtNeck As TextBox
    Friend WithEvents txtAbdominal As TextBox
    Friend WithEvents grpGender As GroupBox
    Friend WithEvents radMale As RadioButton
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents btnCalcBF As Button
    Friend WithEvents lblBF As Label
    Friend WithEvents lblBFCalc As Label
    Friend WithEvents grpProfile As GroupBox
    Friend WithEvents lblAge As Label
    Friend WithEvents lblAgeDisplay As Label
End Class
