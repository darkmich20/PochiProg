﻿Imports System.ComponentModel

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

        If sum > Val(txt1LB.Text) Then
            Beep()
            txt1LMU.Clear()
            MessageBox.Show("Sum of Handler Loss and Missing Unit must not be greater than Bin 1 Summary(1st Load)", "Error")

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

        If sum2 > Val(txt1RB.Text) Then
            Beep()
            txt1RMU.Clear()
            MessageBox.Show("Sum of Handler Loss and Missing Unit must not be greater than Bin 1 Summary(1st Reload)", "Error")

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
            txt2MU.Clear()
            MessageBox.Show("Sum of Handler Loss and Missing Unit must not be greater than Bin 1 Summary(2nd ReLoad)", "Error")


        End If

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


    End Sub
    Private Sub _2ndReload_TextChanged(sender As Object, e As EventArgs) Handles txt2RR.TextChanged, txt2RHL.TextChanged, txt2RB.TextChanged, txt2MU.TextChanged
        Dim totalBuffer As Integer = 0
        Dim parseBuffer As Integer = 0

        '============== Actual Bin 1 2nd reload ======================' 
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


    Private Sub _1stLoad_HandlerLoss_TextChanged(sender As Object, e As EventArgs) Handles txt1LHL.TextChanged
        '=========== Handler loss should not be greater than 1st load bin 1 ===============

        If Val(txt1LHL.Text) >= Val(txt1LB.Text) Then
            Beep()
            txt1LHL.Clear()
            MessageBox.Show("Quantity of Handler loss( 1st load) must not be higher than Bin 1 of 1st Load", "Error")
            'tltpSave.Show("Quantity of Handler loss must not be higher than Bin 1 1st_Load", txt1LHL)


        End If
    End Sub

    Private Sub _1stReLoad_HandlerLoss_TextChanged(sender As Object, e As EventArgs) Handles txt1RHL.TextChanged
        '=========== Handler loss should not be greater than 1st Reload bin 1 ===============

        If Val(txt1RHL.Text) >= Val(txt1RB.Text) Then
            Beep()
            txt1RHL.Clear()
            MessageBox.Show("Quantity of Handler loss( 1st Reload) must not be higher than Bin 1 of 1st ReLoad", "Error")
            'tltpSave.Show("Quantity of Handler loss must not be higher than Bin 1 1st_Load", txt1LHL)


        End If
    End Sub


    Private Sub _2ndReLoad_HandlerLoss_TextChanged(sender As Object, e As EventArgs) Handles txt2RHL.TextChanged
        '=========== Handler loss should not be greater than 2nd Reload bin 1 ===============

        If Val(txt2RHL.Text) >= Val(txt2RB.Text) Then
            Beep()
            txt2RHL.Clear()
            MessageBox.Show("Quantity of Handler loss( 2nd Reload) must not be higher than Bin 1 of 2nd ReLoad", "Error")
            'tltpSave.Show("Quantity of Handler loss must not be higher than Bin 1 1st_Load", txt1LHL)


        End If
    End Sub

    Private Sub _1stLoad_MissingUnit_TextChanged(sender As Object, e As EventArgs) Handles txt1LMU.TextChanged
        '=========== Missing Unit should not be greater than 1st load bin 1 ===============

        If Val(txt1LMU.Text) >= Val(txt1LB.Text) Then
            Beep()
            txt1LMU.Clear()
            MessageBox.Show("Quantity of Missing Unit must not be higher than Bin 1 1st_Load", "Error")
            'tltpSave.Show("Quantity of Handler loss must not be higher than Bin 1 1st_Load", txt1LHL)


        End If
    End Sub
    Private Sub _1stReload_Reject_plus_Bin_TextChanged(sender As Object, e As EventArgs) Handles txt1RB.TextChanged, txt1RR.TextChanged, txt1LR.TextChanged

        Dim totalBuffer As Integer = 0
        Dim parseBuffer As Integer = 0
        '=============1st Reload Bin 1 + Reject================'
        Dim rejLR As Integer
        Integer.TryParse(txt1RB.Text, parseBuffer) '1st Reload Hadler Loss 
        totalBuffer = parseBuffer ' +
        Integer.TryParse(txt1RR.Text, parseBuffer) ' 1st reload Missing Unit
        totalBuffer += parseBuffer

        rejLR = totalBuffer

        If rejLR > Val(txt1LR.Text) Then
            Beep()
            txt1RR.Clear()
            MessageBox.Show("Sum of 1st Reload Bin 1 and 1st Reload Reject must not be greater than Reject of 1st load", "Error")


        End If
        '====================================================================='
    End Sub

    Private Sub _2ndReload_Reject_plus_Bin_TextChanged(sender As Object, e As EventArgs) Handles txt2RB.TextChanged, txt2RR.TextChanged, txt1RR.TextChanged

        Dim totalBuffer As Integer = 0
        Dim parseBuffer As Integer = 0
        '=============2nd Reload Bin 1 + Reject================'
        Dim Rej2 As Integer
        Integer.TryParse(txt2RB.Text, parseBuffer) '2nd Reload bIN 
        totalBuffer = parseBuffer ' +
        Integer.TryParse(txt2RR.Text, parseBuffer) ' 2nd reload Reject
        totalBuffer += parseBuffer

        Rej2 = totalBuffer

        If Rej2 > Val(txt1RR.Text) Then
            Beep()
            txt2RR.Clear()
            MessageBox.Show("Sum of 2nd Reload Bin 1 and 2nd Reload Reject must not be greater than Reject of 1st Reload", "Error")


        End If
        '====================================================================='
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

    Private Sub txt2RB_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt2RB.KeyPress

        If Val(txt1RR.Text) < Val(txt2RB.Text & e.KeyChar) Then ' 1st reload reject > 2nd reload Bin
            Beep()
            e.Handled = True
            txt2RB.Clear()
            MessageBox.Show("2nd Reload Bin qty must not be higher than Rejects on 1st_Reload ", "Error")

            'tltpSave.Show("2nd Reload Bin 1 qty must not be higher than Rejects on 1st_Reload", txt2RB)
        End If
        '1st reLoad reject < 2nd reload Bin1

    End Sub
    Private Sub txt2MU_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt2MU.KeyPress
        If Val(txt2MU.Text) > Val(txt2RB.Text & e.KeyChar) Then ' 2nd reload missing Unit > 2nd reload Bin
            Beep()
            e.Handled = True
            txt2MU.Clear()
            MessageBox.Show("Missing Unit must not be higher than Bin 1 2nd_Reload", "Error")

            'tltpSave.Show("Missing Unit must not be higher than Bin 1 2nd_Reload", txt2MU)

        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Form2.Show()
    End Sub

    'Private Sub txt1LoadBin_TextChanged(sender As Object, e As EventArgs) Handles txt1LR.TextChanged
    '    '============ Reject 1st Load ========

    '    If Val(txt1LR.Text) > Val(txt1LB.Text) Then
    '        Beep()
    '        txt1LR.Clear()
    '        MessageBox.Show("1st load Reject QTY must not be higher than Bin 1 of 1st_Load", "Error")

    '    End If
    'End Sub
    'Private Sub txt1ReloadRej_TextChanged(sender As Object, e As EventArgs) Handles txt1RR.TextChanged
    '    '============ Reject 1st Reload ========

    '    If Val(txt1RR.Text) > Val(txt1RB.Text) Then
    '        Beep()
    '        txt1RR.Clear()
    '        MessageBox.Show("1st Reload Reject QTY must not be higher than Bin 1 of 1st_Load", "Error")

    '    End If
    'End Sub

    'Private Sub txt2ReloadRej_TextChanged(sender As Object, e As EventArgs) Handles txt2RR.TextChanged
    '    '============ Reject 2nd Reload ========

    '    If Val(txt2RR.Text) > Val(txt2RB.Text) Then
    '        Beep()
    '        txt2RR.Clear()
    '        MessageBox.Show("2nd Reload Reject QTY must not be higher than Bin 1 of 1st_Load", "Error")

    '    End If
    'End Sub











End Class
