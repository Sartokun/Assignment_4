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

        for (int i = K; i < N-K; i++)
        {
            int sum = 0;

            sum += int.Parse(population[i]);
            //Console.Write(population[i] + "+");

            for (int j = 1; j < K+1; j++)
            {
                sum += int.Parse(population[i+j]);
                //Console.Write(population[i+j] + "+");
                sum += int.Parse(population[i-j]);
                //Console.Write(population[i-j] + "+");
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

