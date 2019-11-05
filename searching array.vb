Module Module1

    Sub Main()
        Dim Marks(8) As Integer
        Dim StuMarks, INDEX, COUNT, A, COUNTER As Integer
        Dim Found As Boolean

        stumarks = 0
        index = 0
        a = 0
        count = 0
        Found = False
        Counter = 0

        For COUNT = 1 To 8
            Marks(COUNT) = 0
        Next COUNT

        For Index = 1 To 8
            Console.Write(" ENTER MARKS OF STUDENT NO " & INDEX & ": ")
            StuMarks = Console.ReadLine
            Marks(INDEX) = StuMarks
        Next Index


        Console.Write("enter marks to be searched in array: ")
        A = Console.ReadLine
        For COUNTER = 1 To 8
            If Marks(COUNTER) = A Then
                Found = True
                Exit For
            End If
        Next

        If Found = True Then
            Console.Write(A & " " & "is found in array at location " & COUNTER)
        End If
        Console.ReadKey()
    End Sub

End Module
