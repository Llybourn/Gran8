Module Module1

    Sub Main()
        Dim random As New Random()
        Dim D1 As Integer
        Dim D2 As Integer
        Dim suma As Integer
        Dim juegoActivo As Boolean = True

        While juegoActivo
            ' Lanzar los dados
            D1 = Random.Next(1, 7)
            D2 = Random.Next(1, 7)
            suma = D1 + D2

            ' Mostrar los valores de los dados
            Console.WriteLine("Dado 1: " & D1)
            Console.WriteLine("Dado 2: " & D2)
            Console.WriteLine("Suma de ambos dados: " & suma)

            ' Verificar el resultado
            If suma = 8 Then
                Console.WriteLine("¡Felicidades! Ganaste con un 8.")
                juegoActivo = False
            ElseIf suma = 7 Then
                Console.WriteLine("Lo siento, perdiste con un 7.")
                juegoActivo = False
            Else
                Console.WriteLine("No se ha obtenido un 7 ni un 8. Lanzando de nuevo...")
            End If

            Console.WriteLine()
        End While

        Console.WriteLine("Fin del juego.")
        Console.ReadLine()
    End Sub

End Module
