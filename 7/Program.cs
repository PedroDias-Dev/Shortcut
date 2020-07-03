using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("ola, digite a senha para prosseguir:");
            string senha = Console.ReadLine();
            if (senha == "PONTO"){
                goto continuacao;
            }
            else{
                System.Console.WriteLine("bem, voce errou a senha. tente novamente ");
                Console.ReadLine();
                System.Environment.Exit(0);
            }

            continuacao:
            System.Console.WriteLine("boa boa meu consagrado");
            System.Console.WriteLine("pegou o jeito");
            System.Console.WriteLine("podemos ir para o proximo desafio?");
            System.Console.WriteLine("pressione enter para prosseguir");

            Console.ReadLine();

            System.Console.WriteLine("a dica eh a seguinte");
            System.Console.WriteLine("a senha eh o que voce quiser");
            System.Console.WriteLine("nao literalmente, mas eh o que voce quiser");
            System.Console.WriteLine("caso voce nao tenha entendido, pressione enter para prosseguir");

            Console.ReadLine();

            System.Console.WriteLine("da teu jeito");
            System.Console.WriteLine("em ultimo caso, abra o codigo");

            Console.ReadLine();
        }
    }
}
