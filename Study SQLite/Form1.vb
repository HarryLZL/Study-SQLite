Imports System.Data.SQLite

Public Class Form1
    Dim int_MouseX, int_MouseY As Integer
    Private dbPath As String = Application.StartupPath.ToString & "DB\masterDB.db"

#Region "数据库操作"
    ''' <summary>
    ''' 创建表
    ''' </summary>
    Private Sub Button_CreateTable_Click(sender As Object, e As EventArgs) Handles Button_CreateTable.Click
        Dim sql As String = "CREATE TABLE TB_UserInfo (ID INTEGER, Name TEXT, Password text)"
        'Dim dbPath As String = System.IO.Directory.GetCurrentDirectory & "\DB\masterDB.db"
        Try
            Using conn As New SQLiteConnection($"data source={dbPath}")
                Using comm As New SQLiteCommand(sql, conn)
                    conn.Open()
                    comm.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' 检索数据库 TB_UserInfo 表
    ''' </summary>
    Private Sub Button_Serarch_Click(sender As Object, e As EventArgs) Handles Button_Serarch.Click
        Dim sql As String = "SELECT * FROM TB_UserInfo"
        Dim dt As New DataTable
        Try
            Using conn As New SQLiteConnection($"data source={dbPath}")
                Using da As New SQLiteDataAdapter(sql, conn)
                    da.Fill(dt)
                End Using
            End Using
            DataGridView_Search.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
    Private Sub Button_Insert_Click(sender As Object, e As EventArgs) Handles Button_Insert.Click
        Dim newID As Integer = Take_MaxID_Value() + 1
        Dim sql As String = $"INSERT INTO TB_UserInfo(ID, Name, Password) VALUES({newID}, '{TextBox_UserName.Text.Trim}', '{TextBox_Password.Text.Trim}')"
        If IsDBNull(newID) Then newID = 1
        Try
            Using conn As New SQLiteConnection($"data source={dbPath}")
                Using comm As New SQLiteCommand(sql, conn)
                    conn.Open()
                    comm.ExecuteNonQuery()
                End Using
            End Using
            Call Button_Serarch_Click(Nothing, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Function Take_MaxID_Value() As Integer
        Dim sql As String = "SELECT CASE WHEN MAX(ID) IS NULL THEN 0 ELSE MAX(ID) END FROM TB_UserInfo"
        Using conn As New SQLiteConnection($"data source={dbPath}")
            Using comm As New SQLiteCommand(sql, conn)
                conn.Open()
                Take_MaxID_Value = comm.ExecuteScalar()
            End Using
        End Using
    End Function

#End Region

#Region "人性化控制"
    Private Sub Button_CreateTable_MouseMove(sender As Object, e As MouseEventArgs) Handles Button4.MouseMove, Button3.MouseMove, Button_Insert.MouseMove, Button_Serarch.MouseMove, Button_CreateTable.MouseMove
        sender.BackColor = Color.CornflowerBlue
    End Sub

    Private Sub Button_CreateTable_MouseLeave(sender As Object, e As EventArgs) Handles Button4.MouseLeave, Button3.MouseLeave, Button_Insert.MouseLeave, Button_Serarch.MouseLeave, Button_CreateTable.MouseLeave
        sender.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub Panel_Title_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel_Title.MouseDown
        int_MouseX = e.X : int_MouseY = e.Y
    End Sub

    Private Sub Panel_Title_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel_Title.MouseMove
        If int_MouseX = e.X And int_MouseY = e.Y Then Exit Sub
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Left = Me.Left + e.X - int_MouseX
            Me.Top = Me.Top + e.Y - int_MouseY
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Button_Serarch_Click(Nothing, Nothing)
    End Sub
#End Region

    Private Sub Button_Quit_Click(sender As Object, e As EventArgs) Handles Button_Quit.Click
        Me.Close()
    End Sub
End Class
