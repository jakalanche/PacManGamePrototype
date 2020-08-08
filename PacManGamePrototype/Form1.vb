
Imports System.Windows.Forms
'Imports System.Drawing.Rectangle
Public Class Form1
    Dim totalLives = 3
    Dim direction As String = "" 'Current direction as string
    Dim pacmanAnimation As Integer = 0 ' Current Animation eg. up, down, left right. 0 - 5
    Public Shared mapArray(,) As Integer = New Integer(,) _
                                                        {       '1           5              10             15             20             25
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
    Dim a As Integer 'column number
    Dim b As Integer 'row number
    Dim obstacles As List(Of PictureBox) = New List(Of PictureBox)
    Dim dots As List(Of PictureBox) = New List(Of PictureBox)
    Dim dotsArray(a, b) As PictureBox 'dots picturebox array
    Dim wallArray(a, b) As PictureBox ' 
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
        AnimationChange(pacmanAnimation)
        'End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'PictureBox1.
        pacman.SetBounds(10, 10, 4, 4)
        PlaceDots()
        PlaceWalls()
        DisplayMaze()

    End Sub

    Private Sub DisplayMaze()
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
        If direction = "neutral" Then
            pacman.Location = New Point(pacman.Location.X, pacman.Location.Y)
            AnimationChange(0)
        End If
        'PacmanCollision()
        LivesCount()
        For Each wall In obstacles
            If pacman.Bounds.IntersectsWith(wall.Bounds) Then
                If direction = "up" Then
                    pacman.Location = New Point(pacman.Location.X, pacman.Location.Y + 1)
                    direction = "neutral"
                ElseIf direction = "down" Then
                    pacman.Location = New Point(pacman.Location.X, pacman.Location.Y - 1)
                    direction = "neutral"
                ElseIf direction = "left" Then
                    pacman.Location = New Point(pacman.Location.X + 1, pacman.Location.Y)
                    direction = "neutral"
                ElseIf direction = "right" Then
                    pacman.Location = New Point(pacman.Location.X - 1, pacman.Location.Y)
                    direction = "neutral"
                End If
                AnimationChange(0)
                direction = "neutral"
            End If
        Next



        For Each dot In obstacles
            If pacman.Bounds.IntersectsWith(dot.Bounds) Then
                MsgBox("Yes")
            End If
        Next


    End Sub
    Private Sub AnimationChange(pacAni)
        If pacAni = 1 Then 'up
            pacman.Image = My.Resources.pacman_up
        ElseIf pacAni = 2 Then 'down
            pacman.Image = My.Resources.pacman_down
        ElseIf pacAni = 3 Then 'left
            pacman.Image = My.Resources.pacman_left
        ElseIf pacAni = 4 Then 'right
            pacman.Image = My.Resources.pacman_right
        ElseIf pacAni = 0 Then
            pacman.Image = My.Resources.pac_neutral
        End If
        pacman.Refresh()
    End Sub


    Sub PlaceDots()
        Dim dotsArray(mapArray.GetUpperBound(0), mapArray.GetUpperBound(1)) As PictureBox
        Dim dotNo As Integer = 0 ' dot count
        Dim x As Integer = 8 'x axis
        Dim y As Integer = 8 'y axis
        Dim dotSizeX As Integer = 8
        Dim dotSizeY As Integer = 8
        Dim aLen As Integer = mapArray.GetUpperBound(0)
        Dim bLen As Integer = mapArray.GetUpperBound(1)

        For a = mapArray.GetLowerBound(0) To mapArray.GetUpperBound(0)
            For b = mapArray.GetLowerBound(1) To mapArray.GetUpperBound(1)
                'MsgBox(dotsArray(a, b).ToString)
                If mapArray(a, b).ToString = 1 Then
                    Dim pb As New PictureBox
                    pb.Image = My.Resources.dot 'dot image
                    pb.Width = dotSizeX
                    pb.Height = dotSizeY
                    pb.Location = New Point(x * b, y * a)
                    dotsArray(a, b) = pb
                    Controls.Add(pb)
                    dots.Add(pb)
                End If
            Next
        Next
    End Sub
    Sub PlaceWalls()
        Dim wallArray(mapArray.GetUpperBound(0), mapArray.GetUpperBound(1)) As PictureBox
        Dim dotNo As Integer = 0 ' dot count
        Dim x As Integer = 8 'x axis
        Dim y As Integer = 8 'y axis
        Dim wall As PictureBox
        Dim aLen As Integer = mapArray.GetUpperBound(0)
        Dim bLen As Integer = mapArray.GetUpperBound(1)
        For a = mapArray.GetLowerBound(0) To mapArray.GetUpperBound(0)
            For b = mapArray.GetLowerBound(1) To mapArray.GetUpperBound(1)
                'MsgBox(dotsArray(a, b).ToString)
                If mapArray(a, b) = 0 Then
                    wall = New PictureBox
                    'wall.
                    wall.Size = New Size(8, 8)
                    wall.Location = New Point(x * b, y * a)
                    wall.SetBounds(x * b, y * a, 8, 8)
                    wall.Visible = False
                    'wallArray(a, b) = wall
                    Controls.Add(wall)
                    obstacles.Add(wall)
                End If
            Next
        Next

    End Sub


    Sub PacmanCollision()
        'Dim collArray(wallArray.GetUpperBound(0), wallArray.GetUpperBound(1)) As PictureBox
        Dim x As Integer = 8 'x axis
        Dim y As Integer = 8 'y axis
        Dim aLen As Integer = mapArray.GetUpperBound(0)
        Dim bLen As Integer = mapArray.GetUpperBound(1)
        For a = wallArray.GetLowerBound(0) To wallArray.GetUpperBound(0)
            For b = wallArray.GetLowerBound(1) To wallArray.GetUpperBound(1)
                Dim wall As PictureBox = wallArray(a, b)
                'If pacman.Bounds.IntersectsWith(wall.Bounds) Then
                '    AnimationChange(0)
                'End If
                'Dim pb As PictureBox = wallArray(a, b)
                'If pb.bound Then
            Next
        Next
    End Sub
    'Generate map data
    'For X = 0 To 99
    'For Y = 0 To 99
    '    DrawTile(MapTiles.Images(MapData(X,Y)), X x 32, Y x 32)
    'Next
    'Next


    Sub RemoveAllDots()
        'For i = 1 To row
        '    For j = 1 To col
        '        Controls.Remove(dots(i, j))
        '    Next
        'Next
    End Sub

    Sub LivesCount()
        For i = 0 To totalLives
            'Dim x = 0 'lopp and increase distnce for each. 
            'Dim live As New Label
            'live.Image = My.Resources.
        Next
    End Sub
End Class
