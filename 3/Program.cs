using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("ola, digite a senha para prosseguir:");
            string senha = Console.ReadLine();
            if (senha == "2"){
                goto continuacao;
            }
            else{
                System.Console.WriteLine("bem, voce errou a senha. tente novamente ");
                System.Environment.Exit(0);
            }

            continuacao:

            System.Console.WriteLine("conseguiu denovo hein espertinho");
            System.Console.WriteLine("mas nao vai ficando feliz nao hein");
            System.Console.WriteLine("pressione enter para prosseguir");

            Console.ReadLine();

            System.Console.WriteLine("obviamente os desafios vao ficar cada vez mais dificeis");
            System.Console.WriteLine("e a dica para o proximo eh");
            System.Console.WriteLine("o minerio novo do minecraft");
            System.Console.WriteLine("pressione enter para prosseguir");

            Console.ReadLine();

            System.Console.WriteLine("pois eh, eu sou um gamer mesmo, e dai");
            System.Console.WriteLine("alias, caso voce nao saiba, nao ha problema em pesquisar a resposta");
            System.Console.WriteLine("agora vai la vai");

            Console.ReadLine();

        }
    }
}
