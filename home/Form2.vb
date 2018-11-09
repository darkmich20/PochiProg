Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbMainDataSet.tblLogs' table. You can move, or remove it, as needed.
        Me.TblLogsTableAdapter.Fill(Me.DbMainDataSet.tblLogs)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.TblLogsTableAdapter.FillBySearch(Me.DbMainDataSet.tblLogs, txtlot.Text, txtDevice.Text)
    End Sub
End Class