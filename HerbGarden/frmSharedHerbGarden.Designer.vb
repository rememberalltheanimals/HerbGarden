<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSharedHerbGarden
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
        Me.lblLatin = New System.Windows.Forms.Label()
        Me.lblMember = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblNumOfPlants = New System.Windows.Forms.Label()
        Me.lblFamily = New System.Windows.Forms.Label()
        Me.lblHabitat = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblParts = New System.Windows.Forms.Label()
        Me.lblUses = New System.Windows.Forms.Label()
        Me.lblSpacing = New System.Windows.Forms.Label()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.txtLatin = New System.Windows.Forms.TextBox()
        Me.txtMember = New System.Windows.Forms.TextBox()
        Me.cboYear = New System.Windows.Forms.ComboBox()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.txtFamily = New System.Windows.Forms.TextBox()
        Me.txtHabitat = New System.Windows.Forms.TextBox()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.txtParts = New System.Windows.Forms.TextBox()
        Me.cboUses = New System.Windows.Forms.ComboBox()
        Me.txtSpacing = New System.Windows.Forms.TextBox()
        Me.txtStartDate = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lbxPlants = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblLatin
        '
        Me.lblLatin.AutoSize = True
        Me.lblLatin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLatin.Location = New System.Drawing.Point(40, 36)
        Me.lblLatin.Name = "lblLatin"
        Me.lblLatin.Size = New System.Drawing.Size(105, 20)
        Me.lblLatin.TabIndex = 0
        Me.lblLatin.Text = "Latin Name:"
        '
        'lblMember
        '
        Me.lblMember.AutoSize = True
        Me.lblMember.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMember.Location = New System.Drawing.Point(40, 83)
        Me.lblMember.Name = "lblMember"
        Me.lblMember.Size = New System.Drawing.Size(123, 20)
        Me.lblMember.TabIndex = 1
        Me.lblMember.Text = "Member Lead:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(40, 131)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(156, 20)
        Me.lblYear.TabIndex = 2
        Me.lblYear.Text = "Annual / Perrenial:"
        '
        'lblNumOfPlants
        '
        Me.lblNumOfPlants.AutoSize = True
        Me.lblNumOfPlants.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumOfPlants.Location = New System.Drawing.Point(40, 177)
        Me.lblNumOfPlants.Name = "lblNumOfPlants"
        Me.lblNumOfPlants.Size = New System.Drawing.Size(103, 20)
        Me.lblNumOfPlants.TabIndex = 3
        Me.lblNumOfPlants.Text = "# Of Plants:"
        '
        'lblFamily
        '
        Me.lblFamily.AutoSize = True
        Me.lblFamily.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFamily.Location = New System.Drawing.Point(40, 228)
        Me.lblFamily.Name = "lblFamily"
        Me.lblFamily.Size = New System.Drawing.Size(111, 20)
        Me.lblFamily.TabIndex = 4
        Me.lblFamily.Text = "Plant Family:"
        '
        'lblHabitat
        '
        Me.lblHabitat.AutoSize = True
        Me.lblHabitat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHabitat.Location = New System.Drawing.Point(40, 277)
        Me.lblHabitat.Name = "lblHabitat"
        Me.lblHabitat.Size = New System.Drawing.Size(226, 20)
        Me.lblHabitat.TabIndex = 5
        Me.lblHabitat.Text = "Native Ecosystem, Climate:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(40, 326)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(113, 20)
        Me.lblStatus.TabIndex = 6
        Me.lblStatus.Text = "Plant Status:"
        '
        'lblParts
        '
        Me.lblParts.AutoSize = True
        Me.lblParts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParts.Location = New System.Drawing.Point(40, 376)
        Me.lblParts.Name = "lblParts"
        Me.lblParts.Size = New System.Drawing.Size(146, 20)
        Me.lblParts.TabIndex = 7
        Me.lblParts.Text = "Main Parts Used:"
        '
        'lblUses
        '
        Me.lblUses.AutoSize = True
        Me.lblUses.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUses.Location = New System.Drawing.Point(40, 427)
        Me.lblUses.Name = "lblUses"
        Me.lblUses.Size = New System.Drawing.Size(169, 20)
        Me.lblUses.TabIndex = 8
        Me.lblUses.Text = "Cullinary or Medical:"
        '
        'lblSpacing
        '
        Me.lblSpacing.AutoSize = True
        Me.lblSpacing.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpacing.Location = New System.Drawing.Point(40, 477)
        Me.lblSpacing.Name = "lblSpacing"
        Me.lblSpacing.Size = New System.Drawing.Size(65, 20)
        Me.lblSpacing.TabIndex = 9
        Me.lblSpacing.Text = "Space:"
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartDate.Location = New System.Drawing.Point(40, 526)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(195, 20)
        Me.lblStartDate.TabIndex = 10
        Me.lblStartDate.Text = "Germination start date:"
        '
        'txtLatin
        '
        Me.txtLatin.Location = New System.Drawing.Point(151, 36)
        Me.txtLatin.Name = "txtLatin"
        Me.txtLatin.Size = New System.Drawing.Size(100, 20)
        Me.txtLatin.TabIndex = 11
        '
        'txtMember
        '
        Me.txtMember.Location = New System.Drawing.Point(170, 82)
        Me.txtMember.Name = "txtMember"
        Me.txtMember.Size = New System.Drawing.Size(100, 20)
        Me.txtMember.TabIndex = 12
        '
        'cboYear
        '
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Location = New System.Drawing.Point(203, 129)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(121, 21)
        Me.cboYear.TabIndex = 13
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(151, 176)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtNumber.TabIndex = 14
        '
        'txtFamily
        '
        Me.txtFamily.Location = New System.Drawing.Point(158, 227)
        Me.txtFamily.Name = "txtFamily"
        Me.txtFamily.Size = New System.Drawing.Size(100, 20)
        Me.txtFamily.TabIndex = 15
        '
        'txtHabitat
        '
        Me.txtHabitat.Location = New System.Drawing.Point(273, 276)
        Me.txtHabitat.Name = "txtHabitat"
        Me.txtHabitat.Size = New System.Drawing.Size(100, 20)
        Me.txtHabitat.TabIndex = 16
        '
        'cboStatus
        '
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Location = New System.Drawing.Point(159, 325)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(121, 21)
        Me.cboStatus.TabIndex = 17
        '
        'txtParts
        '
        Me.txtParts.Location = New System.Drawing.Point(192, 376)
        Me.txtParts.Name = "txtParts"
        Me.txtParts.Size = New System.Drawing.Size(100, 20)
        Me.txtParts.TabIndex = 18
        '
        'cboUses
        '
        Me.cboUses.FormattingEnabled = True
        Me.cboUses.Location = New System.Drawing.Point(215, 426)
        Me.cboUses.Name = "cboUses"
        Me.cboUses.Size = New System.Drawing.Size(121, 21)
        Me.cboUses.TabIndex = 19
        '
        'txtSpacing
        '
        Me.txtSpacing.Location = New System.Drawing.Point(111, 479)
        Me.txtSpacing.Name = "txtSpacing"
        Me.txtSpacing.Size = New System.Drawing.Size(100, 20)
        Me.txtSpacing.TabIndex = 20
        '
        'txtStartDate
        '
        Me.txtStartDate.Location = New System.Drawing.Point(241, 528)
        Me.txtStartDate.Name = "txtStartDate"
        Me.txtStartDate.Size = New System.Drawing.Size(100, 20)
        Me.txtStartDate.TabIndex = 21
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(556, 82)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(220, 85)
        Me.btnCalculate.TabIndex = 22
        Me.btnCalculate.Text = "How much land does it need?"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lbxPlants
        '
        Me.lbxPlants.FormattingEnabled = True
        Me.lbxPlants.Location = New System.Drawing.Point(566, 207)
        Me.lbxPlants.Name = "lbxPlants"
        Me.lbxPlants.Size = New System.Drawing.Size(210, 316)
        Me.lbxPlants.TabIndex = 23
        '
        'frmSharedHerbGarden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 625)
        Me.Controls.Add(Me.lbxPlants)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtStartDate)
        Me.Controls.Add(Me.txtSpacing)
        Me.Controls.Add(Me.cboUses)
        Me.Controls.Add(Me.txtParts)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.txtHabitat)
        Me.Controls.Add(Me.txtFamily)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.cboYear)
        Me.Controls.Add(Me.txtMember)
        Me.Controls.Add(Me.txtLatin)
        Me.Controls.Add(Me.lblStartDate)
        Me.Controls.Add(Me.lblSpacing)
        Me.Controls.Add(Me.lblUses)
        Me.Controls.Add(Me.lblParts)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblHabitat)
        Me.Controls.Add(Me.lblFamily)
        Me.Controls.Add(Me.lblNumOfPlants)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblMember)
        Me.Controls.Add(Me.lblLatin)
        Me.Name = "frmSharedHerbGarden"
        Me.Text = "Shared Herb Garden 2022"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLatin As Label
    Friend WithEvents lblMember As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblNumOfPlants As Label
    Friend WithEvents lblFamily As Label
    Friend WithEvents lblHabitat As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblParts As Label
    Friend WithEvents lblUses As Label
    Friend WithEvents lblSpacing As Label
    Friend WithEvents lblStartDate As Label
    Friend WithEvents txtLatin As TextBox
    Friend WithEvents txtMember As TextBox
    Friend WithEvents cboYear As ComboBox
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents txtFamily As TextBox
    Friend WithEvents txtHabitat As TextBox
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents txtParts As TextBox
    Friend WithEvents cboUses As ComboBox
    Friend WithEvents txtSpacing As TextBox
    Friend WithEvents txtStartDate As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lbxPlants As ListBox
End Class
