Class PacmanView

    Public Shared Sub DisplayMaze()
        Dim maze As Label = New Label With {
            .BackgroundImage = My.Resources.maze,
            .Location = New Point(0, 0),
            .Width = 224,
            .Height = 288
        }
        maze.SendToBack()
        Form1.Controls.Add(maze)

    End Sub

    Public Shared Sub AnimationChange(pacAni)
        If pacAni = 1 Then 'up
            Form1.pacman.Image = My.Resources.pacman_up
        ElseIf pacAni = 2 Then 'down
            Form1.pacman.Image = My.Resources.pacman_down
        ElseIf pacAni = 3 Then 'left
            Form1.pacman.Image = My.Resources.pacman_left
        ElseIf pacAni = 4 Then 'right
            Form1.pacman.Image = My.Resources.pacman_right
        ElseIf pacAni = 0 Then
            Form1.pacman.Image = My.Resources.pac_neutral
        End If
        Form1.pacman.Refresh()
    End Sub


End Class
