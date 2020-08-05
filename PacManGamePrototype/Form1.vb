Public Class Form1
    Dim direction As String = "" 'Current direction as string
    Dim pacmanAnimation As Integer = 0 ' Current Animation eg. up, down, left right. 0 - 5
    'Handle Movement using keys
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'MsgBox(e.KeyCode.ToString)
        If e.KeyCode = Keys.Up Then
            direction = "up"
            pacmanAnimation = 1
        End If
        If e.KeyCode = Keys.Down Then
            direction = "down"
            pacmanAnimation = 2
        End If
        If e.KeyCode = Keys.Left Then
            direction = "left"
            pacmanAnimation = 3
        End If
        If e.KeyCode = Keys.Right Then
            direction = "right"
            pacmanAnimation = 4
        End If
        'If Check if possibel first
        animationChange(pacmanAnimation)
        'End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'PictureBox1.
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Handle 
        If direction = "up" Then
            pacman.Location = New Point(pacman.Location.X, pacman.Location.Y - 1)

        End If
        If direction = "down" Then
            pacman.Location = New Point(pacman.Location.X, pacman.Location.Y + 1)

        End If
        If direction = "left" Then
            pacman.Location = New Point(pacman.Location.X - 1, pacman.Location.Y)

        End If
        If direction = "right" Then
            pacman.Location = New Point(pacman.Location.X + 1, pacman.Location.Y)

        End If

    End Sub
    Private Sub animationChange(pacAni)
        If pacAni = 1 Then 'up
            pacman.Image = My.Resources.pacman_up
        ElseIf pacAni = 2 Then 'down
            pacman.Image = My.Resources.pacman_down
        ElseIf pacAni = 3 Then 'left
            pacman.Image = My.Resources.pacman_left
        ElseIf pacAni = 4 Then 'right
            pacman.Image = My.Resources.pacman_right
        Else
            pacman.Image = My.Resources.pac_neutral
        End If
        pacman.Refresh()
    End Sub


End Class
