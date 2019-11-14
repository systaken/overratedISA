<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtToAddress = New System.Windows.Forms.TextBox()
        Me.txtBody = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtComm = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtToAddress
        '
        Me.txtToAddress.AcceptsReturn = True
        Me.txtToAddress.Location = New System.Drawing.Point(108, 50)
        Me.txtToAddress.Name = "txtToAddress"
        Me.txtToAddress.Size = New System.Drawing.Size(163, 20)
        Me.txtToAddress.TabIndex = 9
        '
        'txtBody
        '
        Me.txtBody.Location = New System.Drawing.Point(108, 77)
        Me.txtBody.Multiline = True
        Me.txtBody.Name = "txtBody"
        Me.txtBody.Size = New System.Drawing.Size(404, 71)
        Me.txtBody.TabIndex = 10
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(108, 154)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(404, 24)
        Me.btnSend.TabIndex = 11
        Me.btnSend.Text = "S&end"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "&Body:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "&ToAddress:"
        '
        'txtComm
        '
        Me.txtComm.AcceptsReturn = True
        Me.txtComm.Location = New System.Drawing.Point(108, 24)
        Me.txtComm.Name = "txtComm"
        Me.txtComm.Size = New System.Drawing.Size(163, 20)
        Me.txtComm.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 450)
        Me.Controls.Add(Me.txtComm)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtToAddress)
        Me.Controls.Add(Me.txtBody)
        Me.Controls.Add(Me.btnSend)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtToAddress As TextBox
    Friend WithEvents txtBody As TextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtComm As TextBox
End Class
