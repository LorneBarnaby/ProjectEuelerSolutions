Module Module1

    Dim number As Long = 600851475143
    Dim divisors As New List(Of Long)
    Dim primeDivisors As New List(Of Long)
    Dim iter As Integer = 1

    Sub Main()
        getDivs()
        getPrimes()
        primeDivisors.Sort()
        Console.WriteLine(primeDivisors(primeDivisors.Count - 1))
        Console.Read()
    End Sub

    Sub getDivs()
        While iter < Math.Floor(number / 2) 'as with every single other one please make this 87 million unless you wish to wait multiple hours for your computer to figure this out 
            If (number Mod iter = 0) Then
                divisors.Add(iter)
            End If
            iter += 2
        End While
    End Sub

    Sub getPrimes()
        For Each thing As Long In divisors
            If checkPrime(thing) Then
                primeDivisors.Add(thing)
            End If
        Next

    End Sub


    Function checkPrime(n As Long)
        If n <= 1 Then
            Return False
        ElseIf n <= 3 Then
            Return True
        ElseIf n Mod 2 = 0 Or n Mod 3 = 0 Then
            Return False
        End If
        Dim i As Integer = 5
        While (i * i <= n)
            If ((n Mod i = 0) Or (n Mod (i + 2) = 0)) Then
                Return False
            End If
            i += 6
        End While
        Return True
    End Function

End Module
