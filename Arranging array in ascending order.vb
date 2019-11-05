Module Module1

    Sub Main()
        Dim marks(8) As Integer
        Dim StuMarks, index, count, a, b, C, D, E As Integer


        stumarks = 0
        index = 0
        a = 0
        count = 0
        B = 0
        C = 0
        D = 0
        E = 0

        For COUNT = 1 To 8
            marks(count) = 0
        Next

        For Index = 1 To 8
            Console.Write(" ENTER MARKS OF STUDENT NO " & index & ": ")
            StuMarks = Console.ReadLine
            marks(index) = StuMarks
        Next


        For a = 7 To 1 Step -1
            For C = 1 To a
                If marks(C) > marks(C + 1) Then
                    b = marks(C)
                    marks(C) = marks(C + 1)
                    marks(C + 1) = b
                End If
            Next
        Next

        Console.WriteLine("MARKS IN ASCENDING ORDER ARE: ")
        For D = 1 To 8
            E = marks(D)
            Console.WriteLine(E)
        Next
        Console.ReadKey()
    End Sub

End Module
