using GameTOP.Interface;

namespace GameTOP.lib
{
    public class Jogador2 : iJogador
    {
        public string Chutar()
        {
            return "Maradona estas pateando \n";
        }

        public string Correr()
        {
            return "Maradona estas corriendo \n";
        }

        public string Passe()
        {
            return "Maradona estas passe \n";
        }
    }
}