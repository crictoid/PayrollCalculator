' Program:  Payroll Calculator
' Author:   Mark Bulmer
' Date:     February 13, 2022
' Purpose:  This application calculates taxes and displays net income.

Option Strict On

Public Class frmPayroll

    ' Tax rates - used in multiple procedures
    Const _cdecFICATax As Decimal = 0.0765D
    Const _cdecFederalTax As Decimal = 0.22D
    Const _cdecStateTax As Decimal = 0.04D


    Private Sub btnCost_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCost.Click
        ' This event handler is executed when the user clicks the
        ' Display Tax button. It calculates and displays the total
        ' amount of taxes for each type.

        Dim strBiweeklyPay As String
        Dim intBiweeklyPay As Integer
        Dim decFICACost As Decimal
        Dim decFederalCost As Decimal
        Dim decStateCost As Decimal
        Dim decNetCost As Decimal

        strBiweeklyPay = txtBiweeklyPay.Text
        intBiweeklyPay = Convert.ToInt32(strBiweeklyPay)
        decFICACost = intBiweeklyPay * _cdecFICATax
        lblFICACost.Text = decFICACost.ToString("C")
        decFederalCost = intBiweeklyPay * _cdecFederalTax
        lblFederalCost.Text = decFederalCost.ToString("C")
        decStateCost = intBiweeklyPay * _cdecStateTax
        lblStateCost.Text = decStateCost.ToString("C")
        decNetCost = intBiweeklyPay - decFICACost - decFederalCost - decStateCost
        lblNetCost.Text = decNetCost.ToString("C")
    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click
        ' This event handler is executed when the user clicks the
        ' Clear button. It clears the number of days text box
        ' and the Text property of the Display Tax label.
        ' Then it sets the focus on the txtBiweeklyPay Textbox object.

        txtBiweeklyPay.Clear()
        lblFICACost.Text = ""
        lblFederalCost.Text = ""
        lblStateCost.Text = ""
        lblNetCost.Text = ""
        txtBiweeklyPay.Focus()

    End Sub

    Private Sub frmDigitalDownloads_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' This event handler is executed when the form is loaded.
        ' It displays the cost heading, clears the Text property of the
        ' Total Cost label, and sets the focus on
        '  the txtBiweeklyPay Textbox object.

        lblFICACost.Text = ""
        lblFederalCost.Text = ""
        lblStateCost.Text = ""
        lblNetCost.Text = ""
        txtBiweeklyPay.Focus()

    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit.Click
        ' Close the window and terminate the application.

        Close()
    End Sub

End Class
