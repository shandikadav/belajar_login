Imports System.Data.SqlClient
Module Module1
    Public koneksi As SqlConnection
    Sub konekdb()
        Try
            koneksi = New SqlConnection("Data Source=DESKTOP-D5OLT2H\SQLEXPRESS;initial catalog=login;integrated security=true")
            koneksi.Open()
            'MsgBox("Database terkoneksi", vbInformation)
        Catch ex As Exception
            MsgBox("Database tidak terkoneksi", vbExclamation)
        End Try
    End Sub
End Module
