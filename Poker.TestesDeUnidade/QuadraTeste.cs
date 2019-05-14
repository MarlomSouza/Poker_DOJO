using Poker.Dominio.Jogadas;
using Xunit;

namespace Poker.TestesDeUnidade
{
    public class QuadraTeste
    {
        [Theory]
        [InlineData(new[] { 1, 1, 1, 1, 2 })]
        [InlineData(new[] { 6, 9, 9, 9, 9 })]
        [InlineData(new[] { 3, 3, 2, 3, 3 })]
        public void Deve_ser_uma_jogada_valida(int[] mao)
        {
            //When
            var jogada = new Quadra(mao);
            //Then
            Assert.True(jogada.EhValida());
        }

        [Theory]
        [InlineData(new[] { 4, 4, 3, 4, 5 })]
        [InlineData(new[] { 1, 2, 3, 4, 5 })]
        public void Nao_deve_ser_uma_jogada_valida(int[] mao)
        {
            //When
            var jogada = new Quadra(mao);
            //Then
            Assert.False(jogada.EhValida());
        }
    }
}