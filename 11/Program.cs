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
                Console.ReadLine();
                System.Environment.Exit(0);
            }

            continuacao:
            System.Console.WriteLine("<EM ANDAMENTO>");
            Console.WriteLine("o que anda, e nunca para?");
            Console.WriteLine("...");
            Console.ReadLine();

            Console.WriteLine("o andamento do universo...");
            Console.WriteLine("...");
            Console.ReadLine();

            Console.WriteLine("a execucao das mudancas inevitaveis");
            Console.WriteLine("...");
            Console.ReadLine();

            Console.WriteLine("a desculpa para vida");
            Console.WriteLine("...");
            Console.ReadLine();

            Console.WriteLine("determina a pressa, carateriza a lentidao");
            Console.WriteLine("...");
            Console.ReadLine();

            Console.WriteLine("eu avisei que ia ficar mais dificil");
            Console.WriteLine("vou testar seu raciocinio, e sua determinacao tambem");
            Console.WriteLine("vai la");
            Console.ReadLine();


        }
    }
}
