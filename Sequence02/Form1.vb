Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intNum1 As Integer = 1
        Dim intNum2 As Integer = 2
        Dim intNum3 As Integer = 3
        Dim intTotal As Integer = 2

        Dim intOdd As Integer

        lstRecord.Items.Clear()
        lstRecord.Items.Add(intNum1)
        lstRecord.Items.Add(intNum2)
        lstRecord.Items.Add(intNum3)

        Do While intNum1 <= 4000000 And intNum2 <= 4000000 And intNum3 <= 4000000

            intNum1 = intNum2 + intNum3
            lstRecord.Items.Add(intNum1)
            If intNum1 Mod 2 > 0 Then
                intOdd += intNum1
            Else
                intTotal += intNum1
            End If

            intNum2 = intNum3 + intNum1
            lstRecord.Items.Add(intNum2)
            If intNum2 Mod 2 > 0 Then
                intOdd += intNum2
            Else
                intTotal += intNum2
            End If

            intNum3 = intNum1 + intNum2

            If intNum3 < 4000000 Then
                lstRecord.Items.Add(intNum3)
            End If

            If intNum3 Mod 2 > 0 Then
                intOdd += intNum3
            Else
                intTotal += intNum3
            End If

            lblTotal.Text = CStr(intTotal)

        Loop

    End Sub
End Class
