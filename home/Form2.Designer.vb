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
        Me.DbMainDataSet = New home.dbMainDataSet()
        Me.DbMainDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TblLogsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblLogsTableAdapter = New home.dbMainDataSetTableAdapters.tblLogsTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeviceNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalBin1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalRejectsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalYieldDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DbMainDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbMainDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblLogsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbldev
        '
        Me.lbldev.AutoSize = True
        Me.lbldev.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldev.Location = New System.Drawing.Point(311, 18)
        Me.lbldev.Name = "lbldev"
        Me.lbldev.Size = New System.Drawing.Size(83, 19)
        Me.lbldev.TabIndex = 54
        Me.lbldev.Text = "DEVICE #"
        '
        'txtDevice
        '
        Me.txtDevice.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDevice.Location = New System.Drawing.Point(400, 12)
        Me.txtDevice.Name = "txtDevice"
        Me.txtDevice.Size = New System.Drawing.Size(173, 30)
        Me.txtDevice.TabIndex = 53
        '
        'txtlot
        '
        Me.txtlot.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlot.Location = New System.Drawing.Point(67, 12)
        Me.txtlot.Name = "txtlot"
        Me.txtlot.Size = New System.Drawing.Size(173, 30)
        Me.txtlot.TabIndex = 52
        '
        'lbllot
        '
        Me.lbllot.AutoSize = True
        Me.lbllot.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllot.Location = New System.Drawing.Point(11, 18)
        Me.lbllot.Name = "lbllot"
        Me.lbllot.Size = New System.Drawing.Size(54, 19)
        Me.lbllot.TabIndex = 51
        Me.lbllot.Text = "LOT #"
        '
        'DbMainDataSet
        '
        Me.DbMainDataSet.DataSetName = "dbMainDataSet"
        Me.DbMainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DbMainDataSetBindingSource
        '
        Me.DbMainDataSetBindingSource.DataSource = Me.DbMainDataSet
        Me.DbMainDataSetBindingSource.Position = 0
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(736, 91)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(232, 306)
        Me.ListView1.TabIndex = 56
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.List
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.LotNumberDataGridViewTextBoxColumn, Me.DeviceNumberDataGridViewTextBoxColumn, Me.TotalBin1DataGridViewTextBoxColumn, Me.TotalRejectsDataGridViewTextBoxColumn, Me.TotalYieldDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblLogsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 91)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(680, 306)
        Me.DataGridView1.TabIndex = 57
        '
        'TblLogsBindingSource
        '
        Me.TblLogsBindingSource.DataMember = "tblLogs"
        Me.TblLogsBindingSource.DataSource = Me.DbMainDataSetBindingSource
        '
        'TblLogsTableAdapter
        '
        Me.TblLogsTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'LotNumberDataGridViewTextBoxColumn
        '
        Me.LotNumberDataGridViewTextBoxColumn.DataPropertyName = "Lot Number"
        Me.LotNumberDataGridViewTextBoxColumn.HeaderText = "Lot Number"
        Me.LotNumberDataGridViewTextBoxColumn.Name = "LotNumberDataGridViewTextBoxColumn"
        '
        'DeviceNumberDataGridViewTextBoxColumn
        '
        Me.DeviceNumberDataGridViewTextBoxColumn.DataPropertyName = "Device Number"
        Me.DeviceNumberDataGridViewTextBoxColumn.HeaderText = "Device Number"
        Me.DeviceNumberDataGridViewTextBoxColumn.Name = "DeviceNumberDataGridViewTextBoxColumn"
        '
        'TotalBin1DataGridViewTextBoxColumn
        '
        Me.TotalBin1DataGridViewTextBoxColumn.DataPropertyName = "Total Bin 1"
        Me.TotalBin1DataGridViewTextBoxColumn.HeaderText = "Total Bin 1"
        Me.TotalBin1DataGridViewTextBoxColumn.Name = "TotalBin1DataGridViewTextBoxColumn"
        '
        'TotalRejectsDataGridViewTextBoxColumn
        '
        Me.TotalRejectsDataGridViewTextBoxColumn.DataPropertyName = "Total Reject/s"
        Me.TotalRejectsDataGridViewTextBoxColumn.HeaderText = "Total Reject/s"
        Me.TotalRejectsDataGridViewTextBoxColumn.Name = "TotalRejectsDataGridViewTextBoxColumn"
        '
        'TotalYieldDataGridViewTextBoxColumn
        '
        Me.TotalYieldDataGridViewTextBoxColumn.DataPropertyName = "Total Yield %"
        Me.TotalYieldDataGridViewTextBoxColumn.HeaderText = "Total Yield %"
        Me.TotalYieldDataGridViewTextBoxColumn.Name = "TotalYieldDataGridViewTextBoxColumn"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 418)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.lbldev)
        Me.Controls.Add(Me.txtDevice)
        Me.Controls.Add(Me.txtlot)
        Me.Controls.Add(Me.lbllot)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DbMainDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbMainDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblLogsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbldev As Label
    Friend WithEvents txtDevice As TextBox
    Friend WithEvents txtlot As TextBox
    Friend WithEvents lbllot As Label
    Friend WithEvents DbMainDataSetBindingSource As BindingSource
    Friend WithEvents DbMainDataSet As dbMainDataSet
    Friend WithEvents ListView1 As ListView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TblLogsBindingSource As BindingSource
    Friend WithEvents TblLogsTableAdapter As dbMainDataSetTableAdapters.tblLogsTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LotNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeviceNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalBin1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalRejectsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalYieldDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
