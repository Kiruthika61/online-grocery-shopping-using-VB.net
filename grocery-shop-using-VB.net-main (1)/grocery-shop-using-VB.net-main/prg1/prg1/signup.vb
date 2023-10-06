
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlCommand


Public Class signup

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Missing Information")
        Else
            Try
                Dim con As SqlConnection = New SqlConnection("Data Source=JEEVITHA\SQLEXPRESS8;Initial Catalog=idusvb;Integrated Security=True")
                Dim cmd As SqlCommand = New SqlCommand("INSERT INTO [idusvb].[dbo].[idus]  ([name],[address],[phone],[password])  values('" + TextBox1.Text + "','" + TextBox2.Text + "', '" + TextBox3.Text + "','" + TextBox4.Text + "')")
                con.Open()

                con.Close()

                Dim Obj = New Items
                Obj.Show()
                Me.Hide()
            Catch d As Exception

            End Try
        End If

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub signup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class





