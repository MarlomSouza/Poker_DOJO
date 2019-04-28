namespace Poker
{
    public class UmPar
    {
        private int[] mao;

        public UmPar(int[] mao)
        {
            this.mao = mao;
        }

        public bool EhValida()
        {
            for (int i = 0; i < mao.Length - 1; i++)
            {
                for (int j = i + 1; j < mao.Length; j++)
                {
                    if (mao[i] == mao[j]) return true;
                }
            }
            return false;
        }
    }
}