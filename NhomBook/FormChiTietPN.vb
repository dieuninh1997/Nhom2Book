Imports System.Data.SqlClient

Public Class FormChiTietPN
    Dim kn As New KetNoi
    Dim directory As String = My.Application.Info.DirectoryPath

    Private Sub FormChiTietPN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NameHeaderDgv()
        dgChitietPn.Columns("mapn").HeaderText = "Mã phiếu nhập"
        dgChitietPn.Columns("mas").HeaderText = "Mã sách"
        dgChitietPn.Columns("soluong").HeaderText = "Số lượng"
        dgChitietPn.Columns("dongia").HeaderText = "Đơn giá"
        dgChitietPn.Columns("dvt").HeaderText = "Đơn vị tính"
        dgChitietPn.Columns("thanhtien").HeaderText = "Thành tiền"
    End Sub
    Private Sub ShowData(ByVal id As String)
        ' MsgBox(id)

        Dim _soluong As Integer
        _soluong = 0
        Dim sql As String
        sql = "checkIDCtpn"
        Dim Name(_soluong) As String
        Dim Value(_soluong) As String
        Name(0) = "@ma"
        Value(0) = id
        dgChitietPn.DataSource = kn.checkID(sql, Name, Value, _soluong)

    End Sub

    Private Sub btnInPn_Click(sender As Object, e As EventArgs) Handles btnInPn.Click
        Dim SaveFileDialog1 As SaveFileDialog = New SaveFileDialog()

        Dim colName As String = "Mã phiếu nhập,Mã sách,Số lượng,Đơn giá,Đơn vị tính,Thành tiền"
        Try
            SaveFileDialog1.Filter = "Excel (*.xlsx)|*.xlsx"
            SaveFileDialog1.ShowDialog()
            Dim File_name = SaveFileDialog1.FileName
            Export_to_Excel(dgChitietPn.DataSource, colName, File_name)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub picExit_Click(sender As Object, e As EventArgs) Handles picExit.Click
        Try
            Me.Hide()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    Private Sub txtMapnCtpn_TextChanged(sender As Object, e As EventArgs) Handles txtMapnCtpn.TextChanged
        ShowData(Me.txtMapnCtpn.Text)
        NameHeaderDgv()
    End Sub
End Class
