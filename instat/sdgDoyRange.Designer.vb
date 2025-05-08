<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgDoyRange
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
        Me.rdoFromFixed = New System.Windows.Forms.RadioButton()
        Me.rdoFromVariable = New System.Windows.Forms.RadioButton()
        Me.grpFrom = New System.Windows.Forms.GroupBox()
        Me.ucrReceiverFrom = New instat.ucrReceiverSingle()
        Me.ucrDoyFrom = New instat.ucrDayOfYear()
        Me.ucrPnlFrom = New instat.UcrPanel()
        Me.grpTo = New System.Windows.Forms.GroupBox()
        Me.lblToDays = New System.Windows.Forms.Label()
        Me.ucrNudToDiff = New instat.ucrNud()
        Me.lblToPlus = New System.Windows.Forms.Label()
        Me.rdoLength = New System.Windows.Forms.RadioButton()
        Me.ucrReceiverTo = New instat.ucrReceiverSingle()
        Me.ucrDoyTo = New instat.ucrDayOfYear()
        Me.rdoToVariable = New System.Windows.Forms.RadioButton()
        Me.rdoToFixed = New System.Windows.Forms.RadioButton()
        Me.ucrPnlTo = New instat.UcrPanel()
        Me.ucrSelectorDoy = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBaseSub = New instat.ucrButtonsSubdialogue()
        Me.grpDateFrom = New System.Windows.Forms.GroupBox()
        Me.lblToDate = New System.Windows.Forms.Label()
        Me.ucrNudDateTo = New instat.ucrNud()
        Me.lblDatePlusTo = New System.Windows.Forms.Label()
        Me.rdoDateLenghtTo = New System.Windows.Forms.RadioButton()
        Me.ucrReceiverVarDateTo = New instat.ucrReceiverSingle()
        Me.rdoVarDateTo = New System.Windows.Forms.RadioButton()
        Me.rdoFixedDateTo = New System.Windows.Forms.RadioButton()
        Me.ucrPnlDateTo = New instat.UcrPanel()
        Me.ucrReceiverFixedDateTo = New instat.ucrDateTimePicker()
        Me.grpDateTo = New System.Windows.Forms.GroupBox()
        Me.ucrFixedDateFrom = New instat.ucrDateTimePicker()
        Me.ucrRecieverVarDate = New instat.ucrReceiverSingle()
        Me.rdoVarDateFrom = New System.Windows.Forms.RadioButton()
        Me.rdoFixedDateFrom = New System.Windows.Forms.RadioButton()
        Me.ucrPnlDateFrom = New instat.UcrPanel()
        Me.grpFrom.SuspendLayout()
        Me.grpTo.SuspendLayout()
        Me.grpDateFrom.SuspendLayout()
        Me.grpDateTo.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoFromFixed
        '
        Me.rdoFromFixed.AutoSize = True
        Me.rdoFromFixed.Location = New System.Drawing.Point(45, 32)
        Me.rdoFromFixed.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoFromFixed.Name = "rdoFromFixed"
        Me.rdoFromFixed.Size = New System.Drawing.Size(89, 20)
        Me.rdoFromFixed.TabIndex = 1
        Me.rdoFromFixed.TabStop = True
        Me.rdoFromFixed.Text = "Fixed Day"
        Me.rdoFromFixed.UseVisualStyleBackColor = True
        '
        'rdoFromVariable
        '
        Me.rdoFromVariable.AutoSize = True
        Me.rdoFromVariable.Location = New System.Drawing.Point(150, 32)
        Me.rdoFromVariable.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoFromVariable.Name = "rdoFromVariable"
        Me.rdoFromVariable.Size = New System.Drawing.Size(107, 20)
        Me.rdoFromVariable.TabIndex = 2
        Me.rdoFromVariable.TabStop = True
        Me.rdoFromVariable.Text = "Variable Day"
        Me.rdoFromVariable.UseVisualStyleBackColor = True
        '
        'grpFrom
        '
        Me.grpFrom.Controls.Add(Me.ucrReceiverFrom)
        Me.grpFrom.Controls.Add(Me.ucrDoyFrom)
        Me.grpFrom.Controls.Add(Me.rdoFromVariable)
        Me.grpFrom.Controls.Add(Me.rdoFromFixed)
        Me.grpFrom.Controls.Add(Me.ucrPnlFrom)
        Me.grpFrom.Location = New System.Drawing.Point(12, 267)
        Me.grpFrom.Margin = New System.Windows.Forms.Padding(4)
        Me.grpFrom.Name = "grpFrom"
        Me.grpFrom.Padding = New System.Windows.Forms.Padding(4)
        Me.grpFrom.Size = New System.Drawing.Size(318, 129)
        Me.grpFrom.TabIndex = 1
        Me.grpFrom.TabStop = False
        Me.grpFrom.Text = "From"
        '
        'ucrReceiverFrom
        '
        Me.ucrReceiverFrom.AutoSize = True
        Me.ucrReceiverFrom.frmParent = Me
        Me.ucrReceiverFrom.Location = New System.Drawing.Point(45, 85)
        Me.ucrReceiverFrom.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFrom.Name = "ucrReceiverFrom"
        Me.ucrReceiverFrom.Selector = Nothing
        Me.ucrReceiverFrom.Size = New System.Drawing.Size(155, 25)
        Me.ucrReceiverFrom.strNcFilePath = ""
        Me.ucrReceiverFrom.TabIndex = 5
        Me.ucrReceiverFrom.ucrSelector = Nothing
        '
        'ucrDoyFrom
        '
        Me.ucrDoyFrom.AutoSize = True
        Me.ucrDoyFrom.Location = New System.Drawing.Point(45, 84)
        Me.ucrDoyFrom.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrDoyFrom.Name = "ucrDoyFrom"
        Me.ucrDoyFrom.Size = New System.Drawing.Size(261, 42)
        Me.ucrDoyFrom.TabIndex = 5
        '
        'ucrPnlFrom
        '
        Me.ucrPnlFrom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlFrom.Location = New System.Drawing.Point(35, 21)
        Me.ucrPnlFrom.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrPnlFrom.Name = "ucrPnlFrom"
        Me.ucrPnlFrom.Size = New System.Drawing.Size(232, 45)
        Me.ucrPnlFrom.TabIndex = 3
        '
        'grpTo
        '
        Me.grpTo.Controls.Add(Me.lblToDays)
        Me.grpTo.Controls.Add(Me.ucrNudToDiff)
        Me.grpTo.Controls.Add(Me.lblToPlus)
        Me.grpTo.Controls.Add(Me.rdoLength)
        Me.grpTo.Controls.Add(Me.ucrReceiverTo)
        Me.grpTo.Controls.Add(Me.ucrDoyTo)
        Me.grpTo.Controls.Add(Me.rdoToVariable)
        Me.grpTo.Controls.Add(Me.rdoToFixed)
        Me.grpTo.Controls.Add(Me.ucrPnlTo)
        Me.grpTo.Location = New System.Drawing.Point(336, 267)
        Me.grpTo.Margin = New System.Windows.Forms.Padding(4)
        Me.grpTo.Name = "grpTo"
        Me.grpTo.Padding = New System.Windows.Forms.Padding(4)
        Me.grpTo.Size = New System.Drawing.Size(392, 129)
        Me.grpTo.TabIndex = 2
        Me.grpTo.TabStop = False
        Me.grpTo.Text = "To"
        '
        'lblToDays
        '
        Me.lblToDays.AutoSize = True
        Me.lblToDays.BackColor = System.Drawing.Color.Transparent
        Me.lblToDays.Location = New System.Drawing.Point(128, 90)
        Me.lblToDays.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblToDays.Name = "lblToDays"
        Me.lblToDays.Size = New System.Drawing.Size(37, 16)
        Me.lblToDays.TabIndex = 9
        Me.lblToDays.Text = "days"
        '
        'ucrNudToDiff
        '
        Me.ucrNudToDiff.AutoSize = True
        Me.ucrNudToDiff.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudToDiff.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudToDiff.Location = New System.Drawing.Point(62, 85)
        Me.ucrNudToDiff.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrNudToDiff.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudToDiff.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudToDiff.Name = "ucrNudToDiff"
        Me.ucrNudToDiff.Size = New System.Drawing.Size(62, 25)
        Me.ucrNudToDiff.TabIndex = 7
        Me.ucrNudToDiff.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblToPlus
        '
        Me.lblToPlus.AutoSize = True
        Me.lblToPlus.BackColor = System.Drawing.Color.Transparent
        Me.lblToPlus.Location = New System.Drawing.Point(20, 90)
        Me.lblToPlus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblToPlus.Name = "lblToPlus"
        Me.lblToPlus.Size = New System.Drawing.Size(36, 16)
        Me.lblToPlus.TabIndex = 8
        Me.lblToPlus.Text = "Plus:"
        '
        'rdoLength
        '
        Me.rdoLength.AutoSize = True
        Me.rdoLength.Location = New System.Drawing.Point(236, 35)
        Me.rdoLength.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoLength.Name = "rdoLength"
        Me.rdoLength.Size = New System.Drawing.Size(68, 20)
        Me.rdoLength.TabIndex = 6
        Me.rdoLength.TabStop = True
        Me.rdoLength.Text = "Length"
        Me.rdoLength.UseVisualStyleBackColor = True
        '
        'ucrReceiverTo
        '
        Me.ucrReceiverTo.AutoSize = True
        Me.ucrReceiverTo.frmParent = Me
        Me.ucrReceiverTo.Location = New System.Drawing.Point(18, 84)
        Me.ucrReceiverTo.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTo.Name = "ucrReceiverTo"
        Me.ucrReceiverTo.Selector = Nothing
        Me.ucrReceiverTo.Size = New System.Drawing.Size(150, 25)
        Me.ucrReceiverTo.strNcFilePath = ""
        Me.ucrReceiverTo.TabIndex = 5
        Me.ucrReceiverTo.ucrSelector = Nothing
        '
        'ucrDoyTo
        '
        Me.ucrDoyTo.AutoSize = True
        Me.ucrDoyTo.Location = New System.Drawing.Point(20, 84)
        Me.ucrDoyTo.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrDoyTo.Name = "ucrDoyTo"
        Me.ucrDoyTo.Size = New System.Drawing.Size(261, 42)
        Me.ucrDoyTo.TabIndex = 5
        '
        'rdoToVariable
        '
        Me.rdoToVariable.AutoSize = True
        Me.rdoToVariable.Location = New System.Drawing.Point(122, 35)
        Me.rdoToVariable.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoToVariable.Name = "rdoToVariable"
        Me.rdoToVariable.Size = New System.Drawing.Size(107, 20)
        Me.rdoToVariable.TabIndex = 2
        Me.rdoToVariable.TabStop = True
        Me.rdoToVariable.Text = "Variable Day"
        Me.rdoToVariable.UseVisualStyleBackColor = True
        '
        'rdoToFixed
        '
        Me.rdoToFixed.AutoSize = True
        Me.rdoToFixed.Location = New System.Drawing.Point(20, 35)
        Me.rdoToFixed.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoToFixed.Name = "rdoToFixed"
        Me.rdoToFixed.Size = New System.Drawing.Size(89, 20)
        Me.rdoToFixed.TabIndex = 1
        Me.rdoToFixed.TabStop = True
        Me.rdoToFixed.Text = "Fixed Day"
        Me.rdoToFixed.UseVisualStyleBackColor = True
        '
        'ucrPnlTo
        '
        Me.ucrPnlTo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlTo.Location = New System.Drawing.Point(8, 21)
        Me.ucrPnlTo.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrPnlTo.Name = "ucrPnlTo"
        Me.ucrPnlTo.Size = New System.Drawing.Size(369, 45)
        Me.ucrPnlTo.TabIndex = 3
        '
        'ucrSelectorDoy
        '
        Me.ucrSelectorDoy.AutoSize = True
        Me.ucrSelectorDoy.bDropUnusedFilterLevels = False
        Me.ucrSelectorDoy.bShowHiddenColumns = False
        Me.ucrSelectorDoy.bUseCurrentFilter = True
        Me.ucrSelectorDoy.Location = New System.Drawing.Point(12, 11)
        Me.ucrSelectorDoy.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDoy.Name = "ucrSelectorDoy"
        Me.ucrSelectorDoy.Size = New System.Drawing.Size(266, 229)
        Me.ucrSelectorDoy.TabIndex = 0
        '
        'ucrBaseSub
        '
        Me.ucrBaseSub.AutoSize = True
        Me.ucrBaseSub.Location = New System.Drawing.Point(231, 405)
        Me.ucrBaseSub.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrBaseSub.Name = "ucrBaseSub"
        Me.ucrBaseSub.Size = New System.Drawing.Size(281, 38)
        Me.ucrBaseSub.TabIndex = 3
        '
        'grpDateFrom
        '
        Me.grpDateFrom.Controls.Add(Me.lblToDate)
        Me.grpDateFrom.Controls.Add(Me.ucrNudDateTo)
        Me.grpDateFrom.Controls.Add(Me.lblDatePlusTo)
        Me.grpDateFrom.Controls.Add(Me.rdoDateLenghtTo)
        Me.grpDateFrom.Controls.Add(Me.ucrReceiverVarDateTo)
        Me.grpDateFrom.Controls.Add(Me.rdoVarDateTo)
        Me.grpDateFrom.Controls.Add(Me.rdoFixedDateTo)
        Me.grpDateFrom.Controls.Add(Me.ucrPnlDateTo)
        Me.grpDateFrom.Controls.Add(Me.ucrReceiverFixedDateTo)
        Me.grpDateFrom.Location = New System.Drawing.Point(410, 147)
        Me.grpDateFrom.Margin = New System.Windows.Forms.Padding(4)
        Me.grpDateFrom.Name = "grpDateFrom"
        Me.grpDateFrom.Padding = New System.Windows.Forms.Padding(4)
        Me.grpDateFrom.Size = New System.Drawing.Size(318, 129)
        Me.grpDateFrom.TabIndex = 5
        Me.grpDateFrom.TabStop = False
        Me.grpDateFrom.Text = "To"
        '
        'lblToDate
        '
        Me.lblToDate.AutoSize = True
        Me.lblToDate.BackColor = System.Drawing.Color.Transparent
        Me.lblToDate.Location = New System.Drawing.Point(128, 90)
        Me.lblToDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblToDate.Name = "lblToDate"
        Me.lblToDate.Size = New System.Drawing.Size(37, 16)
        Me.lblToDate.TabIndex = 9
        Me.lblToDate.Text = "days"
        '
        'ucrNudDateTo
        '
        Me.ucrNudDateTo.AutoSize = True
        Me.ucrNudDateTo.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDateTo.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDateTo.Location = New System.Drawing.Point(62, 85)
        Me.ucrNudDateTo.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrNudDateTo.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDateTo.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDateTo.Name = "ucrNudDateTo"
        Me.ucrNudDateTo.Size = New System.Drawing.Size(62, 25)
        Me.ucrNudDateTo.TabIndex = 7
        Me.ucrNudDateTo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblDatePlusTo
        '
        Me.lblDatePlusTo.AutoSize = True
        Me.lblDatePlusTo.BackColor = System.Drawing.Color.Transparent
        Me.lblDatePlusTo.Location = New System.Drawing.Point(20, 90)
        Me.lblDatePlusTo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDatePlusTo.Name = "lblDatePlusTo"
        Me.lblDatePlusTo.Size = New System.Drawing.Size(36, 16)
        Me.lblDatePlusTo.TabIndex = 8
        Me.lblDatePlusTo.Text = "Plus:"
        '
        'rdoDateLenghtTo
        '
        Me.rdoDateLenghtTo.AutoSize = True
        Me.rdoDateLenghtTo.Location = New System.Drawing.Point(236, 35)
        Me.rdoDateLenghtTo.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoDateLenghtTo.Name = "rdoDateLenghtTo"
        Me.rdoDateLenghtTo.Size = New System.Drawing.Size(68, 20)
        Me.rdoDateLenghtTo.TabIndex = 6
        Me.rdoDateLenghtTo.TabStop = True
        Me.rdoDateLenghtTo.Text = "Length"
        Me.rdoDateLenghtTo.UseVisualStyleBackColor = True
        '
        'ucrReceiverVarDateTo
        '
        Me.ucrReceiverVarDateTo.AutoSize = True
        Me.ucrReceiverVarDateTo.frmParent = Me
        Me.ucrReceiverVarDateTo.Location = New System.Drawing.Point(18, 84)
        Me.ucrReceiverVarDateTo.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverVarDateTo.Name = "ucrReceiverVarDateTo"
        Me.ucrReceiverVarDateTo.Selector = Nothing
        Me.ucrReceiverVarDateTo.Size = New System.Drawing.Size(150, 25)
        Me.ucrReceiverVarDateTo.strNcFilePath = ""
        Me.ucrReceiverVarDateTo.TabIndex = 5
        Me.ucrReceiverVarDateTo.ucrSelector = Nothing
        '
        'rdoVarDateTo
        '
        Me.rdoVarDateTo.AutoSize = True
        Me.rdoVarDateTo.Location = New System.Drawing.Point(122, 35)
        Me.rdoVarDateTo.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoVarDateTo.Name = "rdoVarDateTo"
        Me.rdoVarDateTo.Size = New System.Drawing.Size(107, 20)
        Me.rdoVarDateTo.TabIndex = 2
        Me.rdoVarDateTo.TabStop = True
        Me.rdoVarDateTo.Text = "Variable Day"
        Me.rdoVarDateTo.UseVisualStyleBackColor = True
        '
        'rdoFixedDateTo
        '
        Me.rdoFixedDateTo.AutoSize = True
        Me.rdoFixedDateTo.Location = New System.Drawing.Point(20, 35)
        Me.rdoFixedDateTo.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoFixedDateTo.Name = "rdoFixedDateTo"
        Me.rdoFixedDateTo.Size = New System.Drawing.Size(93, 20)
        Me.rdoFixedDateTo.TabIndex = 1
        Me.rdoFixedDateTo.TabStop = True
        Me.rdoFixedDateTo.Text = "Fixed Date"
        Me.rdoFixedDateTo.UseVisualStyleBackColor = True
        '
        'ucrPnlDateTo
        '
        Me.ucrPnlDateTo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlDateTo.Location = New System.Drawing.Point(8, 21)
        Me.ucrPnlDateTo.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrPnlDateTo.Name = "ucrPnlDateTo"
        Me.ucrPnlDateTo.Size = New System.Drawing.Size(301, 45)
        Me.ucrPnlDateTo.TabIndex = 3
        '
        'ucrReceiverFixedDateTo
        '
        Me.ucrReceiverFixedDateTo.AutoSize = True
        Me.ucrReceiverFixedDateTo.DateValue = New Date(2025, 5, 8, 14, 17, 11, 255)
        Me.ucrReceiverFixedDateTo.Format = "dd MMM yyyy"
        Me.ucrReceiverFixedDateTo.Location = New System.Drawing.Point(105, 83)
        Me.ucrReceiverFixedDateTo.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrReceiverFixedDateTo.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrReceiverFixedDateTo.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrReceiverFixedDateTo.Name = "ucrReceiverFixedDateTo"
        Me.ucrReceiverFixedDateTo.Size = New System.Drawing.Size(152, 26)
        Me.ucrReceiverFixedDateTo.TabIndex = 10
        '
        'grpDateTo
        '
        Me.grpDateTo.Controls.Add(Me.ucrFixedDateFrom)
        Me.grpDateTo.Controls.Add(Me.ucrRecieverVarDate)
        Me.grpDateTo.Controls.Add(Me.rdoVarDateFrom)
        Me.grpDateTo.Controls.Add(Me.rdoFixedDateFrom)
        Me.grpDateTo.Controls.Add(Me.ucrPnlDateFrom)
        Me.grpDateTo.Location = New System.Drawing.Point(410, 11)
        Me.grpDateTo.Margin = New System.Windows.Forms.Padding(4)
        Me.grpDateTo.Name = "grpDateTo"
        Me.grpDateTo.Padding = New System.Windows.Forms.Padding(4)
        Me.grpDateTo.Size = New System.Drawing.Size(318, 129)
        Me.grpDateTo.TabIndex = 4
        Me.grpDateTo.TabStop = False
        Me.grpDateTo.Text = "From"
        '
        'ucrFixedDateFrom
        '
        Me.ucrFixedDateFrom.AutoSize = True
        Me.ucrFixedDateFrom.DateValue = New Date(2025, 5, 8, 14, 17, 11, 255)
        Me.ucrFixedDateFrom.Format = "dd MMM yyyy"
        Me.ucrFixedDateFrom.Location = New System.Drawing.Point(67, 83)
        Me.ucrFixedDateFrom.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrFixedDateFrom.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrFixedDateFrom.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrFixedDateFrom.Name = "ucrFixedDateFrom"
        Me.ucrFixedDateFrom.Size = New System.Drawing.Size(152, 26)
        Me.ucrFixedDateFrom.TabIndex = 6
        '
        'ucrRecieverVarDate
        '
        Me.ucrRecieverVarDate.AutoSize = True
        Me.ucrRecieverVarDate.frmParent = Me
        Me.ucrRecieverVarDate.Location = New System.Drawing.Point(45, 85)
        Me.ucrRecieverVarDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrRecieverVarDate.Name = "ucrRecieverVarDate"
        Me.ucrRecieverVarDate.Selector = Nothing
        Me.ucrRecieverVarDate.Size = New System.Drawing.Size(155, 25)
        Me.ucrRecieverVarDate.strNcFilePath = ""
        Me.ucrRecieverVarDate.TabIndex = 5
        Me.ucrRecieverVarDate.ucrSelector = Nothing
        '
        'rdoVarDateFrom
        '
        Me.rdoVarDateFrom.AutoSize = True
        Me.rdoVarDateFrom.Location = New System.Drawing.Point(150, 32)
        Me.rdoVarDateFrom.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoVarDateFrom.Name = "rdoVarDateFrom"
        Me.rdoVarDateFrom.Size = New System.Drawing.Size(111, 20)
        Me.rdoVarDateFrom.TabIndex = 2
        Me.rdoVarDateFrom.TabStop = True
        Me.rdoVarDateFrom.Text = "Variable Date"
        Me.rdoVarDateFrom.UseVisualStyleBackColor = True
        '
        'rdoFixedDateFrom
        '
        Me.rdoFixedDateFrom.AutoSize = True
        Me.rdoFixedDateFrom.Location = New System.Drawing.Point(45, 32)
        Me.rdoFixedDateFrom.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoFixedDateFrom.Name = "rdoFixedDateFrom"
        Me.rdoFixedDateFrom.Size = New System.Drawing.Size(93, 20)
        Me.rdoFixedDateFrom.TabIndex = 1
        Me.rdoFixedDateFrom.TabStop = True
        Me.rdoFixedDateFrom.Text = "Fixed Date"
        Me.rdoFixedDateFrom.UseVisualStyleBackColor = True
        '
        'ucrPnlDateFrom
        '
        Me.ucrPnlDateFrom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlDateFrom.Location = New System.Drawing.Point(35, 21)
        Me.ucrPnlDateFrom.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrPnlDateFrom.Name = "ucrPnlDateFrom"
        Me.ucrPnlDateFrom.Size = New System.Drawing.Size(232, 45)
        Me.ucrPnlDateFrom.TabIndex = 3
        '
        'sdgDoyRange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(734, 446)
        Me.Controls.Add(Me.grpDateFrom)
        Me.Controls.Add(Me.grpDateTo)
        Me.Controls.Add(Me.grpTo)
        Me.Controls.Add(Me.ucrSelectorDoy)
        Me.Controls.Add(Me.grpFrom)
        Me.Controls.Add(Me.ucrBaseSub)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgDoyRange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Select Day of Year Range"
        Me.grpFrom.ResumeLayout(False)
        Me.grpFrom.PerformLayout()
        Me.grpTo.ResumeLayout(False)
        Me.grpTo.PerformLayout()
        Me.grpDateFrom.ResumeLayout(False)
        Me.grpDateFrom.PerformLayout()
        Me.grpDateTo.ResumeLayout(False)
        Me.grpDateTo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseSub As ucrButtonsSubdialogue
    Friend WithEvents rdoFromFixed As RadioButton
    Friend WithEvents rdoFromVariable As RadioButton
    Friend WithEvents ucrPnlFrom As UcrPanel
    Friend WithEvents grpFrom As GroupBox
    Friend WithEvents ucrReceiverFrom As ucrReceiverSingle
    Friend WithEvents grpTo As GroupBox
    Friend WithEvents ucrNudToDiff As ucrNud
    Friend WithEvents lblToPlus As Label
    Friend WithEvents rdoLength As RadioButton
    Friend WithEvents ucrReceiverTo As ucrReceiverSingle
    Friend WithEvents ucrDoyTo As ucrDayOfYear
    Friend WithEvents rdoToVariable As RadioButton
    Friend WithEvents rdoToFixed As RadioButton
    Friend WithEvents ucrPnlTo As UcrPanel
    Friend WithEvents ucrSelectorDoy As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrDoyFrom As ucrDayOfYear
    Friend WithEvents lblToDays As Label
    Friend WithEvents grpDateFrom As GroupBox
    Friend WithEvents lblToDate As Label
    Friend WithEvents ucrNudDateTo As ucrNud
    Friend WithEvents lblDatePlusTo As Label
    Friend WithEvents rdoDateLenghtTo As RadioButton
    Friend WithEvents ucrReceiverVarDateTo As ucrReceiverSingle
    Friend WithEvents rdoVarDateTo As RadioButton
    Friend WithEvents rdoFixedDateTo As RadioButton
    Friend WithEvents ucrPnlDateTo As UcrPanel
    Friend WithEvents grpDateTo As GroupBox
    Friend WithEvents ucrRecieverVarDate As ucrReceiverSingle
    Friend WithEvents rdoVarDateFrom As RadioButton
    Friend WithEvents rdoFixedDateFrom As RadioButton
    Friend WithEvents ucrPnlDateFrom As UcrPanel
    Friend WithEvents ucrReceiverFixedDateTo As ucrDateTimePicker
    Friend WithEvents ucrFixedDateFrom As ucrDateTimePicker
End Class
