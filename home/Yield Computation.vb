Imports System.ComponentModel

Public Class frmhome
    Dim theDate As DateTime = System.DateTime.Now
    WithEvents TblLogsTableAdapterMain As dbMainDataSetTableAdapters.tblLogsTableAdapter

    Private Sub frmhome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TblLogsTableAdapterMain = New dbMainDataSetTableAdapters.tblLogsTableAdapter()
        TblLogsTableAdapterMain.ClearBeforeFill = True
        TblLogsTableAdapterMain.Connection.Open()
    End Sub

    Private Sub clockUpdater_Tick(sender As Object, e As EventArgs) Handles clockUpdater.Tick
        lbldate.Text = Now.ToString()
    End Sub

    Private Sub _TotalBin1_TestChanged(sender As Object, e As EventArgs) Handles txt1LB.TextChanged, txt1RB.TextChanged, txt2RB.TextChanged
        Dim totalBuffer As Integer = 0
        Dim parseBuffer As Integer = 0
        '============Total Bin 1=================
        Integer.TryParse(txt1LB.Text, parseBuffer)
        totalBuffer = parseBuffer
        Integer.TryParse(txt1RB.Text, parseBuffer)
        totalBuffer += parseBuffer
        Integer.TryParse(txt2RB.Text, parseBuffer)
        totalBuffer += parseBuffer

        lblTB.Text = totalBuffer.ToString()
        '========================================
    End Sub

    Private Sub _1stLoad_TextChanged(sender As Object, e As EventArgs) Handles txt1LB.TextChanged, txt1LR.TextChanged, txt1LMU.TextChanged, txt1LHL.TextChanged


        Dim totalBuffer As Integer = 0
        Dim parseBuffer As Integer = 0
        '===================Actual Bin 1 1st Load======================
        Integer.TryParse(txt1LB.Text, parseBuffer) '1st load Bin 
        totalBuffer = parseBuffer
        Integer.TryParse(txt1LHL.Text, parseBuffer) ' - 1st load handler loss
        totalBuffer -= parseBuffer
        Integer.TryParse(txt1LMU.Text, parseBuffer) ' - 1st load missing unit
        totalBuffer -= parseBuffer


        lblAB1.Text = totalBuffer.ToString() '1st load Actual bin 1 
        '====================Total Bin 1================================
        totalBuffer = 0
        parseBuffer = 0
        Integer.TryParse(txt1LB.Text, parseBuffer)  '1st load Bin 1
        totalBuffer += parseBuffer
        Integer.TryParse(txt1RB.Text, parseBuffer) ' + 1st reload Bin
        totalBuffer += parseBuffer
        Integer.TryParse(txt2RB.Text, parseBuffer) ' + 2nd reLoad Bin 
        totalBuffer += parseBuffer
        lblTB.Text = totalBuffer 'Total Bin 1


    End Sub
    Private Sub _QTY_TextChanged(sender As Object, e As EventArgs) Handles lblQTYOUT.TextChanged, lblAB1.TextChanged, lbl1RAB.TextChanged, lbl2RAB.TextChanged, lblTB.TextChanged, lblTR.TextChanged, lblQTYIN.TextChanged


        Dim totalBuffer As Integer = 0
        Dim parseBuffer As Integer = 0



        '==================QTY OUT================='

        Integer.TryParse(lblAB1.Text, parseBuffer)
        totalBuffer = parseBuffer
        Integer.TryParse(lbl1RAB.Text, parseBuffer)
        totalBuffer += parseBuffer
        Integer.TryParse(lbl2RAB.Text, parseBuffer)
        totalBuffer += parseBuffer

        lblQTYOUT.Text = totalBuffer
        '=========================================='

        '================QTY IN ==================='
        Integer.TryParse(lblTB.Text, parseBuffer)
        totalBuffer = parseBuffer
        Integer.TryParse(lblTR.Text, parseBuffer)
        totalBuffer += parseBuffer

        lblQTYIN.Text = totalBuffer

        '=========================================='

    End Sub
    Private Sub _1stloadHLMU_TextChanged(sender As Object, e As EventArgs) Handles txt1LHL.TextChanged, txt1LMU.TextChanged, txt1LB.TextChanged

        Dim totalBuffer As Integer = 0
        Dim parseBuffer As Integer = 0
        '=============Handler loss + Missing Unit 1st Load===================='
        Dim sum As Integer
        Integer.TryParse(txt1LHL.Text, parseBuffer) '1st load handler loss
        totalBuffer = parseBuffer   ' +
        Integer.TryParse(txt1LMU.Text, parseBuffer) ' 1st load Missing Unit
        totalBuffer += parseBuffer

        sum = totalBuffer ' HL + MU = n

        'If Val(txt1LB.Text) <= sum Then ' 1st load bin <= HL + MU
        If sum > Val(txt1LB.Text) Then
            Beep()
            MessageBox.Show("Sum of Handler Loss and Missing Unit must not be greater than Bin 1 Summary(1st Load)", "Error")
            'txt1LMU.Text = ""
            txt1LHL.Text = ""
        End If


    End Sub

    Private Sub _1stReloadHLMU_TextChanged(sender As Object, e As EventArgs) Handles txt1RHL.TextChanged, txt1RMU.TextChanged, txt1RB.TextChanged

        Dim totalBuffer As Integer = 0
        Dim parseBuffer As Integer = 0
        '=============Handler loss + Missing Unit 1st Reload================'
        Dim sum2 As Integer
        Integer.TryParse(txt1RHL.Text, parseBuffer) '1st Reload Hadler Loss 
        totalBuffer = parseBuffer ' +
        Integer.TryParse(txt1RMU.Text, parseBuffer) ' 1st reload Missing Unit
        totalBuffer += parseBuffer

        sum2 = totalBuffer

        'If Val(txt1RB.Text) <= sum2 Then
        If sum2 > Val(txt1RB.Text) Then
            Beep()
            MessageBox.Show("Sum of Handler Loss and Missing Unit must not be greater than Bin 1 Summary(1st Reload)", "Error")
            'txt1RHL.Clear()
            txt1RMU.Clear()
        End If
        '====================================================================='
    End Sub
    Private Sub _2ndReloadHLMU_TextChanged(sender As Object, e As EventArgs) Handles txt2RHL.TextChanged, txt2MU.TextChanged, txt2RB.TextChanged

        Dim totalBuffer As Integer = 0
        Dim parseBuffer As Integer = 0

        '===============Handler loss + Missing Unit 2nd Reload================'
        Dim sum3 As Integer
        Integer.TryParse(txt2RHL.Text, parseBuffer) ' 2nd reload handler Loss
        totalBuffer = parseBuffer
        Integer.TryParse(txt2MU.Text, parseBuffer) ' 2nd reload Missing Unt
        totalBuffer += parseBuffer

        sum3 = totalBuffer

        'If Val(txt2RB.Text) <= sum3 Then
        If sum3 > Val(txt2RB.Text) Then
            Beep()
            MessageBox.Show("Sum of Handler Loss and Missing Unit must not be greater than Bin 1 Summary(2nd ReLoad)", "Error")
            'txt2RHL.Clear()
            txt2MU.Clear()

        End If
        '======================================================================'
    End Sub


    Private Sub _1stReload_TextChanged(sender As Object, e As EventArgs) Handles txt1RB.TextChanged, txt1RHL.TextChanged, txt1RMU.TextChanged
        Dim totalBuffer As Integer = 0
        Dim parseBuffer As Integer = 0
        '============================Actual Bin 1 1st Reload ============================'
        Integer.TryParse(txt1RB.Text, parseBuffer) ' 1st reload Bin
        totalBuffer = parseBuffer
        Integer.TryParse(txt1RHL.Text, parseBuffer) '1st reload handler loss
        totalBuffer -= parseBuffer ' -
        Integer.TryParse(txt1RMU.Text, parseBuffer) ' 1st reload Missing unit
        totalBuffer -= parseBuffer

        lbl1RAB.Text = totalBuffer.ToString() '1st Reload Actual Bin 1
        Percent()
        '================================================================================'

    End Sub
    Private Sub _2ndReload_TextChanged(sender As Object, e As EventArgs) Handles txt2RR.TextChanged, txt2RHL.TextChanged, txt2RB.TextChanged, txt2MU.TextChanged
        Dim totalBuffer As Integer = 0
        Dim parseBuffer As Integer = 0

        '============================ Actual Bin 1 2nd reload ================================' 
        Integer.TryParse(txt2RB.Text, parseBuffer) '2nd reload bin
        totalBuffer = parseBuffer
        Integer.TryParse(txt2RHL.Text, parseBuffer) '2nd reload handler loss
        totalBuffer -= parseBuffer
        Integer.TryParse(txt2MU.Text, parseBuffer) '2nd reload Missing unit
        totalBuffer -= parseBuffer



        lbl2RAB.Text = totalBuffer.ToString() ' 2nd reload Actual Bin 1
        '========================Total Rejects ========================
        totalBuffer = 0
        parseBuffer = 0
        Integer.TryParse(txt2RR.Text, parseBuffer)
        lblTR.Text = parseBuffer
        Percent()
        '==============================================================
    End Sub

    Private Sub Percent()

        If lblTB.Text = "0" Then Exit Sub
        If lblTR.Text = "0" Then Exit Sub
        Dim totalBuffer As Decimal
        Dim parseBuffer As Decimal
        Dim Uno As Decimal

        '============ Total Yield ==============
        Decimal.TryParse(lblTB.Text, Uno)
        Decimal.TryParse(lblTR.Text, parseBuffer)
        Uno += parseBuffer

        Decimal.TryParse(lblTB.Text, parseBuffer)
        totalBuffer = parseBuffer / Uno
        totalBuffer *= 100

        lblFY.Text = Math.Round(totalBuffer, 2)

        'Dim value As Decimal = Decimal.Parse(lblFY.Text)

        'value = Math.Round(value, 2)

        'lblFY.Text = value



    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim _lblTB As Integer
        Dim _lblTR As Integer
        Dim _lblFY As Double
        If txtlot.Text.Length = 0 Then
            tltpSave.Show("Lot Number is required.", txtlot)
            Exit Sub
        End If

        If txtDevice.Text.Length = 0 Then
            tltpSave.Show("Device Number is Required.", txtDevice)
            Exit Sub
        End If

        If lblTB.Text.Length = 0 Then
            tltpSave.Show("Please enter something", lblTB)
            Exit Sub
        End If

        If lblTR.Text.Length = 0 Then
            tltpSave.Show("Please enter something", lblTR)
            Exit Sub
        End If

        If lblFY.Text.Length = 0 Then
            tltpSave.Show("Please enter something", lblFY)
            Exit Sub
        End If

        Integer.TryParse(lblTB.Text, _lblTB)
        Integer.TryParse(lblTR.Text, _lblTR)
        Double.TryParse(lblFY.Text, _lblFY)

        If TblLogsTableAdapterMain.Insert(txtlot.Text, txtDevice.Text, _lblTB, _lblTR, _lblFY) Then
            MsgBox("You're Data has been Saved.")
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtlot.Clear()
        txtDevice.Clear()
        txt1LB.Clear()
        txt1LR.Clear()
        txt1LHL.Clear()
        txt1LMU.Clear()
        txt1RB.Clear()
        txt1RR.Clear()
        txt1RHL.Clear()
        txt1RMU.Clear()
        txt2RB.Clear()
        txt2RR.Clear()
        txt2RHL.Clear()
        txt2MU.Clear()
        lblFY.Text = "0"

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

    Private Sub txt1LHL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt1LHL.KeyPress, txt1LB.KeyPress

        '=========== Handler loss should not be greater than 1st load bin 1 ===============

        If Val(txt1LHL.Text) >= Val(txt1LB.Text & e.KeyChar) Then
            Beep()
            e.Handled = True
            MessageBox.Show("Quantity of Handler loss must not be higher than Bin 1 1st_Load", "Error")
            'tltpSave.Show("Quantity of Handler loss must not be higher than Bin 1 1st_Load", txt1LHL)
            txt1LHL.Clear()

        End If

        '1st load handler loss
    End Sub
    Private Sub txt1LMU_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt1LMU.KeyPress

        '============= 1st load Missing Unit ================

        'If Val(txt1LB.Text) < Val(txt1LMU.Text & e.KeyChar) Then
        If Val(txt1LMU.Text) > Val(txt1LB.Text & e.KeyChar) Then
            Beep()
            e.Handled = True
            txt1LMU.Clear()
            MessageBox.Show("Quantity of Missing Unit must not be higher than Bin 1 1st_Load", "Error")
            'tltpSave.Show("Quantity of Missing Unit must not be higher than Bin 1 1st_Load", txt1LMU)
        End If

    End Sub
    Private Sub txt1RB_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt1RB.KeyPress
        '============ 1st Load Rejects >= 1st Reload Bin ========

        If Val(txt1LR.Text) < Val(txt1RB.Text & e.KeyChar) Then
            Beep()
            e.Handled = True
            txt1RB.Clear()
            MessageBox.Show("1st Reload Bin 1 qty must not be higher than Rejects on 1st_Load", "Error")

            'tltpSave.Show("1st Reload Bin 1 qty must not be higher than Rejects on 1st_Load", txt1RB)
        End If
        '1st Load reject < 1st reload Bin

    End Sub
    Private Sub txt1RHL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt1RHL.KeyPress

        'If Val(txt1RB.Text) < Val(txt1RHL.Text & e.KeyChar) Then
        If Val(txt1RHL.Text) > Val(txt1RB.Text & e.KeyChar) Then
            Beep()
            e.Handled = True
            txt1RHL.Clear()
            MessageBox.Show("Handler Loss must not be higher than Bin 1 1st_Load", "Error")

            'tltpSave.Show("Handler Loss must not be higher than Bin 1 1st_Load", txt1RHL)
        End If
        '1st reload handler Loss
    End Sub
    Private Sub txt2RB_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt2RB.KeyPress



        If Val(txt1RR.Text) < Val(txt2RB.Text & e.KeyChar) Then ' 1st reload reject > 2nd reload Bin
            Beep()
            e.Handled = True
            MessageBox.Show("2nd Reload Bin qty must not be higher than Rejects on 1st_Reload ", "Error")
            txt2RB.Clear()
            'tltpSave.Show("2nd Reload Bin 1 qty must not be higher than Rejects on 1st_Reload", txt2RB)
        End If
        '1st reLoad reject < 2nd reload Bin1

    End Sub

    Private Sub txt2RHL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt2RHL.KeyPress

        If Val(txt2RHL.Text) > Val(txt2RB.Text & e.KeyChar) Then '2nd reload Bin handler loss > 2nd reload Bin
            Beep()
            e.Handled = True
            MessageBox.Show("Handler Loss must not be higher than Bin 1 2nd Reload", "Error")
            txt2RHL.Clear()
            'tltpSave.Show("Handler Loss must not be higher than Bin 1 2nd Reload", txt2RHL)
        End If

    End Sub
    Private Sub txt2MU_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt2MU.KeyPress
        If Val(txt2MU.Text) > Val(txt2RB.Text & e.KeyChar) Then ' 2nd reload missing Unit > 2nd reload Bin
            Beep()
            e.Handled = True
            MessageBox.Show("Missing Unit must not be higher than Bin 1 2nd_Reload", "Error")
            txt2MU.Clear()
            'tltpSave.Show("Missing Unit must not be higher than Bin 1 2nd_Reload", txt2MU)

        End If

    End Sub
    'Private Sub _1stReloadReject_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt1LR.KeyPress, txt1RB.KeyPress, txt1RR.KeyPress


    '    'Dim totalBuffer4 As Integer = 0
    '    'Dim parseBuffer4 As Integer = 0
    '    ''=============Bin 1 + Rejects 1st Reload===================='
    '    'Dim sum4 As Integer
    '    'Integer.TryParse(txt1RR.Text, parseBuffer4)
    '    'totalBuffer4 = parseBuffer4
    '    'Integer.TryParse(txt1RB.Text, parseBuffer4)
    '    'totalBuffer4 += parseBuffer4


    '    'sum4 = totalBuffer4
    '    If Val(txt1LR.Text) < (Val(txt1RR.Text) + Val(txt1RB.Text & e.KeyChar)) Then
    '        'If Val(txt1LR.Text) < sum4 Then
    '        Beep()
    '        e.Handled = True
    '        txt1RR.Text = ""
    '        MessageBox.Show("Sum of Bin 1 and Reject of 1st Reload must not be greater than Reject of 1st Load", "Error")
    '        'tltpSave.Show("Sum of Bin 1 and Reject of 1st Reload must not be greater than Reject of 1st Load", txt1RHL)
    '    End If
    'End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Form2.Show()
    End Sub


End Class
