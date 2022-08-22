namespace ConsoleCalc.Tests.L0
{
    public class CalcolatriceTests
    {
        [Theory()]
        [InlineData(-1, 3)]
        [InlineData(3, -1)]
        [InlineData(-1, -1)]
        public void SommaInteri_SeAddendoNegativo_LanciaErrore(int a, int b)
        {
            //Assemble.
            //Act.
            var calc = new Calcolatrice();
            //Assert.
            Assert.Throws<ArgumentOutOfRangeException>(() => calc.SommaInteri(a, b));
        }

        [Theory()]
        [InlineData(1, 1, 2)]
        [InlineData(0, 1, 1)]
        [InlineData(1, 0, 1)]
        public void SommaInteri_SeAddendiPositivo_RestituisceSomma(int a, int b, int somma)
        {
            //Assemble.
            //Act.
            var calc = new Calcolatrice();
            //Assert.
            Assert.Equal(somma, calc.SommaInteri(a, b));
        }
    }
}