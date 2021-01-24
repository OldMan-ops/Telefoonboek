<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Wijzigen
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
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnWis = New System.Windows.Forms.Button()
        Me.btnWijzig = New System.Windows.Forms.Button()
        Me.btnAfsluiten = New System.Windows.Forms.Button()
        Me.btnOpslaan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(121, 90)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(136, 22)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(319, 90)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(126, 22)
        Me.TextBox2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(121, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Naam"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(319, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Telefoon nummer"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(121, 157)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(136, 22)
        Me.TextBox3.TabIndex = 4
        Me.TextBox3.Visible = False
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(319, 157)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(126, 22)
        Me.TextBox4.TabIndex = 5
        Me.TextBox4.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(121, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nieuwe naam"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(319, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nieuw telefoon nummer"
        '
        'btnWis
        '
        Me.btnWis.Location = New System.Drawing.Point(112, 217)
        Me.btnWis.Name = "btnWis"
        Me.btnWis.Size = New System.Drawing.Size(75, 23)
        Me.btnWis.TabIndex = 8
        Me.btnWis.Text = "Wis nummer"
        Me.btnWis.UseVisualStyleBackColor = True
        '
        'btnWijzig
        '
        Me.btnWijzig.Location = New System.Drawing.Point(241, 217)
        Me.btnWijzig.Name = "btnWijzig"
        Me.btnWijzig.Size = New System.Drawing.Size(75, 23)
        Me.btnWijzig.TabIndex = 9
        Me.btnWijzig.Text = "Wijzig "
        Me.btnWijzig.UseVisualStyleBackColor = True
        '
        'btnAfsluiten
        '
        Me.btnAfsluiten.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAfsluiten.Location = New System.Drawing.Point(370, 217)
        Me.btnAfsluiten.Name = "btnAfsluiten"
        Me.btnAfsluiten.Size = New System.Drawing.Size(75, 23)
        Me.btnAfsluiten.TabIndex = 10
        Me.btnAfsluiten.Text = "Afsluiten"
        Me.btnAfsluiten.UseVisualStyleBackColor = True
        '
        'btnOpslaan
        '
        Me.btnOpslaan.Location = New System.Drawing.Point(241, 217)
        Me.btnOpslaan.Name = "btnOpslaan"
        Me.btnOpslaan.Size = New System.Drawing.Size(75, 23)
        Me.btnOpslaan.TabIndex = 11
        Me.btnOpslaan.Text = "Opslaan"
        Me.btnOpslaan.UseVisualStyleBackColor = True
        Me.btnOpslaan.Visible = False
        '
        'Wijzigen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAfsluiten
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnOpslaan)
        Me.Controls.Add(Me.btnAfsluiten)
        Me.Controls.Add(Me.btnWijzig)
        Me.Controls.Add(Me.btnWis)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Wijzigen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wijzigen nummer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnWis As Button
    Friend WithEvents btnWijzig As Button
    Friend WithEvents btnAfsluiten As Button
    Friend WithEvents btnOpslaan As Button
End Class
