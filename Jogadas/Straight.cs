using System;

namespace Poker.Jogadas
{
    public class Straight
    {
        private int[] mao;

        public Straight(int[] mao)
        {
            this.mao = mao;
        }

        public bool EhValida()
        {
            ordernarCrescenteMao();
            for (int i = 1; i < mao.Length; i++)
            {
                if (mao[i - 1] + 1 != mao[i])
                    return false;
            }

            return true;
        }

        private void ordernarCrescenteMao()
        {
            for (int i = 0; i < mao.Length - 1; i++)
            {
                for (int j = i + 1; j < mao.Length; j++)
                {
                    if (mao[i] <= mao[j]) continue;

                    var maiorValor = mao[i];
                    mao[i] = mao[j];
                    mao[j] = maiorValor;
                }
            }
        }
    }
}