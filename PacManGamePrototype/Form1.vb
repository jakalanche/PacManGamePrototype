
Public Class Form1
    Dim totalLives = 3
    Dim direction As String = "" 'Current direction as string
    Dim pacmanAnimation As Integer = 0 ' Current Animation eg. up, down, left right. 0 - 5
    Dim a As Integer 'column number
    Dim b As Integer 'row number
    Dim dots(a, b) As PictureBox 'dots picturebox array
    'Handle Movement using keys
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'MsgBox(e.KeyCode.ToString)
        If e.KeyCode = Keys.Up Then
            direction = "up"
            pacmanAnimation = 1

        ElseIf e.KeyCode = Keys.Down Then
            direction = "down"
            pacmanAnimation = 2

        ElseIf e.KeyCode = Keys.Left Then
            direction = "left"
            pacmanAnimation = 3
        ElseIf e.KeyCode = Keys.Right Then
            direction = "right"
            pacmanAnimation = 4
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        'If Check if possibel first
        animationChange(pacmanAnimation)
        'End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'PictureBox1.

        PlaceDots()
        displayMaze()

    End Sub

    Private Sub displayMaze()
        Dim maze As Label = New Label With {
            .BackgroundImage = My.Resources.maze,
            .Location = New Point(0, 0),
            .Width = 224,
            .Height = 288
        }
        maze.SendToBack()
        Controls.Add(maze)

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
        livesCount()


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

    Sub DrawTile(image, xPosition, yPosition, xSize, ySize, a, b)
        dots(a, b) = New PictureBox
        dots(a, b).Image = My.Resources.dot 'dot image
        dots(a, b).Width = xSize
        dots(a, b).Height = ySize
        dots(a, b).Location = New Point(xPosition, yPosition)
        dots(a, b).BringToFront()
        Controls.Add(dots(a, b))
    End Sub
    Sub PlaceDots()
        Dim dotsArray(,) As Integer = New Integer(,) {  '1           5              10             15             20             25
                                                        {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, '1
                                                        {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
                                                        {0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0},
                                                        {0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0},
                                                        {0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0}, '5
                                                        {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
                                                        {0, 1, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 1, 0},
                                                        {0, 1, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 1, 0},
                                                        {0, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 0},
                                                        {0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 2, 0, 0, 2, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0}, '10
                                                        {0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 2, 0, 0, 2, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
                                                        {0, 0, 0, 0, 0, 0, 1, 0, 0, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 0, 0, 1, 0, 0, 0, 0, 0, 0},
                                                        {0, 0, 0, 0, 0, 0, 1, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 1, 0, 0, 0, 0, 0, 0},
                                                        {0, 0, 0, 0, 0, 0, 1, 0, 0, 2, 0, 2, 2, 2, 2, 2, 2, 0, 2, 0, 0, 1, 0, 0, 0, 0, 0, 0},
                                                        {2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 0, 2, 2, 2, 2, 2, 2, 0, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2}, '15
                                                        {0, 0, 0, 0, 0, 0, 1, 0, 0, 2, 0, 2, 2, 2, 2, 2, 2, 0, 2, 0, 0, 1, 0, 0, 0, 0, 0, 0},
                                                        {0, 0, 0, 0, 0, 0, 1, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 1, 0, 0, 0, 0, 0, 0},
                                                        {0, 0, 0, 0, 0, 0, 1, 0, 0, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 0, 0, 1, 0, 0, 0, 0, 0, 0},
                                                        {0, 0, 0, 0, 0, 0, 1, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 1, 0, 0, 0, 0, 0, 0},
                                                        {0, 0, 0, 0, 0, 0, 1, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 1, 0, 0, 0, 0, 0, 0}, '20
                                                        {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
                                                        {0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0},
                                                        {0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0},
                                                        {0, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1, 2, 2, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 0},
                                                        {0, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 0}, '25
                                                        {0, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 0},
                                                        {0, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 0},
                                                        {0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                                                        {0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                                                        {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0}, '30
                                                        {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}}




        Dim dotNo As Integer = 0 ' dot count

        Dim x As Integer = 8 'x axis
        Dim y As Integer = 8 'y axis

        Dim dotSizeX As Integer = 8
        Dim dotSizeY As Integer = 8

        Dim xadd As Integer = 0 'x axis interval add 10 eahc loop
        Dim yadd As Integer = 0 'y axis interval add 10 each loop

        Dim aLen As Integer = dotsArray.GetUpperBound(0)
        Dim bLen As Integer = dotsArray.GetUpperBound(1)

        For a = dotsArray.GetLowerBound(0) To dotsArray.GetUpperBound(0)
            For b = dotsArray.GetLowerBound(1) To dotsArray.GetUpperBound(1)
                'MsgBox(dotsArray(a, b).ToString)
                If dotsArray(a, b).ToString = 1 Then
                    DrawTile(My.Resources.dot, x * a, y * b, dotSizeX, dotSizeY, a, b)
                End If
            Next

        Next


        ''Dim dots(row, col) As PictureBox
        ''create all 
        'For i = 1 To row
        '    For j = 1 To col
        '        If i > 9 Then
        '            dots(i, j) = New PictureBox
        '            dots(i, j).Width = dotSizeX
        '            dots(i, j).Height = dotSizeY
        '            dots(i, j).Image = My.Resources.dot 'dot image
        '            dots(i, j).Location = New Point(x + xadd, y + yadd)
        '            dots(i, j).BringToFront()
        '            'set size and stuff
        '            Controls.Add(dots(i, j))
        '            xadd += 8
        '        ElseIf i < 20 Then
        '            dots(i, j) = New PictureBox
        '            dots(i, j).Width = dotSizeX
        '            dots(i, j).Height = dotSizeY
        '            dots(i, j).Image = My.Resources.dot 'dot image
        '            dots(i, j).Location = New Point(x + xadd, y + yadd)
        '            dots(i, j).BringToFront()
        '            'set size and stuff
        '            Controls.Add(dots(i, j))
        '            xadd += 8
        '        Else

        '        End If
        '    Next
        '    xadd = 0
        '    yadd += 8
        'Next




        ''Exception list
        'For i = 1 To row
        '    For j = 1 To col
        '        'Top left rect
        '        Controls.Remove(dots(2, 2))
        '        Controls.Remove(dots(2, 3))
        '        Controls.Remove(dots(2, 4))
        '        Controls.Remove(dots(2, 5))
        '        Controls.Remove(dots(3, 2))
        '        Controls.Remove(dots(3, 3))
        '        Controls.Remove(dots(3, 4))
        '        Controls.Remove(dots(3, 5))
        '        Controls.Remove(dots(4, 2))
        '        Controls.Remove(dots(4, 3))
        '        Controls.Remove(dots(4, 4))
        '        Controls.Remove(dots(4, 5))
        '        'Top left rect 2
        '        Controls.Remove(dots(2, 7))
        '        Controls.Remove(dots(2, 8))
        '        Controls.Remove(dots(2, 9))
        '        Controls.Remove(dots(2, 10))
        '        Controls.Remove(dots(2, 11))
        '        Controls.Remove(dots(3, 7))
        '        Controls.Remove(dots(3, 8))
        '        Controls.Remove(dots(3, 9))
        '        Controls.Remove(dots(3, 10))
        '        Controls.Remove(dots(3, 11))
        '        Controls.Remove(dots(4, 7))
        '        Controls.Remove(dots(4, 8))
        '        Controls.Remove(dots(4, 9))
        '        Controls.Remove(dots(4, 10))
        '        Controls.Remove(dots(4, 11))
        '        'Top mid line
        '        Controls.Remove(dots(1, 13))
        '        Controls.Remove(dots(2, 13))
        '        Controls.Remove(dots(3, 13))
        '        Controls.Remove(dots(4, 13))
        '        Controls.Remove(dots(1, 14))
        '        Controls.Remove(dots(2, 14))
        '        Controls.Remove(dots(3, 14))
        '        Controls.Remove(dots(4, 14))



        '    Next
        'Next

    End Sub
    Sub removeAllDots()
        'For i = 1 To row
        '    For j = 1 To col
        '        Controls.Remove(dots(i, j))
        '    Next
        'Next
    End Sub

    Sub livesCount()
        For i = 0 To totalLives
            'Dim x = 0 'lopp and increase distnce for each. 
            'Dim live As New Label
            'live.Image = My.Resources.
        Next
    End Sub

    Sub pacmanCollision()
        'pacman.
    End Sub
    'Generate map data
    'For X = 0 To 99
    'For Y = 0 To 99
    '    DrawTile(MapTiles.Images(MapData(X,Y)), X x 32, Y x 32)
    'Next
    'Next
End Class
