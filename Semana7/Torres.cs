using System;
using System.Collections.Generic;

// Clase para resolver el problema de las Torres de Hanoi utilizando pilas
public class TorresDeHanoi
{
    // Método para resolver las Torres de Hanoi con pilas
    public static void Resolver(int numeroDiscos)
    {
        // Creamos tres pilas: origen, auxiliar y destino
        Stack<int> origen = new Stack<int>();
        Stack<int> auxiliar = new Stack<int>();
        Stack<int> destino = new Stack<int>();

        // Inicializamos la pila origen con los discos (del más grande al más pequeño)
        for (int i = numeroDiscos; i > 0; i--)
        {
            origen.Push(i);
        }

        // Llamamos al método recursivo para mover los discos
        MoverDiscos(numeroDiscos, origen, destino, auxiliar, "Origen", "Destino", "Auxiliar");
    }

    // Método recursivo para mover los discos
    private static void MoverDiscos(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar, string nombreOrigen, string nombreDestino, string nombreAuxiliar)
    {
        if (n == 1)
        {
            // Mover un solo disco de origen a destino
            int disco = origen.Pop();
            destino.Push(disco);
            Console.WriteLine($"Mover disco {disco} de {nombreOrigen} a {nombreDestino}");
        }
        else
        {
            // Mover los n-1 discos de origen a auxiliar
            MoverDiscos(n - 1, origen, auxiliar, destino, nombreOrigen, nombreAuxiliar, nombreDestino);

            // Mover el disco restante de origen a destino
            int disco = origen.Pop();
            destino.Push(disco);
            Console.WriteLine($"Mover disco {disco} de {nombreOrigen} a {nombreDestino}");

            // Mover los n-1 discos de auxiliar a destino
            MoverDiscos(n - 1, auxiliar, destino, origen, nombreAuxiliar, nombreDestino, nombreOrigen);
        }
    }
}
