<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayroll
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCost = New System.Windows.Forms.Button()
        Me.lblFICACost = New System.Windows.Forms.Label()
        Me.lblFICA = New System.Windows.Forms.Label()
        Me.txtBiweeklyPay = New System.Windows.Forms.TextBox()
        Me.lblBiweeklyPay = New System.Windows.Forms.Label()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblFederal = New System.Windows.Forms.Label()
        Me.lblFederalCost = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblStateCost = New System.Windows.Forms.Label()
        Me.lblNetIncome = New System.Windows.Forms.Label()
        Me.lblNetCost = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DimGray
        Me.btnExit.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(254, 389)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(116, 48)
        Me.btnExit.TabIndex = 39
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DimGray
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(132, 389)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(116, 48)
        Me.btnClear.TabIndex = 38
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnCost
        '
        Me.btnCost.BackColor = System.Drawing.Color.DimGray
        Me.btnCost.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCost.Location = New System.Drawing.Point(10, 389)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(116, 48)
        Me.btnCost.TabIndex = 37
        Me.btnCost.Text = "Display Tax"
        Me.btnCost.UseVisualStyleBackColor = False
        '
        'lblFICACost
        '
        Me.lblFICACost.AutoSize = True
        Me.lblFICACost.BackColor = System.Drawing.Color.DimGray
        Me.lblFICACost.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFICACost.ForeColor = System.Drawing.Color.White
        Me.lblFICACost.Location = New System.Drawing.Point(233, 163)
        Me.lblFICACost.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblFICACost.Name = "lblFICACost"
        Me.lblFICACost.Size = New System.Drawing.Size(67, 19)
        Me.lblFICACost.TabIndex = 36
        Me.lblFICACost.Text = "$888.88"
        '
        'lblFICA
        '
        Me.lblFICA.AutoSize = True
        Me.lblFICA.BackColor = System.Drawing.Color.DimGray
        Me.lblFICA.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFICA.ForeColor = System.Drawing.Color.White
        Me.lblFICA.Location = New System.Drawing.Point(33, 163)
        Me.lblFICA.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblFICA.Name = "lblFICA"
        Me.lblFICA.Size = New System.Drawing.Size(138, 19)
        Me.lblFICA.TabIndex = 35
        Me.lblFICA.Text = "FICA tax (7.65%):"
        '
        'txtBiweeklyPay
        '
        Me.txtBiweeklyPay.BackColor = System.Drawing.Color.DimGray
        Me.txtBiweeklyPay.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBiweeklyPay.Location = New System.Drawing.Point(237, 119)
        Me.txtBiweeklyPay.Margin = New System.Windows.Forms.Padding(5)
        Me.txtBiweeklyPay.Name = "txtBiweeklyPay"
        Me.txtBiweeklyPay.Size = New System.Drawing.Size(63, 27)
        Me.txtBiweeklyPay.TabIndex = 34
        Me.txtBiweeklyPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblBiweeklyPay
        '
        Me.lblBiweeklyPay.AutoSize = True
        Me.lblBiweeklyPay.BackColor = System.Drawing.Color.DimGray
        Me.lblBiweeklyPay.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBiweeklyPay.ForeColor = System.Drawing.Color.White
        Me.lblBiweeklyPay.Location = New System.Drawing.Point(33, 119)
        Me.lblBiweeklyPay.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblBiweeklyPay.Name = "lblBiweeklyPay"
        Me.lblBiweeklyPay.Size = New System.Drawing.Size(194, 19)
        Me.lblBiweeklyPay.TabIndex = 33
        Me.lblBiweeklyPay.Text = "Enter Bi-Weekly Income:"
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.BackColor = System.Drawing.Color.DimGray
        Me.lblHeading.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.White
        Me.lblHeading.Location = New System.Drawing.Point(62, 55)
        Me.lblHeading.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(238, 27)
        Me.lblHeading.TabIndex = 31
        Me.lblHeading.Text = "Payroll Calculator"
        '
        'lblFederal
        '
        Me.lblFederal.AutoSize = True
        Me.lblFederal.BackColor = System.Drawing.Color.DimGray
        Me.lblFederal.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFederal.ForeColor = System.Drawing.Color.White
        Me.lblFederal.Location = New System.Drawing.Point(33, 201)
        Me.lblFederal.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblFederal.Name = "lblFederal"
        Me.lblFederal.Size = New System.Drawing.Size(148, 19)
        Me.lblFederal.TabIndex = 40
        Me.lblFederal.Text = "Federal tax (22%):"
        '
        'lblFederalCost
        '
        Me.lblFederalCost.AutoSize = True
        Me.lblFederalCost.BackColor = System.Drawing.Color.DimGray
        Me.lblFederalCost.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFederalCost.ForeColor = System.Drawing.Color.White
        Me.lblFederalCost.Location = New System.Drawing.Point(233, 201)
        Me.lblFederalCost.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblFederalCost.Name = "lblFederalCost"
        Me.lblFederalCost.Size = New System.Drawing.Size(67, 19)
        Me.lblFederalCost.TabIndex = 41
        Me.lblFederalCost.Text = "$888.88"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.BackColor = System.Drawing.Color.DimGray
        Me.lblState.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.ForeColor = System.Drawing.Color.White
        Me.lblState.Location = New System.Drawing.Point(33, 237)
        Me.lblState.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(117, 19)
        Me.lblState.TabIndex = 42
        Me.lblState.Text = "State tax (4%):"
        '
        'lblStateCost
        '
        Me.lblStateCost.AutoSize = True
        Me.lblStateCost.BackColor = System.Drawing.Color.DimGray
        Me.lblStateCost.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateCost.ForeColor = System.Drawing.Color.White
        Me.lblStateCost.Location = New System.Drawing.Point(233, 237)
        Me.lblStateCost.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblStateCost.Name = "lblStateCost"
        Me.lblStateCost.Size = New System.Drawing.Size(67, 19)
        Me.lblStateCost.TabIndex = 43
        Me.lblStateCost.Text = "$888.88"
        '
        'lblNetIncome
        '
        Me.lblNetIncome.AutoSize = True
        Me.lblNetIncome.BackColor = System.Drawing.Color.DimGray
        Me.lblNetIncome.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetIncome.ForeColor = System.Drawing.Color.White
        Me.lblNetIncome.Location = New System.Drawing.Point(33, 272)
        Me.lblNetIncome.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblNetIncome.Name = "lblNetIncome"
        Me.lblNetIncome.Size = New System.Drawing.Size(103, 19)
        Me.lblNetIncome.TabIndex = 44
        Me.lblNetIncome.Text = "Net income:"
        '
        'lblNetCost
        '
        Me.lblNetCost.AutoSize = True
        Me.lblNetCost.BackColor = System.Drawing.Color.DimGray
        Me.lblNetCost.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetCost.ForeColor = System.Drawing.Color.White
        Me.lblNetCost.Location = New System.Drawing.Point(233, 272)
        Me.lblNetCost.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblNetCost.Name = "lblNetCost"
        Me.lblNetCost.Size = New System.Drawing.Size(67, 19)
        Me.lblNetCost.TabIndex = 45
        Me.lblNetCost.Text = "$888.88"
        '
        'frmPayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(383, 450)
        Me.Controls.Add(Me.lblNetCost)
        Me.Controls.Add(Me.lblNetIncome)
        Me.Controls.Add(Me.lblStateCost)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblFederalCost)
        Me.Controls.Add(Me.lblFederal)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCost)
        Me.Controls.Add(Me.lblFICACost)
        Me.Controls.Add(Me.lblFICA)
        Me.Controls.Add(Me.txtBiweeklyPay)
        Me.Controls.Add(Me.lblBiweeklyPay)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmPayroll"
        Me.Text = "Payroll Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCost As Button
    Friend WithEvents lblFICACost As Label
    Friend WithEvents lblFICA As Label
    Friend WithEvents txtBiweeklyPay As TextBox
    Friend WithEvents lblBiweeklyPay As Label
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblFederal As Label
    Friend WithEvents lblFederalCost As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblStateCost As Label
    Friend WithEvents lblNetIncome As Label
    Friend WithEvents lblNetCost As Label
End Class
