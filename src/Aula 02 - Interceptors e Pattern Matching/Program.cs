using System;

namespace InterceptorsAndPatternMatching
{
    public interface ICalculator
    {
        int Calculate(int a, int b, string operation);
    }

    // Exemplo simplificado de interceptor (conceito ilustrativo, prévia do C# 14)
    public class LoggingInterceptor : ICalculator
    {
        private readonly ICalculator _inner;

        public LoggingInterceptor(ICalculator inner) => _inner = inner;

        public int Calculate(int a, int b, string operation)
        {
            Console.WriteLine($"Interceptando chamada: {operation}({a}, {b})");
            var result = _inner.Calculate(a, b, operation);
            Console.WriteLine($"Resultado: {result}\n");
            return result;
        }
    }

    public class Calculator : ICalculator
    {
        public int Calculate(int a, int b, string operation) =>
            operation switch
            {
                "+" => a + b,
                "-" => a - b,
                "*" => a * b,
                "/" when b != 0 => a / b,
                "/" when b == 0 => throw new DivideByZeroException(),
                _ => throw new InvalidOperationException("Operação inválida.")
            };
    }

    public class Program
    {
        public static void Main()
        {
            ICalculator calc = new LoggingInterceptor(new Calculator());
            calc.Calculate(10, 5, "+");
            calc.Calculate(20, 4, "*");
        }
    }
}
