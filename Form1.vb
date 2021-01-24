Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LadenNrs()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim naam As String = UCase(TextBox1.Text)
        If telNrs.ContainsKey(naam) Then
            TextBox2.Text = telNrs(naam).ToString
            TextBox1.Text = naam
        End If
    End Sub

    Private Sub NieuweNummersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NieuweNummersToolStripMenuItem.Click
        Toevoegen.ShowDialog()
    End Sub

    Private Sub WijzigNummersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WijzigNummersToolStripMenuItem.Click
        Wijzigen.ShowDialog()
    End Sub
End Class
