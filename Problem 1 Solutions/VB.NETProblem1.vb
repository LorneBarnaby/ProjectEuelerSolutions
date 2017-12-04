Module Module1

    Sub Main()
        Dim total As Integer = 0
        For i As Integer = 1 To 999
            If (i Mod 5 = 0) Or (i Mod 3 = 0) Then
                total += i
            End If
        Next
        Console.WriteLine(total)
        Console.Read()
    End Sub

End Module
