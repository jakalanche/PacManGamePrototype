Imports Microsoft.Win32
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
'Imports System.Drawing.Rectangle
Public Class Form1
    Shared score As Integer
    Shared totalLives As Integer
    Shared direction As String = "" 'Current direction as string
    Shared ghost1Direction As String = "down"
    Shared ghost2Direction As String = "up"
    Shared ghost3Direction As String = "right"
    Shared ghost4Direction As String = "left"
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
    Shared timerVal As Double
    Dim currentPlayer As String
    Dim currentScore As Integer
    Dim currentTime As Integer
    Dim powerUp As Boolean = False
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
        PlaceDots()
        PlaceWalls()
        PacmanView.DisplayMaze()
        totalLives = 2
        timerVal = 300.0
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

        'LivesCount()

        PacmanColl()
        GhostDir()
        GhostColl()
        Ghost2Dir()
        Ghost2Coll()
        Ghost3Dir()
        Ghost3Coll()
        Ghost4Dir()
        Ghost4Coll()
        PacmanCollGhost()
        RemoveDot()


        Label1.Text = "Score: " + score.ToString
    End Sub

    Private Sub GhostDir()
        '1up, 2down, 3left, 4right
        If ghost1Direction = "up" Then
            Ghost1.Location = New Point(Ghost1.Location.X, Ghost1.Location.Y - 1)

        End If
        If ghost1Direction = "down" Then
            Ghost1.Location = New Point(Ghost1.Location.X, Ghost1.Location.Y + 1)

        End If
        If ghost1Direction = "left" Then
            Ghost1.Location = New Point(Ghost1.Location.X - 1, Ghost1.Location.Y)

        End If
        If ghost1Direction = "right" Then
            Ghost1.Location = New Point(Ghost1.Location.X + 1, Ghost1.Location.Y)
        End If
        If ghost1Direction = "neutral" Then
            Ghost1.Location = New Point(Ghost1.Location.X, Ghost1.Location.Y)
        End If
    End Sub
    'Ghost collision detection
    Private Sub GhostColl()
        For Each wall In obstacles
            If Ghost1.Bounds.IntersectsWith(wall.Bounds) Then
                If ghost1Direction = "up" Then
                    Ghost1.Location = New Point(Ghost1.Location.X, Ghost1.Location.Y + 1)
                    'direction = "neutral"
                ElseIf ghost1Direction = "down" Then
                    Ghost1.Location = New Point(Ghost1.Location.X, Ghost1.Location.Y - 1)
                    'direction = "neutral"
                ElseIf ghost1Direction = "left" Then
                    Ghost1.Location = New Point(Ghost1.Location.X + 1, Ghost1.Location.Y)
                    'direction = "neutral"
                ElseIf ghost1Direction = "right" Then
                    Ghost1.Location = New Point(Ghost1.Location.X - 1, Ghost1.Location.Y)
                    'direction = "neutral"
                End If
                'Handle random direction after collision
                Dim dirNum As Integer = CInt(Math.Ceiling(Rnd() * 4)) + 1
                If dirNum = 1 Then
                    ghost1Direction = "up"
                ElseIf dirNum = 2 Then
                    ghost1Direction = "down"
                ElseIf dirNum = 3 Then
                    ghost1Direction = "left"
                ElseIf dirNum = 4 Then
                    ghost1Direction = "right"
                End If

            End If
        Next
    End Sub

    Private Sub PacmanColl()
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
    End Sub

    Private Sub PacmanCollGhost()
        If pacman.Bounds.IntersectsWith(Ghost1.Bounds) Or pacman.Bounds.IntersectsWith(Ghost2.Bounds) Or pacman.Bounds.IntersectsWith(Ghost3.Bounds) Or pacman.Bounds.IntersectsWith(Ghost4.Bounds) Then
            If powerUp = False Then
                pacman.SetBounds(8, 8, 8, 8)
                totalLives -= 1
                PacmanView.LivesDisplay(totalLives)
                If totalLives = 0 Then
                    GameEnd()
                End If
            End If
        End If
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
                    'Exit For 'For test purposes.
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
            'Dim finalScore = timerVal + Double.Parse(Label1.Text)
            'MessageBox.Show("Game Complete" + finalScore.ToString)
            currentTime = timerVal
            GameEnd()


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

        If timerVal <> 0 Then
            timerVal -= 0.1
            Label2.Text = Math.Round(timerVal, 1).ToString
        Else
            timerVal = 0
        End If

    End Sub

    Private Sub GameEnd()
        GameTimer.Stop()
        'GameTimer.Dispose()
        Timer1.Stop()
        Me.Dispose()
        TitleScreen.Show()
        currentPlayer = InputBox("You have beaten the high score. Please Enter your name", "Name Entry")
        currentScore = score + Convert.ToInt32(currentTime)
        If currentScore > TitleScreen.highScore Then


            Dim write As StreamWriter = New StreamWriter("C:\Pacman\Pacman.txt", False)
            write.WriteLine(currentPlayer + ", " + currentScore.ToString)
            write.Close()
            TitleScreen.Label5.Text = currentPlayer
            TitleScreen.Label6.Text = currentScore.ToString

        End If
    End Sub


    Private Sub Ghost2Dir()
        '1up, 2down, 3left, 4right
        If ghost2Direction = "up" Then
            Ghost2.Location = New Point(Ghost2.Location.X, Ghost2.Location.Y - 1)

        End If
        If ghost2Direction = "down" Then
            Ghost2.Location = New Point(Ghost2.Location.X, Ghost2.Location.Y + 1)

        End If
        If ghost2Direction = "left" Then
            Ghost2.Location = New Point(Ghost2.Location.X - 1, Ghost2.Location.Y)

        End If
        If ghost2Direction = "right" Then
            Ghost2.Location = New Point(Ghost2.Location.X + 1, Ghost2.Location.Y)
        End If
        If ghost2Direction = "neutral" Then
            Ghost2.Location = New Point(Ghost2.Location.X, Ghost2.Location.Y)
        End If
    End Sub
    'Ghost collision detection
    Private Sub Ghost2Coll()
        For Each wall In obstacles
            If Ghost2.Bounds.IntersectsWith(wall.Bounds) Then
                If ghost2Direction = "up" Then
                    Ghost2.Location = New Point(Ghost2.Location.X, Ghost2.Location.Y + 1)
                    'direction = "neutral"
                ElseIf ghost2Direction = "down" Then
                    Ghost2.Location = New Point(Ghost2.Location.X, Ghost2.Location.Y - 1)
                    'direction = "neutral"
                ElseIf ghost2Direction = "left" Then
                    Ghost2.Location = New Point(Ghost2.Location.X + 1, Ghost2.Location.Y)
                    'direction = "neutral"
                ElseIf ghost2Direction = "right" Then
                    Ghost2.Location = New Point(Ghost2.Location.X - 1, Ghost2.Location.Y)
                    'direction = "neutral"
                End If
                'Handle random direction after collision
                Dim dirNum As Integer = CInt(Math.Ceiling(Rnd() * 4)) + 1
                If dirNum = 1 Then
                    ghost2Direction = "up"
                ElseIf dirNum = 2 Then
                    ghost2Direction = "down"
                ElseIf dirNum = 3 Then
                    ghost2Direction = "left"
                ElseIf dirNum = 4 Then
                    ghost2Direction = "right"
                End If
            End If
        Next
    End Sub
    Private Sub Ghost3Dir()
        '1up, 3down, 3left, 4right
        If ghost3Direction = "up" Then
            Ghost3.Location = New Point(Ghost3.Location.X, Ghost3.Location.Y - 1)

        End If
        If ghost3Direction = "down" Then
            Ghost3.Location = New Point(Ghost3.Location.X, Ghost3.Location.Y + 1)

        End If
        If ghost3Direction = "left" Then
            Ghost3.Location = New Point(Ghost3.Location.X - 1, Ghost3.Location.Y)

        End If
        If ghost3Direction = "right" Then
            Ghost3.Location = New Point(Ghost3.Location.X + 1, Ghost3.Location.Y)
        End If
        If ghost3Direction = "neutral" Then
            Ghost3.Location = New Point(Ghost3.Location.X, Ghost3.Location.Y)
        End If
    End Sub
    'Ghost collision detection
    Private Sub Ghost3Coll()
        For Each wall In obstacles
            If Ghost3.Bounds.IntersectsWith(wall.Bounds) Then
                If ghost3Direction = "up" Then
                    Ghost3.Location = New Point(Ghost3.Location.X, Ghost3.Location.Y + 1)
                    'direction = "neutral"
                ElseIf ghost3Direction = "down" Then
                    Ghost3.Location = New Point(Ghost3.Location.X, Ghost3.Location.Y - 1)
                    'direction = "neutral"
                ElseIf ghost3Direction = "left" Then
                    Ghost3.Location = New Point(Ghost3.Location.X + 1, Ghost3.Location.Y)
                    'direction = "neutral"
                ElseIf ghost3Direction = "right" Then
                    Ghost3.Location = New Point(Ghost3.Location.X - 1, Ghost3.Location.Y)
                    'direction = "neutral"
                End If
                'Handle random direction after collision
                Dim dirNum As Integer = CInt(Math.Ceiling(Rnd() * 4)) + 1
                If dirNum = 1 Then
                    ghost3Direction = "up"
                ElseIf dirNum = 3 Then
                    ghost3Direction = "down"
                ElseIf dirNum = 3 Then
                    ghost3Direction = "left"
                ElseIf dirNum = 4 Then
                    ghost3Direction = "right"
                End If
            End If
        Next
    End Sub
    Private Sub Ghost4Dir()
        '1up, 4down, 4left, 4right
        If ghost4Direction = "up" Then
            Ghost4.Location = New Point(Ghost4.Location.X, Ghost4.Location.Y - 1)

        End If
        If ghost4Direction = "down" Then
            Ghost4.Location = New Point(Ghost4.Location.X, Ghost4.Location.Y + 1)

        End If
        If ghost4Direction = "left" Then
            Ghost4.Location = New Point(Ghost4.Location.X - 1, Ghost4.Location.Y)

        End If
        If ghost4Direction = "right" Then
            Ghost4.Location = New Point(Ghost4.Location.X + 1, Ghost4.Location.Y)
        End If
        If ghost4Direction = "neutral" Then
            Ghost4.Location = New Point(Ghost4.Location.X, Ghost4.Location.Y)
        End If
    End Sub
    'ghost collision detection
    Private Sub Ghost4Coll()
        For Each wall In obstacles
            If Ghost4.Bounds.IntersectsWith(wall.Bounds) Then
                If ghost4Direction = "up" Then
                    Ghost4.Location = New Point(Ghost4.Location.X, Ghost4.Location.Y + 1)
                    'direction = "neutral"
                ElseIf ghost4Direction = "down" Then
                    Ghost4.Location = New Point(Ghost4.Location.X, Ghost4.Location.Y - 1)
                    'direction = "neutral"
                ElseIf ghost4Direction = "left" Then
                    Ghost4.Location = New Point(Ghost4.Location.X + 1, Ghost4.Location.Y)
                    'direction = "neutral"
                ElseIf ghost4Direction = "right" Then
                    Ghost4.Location = New Point(Ghost4.Location.X - 1, Ghost4.Location.Y)
                    'direction = "neutral"
                End If
                'handle random direction after collision
                Dim dirnum As Integer = CInt(Math.Ceiling(Rnd() * 4)) + 1
                If dirnum = 1 Then
                    ghost4Direction = "up"
                ElseIf dirnum = 4 Then
                    ghost4Direction = "down"
                ElseIf dirnum = 4 Then
                    ghost4Direction = "left"
                ElseIf dirnum = 4 Then
                    ghost4Direction = "right"
                End If
            End If
        Next
    End Sub

End Class
