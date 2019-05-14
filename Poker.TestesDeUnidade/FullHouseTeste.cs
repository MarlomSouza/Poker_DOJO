using Poker.Dominio.Jogadas;
using Xunit;

namespace Poker.TestesDeUnidade
{
    public class FullHouseTeste
    {
        [Theory]
        [InlineData(new[] { 1, 1, 1, 5, 5 })]
        [InlineData(new[] { 7, 2, 7, 2, 7 })]
        [InlineData(new[] { 3, 3, 4, 4, 4 })]
        public void Deve_ser_uma_jogada_valida(int[] mao)
        {
            //When
            var jogada = new FullHouse(mao);
            //Then
            Assert.True(jogada.EhValida());
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3, 5, 6 })]
        [InlineData(new[] { 1, 1, 1, 5, 6 })]
        [InlineData(new[] { 2, 2, 2, 2, 7 })]
        [InlineData(new[] { 5, 5, 3, 4, 4 })]
        public void Nao_deve_ser_uma_jogada_valida(int[] mao)
        {
            //When
            var jogada = new FullHouse(mao);
            //Then
            Assert.False(jogada.EhValida());
        }
    }
}