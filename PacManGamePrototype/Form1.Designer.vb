<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Ghost4 = New System.Windows.Forms.PictureBox()
        Me.Ghost3 = New System.Windows.Forms.PictureBox()
        Me.Ghost2 = New System.Windows.Forms.PictureBox()
        Me.Ghost1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pacman = New System.Windows.Forms.PictureBox()
        Me.maze = New System.Windows.Forms.PictureBox()
        CType(Me.Ghost4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ghost3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ghost2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ghost1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pacman, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maze, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 266)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(93, 266)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Label2"
        '
        'GameTimer
        '
        Me.GameTimer.Enabled = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 249)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Score:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(93, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Time:"
        '
        'Ghost4
        '
        Me.Ghost4.Image = Global.PacManGamePrototype.My.Resources.Resources.GHOST_Yellow__DOWNWARD01
        Me.Ghost4.Location = New System.Drawing.Point(124, 88)
        Me.Ghost4.Name = "Ghost4"
        Me.Ghost4.Size = New System.Drawing.Size(8, 8)
        Me.Ghost4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Ghost4.TabIndex = 7
        Me.Ghost4.TabStop = False
        '
        'Ghost3
        '
        Me.Ghost3.Image = Global.PacManGamePrototype.My.Resources.Resources.GHOST_Red__DOWNWARD01
        Me.Ghost3.Location = New System.Drawing.Point(82, 88)
        Me.Ghost3.Name = "Ghost3"
        Me.Ghost3.Size = New System.Drawing.Size(8, 8)
        Me.Ghost3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Ghost3.TabIndex = 7
        Me.Ghost3.TabStop = False
        '
        'Ghost2
        '
        Me.Ghost2.Image = Global.PacManGamePrototype.My.Resources.Resources.GHOST_Pink__DOWNWARD01
        Me.Ghost2.Location = New System.Drawing.Point(96, 88)
        Me.Ghost2.Name = "Ghost2"
        Me.Ghost2.Size = New System.Drawing.Size(8, 8)
        Me.Ghost2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Ghost2.TabIndex = 7
        Me.Ghost2.TabStop = False
        '
        'Ghost1
        '
        Me.Ghost1.Image = Global.PacManGamePrototype.My.Resources.Resources.GHOST_Blue__DOWNWARD01
        Me.Ghost1.Location = New System.Drawing.Point(110, 88)
        Me.Ghost1.Name = "Ghost1"
        Me.Ghost1.Size = New System.Drawing.Size(8, 8)
        Me.Ghost1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Ghost1.TabIndex = 7
        Me.Ghost1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(202, 254)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(180, 254)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'pacman
        '
        Me.pacman.Image = Global.PacManGamePrototype.My.Resources.Resources.pac_neutral
        Me.pacman.Location = New System.Drawing.Point(105, 180)
        Me.pacman.Name = "pacman"
        Me.pacman.Size = New System.Drawing.Size(8, 8)
        Me.pacman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pacman.TabIndex = 1
        Me.pacman.TabStop = False
        '
        'maze
        '
        Me.maze.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maze.Image = CType(resources.GetObject("maze.Image"), System.Drawing.Image)
        Me.maze.Location = New System.Drawing.Point(0, 0)
        Me.maze.Name = "maze"
        Me.maze.Size = New System.Drawing.Size(227, 248)
        Me.maze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.maze.TabIndex = 0
        Me.maze.TabStop = False
        Me.maze.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(227, 288)
        Me.Controls.Add(Me.Ghost4)
        Me.Controls.Add(Me.Ghost3)
        Me.Controls.Add(Me.Ghost2)
        Me.Controls.Add(Me.Ghost1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pacman)
        Me.Controls.Add(Me.maze)
        Me.Name = "Form1"
        Me.Text = "Pacman"
        CType(Me.Ghost4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ghost3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ghost2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ghost1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pacman, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maze, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pacman As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents maze As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GameTimer As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Ghost1 As PictureBox
    Friend WithEvents Ghost2 As PictureBox
    Friend WithEvents Ghost3 As PictureBox
    Friend WithEvents Ghost4 As PictureBox
End Class
