
Imports System.IO
Module Module1

    Sub data_writer() 
        Dim file_writer As StreamWriter
        Dim i, sum As Integer
        sum = 0
        file_writer = File.CreateText("E:/BDC/Data.txt")
        For i = 1 to 60
            If i Mod 2 = 0 Then
               sum = sum + i
               file_writer.WriteLine(i)
            End If
        Next
        file_writer.WriteLine("Sum of values = " & sum)
        file_writer.Close()
   
    End Sub
    Sub Main()
        Call data_writer()
               

    End Sub

End Module
