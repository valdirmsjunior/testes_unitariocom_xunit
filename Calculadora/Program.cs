using Calculadora.Services;

CalculadoraImp calc = new CalculadoraImp();

Console.WriteLine("Digite o primeiro número: ");
double num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a operação (+, -, *, /, ^, √):");
char operacao = Console.ReadLine()[0];

double num2 = 0;
if (operacao != '√')
{
    Console.WriteLine("Digite o segundo número: ");
    num2 = double.Parse(Console.ReadLine());
}

try
{
    double resultado = calc.Calcular(num1, num2, operacao);
    Console.WriteLine($"Resultado: {resultado}");
}
catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}