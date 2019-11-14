Option Explicit On
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Try
            Dim SMSEngine As SMSCOMMS
            SMSEngine = New SMSCOMMS(txtComm.Text)
            SMSEngine.Open()
            SMSEngine.SendSMS(txtToAddress.Text, txtBody.Text)
            SMSEngine.Close()
            MsgBox(txtComm.Text & "" & txtBody.Text & "" & txtToAddress.Text, vbInformation + vbOKOnly)
        Catch ex As Exception
            MsgBox(ex.ToString(), vbInformation + vbOKOnly)
        End Try
    End Sub
End Class
