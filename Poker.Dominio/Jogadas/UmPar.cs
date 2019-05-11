namespace Poker.Dominio.Jogadas
{
    public class UmPar : Jogada
    {
        public UmPar(int[] mao) : base(mao) { }

        public override bool EhValida()
        {
            for (int i = 0; i < Mao.Length - 1; i++)
            {
                for (int j = i + 1; j < Mao.Length; j++)
                {
                    if (Mao[i] == Mao[j]) return true;
                }
            }
            return false;
        }
    }
}