using Poker.Dominio.Jogadas;
using Poker.Jogadas;
using Xunit;

namespace Poker.TestesDeUnidade
{
    public class TrincaTeste
    {
        [Theory]
        [InlineData(new[] { 1, 1, 1, 5, 4 })]
        [InlineData(new[] { 2, 1, 2, 3, 2 })]
        [InlineData(new[] { 5, 3, 3, 3, 7 })]
        [InlineData(new[] { 1, 9, 4, 4, 4 })]
        public void Deve_ser_uma_jogada_valida(int[] mao)
        {
            //When
            var jogada = new Trica(mao);
            //Then
            Assert.True(jogada.EhValida());
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5 })]
        [InlineData(new[] { 1, 1, 2, 2, 2 })]
        [InlineData(new[] { 5, 5, 5, 5, 5 })]
        [InlineData(new[] { 2, 2, 1, 1, 3 })]
        public void Nao_deve_ser_uma_jogada_valida(int[] mao)
        {
            //When
            var jogada = new Trica(mao);
            //Then
            Assert.False(jogada.EhValida());
        }
    }
}