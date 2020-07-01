using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("ola, digite a senha para prosseguir:");
            string senha = Console.ReadLine();
            if (senha == "SONGS"){
                goto continuacao;
            }
            else{
                System.Console.WriteLine("bem, voce errou a senha. tente novamente ");
                System.Environment.Exit(0);
            }

            continuacao:
            System.Console.WriteLine("EM ANDAMENTO");

            Console.ReadLine();
        }
    }
}
