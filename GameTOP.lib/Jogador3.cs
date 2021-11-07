using GameTOP.Interface;

namespace GameTOP.lib
{
    public class Jogador3 : iJogador
    {
        public string Chutar()
        {
            return "Teste Chuta \n";
        }

        public string Correr()
        {
            return "Teste Corre \n";
        }

        public string Passe()
        {
            return "Teste Passe \n";
        }
    }
}