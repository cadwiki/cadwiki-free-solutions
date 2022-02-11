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
        Me.ButtonLaunchAutocad = New System.Windows.Forms.Button()
        Me.ButtonCallScript = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonLaunchAutocad
        '
        Me.ButtonLaunchAutocad.Location = New System.Drawing.Point(24, 12)
        Me.ButtonLaunchAutocad.Name = "ButtonLaunchAutocad"
        Me.ButtonLaunchAutocad.Size = New System.Drawing.Size(142, 23)
        Me.ButtonLaunchAutocad.TabIndex = 0
        Me.ButtonLaunchAutocad.Text = "Launch AutoCAD"
        Me.ButtonLaunchAutocad.UseVisualStyleBackColor = True
        '
        'ButtonCallScript
        '
        Me.ButtonCallScript.Location = New System.Drawing.Point(24, 59)
        Me.ButtonCallScript.Name = "ButtonCallScript"
        Me.ButtonCallScript.Size = New System.Drawing.Size(142, 23)
        Me.ButtonCallScript.TabIndex = 1
        Me.ButtonCallScript.Text = "Call Script"
        Me.ButtonCallScript.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(227, 108)
        Me.Controls.Add(Me.ButtonCallScript)
        Me.Controls.Add(Me.ButtonLaunchAutocad)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonLaunchAutocad As Button
    Friend WithEvents ButtonCallScript As Button
End Class
