using Poker.Dominio.Jogadas;
using Xunit;

namespace Poker.TestesDeUnidade
{
    public class StraightTeste
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5 })]
        [InlineData(new[] { 5, 2, 3, 1, 4 })]
        [InlineData(new[] { 5, 2, 3, 6, 4 })]
        public void Deve_ser_uma_jogada_valida(int[] mao)
        {
            //When
            var jogada = new Straight(mao);
            //Then
            Assert.True(jogada.EhValida());
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 6 })]
        [InlineData(new[] { 5, 2, 3, 1, 5 })]
        public void Nao_deve_ser_uma_jogada_valida(int[] mao)
        {
            //When
            var jogada = new Straight(mao);
            //Then
            Assert.False(jogada.EhValida());
        }
    }
}