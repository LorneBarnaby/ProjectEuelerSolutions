Module Module1
    Sub Main()
        Dim j As Integer = 20
        While (True)
            If (divisibleBy1To(20, j)) Then
                Exit While
            End If
            j += 20
        End While
        Console.WriteLine(j)
        Console.Read()
    End Sub

    Public Function divisibleBy1To(rangeOf As Integer, n As Integer)
        For i As Integer = 1 To rangeOf
            If n Mod i = 0 Then
                Continue For
            Else
                Return False
            End If
        Next
        Return True
    End Function
End Module
