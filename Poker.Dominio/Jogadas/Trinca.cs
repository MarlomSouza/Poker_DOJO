
using System.Collections.Generic;
using System.Linq;

namespace Poker.Dominio.Jogadas
{
    public class Trinca : Jogada
    {
        public Trinca(int[] mao) : base(mao) { }

        public override bool EhValida()
        {
            var repeticao = new Dictionary<int, int>();

            for (int i = 0; i < Mao.Length; i++)
            {
                if (repeticao.Values.Any(carta => carta > 3))
                    return false;

                if (repeticao.ContainsKey(Mao[i]))
                {
                    var quantidadeRepeticaoCarta = repeticao[Mao[i]];
                    repeticao[Mao[i]] = ++quantidadeRepeticaoCarta;
                }
                else
                    repeticao.Add(Mao[i], 1);
            }

            return repeticao.Count == 3 && repeticao.Values.Any(v => v == 3);
        }
    }
}