Public Class Form1
    Dim x, y As Integer
    Dim newpoint As Point
    Private Sub Formhome1_Load(sender As Object, e As EventArgs)
        FormBook1.Visible = False
        FormBook1.FormTacgia1.Visible = False
        FormBook1.FormTheLoai1.Visible = False
        FormNCC1.Visible = False
        FormPhieuNhap1.Visible = False


    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Formhome1.BringToFront()
        Formhome1.Visible = True

    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        FormBook1.BringToFront()
        FormBook1.Visible = True
        Formhome1.Visible = False



    End Sub

    Private Sub btnProvider_Click(sender As Object, e As EventArgs) Handles btnProvider.Click
        FormNCC1.BringToFront()
        FormNCC1.Visible = True
        FormBook1.Visible = False
        Formhome1.Visible = False


    End Sub

    Private Sub btnImportedBook_Click(sender As Object, e As EventArgs) Handles btnImportedBook.Click
        FormPhieuNhap1.BringToFront()
        FormPhieuNhap1.Visible = True
        FormBook1.Visible = False
        Formhome1.Visible = False
        FormNCC1.Visible = False


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnMini_Click(sender As Object, e As EventArgs) Handles btnMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub panel_MouseDown(sender As Object, e As MouseEventArgs) Handles panel.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub btnScroll_Click(sender As Object, e As EventArgs) Handles btnScroll.Click
        If panelMenu.Width = 185 Then
            'tranlogo.HideSync(pcb1)
            panelMenu.Visible = False
            panelMenu.Width = 45
            ' tranpanel.ShowSync(pnlMenu)
            btnScroll.Location = New Point(18, 60)
        Else
            panelMenu.Width = 185
            btnScroll.Location = New Point(167, 60)
            ' tranlogo.ShowSync(pcb1)
            ' tranpanel.ShowSync(pnlMenu)
        End If
    End Sub


    Private Sub panel_MouseMove(sender As Object, e As MouseEventArgs) Handles panel.MouseMove
        If e.Button Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub
End Class
