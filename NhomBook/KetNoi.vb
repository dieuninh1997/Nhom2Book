﻿Imports System.Data.SqlClient
Public Class KetNoi
    Dim connectString As String = "Data Source=DIEUNINH\SQLEXPRESS;Initial Catalog=QuanLyBanSach;Integrated Security=True"
    Public cmd As New SqlCommand
    Public da As New SqlDataAdapter
    Public con As New SqlConnection
    Public Sub New()
        con = New SqlConnection
        con.ConnectionString = connectString
    End Sub


    Public Sub OpenConnect()
        '  con = New SqlConnection("Data Source=DESKTOP-R7TCLO5;Initial Catalog=quanlysach;Integrated Security=True")
        Try
            If con.State <> ConnectionState.Open Then
                con.ConnectionString = connectString
                con.Open()
            End If


        Catch ex As Exception
            MsgBox(ex.ToString)

        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try

    End Sub
    Public Function CloseConnect()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return con
    End Function
    Public Function getData(ByVal sql As String) As DataTable
        OpenConnect()

        cmd = New SqlCommand(sql, con)
        cmd.CommandType = CommandType.StoredProcedure
        da = New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function

    Public Sub excue()
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Function Add(ByVal sql As String, ByVal Name() As String, ByVal Values() As Object, ByVal _soluong As Integer) As Integer
        Dim i As Integer
        Dim kq As Integer = -1
        cmd = New SqlCommand(sql, con)
        cmd.CommandType = CommandType.StoredProcedure
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        For i = 0 To _soluong
            cmd.Parameters.AddWithValue(Name(i), Values(i))
        Next
        Try
            kq = cmd.ExecuteNonQuery
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return kq
    End Function


    Public Function checkID(ByVal sql As String, ByVal Name() As String, ByVal Values() As String, ByVal _soluong As Integer) As DataTable
        Dim i As Integer

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd = New SqlCommand(sql, con)
        cmd.CommandType = CommandType.StoredProcedure
        For i = 0 To _soluong
            cmd.Parameters.AddWithValue(Name(i), Values(i))
        Next
        da = New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function checkID(ByVal sql As String, ByVal Name() As String, ByVal Values() As Integer, ByVal _soluong As Integer) As DataTable
        Dim i As Integer

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd = New SqlCommand(sql, con)
        cmd.CommandType = CommandType.StoredProcedure
        For i = 0 To _soluong
            cmd.Parameters.AddWithValue(Name(i), Values(i))
        Next
        da = New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function

    Protected Overloads Sub Dispose()
        CloseConnect()
        GC.SuppressFinalize(Me)
    End Sub

End Class