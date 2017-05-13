Public Class FormBook
    Dim dem As Integer
    Private Sub FormBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 1015
        Me.Height = 664


    End Sub

    Private Sub btnSach_Click(sender As Object, e As EventArgs) Handles btnSach.Click

        separator.Width = btnSach.Width
        separator.Left = btnSach.Left
        FormTacgia1.Visible = False
        FormTheLoai1.Visible = False






        ' btnSach.Text = Font.Bold
        ' btnSach.Text = Font.Bold
        ' btnSach.Text = Font.Bold
    End Sub

    Private Sub btnTacgia_Click(sender As Object, e As EventArgs) Handles btnTacgia.Click
        separator.Width = btnTacgia.Width
        separator.Left = btnTacgia.Left
        FormTacgia1.BringToFront()
        FormTacgia1.Visible = True
        FormTheLoai1.Visible = False
    End Sub

    Private Sub btnTheloai_Click(sender As Object, e As EventArgs) Handles btnTheloai.Click
        separator.Width = btnTheloai.Width
        separator.Left = btnTheloai.Left
        FormTheLoai1.BringToFront()
        FormTheLoai1.Visible = True
        FormTacgia1.Visible = False
    End Sub
End Class
