using Xunit;

namespace Poker.Jogadas
{
    public class DoisParesTeste
    {
        [Theory]
        [InlineData(new[] { 1, 1, 3, 4, 4 })]
        [InlineData(new[] { 1, 2, 1, 4, 2 })]
        [InlineData(new[] { 5, 4, 2, 4, 5 })]
        public void Deve_ser_uma_jogada_valida(int[] mao)
        {
            //When
            var jogada = new DoisPares(mao);
            //Then
            Assert.True(jogada.EhValida());
        }

        [Fact]
        public void Nao_deve_ser_uma_jogada_valida()
        {
            //Given
            int[] mao = new[] { 1, 2, 3, 4, 5 };
            //When
            var jogada = new DoisPares(mao);
            //Then
            Assert.False(jogada.EhValida());
        }
    }
}