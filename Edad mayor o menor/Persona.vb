Public Class Persona
    'Atributos de la clase persona 
    Private nombre As String
    Private edad As Integer
    'Método
    Public Sub Edades()
        'Declaramos los atributos
        Console.WriteLine("Ingrese el nombre ")
        'Método para introducir una cadena de texto por la consola
        nombre = Console.ReadLine()
        Console.WriteLine("Ingrese la edad ")
        'Método para introducir un valor de tipo entero por la consola
        edad = Convert.ToInt32(Console.ReadLine())
        'Condición que evalúa el atributo edad 
        If edad >= 18 Then
            Console.WriteLine(nombre & " es mayor de edad")
        Else
            Console.WriteLine(nombre & " es menor de edad")
        End If
        Console.ReadLine()
    End Sub

End Class
