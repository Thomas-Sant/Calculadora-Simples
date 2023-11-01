/*
 * #Desafio 2

 Calculadora Simples: Crie um programa que permita ao usuário realizar operações simples 
de matemática, como adição, subtração, multiplicação e divisão. O programa deve solicitar 
números de entrada e a operação desejada.

 */

using System;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor: ");
            if (!int.TryParse(Console.ReadLine(), out int x))
            {
                Console.WriteLine("Valor inválido para o primeiro número.");
                Console.ReadLine(); // Aguarda a entrada do usuário antes de encerrar
                return;
            }

            Console.WriteLine("Informe o símbolo da operação (+, -, *, /): ");
            string operation = Console.ReadLine();
            bool isOperationValid = operation == "+" || operation == "-" || operation == "*" || operation == "/";
            if (isOperationValid)
            {
                Console.WriteLine("Informe o segundo valor: ");
                if (!int.TryParse(Console.ReadLine(), out int y))
                {
                    Console.WriteLine("Valor inválido para o segundo número.");
                    Console.ReadLine(); // Aguarda a entrada do usuário antes de encerrar
                    return;
                }

                double result = 0;
                try
                {
                    switch (operation)
                    {
                        case "+":
                            result = x + y;
                            break;
                        case "-":
                            result = x - y;
                            break;
                        case "*":
                            result = x * y;
                            break;
                        case "/":
                            if (y == 0)
                            {
                                Console.WriteLine("Não é possível dividir por zero.");
                                Console.ReadLine(); // Aguarda a entrada do usuário antes de encerrar
                                return;
                            }
                            result = (double)x / y;
                            break;
                        default:
                            Console.WriteLine("Operação inválida.");
                            Console.ReadLine(); // Aguarda a entrada do usuário antes de encerrar
                            return;
                    }

                    Console.WriteLine($"O resultado desta operação é: {result}");
                    Console.ReadLine(); // Aguarda a entrada do usuário antes de encerrar
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ocorreu uma exceção: {ex.Message}");
                    Console.ReadLine(); // Aguarda a entrada do usuário antes de encerrar
                }
            }
            else
            {
                Console.WriteLine("O operador não é valido");
                Console.ReadLine();
            }
        }
    }
}