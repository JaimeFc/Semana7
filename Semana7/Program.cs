using System;

// Esta es la clase principal que interactúa con el usuario
class Program
{
    static void Main()
    {
        // Mostramos un mensaje al usuario para que ingrese una fórmula matemática
        Console.WriteLine("=============================");
        Console.WriteLine("UNIVERSIDAD ESTATAL AMAZONICA");
        Console.WriteLine("=============================");
        Console.WriteLine("");
        Console.WriteLine("Ingrese la fórmula matemática:");
        
        // Leemos la entrada del usuario
        string? formula = Console.ReadLine();

        // Verificamos si el usuario no escribió nada
        if (string.IsNullOrEmpty(formula))
        {
            // Si no ingresó nada, mostramos un mensaje de error y terminamos el programa
            Console.WriteLine("La fórmula ingresada no es válida.");
            return;
        }

        // Llamamos al método EsFormulaBalanceada para verificar si la fórmula está balanceada
        if (ValidadorBalanceo.EsFormulaBalanceada(formula))
        {
            // Si está balanceada, mostramos el mensaje correspondiente
            Console.WriteLine("La fórmula está balanceada.");
        }
        else
        {
            // Si no está balanceada, mostramos otro mensaje
            Console.WriteLine("La fórmula no está balanceada.");
        }

// Clase principal para interactuar con el usuario


    
        Console.WriteLine("Ingrese el número de discos para las Torres de Hanoi:");
        
        // Leer el número de discos ingresado por el usuario
        if (int.TryParse(Console.ReadLine(), out int numeroDiscos) && numeroDiscos > 0)
        {
            // Resolver el problema de las Torres de Hanoi con el número de discos dado
            Console.WriteLine($"\nResolviendo las Torres de Hanoi para {numeroDiscos} discos:\n");
            TorresDeHanoi.Resolver(numeroDiscos);
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un número válido de discos (mayor a 0).");
        }
          
    }
}
