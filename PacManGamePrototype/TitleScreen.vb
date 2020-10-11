Imports System.IO
Imports System.Security.Cryptography.X509Certificates
Imports Microsoft.VisualBasic.FileIO
Imports Microsoft.Win32

Public Class TitleScreen
    Public Shared highScorePlayer As String
    Public Shared highScore As String

    Private Sub TitleScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'RegistrySetup()
        ComboBox1.Items.Add("Grid")
        ComboBox1.Items.Add("Hexagon (Coming Soon)")
        ComboBox1.Items.Add("Random Graph")
        HighScoreImport()
        Label5.Text = highScorePlayer
        Label6.Text = highScore

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = 0 Then
            Me.Hide()
            Form1.Show()
            'Dim gameScreen As Form1 = New Form1
            'gameScreen.Show()
        Else
            MessageBox.Show("Map yet to be developed. Try another.")
        End If
    End Sub

    Public Sub HighScoreImport()
        If Directory.Exists("c:\Pacman") = False Then
            Directory.CreateDirectory("c:\Pacman")
        End If
        If File.Exists("c:\Pacman\Pacman.txt") = False Then
            Dim fs As FileStream = File.Create("c:\Pacman\Pacman.txt")
        Else
            Using read As New TextFieldParser("c:\Pacman\Pacman.txt")
                read.TextFieldType = FileIO.FieldType.Delimited
                read.SetDelimiters(",")
                Dim row As String()
                While Not read.EndOfData
                    Try
                        row = read.ReadFields()
                        highScorePlayer = row(0)
                        highScore = row(1)
                    Catch ex As Exception
                    End Try
                End While
            End Using

        End If

    End Sub

End Class

'Dim regName As RegistryKey
'Dim regScore As RegistryKey
'regName = My.Computer.Registry.CurrentUser.OpenSubKey("HKEY_CURRENT_USER\Software\Pacman", True)
'regScore = My.Computer.Registry.CurrentUser.OpenSubKey("HKEY_CURRENT_USER\Software\Pacman", True)
'If My.Computer.Registry.CurrentUser.OpenSubKey("HKEY_CURRENT_USER\Software\Pacman", True) IsNot Nothing Then
'    Form1.regName = My.Computer.Registry.CurrentUser.OpenSubKey("HKEY_CURRENT_USER\Software\Pacman", True)
'    Label5.Text = Form1.regName.ToString
'Else
'    Label5.Text = ""
'End If
'If My.Computer.Registry.CurrentUser.OpenSubKey("HKEY_CURRENT_USER\Software\VB_and_VBA_Program_Settings", True) IsNot Nothing Then
'    Form1.regScore = My.Computer.Registry.CurrentUser.OpenSubKey("HKEY_CURRENT_USER\Software\VB_and_VBA_Program_Settings", True)
'    Label6.Text = Form1.regScore.ToString
'Else
'    Label6.Text = ""
'End If
'regName.Close()
'regScore.Close()