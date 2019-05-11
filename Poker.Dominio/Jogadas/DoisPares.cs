using System;

namespace Poker.Dominio.Jogadas
{
    public class DoisPares : Jogada
    {
        public DoisPares(int[] mao) : base(mao) { }

        public override bool EhValida()
        {
            int quantidadePares = 0;

            for (int i = 0; i < Mao.Length - 1; i++)
            {
                for (int j = i + 1; j < Mao.Length; j++)
                {
                    if (Mao[i] == Mao[j])
                        quantidadePares++;

                    if (quantidadePares >= 2) return true;
                }
            }
            return false;
        }
    }
}