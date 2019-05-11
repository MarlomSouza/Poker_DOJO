using System;
using Poker.Dominio.Jogadas;
using Xunit;

namespace Poker.TestesDeUnidade
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
            var jogada = new UmPar(mao);
            //Then
            Assert.True(jogada.EhValida());
        }

        [Fact]
        public void Nao_deve_ser_uma_jogada_valida()
        {
            //Given
            int[] mao = new[] { 1, 2, 3, 4, 5 };
            //When
            var jogada = new UmPar(mao);
            //Then
            Assert.False(jogada.EhValida());
        }
    }
}