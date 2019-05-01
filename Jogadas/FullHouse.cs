namespace Poker.Jogadas
{
    public class FullHouse : Jogada
    {
        public FullHouse(int[] mao) : base(mao) { }

        public override bool EhValida()
        {
            var valorPrimeiraSequencia = Mao[0];
            var valorSegundaSequencia = 0;

            var contadorPrimeiraSequencia = 0;
            var contadorSegundaSequencia = 0;

            for (int i = 0; i < Mao.Length; i++)
            {
                var existemMaisDeDuasSeguencias = valorSegundaSequencia != 0 && Mao[i] != valorPrimeiraSequencia && Mao[i] != valorSegundaSequencia;
                if (existemMaisDeDuasSeguencias)
                    return false;

                if (valorSegundaSequencia == 0 && Mao[i] != valorPrimeiraSequencia)
                    valorSegundaSequencia = Mao[i];

                if (valorPrimeiraSequencia == Mao[i])
                    contadorPrimeiraSequencia++;

                if (valorSegundaSequencia == Mao[i])
                    contadorSegundaSequencia++;

                if ((contadorPrimeiraSequencia | contadorSegundaSequencia) > 3)
                    return false;
            }

            return true;
        }

    }
}