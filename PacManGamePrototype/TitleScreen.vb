Imports Microsoft.Win32

Public Class TitleScreen

    Private Sub TitleScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ComboBox1.Items.Add("Grid")
        ComboBox1.Items.Add("Hexagon (Coming Soon)")
        ComboBox1.Items.Add("Random Graph")
        Label5.Text = ""
        Label6.Text = ""

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

End Class