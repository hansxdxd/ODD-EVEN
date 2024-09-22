' Odd or Even Number Checker
Module OddOrEven
    Sub Main()
        ' Ask the user to input a number
        Console.Write("Enter a number: ")

        ' Read the input and convert it to an integer
        Dim number As Integer = Convert.ToInt32(Console.ReadLine())

        ' Check if the number is odd or even
        If number Mod 2 = 0 Then
            Console.WriteLine(number & " is an Even number.")
        Else
            Console.WriteLine(number & " is an Odd number.")
        End If

        ' Wait for the user to press a key before closing
        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()
    End Sub
End Module
