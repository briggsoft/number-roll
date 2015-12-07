Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim random As New Random()
        Dim number As Integer
        random = New Random
        number = random.Next(0, 85)
        Label1.Text = number.ToString
        If Label1.Text = ("42") Then
            MsgBox("Middle number = 42 Generate again")
        End If
        If Label1.Text = ("3") Then
            Label1.ForeColor = Color.Teal
        End If
        If Label1.Text = ("7") Then
            Label1.ForeColor = Color.Red
        End If
        If Label1.Text = ("14") Then
            Label1.ForeColor = Color.BlueViolet
        End If
        If Label1.Text = ("1") Then
            Label1.ForeColor = Color.Cornsilk
        End If
        If Label1.Text = ("45") Then
            Label1.ForeColor = Color.Coral
        End If
        If Label1.Text = ("1") Then
            Label1.ForeColor = Color.PaleGreen
        End If
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Label1.Text = ("42") Then
            MsgBox("Middle number = 42 Generate again")
        End If
        If Label1.Text = ("3") Then
            Label1.ForeColor = Color.Teal
        End If
        If Label1.Text = ("7") Then
            Label1.ForeColor = Color.Red
        End If
        If Label1.Text = ("14") Then
            Label1.ForeColor = Color.BlueViolet
        End If
        If Label1.Text = ("1") Then
            Label1.ForeColor = Color.Cornsilk
        End If
        If Label1.Text = ("45") Then
            Label1.ForeColor = Color.Coral
        End If
        If Label1.Text = ("1") Then
            Label1.ForeColor = Color.PaleGreen
        End If
    End Sub
End Class
