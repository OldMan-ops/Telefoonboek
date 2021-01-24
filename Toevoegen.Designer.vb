<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Toevoegen
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnToevoegen = New System.Windows.Forms.Button()
        Me.btnWis = New System.Windows.Forms.Button()
        Me.btnSluit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(39, 78)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(178, 22)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(274, 78)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(178, 22)
        Me.TextBox2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(103, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Naam"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(304, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Telefoon nummer"
        '
        'btnToevoegen
        '
        Me.btnToevoegen.Location = New System.Drawing.Point(39, 140)
        Me.btnToevoegen.Name = "btnToevoegen"
        Me.btnToevoegen.Size = New System.Drawing.Size(109, 23)
        Me.btnToevoegen.TabIndex = 1
        Me.btnToevoegen.Text = "Toevoegen"
        Me.btnToevoegen.UseVisualStyleBackColor = True
        '
        'btnWis
        '
        Me.btnWis.Location = New System.Drawing.Point(183, 140)
        Me.btnWis.Name = "btnWis"
        Me.btnWis.Size = New System.Drawing.Size(112, 23)
        Me.btnWis.TabIndex = 2
        Me.btnWis.Text = "Wis invoer"
        Me.btnWis.UseVisualStyleBackColor = True
        '
        'btnSluit
        '
        Me.btnSluit.Location = New System.Drawing.Point(333, 140)
        Me.btnSluit.Name = "btnSluit"
        Me.btnSluit.Size = New System.Drawing.Size(98, 23)
        Me.btnSluit.TabIndex = 3
        Me.btnSluit.Text = "Sluit venster"
        Me.btnSluit.UseVisualStyleBackColor = True
        '
        'Toevoegen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSluit)
        Me.Controls.Add(Me.btnWis)
        Me.Controls.Add(Me.btnToevoegen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Toevoegen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nieuw nummer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnToevoegen As Button
    Friend WithEvents btnWis As Button
    Friend WithEvents btnSluit As Button
End Class
