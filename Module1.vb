Module Module1
    Public telNrs As New Hashtable()
    Dim folder As String = System.Environment.GetFolderPath _
                (Environment.SpecialFolder.MyDocuments) & "\telefoonboek"
    Dim bestand As String = folder & "\" & "telNrs.txt"
    Public Sub LadenNrs()
        'controleer bestaan bestand
        If Not System.IO.File.Exists(bestand) Then
            MessageBox.Show("Er zijn geen telefoonnummers opgeslagen")
        Else
            'lezen Hashtable
            Dim objReader As New System.IO.StreamReader(bestand)
            Dim naam As String
            Dim telNr As String

            Do While objReader.Peek <> -1
                naam = objReader.ReadLine
                telNr = objReader.ReadLine

                telNrs.Add(naam, telNr)
            Loop
            objReader.Close()
            objReader.Dispose()
        End If
    End Sub
    Public Sub OpslaanNrs()
        'controle folder bestaat, zo niet dan aanmaken
        If Not System.IO.Directory.Exists(folder) Then
            System.IO.Directory.CreateDirectory(folder)
        End If
        'opslaan Hastable telNrs
        Dim objwriter As New System.IO.StreamWriter(bestand)
        For Each telnr As DictionaryEntry In telNrs
            objwriter.WriteLine((telnr.Key).ToString)
            objwriter.WriteLine((telnr.Value).ToString)
        Next
        objwriter.Close()

        'geheugen ruimte vrijmaken
        objwriter.Dispose()
    End Sub
    Public Function controlenaam(naam As String) As Boolean
        Dim letters As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ "
        Dim karakter As Char

        'controle tekst aanwezig
        If String.IsNullOrWhiteSpace(naam) Then
            controlenaam = False
            Exit Function
        End If

        'omzetten naam naar kleine letters
        naam = UCase(naam)

        'controler elk karakter uit naam
        For i = 0 To naam.Length - 1
            karakter = naam.Chars(i)
            If Not InStr(letters, karakter.ToString) > 0 Then
                controlenaam = False
                Exit Function
            End If
        Next

        controlenaam = True
    End Function

    Public Function controlenummer(nummer As String) As Boolean
        Dim karakter As Char

        'controle nummer aanwezig
        If String.IsNullOrWhiteSpace(nummer) Then
            controlenummer = False
            Exit Function
        End If

        'test elk karakter
        For i = 0 To nummer.Length - 1
            karakter = nummer.Chars(i)
            If Not IsNumeric(karakter.ToString) And karakter.ToString <> " " Then
                controlenummer = False
                Exit Function
            End If
        Next

        controlenummer = True
    End Function
End Module
