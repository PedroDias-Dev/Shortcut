using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("ola, digite a senha para prosseguir:");
            string senha = Console.ReadLine();
            if (senha == "REDENCAO"){
                goto continuacao;
            }
            else{
                System.Console.WriteLine("bem, voce errou a senha. tente novamente ");
                System.Environment.Exit(0);
            }

            continuacao:
            System.Console.WriteLine("olha so, rebelde voce ein");
            System.Console.WriteLine("depois nao disse que eu nao avisei");
            System.Console.WriteLine("pressione enter para prosseguir");

            Console.ReadLine();

            System.Console.WriteLine("a proxima ta no mesmo esquema da ultima");
            System.Console.WriteLine("ja que voce quer quebrar as regras, manda ver");
            System.Console.WriteLine("a senha ta na segunda fase");
            System.Console.WriteLine("eh outro segredo");
            System.Console.WriteLine("pressione enter para prosseguir");

            Console.ReadLine();

            System.Console.WriteLine("eh isso, pode ir");
            Console.ReadLine();
        }
    }
}
