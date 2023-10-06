Public Class Splash

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Myprogress.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Myprogress.Increment(2)
        Dim percentage As String
        percentage = Convert.ToString(Myprogress.Value)
        percentagelbl.Text = percentage + "%"
        If Myprogress.Value = 100 Then
            Me.Hide()
            Dim use = New user
            user.Show()
        End If
    End Sub

    Private Sub percentagelbl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles percentagelbl.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
