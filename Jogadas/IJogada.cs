namespace Poker.Jogadas
{
    public abstract class Jogada
    {
        public int[] Mao { get; set; }
        public Jogada(int[] mao)
        {
            this.Mao = mao;
        }
        public abstract bool EhValida();
    }
}