using System;

namespace Poker.Jogadas
{
    public class Trica
    {
        private int[] mao;

        public Trica(int[] mao) => this.mao = mao;

        public bool EhValida()
        {
            var valorPrimeiraSequencia = mao[0];
            var valorSegundaSequencia = 0;

            var contadorPrimeiraSequencia = 0;
            var contadorSegundaSequencia = 0;

            for (int i = 0; i < mao.Length; i++)
            {
                var existemMaisDeDuasSeguencias = valorSegundaSequencia != 0 && mao[i] != valorPrimeiraSequencia && mao[i] != valorSegundaSequencia;
                if (existemMaisDeDuasSeguencias)
                    return false;

                if (valorSegundaSequencia == 0 && mao[i] != valorPrimeiraSequencia)
                    valorSegundaSequencia = mao[i];

                if (valorPrimeiraSequencia == mao[i])
                    contadorPrimeiraSequencia++;

                if (valorSegundaSequencia == mao[i])
                    contadorSegundaSequencia++;

                if ((contadorPrimeiraSequencia | contadorSegundaSequencia) > 3)
                    return false;
            }

            return true;
        }
    }
}
