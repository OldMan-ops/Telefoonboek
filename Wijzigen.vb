Public Class Wijzigen
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim naam As String = UCase(TextBox1.Text)
        If telNrs.ContainsKey(naam) Then
            TextBox2.Text = telNrs(naam).ToString
            TextBox1.Text = naam
        End If
    End Sub

    Private Sub btnWis_Click(sender As Object, e As EventArgs) Handles btnWis.Click
        Dim naam As String = UCase(TextBox1.Text)
        If telNrs.ContainsKey(naam) Then
            telNrs.Remove(naam)
        End If

        TextBox1.Text = Nothing
        TextBox2.Text = Nothing

    End Sub

    Private Sub btnWijzig_Click(sender As Object, e As EventArgs) Handles btnWijzig.Click
        TextBox1.Enabled = False
        TextBox2.Enabled = False

        Label3.Visible = True
        Label4.Visible = True
        TextBox3.Visible = True
        TextBox4.Visible = True

        btnWijzig.Visible = False
        btnOpslaan.Visible = True
        TextBox3.Text = TextBox1.Text
        TextBox4.Text = TextBox2.Text
    End Sub

    Private Sub btnOpslaan_Click(sender As Object, e As EventArgs) Handles btnOpslaan.Click
        'voer controle invoer uit
        If controlenaam(TextBox1.Text) = False Then
            MessageBox.Show("Naam niet correct")
            TextBox1.Focus()
            Exit Sub
        End If

        If controlenummer(TextBox2.Text) = False Then
            MessageBox.Show("Telefoonnummer niet correct")
            TextBox2.Focus()
            Exit Sub
        End If

        'verwijder oude gegevens uit Hashtable
        telNrs.Remove(TextBox1.Text)

        'voeg nummer toe aan Hashtable
        Dim naam As String = UCase(TextBox3.Text)
        telNrs(Trim(naam)) = Trim(TextBox4.Text)

        'terug naar oude situatie
        Call Terugzetten()
    End Sub
    Private Sub terugzetten()
        'maak de textboxen weer leeg
        TextBox1.Text = Nothing
        TextBox2.Text = Nothing
        TextBox1.Focus()

        'alles weer terug zetten
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox1.Text = TextBox3.Text
        TextBox2.Text = TextBox4.Text
        Label3.Visible = False
        Label4.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False

        btnWijzig.Visible = True
        btnOpslaan.Visible = False
    End Sub

    Private Sub Wijzigen_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If btnOpslaan.Visible = True Then
            If MessageBox.Show("Wijzigingen zijn niet opgeslagen" & vbCrLf & "weet u zeker dat u wilt afsluiten?", "Afsluiten", MessageBoxButtons.YesNo) = DialogResult.No Then
                e.Cancel = True
                Exit Sub
            End If
            Call terugzetten()
        End If

        Call OpslaanNrs()

    End Sub
End Class