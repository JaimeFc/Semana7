using System;
using System.Collections.Generic;

// Esta clase contiene toda la lógica para validar si una fórmula está balanceada
public class ValidadorBalanceo
{
    // Método principal que verifica si la fórmula es balanceada
    public static bool EsFormulaBalanceada(string? formula)
    {
        // Si la fórmula es nula, devolvemos falso porque no se puede validar
        if (formula == null) return false;

        // Usamos una pila para manejar los caracteres de apertura
        Stack<char> pila = new Stack<char>();

        // Recorremos cada carácter en la fórmula
        foreach (char c in formula)
        {
            // Si es un paréntesis, corchete o llave de apertura, lo agregamos a la pila
            if (c == '(' || c == '[' || c == '{')
            {
                pila.Push(c);
            }
            // Si es un carácter de cierre
            else if (c == ')' || c == ']' || c == '}')
            {
                // Si la pila está vacía, significa que no hay un carácter de apertura correspondiente
                if (pila.Count == 0) return false;

                // Quitamos el último elemento de la pila (carácter de apertura)
                char tope = pila.Pop();

                // Verificamos si el carácter de apertura coincide con el de cierre
                if (!EsParCoincidente(tope, c)) return false;
            }
        }

        // Al final, la pila debe estar vacía si todo está balanceado
        return pila.Count == 0;
    }

    // Método que comprueba si un carácter de apertura coincide con su cierre
    private static bool EsParCoincidente(char apertura, char cierre)
    {
        // Verifica cada combinación válida de apertura y cierre
        return (apertura == '(' && cierre == ')') ||
               (apertura == '[' && cierre == ']') ||
               (apertura == '{' && cierre == '}');
    }
}
