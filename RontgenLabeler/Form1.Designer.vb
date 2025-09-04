<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnProses = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnProses
        '
        Me.BtnProses.Location = New System.Drawing.Point(50, 50)
        Me.BtnProses.Name = "BtnProses"
        Me.BtnProses.Size = New System.Drawing.Size(200, 40)
        Me.BtnProses.TabIndex = 0
        Me.BtnProses.Text = "Proses Folder"
        Me.BtnProses.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 150)
        Me.Controls.Add(Me.BtnProses)
        Me.Name = "Form1"
        Me.Text = "Rontgen Labeler"
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents BtnProses As Button
End Class
