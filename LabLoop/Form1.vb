Imports System.ComponentModel

Public Class Form1
    Private Sub CalculateBtn_Click(sender As Object, e As EventArgs) Handles CalculateBtn.Click
        ' start num must be positive number
        If Val(StartNumTextbox.Text) < 0 Then
            MsgBox("กรุณาใส่ตัวเลขเริ่มต้นมีค่ามากกว่า 0", vbExclamation, "Warning")
        End If

        ' end num must greater than start num
        If Val(EndNumTextbox.Text) < Val(StartNumTextbox.Text) Then
            MsgBox("กรุณาใส่ตัวเลขสิ้นสุดให้มีค่ามากกว่าเลขเริ่มต้น", vbExclamation, "Warning")
        End If

        ' end num must less than 1000
        If Val(EndNumTextbox.Text) > 1000 Then
            MsgBox("กรุณาใส่ตัวเลขสิ้นสุดให้มีค่าไม่เกิน 1,000", vbExclamation, "Warning")
        End If

        ' calculate
        StartValueResultLabel.Text = StartNumTextbox.Text
        EndValueResultLabel.Text = EndNumTextbox.Text

        ' initialize startnumber and endnumber
        Dim i As Integer = Val(StartNumTextbox.Text)
        Dim endNum As Integer = Val(EndNumTextbox.Text)

        ' make start num always a odd number
        If i Mod 2 = 0 Then
            i += 1
        End If

        Dim sum As Integer
        While i <= endNum
            sum += i
            i += 2
        End While

        ValueResultLabel.Text = sum

    End Sub
End Class
