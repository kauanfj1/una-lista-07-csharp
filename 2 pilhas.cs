using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<int> pilhaNumeros = new Stack<int>();

        pilhaNumeros.Push(1);
        pilhaNumeros.Push(2);
        pilhaNumeros.Push(3);

        Console.WriteLine("Elementos da Pilha:");

        while (pilhaNumeros.Count > 0)
        {
            int numero = pilhaNumeros.Pop();
            Console.WriteLine(numero);
        }
    }
}
