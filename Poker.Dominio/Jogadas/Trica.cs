using System;
using System.Collections.Generic;
using System.Linq;
using Poker.Jogadas.Helpers;

namespace Poker.Dominio.Jogadas
{
    public class Trica : Jogada
    {
        public Trica(int[] mao) : base(mao) { }

        public override bool EhValida()
        {
            var repeticao = new Dictionary<int, int>();

            for (int i = 0; i < Mao.Length; i++)
            {
                int quantidadeRepeticao = quantidadeRepeticao = repeticao.GetValueOrDefault(Mao[i], 1);
                if (quantidadeRepeticao > 3)
                    return false;

                if (repeticao.ContainsKey(Mao[i]))
                    repeticao[Mao[i]] = ++quantidadeRepeticao;
                else
                    repeticao.Add(Mao[i], quantidadeRepeticao);
            }

            return repeticao.Count == 3 && repeticao.Values.Any(v => v == 3);
        }
    }
}