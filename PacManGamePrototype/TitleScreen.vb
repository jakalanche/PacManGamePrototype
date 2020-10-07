Public Class TitleScreen
    Private Sub TitleScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Grid")
        ComboBox1.Items.Add("Hexagon (Coming Soon)")
        ComboBox1.Items.Add("Random Graph")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = 0 Then
            Me.Hide()
            Form1.Show()
        Else
            MessageBox.Show("Map yet to be developed. Try another.")
        End If
    End Sub

End Class