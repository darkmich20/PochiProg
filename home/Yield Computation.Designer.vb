<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmhome
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
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.lbl_1stload = New System.Windows.Forms.Label()
        Me.lbl_1stRload = New System.Windows.Forms.Label()
        Me.lbl_2ndRload = New System.Windows.Forms.Label()
        Me.lbl_tb1 = New System.Windows.Forms.Label()
        Me.lbl_totalrjs = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_qty4 = New System.Windows.Forms.Label()
        Me.lblTB = New System.Windows.Forms.Label()
        Me.lblTR = New System.Windows.Forms.Label()
        Me.lblFY = New System.Windows.Forms.Label()
        Me.lbl_qty1 = New System.Windows.Forms.Label()
        Me.lbl_qty2 = New System.Windows.Forms.Label()
        Me.lbl_qty3 = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.lbl_bSummary = New System.Windows.Forms.Label()
        Me.lbl_reject = New System.Windows.Forms.Label()
        Me.lbl_hloss = New System.Windows.Forms.Label()
        Me.lbl_Mssngunits = New System.Windows.Forms.Label()
        Me.lbl_actualBin = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl2RAB = New System.Windows.Forms.Label()
        Me.lbl1RAB = New System.Windows.Forms.Label()
        Me.txt2MU = New System.Windows.Forms.TextBox()
        Me.txt2RHL = New System.Windows.Forms.TextBox()
        Me.txt2RR = New System.Windows.Forms.TextBox()
        Me.txt2RB = New System.Windows.Forms.TextBox()
        Me.txt1RMU = New System.Windows.Forms.TextBox()
        Me.txt1RHL = New System.Windows.Forms.TextBox()
        Me.txt1RR = New System.Windows.Forms.TextBox()
        Me.txt1RB = New System.Windows.Forms.TextBox()
        Me.txt1LMU = New System.Windows.Forms.TextBox()
        Me.txt1LHL = New System.Windows.Forms.TextBox()
        Me.txt1LR = New System.Windows.Forms.TextBox()
        Me.txt1LB = New System.Windows.Forms.TextBox()
        Me.lblAB1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lbllot = New System.Windows.Forms.Label()
        Me.txtlot = New System.Windows.Forms.TextBox()
        Me.txtDevice = New System.Windows.Forms.TextBox()
        Me.lbldev = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.clockUpdater = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_title.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.White
        Me.lbl_title.Location = New System.Drawing.Point(172, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(827, 58)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "RE-SCREEN YIELD COMPUTATION"
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.Location = New System.Drawing.Point(846, 89)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(62, 19)
        Me.lbl_date.TabIndex = 1
        Me.lbl_date.Text = "DATE :"
        '
        'lbl_1stload
        '
        Me.lbl_1stload.AutoSize = True
        Me.lbl_1stload.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_1stload.Location = New System.Drawing.Point(167, 116)
        Me.lbl_1stload.Name = "lbl_1stload"
        Me.lbl_1stload.Size = New System.Drawing.Size(75, 19)
        Me.lbl_1stload.TabIndex = 12
        Me.lbl_1stload.Text = "1st Load"
        '
        'lbl_1stRload
        '
        Me.lbl_1stRload.AutoSize = True
        Me.lbl_1stRload.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_1stRload.Location = New System.Drawing.Point(298, 116)
        Me.lbl_1stRload.Name = "lbl_1stRload"
        Me.lbl_1stRload.Size = New System.Drawing.Size(90, 19)
        Me.lbl_1stRload.TabIndex = 13
        Me.lbl_1stRload.Text = "1st Reload"
        '
        'lbl_2ndRload
        '
        Me.lbl_2ndRload.AutoSize = True
        Me.lbl_2ndRload.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_2ndRload.Location = New System.Drawing.Point(446, 116)
        Me.lbl_2ndRload.Name = "lbl_2ndRload"
        Me.lbl_2ndRload.Size = New System.Drawing.Size(96, 19)
        Me.lbl_2ndRload.TabIndex = 14
        Me.lbl_2ndRload.Text = "2nd Reload"
        '
        'lbl_tb1
        '
        Me.lbl_tb1.AutoSize = True
        Me.lbl_tb1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tb1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_tb1.Location = New System.Drawing.Point(26, 110)
        Me.lbl_tb1.Name = "lbl_tb1"
        Me.lbl_tb1.Size = New System.Drawing.Size(99, 19)
        Me.lbl_tb1.TabIndex = 15
        Me.lbl_tb1.Text = "Total Bin 1 :"
        '
        'lbl_totalrjs
        '
        Me.lbl_totalrjs.AutoSize = True
        Me.lbl_totalrjs.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalrjs.Location = New System.Drawing.Point(6, 168)
        Me.lbl_totalrjs.Name = "lbl_totalrjs"
        Me.lbl_totalrjs.Size = New System.Drawing.Size(121, 19)
        Me.lbl_totalrjs.TabIndex = 16
        Me.lbl_totalrjs.Text = "Total Reject/s :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(-3, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 38)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Final Re-Screen" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       Yield : "
        '
        'lbl_qty4
        '
        Me.lbl_qty4.AutoSize = True
        Me.lbl_qty4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_qty4.Location = New System.Drawing.Point(184, 49)
        Me.lbl_qty4.Name = "lbl_qty4"
        Me.lbl_qty4.Size = New System.Drawing.Size(35, 19)
        Me.lbl_qty4.TabIndex = 18
        Me.lbl_qty4.Text = "Qty"
        '
        'lblTB
        '
        Me.lblTB.AutoSize = True
        Me.lblTB.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTB.Location = New System.Drawing.Point(60, 23)
        Me.lblTB.Name = "lblTB"
        Me.lblTB.Size = New System.Drawing.Size(18, 19)
        Me.lblTB.TabIndex = 19
        Me.lblTB.Text = "0"
        '
        'lblTR
        '
        Me.lblTR.AutoSize = True
        Me.lblTR.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTR.Location = New System.Drawing.Point(58, 20)
        Me.lblTR.Name = "lblTR"
        Me.lblTR.Size = New System.Drawing.Size(18, 19)
        Me.lblTR.TabIndex = 20
        Me.lblTR.Text = "0"
        '
        'lblFY
        '
        Me.lblFY.AutoSize = True
        Me.lblFY.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFY.Location = New System.Drawing.Point(55, 28)
        Me.lblFY.Name = "lblFY"
        Me.lblFY.Size = New System.Drawing.Size(18, 19)
        Me.lblFY.TabIndex = 21
        Me.lblFY.Text = "0"
        '
        'lbl_qty1
        '
        Me.lbl_qty1.AutoSize = True
        Me.lbl_qty1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_qty1.Location = New System.Drawing.Point(187, 132)
        Me.lbl_qty1.Name = "lbl_qty1"
        Me.lbl_qty1.Size = New System.Drawing.Size(29, 16)
        Me.lbl_qty1.TabIndex = 22
        Me.lbl_qty1.Text = "Qty"
        '
        'lbl_qty2
        '
        Me.lbl_qty2.AutoSize = True
        Me.lbl_qty2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_qty2.Location = New System.Drawing.Point(332, 135)
        Me.lbl_qty2.Name = "lbl_qty2"
        Me.lbl_qty2.Size = New System.Drawing.Size(29, 16)
        Me.lbl_qty2.TabIndex = 23
        Me.lbl_qty2.Text = "Qty"
        '
        'lbl_qty3
        '
        Me.lbl_qty3.AutoSize = True
        Me.lbl_qty3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_qty3.Location = New System.Drawing.Point(475, 135)
        Me.lbl_qty3.Name = "lbl_qty3"
        Me.lbl_qty3.Size = New System.Drawing.Size(29, 16)
        Me.lbl_qty3.TabIndex = 24
        Me.lbl_qty3.Text = "Qty"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(930, 89)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(69, 19)
        Me.lbldate.TabIndex = 27
        Me.lbldate.Text = "Label16"
        '
        'lbl_bSummary
        '
        Me.lbl_bSummary.AutoSize = True
        Me.lbl_bSummary.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bSummary.Location = New System.Drawing.Point(6, 154)
        Me.lbl_bSummary.Name = "lbl_bSummary"
        Me.lbl_bSummary.Size = New System.Drawing.Size(135, 19)
        Me.lbl_bSummary.TabIndex = 28
        Me.lbl_bSummary.Text = "Bin 1 Summary :"
        '
        'lbl_reject
        '
        Me.lbl_reject.AutoSize = True
        Me.lbl_reject.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_reject.Location = New System.Drawing.Point(62, 198)
        Me.lbl_reject.Name = "lbl_reject"
        Me.lbl_reject.Size = New System.Drawing.Size(76, 19)
        Me.lbl_reject.TabIndex = 29
        Me.lbl_reject.Text = "Rejects :"
        '
        'lbl_hloss
        '
        Me.lbl_hloss.AutoSize = True
        Me.lbl_hloss.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hloss.Location = New System.Drawing.Point(20, 236)
        Me.lbl_hloss.Name = "lbl_hloss"
        Me.lbl_hloss.Size = New System.Drawing.Size(121, 19)
        Me.lbl_hloss.TabIndex = 30
        Me.lbl_hloss.Text = "Handler Loss :"
        '
        'lbl_Mssngunits
        '
        Me.lbl_Mssngunits.AutoSize = True
        Me.lbl_Mssngunits.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Mssngunits.Location = New System.Drawing.Point(19, 273)
        Me.lbl_Mssngunits.Name = "lbl_Mssngunits"
        Me.lbl_Mssngunits.Size = New System.Drawing.Size(122, 19)
        Me.lbl_Mssngunits.TabIndex = 31
        Me.lbl_Mssngunits.Text = "Missing Units :"
        '
        'lbl_actualBin
        '
        Me.lbl_actualBin.AutoSize = True
        Me.lbl_actualBin.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_actualBin.Location = New System.Drawing.Point(28, 312)
        Me.lbl_actualBin.Name = "lbl_actualBin"
        Me.lbl_actualBin.Size = New System.Drawing.Size(110, 19)
        Me.lbl_actualBin.TabIndex = 32
        Me.lbl_actualBin.Text = "Actual Bin 1 :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbl2RAB)
        Me.GroupBox1.Controls.Add(Me.lbl1RAB)
        Me.GroupBox1.Controls.Add(Me.txt2MU)
        Me.GroupBox1.Controls.Add(Me.txt2RHL)
        Me.GroupBox1.Controls.Add(Me.txt2RR)
        Me.GroupBox1.Controls.Add(Me.txt2RB)
        Me.GroupBox1.Controls.Add(Me.txt1RMU)
        Me.GroupBox1.Controls.Add(Me.txt1RHL)
        Me.GroupBox1.Controls.Add(Me.txt1RR)
        Me.GroupBox1.Controls.Add(Me.txt1RB)
        Me.GroupBox1.Controls.Add(Me.txt1LMU)
        Me.GroupBox1.Controls.Add(Me.txt1LHL)
        Me.GroupBox1.Controls.Add(Me.txt1LR)
        Me.GroupBox1.Controls.Add(Me.txt1LB)
        Me.GroupBox1.Controls.Add(Me.lblAB1)
        Me.GroupBox1.Controls.Add(Me.lbl_qty3)
        Me.GroupBox1.Controls.Add(Me.lbl_qty2)
        Me.GroupBox1.Controls.Add(Me.lbl_actualBin)
        Me.GroupBox1.Controls.Add(Me.lbl_qty1)
        Me.GroupBox1.Controls.Add(Me.lbl_bSummary)
        Me.GroupBox1.Controls.Add(Me.lbl_2ndRload)
        Me.GroupBox1.Controls.Add(Me.lbl_Mssngunits)
        Me.GroupBox1.Controls.Add(Me.lbl_1stRload)
        Me.GroupBox1.Controls.Add(Me.lbl_reject)
        Me.GroupBox1.Controls.Add(Me.lbl_1stload)
        Me.GroupBox1.Controls.Add(Me.lbl_hloss)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(642, 382)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Directions :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 18)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Click Save button to Save."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(390, 18)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Fill in the Boxes  with the corresponding re-screen data."
        '
        'lbl2RAB
        '
        Me.lbl2RAB.AutoSize = True
        Me.lbl2RAB.Location = New System.Drawing.Point(485, 307)
        Me.lbl2RAB.Name = "lbl2RAB"
        Me.lbl2RAB.Size = New System.Drawing.Size(22, 25)
        Me.lbl2RAB.TabIndex = 48
        Me.lbl2RAB.Text = "0"
        '
        'lbl1RAB
        '
        Me.lbl1RAB.AutoSize = True
        Me.lbl1RAB.Location = New System.Drawing.Point(330, 307)
        Me.lbl1RAB.Name = "lbl1RAB"
        Me.lbl1RAB.Size = New System.Drawing.Size(22, 25)
        Me.lbl1RAB.TabIndex = 47
        Me.lbl1RAB.Text = "0"
        '
        'txt2MU
        '
        Me.txt2MU.BackColor = System.Drawing.Color.White
        Me.txt2MU.Location = New System.Drawing.Point(438, 265)
        Me.txt2MU.Name = "txt2MU"
        Me.txt2MU.Size = New System.Drawing.Size(122, 32)
        Me.txt2MU.TabIndex = 46
        '
        'txt2RHL
        '
        Me.txt2RHL.BackColor = System.Drawing.Color.White
        Me.txt2RHL.Location = New System.Drawing.Point(438, 228)
        Me.txt2RHL.Name = "txt2RHL"
        Me.txt2RHL.Size = New System.Drawing.Size(122, 32)
        Me.txt2RHL.TabIndex = 45
        '
        'txt2RR
        '
        Me.txt2RR.BackColor = System.Drawing.Color.White
        Me.txt2RR.Location = New System.Drawing.Point(438, 190)
        Me.txt2RR.Name = "txt2RR"
        Me.txt2RR.Size = New System.Drawing.Size(122, 32)
        Me.txt2RR.TabIndex = 44
        Me.txt2RR.Text = " "
        '
        'txt2RB
        '
        Me.txt2RB.BackColor = System.Drawing.Color.White
        Me.txt2RB.Location = New System.Drawing.Point(438, 153)
        Me.txt2RB.Name = "txt2RB"
        Me.txt2RB.Size = New System.Drawing.Size(122, 32)
        Me.txt2RB.TabIndex = 43
        '
        'txt1RMU
        '
        Me.txt1RMU.BackColor = System.Drawing.Color.White
        Me.txt1RMU.Location = New System.Drawing.Point(289, 266)
        Me.txt1RMU.Name = "txt1RMU"
        Me.txt1RMU.Size = New System.Drawing.Size(122, 32)
        Me.txt1RMU.TabIndex = 42
        '
        'txt1RHL
        '
        Me.txt1RHL.BackColor = System.Drawing.Color.White
        Me.txt1RHL.Location = New System.Drawing.Point(289, 228)
        Me.txt1RHL.Name = "txt1RHL"
        Me.txt1RHL.Size = New System.Drawing.Size(122, 32)
        Me.txt1RHL.TabIndex = 41
        '
        'txt1RR
        '
        Me.txt1RR.BackColor = System.Drawing.Color.White
        Me.txt1RR.Location = New System.Drawing.Point(289, 190)
        Me.txt1RR.Name = "txt1RR"
        Me.txt1RR.Size = New System.Drawing.Size(122, 32)
        Me.txt1RR.TabIndex = 40
        '
        'txt1RB
        '
        Me.txt1RB.BackColor = System.Drawing.Color.White
        Me.txt1RB.Location = New System.Drawing.Point(289, 153)
        Me.txt1RB.Name = "txt1RB"
        Me.txt1RB.Size = New System.Drawing.Size(122, 32)
        Me.txt1RB.TabIndex = 39
        '
        'txt1LMU
        '
        Me.txt1LMU.BackColor = System.Drawing.Color.White
        Me.txt1LMU.Location = New System.Drawing.Point(144, 267)
        Me.txt1LMU.Name = "txt1LMU"
        Me.txt1LMU.Size = New System.Drawing.Size(122, 32)
        Me.txt1LMU.TabIndex = 38
        '
        'txt1LHL
        '
        Me.txt1LHL.BackColor = System.Drawing.Color.White
        Me.txt1LHL.Location = New System.Drawing.Point(144, 228)
        Me.txt1LHL.Name = "txt1LHL"
        Me.txt1LHL.Size = New System.Drawing.Size(122, 32)
        Me.txt1LHL.TabIndex = 37
        '
        'txt1LR
        '
        Me.txt1LR.BackColor = System.Drawing.Color.White
        Me.txt1LR.Location = New System.Drawing.Point(144, 190)
        Me.txt1LR.Name = "txt1LR"
        Me.txt1LR.Size = New System.Drawing.Size(122, 32)
        Me.txt1LR.TabIndex = 36
        '
        'txt1LB
        '
        Me.txt1LB.BackColor = System.Drawing.Color.White
        Me.txt1LB.Location = New System.Drawing.Point(144, 153)
        Me.txt1LB.Name = "txt1LB"
        Me.txt1LB.Size = New System.Drawing.Size(122, 32)
        Me.txt1LB.TabIndex = 35
        '
        'lblAB1
        '
        Me.lblAB1.AutoSize = True
        Me.lblAB1.Location = New System.Drawing.Point(185, 307)
        Me.lblAB1.Name = "lblAB1"
        Me.lblAB1.Size = New System.Drawing.Size(22, 25)
        Me.lblAB1.TabIndex = 34
        Me.lblAB1.Text = "0"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.lbl_totalrjs)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.lbl_tb1)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lbl_qty4)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(701, 125)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(313, 324)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TOTAL"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.White
        Me.GroupBox5.Controls.Add(Me.lblFY)
        Me.GroupBox5.Location = New System.Drawing.Point(134, 218)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(164, 71)
        Me.GroupBox5.TabIndex = 24
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = " "
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.lblTR)
        Me.GroupBox4.Location = New System.Drawing.Point(131, 151)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(166, 46)
        Me.GroupBox4.TabIndex = 23
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = " "
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.lblTB)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox3.Location = New System.Drawing.Point(131, 87)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(167, 45)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = " "
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(1056, 313)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(110, 37)
        Me.btnSave.TabIndex = 35
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnClear.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(1056, 256)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(113, 35)
        Me.btnClear.TabIndex = 36
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lbllot
        '
        Me.lbllot.AutoSize = True
        Me.lbllot.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllot.Location = New System.Drawing.Point(25, 92)
        Me.lbllot.Name = "lbllot"
        Me.lbllot.Size = New System.Drawing.Size(54, 19)
        Me.lbllot.TabIndex = 47
        Me.lbllot.Text = "LOT #"
        '
        'txtlot
        '
        Me.txtlot.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlot.Location = New System.Drawing.Point(81, 86)
        Me.txtlot.Name = "txtlot"
        Me.txtlot.Size = New System.Drawing.Size(173, 30)
        Me.txtlot.TabIndex = 48
        '
        'txtDevice
        '
        Me.txtDevice.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDevice.Location = New System.Drawing.Point(414, 86)
        Me.txtDevice.Name = "txtDevice"
        Me.txtDevice.Size = New System.Drawing.Size(173, 30)
        Me.txtDevice.TabIndex = 49
        '
        'lbldev
        '
        Me.lbldev.AutoSize = True
        Me.lbldev.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldev.Location = New System.Drawing.Point(325, 92)
        Me.lbldev.Name = "lbldev"
        Me.lbldev.Size = New System.Drawing.Size(83, 19)
        Me.lbldev.TabIndex = 50
        Me.lbldev.Text = "DEVICE #"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(1056, 371)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(110, 37)
        Me.btnExit.TabIndex = 52
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(744, 478)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(215, 23)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "testConnection"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'clockUpdater
        '
        Me.clockUpdater.Enabled = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1189, 24)
        Me.MenuStrip1.TabIndex = 54
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'frmhome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1189, 513)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lbldev)
        Me.Controls.Add(Me.txtDevice)
        Me.Controls.Add(Me.txtlot)
        Me.Controls.Add(Me.lbllot)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmhome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Yield Computation"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents lbl_1stload As Label
    Friend WithEvents lbl_1stRload As Label
    Friend WithEvents lbl_2ndRload As Label
    Friend WithEvents lbl_tb1 As Label
    Friend WithEvents lbl_totalrjs As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_qty4 As Label
    Friend WithEvents lblTB As Label
    Friend WithEvents lblTR As Label
    Friend WithEvents lblFY As Label
    Friend WithEvents lbl_qty1 As Label
    Friend WithEvents lbl_qty2 As Label
    Friend WithEvents lbl_qty3 As Label
    Friend WithEvents lbldate As Label
    Friend WithEvents lbl_bSummary As Label
    Friend WithEvents lbl_reject As Label
    Friend WithEvents lbl_hloss As Label
    Friend WithEvents lbl_Mssngunits As Label
    Friend WithEvents lbl_actualBin As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt2MU As TextBox
    Friend WithEvents txt2RHL As TextBox
    Friend WithEvents txt2RR As TextBox
    Friend WithEvents txt2RB As TextBox
    Friend WithEvents txt1RMU As TextBox
    Friend WithEvents txt1RHL As TextBox
    Friend WithEvents txt1RR As TextBox
    Friend WithEvents txt1RB As TextBox
    Friend WithEvents txt1LMU As TextBox
    Friend WithEvents txt1LHL As TextBox
    Friend WithEvents txt1LR As TextBox
    Friend WithEvents txt1LB As TextBox
    Friend WithEvents lblAB1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lbllot As Label
    Friend WithEvents txtlot As TextBox
    Friend WithEvents txtDevice As TextBox
    Friend WithEvents lbldev As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents lbl2RAB As Label
    Friend WithEvents lbl1RAB As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TblLogsTableAdapterMain As dbMainDataSetTableAdapters.tblLogsTableAdapter
    Friend WithEvents QueriesTableAdapterMain As dbMainDataSetTableAdapters.QueriesTableAdapter
    Friend WithEvents clockUpdater As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
