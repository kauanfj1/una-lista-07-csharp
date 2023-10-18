using System;

class Program
{
    static void Main()
    {
        int[] vetor = { 1, 100, 30, 50, 11, 13, 5, 7, 78 };

        Console.WriteLine("Vetor não ordenado:");
        ImprimirVetor(vetor);

        OrdenacaoPorInsercao(vetor);

        Console.WriteLine("\nVetor ordenado:");
        ImprimirVetor(vetor);
    }

    static void OrdenacaoPorInsercao(int[] vetor)
    {
        int n = vetor.Length;

        for (int i = 1; i < n; i++)
        {
            int chave = vetor[i];
            int j = i - 1;

            while (j >= 0 && vetor[j] > chave)
            {
                vetor[j + 1] = vetor[j];
                j--;
            }

            vetor[j + 1] = chave;
        }
    }

    static void ImprimirVetor(int[] vetor)
    {
        foreach (var item in vetor)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
