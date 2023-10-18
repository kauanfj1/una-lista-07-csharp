using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> listaFrutas = new List<string>();

        listaFrutas.Add("Maçã");
        listaFrutas.Add("Banana");
        listaFrutas.Add("Laranja");

        Console.WriteLine("Lista de Frutas:");
        foreach (var fruta in listaFrutas)
        {
            Console.WriteLine(fruta);
        }
    }
}
