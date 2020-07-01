using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("ola, digite a senha para prosseguir:");
            string senha = Console.ReadLine();
            if (senha == "OMNISPHERE"){
                goto continuacao;
            }
            else{
                System.Console.WriteLine("bem, voce errou a senha. tente novamente ");
                System.Environment.Exit(0);
            }

            continuacao:
            System.Console.WriteLine("sem duvida o melhor preset de um dos melhores vsts");
            System.Console.WriteLine("desculpa, me destrai");
            System.Console.WriteLine("vamos para o ultimo dos fáceis?");
            System.Console.WriteLine("pressione enter para prosseguir");

            Console.ReadLine();

            System.Console.WriteLine("a dica eh");
            System.Console.WriteLine("ha um codigo em bin");
            System.Console.WriteLine("siga o caminho");
            System.Console.WriteLine("primeira palavra em seu site");
            System.Console.WriteLine("pressione enter para prosseguir");

            Console.ReadLine();

            System.Console.WriteLine("vai la");

            Console.ReadLine();
        }
    }
}
