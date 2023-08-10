using System;

public class Program 
{
    public static void Main(string[] args) 
    {
        Console.WriteLine("Bem vindo a sua calculadora Infinita");

        double a;
        string operador;
        double b;
        double resultado = 0;

        bool calculando = true;
        while (calculando) 
        {
            Console.Write("Valor A: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Escolha um operador: \n+\n-\n*\n/\n");
            Console.Write("Escolha: ");
            operador = Console.ReadLine();

            Console.Write("Valor B: ");
            b = Convert.ToDouble(Console.ReadLine());

            if (operador == "+")
            {
                resultado = a + b;
            }
            else if (operador == "-")
            {
                resultado = a - b;
            }
            else if (operador == "*")
            {
                resultado = a * b;
            }
            else if (operador == "/")
            {
                resultado = a / b;
            }
            else
            {
                if ((operador != "+") || (operador != "-") || (operador != "*") || (operador != "/"))
                {
                    Console.WriteLine("Por favor, verifique as informações!");
                    continue;
                }
            }

            Console.WriteLine(resultado);

            break;
        }

        double acumular = 0;

        bool repita = true;
        while (repita) 
        {
            Console.Write("Novo Valor: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escolha um operador: \n+\n-\n*\n/\n");
            Console.Write("Escolha: ");
            operador = Console.ReadLine();

            if (operador == "+")
            {
                acumular += resultado + a;
            }
            else if (operador == "-")
            {
                acumular += resultado - a;
            }
            else if (operador == "*")
            {
                acumular += resultado * a;
            }
            else if (operador == "/") 
            {
                acumular += resultado / a;
            }
            else 
            {
                Console.WriteLine("Digite um valor válido: ");
                continue;
            }

            Console.WriteLine("Novo valor: " + acumular);
        }
    }
}

