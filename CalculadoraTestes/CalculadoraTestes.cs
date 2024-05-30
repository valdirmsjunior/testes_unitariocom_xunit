using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Calculadora.Services;

namespace CalculadoraTestes
{
    public class CalculadoraTestes
    {
        private CalculadoraImp _calc;

        public CalculadoraTestes()
        {
            _calc = new CalculadoraImp();
        }

        [Fact(DisplayName = "Teste Numero 1 Soma")]
        public void DeveSomar2NumerosERetornar15()
        {
            //Arrange
            double num1 = 5;
            double num2 = 10;
            char operacao = '+';
            
            //Act
            double resultado = _calc.Calcular(num1, num2, operacao);

            //Assert
            Assert.Equal(15, resultado);
        }

        [Fact(DisplayName = "Teste Numero 2 Subtrair")]
        public void DeveSubtrair2NumerosERetornar5()
        {
            //Arrange
            double num1 = 15;
            double num2 = 10;
            char operacao = '-';
            double res = num1 - num2;
            
            //Act
            double resultado = _calc.Calcular(num1, num2, operacao);

            //Assert
            Assert.Equal(res, resultado);
        }

        [Fact(DisplayName = "Teste Numero 3 Multiplicar")]
        public void DeveMultiplicar2NumerosERetornar15()
        {
            //Arrange
            double num1 = 3;
            double num2 = 5;
            char operacao = '*';
            double res = num1 * num2;
            
            //Act
            double resultado = _calc.Calcular(num1, num2, operacao);

            //Assert
            Assert.Equal(res, resultado);
        }

        [Fact(DisplayName = "Teste Numero 4 Dividir")]
        public void DeveDividir2NumerosERetornar5()
        {
            //Arrange
            double num1 = 10;
            double num2 = 2;
            char operacao = '/';
            double res = num1 / num2;
            
            //Act
            double resultado = _calc.Calcular(num1, num2, operacao);

            //Assert
            Assert.Equal(res, resultado);
        }

        [Fact(DisplayName = "Teste Numero 5 Divisao por Zero")]
        public void DivisaoPor0DeveLancarException()
        {
            //Arrange
            double num1 = 6;
            double num2 = 0;
            char operacao = '/';

            //Assert
            Assert.Throws<DivideByZeroException>(() => _calc.Calcular(num1, num2, operacao));
        }

        [Fact (DisplayName = "Teste Numero 6 Potencia")]
        public void PotenciaDe2NumerosDeveRetornar8()
        {
            //Arrange
            double num1 = 2;
            double num2 = 3;
            char operacao = '^';
            double res = Math.Pow(num1, num2);
            
            //Act
            double resultado = _calc.Calcular(num1, num2, operacao);

            //Assert
            Assert.Equal(res, resultado);
        }

        [Fact (DisplayName = "Teste Numero 6 Raiz Quadrada")]
        public void RaizQuadradaDe2NumerosDeveRetornar3()
        {
            //Arrange
            double num1 = 6;
            double num2 = 0;
            char operacao = '√';
            double res = Math.Sqrt(num1);
            
            //Act
            double resultado = _calc.Calcular(num1, num2, operacao);

            //Assert
            Assert.Equal(res, resultado);
        }

        [Fact (DisplayName = "Teste Numero 7 Raiz Quadrada")]
        public void DeveLancarInvalidOperationException()
        {
            //Arrange
            double num1 = 6;
            double num2 = 2;
            char operacao = '?';
            
            //Assert
            Assert.Throws<InvalidOperationException>(() => _calc.Calcular(num1, num2, operacao));
        }

        //[Fact(Skip = "Teste ainda não disponível")]
        [Fact]
        public void DeveVerificarSe4EhParERetornarTrue()
        {
            //Arrange
            int num = 4;

            //Act
            bool resultado = _calc.EhPar(num);

            //Assert
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(new int[] { 2, 4 })]
        [InlineData(new int[] { 6, 8, 10 })]
        public void DeveVerificarSeOsNumerosSaoParesERetornarTrue(int[] numeros)
        {
            //Act / Assert
            Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
        }
    }
}