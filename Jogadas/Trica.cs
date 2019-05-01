using System;
using System.Collections.Generic;
using System.Linq;
using Poker.Jogadas.Helpers;

namespace Poker.Jogadas
{
    public class Trica
    {
        private int[] mao;

        public Trica(int[] mao) => this.mao = mao;

        public bool EhValida()
        {
            var repeticao = new Dictionary<int, int>();

            for (int i = 0; i < mao.Length; i++)
            {
                int quantidadeRepeticao = quantidadeRepeticao = repeticao.GetValueOrDefault(mao[i], 1);
                if (quantidadeRepeticao > 3)
                    return false;

                if (repeticao.ContainsKey(mao[i]))
                    repeticao[mao[i]] = ++quantidadeRepeticao;
                else
                    repeticao.Add(mao[i], quantidadeRepeticao);
            }

            return repeticao.Count == 3 && repeticao.Values.Any(v => v == 3);
        }
    }
}