<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lbldev = New System.Windows.Forms.Label()
        Me.txtDevice = New System.Windows.Forms.TextBox()
        Me.txtlot = New System.Windows.Forms.TextBox()
        Me.lbllot = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TblLogsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lstvMain = New System.Windows.Forms.ListView()
        Me.cntxLstvMain = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeviceNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalBin1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalRejectsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalYieldDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DbMainDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbMainDataSet = New home.dbMainDataSet()
        Me.TblLogsTableAdapter = New home.dbMainDataSetTableAdapters.tblLogsTableAdapter()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblLogsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cntxLstvMain.SuspendLayout()
        CType(Me.DbMainDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbMainDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbldev
        '
        Me.lbldev.AutoSize = True
        Me.lbldev.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldev.Location = New System.Drawing.Point(259, 59)
        Me.lbldev.Name = "lbldev"
        Me.lbldev.Size = New System.Drawing.Size(83, 19)
        Me.lbldev.TabIndex = 54
        Me.lbldev.Text = "DEVICE #"
        '
        'txtDevice
        '
        Me.txtDevice.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDevice.Location = New System.Drawing.Point(348, 53)
        Me.txtDevice.Name = "txtDevice"
        Me.txtDevice.Size = New System.Drawing.Size(173, 30)
        Me.txtDevice.TabIndex = 53
        '
        'txtlot
        '
        Me.txtlot.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlot.Location = New System.Drawing.Point(64, 53)
        Me.txtlot.Name = "txtlot"
        Me.txtlot.Size = New System.Drawing.Size(173, 30)
        Me.txtlot.TabIndex = 52
        '
        'lbllot
        '
        Me.lbllot.AutoSize = True
        Me.lbllot.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllot.Location = New System.Drawing.Point(8, 59)
        Me.lbllot.Name = "lbllot"
        Me.lbllot.Size = New System.Drawing.Size(54, 19)
        Me.lbllot.TabIndex = 51
        Me.lbllot.Text = "LOT #"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.LotNumberDataGridViewTextBoxColumn, Me.DeviceNumberDataGridViewTextBoxColumn, Me.TotalBin1DataGridViewTextBoxColumn, Me.TotalRejectsDataGridViewTextBoxColumn, Me.TotalYieldDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblLogsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 91)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(880, 164)
        Me.DataGridView1.TabIndex = 57
        '
        'TblLogsBindingSource
        '
        Me.TblLogsBindingSource.DataMember = "tblLogs"
        Me.TblLogsBindingSource.DataSource = Me.DbMainDataSetBindingSource
        '
        'lstvMain
        '
        Me.lstvMain.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lstvMain.ContextMenuStrip = Me.cntxLstvMain
        Me.lstvMain.FullRowSelect = True
        Me.lstvMain.GridLines = True
        Me.lstvMain.Location = New System.Drawing.Point(12, 261)
        Me.lstvMain.Name = "lstvMain"
        Me.lstvMain.Size = New System.Drawing.Size(880, 134)
        Me.lstvMain.TabIndex = 58
        Me.lstvMain.UseCompatibleStateImageBehavior = False
        Me.lstvMain.View = System.Windows.Forms.View.Details
        '
        'cntxLstvMain
        '
        Me.cntxLstvMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.cntxLstvMain.Name = "cntxLstvMain"
        Me.cntxLstvMain.Size = New System.Drawing.Size(114, 70)
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Lot Number"
        Me.ColumnHeader2.Width = 131
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Device Number"
        Me.ColumnHeader3.Width = 124
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Total Bin 1"
        Me.ColumnHeader4.Width = 101
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Total Rejects/s"
        Me.ColumnHeader5.Width = 97
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Total Yield%"
        Me.ColumnHeader6.Width = 78
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LotNumberDataGridViewTextBoxColumn
        '
        Me.LotNumberDataGridViewTextBoxColumn.DataPropertyName = "Lot Number"
        Me.LotNumberDataGridViewTextBoxColumn.HeaderText = "Lot Number"
        Me.LotNumberDataGridViewTextBoxColumn.Name = "LotNumberDataGridViewTextBoxColumn"
        Me.LotNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DeviceNumberDataGridViewTextBoxColumn
        '
        Me.DeviceNumberDataGridViewTextBoxColumn.DataPropertyName = "Device Number"
        Me.DeviceNumberDataGridViewTextBoxColumn.HeaderText = "Device Number"
        Me.DeviceNumberDataGridViewTextBoxColumn.Name = "DeviceNumberDataGridViewTextBoxColumn"
        Me.DeviceNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalBin1DataGridViewTextBoxColumn
        '
        Me.TotalBin1DataGridViewTextBoxColumn.DataPropertyName = "Total Bin 1"
        Me.TotalBin1DataGridViewTextBoxColumn.HeaderText = "Total Bin 1"
        Me.TotalBin1DataGridViewTextBoxColumn.Name = "TotalBin1DataGridViewTextBoxColumn"
        Me.TotalBin1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalRejectsDataGridViewTextBoxColumn
        '
        Me.TotalRejectsDataGridViewTextBoxColumn.DataPropertyName = "Total Reject/s"
        Me.TotalRejectsDataGridViewTextBoxColumn.HeaderText = "Total Reject/s"
        Me.TotalRejectsDataGridViewTextBoxColumn.Name = "TotalRejectsDataGridViewTextBoxColumn"
        Me.TotalRejectsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalYieldDataGridViewTextBoxColumn
        '
        Me.TotalYieldDataGridViewTextBoxColumn.DataPropertyName = "Total Yield %"
        Me.TotalYieldDataGridViewTextBoxColumn.HeaderText = "Total Yield %"
        Me.TotalYieldDataGridViewTextBoxColumn.Name = "TotalYieldDataGridViewTextBoxColumn"
        Me.TotalYieldDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DbMainDataSetBindingSource
        '
        Me.DbMainDataSetBindingSource.DataSource = Me.DbMainDataSet
        Me.DbMainDataSetBindingSource.Position = 0
        '
        'DbMainDataSet
        '
        Me.DbMainDataSet.DataSetName = "dbMainDataSet"
        Me.DbMainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblLogsTableAdapter
        '
        Me.TblLogsTableAdapter.ClearBeforeFill = True
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.RefreshToolStripMenuItem.Text = "R&efresh"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(904, 407)
        Me.Controls.Add(Me.lstvMain)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lbldev)
        Me.Controls.Add(Me.txtDevice)
        Me.Controls.Add(Me.txtlot)
        Me.Controls.Add(Me.lbllot)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblLogsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cntxLstvMain.ResumeLayout(False)
        CType(Me.DbMainDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbMainDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbldev As Label
    Friend WithEvents txtDevice As TextBox
    Friend WithEvents txtlot As TextBox
    Friend WithEvents lbllot As Label
    Friend WithEvents DbMainDataSetBindingSource As BindingSource
    Friend WithEvents DbMainDataSet As dbMainDataSet
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TblLogsBindingSource As BindingSource
    Friend WithEvents TblLogsTableAdapter As dbMainDataSetTableAdapters.tblLogsTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LotNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeviceNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalBin1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalRejectsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalYieldDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lstvMain As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents cntxLstvMain As ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
End Class
