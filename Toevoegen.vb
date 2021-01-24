Public Class Toevoegen
    Private Sub btnToevoegen_Click(sender As Object, e As EventArgs) Handles btnToevoegen.Click
        'voer controle invoer uit
        If controlenaam(TextBox1.Text) = False Then
            MessageBox.Show("Naam ontbreekt of is niet correct")
            TextBox1.Focus()
            Exit Sub
        End If

        If controlenummer(TextBox2.Text) = False Then
            MessageBox.Show("Telefoon nummer ontbreekt of is niet correct")
            TextBox2.Focus()
            Exit Sub
        End If

        'voeg nummer toe aan Hashtable
        Dim naam As String = UCase(TextBox1.Text)
        telNrs(Trim(naam)) = Trim(TextBox2.Text)

        'maak de textboxen weer leeg
        TextBox1.Text = Nothing
        TextBox2.Text = Nothing
        TextBox1.Focus()
    End Sub

    Private Sub btnWis_Click(sender As Object, e As EventArgs) Handles btnWis.Click
        TextBox1.Text = Nothing
        TextBox2.Text = Nothing
        TextBox1.Focus()
    End Sub

    Private Sub btnSluit_Click(sender As Object, e As EventArgs) Handles btnSluit.Click
        Me.Close()
    End Sub

    Private Sub Toevoegen_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If TextBox1.Text <> Nothing And TextBox2.Text <> Nothing Then
            If MessageBox.Show("De invoer is niet bewaard" & vbCrLf & "weet u zeker dat u wilt afsluiten?", "Afsluiten", MessageBoxButtons.YesNo) = DialogResult.No Then
                e.Cancel = True
                Exit Sub
            End If
        End If

        Call OpslaanNrs()
    End Sub
End Class