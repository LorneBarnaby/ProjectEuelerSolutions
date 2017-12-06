Module Module1

    Dim palindromes As New List(Of Integer)
    Dim digits As Integer = 3

    Sub Main()
        findPalins(digits)
        palindromes.Sort()
        Console.WriteLine(palindromes(palindromes.Count - 1))
        Console.Read()
    End Sub

    Sub findPalins(dig As Integer)
        Dim limit As Integer = Convert.ToInt32(Math.Pow(10, dig) - 1)
        For i As Integer = 1 To limit
            For j As Integer = 1S To limit
                Dim product As Integer = i * j
                If (isPalin(product)) Then
                    palindromes.Add(product)
                End If
            Next
        Next
    End Sub

    Function isPalin(n)
        Dim first As String = n.ToString()
        Dim firstARR() As Char = first.ToCharArray()
        Array.Reverse(firstARR)
        Dim final As String = New String(firstARR)
        If (final = first) Then
            Return True
        Else
            Return False
        End If
    End Function

End Module
