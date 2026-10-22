using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Calculadora ===");

            Console.Write("Digite o primeiro número: ");
            if (!double.TryParse(Console.ReadLine(), out double primeiroNumero))
            {
                Console.WriteLine("Número inválido.");
                return;
            }

            Console.Write("Digite a operação (+, -, *, /, P, R): ");
            string operacao = Console.ReadLine();

            Console.Write("Digite o segundo número: ");
            if (!double.TryParse(Console.ReadLine(), out double segundoNumero))
            {
                Console.WriteLine("Número inválido.");
                return;
            }

            double resultado;

            switch (operacao)
            {
                case "+":
                    resultado = primeiroNumero + segundoNumero;
                    break;

                case "-":
                    resultado = primeiroNumero - segundoNumero;
                    break;

                case "*":
                    resultado = primeiroNumero * segundoNumero;
                    break;

                case "/":
                    if (segundoNumero == 0)
                    {
                        Console.WriteLine("Não é possível dividir por zero.");
                        return;
                    }

                    resultado = primeiroNumero / segundoNumero;
                    break;

                case "P":
                    resultado = Math.Pow(primeiroNumero, segundoNumero);
                    break;

                case "R":
                    resultado = Math.Sqrt(primeiroNumero);
                    break;

                default:
                    Console.WriteLine("Operação inválida.");
                    return;
            }

            Console.WriteLine($"Resultado: {resultado}");
            Console.ReadLine();
        }
    }
}
