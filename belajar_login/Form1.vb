Imports System.Data.SqlClient
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As SqlCommand
        Dim rd As SqlDataReader
        Dim sql, user, pass As String
        konekdb()
        user = TextBox1.Text
        pass = TextBox2.Text
        sql = "SELECT * FROM tbl_login WHERE Username = '" + TextBox1.Text + "' AND Password = '" + TextBox2.Text + "'"
        cmd = New SqlCommand(sql, koneksi)
        rd = cmd.ExecuteReader
        rd.Read()

        If rd.HasRows = True Then
            MsgBox("Login berhasil!", vbInformation)
            menu_utamavb.Show()
            Me.Hide()
        Else
            MsgBox("Login gagal!", vbExclamation)
        End If
    End Sub
End Class
