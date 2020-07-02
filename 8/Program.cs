using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("ola, digite a senha para prosseguir:");
            string senha = Console.ReadLine();

            // pois eh, muda ali, a senha agora eh o que voce quiser
            if (senha == "a"){
                // obviamente mudadando o codigo, o aplicativo nao ira mais funcionar, entao pense nisso nas proximas fases
                // em vez de executar o exe, executa aqui mesmo, ja que voce ta se achando o programador

                // o exe pode conter informacoes adicionais, entao nao recomendo mexer no codigo
                // seu boco
                
                goto continuacao;
            }
            else{
                System.Console.WriteLine("bem, voce errou a senha. tente novamente ");
                System.Environment.Exit(0);
            }

            continuacao:
            process process1 = new process();
            process1.Process();
        }
    }
}
