using System;
using System.IO;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("ola, digite a senha para prosseguir:");
            string senha = Console.ReadLine();
            if (senha == "MARIO QUINTANA"){
                goto continuacao;
            }
            else{
                System.Console.WriteLine("bem, voce errou a senha. tente novamente ");
                System.Environment.Exit(0);
            }

            continuacao:
            System.Console.WriteLine("muito bem, provou que eh inteligente");
            System.Console.WriteLine("mas sera que eh suficiente?");
            System.Console.WriteLine("pressione enter para prosseguir");

            Console.ReadLine();

            System.Console.WriteLine("dessa vez voce nao precisa abrir o codigo seu espertinho");
            System.Console.WriteLine("olha a pasta 6 mesmo");
            System.Console.WriteLine("so isso");
            System.Console.WriteLine("so isso mesmo");
            System.Console.WriteLine("pressione enter para prosseguir");

            Console.ReadLine();

            System.Console.WriteLine("ja falei que eh so isso, vai la agora");
            process process1 = new process();
            process1.Write();

            Console.ReadLine();
          
        }
    }
}
