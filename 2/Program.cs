using System;
using System.Diagnostics;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.WriteLine("ola, digite a senha para prosseguir:");
            string senha = Console.ReadLine();
            if (senha == "GENIO"){
                goto continuacao;
            }
            else{
                System.Console.WriteLine("bem, voce errou a senha. tente novamente ");
                Console.ReadLine();
                System.Environment.Exit(0);
            }

            continuacao:
            System.Console.WriteLine("olha so, voce conseguiu mesmo");
            System.Console.WriteLine("pode tentar ir para a outra fase");
            System.Console.WriteLine("pressione enter para prosseguir");

            Console.ReadLine();

            System.Console.WriteLine("mas dessa vez nao vou te dar a senha");
            System.Console.WriteLine("pressione enter para prosseguir");

            Console.ReadLine();

            System.Console.WriteLine("a unica dica eh 1 + 1");
            System.Console.WriteLine("simples neh, vai la entao");

            Console.ReadLine();

            
        }
    }
}
