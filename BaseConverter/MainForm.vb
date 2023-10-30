Imports System.ComponentModel

Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Rad16.Checked = True
    End Sub

    Private Sub MainForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim dlgUserConfirm As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If dlgUserConfirm = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub BtnConvert_Click(sender As Object, e As EventArgs) Handles BtnConvert.Click
        Try
            Dim strBin As String = Txt2.Text.Trim()
            Dim dblDec As Double
            Dim strOutput As String = ""

            Select Case True
                Case Rad4.Checked, Rad8.Checked, Rad16.Checked
                    dblDec = ConvertToDecimal(strBin)

                    If dblDec Mod 1 <> 0 Then
                        Dim intDivisor As Integer

                        Select Case True
                            Case Rad4.Checked
                                intDivisor = 4
                            Case Rad8.Checked
                                intDivisor = 8
                            Case Rad10.Checked
                                intDivisor = 10
                            Case Rad16.Checked
                                intDivisor = 16
                            Case Else
                        End Select

                        Dim intCounter As Integer
                        Do Until dblDec Mod 1 = 0
                            dblDec *= intDivisor
                            intCounter += 1
                        Loop

                        strOutput = ConvertFromDecimal(dblDec)
                        strOutput = strOutput.Insert(Len(strOutput) - intCounter, ".")
                    Else
                        strOutput = ConvertFromDecimal(dblDec)
                    End If

                Case Rad10.Checked
                    strOutput = CStr(ConvertToDecimal(strBin))
            End Select

            TxtOut.Text = PrintOutput(strBin, strOutput)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click, ResetToolStripMenuItem.Click
        Txt2.Clear()
        TxtOut.Clear()
    End Sub

    Private Sub Txt2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt2.KeyPress
        Dim KeyCode As Integer = AscW(e.KeyChar)

        ' Prevent user entering invalid input
        If Not (
            KeyCode = 48 OrElse KeyCode = 49 OrElse
            KeyCode = 8 OrElse
            KeyCode = 46 And (Not sender.Text.Contains(".") OrElse sender.SelectedText.Contains("."))
        ) Then
            e.KeyChar = Nothing
        End If
    End Sub

    Private Function ConvertToDecimal(strBin As String) As Double
        Dim strSplit() As String = Split(strBin, ".")
        Dim dblRes As Double = 0

        If strSplit.Length >= 2 Then
            Dim intLenLower As Integer = Len(strSplit(1))
            For i As Integer = 1 To intLenLower
                dblRes += Convert.ToDouble(Mid(strSplit(1), i, 1)) * 2 ^ -i
            Next
        End If

        Dim intLenUpper As Integer = Len(strSplit(0))
        For i As Integer = 0 To intLenUpper - 1
            dblRes += Convert.ToDouble(Mid(strSplit(0), intLenUpper - i, 1)) * 2 ^ i
        Next

        Return dblRes
    End Function

    Private Function ConvertFromDecimal(dblDec As Double) As String
        Dim intDivisor As Integer

        Select Case True
            Case Rad4.Checked
                intDivisor = 4
            Case Rad8.Checked
                intDivisor = 8
            Case Rad10.Checked
                intDivisor = 10
            Case Rad16.Checked
                intDivisor = 16
            Case Else
        End Select

        Dim intRemaining As Integer = dblDec
        Dim intRemainder As Integer
        Dim strOutput As String = ""
        Dim strRemainder As String

        Do Until intRemaining <= 0
            intRemainder = intRemaining Mod intDivisor
            intRemaining \= intDivisor

            Select Case intRemainder
                Case 10
                    strRemainder = "A"
                Case 11
                    strRemainder = "B"
                Case 12
                    strRemainder = "C"
                Case 13
                    strRemainder = "D"
                Case 14
                    strRemainder = "E"
                Case 15
                    strRemainder = "F"
                Case Else
                    strRemainder = CStr(intRemainder)
            End Select
            strOutput = strRemainder & strOutput
        Loop

        Return strOutput
    End Function

    Private Function PrintOutput(strBinInput As String, strOutput As String) As String
        Dim Base As String = ""

        Select Case True
            Case Rad4.Checked
                Base = "Quarternary"
            Case Rad8.Checked
                Base = "Octal"
            Case Rad10.Checked
                Base = "Decimal"
            Case Rad16.Checked
                Base = "Hexadecimal"
        End Select

        Return "The " & Base & " equivalent of the Binary number " & strBinInput & " is " & strOutput
    End Function

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutMeForm.ShowDialog()
    End Sub
End Class
