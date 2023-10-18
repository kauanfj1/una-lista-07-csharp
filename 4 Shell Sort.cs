using System;

class Program
{
    static void Main()
    {
        int[] vetor = { 1, 100, 30, 50, 11, 13, 5, 7, 78 };

        Console.WriteLine("Vetor não ordenado:");
        ImprimirVetor(vetor);

        ShellSort(vetor);

        Console.WriteLine("\nVetor ordenado:");
        ImprimirVetor(vetor);
    }

    static void ShellSort(int[] vetor)
    {
        int n = vetor.Length;
        int lacuna = n / 2;

        while (lacuna > 0)
        {
            for (int i = lacuna; i < n; i++)
            {
                int temp = vetor[i];
                int j = i;

                while (j >= lacuna && vetor[j - lacuna] > temp)
                {
                    vetor[j] = vetor[j - lacuna];
                    j -= lacuna;
                }

                vetor[j] = temp;
            }

            lacuna /= 2;
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
