Public Class login

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Dim Obj = New Employees
        Obj.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If UnameTb.Text = "" Or PasswordTb.Text = "" Then
            MsgBox("Enter UserName and Password")
        ElseIf UnameTb.Text = "Admin" And PasswordTb.Text = "Password" Then
            Dim Obj = New Items
            Obj.Show()
            Me.Hide()
        ElseIf UnameTb.Text = "Sandra" And PasswordTb.Text = "123.s" Then
            Dim Obj = New Items
            Obj.Show()
            Me.Hide()
        ElseIf UnameTb.Text = "Raj" And PasswordTb.Text = "34567" Then
            Dim Obj = New Items
            Obj.Show()
            Me.Hide()
        Else
            MsgBox("Wrong UserName or Password")
            UnameTb.Text = ""
            PasswordTb.Text = ""


        End If
    End Sub

    Sub newShow()
        Throw New NotImplementedException
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub
End Class