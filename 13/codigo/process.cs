using System;

namespace codigo
{
    public class process
    {
        public void VerificarSenha(){
            System.Console.WriteLine("ola, digite a senha para prosseguir:");
            string senha = Console.ReadLine();
            if (senha == "FREEDOM"){
                
            }
            else{
                System.Console.WriteLine("bem, voce errou a senha. tente novamente ");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
        }
    }
}