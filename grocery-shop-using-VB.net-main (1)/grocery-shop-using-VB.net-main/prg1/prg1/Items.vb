Imports System.Data.SqlClient
Public Class Items
    Dim con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\jeevi\OneDrive\Documents\GroceryDbVb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")

    Public Property d As Object

    Public Property c As Object

    Public Property a As String

    Public Property b As Double

    Private Sub Items_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QtyTb.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ItnameTb.Text = "" Or QtyTb.Text = "" Or CatCb.SelectedIndex = -1 Or PriceTb.SelectedItem = "" Then
            MsgBox("Missing Information")
        Else
            Try
                con.Open()
                Dim query = "insert into UserTb2 values('" & ItnameTb.Text & "'," & QtyTb.Text & "," & PriceTb.SelectedItem.ToVal() & ",'" & CatCb.SelectedItem.ToString() & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Items Saved Successfully")
                con.Close()

            Catch ex As Exception

            End Try

        End If
        a = ItnameTb.Text
        d = CatCb.SelectedItem
        b = Val(QtyTb.Text)
        c = Val(PriceTb.SelectedItem)
        If a = "apple" And b = "10" Or "20" Or "30" Or "40" Or "50" Or "12" Or "15" And c = "100" Or "200" Or "150" Or "50" And d = "FRUIT" Then
            MsgBox("Item saved successfully")
        ElseIf a = "orange" And b = "10" Or "20" Or "30" Or "40" Or "50" Or "12" Or "15" And c = "100" Or "200" Or "150" Or "50" And d = "FRUIT" Then
            MsgBox("Item saved successfully")
        ElseIf a = "banana" And b = "10" Or "20" Or "30" Or "40" Or "50" Or "12" Or "15" And c = "100" Or "200" Or "150" Or "50" And d = "FRUIT" Then
            MsgBox("Item saved successfully")
        ElseIf a = "fig" And b = "10" Or "20" Or "30" Or "40" Or "50" Or "12" Or "15" And c = "100" Or "200" Or "150" Or "50" And d = "FRUIT" Then
            MsgBox("Item saved successfully")
        ElseIf a = "grapes" And b = "10" Or "20" Or "30" Or "40" Or "50" Or "12" Or "15" And c = "100" Or "200" Or "150" Or "50" And d = "FRUIT" Then
            MsgBox("Item saved successfully")
        Else
            MsgBox("product is currently unavailable")
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub
    Private Sub clear()
        ItnameTb.Text = ""
        QtyTb.Text = ""
        PriceTb.Text = ""
        CatCb.SelectedIndex = 0
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        clear()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PriceTb.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        clear()

    End Sub

    Private Sub ItnameTb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItnameTb.TextChanged

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim Obj = New billing
        Obj.Show()
        Me.Hide()
    End Sub
End Class