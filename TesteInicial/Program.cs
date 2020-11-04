using System;
using System.Reflection.Metadata.Ecma335;

namespace MyCalculator
{
    class Program
    {
        static int LeituraInt()
        {
            string ler = Console.ReadLine();
            int numero = Convert.ToInt32(ler);
            return numero;
        }

        static void Soma()
        {
            int a = LeituraInt();
            int b = LeituraInt();
            Console.WriteLine($"\n{a} + {b} = {a + b}\n");
        }

        static void Multiplicacao()
        {
            int a = LeituraInt();
            int b = LeituraInt();
            Console.WriteLine($"\n{a} * {b} = {a * b}\n");
        }

        static void Subtracao()
        {
            int a = LeituraInt();
            int b = LeituraInt();
            Console.WriteLine($"\n{a} - {b} = {a - b}\n");
        }

        static void Divisao()
        {
            double a = LeituraInt();
            double b = LeituraInt();
            Console.WriteLine($"\n{a} / {b} = {(a / b):N2}\n");
        }

        static void Potenciacao()
        {
            int x = LeituraInt();
            int expoente = LeituraInt();
            Console.WriteLine($"\n{x}^{expoente} = {Math.Pow(x, expoente)}\n");
        }
        
        static void RaizQuadrada()
        {
            double x = LeituraInt();
            Console.WriteLine($"\nRaiz quadrade de {x} = {Math.Sqrt(x):N2}\n");
        }

        static void RaizCubica()
        {
            double x = LeituraInt();
            Console.WriteLine($"\nRaiz cubicade de {x} = {Math.Cbrt(x):N2}\n");
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
                Console.WriteLine("7 - Raiz cubica");
                Console.WriteLine("0 - Sair");

                menu = LeituraInt();
                if (menu == 0) break;

                switch (menu)
                {
                    case 1:
                        Soma();
                        break;
                    case 2:
                        Multiplicacao();
                        break;
                    case 3:
                        Subtracao();
                            break;
                    case 4:
                        Divisao();
                            break;
                    case 5:
                        Potenciacao();
                        break;
                    case 6:
                        RaizQuadrada();
                        break;
                    case 7:
                        RaizCubica();
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
