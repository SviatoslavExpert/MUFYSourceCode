﻿Module Module1

    'Declare global variables
    Dim Student As New Dictionary(Of String, Integer)
    Dim sname As String
    Dim age As Integer


    Sub Main()

        Call InputName()
        Call InputAge()
        Call DisplayNamewithAge()


    End Sub

    Sub InputName()
        For i = 1 To Name.Length() - 1
            Console.WriteLine("Please enter name:")
            sname = Console.ReadLine
            Console.WriteLine("Please enter age:")
            age = Console.ReadLine
            Student.Add(sname, age)
        Next
        For Each e
    End Sub

    Sub DisplayNamewithAge()

        Console.WriteLine("Who's information do you want to display? Enter their name...")
        nameDisplay = Console.ReadLine()
        For i = 1 To Name.Length() - 1

            If Name(i) = nameDisplay Then
                Console.WriteLine("Person's name is " & Name(i) & ", the person is" & Age.Item(i - 1) & " years old")
            End If
        Next

    End Sub

    Sub InputAge()
        For i = 1 To Name.Length() - 1
            Console.WriteLine("Please enter age of person " & i)
2:          ageAdd = Console.ReadLine()
            If IsNumeric(ageAdd) = True Then
                Age.Add(Str(ageAdd))
            Else
                Console.WriteLine("Invalid input, please enter again")
                GoTo 2
            End If
        Next

    End Sub


End Module
'Sub DisplayAge()
'    Console.WriteLine("Enter age of person to get")
'    ageDisplay = Console.ReadLine()
'    For i = 1 To Age.Length() - 1

'        If Age(i) = ageDisplay Then
'            Console.WriteLine("Person's age is " & Age(i))
'        End If
'    Next

'End Sub