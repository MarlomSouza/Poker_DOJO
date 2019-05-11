using System;

namespace Poker.Dominio.Jogadas
{
    public class Straight : Jogada
    {
        public Straight(int[] mao) : base(mao) { }
        public override bool EhValida()
        {
            ordernarCrescenteMao();
            for (int i = 1; i < Mao.Length; i++)
            {
                if (Mao[i - 1] + 1 != Mao[i])
                    return false;
            }
            return true;
        }

        private void ordernarCrescenteMao()
        {
            for (int i = 0; i < Mao.Length - 1; i++)
            {
                for (int j = i + 1; j < Mao.Length; j++)
                {
                    if (Mao[i] <= Mao[j]) continue;

                    var maiorValor = Mao[i];
                    Mao[i] = Mao[j];
                    Mao[j] = maiorValor;
                }
            }
        }
    }
}