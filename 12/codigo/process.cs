using System;
using System.IO;

namespace codigo
{
    public class process
    {
        public void VerificarSenha(){
            System.Console.WriteLine("ola, digite a senha para prosseguir:");
            string senha = Console.ReadLine();
            if (senha == "TEMPO"){
                
            }
            else{
                System.Console.WriteLine("bem, voce errou a senha. tente novamente ");
                Console.ReadLine();
                System.Environment.Exit(0);
            }

        }

        public void Write() {

            // Cria o nome do arquivo com ano, mês, dia, hora minuto e segundo

            string nomeArquivo = @"C:\Users\pedro\Documents\Programação\Shortcut\12\esse_mesmo" + ".txt";

            // Cria um novo arquivo e devolve um StreamWriter para ele

            StreamWriter writer = new StreamWriter(nomeArquivo);

            // Agora é só sair escrevendo

            writer.WriteLine("01101000 01110100 01110100 01110000 01110011 00111010 00101111 00101111 01110111 01110111 01110111 00101110 01101110 01100101 01111000 01110101 01110011 01101101 01101111 01100100 01110011 00101110 01100011 01101111 01101101 00101111 01110011 01110100 01100001 01110010 01100100 01100101 01110111 01110110 01100001 01101100 01101100 01100101 01111001 00101111 01101101 01101111 01100100 01110011 00101111 00110100 00110001");

            // Não esqueça de fechar o arquivo ao terminar

            writer.Close();

}

}

}
        
            //File.WriteAllText(PATH, "01101000 01110100 01110100 01110000 01110011 00111010 00101111 00101111 01110111 01110111 01110111 00101110 01101110 01100101 01111000 01110101 01110011 01101101 01101111 01100100 01110011 00101110 01100011 01101111 01101101 00101111 01110011 01110100 01100001 01110010 01100100 01100101 01110111 01110110 01100001 01101100 01101100 01100101 01111001 00101111 01101101 01101111 01100100 01110011 00101111 00110100 00110001");
