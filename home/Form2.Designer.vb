﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.lbldev = New System.Windows.Forms.Label()
        Me.txtDevice = New System.Windows.Forms.TextBox()
        Me.txtlot = New System.Windows.Forms.TextBox()
        Me.lbllot = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotNumberDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeviceNumberDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalBin1DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalRejectsDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblLogsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbMainDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbMainDataSet = New RSYC.dbMainDataSet()
        Me.cntxLstvMain = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeviceNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalBin1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalRejectsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblLogsTableAdapter = New RSYC.dbMainDataSetTableAdapters.tblLogsTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblLogsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbMainDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbMainDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cntxLstvMain.SuspendLayout()
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.LotNumberDataGridViewTextBoxColumn1, Me.DeviceNumberDataGridViewTextBoxColumn1, Me.TotalBin1DataGridViewTextBoxColumn1, Me.TotalRejectsDataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn1, Me.Time})
        Me.DataGridView1.DataSource = Me.TblLogsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 91)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(793, 304)
        Me.DataGridView1.TabIndex = 57
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        Me.IDDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'LotNumberDataGridViewTextBoxColumn1
        '
        Me.LotNumberDataGridViewTextBoxColumn1.DataPropertyName = "Lot Number"
        Me.LotNumberDataGridViewTextBoxColumn1.HeaderText = "Lot Number"
        Me.LotNumberDataGridViewTextBoxColumn1.Name = "LotNumberDataGridViewTextBoxColumn1"
        Me.LotNumberDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DeviceNumberDataGridViewTextBoxColumn1
        '
        Me.DeviceNumberDataGridViewTextBoxColumn1.DataPropertyName = "Device Number"
        Me.DeviceNumberDataGridViewTextBoxColumn1.HeaderText = "Device Number"
        Me.DeviceNumberDataGridViewTextBoxColumn1.Name = "DeviceNumberDataGridViewTextBoxColumn1"
        Me.DeviceNumberDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'TotalBin1DataGridViewTextBoxColumn1
        '
        Me.TotalBin1DataGridViewTextBoxColumn1.DataPropertyName = "Total Bin 1"
        Me.TotalBin1DataGridViewTextBoxColumn1.HeaderText = "Total Bin 1"
        Me.TotalBin1DataGridViewTextBoxColumn1.Name = "TotalBin1DataGridViewTextBoxColumn1"
        Me.TotalBin1DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'TotalRejectsDataGridViewTextBoxColumn1
        '
        Me.TotalRejectsDataGridViewTextBoxColumn1.DataPropertyName = "Total Reject/s"
        Me.TotalRejectsDataGridViewTextBoxColumn1.HeaderText = "Total Reject/s"
        Me.TotalRejectsDataGridViewTextBoxColumn1.Name = "TotalRejectsDataGridViewTextBoxColumn1"
        Me.TotalRejectsDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Total Yield"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Total Yield"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Time
        '
        Me.Time.DataPropertyName = "Time"
        Me.Time.HeaderText = "Time"
        Me.Time.Name = "Time"
        Me.Time.ReadOnly = True
        Me.Time.Width = 150
        '
        'TblLogsBindingSource
        '
        Me.TblLogsBindingSource.DataMember = "tblLogs"
        Me.TblLogsBindingSource.DataSource = Me.DbMainDataSetBindingSource
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
        'cntxLstvMain
        '
        Me.cntxLstvMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.cntxLstvMain.Name = "cntxLstvMain"
        Me.cntxLstvMain.Size = New System.Drawing.Size(114, 70)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.RefreshToolStripMenuItem.Text = "R&efresh"
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
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ID"
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        '
        'TblLogsTableAdapter
        '
        Me.TblLogsTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(528, 54)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 59
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(810, 407)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lbldev)
        Me.Controls.Add(Me.txtDevice)
        Me.Controls.Add(Me.txtlot)
        Me.Controls.Add(Me.lbllot)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Re-screen Search"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblLogsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbMainDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbMainDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cntxLstvMain.ResumeLayout(False)
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
    Friend WithEvents TotalYieldDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents cntxLstvMain As ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LotNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeviceNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalBin1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalRejectsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents LotNumberDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DeviceNumberDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TotalBin1DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TotalRejectsDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Time As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
