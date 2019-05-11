namespace Poker.Dominio.Helpers
{
    public static class Ordenar
    {
        public static int[] Crescente(this int[] mao)
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
            return mao;
        }
    }
}