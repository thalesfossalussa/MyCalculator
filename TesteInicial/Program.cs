using System;
using System.Reflection.Metadata.Ecma335;

namespace TesteInicial
{
    class Program
    {
        static int leituraInt()
        {
            string ler = Console.ReadLine();
            int numero = Convert.ToInt32(ler);
            return numero;
        }

        static void soma()
        {
            int a = leituraInt();
            int b = leituraInt();
            Console.WriteLine($"\n{a} + {b} = {a + b}\n");
        }

        static void multiplicacao()
        {
            int a = leituraInt();
            int b = leituraInt();
            Console.WriteLine($"\n{a} * {b} = {a * b}\n");
        }

        static void subtracao()
        {
            int a = leituraInt();
            int b = leituraInt();
            Console.WriteLine($"\n{a} - {b} = {a - b}\n");
        }

        static void divisao()
        {
            double a = leituraInt();
            double b = leituraInt();
            Console.WriteLine($"\n{a} / {b} = {(a / b):N2}\n");
        }

        static void potenciacao()
        {
            int x = leituraInt();
            int expoente = leituraInt();
            Console.WriteLine($"\n{x}^{expoente} = {Math.Pow(x, expoente)}\n");
        }
        
        static void raizQuadrada()
        {
            double x = leituraInt();
            Console.WriteLine($"\nRaiz quadrade de {x} = {Math.Sqrt(x):N2}\n");
        }

        static void Main(string[] args)
        {
            int menu;
            string nome;
            Console.Write("Olá! Qual o seu nome? ");

            nome = Console.ReadLine();

            Console.WriteLine("\n" + nome + " Started MyCalculator! have fun!!!\n");

            while(true)
            {
                Console.WriteLine("Menu de operações:");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Multiplicação");
                Console.WriteLine("3 - Subtração");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Potenciação");
                Console.WriteLine("6 - Raiz quadrada");
                Console.WriteLine("0 - Sair");

                menu = leituraInt();
                if (menu == 0) break;

                switch (menu)
                {
                    case 1:
                        soma();
                        break;
                    case 2:
                        multiplicacao();
                        break;
                    case 3:
                        subtracao();
                            break;
                    case 4:
                        divisao();
                            break;
                    case 5:
                        potenciacao();
                        break;
                    case 6:
                        raizQuadrada();
                        break;
                    default:
                        Console.WriteLine("\nValor inválido, por favor tente novamente!\n");
                        break;
                }
            }
            Console.WriteLine("Fim de execução!");
        }
    }
}
