<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNights = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNightlyCharge = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblRoomCharges = New System.Windows.Forms.Label()
        Me.lblAddCharges = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtRoomService = New System.Windows.Forms.TextBox()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.txtMisc = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblDateToday = New System.Windows.Forms.Label()
        Me.lblTimeToday = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(247, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Highlander Hotel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(397, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Today's Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(456, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Time:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(72, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nights"
        '
        'txtNights
        '
        Me.txtNights.Location = New System.Drawing.Point(150, 40)
        Me.txtNights.Name = "txtNights"
        Me.txtNights.Size = New System.Drawing.Size(100, 26)
        Me.txtNights.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Nightly Charges"
        '
        'txtNightlyCharge
        '
        Me.txtNightlyCharge.Location = New System.Drawing.Point(150, 97)
        Me.txtNightlyCharge.Name = "txtNightlyCharge"
        Me.txtNightlyCharge.Size = New System.Drawing.Size(100, 26)
        Me.txtNightlyCharge.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(38, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 20)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Room Charges"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 20)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Additional Charges"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(81, 106)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 20)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Subtotal:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(116, 148)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 20)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Tax:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(42, 190)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 20)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Total Charges:"
        '
        'lblRoomCharges
        '
        Me.lblRoomCharges.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblRoomCharges.Location = New System.Drawing.Point(183, 25)
        Me.lblRoomCharges.Name = "lblRoomCharges"
        Me.lblRoomCharges.Size = New System.Drawing.Size(100, 23)
        Me.lblRoomCharges.TabIndex = 14
        '
        'lblAddCharges
        '
        Me.lblAddCharges.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblAddCharges.Location = New System.Drawing.Point(183, 64)
        Me.lblAddCharges.Name = "lblAddCharges"
        Me.lblAddCharges.Size = New System.Drawing.Size(100, 23)
        Me.lblAddCharges.TabIndex = 15
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblSubtotal.Location = New System.Drawing.Point(183, 103)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(100, 23)
        Me.lblSubtotal.TabIndex = 16
        '
        'lblTax
        '
        Me.lblTax.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTax.Location = New System.Drawing.Point(183, 145)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(100, 23)
        Me.lblTax.TabIndex = 17
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTotal.Location = New System.Drawing.Point(183, 187)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 18
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 20)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Room Service "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(39, 75)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 20)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Telephone:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(82, 119)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 20)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Misc:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtNights)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtNightlyCharge)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 158)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(270, 154)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Room Information"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtMisc)
        Me.GroupBox2.Controls.Add(Me.txtTelephone)
        Me.GroupBox2.Controls.Add(Me.txtRoomService)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Location = New System.Drawing.Point(360, 158)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(269, 154)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Additional Charges"
        '
        'txtRoomService
        '
        Me.txtRoomService.Location = New System.Drawing.Point(148, 37)
        Me.txtRoomService.Name = "txtRoomService"
        Me.txtRoomService.Size = New System.Drawing.Size(100, 26)
        Me.txtRoomService.TabIndex = 23
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(148, 69)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(100, 26)
        Me.txtTelephone.TabIndex = 24
        '
        'txtMisc
        '
        Me.txtMisc.Location = New System.Drawing.Point(148, 112)
        Me.txtMisc.Name = "txtMisc"
        Me.txtMisc.Size = New System.Drawing.Size(100, 26)
        Me.txtMisc.TabIndex = 25
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.lblRoomCharges)
        Me.GroupBox3.Controls.Add(Me.lblAddCharges)
        Me.GroupBox3.Controls.Add(Me.lblSubtotal)
        Me.GroupBox3.Controls.Add(Me.lblTax)
        Me.GroupBox3.Controls.Add(Me.lblTotal)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(139, 335)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(330, 221)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Total Charges"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(40, 598)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(190, 39)
        Me.btnCalculate.TabIndex = 28
        Me.btnCalculate.Text = "Calculate Charges"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(251, 598)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(129, 39)
        Me.btnClear.TabIndex = 30
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(446, 598)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(129, 39)
        Me.btnExit.TabIndex = 31
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblDateToday
        '
        Me.lblDateToday.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblDateToday.Location = New System.Drawing.Point(534, 59)
        Me.lblDateToday.Name = "lblDateToday"
        Me.lblDateToday.Size = New System.Drawing.Size(151, 23)
        Me.lblDateToday.TabIndex = 32
        '
        'lblTimeToday
        '
        Me.lblTimeToday.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblTimeToday.Location = New System.Drawing.Point(534, 94)
        Me.lblTimeToday.Name = "lblTimeToday"
        Me.lblTimeToday.Size = New System.Drawing.Size(151, 23)
        Me.lblTimeToday.TabIndex = 33
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 682)
        Me.Controls.Add(Me.lblTimeToday)
        Me.Controls.Add(Me.lblDateToday)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Room Charge Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNights As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNightlyCharge As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblRoomCharges As System.Windows.Forms.Label
    Friend WithEvents lblAddCharges As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtMisc As TextBox
    Friend WithEvents txtTelephone As TextBox
    Friend WithEvents txtRoomService As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblDateToday As Label
    Friend WithEvents lblTimeToday As Label
End Class
