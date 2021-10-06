<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.statusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lstCollections = New System.Windows.Forms.ListBox()
        Me.btnAddTitles = New System.Windows.Forms.Button()
        Me.lblUsers = New System.Windows.Forms.Label()
        Me.lstIDsToAdd = New System.Windows.Forms.ListBox()
        Me.txtCollections = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstUsers = New System.Windows.Forms.ListBox()
        Me.txtComputers = New System.Windows.Forms.RichTextBox()
        Me.btnAddNames = New System.Windows.Forms.Button()
        Me.btnAddFromClipboard = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPush = New System.Windows.Forms.Button()
        Me.chkShowAll = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLookup = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.sd1 = New System.Windows.Forms.SaveFileDialog()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgressBar, Me.statusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 272)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(574, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ProgressBar
        '
        Me.ProgressBar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(100, 16)
        '
        'statusLabel
        '
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(42, 17)
        Me.statusLabel.Text = "Ready."
        '
        'lstCollections
        '
        Me.lstCollections.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCollections.FormattingEnabled = True
        Me.lstCollections.Location = New System.Drawing.Point(702, 199)
        Me.lstCollections.Name = "lstCollections"
        Me.lstCollections.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstCollections.Size = New System.Drawing.Size(294, 199)
        Me.lstCollections.Sorted = True
        Me.lstCollections.TabIndex = 3
        '
        'btnAddTitles
        '
        Me.btnAddTitles.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddTitles.Location = New System.Drawing.Point(701, 166)
        Me.btnAddTitles.Name = "btnAddTitles"
        Me.btnAddTitles.Size = New System.Drawing.Size(296, 27)
        Me.btnAddTitles.TabIndex = 21
        Me.btnAddTitles.Text = "Add To Queue"
        Me.btnAddTitles.UseVisualStyleBackColor = True
        '
        'lblUsers
        '
        Me.lblUsers.AutoSize = True
        Me.lblUsers.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsers.Location = New System.Drawing.Point(179, 9)
        Me.lblUsers.Name = "lblUsers"
        Me.lblUsers.Size = New System.Drawing.Size(119, 15)
        Me.lblUsers.TabIndex = 16
        Me.lblUsers.Text = "Last User Logged On:"
        '
        'lstIDsToAdd
        '
        Me.lstIDsToAdd.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstIDsToAdd.FormattingEnabled = True
        Me.lstIDsToAdd.Location = New System.Drawing.Point(1018, 342)
        Me.lstIDsToAdd.Name = "lstIDsToAdd"
        Me.lstIDsToAdd.Size = New System.Drawing.Size(159, 56)
        Me.lstIDsToAdd.TabIndex = 15
        '
        'txtCollections
        '
        Me.txtCollections.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCollections.Location = New System.Drawing.Point(13, 27)
        Me.txtCollections.Name = "txtCollections"
        Me.txtCollections.Size = New System.Drawing.Size(158, 193)
        Me.txtCollections.TabIndex = 0
        Me.txtCollections.Text = ""
        Me.txtCollections.WordWrap = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 15)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Machine Names:"
        '
        'lstUsers
        '
        Me.lstUsers.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstUsers.FormattingEnabled = True
        Me.lstUsers.Location = New System.Drawing.Point(1018, 251)
        Me.lstUsers.Name = "lstUsers"
        Me.lstUsers.Size = New System.Drawing.Size(159, 69)
        Me.lstUsers.TabIndex = 14
        '
        'txtComputers
        '
        Me.txtComputers.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComputers.Location = New System.Drawing.Point(182, 27)
        Me.txtComputers.Name = "txtComputers"
        Me.txtComputers.Size = New System.Drawing.Size(380, 193)
        Me.txtComputers.TabIndex = 2
        Me.txtComputers.Text = ""
        Me.txtComputers.WordWrap = False
        '
        'btnAddNames
        '
        Me.btnAddNames.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNames.Location = New System.Drawing.Point(1017, 166)
        Me.btnAddNames.Name = "btnAddNames"
        Me.btnAddNames.Size = New System.Drawing.Size(160, 27)
        Me.btnAddNames.TabIndex = 29
        Me.btnAddNames.Text = "Add To Queue"
        Me.btnAddNames.UseVisualStyleBackColor = True
        '
        'btnAddFromClipboard
        '
        Me.btnAddFromClipboard.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddFromClipboard.Location = New System.Drawing.Point(1017, 199)
        Me.btnAddFromClipboard.Name = "btnAddFromClipboard"
        Me.btnAddFromClipboard.Size = New System.Drawing.Size(160, 27)
        Me.btnAddFromClipboard.TabIndex = 30
        Me.btnAddFromClipboard.Text = "Add From Clipboard"
        Me.btnAddFromClipboard.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1015, 323)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 15)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Collections To Add:"
        '
        'btnPush
        '
        Me.btnPush.Location = New System.Drawing.Point(700, 404)
        Me.btnPush.Name = "btnPush"
        Me.btnPush.Size = New System.Drawing.Size(479, 33)
        Me.btnPush.TabIndex = 32
        Me.btnPush.Text = "Push Queue"
        Me.btnPush.UseVisualStyleBackColor = True
        '
        'chkShowAll
        '
        Me.chkShowAll.AutoSize = True
        Me.chkShowAll.Location = New System.Drawing.Point(588, 303)
        Me.chkShowAll.Name = "chkShowAll"
        Me.chkShowAll.Size = New System.Drawing.Size(71, 17)
        Me.chkShowAll.TabIndex = 33
        Me.chkShowAll.Text = "Show All"
        Me.chkShowAll.UseVisualStyleBackColor = True
        Me.chkShowAll.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1015, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 15)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Workstations To Add:"
        '
        'btnLookup
        '
        Me.btnLookup.Location = New System.Drawing.Point(12, 226)
        Me.btnLookup.Name = "btnLookup"
        Me.btnLookup.Size = New System.Drawing.Size(158, 33)
        Me.btnLookup.TabIndex = 1
        Me.btnLookup.Text = "Lookup"
        Me.btnLookup.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(458, 226)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(104, 33)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save To Text File"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(182, 226)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(185, 33)
        Me.btnCopy.TabIndex = 3
        Me.btnCopy.Text = "Copy To Clipboard"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'btnExcel
        '
        Me.btnExcel.Location = New System.Drawing.Point(373, 226)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(79, 33)
        Me.btnExcel.TabIndex = 35
        Me.btnExcel.Text = "Save Excel"
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 294)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnLookup)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chkShowAll)
        Me.Controls.Add(Me.btnPush)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAddFromClipboard)
        Me.Controls.Add(Me.btnAddNames)
        Me.Controls.Add(Me.txtComputers)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCollections)
        Me.Controls.Add(Me.btnAddTitles)
        Me.Controls.Add(Me.lblUsers)
        Me.Controls.Add(Me.lstIDsToAdd)
        Me.Controls.Add(Me.lstUsers)
        Me.Controls.Add(Me.lstCollections)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lookup"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents statusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lstCollections As System.Windows.Forms.ListBox
    Friend WithEvents btnAddTitles As System.Windows.Forms.Button
    Friend WithEvents lblUsers As System.Windows.Forms.Label
    Friend WithEvents lstIDsToAdd As System.Windows.Forms.ListBox
    Friend WithEvents txtCollections As System.Windows.Forms.RichTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstUsers As System.Windows.Forms.ListBox
    Friend WithEvents txtComputers As System.Windows.Forms.RichTextBox
    Friend WithEvents btnAddNames As System.Windows.Forms.Button
    Friend WithEvents btnAddFromClipboard As System.Windows.Forms.Button
    Friend WithEvents ProgressBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPush As System.Windows.Forms.Button
    Friend WithEvents chkShowAll As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnLookup As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents sd1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents btnExcel As System.Windows.Forms.Button

End Class
