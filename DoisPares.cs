using System;

namespace Poker
{
    public class DoisPares
    {
        private int[] mao;

        public DoisPares(int[] mao) => this.mao = mao;

        public bool EhValida()
        {
            int quantidadePares = 0;

            for (int i = 0; i < mao.Length - 1; i++)
            {
                for (int j = i + 1; j < mao.Length; j++)
                {
                    if (mao[i] == mao[j])
                        quantidadePares++;

                    if (quantidadePares >= 2) return true;
                }
            }
            return false;
        }
    }
}