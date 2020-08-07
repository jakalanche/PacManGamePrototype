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
        Me.pacman = New System.Windows.Forms.PictureBox()
        Me.maze = New System.Windows.Forms.PictureBox()
        CType(Me.pacman, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maze, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'pacman
        '
        Me.pacman.Image = Global.PacManGamePrototype.My.Resources.Resources.pac_neutral
        Me.pacman.Location = New System.Drawing.Point(104, 210)
        Me.pacman.Name = "pacman"
        Me.pacman.Size = New System.Drawing.Size(16, 16)
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
        Me.maze.TabIndex = 0
        Me.maze.TabStop = False
        Me.maze.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(224, 288)
        Me.Controls.Add(Me.pacman)
        Me.Controls.Add(Me.maze)
        Me.Name = "Form1"
        Me.Text = "Pacman"
        CType(Me.pacman, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maze, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pacman As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents maze As PictureBox
End Class
