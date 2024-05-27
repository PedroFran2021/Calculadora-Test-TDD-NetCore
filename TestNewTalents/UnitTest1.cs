using System;
using System.Linq;
using Xunit;
using NewTalents;

using Class1V1 = GridV1::Namespace.Class1;

using Class1V2 = GridV2::Namespace.Class1;


namespace TestNewTestes
{
    public class UnitTest
    {
        [theory]
        [inlinedata(1, 2, 3)]
        [inlinedata (4, 5, 9)]

        public void TestSomar(int val1, int val2, int resultado)
        {
            calculadora calc = new calculadora();

            int resultadoCalculadora = calc.somar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [theory]
        [inlinedata(1, 2, 2)]
        [inlinedata(4, 5, 20)]

        public void TestMultiplicar(int val1, int val2, int resultado)
        {
            calculadora calc = new calculadora();

            int resultadoCalculadora = calc.multiplicar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [theory]
        [inlinedata(6, 2, 3)]
        [inlinedata(5, 5, 1)]

        public void TestDividir(int val1, int val2, int resultado)
        {
            calculadora calc = new calculadora();

            int resultadoCalculadora = calc.dividir(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [theory]
        [inlinedata(6, 2, 4)]
        [inlinedata(5, 5, 0)]

        public void TestSubtrair(int val1, int val2, int resultado)
        {
            calculadora calc = new calculadora();

            int resultadoCalculadora = calc.subtrair(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]

        public void TestarDivisaoPorZero() 
        {
            Calculadora calc = new Calculadora();

            Assert.Throws<DidvideByZeroException>(
                () => calc.dividir(3, 0)
                );
        }

        [Fact]

        public void TestarHistorico()
        {
            Calculadora calc = new Calculadora();

            calc.somar(1, 2);
            calc.somar(2, 8);
            calc.somar(3, 7);
            calc.somar(4, 1);

            var lista = calc.historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Cout);
                
        }
    }
}
