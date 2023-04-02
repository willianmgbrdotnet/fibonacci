//Impressão de numeros FIBONACCI separados por virgula

using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidNumeros = 100;
            int numA = 0;
            int numB = 1;
            int numC;

            var sequencFibo = numA.ToString() + ", " + numB.ToString();
            
            //Determinando o proximo numero da sequencia a partir 
            //do terceiro numero 
            for (int i = 2; i < quantidNumeros; i++)
            {
                numC = numA + numB;
                numA = numB;
                numB = numC;

                sequencFibo = sequencFibo + ", " + numB.ToString();
            }
            System.Console.WriteLine(sequencFibo);
        }
    }
}