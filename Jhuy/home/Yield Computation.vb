Public Class frmhome
    Dim theDate As DateTime = System.DateTime.Now

    Private Sub frmhome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DONE - Actual bin 1 = Bin 1 -  (Handler Loss + Missing Units)
        'DONE - Total Bin 1 = 1st Load + 1st Reload + 2nd Reload
        'Total rejects = 2nd Reload
        'Final Rescreen Yield = Total Bin 1 / total Bin 1 + total rejec
    End Sub

    Private Sub clockUpdater_Tick(sender As Object, e As EventArgs) Handles clockUpdater.Tick
        lbldate.Text = Now.ToString()
    End Sub

    Private Sub _TotalBin1_TestChanged(sender As Object, e As EventArgs) Handles txt1LB.TextChanged, txt1RB.TextChanged, txt2RB.TextChanged
        Dim totalBuffer As Integer = 0
        Dim parseBuffer As Integer = 0

        Integer.TryParse(txt1LB.Text, parseBuffer)
        totalBuffer = parseBuffer
        Integer.TryParse(txt1RB.Text, parseBuffer)
        totalBuffer += parseBuffer
        Integer.TryParse(txt2RB.Text, parseBuffer)
        totalBuffer += parseBuffer

        lblTB.Text = totalBuffer.ToString()

    End Sub

    Private Sub _1stLoad_TextChanged(sender As Object, e As EventArgs) Handles txt1LB.TextChanged, txt1LR.TextChanged, txt1LMU.TextChanged, txt1LHL.TextChanged
        Dim totalBuffer As Integer = 0
        Dim parseBuffer As Integer = 0

        Integer.TryParse(txt1LB.Text, parseBuffer)
        totalBuffer = parseBuffer
        Integer.TryParse(txt1LHL.Text, parseBuffer)
        totalBuffer -= parseBuffer
        Integer.TryParse(txt1LMU.Text, parseBuffer)
        totalBuffer -= parseBuffer


        lblAB1.Text = totalBuffer.ToString()

        totalBuffer = 0
        parseBuffer = 0
        Integer.TryParse(txt1LB.Text, parseBuffer)
        totalBuffer += parseBuffer
        Integer.TryParse(txt1RB.Text, parseBuffer)
        totalBuffer += parseBuffer
        Integer.TryParse(txt2RB.Text, parseBuffer)
        totalBuffer += parseBuffer
        lblTB.Text = totalBuffer


    End Sub
    Private Sub _1stReload_TextChanged(sender As Object, e As EventArgs) Handles txt1RB.TextChanged, txt1RR.TextChanged
        Dim totalBuffer As Integer = 0
        Dim parseBuffer As Integer = 0

        Integer.TryParse(txt1RB.Text, parseBuffer)
        totalBuffer = parseBuffer
        Integer.TryParse(txt1RR.Text, parseBuffer)
        totalBuffer -= parseBuffer

        lbl1RAB.Text = totalBuffer.ToString()
        Percent()
    End Sub
    Private Sub _2ndReload_TextChanged(sender As Object, e As EventArgs) Handles txt2RR.TextChanged, txt2RHL.TextChanged, txt2RB.TextChanged, txt2MU.TextChanged
        Dim totalBuffer As Integer = 0
        Dim parseBuffer As Integer = 0


        Integer.TryParse(txt2RB.Text, parseBuffer)
        totalBuffer = parseBuffer
        Integer.TryParse(txt2RHL.Text, parseBuffer)
        totalBuffer -= parseBuffer
        Integer.TryParse(txt2MU.Text, parseBuffer)
        totalBuffer -= parseBuffer



        lbl2RAB.Text = totalBuffer.ToString()

        totalBuffer = 0
        parseBuffer = 0
        Integer.TryParse(txt2RR.Text, parseBuffer)
        lblTR.Text = parseBuffer
        Percent()
    End Sub

    Private Sub Percent()

        If lblTB.Text = 0 Then Exit Sub
        If lblTR.Text = 0 Then Exit Sub
        Dim totalBuffer As Decimal
        Dim parseBuffer As Decimal
        Dim Uno As Decimal


        Decimal.TryParse(lblTB.Text, Uno)
        Decimal.TryParse(lblTR.Text, parseBuffer)
        Uno += parseBuffer

        Decimal.TryParse(lblTB.Text, parseBuffer)
        totalBuffer = parseBuffer / Uno
        totalBuffer *= 100

        lblFY.Text = totalBuffer



    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        MsgBox("Waley pa :P" + vbNewLine + vbNewLine + "Mag ccrash pag pinindut mo OK :P", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Chillax")
        Throw New Exception("Waley pa :P")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtlot.Clear()
        txtDevice.Clear()
        txt1LB.Clear()
        txt1RB.Clear()
        txt2RB.Clear()
        txt1LR.Clear()
        txt1RR.Clear()
        txt2RR.Clear()
        txt1LHL.Clear()
        txt1RHL.Clear()
        txt2RHL.Clear()
        txt1LMU.Clear()
        txt1RMU.Clear()
        txt2MU.Clear()

    End Sub
End Class
