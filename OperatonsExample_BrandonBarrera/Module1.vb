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

        Dim BanBan As Integer
        BanBan = (0) 'set BanBan as 0

        Console.WriteLine("BanBan = 34?")
        Console.WriteLine(BanBan = 34)
        Console.WriteLine()

        Do While (BanBan < 100) 'add one if less than
            BanBan = (BanBan + 1)
            Console.WriteLine("BanBan = " & BanBan)
            Console.WriteLine()
        Loop

        If (BanBan = 100) Then
            Console.WriteLine("All Done!") 'inform BanBan is done
            Console.WriteLine()
        End If

    End Sub

End Module
