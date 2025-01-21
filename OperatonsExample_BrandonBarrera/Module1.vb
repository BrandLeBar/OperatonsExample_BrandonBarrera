'Brandon Barrera
'Spring 2025
'RCET2265
'OperatorsExample
'

Option Compare Text

Module Module1

    Sub Main()
        'sum operator
        Console.Write("5+3=") 'print a string
        Console.WriteLine(5 + 3) 'print the sum
        Console.WriteLine()

        'difference operator
        Console.Write("5-3=") 'print a string
        Console.WriteLine(5 - 3) 'print the difference
        Console.WriteLine()

        'multiplication operator
        Console.Write("5*3=") 'print a string
        Console.WriteLine(5 * 3) 'print the product
        Console.WriteLine()

        'integer division operator
        Console.Write("5/3=") 'print a string
        Console.WriteLine(5 / 3) 'print the difference
        Console.WriteLine()

        'Compare
        Console.WriteLine("5>3=") 'print a string
        Console.WriteLine(5 > 3) 'print exponent
        Console.WriteLine()

        Console.WriteLine("5<3=") 'print a string
        Console.WriteLine(5 < 3) 'print exponent
        Console.WriteLine()

        Console.WriteLine("5=3=") 'print a string
        Console.WriteLine(5 = 3) 'print exponent
        Console.WriteLine()

        Console.WriteLine("Is 5 not equal to 3?") 'print a string
        Console.WriteLine(5 <> 3) 'print exponent
        Console.WriteLine()

        Console.WriteLine("A < B =") 'print a string
        Console.WriteLine("A" < "B")
        Console.WriteLine()

        Console.WriteLine("Is " & Chr(34) & "A" & Chr(34) & " the same as " & Chr(34) & "a" & Chr(34) & " ?") 'print a string
        Console.WriteLine("A" = "a")
        Console.WriteLine()

    End Sub

End Module
