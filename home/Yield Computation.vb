Public Class frmhome
    Dim theDate As DateTime = System.DateTime.Now
    WithEvents TblLogsTableAdapterMain As dbMainDataSetTableAdapters.tblLogsTableAdapter

    Private Sub frmhome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DONE - Actual bin 1 = Bin 1 -  (Handler Loss + Missing Units)
        'DONE - Total Bin 1 = 1st Load + 1st Reload + 2nd Reload
        'Total rejects = 2nd Reload
        'Final Rescreen Yield = Total Bin 1 / total Bin 1 + total rejec

        TblLogsTableAdapterMain = New dbMainDataSetTableAdapters.tblLogsTableAdapter() 'EWAN KO NALANG KUNG MAG NULL PA TO
        TblLogsTableAdapterMain.ClearBeforeFill = True
        TblLogsTableAdapterMain.Connection.Open()
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

        If lblTB.Text = "0" Then Exit Sub
        If lblTR.Text = "0" Then Exit Sub
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

        Dim value As Decimal = Decimal.Parse(lblFY.Text)

        value = Math.Round(value, 2)

        lblFY.Text = value



    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim _lblTB As Integer
        Dim _lblTR As Integer
        Dim _lblFY As Double
        If txtlot.Text.Length = 0 Then
            tltpSave.Show("Please enter sometihng", txtlot)
            Exit Sub
        End If

        If txtDevice.Text.Length = 0 Then
            tltpSave.Show("Please enter sometihng", txtDevice)
            Exit Sub
        End If

        If lblTB.Text.Length = 0 Then
            tltpSave.Show("Please enter sometihng", lblTB)
            Exit Sub
        End If

        If lblTR.Text.Length = 0 Then
            tltpSave.Show("Please enter sometihng", lblTR)
            Exit Sub
        End If

        If lblFY.Text.Length = 0 Then
            tltpSave.Show("Please enter sometihng", lblFY)
            Exit Sub
        End If

        Integer.TryParse(lblTB.Text, _lblTB)
        Integer.TryParse(lblTR.Text, _lblTR)
        Integer.TryParse(lblFY.Text, _lblFY)

        If TblLogsTableAdapterMain.Insert(txtlot.Text, txtDevice.Text, _lblTB, _lblTR, _lblFY) Then
            MsgBox("Saved !!!")
        End If

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

    Private Sub _1st_Load_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt1LB.KeyPress, txt1LR.KeyPress, txt1LHL.KeyPress, txt1LMU.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub _2nd_Load_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt1RB.KeyPress, txt1RR.KeyPress, txt1RHL.KeyPress, txt1RMU.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub _3rd_Load_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt2RB.KeyPress, txt2RR.KeyPress, txt2RHL.KeyPress, txt2MU.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt1LHL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt1LHL.KeyPress

        If Val(txt1LB.Text) < Val(txt1LHL.Text & e.KeyChar) Then
            Beep()
            e.Handled = True
            txt1LHL.Text = ""
            MessageBox.Show("Value must not greater than Bin 1 Load", "Error")

        End If
    End Sub

    Private Sub txt1LMU_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt1LMU.KeyPress

        If Val(txt1LB.Text) < Val(txt1LMU.Text & e.KeyChar) Then
            Beep()
            e.Handled = True
            txt1LMU.Text = ""
            MessageBox.Show("Value must not greater than Bin 1 Load", "Error")

        End If

    End Sub

    Private Sub txt1RB_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt1RB.KeyPress

        If Val(txt1LR.Text) < Val(txt1RB.Text & e.KeyChar) Then
            Beep()
            e.Handled = True
            txt1RB.Text = ""
            MessageBox.Show("1st Reload Bin 1 value must not greater than in Reject on 1st Load ", "Error")

        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
