using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("ola, digite a senha para prosseguir:");
            string senha = Console.ReadLine();
            if (senha == "FORUM"){
                goto continuacao;
            }
            //else if(senha == "FÓRUM"){
                //goto continuacao;
            //}

            else{
                System.Console.WriteLine("bem, voce errou a senha. tente novamente ");
                System.Environment.Exit(0);
            }

            continuacao:
            System.Console.WriteLine("hmm entao voce sabe mexer com coordenadas hein");
            System.Console.WriteLine("otimo, sera necessario");
            System.Console.WriteLine("pronto para o proximo?");
            System.Console.WriteLine("pressione enter para prosseguir");

            Console.ReadLine();

            System.Console.WriteLine("a dica eh");
            System.Console.WriteLine("em memorium 2 <preset>");
            System.Console.WriteLine("talvez o ingles te ajude");
            System.Console.WriteLine("confuso e mal formulado neh, mas nao se preocupe, a resposta eh mais simples do que parece");
            System.Console.WriteLine("pressione enter para prosseguir");

            Console.ReadLine();

            System.Console.WriteLine("vai la");

            Console.ReadLine();
        }
    }
}
