using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("ola, digite a senha para prosseguir:");
            string senha = Console.ReadLine();
            if (senha == "NETHERITE"){
                // pera laaa
                // ta abrindo o codigo neh...
                // achei que fosse proibido neh
                // mas ta bom neh
                // dessa vez
                // pega ai tua senha
                goto REDENCAO;
            }
            else{
                System.Console.WriteLine("bem, voce errou a senha. tente novamente ");
                System.Environment.Exit(0);
            }

            REDENCAO:
            System.Console.WriteLine("ta pegando o jeito neh");
            System.Console.WriteLine("mas beleza, nao comeca a se achar nao hein");
            System.Console.WriteLine("pressione enter para prosseguir");

            Console.ReadLine();

            System.Console.WriteLine("a partir daqui as coisas vao complicar um pouco");
            System.Console.WriteLine("a dica agora eh");
            System.Console.WriteLine("as vezes voce tem que olhar atraves do muro");
            System.Console.WriteLine("as vezes voce tem que quebrar as <REGRAS>");
            System.Console.WriteLine("procure o goto da quarta...");
            System.Console.WriteLine("pressione enter para prosseguir");

            Console.ReadLine();

            System.Console.WriteLine("complicou neh");
            System.Console.WriteLine("vai la, quero ver agora");

            Console.ReadLine();
        }
    }
}
