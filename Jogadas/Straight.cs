using System;
using Poker.Jogadas.Helpers;

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
            mao.Crescente();
            for (int i = 1; i < mao.Length; i++)
            {
                if (mao[i - 1] + 1 != mao[i])
                    return false;
            }

            return true;
        }

        private void ordernarMao()
        {
            
        }
    }
}