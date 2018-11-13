Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbMainDataSet.tblLogs' table. You can move, or remove it, as needed.
        Me.TblLogsTableAdapter.Fill(Me.DbMainDataSet.tblLogs)


        RefreshListView("")
    End Sub
    Private Sub RefreshListView(e As String)
        'e Para sa search sa susunud
        TblLogsTableAdapter.FillBySearch(DbMainDataSet.tblLogs, txtlot.Text, txtDevice.Text)
        ' lstvMain.Items.Clear()
        Dim lstvItem As ListViewItem

        Dim i As Integer = 0
        Do
            On Error Resume Next
            'Nag eeror kapag may null xD DBNull thing hahaha
            lstvItem = New ListViewItem
            lstvItem.Text = DbMainDataSet.tblLogs.Item(i).ID
            lstvItem.SubItems.Add(DbMainDataSet.tblLogs.Item(i).Lot_Number.ToString())
            lstvItem.SubItems.Add(DbMainDataSet.tblLogs.Item(i).Device_Number.ToString())
            lstvItem.SubItems.Add(DbMainDataSet.tblLogs.Item(i).Total_Bin_1.ToString())
            lstvItem.SubItems.Add(DbMainDataSet.tblLogs.Item(i)._Total_Reject_s.ToString())
            lstvItem.SubItems.Add(DbMainDataSet.tblLogs.Item(i).Total_Yield.ToString())
            lstvItem.SubItems.Add(DbMainDataSet.tblLogs.Item(i).Time.ToString())
            '  lstvMain.Items.Add(lstvItem)
            i += 1
        Loop While i < DbMainDataSet.tblLogs.Count

    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        RefreshListView("")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.TblLogsTableAdapter.FillBySearch(Me.DbMainDataSet.tblLogs, txtlot.Text, txtDevice.Text)
    End Sub
End Class