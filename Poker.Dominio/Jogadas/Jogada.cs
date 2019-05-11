namespace Poker.Dominio.Jogadas
{
    public abstract class Jogada
    {
        public int[] Mao { get; private set; }
        public Jogada(int[] mao) => Mao = mao;

        public abstract bool EhValida();
    }
}