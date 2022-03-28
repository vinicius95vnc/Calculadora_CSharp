using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("---------------------------");
            Console.WriteLine("O que deseja calcular?");
            Console.WriteLine("1 - Soma +");
            Console.WriteLine("2 - Subtração -");
            Console.WriteLine("3 - Multiplicação *");
            Console.WriteLine("4 - Divisão /");
            Console.WriteLine("5 - Porcentagem %");

            Console.WriteLine("---------------------------");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Selecione uma opção: ");

            short res = short.Parse (Console.ReadLine());

            switch(res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: Porcentagem(); break;
                case 0: Console.WriteLine("Obrigado por usar a Calculadora! Até mais!"); System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;
            Console.WriteLine("O Resultado da soma é: " + resultado);
            Console.ReadKey();
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu de opções...");
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;
            Console.WriteLine("O Resultado da Subtração é: " + resultado);
            Console.ReadKey();
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu de opções...");
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;
            Console.WriteLine("O Resultado da Multiplicação é: " + resultado);
            Console.ReadKey();
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu de opções...");
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 / v2;
            Console.WriteLine("O Resultado da Divisão é: " + resultado);
            Console.ReadKey();
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu de opções...");
            Menu();
        }

        static void Porcentagem()
        {
            Console.Clear();

            Console.WriteLine("Porcentagem: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 / 100 * v2;
            Console.WriteLine("O Resultado da porcentagem é: " + resultado);
            Console.ReadKey();
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu de opções...");
            Menu();
        }
    }
}