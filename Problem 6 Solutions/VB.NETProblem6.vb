Module Module1
    Dim sumto As Integer = 100
    Dim totSumTo As Integer
    Dim totSumToSquared As Integer
    Dim squareOfAllFrom1Tosumto As Integer

    Sub Main()
        For i As Integer = 1 To sumto
            totSumTo += i
        Next
        totSumToSquared = Math.Pow(totSumTo, 2)
        For i As Integer = 1 To sumto
            squareOfAllFrom1Tosumto += Math.Pow(i, 2)
        Next
        Console.Write(totSumToSquared - squareOfAllFrom1Tosumto)
        Console.Read()
    End Sub
End Module
