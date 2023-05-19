using System;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        int K = int.Parse(input[1]);

        string[] population = Console.ReadLine().Split();

        int maxPopulation = 0;
        //Console.WriteLine(N);
        //Console.WriteLine(K);

        for (int i = 1; i < N-K; i++)
        {
            int sum = 0;

            sum += int.Parse(population[i]);
            //Console.Write(population[i] + "+");

            for (int j = 0; j < K; j++)
            {
                sum += int.Parse(population[i+1]);
                //Console.Write(population[i+1] + "+");
                sum += int.Parse(population[i-1]);
                //Console.Write(population[i-1] + "+");
            }

            //Console.WriteLine(" = " + sum);

            if (sum > maxPopulation)
            {
                maxPopulation = sum;
            }
        }
        Console.WriteLine(maxPopulation);
    }
}

