using System.IO;

namespace _6
{
    public class process
    {
        private const string PATH = "6/aqui.txt";


        public process(){

            string pasta = PATH.Split('/')[0];

            if (!Directory.Exists(pasta)) {
                Directory.CreateDirectory(pasta);
            }
            if(!File.Exists(PATH)){
                File.Create(PATH).Close();
            }
        }

        public void Write(){
            File.WriteAllText(PATH, " пароли шумо мехоҳед \n ТОЧИК \n танҳо ин");
        }
        
    }
}

//
//пароли шумо мехоҳед

//ТОЧИК

//танҳо ин