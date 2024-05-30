using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        public double Calcular(double num1, double num2, char operacao)
        {
            switch (operacao)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    return num2 != 0 ? num1 / num2 : throw new DivideByZeroException();
                case '^':
                    return Math.Pow(num1, num2);
                case '√':
                    return Math.Sqrt(num1);
                default:
                    throw new InvalidOperationException("Operação inválida");
            }
        }

        public bool EhPar(int num)
        {
            return num % 2 == 0;
        }
    }
}