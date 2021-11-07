using GameTOP.Interface;

namespace GameTOP.lib
{
    public class Jogador1 : iJogador
    {
        public readonly string _Nome;        

        public Jogador1(string nome = "Ronaldo")
        {
            _Nome = nome;
        }

        // o que um jogador faz
        //1-> CHUTA
        public string Chutar()
        {
            return $"{_Nome} está Chutando \n";
        }
        //2-> CORRE
        public string Correr()
        {
            return $"{_Nome} está Correndo \n";
        }
        //3-> PASSE
        public string Passe()
        {
            return $"{_Nome} está Passando \n";
        }
    }
}