<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Btn_Clear = New System.Windows.Forms.Button()
        Me.ButtonSolve = New System.Windows.Forms.Button()
        Me.Btn_solve = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_Clear
        '
        Me.Btn_Clear.Location = New System.Drawing.Point(66, 264)
        Me.Btn_Clear.Name = "Btn_Clear"
        Me.Btn_Clear.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Clear.TabIndex = 0
        Me.Btn_Clear.Text = "Clear"
        Me.Btn_Clear.UseVisualStyleBackColor = True
        '
        'ButtonSolve
        '
        Me.ButtonSolve.Location = New System.Drawing.Point(160, 264)
        Me.ButtonSolve.Name = "ButtonSolve"
        Me.ButtonSolve.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSolve.TabIndex = 1
        Me.ButtonSolve.Text = "Solve"
        Me.ButtonSolve.UseVisualStyleBackColor = True
        '
        'Btn_solve
        '
        Me.Btn_solve.Location = New System.Drawing.Point(160, 264)
        Me.Btn_solve.Name = "Btn_solve"
        Me.Btn_solve.Size = New System.Drawing.Size(75, 23)
        Me.Btn_solve.TabIndex = 1
        Me.Btn_solve.Text = "Solve"
        Me.Btn_solve.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 299)
        Me.Controls.Add(Me.ButtonSolve)
        Me.Controls.Add(Me.Btn_Clear)
        Me.Name = "Form1"
        Me.Text = "sudoku"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_Clear As System.Windows.Forms.Button
    Friend WithEvents ButtonSolve As System.Windows.Forms.Button
    Friend WithEvents Btn_solve As System.Windows.Forms.Button

End Class
