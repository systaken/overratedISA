Option Explicit On
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim SMSEngine As SMSCOMMS
        SMSEngine = New SMSCOMMS(txtComm.Text)
        SMSEngine.Open()
        SMSEngine.SendSMS(txtToAddress.Text, txtBody.Text)
        SMSEngine.Close()
    End Sub
End Class
