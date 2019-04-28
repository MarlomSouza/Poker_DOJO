using System;
using Xunit;

namespace Poker
{
    public class UmParTeste
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 4 })]
        [InlineData(new[] { 1, 2, 1, 4, 5 })]
        [InlineData(new[] { 1, 2, 2, 4, 5 })]
        public void Deve_ser_uma_jogada_valida(int[] mao)
        {
            //When
            var jogada = new Par(mao);
            //Then
            Assert.True(jogada.EhValida());
        }

        [Fact]
        public void Nao_deve_ser_uma_jogada_valida()
        {
            //Given
            int[] mao = new[] { 1, 2, 3, 4, 5 };
            //When
            var jogada = new Par(mao);
            //Then
            Assert.False(jogada.EhValida());
        }


        private class Par
        {
            private int[] mao;

            public Par(int[] mao)
            {
                this.mao = mao;
            }

            public bool EhValida()
            {
                for (int i = 0; i < mao.Length - 1; i++)
                {
                    for (int j = i + 1; j < mao.Length; j++)
                    {
                        if (mao[i] == mao[j]) return true;
                    }
                }
                return false;
            }
        }
    }
}