Public Class Form1
    Dim direction As String 'Current direction as string
    Dim pacmanAnimation As String ' Current Animation eg. up, down, left right.
    'Handle Movement using keys
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Up Then
            direction = "up"
        End If
        If e.KeyCode = Keys.Down Then
            direction = "down"
        End If
        If e.KeyCode = Keys.Left Then
            direction = "left"
        End If
        If e.KeyCode = Keys.Right Then
            direction = "right"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'PictureBox1.
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Handle 
        If direction = "up" Then
            pacman.Location = New Point(pacman.Location.X, pacman.Location.Y + 1)
            If pacmanAnimation = "1" Then
                'pacman.BackgroundImage = My.Resources.pacman_eat
                'pacmanAnimation = "0"
            Else
                'pacman.BackgroundImage = My.Resources.pacman_eat1
                'pacmanAnimation = "1"
            End If
        End If
            If direction = "down" Then
            pacman.Location = New Point(pacman.Location.X, pacman.Location.Y - 1)
        End If
        If direction = "left" Then
            pacman.Location = New Point(pacman.Location.X - 1, pacman.Location.Y)
        End If
        If direction = "right" Then
            pacman.Location = New Point(pacman.Location.X + 1, pacman.Location.Y)
        End If
    End Sub
End Class
