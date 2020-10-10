Imports System.Security.Cryptography.X509Certificates
Imports Microsoft.Win32

Public Class TitleScreen
    Public Shared nameKey As RegistryKey
    Public Shared scoreKey As RegistryKey
    Public Shared highScorePlayer As String
    Public Shared highScore As Integer

    Private Sub TitleScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'RegistrySetup()
        ComboBox1.Items.Add("Grid")
        ComboBox1.Items.Add("Hexagon (Coming Soon)")
        ComboBox1.Items.Add("Random Graph")
        Label5.Text = ""
        Label6.Text = ""
        RegistrySetup()
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

    Public Sub RegistrySetup()
        nameKey = Registry.LocalMachine.OpenSubKey("HKEY_CURRENT_USER\Software\Pacman", True)
        Dim name = nameKey.GetValue("Name")
        If name Is Nothing Then
            nameKey.CreateSubKey("Name", True)
        Else
            highScorePlayer = name.ToString
        End If
        nameKey.Close()

        scoreKey = Registry.LocalMachine.OpenSubKey("HKEY_CURRENT_USER\Software\Pacman", True)
        Dim score = scoreKey.GetValue("Score")
        If score Is Nothing Then
            scoreKey.CreateSubKey("Score", True)
        Else
            highScore = Integer.Parse(CType(score, String))
        End If
        scoreKey.Close()
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