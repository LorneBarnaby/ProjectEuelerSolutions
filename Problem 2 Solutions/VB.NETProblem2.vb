Module Module1

    Sub Main()
        Dim total As Integer = 0
        Dim num As Integer = 0
        Dim counter As Integer = 0

        While num < 4000000
            counter += 1
            num = fib(counter)
            If num Mod 2 = 0 Then
                total += num
            End If
        End While
        Console.Write(total)
        Console.Read()
    End Sub

    Function fib(n As Integer)
        If n <= 1 Then
            Return n
        Else
            Return fib(n - 1) + fib(n - 2)
        End If
    End Function

End Module
