
Imports System.Windows.Forms
'Imports System.Drawing.Rectangle
Public Class Form1
    Shared score As Integer
    Shared totalLives As Integer = 3
    Shared direction As String = "" 'Current direction as string
    Shared pacmanAnimation As Integer = 0 ' Current Animation eg. up, down, left right. 0 - 5
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
    Shared a As Integer 'column number
    Shared b As Integer 'row number
    Shared obstacles As List(Of PictureBox) = New List(Of PictureBox)
    Shared dots As List(Of PictureBox) = New List(Of PictureBox)
    Shared dotsArray(a, b) As PictureBox 'dots picturebox array
    Shared wallArray(a, b) As PictureBox ' 
    Shared timerVal As Double = 0.0
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
        PacmanView.AnimationChange(pacmanAnimation)
        'End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'PictureBox1.
        pacman.SetBounds(8, 8, 8, 8)
        PlaceDots()
        PlaceWalls()
        PacmanView.DisplayMaze()
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
            PacmanView.AnimationChange(0)
        End If
        'PacmanCollision()
        'LivesCount()
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
                PacmanView.AnimationChange(0)
                direction = "neutral"
            End If
        Next
        RemoveDot()
        Label1.Text = "Score: " + score.ToString
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
    Sub RemoveDot()
        Dim dotDelete As PictureBox
        For Each pb In dots

            If dots.Contains(pb) Then
                If pacman.Bounds.IntersectsWith(pb.Bounds) Then
                    score += 1
                    dotDelete = pb
                    Controls.Remove(pb) 'remove from screen
                    'remove from list
                End If
            End If
        Next
        dots.Remove(dotDelete)
        If dots.Count = 0 Then
            Dim finalScore = timerVal + Double.Parse(Label1.Text)
            MessageBox.Show("Game Complete" + finalScore.ToString)
            Timer1.Interval = 0

        End If
        ''Dim dotsArray(mapArray.GetUpperBound(0), mapArray.GetUpperBound(1)) As PictureBox
        'For a = dotsArray.GetLowerBound(0) To dotsArray.GetUpperBound(0)
        '    For b = dotsArray.GetLowerBound(1) To dotsArray.GetUpperBound(1)
        '        If pacman.Bounds.IntersectsWith(dotsArray(a, b).Bounds) Then
        '            score += 1
        '        End If
        '    Next
        'Next
    End Sub

    Private Sub GameTimer_Tick(sender As Object, e As EventArgs) Handles GameTimer.Tick
        timerVal += 0.1
        Label2.Text = timerVal.ToString
    End Sub

End Class
