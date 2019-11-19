Module Module1

    Sub Main()
        Dim NoArr(4, 6) As String
        Dim Row, Column, Row1, Column1, X, Y As Integer
        Dim AlreadyValue As Boolean

        X = 5
        Y = 7
        AlreadyValue = False

        'initialsing Array
        For Row = 1 To 4
            For Column = 1 To 6
                NoArr(Row, Column) = 0
            Next
        Next

        'populating Array
        For Row = 1 To 4
            For Column = 1 To 6
                Do
                    AlreadyValue = False
                    Row1 = Int((Rnd() * X - 1) + 1)
                    Column1 = Int((Rnd() * Y - 1) + 1)
                    If NoArr(Row1, Column1) = "X" Then
                        AlreadyValue = True
                    Else
                        NoArr(Row1, Column1) = "X"
                    End If
                Loop Until AlreadyValue = False
            Next
        Next
        'output Array
        For Row = 1 To 4
            For Column = 1 To 6
                Console.Write(NoArr(Row, Column))
            Next
            Console.WriteLine()
        Next
        Console.ReadKey()

    End Sub

End Module
