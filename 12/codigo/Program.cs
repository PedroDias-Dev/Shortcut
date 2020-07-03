using System;

namespace codigo
{
    class Program
    {
        static void Main(string[] args)
        {
            process process1 = new process();
            process1.VerificarSenha();

            System.Console.WriteLine("olha so, suas nocoes de logica sao boas mesmo");
            System.Console.WriteLine("como pode perceber, o codigo agora esta bloqueado, e para acessar...");
            System.Console.WriteLine("adivinha so, voce precisa de uma senha");
            System.Console.WriteLine("mas nao se preocupa, se fizer tudo certo, o codigo sera todo seu");
            System.Console.WriteLine("vamos prosseguir?");
            System.Console.WriteLine("pressione enter para prosseguir");

            Console.ReadLine();

            System.Console.WriteLine("no proximo desafio irei testar suas habilidades de pesquisa, novamente");
            process1.Write();
            System.Console.WriteLine("algo acabou de ser gerado nessa pasta");
            System.Console.WriteLine("siga seu caminho");
            System.Console.WriteLine("o que serao as permissoes? o que sao os creditos?");
            System.Console.WriteLine("O QUE EH A LICENCA?");
            System.Console.WriteLine("FREE AS IN -------");
            System.Console.WriteLine("pressione enter para prosseguir");

            Console.ReadLine();

            System.Console.WriteLine("so isso, pode ir");
            Console.ReadLine();
        }
    }
}
