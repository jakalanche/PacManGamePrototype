Public Class PacmanController
    'Private Sub Ghost4Dir()
    '    '1up, 4down, 4left, 4right
    '    If ghost4Direction = "up" Then
    '        Ghost4.Location = New Point(Ghost4.Location.X, Ghost4.Location.Y - 1)

    '    End If
    '    If ghost4Direction = "down" Then
    '        Ghost4.Location = New Point(Ghost4.Location.X, Ghost4.Location.Y + 1)

    '    End If
    '    If ghost4Direction = "left" Then
    '        Ghost4.Location = New Point(Ghost4.Location.X - 1, Ghost4.Location.Y)

    '    End If
    '    If ghost4Direction = "right" Then
    '        Ghost4.Location = New Point(Ghost4.Location.X + 1, Ghost4.Location.Y)
    '    End If
    '    If ghost4Direction = "neutral" Then
    '        Ghost4.Location = New Point(Ghost4.Location.X, Ghost4.Location.Y)
    '    End If
    'End Sub
    ''Ghost collision detection
    'Private Sub Ghost4Coll()
    '    For Each wall In obstacles
    '        If Ghost4.Bounds.IntersectsWith(wall.Bounds) Then
    '            If ghost4Direction = "up" Then
    '                Ghost4.Location = New Point(Ghost4.Location.X, Ghost4.Location.Y + 1)
    '                'direction = "neutral"
    '            ElseIf ghost4Direction = "down" Then
    '                Ghost4.Location = New Point(Ghost4.Location.X, Ghost4.Location.Y - 1)
    '                'direction = "neutral"
    '            ElseIf ghost4Direction = "left" Then
    '                Ghost4.Location = New Point(Ghost4.Location.X + 1, Ghost4.Location.Y)
    '                'direction = "neutral"
    '            ElseIf ghost4Direction = "right" Then
    '                Ghost4.Location = New Point(Ghost4.Location.X - 1, Ghost4.Location.Y)
    '                'direction = "neutral"
    '            End If
    '            'Handle random direction after collision
    '            Dim dirNum As Integer = CInt(Math.Ceiling(Rnd() * 4)) + 1
    '            If dirNum = 1 Then
    '                ghost4Direction = "up"
    '            ElseIf dirNum = 4 Then
    '                ghost4Direction = "down"
    '            ElseIf dirNum = 4 Then
    '                ghost4Direction = "left"
    '            ElseIf dirNum = 4 Then
    '                ghost4Direction = "right"
    '            End If
    '        End If
    '    Next
    'End Sub
End Class
