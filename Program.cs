//Impressão de numeros FIBONACCI separados por virgula

using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidNumeros = 100;
            ulong numA = 0;
            ulong numB = 1;
            ulong numC;

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