Imports System.IO
Public Class admin

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim jarcheck As Boolean = CheckBoxjar.Checked
        Dim configcheck As Boolean = CheckBoxconfig.Checked
        File.Delete("serverbuild")
        Using write1 As StreamWriter = File.AppendText("serverbuild")
            write1.WriteLine(TextBox1.Text)
            write1.WriteLine(jarcheck)
            write1.WriteLine(configcheck)
            write1.Close()
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        File.Delete("servermodlist")
        File.Delete("servercoremodlist")
        File.Delete("serverclientonlymodlist")
        Try
            Dim o As New System.IO.DirectoryInfo(".\mods\")
            Dim myfiles() As System.IO.FileInfo
            myfiles = o.GetFiles("*")
            Using write1 As StreamWriter = File.AppendText("servermodlist")
                For x As Integer = 0 To myfiles.Length - 1
                    write1.WriteLine(myfiles(x).Name())
                Next
                write1.Close()
            End Using

            Dim p As New System.IO.DirectoryInfo(".\coremods\")
            Dim myfiles2() As System.IO.FileInfo
            myfiles2 = p.GetFiles("*")
            Using write1 As StreamWriter = File.AppendText("servercoremodlist")
                For y As Integer = 0 To myfiles2.Length - 1
                    write1.WriteLine(myfiles2(y).Name())
                Next
                write1.Close()
            End Using

            Dim q As New System.IO.DirectoryInfo(".\clientonlymods\")
            Dim myfiles3() As System.IO.FileInfo
            myfiles3 = q.GetFiles("*")
            Using write1 As StreamWriter = File.AppendText("serverclientonlymodlist")
                For z As Integer = 0 To myfiles3.Length - 1
                    write1.WriteLine(myfiles3(z).Name())
                Next
                write1.Close()
            End Using
        Catch sysex As System.IO.DirectoryNotFoundException
        End Try

    End Sub
End Class
